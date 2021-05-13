namespace ExportWithDpl.SpreadsheetStreamingExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabelExportedCells = new Telerik.WinControls.UI.RadLabel();
            this.radLabelNumberOfExportedCells = new Telerik.WinControls.UI.RadLabel();
            this.radLabelExportTime = new Telerik.WinControls.UI.RadLabel();
            this.radLabelExportTimeElapsed = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSeconds = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCurrentMemory = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMemory = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMB = new Telerik.WinControls.UI.RadLabel();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.radProgressBarExportProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.radDropDownListExtension = new Telerik.WinControls.UI.RadDropDownList();
            this.radSpinEditorRowsCount = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelExtension = new Telerik.WinControls.UI.RadLabel();
            this.radLabelRowsCount = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfExportedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTimeElapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExportProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(187)))), ((int)(((byte)(162)))));
            this.radLabel1.Location = new System.Drawing.Point(2, 7);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(255, 28);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Large Document Export";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 549);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(850, 24);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // radLabelExportedCells
            // 
            this.radLabelExportedCells.Location = new System.Drawing.Point(3, 3);
            this.radLabelExportedCells.Name = "radLabelExportedCells";
            this.radLabelExportedCells.Size = new System.Drawing.Size(78, 18);
            this.radLabelExportedCells.TabIndex = 1;
            this.radLabelExportedCells.Text = "Exported cells:";
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
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(692, 437);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(150, 24);
            this.radButtonExport.TabIndex = 12;
            this.radButtonExport.Text = "Export";
            // 
            // radProgressBarExportProgress
            // 
            this.radProgressBarExportProgress.Location = new System.Drawing.Point(2, 485);
            this.radProgressBarExportProgress.Name = "radProgressBarExportProgress";
            this.radProgressBarExportProgress.Size = new System.Drawing.Size(840, 24);
            this.radProgressBarExportProgress.TabIndex = 11;
            // 
            // radDropDownListExtension
            // 
            this.radDropDownListExtension.DropDownAnimationEnabled = false;
            this.radDropDownListExtension.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem3.Text = "Xlsx";
            radListDataItem4.Text = "Csv";
            this.radDropDownListExtension.Items.Add(radListDataItem3);
            this.radDropDownListExtension.Items.Add(radListDataItem4);
            this.radDropDownListExtension.Location = new System.Drawing.Point(438, 439);
            this.radDropDownListExtension.Name = "radDropDownListExtension";
            this.radDropDownListExtension.Size = new System.Drawing.Size(125, 20);
            this.radDropDownListExtension.TabIndex = 10;
            this.radDropDownListExtension.Text = "Xlsx";
            // 
            // radSpinEditorRowsCount
            // 
            this.radSpinEditorRowsCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radSpinEditorRowsCount.Location = new System.Drawing.Point(107, 439);
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
            this.radSpinEditorRowsCount.Size = new System.Drawing.Size(119, 20);
            this.radSpinEditorRowsCount.TabIndex = 9;
            this.radSpinEditorRowsCount.TabStop = false;
            this.radSpinEditorRowsCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // radLabelExtension
            // 
            this.radLabelExtension.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelExtension.Location = new System.Drawing.Point(311, 442);
            this.radLabelExtension.Name = "radLabelExtension";
            this.radLabelExtension.Size = new System.Drawing.Size(61, 18);
            this.radLabelExtension.TabIndex = 7;
            this.radLabelExtension.Text = "Extension:";
            // 
            // radLabelRowsCount
            // 
            this.radLabelRowsCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelRowsCount.Location = new System.Drawing.Point(5, 442);
            this.radLabelRowsCount.Name = "radLabelRowsCount";
            this.radLabelRowsCount.Size = new System.Drawing.Size(71, 18);
            this.radLabelRowsCount.TabIndex = 8;
            this.radLabelRowsCount.Text = "Rows count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 598);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radButtonExport);
            this.Controls.Add(this.radProgressBarExportProgress);
            this.Controls.Add(this.radDropDownListExtension);
            this.Controls.Add(this.radSpinEditorRowsCount);
            this.Controls.Add(this.radLabelExtension);
            this.Controls.Add(this.radLabelRowsCount);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNumberOfExportedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExportTimeElapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBarExportProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabelExportedCells;
        private Telerik.WinControls.UI.RadLabel radLabelNumberOfExportedCells;
        private Telerik.WinControls.UI.RadLabel radLabelExportTime;
        private Telerik.WinControls.UI.RadLabel radLabelExportTimeElapsed;
        private Telerik.WinControls.UI.RadLabel radLabelSeconds;
        private Telerik.WinControls.UI.RadLabel radLabelCurrentMemory;
        private Telerik.WinControls.UI.RadLabel radLabelMemory;
        private Telerik.WinControls.UI.RadLabel radLabelMB;
        private Telerik.WinControls.UI.RadButton radButtonExport;
        private Telerik.WinControls.UI.RadProgressBar radProgressBarExportProgress;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListExtension;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorRowsCount;
        private Telerik.WinControls.UI.RadLabel radLabelExtension;
        private Telerik.WinControls.UI.RadLabel radLabelRowsCount;
    }
}