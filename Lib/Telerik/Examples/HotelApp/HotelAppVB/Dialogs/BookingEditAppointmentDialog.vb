Imports CustomControls
Imports HotelApp.Data
Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.Dialogs

Namespace HotelApp
	Partial Public Class BookingEditAppointmentDialog
		Inherits EditAppointmentDialog
		Private Guests As BindingList(Of Guest)

		Public Sub New()
			InitializeComponent()
			Me.Opacity = 0
			AddHandler Me.addNewGuestButton.Click, AddressOf addNewGuestButton_Click
		End Sub

		Protected Overrides Sub OnShown(ByVal e As EventArgs)
			MyBase.OnShown(e)
			Me.Opacity = 1
		End Sub

		Protected Overrides Function ValidateInput() As Boolean
			If Me.guestsDropDownList.SelectedIndex < 0 Then
				Return False
			End If
			Return MyBase.ValidateInput()
		End Function

		Public Sub New(ByVal guests As BindingList(Of Guest))
			Me.New()
			Me.Guests = guests
		End Sub

		Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.ShowIcon = False
			Me.txtSubject.Width -= 10
			Me.txtSubject.Visible = False
			Me.txtSubject.Left += 10
			Me.chkAllDay.Visible = False
			Me.labelBackground.Top -= 40
			Me.cmbBackground.Top -= 40
			Me.cmbBackground.Left -= 13
			Me.labelStatus.Top -= 40
			Me.labelStatus.Left += 10
			Me.radSeparator1.Top -= 40
			Me.dateStart.Top -= 30
			Me.dateStart.Left += 10
			Me.dateEnd.Top = Me.dateStart.Top
			Me.dateStart.Width = 170
			Me.dateEnd.Width = 180
			Me.dateEnd.Left += 10
			Me.labelStartTime.Text = "Check-in:"
			Me.labelEndTime.Text = "Check-out:"
			Me.labelStartTime.Top -= 30
			Me.labelEndTime.Top -= 30
			Me.labelEndTime.Left = Me.labelStatus.Left - 5
			Me.labelEndTime.Top = Me.labelStartTime.Top
			Me.dateEnd.Left = Me.guestsDropDownList.Left
			Me.cmbBackground.Width = 170
			Me.guestsDropDownList.Width = 410
			Me.guestsDropDownList.Left = Me.txtSubject.Left
			Me.guestsDropDownList.Top = Me.txtSubject.Top
			Me.buttonOK.Top -= 320
			Me.buttonCancel.Top -= 320
			Me.buttonCancel.Left -= 20
			Me.Height -= 320
			Me.FormElement.TitleBar.CustomFont = Utils.MainFont
			Me.MaximumSize = New Size(Me.Width, Me.Height)

			Me.guestsDropDownList.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.addNewGuestButton.ButtonElement.Padding = New Padding(0)
			Me.addNewGuestButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.addNewGuestButton.Top = Me.txtSubject.Top
		End Sub

		Private Sub addNewGuestButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim addGuestForm As New RadForm()
			addGuestForm.ShowIcon = False
			addGuestForm.Text = "Add new guest"
			Dim scrollablePanel As New RadScrollablePanel()
			Dim editGuestInfo_Renamed As New EditGuestInfo()
			scrollablePanel.Controls.Add(editGuestInfo_Renamed)
			scrollablePanel.Dock = DockStyle.Fill
			addGuestForm.Controls.Add(scrollablePanel)
			editGuestInfo_Renamed.HeaderPanel.Visible = False
			addGuestForm.Height = editGuestInfo_Renamed.Height + addGuestForm.FormElement.TitleBar.Size.Height + 1
			AddHandler editGuestInfo_Renamed.SaveButton.Click, AddressOf SaveButton_Click
			Dim guest_Renamed As New Guest()
			editGuestInfo_Renamed.Initialize(guest_Renamed, New Booking())
			addGuestForm.StartPosition = FormStartPosition.Manual
			addGuestForm.Location = New Point(Screen.PrimaryScreen.Bounds.Width \ 2 - addGuestForm.Width \ 2,Screen.PrimaryScreen.Bounds.Height \ 2 - addGuestForm.Height \ 2)

			If addGuestForm.ShowDialog() = DialogResult.OK Then
				Me.Guests.Add(guest_Renamed)
			End If
		End Sub

		Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim saveButton As RadButton = TryCast(sender, RadButton)
			If saveButton IsNot Nothing Then
				Dim f As RadForm = TryCast(saveButton.FindForm(), RadForm)

				If saveButton.DialogResult = DialogResult.OK Then
					f.DialogResult = DialogResult.OK
					f.Close()
				End If
			End If
		End Sub

		Protected Overrides Sub LoadSettingsFromEvent(ByVal sourceEvent As Telerik.WinControls.UI.IEvent)
			MyBase.LoadSettingsFromEvent(sourceEvent)

			Dim b As Booking = TryCast(Me.Appointment.DataItem, Booking)
			If b IsNot Nothing Then
				Me.Text = "Edit booking for room #" & b.RoomId
			Else
                Me.Text = "New booking for room #" & Me.Appointment.ResourceId.KeyValue.ToString()
			End If

			Me.labelSubject.Text = "Guest:"
			Me.txtSubject.Enabled = False
			Me.textBoxDescription.Visible = False
			Me.cmbShowTimeAs.Visible = False
			Me.labelBackground.Text = "Status:"
			Me.chkAllDay.Visible = False
			Me.labelLocation.Visible = False
			Me.txtLocation.Visible = False
			Me.cmbResource.Visible = False
			Me.labelResource.Visible = False
			Me.radSeparator2.Visible = False
			Me.radSeparator3.Visible = False
			Me.radSeparator1.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.radLabelReminder.Visible = False
			Me.radDropDownListReminder.Visible = False
			Me.timeStart.Visible = False
			Me.timeEnd.Visible = False

			Me.buttonDelete.Visible = False
			Me.buttonRecurrence.Visible = False

			Me.guestsDropDownList.DataSource = Me.Guests
			Me.guestsDropDownList.DisplayMember = "Name"
			Me.guestsDropDownList.ValueMember = "Id"
			Me.guestsDropDownList.SelectedIndex = -1
			If b IsNot Nothing Then
				For i As Integer = 0 To Me.guestsDropDownList.Items.Count - 1
					If Me.guestsDropDownList.Items(i).Text = b.Guests(0).Name Then
						Me.guestsDropDownList.SelectedIndex = i
						Me.guestsDropDownList.DropDownListElement.TextBox.TextBoxItem.SelectionLength = 0
						Exit For
					End If
				Next i
			End If
			Me.labelStatus.Visible = False
			AddHandler Me.guestsDropDownList.SelectedValueChanged, AddressOf guestsDropDownList_SelectedValueChanged
		End Sub

		Private Sub guestsDropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.guestsDropDownList.SelectedValue Is Nothing Then
                Return
            End If

            Dim value As String = Me.guestsDropDownList.SelectedValue.ToString()
			Dim guest_Renamed As Guest = Utils.GetGuestById(Me.Guests, value)

			If guest_Renamed IsNot Nothing Then
				Me.txtSubject.Text = guest_Renamed.Name
			End If
			CType(Me.SchedulerData, RadScheduler).Tag = guest_Renamed
		End Sub
	End Class
End Namespace