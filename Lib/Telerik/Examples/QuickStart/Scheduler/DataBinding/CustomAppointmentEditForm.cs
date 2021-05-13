namespace Telerik.Examples.WinControls.Scheduler.DataBinding
{
	public partial class CustomAppointmentEditForm : Telerik.WinControls.UI.Scheduler.Dialogs.EditAppointmentDialog
	{
		public CustomAppointmentEditForm()
		{
			InitializeComponent();
		}

		protected override void LoadSettingsFromEvent(Telerik.WinControls.UI.IEvent ev)
		{
			base.LoadSettingsFromEvent(ev);
			
			AppointmentWithEmail appointmentWithEmail = ev as AppointmentWithEmail;
			if(appointmentWithEmail != null)
			{
				this.txtEmail.Text = appointmentWithEmail.Email;
			}
		}

		protected override void ApplySettingsToEvent(Telerik.WinControls.UI.IEvent ev)
		{
			AppointmentWithEmail appointmentWithEmail = ev as AppointmentWithEmail;
			if (appointmentWithEmail != null)
			{
				appointmentWithEmail.Email = this.txtEmail.Text;
			}
			base.ApplySettingsToEvent(ev);
		}

		protected override Telerik.WinControls.UI.IEvent CreateNewEvent()
		{
			return new AppointmentWithEmail();
		}
	}
}
