namespace Telerik.Examples.WinControls.Scheduler.Timeline
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radDateTimePickerStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDateTimePickerEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorTimeSlots = new Telerik.WinControls.UI.RadSpinEditor();
            this.radRadioButtonWeek = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonMonth = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonHour = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonDay = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBoxRenderingOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorVerticalSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelVerticalSpacing = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBoxAutoSizeAppointments = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxExactTimeRendering = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBoxColumnSizing = new Telerik.WinControls.UI.RadGroupBox();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxRenderingOptions)).BeginInit();
            this.radGroupBoxRenderingOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorVerticalSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVerticalSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoSizeAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExactTimeRendering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumnSizing)).BeginInit();
            this.radGroupBoxColumnSizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBoxColumnSizing);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBoxRenderingOptions);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox3);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox2);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 832);
            this.settingsPanel.Size = new System.Drawing.Size(230, 832);
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Timeline;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2014, 6, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2014, 6, 5, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1473, 786);
            this.radScheduler1.TabIndex = 1;
            // 
            // radDateTimePickerStart
            // 
            this.radDateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDateTimePickerStart.Location = new System.Drawing.Point(5, 43);
            this.radDateTimePickerStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerStart.Name = "radDateTimePickerStart";
            this.radDateTimePickerStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.radDateTimePickerStart.TabIndex = 1;
            this.radDateTimePickerStart.TabStop = false;
            this.radDateTimePickerStart.Text = "Tuesday, 12 January, 2010";
            this.radDateTimePickerStart.Value = new System.DateTime(2010, 1, 12, 9, 56, 48, 405);
            // 
            // radDateTimePickerEnd
            // 
            this.radDateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDateTimePickerEnd.Location = new System.Drawing.Point(5, 91);
            this.radDateTimePickerEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerEnd.Name = "radDateTimePickerEnd";
            this.radDateTimePickerEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.radDateTimePickerEnd.TabIndex = 2;
            this.radDateTimePickerEnd.TabStop = false;
            this.radDateTimePickerEnd.Text = "Tuesday, 12 January, 2010";
            this.radDateTimePickerEnd.Value = new System.DateTime(2010, 1, 12, 9, 57, 3, 799);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(90, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Range Start Date";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 71);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(85, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Range End Date";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radSpinEditorTimeSlots);
            this.radGroupBox2.Controls.Add(this.radRadioButtonWeek);
            this.radGroupBox2.Controls.Add(this.radRadioButtonMonth);
            this.radGroupBox2.Controls.Add(this.radRadioButtonHour);
            this.radGroupBox2.Controls.Add(this.radRadioButtonDay);
            this.radGroupBox2.HeaderText = "Time scales";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 37);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(210, 179);
            this.radGroupBox2.TabIndex = 6;
            this.radGroupBox2.Text = "Time scales";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(5, 128);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(92, 18);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Visible Time Slots";
            // 
            // radSpinEditorTimeSlots
            // 
            this.radSpinEditorTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorTimeSlots.Location = new System.Drawing.Point(5, 148);
            this.radSpinEditorTimeSlots.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorTimeSlots.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorTimeSlots.Name = "radSpinEditorTimeSlots";
            this.radSpinEditorTimeSlots.NullableValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // 
            // 
            this.radSpinEditorTimeSlots.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorTimeSlots.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorTimeSlots.TabIndex = 8;
            this.radSpinEditorTimeSlots.TabStop = false;
            this.radSpinEditorTimeSlots.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // radRadioButtonWeek
            // 
            this.radRadioButtonWeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonWeek.Location = new System.Drawing.Point(5, 80);
            this.radRadioButtonWeek.Name = "radRadioButtonWeek";
            this.radRadioButtonWeek.Size = new System.Drawing.Size(48, 18);
            this.radRadioButtonWeek.TabIndex = 2;
            this.radRadioButtonWeek.Text = "Week";
            // 
            // radRadioButtonMonth
            // 
            this.radRadioButtonMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonMonth.Location = new System.Drawing.Point(5, 104);
            this.radRadioButtonMonth.Name = "radRadioButtonMonth";
            this.radRadioButtonMonth.Size = new System.Drawing.Size(54, 18);
            this.radRadioButtonMonth.TabIndex = 2;
            this.radRadioButtonMonth.Text = "Month";
            // 
            // radRadioButtonHour
            // 
            this.radRadioButtonHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonHour.Location = new System.Drawing.Point(5, 56);
            this.radRadioButtonHour.Name = "radRadioButtonHour";
            this.radRadioButtonHour.Size = new System.Drawing.Size(45, 18);
            this.radRadioButtonHour.TabIndex = 1;
            this.radRadioButtonHour.Text = "Hour";
            // 
            // radRadioButtonDay
            // 
            this.radRadioButtonDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButtonDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButtonDay.Location = new System.Drawing.Point(5, 32);
            this.radRadioButtonDay.Name = "radRadioButtonDay";
            this.radRadioButtonDay.Size = new System.Drawing.Size(39, 18);
            this.radRadioButtonDay.TabIndex = 0;
            this.radRadioButtonDay.Text = "Day";
            this.radRadioButtonDay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.radLabel1);
            this.radGroupBox3.Controls.Add(this.radDateTimePickerEnd);
            this.radGroupBox3.Controls.Add(this.radDateTimePickerStart);
            this.radGroupBox3.Controls.Add(this.radLabel2);
            this.radGroupBox3.HeaderText = "Date options";
            this.radGroupBox3.Location = new System.Drawing.Point(10, 222);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox3.Size = new System.Drawing.Size(210, 128);
            this.radGroupBox3.TabIndex = 7;
            this.radGroupBox3.Text = "Date options";
            // 
            // radGroupBoxRenderingOptions
            // 
            this.radGroupBoxRenderingOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxRenderingOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBoxRenderingOptions.Controls.Add(this.radSpinEditorVerticalSpacing);
            this.radGroupBoxRenderingOptions.Controls.Add(this.radLabelVerticalSpacing);
            this.radGroupBoxRenderingOptions.Controls.Add(this.radCheckBoxAutoSizeAppointments);
            this.radGroupBoxRenderingOptions.Controls.Add(this.radCheckBoxExactTimeRendering);
            this.radGroupBoxRenderingOptions.HeaderText = "Rendering options";
            this.radGroupBoxRenderingOptions.Location = new System.Drawing.Point(10, 356);
            this.radGroupBoxRenderingOptions.Name = "radGroupBoxRenderingOptions";
            this.radGroupBoxRenderingOptions.Size = new System.Drawing.Size(210, 127);
            this.radGroupBoxRenderingOptions.TabIndex = 8;
            this.radGroupBoxRenderingOptions.Text = "Rendering options";
            // 
            // radSpinEditorVerticalSpacing
            // 
            this.radSpinEditorVerticalSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorVerticalSpacing.Location = new System.Drawing.Point(5, 94);
            this.radSpinEditorVerticalSpacing.Name = "radSpinEditorVerticalSpacing";
            this.radSpinEditorVerticalSpacing.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorVerticalSpacing.TabIndex = 1;
            this.radSpinEditorVerticalSpacing.TabStop = false;
            // 
            // radLabelVerticalSpacing
            // 
            this.radLabelVerticalSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelVerticalSpacing.Location = new System.Drawing.Point(5, 70);
            this.radLabelVerticalSpacing.Name = "radLabelVerticalSpacing";
            this.radLabelVerticalSpacing.Size = new System.Drawing.Size(159, 18);
            this.radLabelVerticalSpacing.TabIndex = 1;
            this.radLabelVerticalSpacing.Text = "Appointments Vertical Spacing";
            // 
            // radCheckBoxAutoSizeAppointments
            // 
            this.radCheckBoxAutoSizeAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxAutoSizeAppointments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxAutoSizeAppointments.Location = new System.Drawing.Point(5, 46);
            this.radCheckBoxAutoSizeAppointments.Name = "radCheckBoxAutoSizeAppointments";
            this.radCheckBoxAutoSizeAppointments.Size = new System.Drawing.Size(141, 18);
            this.radCheckBoxAutoSizeAppointments.TabIndex = 0;
            this.radCheckBoxAutoSizeAppointments.Text = "Auto Size Appointments";
            this.radCheckBoxAutoSizeAppointments.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxExactTimeRendering
            // 
            this.radCheckBoxExactTimeRendering.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxExactTimeRendering.Location = new System.Drawing.Point(5, 22);
            this.radCheckBoxExactTimeRendering.Name = "radCheckBoxExactTimeRendering";
            this.radCheckBoxExactTimeRendering.Size = new System.Drawing.Size(128, 18);
            this.radCheckBoxExactTimeRendering.TabIndex = 0;
            this.radCheckBoxExactTimeRendering.Text = "Exact Time Rendering";
            // 
            // radGroupBoxColumnSizing
            // 
            this.radGroupBoxColumnSizing.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxColumnSizing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBoxColumnSizing.Controls.Add(this.radTrackBar1);
            this.radGroupBoxColumnSizing.HeaderText = "Resize the current column";
            this.radGroupBoxColumnSizing.Location = new System.Drawing.Point(10, 489);
            this.radGroupBoxColumnSizing.Name = "radGroupBoxColumnSizing";
            this.radGroupBoxColumnSizing.Size = new System.Drawing.Size(210, 86);
            this.radGroupBoxColumnSizing.TabIndex = 9;
            this.radGroupBoxColumnSizing.Text = "Resize the current column";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar1.LargeTickFrequency = 1;
            this.radTrackBar1.Location = new System.Drawing.Point(5, 21);
            this.radTrackBar1.Maximum = 10F;
            this.radTrackBar1.Minimum = 1F;
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(200, 52);
            this.radTrackBar1.TabIndex = 0;
            this.radTrackBar1.Value = 1F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 796);
            this.Tag = "";
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxRenderingOptions)).EndInit();
            this.radGroupBoxRenderingOptions.ResumeLayout(false);
            this.radGroupBoxRenderingOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorVerticalSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVerticalSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxAutoSizeAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExactTimeRendering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumnSizing)).EndInit();
            this.radGroupBoxColumnSizing.ResumeLayout(false);
            this.radGroupBoxColumnSizing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker  radDateTimePickerEnd;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerStart;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonHour;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonDay;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonWeek;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonMonth;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorTimeSlots;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxColumnSizing;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxRenderingOptions;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorVerticalSpacing;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxAutoSizeAppointments;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxExactTimeRendering;
        private Telerik.WinControls.UI.RadLabel radLabelVerticalSpacing;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    }
}