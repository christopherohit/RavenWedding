Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Public Sub New()
			InitializeComponent()
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
				Return "Organizational chart"
			End Get
		End Property

		'protected override int CalculateTreeWidth(int clientWidth)
		'{
		'    return this.radTreeView1.Width;
		'}

		'protected override int CalculateOffset(int clientWidth)
		'{
		'    return (clientWidth - this.radTreeView1.Width) / 2;
		'}

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.AutoScroll = False

			' TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)

			AddHandler radTreeView1.TreeViewElement.CreateNodeElement, AddressOf TreeViewElement_CreateNodeElement
			Me.radTreeView1.TreeViewElement.AutoSizeItems = True
			Me.radTreeView1.ShowLines = False
			Me.radTreeView1.ShowRootLines = False
			Me.radTreeView1.TreeViewElement.ViewElement.Margin = New Padding(4)
			Me.radTreeView1.ShowExpandCollapse = True
			Me.radTreeView1.TreeIndent = 50
			Me.radTreeView1.FullRowSelect = False
			Me.radTreeView1.ShowLines = True
			Me.radTreeView1.LineStyle = TreeLineStyle.Solid
			Me.radTreeView1.LineColor = Color.FromArgb(110, 153, 210)
			Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView1.AllowEdit = False

			Me.northwindDataSet.Employees.Columns.Add("ParentID", GetType(Integer))

			Me.northwindDataSet.Employees.Rows(0)("ParentID") = 5
			Me.northwindDataSet.Employees.Rows(1)("ParentID") = DBNull.Value
			Me.northwindDataSet.Employees.Rows(2)("ParentID") = 5
			Me.northwindDataSet.Employees.Rows(3)("ParentID") = 5
			Me.northwindDataSet.Employees.Rows(4)("ParentID") = 2
			Me.northwindDataSet.Employees.Rows(5)("ParentID") = 5
			Me.northwindDataSet.Employees.Rows(6)("ParentID") = 5
			Me.northwindDataSet.Employees.Rows(7)("ParentID") = 2
			Me.northwindDataSet.Employees.Rows(8)("ParentID") = 5

			Me.radTreeView1.DisplayMember = "LastName"
			Me.radTreeView1.ChildMember = "EmployeeID"
			Me.radTreeView1.ParentMember = "ParentID"
			Me.radTreeView1.DataSource = Me.northwindDataSet.Employees
			Me.radTreeView1.ExpandAll()

			Me.radTreeView1.Size = New Size(768, 479)
		End Sub

		Private Sub TreeViewElement_CreateNodeElement(ByVal sender As Object, ByVal args As CreateTreeNodeElementEventArgs)
			args.NodeElement = New CustomTreeNodeElement()
		End Sub
	End Class
End Namespace
