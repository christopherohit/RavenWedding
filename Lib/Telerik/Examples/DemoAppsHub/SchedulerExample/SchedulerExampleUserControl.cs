using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace DemoAppsHub.SchedulerExample
{
    public partial class SchedulerExampleUserControl : UserControl
    {
        public SchedulerExampleUserControl()
        {
            InitializeComponent();
            this.radSchedulerNavigator1.AutomaticNavigation = false;
            this.radScheduler1.ThemeName = "TelerikMetroBlue";
            this.radSchedulerNavigator1.ThemeName = "TelerikMetroBlue";
            this.radScheduler1.ActiveViewType = SchedulerViewType.Month;
            this.radScheduler1.BringToFront();
            FillSchedulerAppointments();
        }

        private void FillSchedulerAppointments()
        {
            AppointmentBackgroundInfo backInfo = new AppointmentBackgroundInfo(15, "White", Color.White, Color.White);
            backInfo.ShadowStyle = ShadowStyles.Solid;
            backInfo.ShadowColor = Color.FromArgb(178, 193, 207, 229);
            backInfo.ShadowWidth = 2;
            backInfo.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders;
            backInfo.BorderColor = Color.LightGray;
            backInfo.BorderColor2 = Color.Gray;
            backInfo.BorderGradientStyle = GradientStyles.Solid;
            backInfo.DateTimeColor = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleColor;
            backInfo.DateTimeFont = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleFont;

            this.radScheduler1.Backgrounds.Add(backInfo);

            foreach (AppointmentBackgroundInfo info in this.radScheduler1.Backgrounds)
            {
                info.BorderGradientStyle = GradientStyles.Solid;
                info.GradientStyle = GradientStyles.Solid;
                info.BackColor2 = info.BackColor;
                info.BorderGradientStyle = GradientStyles.Solid;
                info.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            }

            DateTime appointmentTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
      
            this.radScheduler1.Appointments.BeginUpdate();

            Appointment appointment = new Appointment(appointmentTime, TimeSpan.FromHours(3), Telerik.WinControls.VersionNumber.MarketingVersion + " Release", "Description");
            appointment.StatusId = 3;
            appointment.BackgroundId = 6;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(appointmentTime.AddDays(26), TimeSpan.FromHours(2), Telerik.WinControls.VersionNumber.MarketingVersion + " Webinar week", "Description");
            appointment.StatusId = 1;
            appointment.BackgroundId = 2;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(appointmentTime.AddDays(52), TimeSpan.FromHours(5), "DevReach opening", "Description");
            appointment.StatusId = 3;
            appointment.BackgroundId = 9;
            this.radScheduler1.Appointments.Add(appointment);

            DateTime dtStart = DateTime.Today.AddHours(10);
            DateTime dtEnd = DateTime.Today.AddHours(12);

            appointment = new Appointment(dtStart, dtEnd,
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(14), dtEnd.AddDays(14),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(28), dtEnd.AddDays(28),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart.AddDays(3), dtEnd.AddDays(3),
                "MOSS 2007 Web 2.0 Controls / AJAX / Silverlight",
                "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING!  In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(33), dtEnd.AddDays(33),
                "Control Customization In Silverlight 3",
                "Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls. ");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(23), dtEnd.AddDays(23),
                "Science Fiction Becomes Reality With WPF",
                "In this session you will see how the two worlds of science fiction and real-life software embrace each-other to form an astonishing mixture of art, user experience and functionality. We will show you a different perspective of how you can utilize modern technologies to achieve better interaction and presentation in ways you only consider possible in movies.");
            appointment.BackgroundId = (int)AppointmentBackground.PhoneCall;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(42), dtEnd.AddDays(42),
                "Building Office Applications With VSTO",
                "This session focuses on the power and developer productivity of Visual Studio Tools for the Office System (VSTO). VSTO is a .NET Smart Client technology and this session will delve into the tips and tricks, positives and negatives when designing and building smart client applications with VSTO. VSTO allows you to build managed code applications with .NET languages like VB.NET and C# and have the functionality of those applications manifest in the rich user interfaces of Microsoft Excel, Word, PowerPoint, Visio, Outlook and others from the Office stack. You will learn just how easy it is to build powerful VSTO applications in this session and how to deploy those applications. This session will cover all versions of VSTO (versions 1.0 through 3.0) targeting both Office 2003 and Office 2007. VSTO addresses some of the biggest challenges that Office solution developers are facing today, including separation of data and view elements, server-side and offline scenarios, seamless integration with the Visual Studio tools, deployment and updating. Lastly, this session will delve into the future of VSTO and its potential coverage of document-centric and add-in solutions for the entire Office System stack.");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);
             
            appointment = new Appointment(dtStart.AddDays(67), dtEnd.AddDays(67),
                "Blend For Silverlight Developers",
                "In this session, we will dig into how developers can use Blend for their Silverlight 2 applications. This includes tips and tricks for common graphic tasks like shiny buttons, clipping regions and grouping/layers. Common programmer tasks like event handling, data binding and stying is also covered.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart.AddDays(55), dtEnd.AddDays(55),
                "I Must Attend This Meeting Week Day.",
                "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.");
            appointment.BackgroundId = (int)AppointmentBackground.Vacation;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(49), dtEnd.AddDays(49),
                "Integrating WPF And WCF Into Office Business Applications",
                "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(92), dtEnd.AddDays(92),
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
         
    }
}
