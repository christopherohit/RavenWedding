Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Imports MedicalAppCS.Properties

Imports Telerik.Charting
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Namespace MedicalAppCS
	Public Partial Class PatientEncounters
		Inherits UserControl
		Private personId As Integer = -1
		Private errorProvider As ErrorProvider

		Public ReadOnly Property CurrentDate() As DateTime
			Get
				Return New DateTime(2015, 6, 17, DateTime.Now.Hour, DateTime.Now.Minute, 0)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Me.errorProvider = New ErrorProvider()
			Dim previewItem As RadPageViewItem = Me.documentWindowNewEncounter.TabStripItem
			Dim pageViewStripElement As RadPageViewStripElement = TryCast(Me.radDockPatientEncounters.SplitPanelElement.Children(2).Children(0), RadPageViewStripElement)
			pageViewStripElement.PreviewItem = previewItem
			previewItem.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed

			Me.encounterStartDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.encounterEndDateTimePicker.DateTimePickerElement.ShowTimePicker = True
			Me.encounterStartDateTimePicker.ThemeName = "MedicalAppTheme"
			Me.encounterEndDateTimePicker.ThemeName = "MedicalAppTheme"

			Dim border As BorderPrimitive = Me.encounterCancelButton.ButtonElement.BorderElement
			border.ForeColor = Color.FromArgb(171, 173, 179)
			border.Width = 1
			border.BoxStyle = BorderBoxStyle.SingleBorder
			Me.encounterCancelButton.ButtonElement.ButtonFillElement.NumberOfColors = 1
			Me.encounterCancelButton.ButtonElement.ButtonFillElement.BackColor = Color.Transparent
			Me.encounterCancelButton.ForeColor = Color.FromArgb(55, 55, 55)
			Me.encounterCancelButton.Font = New Font("Segoe UI", 12)

			AddHandler Me.radDockPatientEncounters.GetService(Of DragDropService)().Starting, AddressOf PatientEncounters_Starting
			For Each dw As DockWindow In Me.radDockPatientEncounters.DockWindows
				dw.AllowedDockState = Not AllowedDockState.Floating
			Next dw

			CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.encountersBindingSource.DataMember = "Encounters"
			Me.encountersBindingSource.DataSource = DataSources.PatientsDataSet
			CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			AddHandler Me.encountersBindingSource.ListChanged, AddressOf encountersBindingSource_ListChanged
		End Sub

		Private Sub encountersBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
			Dim encounters As PatientsDataSet.EncountersDataTable = DataSources.PatientsDataSet.Encounters
			Dim personEncounters As DataRow() = encounters.Select("PersonId = " & Me.personId)
			Me.UpdateConditions(personEncounters)
			Me.UpdateChartData(personEncounters)
			Me.UpdateBMIfields(personEncounters)
			Me.FillEncountersListView(personEncounters)
		End Sub

		Private Sub PatientEncounters_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
			e.Cancel = True
		End Sub

		Private Sub PatientEncounters_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.personId = CInt(Fix(Me.Tag))
			Me.FillPersonInfo()
			Dim encounters As PatientsDataSet.EncountersDataTable = DataSources.PatientsDataSet.Encounters
			Dim personEncounters As DataRow() = encounters.Select("PersonId = " & Me.personId)

			' Summary tab
			Me.documentWindowSummary.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed
			Me.summaryChartView.ChartElement.TitleElement.PositionOffset = New SizeF(110, 2)
			Me.summaryChartView.ChartElement.TitleElement.Font = New Font("Segoe UI", 10.5f)
			Me.UpdateConditions(personEncounters)
			Me.UpdateChartData(personEncounters)
			Me.UpdateBMIfields(personEncounters)

			' History tab 
			Me.documentWindowHistory.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed
			Me.FillEncountersListView(personEncounters)

			' New encounter tab
			Me.documentWindowNewEncounter.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed
			Me.FillDiagnosisDropDownLists()

			Me.ClearEncounterValues()
		End Sub

		Private Sub EditPatientInfoButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditPatientInfoButton.Click
			Dim editPatientForm As EditPatientForm = New EditPatientForm()
			editPatientForm.Tag = Me.personId
			editPatientForm.StartPosition = FormStartPosition.CenterParent
			editPatientForm.ShowDialog(Me)

			Me.FillPersonInfo()
		End Sub

		Private Sub radDockPatientEncounters_DockWindowClosing(ByVal sender As Object, ByVal e As DockWindowCancelEventArgs) Handles radDockPatientEncounters.DockWindowClosing
			If e.NewWindow Is Me.documentWindowSummary OrElse e.NewWindow Is Me.documentWindowHistory OrElse e.NewWindow Is Me.documentWindowNewEncounter Then
				e.Cancel = True
			End If
		End Sub

		Public Sub UpdateControlsData()
			Dim encounters As PatientsDataSet.EncountersDataTable = DataSources.PatientsDataSet.Encounters
			Dim personEncounters As DataRow() = encounters.Select("PersonId = " & Me.personId)
			Me.UpdateConditions(personEncounters)
			Me.UpdateChartData(personEncounters)
			Me.UpdateBMIfields(personEncounters)
			Me.FillEncountersListView(personEncounters)
		End Sub

		Private Sub FillPersonInfo()
			Dim person As PatientsDataSet.PersonsRow = DataSources.PatientsDataSet.Persons.FindById(Me.personId)
			Me.patientNameLabel.Text = person.FirstName & " " & person.FamilyName
			Dim today As DateTime = CurrentDate
			Dim age As Integer = today.Year - person.BirthDate.Year
			If person.BirthDate > today.AddYears(-age) Then
				age -= 1
			End If
			If person.Gender = "M" Then
				Me.patientInformationLabel.Text = String.Format("{0} yo | {1} | {2}", age.ToString(),"male", person.BirthDate.ToString("d-M-yyyy"))
			Else
				Me.patientInformationLabel.Text = String.Format("{0} yo | {1} | {2}", age.ToString(),"female", person.BirthDate.ToString("d-M-yyyy"))
			End If
			Me.addressCityLabel.Text = person.City & ", " & person.State
			Me.addressStreetLabel.Text = person.Address & " " & person.PostalCode
			Me.phoneLabel.Text = person.Phone

			Dim personImageId As Integer = -1
			If Not person("PersonImageId") Is DBNull.Value Then
				personImageId = person.PersonImageId
			End If
			Dim personImage As PatientsDataSet.PersonImagesRow = DataSources.PatientsDataSet.PersonImages.FindById(personImageId)
			Dim image As Image
			If Not personImage Is Nothing AndAlso Not personImage("Picture") Is DBNull.Value Then
				Using ms As System.IO.MemoryStream = New System.IO.MemoryStream(personImage.Picture)
					image = Image.FromStream(ms)
				End Using
			Else
                image = Resources.no_image
			End If

			Dim bitmap As Bitmap = New Bitmap(image, New Size(114, 114))
			Me.patientImageLabel.Image = bitmap
		End Sub

		#Region "Summary"

		Private Sub summaryChartView_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs) Handles summaryChartView.LabelFormatting
			e.LabelElement.BackColor = Color.White
			e.LabelElement.BorderColor = e.LabelElement.DataPointElement.BackColor
			e.LabelElement.Shape = Nothing
		End Sub

		Private Sub summaryChartView_SelectedPointChanged(ByVal sender As Object, ByVal e As ChartViewSelectedPointChangedEventArgs) Handles summaryChartView.SelectedPointChanged
			If Not e.OldSelectedPoint Is Nothing Then
                TryCast(e.OldSelectedPoint.Presenter, LineSeries).ShowLabels = False
			End If

			If Not e.NewSelectedPoint Is Nothing Then
                TryCast(e.NewSelectedPoint.Presenter, LineSeries).ShowLabels = True
			End If
		End Sub

		Private Sub UpdateConditions(ByVal personEncounters As DataRow())
			Me.summaryConditionsListControl.Items.Clear()
			For Each row As DataRow In personEncounters
				Dim primaryId As Integer
				If Integer.TryParse(row("PrimaryDiagnosisId").ToString(), primaryId) Then
					Dim concept As PatientsDataSet.ConceptsRow = DataSources.PatientsDataSet.Concepts.FindById(primaryId)
					Dim item As RadListDataItem = New RadListDataItem(concept.Name)
					item.TextWrap = True
					Me.summaryConditionsListControl.Items.Add(item)
				End If

				Dim secondaryId As Integer
				If Integer.TryParse(row("SecondaryDiagnosisId").ToString(), secondaryId) Then
					Dim concept As PatientsDataSet.ConceptsRow = DataSources.PatientsDataSet.Concepts.FindById(secondaryId)
					Dim item As RadListDataItem = New RadListDataItem(concept.Name)
					item.TextWrap = True
					Me.summaryConditionsListControl.Items.Add(item)
				End If
			Next row
		End Sub

		Private Sub UpdateBMIfields(ByVal personEncounters As DataRow())
			Dim latestEncounter As PatientsDataSet.EncountersRow = Nothing
			For Each encounter As PatientsDataSet.EncountersRow In personEncounters
				If Not encounter("Weight") Is DBNull.Value AndAlso Not encounter("Height") Is DBNull.Value Then
					If Not latestEncounter Is Nothing Then
						Dim currentEncounterDateTime As DateTime = CDate(encounter("EncounterDatetime"))
						If currentEncounterDateTime > latestEncounter.EncounterDatetime Then
							latestEncounter = encounter
						End If
					Else
						latestEncounter = encounter
					End If
				End If
			Next encounter

			If Not latestEncounter Is Nothing Then
				Me.summaryHeightLabel.Text = latestEncounter.Height & " cm"
				Me.summaryWeightLabel.Text = latestEncounter.Weight & " kg"
				Dim heightInMeters As Double = latestEncounter.Height / 100
				Dim bmi As Double = latestEncounter.Weight / (heightInMeters * heightInMeters)
				Me.summaryBMILabel.Text = Math.Round(bmi).ToString()
				Dim category As String
				Dim bmiCategoryColor As Color
				If bmi < 18.5 Then
					category = "UNDERWEIGHT"
					bmiCategoryColor = Color.FromArgb(62, 201, 228)
				ElseIf bmi < 25 Then
					category = "NORMAL"
					bmiCategoryColor = Color.FromArgb(174, 215, 151)
				ElseIf bmi < 30 Then
					category = "OVERWEIGHT"
					bmiCategoryColor = Color.FromArgb(255, 192, 82)
				Else
					category = "OBESE"
					bmiCategoryColor = Color.FromArgb(233, 88, 52)
				End If

				Me.summaryBMICategoryLabel.Text = category
				Me.summaryBMICategoryLabel.ForeColor = bmiCategoryColor
				Me.summaryBMIRadialGauge.Value = CSng(bmi)
			Else
				Me.summaryHeightLabel.Text = String.Empty
				Me.summaryWeightLabel.Text = String.Empty
				Me.summaryBMICategoryLabel.Text = String.Empty
				Me.summaryBMILabel.Text = String.Empty
				Me.summaryBMIRadialGauge.Value = 0
			End If
		End Sub

		Private Sub UpdateChartData(ByVal personEncounters As DataRow())
			Me.summaryChartView.Axes.Clear()
			Me.summaryChartView.Series.Clear()

			Dim horizontalAxis As DateTimeCategoricalAxis = New DateTimeCategoricalAxis()
			horizontalAxis.PlotMode = AxisPlotMode.BetweenTicks
			horizontalAxis.LabelFormat = "{0:dd-MM-yyyy}"

			Dim verticalAxis As LinearAxis = New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.Minimum = 0
			verticalAxis.Maximum = 100
			verticalAxis.DesiredTickCount = 6
			verticalAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden
			verticalAxis.LabelFormatProvider = New CustomFormatProvider()

			Dim lineSaO2 As LineSeries = Me.CreateLineSeries(New StarShape(), Color.FromArgb(137, 142, 246), New SizeF(15, 15))
			lineSaO2.HorizontalAxis = horizontalAxis
			lineSaO2.VerticalAxis = verticalAxis

			Dim triangle As CustomShape = New CustomShape()
			triangle.CreateClosedShape(Me.CreateInitialShape(3, 6))
			Dim lineBlPr As LineSeries = Me.CreateLineSeries(triangle, Color.FromArgb(93, 82, 85), New SizeF(10, 10))
			lineBlPr.HorizontalAxis = horizontalAxis
			lineBlPr.VerticalAxis = verticalAxis

			Dim lineRespRate As LineSeries = Me.CreateLineSeries(New RoundRectShape(0), Color.FromArgb(255, 192, 82), New SizeF(8, 8))
			lineRespRate.HorizontalAxis = horizontalAxis
			lineRespRate.VerticalAxis = verticalAxis

			Dim linePulse As LineSeries = Me.CreateLineSeries(New DiamondShape(), Color.FromArgb(222, 88, 88), New SizeF(12, 12))
			linePulse.HorizontalAxis = horizontalAxis
			linePulse.VerticalAxis = verticalAxis

			Dim lineTemp As LineSeries = Me.CreateLineSeries(Nothing, Color.FromArgb(106, 214, 231), New SizeF(8, 8))
			lineTemp.HorizontalAxis = horizontalAxis
			lineTemp.VerticalAxis = verticalAxis

			For Each row As PatientsDataSet.EncountersRow In personEncounters
				If Not row("BloodOxygenSaturation") Is DBNull.Value Then
					Dim saO2Value As Integer = Me.ScaleChartValue(row.BloodOxygenSaturation, 85, 100, 80, 100)
					Dim saO2Point As CategoricalDataPoint = New CategoricalDataPoint(saO2Value, row.EncounterDatetime)
					saO2Point.Label = row.BloodOxygenSaturation
					lineSaO2.DataPoints.Add(saO2Point)
				End If
				If Not row("BloodPressure") Is DBNull.Value Then
					Dim values As String() = row.BloodPressure.Split(New Char() { "/"c })
					Dim systolic As Integer = Me.ScaleChartValue(Integer.Parse(values(0)), 70, 190, 60, 80)
					Dim diastolic As Integer = Me.ScaleChartValue(Integer.Parse(values(1)), 40, 100, 60, 80)
					Dim blPressureValue As Integer = (systolic + diastolic) / 2
					Dim blPrPoint As CategoricalDataPoint = New CategoricalDataPoint(blPressureValue, row.EncounterDatetime)
					blPrPoint.Label = row.BloodPressure
					lineBlPr.DataPoints.Add(blPrPoint)
				End If
				If Not row("RespiratoryRate") Is DBNull.Value Then
					Dim respRateValue As Integer = Me.ScaleChartValue(row.RespiratoryRate, 12, 28, 40, 60)
					Dim respRatePoint As CategoricalDataPoint = New CategoricalDataPoint(respRateValue, row.EncounterDatetime)
					respRatePoint.Label = row.RespiratoryRate
					lineRespRate.DataPoints.Add(respRatePoint)
				End If
				If Not row("Pulse") Is DBNull.Value Then
					Dim pulseValue As Integer = Me.ScaleChartValue(row.Pulse, 50, 150, 20, 40)
					Dim pulsePoint As CategoricalDataPoint = New CategoricalDataPoint(pulseValue, row.EncounterDatetime)
					pulsePoint.Label = row.Pulse & "/min"
					linePulse.DataPoints.Add(pulsePoint)
				End If
				If Not row("Temperature") Is DBNull.Value Then
					Dim tempValue As Integer = Me.ScaleChartValue(row.Temperature, 32, 40, 0, 20)
					Dim tempPoint As CategoricalDataPoint = New CategoricalDataPoint(tempValue, row.EncounterDatetime)
					tempPoint.Label = row.Temperature
					lineTemp.DataPoints.Add(tempPoint)
				End If
			Next row

			Me.summaryChartView.Series.Add(lineSaO2)
			Me.summaryChartView.Series.Add(lineBlPr)
			Me.summaryChartView.Series.Add(lineRespRate)
			Me.summaryChartView.Series.Add(linePulse)
			Me.summaryChartView.Series.Add(lineTemp)
			Dim grid As CartesianGrid = Me.summaryChartView.GetArea(Of CartesianArea)().GetGrid(Of CartesianGrid)()
			grid.AlternatingHorizontalColor = False

			Dim i As Integer = 0
			Do While i < verticalAxis.Children.Count
				Dim label As AxisLabelElement = TryCast(verticalAxis.Children(i), AxisLabelElement)

				If Not label Is Nothing Then
					label.PositionOffset = New PointF(0, -20)
				End If
				i += 1
			Loop
		End Sub

		Private Function CreateLineSeries(ByVal shape As ElementShape, ByVal backColor As Color, ByVal pointSize As SizeF) As LineSeries
			Dim lineSeries As LineSeries = New LineSeries()
			lineSeries.Shape = shape
			lineSeries.BorderColor = Color.Transparent
			lineSeries.BackColor = backColor
			lineSeries.PointSize = pointSize
			Return lineSeries
		End Function

		Private Function CreateInitialShape(ByVal vertices As Integer, ByVal radius1 As Double) As List(Of PointF)
			Dim pts As List(Of PointF) = New List(Of PointF)()

			If radius1 = 0 Then
			Return Nothing
			End If

			Dim i As Integer = 0
			Do While i < vertices
				Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices)
				pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
				i += 1
			Loop

			Return pts
		End Function

		Private Function ScaleChartValue(ByVal value As Double, ByVal minValue As Double, ByVal maxValue As Double, ByVal startRange As Integer, ByVal endRange As Integer) As Integer
			If value <= minValue Then
				Return startRange
			ElseIf maxValue <= value Then
				Return endRange
			End If

			Dim ticksCount As Integer = endRange - startRange
			Dim coef As Double = (value - minValue) / (maxValue - minValue)

			Return CInt(Fix(ticksCount * coef)) + startRange
		End Function

		#End Region

		#Region "History"

		Private Sub historyEditEncounterButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles historyEditEncounterButton.Click
			Me.CreateEditEncounterDocumentWindow()
		End Sub

		Private Sub historyEncountersListView_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs) Handles historyEncountersListView.VisualItemCreating
			Dim patientsItem As PatientsListViewVisualItem = New PatientsListViewVisualItem()
			patientsItem.TopRightElement.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
			patientsItem.Padding = New Padding(5, 0, 0, 0)
			e.VisualItem = patientsItem
		End Sub

		Private Sub historyEncountersListView_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs) Handles historyEncountersListView.VisualItemFormatting
			If (Not e.VisualItem.Data.Selected) AndAlso Me.historyEncountersListView.Items.IndexOf(e.VisualItem.Data) Mod 2 <> 0 Then
				e.VisualItem.BackColor = Color.FromArgb(250, 250, 250)
			Else
				e.VisualItem.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
			End If

			Dim [date] As DateTime = CDate(e.VisualItem.Data("Date"))
			e.VisualItem.Text = "<html>" & "<span style=""color:#262626;font-size:11pt;font-family:Segoe UI;"">" & [date].ToString("d MMM yyyy") & "</span>" & "<br>" & "<span style=""color:#006DC0;font-size:16pt;font-family:Segoe UI;"">" & e.VisualItem.Data("PrimaryDiagnosisName") & "</span>" & "</html>"

			If CBool(e.VisualItem.Data("Hospitalized")) Then
                TryCast(e.VisualItem, PatientsListViewVisualItem).TopRightElement.Text = "INPATIENT"
			Else
                TryCast(e.VisualItem, PatientsListViewVisualItem).TopRightElement.Text = "OUTPATIENT"
			End If
		End Sub

		Private Sub historyEncountersListView_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles historyEncountersListView.SelectedItemChanged
			Dim item As ListViewDataItem = Me.historyEncountersListView.SelectedItem
			If item Is Nothing Then
				Return
			End If
			Dim encounterId As Integer = CInt(Fix(item("EncounterId")))
			Dim encounter As PatientsDataSet.EncountersRow = DataSources.PatientsDataSet.Encounters.FindById(encounterId)

			Me.historyEncounterDateLabel.Text = encounter.EncounterDatetime.ToString("d MMM yyyy | HH:mm")
			Dim concept As PatientsDataSet.ConceptsRow = DataSources.PatientsDataSet.Concepts.FindById(encounter.PrimaryDiagnosisId)
			Me.historyPrimaryDiagnosisLabel.Text = concept.Name
			If Not encounter("SecondaryDiagnosisId") Is DBNull.Value Then
				concept = DataSources.PatientsDataSet.Concepts.FindById(encounter.SecondaryDiagnosisId)
				Me.historySecondaryDiagnosisLabel.Text = concept.Name
			Else
				Me.historySecondaryDiagnosisLabel.Text = String.Empty
			End If

			If Not encounter("Notes") Is DBNull.Value AndAlso (Not String.IsNullOrEmpty(Convert.ToString(encounter("Notes")))) Then
				Me.historyNotesLabel.Text = encounter.Notes
			Else
				Me.radLabel14.Visible = False
				Me.historyNotesLabel.Text = String.Empty
			End If
		End Sub

		Private Sub historyEncountersListView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles historyEncountersListView.DoubleClick
			Me.CreateEditEncounterDocumentWindow()
		End Sub

		Private Sub FillEncountersListView(ByVal personEncounters As DataRow())
			Dim encountersTable As DataTable = New DataTable()
			encountersTable.Columns.Add("EncounterId", GetType(Integer))
			encountersTable.Columns.Add("Date", GetType(DateTime))
			encountersTable.Columns.Add("ConceptId", GetType(Integer))
			encountersTable.Columns.Add("PrimaryDiagnosisName", GetType(String))
			encountersTable.Columns.Add("Hospitalized", GetType(Boolean))
			Dim i As Integer = 0
			Do While i < personEncounters.Length
				Dim encounter As PatientsDataSet.EncountersRow = CType(personEncounters(i), PatientsDataSet.EncountersRow)
				If Not encounter("PrimaryDiagnosisId") Is DBNull.Value Then
					Dim concept As PatientsDataSet.ConceptsRow = DataSources.PatientsDataSet.Concepts.FindById(encounter.PrimaryDiagnosisId)
					Dim hospitalized As Boolean = encounter.EncounterEndDatetime.DayOfYear <> encounter.EncounterDatetime.DayOfYear
					encountersTable.Rows.Add(encounter.Id, encounter.EncounterDatetime, encounter.PrimaryDiagnosisId, concept.Name, hospitalized)
				End If
				i += 1
			Loop

			Dim dataView As DataView = encountersTable.DefaultView
			dataView.Sort = "Date DESC"

			encountersTable = dataView.ToTable()

			Me.historyEncountersListView.DataSource = Nothing
			Dim encountersExist As Boolean = personEncounters.Length <> 0

			For Each control As Control In Me.documentWindowHistory.Controls
				control.Visible = encountersExist
			Next control

			For Each control As Control In Me.documentWindowSummary.Controls
				control.Visible = encountersExist
			Next control

			Me.summaryNoEncountersLabel.Visible = Not encountersExist
			Me.historyNoEncountersLabel.Visible = Not encountersExist

			If encountersExist Then
				Me.historyEncountersListView.DataSource = encountersTable
				Me.historyEncountersListView.SelectedIndex = 0
			End If
		End Sub

		Private Sub CreateEditEncounterDocumentWindow()
			Dim editEncounterDocumentWindow As DocumentWindow = New DocumentWindow()
			editEncounterDocumentWindow.DocumentButtons = DocumentStripButtons.None

			Dim item As ListViewDataItem = Me.historyEncountersListView.SelectedItem
			If item Is Nothing Then
				Return
			End If
			Dim encounterId As Integer = CInt(Fix(item("EncounterId")))

			Dim editEncounter As EditEncounter = New EditEncounter()
			editEncounter.Tag = encounterId

			editEncounterDocumentWindow.Controls.Add(editEncounter)
			Dim encounterDate As DateTime = CDate(item("Date"))
			editEncounterDocumentWindow.Text = encounterDate.ToString("d MMM yyyy")

			Me.documentTabStrip1.Controls.Add(editEncounterDocumentWindow)
			editEncounterDocumentWindow.Select()
		End Sub

		#End Region

		#Region "New encounter"

		Private Sub encounterSaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles encounterSaveButton.Click
			If (Not Me.AreRequiredFieldsValid()) Then
				Return
			End If

			Dim encounter As PatientsDataSet.EncountersRow = CType(DataSources.PatientsDataSet.Encounters.Rows.Add(), PatientsDataSet.EncountersRow)
			encounter.PersonId = Me.personId
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

			Me.ClearEncounterValues()
			Me.documentWindowSummary.Select()
		End Sub

		Private Sub encounterCancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles encounterCancelButton.Click
			Me.ClearEncounterValues()
			Me.documentTabStrip1.SelectedTab = Me.documentWindowSummary
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

		Private Sub ClearEncounterValues()
			Me.encounterStartDateTimePicker.DateTimePickerElement.Value = Nothing
			Me.encounterEndDateTimePicker.DateTimePickerElement.Value = Nothing
			Me.primaryDiagnosisDropDownList.SelectedItem = Nothing
			Me.secondaryDiagnosisDropDownList.SelectedItem = Nothing
			Me.encounterNotesTextBoxControl.Text = String.Empty
			Me.encounterTemperatureSpinEditor.NullableValue = Nothing
			Me.encounterPulseSpinEditor.NullableValue = Nothing
			Me.encounterRespiratoryRateSpinEditor.NullableValue = Nothing
			Me.encounterBloodPressureMaskedEditBox.Text = String.Empty
			Me.encounterBloodOxygenSaturationSpinEditor.NullableValue = Nothing
			Me.encounterWeightSpinEditor.NullableValue = Nothing
			Me.encounterHeightSpinEditor.NullableValue = Nothing
		End Sub

		Private Sub FillDiagnosisDropDownLists()
			Me.primaryDiagnosisDropDownList.BeginUpdate()
			Me.secondaryDiagnosisDropDownList.BeginUpdate()
			For Each concept As PatientsDataSet.ConceptsRow In DataSources.PatientsDataSet.Concepts
				Me.primaryDiagnosisDropDownList.Items.Add(New RadListDataItem(concept.Name, concept.Id))
				Me.secondaryDiagnosisDropDownList.Items.Add(New RadListDataItem(concept.Name, concept.Id))
			Next concept
			Me.primaryDiagnosisDropDownList.EndUpdate()
			Me.secondaryDiagnosisDropDownList.EndUpdate()
		End Sub

		#End Region
	End Class

	Public Class CustomFormatProvider
		Implements ICustomFormatter, IFormatProvider
		Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
			Return Me
		End Function

'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their method:
		Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
			Dim num As Integer = Integer.Parse(arg.ToString())
			Select Case num
				Case 0
					Return "Temperature"
				Case 20
					Return "Pulse"
				Case 40
					Return "Respiratory" & Environment.NewLine & "rate"
				Case 60
					Return "Blood" & Environment.NewLine & "pressure"
				Case 80
					Return "Blood" & Environment.NewLine & "oxygen" & Environment.NewLine & "saturation"
				Case Else
					Return String.Empty
			End Select
		End Function
	End Class
End Namespace
