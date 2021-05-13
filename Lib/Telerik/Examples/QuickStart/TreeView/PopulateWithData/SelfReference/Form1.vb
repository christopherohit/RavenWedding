Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.SelfReference
	''' <summary>
	''' RadTreeView example
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Public Sub New()
			InitializeComponent()
			Me.radTreeView1.AllowDragDrop = True

			Me.SelectedControl = Me.radTreeView1
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Employees"
			End Get
		End Property

		Private Sub ExpandNodes()
			Using Me.radTreeView1.DeferRefresh()
				Dim root As RadTreeNode = Me.radTreeView1.Nodes(0)
				root.Expand()
				Dim index As Integer = 0

				For Each node As RadTreeNode In root.Nodes
					If index Mod 2 = 0 Then
						node.Expand()
					End If

					index += 1
				Next node

				If root.Nodes.Count > 0 Then
					root.Nodes(root.Nodes.Count - 1).ExpandAll()
				End If
			End Using
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'adventureLT2008DataSet.Employee' table. You can move, or remove it, as needed.
			Me.employeeTableAdapter.Fill(Me.adventureLT2008DataSet.Employee)

			'Note: The self-reference binding properties can be setup using Visual Studio Properties Window or Smart Tag
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = True
			Me.radTreeView1.DisplayMember = "Title"
			Me.radTreeView1.ParentMember = "ManagerID"
			Me.radTreeView1.ChildMember = "EmployeeID"
			Me.radTreeView1.DataSource = Me.employeeBindingSource

			ExpandNodes()
		End Sub
	End Class
End Namespace

