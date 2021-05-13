Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.doubleBufferedTableLayoutPanel1

			LoadData()
			Me.radTreeView1.ExpandAll()

			Dim item As New RadMenuItem("None")
			AddHandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			item = New RadMenuItem("Ascending")
			AddHandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			item = New RadMenuItem("Descending")
			AddHandler item.Click, AddressOf item_Click
			Me.radDropDownButton1.Items.Add(item)

			Dim searchIcon As New ImagePrimitive()
            searchIcon.Image = My.Resources.TV_search
            Me.radTextBox1.TextBoxElement.ButtonsStack.Children.Add(searchIcon)
			AddHandler radTextBox1.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = True
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True
			Me.radTreeView1.ItemHeight = 27
			Me.radTreeView1.AllowDefaultContextMenu = True
			Me.AutoScroll = False
		End Sub

		Private Sub LoadData()
			Dim root As RadTreeNode = Me.radTreeView1.Nodes.Add("Programming")
			root.Nodes.Add("Microsoft Research News and Highlights", 1)

			root.Nodes.Add("Joel on Software", 1)
			root.Nodes.Add("Miguel de Icaza", 1)
			root.Nodes.Add("channel 9", 1)

			root = Me.radTreeView1.Nodes.Add("News (1)")
			root.Nodes.Add("cnn.com (1)", 1)
			root.Nodes.Add("msnbc.com", 1)
			root.Nodes.Add("reuters.com", 1)
			root.Nodes.Add("bbc.co.uk", 1)

			root = Me.radTreeView1.Nodes.Add("Personal (19)")
			root.Nodes.Add("sports (2)", 1)
			Dim folder As RadTreeNode = root.Nodes.Add("fun (17)")
			folder.Nodes.Add("Lolcats (2)", 1)
			folder.Nodes.Add("FFFOUND (15)", 1)

			Me.radTreeView1.Nodes.Add("Telerik blogs", 1)
			Me.radTreeView1.Nodes.Add("Techcrunch", 1)
			Me.radTreeView1.Nodes.Add("Engadget", 1)
		End Sub

		Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadMenuItem = CType(sender, RadMenuItem)
			Me.radDropDownButton1.Text = item.Text
			If item.Text = "None" Then
				radTreeView1.SortOrder = SortOrder.None
			ElseIf item.Text = "Ascending" Then
				radTreeView1.SortOrder = SortOrder.Ascending
			Else
				radTreeView1.SortOrder = SortOrder.Descending
			End If
		End Sub

		Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTreeView1.Filter = Me.radTextBox1.Text
		End Sub

		Private Sub radTreeView1_NodeFormatting(ByVal sender As Object, ByVal args As TreeNodeFormattingEventArgs)
			If args.Node.Text.Contains("(") Then
				args.NodeElement.ContentElement.Text = "<html><b>" & args.Node.Text
			End If
		End Sub

		Private Sub TextBoxItem_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(radTextBox1.Size.Width - 28, 0)
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radTreeView1.NodeFormatting, AddressOf radTreeView1_NodeFormatting
			AddHandler radTextBox1.TextChanged, AddressOf radTextBox1_TextChanged
		End Sub
	End Class
End Namespace
