
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.Timeline
    Partial Public Class Form1
        Inherits ExamplesForm
#Region "Fields"
        Private isUpdating As Boolean = False
#End Region

#Region "Constructors"

        Public Sub New()
            InitializeComponent()

            Me.radScheduler1.GetTimelineView().GetTimescale(Timescales.Months).Visible = False
            Me.radScheduler1.ActiveView.StartDate = DateTime.Today
            Me.radScheduler1.AutoSizeAppointments = True

            SetRadioTags()

            FillAppointments()

            ShowActiveAppointments()

            Me.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Days)
            AddHandler Me.radScheduler1.ActiveView.PropertyChanged, AddressOf ActiveView_PropertyChanged
            AddHandler Me.radScheduler1.CellSelectionChanged, AddressOf radScheduler1_CellSelectionChanged
            Me.radScheduler1.SelectionBehavior.SelectCell(Me.radScheduler1.ViewElement.GetCellAtPosition(0, 0))
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radDateTimePickerStart.ValueChanged, AddressOf Me.radDateTimePickerStart_ValueChanged
            AddHandler Me.radDateTimePickerEnd.ValueChanged, AddressOf Me.radDateTimePickerEnd_ValueChanged
            AddHandler Me.radSpinEditorTimeSlots.ValueChanged, AddressOf Me.radSpinEditorTimeSlots_ValueChanged
            AddHandler Me.radRadioButtonWeek.ToggleStateChanged, AddressOf Me.radRadioButtonDay_ToggleStateChanged
            AddHandler Me.radRadioButtonMonth.ToggleStateChanged, AddressOf Me.radRadioButtonDay_ToggleStateChanged
            AddHandler Me.radRadioButtonHour.ToggleStateChanged, AddressOf Me.radRadioButtonDay_ToggleStateChanged
            AddHandler Me.radRadioButtonDay.ToggleStateChanged, AddressOf Me.radRadioButtonDay_ToggleStateChanged
            AddHandler Me.radCheckBoxExactTimeRendering.ToggleStateChanged, AddressOf radCheckBoxExactTimeRendering_ToggleStateChanged
            AddHandler Me.radCheckBoxAutoSizeAppointments.ToggleStateChanged, AddressOf radCheckBoxAutoSizeAppointments_ToggleStateChanged
            AddHandler Me.radSpinEditorVerticalSpacing.ValueChanged, AddressOf radSpinEditorVerticalSpacing_ValueChanged
            AddHandler Me.radTrackBar1.ValueChanged, AddressOf Me.radTrackBar1_ValueChanged
        End Sub

#End Region

#Region "Methods"

        Private Sub SetRadioTags()
            Me.radRadioButtonDay.Tag = Timescales.Days
            Me.radRadioButtonHour.Tag = Timescales.Hours
            Me.radRadioButtonWeek.Tag = Timescales.Weeks
            Me.radRadioButtonMonth.Tag = Timescales.Months
        End Sub

        Private Sub ShowActiveAppointments()
            Me.radDateTimePickerStart.Value = Me.radScheduler1.GetTimelineView().RangeStartDate
            Me.radDateTimePickerEnd.Value = Me.radScheduler1.GetTimelineView().RangeEndDate
        End Sub

        Private Sub FillAppointments()
            Me.radScheduler1.Appointments.BeginUpdate()

            Dim dtStart As DateTime = DateTime.Today.AddHours(10)
            Dim dtEnd As DateTime = DateTime.Today.AddHours(12)

            Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
            appointment.BackgroundId = CInt(AppointmentBackground.Anniversary)
            appointment.StatusId = CInt(AppointmentStatus.Unavailable)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(2), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
            appointment.BackgroundId = CInt(AppointmentBackground.Business)
            appointment.StatusId = CInt(AppointmentStatus.Free)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(3), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
            appointment.BackgroundId = CInt(AppointmentBackground.Important)
            appointment.StatusId = CInt(AppointmentStatus.Tentative)
            Me.radScheduler1.Appointments.Add(appointment)

            dtStart = dtStart.AddDays(1)
            dtEnd = dtEnd.AddDays(1)

            appointment = New Appointment(dtStart, dtEnd.AddDays(3), "MOSS 2007 Web 2.0 Controls / AJAX / Silverlight", "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING!  In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!")
            appointment.BackgroundId = CInt(AppointmentBackground.MustAttend)
            appointment.StatusId = CInt(AppointmentStatus.Free)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(1), dtEnd.AddHours(1), "Control Customization In Silverlight 3", "Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls. ")
            appointment.BackgroundId = CInt(AppointmentBackground.NeedsPreparation)
            appointment.StatusId = CInt(AppointmentStatus.Busy)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Science Fiction Becomes Reality With WPF", "In this session you will see how the two worlds of science fiction and real-life software embrace each-other to form an astonishing mixture of art, user experience and functionality. We will show you a different perspective of how you can utilize modern technologies to achieve better interaction and presentation in ways you only consider possible in movies.")
            appointment.BackgroundId = CInt(AppointmentBackground.PhoneCall)
            appointment.StatusId = CInt(AppointmentStatus.Busy)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(5), "Building Office Applications With VSTO", "This session focuses on the power and developer productivity of Visual Studio Tools for the Office System (VSTO). VSTO is a .NET Smart Client technology and this session will delve into the tips and tricks, positives and negatives when designing and building smart client applications with VSTO. VSTO allows you to build managed code applications with .NET languages like VB.NET and C# and have the functionality of those applications manifest in the rich user interfaces of Microsoft Excel, Word, PowerPoint, Visio, Outlook and others from the Office stack. You will learn just how easy it is to build powerful VSTO applications in this session and how to deploy those applications. This session will cover all versions of VSTO (versions 1.0 through 3.0) targeting both Office 2003 and Office 2007. VSTO addresses some of the biggest challenges that Office solution developers are facing today, including separation of data and view elements, server-side and offline scenarios, seamless integration with the Visual Studio tools, deployment and updating. Lastly, this session will delve into the future of VSTO and its potential coverage of document-centric and add-in solutions for the entire Office System stack.")
            appointment.BackgroundId = CInt(AppointmentBackground.Personal)
            appointment.StatusId = CInt(AppointmentStatus.Tentative)
            Me.radScheduler1.Appointments.Add(appointment)

            Dim tempDateTime As DateTime = dtEnd.AddHours(7)
            appointment = New Appointment(dtStart.AddHours(6), tempDateTime.AddDays(1), "Blend For Silverlight Developers", "In this session, we will dig into how developers can use Blend for their Silverlight 2 applications. This includes tips and tricks for common graphic tasks like shiny buttons, clipping regions and grouping/layers. Common programmer tasks like event handling, data binding and stying is also covered.")
            appointment.BackgroundId = CInt(AppointmentBackground.Business)
            appointment.StatusId = CInt(AppointmentStatus.Free)
            Me.radScheduler1.Appointments.Add(appointment)

            dtStart = dtStart.AddDays(1)
            dtEnd = dtEnd.AddDays(1)

            appointment = New Appointment(dtStart.AddHours(1), dtEnd.AddHours(4), "I Must Attend This Meeting Week Day.", "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.")
            appointment.BackgroundId = CInt(AppointmentBackground.Vacation)
            appointment.StatusId = CInt(AppointmentStatus.Unavailable)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(5), dtEnd.AddHours(7), "Integrating WPF And WCF Into Office Business Applications", "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.")
            appointment.BackgroundId = CInt(AppointmentBackground.Personal)
            appointment.StatusId = CInt(AppointmentStatus.Tentative)
            Me.radScheduler1.Appointments.Add(appointment)

            appointment = New Appointment(dtStart.AddHours(8), dtEnd.AddHours(10), "Pragmatic ASP.NET Tips, Tricks, And Tools", "Every experienced ASP.NET developer has picked up a few cool tricks or useful tools that they put to use on every new project after they've learned them. This session draws upon the experience of many successful ASP.NET developers and distills this knowledge into a collection of tips and tricks you can start using in your work today. Some of the topics covered in this session include error handling, tracing, caching, base page classes, site layout and architecture, and data access best practices. You'll learn about highly reusable Http Modules and Handlers and a few code routines you may want to add to your personal library. Stick around for part 2 if you’re interested in learning about a wide variety of (usually free) tools available to aid ASP.NET developers. This session is appropriate for anyone who is working with ASP.NET today, and especially for those who are new to ASP.NET.")
            appointment.BackgroundId = CInt(AppointmentBackground.MustAttend)
            appointment.StatusId = CInt(AppointmentStatus.Busy)
            Me.radScheduler1.Appointments.Add(appointment)

            dtStart = dtStart.AddDays(1)
            dtEnd = dtEnd.AddDays(1)

            appointment = New Appointment(dtStart, dtEnd, "Fun With Programming", "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.")
            appointment.BackgroundId = CInt(AppointmentBackground.NeedsPreparation)
            appointment.StatusId = CInt(AppointmentStatus.Busy)
            Me.radScheduler1.Appointments.Add(appointment)

            Me.radScheduler1.Appointments.EndUpdate()
        End Sub
#End Region

#Region "Events"

        Private Sub ActiveView_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs)
            If e.PropertyName = "CurrentScale" Then
                isUpdating = True
                Dim scale As SchedulerTimescale = Me.radScheduler1.GetTimelineView().GetScaling()
                Select Case scale.Timescale
                    Case Timescales.Months
                        Me.radRadioButtonMonth.IsChecked = True
                        Exit Select
                    Case Timescales.Hours
                        Me.radRadioButtonHour.IsChecked = True
                        Exit Select
                    Case Timescales.Days
                        Me.radRadioButtonDay.IsChecked = True
                        Exit Select
                    Case Timescales.Weeks
                        Me.radRadioButtonWeek.IsChecked = True
                        Exit Select
                End Select
                isUpdating = False
            End If
        End Sub

        Private Sub radDateTimePickerEnd_ValueChanged(sender As Object, e As EventArgs)
            Me.radScheduler1.GetTimelineView().RangeEndDate = Me.radDateTimePickerEnd.Value
        End Sub

        Private Sub radDateTimePickerStart_ValueChanged(sender As Object, e As EventArgs)
            Me.radScheduler1.GetTimelineView().RangeStartDate = Me.radDateTimePickerStart.Value
        End Sub

        Private Sub radRadioButtonDay_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If isUpdating Then
                Return
            End If

            Dim schedulerTimelineView As SchedulerTimelineView = Me.radScheduler1.GetTimelineView()
            Dim timescales As Timescales = DirectCast(DirectCast(sender, RadRadioButton).Tag, Timescales)
            schedulerTimelineView.ShowTimescale(timescales)

            AdjustSpintEditorValues(timescales)
        End Sub

        Private Sub AdjustSpintEditorValues(timescales__1 As Timescales)
            Select Case timescales__1
                Case Timescales.Months, Timescales.Hours
                    Me.radSpinEditorTimeSlots.Maximum = 12
                    Me.radSpinEditorTimeSlots.Value = 12
                    Exit Select
                Case Timescales.Days
                    Me.radSpinEditorTimeSlots.Maximum = 7
                    Me.radSpinEditorTimeSlots.Value = 7
                    Exit Select
                Case Timescales.Weeks
                    Me.radSpinEditorTimeSlots.Maximum = 4
                    Me.radSpinEditorTimeSlots.Value = 4
                    Exit Select
            End Select
        End Sub

        Private Sub radSpinEditorTimeSlots_ValueChanged(sender As Object, e As EventArgs)
            Dim timescale As SchedulerTimescale = Me.radScheduler1.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Me.radSpinEditorTimeSlots.Value)
        End Sub

        Private Sub radSpinEditorVerticalSpacing_ValueChanged(sender As Object, e As EventArgs)
            Dim timeline As SchedulerTimelineViewElement = TryCast(Me.radScheduler1.ViewElement, SchedulerTimelineViewElement)
            timeline.AppointmentMargin = New System.Windows.Forms.Padding(timeline.AppointmentMargin.Left,
                                                                          Convert.ToInt32(Me.radSpinEditorVerticalSpacing.Value / 2),
                                                                          timeline.AppointmentMargin.Right,
                                                                          Convert.ToInt32(Me.radSpinEditorVerticalSpacing.Value / 2))
        End Sub

        Private Sub radCheckBoxAutoSizeAppointments_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radScheduler1.AutoSizeAppointments = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxExactTimeRendering_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radScheduler1.EnableExactTimeRendering = args.ToggleState = ToggleState.[On]
        End Sub

        Private suspendTrackBar As Boolean = False
        Private Sub radTrackBar1_ValueChanged(sender As Object, e As EventArgs)
            Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column
            If column >= 0 AndAlso Not suspendTrackBar Then
                DirectCast(Me.radScheduler1.ViewElement, SchedulerTimelineViewElement).SetColumnWidth(column, Me.radTrackBar1.Value)
            End If
        End Sub

        Private Sub radScheduler1_CellSelectionChanged(sender As Object, e As EventArgs)
            suspendTrackBar = True
            Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column
            If column >= 0 Then
                Me.radTrackBar1.Value = DirectCast(Me.radScheduler1.ViewElement, SchedulerTimelineViewElement).GetColumnWidth(column)
            End If

            suspendTrackBar = False
        End Sub

#End Region

    End Class
End Namespace