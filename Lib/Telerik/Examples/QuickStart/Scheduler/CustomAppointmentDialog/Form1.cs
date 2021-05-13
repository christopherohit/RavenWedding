using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using System;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
{
    public partial class Form1 : ExamplesForm
    {
        CustomEditAppointmentDialog appointmentDialog = null;

        public Form1()
        {
            InitializeComponent();
            
            this.radSchedulerDemo.AppointmentFactory = new CustomAppointmentFactory();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += delegate (object sender, EventArgs args) 
            {
                timer.Stop();
                IEvent appointment = this.radSchedulerDemo.AppointmentFactory.CreateNewAppointment();
                DateTimeInterval interval = new DateTimeInterval(DateTime.Now, TimeSpan.FromHours(1));
                this.radSchedulerDemo.AddNewAppointmentWithDialog(appointment, interval, false, null);
            };
            timer.Start();
        }

        private void radSchedulerDemo_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            this.appointmentDialog = new CustomEditAppointmentDialog();
            this.appointmentDialog.ThemeName = this.radSchedulerDemo.ThemeName;
            e.AppointmentEditDialog = this.appointmentDialog;
        }

        protected override void WireEvents()
        {
            this.radSchedulerDemo.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radSchedulerDemo_AppointmentEditDialogShowing);
        }
    }
}
