namespace Telerik.Examples.WinControls.VirtualGrid.Performance
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
            this.radButtonLoad = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorRowSize = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelRowResize = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorColumnSize = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelColumnResize = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumnSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelColumnResize)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Size = new System.Drawing.Size(230, 536);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.AllowSorting = false;
            this.radVirtualGrid1.ColumnCount = 100;
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.RowCount = 1000;
            this.radVirtualGrid1.Size = new System.Drawing.Size(1871, 1086);
            this.radVirtualGrid1.StandardTab = false;
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            this.radVirtualGrid1.Visible = false;
            // 
            // radButtonLoad
            // 
            this.radButtonLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButtonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonLoad.Location = new System.Drawing.Point(818, 484);
            this.radButtonLoad.Name = "radButtonLoad";
            this.radButtonLoad.Size = new System.Drawing.Size(275, 52);
            this.radButtonLoad.TabIndex = 0;
            this.radButtonLoad.Text = "LOAD 1 BILLION CELLS";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radSpinEditorRowSize);
            this.radGroupBox1.Controls.Add(this.radLabelRowResize);
            this.radGroupBox1.HeaderText = "Resize rows";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 94);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Resize rows";
            // 
            // radSpinEditorRowSize
            // 
            this.radSpinEditorRowSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorRowSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radSpinEditorRowSize.Location = new System.Drawing.Point(5, 61);
            this.radSpinEditorRowSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radSpinEditorRowSize.Name = "radSpinEditorRowSize";
            this.radSpinEditorRowSize.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorRowSize.TabIndex = 1;
            this.radSpinEditorRowSize.TabStop = false;
            this.radSpinEditorRowSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // radLabelRowResize
            // 
            this.radLabelRowResize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelRowResize.Location = new System.Drawing.Point(5, 22);
            this.radLabelRowResize.Name = "radLabelRowResize";
            this.radLabelRowResize.Size = new System.Drawing.Size(141, 33);
            this.radLabelRowResize.TabIndex = 0;
            this.radLabelRowResize.Text = "Set every 10th row height.\r\n(100 000 in total)";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radSpinEditorColumnSize);
            this.radGroupBox2.Controls.Add(this.radLabelColumnResize);
            this.radGroupBox2.HeaderText = "Resize columns";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 132);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(210, 95);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Resize columns";
            // 
            // radSpinEditorColumnSize
            // 
            this.radSpinEditorColumnSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorColumnSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorColumnSize.Location = new System.Drawing.Point(5, 61);
            this.radSpinEditorColumnSize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.radSpinEditorColumnSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorColumnSize.Name = "radSpinEditorColumnSize";
            this.radSpinEditorColumnSize.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorColumnSize.TabIndex = 1;
            this.radSpinEditorColumnSize.TabStop = false;
            this.radSpinEditorColumnSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radLabelColumnResize
            // 
            this.radLabelColumnResize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelColumnResize.Location = new System.Drawing.Point(5, 22);
            this.radLabelColumnResize.Name = "radLabelColumnResize";
            this.radLabelColumnResize.Size = new System.Drawing.Size(160, 33);
            this.radLabelColumnResize.TabIndex = 0;
            this.radLabelColumnResize.Text = "Set every other column width.\r\n(500 in total)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Controls.Add(this.radButtonLoad);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1881, 1096);
            this.Controls.SetChildIndex(this.radButtonLoad, 0);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorColumnSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelColumnResize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorColumnSize;
        private Telerik.WinControls.UI.RadLabel radLabelColumnResize;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRowSize;
        private Telerik.WinControls.UI.RadLabel radLabelRowResize;
        private Telerik.WinControls.UI.RadButton radButtonLoad;
    }
}