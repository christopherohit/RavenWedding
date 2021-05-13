namespace Telerik.Examples.WinControls.Scheduler.FirstLook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval2 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 = new Telerik.WinControls.RootRadElement();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radDropDownList1);
            this.settingsPanel.Location = new System.Drawing.Point(1283, 105);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.MultiViewRows = 3;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(1900, 1, 1, 0, 0, 0, 0)});
            this.radCalendar1.Size = new System.Drawing.Size(252, 530);
            this.radCalendar1.TabIndex = 1;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // object_a65e45d6_6d0c_4754_ac40_31a6d96432e9
            // 
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.MinSize = new System.Drawing.Size(400, 74);
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Name = "object_a65e45d6_6d0c_4754_ac40_31a6d96432e9";
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchHorizontally = true;
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchVertically = true;
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radSchedulerDemo;
            this.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(272, 43);
            this.radSchedulerNavigator1.MinimumSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(723, 77);
            this.radSchedulerNavigator1.TabIndex = 8;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Text = "11/02/2009 - 11/04/2009";
            // 
            // radSchedulerDemo
            // 
            dateTimeInterval2.End = new System.DateTime(((long)(0)));
            dateTimeInterval2.Start = new System.DateTime(((long)(0)));
            this.radSchedulerDemo.AccessibleInterval = dateTimeInterval2;
            this.radSchedulerDemo.AppointmentTitleFormat = null;
            this.radSchedulerDemo.Culture = new System.Globalization.CultureInfo("en-US");
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radSchedulerDemo.HeaderFormat = "dd (ddd)";
            this.radSchedulerDemo.Location = new System.Drawing.Point(272, 137);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2013, 3, 17, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2013, 3, 12, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radSchedulerDemo.PrintStyle = schedulerDailyPrintStyle2;
            this.radSchedulerDemo.Size = new System.Drawing.Size(723, 502);
            this.radSchedulerDemo.TabIndex = 0;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Controls.Add(this.radPageViewPage5);
            this.radPageView1.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageView1.Location = new System.Drawing.Point(4, 43);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(280, 596);
            this.radPageView1.TabIndex = 11;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radCalendar1);
            this.radPageViewPage1.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewCalendar;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(264F, 38F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage1.Text = "Calendar";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Notes;
            this.radPageViewPage2.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewNotes;
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(264F, 38F);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage2.Text = "Notes";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Tasks;
            this.radPageViewPage3.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewTasks;
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(264F, 38F);
            this.radPageViewPage3.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage3.Text = "Tasks";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Contacts;
            this.radPageViewPage4.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewContacts;
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(264F, 38F);
            this.radPageViewPage4.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage4.Text = "Contacts";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Mail;
            this.radPageViewPage5.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewMail;
            this.radPageViewPage5.ItemSize = new System.Drawing.SizeF(264F, 38F);
            this.radPageViewPage5.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage5.Text = "Mail";
            // 
            // radSchedulerReminder1
            // 
            this.radSchedulerReminder1.AssociatedScheduler = null;
            this.radSchedulerReminder1.ThemeName = null;
            this.radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AllowShowFocusCues = false;
            this.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownList1.AutoSize = false;
            this.radDropDownList1.Location = new System.Drawing.Point(10, 49);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(210, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 18);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Active editor:";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 87);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(184, 18);
            this.radCheckBox1.TabIndex = 15;
            this.radCheckBox1.Text = "Allow Appointments Multi Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radSchedulerDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1856, 894);
            this.Controls.SetChildIndex(this.radSchedulerDemo, 0);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.RootRadElement object_a65e45d6_6d0c_4754_ac40_31a6d96432e9;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
