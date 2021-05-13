Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.AgendaView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private defaultFontHeader As Font = New System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Regular)
		Private defaultFontBold As Font = New System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold)
        Private Shadows defaultFont As Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        Private Shadows defaultPadding As New Padding(10, 10, 0, 0)

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			InitializeControlsAndWireEvents()
			AddResources()
			FillAppointments()

			Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Agenda
			CType(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerAgendaViewElement).Grid.Columns("Recurrence").IsVisible = False
		End Sub

		Private Sub InitializeControlsAndWireEvents()
			Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Agenda
			Dim agendaView As SchedulerAgendaView = TryCast(Me.radScheduler1.SchedulerElement.View, SchedulerAgendaView)
			Dim agendaViewElement As SchedulerAgendaViewElement = TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerAgendaViewElement)

			agendaViewElement.Grid.CurrentRow = Nothing
			Me.radSchedulerNavigator1.SchedulerNavigatorElement.ViewPanel.Visibility = ElementVisibility.Collapsed
			Me.radCalendar1.SelectedDate = Date.Today
			Me.daysCountSpinEditor.Value = agendaView.DayCount
			Me.daysCountSpinEditor.Minimum = 1
			Me.daysCountSpinEditor.Maximum = 30

			Me.resourceToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.resourceToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.resourceToggleButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radCheckedListBox1.SelectedItem = Nothing
			Me.radCheckedListBox1.FullRowSelect = True
			Me.radCheckedListBox1.ItemSize = New Size(150, 30)
			AddHandler Me.radCheckedListBox1.SelectedItemChanging, AddressOf radCheckedListBox1_SelectedItemChanging
			AddHandler Me.radCheckedListBox1.VisualItemFormatting, AddressOf radCheckedListBox1_VisualItemFormatting
			AddHandler Me.radCheckedListBox1.ItemCheckedChanged, AddressOf radCheckedListBox1_ItemCheckedChanged
			Me.radCheckedListBox1.Items(0).CheckState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.resourceToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			agendaView.GroupByDate = False
			Me.noGroupRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			AddHandler Me.groupRadioButton.ToggleStateChanged, AddressOf groupRadioButton_ToggleStateChanged
			AddHandler Me.radCalendar1.SelectionChanged, AddressOf radCalendar1_SelectionChanged
			AddHandler Me.daysCountSpinEditor.ValueChanged, AddressOf daysCountSpinEditor_ValueChanged
			AddHandler Me.resourceToggleButton1.ToggleStateChanged, AddressOf resourceToggleButton1_ToggleStateChanged
			AddHandler Me.resourceToggleButton2.ToggleStateChanged, AddressOf resourceToggleButton2_ToggleStateChanged
			AddHandler Me.resourceToggleButton3.ToggleStateChanged, AddressOf resourceToggleButton3_ToggleStateChanged
			AddHandler Me.radSchedulerNavigator1.NavigateBackwardsClick, AddressOf radSchedulerNavigator1_NavigateClick
			AddHandler Me.radSchedulerNavigator1.NavigateForwardsClick, AddressOf radSchedulerNavigator1_NavigateClick
		End Sub

		Private Sub radSchedulerNavigator1_NavigateClick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCalendar1.SelectedDate = Me.radScheduler1.ActiveView.StartDate
		End Sub

		Private Sub resourceToggleButton3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radScheduler1.Resources(2).Visible = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
			RefreshAppointmentsByResource()
		End Sub

		Private Sub resourceToggleButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radScheduler1.Resources(1).Visible = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
			RefreshAppointmentsByResource()
		End Sub

		Private Sub resourceToggleButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radScheduler1.Resources(0).Visible = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
			RefreshAppointmentsByResource()
		End Sub

		Private Sub RefreshAppointmentsByResource()
			Me.radScheduler1.Appointments.BeginUpdate()
			For Each a As Appointment In Me.radScheduler1.Appointments
				If IsResourceVisible(a.ResourceId) Then
					a.Visible = True
				Else
					a.Visible = False
				End If
			Next a
			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Function IsResourceVisible(ByVal resourceId As EventId) As Boolean
			For Each res As Resource In Me.radScheduler1.Resources
				If res.Id Is resourceId AndAlso res.Visible Then
					If res.Visible Then
						Return True
					End If
					Return False
				End If
			Next res
			Return False
		End Function

		Private Sub daysCountSpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim agendaView As SchedulerAgendaView = TryCast(Me.radScheduler1.SchedulerElement.View, SchedulerAgendaView)
			agendaView.DayCount = CInt(Fix(Me.daysCountSpinEditor.Value))
		End Sub

		Private Sub radCalendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radScheduler1.FocusedDate = Me.radCalendar1.SelectedDate
		End Sub

		Private Sub groupRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim agendaView As SchedulerAgendaView = TryCast(Me.radScheduler1.SchedulerElement.View, SchedulerAgendaView)
			Dim agendaViewElement As SchedulerAgendaViewElement = TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerAgendaViewElement)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				agendaView.GroupByDate = False
			Else
				agendaView.GroupByDate = True
			End If
		End Sub

		Private Sub AddResources()
			Dim resource_Renamed As New Resource()
			resource_Renamed.Id = New EventId(1)
			resource_Renamed.Name = "Nancy Davolio"
			resource_Renamed.Color = Color.LightBlue
            resource_Renamed.Image = My.Resources.nancy45x45
            Me.radScheduler1.Resources.Add(resource_Renamed)

			resource_Renamed = New Resource()
			resource_Renamed.Id = New EventId(2)
			resource_Renamed.Name = "Andrew Fuller"
			resource_Renamed.Color = Color.LightSalmon
            resource_Renamed.Image = My.Resources.andrew45x45
            Me.radScheduler1.Resources.Add(resource_Renamed)

			resource_Renamed = New Resource()
			resource_Renamed.Id = New EventId(3)
			resource_Renamed.Name = "Robert King"
			resource_Renamed.Color = Color.LightYellow
			resource_Renamed.Image = My.Resources.bob45x45
			Me.radScheduler1.Resources.Add(resource_Renamed)
		End Sub

		Private Sub FillAppointments()
			Dim appointment_Renamed As New Appointment(Date.Today.AddHours(7), TimeSpan.FromMinutes(60), "Keynote", "Opening session")
			appointment_Renamed.StatusId = 3
			appointment_Renamed.BackgroundId = 6
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Dim rrule As New DailyRecurrenceRule(appointment_Renamed.Start, 1, 2)
			appointment_Renamed.RecurrenceRule = rrule
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(8), TimeSpan.FromMinutes(60), "Things Developers Need to Know about Building Intelligent Apps", "In this session, we will discuss the top trends that developers need to be aware of as they begin to integrate Artificial Intelligence into their applications. ")
			appointment_Renamed.StatusId = 3
			appointment_Renamed.BackgroundId = 6
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(9), TimeSpan.FromMinutes(45), "3DPrinterOS is the world’s first operating system for 3D printers, powered by Azure", "3DPrinterOS is an easy to use real-time digital manufacturing OS. Just like DOS and IBM revolutionized the PC information age, 3DPrinterOS makes it easy to print and operate many different brands of 3D printers from one UI. ")
			appointment_Renamed.StatusId = 1
			appointment_Renamed.BackgroundId = 4
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(1).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(9).AddMinutes(30), TimeSpan.FromMinutes(90), "Azure services every developers needs to know about", "Azure is a powerful platform with many amazing services, but it can also be hard to know which ones you need to know about when you’re first getting started with cloud development. In this talk we’ll cover five common services that most .NET applications designed to run in the cloud will benefit from using.")
			appointment_Renamed.StatusId = 4
			appointment_Renamed.BackgroundId = 1
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(2).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(10), TimeSpan.FromMinutes(120), "Reasons to Move Your C++ Code to Visual Studio 2017", "Come learn the top 7 reasons to use Visual Studio 2017 if you are a C++ developer. Whether you are using the product and are looking to upgrade, or you never used it before but you are considering it now, join us to discover how Visual Studio 2017 raises the bar in terms of C++ productivity. ")
			appointment_Renamed.StatusId = 1
			appointment_Renamed.BackgroundId = 6
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(12), TimeSpan.FromMinutes(120), "A Developer’s Introduction to Big Data Processing with Azure Databricks", "In this session you’ll see an introductory journey into how Azure Databricks can bring together structured, and unstructured data, help derive deep insights with Machine Learning, and even create a real-time feedback loop. Your applications deserve to be more intelligent, and when it comes to data-driven intelligence, Azure Databricks is the way to go.")
			appointment_Renamed.StatusId = 5
			appointment_Renamed.BackgroundId = 5
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(1).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(14), TimeSpan.FromMinutes(75), "Accelerating Windows 10 enterprise app deployment with MSIX", "MSIX provides lots of benefits across the app lifecycle management. Learn how to take advantage of MSIX in your enterprise and the benefits to developers, IT Pros and end users. During the session we will deep dive into the benefits of MSIX and the new tooling and features available to make it easy to move your existing apps to MSIX. As you move to MSIX we will also discuss what it means for things like legacy plug-ins.")
			appointment_Renamed.StatusId = 3
			appointment_Renamed.BackgroundId = 1
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(2).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(14).AddMinutes(30), TimeSpan.FromMinutes(45), "Accelerate your SaaS App development using the power of the Business Application Platform", "Join this session to learn how the Business Application Platform can accelerate the time to market for your next Line of Business SaaS app. ")
			appointment_Renamed.StatusId = 2
			appointment_Renamed.BackgroundId = 4
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(15), TimeSpan.FromMinutes(120), "Adaptive Cards in Bots, Windows, Outlook and your own applications", "Learn how Bots, Windows and Outlook use the power of Adaptive cards to showcase information from applications like yours. Using the same technology, your application can do the same to help create interactive and actionable experiences that are both engaging and can simplify business processes across your organization.")
			appointment_Renamed.StatusId = 1
			appointment_Renamed.BackgroundId = 1
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(1).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(16), TimeSpan.FromMinutes(90), "Adding Visual Intelligence to your application with Windows Machine Learning", "In this lab you will learn how Azure Custom Vision and the Windows AI Platform seamlessly work together to add Visual Intelligence to your UWP application. Custom Vision enables you to easily customize your own state-of-the-art computer vision models that fit perfectly with your unique use case.")
			appointment_Renamed.StatusId = 5
			appointment_Renamed.BackgroundId = 3
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(1).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(17), TimeSpan.FromMinutes(120), "Adobe's proven practices for running Open Source Workloads on Azure", "Adobe Experience Cloud is the fastest growing product at Adobe and to reach the next phase of its vision, it would need a global infrastructure, on-demand scalability, and the capability to store, manage, analyze big data and support the open source tools and platforms that Adobe builds with.")
			appointment_Renamed.StatusId = 2
			appointment_Renamed.BackgroundId = 1
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(2).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddHours(17).AddMinutes(30), TimeSpan.FromMinutes(120), "Amplifying human ingenuity with Microsoft AI", "Microsoft is delivering a flexible AI platform for organizations and developers to infuse intelligence into their products and services using tools and services like Microsoft Cognitive Services, Azure Bot Service, Azure Machine Learning, and Cognitive Toolkit. In this session, we provide a high-level view of the Microsoft AI Platform and show demos for you to amplify your ingenuity with intelligent technology.")
			appointment_Renamed.StatusId = 4
			appointment_Renamed.BackgroundId = 2
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddDays(1).AddHours(9).AddMinutes(30), TimeSpan.FromMinutes(120), ".NET Overview & Roadmap", "We'll take a look at the current state of .NET, it's incredible growth, and the new features of .NET Core 2.1. We'll also show you the exciting direction .NET is headed to help you build cutting edge solutions for the future. ")
			appointment_Renamed.StatusId = 2
			appointment_Renamed.BackgroundId = 3
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(2).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddDays(1).AddHours(12).AddMinutes(30), TimeSpan.FromMinutes(120), "Building secure cloud apps – lessons learned from Microsoft’s internal security and software engineering teams", "Learn from Core Services Engineering & Operations (formerly Microsoft IT) software engineering leads and our Digital Security & Risk Engineering (DSRE) engineers how our Line of Business application development teams work hand in hand with our security experts to implement tools and patterns to secure our cloud footprint while accelerating the speed at which our software engineers build applications in the cloud. ")
			appointment_Renamed.StatusId = 3
			appointment_Renamed.BackgroundId = 2
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(1).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddDays(1).AddHours(14).AddMinutes(30), TimeSpan.FromMinutes(120), "Building smart apps with Visual Studio, Xamarin, and Cognitive Services", "What can’t you do with Cognitive Services? Come see how to leverage these powerful services to infuse your apps with intelligent algorithms to see, hear, speak, understand, and interpret your user needs to transform your business with AI.")
			appointment_Renamed.StatusId = 4
			appointment_Renamed.BackgroundId = 2
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddDays(1).AddHours(15), TimeSpan.FromMinutes(120), "Building Solution Templates and Managed Applications for the Azure Marketplace", "The Azure Marketplace provides a great opportunity for visibility and validation of your applications for customers. Millions of compute hours are driven through certified applications available in the Azure Marketplace each month. ")
			appointment_Renamed.StatusId = 4
			appointment_Renamed.BackgroundId = 2
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(2).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)

			appointment_Renamed = New Appointment(Date.Today.AddDays(1).AddHours(17).AddMinutes(30), TimeSpan.FromMinutes(120), "Building Windows - how the bits flow from check-in to the fast-ring", "Ever wondered how Microsoft takes the combined work of over 11,000 engineers developing Windows at Microsoft, bring it together in one branch, build, test and get it onto your desktop.")
			appointment_Renamed.StatusId = 4
			appointment_Renamed.BackgroundId = 2
			appointment_Renamed.ResourceId = Me.radScheduler1.Resources(0).Id
			Me.radScheduler1.Appointments.Add(appointment_Renamed)
		End Sub

		Private Sub radCheckedListBox1_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
			e.VisualItem.Margin = New Padding(6, 10, 0, 0)

			e.VisualItem.Font = defaultFont

			Dim visualItem As SimpleListViewVisualItem = TryCast(e.VisualItem, SimpleListViewVisualItem)
			If visualItem IsNot Nothing Then
				visualItem.ToggleElement.Margin = New Padding(0, 0, 5, 0)
			End If
		End Sub

		Private Sub radCheckedListBox1_ItemCheckedChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs)
			RemoveHandler Me.radCheckedListBox1.ItemCheckedChanged, AddressOf radCheckedListBox1_ItemCheckedChanged
			If e.Item.Text = "All Categories" Then
				For Each item As ListViewDataItem In Me.radCheckedListBox1.Items
					If item IsNot e.Item Then
						item.CheckState = e.Item.CheckState
					End If
				Next item
			Else
				Dim areAllItemsChecked As Boolean = True
				For i As Integer = 1 To Me.radCheckedListBox1.Items.Count - 1
					If Me.radCheckedListBox1.Items(i).CheckState = Telerik.WinControls.Enumerations.ToggleState.Off Then
						areAllItemsChecked = False
						Exit For
					End If
				Next i
				If areAllItemsChecked = True Then
					'this.radCheckedListBox1.Items[0].CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
				Else
					Me.radCheckedListBox1.Items(0).CheckState = Telerik.WinControls.Enumerations.ToggleState.Off
				End If
			End If
			AddHandler Me.radCheckedListBox1.ItemCheckedChanged, AddressOf radCheckedListBox1_ItemCheckedChanged
			RefreshVisibleAppointmentsByBackground()
		End Sub

		Private Sub RefreshVisibleAppointmentsByBackground()
			Me.radScheduler1.Appointments.BeginUpdate()
			For Each a As Appointment In Me.radScheduler1.Appointments
				If IsBackgroundChecked(a.BackgroundId) OrElse Me.radCheckedListBox1.Items(0).CheckState = Telerik.WinControls.Enumerations.ToggleState.On Then
					a.Visible = True
				Else
					a.Visible = False
				End If
			Next a
			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Function IsBackgroundChecked(ByVal id As Integer) As Boolean
			If id = 0 AndAlso Me.radCheckedListBox1.Items(0).CheckState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return True
			End If
			For Each item As ListViewDataItem In Me.radCheckedListBox1.Items
				If CInt(Fix(item.Tag)) = id AndAlso item.CheckState = Telerik.WinControls.Enumerations.ToggleState.On Then
					Return True
				End If
			Next item
			Return False
		End Function

		Private Sub radCheckedListBox1_SelectedItemChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemCancelEventArgs)
			e.Cancel = True
		End Sub
	End Class
End Namespace