using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.Printing
{
    public partial class Form1 : ExamplesForm
    {
        bool suspendRadioButtons = false;

        public Form1()
        {
            InitializeComponent();
            FillAppointments();
            this.radScheduler1.ActiveViewType = SchedulerViewType.Week;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.radScheduler1.Print(true, this.radPrintDocument1);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radScheduler1.ThemeName;
            dialog.Document = this.radPrintDocument1;
            dialog.ShowDialog();

            this.UpdateSelectedStyle();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SchedulerPrintSettingsDialog dialog = new SchedulerPrintSettingsDialog();
            dialog.ThemeName = this.radScheduler1.ThemeName;
            dialog.PrintDocument = this.radPrintDocument1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonPreview_Click(sender, e);
            }
            else
            {
                this.UpdateSelectedStyle();
            }
        }

        private void radScheduler1_ActiveViewChanged(object sender, Telerik.WinControls.UI.SchedulerViewChangedEventArgs e)
        {
            switch (this.radScheduler1.ActiveViewType)
            {
                case SchedulerViewType.Day:
                    radioDaily.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    break;
                case SchedulerViewType.Week:
                    radioWeekly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    break;
                case SchedulerViewType.Month:
                    radioMonthly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    break;
                case SchedulerViewType.Timeline:
                    radioDetails.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    break;
                case SchedulerViewType.Agenda:
                    radioAgenda.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    break;
            }
        }

        private void radio_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState != Telerik.WinControls.Enumerations.ToggleState.On || suspendRadioButtons)
            {
                return;
            }

            if (sender == this.radioDaily)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Day;
                this.radScheduler1.PrintStyle = new SchedulerDailyPrintStyle(this.radScheduler1.ActiveView.StartDate, DateTime.Now);
            }
            else if (sender == this.radioWeekly)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Week;
                DateTime startDate = DateHelper.GetStartOfWeek(this.radScheduler1.ActiveView.EndDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday);
                DateTime endDate = DateHelper.GetEndOfWeek(startDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1);
                this.radScheduler1.PrintStyle = new SchedulerWeeklyPrintStyle(startDate, endDate);
            }
            else if (sender == this.radioWeeklyCalendar)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Week;
                DateTime startDate = DateHelper.GetStartOfWeek(this.radScheduler1.ActiveView.EndDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday);
                DateTime endDate = DateHelper.GetEndOfWeek(startDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1);
                this.radScheduler1.PrintStyle = new SchedulerWeeklyCalendarPrintStyle(startDate, endDate);
            }
            else if (sender == this.radioMonthly)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Month;
                this.radScheduler1.PrintStyle = new SchedulerMonthlyPrintStyle(this.radScheduler1.ActiveView.StartDate, this.radScheduler1.ActiveView.EndDate);
            }
            else if (sender == this.radioDetails)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
                this.radScheduler1.PrintStyle = new SchedulerDetailsPrintStyle(this.radScheduler1.ActiveView.StartDate, this.radScheduler1.ActiveView.EndDate);
            }
            else if (sender == this.radioAgenda)
            {
                this.radScheduler1.ActiveViewType = SchedulerViewType.Agenda;
                DateTime startDate = DateHelper.GetStartOfWeek(this.radScheduler1.ActiveView.EndDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday);
                DateTime endDate = DateHelper.GetEndOfWeek(startDate, this.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1);                
                this.radScheduler1.PrintStyle = new SchedulerAgendaPrintStyle(startDate, endDate);
            }
        }

        private void UpdateSelectedStyle()
        {
            suspendRadioButtons = true;

            if (this.radScheduler1.PrintStyle is SchedulerDailyPrintStyle)
            {
                this.radioDaily.IsChecked = true;
            }
            else if (this.radScheduler1.PrintStyle is SchedulerWeeklyPrintStyle)
            {
                this.radioWeekly.IsChecked = true;
            }
            else if (this.radScheduler1.PrintStyle is SchedulerWeeklyCalendarPrintStyle)
            {
                this.radioWeeklyCalendar.IsChecked = true;
            }
            else if (this.radScheduler1.PrintStyle is SchedulerMonthlyPrintStyle)
            {
                this.radioMonthly.IsChecked = true;
            }
            else if (this.radScheduler1.PrintStyle is SchedulerDetailsPrintStyle)
            {
                this.radioDetails.IsChecked = true;
            }

            suspendRadioButtons = false;
        }

        private void FillAppointments()
        {
            this.radSchedulerNavigator1.SchedulerNavigatorElement.TimeZonesDropDown.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateHelper.GetStartOfWeek(DateTime.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(10);
            DateTime dtEnd = DateHelper.GetStartOfWeek(DateTime.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "Building Windows 8 applications with the Metro look",
                "In this session, I will show you how to build a Windows 8 Metro Style Application in XAML and C#.During the process, I will highlight the similarities with other XAML platforms like Silverlight for the Windows Phone, and even how to share code between the two, as well as how to take advantage of the new features in WinRT such as contracts/charms and the new intrinsic GridView controls with semantic zoom.");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(2),
                "Silverlight 5 for LOB development",
                "Most Silverlight 5 sessions give you an overview of the most magical features in the platform. However, not everyone is busy building 3D-enabled applications or media-intensive applications. Most Silverlight developers build LOB applications. For this group, this session is exactly what you need.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(4),
                "Building Applications with HTML 5 and Javascript – a new perspective: Windows 8",
                "HTML 5 is out there for some time (though still a draft) and a lot of web applications are being built using this standard and technologies like Javascript. But how about building apps for the OS system Windows 8 using HTML 5 and Javascript?");
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart, dtEnd.AddDays(3),
                "What’s New In Windows Phone",
                "An overview of the features new in Windows Phone 7.5 (code name Mango) along with details on some of the most important new features, starting with Fast Application Switching, greater access to the calendar and contacts, a local database, a greatly enhanced motion API and much more.");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(1), dtEnd.AddHours(1),
                "Windows Phone 7 Application - from start to market",
                "A crash course in Windows Phone application development with Visual Studio and Expression Blend, with an emphasis on declarative Xaml programming. This presentation will start with foundational information and take you through advanced topics such as tasks and data binding, as well as preparing your program for the marketplace.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(3),
                "How Do You Test SharePoint 2010 Applications?",
                "There are many types of testing you can perform on a developed web application – from unit, to functional, to smoke, to load testing – and more!  Different tools are required for different types of testing, and properly testing SharePoint 2010 can present unique challenges.  Using Visual Studio 2010 Ultimate and several commercial testing tools, I will demonstrate several key testing types in action as applied to a SharePoint 2010 application.  When performing a stress test, I will take you through the interpretation of the results and guide you on how and what to test in your application.");
            appointment.BackgroundId = (int)AppointmentBackground.PhoneCall;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(5),
                "Common Design Patterns",
                "Design Patterns provide common templates for solving the same family of problems in a similar way. They also provide a higher-level language for software developers to use to describe approaches they might choose when designing a component of an application. In this session, you'll learn about several of the most common, and useful, design patterns used by Microsoft developers today.");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            DateTime tempDateTime = dtEnd.AddHours(7);
            appointment = new Appointment(dtStart.AddHours(6), tempDateTime.AddDays(1),
                "Moving your XAML applications to Metro",
                "By now you know what Metro is, what the Windows Runtime (WinRT) is, and that C# and VB.NET can access the WinRT via an interop layer. The big question: What's involved in moving my Silverlight (or WPF) application over to Metro? In this session Carl Franklin goes through the pain points and gives you a real idea of what it will take to port your application.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart.AddHours(1), dtEnd.AddHours(4),
                "Windows Azure – Under the hood",
                "As a happy Windows Azure user you’ve probably been wondering about the internals of Windows Azure. How is provisioning of services happening, how do all components scale seemingly infinite? What happens if my role instance goes down? Come join me and balance on the thin line between software architecture and system architecture that forms the base of one of the most complete cloud platforms out there: Windows Azure.");
            appointment.BackgroundId = (int)AppointmentBackground.Vacation;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(1).AddHours(5), dtEnd.AddDays(1).AddHours(7),
                "Taking Care of a Cloud Environment: Windows Azure",
                "No, this session is not about greener IT. It does cover the environment your application will live in once deployed to Windows Azure: learn about the virtual machine you’ve deployed to and how it interacts with the datacenter. Learn about how you can get use the RoleEnvironment class and diagnostics provided by Windows Azure. Communication between roles, logging and diagnostics are just some of the possibilities of what you can do if you know about how the Windows Azure environment works. And who knows, maybe we can even auto-scale our application...");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(8), dtEnd.AddHours(10),
                "Pragmatic ASP.NET Tips, Tricks, And Tools",
                "Every experienced ASP.NET developer has picked up a few cool tricks or useful tools that they put to use on every new project after they've learned them. This session draws upon the experience of many successful ASP.NET developers and distills this knowledge into a collection of tips and tricks you can start using in your work today. Some of the topics covered in this session include error handling, tracing, caching, base page classes, site layout and architecture, and data access best practices. You'll learn about highly reusable Http Modules and Handlers and a few code routines you may want to add to your personal library. Stick around for part 2 if you’re interested in learning about a wide variety of (usually free) tools available to aid ASP.NET developers. This session is appropriate for anyone who is working with ASP.NET today, and especially for those who are new to ASP.NET.");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart, dtEnd,
                "Fun With Programming",
                "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        }

        protected override void WireEvents()
        {
            this.radScheduler1.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(radScheduler1_ActiveViewChanged);
            this.radioDetails.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            this.radioMonthly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            this.radioWeekly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            this.radioWeeklyCalendar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            this.radioDaily.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
        }
    }
}
