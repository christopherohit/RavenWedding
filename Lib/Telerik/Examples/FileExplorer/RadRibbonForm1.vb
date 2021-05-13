Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Layouts
Imports IWshRuntimeLibrary
Imports System.Threading

Namespace FileExplorer
	Partial Public Class RadRibbonForm1
		Inherits Telerik.WinControls.UI.RadRibbonForm
		#Region "Fields"

		Private WshShell As WshShellClass

		Private backCollection As New Stack(Of RadTreeNode)()
		Private forwardCollection As New Stack(Of RadTreeNode)()
		Private navigateOperationInProgress As Boolean = False
		Private searchButton As CustomButton
		Private autoCompleteDataSource As New AutoCompleteStringCollection()
		Private detailsToggleButton As CustomToggleButton
		Private iconsToggleButton As CustomToggleButton
		Private copySource As List(Of ListViewDataItem) = Nothing
		Private Enum IconSize
			Small
			Medium
			Large
			ExtraLarge
		End Enum
'INSTANT VB NOTE: The variable iconSize was renamed since Visual Basic does not handle variables named the same as their type well:
		Private iconSize_Renamed As IconSize = IconSize.Medium

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro"
            radRibbonBar1.StartButtonImage = Telerik.WinControls.ResFinder.MenuIcon

			SetupListView()

			Me.AllowAero = False
			radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			splitPanel1.BorderStyle = BorderStyle.None
			splitPanel2.BorderStyle = BorderStyle.None

            RibbonBar.RibbonBarElement.QuickAccessToolBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			radTreeView1.LazyMode = False
			AddNodes()
			AddHandler radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_SelectedNodeChanged
			AddHandler radTreeView1.NodesNeeded, AddressOf radTreeView1_NodesNeeded
			AddHandler radTreeView1.KeyDown, AddressOf radTreeView1_KeyDown
			AddHandler radTreeView1.NodeFormatting, AddressOf radTreeView1_NodeFormatting
			radTreeView1.SelectedNode = radTreeView1.Nodes("My Computer")

			radBreadCrumb1.DefaultTreeView = radTreeView1

			AddButtonToTextBox()
			AddHandler radTextBox1.TextChanged, AddressOf radTextBox1_TextChanged
			radTextBox1.AutoCompleteCustomSource = autoCompleteDataSource

			AddButtonsToStatusStrip()

			historyButton.ShowArrow = False

			AddHandler pasteAsShortcutMenuItem.Click, AddressOf pasteAsShortcutMenuItem_Click
			AddHandler pasteMenuItem.Click, AddressOf pasteMenuItem_Click

			AddHandler deleteSelectionMenuItem.Click, AddressOf deleteSelectionMenuItem_Click
			AddHandler deleteAllMenuItem.Click, AddressOf deleteAllMenuItem_Click

			AddHandler cutButton.Click, AddressOf copyButton_Click

			AddHandler sortByNameMenuItem.Click, AddressOf sortBy_Click
			AddHandler sortByDateModifiedMenuItem.Click, AddressOf sortBy_Click
			AddHandler sortByTypeMenuItem.Click, AddressOf sortBy_Click
            AddHandler sortBySizeMenuItem.Click, AddressOf sortBy_Click

            AddHandler office2010BlackButton.Click, AddressOf changeTheme_Click
            AddHandler office2010BlueButton.Click, AddressOf changeTheme_Click
            AddHandler office2010SilverButton.Click, AddressOf changeTheme_Click
            AddHandler controlDefaultButton.Click, AddressOf changeTheme_Click
            AddHandler telerikMetroButton.Click, AddressOf changeTheme_Click
		End Sub


		#End Region

		#Region "Methods"

		Private Sub AddNodes()
			Dim favorites As New RadTreeNode()
			favorites.Text = "Favorites"
            favorites.Image = My.Resources.favorites
			radTreeView1.Nodes.Add(favorites)

			Dim desktop As New RadTreeNode()
			desktop.Tag = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			desktop.Text = "Desktop"
			favorites.Nodes.Add(desktop)

			Dim libraries As New RadTreeNode()
			libraries.Text = "Libraries"
            libraries.Image = My.Resources.documents
			radTreeView1.Nodes.Add(libraries)

			Dim documents As New RadTreeNode("Documents")
			documents.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			libraries.Nodes.Add(documents)

			Dim music As New RadTreeNode("Music")
			music.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
			libraries.Nodes.Add(music)

			Dim pictures As New RadTreeNode("Pictures")
			pictures.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
			libraries.Nodes.Add(pictures)

			Dim myComputerNode As New RadTreeNode("My Computer")
            myComputerNode.Image = My.Resources.computer

			Dim drives() As String = Directory.GetLogicalDrives()
			For i As Integer = 0 To drives.Length - 1
				Dim node As New RadTreeNode(drives(i))
				node.Tag = drives(i)
				myComputerNode.Nodes.Add(node)
			Next i
			radTreeView1.Nodes.Add(myComputerNode)
		End Sub

		Private Sub SetupListView()
			AddHandler radListView1.ItemMouseDoubleClick, AddressOf radListView1_ItemMouseDoubleClick
			AddHandler radListView1.KeyDown, AddressOf radListView1_KeyDown
			AddHandler radListView1.ViewTypeChanged, AddressOf radListView1_ViewTypeChanged
			AddHandler radListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
			AddHandler radListView1.CellFormatting, AddressOf radListView1_CellFormatting
			AddHandler radListView1.SelectedItemsChanged, AddressOf radListView1_SelectedItemsChanged
			AddHandler radListView1.ItemValidating, AddressOf radListView1_ItemValidating
			AddHandler radListView1.ItemEdited, AddressOf radListView1_ItemEdited

			radListView1.EnableFiltering = True
			radListView1.EnableSorting = True
			radListView1.MultiSelect = True
			radListView1.FullRowSelect = False
			radListView1.AllowRemove = False

			radListView1.Columns.Add(New ListViewDetailColumn("Name"))
			radListView1.Columns.Add(New ListViewDetailColumn("Date Modified"))
			radListView1.Columns.Add(New ListViewDetailColumn("Type"))
			radListView1.Columns.Add(New ListViewDetailColumn("Size"))
		End Sub

		Private Sub UpdateView(ByVal node As RadTreeNode)
			radListView1.Items.Clear()

			If node.Tag Is Nothing AndAlso (node.Text = "Favorites" OrElse node.Text = "Libraries" OrElse node.Text = "My Computer") Then
				For Each childNode As RadTreeNode In node.Nodes
					Dim item As New ListViewDataItem()
					radListView1.Items.Add(item)
					item.Text = childNode.Text
					item("Name") = childNode.Text
					item.Tag = childNode.Tag

					Dim hImgLarge As IntPtr = SHGetFileInfo(childNode.Tag.ToString(), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
					item.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
				Next childNode
				Return
			End If

			If node.Tag IsNot Nothing Then
				Dim directories() As String = Directory.GetDirectories(node.Tag.ToString())
				Dim files() As String = Directory.GetFiles(node.Tag.ToString())

				For Each directory As String In directories
					Dim item As New ListViewDataItem()
					radListView1.Items.Add(item)
					item.Text = Path.GetFileName(directory)
					item.Tag = directory
                    item("Name") = Path.GetFileName(directory)
                    item("Date Modified") = System.IO.Directory.GetLastWriteTime(directory)

					item("Type") = "File folder"
					item("Size") = ""

					Dim hImgLarge As IntPtr = SHGetFileInfo(directory, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
					item.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
				Next directory

				For Each file As String In files
					Dim item As New ListViewDataItem()
					radListView1.Items.Add(item)
					item.Tag = file
					item.Text = Path.GetFileName(file)
					item("Name") = Path.GetFileName(file)
					item("Date Modified") = System.IO.File.GetLastWriteTime(file)
					item("Type") = "File folder"
					Dim fi As New FileInfo(file)
					item("Size") = GetFileSize(fi.Length)

					Dim hImgLarge As IntPtr = SHGetFileInfo(file, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
					item.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
				Next file
			End If
		End Sub

		Private Sub NavigateBack()
			If backCollection.Count > 0 Then
				If backCollection.Peek() Is radTreeView1.SelectedNode Then
					forwardCollection.Push(backCollection.Pop())
				End If
				navigateOperationInProgress = True
				radTreeView1.SelectedNode = backCollection.Peek()
				forwardCollection.Push(backCollection.Pop())
				navigateOperationInProgress = False
			End If
		End Sub

		Private Sub NavigateForward()
			If forwardCollection.Count > 0 Then
				If forwardCollection.Peek() Is radTreeView1.SelectedNode Then
					backCollection.Push(forwardCollection.Pop())
				End If

				navigateOperationInProgress = True
				radTreeView1.SelectedNode = forwardCollection.Peek()
				backCollection.Push(forwardCollection.Pop())
				navigateOperationInProgress = False
			End If
		End Sub

		Private Sub AddButtonToTextBox()
			searchButton = New CustomButton()
            searchButton.Image = My.Resources.search
			searchButton.ImageAlignment = ContentAlignment.MiddleCenter
			searchButton.ShouldHandleMouseInput = False
			searchButton.MaxSize = New Size(16, 16)
			searchButton.MinSize = New Size(16, 16)
			searchButton.ButtonFillElement.BackColor = Color.Transparent
			searchButton.ButtonFillElement.BackColor2 = Color.Transparent
			searchButton.ButtonFillElement.BackColor3 = Color.Transparent
			searchButton.ButtonFillElement.BackColor4 = Color.Transparent
			searchButton.BorderElement.Visibility = ElementVisibility.Collapsed
			AddHandler searchButton.Click, AddressOf searchButton_Click

			Dim textBoxItem As RadTextBoxItem = Me.radTextBox1.TextBoxElement.TextBoxItem
			textBoxItem.Alignment = ContentAlignment.MiddleLeft

			Me.radTextBox1.TextBoxElement.Children.Remove(textBoxItem)

			DockLayoutPanel.SetDock(textBoxItem, Telerik.WinControls.Layouts.Dock.Left)
			DockLayoutPanel.SetDock(searchButton, Telerik.WinControls.Layouts.Dock.Right)

			Dim dockLayoutPanel_Renamed As New DockLayoutPanel()

			dockLayoutPanel_Renamed.Children.Add(searchButton)
			dockLayoutPanel_Renamed.Children.Add(textBoxItem)

			Me.radTextBox1.TextBoxElement.Children.Add(dockLayoutPanel_Renamed)
		End Sub

		Private Sub AddButtonsToStatusStrip()
			detailsToggleButton = New CustomToggleButton()
			detailsToggleButton.Padding = New Padding(2, 0, 2, 0)
            detailsToggleButton.Image = My.Resources.detailsViewIcon
			detailsToggleButton.BorderElement.Visibility = ElementVisibility.Collapsed
			detailsToggleButton.ButtonFillElement.BackColor = Color.Transparent
			detailsToggleButton.ButtonFillElement.BackColor2 = Color.Transparent
			detailsToggleButton.ButtonFillElement.BackColor3 = Color.Transparent
			detailsToggleButton.ButtonFillElement.BackColor4 = Color.Transparent
			detailsToggleButton.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			detailsToggleButton.ToolTipText = "Details View"
			radStatusStrip1.Items.Add(detailsToggleButton)
			AddHandler detailsToggleButton.ToggleStateChanged, AddressOf detailsToggleButton_ToggleStateChanged


			iconsToggleButton = New CustomToggleButton()
			iconsToggleButton.Padding = New Padding(2, 0, 2, 0)
            iconsToggleButton.Image = My.Resources.iconsViewIcon
			iconsToggleButton.BorderElement.Visibility = ElementVisibility.Collapsed
			iconsToggleButton.ButtonFillElement.BackColor = Color.Transparent
			iconsToggleButton.ButtonFillElement.BackColor2 = Color.Transparent
			iconsToggleButton.ButtonFillElement.BackColor3 = Color.Transparent
			iconsToggleButton.ButtonFillElement.BackColor4 = Color.Transparent
			iconsToggleButton.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			iconsToggleButton.ToolTipText = "Icons View"
			AddHandler iconsToggleButton.ToggleStateChanged, AddressOf iconsToggleButton_ToggleStateChanged
			radStatusStrip1.Items.Add(iconsToggleButton)

		End Sub

		Private Function IsFile(ByVal path As String) As Boolean
			' get the file attributes for file or directory
			Dim attr As FileAttributes = System.IO.File.GetAttributes(path)

			'detect whether its a directory or file
			If (attr And FileAttributes.Directory) = FileAttributes.Directory Then
				Return False
			Else
				Return True
			End If
		End Function

		Public Sub DirectoryCopy(ByVal sourceDir As String, ByVal targetDir As String)
			Dim source As New DirectoryInfo(sourceDir)
			Dim target As New DirectoryInfo(targetDir)
			' Check if the target directory exists, if not, create it.
			If Directory.Exists(target.FullName) = False Then
				Directory.CreateDirectory(target.FullName)
			End If

			' Copy each file into it’s new directory.
			For Each fi As FileInfo In source.GetFiles()
				Console.WriteLine("Copying {0}\{1}", target.FullName, fi.Name)
				fi.CopyTo(Path.Combine(target.ToString(), fi.Name), True)
			Next fi

			' Copy each subdirectory using recursion.
			For Each diSourceSubDir As DirectoryInfo In source.GetDirectories()
				Dim nextTargetSubDir As DirectoryInfo = target.CreateSubdirectory(diSourceSubDir.Name)

				DirectoryCopy(diSourceSubDir.FullName, nextTargetSubDir.FullName)
			Next diSourceSubDir
		End Sub

		Public Function DeleteDirectory(ByVal target_dir As String) As Boolean
			Dim result As Boolean = False

			Dim files() As String = Directory.GetFiles(target_dir)
			Dim dirs() As String = Directory.GetDirectories(target_dir)

			For Each file As String In files
				System.IO.File.SetAttributes(file, FileAttributes.Normal)
				System.IO.File.Delete(file)
			Next file

			For Each dir As String In dirs
				DeleteDirectory(dir)
			Next dir

			Directory.Delete(target_dir, False)

			Return result
		End Function

		#End Region

		#Region "Events"

		Private Sub radListView1_ItemValidating(ByVal sender As Object, ByVal e As ListViewItemValidatingEventArgs)
			If String.IsNullOrEmpty(Convert.ToString(e.NewValue)) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub radListView1_ItemEdited(ByVal sender As Object, ByVal e As ListViewItemEditedEventArgs)
			Dim sourcePath As String = e.VisualItem.Data.Tag.ToString()
			Dim destinationPath As String = Path.GetDirectoryName(sourcePath) + e.VisualItem.Text
			If Not(String.Equals(sourcePath, destinationPath)) Then
				System.IO.File.Move(sourcePath, destinationPath)
			End If
		End Sub

		Private Sub radListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
			e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
			e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText
			e.CellElement.ImageAlignment = ContentAlignment.MiddleLeft
		End Sub

		Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
			If radListView1.ViewType = ListViewType.ListView Then
				e.VisualItem.TextAlignment = ContentAlignment.MiddleLeft
				e.VisualItem.TextImageRelation = TextImageRelation.ImageBeforeText
				If e.VisualItem.Data.Tag IsNot Nothing Then
					Dim hImgLarge As IntPtr = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
					Try
						e.VisualItem.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
					Catch ex As ArgumentException
					End Try
					DestroyIcon(shinfo.hIcon)
				End If
			End If

			If radListView1.ViewType = ListViewType.IconsView Then
				e.VisualItem.TextAlignment = ContentAlignment.MiddleCenter
				e.VisualItem.TextImageRelation = TextImageRelation.ImageAboveText
				e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter
				If e.VisualItem.Data.Tag IsNot Nothing Then
					Select Case iconSize_Renamed
						Case IconSize.Small
							e.VisualItem.TextAlignment = ContentAlignment.MiddleLeft
							e.VisualItem.TextImageRelation = TextImageRelation.ImageBeforeText
							e.VisualItem.ImageAlignment = ContentAlignment.MiddleLeft

                            Dim small As IntPtr = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
                            Try
                                e.VisualItem.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
                            Catch ex As ArgumentException
                            End Try
                        Case IconSize.Medium
                            Dim medium As IntPtr = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON)
                            Try
                                e.VisualItem.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
                            Catch ex As ArgumentException
                            End Try
                    End Select
				End If
			End If
		End Sub

		Private Sub radListView1_SelectedItemsChanged(ByVal sender As Object, ByVal e As EventArgs)
			selectedItemInfoLabel.Text = If(radListView1.SelectedItems.Count = 1, "1 item selected", radListView1.SelectedItems.Count & " items selected")
		End Sub

		Private Sub radListView1_ViewTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case radListView1.ViewType
				Case ListViewType.DetailsView
					radListView1.AllowArbitraryItemWidth = False
					radListView1.AllowArbitraryItemHeight = True
					radListView1.ItemSize = New Size(64, 64)
				Case ListViewType.IconsView
					radListView1.AllowArbitraryItemWidth = True
					radListView1.AllowArbitraryItemHeight = True
					radListView1.ItemSize = New Size(64, 64)
				Case ListViewType.ListView
					radListView1.FullRowSelect = False

				Case Else
			End Select
		End Sub

		Private Sub radListView1_ItemMouseDoubleClick(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
			For Each node As RadTreeNode In radTreeView1.SelectedNode.Nodes
				If e.Item.Text = node.Text Then
					radTreeView1.SelectedNode = node
					Return
				End If
			Next node
			Process.Start(e.Item.Tag.ToString())
		End Sub

		Private Sub radListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyData = Keys.Back Then
				NavigateBack()
			End If
			If e.KeyData = Keys.Delete Then
				deleteSelectionMenuItem_Click(Nothing, Nothing)
			End If
			If e.KeyData = Keys.Enter AndAlso radListView1.SelectedItem IsNot Nothing Then
				For Each node As RadTreeNode In radTreeView1.SelectedNode.Nodes
					If radListView1.SelectedItem.Text = node.Text Then
						radTreeView1.SelectedNode = node
						Return
					End If
				Next node
				Process.Start(radListView1.SelectedItem.Tag.ToString())
			End If
		End Sub

		Private Sub radTreeView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyData = Keys.Back Then
				NavigateBack()
			End If
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			If e.Node Is Nothing Then
				Return
			End If
			Try
				'this checks for access exceptions
				If e.Node.Tag IsNot Nothing Then
					Dim directories() As String = Directory.GetDirectories(e.Node.Tag.ToString())
				End If

				'add the node to history
				If Not(navigateOperationInProgress) Then
					backCollection.Push(e.Node)
				End If

				'update view
				UpdateView(e.Node)

				'updates status strip labels
				If radListView1.Items.Count = 1 Then
					directoryInfoLabel.Text = radListView1.Items.Count & " item"
				Else
					directoryInfoLabel.Text = radListView1.Items.Count & " items"
				End If

				If e.Node.Nodes.Count > 0 AndAlso e.Node.Expanded = False Then
					e.Node.Expanded = True
				End If
			Catch ex As UnauthorizedAccessException
				RadMessageBox.Show(ex.Message.ToString())
			Catch ex2 As IOException
				RadMessageBox.Show(ex2.Message.ToString())
			End Try
		End Sub

		Private Sub radTreeView1_NodesNeeded(ByVal sender As Object, ByVal e As NodesNeededEventArgs)
			If e.Parent.Tag IsNot Nothing Then
				Dim directoryPath As String = e.Parent.Tag.ToString()
				If Directory.Exists(directoryPath) Then
					Try
						Dim directories() As String = Directory.GetDirectories(directoryPath)

						For i As Integer = 0 To directories.Length - 1
							Dim node As New RadTreeNode(Path.GetFileName(directories(i)))
							node.Tag = directories(i)
							e.Nodes.Add(node)
						Next i
					Catch ex As UnauthorizedAccessException
					Catch ex2 As IOException
					End Try
				End If
			End If
		End Sub

		Private Sub radTreeView1_NodeFormatting(ByVal sender As Object, ByVal e As TreeNodeFormattingEventArgs)
			If e.Node.Tag IsNot Nothing Then
				Dim hImgLarge As IntPtr = SHGetFileInfo(e.Node.Tag.ToString(), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
				e.NodeElement.ImageElement.Image = Icon.FromHandle(shinfo.hIcon).ToBitmap()
			End If
		End Sub

		Private Sub forwardButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles forwardButton.Click
			NavigateForward()
		End Sub

		Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backButton.Click
			NavigateBack()
		End Sub

		Private Sub upButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles upButton.Click
			If radTreeView1.SelectedNode IsNot Nothing AndAlso radTreeView1.SelectedNode.Parent IsNot Nothing Then
				radTreeView1.SelectedNode = radTreeView1.SelectedNode.Parent
			End If
		End Sub

		Private Sub refreshButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshButton.Click, refreshButtonInRibbon.Click
			If radTreeView1.SelectedNode IsNot Nothing Then
				Dim savedNode As RadTreeNode = radTreeView1.SelectedNode
				radTreeView1.SelectedNode = New RadTreeNode()
				radTreeView1.SelectedNode = savedNode
			End If
		End Sub

		Private Sub historyButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles historyButton.Click
			historyButton.Items.Clear()
			For Each node As RadTreeNode In backCollection
				If node IsNot radTreeView1.SelectedNode Then
					Dim historyDropDownItem As New RadMenuItem()
					historyDropDownItem.Text = node.Text
					historyDropDownItem.Tag = node
					AddHandler historyDropDownItem.Click, AddressOf historyDropDownItem_Click
					historyButton.Items.Add(historyDropDownItem)
				End If
			Next node
			If historyButton.Items.Count > 0 Then
				historyButton.ShowDropDown()
			End If
		End Sub

		Private Sub historyDropDownItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
			radTreeView1.SelectedNode = TryCast(item.Tag, RadTreeNode)
		End Sub

		Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If String.IsNullOrEmpty(radTextBox1.Text) Then
                searchButton.Image = My.Resources.search
				searchButton.ShouldHandleMouseInput = False
				radListView1.FilterDescriptors.Clear()
			Else
                searchButton.Image = My.Resources.cross
				searchButton.ShouldHandleMouseInput = True

				Dim filter As New FilterDescriptor()
				filter.PropertyName = "Text"
				filter.Operator = FilterOperator.StartsWith
				filter.Value = radTextBox1.Text
				radListView1.FilterDescriptors.Add(filter)

				autoCompleteDataSource.Add(radTextBox1.Text)
			End If
		End Sub

		Private Sub searchButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			radTextBox1.Text = ""
		End Sub

		Private Sub iconsToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				detailsToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
				detailsToggleButton.ToolTipText = "Details View"
				iconsToggleButton.ToolTipText = "List View"
				radListView1.ViewType = ListViewType.IconsView
			Else
				radListView1.ViewType = ListViewType.ListView
				detailsToggleButton.ToolTipText = "Details View"
				iconsToggleButton.ToolTipText = "Icons View"
			End If
		End Sub

		Private Sub detailsToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				iconsToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
				radListView1.ViewType = ListViewType.DetailsView
				detailsToggleButton.ToolTipText = "List View"
				iconsToggleButton.ToolTipText = "Icons View"
			Else
				radListView1.ViewType = ListViewType.ListView
				detailsToggleButton.ToolTipText = "Details View"
				iconsToggleButton.ToolTipText = "Icons View"
			End If
		End Sub

		Private Sub copyAsPathButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyAsPathButton.Click
			If radListView1.SelectedItem.Tag IsNot Nothing Then
				Clipboard.SetText(radListView1.SelectedItem.Tag.ToString())
			End If
		End Sub

		Private Sub newFolderButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newFolderButton.Click
			If radTreeView1.SelectedNode.Tag IsNot Nothing Then
				If Not(Directory.Exists(radTreeView1.SelectedNode.Tag.ToString() & "New Folder")) Then
					Directory.CreateDirectory(radTreeView1.SelectedNode.Tag.ToString() & "New Folder")
					UpdateView(radTreeView1.SelectedNode)
					For Each item As ListViewDataItem In radListView1.Items
						If item.Text = "New Folder" Then
							radListView1.SelectedItem = item
						End If
					Next item
				Else
					Dim i As Integer = 0
					For Each item As ListViewDataItem In radListView1.Items
						If item.Text.Contains("New Folder") Then
							i += 1
						End If
					Next item

					Directory.CreateDirectory(radTreeView1.SelectedNode.Tag.ToString() & "New Folder (" & i & ")")
					UpdateView(radTreeView1.SelectedNode)

					For Each item As ListViewDataItem In radListView1.Items
						If item.Text = "New Folder (" & i & ")" Then
							radListView1.SelectedItem = item
						End If
					Next item
					radListView1.ListViewElement.BeginEdit()
				End If
			End If
		End Sub

		Private Sub deleteSelectionMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If RadMessageBox.Show("Are you sure that you want to delete the selected items?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				For Each item As ListViewDataItem In radListView1.SelectedItems
					If item.Tag IsNot Nothing Then
						If IsFile(item.Tag.ToString()) Then
							System.IO.File.Delete(item.Tag.ToString())
						Else
							DeleteDirectory(item.Tag.ToString())
						End If
					End If
				Next item
				UpdateView(radTreeView1.SelectedNode)
			End If
		End Sub

		Private Sub deleteAllMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If RadMessageBox.Show("Are you sure that you want to delete all files and folders in the directory?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				For Each item As ListViewDataItem In radListView1.Items
					If item.Tag IsNot Nothing Then
						If IsFile(item.Tag.ToString()) Then
							System.IO.File.Delete(item.Tag.ToString())
						Else
							DeleteDirectory(item.Tag.ToString())
						End If
					End If
				Next item
				UpdateView(radTreeView1.SelectedNode)
			End If
		End Sub

		Private Sub pasteMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			WaitingForm.ShowForm(Nothing)

			For Each item As ListViewDataItem In copySource
				If item.Tag IsNot Nothing AndAlso radTreeView1.SelectedNode.Tag IsNot Nothing Then
					If IsFile(item.Tag.ToString()) Then
						System.IO.File.Move(item.Tag.ToString(), radTreeView1.SelectedNode.Tag.ToString() & "\" & Path.GetFileName(item.Tag.ToString()))
					Else
						Directory.Move(item.Tag.ToString(), radTreeView1.SelectedNode.Tag.ToString() & "\" & Path.GetFileName(item.Tag.ToString()))
					End If
				End If
			Next item
			UpdateView(radTreeView1.SelectedNode)
			WaitingForm.CloseForm()

		End Sub

		Private Sub pasteAsShortcutMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each item As ListViewDataItem In copySource
				If radListView1.SelectedItem.Tag IsNot Nothing AndAlso item.Tag IsNot Nothing Then
					' Create a new instance of WshShellClass
					WshShell = New WshShellClass()

					' Create the shortcut
					Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut

					' Choose the path for the shortcut
					MyShortcut = CType(WshShell.CreateShortcut(radTreeView1.SelectedNode.Tag.ToString() & "\" & Path.GetFileName(item.Tag.ToString()) & ".lnk"), IWshRuntimeLibrary.IWshShortcut)

					' Where the shortcut should point to
					MyShortcut.TargetPath = item.Tag.ToString()

					' Create the shortcut at the given path
					MyShortcut.Save()
				End If
			Next item
			UpdateView(radTreeView1.SelectedNode)
		End Sub

		Private Sub copyButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyButton.Click
			copySource = New List(Of ListViewDataItem)()
			For Each item As ListViewDataItem In radListView1.SelectedItems
				If item.Tag IsNot Nothing AndAlso (System.IO.File.Exists(item.Tag.ToString()) OrElse Directory.Exists(item.Tag.ToString())) Then
					copySource.Add(item)
				End If
			Next item
		End Sub

		Private Sub copyToFolderButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToFolderButton.Click
			If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
				WaitingForm.ShowForm(Nothing)
				Thread.Sleep(1000)
				For Each item As ListViewDataItem In radListView1.SelectedItems
					If item.Tag IsNot Nothing Then
						If IsFile(item.Tag.ToString()) Then
							If System.IO.File.Exists(folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString())) Then
								If RadMessageBox.Show("The file with the same name already exists in the specified location. Do you want to override it?", "File exists", MessageBoxButtons.YesNo) = DialogResult.Yes Then
									System.IO.File.Copy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString()), True)
								End If
							Else
								System.IO.File.Copy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString()))
							End If
						Else
							If Directory.Exists(folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString())) Then
								If RadMessageBox.Show("Directory with the same name already exists in the specified location. Do you want to override it?", "File exists", MessageBoxButtons.YesNo) = DialogResult.Yes Then
									DirectoryCopy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString()))
								End If
							Else
								DirectoryCopy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath & "\" & Path.GetFileName(item.Tag.ToString()))
							End If
						End If
					End If
				Next item
			End If
			WaitingForm.CloseForm()
		End Sub

		Private Sub renameButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles renameButton.Click
			radListView1.ListViewElement.BeginEdit()
			If IsFile(radListView1.SelectedItem.Tag.ToString()) Then
				System.IO.File.Move(radListView1.SelectedItem.Tag.ToString(), radTreeView1.SelectedNode.Tag.ToString() & radListView1.SelectedItem.Text)
			Else
				Directory.Move(radListView1.SelectedItem.Tag.ToString(), radListView1.SelectedItem.Text)
			End If
		End Sub

		Private Sub detailsGaleryItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles detailsGaleryItem.Click
			radListView1.ViewType = ListViewType.DetailsView
		End Sub

		Private Sub smallIconsGaleryItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles smallIconsGaleryItem.Click
			radListView1.ViewType = ListViewType.IconsView
			radListView1.AllowArbitraryItemWidth = True
			radListView1.AllowArbitraryItemHeight = True
			iconSize_Renamed = IconSize.Small
            radListView1.ListViewElement.SynchronizeVisualItems()
			radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal
		End Sub

		Private Sub mediumIconsGaleryItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mediumIconsGaleryItem.Click
			radListView1.ViewType = ListViewType.IconsView
			radListView1.AllowArbitraryItemWidth = True
			radListView1.AllowArbitraryItemHeight = True
			iconSize_Renamed = IconSize.Medium
            radListView1.ListViewElement.SynchronizeVisualItems()
			radListView1.ListViewElement.ViewElement.Orientation = Orientation.Vertical
		End Sub

		Private Sub listGaleryItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles listGaleryItem.Click
			radListView1.ViewType = ListViewType.ListView
		End Sub

		Private Sub sortBy_Click(ByVal sender As Object, ByVal e As EventArgs)

			Dim clickedItem As RadMenuItem = TryCast(sender, RadMenuItem)
			If radListView1.SortDescriptors.Count > 0 AndAlso radListView1.SortDescriptors(0).PropertyName = clickedItem.Text Then
				clickedItem.IsChecked = False
				radListView1.SortDescriptors.Clear()
			Else
				radListView1.SortDescriptors.Clear()
				Dim descriptor As New SortDescriptor(clickedItem.Text, ListSortDirection.Ascending)
				radListView1.SortDescriptors.Add(descriptor)

				For Each item As RadMenuItem In sortByButton.Items
					item.IsChecked = False
				Next item
				clickedItem.IsChecked = True
			End If
		End Sub

		#End Region

		#Region "Helpers"

		#Region "GetAssociatedFileIcon"

		<DllImport("user32.dll")>
		Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
		End Function

		'how to the the image
		'IntPtr hImgSmall = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
		'IntPtr hImgLarge = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);

		Private shinfo As New SHFILEINFO()

		' Constants that we need in the function call
		Private Const SHGFI_ICON As Integer = &H100
		Private Const SHGFI_SMALLICON As Integer = &H1
		Private Const SHGFI_LARGEICON As Integer = &H0

		' This structure will contain information about the file
		Public Structure SHFILEINFO
			' Handle to the icon representing the file
			Public hIcon As IntPtr
			' Index of the icon within the image list
			Public iIcon As Integer
			' Various attributes of the file
			Public dwAttributes As UInteger
			' Path to the file
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
			Public szDisplayName As String
			' File type
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 80)>
			Public szTypeName As String
		End Structure

		' The signature of SHGetFileInfo (located in Shell32.dll)
		<DllImport("Shell32.dll")>
		Public Shared Function SHGetFileInfo(ByVal pszPath As String, ByVal dwFileAttributes As UInteger, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, ByVal uFlags As UInteger) As IntPtr
		End Function
		#End Region

		Private Function GetFileSize(ByVal byteCount As Double) As String
			Dim size As String = "0 Bytes"
			If byteCount >= 1073741824.0 Then
				size = String.Format("{0:##.##}", byteCount / 1073741824.0) & " GB"
			ElseIf byteCount >= 1048576.0 Then
				size = String.Format("{0:##.##}", byteCount / 1048576.0) & " MB"
			ElseIf byteCount >= 1024.0 Then
				size = String.Format("{0:##.##}", byteCount / 1024.0) & " KB"
			ElseIf byteCount > 0 AndAlso byteCount < 1024.0 Then
				size = byteCount.ToString() & " Bytes"
			End If

			Return size
		End Function

		Private Function ImageResize(ByVal img As Image, ByVal size_Renamed As Size) As Image
			'get the height and width of the image
			Dim originalW As Integer = img.Width
			Dim originalH As Integer = img.Height

			'get the new size based on the percentage change
			Dim resizedW As Integer = size_Renamed.Width
			Dim resizedH As Integer = size_Renamed.Height

			'create a new Bitmap the size of the new image
			Dim bmp As New Bitmap(resizedW, resizedH)
			'create a new graphic from the Bitmap
			Dim graphic As Graphics = Graphics.FromImage(CType(bmp, Image))
			graphic.InterpolationMode = InterpolationMode.HighQualityBicubic
			'draw the newly resized image
			graphic.DrawImage(img, 0, 0, resizedW, resizedH)
			'dispose and free up the resources
			graphic.Dispose()
			'return the image
			Return CType(bmp, Image)
		End Function


		#End Region

        Private Sub changeTheme_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim element = TryCast(sender, RadGalleryItem)
            If element IsNot Nothing Then
                ThemeResolutionService.ApplicationThemeName = element.Text
                radRibbonBar1.StartButtonImage = Telerik.WinControls.ResFinder.MenuIcon
            End If
        End Sub

	End Class
End Namespace
