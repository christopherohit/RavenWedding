Imports Microsoft.VisualBasic
Imports System
Namespace MedicalAppCS
	Public Partial Class AddPatientForm
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
			Me.phoneMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.addressTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.stateTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.cityTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.photoBrowseEditor = New Telerik.WinControls.UI.RadBrowseEditor()
			Me.birthDateDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.genderFemaleRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.genderMaleRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.lastNameTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.middleNameTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.firstNameTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.saveButton = New Telerik.WinControls.UI.RadButton()
			Me.cancelButton = New Telerik.WinControls.UI.RadButton()
			Me.personsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter()
			Me.postalCodeTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
			Me.personImagesTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter()
			Me.patientsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter()
			CType(Me.phoneMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addressTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stateTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cityTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.photoBrowseEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.birthDateDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.genderFemaleRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.genderMaleRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lastNameTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.middleNameTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.firstNameTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.postalCodeTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' phoneMaskedEditBox
			' 
			Me.phoneMaskedEditBox.Location = New System.Drawing.Point(310, 260)
			Me.phoneMaskedEditBox.Mask = "(999) 000-0000"
			Me.phoneMaskedEditBox.Name = "phoneMaskedEditBox"
			Me.phoneMaskedEditBox.Size = New System.Drawing.Size(225, 20)
			Me.phoneMaskedEditBox.TabIndex = 35
			Me.phoneMaskedEditBox.TabStop = False
			Me.phoneMaskedEditBox.ThemeName = "MedicalAppTheme"
			' 
			' addressTextBoxControl
			' 
			Me.addressTextBoxControl.Location = New System.Drawing.Point(310, 133)
			Me.addressTextBoxControl.Multiline = True
			Me.addressTextBoxControl.Name = "addressTextBoxControl"
			Me.addressTextBoxControl.Size = New System.Drawing.Size(225, 54)
			Me.addressTextBoxControl.TabIndex = 33
			Me.addressTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' stateTextBoxControl
			' 
			Me.stateTextBoxControl.Location = New System.Drawing.Point(310, 83)
			Me.stateTextBoxControl.Name = "stateTextBoxControl"
			Me.stateTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.stateTextBoxControl.TabIndex = 32
			Me.stateTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' cityTextBoxControl
			' 
			Me.cityTextBoxControl.Location = New System.Drawing.Point(310, 33)
			Me.cityTextBoxControl.Name = "cityTextBoxControl"
			Me.cityTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.cityTextBoxControl.TabIndex = 31
			Me.cityTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' photoBrowseEditor
			' 
			Me.photoBrowseEditor.Location = New System.Drawing.Point(17, 260)
			Me.photoBrowseEditor.Name = "photoBrowseEditor"
			Me.photoBrowseEditor.Size = New System.Drawing.Size(225, 20)
			Me.photoBrowseEditor.TabIndex = 30
			Me.photoBrowseEditor.Text = "radBrowseEditor1"
			Me.photoBrowseEditor.ThemeName = "MedicalAppTheme"
			' 
			' birthDateDateTimePicker
			' 
			Me.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy"
			Me.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.birthDateDateTimePicker.Location = New System.Drawing.Point(17, 213)
			Me.birthDateDateTimePicker.Name = "birthDateDateTimePicker"
			Me.birthDateDateTimePicker.Size = New System.Drawing.Size(225, 20)
			Me.birthDateDateTimePicker.TabIndex = 29
			Me.birthDateDateTimePicker.TabStop = False
			Me.birthDateDateTimePicker.ThemeName = "MedicalAppTheme"
			Me.birthDateDateTimePicker.Value = New System.DateTime((CLng(Fix(0))))
			' 
			' genderFemaleRadioButton
			' 
			Me.genderFemaleRadioButton.Location = New System.Drawing.Point(111, 167)
			Me.genderFemaleRadioButton.Name = "genderFemaleRadioButton"
			Me.genderFemaleRadioButton.Size = New System.Drawing.Size(56, 18)
			Me.genderFemaleRadioButton.TabIndex = 28
			Me.genderFemaleRadioButton.TabStop = False
			Me.genderFemaleRadioButton.Text = "Female"
			Me.genderFemaleRadioButton.ThemeName = "MedicalAppTheme"
			' 
			' genderMaleRadioButton
			' 
			Me.genderMaleRadioButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.genderMaleRadioButton.Location = New System.Drawing.Point(17, 167)
			Me.genderMaleRadioButton.Name = "genderMaleRadioButton"
			Me.genderMaleRadioButton.Size = New System.Drawing.Size(45, 18)
			Me.genderMaleRadioButton.TabIndex = 27
			Me.genderMaleRadioButton.Text = "Male"
			Me.genderMaleRadioButton.ThemeName = "MedicalAppTheme"
			Me.genderMaleRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' lastNameTextBoxControl
			' 
			Me.lastNameTextBoxControl.Location = New System.Drawing.Point(17, 133)
			Me.lastNameTextBoxControl.Name = "lastNameTextBoxControl"
			Me.lastNameTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.lastNameTextBoxControl.TabIndex = 26
			Me.lastNameTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' middleNameTextBoxControl
			' 
			Me.middleNameTextBoxControl.Location = New System.Drawing.Point(17, 83)
			Me.middleNameTextBoxControl.Name = "middleNameTextBoxControl"
			Me.middleNameTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.middleNameTextBoxControl.TabIndex = 25
			Me.middleNameTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' firstNameTextBoxControl
			' 
			Me.firstNameTextBoxControl.Location = New System.Drawing.Point(17, 33)
			Me.firstNameTextBoxControl.Name = "firstNameTextBoxControl"
			Me.firstNameTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.firstNameTextBoxControl.TabIndex = 24
			Me.firstNameTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' radLabel9
			' 
			Me.radLabel9.Location = New System.Drawing.Point(307, 239)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New System.Drawing.Size(38, 18)
			Me.radLabel9.TabIndex = 23
			Me.radLabel9.Text = "Phone"
			Me.radLabel9.ThemeName = "MedicalAppTheme"
			' 
			' radLabel8
			' 
			Me.radLabel8.Location = New System.Drawing.Point(308, 112)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New System.Drawing.Size(46, 18)
			Me.radLabel8.TabIndex = 22
			Me.radLabel8.Text = "Address"
			Me.radLabel8.ThemeName = "MedicalAppTheme"
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New System.Drawing.Point(308, 62)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(32, 18)
			Me.radLabel7.TabIndex = 21
			Me.radLabel7.Text = "State"
			Me.radLabel7.ThemeName = "MedicalAppTheme"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New System.Drawing.Point(308, 12)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(25, 18)
			Me.radLabel6.TabIndex = 20
			Me.radLabel6.Text = "City"
			Me.radLabel6.ThemeName = "MedicalAppTheme"
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New System.Drawing.Point(14, 239)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(36, 18)
			Me.radLabel5.TabIndex = 19
			Me.radLabel5.Text = "Photo"
			Me.radLabel5.ThemeName = "MedicalAppTheme"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(14, 193)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(70, 18)
			Me.radLabel4.TabIndex = 18
			Me.radLabel4.Text = "Date of birth"
			Me.radLabel4.ThemeName = "MedicalAppTheme"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(14, 112)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(57, 18)
			Me.radLabel3.TabIndex = 17
			Me.radLabel3.Text = "Last name"
			Me.radLabel3.ThemeName = "MedicalAppTheme"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(14, 62)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(72, 18)
			Me.radLabel2.TabIndex = 16
			Me.radLabel2.Text = "Middle name"
			Me.radLabel2.ThemeName = "MedicalAppTheme"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(14, 12)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(58, 18)
			Me.radLabel1.TabIndex = 15
			Me.radLabel1.Text = "First name"
			Me.radLabel1.ThemeName = "MedicalAppTheme"
			' 
			' saveButton
			' 
			Me.saveButton.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.saveButton.Location = New System.Drawing.Point(17, 307)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(70, 21)
			Me.saveButton.TabIndex = 37
			Me.saveButton.Text = "Save"
			Me.saveButton.ThemeName = "MedicalAppTheme"
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' cancelButton
			' 
			Me.cancelButton.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.cancelButton.Location = New System.Drawing.Point(97, 307)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(70, 21)
			Me.cancelButton.TabIndex = 38
			Me.cancelButton.Text = "Cancel"
			Me.cancelButton.ThemeName = "MedicalAppTheme"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click);
			' 
			' personsTableAdapter1
			' 
			Me.personsTableAdapter1.ClearBeforeFill = True
			' 
			' postalCodeTextBoxControl
			' 
			Me.postalCodeTextBoxControl.Location = New System.Drawing.Point(310, 213)
			Me.postalCodeTextBoxControl.Name = "postalCodeTextBoxControl"
			Me.postalCodeTextBoxControl.Size = New System.Drawing.Size(225, 20)
			Me.postalCodeTextBoxControl.TabIndex = 34
			Me.postalCodeTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' radLabel10
			' 
			Me.radLabel10.Location = New System.Drawing.Point(307, 193)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New System.Drawing.Size(64, 18)
			Me.radLabel10.TabIndex = 37
			Me.radLabel10.Text = "Postal code"
			Me.radLabel10.ThemeName = "MedicalAppTheme"
			' 
			' personImagesTableAdapter1
			' 
			Me.personImagesTableAdapter1.ClearBeforeFill = True
			' 
			' patientsTableAdapter1
			' 
			Me.patientsTableAdapter1.ClearBeforeFill = True
			' 
			' AddPatientForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(552, 340)
			Me.Controls.Add(Me.postalCodeTextBoxControl)
			Me.Controls.Add(Me.radLabel10)
			Me.Controls.Add(Me.cancelButton)
			Me.Controls.Add(Me.saveButton)
			Me.Controls.Add(Me.phoneMaskedEditBox)
			Me.Controls.Add(Me.addressTextBoxControl)
			Me.Controls.Add(Me.stateTextBoxControl)
			Me.Controls.Add(Me.cityTextBoxControl)
			Me.Controls.Add(Me.photoBrowseEditor)
			Me.Controls.Add(Me.birthDateDateTimePicker)
			Me.Controls.Add(Me.genderFemaleRadioButton)
			Me.Controls.Add(Me.genderMaleRadioButton)
			Me.Controls.Add(Me.lastNameTextBoxControl)
			Me.Controls.Add(Me.middleNameTextBoxControl)
			Me.Controls.Add(Me.firstNameTextBoxControl)
			Me.Controls.Add(Me.radLabel9)
			Me.Controls.Add(Me.radLabel8)
			Me.Controls.Add(Me.radLabel7)
			Me.Controls.Add(Me.radLabel6)
			Me.Controls.Add(Me.radLabel5)
			Me.Controls.Add(Me.radLabel4)
			Me.Controls.Add(Me.radLabel3)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radLabel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AddPatientForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "New Patient"
			Me.ThemeName = "MedicalAppTheme"
			CType(Me.phoneMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addressTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stateTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cityTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.photoBrowseEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.birthDateDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.genderFemaleRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.genderMaleRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lastNameTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.middleNameTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.firstNameTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.postalCodeTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private phoneMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
		Private addressTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private stateTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private cityTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private photoBrowseEditor As Telerik.WinControls.UI.RadBrowseEditor
		Private birthDateDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private genderFemaleRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private genderMaleRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private lastNameTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private middleNameTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private firstNameTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents saveButton As Telerik.WinControls.UI.RadButton
		Private WithEvents cancelButton As Telerik.WinControls.UI.RadButton
		Private personsTableAdapter1 As PatientsDataSetTableAdapters.PersonsTableAdapter
		Private postalCodeTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private personImagesTableAdapter1 As PatientsDataSetTableAdapters.PersonImagesTableAdapter
		Private patientsTableAdapter1 As PatientsDataSetTableAdapters.PatientsTableAdapter
	End Class
End Namespace