namespace ExportWithDpl.SpreadsheetStreaming
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabelRowsCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabelExtension = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorRowsCount = new Telerik.WinControls.UI.RadSpinEditor();
            this.radDropDownListExtension = new Telerik.WinControls.UI.RadDropDownList();
            this.radProgressBarExportProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.radLabelExportedCells = new Telerik.WinControls.UI.RadLabel();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabelNumberOfExportedCells = new Telerik.WinControls.UI.RadLabel();
            this.radLabelExportTime = new Telerik.WinControls.UI.RadLabel();
            this.radLabelExportTimeElapsed = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSeconds = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCurrentMemory = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMemory = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMB = new Telerik.WinControls.UI.RadLabel();
            this.doubleBufferedTableLayoutPanel1 = new DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExportProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfExportedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTimeElapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMB)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(744, 460);
            this.radGridView1.TabIndex = 0;
            // 
            // radLabelRowsCount
            // 
            this.radLabelRowsCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabelRowsCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelRowsCount.Location = new System.Drawing.Point(30, 13);
            this.radLabelRowsCount.Name = "radLabelRowsCount";
            this.radLabelRowsCount.Size = new System.Drawing.Size(71, 18);
            this.radLabelRowsCount.TabIndex = 1;
            this.radLabelRowsCount.Text = "Rows count:";
            // 
            // radLabelExtension
            // 
            this.radLabelExtension.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabelExtension.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelExtension.Location = new System.Drawing.Point(363, 13);
            this.radLabelExtension.Name = "radLabelExtension";
            this.radLabelExtension.Size = new System.Drawing.Size(61, 18);
            this.radLabelExtension.TabIndex = 1;
            this.radLabelExtension.Text = "Extension:";
            // 
            // radSpinEditorRowsCount
            // 
            this.radSpinEditorRowsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radSpinEditorRowsCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radSpinEditorRowsCount.Location = new System.Drawing.Point(107, 12);
            this.radSpinEditorRowsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.radSpinEditorRowsCount.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.radSpinEditorRowsCount.Name = "radSpinEditorRowsCount";
            this.radSpinEditorRowsCount.NullableValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radSpinEditorRowsCount.Size = new System.Drawing.Size(112, 20);
            this.radSpinEditorRowsCount.TabIndex = 2;
            this.radSpinEditorRowsCount.TabStop = false;
            this.radSpinEditorRowsCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // radDropDownListExtension
            // 
            this.radDropDownListExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListExtension.DropDownAnimationEnabled = false;
            this.radDropDownListExtension.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "Xlsx";
            radListDataItem2.Text = "Csv";
            this.radDropDownListExtension.Items.Add(radListDataItem1);
            this.radDropDownListExtension.Items.Add(radListDataItem2);
            this.radDropDownListExtension.Location = new System.Drawing.Point(430, 12);
            this.radDropDownListExtension.Name = "radDropDownListExtension";
            this.radDropDownListExtension.Size = new System.Drawing.Size(130, 20);
            this.radDropDownListExtension.TabIndex = 3;
            this.radDropDownListExtension.Text = "Xlsx";
            // 
            // radProgressBarExportProgress
            // 
            this.radProgressBarExportProgress.Location = new System.Drawing.Point(15, 569);
            this.radProgressBarExportProgress.Name = "radProgressBarExportProgress";
            this.radProgressBarExportProgress.Size = new System.Drawing.Size(741, 24);
            this.radProgressBarExportProgress.TabIndex = 4;
            // 
            // radLabelExportedCells
            // 
            this.radLabelExportedCells.Location = new System.Drawing.Point(3, 3);
            this.radLabelExportedCells.Name = "radLabelExportedCells";
            this.radLabelExportedCells.Size = new System.Drawing.Size(78, 18);
            this.radLabelExportedCells.TabIndex = 1;
            this.radLabelExportedCells.Text = "Exported cells:";
            // 
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(604, 509);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(150, 24);
            this.radButtonExport.TabIndex = 5;
            this.radButtonExport.Text = "Export";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabelExportedCells);
            this.flowLayoutPanel1.Controls.Add(this.radLabelNumberOfExportedCells);
            this.flowLayoutPanel1.Controls.Add(this.radLabelExportTime);
            this.flowLayoutPanel1.Controls.Add(this.radLabelExportTimeElapsed);
            this.flowLayoutPanel1.Controls.Add(this.radLabelSeconds);
            this.flowLayoutPanel1.Controls.Add(this.radLabelCurrentMemory);
            this.flowLayoutPanel1.Controls.Add(this.radLabelMemory);
            this.flowLayoutPanel1.Controls.Add(this.radLabelMB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 618);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 43);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // radLabelNumberOfExportedCells
            // 
            this.radLabelNumberOfExportedCells.Location = new System.Drawing.Point(87, 3);
            this.radLabelNumberOfExportedCells.Name = "radLabelNumberOfExportedCells";
            this.radLabelNumberOfExportedCells.Size = new System.Drawing.Size(12, 18);
            this.radLabelNumberOfExportedCells.TabIndex = 1;
            this.radLabelNumberOfExportedCells.Text = "0";
            // 
            // radLabelExportTime
            // 
            this.radLabelExportTime.Location = new System.Drawing.Point(105, 3);
            this.radLabelExportTime.Name = "radLabelExportTime";
            this.radLabelExportTime.Size = new System.Drawing.Size(66, 18);
            this.radLabelExportTime.TabIndex = 1;
            this.radLabelExportTime.Text = "Export time:";
            // 
            // radLabelExportTimeElapsed
            // 
            this.radLabelExportTimeElapsed.Location = new System.Drawing.Point(177, 3);
            this.radLabelExportTimeElapsed.Name = "radLabelExportTimeElapsed";
            this.radLabelExportTimeElapsed.Size = new System.Drawing.Size(12, 18);
            this.radLabelExportTimeElapsed.TabIndex = 1;
            this.radLabelExportTimeElapsed.Text = "0";
            // 
            // radLabelSeconds
            // 
            this.radLabelSeconds.Location = new System.Drawing.Point(195, 3);
            this.radLabelSeconds.Name = "radLabelSeconds";
            this.radLabelSeconds.Size = new System.Drawing.Size(11, 18);
            this.radLabelSeconds.TabIndex = 1;
            this.radLabelSeconds.Text = "s";
            // 
            // radLabelCurrentMemory
            // 
            this.radLabelCurrentMemory.Location = new System.Drawing.Point(212, 3);
            this.radLabelCurrentMemory.Name = "radLabelCurrentMemory";
            this.radLabelCurrentMemory.Size = new System.Drawing.Size(91, 18);
            this.radLabelCurrentMemory.TabIndex = 1;
            this.radLabelCurrentMemory.Text = "Current memory:";
            // 
            // radLabelMemory
            // 
            this.radLabelMemory.Location = new System.Drawing.Point(309, 3);
            this.radLabelMemory.Name = "radLabelMemory";
            this.radLabelMemory.Size = new System.Drawing.Size(12, 18);
            this.radLabelMemory.TabIndex = 1;
            this.radLabelMemory.Text = "0";
            // 
            // radLabelMB
            // 
            this.radLabelMB.Location = new System.Drawing.Point(327, 3);
            this.radLabelMB.Name = "radLabelMB";
            this.radLabelMB.Size = new System.Drawing.Size(23, 18);
            this.radLabelMB.TabIndex = 1;
            this.radLabelMB.Text = "MB";
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 5;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65009F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.13677F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.74245F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02487F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.97869F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabelRowsCount, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radSpinEditorRowsCount, 1, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radDropDownListExtension, 4, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabelExtension, 3, 0);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(15, 498);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 1;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(563, 44);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 674);
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radButtonExport);
            this.Controls.Add(this.radProgressBarExportProgress);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExportProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfExportedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTimeElapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMB)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabelRowsCount;
        private Telerik.WinControls.UI.RadLabel radLabelExtension;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRowsCount;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListExtension;
        private Telerik.WinControls.UI.RadProgressBar radProgressBarExportProgress;
        private Telerik.WinControls.UI.RadLabel radLabelExportedCells;
        private Telerik.WinControls.UI.RadButton radButtonExport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabelNumberOfExportedCells;
        private Telerik.WinControls.UI.RadLabel radLabelExportTime;
        private Telerik.WinControls.UI.RadLabel radLabelExportTimeElapsed;
        private Telerik.WinControls.UI.RadLabel radLabelSeconds;
        private Telerik.WinControls.UI.RadLabel radLabelCurrentMemory;
        private Telerik.WinControls.UI.RadLabel radLabelMemory;
        private Telerik.WinControls.UI.RadLabel radLabelMB;
        private DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }

    class DoubleBufferedTableLayoutPanel : System.Windows.Forms.TableLayoutPanel
    {
        public DoubleBufferedTableLayoutPanel()
            : base()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}