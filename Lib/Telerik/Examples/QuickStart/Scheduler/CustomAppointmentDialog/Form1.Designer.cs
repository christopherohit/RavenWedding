namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
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
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1016, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 832);

            // 
            // radSchedulerDemo
            // 
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radSchedulerDemo.HeaderFormat = "dd dddd";
            this.radSchedulerDemo.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            this.radSchedulerDemo.Size = new System.Drawing.Size(1217, 834);
            this.radSchedulerDemo.TabIndex = 0;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSchedulerDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1217, 834);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
    }
}
