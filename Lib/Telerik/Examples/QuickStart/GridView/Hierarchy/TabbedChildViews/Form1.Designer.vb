Namespace Telerik.Examples.WinControls.GridView.Hierarchy.TabbedChildViews
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn2 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn2 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn3 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn3 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn4 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn5 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn4 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn5 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn12 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn13 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn14 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn15 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn16 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn17 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn18 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn19 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn6 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton5 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton6 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton7 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton8 = New Telerik.WinControls.UI.RadRadioButton()
			Dim gridViewRelation1 As New Telerik.WinControls.UI.GridViewRelation()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridViewTemplate1 = New Telerik.WinControls.UI.GridViewTemplate()
			Me.ordersBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.gridViewTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(918, 1)
			Me.settingsPanel.Size = New Size(200, 318)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			' 
			' gridViewTemplate1
			' 
			Me.gridViewTemplate1.Caption = "Orders"
			gridViewTextBoxColumn1.FieldName = "ShipName"
			gridViewTextBoxColumn1.HeaderText = "ShipName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "ShipName"
			gridViewTextBoxColumn1.Width = 180
			gridViewDecimalColumn1.DataType = GetType(Integer)
			gridViewDecimalColumn1.FieldName = "OrderID"
			gridViewDecimalColumn1.HeaderText = "OrderID"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.IsVisible = False
			gridViewDecimalColumn1.Name = "OrderID"
			gridViewTextBoxColumn2.FieldName = "CustomerID"
			gridViewTextBoxColumn2.HeaderText = "CustomerID"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.IsVisible = False
			gridViewTextBoxColumn2.Name = "CustomerID"
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "EmployeeID"
			gridViewDecimalColumn2.HeaderText = "EmployeeID"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.IsVisible = False
			gridViewDecimalColumn2.Name = "EmployeeID"
			gridViewDateTimeColumn1.DataType = GetType(Date)
			gridViewDateTimeColumn1.FieldName = "OrderDate"
			gridViewDateTimeColumn1.FormatString = "{0:d}"
			gridViewDateTimeColumn1.HeaderText = "OrderDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "OrderDate"
			gridViewDateTimeColumn1.Width = 120
			gridViewDateTimeColumn2.DataType = GetType(Date)
			gridViewDateTimeColumn2.FieldName = "RequiredDate"
			gridViewDateTimeColumn2.HeaderText = "RequiredDate"
			gridViewDateTimeColumn2.IsAutoGenerated = True
			gridViewDateTimeColumn2.IsVisible = False
			gridViewDateTimeColumn2.Name = "RequiredDate"
			gridViewDateTimeColumn3.DataType = GetType(Date)
			gridViewDateTimeColumn3.FieldName = "ShippedDate"
			gridViewDateTimeColumn3.HeaderText = "ShippedDate"
			gridViewDateTimeColumn3.IsAutoGenerated = True
			gridViewDateTimeColumn3.IsVisible = False
			gridViewDateTimeColumn3.Name = "ShippedDate"
			gridViewDecimalColumn3.DataType = GetType(Integer)
			gridViewDecimalColumn3.FieldName = "ShipVia"
			gridViewDecimalColumn3.HeaderText = "ShipVia"
			gridViewDecimalColumn3.IsAutoGenerated = True
			gridViewDecimalColumn3.IsVisible = False
			gridViewDecimalColumn3.Name = "ShipVia"
			gridViewDecimalColumn4.DataType = GetType(Decimal)
			gridViewDecimalColumn4.FieldName = "Freight"
			gridViewDecimalColumn4.FormatString = "{0} lbs"
			gridViewDecimalColumn4.HeaderText = "Freight"
			gridViewDecimalColumn4.IsAutoGenerated = True
			gridViewDecimalColumn4.Name = "Freight"
			gridViewDecimalColumn4.Width = 70
			gridViewTextBoxColumn3.FieldName = "ShipAddress"
			gridViewTextBoxColumn3.HeaderText = "ShipAddress"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "ShipAddress"
			gridViewTextBoxColumn3.Width = 150
			gridViewTextBoxColumn4.FieldName = "ShipCity"
			gridViewTextBoxColumn4.HeaderText = "ShipCity"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "ShipCity"
			gridViewTextBoxColumn4.Width = 80
			gridViewTextBoxColumn5.FieldName = "ShipRegion"
			gridViewTextBoxColumn5.HeaderText = "ShipRegion"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.IsVisible = False
			gridViewTextBoxColumn5.Name = "ShipRegion"
			gridViewTextBoxColumn6.FieldName = "ShipPostalCode"
			gridViewTextBoxColumn6.HeaderText = "ShipPostalCode"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.IsVisible = False
			gridViewTextBoxColumn6.Name = "ShipPostalCode"
			gridViewTextBoxColumn7.FieldName = "ShipCountry"
			gridViewTextBoxColumn7.HeaderText = "ShipCountry"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.Name = "ShipCountry"
			gridViewTextBoxColumn7.Width = 100
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn1)
			Me.gridViewTemplate1.Columns.Add(gridViewDecimalColumn1)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn2)
			Me.gridViewTemplate1.Columns.Add(gridViewDecimalColumn2)
			Me.gridViewTemplate1.Columns.Add(gridViewDateTimeColumn1)
			Me.gridViewTemplate1.Columns.Add(gridViewDateTimeColumn2)
			Me.gridViewTemplate1.Columns.Add(gridViewDateTimeColumn3)
			Me.gridViewTemplate1.Columns.Add(gridViewDecimalColumn3)
			Me.gridViewTemplate1.Columns.Add(gridViewDecimalColumn4)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn3)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn4)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn5)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn6)
			Me.gridViewTemplate1.Columns.Add(gridViewTextBoxColumn7)
			Me.gridViewTemplate1.DataSource = Me.ordersBindingSource
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.Templates.AddRange(New Telerik.WinControls.UI.GridViewTemplate() { Me.gridViewTemplate1})
			gridViewDecimalColumn5.DataType = GetType(Integer)
			gridViewDecimalColumn5.FieldName = "EmployeeID"
			gridViewDecimalColumn5.HeaderText = "EmployeeID"
			gridViewDecimalColumn5.IsAutoGenerated = True
			gridViewDecimalColumn5.IsVisible = False
			gridViewDecimalColumn5.Name = "EmployeeID"
			gridViewTextBoxColumn8.FieldName = "FirstName"
			gridViewTextBoxColumn8.HeaderText = "FirstName"
			gridViewTextBoxColumn8.IsAutoGenerated = True
			gridViewTextBoxColumn8.Name = "FirstName"
			gridViewTextBoxColumn8.Width = 100
			gridViewTextBoxColumn9.FieldName = "LastName"
			gridViewTextBoxColumn9.HeaderText = "LastName"
			gridViewTextBoxColumn9.IsAutoGenerated = True
			gridViewTextBoxColumn9.Name = "LastName"
			gridViewTextBoxColumn9.Width = 100
			gridViewTextBoxColumn10.FieldName = "Title"
			gridViewTextBoxColumn10.HeaderText = "Title"
			gridViewTextBoxColumn10.IsAutoGenerated = True
			gridViewTextBoxColumn10.Name = "Title"
			gridViewTextBoxColumn10.Width = 150
			gridViewTextBoxColumn11.FieldName = "TitleOfCourtesy"
			gridViewTextBoxColumn11.HeaderText = "TitleOfCourtesy"
			gridViewTextBoxColumn11.IsAutoGenerated = True
			gridViewTextBoxColumn11.IsVisible = False
			gridViewTextBoxColumn11.Name = "TitleOfCourtesy"
			gridViewDateTimeColumn4.DataType = GetType(Date)
			gridViewDateTimeColumn4.FieldName = "BirthDate"
			gridViewDateTimeColumn4.HeaderText = "BirthDate"
			gridViewDateTimeColumn4.IsAutoGenerated = True
			gridViewDateTimeColumn4.IsVisible = False
			gridViewDateTimeColumn4.Name = "BirthDate"
			gridViewDateTimeColumn5.DataType = GetType(Date)
			gridViewDateTimeColumn5.FieldName = "HireDate"
			gridViewDateTimeColumn5.HeaderText = "HireDate"
			gridViewDateTimeColumn5.IsAutoGenerated = True
			gridViewDateTimeColumn5.IsVisible = False
			gridViewDateTimeColumn5.Name = "HireDate"
			gridViewTextBoxColumn12.FieldName = "Address"
			gridViewTextBoxColumn12.HeaderText = "Address"
			gridViewTextBoxColumn12.IsAutoGenerated = True
			gridViewTextBoxColumn12.IsVisible = False
			gridViewTextBoxColumn12.Name = "Address"
			gridViewTextBoxColumn13.FieldName = "City"
			gridViewTextBoxColumn13.HeaderText = "City"
			gridViewTextBoxColumn13.IsAutoGenerated = True
			gridViewTextBoxColumn13.Name = "City"
			gridViewTextBoxColumn13.Width = 100
			gridViewTextBoxColumn14.FieldName = "Region"
			gridViewTextBoxColumn14.HeaderText = "Region"
			gridViewTextBoxColumn14.IsAutoGenerated = True
			gridViewTextBoxColumn14.IsVisible = False
			gridViewTextBoxColumn14.Name = "Region"
			gridViewTextBoxColumn15.FieldName = "PostalCode"
			gridViewTextBoxColumn15.HeaderText = "PostalCode"
			gridViewTextBoxColumn15.IsAutoGenerated = True
			gridViewTextBoxColumn15.IsVisible = False
			gridViewTextBoxColumn15.Name = "PostalCode"
			gridViewTextBoxColumn16.FieldName = "Country"
			gridViewTextBoxColumn16.HeaderText = "Country"
			gridViewTextBoxColumn16.IsAutoGenerated = True
			gridViewTextBoxColumn16.Name = "Country"
			gridViewTextBoxColumn16.Width = 100
			gridViewTextBoxColumn17.FieldName = "HomePhone"
			gridViewTextBoxColumn17.HeaderText = "Phone"
			gridViewTextBoxColumn17.IsAutoGenerated = True
			gridViewTextBoxColumn17.Name = "HomePhone"
			gridViewTextBoxColumn17.Width = 100
			gridViewTextBoxColumn18.FieldName = "Extension"
			gridViewTextBoxColumn18.HeaderText = "Extension"
			gridViewTextBoxColumn18.IsAutoGenerated = True
			gridViewTextBoxColumn18.IsVisible = False
			gridViewTextBoxColumn18.Name = "Extension"
			gridViewImageColumn1.DataType = GetType(Byte())
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.IsVisible = False
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn19.FieldName = "Notes"
			gridViewTextBoxColumn19.HeaderText = "Notes"
			gridViewTextBoxColumn19.IsAutoGenerated = True
			gridViewTextBoxColumn19.IsVisible = False
			gridViewTextBoxColumn19.Name = "Notes"
			gridViewDecimalColumn6.DataType = GetType(Integer)
			gridViewDecimalColumn6.FieldName = "ReportsTo"
			gridViewDecimalColumn6.HeaderText = "ReportsTo"
			gridViewDecimalColumn6.IsAutoGenerated = True
			gridViewDecimalColumn6.IsVisible = False
			gridViewDecimalColumn6.Name = "ReportsTo"
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn5)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn11)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn4)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDateTimeColumn5)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn12)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn13)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn14)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn15)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn16)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn17)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn18)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewImageColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn19)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn6)
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView1.Name = "radGridView1"
			gridViewRelation1.ChildColumnNames = (CType(resources.GetObject("gridViewRelation1.ChildColumnNames"), System.Collections.Specialized.StringCollection))
			gridViewRelation1.ChildTemplate = Me.gridViewTemplate1
			gridViewRelation1.ParentColumnNames = (CType(resources.GetObject("gridViewRelation1.ParentColumnNames"), System.Collections.Specialized.StringCollection))
			gridViewRelation1.ParentTemplate = Me.radGridView1.MasterTemplate
			gridViewRelation1.RelationName = Nothing
			Me.radGridView1.Relations.Add(gridViewRelation1)
			' 
			' 
			' 
			Me.radGridView1.Size = New Size(1119, 320)
			Me.radGridView1.TabIndex = 1

			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton4)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton3)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.Font = New Font("Arial", 8.25F)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Tabs Position"
			Me.radGroupBox1.Location = New Point(10, 47)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 132)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Tabs Position"
			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.AllowShowFocusCues = True
			Me.radRadioButton4.AutoSize = True
			Me.radRadioButton4.Font = New Font("Arial", 8.25F)
			Me.radRadioButton4.Location = New Point(18, 103)
			Me.radRadioButton4.Name = "radRadioButton4"
			Me.radRadioButton4.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioButton4.Size = New Size(47, 16)
			Me.radRadioButton4.TabIndex = 3
			Me.radRadioButton4.Text = "Right"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.AllowShowFocusCues = True
			Me.radRadioButton3.AutoSize = True
			Me.radRadioButton3.Font = New Font("Arial", 8.25F)
			Me.radRadioButton3.Location = New Point(18, 79)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioButton3.Size = New Size(39, 16)
			Me.radRadioButton3.TabIndex = 2
			Me.radRadioButton3.Text = "Left"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.AllowShowFocusCues = True
			Me.radRadioButton2.AutoSize = True
			Me.radRadioButton2.Font = New Font("Arial", 8.25F)
			Me.radRadioButton2.Location = New Point(18, 55)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioButton2.Size = New Size(56, 16)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Bottom"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.AllowShowFocusCues = True
			Me.radRadioButton1.AutoSize = True
			Me.radRadioButton1.Font = New Font("Arial", 8.25F)
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton1.Location = New Point(18, 31)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioButton1.Size = New Size(40, 16)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "Top"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radRadioButton8)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton7)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton6)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton5)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New Padding(0)
			Me.radGroupBox2.HeaderText = "Page view mode"
			Me.radGroupBox2.Location = New Point(10, 215)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(180, 135)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "Page view mode"
			' 
			' radRadioButton5
			' 
			Me.radRadioButton5.Location = New Point(18, 24)
			Me.radRadioButton5.Name = "radRadioButton5"
			Me.radRadioButton5.Size = New Size(110, 18)
			Me.radRadioButton5.TabIndex = 0
			Me.radRadioButton5.Text = "Strip"
			Me.radRadioButton5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' radRadioButton6
			' 
			Me.radRadioButton6.Location = New Point(18, 49)
			Me.radRadioButton6.Name = "radRadioButton6"
			Me.radRadioButton6.Size = New Size(110, 18)
			Me.radRadioButton6.TabIndex = 1
			Me.radRadioButton6.Text = "Stack"

			' 
			' radRadioButton7
			' 
			Me.radRadioButton7.Location = New Point(18, 73)
			Me.radRadioButton7.Name = "radRadioButton7"
			Me.radRadioButton7.Size = New Size(110, 18)
			Me.radRadioButton7.TabIndex = 2
			Me.radRadioButton7.Text = "Outlook"

			' 
			' radRadioButton8
			' 
			Me.radRadioButton8.Location = New Point(18, 98)
			Me.radRadioButton8.Name = "radRadioButton8"
			Me.radRadioButton8.Size = New Size(110, 18)
			Me.radRadioButton8.TabIndex = 3
			Me.radRadioButton8.Text = "Explorer Bar"

			' 
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1119, 320)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.gridViewTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radRadioButton4 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesBindingSource As BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private ordersBindingSource As BindingSource
		Private ordersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private gridViewTemplate1 As Telerik.WinControls.UI.GridViewTemplate
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton7 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton6 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton5 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton8 As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
