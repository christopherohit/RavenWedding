Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Customize.NodeFormatting
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private boldFont As Font
		Private bottomRightBitmap As Bitmap = Resources.TV_email

		Public Sub New()
			InitializeComponent()

			AddHandler radTreeView1.TreeViewElement.NodeFormatting, AddressOf TreeViewElement_NodeFormatting
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxFormatting.ToggleStateChanged, AddressOf radCheckBoxFormatting_ToggleStateChanged
		End Sub

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Mail"
			End Get
		End Property

		Private Sub LoadData()
			Dim table As New DataTable()

			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("ParentID", GetType(Integer))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Title", GetType(String))
			table.Columns.Add("Icon", GetType(Image))
			table.Columns.Add("IsNew", GetType(Boolean))
			table.Columns.Add("NewItemCount", GetType(Integer))
			table.Columns.Add("IsImportant", GetType(Boolean))
			table.Columns.Add("HasFlag", GetType(Boolean))

			table.Rows.Add(0, Nothing, "Personal Folders", Nothing, Resources.TV_RootFolder)
			table.Rows.Add(1, 0, "Deleted Items", Nothing, Resources.TV_RecycleBin, False, 1)
			table.Rows.Add(2, 0, "Drafts", Nothing, Resources.TV_DraftFolder)
			table.Rows.Add(3, 0, "Inbox", Nothing, Resources.TV_DraftFolder, False, 3)
			table.Rows.Add(4, 0, "Junk E-mails", Nothing, Resources.TV_DraftFolder)
			table.Rows.Add(5, 0, "Outbox", Nothing, Resources.TV_DraftFolder)
			table.Rows.Add(6, 0, "Send Items", Nothing, Resources.TV_DraftFolder)
			table.Rows.Add(7, 0, "Search Folder", Nothing, Resources.TV_DraftFolder)

			table.Rows.Add(8, 1, "Adam Smith", "You`ve got to see this!", Resources.TV_MailNew, True)
			table.Rows.Add(9, 3, "Lewis Clark", "This is extremely urgent", Resources.TV_MailNew, True, Nothing, True)
			table.Rows.Add(10, 3, "Tomas Brown", "Need your help with this article", Resources.TV_MailOpened, False, Nothing, False, True)
			table.Rows.Add(11, 3, "Jeff Patel", "Please, check this our and report by Tomorow!", Resources.TV_MailNew, True)
			table.Rows.Add(12, 3, "Smith Jones", "Seend this yet?", Resources.TV_MailNew, True)
			table.Rows.Add(13, 3, "Denis Cooper", "Great new tool", Resources.TV_MailOpened, False)
			table.Rows.Add(14, 3, "Jackie Turner", "Team Building Session - All Hands", Resources.TV_MailOpened, False, Nothing, True)

			Me.radTreeView1.DataSource = table
			Me.radTreeView1.DisplayMember = "Name"
			Me.radTreeView1.ChildMember = "ID"
			Me.radTreeView1.ParentMember = "ParentID"
			Me.radTreeView1.ExpandAll()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			LoadData()
			Me.radTreeView1.AllowEdit = False
			Me.radTreeView1.Size = New Size(460, 500)
		End Sub

		Private Sub TreeViewElement_NodeFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.TreeNodeFormattingEventArgs)
			If Not radCheckBoxFormatting.IsChecked Then
				args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
				args.NodeElement.ContentElement.DisableHTMLRendering = True
				CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
				Return
			End If

			Dim rowView As DataRowView = CType(args.Node.DataBoundItem, DataRowView)
			args.NodeElement.ImageElement.Image = CType(rowView("Icon"), Image)

			args.NodeElement.ClipDrawing = False

			Dim element As RadElement = args.NodeElement.Children(0)

			Dim imageElement As LightVisualElement = Nothing
			If element.Name <> "StateImage" Then
				imageElement = New LightVisualElement()
				imageElement.Name = "StateImage"
				imageElement.StretchHorizontally = False
				imageElement.ImageLayout = ImageLayout.Center
				imageElement.MinSize = New Size(20, 20)
				imageElement.DrawBorder = True
				imageElement.DrawFill = True
				imageElement.GradientStyle = GradientStyles.Linear
				imageElement.GradientAngle = 0
				imageElement.NumberOfColors = 2
				imageElement.BorderBoxStyle = BorderBoxStyle.FourBorders

				imageElement.BorderRightWidth = 1
				imageElement.FitToSizeMode = RadFitToSizeMode.FitToParentBounds
				args.NodeElement.Children.Insert(0, imageElement)

				imageElement.BackColor = Color.FromArgb(255, 255, 255)
				imageElement.BackColor2 = Color.FromArgb(226, 226, 226)
				imageElement.BorderRightColor = Color.FromArgb(180, 184, 191)
                imageElement.BorderRightShadowColor = Color.FromArgb(241, 241, 241)
				imageElement.BorderLeftWidth = 0
				imageElement.BorderTopWidth = 0
				imageElement.BorderBottomWidth = 0
			Else
				imageElement = CType(args.NodeElement.Children(0), LightVisualElement)
			End If


			If rowView("Title") IsNot DBNull.Value Then
				args.NodeElement.ContentElement.Text = CStr(rowView("Name")) & " - " & CStr(rowView("Title"))
				If CBool(rowView("IsNew")) Then
					If boldFont Is Nothing Then
						boldFont = New Font(Me.Font, FontStyle.Bold)
					End If
					args.NodeElement.ContentElement.Font = boldFont
				Else
					args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
				End If

				If rowView("IsImportant") IsNot DBNull.Value Then
					If CBool(rowView("IsImportant")) Then
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Resources.TV_Exclamation
					Else
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
					End If
				End If

				If rowView("HasFlag") IsNot DBNull.Value Then
					If CBool(rowView("HasFlag")) Then
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Resources.TV_RedFlag
					Else
						CType(args.NodeElement.Children(0), LightVisualElement).Image = Nothing
					End If
				End If
            ElseIf rowView("NewItemCount") IsNot DBNull.Value Then
                Dim newItemCount As Integer = CInt(rowView("NewItemCount"))
                args.NodeElement.ContentElement.DisableHTMLRendering = False
                Dim color As String = "blue"
                Dim backColor As Color = args.NodeElement.BackColor

                If Not args.NodeElement.DrawFill OrElse backColor = System.Drawing.Color.Transparent Then
                    Dim parent As RadElement = args.NodeElement.Parent

                    While parent IsNot Nothing
                        Dim lve As LightVisualElement = TryCast(parent, LightVisualElement)

                        If lve IsNot Nothing AndAlso lve.DrawFill AndAlso lve.BackColor <> System.Drawing.Color.Transparent Then
                            backColor = lve.BackColor
                            Exit While
                        End If

                        parent = parent.Parent
                    End While
                End If

                If ImageHelper.IsDarkColor(backColor) Then
                    color = "cyan"
                End If

                args.NodeElement.ContentElement.Text = String.Format("<html> {0}<color={2}>({1})", args.Node.Text, newItemCount, color)
            End If
		End Sub

		Private Sub radCheckBoxFormatting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radTreeView1.TreeViewElement.Update(RadTreeViewElement.UpdateActions.StateChanged)
		End Sub
	End Class
End Namespace
