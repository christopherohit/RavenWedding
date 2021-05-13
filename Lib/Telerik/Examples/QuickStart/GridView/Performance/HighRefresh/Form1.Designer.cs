using Telerik.QuickStart.WinControls;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
{
    partial class Form1 : ExamplesForm
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
            this.components = new Container();
            this.infoCountLabel = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.infoAverageLabel = new Telerik.WinControls.UI.RadLabel();
            this.countResultLabel = new Telerik.WinControls.UI.RadLabel();
            this.averageResultLabel = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLblAverage = new Telerik.WinControls.UI.RadLabel();
            this.radLblRefreshCount = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCountLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAverageLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countResultLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageResultLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblRefreshCount)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(796, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 715);
            // 
            // infoCountLabel
            // 
            this.infoCountLabel.AutoSize = false;
            this.infoCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoCountLabel.ForeColor = System.Drawing.Color.Red;
            this.infoCountLabel.Location = new System.Drawing.Point(12, 793);
            this.infoCountLabel.Name = "infoCountLabel";
            // 
            // 
            // 
            this.infoCountLabel.RootElement.StretchHorizontally = true;
            this.infoCountLabel.RootElement.StretchVertically = true;
            this.infoCountLabel.Size = new System.Drawing.Size(113, 21);
            this.infoCountLabel.TabIndex = 1;
            this.infoCountLabel.Text = "Refresh Count: ";
            this.infoCountLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoCountLabel.Visible = false;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 48);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(980, 766);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            // 
            // infoAverageLabel
            // 
            this.infoAverageLabel.AutoSize = false;
            this.infoAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoAverageLabel.ForeColor = System.Drawing.Color.Red;
            this.infoAverageLabel.Location = new System.Drawing.Point(237, 793);
            this.infoAverageLabel.Name = "infoAverageLabel";
            // 
            // 
            // 
            this.infoAverageLabel.RootElement.StretchHorizontally = true;
            this.infoAverageLabel.RootElement.StretchVertically = true;
            this.infoAverageLabel.Size = new System.Drawing.Size(172, 21);
            this.infoAverageLabel.TabIndex = 2;
            this.infoAverageLabel.Text = "Average Refresh Time: ";
            this.infoAverageLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoAverageLabel.Visible = false;
            // 
            // countResultLabel
            // 
            this.countResultLabel.AutoSize = false;
            this.countResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countResultLabel.ForeColor = System.Drawing.Color.Red;
            this.countResultLabel.Location = new System.Drawing.Point(117, 793);
            this.countResultLabel.Name = "countResultLabel";
            // 
            // 
            // 
            this.countResultLabel.RootElement.StretchHorizontally = true;
            this.countResultLabel.RootElement.StretchVertically = true;
            this.countResultLabel.Size = new System.Drawing.Size(15, 21);
            this.countResultLabel.TabIndex = 2;
            this.countResultLabel.Text = "x";
            this.countResultLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.countResultLabel.Visible = false;
            // 
            // averageResultLabel
            // 
            this.averageResultLabel.AutoSize = false;
            this.averageResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageResultLabel.ForeColor = System.Drawing.Color.Red;
            this.averageResultLabel.Location = new System.Drawing.Point(402, 793);
            this.averageResultLabel.Name = "averageResultLabel";
            // 
            // 
            // 
            this.averageResultLabel.RootElement.StretchHorizontally = true;
            this.averageResultLabel.RootElement.StretchVertically = true;
            this.averageResultLabel.Size = new System.Drawing.Size(15, 21);
            this.averageResultLabel.TabIndex = 3;
            this.averageResultLabel.Text = "x";
            this.averageResultLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.averageResultLabel.Visible = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLblAverage);
            this.radPanel1.Controls.Add(this.radLblRefreshCount);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(980, 48);
            this.radPanel1.TabIndex = 4;
            // 
            // radLblAverage
            // 
            this.radLblAverage.Location = new System.Drawing.Point(3, 28);
            this.radLblAverage.Name = "radLblAverage";
            this.radLblAverage.Size = new System.Drawing.Size(0, 0);
            this.radLblAverage.TabIndex = 1;
            // 
            // radLblRefreshCount
            // 
            this.radLblRefreshCount.Location = new System.Drawing.Point(3, 8);
            this.radLblRefreshCount.Name = "radLblRefreshCount";
            this.radLblRefreshCount.Size = new System.Drawing.Size(80, 14);
            this.radLblRefreshCount.TabIndex = 0;
            this.radLblRefreshCount.Text = "Refresh Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.averageResultLabel);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.countResultLabel);
            this.Controls.Add(this.infoAverageLabel);
            this.Controls.Add(this.infoCountLabel);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 717);
            this.Controls.SetChildIndex(this.infoCountLabel, 0);
            this.Controls.SetChildIndex(this.infoAverageLabel, 0);
            this.Controls.SetChildIndex(this.countResultLabel, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.averageResultLabel, 0);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCountLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAverageLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countResultLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageResultLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblRefreshCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel infoCountLabel;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel infoAverageLabel;
        private Telerik.WinControls.UI.RadLabel countResultLabel;
        private Telerik.WinControls.UI.RadLabel averageResultLabel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLblRefreshCount;
        private Telerik.WinControls.UI.RadLabel radLblAverage;
    }
}