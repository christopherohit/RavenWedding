using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.IO;
using Telerik.WinControls.UI.Scheduler.ICalendar;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.ICalImportExport
{
    public partial class Form1 : ExamplesForm
    {       
        public Form1()
        {
            InitializeComponent();
            this.radButton1.Click += new EventHandler(radButton1_Click);
            this.radButton2.Click += new EventHandler(radButton2_Click);
            this.radScheduler1.GetDayView().DayCount = 3;         
        }

        void radButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = ".ics";
            openFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    this.radScheduler1.Import(fileStream, new SchedulerICalendarImporter());
                }
            }
        }

        void radButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    this.radScheduler1.Export(fileStream, new SchedulerICalendarExporter());
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            this.radScheduler1.ActiveView.StartDate = DateTime.Now.Date;

            FillAppointments();
        }

        private void FillAppointments()
        {
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateTime.Now.Date.AddDays(2).AddHours(10);
            DateTime dtEnd = DateTime.Now.Date.AddDays(2).AddHours(12);

            Appointment appointment = new Appointment(dtStart.AddHours(-1), dtEnd.AddHours(8),
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart, dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        }

        protected override void WireEvents()
        {
        }
    }
}
