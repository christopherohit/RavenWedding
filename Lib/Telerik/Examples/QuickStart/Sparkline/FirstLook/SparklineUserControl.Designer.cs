namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    partial class SparklineUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alertLabel = new Telerik.WinControls.UI.RadLabel();
            this.radSparkline1 = new Telerik.WinControls.UI.RadSparkline();
            this.timeLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.alertLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSparkline1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.alertLabel.AutoSize = false;
            this.alertLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.alertLabel.Location = new System.Drawing.Point(0, 0);
            this.alertLabel.Name = "radLabel1";
            this.alertLabel.Size = new System.Drawing.Size(16, 35);
            this.alertLabel.TabIndex = 0;
            this.alertLabel.Text = "!";
            // 
            // radSparkline1
            // 
            this.radSparkline1.AxisDrawMode = Telerik.WinControls.UI.AxisDrawMode.BelowSeries;
            this.radSparkline1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSparkline1.Location = new System.Drawing.Point(16, 0);
            this.radSparkline1.Name = "radSparkline1";
            this.radSparkline1.Size = new System.Drawing.Size(159, 35);
            this.radSparkline1.TabIndex = 1;
            this.radSparkline1.Text = "radSparkline1";
            // 
            // radLabel2
            // 
            this.timeLabel.AutoSize = false;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Location = new System.Drawing.Point(175, 0);
            this.timeLabel.Name = "radLabel2";
            this.timeLabel.Size = new System.Drawing.Size(55, 35);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "time";
            // 
            // SparklineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSparkline1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.alertLabel);
            this.Name = "SparklineUserControl";
            this.Size = new System.Drawing.Size(230, 35);
            ((System.ComponentModel.ISupportInitialize)(this.alertLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSparkline1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel alertLabel;
        private Telerik.WinControls.UI.RadSparkline radSparkline1;
        private Telerik.WinControls.UI.RadLabel timeLabel;
    }
}
