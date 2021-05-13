Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Collections.Generic
Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Scheduler.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Private openedAlerts As New List(Of IRemindObject)()
        Private initialTimer As Timer
        Private initialViewStartDate As DateTime
        Public Sub New()
            InitializeComponent()

            Me.radSchedulerDemo.GetDayView().DayCount = 1
            AddHandler Me.radSchedulerNavigator1.ShowWeekendStateChanged, AddressOf radSchedulerNavigator1_ShowWeekendStateChanged
            Me.radCalendar1.ShowOtherMonthsDays = False
            Me.radCalendar1.AllowMultipleSelect = False
            Me.radCalendar1.TitleFormat = "MMMM"

            Me.radCalendar1.SelectedDate = DateTime.Today
            AddHandler Me.radCalendar1.SelectionChanged, AddressOf radCalendar1_SelectionChanged

            AddHandler Me.radSchedulerDemo.PropertyChanged, AddressOf radScheduler1_PropertyChanged
            AddHandler Me.radSchedulerDemo.Appointments.CollectionChanged, AddressOf Appointments_CollectionChanged
            AddHandler Me.radSchedulerDemo.ThemeNameChanged, AddressOf radSchedulerDemo_ThemeNameChanged
            Me.radSchedulerDemo.AppointmentTitleFormat = "{2} ({3})"

            Me.radSchedulerNavigator1.TimelineViewButtonVisible = False

            Me.FillEditorModes()

            Me.initialViewStartDate = Me.radSchedulerDemo.ActiveView.StartDate
            Me.initialTimer = New Timer()
            Me.initialTimer.Interval = 2000
            AddHandler Me.initialTimer.Tick, AddressOf initialTimer_Tick
            Me.initialTimer.Start()

            Me.radCalendar1.InvalidateCalendar()

            Dim outlookElement As RadPageViewOutlookElement = TryCast(Me.radPageView1.ViewElement, RadPageViewOutlookElement)
            For i As Integer = 0 To Me.radPageView1.Pages.Count - 1
                outlookElement.DragGripDown()
            Next

            Me.radPageView1.Dock = DockStyle.Left
            Me.radPageView1.BringToFront()

            Me.radSchedulerNavigator1.Dock = DockStyle.Top
            Me.radSchedulerNavigator1.BringToFront()

            Me.radSchedulerDemo.Dock = DockStyle.Fill
            Me.radSchedulerDemo.BringToFront()
        End Sub

        Private Sub radSchedulerDemo_ThemeNameChanged(source As Object, args As ThemeNameChangedEventArgs)
            Me.radSchedulerReminder1.ThemeName = Me.radSchedulerDemo.ThemeName
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radDropDownList1.SelectedValueChanged, AddressOf Me.radDropDownList1_SelectedValueChanged
            AddHandler Me.radCheckBox1.CheckStateChanged, AddressOf radCheckBox1_CheckStateChanged
        End Sub

        Private Sub FillEditorModes()
            Dim item As New RadListDataItem("None")
            item.Value = SchedulerEditorViewMode.None
            Me.radDropDownList1.Items.Add(item)

            item = New RadListDataItem("Inplace Editor")
            item.Value = SchedulerEditorViewMode.Editor
            Me.radDropDownList1.Items.Add(item)

            item = New RadListDataItem("Inplace Editor Dialog")
            item.Value = SchedulerEditorViewMode.EditorDialog
            Me.radDropDownList1.Items.Add(item)

            Me.radDropDownList1.SelectedIndex = 1
        End Sub

        Private Sub initialTimer_Tick(sender As Object, e As EventArgs)
            Me.initialTimer.[Stop]()
            Me.initialTimer.Dispose()

            Me.ApplySchedulerSettings()
        End Sub

        Private Sub ApplySchedulerSettings()
            Me.radSchedulerReminder1.AssociatedScheduler = Me.radSchedulerDemo
            AddHandler Me.radSchedulerReminder1.RemindObjectShown, AddressOf radSchedulerReminder1_RemindObjectShown
            AddHandler Me.radSchedulerReminder1.ItemOpened, AddressOf radSchedulerReminder1_ItemOpened
            Me.radSchedulerReminder1.StartReminderInterval = Me.initialViewStartDate
            Me.radSchedulerReminder1.EndReminderInterval = DateHelper.GetEndOfDay(DateTime.Now)
            Me.radSchedulerReminder1.StartReminder()
        End Sub

        Private Sub radSchedulerReminder1_ItemOpened(sender As Object, e As RadOpenItemArgs)
            Dim editAppointmentDialog As New EditAppointmentDialog(DirectCast(e.RemindObject, IEvent), Me.radSchedulerDemo)
            editAppointmentDialog.ThemeName = radSchedulerDemo.ThemeName
            editAppointmentDialog.ShowDialog(Me)
        End Sub

        Private Sub radSchedulerReminder1_RemindObjectShown(sender As Object, e As RadShowRemindObjectArgs)
            If Me.openedAlerts.Contains(e.RemindObject) Then
                Return
            End If
            Dim radDesktopAlert As New Telerik.WinControls.UI.RadDesktopAlert(Me.components)

            Dim radButtonElement As New RadButtonElement()
            AddHandler radButtonElement.Click, AddressOf radButtonElement_Click
            radButtonElement.Tag = e.RemindObject
            radButtonElement.Image = My.Resources.EditTask16

            Me.openedAlerts.Add(e.RemindObject)

            radDesktopAlert.ButtonItems.Add(radButtonElement)

            radDesktopAlert.FixedSize = New System.Drawing.Size(329, 120)
            radDesktopAlert.ContentImage = My.Resources.Reminder48
            radDesktopAlert.ContentText = "<html><I>" + DirectCast(e.RemindObject, Appointment).Description + "</I></html>"
            radDesktopAlert.CaptionText = e.RemindObject.Subject
            radDesktopAlert.Show()
            AddHandler radDesktopAlert.Closed, AddressOf radDesktopAlert_AlertClosed
            radDesktopAlert.ThemeName = Me.radSchedulerDemo.ThemeName
        End Sub

        Private Sub radDesktopAlert_AlertClosed(sender As Object, args As RadPopupClosedEventArgs)
            Dim radDesktopAlert As Telerik.WinControls.UI.RadDesktopAlert = TryCast(sender, Telerik.WinControls.UI.RadDesktopAlert)
            Me.openedAlerts.Remove(DirectCast(radDesktopAlert.ButtonItems(0).Tag, IRemindObject))
        End Sub

        Private Sub radButtonElement_Click(sender As Object, e As EventArgs)
            Dim radButtonElement As RadButtonElement = TryCast(sender, RadButtonElement)
            Dim editAppointmentDialog As New EditAppointmentDialog(DirectCast(radButtonElement.Tag, IEvent), Me.radSchedulerDemo)
            editAppointmentDialog.ShowDialog(Me)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radSchedulerDemo.SchedulerElement.EditorManager.EditorViewMode = DirectCast(Me.radDropDownList1.SelectedValue, SchedulerEditorViewMode)
            AddHandler Me.radCalendar1.ViewChanged, AddressOf radCalendar1_ViewChanged

            Dim baseDate As DateTime = DateTime.Today
            Dim start As DateTime() = New DateTime() {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), _
                baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

            Dim [end] As DateTime() = New DateTime() {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), _
                baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

            Dim summaries As String() = New String() {"Control Customization In Silverlight", "MOSS 2007 Web 2.0 Controls / AJAX / Silverlight", "I Must Attend This Meeting Week Day.", "Integrating WPF And WCF Into Office Business Applications", "Introduction To WWF", "Object-Relational Mapping In Modern Architectures", _
                "SQL Reporting Services 2005 And What's New In 2008", "Fun With Programming", "Deep Dive Into Entity Framework Object Services"}
            Dim descriptions As String() = New String() {"Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls.", "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING! In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!", "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.", "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.", "With the .NET 3.0 Framework, developers were given the plumbing to create business process management solutions graphically. In this session, Mark will introduce the basics of working with Workflow Foundation. This is a 100 level talk for developers that are new to WF. We will spend some time talking about the architecture and when best to use a tool like WF for the greatest return. We'll also compare WF to BizTalk and learn that they are completely different worlds.", "WCF, WPF, Silverlight: Always new Buzzwords appear and come to market with new technologies, which are hard to learn. But how do those technologies integrate and collaborate? Data Access is usually encapsulated in a data access layer. Does this still make sense with the all over presence and acceptance of object-relational mapping (ORM)? Using surprisingly simple tools, you can implement basic and complex applications. This presentation shows that you need to rethink your architecture in order to implement persistent objects in nowadays application requirements. You will learn about the necessary feature set of an object-relational mapping tool and how it simplifies your daily work and how it reduces your data access code by 90%", _
                "Business Data Catalog is a new business integration feature in Microsoft Office SharePoint Server 2007 to surface business data from back-end server applications without any coding. Business Data Catalog bridges the gap between the portal site and your business applications and enables you to bring in key data from various business applications to Office SharePoint Server 2007 lists, Web Parts, search, user profiles, and custom applications. To achieve this goal, Business Data Catalog provides homogeneous access to the underlying data sources with a metadata model that provides a consistent and simplified client object model. Business Data Catalog is the key infrastructural component around which the other Business Data features of Office SharePoint Server 2007 are built. We will explore how to expose SQL-Server 2005 data in a SP 2007 portal.", "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.", "The Entity Framework combined with the Entity Data Model (EDM) bring data access to a new level in Enterprise Applications. Entity Framework Object Services APIs, while providing a lot of automated functionality, are filled with features that give developers much more control over how objects are handled. The most important jobs of the ObjectContext are relationship management and change tracking. This session drills into how the ObjectContext manages relationships and how you can control its behavior. This is especially important in SOA scenarios where you may need to transport ObjectGraphs. We also look closely at change tracking, focusing on the challenges and solutions for dealing with data concurrency when moving objects across tiers in your enterprise applications. Knowing what to expect from these features and how to take control of them will empower you in your use of the Entity Framework and EDMs in your Web sites, SOA applications, and smart clients, as well as other applications that share the EDM."}
            Dim locations As String() = New String() {"Hall 14", "Hall 05", "Hall 11", "Hall 13", "Hall 01", "Hall 02", _
                "Hall 14", "Hall 10", "Home"}
            Dim backgrounds As AppointmentBackground() = New AppointmentBackground() {AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal, AppointmentBackground.Important, AppointmentBackground.NeedsPreparation, AppointmentBackground.Birthday, _
                AppointmentBackground.TravelRequired, AppointmentBackground.NeedsPreparation, AppointmentBackground.Business}
            Dim statuses As AppointmentStatus() = New AppointmentStatus() {AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Tentative, _
                AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy}

            Dim appointment As Appointment = Nothing
            For i As Integer = 0 To summaries.Length - 1
                appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
                appointment.BackgroundId = CInt(backgrounds(i))
                appointment.StatusId = CInt(statuses(i))
                appointment.Reminder = TimeSpan.FromMinutes(15)
                Me.radSchedulerDemo.Appointments.Add(appointment)
            Next

            appointment = New Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "The Daily Scrum", "One of the most popular Agile project management and development methods, Scrum is starting to be adopted at major corporations and on very large projects. After an quick introduction to the basics of Scrum like: the Scrum Master, team, product owner, and burn down, and of course the daily Scrum, Stephen, Remi, and Joel show many real world applications of the methodology drawn from his own experience as a Scrum Master. Negotiating with the business, estimation, and team dynamics are all discussed as well as how to use Scrum in small organizations, large enterprise environments, and consulting environments. The speakers will also discuss using Scrum with virtual teams and even an offshoring environment. The session will finish with a large Q&A on best practices", "Room 604")
            appointment.RecurrenceRule = New DailyRecurrenceRule(baseDate.AddHours(11.0), 2)
            Me.radSchedulerDemo.Appointments.Add(appointment)
            Me.radSchedulerDemo.Appointments.EndUpdate()

            Me.radSchedulerDemo.Resources.Add(New Resource(1, "Dell Laptop"))
            Me.radSchedulerDemo.Resources.Add(New Resource(2, "Lenovo Laptop"))
            Me.radSchedulerDemo.Resources.Add(New Resource(3, "Toshiba Laptop"))

            Me.InitializeCalendar()

            Me.radSchedulerDemo.ActiveViewType = SchedulerViewType.Week
            TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayViewBase).RangeFactor = ScaleRange.HalfHour
            TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayViewBase).RulerWidth = 45

            Dim dayView As SchedulerDayViewElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewElement)
            dayView.GetDayViewBase().RulerWidth = 43
            dayView.DataAreaElement.Table.ScrollToWorkHours()

            AddHandler Me.radSchedulerDemo.ActiveViewChanged, AddressOf radSchedulerDemo_ActiveViewChanged
        End Sub

        Private Sub radCalendar1_ViewChanged(sender As Object, e As EventArgs)
            InitializeCalendar()
        End Sub

        Private Sub radSchedulerDemo_ActiveViewChanged(sender As Object, e As SchedulerViewChangedEventArgs)
            If TryCast(e.NewView, SchedulerMonthView) Is Nothing Then
                Dim dayBase As SchedulerDayViewBase = TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayViewBase)

                If dayBase IsNot Nothing Then
                    If e.OldView IsNot Nothing AndAlso e.NewView IsNot Nothing Then
                        If e.NewView.ViewType <> e.OldView.ViewType Then
                            dayBase.RangeFactor = ScaleRange.HalfHour
                        End If
                    End If
                End If

                Dim dayView As SchedulerDayViewElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewElement)

                dayView.DataAreaElement.Table.ScrollToWorkHours()
            End If

            If e.NewView.ViewType <> e.OldView.ViewType AndAlso e.NewView.ViewType = SchedulerViewType.Month Then
                Me.radSchedulerDemo.GetMonthView().WeekCount = 5
            End If
        End Sub

        Private Sub Appointments_CollectionChanged(sender As Object, e As Telerik.WinControls.Data.NotifyCollectionChangedEventArgs)
            InitializeCalendar()
        End Sub

        Private Sub InitializeCalendar()
            Dim viewElement As MultiMonthViewElement = TryCast(Me.radCalendar1.CalendarElement.CalendarVisualElement, MultiMonthViewElement)

            Me.radCalendar1.CalendarElement.Margin = New Padding(0, 0, 0, 14)

            If viewElement IsNot Nothing Then
                Dim table As CalendarMultiMonthViewTableElement = viewElement.GetMultiTableElement()

                For Each monthView As MonthViewElement In table.Children
                    monthView.TitleElement.Margin = New Padding(-4, -2, -2, -2)
                    monthView.TitleElement.Padding = New Padding(3)

                    For Each cell As CalendarCellElement In monthView.TableElement.Children
                        Dim headerCell As Boolean = CBool(cell.GetValue(CalendarCellElement.IsHeaderCellProperty))
                        If headerCell Then
                            Continue For
                        End If

                        Dim view As New SchedulerDayView()
                        view.DayCount = 1
                        view.StartDate = cell.[Date]
                        view.GetViewContainingDate(cell.[Date])

                        view.UpdateAppointments(Me.radSchedulerDemo.Appointments)

                        If view.Appointments.Count > 0 Then
                            cell.Font = New Font(cell.Font, FontStyle.Bold)
                        Else
                            cell.Font = Me.radCalendar1.Font
                        End If
                    Next
                Next
            End If
        End Sub

        Private Sub radScheduler1_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
            InitializeCalendar()
        End Sub

        Private Sub radCalendar1_SelectionChanged(sender As Object, e As EventArgs)
            If Me.radCalendar1.SelectedDates.Count > 0 Then
                Me.radSchedulerDemo.ActiveView.StartDate = Me.radCalendar1.SelectedDate
            End If
        End Sub

        Private Sub radSchedulerNavigator1_ShowWeekendStateChanged(sender As Object, args As StateChangedEventArgs)
            If TryCast(Me.radSchedulerDemo.ActiveView, SchedulerMonthView) Is Nothing Then
                TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayViewBase).RulerWidth = 45

                TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewElement).DataAreaElement.ScrollView.Value = Point.Empty

                TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewElement).DataAreaElement.Table.ScrollToWorkHours()
            End If
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                Me.initialTimer.Dispose()
                Me.radSchedulerReminder1.Dispose()
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub radDropDownList1_SelectedValueChanged(sender As Object, e As EventArgs)
            Me.radSchedulerDemo.SchedulerElement.EditorManager.EditorViewMode = DirectCast(Me.radDropDownList1.SelectedValue, SchedulerEditorViewMode)
        End Sub

        Private Sub radCheckBox1_CheckStateChanged(sender As Object, e As EventArgs)
            Me.radSchedulerDemo.AllowAppointmentsMultiSelect = Me.radCheckBox1.Checked
        End Sub
    End Class
End Namespace
