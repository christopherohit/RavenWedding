namespace Telerik.Examples.WinControls.Scheduler.Reminder
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
            this.components = new System.ComponentModel.Container();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonCustom = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonDefault = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radSpinEditor1);
            this.settingsPanel.Controls.Add(this.radButton1);
            this.settingsPanel.Location = new System.Drawing.Point(979, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 476);

            this.settingsPanel.Controls.SetChildIndex(this.radButton1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinEditor1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(10, 216);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(180, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Start";
 
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 57);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(129, 16);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "TimeInterval in seconds:";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditor1.Location = new System.Drawing.Point(10, 79);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.radSpinEditor1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radSpinEditor1.Name = "radSpinEditor1";
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.ShowBorder = true;
            this.radSpinEditor1.Size = new System.Drawing.Size(180, 20);
            this.radSpinEditor1.TabIndex = 3;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // radScheduler1
            // 
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 74);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Size = new System.Drawing.Size(1180, 404);
            this.radScheduler1.TabIndex = 1;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStep = 1;
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1180, 74);
            this.radSchedulerNavigator1.TabIndex = 2;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // radSchedulerReminder1
            // 
            this.radSchedulerReminder1.AssociatedScheduler = this.radScheduler1;
            //this.radSchedulerReminder1.StartNotification = System.TimeSpan.Parse("00:15:00");
            this.radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioButtonCustom);
            this.radGroupBox1.Controls.Add(this.radRadioButtonDefault);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Alarm Form";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 110);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 80);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Alarm Form";
            // 
            // radRadioButtonCustom
            // 
            this.radRadioButtonCustom.Location = new System.Drawing.Point(13, 47);
            this.radRadioButtonCustom.Name = "radRadioButtonCustom";
            this.radRadioButtonCustom.Size = new System.Drawing.Size(143, 18);
            this.radRadioButtonCustom.TabIndex = 1;
            this.radRadioButtonCustom.Text = "Custom Alarm Form";
        
            // 
            // radRadioButtonDefault
            // 
            this.radRadioButtonDefault.Location = new System.Drawing.Point(13, 23);
            this.radRadioButtonDefault.Name = "radRadioButtonDefault";
            this.radRadioButtonDefault.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonDefault.TabIndex = 0;
            this.radRadioButtonDefault.Text = "Default";
            this.radRadioButtonDefault.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1180, 478);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonCustom;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonDefault;
    }
}