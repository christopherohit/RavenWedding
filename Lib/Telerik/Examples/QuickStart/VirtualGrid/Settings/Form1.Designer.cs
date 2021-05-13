namespace Telerik.Examples.WinControls.VirtualGrid.Settings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionsLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorHeaderRowHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorNewRowHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorDataRowHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorColumnWidth = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorCellSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorRowSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBoxShowHeaderRow = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowNewRow = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxShowFilterRow = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxFitColumns = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxAlternatingRowColors = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxHotTracking = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorFilterRowHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorHeaderRowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorNewRowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDataRowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumnWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorCellSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowHeaderRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowNewRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowFilterRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFitColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAlternatingRowColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHotTracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorFilterRowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 11);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.tableLayoutPanel1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(225, 764);
            this.settingsPanel.Size = new System.Drawing.Size(225, 764);
            // 
            // optionsLabel
            // 
            this.optionsLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.optionsLabel1.Location = new System.Drawing.Point(0, 0);
            this.optionsLabel1.Name = "optionsLabel";
            this.optionsLabel1.Size = new System.Drawing.Size(70, 22);
            this.optionsLabel1.TabIndex = 0;
            this.optionsLabel1.Text = "OPTIONS";
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.MasterViewInfo.AllowColumnSort = false;
            this.radVirtualGrid1.MasterViewInfo.AllowCut = false;
            this.radVirtualGrid1.MasterViewInfo.AllowDelete = false;
            this.radVirtualGrid1.MasterViewInfo.AllowEdit = false;
            this.radVirtualGrid1.MasterViewInfo.AllowPaste = false;
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(800, 600);
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.CellFormatting += new Telerik.WinControls.UI.VirtualGridCellElementEventHandler(this.radVirtualGrid1_CellFormatting);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel1.Location = new System.Drawing.Point(3, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(99, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Header row height";
            // 
            // radSpinEditorHeaderRowHeight
            // 
            this.radSpinEditorHeaderRowHeight.Location = new System.Drawing.Point(3, 37);
            this.radSpinEditorHeaderRowHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorHeaderRowHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditorHeaderRowHeight.Name = "radSpinEditorHeaderRowHeight";
            this.radSpinEditorHeaderRowHeight.NullableValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.radSpinEditorHeaderRowHeight.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorHeaderRowHeight.TabIndex = 2;
            this.radSpinEditorHeaderRowHeight.TabStop = false;
            this.radSpinEditorHeaderRowHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel2.Location = new System.Drawing.Point(3, 81);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(86, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "New row height";
            // 
            // radSpinEditorNewRowHeight
            // 
            this.radSpinEditorNewRowHeight.Location = new System.Drawing.Point(3, 105);
            this.radSpinEditorNewRowHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorNewRowHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditorNewRowHeight.Name = "radSpinEditorNewRowHeight";
            this.radSpinEditorNewRowHeight.NullableValue = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.radSpinEditorNewRowHeight.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorNewRowHeight.TabIndex = 2;
            this.radSpinEditorNewRowHeight.TabStop = false;
            this.radSpinEditorNewRowHeight.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel3.Location = new System.Drawing.Point(3, 217);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(63, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Row height";
            // 
            // radSpinEditorDataRowHeight
            // 
            this.radSpinEditorDataRowHeight.Location = new System.Drawing.Point(3, 241);
            this.radSpinEditorDataRowHeight.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.radSpinEditorDataRowHeight.Name = "radSpinEditorDataRowHeight";
            this.radSpinEditorDataRowHeight.NullableValue = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.radSpinEditorDataRowHeight.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorDataRowHeight.TabIndex = 2;
            this.radSpinEditorDataRowHeight.TabStop = false;
            this.radSpinEditorDataRowHeight.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel4.Location = new System.Drawing.Point(3, 285);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(76, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Column width";
            // 
            // radSpinEditorColumnWidth
            // 
            this.radSpinEditorColumnWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radSpinEditorColumnWidth.Location = new System.Drawing.Point(3, 309);
            this.radSpinEditorColumnWidth.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.radSpinEditorColumnWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorColumnWidth.Name = "radSpinEditorColumnWidth";
            this.radSpinEditorColumnWidth.NullableValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.radSpinEditorColumnWidth.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorColumnWidth.TabIndex = 2;
            this.radSpinEditorColumnWidth.TabStop = false;
            this.radSpinEditorColumnWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel5.Location = new System.Drawing.Point(3, 353);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(66, 18);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Cell spacing";
            // 
            // radSpinEditorCellSpacing
            // 
            this.radSpinEditorCellSpacing.Location = new System.Drawing.Point(3, 377);
            this.radSpinEditorCellSpacing.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorCellSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorCellSpacing.Name = "radSpinEditorCellSpacing";
            this.radSpinEditorCellSpacing.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorCellSpacing.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorCellSpacing.TabIndex = 2;
            this.radSpinEditorCellSpacing.TabStop = false;
            this.radSpinEditorCellSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel6.Location = new System.Drawing.Point(3, 421);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(69, 18);
            this.radLabel6.TabIndex = 1;
            this.radLabel6.Text = "Row spacing";
            // 
            // radSpinEditorRowSpacing
            // 
            this.radSpinEditorRowSpacing.Location = new System.Drawing.Point(3, 445);
            this.radSpinEditorRowSpacing.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorRowSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorRowSpacing.Name = "radSpinEditorRowSpacing";
            this.radSpinEditorRowSpacing.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditorRowSpacing.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorRowSpacing.TabIndex = 2;
            this.radSpinEditorRowSpacing.TabStop = false;
            this.radSpinEditorRowSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // radCheckBoxShowHeaderRow
            // 
            this.radCheckBoxShowHeaderRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowHeaderRow.Location = new System.Drawing.Point(3, 479);
            this.radCheckBoxShowHeaderRow.Name = "radCheckBoxShowHeaderRow";
            this.radCheckBoxShowHeaderRow.Size = new System.Drawing.Size(138, 18);
            this.radCheckBoxShowHeaderRow.TabIndex = 3;
            this.radCheckBoxShowHeaderRow.Text = "Should column headers";
            this.radCheckBoxShowHeaderRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxShowNewRow
            // 
            this.radCheckBoxShowNewRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowNewRow.Location = new System.Drawing.Point(3, 513);
            this.radCheckBoxShowNewRow.Name = "radCheckBoxShowNewRow";
            this.radCheckBoxShowNewRow.Size = new System.Drawing.Size(93, 18);
            this.radCheckBoxShowNewRow.TabIndex = 3;
            this.radCheckBoxShowNewRow.Text = "Show new row";
            this.radCheckBoxShowNewRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxShowFilterRow
            // 
            this.radCheckBoxShowFilterRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxShowFilterRow.Location = new System.Drawing.Point(3, 547);
            this.radCheckBoxShowFilterRow.Name = "radCheckBoxShowFilterRow";
            this.radCheckBoxShowFilterRow.Size = new System.Drawing.Size(95, 18);
            this.radCheckBoxShowFilterRow.TabIndex = 3;
            this.radCheckBoxShowFilterRow.Text = "Show filter row";
            this.radCheckBoxShowFilterRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxFitColumns
            // 
            this.radCheckBoxFitColumns.Location = new System.Drawing.Point(3, 581);
            this.radCheckBoxFitColumns.Name = "radCheckBoxFitColumns";
            this.radCheckBoxFitColumns.Size = new System.Drawing.Size(77, 18);
            this.radCheckBoxFitColumns.TabIndex = 3;
            this.radCheckBoxFitColumns.Text = "Fit columns";
            // 
            // radCheckBoxAlternatingRowColors
            // 
            this.radCheckBoxAlternatingRowColors.Location = new System.Drawing.Point(3, 615);
            this.radCheckBoxAlternatingRowColors.Name = "radCheckBoxAlternatingRowColors";
            this.radCheckBoxAlternatingRowColors.Size = new System.Drawing.Size(131, 18);
            this.radCheckBoxAlternatingRowColors.TabIndex = 3;
            this.radCheckBoxAlternatingRowColors.Text = "Alternating row colors";
            // 
            // radCheckBoxHotTracking
            // 
            this.radCheckBoxHotTracking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxHotTracking.Location = new System.Drawing.Point(3, 649);
            this.radCheckBoxHotTracking.Name = "radCheckBoxHotTracking";
            this.radCheckBoxHotTracking.Size = new System.Drawing.Size(117, 18);
            this.radCheckBoxHotTracking.TabIndex = 3;
            this.radCheckBoxHotTracking.Text = "Enable hot tracking";
            this.radCheckBoxHotTracking.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel7.Location = new System.Drawing.Point(3, 149);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(88, 18);
            this.radLabel7.TabIndex = 1;
            this.radLabel7.Text = "Filter row height";
            // 
            // radSpinEditorFilterRowHeight
            // 
            this.radSpinEditorFilterRowHeight.Location = new System.Drawing.Point(3, 173);
            this.radSpinEditorFilterRowHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorFilterRowHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditorFilterRowHeight.Name = "radSpinEditorFilterRowHeight";
            this.radSpinEditorFilterRowHeight.NullableValue = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.radSpinEditorFilterRowHeight.Size = new System.Drawing.Size(194, 20);
            this.radSpinEditorFilterRowHeight.TabIndex = 2;
            this.radSpinEditorFilterRowHeight.TabStop = false;
            this.radSpinEditorFilterRowHeight.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxHotTracking, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorNewRowHeight, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxAlternatingRowColors, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.radLabel7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxFitColumns, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorFilterRowHeight, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxShowFilterRow, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxShowNewRow, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorDataRowHeight, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.radCheckBoxShowHeaderRow, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.radLabel4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorRowSpacing, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorColumnWidth, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.radLabel6, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorCellSpacing, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorHeaderRowHeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel5, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 686);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1265, 796);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorHeaderRowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorNewRowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDataRowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumnWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorCellSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowHeaderRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowNewRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowFilterRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFitColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAlternatingRowColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHotTracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorFilterRowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private DataSources.NorthwindDataSet northwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowFilterRow;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowNewRow;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowHeaderRow;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRowSpacing;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorCellSpacing;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorColumnWidth;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorDataRowHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorNewRowHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorHeaderRowHeight;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxHotTracking;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAlternatingRowColors;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFitColumns;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorFilterRowHeight;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel optionsLabel1;
    }
}