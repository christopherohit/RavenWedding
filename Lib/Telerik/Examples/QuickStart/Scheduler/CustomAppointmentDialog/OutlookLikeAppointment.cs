using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
{
    public class OutlookLikeAppointment : Appointment
    {
        public OutlookLikeAppointment()
            : base()
        {
        }

        private string email = string.Empty;
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (this.email != value)
                {
                    this.email = value;
                    this.OnPropertyChanged("Email");
                }
            }
        }

        protected override Event CreateOccurrenceInstance()
        {
            OutlookLikeAppointment occurrence = new OutlookLikeAppointment();
            occurrence.email = this.email;
            return occurrence;
        }
    }
}
