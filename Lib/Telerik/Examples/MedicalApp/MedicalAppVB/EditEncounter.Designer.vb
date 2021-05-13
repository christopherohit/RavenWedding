Imports Microsoft.VisualBasic
Imports System
Namespace MedicalAppCS
	Public Partial Class EditEncounter
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
			Me.encounterSaveButton = New Telerik.WinControls.UI.RadButton()
			Me.encounterCancelButton = New Telerik.WinControls.UI.RadButton()
			Me.encounterStartDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.encounterEndDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.encounterNotesTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.encounterBloodPressureMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.primaryDiagnosisDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.secondaryDiagnosisDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.encountersTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.EncountersTableAdapter()
			Me.conceptsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.ConceptsTableAdapter()
			Me.encounterHeightSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterWeightSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterBloodOxygenSaturationSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterRespiratoryRateSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterPulseSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterTemperatureSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.patientsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterSaveButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterStartDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterEndDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterNotesTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterBloodPressureMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.primaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.secondaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterHeightSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterWeightSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterBloodOxygenSaturationSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterRespiratoryRateSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterPulseSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterTemperatureSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel1.Location = New System.Drawing.Point(17, 15)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(36, 22)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Start"
			Me.radLabel1.ThemeName = "MedicalAppTheme"
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel2.Location = New System.Drawing.Point(16, 64)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(30, 22)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "End"
			Me.radLabel2.ThemeName = "MedicalAppTheme"
			' 
			' radLabel3
			' 
			Me.radLabel3.BackColor = System.Drawing.Color.Transparent
			Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel3.Location = New System.Drawing.Point(16, 119)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(117, 22)
			Me.radLabel3.TabIndex = 1
			Me.radLabel3.Text = "Primary diagnosis"
			Me.radLabel3.ThemeName = "MedicalAppTheme"
			' 
			' radLabel4
			' 
			Me.radLabel4.BackColor = System.Drawing.Color.Transparent
			Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel4.Location = New System.Drawing.Point(17, 173)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(134, 22)
			Me.radLabel4.TabIndex = 1
			Me.radLabel4.Text = "Secondary diagnosis"
			Me.radLabel4.ThemeName = "MedicalAppTheme"
			' 
			' radLabel5
			' 
			Me.radLabel5.BackColor = System.Drawing.Color.Transparent
			Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel5.Location = New System.Drawing.Point(16, 222)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(44, 22)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "Notes"
			Me.radLabel5.ThemeName = "MedicalAppTheme"
			' 
			' radLabel6
			' 
			Me.radLabel6.BackColor = System.Drawing.Color.Transparent
			Me.radLabel6.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel6.Location = New System.Drawing.Point(566, 15)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(87, 22)
			Me.radLabel6.TabIndex = 1
			Me.radLabel6.Text = "Temperature"
			Me.radLabel6.ThemeName = "MedicalAppTheme"
			' 
			' radLabel7
			' 
			Me.radLabel7.BackColor = System.Drawing.Color.Transparent
			Me.radLabel7.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel7.Location = New System.Drawing.Point(565, 72)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(40, 22)
			Me.radLabel7.TabIndex = 1
			Me.radLabel7.Text = "Pulse"
			Me.radLabel7.ThemeName = "MedicalAppTheme"
			' 
			' radLabel8
			' 
			Me.radLabel8.BackColor = System.Drawing.Color.Transparent
			Me.radLabel8.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel8.Location = New System.Drawing.Point(565, 130)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New System.Drawing.Size(105, 22)
			Me.radLabel8.TabIndex = 1
			Me.radLabel8.Text = "Respiratory rate"
			Me.radLabel8.ThemeName = "MedicalAppTheme"
			' 
			' radLabel9
			' 
			Me.radLabel9.BackColor = System.Drawing.Color.Transparent
			Me.radLabel9.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel9.Location = New System.Drawing.Point(565, 189)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New System.Drawing.Size(100, 22)
			Me.radLabel9.TabIndex = 2
			Me.radLabel9.Text = "Blood pressure"
			Me.radLabel9.ThemeName = "MedicalAppTheme"
			' 
			' radLabel10
			' 
			Me.radLabel10.BackColor = System.Drawing.Color.Transparent
			Me.radLabel10.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel10.Location = New System.Drawing.Point(565, 365)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New System.Drawing.Size(49, 22)
			Me.radLabel10.TabIndex = 5
			Me.radLabel10.Text = "Height"
			Me.radLabel10.ThemeName = "MedicalAppTheme"
			' 
			' radLabel11
			' 
			Me.radLabel11.BackColor = System.Drawing.Color.Transparent
			Me.radLabel11.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel11.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel11.Location = New System.Drawing.Point(566, 307)
			Me.radLabel11.Name = "radLabel11"
			Me.radLabel11.Size = New System.Drawing.Size(52, 22)
			Me.radLabel11.TabIndex = 3
			Me.radLabel11.Text = "Weight"
			Me.radLabel11.ThemeName = "MedicalAppTheme"
			' 
			' radLabel12
			' 
			Me.radLabel12.BackColor = System.Drawing.Color.Transparent
			Me.radLabel12.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel12.Location = New System.Drawing.Point(565, 248)
			Me.radLabel12.Name = "radLabel12"
			Me.radLabel12.Size = New System.Drawing.Size(158, 22)
			Me.radLabel12.TabIndex = 4
			Me.radLabel12.Text = "Blood oxygen saturation"
			Me.radLabel12.ThemeName = "MedicalAppTheme"
			' 
			' encounterSaveButton
			' 
			Me.encounterSaveButton.Location = New System.Drawing.Point(911, 22)
			Me.encounterSaveButton.Name = "encounterSaveButton"
			Me.encounterSaveButton.Size = New System.Drawing.Size(228, 36)
			Me.encounterSaveButton.TabIndex = 6
			Me.encounterSaveButton.Text = "Save"
			Me.encounterSaveButton.ThemeName = "MedicalAppTheme"
'			Me.encounterSaveButton.Click += New System.EventHandler(Me.encounterSaveButton_Click);
			' 
			' encounterCancelButton
			' 
			Me.encounterCancelButton.Location = New System.Drawing.Point(911, 68)
			Me.encounterCancelButton.Name = "encounterCancelButton"
			Me.encounterCancelButton.Size = New System.Drawing.Size(228, 36)
			Me.encounterCancelButton.TabIndex = 7
			Me.encounterCancelButton.Text = "Cancel"
'			Me.encounterCancelButton.Click += New System.EventHandler(Me.encounterCancelButton_Click);
			' 
			' encounterStartDateTimePicker
			' 
			Me.encounterStartDateTimePicker.CustomFormat = "d-M-yyyy HH:mm"
			Me.encounterStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.encounterStartDateTimePicker.Location = New System.Drawing.Point(19, 38)
			Me.encounterStartDateTimePicker.Name = "encounterStartDateTimePicker"
			Me.encounterStartDateTimePicker.Size = New System.Drawing.Size(435, 20)
			Me.encounterStartDateTimePicker.TabIndex = 8
			Me.encounterStartDateTimePicker.TabStop = False
			Me.encounterStartDateTimePicker.Text = "17-6-2006 00:00"
			Me.encounterStartDateTimePicker.Value = New System.DateTime(2006, 6, 17, 0, 0, 0, 0)
			' 
			' encounterEndDateTimePicker
			' 
			Me.encounterEndDateTimePicker.CustomFormat = "d-M-yyyy HH:mm"
			Me.encounterEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.encounterEndDateTimePicker.Location = New System.Drawing.Point(19, 87)
			Me.encounterEndDateTimePicker.Name = "encounterEndDateTimePicker"
			Me.encounterEndDateTimePicker.Size = New System.Drawing.Size(435, 20)
			Me.encounterEndDateTimePicker.TabIndex = 9
			Me.encounterEndDateTimePicker.TabStop = False
			Me.encounterEndDateTimePicker.Text = "17-6-2006 00:00"
			Me.encounterEndDateTimePicker.Value = New System.DateTime(2006, 6, 17, 0, 0, 0, 0)
			' 
			' encounterNotesTextBoxControl
			' 
			Me.encounterNotesTextBoxControl.Location = New System.Drawing.Point(19, 245)
			Me.encounterNotesTextBoxControl.Multiline = True
			Me.encounterNotesTextBoxControl.Name = "encounterNotesTextBoxControl"
			Me.encounterNotesTextBoxControl.Size = New System.Drawing.Size(435, 161)
			Me.encounterNotesTextBoxControl.TabIndex = 12
			Me.encounterNotesTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' encounterBloodPressureMaskedEditBox
			' 
			Me.encounterBloodPressureMaskedEditBox.Location = New System.Drawing.Point(568, 212)
			Me.encounterBloodPressureMaskedEditBox.Mask = "990\/990"
			Me.encounterBloodPressureMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
			Me.encounterBloodPressureMaskedEditBox.Name = "encounterBloodPressureMaskedEditBox"
			Me.encounterBloodPressureMaskedEditBox.PromptChar = " "c
			Me.encounterBloodPressureMaskedEditBox.Size = New System.Drawing.Size(228, 20)
			Me.encounterBloodPressureMaskedEditBox.TabIndex = 17
			Me.encounterBloodPressureMaskedEditBox.TabStop = False
			Me.encounterBloodPressureMaskedEditBox.Text = "   /   "
			Me.encounterBloodPressureMaskedEditBox.ThemeName = "MedicalAppTheme"
			' 
			' primaryDiagnosisDropDownList
			' 
			Me.primaryDiagnosisDropDownList.Location = New System.Drawing.Point(19, 142)
			Me.primaryDiagnosisDropDownList.Name = "primaryDiagnosisDropDownList"
			Me.primaryDiagnosisDropDownList.Size = New System.Drawing.Size(435, 20)
			Me.primaryDiagnosisDropDownList.TabIndex = 18
			Me.primaryDiagnosisDropDownList.ThemeName = "MedicalAppTheme"
			' 
			' secondaryDiagnosisDropDownList
			' 
			Me.secondaryDiagnosisDropDownList.Location = New System.Drawing.Point(19, 196)
			Me.secondaryDiagnosisDropDownList.Name = "secondaryDiagnosisDropDownList"
			Me.secondaryDiagnosisDropDownList.Size = New System.Drawing.Size(435, 20)
			Me.secondaryDiagnosisDropDownList.TabIndex = 19
			Me.secondaryDiagnosisDropDownList.ThemeName = "MedicalAppTheme"
			' 
			' encountersTableAdapter1
			' 
			Me.encountersTableAdapter1.ClearBeforeFill = True
			' 
			' conceptsTableAdapter1
			' 
			Me.conceptsTableAdapter1.ClearBeforeFill = True
			' 
			' encounterHeightSpinEditor
			' 
			Me.encounterHeightSpinEditor.DecimalPlaces = 1
			Me.encounterHeightSpinEditor.Location = New System.Drawing.Point(568, 388)
			Me.encounterHeightSpinEditor.Maximum = New Decimal(New Integer() { 280, 0, 0, 0})
			Me.encounterHeightSpinEditor.Minimum = New Decimal(New Integer() { 35, 0, 0, 0})
			Me.encounterHeightSpinEditor.Name = "encounterHeightSpinEditor"
			Me.encounterHeightSpinEditor.NullableValue = Nothing
			Me.encounterHeightSpinEditor.ShowUpDownButtons = False
			Me.encounterHeightSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterHeightSpinEditor.TabIndex = 16
			Me.encounterHeightSpinEditor.TabStop = False
			Me.encounterHeightSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterHeightSpinEditor.Value = New Decimal(New Integer() { 35, 0, 0, 0})
			' 
			' encounterWeightSpinEditor
			' 
			Me.encounterWeightSpinEditor.DecimalPlaces = 1
			Me.encounterWeightSpinEditor.Location = New System.Drawing.Point(568, 330)
			Me.encounterWeightSpinEditor.Maximum = New Decimal(New Integer() { 250, 0, 0, 0})
			Me.encounterWeightSpinEditor.Minimum = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.encounterWeightSpinEditor.Name = "encounterWeightSpinEditor"
			Me.encounterWeightSpinEditor.NullableValue = Nothing
			Me.encounterWeightSpinEditor.ShowUpDownButtons = False
			Me.encounterWeightSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterWeightSpinEditor.TabIndex = 16
			Me.encounterWeightSpinEditor.TabStop = False
			Me.encounterWeightSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterWeightSpinEditor.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			' 
			' encounterBloodOxygenSaturationSpinEditor
			' 
			Me.encounterBloodOxygenSaturationSpinEditor.Location = New System.Drawing.Point(568, 271)
			Me.encounterBloodOxygenSaturationSpinEditor.Minimum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.encounterBloodOxygenSaturationSpinEditor.Name = "encounterBloodOxygenSaturationSpinEditor"
			Me.encounterBloodOxygenSaturationSpinEditor.NullableValue = Nothing
			Me.encounterBloodOxygenSaturationSpinEditor.ShowUpDownButtons = False
			Me.encounterBloodOxygenSaturationSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterBloodOxygenSaturationSpinEditor.TabIndex = 16
			Me.encounterBloodOxygenSaturationSpinEditor.TabStop = False
			Me.encounterBloodOxygenSaturationSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterBloodOxygenSaturationSpinEditor.Value = New Decimal(New Integer() { 20, 0, 0, 0})
			' 
			' encounterRespiratoryRateSpinEditor
			' 
			Me.encounterRespiratoryRateSpinEditor.Location = New System.Drawing.Point(568, 153)
			Me.encounterRespiratoryRateSpinEditor.Maximum = New Decimal(New Integer() { 60, 0, 0, 0})
			Me.encounterRespiratoryRateSpinEditor.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.encounterRespiratoryRateSpinEditor.Name = "encounterRespiratoryRateSpinEditor"
			Me.encounterRespiratoryRateSpinEditor.NullableValue = Nothing
			Me.encounterRespiratoryRateSpinEditor.ShowUpDownButtons = False
			Me.encounterRespiratoryRateSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterRespiratoryRateSpinEditor.TabIndex = 16
			Me.encounterRespiratoryRateSpinEditor.TabStop = False
			Me.encounterRespiratoryRateSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterRespiratoryRateSpinEditor.Value = New Decimal(New Integer() { 10, 0, 0, 0})
			' 
			' encounterPulseSpinEditor
			' 
			Me.encounterPulseSpinEditor.Location = New System.Drawing.Point(568, 95)
			Me.encounterPulseSpinEditor.Maximum = New Decimal(New Integer() { 230, 0, 0, 0})
			Me.encounterPulseSpinEditor.Minimum = New Decimal(New Integer() { 35, 0, 0, 0})
			Me.encounterPulseSpinEditor.Name = "encounterPulseSpinEditor"
			Me.encounterPulseSpinEditor.NullableValue = Nothing
			Me.encounterPulseSpinEditor.ShowUpDownButtons = False
			Me.encounterPulseSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterPulseSpinEditor.TabIndex = 16
			Me.encounterPulseSpinEditor.TabStop = False
			Me.encounterPulseSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterPulseSpinEditor.Value = New Decimal(New Integer() { 35, 0, 0, 0})
			' 
			' encounterTemperatureSpinEditor
			' 
			Me.encounterTemperatureSpinEditor.DecimalPlaces = 1
			Me.encounterTemperatureSpinEditor.Location = New System.Drawing.Point(568, 38)
			Me.encounterTemperatureSpinEditor.Maximum = New Decimal(New Integer() { 45, 0, 0, 0})
			Me.encounterTemperatureSpinEditor.Minimum = New Decimal(New Integer() { 25, 0, 0, 0})
			Me.encounterTemperatureSpinEditor.Name = "encounterTemperatureSpinEditor"
			Me.encounterTemperatureSpinEditor.NullableValue = Nothing
			Me.encounterTemperatureSpinEditor.ShowUpDownButtons = False
			Me.encounterTemperatureSpinEditor.Size = New System.Drawing.Size(228, 18)
			Me.encounterTemperatureSpinEditor.TabIndex = 15
			Me.encounterTemperatureSpinEditor.TabStop = False
			Me.encounterTemperatureSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterTemperatureSpinEditor.Value = New Decimal(New Integer() { 25, 0, 0, 0})
			' 
			' patientsTableAdapter1
			' 
			Me.patientsTableAdapter1.ClearBeforeFill = True
			' 
			' EditEncounter
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.Controls.Add(Me.secondaryDiagnosisDropDownList)
			Me.Controls.Add(Me.primaryDiagnosisDropDownList)
			Me.Controls.Add(Me.encounterBloodPressureMaskedEditBox)
			Me.Controls.Add(Me.encounterHeightSpinEditor)
			Me.Controls.Add(Me.encounterWeightSpinEditor)
			Me.Controls.Add(Me.encounterBloodOxygenSaturationSpinEditor)
			Me.Controls.Add(Me.encounterRespiratoryRateSpinEditor)
			Me.Controls.Add(Me.encounterPulseSpinEditor)
			Me.Controls.Add(Me.encounterTemperatureSpinEditor)
			Me.Controls.Add(Me.encounterNotesTextBoxControl)
			Me.Controls.Add(Me.encounterEndDateTimePicker)
			Me.Controls.Add(Me.encounterStartDateTimePicker)
			Me.Controls.Add(Me.encounterCancelButton)
			Me.Controls.Add(Me.encounterSaveButton)
			Me.Controls.Add(Me.radLabel10)
			Me.Controls.Add(Me.radLabel9)
			Me.Controls.Add(Me.radLabel11)
			Me.Controls.Add(Me.radLabel8)
			Me.Controls.Add(Me.radLabel12)
			Me.Controls.Add(Me.radLabel7)
			Me.Controls.Add(Me.radLabel6)
			Me.Controls.Add(Me.radLabel5)
			Me.Controls.Add(Me.radLabel4)
			Me.Controls.Add(Me.radLabel3)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radLabel1)
			Me.Name = "EditEncounter"
			Me.Size = New System.Drawing.Size(1365, 439)
'			Me.Load += New System.EventHandler(Me.Encounter_Load);
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterSaveButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterStartDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterEndDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterNotesTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterBloodPressureMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.primaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.secondaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterHeightSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterWeightSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterBloodOxygenSaturationSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterRespiratoryRateSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterPulseSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterTemperatureSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private radLabel12 As Telerik.WinControls.UI.RadLabel
		Private WithEvents encounterSaveButton As Telerik.WinControls.UI.RadButton
		Private WithEvents encounterCancelButton As Telerik.WinControls.UI.RadButton
		Private encounterStartDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private encounterEndDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private encounterNotesTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private encounterBloodPressureMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
		Private encounterTemperatureSpinEditor As NullableSpinEditor
		Private encounterPulseSpinEditor As NullableSpinEditor
		Private encounterRespiratoryRateSpinEditor As NullableSpinEditor
		Private encounterBloodOxygenSaturationSpinEditor As NullableSpinEditor
		Private encounterWeightSpinEditor As NullableSpinEditor
		Private encounterHeightSpinEditor As NullableSpinEditor
		Private primaryDiagnosisDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private secondaryDiagnosisDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private encountersTableAdapter1 As PatientsDataSetTableAdapters.EncountersTableAdapter
		Private conceptsTableAdapter1 As PatientsDataSetTableAdapters.ConceptsTableAdapter
		Private patientsTableAdapter1 As PatientsDataSetTableAdapters.PatientsTableAdapter
	End Class
End Namespace
