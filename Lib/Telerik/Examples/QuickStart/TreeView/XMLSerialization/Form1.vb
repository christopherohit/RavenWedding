Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.XMLSerialization
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_folders

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radTreeView1
			Me.UpdateButtonStates()

			Me.radTreeView1.AllowDefaultContextMenu = True
			AddHandler Me.radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_Selected
			AddHandler radTreeView1.NodeFormatting, AddressOf radTreeView1_NodeFormatting
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler btnAddChild.Click, AddressOf btnAddChild_Click
			AddHandler btnLoadFile.Click, AddressOf btnLoadFile_Click
			AddHandler btnSaveFile.Click, AddressOf btnSaveFile_Click
			AddHandler btnRemove.Click, AddressOf btnRemove_Click
			AddHandler btnAddRoot.Click, AddressOf btnAddRoot_Click
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
				Return "Serialization"
			End Get
		End Property

		Private Sub UpdateButtonStates()
			Dim selectedNode As RadTreeNode = Me.radTreeView1.SelectedNode
			Dim enabled As Boolean = selectedNode IsNot Nothing

			Me.btnAddChild.Enabled = enabled
			Me.btnRemove.Enabled = enabled
		End Sub

		Private Sub AddNode(ByVal nodes As RadTreeNodeCollection)
			Dim newNode As New RadTreeNode()
			newNode.Text = "RadTreeNode"
			nodes.Add(newNode)
			Me.radTreeView1.SelectedNode = newNode
		End Sub

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True
		End Sub

		Private Sub radTreeView1_Selected(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			Me.UpdateButtonStates()
		End Sub

		Private Sub radTreeView1_NodeFormatting(ByVal sender As Object, ByVal e As TreeNodeFormattingEventArgs)
			e.NodeElement.ImageElement.Image = Resources.TV_Folder
		End Sub

		Private Sub btnAddRoot_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddNode(Me.radTreeView1.Nodes)
		End Sub

		Private Sub btnAddChild_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedNode As RadTreeNode = Me.radTreeView1.SelectedNode
			If selectedNode IsNot Nothing Then
				Me.AddNode(selectedNode.Nodes)
				selectedNode.Expanded = True
			End If
		End Sub

		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedNode As RadTreeNode = Me.radTreeView1.SelectedNode
			If selectedNode IsNot Nothing Then
				selectedNode.Remove()
			End If
		End Sub

		Private Sub btnLoadFile_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.AddExtension = True
			openFileDialog.DefaultExt = ".xml"
			openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
			openFileDialog.Multiselect = False

			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.radTreeView1.LoadXML(openFileDialog.FileName)
			End If
		End Sub

		Private Sub btnSaveFile_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.AddExtension = True
			saveFileDialog.DefaultExt = ".xml"
			saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"

			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Me.radTreeView1.SaveXML(saveFileDialog.FileName)
			End If
		End Sub

		#End Region
	End Class
End Namespace