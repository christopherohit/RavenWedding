Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.Performance
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_folders

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radTreeViewDemo
			'this.radTreeViewDemo.NodeFormatting += new TreeNodeFormattingEventHandler(radTreeViewDemo_NodeFormatting);
			Me.radTreeViewDemo.TreeViewElement.Text = "Click the Load buton to load nodes"
			Me.radTreeViewDemo.TreeViewElement.TextWrap = True
			Me.radTreeViewDemo.TreeViewElement.TextAlignment = ContentAlignment.MiddleCenter
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radBtnLoad.Click, AddressOf radButton1_Click
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeViewDemo
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Performance"
			End Get
		End Property

		Private Sub LoadNodes()
			Dim index As Integer = 0

			Dim watch As Stopwatch = Stopwatch.StartNew()

			Using Me.radTreeViewDemo.DeferRefresh()
				Me.radTreeViewDemo.Nodes.Clear()
				For i As Integer = 0 To 3124
					index += 1
					Dim node As New RadTreeNode("Node" & index)

					For j As Integer = 0 To 4
						index += 1
						Dim child As New RadTreeNode("Node" & index)
						node.Nodes.Add(child)
						For p As Integer = 0 To 1
							index += 1
							Dim childChild As New RadTreeNode("Node" & index)
							child.Nodes.Add(childChild)
						Next p

					Next j

					Me.radTreeViewDemo.Nodes.Add(node)
				Next i
			End Using

			watch.Stop()
			Me.radProgressBar1.Value1 = 50000
			radLabel1.Text = "Time elapsed: " & (watch.ElapsedMilliseconds / 1000.0).ToString("0.00") & " sec"
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radTreeViewDemo.AllowAdd = True
			Me.radTreeViewDemo.AllowRemove = True
		End Sub

		Private Sub radTreeViewDemo_NodeFormatting(ByVal sender As Object, ByVal e As TreeNodeFormattingEventArgs)
			e.NodeElement.ImageElement.Image = Resources.TV_Folder
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTreeViewDemo.TreeViewElement.Text = ""
			LoadNodes()
		End Sub
	End Class
End Namespace
