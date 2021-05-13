Imports Microsoft.VisualBasic
Imports System
Namespace MedicalAppCS
	Public Partial Class AppointmentForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.patientsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.startDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.endDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.locationTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.descriptionTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.cancelButton = New Telerik.WinControls.UI.RadButton()
			Me.saveButton = New Telerik.WinControls.UI.RadButton()
			Me.personsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter()
			Me.appointmentsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.AppointmentsTableAdapter()
			CType(Me.patientsDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.startDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.endDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.locationTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.descriptionTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' patientsDropDownList
			' 
			Me.patientsDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.patientsDropDownList.Location = New System.Drawing.Point(17, 33)
			Me.patientsDropDownList.Name = "patientsDropDownList"
			Me.patientsDropDownList.Size = New System.Drawing.Size(225, 20)
			Me.patientsDropDownList.TabIndex = 0
			Me.patientsDropDownList.ThemeName = "MedicalAppTheme"
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Location = New System.Drawing.Point(14, 12)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(41, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Patient"
			Me.radLabel1.ThemeName = "MedicalAppTheme"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(15, 62)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(30, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Start"
			Me.radLabel2.ThemeName = "MedicalAppTheme"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(14, 112)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(25, 18)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "End"
			Me.radLabel3.ThemeName = "MedicalAppTheme"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(307, 12)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(49, 18)
			Me.radLabel4.TabIndex = 2
			Me.radLabel4.Text = "Location"
			Me.radLabel4.ThemeName = "MedicalAppTheme"
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New System.Drawing.Point(307, 62)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(63, 18)
			Me.radLabel5.TabIndex = 2
			Me.radLabel5.Text = "Description"
			Me.radLabel5.ThemeName = "MedicalAppTheme"
			' 
			' startDateTimePicker
			' 
			Me.startDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm"
			Me.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.startDateTimePicker.Location = New System.Drawing.Point(17, 83)
			Me.startDateTimePicker.Name = "startDateTimePicker"
			Me.startDateTimePicker.Size = New System.Drawing.Size(225, 20)
			Me.startDateTimePicker.TabIndex = 3
			Me.startDateTimePicker.TabStop = False
			Me.startDateTimePicker.Text = "17-June-2015 12:00"
			Me.startDateTimePicker.Value = New System.DateTime(2015, 6, 17, 12, 0, 0, 0)
			' 
			' endDateTimePicker
			' 
			Me.endDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm"
			Me.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.endDateTimePicker.Location = New System.Drawing.Point(17, 133)
			Me.endDateTimePicker.Name = "endDateTimePicker"
			Me.endDateTimePicker.Size = New System.Drawing.Size(225, 20)
			Me.endDateTimePicker.TabIndex = 4
			Me.endDateTimePicker.TabStop = False
			Me.endDateTimePicker.Text = "17-June-2015 12:30"
			Me.endDateTimePicker.Value = New System.DateTime(2015, 6, 17, 12, 30, 0, 0)
			' 
			' locationTextBoxControl
			' 
			Me.locationTextBoxControl.Location = New System.Drawing.Point(310, 33)
			Me.locationTextBoxControl.Name = "locationTextBoxControl"
			Me.locationTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.locationTextBoxControl.TabIndex = 5
			Me.locationTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' descriptionTextBoxControl
			' 
			Me.descriptionTextBoxControl.Location = New System.Drawing.Point(310, 83)
			Me.descriptionTextBoxControl.Multiline = True
			Me.descriptionTextBoxControl.Name = "descriptionTextBoxControl"
			Me.descriptionTextBoxControl.Size = New System.Drawing.Size(225, 70)
			Me.descriptionTextBoxControl.TabIndex = 6
			Me.descriptionTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' cancelButton
			' 
			Me.cancelButton.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.cancelButton.Location = New System.Drawing.Point(97, 195)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(70, 21)
			Me.cancelButton.TabIndex = 40
			Me.cancelButton.Text = "Cancel"
			Me.cancelButton.ThemeName = "MedicalAppTheme"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click);
			' 
			' saveButton
			' 
			Me.saveButton.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.saveButton.Location = New System.Drawing.Point(17, 195)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(70, 21)
			Me.saveButton.TabIndex = 39
			Me.saveButton.Text = "Save"
			Me.saveButton.ThemeName = "MedicalAppTheme"
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' personsTableAdapter1
			' 
			Me.personsTableAdapter1.ClearBeforeFill = True
			' 
			' appointmentsTableAdapter1
			' 
			Me.appointmentsTableAdapter1.ClearBeforeFill = True
			' 
			' AppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(552, 228)
			Me.Controls.Add(Me.cancelButton)
			Me.Controls.Add(Me.saveButton)
			Me.Controls.Add(Me.descriptionTextBoxControl)
			Me.Controls.Add(Me.locationTextBoxControl)
			Me.Controls.Add(Me.endDateTimePicker)
			Me.Controls.Add(Me.startDateTimePicker)
			Me.Controls.Add(Me.radLabel5)
			Me.Controls.Add(Me.radLabel4)
			Me.Controls.Add(Me.radLabel3)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.patientsDropDownList)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AppointmentForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "New Appointment"
			Me.ThemeName = "MedicalAppTheme"
'			Me.Load += New System.EventHandler(Me.AddAppointmentForm_Load);
			CType(Me.patientsDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.startDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.endDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.locationTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.descriptionTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private patientsDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private startDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private endDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private locationTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private descriptionTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private WithEvents cancelButton As Telerik.WinControls.UI.RadButton
		Private WithEvents saveButton As Telerik.WinControls.UI.RadButton
		Private personsTableAdapter1 As PatientsDataSetTableAdapters.PersonsTableAdapter
		Private appointmentsTableAdapter1 As PatientsDataSetTableAdapters.AppointmentsTableAdapter
	End Class
End Namespace