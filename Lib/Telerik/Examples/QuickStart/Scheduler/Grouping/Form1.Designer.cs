namespace Telerik.Examples.WinControls.Scheduler.Grouping
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox4);
            this.settingsPanel.Location = new System.Drawing.Point(1042, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 269);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox4, 0);
            // 
            // radSchedulerDemo
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radSchedulerDemo.AccessibleInterval = dateTimeInterval1;
            this.radSchedulerDemo.Culture = new System.Globalization.CultureInfo("en-US");
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerDemo.HeaderFormat = "MMMM dd";
            this.radSchedulerDemo.Location = new System.Drawing.Point(0, 77);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2014, 6, 15, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2014, 6, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radSchedulerDemo.PrintStyle = schedulerDailyPrintStyle1;
            this.radSchedulerDemo.Size = new System.Drawing.Size(1289, 845);
            this.radSchedulerDemo.TabIndex = 0;
            this.radSchedulerDemo.Text = "radScheduler1";
            this.radSchedulerDemo.CellSelectionChanged += new System.EventHandler(this.radSchedulerDemo_CellSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = null;
            this.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.MinimumSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1289, 77);
            this.radSchedulerNavigator1.TabIndex = 0;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar1.LargeTickFrequency = 1;
            this.radTrackBar1.Location = new System.Drawing.Point(5, 24);
            this.radTrackBar1.Maximum = 10F;
            this.radTrackBar1.Minimum = 1F;
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(170, 55);
            this.radTrackBar1.TabIndex = 1;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.Value = 1F;
            this.radTrackBar1.ValueChanged += new System.EventHandler(this.radTrackBar1_ValueChanged);
            this.radTrackBar1.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(this.radTrackBar1_ToolTipTextNeeded);
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox4.Controls.Add(this.radTrackBar1);
            this.radGroupBox4.HeaderText = "Resize the selected resource";
            this.radGroupBox4.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(180, 84);
            this.radGroupBox4.TabIndex = 5;
            this.radGroupBox4.Text = "Resize the selected resource";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radSchedulerDemo);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1299, 932);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
    }
}
