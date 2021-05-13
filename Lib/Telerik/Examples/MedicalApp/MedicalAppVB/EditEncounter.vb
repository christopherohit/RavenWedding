Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace MedicalAppCS
	Public Partial Class EditEncounter
		Inherits UserControl
		Private encounterId As Integer
		Private errorProvider As ErrorProvider

		Public Sub New()
			InitializeComponent()
			Me.errorProvider = New ErrorProvider()
		End Sub

		Private Sub Encounter_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.encounterId = CInt(Fix(Me.Tag))

			Me.CustomizeStyles()

			' set encounter values
			Dim encounter As PatientsDataSet.EncountersRow = DataSources.PatientsDataSet.Encounters.FindById(Me.encounterId)
			If encounter Is Nothing Then
				Me.Close()
				Return
			End If

			If Not encounter("EncounterDatetime") Is DBNull.Value Then
				Me.encounterStartDateTimePicker.Value = encounter.EncounterDatetime
			End If
			If Not encounter("EncounterEndDatetime") Is DBNull.Value Then
				Me.encounterEndDateTimePicker.Value = encounter.EncounterEndDatetime
			End If
			Dim primaryDiagnosisId As Integer = -1
			If Not encounter("PrimaryDiagnosisId") Is DBNull.Value Then
				primaryDiagnosisId = encounter.PrimaryDiagnosisId
			End If
			Dim secondaryDiagnosisId As Integer = -1
			If Not encounter("SecondaryDiagnosisId") Is DBNull.Value Then
				secondaryDiagnosisId = encounter.SecondaryDiagnosisId
			End If
			Me.primaryDiagnosisDropDownList.BeginUpdate()
			Me.secondaryDiagnosisDropDownList.BeginUpdate()
			Dim primarySelectedItem As RadListDataItem = Nothing
			Dim secondarySelectedItem As RadListDataItem = Nothing
			For Each concept As PatientsDataSet.ConceptsRow In DataSources.PatientsDataSet.Concepts
				Dim primaryItem As RadListDataItem = New RadListDataItem(concept.Name, concept.Id)
				Me.primaryDiagnosisDropDownList.Items.Add(primaryItem)
				If primaryDiagnosisId = concept.Id Then
					primarySelectedItem = primaryItem
				End If

				Dim secondaryItem As RadListDataItem = New RadListDataItem(concept.Name, concept.Id)
				Me.secondaryDiagnosisDropDownList.Items.Add(secondaryItem)
				If secondaryDiagnosisId = concept.Id Then
					secondarySelectedItem = secondaryItem
				End If
			Next concept
			Me.primaryDiagnosisDropDownList.EndUpdate()
			Me.secondaryDiagnosisDropDownList.EndUpdate()

			Me.primaryDiagnosisDropDownList.SelectedItem = primarySelectedItem
			Me.secondaryDiagnosisDropDownList.SelectedItem = secondarySelectedItem

			If Not encounter("Notes") Is DBNull.Value Then
				Me.encounterNotesTextBoxControl.Text = encounter.Notes
			End If
			If Not encounter("Temperature") Is DBNull.Value Then
				Me.encounterTemperatureSpinEditor.NullableValue = CDec(encounter.Temperature)
			End If
			If Not encounter("Pulse") Is DBNull.Value Then
				Me.encounterPulseSpinEditor.NullableValue = encounter.Pulse
			End If
			If Not encounter("RespiratoryRate") Is DBNull.Value Then
				Me.encounterRespiratoryRateSpinEditor.NullableValue = encounter.RespiratoryRate
			End If
			If Not encounter("BloodPressure") Is DBNull.Value Then
				Me.encounterBloodPressureMaskedEditBox.Text = encounter.BloodPressure
			End If
			If Not encounter("BloodOxygenSaturation") Is DBNull.Value Then
				Me.encounterBloodOxygenSaturationSpinEditor.NullableValue = encounter.BloodOxygenSaturation
			End If
			If Not encounter("Weight") Is DBNull.Value Then
				Me.encounterWeightSpinEditor.NullableValue = CDec(encounter.Weight)
			End If
			If Not encounter("Height") Is DBNull.Value Then
				Me.encounterHeightSpinEditor.NullableValue = CDec(encounter.Height)
			End If
		End Sub

		Private Sub encounterSaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles encounterSaveButton.Click
			If (Not Me.AreRequiredFieldsValid()) Then
				Return
			End If

			Dim encounter As PatientsDataSet.EncountersRow = DataSources.PatientsDataSet.Encounters.FindById(Me.encounterId)
			encounter.EncounterDatetime = Me.encounterStartDateTimePicker.Value
			encounter.EncounterEndDatetime = Me.encounterEndDateTimePicker.Value
			encounter.PrimaryDiagnosisId = CInt(Fix(Me.primaryDiagnosisDropDownList.SelectedItem.Value))
			If Not Me.secondaryDiagnosisDropDownList.SelectedItem Is Nothing Then
				encounter.SecondaryDiagnosisId = CInt(Fix(Me.secondaryDiagnosisDropDownList.SelectedItem.Value))
			End If
			If (Not String.IsNullOrEmpty(Me.encounterNotesTextBoxControl.Text)) Then
				encounter.Notes = Me.encounterNotesTextBoxControl.Text
			End If
			If Not Me.encounterTemperatureSpinEditor.NullableValue Is Nothing Then
				encounter.Temperature = CDbl(Me.encounterTemperatureSpinEditor.NullableValue)
			End If
			If Not Me.encounterPulseSpinEditor.NullableValue Is Nothing Then
				encounter.Pulse = CInt(Fix(Me.encounterPulseSpinEditor.NullableValue))
			End If
			If Not Me.encounterRespiratoryRateSpinEditor.NullableValue Is Nothing Then
				encounter.RespiratoryRate = CInt(Fix(Me.encounterRespiratoryRateSpinEditor.NullableValue))
			End If
			If (Not String.IsNullOrEmpty(Me.encounterBloodPressureMaskedEditBox.Text)) AndAlso Me.encounterBloodPressureMaskedEditBox.Text.Trim() <> "/" Then
				encounter.BloodPressure = Me.encounterBloodPressureMaskedEditBox.Text
			End If
			If Not Me.encounterBloodOxygenSaturationSpinEditor.NullableValue Is Nothing Then
				encounter.BloodOxygenSaturation = CInt(Fix(Me.encounterBloodOxygenSaturationSpinEditor.NullableValue))
			End If
			If Not Me.encounterWeightSpinEditor.NullableValue Is Nothing Then
				encounter.Weight = CDbl(Me.encounterWeightSpinEditor.NullableValue)
			End If
			If Not Me.encounterHeightSpinEditor.NullableValue Is Nothing Then
				encounter.Height = CDbl(Me.encounterHeightSpinEditor.NullableValue)
			End If

			Me.encountersTableAdapter1.Update(DataSources.PatientsDataSet.Encounters)
			Me.encountersTableAdapter1.Fill(DataSources.PatientsDataSet.Encounters)
			Me.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients)
			Me.Close()
		End Sub

		Private Sub encounterCancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles encounterCancelButton.Click
			Me.Close()
		End Sub

		Private Sub Close()
            TryCast(Me.Parent, Telerik.WinControls.UI.Docking.DocumentWindow).Close()
		End Sub

		Private Sub CustomizeStyles()
			Me.encounterStartDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.encounterEndDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.encounterStartDateTimePicker.ThemeName = "MedicalAppTheme"
			Me.encounterEndDateTimePicker.ThemeName = "MedicalAppTheme"

			Dim border As BorderPrimitive = Me.encounterCancelButton.ButtonElement.BorderElement
			border.ForeColor = Color.FromArgb(171, 173, 179)
			border.Width = 1
			border.BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder

			Me.encounterCancelButton.ButtonElement.ButtonFillElement.NumberOfColors = 1
			Me.encounterCancelButton.ButtonElement.ButtonFillElement.BackColor = Color.Transparent

			Me.encounterCancelButton.ForeColor = Color.FromArgb(55, 55, 55)
			Me.encounterCancelButton.Font = New Font("Segoe UI", 11)
		End Sub

		Private Function AreRequiredFieldsValid() As Boolean
			If Me.encounterStartDateTimePicker.DateTimePickerElement.Value Is Nothing Then
				Me.errorProvider.SetError(Me.encounterStartDateTimePicker, "Start date is required")
				Return False
			End If
			If Me.encounterEndDateTimePicker.DateTimePickerElement.Value Is Nothing Then
				Me.errorProvider.SetError(Me.encounterEndDateTimePicker, "End date is required")
				Return False
			End If
			If Me.primaryDiagnosisDropDownList.SelectedItem Is Nothing Then
				Me.errorProvider.SetError(Me.primaryDiagnosisDropDownList, "Primary diagnosis is required")
				Return False
			End If

			Return True
		End Function
	End Class
End Namespace
