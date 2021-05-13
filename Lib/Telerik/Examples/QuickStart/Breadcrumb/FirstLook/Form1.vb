Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Breadcrumb.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.radTreeView1.LazyMode = False
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.radBreadCrumb1.UpdateBreadCrumb(Me.radTreeView1.SelectedNode)
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radTreeView1.NodesNeeded, AddressOf Me.radTreeView1_NodesNeeded
        End Sub

        Private Sub radTreeView1_NodesNeeded(ByVal sender As Object, ByVal args As NodesNeededEventArgs)
            If args.Parent Is Nothing Then
                LoadRoot(args.Nodes)
                Return
            End If

            If args.Parent.Text = "Favorites" Then
                LoadFavorites(args.Nodes)
                args.Parent.Expand()
            ElseIf args.Parent.Text = "Libraries" Then
                LoadLibraries(args.Nodes)
                args.Parent.Expand()
                Me.radTreeView1.SelectedNode = args.Parent.Nodes("Pictures")
            ElseIf args.Parent.Text = "Computer" Then
                LoadComputer(args.Nodes)
                args.Parent.Expand()
            ElseIf args.Parent.Text = "Network" Then
                LoadNetwork(args.Nodes)
                args.Parent.Expand()
            ElseIf args.Parent.Text = "System" Then
                LoadSystem(args.Nodes)
                args.Parent.Expand()
            End If
        End Sub

        Private Sub LoadRoot(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("Favorites")
            node.ImageKey = "favorites"
            nodes.Add(node)
            node = New RadTreeNode("Libraries")
            node.ImageKey = "libraries"
            nodes.Add(node)
            node = New RadTreeNode("Computer")
            node.ImageKey = "computer"
            nodes.Add(node)
            node = New RadTreeNode("Network")
            node.ImageKey = "network"
            nodes.Add(node)
        End Sub

        Private Sub LoadFavorites(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("Work")
            node.ImageKey = "work"
            nodes.Add(node)
            node = New RadTreeNode("Downloads")
            node.ImageKey = "downloads"
            nodes.Add(node)
            node = New RadTreeNode("Desktop")
            node.ImageKey = "desktop"
            nodes.Add(node)
            node = New RadTreeNode("Virtual Machines")
            node.ImageKey = "virtual machines"
            nodes.Add(node)
        End Sub

        Private Sub LoadLibraries(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("Documents")
            node.ImageKey = "documents"
            nodes.Add(node)
            node = New RadTreeNode("Music")
            node.ImageKey = "music"
            nodes.Add(node)
            node = New RadTreeNode("Pictures")
            node.ImageKey = "pictures"
            nodes.Add(node)
            node = New RadTreeNode("Videos")
            node.ImageKey = "video"
            nodes.Add(node)
        End Sub

        Private Sub LoadComputer(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("System")
            node.ImageKey = "hdd"
            nodes.Add(node)
            node = New RadTreeNode("Resources")
            node.ImageKey = "network drive"
            nodes.Add(node)
            node = New RadTreeNode("Share")
            node.ImageKey = "network drive"
            nodes.Add(node)
        End Sub

        Private Sub LoadNetwork(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("PC1")
            node.ImageKey = "computer"
            nodes.Add(node)
            node = New RadTreeNode("PC2")
            node.ImageKey = "computer"
            nodes.Add(node)
            node = New RadTreeNode("Laptop1")
            node.ImageKey = "computer"
            nodes.Add(node)
            node = New RadTreeNode("Laptop2")
            node.ImageKey = "computer"
            nodes.Add(node)
        End Sub

        Private Sub LoadSystem(ByVal nodes As IList(Of RadTreeNode))
            Dim node As RadTreeNode = New RadTreeNode("Program Files")
            node.ImageKey = "folder"
            nodes.Add(node)
            node = New RadTreeNode("Program Files (x86)")
            node.ImageKey = "folder"
            nodes.Add(node)
            node = New RadTreeNode("Users")
            node.ImageKey = "folder"
            nodes.Add(node)
            node = New RadTreeNode("Windows")
            node.ImageKey = "folder"
            nodes.Add(node)
        End Sub

        Private Sub AutoCompleteCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radBreadCrumb1.IsAutoCompleteEnabled = Not Me.radBreadCrumb1.IsAutoCompleteEnabled
        End Sub

        Private Sub TextModeCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radBreadCrumb1.IsTextModeEnabled = Not Me.radBreadCrumb1.IsTextModeEnabled
            Me.autoCompleteCheckBox.Enabled = Me.radBreadCrumb1.IsTextModeEnabled
        End Sub

        Private Sub HistroyCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radBreadCrumb1.IsHistoryEnabled = Not Me.radBreadCrumb1.IsHistoryEnabled
        End Sub

        Private Sub SelectTreeNodeCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radBreadCrumb1.SelectTreeNodeOnClick = Not Me.radBreadCrumb1.SelectTreeNodeOnClick
        End Sub
    End Class
End Namespace
