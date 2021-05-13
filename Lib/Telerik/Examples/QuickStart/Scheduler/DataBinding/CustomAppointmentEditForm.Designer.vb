Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
	Partial Public Class CustomAppointmentEditForm
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
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.txtEmail = New Telerik.WinControls.UI.RadTextBox()
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
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' txtSubject
			' 
			Me.txtSubject.Size = New Size(456, 20)
			' 
			' txtLocation
			' 
			Me.txtLocation.Size = New Size(456, 20)
			' 
			' cmbBackground
			' 
			Me.cmbBackground.Location = New Point(79, 59)
			' 
			' 
			' 
			Me.cmbBackground.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbBackground.Size = New Size(200, 20)
			' 
			' dateStart
			' 
			Me.dateStart.NullableValue = New Date(2009, 6, 30, 18, 26, 5, 245)
			Me.dateStart.Size = New Size(104, 20)
			Me.dateStart.Text = "6/30/2009"
			Me.dateStart.Value = New Date(2009, 6, 30, 18, 26, 5, 245)
			' 
			' timeStart
			' 
			Me.timeStart.Location = New Point(189, 103)
			Me.timeStart.NullableValue = New Date(2009, 6, 30, 18, 26, 5, 245)
			Me.timeStart.Text = "6:26:05 PM"
			Me.timeStart.Value = New Date(2009, 6, 30, 18, 26, 5, 245)
			' 
			' dateEnd
			' 
			Me.dateEnd.NullableValue = New Date(2009, 6, 30, 18, 26, 5, 245)
			Me.dateEnd.Size = New Size(104, 20)
			Me.dateEnd.Text = "6/30/2009"
			Me.dateEnd.Value = New Date(2009, 6, 30, 18, 26, 5, 245)
			' 
			' timeEnd
			' 
			Me.timeEnd.Location = New Point(189, 129)
			Me.timeEnd.NullableValue = New Date(2009, 6, 30, 18, 26, 5, 245)
			Me.timeEnd.Text = "6:26:05 PM"
			Me.timeEnd.Value = New Date(2009, 6, 30, 18, 26, 5, 245)
			' 
			' chkAllDay
			' 
			Me.chkAllDay.Location = New Point(285, 103)
			' 
			' cmbResource
			' 
			' 
			' 
			' 
			Me.cmbResource.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbResource.Size = New Size(200, 20)
			' 
			' labelStatus
			' 
			Me.labelStatus.Location = New Point(286, 61)
			' 
			' cmbShowTimeAs
			' 
			Me.cmbShowTimeAs.Location = New Point(374, 59)
			' 
			' 
			' 
			Me.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbShowTimeAs.Size = New Size(161, 20)
			' 
			' textBoxDescription
			' 
			Me.textBoxDescription.Location = New Point(6, 238)
			' 
			' 
			' 
			Me.textBoxDescription.RootElement.StretchVertically = True
			Me.textBoxDescription.Size = New Size(529, 147)
			' 
			' buttonOK
			' 
			Me.buttonOK.Location = New Point(6, 391)
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Location = New Point(87, 391)
			' 
			' buttonDelete
			' 
			Me.buttonDelete.Location = New Point(168, 391)
			' 
			' buttonRecurrence
			' 
			Me.buttonRecurrence.Location = New Point(249, 391)
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(7, 212)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(35, 18)
			Me.radLabel1.TabIndex = 22
			Me.radLabel1.Text = "Email:"
			' 
			' txtEmail
			' 
			Me.txtEmail.Location = New Point(79, 210)
			Me.txtEmail.Name = "txtEmail"
			Me.txtEmail.Size = New Size(200, 20)
			Me.txtEmail.TabIndex = 23
			Me.txtEmail.TabStop = False
			' 
			' CustomAppointmentEditForm
			' 
			Me.ClientSize = New Size(539, 414)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.txtEmail)
			Me.Name = "CustomAppointmentEditForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New Size(150, 36)
			Me.Text = "Edit Appointment"
			Me.Controls.SetChildIndex(Me.txtEmail, 0)
			Me.Controls.SetChildIndex(Me.chkAllDay, 0)
			Me.Controls.SetChildIndex(Me.timeEnd, 0)
			Me.Controls.SetChildIndex(Me.timeStart, 0)
			Me.Controls.SetChildIndex(Me.cmbResource, 0)
			Me.Controls.SetChildIndex(Me.radSeparator1, 0)
			Me.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.Controls.SetChildIndex(Me.radSeparator2, 0)
			Me.Controls.SetChildIndex(Me.radSeparator3, 0)
			Me.Controls.SetChildIndex(Me.labelStatus, 0)
			Me.Controls.SetChildIndex(Me.labelSubject, 0)
			Me.Controls.SetChildIndex(Me.labelLocation, 0)
			Me.Controls.SetChildIndex(Me.labelBackground, 0)
			Me.Controls.SetChildIndex(Me.labelStartTime, 0)
			Me.Controls.SetChildIndex(Me.labelEndTime, 0)
			Me.Controls.SetChildIndex(Me.labelResource, 0)
			Me.Controls.SetChildIndex(Me.buttonOK, 0)
			Me.Controls.SetChildIndex(Me.buttonCancel, 0)
			Me.Controls.SetChildIndex(Me.cmbBackground, 0)
			Me.Controls.SetChildIndex(Me.buttonDelete, 0)
			Me.Controls.SetChildIndex(Me.buttonRecurrence, 0)
			Me.Controls.SetChildIndex(Me.txtSubject, 0)
			Me.Controls.SetChildIndex(Me.txtLocation, 0)
			Me.Controls.SetChildIndex(Me.dateStart, 0)
			Me.Controls.SetChildIndex(Me.dateEnd, 0)
			Me.Controls.SetChildIndex(Me.cmbShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.textBoxDescription, 0)
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
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private txtEmail As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace
