using System;
using System.Windows.Forms;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
{
    public partial class CustomEditAppointmentDialog : RadSchedulerDialog, IEditAppointmentDialog
    {
        #region fields

        private static readonly TimeSpan EndOfDayTimeSpan = new TimeSpan(23, 59, 59);
        private static readonly TimeSpan StartOfDayTimeSpan = new TimeSpan(0, 0, 0);

        private IEvent appointment = null;
        private ISchedulerData schedulerData = null;
        protected IOpenRecurringAppointmentDialog openRecurringAppointmentDialog = null;

        private IEvent recurringAppointment = null;
        private bool saveRecurringAppointment = false;

        #endregion

        #region constructors

        public CustomEditAppointmentDialog()
        {
            InitializeComponent();

            WireEvents();
        }

        #endregion

        #region IEditAppointmentDialog Members

        public bool EditAppointment(IEvent appointment, ISchedulerData schedulerData)
        {
            this.appointment = appointment;
            this.schedulerData = schedulerData;

            // show OpenRecurringAppointmentDialog
            if (this.appointment != null && this.appointment.MasterEvent != null)
            {
                if (this.openRecurringAppointmentDialog == null)
                {
                    this.openRecurringAppointmentDialog = new OpenRecurringAppointmentDialog();
                }
                this.openRecurringAppointmentDialog.ThemeName = this.ThemeName;
                this.openRecurringAppointmentDialog.EventName = appointment.Summary;
                DialogResult result = this.openRecurringAppointmentDialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return false;
                }

                bool editOccurrence = this.openRecurringAppointmentDialog.EditOccurrence;
                if (!editOccurrence)
                {
                    this.appointment = this.appointment.MasterEvent as OutlookLikeAppointment;
                }
            }

            return true;
        }

        public void ShowRecurrenceDialog()
        {
            // initialize the recurringAppointment as OutlookLikeAppointment
            if (this.recurringAppointment == null)
            {
                this.recurringAppointment = new OutlookLikeAppointment();
            }

            // set settings
            this.recurringAppointment.Start = this.GetAppointmentStart();
            this.recurringAppointment.End = this.GetAppointmentEnd();
            if (!this.RecurrenceSettingsShouldBeSaved() && this.appointment.RecurrenceRule != null)
            {
                this.recurringAppointment.RecurrenceRule = this.appointment.RecurrenceRule.Clone();
            }

            // show EditRecurrenceDialog
            IEditRecurrenceDialog editRecurrenceDialog = new EditRecurrenceDialog(recurringAppointment, this.schedulerData);
            editRecurrenceDialog.ThemeName = this.ThemeName;
            DialogResult result = editRecurrenceDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.saveRecurringAppointment = true;

                this.SetStartDateAndTime(this.recurringAppointment.Start);
                this.SetEndDateAndTime(this.recurringAppointment.End);

                ApplyRecurrenceBehavior(this.recurringAppointment);
            }
        }

        #endregion

        #region events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.saveRecurringAppointment = false;
            this.recurringAppointment = null;

            // load appointment settings and controls data
            this.LoadStatuses();
            this.LoadSettingsFromEvent(this.appointment);
            this.ApplyRecurrenceBehavior(this.appointment);

            this.btnRecurrence.Enabled = (this.appointment.MasterEvent == null);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.txtSubject.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ApplySettingsToEvent(this.appointment);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.schedulerData != null)
            {
                this.schedulerData.GetEventStorage().Remove(this.appointment);
            }

            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnRecurrence_Click(object sender, EventArgs e)
        {
            this.ShowRecurrenceDialog();
        }

        #endregion

        #region private methods

        private void LoadStatuses()
        {
            if (this.schedulerData == null)
            {
                return;
            }

            ISchedulerStorage<IAppointmentStatusInfo> statusStorage = this.schedulerData.GetStatusStorage();
            this.cmbShowTimeAs.BeginUpdate();
            this.cmbShowTimeAs.Items.Clear();
            foreach (IAppointmentStatusInfo status in statusStorage)
            {
                this.cmbShowTimeAs.Items.Add(new RadListDataItem(status.DisplayName, status.Id));
            }

            if (this.cmbShowTimeAs.Items.Count > 0)
            {
                this.cmbShowTimeAs.SelectedIndex = 0;
            }

            this.cmbShowTimeAs.EndUpdate();
        }


        private void ApplySettingsToEvent(IEvent targetEvent)
        {
            // appointment settings
            targetEvent.Summary = this.txtSubject.Text;
            targetEvent.Location = this.txtLocation.Text;
            targetEvent.Description = this.txtDescription.Text;

            object selectedStatus = this.cmbShowTimeAs.SelectedValue;
            targetEvent.StatusId = (selectedStatus != null) ? (int)selectedStatus : 1;

            targetEvent.Start = this.GetAppointmentStart();
            targetEvent.End = this.GetAppointmentEnd();

            if (this.RecurrenceSettingsShouldBeSaved())
            {
                targetEvent.RecurrenceRule = this.recurringAppointment.RecurrenceRule;
            }

            // if we are editing an occurrence, add an exception
            if (targetEvent.MasterEvent != null) 
            {
                if (!targetEvent.MasterEvent.Exceptions.Contains(targetEvent))
                {
                    if (targetEvent.RecurrenceId == null)
                    {
                        targetEvent.RecurrenceId = targetEvent.Start;
                    }
                    targetEvent.MasterEvent.Exceptions.Add(targetEvent);
                }
            }

            // OutlookLike settings
            OutlookLikeAppointment outlookAppointment = targetEvent as OutlookLikeAppointment;
            if (outlookAppointment == null)
                return;
            outlookAppointment.Email = this.txtEmail.Text;
        }

        private void LoadSettingsFromEvent(IEvent sourceEvent)
        {
            // appointment settings
            this.txtSubject.Text = sourceEvent.Summary;
            this.txtLocation.Text = sourceEvent.Location;
            this.txtDescription.Text = sourceEvent.Description;

            this.cmbShowTimeAs.SelectedValue = sourceEvent.StatusId;

            this.SetStartDateAndTime(sourceEvent.Start);
            this.SetEndDateAndTime(sourceEvent.End);

            double totalHours = sourceEvent.Duration.TotalHours;
            bool isAllDay = totalHours >= 23.99 && Math.Round(totalHours) % 24 == 0;
            this.chkAllDay.ToggleState = isAllDay ? ToggleState.On : ToggleState.Off;

            if (this.appointment != null && this.schedulerData != null)
            {
                this.btnDelete.Enabled = schedulerData.GetEventStorage().Contains(this.appointment) && sourceEvent.AllowDelete;
            }

            this.SetTimePickersEnabledState(isAllDay);

            // OutlookLike settings
            OutlookLikeAppointment outlookAppointment = sourceEvent as OutlookLikeAppointment;
            if (outlookAppointment == null)
            {
                this.txtEmail.Text = String.Empty;
                return;
            }
            this.txtEmail.Text = outlookAppointment.Email;
        }


        private void ApplyRecurrenceBehavior(IEvent appointment)
        {
            bool isOutlookBehavior = false;
            Telerik.WinControls.UI.RadScheduler scheduler = this.schedulerData as Telerik.WinControls.UI.RadScheduler;

            if (scheduler != null)
            {
                if (appointment != null && appointment.RecurrenceRule != null)
                {
                    isOutlookBehavior = true;
                }
            }

            this.dateStart.Enabled = !isOutlookBehavior;
            this.dateEnd.Enabled = !isOutlookBehavior;
            this.timeStart.Enabled = !isOutlookBehavior && !this.chkAllDay.Checked;
            this.timeEnd.Enabled = !isOutlookBehavior && !this.chkAllDay.Checked;
            this.chkAllDay.Visible = !isOutlookBehavior;
        }

        private bool RecurrenceSettingsShouldBeSaved()
        {
            return this.saveRecurringAppointment && this.recurringAppointment != null;
        }

        private void SetTimePickersEnabledState(bool allDay)
        {
            bool enabled = !allDay;
            this.timeStart.Enabled = enabled;
            this.timeEnd.Enabled = enabled;
        }


        private DateTime GetAppointmentStart()
        {
            DateTime startDate = this.dateStart.Value.Date;

            if (!(this.chkAllDay.ToggleState == ToggleState.On))
            {
                TimeSpan startTime = this.timeStart.Value.TimeOfDay;
                startDate = startDate.Add(startTime);
            }

            return startDate;
        }

        private DateTime GetAppointmentEnd()
        {
            DateTime endDate = this.dateEnd.Value.Date;
            TimeSpan endTime = this.timeEnd.Value.TimeOfDay;

            bool isAllDay = this.chkAllDay.ToggleState == ToggleState.On;
            if (!isAllDay)
            {
                endDate = endDate.Add(endTime);
            }
            else
            {
                endDate = endDate.Add(CustomEditAppointmentDialog.EndOfDayTimeSpan);
            }

            return endDate;
        }

        private void SetStartDateAndTime(DateTime start)
        {
            this.dateStart.Value = start;
            this.timeStart.Value = start;
        }

        private void SetEndDateAndTime(DateTime end)
        {
            this.dateEnd.Value = end;
            this.timeEnd.Value = end;
        }

        #endregion

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();

            ThemeResolutionService.ApplyThemeToControlTree(this, this.ThemeName);
        }

        private void WireEvents()
        {
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRecurrence.Click += new System.EventHandler(this.btnRecurrence_Click);
        }
    }
}