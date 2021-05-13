Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.DragDrop
	''' <summary>
	''' Form1
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private dragNode As RadTreeNode = Nothing

		''' <summary>
		''' Form1 constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Me.radTreeView1.ItemHeight = 27
			Me.radTreeView2.ItemHeight = 27
			Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView2.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView2.FullRowSelect = False
			Me.radTreeView1.FullRowSelect = False
			Me.radTreeView1.MultiSelect = True

			Me.AutoScroll = False
			Me.radTextBox1.TextBoxElement.AllowDrop = True

			Dim dragDropService1 As TreeViewDragDropService = Me.radTreeView1.TreeViewElement.DragDropService
			Dim dragDropService2 As TreeViewDragDropService = Me.radTreeView2.TreeViewElement.DragDropService

			AddHandler dragDropService1.PreviewDragOver, AddressOf DragDropService_PreviewDragOver
			AddHandler dragDropService2.PreviewDragOver, AddressOf DragDropService_PreviewDragOver
		End Sub

		Private Sub DragDropService_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
			Dim textBox As RadTextBoxElement = TryCast(e.HitTarget, RadTextBoxElement)

			If textBox Is Me.radTextBox1.TextBoxElement Then
				e.CanDrop = True
			End If
		End Sub

		Private Sub radTreeView1_DragEnded(ByVal sender As Object, ByVal e As RadTreeViewDragEventArgs)
			If Me.dragNode IsNot Nothing Then
				Me.radTextBox1.Text = Me.dragNode.Text
			End If
		End Sub

		Private Sub radTreeView1_ItemDrag(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			Me.dragNode = e.Node
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radTreeView1.ItemDrag, AddressOf radTreeView1_ItemDrag
			AddHandler radTreeView2.ItemDrag, AddressOf radTreeView1_ItemDrag
			AddHandler radTreeView1.DragEnded, AddressOf radTreeView1_DragEnded
			AddHandler radTreeView2.DragEnded, AddressOf radTreeView1_DragEnded
		End Sub
	End Class
End Namespace
