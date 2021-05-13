namespace Telerik.Examples.WinControls.Scheduler.Holidays
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
            this.timePickerRulerStart = new Telerik.WinControls.UI.RadTimePicker();
            this.timePickerRulerEnd = new Telerik.WinControls.UI.RadTimePicker();
            this.radButtonImportFromOutlook = new Telerik.WinControls.UI.RadButton();
            this.radCheckedDDLHolidays = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.radCheckBoxColorCells = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerRulerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerRulerEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonImportFromOutlook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedDDLHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColorCells)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxColorCells);
            this.settingsPanel.Controls.Add(this.radCheckedDDLHolidays);
            this.settingsPanel.Controls.Add(this.radButtonImportFromOutlook);
            this.settingsPanel.Location = new System.Drawing.Point(1065, 80);
            this.settingsPanel.Size = new System.Drawing.Size(230, 719);
            this.settingsPanel.Controls.SetChildIndex(this.radButtonImportFromOutlook, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckedDDLHolidays, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxColorCells, 0);
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2014, 6, 15, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2014, 6, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1503, 651);
            this.radScheduler1.TabIndex = 2;
            // 
            // timePickerRulerStart
            // 
            this.timePickerRulerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePickerRulerStart.Location = new System.Drawing.Point(90, 3);
            this.timePickerRulerStart.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.timePickerRulerStart.MinValue = new System.DateTime(((long)(0)));
            this.timePickerRulerStart.Name = "timePickerRulerStart";
            this.timePickerRulerStart.Size = new System.Drawing.Size(107, 20);
            this.timePickerRulerStart.TabIndex = 8;
            this.timePickerRulerStart.TabStop = false;
            this.timePickerRulerStart.Value = new System.DateTime(2014, 6, 9, 14, 58, 13, 0);
            // 
            // timePickerRulerEnd
            // 
            this.timePickerRulerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePickerRulerEnd.Location = new System.Drawing.Point(90, 29);
            this.timePickerRulerEnd.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.timePickerRulerEnd.MinValue = new System.DateTime(((long)(0)));
            this.timePickerRulerEnd.Name = "timePickerRulerEnd";
            this.timePickerRulerEnd.Size = new System.Drawing.Size(107, 20);
            this.timePickerRulerEnd.TabIndex = 9;
            this.timePickerRulerEnd.TabStop = false;
            this.timePickerRulerEnd.Value = new System.DateTime(2014, 6, 9, 14, 58, 13, 0);
            // 
            // radButtonImportFromOutlook
            // 
            this.radButtonImportFromOutlook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonImportFromOutlook.Location = new System.Drawing.Point(10, 49);
            this.radButtonImportFromOutlook.Name = "radButtonImportFromOutlook";
            this.radButtonImportFromOutlook.Size = new System.Drawing.Size(210, 24);
            this.radButtonImportFromOutlook.TabIndex = 1;
            this.radButtonImportFromOutlook.Text = "Import Outlook Holidays File";
            this.radButtonImportFromOutlook.Click += new System.EventHandler(this.radButtonImportFromOutlook_Click);
            // 
            // radCheckedDDLHolidays
            // 
            this.radCheckedDDLHolidays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckedDDLHolidays.Location = new System.Drawing.Point(10, 134);
            this.radCheckedDDLHolidays.Name = "radCheckedDDLHolidays";
            this.radCheckedDDLHolidays.NullText = "Holidays";
            this.radCheckedDDLHolidays.Size = new System.Drawing.Size(210, 20);
            this.radCheckedDDLHolidays.TabIndex = 3;
            this.radCheckedDDLHolidays.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.radCheckedDDLHolidays_ItemCheckedChanged);
            // 
            // radCheckBoxColorCells
            // 
            this.radCheckBoxColorCells.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxColorCells.Location = new System.Drawing.Point(10, 95);
            this.radCheckBoxColorCells.Name = "radCheckBoxColorCells";
            this.radCheckBoxColorCells.Size = new System.Drawing.Size(85, 18);
            this.radCheckBoxColorCells.TabIndex = 4;
            this.radCheckBoxColorCells.Text = "Colorize cells";
            this.radCheckBoxColorCells.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxColorCells.CheckStateChanged += new System.EventHandler(this.radCheckBoxColorCells_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1513, 661);
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerRulerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerRulerEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonImportFromOutlook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedDDLHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColorCells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadTimePicker timePickerRulerStart;
        private Telerik.WinControls.UI.RadTimePicker timePickerRulerEnd;
        private Telerik.WinControls.UI.RadCheckedDropDownList radCheckedDDLHolidays;
        private Telerik.WinControls.UI.RadButton radButtonImportFromOutlook;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColorCells;
    }
}