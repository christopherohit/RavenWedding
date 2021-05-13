using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.AgendaView
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Font defaultFontHeader = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Regular);
        Font defaultFontBold = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
        Font defaultFont = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Regular);
        Padding defaultPadding = new Padding(10, 10, 0, 0);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeControlsAndWireEvents();
            AddResources();
            FillAppointments();

            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Agenda;
            ((SchedulerAgendaViewElement)this.radScheduler1.SchedulerElement.ViewElement).Grid.Columns["Recurrence"].IsVisible = false;
        }

        private void InitializeControlsAndWireEvents()
        {
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Agenda;
            SchedulerAgendaView agendaView = this.radScheduler1.SchedulerElement.View as SchedulerAgendaView;
            SchedulerAgendaViewElement agendaViewElement = this.radScheduler1.SchedulerElement.ViewElement as SchedulerAgendaViewElement;

            agendaViewElement.Grid.CurrentRow = null;
            this.radSchedulerNavigator1.SchedulerNavigatorElement.ViewPanel.Visibility = ElementVisibility.Collapsed;
            this.radCalendar1.SelectedDate = DateTime.Today;
            this.daysCountSpinEditor.Value = agendaView.DayCount;
            this.daysCountSpinEditor.Minimum = 1;
            this.daysCountSpinEditor.Maximum = 30;

            this.resourceToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.resourceToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.resourceToggleButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckedListBox1.SelectedItem = null;
            this.radCheckedListBox1.FullRowSelect = true;
            this.radCheckedListBox1.ItemSize = new Size(150, 30);
            this.radCheckedListBox1.SelectedItemChanging += radCheckedListBox1_SelectedItemChanging;
            this.radCheckedListBox1.VisualItemFormatting += radCheckedListBox1_VisualItemFormatting;
            this.radCheckedListBox1.ItemCheckedChanged += radCheckedListBox1_ItemCheckedChanged;
            this.radCheckedListBox1.Items[0].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.resourceToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            agendaView.GroupByDate = false;
            this.noGroupRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.groupRadioButton.ToggleStateChanged += groupRadioButton_ToggleStateChanged;
            this.radCalendar1.SelectionChanged += radCalendar1_SelectionChanged;
            this.daysCountSpinEditor.ValueChanged += daysCountSpinEditor_ValueChanged;
            this.resourceToggleButton1.ToggleStateChanged += resourceToggleButton1_ToggleStateChanged;
            this.resourceToggleButton2.ToggleStateChanged += resourceToggleButton2_ToggleStateChanged;
            this.resourceToggleButton3.ToggleStateChanged += resourceToggleButton3_ToggleStateChanged;
            this.radSchedulerNavigator1.NavigateBackwardsClick += radSchedulerNavigator1_NavigateClick;
            this.radSchedulerNavigator1.NavigateForwardsClick += radSchedulerNavigator1_NavigateClick;
        }

        private void radSchedulerNavigator1_NavigateClick(object sender, EventArgs e)
        {
            this.radCalendar1.SelectedDate = this.radScheduler1.ActiveView.StartDate;
        }

        private void resourceToggleButton3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radScheduler1.Resources[2].Visible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            RefreshAppointmentsByResource();
        }

        private void resourceToggleButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radScheduler1.Resources[1].Visible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            RefreshAppointmentsByResource();
        }

        private void resourceToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radScheduler1.Resources[0].Visible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            RefreshAppointmentsByResource();
        }

        private void RefreshAppointmentsByResource()
        {
            this.radScheduler1.Appointments.BeginUpdate();
            foreach (Appointment a in this.radScheduler1.Appointments)
            {
                if (IsResourceVisible(a.ResourceId))
                {
                    a.Visible = true;
                }
                else
                {
                    a.Visible = false;
                }
            }
            this.radScheduler1.Appointments.EndUpdate();
        }

        private bool IsResourceVisible(EventId resourceId)
        {
            foreach (Resource res in this.radScheduler1.Resources)
            {
                if (res.Id == resourceId && res.Visible)
                {
                    if (res.Visible)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        private void daysCountSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            SchedulerAgendaView agendaView = this.radScheduler1.SchedulerElement.View as SchedulerAgendaView;
            agendaView.DayCount = (int)this.daysCountSpinEditor.Value;
        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.radScheduler1.FocusedDate = this.radCalendar1.SelectedDate;
        }

        private void groupRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            SchedulerAgendaView agendaView = this.radScheduler1.SchedulerElement.View as SchedulerAgendaView;
            SchedulerAgendaViewElement agendaViewElement = this.radScheduler1.SchedulerElement.ViewElement as SchedulerAgendaViewElement;
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                agendaView.GroupByDate = false;
            }
            else
            {
                agendaView.GroupByDate = true;
            }
        }

        private void AddResources()
        {
            Resource resource = new Resource();
            resource.Id = new EventId(1);
            resource.Name = "Nancy Davolio";
            resource.Color = Color.LightBlue;
            resource.Image = Properties.Resources.nancy45x45;
            this.radScheduler1.Resources.Add(resource);

            resource = new Resource();
            resource.Id = new EventId(2);
            resource.Name = "Andrew Fuller";
            resource.Color = Color.LightSalmon;
            resource.Image = Properties.Resources.andrew45x45;
            this.radScheduler1.Resources.Add(resource);

            resource = new Resource();
            resource.Id = new EventId(3);
            resource.Name = "Robert King";
            resource.Color = Color.LightYellow;
            resource.Image = Properties.Resources.bob45x45;
            this.radScheduler1.Resources.Add(resource);
        }

        private void FillAppointments()
        {
            Appointment appointment = new Appointment(DateTime.Today.AddHours(7), TimeSpan.FromMinutes(60), "Keynote", "Opening session");
            appointment.StatusId = 3;
            appointment.BackgroundId = 6;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            DailyRecurrenceRule rrule = new DailyRecurrenceRule(appointment.Start, 1, 2);
            appointment.RecurrenceRule = rrule;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(8), TimeSpan.FromMinutes(60), "Things Developers Need to Know about Building Intelligent Apps", "In this session, we will discuss the top trends that developers need to be aware of as they begin to integrate Artificial Intelligence into their applications. ");
            appointment.StatusId = 3;
            appointment.BackgroundId = 6;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(9), TimeSpan.FromMinutes(45), "3DPrinterOS is the world’s first operating system for 3D printers, powered by Azure", "3DPrinterOS is an easy to use real-time digital manufacturing OS. Just like DOS and IBM revolutionized the PC information age, 3DPrinterOS makes it easy to print and operate many different brands of 3D printers from one UI. ");
            appointment.StatusId = 1;
            appointment.BackgroundId = 4;
            appointment.ResourceId = this.radScheduler1.Resources[1].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(9).AddMinutes(30), TimeSpan.FromMinutes(90), "Azure services every developers needs to know about", "Azure is a powerful platform with many amazing services, but it can also be hard to know which ones you need to know about when you’re first getting started with cloud development. In this talk we’ll cover five common services that most .NET applications designed to run in the cloud will benefit from using.");
            appointment.StatusId = 4;
            appointment.BackgroundId = 1;
            appointment.ResourceId = this.radScheduler1.Resources[2].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(10), TimeSpan.FromMinutes(120), "Reasons to Move Your C++ Code to Visual Studio 2017", "Come learn the top 7 reasons to use Visual Studio 2017 if you are a C++ developer. Whether you are using the product and are looking to upgrade, or you never used it before but you are considering it now, join us to discover how Visual Studio 2017 raises the bar in terms of C++ productivity. ");
            appointment.StatusId = 1;
            appointment.BackgroundId = 6;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(12), TimeSpan.FromMinutes(120), "A Developer’s Introduction to Big Data Processing with Azure Databricks", "In this session you’ll see an introductory journey into how Azure Databricks can bring together structured, and unstructured data, help derive deep insights with Machine Learning, and even create a real-time feedback loop. Your applications deserve to be more intelligent, and when it comes to data-driven intelligence, Azure Databricks is the way to go.");
            appointment.StatusId = 5;
            appointment.BackgroundId = 5;
            appointment.ResourceId = this.radScheduler1.Resources[1].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(14), TimeSpan.FromMinutes(75), "Accelerating Windows 10 enterprise app deployment with MSIX", "MSIX provides lots of benefits across the app lifecycle management. Learn how to take advantage of MSIX in your enterprise and the benefits to developers, IT Pros and end users. During the session we will deep dive into the benefits of MSIX and the new tooling and features available to make it easy to move your existing apps to MSIX. As you move to MSIX we will also discuss what it means for things like legacy plug-ins.");
            appointment.StatusId = 3;
            appointment.BackgroundId = 1;
            appointment.ResourceId = this.radScheduler1.Resources[2].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(14).AddMinutes(30), TimeSpan.FromMinutes(45), "Accelerate your SaaS App development using the power of the Business Application Platform", "Join this session to learn how the Business Application Platform can accelerate the time to market for your next Line of Business SaaS app. ");
            appointment.StatusId = 2;
            appointment.BackgroundId = 4;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(15), TimeSpan.FromMinutes(120), "Adaptive Cards in Bots, Windows, Outlook and your own applications", "Learn how Bots, Windows and Outlook use the power of Adaptive cards to showcase information from applications like yours. Using the same technology, your application can do the same to help create interactive and actionable experiences that are both engaging and can simplify business processes across your organization.");
            appointment.StatusId = 1;
            appointment.BackgroundId = 1;
            appointment.ResourceId = this.radScheduler1.Resources[1].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(16), TimeSpan.FromMinutes(90), "Adding Visual Intelligence to your application with Windows Machine Learning", "In this lab you will learn how Azure Custom Vision and the Windows AI Platform seamlessly work together to add Visual Intelligence to your UWP application. Custom Vision enables you to easily customize your own state-of-the-art computer vision models that fit perfectly with your unique use case.");
            appointment.StatusId = 5;
            appointment.BackgroundId = 3;
            appointment.ResourceId = this.radScheduler1.Resources[1].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(17), TimeSpan.FromMinutes(120), "Adobe's proven practices for running Open Source Workloads on Azure", "Adobe Experience Cloud is the fastest growing product at Adobe and to reach the next phase of its vision, it would need a global infrastructure, on-demand scalability, and the capability to store, manage, analyze big data and support the open source tools and platforms that Adobe builds with.");
            appointment.StatusId = 2;
            appointment.BackgroundId = 1;
            appointment.ResourceId = this.radScheduler1.Resources[2].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddHours(17).AddMinutes(30), TimeSpan.FromMinutes(120), "Amplifying human ingenuity with Microsoft AI", "Microsoft is delivering a flexible AI platform for organizations and developers to infuse intelligence into their products and services using tools and services like Microsoft Cognitive Services, Azure Bot Service, Azure Machine Learning, and Cognitive Toolkit. In this session, we provide a high-level view of the Microsoft AI Platform and show demos for you to amplify your ingenuity with intelligent technology.");
            appointment.StatusId = 4;
            appointment.BackgroundId = 2;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddDays(1).AddHours(9).AddMinutes(30), TimeSpan.FromMinutes(120), ".NET Overview & Roadmap", "We'll take a look at the current state of .NET, it's incredible growth, and the new features of .NET Core 2.1. We'll also show you the exciting direction .NET is headed to help you build cutting edge solutions for the future. ");
            appointment.StatusId = 2;
            appointment.BackgroundId = 3;
            appointment.ResourceId = this.radScheduler1.Resources[2].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddDays(1).AddHours(12).AddMinutes(30), TimeSpan.FromMinutes(120), "Building secure cloud apps – lessons learned from Microsoft’s internal security and software engineering teams", "Learn from Core Services Engineering & Operations (formerly Microsoft IT) software engineering leads and our Digital Security & Risk Engineering (DSRE) engineers how our Line of Business application development teams work hand in hand with our security experts to implement tools and patterns to secure our cloud footprint while accelerating the speed at which our software engineers build applications in the cloud. ");
            appointment.StatusId = 3;
            appointment.BackgroundId = 2;
            appointment.ResourceId = this.radScheduler1.Resources[1].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddDays(1).AddHours(14).AddMinutes(30), TimeSpan.FromMinutes(120), "Building smart apps with Visual Studio, Xamarin, and Cognitive Services", "What can’t you do with Cognitive Services? Come see how to leverage these powerful services to infuse your apps with intelligent algorithms to see, hear, speak, understand, and interpret your user needs to transform your business with AI.");
            appointment.StatusId = 4;
            appointment.BackgroundId = 2;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddDays(1).AddHours(15), TimeSpan.FromMinutes(120), "Building Solution Templates and Managed Applications for the Azure Marketplace", "The Azure Marketplace provides a great opportunity for visibility and validation of your applications for customers. Millions of compute hours are driven through certified applications available in the Azure Marketplace each month. ");
            appointment.StatusId = 4;
            appointment.BackgroundId = 2;
            appointment.ResourceId = this.radScheduler1.Resources[2].Id;
            this.radScheduler1.Appointments.Add(appointment);

            appointment = new Appointment(DateTime.Today.AddDays(1).AddHours(17).AddMinutes(30), TimeSpan.FromMinutes(120), "Building Windows - how the bits flow from check-in to the fast-ring", "Ever wondered how Microsoft takes the combined work of over 11,000 engineers developing Windows at Microsoft, bring it together in one branch, build, test and get it onto your desktop.");
            appointment.StatusId = 4;
            appointment.BackgroundId = 2;
            appointment.ResourceId = this.radScheduler1.Resources[0].Id;
            this.radScheduler1.Appointments.Add(appointment);
        }

        private void radCheckedListBox1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            e.VisualItem.Margin = new Padding(6, 10, 0, 0);

            e.VisualItem.Font = defaultFont;

            SimpleListViewVisualItem visualItem = e.VisualItem as SimpleListViewVisualItem;
            if (visualItem != null)
            {
                visualItem.ToggleElement.Margin = new Padding(0, 0, 5, 0);
            }
        }

        private void radCheckedListBox1_ItemCheckedChanged(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            this.radCheckedListBox1.ItemCheckedChanged -= radCheckedListBox1_ItemCheckedChanged;
            if (e.Item.Text == "All Categories")
            {
                foreach (ListViewDataItem item in this.radCheckedListBox1.Items)
                {
                    if (item != e.Item)
                    {
                        item.CheckState = e.Item.CheckState;
                    }
                }
            }
            else
            {
                bool areAllItemsChecked = true;
                for (int i = 1; i < this.radCheckedListBox1.Items.Count; i++)
                {
                    if (this.radCheckedListBox1.Items[i].CheckState == Telerik.WinControls.Enumerations.ToggleState.Off)
                    {
                        areAllItemsChecked = false;
                        break;
                    }
                }
                if (areAllItemsChecked == true)
                {
                    //this.radCheckedListBox1.Items[0].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                }
                else
                {
                    this.radCheckedListBox1.Items[0].CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                }
            }
            this.radCheckedListBox1.ItemCheckedChanged += radCheckedListBox1_ItemCheckedChanged;
            RefreshVisibleAppointmentsByBackground();
        }

        private void RefreshVisibleAppointmentsByBackground()
        {
            this.radScheduler1.Appointments.BeginUpdate();
            foreach (Appointment a in this.radScheduler1.Appointments)
            {
                if (IsBackgroundChecked(a.BackgroundId) || this.radCheckedListBox1.Items[0].CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    a.Visible = true;
                }
                else
                {
                    a.Visible = false;
                }
            }
            this.radScheduler1.Appointments.EndUpdate();
        }

        private bool IsBackgroundChecked(int id)
        {
            if (id == 0 && this.radCheckedListBox1.Items[0].CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                return true;
            }
            foreach (ListViewDataItem item in this.radCheckedListBox1.Items)
            {
                if ((int)item.Tag == id && item.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    return true;
                }
            }
            return false;
        }

        private void radCheckedListBox1_SelectedItemChanging(object sender, Telerik.WinControls.UI.ListViewItemCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}