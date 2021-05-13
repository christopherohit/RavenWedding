using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Collections.Generic;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Scheduler.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private List<IRemindObject> openedAlerts = new List<IRemindObject>();
        private Timer initialTimer;
        private DateTime initialViewStartDate;
        public Form1()
        {
            InitializeComponent();

            this.radSchedulerDemo.GetDayView().DayCount = 1;
            this.radSchedulerNavigator1.ShowWeekendStateChanged += new StateChangedEventHandler(radSchedulerNavigator1_ShowWeekendStateChanged);
            this.radCalendar1.ShowOtherMonthsDays = false;
            this.radCalendar1.AllowMultipleSelect = false;
            this.radCalendar1.TitleFormat = "MMMM";

            this.radCalendar1.SelectedDate = DateTime.Today;
            this.radCalendar1.SelectionChanged += new EventHandler(radCalendar1_SelectionChanged);

            this.radSchedulerDemo.PropertyChanged += new PropertyChangedEventHandler(radScheduler1_PropertyChanged);
            this.radSchedulerDemo.Appointments.CollectionChanged += new Telerik.WinControls.Data.NotifyCollectionChangedEventHandler(Appointments_CollectionChanged);
            this.radSchedulerDemo.ThemeNameChanged += new ThemeNameChangedEventHandler(radSchedulerDemo_ThemeNameChanged);
            this.radSchedulerDemo.AppointmentTitleFormat = "{2} ({3})";

            this.radSchedulerNavigator1.TimelineViewButtonVisible = false;

            this.FillEditorModes();

            this.initialViewStartDate = this.radSchedulerDemo.ActiveView.StartDate;
            this.initialTimer = new Timer();
            this.initialTimer.Interval = 2000;
            this.initialTimer.Tick += new EventHandler(initialTimer_Tick);
            this.initialTimer.Start();

            this.radCalendar1.InvalidateCalendar();

            RadPageViewOutlookElement outlookElement = this.radPageView1.ViewElement as RadPageViewOutlookElement;
            for (int i = 0; i < this.radPageView1.Pages.Count; i++)
            {
                outlookElement.DragGripDown();
            }

            this.radPageView1.Dock = DockStyle.Left;
            this.radPageView1.BringToFront();

            this.radSchedulerNavigator1.Dock = DockStyle.Top;
            this.radSchedulerNavigator1.BringToFront();

            this.radSchedulerDemo.Dock = DockStyle.Fill;
            this.radSchedulerDemo.BringToFront();
        }

        void radSchedulerDemo_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            this.radSchedulerReminder1.ThemeName = this.radSchedulerDemo.ThemeName;
        }

        protected override void WireEvents()
        {
            this.radDropDownList1.SelectedValueChanged += new System.EventHandler(this.radDropDownList1_SelectedValueChanged);
            this.radCheckBox1.CheckStateChanged += radCheckBox1_CheckStateChanged;
        }

        private void FillEditorModes()
        {
            RadListDataItem item = new RadListDataItem("None");
            item.Value = SchedulerEditorViewMode.None;
            this.radDropDownList1.Items.Add(item);

            item = new RadListDataItem("Inplace Editor");
            item.Value = SchedulerEditorViewMode.Editor;
            this.radDropDownList1.Items.Add(item);

            item = new RadListDataItem("Inplace Editor Dialog");
            item.Value = SchedulerEditorViewMode.EditorDialog;
            this.radDropDownList1.Items.Add(item);

            this.radDropDownList1.SelectedIndex = 1;
        }

        void initialTimer_Tick(object sender, EventArgs e)
        {
            this.initialTimer.Stop();
            this.initialTimer.Dispose();

            this.ApplySchedulerSettings();
        }

        private void ApplySchedulerSettings()
        {
            this.radSchedulerReminder1.AssociatedScheduler = this.radSchedulerDemo;
            this.radSchedulerReminder1.RemindObjectShown += new EventHandler<RadShowRemindObjectArgs>(radSchedulerReminder1_RemindObjectShown);
            this.radSchedulerReminder1.ItemOpened += new EventHandler<RadOpenItemArgs>(radSchedulerReminder1_ItemOpened);
            this.radSchedulerReminder1.StartReminderInterval = this.initialViewStartDate;
            this.radSchedulerReminder1.EndReminderInterval = DateHelper.GetEndOfDay(DateTime.Now);
            this.radSchedulerReminder1.StartReminder();
        }

        void radSchedulerReminder1_ItemOpened(object sender, RadOpenItemArgs e)
        {
            EditAppointmentDialog editAppointmentDialog = new EditAppointmentDialog((IEvent)e.RemindObject, this.radSchedulerDemo);
            editAppointmentDialog.ThemeName = radSchedulerDemo.ThemeName;
            editAppointmentDialog.ShowDialog(this);
        }

        void radSchedulerReminder1_RemindObjectShown(object sender, RadShowRemindObjectArgs e)
        {
            if (this.openedAlerts.Contains(e.RemindObject))
            {
                return;
            }
            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);

            RadButtonElement radButtonElement = new RadButtonElement();
            radButtonElement.Click += new EventHandler(radButtonElement_Click);
            radButtonElement.Tag = e.RemindObject;
            radButtonElement.Image = global::Telerik.Examples.WinControls.Properties.Resources.EditTask16;

            this.openedAlerts.Add(e.RemindObject);

            radDesktopAlert.ButtonItems.Add(radButtonElement);

            radDesktopAlert.FixedSize = new System.Drawing.Size(329, 120);
            radDesktopAlert.ContentImage = global::Telerik.Examples.WinControls.Properties.Resources.Reminder48;
            radDesktopAlert.ContentText = "<html><I>" + ((Appointment)e.RemindObject).Description + "</I></html>";
            radDesktopAlert.CaptionText = e.RemindObject.Subject;
            radDesktopAlert.Show();
            radDesktopAlert.Closed += new RadPopupClosedEventHandler(radDesktopAlert_AlertClosed);
            radDesktopAlert.ThemeName = this.radSchedulerDemo.ThemeName;
        }

        void radDesktopAlert_AlertClosed(object sender, RadPopupClosedEventArgs args)
        {
            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = sender as Telerik.WinControls.UI.RadDesktopAlert;
            this.openedAlerts.Remove((IRemindObject)radDesktopAlert.ButtonItems[0].Tag);
        }

        void radButtonElement_Click(object sender, EventArgs e)
        {
            RadButtonElement radButtonElement = sender as RadButtonElement;
            EditAppointmentDialog editAppointmentDialog = new EditAppointmentDialog((IEvent)radButtonElement.Tag, this.radSchedulerDemo);
            editAppointmentDialog.ShowDialog(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radSchedulerDemo.SchedulerElement.EditorManager.EditorViewMode = (SchedulerEditorViewMode)this.radDropDownList1.SelectedValue;
            this.radCalendar1.ViewChanged += new EventHandler(radCalendar1_ViewChanged);

            DateTime baseDate = DateTime.Today;
            DateTime[] start = new DateTime[] { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), 
                baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0),
                baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)};

            DateTime[] end = new DateTime[] { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0),
                baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0),
                baseDate.AddDays(-4.0).AddHours(14.0),  baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)};

            string[] summaries = new string[] { "Control Customization In Silverlight", 
                "MOSS 2007 Web 2.0 Controls / AJAX / Silverlight", 
                "I Must Attend This Meeting Week Day.", 
                "Integrating WPF And WCF Into Office Business Applications", 
                "Introduction To WWF", 
                "Object-Relational Mapping In Modern Architectures", 
                "SQL Reporting Services 2005 And What's New In 2008", 
                "Fun With Programming", 
                "Deep Dive Into Entity Framework Object Services" };
            string[] descriptions = new string[] { "Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls.", 
                "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING!  In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!", 
                "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.", 
                "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.", 
                "With the .NET 3.0 Framework, developers were given the plumbing to create business process management solutions graphically. In this session, Mark will introduce the basics of working with Workflow Foundation. This is a 100 level talk for developers that are new to WF. We will spend some time talking about the architecture and when best to use a tool like WF for the greatest return. We'll also compare WF to BizTalk and learn that they are completely different worlds.", 
                "WCF, WPF, Silverlight: Always new Buzzwords appear and come to market with new technologies, which are hard to learn. But how do those technologies integrate and collaborate? Data Access is usually encapsulated in a data access layer. Does this still make sense with the all over presence and acceptance of object-relational mapping (ORM)? Using surprisingly simple tools, you can implement basic and complex applications. This presentation shows that you need to rethink your architecture in order to implement persistent objects in nowadays application requirements. You will learn about the necessary feature set of an object-relational mapping tool and how it simplifies your daily work and how it reduces your data access code by 90%", 
                "Business Data Catalog is a new business integration feature in Microsoft Office SharePoint Server 2007 to surface business data from back-end server applications without any coding. Business Data Catalog bridges the gap between the portal site and your business applications and enables you to bring in key data from various business applications to Office SharePoint Server 2007 lists, Web Parts, search, user profiles, and custom applications. To achieve this goal, Business Data Catalog provides homogeneous access to the underlying data sources with a metadata model that provides a consistent and simplified client object model. Business Data Catalog is the key infrastructural component around which the other Business Data features of Office SharePoint Server 2007 are built. We will explore how to expose SQL-Server 2005 data in a SP 2007 portal.", 
                "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.", 
                "The Entity Framework combined with the Entity Data Model (EDM) bring data access to a new level in Enterprise Applications. Entity Framework Object Services APIs, while providing a lot of automated functionality, are filled with features that give developers much more control over how objects are handled. The most important jobs of the ObjectContext are relationship management and change tracking. This session drills into how the ObjectContext manages relationships and how you can control its behavior. This is especially important in SOA scenarios where you may need to transport ObjectGraphs. We also look closely at change tracking, focusing on the challenges and solutions for dealing with data concurrency when moving objects across tiers in your enterprise applications. Knowing what to expect from these features and how to take control of them will empower you in your use of the Entity Framework and EDMs in your Web sites, SOA applications, and smart clients, as well as other applications that share the EDM." };
            string[] locations = new string[] { "Hall 14", "Hall 05", "Hall 11", "Hall 13", "Hall 01", "Hall 02", "Hall 14", "Hall 10", "Home" };
            AppointmentBackground[] backgrounds = new AppointmentBackground[] { AppointmentBackground.Business, AppointmentBackground.MustAttend, 
                AppointmentBackground.Personal, AppointmentBackground.Important, AppointmentBackground.NeedsPreparation, AppointmentBackground.Birthday
                ,AppointmentBackground.TravelRequired, AppointmentBackground.NeedsPreparation, AppointmentBackground.Business};
            AppointmentStatus[] statuses = new AppointmentStatus[]{AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy,AppointmentStatus.Tentative,
                AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy};

            Appointment appointment = null;
            for (int i = 0; i < summaries.Length; i++)
            {
                appointment = new Appointment(start[i], end[i], summaries[i],
                                              descriptions[i], locations[i]);
                appointment.BackgroundId = (int)backgrounds[i];
                appointment.StatusId = (int)statuses[i];
                appointment.Reminder = TimeSpan.FromMinutes(15);
                this.radSchedulerDemo.Appointments.Add(appointment);
            }

            appointment = new Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "The Daily Scrum", "One of the most popular Agile project management and development methods, Scrum is starting to be adopted at major corporations and on very large projects. After an quick introduction to the basics of Scrum like: the Scrum Master, team, product owner, and burn down, and of course the daily Scrum, Stephen, Remi, and Joel show many real world applications of the methodology drawn from his own experience as a Scrum Master. Negotiating with the business, estimation, and team dynamics are all discussed as well as how to use Scrum in small organizations, large enterprise environments, and consulting environments. The speakers will also discuss using Scrum with virtual teams and even an offshoring environment. The session will finish with a large Q&A on best practices", "Room 604");
            appointment.RecurrenceRule = new DailyRecurrenceRule(baseDate.AddHours(11.0), 2);
            this.radSchedulerDemo.Appointments.Add(appointment);
            this.radSchedulerDemo.Appointments.EndUpdate();

            this.radSchedulerDemo.Resources.Add(new Resource(1, "Dell Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(2, "Lenovo Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(3, "Toshiba Laptop"));

            this.InitializeCalendar();

            this.radSchedulerDemo.ActiveViewType = SchedulerViewType.Week;
            (this.radSchedulerDemo.ActiveView as SchedulerDayViewBase).RangeFactor = ScaleRange.HalfHour;
          

            SchedulerDayViewElement dayView = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewElement;
         
            dayView.DataAreaElement.Table.ScrollToWorkHours();

            this.radSchedulerDemo.ActiveViewChanged += new EventHandler<SchedulerViewChangedEventArgs>(radSchedulerDemo_ActiveViewChanged);
        }

        void radCalendar1_ViewChanged(object sender, EventArgs e)
        {
            InitializeCalendar();
        }

        void radSchedulerDemo_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView as SchedulerMonthView == null)
            {
                SchedulerDayViewBase dayBase = (this.radSchedulerDemo.ActiveView as SchedulerDayViewBase);
                if (dayBase != null)
                {
                    if (e.OldView != null && e.NewView != null)
                    {
                        if (e.NewView.ViewType != e.OldView.ViewType)
                        {
                            dayBase.RangeFactor = ScaleRange.HalfHour;
                        }
                    }

                    SchedulerDayViewElement dayView = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewElement;

                    dayView.DataAreaElement.Table.ScrollToWorkHours();
                }
            }

            if (e.NewView.ViewType != e.OldView.ViewType && e.NewView.ViewType == SchedulerViewType.Month)
            {
                this.radSchedulerDemo.GetMonthView().WeekCount = 5;
            }
        }

        void Appointments_CollectionChanged(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        {
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            MultiMonthViewElement viewElement = this.radCalendar1.CalendarElement.CalendarVisualElement as MultiMonthViewElement;

            this.radCalendar1.CalendarElement.Margin = new Padding(0, 0, 0, 14);

            if (viewElement != null)
            {
                CalendarMultiMonthViewTableElement table = viewElement.GetMultiTableElement();

                foreach (MonthViewElement monthView in table.Children)
                {
                    monthView.TitleElement.Margin = new Padding(-4, -2, -2, -2);
                    monthView.TitleElement.Padding = new Padding(3);

                    foreach (CalendarCellElement cell in monthView.TableElement.Children)
                    {
                        bool headerCell = (bool)cell.GetValue(CalendarCellElement.IsHeaderCellProperty);
                        if (headerCell)
                            continue;

                        SchedulerDayView view = new SchedulerDayView();
                        view.DayCount = 1;
                        view.StartDate = cell.Date;
                        view.GetViewContainingDate(cell.Date);

                        view.UpdateAppointments(this.radSchedulerDemo.Appointments);

                        if (view.Appointments.Count > 0)
                        {
                            cell.Font = new Font(cell.Font, FontStyle.Bold);
                        }
                        else
                        {
                            cell.Font = this.radCalendar1.Font;
                        }
                    }
                }
            }
        }

        void radScheduler1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            InitializeCalendar();
        }

        void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.radCalendar1.SelectedDates.Count > 0)
            {
                this.radSchedulerDemo.ActiveView.StartDate = this.radCalendar1.SelectedDate;
            }
        }

        private void radSchedulerNavigator1_ShowWeekendStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radSchedulerDemo.ActiveView as SchedulerDayViewBase != null)
            {
                (this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.ScrollView.Value = Point.Empty;

                (this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.Table.ScrollToWorkHours();
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.initialTimer.Dispose();
                this.radSchedulerReminder1.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.radSchedulerDemo.SchedulerElement.EditorManager.EditorViewMode = (SchedulerEditorViewMode)this.radDropDownList1.SelectedValue;
        }

        void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.radSchedulerDemo.AllowAppointmentsMultiSelect = this.radCheckBox1.Checked;
        }
    }
}
