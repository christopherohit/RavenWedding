Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.LoadOnDemand
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
        Private bottomRightBitmap As Bitmap = My.Resources.TV_folders

		Public Sub New()
			InitializeComponent()
			Me.radTreeView1.LazyMode = False

			Me.SelectedControl = Me.radTreeView1
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radTreeView1.NodesNeeded, AddressOf radTreeView1_NodesNeeded
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "File Browser"
			End Get
		End Property

		Private Sub radTreeView1_NodesNeeded(ByVal sender As Object, ByVal args As NodesNeededEventArgs)
			If args.Parent Is Nothing Then
				LoadRoot(args.Nodes)
				Return
			End If

			If args.Parent.Text = "Favorites" Then
				LoadFavorites(args.Nodes)
			ElseIf args.Parent.Text = "Libraries" Then
				LoadLibraries(args.Nodes)
				args.Parent.Expand()
			ElseIf args.Parent.Text = "Computer" Then
				LoadComputer(args.Nodes)
			ElseIf args.Parent.Text = "Network" Then
				LoadNetwork(args.Nodes)
			ElseIf args.Parent.Text = "System" Then
				LoadSystem(args.Nodes)
			End If
		End Sub

		Private Sub LoadRoot(ByVal nodes As IList(Of RadTreeNode))
			Dim node As New RadTreeNode("Favorites")
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
			Dim node As New RadTreeNode("Work")
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
			Dim node As New RadTreeNode("Documents")
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
			Dim node As New RadTreeNode("System")
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
			Dim node As New RadTreeNode("PC1")
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
			Dim node As New RadTreeNode("Program Files")
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
	End Class
End Namespace

