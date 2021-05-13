namespace Telerik.Examples.WinControls.Scheduler.DataBinding
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rbDataSet = new Telerik.WinControls.UI.RadRadioButton();
            this.rbBusinessObjects = new Telerik.WinControls.UI.RadRadioButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBusinessObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.btnSave);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(687, 1);
            // 
            // 
            // 
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.btnSave, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            // 
            // radSchedulerDemo
            // 
            this.radSchedulerDemo.BackColor = System.Drawing.Color.White;
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerDemo.HeaderFormat = "MMMM dd";
            this.radSchedulerDemo.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            // 
            // 
            // 
            this.radSchedulerDemo.Size = new System.Drawing.Size(888, 820);
            this.radSchedulerDemo.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.rbDataSet);
            this.radGroupBox1.Controls.Add(this.rbBusinessObjects);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = " Bind to: ";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.Size = new System.Drawing.Size(180, 90);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = " Bind to: ";
            // 
            // rbDataSet
            // 
            this.rbDataSet.AllowShowFocusCues = true;
            this.rbDataSet.Location = new System.Drawing.Point(9, 51);
            this.rbDataSet.Name = "rbDataSet";
            this.rbDataSet.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.rbDataSet.Size = new System.Drawing.Size(61, 16);
            this.rbDataSet.TabIndex = 1;
            this.rbDataSet.Text = "DataSet";
            // 
            // rbBusinessObjects
            // 
            this.rbBusinessObjects.AllowShowFocusCues = true;
            this.rbBusinessObjects.Location = new System.Drawing.Point(9, 29);
            this.rbBusinessObjects.Name = "rbBusinessObjects";
            this.rbBusinessObjects.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.rbBusinessObjects.Size = new System.Drawing.Size(108, 16);
            this.rbBusinessObjects.TabIndex = 0;
            this.rbBusinessObjects.Text = "Business Objects";
            // 
            // btnSave
            // 
            this.btnSave.AllowShowFocusCues = true;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(10, 102);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.Size = new System.Drawing.Size(180, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save changes";
           
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(10, 126);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.Size = new System.Drawing.Size(92, 12);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "updates the database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radSchedulerDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(888, 820);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbBusinessObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
		private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
		private Telerik.WinControls.UI.RadRadioButton rbDataSet;
		private Telerik.WinControls.UI.RadRadioButton rbBusinessObjects;
		private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
