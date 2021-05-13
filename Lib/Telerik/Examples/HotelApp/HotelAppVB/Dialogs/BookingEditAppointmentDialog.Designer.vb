Namespace HotelApp
	Partial Public Class BookingEditAppointmentDialog
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.guestsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.addNewGuestButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.labelSubject, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelLocation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelBackground, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelEndTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAllDay, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelResource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbResource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelStatus, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonOK, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonDelete, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListReminder, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelReminder, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.guestsDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addNewGuestButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cmbBackground
			' 
			' 
			' 
			' 
			Me.cmbBackground.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' dateStart
			' 
			Me.dateStart.Text = "8/18/2017"
			Me.dateStart.Value = New Date(2017, 8, 18, 14, 26, 12, 426)
			' 
			' timeStart
			' 
			Me.timeStart.Text = "2:26:12 PM"
			Me.timeStart.Value = New Date(2017, 8, 18, 14, 26, 12, 426)
			' 
			' dateEnd
			' 
			Me.dateEnd.Text = "8/18/2017"
			Me.dateEnd.Value = New Date(2017, 8, 18, 14, 26, 12, 426)
			' 
			' timeEnd
			' 
			Me.timeEnd.Text = "2:26:12 PM"
			Me.timeEnd.Value = New Date(2017, 8, 18, 14, 26, 12, 426)
			' 
			' cmbShowTimeAs
			' 
			' 
			' 
			' 
			Me.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbShowTimeAs.Size = New Size(144, 20)
			' 
			' radDropDownListReminder
			' 
			Me.radDropDownListReminder.Text = "None"
			' 
			' radLabelReminder
			' 
			Me.radLabelReminder.Size = New Size(54, 18)
			Me.radLabelReminder.Text = "Reminder"
			' 
			' guestsDropDownList
			' 
			Me.guestsDropDownList.Location = New Point(347, 61)
			Me.guestsDropDownList.Name = "guestsDropDownList"
			Me.guestsDropDownList.Size = New Size(148, 20)
			Me.guestsDropDownList.TabIndex = 25
			Me.guestsDropDownList.Text = "radDropDownList1"
			' 
			' addNewGuestButton
			' 
			Me.addNewGuestButton.Image = My.Resources.plus
			Me.addNewGuestButton.Location = New Point(510, 61)
			Me.addNewGuestButton.Name = "addNewGuestButton"
			Me.addNewGuestButton.Size = New Size(20, 24)
			Me.addNewGuestButton.TabIndex = 26
			' 
			' BookingEditAppointmentDialog
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(545, 378)
			Me.Controls.Add(Me.addNewGuestButton)
			Me.Controls.Add(Me.guestsDropDownList)
			Me.Name = "BookingEditAppointmentDialog"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New Size(539, 365)
			Me.Text = "BookingEditAppointmentDialog"
			Me.Controls.SetChildIndex(Me.labelSubject, 0)
			Me.Controls.SetChildIndex(Me.labelLocation, 0)
			Me.Controls.SetChildIndex(Me.labelBackground, 0)
			Me.Controls.SetChildIndex(Me.txtSubject, 0)
			Me.Controls.SetChildIndex(Me.txtLocation, 0)
			Me.Controls.SetChildIndex(Me.cmbBackground, 0)
			Me.Controls.SetChildIndex(Me.labelStartTime, 0)
			Me.Controls.SetChildIndex(Me.labelEndTime, 0)
			Me.Controls.SetChildIndex(Me.dateStart, 0)
			Me.Controls.SetChildIndex(Me.timeStart, 0)
			Me.Controls.SetChildIndex(Me.dateEnd, 0)
			Me.Controls.SetChildIndex(Me.timeEnd, 0)
			Me.Controls.SetChildIndex(Me.chkAllDay, 0)
			Me.Controls.SetChildIndex(Me.labelResource, 0)
			Me.Controls.SetChildIndex(Me.cmbResource, 0)
			Me.Controls.SetChildIndex(Me.radLabelReminder, 0)
			Me.Controls.SetChildIndex(Me.radDropDownListReminder, 0)
			Me.Controls.SetChildIndex(Me.labelStatus, 0)
			Me.Controls.SetChildIndex(Me.cmbShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.textBoxDescription, 0)
			Me.Controls.SetChildIndex(Me.buttonOK, 0)
			Me.Controls.SetChildIndex(Me.buttonCancel, 0)
			Me.Controls.SetChildIndex(Me.buttonDelete, 0)
			Me.Controls.SetChildIndex(Me.buttonRecurrence, 0)
			Me.Controls.SetChildIndex(Me.radSeparator1, 0)
			Me.Controls.SetChildIndex(Me.radSeparator2, 0)
			Me.Controls.SetChildIndex(Me.radSeparator3, 0)
			Me.Controls.SetChildIndex(Me.guestsDropDownList, 0)
			Me.Controls.SetChildIndex(Me.addNewGuestButton, 0)
			CType(Me.labelSubject, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelLocation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelBackground, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbBackground, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelStartTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelEndTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAllDay, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelResource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbResource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelStatus, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonOK, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonCancel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonDelete, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListReminder, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelReminder, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.guestsDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addNewGuestButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private guestsDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private addNewGuestButton As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
