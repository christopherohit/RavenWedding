using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.Holidays
{
    public partial class Form1 : ExamplesForm
    {
        private string resourceName = "Telerik.Examples.WinControls.Scheduler.Holidays.holidays.hol";
        private string fileName = string.Empty;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            this.timer = new Timer();
            this.timer.Tick += Timer_Tick;
            this.timer.Interval = 300;

            this.LoadSettings();
            this.radScheduler1.SelectionBehavior.SelectCell(this.radScheduler1.ViewElement.GetCellAtPosition(0, 0));
            this.radScheduler1.CellFormatting += RadScheduler1_CellFormatting;
            this.radScheduler1.ShowNavigationElements = true;
            this.radScheduler1.AllowAppointmentsMultiSelect = false;

            this.radCheckedDDLHolidays.LocationChanged += radCheckedDDLHolidays_LocationChanged;
        }

        void radCheckedDDLHolidays_LocationChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("DDL Location: " + this.radCheckedDDLHolidays.Location);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ((RadCheckedListDataItem)this.radCheckedDDLHolidays.Items.Last()).Checked = true;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.timer.Tick -= Timer_Tick;
            this.timer.Dispose();
            this.timer = null;

            this.radCheckedDDLHolidays.ShowDropDown();
        }

        private void LoadSettings()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                var source = this.radScheduler1.Holidays.GetAllLocations(stream);
                this.radCheckedDDLHolidays.DataSource = source;
            }
        }

        private void radCheckedDDLHolidays_ItemCheckedChanged(object sender, RadCheckedListDataItemEventArgs e)
        {
            this.radScheduler1.Appointments.Clear();
            this.radScheduler1.Holidays.Clear();
            if (string.IsNullOrEmpty(this.fileName))
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    this.radScheduler1.Holidays.ReadHolidays(stream, true, this.radCheckedDDLHolidays.CheckedItems.Select(l => l.Text));
                }
            }
            else
            {
                this.radScheduler1.Holidays.ReadHolidays(this.fileName, true, this.radCheckedDDLHolidays.CheckedItems.Select(l => l.Text));
            }

            this.radScheduler1.ViewElement.View.StartDate = FindFirstHoliday();
        }

        private void RadScheduler1_CellFormatting(object sender, SchedulerCellEventArgs e)
        {
            if( !this.radCheckBoxColorCells.IsChecked)
            {
                return;
            }

            if (!(e.CellElement is SchedulerHeaderCellElement))
            {
                if (this.radScheduler1.Holidays.IsHoliday(e.CellElement.Date))
                {
                    string s = string.Empty;
                    foreach (var item in this.radScheduler1.Holidays.GetHolidays(e.CellElement.Date).OrderBy(ae=>ae.HolidayName))
                    {
                        if( !s.Contains(item.HolidayName))
                            s += item.HolidayName + Environment.NewLine;
                    }

                    e.CellElement.DrawText = true;
                    e.CellElement.Text = s.ToString();
                    e.CellElement.TextWrap = true;
                    e.CellElement.TextAlignment = ContentAlignment.BottomCenter;
                    Padding padding = e.CellElement.Padding;
                    if( this.radScheduler1.ActiveViewType == SchedulerViewType.Month)
                        padding.Bottom = 22;
                    e.CellElement.Padding = padding;

                    if (this.radScheduler1.Holidays.GetHolidays(e.CellElement.Date).Where(l => l.Location == "Bulgaria").Any())
                        e.CellElement.BackColor = Color.LightGreen;
                    else
                        e.CellElement.BackColor = Color.Orange;
                }
                else
                {
                    e.CellElement.DrawText = false;
                    e.CellElement.ResetValue(RadItem.BackColorProperty, ValueResetFlags.Local);
                }
            }
        }

        private DateTime FindFirstHoliday()
        {
            DateTime now = DateTime.Today;
            IEnumerable<Holiday> holidays = this.radScheduler1.Holidays.Where(hol => hol.Date >= now);
            if (!holidays.Any())
            {
                return now;
            }

            TimeSpan minDistance = holidays.Min(hol => (hol.Date - now).Duration());
            return holidays.First(hol => (hol.Date - now).Duration() == minDistance).Date;
        }

        private void radCheckBoxColorCells_CheckStateChanged(object sender, EventArgs e)
        {
            this.radScheduler1.SchedulerElement.RefreshViewElement();
        }

        private void radButtonImportFromOutlook_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "outlookhol_7130_5000_en - us.hol";
            openFileDialog.DefaultExt = "*.hol";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radScheduler1.Appointments.Clear();
                this.radScheduler1.Holidays.Clear();
                this.fileName = openFileDialog.FileName;
                var source = this.radScheduler1.Holidays.GetAllLocations(this.fileName);
                this.radCheckedDDLHolidays.DataSource = source;
            }
        }
    }
}
