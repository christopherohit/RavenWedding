Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace MedicalAppCS
	Public Partial Class AppointmentForm
		Inherits RadForm
		Private appointmentId As Integer = -1
		Private editing As Boolean = False
		Private errorProvider As ErrorProvider

		Public Sub New()
			InitializeComponent()
			Me.errorProvider = New ErrorProvider()
		End Sub

		Private Sub AddAppointmentForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.startDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.endDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.startDateTimePicker.ThemeName = "MedicalAppTheme"
			Me.endDateTimePicker.ThemeName = "MedicalAppTheme"

			Dim selectedPatientId As Integer = -1
			Dim appointmentsRow As PatientsDataSet.AppointmentsRow = TryCast(Me.Tag, PatientsDataSet.AppointmentsRow)
			If Not appointmentsRow Is Nothing Then
				Me.appointmentId = appointmentsRow.Id
				Me.editing = True
				Me.Text = "Edit Appointment"
				Me.startDateTimePicker.Value = appointmentsRow.Start
				Me.endDateTimePicker.Value = appointmentsRow.End
				selectedPatientId = appointmentsRow.PersonId
				If Not appointmentsRow("Location") Is DBNull.Value Then
					Me.locationTextBoxControl.Text = appointmentsRow.Location
				End If
				If Not appointmentsRow("Description") Is DBNull.Value Then
					Me.descriptionTextBoxControl.Text = appointmentsRow.Description
				End If
			End If

			Dim appointment As Appointment = TryCast(Me.Tag, Appointment)
			If Not appointment Is Nothing Then
				Me.startDateTimePicker.Value = appointment.Start
				Me.endDateTimePicker.Value = appointment.End
			End If


			Dim selectedItem As RadListDataItem = Nothing
			Me.patientsDropDownList.BeginUpdate()
			For Each person As PatientsDataSet.PersonsRow In DataSources.PatientsDataSet.Persons
				Dim item As RadListDataItem = New RadListDataItem(person.FirstName & " " & person.FamilyName, person.Id)
				If selectedPatientId <> -1 AndAlso selectedPatientId = person.Id Then
					selectedItem = item
				End If
				Me.patientsDropDownList.Items.Add(item)
			Next person
			Me.patientsDropDownList.EndUpdate()
			Me.patientsDropDownList.SelectedItem = selectedItem
		End Sub

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			If (Not Me.AreRequiredFieldsValid()) Then
				Return
			End If

			If Me.editing Then
				Me.EditAppointment()
			Else
				Me.AddAppointment()
			End If

			Me.Close()
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancelButton.Click
			Me.Close()
		End Sub

		Private Sub AddAppointment()
			Dim appointment As PatientsDataSet.AppointmentsRow = CType(DataSources.PatientsDataSet.Appointments.Rows.Add(), PatientsDataSet.AppointmentsRow)
			appointment.PersonId = CInt(Fix(Me.patientsDropDownList.SelectedItem.Value))
			appointment.Subject = Me.patientsDropDownList.SelectedItem.Text
			appointment.Start = Me.startDateTimePicker.Value
			appointment.End = Me.endDateTimePicker.Value
			appointment.Location = Me.locationTextBoxControl.Text
			appointment.Description = Me.descriptionTextBoxControl.Text

			Me.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments)
			Me.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments)
			RadMessageBox.Show(Me, "Appointment added.")
		End Sub

		Private Sub EditAppointment()
			Dim appointment As PatientsDataSet.AppointmentsRow = DataSources.PatientsDataSet.Appointments.FindById(Me.appointmentId)
			appointment.PersonId = CInt(Fix(Me.patientsDropDownList.SelectedItem.Value))
			appointment.Subject = Me.patientsDropDownList.SelectedItem.Text
			appointment.Start = Me.startDateTimePicker.Value
			appointment.End = Me.endDateTimePicker.Value
			appointment.Location = Me.locationTextBoxControl.Text
			appointment.Description = Me.descriptionTextBoxControl.Text

			Me.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments)
			Me.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments)
			RadMessageBox.Show(Me, "Appointment changed.")
		End Sub

		Private Function AreRequiredFieldsValid() As Boolean
			If Me.patientsDropDownList.SelectedItem Is Nothing Then
				Me.errorProvider.SetError(Me.patientsDropDownList, "Patient is required")
				Return False
			End If
			If Me.startDateTimePicker.DateTimePickerElement.Value Is Nothing Then
				Me.errorProvider.SetError(Me.startDateTimePicker, "Start Date is required")
				Return False
			End If
			If Me.endDateTimePicker.DateTimePickerElement.Value Is Nothing Then
				Me.errorProvider.SetError(Me.endDateTimePicker, "End Date is required")
				Return False
			End If

			Return True
		End Function
	End Class
End Namespace
