Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
	Partial Public Class CustomEditAppointmentDialog
		Inherits RadSchedulerDialog
		Implements IEditAppointmentDialog
		#Region "fields"

		Private Shared ReadOnly EndOfDayTimeSpan As New TimeSpan(23, 59, 59)
		Private Shared ReadOnly StartOfDayTimeSpan As New TimeSpan(0, 0, 0)

		Private appointment As IEvent = Nothing
		Private schedulerData As ISchedulerData = Nothing
		Protected openRecurringAppointmentDialog As IOpenRecurringAppointmentDialog = Nothing

		Private recurringAppointment As IEvent = Nothing
		Private saveRecurringAppointment As Boolean = False

		#End Region

		#Region "constructors"

		Public Sub New()
			InitializeComponent()

			WireEvents()
		End Sub

		#End Region

		#Region "IEditAppointmentDialog Members"

        Public Function EditAppointment(ByVal appointment As IEvent, ByVal schedulerData As ISchedulerData) As Boolean Implements IEditAppointmentDialog.EditAppointment
            Me.appointment = appointment
            Me.schedulerData = schedulerData

            ' show OpenRecurringAppointmentDialog
            If Me.appointment IsNot Nothing AndAlso Me.appointment.MasterEvent IsNot Nothing Then
                If Me.openRecurringAppointmentDialog Is Nothing Then
                    Me.openRecurringAppointmentDialog = New OpenRecurringAppointmentDialog()
                End If
                Me.openRecurringAppointmentDialog.ThemeName = Me.ThemeName
                Me.openRecurringAppointmentDialog.EventName = appointment.Summary
                Dim result As DialogResult = Me.openRecurringAppointmentDialog.ShowDialog()
                If result <> DialogResult.OK Then
                    Return False
                End If

                Dim editOccurrence As Boolean = Me.openRecurringAppointmentDialog.EditOccurrence
                If Not editOccurrence Then
                    Me.appointment = TryCast(Me.appointment.MasterEvent, OutlookLikeAppointment)
                End If
            End If

            Return True
        End Function

        Public Sub ShowRecurrenceDialog() Implements IEditAppointmentDialog.ShowRecurrenceDialog
            ' initialize the recurringAppointment as OutlookLikeAppointment
            If Me.recurringAppointment Is Nothing Then
                Me.recurringAppointment = New OutlookLikeAppointment()
            End If

            ' set settings
            Me.recurringAppointment.Start = Me.GetAppointmentStart()
            Me.recurringAppointment.End = Me.GetAppointmentEnd()
            If (Not Me.RecurrenceSettingsShouldBeSaved()) AndAlso Me.appointment.RecurrenceRule IsNot Nothing Then
                Me.recurringAppointment.RecurrenceRule = Me.appointment.RecurrenceRule.Clone()
            End If

            ' show EditRecurrenceDialog
            Dim editRecurrenceDialog As IEditRecurrenceDialog = New EditRecurrenceDialog(recurringAppointment, Me.schedulerData)
            editRecurrenceDialog.ThemeName = Me.ThemeName
            Dim result As DialogResult = editRecurrenceDialog.ShowDialog()
            If result = DialogResult.OK Then
                Me.saveRecurringAppointment = True

                Me.SetStartDateAndTime(Me.recurringAppointment.Start)
                Me.SetEndDateAndTime(Me.recurringAppointment.End)

                ApplyRecurrenceBehavior(Me.recurringAppointment)
            End If
        End Sub

        Public Overloads Function ShowDialog() As System.Windows.Forms.DialogResult Implements IEditAppointmentDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function

        Private Shadows Event Shown As System.EventHandler Implements IEditAppointmentDialog.Shown

#End Region

#Region "events"

        Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.saveRecurringAppointment = False
            Me.recurringAppointment = Nothing

            ' load appointment settings and controls data
            Me.LoadStatuses()
            Me.LoadSettingsFromEvent(Me.appointment)
            Me.ApplyRecurrenceBehavior(Me.appointment)

            Me.btnRecurrence.Enabled = (Me.appointment.MasterEvent Is Nothing)
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)

            Me.txtSubject.Focus()
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApplySettingsToEvent(Me.appointment)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.schedulerData IsNot Nothing Then
				Me.schedulerData.GetEventStorage().Remove(Me.appointment)
			End If

			Me.DialogResult = DialogResult.Abort
			Me.Close()
		End Sub

		Private Sub btnRecurrence_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ShowRecurrenceDialog()
		End Sub

		#End Region

		#Region "private methods"

		Private Sub LoadStatuses()
			If Me.schedulerData Is Nothing Then
				Return
			End If

			Dim statusStorage As ISchedulerStorage(Of IAppointmentStatusInfo) = Me.schedulerData.GetStatusStorage()
			Me.cmbShowTimeAs.BeginUpdate()
			Me.cmbShowTimeAs.Items.Clear()
			For Each status As IAppointmentStatusInfo In statusStorage
				Me.cmbShowTimeAs.Items.Add(New RadListDataItem(status.DisplayName, status.Id))
			Next status

			If Me.cmbShowTimeAs.Items.Count > 0 Then
				Me.cmbShowTimeAs.SelectedIndex = 0
			End If

			Me.cmbShowTimeAs.EndUpdate()
		End Sub


		Private Sub ApplySettingsToEvent(ByVal targetEvent As IEvent)
			' appointment settings
			targetEvent.Summary = Me.txtSubject.Text
			targetEvent.Location = Me.txtLocation.Text
			targetEvent.Description = Me.txtDescription.Text

			Dim selectedStatus As Object = Me.cmbShowTimeAs.SelectedValue
			targetEvent.StatusId = If((selectedStatus IsNot Nothing), CInt(Fix(selectedStatus)), 1)

			targetEvent.Start = Me.GetAppointmentStart()
			targetEvent.End = Me.GetAppointmentEnd()

			If Me.RecurrenceSettingsShouldBeSaved() Then
				targetEvent.RecurrenceRule = Me.recurringAppointment.RecurrenceRule
			End If

			' if we are editing an occurrence, add an exception
			If targetEvent.MasterEvent IsNot Nothing Then
				If Not targetEvent.MasterEvent.Exceptions.Contains(targetEvent) Then
					If targetEvent.RecurrenceId Is Nothing Then
						targetEvent.RecurrenceId = targetEvent.Start
					End If
					targetEvent.MasterEvent.Exceptions.Add(targetEvent)
				End If
			End If

			' OutlookLike settings
			Dim outlookAppointment As OutlookLikeAppointment = TryCast(targetEvent, OutlookLikeAppointment)
			If outlookAppointment Is Nothing Then
				Return
			End If
			outlookAppointment.Email = Me.txtEmail.Text
		End Sub

		Private Sub LoadSettingsFromEvent(ByVal sourceEvent As IEvent)
			' appointment settings
			Me.txtSubject.Text = sourceEvent.Summary
			Me.txtLocation.Text = sourceEvent.Location
			Me.txtDescription.Text = sourceEvent.Description

			Me.cmbShowTimeAs.SelectedValue = sourceEvent.StatusId

			Me.SetStartDateAndTime(sourceEvent.Start)
			Me.SetEndDateAndTime(sourceEvent.End)

			Dim totalHours As Double = sourceEvent.Duration.TotalHours
			Dim isAllDay As Boolean = totalHours >= 23.99 AndAlso Math.Round(totalHours) Mod 24 = 0
			Me.chkAllDay.ToggleState = If(isAllDay, ToggleState.On, ToggleState.Off)

			If Me.appointment IsNot Nothing AndAlso Me.schedulerData IsNot Nothing Then
				Me.btnDelete.Enabled = schedulerData.GetEventStorage().Contains(Me.appointment) AndAlso sourceEvent.AllowDelete
			End If

			Me.SetTimePickersEnabledState(isAllDay)

			' OutlookLike settings
			Dim outlookAppointment As OutlookLikeAppointment = TryCast(sourceEvent, OutlookLikeAppointment)
			If outlookAppointment Is Nothing Then
				Me.txtEmail.Text = String.Empty
				Return
			End If
			Me.txtEmail.Text = outlookAppointment.Email
		End Sub


		Private Sub ApplyRecurrenceBehavior(ByVal appointment As IEvent)
			Dim isOutlookBehavior As Boolean = False
			Dim scheduler As Telerik.WinControls.UI.RadScheduler = TryCast(Me.schedulerData, Telerik.WinControls.UI.RadScheduler)

			If scheduler IsNot Nothing Then
				If appointment IsNot Nothing AndAlso appointment.RecurrenceRule IsNot Nothing Then
					isOutlookBehavior = True
				End If
			End If

			Me.dateStart.Enabled = Not isOutlookBehavior
			Me.dateEnd.Enabled = Not isOutlookBehavior
			Me.timeStart.Enabled = (Not isOutlookBehavior) AndAlso Not Me.chkAllDay.Checked
			Me.timeEnd.Enabled = (Not isOutlookBehavior) AndAlso Not Me.chkAllDay.Checked
			Me.chkAllDay.Visible = Not isOutlookBehavior
		End Sub

		Private Function RecurrenceSettingsShouldBeSaved() As Boolean
			Return Me.saveRecurringAppointment AndAlso Me.recurringAppointment IsNot Nothing
		End Function

		Private Sub SetTimePickersEnabledState(ByVal allDay As Boolean)
			Dim enabled As Boolean = Not allDay
			Me.timeStart.Enabled = enabled
			Me.timeEnd.Enabled = enabled
		End Sub


		Private Function GetAppointmentStart() As Date
			Dim startDate As Date = Me.dateStart.Value.Date

			If Not(Me.chkAllDay.ToggleState = ToggleState.On) Then
				Dim startTime As TimeSpan = Me.timeStart.Value.TimeOfDay
				startDate = startDate.Add(startTime)
			End If

			Return startDate
		End Function

		Private Function GetAppointmentEnd() As Date
			Dim endDate As Date = Me.dateEnd.Value.Date
			Dim endTime As TimeSpan = Me.timeEnd.Value.TimeOfDay

			Dim isAllDay As Boolean = Me.chkAllDay.ToggleState = ToggleState.On
			If Not isAllDay Then
				endDate = endDate.Add(endTime)
			Else
				endDate = endDate.Add(CustomEditAppointmentDialog.EndOfDayTimeSpan)
			End If

			Return endDate
		End Function

		Private Sub SetStartDateAndTime(ByVal start As Date)
			Me.dateStart.Value = start
			Me.timeStart.Value = start
		End Sub

		Private Sub SetEndDateAndTime(ByVal [end] As Date)
			Me.dateEnd.Value = [end]
			Me.timeEnd.Value = [end]
		End Sub

		#End Region

		Protected Overrides Sub OnThemeChanged()
			MyBase.OnThemeChanged()

			ThemeResolutionService.ApplyThemeToControlTree(Me, Me.ThemeName)
		End Sub

		Private Sub WireEvents()
			AddHandler btnSave.Click, AddressOf btnSave_Click
			AddHandler btnDelete.Click, AddressOf btnDelete_Click
			AddHandler btnRecurrence.Click, AddressOf btnRecurrence_Click
		End Sub
	End Class
End Namespace