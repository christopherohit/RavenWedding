Namespace Telerik.Examples.WinControls.GridView.Export.SpreadExportImages

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
            Dim gridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.furnitureDataSet = New Telerik.Examples.WinControls.DataSources.FurnitureDataSet()
            Me.productsTableAdapter = New Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.imageAlignmentDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.imageLayoutDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType((Me.radGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGridView1.MasterTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.furnitureDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.exportButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType((Me.imageAlignmentDropDownList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageLayoutDropDownList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.exportButton)
            Me.settingsPanel.Location = New System.Drawing.Point(1046, 187)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 226)
            Me.settingsPanel.Controls.SetChildIndex(Me.exportButton, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowCellContextMenu = False
            Me.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = False
            Me.radGridView1.MasterTemplate.AllowColumnReorder = False
            Me.radGridView1.MasterTemplate.AllowDeleteRow = False
            Me.radGridView1.MasterTemplate.AllowDragToGroup = False
            Me.radGridView1.MasterTemplate.AllowEditRow = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            gridViewImageColumn1.DataType = GetType(Byte())
            gridViewImageColumn1.FieldName = "Photo"
            gridViewImageColumn1.HeaderText = "Photo"
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
            gridViewImageColumn1.IsAutoGenerated = True
            gridViewImageColumn1.Name = "Photo"
            gridViewImageColumn1.Width = 408
            gridViewTextBoxColumn1.FieldName = "ProductName"
            gridViewTextBoxColumn1.HeaderText = "Product"
            gridViewTextBoxColumn1.IsAutoGenerated = True
            gridViewTextBoxColumn1.Name = "ProductName"
            gridViewTextBoxColumn1.Width = 238
            gridViewTextBoxColumn2.FieldName = "Manufacturer"
            gridViewTextBoxColumn2.HeaderText = "Manufacturer"
            gridViewTextBoxColumn2.IsAutoGenerated = True
            gridViewTextBoxColumn2.Name = "Manufacturer"
            gridViewTextBoxColumn2.Width = 241
            gridViewTextBoxColumn3.FieldName = "Dimensions"
            gridViewTextBoxColumn3.FormatString = "{0} inches"
            gridViewTextBoxColumn3.HeaderText = "Dimensions"
            gridViewTextBoxColumn3.IsAutoGenerated = True
            gridViewTextBoxColumn3.Name = "Dimensions"
            gridViewTextBoxColumn3.Width = 207
            gridViewDecimalColumn1.FieldName = "Price"
            gridViewDecimalColumn1.FormatString = "{0:C}"
            gridViewDecimalColumn1.HeaderText = "Price"
            gridViewDecimalColumn1.IsAutoGenerated = True
            gridViewDecimalColumn1.Name = "Price"
            gridViewDecimalColumn1.Width = 207
            gridViewDecimalColumn2.DataType = GetType(Integer)
            gridViewDecimalColumn2.FieldName = "Quantity"
            gridViewDecimalColumn2.HeaderText = "Quantity"
            gridViewDecimalColumn2.IsAutoGenerated = True
            gridViewDecimalColumn2.Name = "Quantity"
            gridViewDecimalColumn2.Width = 150
            gridViewDecimalColumn3.DataType = GetType(Integer)
            gridViewDecimalColumn3.FieldName = "ID"
            gridViewDecimalColumn3.HeaderText = "ID"
            gridViewDecimalColumn3.IsAutoGenerated = True
            gridViewDecimalColumn3.IsVisible = False
            gridViewDecimalColumn3.Name = "ID"
            gridViewDecimalColumn3.Width = 121
            gridViewTextBoxColumn4.FieldName = "Front"
            gridViewTextBoxColumn4.HeaderText = "Front"
            gridViewTextBoxColumn4.IsAutoGenerated = True
            gridViewTextBoxColumn4.IsVisible = False
            gridViewTextBoxColumn4.Name = "Front"
            gridViewTextBoxColumn4.Width = 207
            gridViewTextBoxColumn5.FieldName = "Back"
            gridViewTextBoxColumn5.HeaderText = "Back"
            gridViewTextBoxColumn5.IsAutoGenerated = True
            gridViewTextBoxColumn5.IsVisible = False
            gridViewTextBoxColumn5.Name = "Back"
            gridViewTextBoxColumn5.Width = 145
            gridViewTextBoxColumn6.FieldName = "SalesRepresentative"
            gridViewTextBoxColumn6.HeaderText = "SalesRepresentative"
            gridViewTextBoxColumn6.IsAutoGenerated = True
            gridViewTextBoxColumn6.IsVisible = False
            gridViewTextBoxColumn6.Name = "SalesRepresentative"
            gridViewTextBoxColumn6.Width = 132
            gridViewTextBoxColumn7.FieldName = "Lining"
            gridViewTextBoxColumn7.HeaderText = "Lining"
            gridViewTextBoxColumn7.IsAutoGenerated = True
            gridViewTextBoxColumn7.IsVisible = False
            gridViewTextBoxColumn7.Name = "Lining"
            gridViewTextBoxColumn7.Width = 161
            gridViewCheckBoxColumn1.FieldName = "Condition"
            gridViewCheckBoxColumn1.HeaderText = "Condition"
            gridViewCheckBoxColumn1.IsAutoGenerated = True
            gridViewCheckBoxColumn1.IsVisible = False
            gridViewCheckBoxColumn1.Name = "Condition"
            gridViewCheckBoxColumn1.Width = 200
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewImageColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewDecimalColumn1, gridViewDecimalColumn2, gridViewDecimalColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewCheckBoxColumn1})
            Me.radGridView1.MasterTemplate.DataSource = Me.productsBindingSource
            Me.radGridView1.MasterTemplate.EnableGrouping = False
            Me.radGridView1.MasterTemplate.EnableSorting = False
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(1467, 907)
            Me.radGridView1.TabIndex = 2
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.furnitureDataSet
            Me.furnitureDataSet.DataSetName = "FurnitureDataSet"
            Me.furnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.productsTableAdapter.ClearBeforeFill = True
            Me.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.exportButton.Location = New System.Drawing.Point(10, 33)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(210, 24)
            Me.exportButton.TabIndex = 1
            Me.exportButton.Text = "Export"
            AddHandler Me.exportButton.Click, AddressOf Me.exportButton_Click
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.imageAlignmentDropDownList)
            Me.radGroupBox1.Controls.Add(Me.imageLayoutDropDownList)
            Me.radGroupBox1.Controls.Add(Me.radLabel2)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.HeaderText = "Image column export settings:"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 64)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(210, 141)
            Me.radGroupBox1.TabIndex = 2
            Me.radGroupBox1.Text = "Image column export settings:"
            Me.imageAlignmentDropDownList.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.imageAlignmentDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.imageAlignmentDropDownList.Location = New System.Drawing.Point(5, 107)
            Me.imageAlignmentDropDownList.Name = "imageAlignmentDropDownList"
            Me.imageAlignmentDropDownList.Size = New System.Drawing.Size(200, 20)
            Me.imageAlignmentDropDownList.TabIndex = 3
            AddHandler Me.imageAlignmentDropDownList.SelectedIndexChanged, AddressOf Me.imageAlignmentDropDownList_SelectedIndexChanged
            Me.imageLayoutDropDownList.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.imageLayoutDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.imageLayoutDropDownList.Location = New System.Drawing.Point(5, 47)
            Me.imageLayoutDropDownList.Name = "imageLayoutDropDownList"
            Me.imageLayoutDropDownList.Size = New System.Drawing.Size(200, 20)
            Me.imageLayoutDropDownList.TabIndex = 2
            AddHandler Me.imageLayoutDropDownList.SelectedIndexChanged, AddressOf Me.imageLayoutDropDownList_SelectedIndexChanged
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel2.Location = New System.Drawing.Point(5, 83)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(91, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Image Alignment"
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(5, 22)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(73, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Image Layout"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1477, 917)
            AddHandler Me.Load, AddressOf Me.Form1_Load
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType((Me.radGridView1.MasterTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.furnitureDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.exportButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType((Me.imageAlignmentDropDownList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageLayoutDropDownList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radGridView1 As Telerik.WinControls.UI.RadGridView

        Private productsBindingSource As System.Windows.Forms.BindingSource

        Private furnitureDataSet As DataSources.FurnitureDataSet

        Private productsTableAdapter As DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter

        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox

        Private exportButton As Telerik.WinControls.UI.RadButton

        Private imageAlignmentDropDownList As Telerik.WinControls.UI.RadDropDownList

        Private imageLayoutDropDownList As Telerik.WinControls.UI.RadDropDownList

        Private radLabel2 As Telerik.WinControls.UI.RadLabel

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace