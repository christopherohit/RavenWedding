Namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim tableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim gridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim gridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim gridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn21 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn22 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn23 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn24 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim gridViewTextBoxColumn25 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim tableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.openOrdersGroupBox = New Telerik.WinControls.UI.RadGroupBox()
            Me.openOrdersScrollablePanel = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.orderDetailsGroupBox = New Telerik.WinControls.UI.RadGroupBox()
            Me.orderDetailsTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.clearButton = New Telerik.WinControls.UI.RadButton()
            Me.productsMultiColumnComboBox = New Telerik.WinControls.UI.RadMultiColumnComboBox()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.northwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.productsLabel = New Telerik.WinControls.UI.RadLabel()
            Me.customerMultiColumnComboBox = New Telerik.WinControls.UI.RadMultiColumnComboBox()
            Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeeLabel = New Telerik.WinControls.UI.RadLabel()
            Me.employeeMultiColumnComboBox = New Telerik.WinControls.UI.RadMultiColumnComboBox()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.customerLabel = New Telerik.WinControls.UI.RadLabel()
            Me.quantityLabel = New Telerik.WinControls.UI.RadLabel()
            Me.quantitySpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            Me.totalLabel = New Telerik.WinControls.UI.RadLabel()
            Me.submitButton = New Telerik.WinControls.UI.RadButton()
            Me.createNewOrderLabel = New Telerik.WinControls.UI.RadLabel()
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
            Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter()
            Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.order_DetailsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.openOrdersGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.openOrdersGroupBox.SuspendLayout()
            CType(Me.openOrdersScrollablePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.openOrdersScrollablePanel.SuspendLayout()
            CType(Me.orderDetailsGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.orderDetailsGroupBox.SuspendLayout()
            Me.orderDetailsTableLayoutPanel.SuspendLayout()
            CType(Me.clearButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsMultiColumnComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerMultiColumnComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeMultiColumnComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.quantityLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.quantitySpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.totalLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.submitButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.createNewOrderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1808, 1)
            Me.radPanel1.Controls.Add(Me.openOrdersGroupBox)
            Me.radPanel1.Controls.Add(Me.orderDetailsGroupBox)
            Me.radPanel1.Controls.Add(Me.createNewOrderLabel)
            Me.radPanel1.Location = New System.Drawing.Point(30, 30)
            Me.radPanel1.Margin = New System.Windows.Forms.Padding(30)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(791, 550)
            Me.radPanel1.TabIndex = 1
            Me.openOrdersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.openOrdersGroupBox.Controls.Add(Me.openOrdersScrollablePanel)
            Me.openOrdersGroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25F)
            Me.openOrdersGroupBox.HeaderText = "Open Orders"
            Me.openOrdersGroupBox.Location = New System.Drawing.Point(322, 54)
            Me.openOrdersGroupBox.Margin = New System.Windows.Forms.Padding(11)
            Me.openOrdersGroupBox.Name = "openOrdersGroupBox"
            Me.openOrdersGroupBox.Padding = New System.Windows.Forms.Padding(2, 40, 2, 2)
            Me.openOrdersGroupBox.Size = New System.Drawing.Size(458, 485)
            Me.openOrdersGroupBox.TabIndex = 2
            Me.openOrdersGroupBox.Text = "Open Orders"
            CType(Me.openOrdersGroupBox.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = New System.Windows.Forms.Padding(2, 40, 2, 2)
            CType(Me.openOrdersGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Text = "Open Orders"
            CType(Me.openOrdersGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
            CType(Me.openOrdersGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(5)
            CType(Me.openOrdersGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.openOrdersScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.openOrdersScrollablePanel.Location = New System.Drawing.Point(2, 40)
            Me.openOrdersScrollablePanel.Name = "openOrdersScrollablePanel"
            Me.openOrdersScrollablePanel.Padding = New System.Windows.Forms.Padding(0)
            Me.openOrdersScrollablePanel.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.openOrdersScrollablePanel.PanelContainer.Size = New System.Drawing.Size(454, 443)
            Me.openOrdersScrollablePanel.RootElement.EnableElementShadow = False
            Me.openOrdersScrollablePanel.Size = New System.Drawing.Size(454, 443)
            Me.openOrdersScrollablePanel.TabIndex = 0
            CType(Me.openOrdersScrollablePanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.orderDetailsGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.orderDetailsGroupBox.Controls.Add(Me.orderDetailsTableLayoutPanel)
            Me.orderDetailsGroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25F)
            Me.orderDetailsGroupBox.HeaderText = "Order Details"
            Me.orderDetailsGroupBox.Location = New System.Drawing.Point(11, 54)
            Me.orderDetailsGroupBox.Margin = New System.Windows.Forms.Padding(11, 11, 0, 11)
            Me.orderDetailsGroupBox.Name = "orderDetailsGroupBox"
            Me.orderDetailsGroupBox.Padding = New System.Windows.Forms.Padding(7, 40, 7, 7)
            Me.orderDetailsGroupBox.Size = New System.Drawing.Size(300, 485)
            Me.orderDetailsGroupBox.TabIndex = 1
            Me.orderDetailsGroupBox.Text = "Order Details"
            CType(Me.orderDetailsGroupBox.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = New System.Windows.Forms.Padding(7, 40, 7, 7)
            CType(Me.orderDetailsGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Text = "Order Details"
            CType(Me.orderDetailsGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
            CType(Me.orderDetailsGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(5)
            CType(Me.orderDetailsGroupBox.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.orderDetailsTableLayoutPanel.ColumnCount = 3
            Me.orderDetailsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4717F))
            Me.orderDetailsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5283F))
            Me.orderDetailsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0F))
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.clearButton, 2, 9)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.productsMultiColumnComboBox, 0, 5)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.productsLabel, 0, 4)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.customerMultiColumnComboBox, 0, 3)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.employeeLabel, 0, 0)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.employeeMultiColumnComboBox, 0, 1)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.customerLabel, 0, 2)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.quantityLabel, 0, 6)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.quantitySpinEditor, 0, 7)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.radSeparator1, 0, 8)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.totalLabel, 0, 9)
            Me.orderDetailsTableLayoutPanel.Controls.Add(Me.submitButton, 1, 9)
            Me.orderDetailsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.orderDetailsTableLayoutPanel.Location = New System.Drawing.Point(7, 40)
            Me.orderDetailsTableLayoutPanel.Name = "orderDetailsTableLayoutPanel"
            Me.orderDetailsTableLayoutPanel.RowCount = 11
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.orderDetailsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.orderDetailsTableLayoutPanel.Size = New System.Drawing.Size(286, 438)
            Me.orderDetailsTableLayoutPanel.TabIndex = 0
            Me.clearButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.clearButton.Location = New System.Drawing.Point(215, 337)
            Me.clearButton.Name = "clearButton"
            Me.clearButton.Size = New System.Drawing.Size(68, 24)
            Me.clearButton.TabIndex = 10
            Me.clearButton.Text = "Clear"
            AddHandler Me.clearButton.Click, New System.EventHandler(AddressOf Me.ClearButton_Click)
            Me.productsMultiColumnComboBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.productsMultiColumnComboBox.AutoSizeDropDownToBestFit = True
            Me.orderDetailsTableLayoutPanel.SetColumnSpan(Me.productsMultiColumnComboBox, 3)
            Me.productsMultiColumnComboBox.DataSource = Me.productsBindingSource
            Me.productsMultiColumnComboBox.DisplayMember = "ProductName"
            Me.productsMultiColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window
            Me.productsMultiColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.productsMultiColumnComboBox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.productsMultiColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
            Me.productsMultiColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.productsMultiColumnComboBox.EditorControl.Location = New System.Drawing.Point(0, 0)
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = False
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = False
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = False
            gridViewDecimalColumn1.DataType = GetType(Integer)
            gridViewDecimalColumn1.EnableExpressionEditor = False
            gridViewDecimalColumn1.FieldName = "ProductID"
            gridViewDecimalColumn1.HeaderText = "ProductID"
            gridViewDecimalColumn1.IsAutoGenerated = True
            gridViewDecimalColumn1.IsVisible = False
            gridViewDecimalColumn1.Name = "ProductID"
            gridViewTextBoxColumn1.EnableExpressionEditor = False
            gridViewTextBoxColumn1.FieldName = "ProductName"
            gridViewTextBoxColumn1.HeaderText = "Product Name"
            gridViewTextBoxColumn1.IsAutoGenerated = True
            gridViewTextBoxColumn1.Name = "ProductName"
            gridViewTextBoxColumn1.Width = 92
            gridViewDecimalColumn2.DataType = GetType(Integer)
            gridViewDecimalColumn2.EnableExpressionEditor = False
            gridViewDecimalColumn2.FieldName = "SupplierID"
            gridViewDecimalColumn2.HeaderText = "SupplierID"
            gridViewDecimalColumn2.IsAutoGenerated = True
            gridViewDecimalColumn2.IsVisible = False
            gridViewDecimalColumn2.Name = "SupplierID"
            gridViewDecimalColumn3.DataType = GetType(Integer)
            gridViewDecimalColumn3.EnableExpressionEditor = False
            gridViewDecimalColumn3.FieldName = "CategoryID"
            gridViewDecimalColumn3.HeaderText = "CategoryID"
            gridViewDecimalColumn3.IsAutoGenerated = True
            gridViewDecimalColumn3.IsVisible = False
            gridViewDecimalColumn3.Name = "CategoryID"
            gridViewDecimalColumn4.EnableExpressionEditor = False
            gridViewDecimalColumn4.FieldName = "UnitPrice"
            gridViewDecimalColumn4.HeaderText = "Unit Price"
            gridViewDecimalColumn4.IsAutoGenerated = True
            gridViewDecimalColumn4.Name = "UnitPrice"
            gridViewDecimalColumn4.Width = 89
            gridViewDecimalColumn5.DataType = GetType(Short)
            gridViewDecimalColumn5.EnableExpressionEditor = False
            gridViewDecimalColumn5.FieldName = "UnitsInStock"
            gridViewDecimalColumn5.HeaderText = "Units in Stock"
            gridViewDecimalColumn5.IsAutoGenerated = True
            gridViewDecimalColumn5.Name = "UnitsInStock"
            gridViewDecimalColumn5.Width = 77
            gridViewTextBoxColumn2.EnableExpressionEditor = False
            gridViewTextBoxColumn2.FieldName = "QuantityPerUnit"
            gridViewTextBoxColumn2.HeaderText = "QuantityPerUnit"
            gridViewTextBoxColumn2.IsAutoGenerated = True
            gridViewTextBoxColumn2.IsVisible = False
            gridViewTextBoxColumn2.Name = "QuantityPerUnit"
            gridViewTextBoxColumn2.Width = 87
            gridViewDecimalColumn6.DataType = GetType(Short)
            gridViewDecimalColumn6.EnableExpressionEditor = False
            gridViewDecimalColumn6.FieldName = "UnitsOnOrder"
            gridViewDecimalColumn6.HeaderText = "Units on Order"
            gridViewDecimalColumn6.IsAutoGenerated = True
            gridViewDecimalColumn6.Name = "UnitsOnOrder"
            gridViewDecimalColumn6.Width = 86
            gridViewDecimalColumn7.DataType = GetType(Short)
            gridViewDecimalColumn7.EnableExpressionEditor = False
            gridViewDecimalColumn7.FieldName = "ReorderLevel"
            gridViewDecimalColumn7.HeaderText = "ReorderLevel"
            gridViewDecimalColumn7.IsAutoGenerated = True
            gridViewDecimalColumn7.IsVisible = False
            gridViewDecimalColumn7.Name = "ReorderLevel"
            gridViewCheckBoxColumn1.EnableExpressionEditor = False
            gridViewCheckBoxColumn1.FieldName = "Discontinued"
            gridViewCheckBoxColumn1.HeaderText = "Discontinued"
            gridViewCheckBoxColumn1.IsAutoGenerated = True
            gridViewCheckBoxColumn1.IsVisible = False
            gridViewCheckBoxColumn1.MinWidth = 20
            gridViewCheckBoxColumn1.Name = "Discontinued"
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewDecimalColumn2, gridViewDecimalColumn3, gridViewDecimalColumn4, gridViewDecimalColumn5, gridViewTextBoxColumn2, gridViewDecimalColumn6, gridViewDecimalColumn7, gridViewCheckBoxColumn1})
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.DataSource = Me.productsBindingSource
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = False
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.MultiSelect = True
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = False
            Me.productsMultiColumnComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.productsMultiColumnComboBox.EditorControl.Name = "NestedRadGridView"
            Me.productsMultiColumnComboBox.EditorControl.[ReadOnly] = True
            Me.productsMultiColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.productsMultiColumnComboBox.EditorControl.ShowGroupPanel = False
            Me.productsMultiColumnComboBox.EditorControl.Size = New System.Drawing.Size(240, 150)
            Me.productsMultiColumnComboBox.EditorControl.TabIndex = 0
            Me.productsMultiColumnComboBox.Location = New System.Drawing.Point(3, 200)
            Me.productsMultiColumnComboBox.Name = "productsMultiColumnComboBox"
            Me.productsMultiColumnComboBox.NullText = "Select the products for this order..."
            Me.productsMultiColumnComboBox.Size = New System.Drawing.Size(280, 20)
            Me.productsMultiColumnComboBox.TabIndex = 4
            Me.productsMultiColumnComboBox.TabStop = False
            Me.productsMultiColumnComboBox.ValueMember = "ProductID"
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.northwindDataSetBindingSource
            Me.northwindDataSetBindingSource.DataSource = Me.northwindDataSet
            Me.northwindDataSetBindingSource.Position = 0
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.productsLabel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.productsLabel.Location = New System.Drawing.Point(0, 168)
            Me.productsLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.productsLabel.Name = "productsLabel"
            Me.productsLabel.Size = New System.Drawing.Size(53, 18)
            Me.productsLabel.TabIndex = 3
            Me.productsLabel.Text = "Products:"
            Me.customerMultiColumnComboBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.customerMultiColumnComboBox.AutoSizeDropDownToBestFit = True
            Me.orderDetailsTableLayoutPanel.SetColumnSpan(Me.customerMultiColumnComboBox, 3)
            Me.customerMultiColumnComboBox.DataSource = Me.customersBindingSource
            Me.customerMultiColumnComboBox.DisplayMember = "ContactName"
            Me.customerMultiColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window
            Me.customerMultiColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.customerMultiColumnComboBox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.customerMultiColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
            Me.customerMultiColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.customerMultiColumnComboBox.EditorControl.Location = New System.Drawing.Point(0, 0)
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = False
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = False
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = False
            gridViewTextBoxColumn3.EnableExpressionEditor = False
            gridViewTextBoxColumn3.FieldName = "ContactName"
            gridViewTextBoxColumn3.HeaderText = "Contact"
            gridViewTextBoxColumn3.IsAutoGenerated = True
            gridViewTextBoxColumn3.Name = "ContactName"
            gridViewTextBoxColumn3.Width = 93
            gridViewTextBoxColumn4.EnableExpressionEditor = False
            gridViewTextBoxColumn4.FieldName = "CompanyName"
            gridViewTextBoxColumn4.HeaderText = "Company"
            gridViewTextBoxColumn4.IsAutoGenerated = True
            gridViewTextBoxColumn4.Name = "CompanyName"
            gridViewTextBoxColumn4.Width = 91
            gridViewTextBoxColumn5.EnableExpressionEditor = False
            gridViewTextBoxColumn5.FieldName = "Region"
            gridViewTextBoxColumn5.HeaderText = "Region"
            gridViewTextBoxColumn5.IsAutoGenerated = True
            gridViewTextBoxColumn5.Name = "Region"
            gridViewTextBoxColumn6.EnableExpressionEditor = False
            gridViewTextBoxColumn6.FieldName = "City"
            gridViewTextBoxColumn6.HeaderText = "City"
            gridViewTextBoxColumn6.IsAutoGenerated = True
            gridViewTextBoxColumn6.Name = "City"
            gridViewTextBoxColumn7.EnableExpressionEditor = False
            gridViewTextBoxColumn7.FieldName = "Address"
            gridViewTextBoxColumn7.HeaderText = "Address"
            gridViewTextBoxColumn7.IsAutoGenerated = True
            gridViewTextBoxColumn7.Name = "Address"
            gridViewTextBoxColumn8.EnableExpressionEditor = False
            gridViewTextBoxColumn8.FieldName = "PostalCode"
            gridViewTextBoxColumn8.HeaderText = "PostalCode"
            gridViewTextBoxColumn8.IsAutoGenerated = True
            gridViewTextBoxColumn8.IsVisible = False
            gridViewTextBoxColumn8.Name = "PostalCode"
            gridViewTextBoxColumn9.EnableExpressionEditor = False
            gridViewTextBoxColumn9.FieldName = "Country"
            gridViewTextBoxColumn9.HeaderText = "Country"
            gridViewTextBoxColumn9.IsAutoGenerated = True
            gridViewTextBoxColumn9.IsVisible = False
            gridViewTextBoxColumn9.Name = "Country"
            gridViewTextBoxColumn10.EnableExpressionEditor = False
            gridViewTextBoxColumn10.FieldName = "CustomerID"
            gridViewTextBoxColumn10.HeaderText = "CustomerID"
            gridViewTextBoxColumn10.IsAutoGenerated = True
            gridViewTextBoxColumn10.IsVisible = False
            gridViewTextBoxColumn10.Name = "CustomerID"
            gridViewTextBoxColumn11.EnableExpressionEditor = False
            gridViewTextBoxColumn11.FieldName = "ContactTitle"
            gridViewTextBoxColumn11.HeaderText = "ContactTitle"
            gridViewTextBoxColumn11.IsAutoGenerated = True
            gridViewTextBoxColumn11.IsVisible = False
            gridViewTextBoxColumn11.Name = "ContactTitle"
            gridViewTextBoxColumn12.EnableExpressionEditor = False
            gridViewTextBoxColumn12.FieldName = "Phone"
            gridViewTextBoxColumn12.HeaderText = "Phone"
            gridViewTextBoxColumn12.IsAutoGenerated = True
            gridViewTextBoxColumn12.IsVisible = False
            gridViewTextBoxColumn12.Name = "Phone"
            gridViewTextBoxColumn13.EnableExpressionEditor = False
            gridViewTextBoxColumn13.FieldName = "Fax"
            gridViewTextBoxColumn13.HeaderText = "Fax"
            gridViewTextBoxColumn13.IsAutoGenerated = True
            gridViewTextBoxColumn13.IsVisible = False
            gridViewTextBoxColumn13.Name = "Fax"
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewTextBoxColumn8, gridViewTextBoxColumn9, gridViewTextBoxColumn10, gridViewTextBoxColumn11, gridViewTextBoxColumn12, gridViewTextBoxColumn13})
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.DataSource = Me.customersBindingSource
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = False
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = False
            Me.customerMultiColumnComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2
            Me.customerMultiColumnComboBox.EditorControl.Name = "NestedRadGridView"
            Me.customerMultiColumnComboBox.EditorControl.[ReadOnly] = True
            Me.customerMultiColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.customerMultiColumnComboBox.EditorControl.ShowGroupPanel = False
            Me.customerMultiColumnComboBox.EditorControl.Size = New System.Drawing.Size(240, 150)
            Me.customerMultiColumnComboBox.EditorControl.TabIndex = 0
            Me.customerMultiColumnComboBox.Location = New System.Drawing.Point(3, 123)
            Me.customerMultiColumnComboBox.Name = "customerMultiColumnComboBox"
            Me.customerMultiColumnComboBox.NullText = "Select a customer for this order..."
            Me.customerMultiColumnComboBox.Size = New System.Drawing.Size(280, 20)
            Me.customerMultiColumnComboBox.TabIndex = 2
            Me.customerMultiColumnComboBox.TabStop = False
            Me.customerMultiColumnComboBox.ValueMember = "CustomerID"
            AddHandler Me.customerMultiColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.CustomerMultiColumnComboBox_SelectedIndexChanged)
            Me.customersBindingSource.DataMember = "Customers"
            Me.customersBindingSource.DataSource = Me.northwindDataSetBindingSource
            Me.employeeLabel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.employeeLabel.Location = New System.Drawing.Point(0, 14)
            Me.employeeLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.employeeLabel.Name = "employeeLabel"
            Me.employeeLabel.Size = New System.Drawing.Size(57, 18)
            Me.employeeLabel.TabIndex = 0
            Me.employeeLabel.Text = "Employee:"
            Me.employeeMultiColumnComboBox.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.employeeMultiColumnComboBox.AutoSizeDropDownToBestFit = True
            Me.orderDetailsTableLayoutPanel.SetColumnSpan(Me.employeeMultiColumnComboBox, 3)
            Me.employeeMultiColumnComboBox.DataSource = Me.employeesBindingSource
            Me.employeeMultiColumnComboBox.DisplayMember = "LastName"
            Me.employeeMultiColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window
            Me.employeeMultiColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.employeeMultiColumnComboBox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.employeeMultiColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
            Me.employeeMultiColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.employeeMultiColumnComboBox.EditorControl.Location = New System.Drawing.Point(0, 0)
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = False
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = False
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = False
            gridViewDecimalColumn8.DataType = GetType(Integer)
            gridViewDecimalColumn8.EnableExpressionEditor = False
            gridViewDecimalColumn8.FieldName = "EmployeeID"
            gridViewDecimalColumn8.HeaderText = "EmployeeID"
            gridViewDecimalColumn8.IsAutoGenerated = True
            gridViewDecimalColumn8.IsVisible = False
            gridViewDecimalColumn8.Name = "EmployeeID"
            gridViewTextBoxColumn14.EnableExpressionEditor = False
            gridViewTextBoxColumn14.FieldName = "FirstName"
            gridViewTextBoxColumn14.HeaderText = "First Name"
            gridViewTextBoxColumn14.IsAutoGenerated = True
            gridViewTextBoxColumn14.Name = "FirstName"
            gridViewTextBoxColumn14.Width = 76
            gridViewTextBoxColumn15.EnableExpressionEditor = False
            gridViewTextBoxColumn15.FieldName = "LastName"
            gridViewTextBoxColumn15.HeaderText = "Last Name"
            gridViewTextBoxColumn15.IsAutoGenerated = True
            gridViewTextBoxColumn15.Name = "LastName"
            gridViewTextBoxColumn15.Width = 94
            gridViewTextBoxColumn16.EnableExpressionEditor = False
            gridViewTextBoxColumn16.FieldName = "Title"
            gridViewTextBoxColumn16.HeaderText = "Title"
            gridViewTextBoxColumn16.IsAutoGenerated = True
            gridViewTextBoxColumn16.Name = "Title"
            gridViewTextBoxColumn17.EnableExpressionEditor = False
            gridViewTextBoxColumn17.FieldName = "TitleOfCourtesy"
            gridViewTextBoxColumn17.HeaderText = "TitleOfCourtesy"
            gridViewTextBoxColumn17.IsAutoGenerated = True
            gridViewTextBoxColumn17.IsVisible = False
            gridViewTextBoxColumn17.Name = "TitleOfCourtesy"
            gridViewDateTimeColumn1.EnableExpressionEditor = False
            gridViewDateTimeColumn1.FieldName = "BirthDate"
            gridViewDateTimeColumn1.HeaderText = "BirthDate"
            gridViewDateTimeColumn1.IsAutoGenerated = True
            gridViewDateTimeColumn1.IsVisible = False
            gridViewDateTimeColumn1.Name = "BirthDate"
            gridViewDateTimeColumn2.EnableExpressionEditor = False
            gridViewDateTimeColumn2.FieldName = "HireDate"
            gridViewDateTimeColumn2.HeaderText = "HireDate"
            gridViewDateTimeColumn2.IsAutoGenerated = True
            gridViewDateTimeColumn2.IsVisible = False
            gridViewDateTimeColumn2.Name = "HireDate"
            gridViewTextBoxColumn18.EnableExpressionEditor = False
            gridViewTextBoxColumn18.FieldName = "Address"
            gridViewTextBoxColumn18.HeaderText = "Address"
            gridViewTextBoxColumn18.IsAutoGenerated = True
            gridViewTextBoxColumn18.IsVisible = False
            gridViewTextBoxColumn18.Name = "Address"
            gridViewTextBoxColumn19.EnableExpressionEditor = False
            gridViewTextBoxColumn19.FieldName = "City"
            gridViewTextBoxColumn19.HeaderText = "City"
            gridViewTextBoxColumn19.IsAutoGenerated = True
            gridViewTextBoxColumn19.Name = "City"
            gridViewTextBoxColumn20.EnableExpressionEditor = False
            gridViewTextBoxColumn20.FieldName = "Region"
            gridViewTextBoxColumn20.HeaderText = "Region"
            gridViewTextBoxColumn20.IsAutoGenerated = True
            gridViewTextBoxColumn20.IsVisible = False
            gridViewTextBoxColumn20.Name = "Region"
            gridViewTextBoxColumn21.EnableExpressionEditor = False
            gridViewTextBoxColumn21.FieldName = "PostalCode"
            gridViewTextBoxColumn21.HeaderText = "PostalCode"
            gridViewTextBoxColumn21.IsAutoGenerated = True
            gridViewTextBoxColumn21.IsVisible = False
            gridViewTextBoxColumn21.Name = "PostalCode"
            gridViewTextBoxColumn22.EnableExpressionEditor = False
            gridViewTextBoxColumn22.FieldName = "Country"
            gridViewTextBoxColumn22.HeaderText = "Country"
            gridViewTextBoxColumn22.IsAutoGenerated = True
            gridViewTextBoxColumn22.Name = "Country"
            gridViewTextBoxColumn23.EnableExpressionEditor = False
            gridViewTextBoxColumn23.FieldName = "HomePhone"
            gridViewTextBoxColumn23.HeaderText = "HomePhone"
            gridViewTextBoxColumn23.IsAutoGenerated = True
            gridViewTextBoxColumn23.IsVisible = False
            gridViewTextBoxColumn23.Name = "HomePhone"
            gridViewTextBoxColumn24.EnableExpressionEditor = False
            gridViewTextBoxColumn24.FieldName = "Extension"
            gridViewTextBoxColumn24.HeaderText = "Extension"
            gridViewTextBoxColumn24.IsAutoGenerated = True
            gridViewTextBoxColumn24.IsVisible = False
            gridViewTextBoxColumn24.Name = "Extension"
            gridViewImageColumn1.DataType = GetType(Byte())
            gridViewImageColumn1.EnableExpressionEditor = False
            gridViewImageColumn1.FieldName = "Photo"
            gridViewImageColumn1.HeaderText = "Photo"
            gridViewImageColumn1.IsAutoGenerated = True
            gridViewImageColumn1.IsVisible = False
            gridViewImageColumn1.Name = "Photo"
            gridViewTextBoxColumn25.EnableExpressionEditor = False
            gridViewTextBoxColumn25.FieldName = "Notes"
            gridViewTextBoxColumn25.HeaderText = "Notes"
            gridViewTextBoxColumn25.IsAutoGenerated = True
            gridViewTextBoxColumn25.IsVisible = False
            gridViewTextBoxColumn25.Name = "Notes"
            gridViewDecimalColumn9.DataType = GetType(Integer)
            gridViewDecimalColumn9.EnableExpressionEditor = False
            gridViewDecimalColumn9.FieldName = "ReportsTo"
            gridViewDecimalColumn9.HeaderText = "ReportsTo"
            gridViewDecimalColumn9.IsAutoGenerated = True
            gridViewDecimalColumn9.IsVisible = False
            gridViewDecimalColumn9.Name = "ReportsTo"
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewDecimalColumn8, gridViewTextBoxColumn14, gridViewTextBoxColumn15, gridViewTextBoxColumn16, gridViewTextBoxColumn17, gridViewDateTimeColumn1, gridViewDateTimeColumn2, gridViewTextBoxColumn18, gridViewTextBoxColumn19, gridViewTextBoxColumn20, gridViewTextBoxColumn21, gridViewTextBoxColumn22, gridViewTextBoxColumn23, gridViewTextBoxColumn24, gridViewImageColumn1, gridViewTextBoxColumn25, gridViewDecimalColumn9})
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.DataSource = Me.employeesBindingSource
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = False
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = False
            Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition3
            Me.employeeMultiColumnComboBox.EditorControl.Name = "NestedRadGridView"
            Me.employeeMultiColumnComboBox.EditorControl.[ReadOnly] = True
            Me.employeeMultiColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.employeeMultiColumnComboBox.EditorControl.ShowGroupPanel = False
            Me.employeeMultiColumnComboBox.EditorControl.Size = New System.Drawing.Size(240, 150)
            Me.employeeMultiColumnComboBox.EditorControl.TabIndex = 0
            Me.employeeMultiColumnComboBox.Location = New System.Drawing.Point(3, 46)
            Me.employeeMultiColumnComboBox.Name = "employeeMultiColumnComboBox"
            Me.employeeMultiColumnComboBox.NullText = "Select an employee to handle the order..."
            Me.employeeMultiColumnComboBox.Size = New System.Drawing.Size(280, 20)
            Me.employeeMultiColumnComboBox.TabIndex = 1
            Me.employeeMultiColumnComboBox.TabStop = False
            Me.employeeMultiColumnComboBox.ValueMember = "EmployeeID"
            AddHandler Me.employeeMultiColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.EmployeeMultiColumnComboBox_SelectedIndexChanged)
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.northwindDataSetBindingSource
            Me.customerLabel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.customerLabel.Location = New System.Drawing.Point(0, 91)
            Me.customerLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.customerLabel.Name = "customerLabel"
            Me.customerLabel.Size = New System.Drawing.Size(57, 18)
            Me.customerLabel.TabIndex = 2
            Me.customerLabel.Text = "Customer:"
            Me.quantityLabel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.quantityLabel.Location = New System.Drawing.Point(0, 245)
            Me.quantityLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.quantityLabel.Name = "quantityLabel"
            Me.quantityLabel.Size = New System.Drawing.Size(52, 18)
            Me.quantityLabel.TabIndex = 5
            Me.quantityLabel.Text = "Quantity:"
            Me.quantitySpinEditor.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.quantitySpinEditor.Location = New System.Drawing.Point(3, 277)
            Me.quantitySpinEditor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.quantitySpinEditor.Name = "quantitySpinEditor"
            Me.quantitySpinEditor.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.quantitySpinEditor.Size = New System.Drawing.Size(101, 20)
            Me.quantitySpinEditor.TabIndex = 6
            Me.quantitySpinEditor.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.quantitySpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.QuantitySpinEditor_ValueChanged)
            Me.radSeparator1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.orderDetailsTableLayoutPanel.SetColumnSpan(Me.radSeparator1, 3)
            Me.radSeparator1.Location = New System.Drawing.Point(3, 316)
            Me.radSeparator1.Name = "radSeparator1"
            Me.radSeparator1.Size = New System.Drawing.Size(280, 4)
            Me.radSeparator1.TabIndex = 7
            Me.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.totalLabel.Location = New System.Drawing.Point(0, 340)
            Me.totalLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.totalLabel.Name = "totalLabel"
            Me.totalLabel.Size = New System.Drawing.Size(73, 17)
            Me.totalLabel.TabIndex = 8
            Me.totalLabel.Text = "<html>Total: <strong>$ 14.00</strong></html>"
            Me.submitButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.submitButton.Location = New System.Drawing.Point(110, 337)
            Me.submitButton.Name = "submitButton"
            Me.submitButton.Size = New System.Drawing.Size(99, 24)
            Me.submitButton.TabIndex = 9
            Me.submitButton.Text = "Submit"
            AddHandler Me.submitButton.Click, New System.EventHandler(AddressOf Me.SubmitButton_Click)
            Me.createNewOrderLabel.AutoSize = False
            Me.createNewOrderLabel.BackColor = System.Drawing.Color.Black
            Me.createNewOrderLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.createNewOrderLabel.Font = New System.Drawing.Font("Segoe UI", 13.5F)
            Me.createNewOrderLabel.ForeColor = System.Drawing.Color.White
            Me.createNewOrderLabel.Location = New System.Drawing.Point(0, 0)
            Me.createNewOrderLabel.Name = "createNewOrderLabel"
            Me.createNewOrderLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.createNewOrderLabel.Size = New System.Drawing.Size(791, 40)
            Me.createNewOrderLabel.TabIndex = 0
            Me.createNewOrderLabel.Text = "Create a New Order"
            Me.employeesTableAdapter.ClearBeforeFill = True
            Me.customersTableAdapter.ClearBeforeFill = True
            Me.productsTableAdapter.ClearBeforeFill = True
            Me.orderDetailsBindingSource.DataMember = "Order Details"
            Me.orderDetailsBindingSource.DataSource = Me.northwindDataSetBindingSource
            Me.order_DetailsTableAdapter.ClearBeforeFill = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType(Me.openOrdersGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.openOrdersGroupBox.ResumeLayout(False)
            CType(Me.openOrdersScrollablePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.openOrdersScrollablePanel.ResumeLayout(False)
            CType(Me.orderDetailsGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.orderDetailsGroupBox.ResumeLayout(False)
            Me.orderDetailsTableLayoutPanel.ResumeLayout(False)
            Me.orderDetailsTableLayoutPanel.PerformLayout()
            CType(Me.clearButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsMultiColumnComboBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerMultiColumnComboBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeMultiColumnComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeMultiColumnComboBox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeMultiColumnComboBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.quantityLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.quantitySpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.totalLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.submitButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.createNewOrderLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private createNewOrderLabel As Telerik.WinControls.UI.RadLabel
        Private openOrdersGroupBox As Telerik.WinControls.UI.RadGroupBox
        Private orderDetailsGroupBox As Telerik.WinControls.UI.RadGroupBox
        Private openOrdersScrollablePanel As Telerik.WinControls.UI.RadScrollablePanel
        Private orderDetailsTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private productsMultiColumnComboBox As Telerik.WinControls.UI.RadMultiColumnComboBox
        Private productsLabel As Telerik.WinControls.UI.RadLabel
        Private customerMultiColumnComboBox As Telerik.WinControls.UI.RadMultiColumnComboBox
        Private employeeLabel As Telerik.WinControls.UI.RadLabel
        Private employeeMultiColumnComboBox As Telerik.WinControls.UI.RadMultiColumnComboBox
        Private customerLabel As Telerik.WinControls.UI.RadLabel
        Private quantityLabel As Telerik.WinControls.UI.RadLabel
        Private quantitySpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
        Private clearButton As Telerik.WinControls.UI.RadButton
        Private totalLabel As Telerik.WinControls.UI.RadLabel
        Private submitButton As Telerik.WinControls.UI.RadButton
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private northwindDataSetBindingSource As System.Windows.Forms.BindingSource
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private customersBindingSource As System.Windows.Forms.BindingSource
        Private employeesBindingSource As System.Windows.Forms.BindingSource
        Private employeesTableAdapter As DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Private customersTableAdapter As DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
        Private productsTableAdapter As DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter
        Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
        Private order_DetailsTableAdapter As DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
    End Class
End Namespace
