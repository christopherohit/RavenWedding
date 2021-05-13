namespace Telerik.Examples.WinControls.VirtualGrid.Validation
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
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorSecondCondition = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorFirstCondition = new Telerik.WinControls.UI.RadSpinEditor();
            this.radDropDownListSecondCondition = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownListFirstCondition = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownListColumnName = new Telerik.WinControls.UI.RadDropDownList();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSecondCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorFirstCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSecondCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListFirstCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListColumnName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 321);
            this.settingsPanel.Size = new System.Drawing.Size(230, 321);
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.MasterViewInfo.RowCount = 1000;
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(1473, 786);
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.SortChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_SortChanged);
            this.radVirtualGrid1.FilterChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_FilterChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.radGroupBox1.HeaderText = "Column restrictions:";
            this.radGroupBox1.Location = new System.Drawing.Point(5, 33);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(220, 256);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Column restrictions:";
            this.radGroupBox1.UseMnemonic = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 111);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(24, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "and";
            // 
            // radSpinEditorSecondCondition
            // 
            this.radSpinEditorSecondCondition.Location = new System.Drawing.Point(3, 183);
            this.radSpinEditorSecondCondition.Name = "radSpinEditorSecondCondition";
            this.radSpinEditorSecondCondition.Size = new System.Drawing.Size(180, 20);
            this.radSpinEditorSecondCondition.TabIndex = 1;
            this.radSpinEditorSecondCondition.TabStop = false;
            // 
            // radSpinEditorFirstCondition
            // 
            this.radSpinEditorFirstCondition.Location = new System.Drawing.Point(3, 75);
            this.radSpinEditorFirstCondition.Name = "radSpinEditorFirstCondition";
            this.radSpinEditorFirstCondition.Size = new System.Drawing.Size(180, 20);
            this.radSpinEditorFirstCondition.TabIndex = 1;
            this.radSpinEditorFirstCondition.TabStop = false;
            // 
            // radDropDownListSecondCondition
            // 
            this.radDropDownListSecondCondition.DropDownAnimationEnabled = false;
            this.radDropDownListSecondCondition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListSecondCondition.Location = new System.Drawing.Point(3, 144);
            this.radDropDownListSecondCondition.Name = "radDropDownListSecondCondition";
            this.radDropDownListSecondCondition.Size = new System.Drawing.Size(180, 20);
            this.radDropDownListSecondCondition.TabIndex = 0;
            // 
            // radDropDownListFirstCondition
            // 
            this.radDropDownListFirstCondition.DropDownAnimationEnabled = false;
            this.radDropDownListFirstCondition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListFirstCondition.Location = new System.Drawing.Point(3, 39);
            this.radDropDownListFirstCondition.Name = "radDropDownListFirstCondition";
            this.radDropDownListFirstCondition.Size = new System.Drawing.Size(180, 20);
            this.radDropDownListFirstCondition.TabIndex = 0;
            // 
            // radDropDownListColumnName
            // 
            this.radDropDownListColumnName.DropDownAnimationEnabled = false;
            this.radDropDownListColumnName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListColumnName.Location = new System.Drawing.Point(3, 3);
            this.radDropDownListColumnName.Name = "radDropDownListColumnName";
            this.radDropDownListColumnName.Size = new System.Drawing.Size(180, 20);
            this.radDropDownListColumnName.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radDropDownListColumnName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorSecondCondition, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radDropDownListSecondCondition, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radDropDownListFirstCondition, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditorFirstCondition, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 217);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 796);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSecondCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorFirstCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSecondCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListFirstCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListColumnName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorSecondCondition;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorFirstCondition;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListSecondCondition;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListFirstCondition;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListColumnName;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
    }
}