Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.ItemDragDrop
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


		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridViewDecimalColumn53 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn85 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn86 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn87 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn88 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn21 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn22 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn89 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn90 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn91 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn92 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn93 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn94 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn95 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn5 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn96 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn54 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn55 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn97 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn56 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDateTimeColumn23 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn24 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDateTimeColumn25 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewDecimalColumn57 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn58 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn98 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn99 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn100 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn101 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn102 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn103 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn59 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn104 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn60 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn61 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn105 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn62 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn63 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn64 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewDecimalColumn65 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewCheckBoxColumn5 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
			Me.productsBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGridView2 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.radGridView3 = New Telerik.WinControls.UI.RadGridView()
			Me.ordersBindingSource = New BindingSource(Me.components)
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
			Me.textBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.ordersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.dragModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dragModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.dragModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1093, 1)
			Me.settingsPanel.Size = New Size(200, 549)

			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.dragModeCombo, 0)
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radGridView2
			' 
			Me.radGridView2.BackColor = Color.Transparent
			Me.radGridView2.Cursor = Cursors.Default
			Me.radGridView2.Dock = DockStyle.Fill
			Me.radGridView2.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView2.ForeColor = Color.Black
			Me.radGridView2.ImeMode = ImeMode.NoControl
			Me.radGridView2.Location = New Point(0, 0)
			' 
			' 
			' 
			gridViewDecimalColumn53.DataType = GetType(Integer)
			gridViewDecimalColumn53.FieldName = "EmployeeID"
			gridViewDecimalColumn53.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn53.HeaderText = "EmployeeID"
			gridViewDecimalColumn53.IsAutoGenerated = True
			gridViewDecimalColumn53.IsVisible = False
			gridViewDecimalColumn53.Name = "EmployeeID"
			gridViewTextBoxColumn85.FieldName = "LastName"
			gridViewTextBoxColumn85.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn85.HeaderText = "LastName"
			gridViewTextBoxColumn85.IsAutoGenerated = True
			gridViewTextBoxColumn85.IsVisible = False
			gridViewTextBoxColumn85.Name = "LastName"
			gridViewTextBoxColumn86.FieldName = "FirstName"
			gridViewTextBoxColumn86.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn86.HeaderText = "FirstName"
			gridViewTextBoxColumn86.IsAutoGenerated = True
			gridViewTextBoxColumn86.Name = "FirstName"
			gridViewTextBoxColumn87.FieldName = "Title"
			gridViewTextBoxColumn87.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn87.HeaderText = "Title"
			gridViewTextBoxColumn87.IsAutoGenerated = True
			gridViewTextBoxColumn87.Name = "Title"
			gridViewTextBoxColumn88.FieldName = "TitleOfCourtesy"
			gridViewTextBoxColumn88.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn88.HeaderText = "TitleOfCourtesy"
			gridViewTextBoxColumn88.IsAutoGenerated = True
			gridViewTextBoxColumn88.IsVisible = False
			gridViewTextBoxColumn88.Name = "TitleOfCourtesy"
			gridViewDateTimeColumn21.FieldName = "BirthDate"
			gridViewDateTimeColumn21.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn21.HeaderText = "BirthDate"
			gridViewDateTimeColumn21.IsAutoGenerated = True
			gridViewDateTimeColumn21.IsVisible = False
			gridViewDateTimeColumn21.Name = "BirthDate"
			gridViewDateTimeColumn22.FieldName = "HireDate"
			gridViewDateTimeColumn22.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn22.HeaderText = "HireDate"
			gridViewDateTimeColumn22.IsAutoGenerated = True
			gridViewDateTimeColumn22.IsVisible = False
			gridViewDateTimeColumn22.Name = "HireDate"
			gridViewTextBoxColumn89.FieldName = "Address"
			gridViewTextBoxColumn89.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn89.HeaderText = "Address"
			gridViewTextBoxColumn89.IsAutoGenerated = True
			gridViewTextBoxColumn89.Name = "Address"
			gridViewTextBoxColumn90.FieldName = "City"
			gridViewTextBoxColumn90.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn90.HeaderText = "City"
			gridViewTextBoxColumn90.IsAutoGenerated = True
			gridViewTextBoxColumn90.IsVisible = False
			gridViewTextBoxColumn90.Name = "City"
			gridViewTextBoxColumn91.FieldName = "Region"
			gridViewTextBoxColumn91.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn91.HeaderText = "Region"
			gridViewTextBoxColumn91.IsAutoGenerated = True
			gridViewTextBoxColumn91.IsVisible = False
			gridViewTextBoxColumn91.Name = "Region"
			gridViewTextBoxColumn92.FieldName = "PostalCode"
			gridViewTextBoxColumn92.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn92.HeaderText = "PostalCode"
			gridViewTextBoxColumn92.IsAutoGenerated = True
			gridViewTextBoxColumn92.IsVisible = False
			gridViewTextBoxColumn92.Name = "PostalCode"
			gridViewTextBoxColumn93.FieldName = "Country"
			gridViewTextBoxColumn93.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn93.HeaderText = "Country"
			gridViewTextBoxColumn93.IsAutoGenerated = True
			gridViewTextBoxColumn93.IsVisible = False
			gridViewTextBoxColumn93.Name = "Country"
			gridViewTextBoxColumn94.FieldName = "HomePhone"
			gridViewTextBoxColumn94.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn94.HeaderText = "HomePhone"
			gridViewTextBoxColumn94.IsAutoGenerated = True
			gridViewTextBoxColumn94.IsVisible = False
			gridViewTextBoxColumn94.Name = "HomePhone"
			gridViewTextBoxColumn95.FieldName = "Extension"
			gridViewTextBoxColumn95.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn95.HeaderText = "Extension"
			gridViewTextBoxColumn95.IsAutoGenerated = True
			gridViewTextBoxColumn95.IsVisible = False
			gridViewTextBoxColumn95.Name = "Extension"
			gridViewImageColumn5.DataType = GetType(Byte())
			gridViewImageColumn5.FieldName = "Photo"
			gridViewImageColumn5.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewImageColumn5.HeaderText = "Photo"
			gridViewImageColumn5.IsAutoGenerated = True
			gridViewImageColumn5.IsVisible = False
			gridViewImageColumn5.Name = "Photo"
			gridViewTextBoxColumn96.FieldName = "Notes"
			gridViewTextBoxColumn96.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn96.HeaderText = "Notes"
			gridViewTextBoxColumn96.IsAutoGenerated = True
			gridViewTextBoxColumn96.IsVisible = False
			gridViewTextBoxColumn96.Name = "Notes"
			gridViewDecimalColumn54.DataType = GetType(Integer)
			gridViewDecimalColumn54.FieldName = "ReportsTo"
			gridViewDecimalColumn54.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn54.HeaderText = "ReportsTo"
			gridViewDecimalColumn54.IsAutoGenerated = True
			gridViewDecimalColumn54.IsVisible = False
			gridViewDecimalColumn54.Name = "ReportsTo"
			Me.radGridView2.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn53, gridViewTextBoxColumn85, gridViewTextBoxColumn86, gridViewTextBoxColumn87, gridViewTextBoxColumn88, gridViewDateTimeColumn21, gridViewDateTimeColumn22, gridViewTextBoxColumn89, gridViewTextBoxColumn90, gridViewTextBoxColumn91, gridViewTextBoxColumn92, gridViewTextBoxColumn93, gridViewTextBoxColumn94, gridViewTextBoxColumn95, gridViewImageColumn5, gridViewTextBoxColumn96, gridViewDecimalColumn54})
			Me.radGridView2.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView2.MasterTemplate.EnableGrouping = False
			Me.radGridView2.Name = "radGridView2"
			Me.radGridView2.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView2.RightToLeft = RightToLeft.No
			' 
			' 
			' 
			Me.radGridView2.RootElement.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView2.ShowGroupPanel = False
			Me.radGridView2.Size = New Size(607, 418)
			Me.radGridView2.TabIndex = 0
			Me.radGridView2.Text = "radGridViewPreview"
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' radGridView3
			' 
			Me.radGridView3.BackColor = Color.Transparent
			Me.radGridView3.Cursor = Cursors.Default
			Me.radGridView3.Dock = DockStyle.Fill
			Me.radGridView3.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView3.ForeColor = Color.Black
			Me.radGridView3.ImeMode = ImeMode.NoControl
			Me.radGridView3.Location = New Point(0, 0)
			' 
			' 
			' 
			gridViewDecimalColumn55.DataType = GetType(Integer)
			gridViewDecimalColumn55.FieldName = "OrderID"
			gridViewDecimalColumn55.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn55.HeaderText = "OrderID"
			gridViewDecimalColumn55.IsAutoGenerated = True
			gridViewDecimalColumn55.Name = "OrderID"
			gridViewDecimalColumn55.TextAlignment = ContentAlignment.MiddleCenter
			gridViewTextBoxColumn97.FieldName = "CustomerID"
			gridViewTextBoxColumn97.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn97.HeaderText = "CustomerID"
			gridViewTextBoxColumn97.IsAutoGenerated = True
			gridViewTextBoxColumn97.IsVisible = False
			gridViewTextBoxColumn97.Name = "CustomerID"
			gridViewDecimalColumn56.DataType = GetType(Integer)
			gridViewDecimalColumn56.FieldName = "EmployeeID"
			gridViewDecimalColumn56.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn56.HeaderText = "EmployeeID"
			gridViewDecimalColumn56.IsAutoGenerated = True
			gridViewDecimalColumn56.IsVisible = False
			gridViewDecimalColumn56.Name = "EmployeeID"
			gridViewDateTimeColumn23.FieldName = "OrderDate"
			gridViewDateTimeColumn23.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn23.HeaderText = "OrderDate"
			gridViewDateTimeColumn23.IsAutoGenerated = True
			gridViewDateTimeColumn23.Name = "OrderDate"
			gridViewDateTimeColumn24.FieldName = "RequiredDate"
			gridViewDateTimeColumn24.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn24.HeaderText = "RequiredDate"
			gridViewDateTimeColumn24.IsAutoGenerated = True
			gridViewDateTimeColumn24.IsVisible = False
			gridViewDateTimeColumn24.Name = "RequiredDate"
			gridViewDateTimeColumn25.FieldName = "ShippedDate"
			gridViewDateTimeColumn25.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDateTimeColumn25.HeaderText = "ShippedDate"
			gridViewDateTimeColumn25.IsAutoGenerated = True
			gridViewDateTimeColumn25.IsVisible = False
			gridViewDateTimeColumn25.Name = "ShippedDate"
			gridViewDecimalColumn57.DataType = GetType(Integer)
			gridViewDecimalColumn57.FieldName = "ShipVia"
			gridViewDecimalColumn57.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn57.HeaderText = "ShipVia"
			gridViewDecimalColumn57.IsAutoGenerated = True
			gridViewDecimalColumn57.IsVisible = False
			gridViewDecimalColumn57.Name = "ShipVia"
			gridViewDecimalColumn58.FieldName = "Freight"
			gridViewDecimalColumn58.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn58.HeaderText = "Freight"
			gridViewDecimalColumn58.IsAutoGenerated = True
			gridViewDecimalColumn58.IsVisible = False
			gridViewDecimalColumn58.Name = "Freight"
			gridViewTextBoxColumn98.FieldName = "ShipName"
			gridViewTextBoxColumn98.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn98.HeaderText = "ShipName"
			gridViewTextBoxColumn98.IsAutoGenerated = True
			gridViewTextBoxColumn98.Name = "ShipName"
			gridViewTextBoxColumn99.FieldName = "ShipAddress"
			gridViewTextBoxColumn99.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn99.HeaderText = "ShipAddress"
			gridViewTextBoxColumn99.IsAutoGenerated = True
			gridViewTextBoxColumn99.IsVisible = False
			gridViewTextBoxColumn99.Name = "ShipAddress"
			gridViewTextBoxColumn100.FieldName = "ShipCity"
			gridViewTextBoxColumn100.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn100.HeaderText = "ShipCity"
			gridViewTextBoxColumn100.IsAutoGenerated = True
			gridViewTextBoxColumn100.IsVisible = False
			gridViewTextBoxColumn100.Name = "ShipCity"
			gridViewTextBoxColumn101.FieldName = "ShipRegion"
			gridViewTextBoxColumn101.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn101.HeaderText = "ShipRegion"
			gridViewTextBoxColumn101.IsAutoGenerated = True
			gridViewTextBoxColumn101.IsVisible = False
			gridViewTextBoxColumn101.Name = "ShipRegion"
			gridViewTextBoxColumn102.FieldName = "ShipPostalCode"
			gridViewTextBoxColumn102.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn102.HeaderText = "ShipPostalCode"
			gridViewTextBoxColumn102.IsAutoGenerated = True
			gridViewTextBoxColumn102.IsVisible = False
			gridViewTextBoxColumn102.Name = "ShipPostalCode"
			gridViewTextBoxColumn103.FieldName = "ShipCountry"
			gridViewTextBoxColumn103.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn103.HeaderText = "ShipCountry"
			gridViewTextBoxColumn103.IsAutoGenerated = True
			gridViewTextBoxColumn103.IsVisible = False
			gridViewTextBoxColumn103.Name = "ShipCountry"
			Me.radGridView3.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn55, gridViewTextBoxColumn97, gridViewDecimalColumn56, gridViewDateTimeColumn23, gridViewDateTimeColumn24, gridViewDateTimeColumn25, gridViewDecimalColumn57, gridViewDecimalColumn58, gridViewTextBoxColumn98, gridViewTextBoxColumn99, gridViewTextBoxColumn100, gridViewTextBoxColumn101, gridViewTextBoxColumn102, gridViewTextBoxColumn103})
			Me.radGridView3.MasterTemplate.DataSource = Me.ordersBindingSource
			Me.radGridView3.MasterTemplate.EnableGrouping = False
			Me.radGridView3.Name = "radGridView3"
			Me.radGridView3.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView3.RightToLeft = RightToLeft.No
			' 
			' 
			' 
			Me.radGridView3.RootElement.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView3.ShowGroupPanel = False
			Me.radGridView3.Size = New Size(607, 418)
			Me.radGridView3.TabIndex = 1
			Me.radGridView3.Text = "radGridViewPreview"
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.northwindDataSet
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButtonClear)
			Me.radGroupBox1.Controls.Add(Me.textBox1)
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.HeaderText = "Events"
			Me.radGroupBox1.Location = New Point(10, 91)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 235)
			Me.radGroupBox1.TabIndex = 9
			Me.radGroupBox1.Text = "Events"
			' 
			' radButtonClear
			' 
			Me.radButtonClear.Location = New Point(23, 197)
			Me.radButtonClear.Name = "radButtonClear"
			Me.radButtonClear.Size = New Size(134, 23)
			Me.radButtonClear.TabIndex = 10
			Me.radButtonClear.Text = "Clear"

			' 
			' textBox1
			' 
			Me.textBox1.AutoSize = False
			Me.textBox1.Location = New Point(23, 22)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(134, 169)
			Me.textBox1.TabIndex = 0
			Me.textBox1.TabStop = False

			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
            Me.radPageView1.Location = New Point(20, 20)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(640, 466)
			Me.radPageView1.TabIndex = 9
			Me.radPageView1.Text = "radPageView1"
			' 
			' radPageViewPage1
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage1.Controls.Add(Me.radGridView1)
			Me.radPageViewPage1.Location = New Point(10, 37)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(619, 418)
			Me.radPageViewPage1.Text = "Products"
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = Color.Transparent
			Me.radGridView1.Cursor = Cursors.Default
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.ImeMode = ImeMode.NoControl
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' radGridView1
			' 
			gridViewDecimalColumn59.DataType = GetType(Integer)
			gridViewDecimalColumn59.FieldName = "ProductID"
			gridViewDecimalColumn59.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn59.HeaderText = "ProductID"
			gridViewDecimalColumn59.IsAutoGenerated = True
			gridViewDecimalColumn59.IsVisible = False
			gridViewDecimalColumn59.Name = "ProductID"
			gridViewTextBoxColumn104.FieldName = "ProductName"
			gridViewTextBoxColumn104.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn104.HeaderText = "ProductName"
			gridViewTextBoxColumn104.IsAutoGenerated = True
			gridViewTextBoxColumn104.Name = "ProductName"
			gridViewDecimalColumn60.DataType = GetType(Integer)
			gridViewDecimalColumn60.FieldName = "SupplierID"
			gridViewDecimalColumn60.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn60.HeaderText = "SupplierID"
			gridViewDecimalColumn60.IsAutoGenerated = True
			gridViewDecimalColumn60.IsVisible = False
			gridViewDecimalColumn60.Name = "SupplierID"
			gridViewDecimalColumn61.DataType = GetType(Integer)
			gridViewDecimalColumn61.FieldName = "CategoryID"
			gridViewDecimalColumn61.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn61.HeaderText = "CategoryID"
			gridViewDecimalColumn61.IsAutoGenerated = True
			gridViewDecimalColumn61.IsVisible = False
			gridViewDecimalColumn61.Name = "CategoryID"
			gridViewTextBoxColumn105.FieldName = "QuantityPerUnit"
			gridViewTextBoxColumn105.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewTextBoxColumn105.HeaderText = "QuantityPerUnit"
			gridViewTextBoxColumn105.IsAutoGenerated = True
			gridViewTextBoxColumn105.Name = "QuantityPerUnit"
			gridViewDecimalColumn62.FieldName = "UnitPrice"
			gridViewDecimalColumn62.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn62.HeaderText = "UnitPrice"
			gridViewDecimalColumn62.IsAutoGenerated = True
			gridViewDecimalColumn62.Name = "UnitPrice"
			gridViewDecimalColumn63.DataType = GetType(Short)
			gridViewDecimalColumn63.FieldName = "UnitsInStock"
			gridViewDecimalColumn63.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn63.HeaderText = "UnitsInStock"
			gridViewDecimalColumn63.IsAutoGenerated = True
			gridViewDecimalColumn63.IsVisible = False
			gridViewDecimalColumn63.Name = "UnitsInStock"
			gridViewDecimalColumn64.DataType = GetType(Short)
			gridViewDecimalColumn64.FieldName = "UnitsOnOrder"
			gridViewDecimalColumn64.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn64.HeaderText = "UnitsOnOrder"
			gridViewDecimalColumn64.IsAutoGenerated = True
			gridViewDecimalColumn64.IsVisible = False
			gridViewDecimalColumn64.Name = "UnitsOnOrder"
			gridViewDecimalColumn65.DataType = GetType(Short)
			gridViewDecimalColumn65.FieldName = "ReorderLevel"
			gridViewDecimalColumn65.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewDecimalColumn65.HeaderText = "ReorderLevel"
			gridViewDecimalColumn65.IsAutoGenerated = True
			gridViewDecimalColumn65.IsVisible = False
			gridViewDecimalColumn65.Name = "ReorderLevel"
			gridViewCheckBoxColumn5.FieldName = "Discontinued"
			gridViewCheckBoxColumn5.FormatInfo = New System.Globalization.CultureInfo("")
			gridViewCheckBoxColumn5.HeaderText = "Discontinued"
			gridViewCheckBoxColumn5.IsAutoGenerated = True
			gridViewCheckBoxColumn5.IsVisible = False
			gridViewCheckBoxColumn5.Name = "Discontinued"
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn59, gridViewTextBoxColumn104, gridViewDecimalColumn60, gridViewDecimalColumn61, gridViewTextBoxColumn105, gridViewDecimalColumn62, gridViewDecimalColumn63, gridViewDecimalColumn64, gridViewDecimalColumn65, gridViewCheckBoxColumn5})
			Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView1.RightToLeft = RightToLeft.No
			' 
			' 
			' 
			Me.radGridView1.RootElement.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New Size(619, 418)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridViewPreview"
			' 
			' radPageViewPage2
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage2.Controls.Add(Me.radGridView2)
			Me.radPageViewPage2.Location = New Point(10, 37)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(607, 418)
			Me.radPageViewPage2.Text = "Company Info"
			' 
			' radPageViewPage3
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage3.Controls.Add(Me.radGridView3)
			Me.radPageViewPage3.Location = New Point(10, 37)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(607, 418)
			Me.radPageViewPage3.Text = "Orders"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(91, 18)
			Me.radLabel1.TabIndex = 10
			Me.radLabel1.Text = "Item Drag Mode:"
			' 
			' dragModeCombo
			' 
			Me.dragModeCombo.Anchor = AnchorStyles.Top
			Me.dragModeCombo.DropDownAnimationEnabled = False
			Me.dragModeCombo.Location = New Point(10, 59)
			Me.dragModeCombo.Name = "dragModeCombo"
			Me.dragModeCombo.Size = New Size(180, 20)
			Me.dragModeCombo.TabIndex = 11
			Me.dragModeCombo.Text = "radDropDownList1"
			Me.dragModeCombo.DropDownStyle = RadDropDownStyle.DropDownList

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1029, 672)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dragModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As RadGroupBox
		Private textBox1 As RadTextBox
		Private radButtonClear As RadButton
		Private productsBindingSource As BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private radGridView2 As RadGridView
		Private productsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter
		Private employeesBindingSource As BindingSource
		Private radGridView3 As RadGridView
		Private ordersBindingSource As BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private ordersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As RadPageViewPage
		Private radPageViewPage2 As RadPageViewPage
		Private radPageViewPage3 As RadPageViewPage
		Private radGridView1 As RadGridView
		Private dragModeCombo As RadDropDownList
		Private radLabel1 As RadLabel
	End Class
End Namespace
