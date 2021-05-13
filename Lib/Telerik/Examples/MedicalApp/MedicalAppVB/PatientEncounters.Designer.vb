Imports Microsoft.VisualBasic
Imports System
Namespace MedicalAppCS
	Public Partial Class PatientEncounters
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
			Me.components = New System.ComponentModel.Container()
			Dim cartesianArea2 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
			Me.radDockPatientEncounters = New Telerik.WinControls.UI.Docking.RadDock()
			Me.documentWindowSummary = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.summaryNoEncountersLabel = New Telerik.WinControls.UI.RadLabel()
			Me.summaryBMIRadialGauge = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
			Me.radialGaugeArc1 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
			Me.radialGaugeArc2 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
			Me.radialGaugeArc3 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
			Me.radialGaugeTicks1 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
			Me.radialGaugeLabels1 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
			Me.radialGaugeNeedle1 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
			Me.radialGaugeArc4 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
			Me.summaryWeightLabel = New Telerik.WinControls.UI.RadLabel()
			Me.summaryBMILabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.summaryBMICategoryLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.summaryHeightLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.summaryChartView = New Telerik.WinControls.UI.RadChartView()
			Me.summaryConditionsPanel = New Telerik.WinControls.UI.RadPanel()
			Me.summaryConditionsListControl = New Telerik.WinControls.UI.RadListControl()
			Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindowHistory = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.historyNoEncountersLabel = New Telerik.WinControls.UI.RadLabel()
			Me.historyEditEncounterButton = New Telerik.WinControls.UI.RadButton()
			Me.historyNotesLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel14 = New Telerik.WinControls.UI.RadLabel()
			Me.historySecondaryDiagnosisLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
			Me.historyPrimaryDiagnosisLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.historyEncounterDateLabel = New Telerik.WinControls.UI.RadLabel()
			Me.historyEncountersListView = New Telerik.WinControls.UI.RadListView()
			Me.documentWindowNewEncounter = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.secondaryDiagnosisDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.primaryDiagnosisDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.encounterBloodPressureMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.encounterNotesTextBoxControl = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.encounterEndDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.encounterStartDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.encounterCancelButton = New Telerik.WinControls.UI.RadButton()
			Me.encounterSaveButton = New Telerik.WinControls.UI.RadButton()
			Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel13 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel15 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel16 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel17 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel18 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel19 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel20 = New Telerik.WinControls.UI.RadLabel()
			Me.encounterHeightSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterWeightSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterBloodOxygenSaturationSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterRespiratoryRateSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterPulseSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.encounterTemperatureSpinEditor = New MedicalAppCS.NullableSpinEditor()
			Me.patientInformationLabel = New Telerik.WinControls.UI.RadLabel()
			Me.patientNameLabel = New Telerik.WinControls.UI.RadLabel()
			Me.varticalLineLabel = New Telerik.WinControls.UI.RadLabel()
			Me.EditPatientInfoButton = New Telerik.WinControls.UI.RadButton()
			Me.addressCityLabel = New Telerik.WinControls.UI.RadLabel()
			Me.addressStreetLabel = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
			Me.phoneLabel = New Telerik.WinControls.UI.RadLabel()
			Me.patientImageLabel = New Telerik.WinControls.UI.RadLabel()
			Me.conceptsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.ConceptsTableAdapter()
			Me.encountersTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.EncountersTableAdapter()
			Me.personsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter()
			Me.personImagesTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter()
			Me.patientsTableAdapter1 = New MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter()
			Me.encountersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.radDockPatientEncounters, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDockPatientEncounters.SuspendLayout()
			Me.documentWindowSummary.SuspendLayout()
			CType(Me.summaryNoEncountersLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryBMIRadialGauge, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryWeightLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryBMILabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryBMICategoryLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryHeightLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.summaryConditionsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.summaryConditionsPanel.SuspendLayout()
			CType(Me.summaryConditionsListControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			Me.documentWindowHistory.SuspendLayout()
			CType(Me.historyNoEncountersLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historyEditEncounterButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historyNotesLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historySecondaryDiagnosisLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historyPrimaryDiagnosisLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historyEncounterDateLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.historyEncountersListView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentWindowNewEncounter.SuspendLayout()
			CType(Me.secondaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.primaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterBloodPressureMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterNotesTextBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterEndDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterStartDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterSaveButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterHeightSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterWeightSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterBloodOxygenSaturationSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterRespiratoryRateSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterPulseSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encounterTemperatureSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.patientInformationLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.patientNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.varticalLineLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.EditPatientInfoButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addressCityLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addressStreetLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.phoneLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.patientImageLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDockPatientEncounters
			' 
			Me.radDockPatientEncounters.ActiveWindow = Me.documentWindowSummary
			Me.radDockPatientEncounters.Controls.Add(Me.documentContainer1)
			Me.radDockPatientEncounters.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.radDockPatientEncounters.DragDropMode = Telerik.WinControls.UI.Docking.DragDropMode.Immediate
			Me.radDockPatientEncounters.IsCleanUpTarget = True
			Me.radDockPatientEncounters.Location = New System.Drawing.Point(0, 146)
			Me.radDockPatientEncounters.MainDocumentContainer = Me.documentContainer1
			Me.radDockPatientEncounters.Name = "radDockPatientEncounters"
			' 
			' 
			' 
			Me.radDockPatientEncounters.RootElement.MinSize = New System.Drawing.Size(0, 0)
			Me.radDockPatientEncounters.ShowDocumentCloseButton = True
			Me.radDockPatientEncounters.Size = New System.Drawing.Size(1364, 474)
			Me.radDockPatientEncounters.TabIndex = 0
			Me.radDockPatientEncounters.TabStop = False
			Me.radDockPatientEncounters.Text = "radDock1"
			Me.radDockPatientEncounters.ThemeName = "MedicalAppTheme"
'			Me.radDockPatientEncounters.DockWindowClosing += New Telerik.WinControls.UI.Docking.DockWindowCancelEventHandler(Me.radDockPatientEncounters_DockWindowClosing);
			' 
			' documentWindowSummary
			' 
			Me.documentWindowSummary.BackColor = System.Drawing.Color.Transparent
			Me.documentWindowSummary.Controls.Add(Me.summaryNoEncountersLabel)
			Me.documentWindowSummary.Controls.Add(Me.summaryBMIRadialGauge)
			Me.documentWindowSummary.Controls.Add(Me.summaryWeightLabel)
			Me.documentWindowSummary.Controls.Add(Me.summaryBMILabel)
			Me.documentWindowSummary.Controls.Add(Me.radLabel8)
			Me.documentWindowSummary.Controls.Add(Me.summaryBMICategoryLabel)
			Me.documentWindowSummary.Controls.Add(Me.radLabel4)
			Me.documentWindowSummary.Controls.Add(Me.summaryHeightLabel)
			Me.documentWindowSummary.Controls.Add(Me.radLabel1)
			Me.documentWindowSummary.Controls.Add(Me.summaryChartView)
			Me.documentWindowSummary.Controls.Add(Me.summaryConditionsPanel)
			Me.documentWindowSummary.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
			Me.documentWindowSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.documentWindowSummary.Location = New System.Drawing.Point(6, 29)
			Me.documentWindowSummary.Margin = New System.Windows.Forms.Padding(0)
			Me.documentWindowSummary.Name = "documentWindowSummary"
			Me.documentWindowSummary.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindowSummary.Size = New System.Drawing.Size(1342, 429)
			Me.documentWindowSummary.Text = "Summary"
			' 
			' summaryNoEncountersLabel
			' 
			Me.summaryNoEncountersLabel.Location = New System.Drawing.Point(20, 20)
			Me.summaryNoEncountersLabel.Name = "summaryNoEncountersLabel"
			Me.summaryNoEncountersLabel.Size = New System.Drawing.Size(210, 42)
			Me.summaryNoEncountersLabel.TabIndex = 9
			Me.summaryNoEncountersLabel.Text = "<html><span style=\""color:#000000;font-size:11pt;font-family:Segoe UI;\"">No data " & "available.<br>Start by adding new encounter.</span></html>"
			Me.summaryNoEncountersLabel.Visible = False
			' 
			' summaryBMIRadialGauge
			' 
			Me.summaryBMIRadialGauge.BackColor = System.Drawing.Color.Transparent
			Me.summaryBMIRadialGauge.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radialGaugeArc1, Me.radialGaugeArc2, Me.radialGaugeArc3, Me.radialGaugeTicks1, Me.radialGaugeLabels1, Me.radialGaugeNeedle1, Me.radialGaugeArc4})
			Me.summaryBMIRadialGauge.Location = New System.Drawing.Point(1115, 157)
			Me.summaryBMIRadialGauge.Name = "summaryBMIRadialGauge"
			Me.summaryBMIRadialGauge.RangeEnd = 60R
			Me.summaryBMIRadialGauge.RangeStart = 10R
			Me.summaryBMIRadialGauge.Size = New System.Drawing.Size(210, 198)
			Me.summaryBMIRadialGauge.StartAngle = 135R
			Me.summaryBMIRadialGauge.SweepAngle = 270R
			Me.summaryBMIRadialGauge.TabIndex = 6
			Me.summaryBMIRadialGauge.Text = "radRadialGauge1"
			Me.summaryBMIRadialGauge.Value = 24F
			' 
			' radialGaugeArc1
			' 
			Me.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(62))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(228))))))
			Me.radialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(144))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(103))))))
			Me.radialGaugeArc1.Name = "radialGaugeArc1"
			Me.radialGaugeArc1.NumberOfColors = 1
			Me.radialGaugeArc1.RangeEnd = 18.5R
			Me.radialGaugeArc1.Width = 6R
			' 
			' radialGaugeArc2
			' 
			Me.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(151))))))
			Me.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
			Me.radialGaugeArc2.Name = "radialGaugeArc2"
			Me.radialGaugeArc2.NumberOfColors = 1
			Me.radialGaugeArc2.RangeEnd = 25R
			Me.radialGaugeArc2.RangeStart = 18.5R
			Me.radialGaugeArc2.Width = 6R
			' 
			' radialGaugeArc3
			' 
			Me.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(82))))))
			Me.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
			Me.radialGaugeArc3.Name = "radialGaugeArc3"
			Me.radialGaugeArc3.NumberOfColors = 1
			Me.radialGaugeArc3.RangeEnd = 30R
			Me.radialGaugeArc3.RangeStart = 25R
			Me.radialGaugeArc3.Width = 6R
			' 
			' radialGaugeTicks1
			' 
			Me.radialGaugeTicks1.DrawText = False
			Me.radialGaugeTicks1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(53))))), (CInt(Fix((CByte(53))))), (CInt(Fix((CByte(53))))))
			Me.radialGaugeTicks1.Name = "radialGaugeTicks1"
			Me.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
			Me.radialGaugeTicks1.TicksCount = 5
			Me.radialGaugeTicks1.TicksLenghtPercentage = 4F
			Me.radialGaugeTicks1.TicksRadiusPercentage = 85F
			Me.radialGaugeTicks1.TickThickness = 1F
			' 
			' radialGaugeLabels1
			' 
			Me.radialGaugeLabels1.DrawText = False
			Me.radialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))))
			Me.radialGaugeLabels1.LabelFontSize = 5F
			Me.radialGaugeLabels1.LabelsCount = 5
			Me.radialGaugeLabels1.Name = "radialGaugeLabels1"
			Me.radialGaugeLabels1.NumberOfColors = 2
			' 
			' radialGaugeNeedle1
			' 
			Me.radialGaugeNeedle1.AutoSize = True
			Me.radialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.radialGaugeNeedle1.BackLenghtPercentage = 0R
			Me.radialGaugeNeedle1.BindValue = True
			Me.radialGaugeNeedle1.InnerPointRadiusPercentage = 2.5R
			Me.radialGaugeNeedle1.LenghtPercentage = 80R
			Me.radialGaugeNeedle1.Name = "radialGaugeNeedle1"
			Me.radialGaugeNeedle1.NumberOfColors = 1
			Me.radialGaugeNeedle1.PointRadiusPercentage = 4R
			Me.radialGaugeNeedle1.Thickness = 0.4R
			Me.radialGaugeNeedle1.Value = 24F
			' 
			' radialGaugeArc4
			' 
			Me.radialGaugeArc4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(52))))))
			Me.radialGaugeArc4.Name = "radialGaugeArc4"
			Me.radialGaugeArc4.RangeEnd = 60R
			Me.radialGaugeArc4.RangeStart = 30R
			Me.radialGaugeArc4.Text = "radialGaugeArc4"
			Me.radialGaugeArc4.Width = 3R
			' 
			' summaryWeightLabel
			' 
			Me.summaryWeightLabel.BackColor = System.Drawing.Color.Transparent
			Me.summaryWeightLabel.Font = New System.Drawing.Font("Segoe UI", 25F)
			Me.summaryWeightLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.summaryWeightLabel.Location = New System.Drawing.Point(1200, 45)
			Me.summaryWeightLabel.Margin = New System.Windows.Forms.Padding(0)
			Me.summaryWeightLabel.Name = "summaryWeightLabel"
			Me.summaryWeightLabel.Size = New System.Drawing.Size(97, 51)
			Me.summaryWeightLabel.TabIndex = 7
			Me.summaryWeightLabel.Text = "70 kg"
			' 
			' summaryBMILabel
			' 
			Me.summaryBMILabel.BackColor = System.Drawing.Color.Transparent
			Me.summaryBMILabel.Font = New System.Drawing.Font("Segoe UI", 25F)
			Me.summaryBMILabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.summaryBMILabel.Location = New System.Drawing.Point(1065, 161)
			Me.summaryBMILabel.Name = "summaryBMILabel"
			Me.summaryBMILabel.Size = New System.Drawing.Size(51, 51)
			Me.summaryBMILabel.TabIndex = 8
			Me.summaryBMILabel.Text = "24"
			' 
			' radLabel8
			' 
			Me.radLabel8.BackColor = System.Drawing.Color.Transparent
			Me.radLabel8.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel8.Location = New System.Drawing.Point(1206, 22)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New System.Drawing.Size(59, 22)
			Me.radLabel8.TabIndex = 6
			Me.radLabel8.Text = "WEIGHT"
			' 
			' summaryBMICategoryLabel
			' 
			Me.summaryBMICategoryLabel.BackColor = System.Drawing.Color.Transparent
			Me.summaryBMICategoryLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.summaryBMICategoryLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(151))))))
			Me.summaryBMICategoryLabel.Location = New System.Drawing.Point(1100, 136)
			Me.summaryBMICategoryLabel.Margin = New System.Windows.Forms.Padding(0)
			Me.summaryBMICategoryLabel.Name = "summaryBMICategoryLabel"
			Me.summaryBMICategoryLabel.Size = New System.Drawing.Size(66, 22)
			Me.summaryBMICategoryLabel.TabIndex = 7
			Me.summaryBMICategoryLabel.Text = "NORMAL"
			' 
			' radLabel4
			' 
			Me.radLabel4.BackColor = System.Drawing.Color.Transparent
			Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel4.Location = New System.Drawing.Point(1068, 136)
			Me.radLabel4.Margin = New System.Windows.Forms.Padding(0)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(32, 22)
			Me.radLabel4.TabIndex = 6
			Me.radLabel4.Text = "BMI"
			' 
			' summaryHeightLabel
			' 
			Me.summaryHeightLabel.BackColor = System.Drawing.Color.Transparent
			Me.summaryHeightLabel.Font = New System.Drawing.Font("Segoe UI", 25F)
			Me.summaryHeightLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.summaryHeightLabel.Location = New System.Drawing.Point(1062, 45)
			Me.summaryHeightLabel.Margin = New System.Windows.Forms.Padding(0)
			Me.summaryHeightLabel.Name = "summaryHeightLabel"
			Me.summaryHeightLabel.Size = New System.Drawing.Size(124, 51)
			Me.summaryHeightLabel.TabIndex = 4
			Me.summaryHeightLabel.Text = "168 cm"
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel1.Location = New System.Drawing.Point(1068, 22)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(56, 22)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "HEIGHT"
			' 
			' summaryChartView
			' 
			cartesianArea2.ShowGrid = True
			Me.summaryChartView.AreaDesign = cartesianArea2
			Me.summaryChartView.Location = New System.Drawing.Point(230, 19)
			Me.summaryChartView.Name = "summaryChartView"
			Me.summaryChartView.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.SingleDataPoint
			Me.summaryChartView.ShowTitle = True
			Me.summaryChartView.Size = New System.Drawing.Size(829, 407)
			Me.summaryChartView.TabIndex = 2
			Me.summaryChartView.Text = "radChartView1"
			Me.summaryChartView.Title = "VITALS' HISTORY"
'			Me.summaryChartView.SelectedPointChanged += New Telerik.WinControls.UI.ChartViewSelectedChangedEventHandler(Me.summaryChartView_SelectedPointChanged);
'			Me.summaryChartView.LabelFormatting += New Telerik.WinControls.UI.ChartViewLabelFormattingEventHandler(Me.summaryChartView_LabelFormatting);
			' 
			' summaryConditionsPanel
			' 
			Me.summaryConditionsPanel.Controls.Add(Me.summaryConditionsListControl)
			Me.summaryConditionsPanel.Controls.Add(Me.radLabel11)
			Me.summaryConditionsPanel.Location = New System.Drawing.Point(19, 19)
			Me.summaryConditionsPanel.Margin = New System.Windows.Forms.Padding(0)
			Me.summaryConditionsPanel.Name = "summaryConditionsPanel"
			Me.summaryConditionsPanel.Size = New System.Drawing.Size(208, 389)
			Me.summaryConditionsPanel.TabIndex = 1
			Me.summaryConditionsPanel.ThemeName = "MedicalAppTheme"
			' 
			' summaryConditionsListControl
			' 
			Me.summaryConditionsListControl.AutoSizeItems = True
			Me.summaryConditionsListControl.Location = New System.Drawing.Point(5, 31)
			Me.summaryConditionsListControl.Name = "summaryConditionsListControl"
			Me.summaryConditionsListControl.SelectionMode = System.Windows.Forms.SelectionMode.None
			Me.summaryConditionsListControl.Size = New System.Drawing.Size(198, 355)
			Me.summaryConditionsListControl.TabIndex = 4
			Me.summaryConditionsListControl.Text = "radListControl1"
			Me.summaryConditionsListControl.ThemeName = "MedicalAppTheme"
			' 
			' radLabel11
			' 
			Me.radLabel11.BackColor = System.Drawing.Color.Transparent
			Me.radLabel11.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel11.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel11.Location = New System.Drawing.Point(6, 3)
			Me.radLabel11.Name = "radLabel11"
			Me.radLabel11.Size = New System.Drawing.Size(92, 22)
			Me.radLabel11.TabIndex = 3
			Me.radLabel11.Text = "CONDITIONS"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.ThemeName = "MedicalAppTheme"
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CanUpdateChildIndex = True
			Me.documentTabStrip1.Controls.Add(Me.documentWindowSummary)
			Me.documentTabStrip1.Controls.Add(Me.documentWindowHistory)
			Me.documentTabStrip1.Controls.Add(Me.documentWindowNewEncounter)
			Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.ShowItemCloseButton = True
			Me.documentTabStrip1.Size = New System.Drawing.Size(1354, 464)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			Me.documentTabStrip1.ThemeName = "MedicalAppTheme"
			' 
			' documentWindowHistory
			' 
			Me.documentWindowHistory.Controls.Add(Me.historyNoEncountersLabel)
			Me.documentWindowHistory.Controls.Add(Me.historyEditEncounterButton)
			Me.documentWindowHistory.Controls.Add(Me.historyNotesLabel)
			Me.documentWindowHistory.Controls.Add(Me.radLabel14)
			Me.documentWindowHistory.Controls.Add(Me.historySecondaryDiagnosisLabel)
			Me.documentWindowHistory.Controls.Add(Me.radLabel12)
			Me.documentWindowHistory.Controls.Add(Me.historyPrimaryDiagnosisLabel)
			Me.documentWindowHistory.Controls.Add(Me.radLabel7)
			Me.documentWindowHistory.Controls.Add(Me.historyEncounterDateLabel)
			Me.documentWindowHistory.Controls.Add(Me.historyEncountersListView)
			Me.documentWindowHistory.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
			Me.documentWindowHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.documentWindowHistory.Location = New System.Drawing.Point(6, 29)
			Me.documentWindowHistory.Margin = New System.Windows.Forms.Padding(0)
			Me.documentWindowHistory.Name = "documentWindowHistory"
			Me.documentWindowHistory.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindowHistory.Size = New System.Drawing.Size(1342, 429)
			Me.documentWindowHistory.Text = "History"
			' 
			' historyNoEncountersLabel
			' 
			Me.historyNoEncountersLabel.Location = New System.Drawing.Point(20, 20)
			Me.historyNoEncountersLabel.Name = "historyNoEncountersLabel"
			Me.historyNoEncountersLabel.Size = New System.Drawing.Size(210, 42)
			Me.historyNoEncountersLabel.TabIndex = 10
			Me.historyNoEncountersLabel.Text = "<html><span style=\""color:#000000;font-size:11pt;font-family:Segoe UI;\"">No data " & "available.<br>Start by adding new encounter.</span></html>"
			Me.historyNoEncountersLabel.Visible = False
			' 
			' historyEditEncounterButton
			' 
			Me.historyEditEncounterButton.Location = New System.Drawing.Point(1010, 19)
			Me.historyEditEncounterButton.Name = "historyEditEncounterButton"
			Me.historyEditEncounterButton.Size = New System.Drawing.Size(153, 36)
			Me.historyEditEncounterButton.TabIndex = 3
			Me.historyEditEncounterButton.Text = "Edit encounter"
			Me.historyEditEncounterButton.ThemeName = "MedicalAppTheme"
'			Me.historyEditEncounterButton.Click += New System.EventHandler(Me.historyEditEncounterButton_Click);
			' 
			' historyNotesLabel
			' 
			Me.historyNotesLabel.AutoSize = False
			Me.historyNotesLabel.BackColor = System.Drawing.Color.Transparent
			Me.historyNotesLabel.Font = New System.Drawing.Font("Segoe UI Light", 18F)
			Me.historyNotesLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))))
			Me.historyNotesLabel.Location = New System.Drawing.Point(579, 237)
			Me.historyNotesLabel.Name = "historyNotesLabel"
			Me.historyNotesLabel.Size = New System.Drawing.Size(761, 191)
			Me.historyNotesLabel.TabIndex = 2
			' 
			' radLabel14
			' 
			Me.radLabel14.BackColor = System.Drawing.Color.Transparent
			Me.radLabel14.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel14.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel14.Location = New System.Drawing.Point(582, 218)
			Me.radLabel14.Name = "radLabel14"
			Me.radLabel14.Size = New System.Drawing.Size(51, 22)
			Me.radLabel14.TabIndex = 2
			Me.radLabel14.Text = "NOTES"
			' 
			' historySecondaryDiagnosisLabel
			' 
			Me.historySecondaryDiagnosisLabel.BackColor = System.Drawing.Color.Transparent
			Me.historySecondaryDiagnosisLabel.Font = New System.Drawing.Font("Segoe UI Light", 18F)
			Me.historySecondaryDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))))
			Me.historySecondaryDiagnosisLabel.Location = New System.Drawing.Point(579, 162)
			Me.historySecondaryDiagnosisLabel.Name = "historySecondaryDiagnosisLabel"
			Me.historySecondaryDiagnosisLabel.Size = New System.Drawing.Size(2, 2)
			Me.historySecondaryDiagnosisLabel.TabIndex = 2
			' 
			' radLabel12
			' 
			Me.radLabel12.BackColor = System.Drawing.Color.Transparent
			Me.radLabel12.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel12.Location = New System.Drawing.Point(582, 144)
			Me.radLabel12.Name = "radLabel12"
			Me.radLabel12.Size = New System.Drawing.Size(167, 22)
			Me.radLabel12.TabIndex = 2
			Me.radLabel12.Text = "SECONDARY DIAGNOSIS"
			' 
			' historyPrimaryDiagnosisLabel
			' 
			Me.historyPrimaryDiagnosisLabel.BackColor = System.Drawing.Color.Transparent
			Me.historyPrimaryDiagnosisLabel.Font = New System.Drawing.Font("Segoe UI Light", 18F)
			Me.historyPrimaryDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))), (CInt(Fix((CByte(38))))))
			Me.historyPrimaryDiagnosisLabel.Location = New System.Drawing.Point(579, 87)
			Me.historyPrimaryDiagnosisLabel.Name = "historyPrimaryDiagnosisLabel"
			Me.historyPrimaryDiagnosisLabel.Size = New System.Drawing.Size(2, 2)
			Me.historyPrimaryDiagnosisLabel.TabIndex = 2
			' 
			' radLabel7
			' 
			Me.radLabel7.BackColor = System.Drawing.Color.Transparent
			Me.radLabel7.Font = New System.Drawing.Font("Segoe UI", 10.5F)
			Me.radLabel7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.radLabel7.Location = New System.Drawing.Point(582, 69)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(144, 22)
			Me.radLabel7.TabIndex = 2
			Me.radLabel7.Text = "PRIMARY DIAGNOSIS"
			' 
			' historyEncounterDateLabel
			' 
			Me.historyEncounterDateLabel.BackColor = System.Drawing.Color.Transparent
			Me.historyEncounterDateLabel.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.historyEncounterDateLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
			Me.historyEncounterDateLabel.Location = New System.Drawing.Point(580, 13)
			Me.historyEncounterDateLabel.Name = "historyEncounterDateLabel"
			Me.historyEncounterDateLabel.Size = New System.Drawing.Size(16, 33)
			Me.historyEncounterDateLabel.TabIndex = 1
			Me.historyEncounterDateLabel.Text = " "
			' 
			' historyEncountersListView
			' 
			Me.historyEncountersListView.AllowEdit = False
			Me.historyEncountersListView.AllowRemove = False
			Me.historyEncountersListView.ItemSize = New System.Drawing.Size(530, 90)
			Me.historyEncountersListView.Location = New System.Drawing.Point(19, 19)
			Me.historyEncountersListView.Name = "historyEncountersListView"
			Me.historyEncountersListView.SelectLastAddedItem = False
			Me.historyEncountersListView.Size = New System.Drawing.Size(550, 377)
			Me.historyEncountersListView.TabIndex = 0
			Me.historyEncountersListView.Text = "radListView1"
			Me.historyEncountersListView.ThemeName = "MedicalAppTheme"
'			Me.historyEncountersListView.SelectedItemChanged += New System.EventHandler(Me.historyEncountersListView_SelectedItemChanged);
'			Me.historyEncountersListView.VisualItemFormatting += New Telerik.WinControls.UI.ListViewVisualItemEventHandler(Me.historyEncountersListView_VisualItemFormatting);
'			Me.historyEncountersListView.VisualItemCreating += New Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(Me.historyEncountersListView_VisualItemCreating);
'			Me.historyEncountersListView.DoubleClick += New System.EventHandler(Me.historyEncountersListView_DoubleClick);
			' 
			' documentWindowNewEncounter
			' 
			Me.documentWindowNewEncounter.BackColor = System.Drawing.Color.White
			Me.documentWindowNewEncounter.Controls.Add(Me.secondaryDiagnosisDropDownList)
			Me.documentWindowNewEncounter.Controls.Add(Me.primaryDiagnosisDropDownList)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterBloodPressureMaskedEditBox)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterNotesTextBoxControl)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterEndDateTimePicker)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterStartDateTimePicker)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterCancelButton)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterSaveButton)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel10)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel2)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel3)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel5)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel6)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel13)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel15)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel16)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel17)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel18)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel19)
			Me.documentWindowNewEncounter.Controls.Add(Me.radLabel20)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterHeightSpinEditor)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterWeightSpinEditor)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterBloodOxygenSaturationSpinEditor)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterRespiratoryRateSpinEditor)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterPulseSpinEditor)
			Me.documentWindowNewEncounter.Controls.Add(Me.encounterTemperatureSpinEditor)
			Me.documentWindowNewEncounter.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
			Me.documentWindowNewEncounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.documentWindowNewEncounter.Location = New System.Drawing.Point(6, 29)
			Me.documentWindowNewEncounter.Margin = New System.Windows.Forms.Padding(0)
			Me.documentWindowNewEncounter.Name = "documentWindowNewEncounter"
			Me.documentWindowNewEncounter.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindowNewEncounter.Size = New System.Drawing.Size(1342, 429)
			Me.documentWindowNewEncounter.Text = "New encounter"
			' 
			' secondaryDiagnosisDropDownList
			' 
			Me.secondaryDiagnosisDropDownList.Location = New System.Drawing.Point(19, 196)
			Me.secondaryDiagnosisDropDownList.Name = "secondaryDiagnosisDropDownList"
			Me.secondaryDiagnosisDropDownList.Size = New System.Drawing.Size(435, 20)
			Me.secondaryDiagnosisDropDownList.TabIndex = 45
			Me.secondaryDiagnosisDropDownList.ThemeName = "MedicalAppTheme"
			' 
			' primaryDiagnosisDropDownList
			' 
			Me.primaryDiagnosisDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.primaryDiagnosisDropDownList.Location = New System.Drawing.Point(19, 142)
			Me.primaryDiagnosisDropDownList.Name = "primaryDiagnosisDropDownList"
			Me.primaryDiagnosisDropDownList.Size = New System.Drawing.Size(435, 20)
			Me.primaryDiagnosisDropDownList.TabIndex = 44
			Me.primaryDiagnosisDropDownList.ThemeName = "MedicalAppTheme"
			' 
			' encounterBloodPressureMaskedEditBox
			' 
			Me.encounterBloodPressureMaskedEditBox.Location = New System.Drawing.Point(568, 212)
			Me.encounterBloodPressureMaskedEditBox.Mask = "990\/990"
			Me.encounterBloodPressureMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
			Me.encounterBloodPressureMaskedEditBox.Name = "encounterBloodPressureMaskedEditBox"
			Me.encounterBloodPressureMaskedEditBox.PromptChar = " "c
			Me.encounterBloodPressureMaskedEditBox.Size = New System.Drawing.Size(228, 20)
			Me.encounterBloodPressureMaskedEditBox.TabIndex = 43
			Me.encounterBloodPressureMaskedEditBox.TabStop = False
			Me.encounterBloodPressureMaskedEditBox.Text = "   /   "
			Me.encounterBloodPressureMaskedEditBox.ThemeName = "MedicalAppTheme"
			' 
			' encounterNotesTextBoxControl
			' 
			Me.encounterNotesTextBoxControl.Location = New System.Drawing.Point(19, 245)
			Me.encounterNotesTextBoxControl.Multiline = True
			Me.encounterNotesTextBoxControl.Name = "encounterNotesTextBoxControl"
			Me.encounterNotesTextBoxControl.Size = New System.Drawing.Size(435, 161)
			Me.encounterNotesTextBoxControl.TabIndex = 36
			Me.encounterNotesTextBoxControl.ThemeName = "MedicalAppTheme"
			' 
			' encounterEndDateTimePicker
			' 
			Me.encounterEndDateTimePicker.CustomFormat = "d-M-yyyy HH:mm"
			Me.encounterEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.encounterEndDateTimePicker.Location = New System.Drawing.Point(19, 87)
			Me.encounterEndDateTimePicker.Name = "encounterEndDateTimePicker"
			Me.encounterEndDateTimePicker.Size = New System.Drawing.Size(435, 20)
			Me.encounterEndDateTimePicker.TabIndex = 35
			Me.encounterEndDateTimePicker.TabStop = False
			Me.encounterEndDateTimePicker.Value = New System.DateTime((CLng(Fix(0))))
			' 
			' encounterStartDateTimePicker
			' 
			Me.encounterStartDateTimePicker.CustomFormat = "d-M-yyyy HH:mm"
			Me.encounterStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			Me.encounterStartDateTimePicker.Location = New System.Drawing.Point(19, 38)
			Me.encounterStartDateTimePicker.Name = "encounterStartDateTimePicker"
			Me.encounterStartDateTimePicker.Size = New System.Drawing.Size(435, 20)
			Me.encounterStartDateTimePicker.TabIndex = 34
			Me.encounterStartDateTimePicker.TabStop = False
			Me.encounterStartDateTimePicker.Value = New System.DateTime((CLng(Fix(0))))
			' 
			' encounterCancelButton
			' 
			Me.encounterCancelButton.Location = New System.Drawing.Point(911, 68)
			Me.encounterCancelButton.Name = "encounterCancelButton"
			Me.encounterCancelButton.Size = New System.Drawing.Size(228, 36)
			Me.encounterCancelButton.TabIndex = 33
			Me.encounterCancelButton.Text = "Cancel"
			Me.encounterCancelButton.ThemeName = "MedicalAppTheme"
'			Me.encounterCancelButton.Click += New System.EventHandler(Me.encounterCancelButton_Click);
			' 
			' encounterSaveButton
			' 
			Me.encounterSaveButton.Location = New System.Drawing.Point(911, 22)
			Me.encounterSaveButton.Name = "encounterSaveButton"
			Me.encounterSaveButton.Size = New System.Drawing.Size(228, 36)
			Me.encounterSaveButton.TabIndex = 32
			Me.encounterSaveButton.Text = "Save"
			Me.encounterSaveButton.ThemeName = "MedicalAppTheme"
'			Me.encounterSaveButton.Click += New System.EventHandler(Me.encounterSaveButton_Click);
			' 
			' radLabel10
			' 
			Me.radLabel10.BackColor = System.Drawing.Color.Transparent
			Me.radLabel10.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel10.Location = New System.Drawing.Point(565, 365)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New System.Drawing.Size(49, 22)
			Me.radLabel10.TabIndex = 31
			Me.radLabel10.Text = "Height"
			Me.radLabel10.ThemeName = "MedicalAppTheme"
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel2.Location = New System.Drawing.Point(565, 189)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(100, 22)
			Me.radLabel2.TabIndex = 28
			Me.radLabel2.Text = "Blood pressure"
			Me.radLabel2.ThemeName = "MedicalAppTheme"
			' 
			' radLabel3
			' 
			Me.radLabel3.BackColor = System.Drawing.Color.Transparent
			Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel3.Location = New System.Drawing.Point(566, 307)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(52, 22)
			Me.radLabel3.TabIndex = 29
			Me.radLabel3.Text = "Weight"
			Me.radLabel3.ThemeName = "MedicalAppTheme"
			' 
			' radLabel5
			' 
			Me.radLabel5.BackColor = System.Drawing.Color.Transparent
			Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel5.Location = New System.Drawing.Point(565, 130)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(105, 22)
			Me.radLabel5.TabIndex = 26
			Me.radLabel5.Text = "Respiratory rate"
			Me.radLabel5.ThemeName = "MedicalAppTheme"
			' 
			' radLabel6
			' 
			Me.radLabel6.BackColor = System.Drawing.Color.Transparent
			Me.radLabel6.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel6.Location = New System.Drawing.Point(565, 248)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(158, 22)
			Me.radLabel6.TabIndex = 30
			Me.radLabel6.Text = "Blood oxygen saturation"
			Me.radLabel6.ThemeName = "MedicalAppTheme"
			' 
			' radLabel13
			' 
			Me.radLabel13.BackColor = System.Drawing.Color.Transparent
			Me.radLabel13.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel13.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel13.Location = New System.Drawing.Point(565, 72)
			Me.radLabel13.Name = "radLabel13"
			Me.radLabel13.Size = New System.Drawing.Size(40, 22)
			Me.radLabel13.TabIndex = 25
			Me.radLabel13.Text = "Pulse"
			Me.radLabel13.ThemeName = "MedicalAppTheme"
			' 
			' radLabel15
			' 
			Me.radLabel15.BackColor = System.Drawing.Color.Transparent
			Me.radLabel15.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel15.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel15.Location = New System.Drawing.Point(566, 15)
			Me.radLabel15.Name = "radLabel15"
			Me.radLabel15.Size = New System.Drawing.Size(87, 22)
			Me.radLabel15.TabIndex = 24
			Me.radLabel15.Text = "Temperature"
			Me.radLabel15.ThemeName = "MedicalAppTheme"
			' 
			' radLabel16
			' 
			Me.radLabel16.BackColor = System.Drawing.Color.Transparent
			Me.radLabel16.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel16.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel16.Location = New System.Drawing.Point(16, 222)
			Me.radLabel16.Name = "radLabel16"
			Me.radLabel16.Size = New System.Drawing.Size(44, 22)
			Me.radLabel16.TabIndex = 23
			Me.radLabel16.Text = "Notes"
			Me.radLabel16.ThemeName = "MedicalAppTheme"
			' 
			' radLabel17
			' 
			Me.radLabel17.BackColor = System.Drawing.Color.Transparent
			Me.radLabel17.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel17.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel17.Location = New System.Drawing.Point(17, 173)
			Me.radLabel17.Name = "radLabel17"
			Me.radLabel17.Size = New System.Drawing.Size(134, 22)
			Me.radLabel17.TabIndex = 22
			Me.radLabel17.Text = "Secondary diagnosis"
			Me.radLabel17.ThemeName = "MedicalAppTheme"
			' 
			' radLabel18
			' 
			Me.radLabel18.BackColor = System.Drawing.Color.Transparent
			Me.radLabel18.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel18.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel18.Location = New System.Drawing.Point(16, 119)
			Me.radLabel18.Name = "radLabel18"
			Me.radLabel18.Size = New System.Drawing.Size(117, 22)
			Me.radLabel18.TabIndex = 21
			Me.radLabel18.Text = "Primary diagnosis"
			Me.radLabel18.ThemeName = "MedicalAppTheme"
			' 
			' radLabel19
			' 
			Me.radLabel19.BackColor = System.Drawing.Color.Transparent
			Me.radLabel19.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel19.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel19.Location = New System.Drawing.Point(16, 64)
			Me.radLabel19.Name = "radLabel19"
			Me.radLabel19.Size = New System.Drawing.Size(30, 22)
			Me.radLabel19.TabIndex = 27
			Me.radLabel19.Text = "End"
			Me.radLabel19.ThemeName = "MedicalAppTheme"
			' 
			' radLabel20
			' 
			Me.radLabel20.BackColor = System.Drawing.Color.Transparent
			Me.radLabel20.Font = New System.Drawing.Font("Segoe UI", 10.25F)
			Me.radLabel20.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
			Me.radLabel20.Location = New System.Drawing.Point(17, 15)
			Me.radLabel20.Name = "radLabel20"
			Me.radLabel20.Size = New System.Drawing.Size(36, 22)
			Me.radLabel20.TabIndex = 20
			Me.radLabel20.Text = "Start"
			Me.radLabel20.ThemeName = "MedicalAppTheme"
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
			Me.encounterHeightSpinEditor.TabIndex = 42
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
			Me.encounterWeightSpinEditor.TabIndex = 41
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
			Me.encounterBloodOxygenSaturationSpinEditor.TabIndex = 40
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
			Me.encounterRespiratoryRateSpinEditor.TabIndex = 39
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
			Me.encounterPulseSpinEditor.TabIndex = 38
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
			Me.encounterTemperatureSpinEditor.TabIndex = 37
			Me.encounterTemperatureSpinEditor.TabStop = False
			Me.encounterTemperatureSpinEditor.ThemeName = "MedicalAppTheme"
			Me.encounterTemperatureSpinEditor.Value = New Decimal(New Integer() { 25, 0, 0, 0})
			' 
			' patientInformationLabel
			' 
			Me.patientInformationLabel.BackColor = System.Drawing.Color.Transparent
			Me.patientInformationLabel.Font = New System.Drawing.Font("Segoe UI", 14.5F)
			Me.patientInformationLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.patientInformationLabel.Location = New System.Drawing.Point(157, 64)
			Me.patientInformationLabel.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.patientInformationLabel.Name = "patientInformationLabel"
			Me.patientInformationLabel.Size = New System.Drawing.Size(249, 30)
			Me.patientInformationLabel.TabIndex = 5
			Me.patientInformationLabel.Text = "32 yo | female | 15-11-1981"
			' 
			' patientNameLabel
			' 
			Me.patientNameLabel.BackColor = System.Drawing.Color.Transparent
			Me.patientNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 32F)
			Me.patientNameLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(36))))), (CInt(Fix((CByte(24))))), (CInt(Fix((CByte(58))))))
			Me.patientNameLabel.Location = New System.Drawing.Point(154, 4)
			Me.patientNameLabel.Name = "patientNameLabel"
			Me.patientNameLabel.Size = New System.Drawing.Size(383, 64)
			Me.patientNameLabel.TabIndex = 8
			Me.patientNameLabel.Text = "Horatio Hornblower"
			' 
			' varticalLineLabel
			' 
			Me.varticalLineLabel.AutoSize = False
			Me.varticalLineLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(36))))), (CInt(Fix((CByte(24))))), (CInt(Fix((CByte(58))))))
			Me.varticalLineLabel.BorderVisible = True
			Me.varticalLineLabel.Location = New System.Drawing.Point(536, 19)
			Me.varticalLineLabel.Name = "varticalLineLabel"
			Me.varticalLineLabel.Size = New System.Drawing.Size(1, 114)
			Me.varticalLineLabel.TabIndex = 9
			' 
			' EditPatientInfoButton
			' 
			Me.EditPatientInfoButton.Location = New System.Drawing.Point(896, 20)
			Me.EditPatientInfoButton.Name = "EditPatientInfoButton"
			Me.EditPatientInfoButton.Size = New System.Drawing.Size(153, 33)
			Me.EditPatientInfoButton.TabIndex = 10
			Me.EditPatientInfoButton.Text = "Edit patient info"
			Me.EditPatientInfoButton.ThemeName = "MedicalAppTheme"
'			Me.EditPatientInfoButton.Click += New System.EventHandler(Me.EditPatientInfoButton_Click);
			' 
			' addressCityLabel
			' 
			Me.addressCityLabel.BackColor = System.Drawing.Color.Transparent
			Me.addressCityLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12F)
			Me.addressCityLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.addressCityLabel.Location = New System.Drawing.Point(558, 19)
			Me.addressCityLabel.Name = "addressCityLabel"
			Me.addressCityLabel.Size = New System.Drawing.Size(95, 25)
			Me.addressCityLabel.TabIndex = 11
			Me.addressCityLabel.Text = "Boston, MA"
			' 
			' addressStreetLabel
			' 
			Me.addressStreetLabel.AutoSize = False
			Me.addressStreetLabel.BackColor = System.Drawing.Color.Transparent
			Me.addressStreetLabel.Font = New System.Drawing.Font("Segoe UI", 12F)
			Me.addressStreetLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.addressStreetLabel.Location = New System.Drawing.Point(558, 43)
			Me.addressStreetLabel.Name = "addressStreetLabel"
			Me.addressStreetLabel.Size = New System.Drawing.Size(177, 47)
			Me.addressStreetLabel.TabIndex = 12
			Me.addressStreetLabel.Text = "201 Jones Road Waltham MA 02451"
			' 
			' radLabel9
			' 
			Me.radLabel9.BackColor = System.Drawing.Color.Transparent
			Me.radLabel9.Font = New System.Drawing.Font("Segoe UI", 12F)
			Me.radLabel9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(76))))), (CInt(Fix((CByte(76))))))
			Me.radLabel9.Location = New System.Drawing.Point(558, 96)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New System.Drawing.Size(58, 25)
			Me.radLabel9.TabIndex = 12
			Me.radLabel9.Text = "phone:"
			' 
			' phoneLabel
			' 
			Me.phoneLabel.BackColor = System.Drawing.Color.Transparent
			Me.phoneLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12F)
			Me.phoneLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
			Me.phoneLabel.Location = New System.Drawing.Point(617, 96)
			Me.phoneLabel.Name = "phoneLabel"
			Me.phoneLabel.Size = New System.Drawing.Size(116, 25)
			Me.phoneLabel.TabIndex = 12
			Me.phoneLabel.Text = "(123) 123-4567"
			' 
			' patientImageLabel
			' 
			Me.patientImageLabel.Image = Resources.no_image
			Me.patientImageLabel.Location = New System.Drawing.Point(18, 19)
			Me.patientImageLabel.Name = "patientImageLabel"
			Me.patientImageLabel.Size = New System.Drawing.Size(114, 114)
			Me.patientImageLabel.TabIndex = 1
			' 
			' conceptsTableAdapter1
			' 
			Me.conceptsTableAdapter1.ClearBeforeFill = True
			' 
			' encountersTableAdapter1
			' 
			Me.encountersTableAdapter1.ClearBeforeFill = True
			' 
			' personsTableAdapter1
			' 
			Me.personsTableAdapter1.ClearBeforeFill = True
			' 
			' personImagesTableAdapter1
			' 
			Me.personImagesTableAdapter1.ClearBeforeFill = True
			' 
			' patientsTableAdapter1
			' 
			Me.patientsTableAdapter1.ClearBeforeFill = True
			' 
			' PatientEncounters
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(252))))))
			Me.Controls.Add(Me.phoneLabel)
			Me.Controls.Add(Me.radLabel9)
			Me.Controls.Add(Me.addressStreetLabel)
			Me.Controls.Add(Me.addressCityLabel)
			Me.Controls.Add(Me.EditPatientInfoButton)
			Me.Controls.Add(Me.varticalLineLabel)
			Me.Controls.Add(Me.patientNameLabel)
			Me.Controls.Add(Me.patientInformationLabel)
			Me.Controls.Add(Me.patientImageLabel)
			Me.Controls.Add(Me.radDockPatientEncounters)
			Me.Name = "PatientEncounters"
			Me.Size = New System.Drawing.Size(1364, 620)
'			Me.Load += New System.EventHandler(Me.PatientEncounters_Load);
			CType(Me.radDockPatientEncounters, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDockPatientEncounters.ResumeLayout(False)
			Me.documentWindowSummary.ResumeLayout(False)
			Me.documentWindowSummary.PerformLayout()
			CType(Me.summaryNoEncountersLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryBMIRadialGauge, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryWeightLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryBMILabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryBMICategoryLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryHeightLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.summaryConditionsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.summaryConditionsPanel.ResumeLayout(False)
			Me.summaryConditionsPanel.PerformLayout()
			CType(Me.summaryConditionsListControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			Me.documentWindowHistory.ResumeLayout(False)
			Me.documentWindowHistory.PerformLayout()
			CType(Me.historyNoEncountersLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historyEditEncounterButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historyNotesLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historySecondaryDiagnosisLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historyPrimaryDiagnosisLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historyEncounterDateLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.historyEncountersListView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentWindowNewEncounter.ResumeLayout(False)
			Me.documentWindowNewEncounter.PerformLayout()
			CType(Me.secondaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.primaryDiagnosisDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterBloodPressureMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterNotesTextBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterEndDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterStartDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterSaveButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterHeightSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterWeightSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterBloodOxygenSaturationSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterRespiratoryRateSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterPulseSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encounterTemperatureSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.patientInformationLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.patientNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.varticalLineLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.EditPatientInfoButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addressCityLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addressStreetLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.phoneLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.patientImageLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radDockPatientEncounters As Telerik.WinControls.UI.Docking.RadDock
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentWindowHistory As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindowSummary As Telerik.WinControls.UI.Docking.DocumentWindow
		Private summaryBMILabel As Telerik.WinControls.UI.RadLabel
		Private summaryBMICategoryLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private summaryHeightLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents summaryChartView As Telerik.WinControls.UI.RadChartView
		Private summaryConditionsPanel As Telerik.WinControls.UI.RadPanel
		Private summaryWeightLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private summaryBMIRadialGauge As Telerik.WinControls.UI.Gauges.RadRadialGauge
		Private radialGaugeArc1 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeArc2 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeArc3 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeTicks1 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
		Private radialGaugeLabels1 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
		Private radialGaugeNeedle1 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
		Private radialGaugeArc4 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private summaryConditionsListControl As Telerik.WinControls.UI.RadListControl
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private patientImageLabel As Telerik.WinControls.UI.RadLabel
		Private patientInformationLabel As Telerik.WinControls.UI.RadLabel
		Private patientNameLabel As Telerik.WinControls.UI.RadLabel
		Private varticalLineLabel As Telerik.WinControls.UI.RadLabel
		Private documentWindowNewEncounter As Telerik.WinControls.UI.Docking.DocumentWindow
		Private WithEvents EditPatientInfoButton As Telerik.WinControls.UI.RadButton
		Private addressCityLabel As Telerik.WinControls.UI.RadLabel
		Private addressStreetLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private phoneLabel As Telerik.WinControls.UI.RadLabel
		Private WithEvents historyEncountersListView As Telerik.WinControls.UI.RadListView
		Private WithEvents historyEditEncounterButton As Telerik.WinControls.UI.RadButton
		Private historyNotesLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel14 As Telerik.WinControls.UI.RadLabel
		Private historySecondaryDiagnosisLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel12 As Telerik.WinControls.UI.RadLabel
		Private historyPrimaryDiagnosisLabel As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private historyEncounterDateLabel As Telerik.WinControls.UI.RadLabel
		Private secondaryDiagnosisDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private primaryDiagnosisDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private encounterBloodPressureMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
		Private encounterHeightSpinEditor As NullableSpinEditor
		Private encounterWeightSpinEditor As NullableSpinEditor
		Private encounterBloodOxygenSaturationSpinEditor As NullableSpinEditor
		Private encounterRespiratoryRateSpinEditor As NullableSpinEditor
		Private encounterPulseSpinEditor As NullableSpinEditor
		Private encounterTemperatureSpinEditor As NullableSpinEditor
		Private encounterNotesTextBoxControl As Telerik.WinControls.UI.RadTextBoxControl
		Private encounterEndDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private encounterStartDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private WithEvents encounterCancelButton As Telerik.WinControls.UI.RadButton
		Private WithEvents encounterSaveButton As Telerik.WinControls.UI.RadButton
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radLabel13 As Telerik.WinControls.UI.RadLabel
		Private radLabel15 As Telerik.WinControls.UI.RadLabel
		Private radLabel16 As Telerik.WinControls.UI.RadLabel
		Private radLabel17 As Telerik.WinControls.UI.RadLabel
		Private radLabel18 As Telerik.WinControls.UI.RadLabel
		Private radLabel19 As Telerik.WinControls.UI.RadLabel
		Private radLabel20 As Telerik.WinControls.UI.RadLabel
		Private conceptsTableAdapter1 As PatientsDataSetTableAdapters.ConceptsTableAdapter
		Private encountersTableAdapter1 As PatientsDataSetTableAdapters.EncountersTableAdapter
		Private personsTableAdapter1 As PatientsDataSetTableAdapters.PersonsTableAdapter
		Private personImagesTableAdapter1 As PatientsDataSetTableAdapters.PersonImagesTableAdapter
		Private patientsTableAdapter1 As PatientsDataSetTableAdapters.PatientsTableAdapter
		Private summaryNoEncountersLabel As Telerik.WinControls.UI.RadLabel
		Private historyNoEncountersLabel As Telerik.WinControls.UI.RadLabel
		Private encountersBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace
