Namespace Telerik.Examples.WinControls.VirtualGrid.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.optionsLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorHeaderRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorNewRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorDataRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorColumnWidth = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorCellSpacing = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorRowSpacing = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radCheckBoxShowHeaderRow = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxShowNewRow = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxShowFilterRow = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxFitColumns = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxAlternatingRowColors = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxHotTracking = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorFilterRowHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radVirtualGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorHeaderRowHeight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorNewRowHeight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorDataRowHeight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorColumnWidth), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorCellSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorRowSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowHeaderRow), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowNewRow), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowFilterRow), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxFitColumns), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxAlternatingRowColors), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxHotTracking), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorFilterRowHeight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.northwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(0, 11)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.tableLayoutPanel1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(225, 764)
            Me.settingsPanel.Size = New System.Drawing.Size(225, 764)
            Me.optionsLabel1.Font = New System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold)
            Me.optionsLabel1.Location = New System.Drawing.Point(0, 0)
            Me.optionsLabel1.Name = "optionsLabel"
            Me.optionsLabel1.Size = New System.Drawing.Size(70, 22)
            Me.optionsLabel1.TabIndex = 0
            Me.optionsLabel1.Text = "OPTIONS"
            Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radVirtualGrid1.MasterViewInfo.AllowColumnSort = False
            Me.radVirtualGrid1.MasterViewInfo.AllowCut = False
            Me.radVirtualGrid1.MasterViewInfo.AllowDelete = False
            Me.radVirtualGrid1.MasterViewInfo.AllowEdit = False
            Me.radVirtualGrid1.MasterViewInfo.AllowPaste = False
            Me.radVirtualGrid1.Name = "radVirtualGrid1"
            Me.radVirtualGrid1.Size = New System.Drawing.Size(800, 600)
            Me.radVirtualGrid1.TabIndex = 0
            Me.radLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel1.Location = New System.Drawing.Point(3, 13)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(99, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "Header row height"
            Me.radSpinEditorHeaderRowHeight.Location = New System.Drawing.Point(3, 37)
            Me.radSpinEditorHeaderRowHeight.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.radSpinEditorHeaderRowHeight.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorHeaderRowHeight.Name = "radSpinEditorHeaderRowHeight"
            Me.radSpinEditorHeaderRowHeight.NullableValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.radSpinEditorHeaderRowHeight.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorHeaderRowHeight.TabIndex = 2
            Me.radSpinEditorHeaderRowHeight.TabStop = False
            Me.radSpinEditorHeaderRowHeight.Value = New Decimal(New Integer() {30, 0, 0, 0})
            Me.radLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel2.Location = New System.Drawing.Point(3, 81)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(86, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "New row height"
            Me.radSpinEditorNewRowHeight.Location = New System.Drawing.Point(3, 105)
            Me.radSpinEditorNewRowHeight.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.radSpinEditorNewRowHeight.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorNewRowHeight.Name = "radSpinEditorNewRowHeight"
            Me.radSpinEditorNewRowHeight.NullableValue = New Decimal(New Integer() {24, 0, 0, 0})
            Me.radSpinEditorNewRowHeight.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorNewRowHeight.TabIndex = 2
            Me.radSpinEditorNewRowHeight.TabStop = False
            Me.radSpinEditorNewRowHeight.Value = New Decimal(New Integer() {24, 0, 0, 0})
            Me.radLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel3.Location = New System.Drawing.Point(3, 217)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(63, 18)
            Me.radLabel3.TabIndex = 1
            Me.radLabel3.Text = "Row height"
            Me.radSpinEditorDataRowHeight.Location = New System.Drawing.Point(3, 241)
            Me.radSpinEditorDataRowHeight.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.radSpinEditorDataRowHeight.Name = "radSpinEditorDataRowHeight"
            Me.radSpinEditorDataRowHeight.NullableValue = New Decimal(New Integer() {24, 0, 0, 0})
            Me.radSpinEditorDataRowHeight.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorDataRowHeight.TabIndex = 2
            Me.radSpinEditorDataRowHeight.TabStop = False
            Me.radSpinEditorDataRowHeight.Value = New Decimal(New Integer() {24, 0, 0, 0})
            Me.radLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel4.Location = New System.Drawing.Point(3, 285)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(76, 18)
            Me.radLabel4.TabIndex = 1
            Me.radLabel4.Text = "Column width"
            Me.radSpinEditorColumnWidth.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.radSpinEditorColumnWidth.Location = New System.Drawing.Point(3, 309)
            Me.radSpinEditorColumnWidth.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
            Me.radSpinEditorColumnWidth.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.radSpinEditorColumnWidth.Name = "radSpinEditorColumnWidth"
            Me.radSpinEditorColumnWidth.NullableValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.radSpinEditorColumnWidth.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorColumnWidth.TabIndex = 2
            Me.radSpinEditorColumnWidth.TabStop = False
            Me.radSpinEditorColumnWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
            Me.radLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel5.Location = New System.Drawing.Point(3, 353)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(66, 18)
            Me.radLabel5.TabIndex = 1
            Me.radLabel5.Text = "Cell spacing"
            Me.radSpinEditorCellSpacing.Location = New System.Drawing.Point(3, 377)
            Me.radSpinEditorCellSpacing.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditorCellSpacing.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radSpinEditorCellSpacing.Name = "radSpinEditorCellSpacing"
            Me.radSpinEditorCellSpacing.NullableValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radSpinEditorCellSpacing.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorCellSpacing.TabIndex = 2
            Me.radSpinEditorCellSpacing.TabStop = False
            Me.radSpinEditorCellSpacing.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel6.Location = New System.Drawing.Point(3, 421)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(69, 18)
            Me.radLabel6.TabIndex = 1
            Me.radLabel6.Text = "Row spacing"
            Me.radSpinEditorRowSpacing.Location = New System.Drawing.Point(3, 445)
            Me.radSpinEditorRowSpacing.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditorRowSpacing.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radSpinEditorRowSpacing.Name = "radSpinEditorRowSpacing"
            Me.radSpinEditorRowSpacing.NullableValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radSpinEditorRowSpacing.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorRowSpacing.TabIndex = 2
            Me.radSpinEditorRowSpacing.TabStop = False
            Me.radSpinEditorRowSpacing.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.radCheckBoxShowHeaderRow.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowHeaderRow.Location = New System.Drawing.Point(3, 479)
            Me.radCheckBoxShowHeaderRow.Name = "radCheckBoxShowHeaderRow"
            Me.radCheckBoxShowHeaderRow.Size = New System.Drawing.Size(138, 18)
            Me.radCheckBoxShowHeaderRow.TabIndex = 3
            Me.radCheckBoxShowHeaderRow.Text = "Should column headers"
            Me.radCheckBoxShowHeaderRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radCheckBoxShowNewRow.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowNewRow.Location = New System.Drawing.Point(3, 513)
            Me.radCheckBoxShowNewRow.Name = "radCheckBoxShowNewRow"
            Me.radCheckBoxShowNewRow.Size = New System.Drawing.Size(93, 18)
            Me.radCheckBoxShowNewRow.TabIndex = 3
            Me.radCheckBoxShowNewRow.Text = "Show new row"
            Me.radCheckBoxShowNewRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radCheckBoxShowFilterRow.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowFilterRow.Location = New System.Drawing.Point(3, 547)
            Me.radCheckBoxShowFilterRow.Name = "radCheckBoxShowFilterRow"
            Me.radCheckBoxShowFilterRow.Size = New System.Drawing.Size(95, 18)
            Me.radCheckBoxShowFilterRow.TabIndex = 3
            Me.radCheckBoxShowFilterRow.Text = "Show filter row"
            Me.radCheckBoxShowFilterRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radCheckBoxFitColumns.Location = New System.Drawing.Point(3, 581)
            Me.radCheckBoxFitColumns.Name = "radCheckBoxFitColumns"
            Me.radCheckBoxFitColumns.Size = New System.Drawing.Size(77, 18)
            Me.radCheckBoxFitColumns.TabIndex = 3
            Me.radCheckBoxFitColumns.Text = "Fit columns"
            Me.radCheckBoxAlternatingRowColors.Location = New System.Drawing.Point(3, 615)
            Me.radCheckBoxAlternatingRowColors.Name = "radCheckBoxAlternatingRowColors"
            Me.radCheckBoxAlternatingRowColors.Size = New System.Drawing.Size(131, 18)
            Me.radCheckBoxAlternatingRowColors.TabIndex = 3
            Me.radCheckBoxAlternatingRowColors.Text = "Alternating row colors"
            Me.radCheckBoxHotTracking.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxHotTracking.Location = New System.Drawing.Point(3, 649)
            Me.radCheckBoxHotTracking.Name = "radCheckBoxHotTracking"
            Me.radCheckBoxHotTracking.Size = New System.Drawing.Size(117, 18)
            Me.radCheckBoxHotTracking.TabIndex = 3
            Me.radCheckBoxHotTracking.Text = "Enable hot tracking"
            Me.radCheckBoxHotTracking.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabel7.Location = New System.Drawing.Point(3, 149)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(88, 18)
            Me.radLabel7.TabIndex = 1
            Me.radLabel7.Text = "Filter row height"
            Me.radSpinEditorFilterRowHeight.Location = New System.Drawing.Point(3, 173)
            Me.radSpinEditorFilterRowHeight.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.radSpinEditorFilterRowHeight.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorFilterRowHeight.Name = "radSpinEditorFilterRowHeight"
            Me.radSpinEditorFilterRowHeight.NullableValue = New Decimal(New Integer() {26, 0, 0, 0})
            Me.radSpinEditorFilterRowHeight.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorFilterRowHeight.TabIndex = 2
            Me.radSpinEditorFilterRowHeight.TabStop = False
            Me.radSpinEditorFilterRowHeight.Value = New Decimal(New Integer() {26, 0, 0, 0})
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.employeesTableAdapter.ClearBeforeFill = True
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxHotTracking, 0, 19)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorNewRowHeight, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxAlternatingRowColors, 0, 18)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel7, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxFitColumns, 0, 17)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorFilterRowHeight, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxShowFilterRow, 0, 16)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 6)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxShowNewRow, 0, 15)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorDataRowHeight, 0, 7)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxShowHeaderRow, 0, 14)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 8)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorRowSpacing, 0, 13)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorColumnWidth, 0, 9)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel6, 0, 12)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorCellSpacing, 0, 11)
            Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditorHeaderRowHeight, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel5, 0, 10)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(14, 42)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 20
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(200, 686)
            Me.tableLayoutPanel1.TabIndex = 4
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radVirtualGrid1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1265, 796)
            Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radVirtualGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorHeaderRowHeight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorNewRowHeight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorDataRowHeight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorColumnWidth), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorCellSpacing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorRowSpacing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowHeaderRow), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowNewRow), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowFilterRow), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxFitColumns), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxAlternatingRowColors), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxHotTracking), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorFilterRowHeight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.northwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Private radCheckBoxShowFilterRow As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowNewRow As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowHeaderRow As Telerik.WinControls.UI.RadCheckBox
        Private radSpinEditorRowSpacing As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorCellSpacing As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorColumnWidth As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorDataRowHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorNewRowHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorHeaderRowHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxHotTracking As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxAlternatingRowColors As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxFitColumns As Telerik.WinControls.UI.RadCheckBox
        Private radSpinEditorFilterRowHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private optionsLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
