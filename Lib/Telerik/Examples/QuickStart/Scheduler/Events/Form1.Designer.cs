namespace Telerik.Examples.WinControls.Scheduler.Events
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTxtEventList = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupEventLog = new Telerik.WinControls.UI.RadGroupBox();
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEventList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEventLog)).BeginInit();
            this.radGroupEventLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupEventLog);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1016, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 832);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEventLog, 0);
            // 
            // radTxtEventList
            // 
            this.radTxtEventList.AutoScroll = true;
            this.radTxtEventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTxtEventList.Location = new System.Drawing.Point(6, 23);
            this.radTxtEventList.Multiline = true;
            this.radTxtEventList.Name = "radTxtEventList";
            // 
            // 
            // 
            this.radTxtEventList.RootElement.StretchVertically = true;
            this.radTxtEventList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.radTxtEventList.Size = new System.Drawing.Size(162, 415);
            this.radTxtEventList.TabIndex = 1;
            this.radTxtEventList.TabStop = false;
            // 
            // radGroupEventLog
            // 
            this.radGroupEventLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupEventLog.AutoScroll = true;
            this.radGroupEventLog.Controls.Add(this.radTxtEventList);
            this.radGroupEventLog.FooterImageIndex = -1;
            this.radGroupEventLog.FooterImageKey = "";
            this.radGroupEventLog.FooterText = "";
            this.radGroupEventLog.HeaderImageIndex = -1;
            this.radGroupEventLog.HeaderImageKey = "";
            this.radGroupEventLog.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupEventLog.HeaderText = "Event Log";
            this.radGroupEventLog.Location = new System.Drawing.Point(10, 8);
            this.radGroupEventLog.Name = "radGroupEventLog";
            this.radGroupEventLog.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupEventLog.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupEventLog.Size = new System.Drawing.Size(180, 445);
            this.radGroupEventLog.TabIndex = 0;
            this.radGroupEventLog.Text = "Event Log";
            // 
            // radSchedulerDemo
            // 
            this.radSchedulerDemo.BackColor = System.Drawing.Color.White;
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerDemo.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radSchedulerDemo.HeaderFormat = "dd dddd";
            this.radSchedulerDemo.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            // 
            // 
            // 
            this.radSchedulerDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSchedulerDemo.Size = new System.Drawing.Size(1217, 834);
            this.radSchedulerDemo.TabIndex = 0;
            this.radSchedulerDemo.Text = "radScheduler1";
          
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.radSchedulerDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1217, 834);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEventList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEventLog)).EndInit();
            this.radGroupEventLog.ResumeLayout(false);
            this.radGroupEventLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
        private Telerik.WinControls.UI.RadTextBox radTxtEventList;
        private Telerik.WinControls.UI.RadGroupBox radGroupEventLog;
    }
}
