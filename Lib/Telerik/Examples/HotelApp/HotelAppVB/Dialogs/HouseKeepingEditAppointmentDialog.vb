Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Scheduler.Dialogs

Namespace HotelApp
	Partial Public Class HouseKeepingEditAppointmentDialog
		Inherits EditAppointmentDialog
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub LoadSettingsFromEvent(ByVal sourceEvent As Telerik.WinControls.UI.IEvent)
			MyBase.LoadSettingsFromEvent(sourceEvent)

			Me.labelSubject.Text = "Room Id"
			Me.labelStatus.Text = "Status"
			Me.labelBackground.Text = "Priority"
			Me.labelLocation.Visible = False
			Me.txtLocation.Visible = False

			Me.radLabelReminder.Visible = False
			Me.radDropDownListReminder.Visible = False
			Me.buttonRecurrence.Visible = False
			Me.buttonDelete.Visible = False
			Me.textBoxDescription.Visible = False

			Dim r As Room = TryCast(Me.Appointment.DataItem, Room)
			If r IsNot Nothing Then
				Me.needsRepairsCheckBox.Checked = r.NeedsRepairs
			End If
		End Sub

		Protected Overrides Sub ApplySettingsToEvent(ByVal targetEvent As Telerik.WinControls.UI.IEvent)
			MyBase.ApplySettingsToEvent(targetEvent)
			Dim r As Room = TryCast(Me.Appointment.DataItem, Room)
			If r IsNot Nothing Then
				r.NeedsRepairs = Me.needsRepairsCheckBox.Checked
			End If
		End Sub

		Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.Text = "Room House Keeping"
			Me.chkAllDay.Visible = False
			Me.labelBackground.Top -= 40
			Me.cmbBackground.Top -= 40
			Me.cmbBackground.Left -= 23
			Me.labelStatus.Top -= 40
			Me.labelStatus.Left -= 40
			Me.cmbShowTimeAs.Top -= 40
			Me.cmbShowTimeAs.Left -= 80
			Me.cmbShowTimeAs.Width = 130
			Me.needsRepairsCheckBox.Top = Me.cmbShowTimeAs.Top + 10
			Me.needsRepairsCheckBox.Left += 80

			Me.radSeparator1.Top -= 40
			Me.radSeparator1.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.radSeparator2.Top -= 40
			Me.radSeparator2.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.timeStart.Top -= 40
			Me.timeEnd.Top -= 40
			Me.dateStart.Top -= 40
			Me.dateEnd.Top -= 40
			Me.labelStartTime.Top -= 40
			Me.labelEndTime.Top -= 40
			Me.cmbResource.Top -= 40
			Me.cmbResource.Left += 30
			Me.labelResource.Top -= 40
			Me.labelResource.Text = "House Keeper"
			Me.radSeparator3.Top -= 40
			Me.radSeparator3.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)

			Me.timeStart.Width += 10
			Me.timeEnd.Width += 10
			Me.buttonOK.Top -= 220
			Me.buttonCancel.Top -= 220
			Me.buttonCancel.Left -= 20
			Me.doneButton.Top = Me.buttonOK.Top
			Me.doneButton.Left += 40
			Me.Height -= 220
		End Sub

		Private Sub doneButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles doneButton.Click
			If Not Me.ValidateInput() Then
				Return
			End If
			Dim r As Room = TryCast(Me.Appointment.DataItem, Room)
			If r IsNot Nothing Then
				Me.cmbShowTimeAs.SelectedValue = CInt(HouseKeepingStatus.Clean)
				Me.ApplySettingsToEvent(Me.Appointment)
				r.HouseKeeperId = Nothing
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub
	End Class
End Namespace