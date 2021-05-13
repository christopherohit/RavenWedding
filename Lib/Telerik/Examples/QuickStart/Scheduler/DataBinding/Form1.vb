Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.SchedulerDataSetTableAdapters
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports System.Data.OleDb

Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
	Partial Public Class Form1
		Inherits ExamplesForm
		Private appointments As List(Of MyAppointment) = Nothing
		Private resources As List(Of MyResource) = Nothing
		Private schedulerDataSet As SchedulerDataSet = Nothing

		Private appointmentsAdapter As New AppointmentsTableAdapter()

		Public Sub New()
			InitializeComponent()

			AddHandler appointmentsAdapter.Adapter.RowUpdated, AddressOf Adapter_RowUpdated
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radSchedulerDemo.ActiveView.StartDate = New Date(2009, 3, 7)

			AddHandler rbBusinessObjects.ToggleStateChanged, AddressOf rbBusinessObjects_ToggleStateChanged
			AddHandler rbDataSet.ToggleStateChanged, AddressOf rbDataSet_ToggleStateChanged

			Me.rbBusinessObjects.ToggleState = ToggleState.On
			Me.radLabel1.Visible = False
			Me.radLabel1.ForeColor = Color.Black

			Me.radSchedulerDemo.AppointmentFactory = New CustomAppointmentFactory()

			AddHandler radSchedulerDemo.AppointmentEditDialogShowing, AddressOf radSchedulerDemo_AppointmentEditDialogShowing
		End Sub

		Private appointmentDialog As IEditAppointmentDialog = Nothing

		Private Sub radSchedulerDemo_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
			If Me.appointmentDialog Is Nothing Then
				Me.appointmentDialog = New CustomAppointmentEditForm()
			End If
			e.AppointmentEditDialog = Me.appointmentDialog
		End Sub

		Private Sub rbDataSet_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.BindToDataSet()
				Me.btnSave.Visible = True
				Me.radLabel1.Visible = True
			End If
		End Sub

		Private Sub rbBusinessObjects_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.BindToBusinessObjects()
				Me.btnSave.Visible = False
				Me.radLabel1.Visible = False
			End If
		End Sub

		Private Sub BindToDataSet()
			If Me.schedulerDataSet Is Nothing Then
				Me.schedulerDataSet = New SchedulerDataSet()

				Me.appointmentsAdapter.Fill(Me.schedulerDataSet.Appointments)

				Dim resourcesAdapter As New ResourcesTableAdapter()
				resourcesAdapter.Fill(Me.schedulerDataSet.Resources)

				Dim appointmentsResourcesAdapter As New AppointmentsResourcesTableAdapter()
				appointmentsResourcesAdapter.Fill(Me.schedulerDataSet.AppointmentsResources)
			End If

			Dim dataSource As New SchedulerBindingDataSource()
			dataSource.EventProvider.AppointmentFactory = Me.radSchedulerDemo.AppointmentFactory

			Dim appointmentMappingInfo As New AppointmentMappingInfo()
			appointmentMappingInfo.Mappings.Add(New SchedulerMapping("Email", "Email"))

			appointmentMappingInfo.UniqueId = "ID"
			appointmentMappingInfo.Start = "Start"
			appointmentMappingInfo.End = "End"
			appointmentMappingInfo.Summary = "Summary"
			appointmentMappingInfo.Description = "Description"
			appointmentMappingInfo.Location = "Location"
			appointmentMappingInfo.BackgroundId = "BackgroundID"
			appointmentMappingInfo.StatusId = "StatusID"
			appointmentMappingInfo.Resources = "AppointmentsAppointmentsResources"
			appointmentMappingInfo.ResourceId = "ResourceID"
			appointmentMappingInfo.RecurrenceRule = "RecurrenceRule"
			appointmentMappingInfo.Exceptions = "AppointmentsAppointments"
			appointmentMappingInfo.MasterEventId = "ParentID"
			appointmentMappingInfo.Visible = "Visible"

			dataSource.EventProvider.Mapping = appointmentMappingInfo
			dataSource.EventProvider.DataSource = Me.schedulerDataSet.Appointments

			Dim resourceMappingInfo As New ResourceMappingInfo()
			resourceMappingInfo.Id = "ID"
			resourceMappingInfo.Name = "ResourceName"

			dataSource.ResourceProvider.Mapping = resourceMappingInfo
			dataSource.ResourceProvider.DataSource = Me.schedulerDataSet.Resources

			Me.radSchedulerDemo.DataSource = dataSource
		End Sub

		Private Sub BindToBusinessObjects()
			Me.appointments = New List(Of MyAppointment)()

			Dim baseDate As New Date(2009, 3, 7)
			Dim start() As Date = { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) }
			Dim [end]() As Date = { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) }
			Dim summaries() As String = { "Mr. Brown", "Mr. White", "Mrs. Green" }
			Dim descriptions() As String = { "", "", "" }
			Dim locations() As String = { "City", "Out of town", "Service Center" }


			Dim appointment As MyAppointment = Nothing
			For i As Integer = 0 To summaries.Length - 1
				appointment = New MyAppointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
				Me.appointments.Add(appointment)
			Next i

			Dim recurringAppointment As New MyAppointment(baseDate.AddHours(7.0), baseDate.AddHours(10.0), "Recurring appointment with exceptions", Nothing, Nothing)
			recurringAppointment.RecurrenceRule = "FREQ=DAILY"
			Dim notVisibleException As New MyAppointment(recurringAppointment.Start.AddDays(1.0), recurringAppointment.End.AddDays(1.0), "Recurring appointment with exceptions", Nothing, Nothing)
			notVisibleException.MasterAppointment = recurringAppointment
			notVisibleException.Visible = False
			recurringAppointment.Exceptions.Add(notVisibleException)
			Me.appointments.Add(recurringAppointment)

			'int[] resourceIds = new int[] { 1, 2, 3 };
			Dim resourceNames() As String = { "Dell Laptop", "Lenovo Laptop", "Toshiba Laptop" }
			Me.resources = New List(Of MyResource)()
			For i As Integer = 0 To resourceNames.Length - 1
				Me.resources.Add(New MyResource(resourceNames(i)))
			Next i

			Dim dataSource As New SchedulerBindingDataSource()
			dataSource.EventProvider.AppointmentFactory = Me.radSchedulerDemo.AppointmentFactory

			Dim appointmentMappingInfo As New AppointmentMappingInfo()
			appointmentMappingInfo.Mappings.Add(New SchedulerMapping("Email", "Email"))

			appointmentMappingInfo.Start = "Start"
			appointmentMappingInfo.End = "End"
			appointmentMappingInfo.Summary = "Subject"
			appointmentMappingInfo.Description = "Description"
			appointmentMappingInfo.Location = "Location"
			appointmentMappingInfo.UniqueId = "Id"
			appointmentMappingInfo.Resources = "Resources"
			appointmentMappingInfo.ResourceId = "Id"
			appointmentMappingInfo.RecurrenceRule = "RecurrenceRule"
			appointmentMappingInfo.Exceptions = "Exceptions"
			appointmentMappingInfo.MasterEventId = "MasterAppointment"
			appointmentMappingInfo.Visible = "Visible"
			dataSource.EventProvider.Mapping = appointmentMappingInfo
			dataSource.EventProvider.DataSource = Me.appointments

			Dim resourceMappingInfo As New ResourceMappingInfo()
			resourceMappingInfo.Id = "Id"
			resourceMappingInfo.Name = "Name"

			dataSource.ResourceProvider.Mapping = resourceMappingInfo
			dataSource.ResourceProvider.DataSource = Me.resources

			Me.radSchedulerDemo.DataSource = dataSource
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
			'see http://msdn.microsoft.com/en-us/library/ms171933.aspx
			Dim appointmentsResourcesAdapter As New AppointmentsResourcesTableAdapter()
			appointmentsResourcesAdapter.Adapter.AcceptChangesDuringUpdate = False

			Dim newChildRecords As SchedulerDataSet.AppointmentsResourcesDataTable = Nothing
			Dim modifiedChildRecords As SchedulerDataSet.AppointmentsResourcesDataTable = Nothing

			Dim deletedChildRecords As SchedulerDataSet.AppointmentsResourcesDataTable = TryCast(Me.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Deleted), SchedulerDataSet.AppointmentsResourcesDataTable)

			Try
				If deletedChildRecords IsNot Nothing Then
					appointmentsResourcesAdapter.Update(deletedChildRecords)
				End If

				Me.appointmentsAdapter.Update(Me.schedulerDataSet.Appointments)
				'this.schedulerDataSet.Appointments.AcceptChanges();

				newChildRecords = TryCast(Me.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Added), SchedulerDataSet.AppointmentsResourcesDataTable)

				modifiedChildRecords = TryCast(Me.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Modified), SchedulerDataSet.AppointmentsResourcesDataTable)

				If newChildRecords IsNot Nothing Then
					appointmentsResourcesAdapter.Update(newChildRecords)
				End If

				If modifiedChildRecords IsNot Nothing Then
					appointmentsResourcesAdapter.Update(modifiedChildRecords)
				End If

				Me.schedulerDataSet.AcceptChanges()
			Catch ex As Exception
				MessageBox.Show(String.Format("An error occurred during the update process:" & vbLf & "{0}", ex.Message))
			Finally
				If deletedChildRecords IsNot Nothing Then
					deletedChildRecords.Dispose()
				End If
				If newChildRecords IsNot Nothing Then
					newChildRecords.Dispose()
				End If
				If modifiedChildRecords IsNot Nothing Then
					modifiedChildRecords.Dispose()
				End If
			End Try
		End Sub

		'synchronize the appointment id between the dataset and the database
		'http://msdn.microsoft.com/en-us/library/ks9f57t0%28VS.71%29.aspx
		Private Sub Adapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
			If e.StatementType = StatementType.Insert Then
				Dim appointnmentsRow As SchedulerDataSet.AppointmentsRow = TryCast(e.Row, SchedulerDataSet.AppointmentsRow)
				If appointnmentsRow IsNot Nothing Then
					Me.schedulerDataSet.EnforceConstraints = False
					Dim oldReadOnly As Boolean = Me.schedulerDataSet.Appointments.IDColumn.ReadOnly
					Me.schedulerDataSet.Appointments.IDColumn.ReadOnly = False
					Dim newId As Integer = GetIndentity()

					For Each row As SchedulerDataSet.AppointmentsResourcesRow In Me.schedulerDataSet.AppointmentsResources
						If row.RowState = DataRowState.Added AndAlso row.AppointmentID = appointnmentsRow.ID Then
							row.AppointmentID = newId
						End If
					Next row

					For Each row As SchedulerDataSet.AppointmentsRow In Me.schedulerDataSet.Appointments
						If row.RowState = DataRowState.Added AndAlso row(Me.schedulerDataSet.Appointments.ParentIDColumn) IsNot DBNull.Value AndAlso row.ParentID = appointnmentsRow.ID Then
							row.ParentID = newId
						End If
					Next row
					appointnmentsRow.ID = newId

					Me.schedulerDataSet.Appointments.IDColumn.ReadOnly = oldReadOnly
					Me.schedulerDataSet.EnforceConstraints = True
				End If
			End If
		End Sub

		Private Function GetIndentity() As Integer
			Dim command As New OleDbCommand()
			command.Connection = Me.appointmentsAdapter.Connection
			command.CommandText = "Select @@IDENTITY"

			Dim obj As Object = command.ExecuteScalar()

			Return CInt(Fix(obj))
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler btnSave.Click, AddressOf btnSave_Click
		End Sub
	End Class

	Public Class AppointmentWithEmail
		Inherits Appointment
		Public Sub New()
			MyBase.New()
		End Sub

'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String = String.Empty

		Public Property Email() As String
			Get
				Return Me.email_Renamed
			End Get
			Set(ByVal value As String)
				If Me.email_Renamed <> value Then
					Me.email_Renamed = value
					Me.OnPropertyChanged("Email")
				End If
			End Set
		End Property

		Protected Overrides Function CreateOccurrenceInstance() As [Event]
			Dim occurrence As New AppointmentWithEmail()
			occurrence.email = Me.email_Renamed
			Return occurrence
		End Function
	End Class

	Public Class CustomAppointmentFactory
		Implements IAppointmentFactory
		#Region "IAppointmentFactory Members"

		Public Function CreateNewAppointment() As IEvent Implements IAppointmentFactory.CreateNewAppointment
			Return New AppointmentWithEmail()
		End Function

		#End Region
	End Class
End Namespace
