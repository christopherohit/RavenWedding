Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace DemoAppsHub.TreeExample
	''' <summary>
	''' Example beautifying
	''' </summary>
	Public Partial Class TreeExampleUserControl
		Inherits UserControl
		Private level1 As Bitmap
		Private level2 As Bitmap
		Private level3 As Bitmap

		Public Sub New()
			InitializeComponent()

            level1 = Resources.level1
            level2 = Resources.level2
            level3 = Resources.level3

			ThemeResolutionService.ApplyThemeToControlTree(Me, "TelerikMetroBlue")

			Dim item As RadMenuItem = New RadMenuItem("None")
			AddHandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			item = New RadMenuItem("Alphabetically")
			AddHandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			Dim searchIcon As ImagePrimitive = New ImagePrimitive()
            searchIcon.Image = Resources.TV_search
			searchIcon.Alignment = ContentAlignment.MiddleRight
			Me.radTextBox1.TextBoxElement.Children.Add(searchIcon)
			Me.radTextBox1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
			AddHandler radTextBox1.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = True
			Me.radTreeView1.AllowEdit = False
			Me.radTreeView1.AllowAdd = False
			Me.radTreeView1.AllowRemove = False
			Me.radTreeView1.ItemHeight = 34
			Me.radTreeView1.AllowDefaultContextMenu = False

			Me.AutoScroll = False

			Me.radPanel3.PanelElement.PanelFill.BackColor = Color.White
			Me.radPanel3.BackColor = Color.White
			Me.radPanel3.PanelElement.PanelFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			Me.radPanel3.PanelElement.PanelBorder.TopColor = Color.FromArgb(196, 199, 182)
			Me.radPanel3.PanelElement.PanelBorder.LeftColor = Color.FromArgb(196, 199, 182)
			Me.radPanel3.PanelElement.PanelBorder.RightColor = Color.FromArgb(196, 199, 182)
			Me.radPanel3.PanelElement.PanelBorder.BottomColor = Color.White
			Me.radPanel3.PanelElement.PanelBorder.BoxStyle = BorderBoxStyle.FourBorders
			Me.radPanel3.PanelElement.PanelBorder.BorderDrawMode = BorderDrawModes.VerticalOverHorizontal
			Me.radPanel3.PanelElement.PanelBorder.GradientStyle = GradientStyles.Solid

			Me.radPanel1.PanelElement.PanelFill.BackColor = Color.FromArgb(26, 93, 192)
			Me.radPanel1.PanelElement.PanelFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			Me.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.radPanel1.PanelElement.Font = New Font("Segoe UI Light", 20, FontStyle.Regular)
			Me.radPanel1.ForeColor = Color.White
			Me.radPanel1.PanelElement.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
			Me.radPanel1.Text = "Music Collection"
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.artistsTableAdapter.Fill(musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(musicCollectionDataSet.Albums)
			Me.songsTableAdapter.Fill(musicCollectionDataSet.Songs)

			Using Me.radTreeView1.DeferRefresh()
				Me.radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID")
				Me.radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID")
				Me.radTreeView1.DisplayMember = "ArtistName"
				Me.radTreeView1.DataSource = artistsBindingSource
			End Using

			For Each node As RadTreeNode In Me.radTreeView1.Nodes
				node.Expand()
			Next node
		End Sub

		Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadMenuItem = CType(sender, RadMenuItem)
			Me.radDropDownButton1.Text = item.Text
			If item.Text = "None" Then
				radTreeView1.SortOrder = SortOrder.None
			Else
				radTreeView1.SortOrder = SortOrder.Ascending
			End If
		End Sub

		Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBox1.TextChanged
			Me.radTreeView1.Filter = Me.radTextBox1.Text
		End Sub

		Private Sub radTreeView1_NodeExpandedChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTreeViewCancelEventArgs) Handles radTreeView1.NodeExpandedChanging
		   Dim nodes As RadTreeNodeCollection = e.Node.Nodes
		   If e.Node.Level = 0 Then
			   e.Node.Image = level1
		   End If
			For Each node As RadTreeNode In nodes
				If node.Level = 0 Then
					node.Image = level1
				ElseIf node.Level = 1 Then
					node.Image = level2
				Else
					node.Image = level3
				End If
			Next node
		End Sub

		Private Sub TextBoxItem_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(radTextBox1.Size.Width - 28, 0)
			End If
		End Sub
	End Class
End Namespace
