Imports Microsoft.VisualBasic
Imports System
Namespace MedicalAppCS
    Partial Public Class MainForm
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
            Me.components = New System.ComponentModel.Container()
            Dim listViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name")
            Dim listViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Age")
            Dim listViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Gender")
            Dim listViewDetailColumn4 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "EncounterTime")
            Dim schedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Dim gridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim gridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim sortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
            Dim tableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.mainPanel = New Telerik.WinControls.UI.RadPanel()
            Me.radSplitButton1 = New Telerik.WinControls.UI.RadSplitButton()
            Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
            Me.radLabelDoctorImage = New Telerik.WinControls.UI.RadLabel()
            Me.radPanelButtonsContainer = New Telerik.WinControls.UI.RadPanel()
            Me.chartsToggleButton = New Telerik.WinControls.UI.RadToggleButton()
            Me.scheduleToggleButton = New Telerik.WinControls.UI.RadToggleButton()
            Me.dashboardToggleButton = New Telerik.WinControls.UI.RadToggleButton()
            Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
            Me.radPageViewPageDashboard = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radListViewNextPatients = New Telerik.WinControls.UI.RadListView()
            Me.radButtonNewAppointment = New Telerik.WinControls.UI.RadButton()
            Me.radButtonRegisterNewPatient = New Telerik.WinControls.UI.RadButton()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.dashboardClockCalendarPanel = New Telerik.WinControls.UI.RadPanel()
            Me.radCalendarDashboard = New Telerik.WinControls.UI.RadCalendar()
            Me.radClock1 = New Telerik.WinControls.UI.RadClock()
            Me.radPanelTomorrowAppointments = New Telerik.WinControls.UI.RadPanel()
            Me.radLabelFirstAppointmentTomorrow = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelTomorrowAppointmentsCount = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radPanelTodaysAppointments = New Telerik.WinControls.UI.RadPanel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelLastAppointmentToday = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelTodayAppointmentsCount = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radPageViewPageSchedule = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radCalendarSchedule = New Telerik.WinControls.UI.RadCalendar()
            Me.radButtonNewAppointmentScheduler = New Telerik.WinControls.UI.RadButton()
            Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
            Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
            Me.radPageViewPageCharts = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.radButtonShowInfoCharts = New Telerik.WinControls.UI.RadButton()
            Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
            Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelSelectedPatientAgeGenderCharts = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelSelectedPatientNameCharts = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelSelectedPatientImageCharts = New Telerik.WinControls.UI.RadLabel()
            Me.radButtonRegisternewPatientCharts = New Telerik.WinControls.UI.RadButton()
            Me.radGridViewPatients = New Telerik.WinControls.UI.RadGridView()
            Me.patientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.patientsDataSet = New MedicalAppCS.PatientsDataSet()
            Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.appointmentsTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.AppointmentsTableAdapter()
            Me.conceptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.conceptsTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.ConceptsTableAdapter()
            Me.encountersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.encountersTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.EncountersTableAdapter()
            Me.personImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.personImagesTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter()
            Me.personsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.personsTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter()
            Me.patientsTableAdapter = New MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter()
            CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType(Me.radSplitButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelDoctorImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelButtonsContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelButtonsContainer.SuspendLayout()
            CType(Me.chartsToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduleToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageView1.SuspendLayout()
            Me.radPageViewPageDashboard.SuspendLayout()
            CType(Me.radListViewNextPatients, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonNewAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonRegisterNewPatient, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardClockCalendarPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dashboardClockCalendarPanel.SuspendLayout()
            CType(Me.radCalendarDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radClock1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelTomorrowAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelTomorrowAppointments.SuspendLayout()
            CType(Me.radLabelFirstAppointmentTomorrow, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTomorrowAppointmentsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelTodaysAppointments.SuspendLayout()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTodayAppointmentsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageViewPageSchedule.SuspendLayout()
            CType(Me.radCalendarSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonNewAppointmentScheduler, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageViewPageCharts.SuspendLayout()
            CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.SuspendLayout()
            CType(Me.radButtonShowInfoCharts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSelectedPatientAgeGenderCharts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSelectedPatientNameCharts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSelectedPatientImageCharts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonRegisternewPatientCharts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridViewPatients, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridViewPatients.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.patientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.patientsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.conceptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.personImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.personsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(36))))), (CInt(Fix((CByte(24))))), (CInt(Fix((CByte(58))))))
            Me.mainPanel.Controls.Add(Me.radSplitButton1)
            Me.mainPanel.Controls.Add(Me.radLabelDoctorImage)
            Me.mainPanel.Controls.Add(Me.radPanelButtonsContainer)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(1364, 89)
            Me.mainPanel.TabIndex = 0
            ' 
            ' radSplitButton1
            ' 
            Me.radSplitButton1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(133))))), (CInt(Fix((CByte(131))))), (CInt(Fix((CByte(139))))))
            Me.radSplitButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
            Me.radSplitButton1.Location = New System.Drawing.Point(427, 4)
            Me.radSplitButton1.Name = "radSplitButton1"
            Me.radSplitButton1.Size = New System.Drawing.Size(178, 38)
            Me.radSplitButton1.TabIndex = 5
            Me.radSplitButton1.Text = "Dr. Jessica Roth"
            Me.radSplitButton1.ThemeName = "MedicalAppTheme"
            '			Me.radSplitButton1.DropDownOpening += New System.EventHandler(Me.radSplitButton1_DropDownOpening);
            ' 
            ' radMenuItem1
            ' 
            Me.radMenuItem1.Name = "radMenuItem1"
            Me.radMenuItem1.Text = "Settings"
            ' 
            ' radMenuItem2
            ' 
            Me.radMenuItem2.Name = "radMenuItem2"
            Me.radMenuItem2.Text = "Profile"
            ' 
            ' radMenuItem3
            ' 
            Me.radMenuItem3.Name = "radMenuItem3"
            Me.radMenuItem3.Text = "Log out"
            ' 
            ' radLabelDoctorImage
            ' 
            Me.radLabelDoctorImage.AutoSize = False
            Me.radLabelDoctorImage.Image = Resources.doctor
            Me.radLabelDoctorImage.Location = New System.Drawing.Point(339, 3)
            Me.radLabelDoctorImage.Name = "radLabelDoctorImage"
            Me.radLabelDoctorImage.Size = New System.Drawing.Size(82, 82)
            Me.radLabelDoctorImage.TabIndex = 3
            ' 
            ' radPanelButtonsContainer
            ' 
            Me.radPanelButtonsContainer.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(14))))), (CInt(Fix((CByte(186))))), (CInt(Fix((CByte(220))))))
            Me.radPanelButtonsContainer.Controls.Add(Me.chartsToggleButton)
            Me.radPanelButtonsContainer.Controls.Add(Me.scheduleToggleButton)
            Me.radPanelButtonsContainer.Controls.Add(Me.dashboardToggleButton)
            Me.radPanelButtonsContainer.Location = New System.Drawing.Point(1, 4)
            Me.radPanelButtonsContainer.Name = "radPanelButtonsContainer"
            Me.radPanelButtonsContainer.Size = New System.Drawing.Size(258, 80)
            Me.radPanelButtonsContainer.TabIndex = 2
            ' 
            ' chartsToggleButton
            ' 
            Me.chartsToggleButton.Location = New System.Drawing.Point(178, -1)
            Me.chartsToggleButton.Name = "chartsToggleButton"
            Me.chartsToggleButton.Size = New System.Drawing.Size(81, 82)
            Me.chartsToggleButton.TabIndex = 6
            Me.chartsToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chartsToggleButton.ThemeName = "MedicalAppTheme"
            '			Me.chartsToggleButton.Click += New System.EventHandler(Me.chartsToggleButton_Click);
            ' 
            ' scheduleToggleButton
            ' 
            Me.scheduleToggleButton.Location = New System.Drawing.Point(99, -1)
            Me.scheduleToggleButton.Name = "scheduleToggleButton"
            Me.scheduleToggleButton.Size = New System.Drawing.Size(80, 82)
            Me.scheduleToggleButton.TabIndex = 6
            Me.scheduleToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.scheduleToggleButton.ThemeName = "MedicalAppTheme"
            '			Me.scheduleToggleButton.Click += New System.EventHandler(Me.scheduleToggleButton_Click);
            ' 
            ' dashboardToggleButton
            ' 
            Me.dashboardToggleButton.CheckState = System.Windows.Forms.CheckState.Checked
            Me.dashboardToggleButton.Location = New System.Drawing.Point(20, -1)
            Me.dashboardToggleButton.Name = "dashboardToggleButton"
            Me.dashboardToggleButton.Size = New System.Drawing.Size(80, 82)
            Me.dashboardToggleButton.TabIndex = 5
            Me.dashboardToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.dashboardToggleButton.ThemeName = "MedicalAppTheme"
            Me.dashboardToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            '			Me.dashboardToggleButton.Click += New System.EventHandler(Me.dashboardToggleButton_Click);
            ' 
            ' radPageView1
            ' 
            Me.radPageView1.Controls.Add(Me.radPageViewPageDashboard)
            Me.radPageView1.Controls.Add(Me.radPageViewPageSchedule)
            Me.radPageView1.Controls.Add(Me.radPageViewPageCharts)
            Me.radPageView1.DefaultPage = Me.radPageViewPageDashboard
            Me.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPageView1.Location = New System.Drawing.Point(0, 89)
            Me.radPageView1.Margin = New System.Windows.Forms.Padding(0)
            Me.radPageView1.Name = "radPageView1"
            Me.radPageView1.SelectedPage = Me.radPageViewPageDashboard
            Me.radPageView1.Size = New System.Drawing.Size(1364, 651)
            Me.radPageView1.TabIndex = 1
            Me.radPageView1.Text = "radPageView1"
            Me.radPageView1.ThemeName = "MedicalAppTheme"
            '			Me.radPageView1.SelectedPageChanged += New System.EventHandler(Me.radPageView1_SelectedPageChanged);
            CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
            CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = True
            ' 
            ' radPageViewPageDashboard
            ' 
            Me.radPageViewPageDashboard.Controls.Add(Me.radListViewNextPatients)
            Me.radPageViewPageDashboard.Controls.Add(Me.radButtonNewAppointment)
            Me.radPageViewPageDashboard.Controls.Add(Me.radButtonRegisterNewPatient)
            Me.radPageViewPageDashboard.Controls.Add(Me.radLabel2)
            Me.radPageViewPageDashboard.Controls.Add(Me.radLabel1)
            Me.radPageViewPageDashboard.Controls.Add(Me.dashboardClockCalendarPanel)
            Me.radPageViewPageDashboard.Controls.Add(Me.radPanelTomorrowAppointments)
            Me.radPageViewPageDashboard.Controls.Add(Me.radPanelTodaysAppointments)
            Me.radPageViewPageDashboard.ItemSize = New System.Drawing.SizeF(103.0F, 28.0F)
            Me.radPageViewPageDashboard.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPageDashboard.Margin = New System.Windows.Forms.Padding(0)
            Me.radPageViewPageDashboard.Name = "radPageViewPageDashboard"
            Me.radPageViewPageDashboard.Size = New System.Drawing.Size(1343, 603)
            Me.radPageViewPageDashboard.Text = "DASHBOARD"
            ' 
            ' radListViewNextPatients
            ' 
            Me.radListViewNextPatients.AllowArbitraryItemHeight = True
            Me.radListViewNextPatients.AllowEdit = False
            Me.radListViewNextPatients.AllowRemove = False
            listViewDetailColumn1.HeaderText = "Name"
            listViewDetailColumn2.HeaderText = "Age"
            listViewDetailColumn3.HeaderText = "Gender"
            listViewDetailColumn4.HeaderText = "EncounterTime"
            Me.radListViewNextPatients.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {listViewDetailColumn1, listViewDetailColumn2, listViewDetailColumn3, listViewDetailColumn4})
            Me.radListViewNextPatients.ItemSize = New System.Drawing.Size(200, 95)
            Me.radListViewNextPatients.Location = New System.Drawing.Point(19, 87)
            Me.radListViewNextPatients.Name = "radListViewNextPatients"
            Me.radListViewNextPatients.SelectLastAddedItem = False
            Me.radListViewNextPatients.Size = New System.Drawing.Size(443, 303)
            Me.radListViewNextPatients.TabIndex = 7
            Me.radListViewNextPatients.Text = "radListView1"
            Me.radListViewNextPatients.ThemeName = "MedicalAppTheme"
            Me.radListViewNextPatients.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
            '			Me.radListViewNextPatients.VisualItemFormatting += New Telerik.WinControls.UI.ListViewVisualItemEventHandler(Me.radListViewNextPatients_VisualItemFormatting);
            '			Me.radListViewNextPatients.VisualItemCreating += New Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(Me.radListViewNextPatients_VisualItemCreating);
            '			Me.radListViewNextPatients.DoubleClick += New System.EventHandler(Me.radListViewNextPatients_DoubleClick);
            ' 
            ' radButtonNewAppointment
            ' 
            Me.radButtonNewAppointment.Location = New System.Drawing.Point(740, 27)
            Me.radButtonNewAppointment.Name = "radButtonNewAppointment"
            Me.radButtonNewAppointment.Size = New System.Drawing.Size(170, 33)
            Me.radButtonNewAppointment.TabIndex = 6
            Me.radButtonNewAppointment.Text = "New appointment"
            Me.radButtonNewAppointment.ThemeName = "MedicalAppTheme"
            '			Me.radButtonNewAppointment.Click += New System.EventHandler(Me.newAppointment_Click);
            ' 
            ' radButtonRegisterNewPatient
            ' 
            Me.radButtonRegisterNewPatient.Location = New System.Drawing.Point(288, 30)
            Me.radButtonRegisterNewPatient.Name = "radButtonRegisterNewPatient"
            Me.radButtonRegisterNewPatient.Size = New System.Drawing.Size(170, 33)
            Me.radButtonRegisterNewPatient.TabIndex = 5
            Me.radButtonRegisterNewPatient.Text = "Register new patient"
            Me.radButtonRegisterNewPatient.ThemeName = "MedicalAppTheme"
            '			Me.radButtonRegisterNewPatient.Click += New System.EventHandler(Me.registerNewPatient_Click);
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.BackColor = System.Drawing.Color.Transparent
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI Light", 21.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.radLabel2.Location = New System.Drawing.Point(470, 20)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(121, 43)
            Me.radLabel2.TabIndex = 4
            Me.radLabel2.Text = "Schedule"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.BackColor = System.Drawing.Color.Transparent
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI Light", 24.0F)
            Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(11))))), (CInt(Fix((CByte(79))))))
            Me.radLabel1.Location = New System.Drawing.Point(11, 20)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(181, 49)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Text = "Next patient"
            ' 
            ' dashboardClockCalendarPanel
            ' 
            Me.dashboardClockCalendarPanel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(252))))), (CInt(Fix((CByte(249))))))
            Me.dashboardClockCalendarPanel.Controls.Add(Me.radCalendarDashboard)
            Me.dashboardClockCalendarPanel.Controls.Add(Me.radClock1)
            Me.dashboardClockCalendarPanel.Location = New System.Drawing.Point(930, 87)
            Me.dashboardClockCalendarPanel.Name = "dashboardClockCalendarPanel"
            Me.dashboardClockCalendarPanel.Size = New System.Drawing.Size(413, 303)
            Me.dashboardClockCalendarPanel.TabIndex = 2
            ' 
            ' radCalendarDashboard
            ' 
            Me.radCalendarDashboard.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters
            Me.radCalendarDashboard.Location = New System.Drawing.Point(193, 75)
            Me.radCalendarDashboard.Name = "radCalendarDashboard"
            Me.radCalendarDashboard.ShowFastNavigationButtons = False
            Me.radCalendarDashboard.ShowNavigationButtons = False
            Me.radCalendarDashboard.ShowRowHeaders = True
            Me.radCalendarDashboard.Size = New System.Drawing.Size(197, 180)
            Me.radCalendarDashboard.TabIndex = 1
            Me.radCalendarDashboard.Text = "radCalendar2"
            Me.radCalendarDashboard.ThemeName = "MedicalAppTheme"
            '			Me.radCalendarDashboard.SelectionChanged += New System.EventHandler(Me.radCalendarDashboard_SelectionChanged);
            ' 
            ' radClock1
            ' 
            Me.radClock1.Location = New System.Drawing.Point(20, 75)
            Me.radClock1.Name = "radClock1"
            Me.radClock1.Size = New System.Drawing.Size(134, 135)
            Me.radClock1.TabIndex = 0
            Me.radClock1.Text = "radClock1"
            Me.radClock1.ThemeName = "MedicalAppTheme"
            ' 
            ' radPanelTomorrowAppointments
            ' 
            Me.radPanelTomorrowAppointments.Controls.Add(Me.radLabelFirstAppointmentTomorrow)
            Me.radPanelTomorrowAppointments.Controls.Add(Me.radLabel9)
            Me.radPanelTomorrowAppointments.Controls.Add(Me.radLabelTomorrowAppointmentsCount)
            Me.radPanelTomorrowAppointments.Controls.Add(Me.radLabel4)
            Me.radPanelTomorrowAppointments.Location = New System.Drawing.Point(704, 87)
            Me.radPanelTomorrowAppointments.Name = "radPanelTomorrowAppointments"
            Me.radPanelTomorrowAppointments.Size = New System.Drawing.Size(206, 303)
            Me.radPanelTomorrowAppointments.TabIndex = 1
            Me.radPanelTomorrowAppointments.ThemeName = "MedicalAppTheme"
            '			Me.radPanelTomorrowAppointments.Click += New System.EventHandler(Me.radPanelTomorrowAppointments_Click);
            ' 
            ' radLabelFirstAppointmentTomorrow
            ' 
            Me.radLabelFirstAppointmentTomorrow.BackColor = System.Drawing.Color.Transparent
            Me.radLabelFirstAppointmentTomorrow.Font = New System.Drawing.Font("Segoe UI", 12.25F)
            Me.radLabelFirstAppointmentTomorrow.Location = New System.Drawing.Point(14, 213)
            Me.radLabelFirstAppointmentTomorrow.Name = "radLabelFirstAppointmentTomorrow"
            Me.radLabelFirstAppointmentTomorrow.Size = New System.Drawing.Size(154, 26)
            Me.radLabelFirstAppointmentTomorrow.TabIndex = 1
            Me.radLabelFirstAppointmentTomorrow.Text = "first one at 7:00 AM"
            '			Me.radLabelFirstAppointmentTomorrow.Click += New System.EventHandler(Me.radPanelTomorrowAppointments_Click);
            ' 
            ' radLabel9
            ' 
            Me.radLabel9.BackColor = System.Drawing.Color.Transparent
            Me.radLabel9.Font = New System.Drawing.Font("Segoe UI Light", 15.0F)
            Me.radLabel9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
            Me.radLabel9.Location = New System.Drawing.Point(14, 175)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(128, 31)
            Me.radLabel9.TabIndex = 1
            Me.radLabel9.Text = "appointments"
            '			Me.radLabel9.Click += New System.EventHandler(Me.radPanelTomorrowAppointments_Click);
            ' 
            ' radLabelTomorrowAppointmentsCount
            ' 
            Me.radLabelTomorrowAppointmentsCount.BackColor = System.Drawing.Color.Transparent
            Me.radLabelTomorrowAppointmentsCount.Font = New System.Drawing.Font("Segoe UI Light", 60.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.radLabelTomorrowAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
            Me.radLabelTomorrowAppointmentsCount.Location = New System.Drawing.Point(1, 83)
            Me.radLabelTomorrowAppointmentsCount.Name = "radLabelTomorrowAppointmentsCount"
            Me.radLabelTomorrowAppointmentsCount.Size = New System.Drawing.Size(129, 108)
            Me.radLabelTomorrowAppointmentsCount.TabIndex = 1
            Me.radLabelTomorrowAppointmentsCount.Text = "32"
            Me.radLabelTomorrowAppointmentsCount.UseCompatibleTextRendering = False
            '			Me.radLabelTomorrowAppointmentsCount.Click += New System.EventHandler(Me.radPanelTomorrowAppointments_Click);
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.BackColor = System.Drawing.Color.Transparent
            Me.radLabel4.Font = New System.Drawing.Font("Segoe UI Light", 14.5F)
            Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(11))))), (CInt(Fix((CByte(79))))))
            Me.radLabel4.Location = New System.Drawing.Point(14, 12)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(121, 30)
            Me.radLabel4.TabIndex = 1
            Me.radLabel4.Text = "TOMORROW"
            '			Me.radLabel4.Click += New System.EventHandler(Me.radPanelTomorrowAppointments_Click);
            ' 
            ' radPanelTodaysAppointments
            ' 
            Me.radPanelTodaysAppointments.Controls.Add(Me.radLabel6)
            Me.radPanelTodaysAppointments.Controls.Add(Me.radLabelLastAppointmentToday)
            Me.radPanelTodaysAppointments.Controls.Add(Me.radLabelTodayAppointmentsCount)
            Me.radPanelTodaysAppointments.Controls.Add(Me.radLabel3)
            Me.radPanelTodaysAppointments.Location = New System.Drawing.Point(478, 87)
            Me.radPanelTodaysAppointments.Name = "radPanelTodaysAppointments"
            Me.radPanelTodaysAppointments.Size = New System.Drawing.Size(206, 303)
            Me.radPanelTodaysAppointments.TabIndex = 0
            Me.radPanelTodaysAppointments.ThemeName = "MedicalAppTheme"
            '			Me.radPanelTodaysAppointments.Click += New System.EventHandler(Me.radPanelTodaysAppointments_Click);
            ' 
            ' radLabel6
            ' 
            Me.radLabel6.BackColor = System.Drawing.Color.Transparent
            Me.radLabel6.Font = New System.Drawing.Font("Segoe UI Light", 15.0F)
            Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
            Me.radLabel6.Location = New System.Drawing.Point(14, 174)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(128, 31)
            Me.radLabel6.TabIndex = 1
            Me.radLabel6.Text = "appointments"
            '			Me.radLabel6.Click += New System.EventHandler(Me.radPanelTodaysAppointments_Click);
            ' 
            ' radLabelLastAppointmentToday
            ' 
            Me.radLabelLastAppointmentToday.BackColor = System.Drawing.Color.Transparent
            Me.radLabelLastAppointmentToday.Font = New System.Drawing.Font("Segoe UI", 12.25F)
            Me.radLabelLastAppointmentToday.Location = New System.Drawing.Point(14, 213)
            Me.radLabelLastAppointmentToday.Name = "radLabelLastAppointmentToday"
            Me.radLabelLastAppointmentToday.Size = New System.Drawing.Size(150, 26)
            Me.radLabelLastAppointmentToday.TabIndex = 1
            Me.radLabelLastAppointmentToday.Text = "last one at 5:00 PM"
            '			Me.radLabelLastAppointmentToday.Click += New System.EventHandler(Me.radPanelTodaysAppointments_Click);
            ' 
            ' radLabelTodayAppointmentsCount
            ' 
            Me.radLabelTodayAppointmentsCount.BackColor = System.Drawing.Color.Transparent
            Me.radLabelTodayAppointmentsCount.Font = New System.Drawing.Font("Segoe UI Light", 60.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.radLabelTodayAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
            Me.radLabelTodayAppointmentsCount.Location = New System.Drawing.Point(1, 83)
            Me.radLabelTodayAppointmentsCount.Name = "radLabelTodayAppointmentsCount"
            Me.radLabelTodayAppointmentsCount.Size = New System.Drawing.Size(129, 108)
            Me.radLabelTodayAppointmentsCount.TabIndex = 1
            Me.radLabelTodayAppointmentsCount.Text = "25"
            Me.radLabelTodayAppointmentsCount.UseCompatibleTextRendering = False
            '			Me.radLabelTodayAppointmentsCount.Click += New System.EventHandler(Me.radPanelTodaysAppointments_Click);
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.BackColor = System.Drawing.Color.Transparent
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI Light", 14.5F)
            Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(11))))), (CInt(Fix((CByte(79))))))
            Me.radLabel3.Location = New System.Drawing.Point(14, 12)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(71, 30)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "TODAY"
            '			Me.radLabel3.Click += New System.EventHandler(Me.radPanelTodaysAppointments_Click);
            ' 
            ' radPageViewPageSchedule
            ' 
            Me.radPageViewPageSchedule.Controls.Add(Me.radCalendarSchedule)
            Me.radPageViewPageSchedule.Controls.Add(Me.radButtonNewAppointmentScheduler)
            Me.radPageViewPageSchedule.Controls.Add(Me.radSchedulerNavigator1)
            Me.radPageViewPageSchedule.Controls.Add(Me.radScheduler1)
            Me.radPageViewPageSchedule.ItemSize = New System.Drawing.SizeF(90.0F, 28.0F)
            Me.radPageViewPageSchedule.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPageSchedule.Margin = New System.Windows.Forms.Padding(0)
            Me.radPageViewPageSchedule.Name = "radPageViewPageSchedule"
            Me.radPageViewPageSchedule.Padding = New System.Windows.Forms.Padding(15)
            Me.radPageViewPageSchedule.Size = New System.Drawing.Size(1343, 603)
            Me.radPageViewPageSchedule.Text = "SCHEDULE"
            ' 
            ' radCalendarSchedule
            ' 
            Me.radCalendarSchedule.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters
            Me.radCalendarSchedule.Location = New System.Drawing.Point(1046, 75)
            Me.radCalendarSchedule.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
            Me.radCalendarSchedule.Name = "radCalendarSchedule"
            Me.radCalendarSchedule.SelectedDates.AddRange(New System.DateTime() {New System.DateTime(1900, 1, 1, 0, 0, 0, 0)})
            Me.radCalendarSchedule.ShowRowHeaders = True
            Me.radCalendarSchedule.Size = New System.Drawing.Size(297, 243)
            Me.radCalendarSchedule.TabIndex = 3
            Me.radCalendarSchedule.Text = "radCalendar1"
            Me.radCalendarSchedule.ThemeName = "MedicalAppTheme"
            '			Me.radCalendarSchedule.SelectionChanged += New System.EventHandler(Me.radCalendarSchedule_SelectionChanged);
            ' 
            ' radButtonNewAppointmentScheduler
            ' 
            Me.radButtonNewAppointmentScheduler.Location = New System.Drawing.Point(1046, 15)
            Me.radButtonNewAppointmentScheduler.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
            Me.radButtonNewAppointmentScheduler.Name = "radButtonNewAppointmentScheduler"
            Me.radButtonNewAppointmentScheduler.Size = New System.Drawing.Size(297, 33)
            Me.radButtonNewAppointmentScheduler.TabIndex = 2
            Me.radButtonNewAppointmentScheduler.Text = "New appointment"
            Me.radButtonNewAppointmentScheduler.ThemeName = "MedicalAppTheme"
            '			Me.radButtonNewAppointmentScheduler.Click += New System.EventHandler(Me.newAppointment_Click);
            ' 
            ' radSchedulerNavigator1
            ' 
            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
            Me.radSchedulerNavigator1.DateFormat = "MMMM d, yyyy"
            Me.radSchedulerNavigator1.Location = New System.Drawing.Point(19, 15)
            Me.radSchedulerNavigator1.Margin = New System.Windows.Forms.Padding(0)
            Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
            Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
            ' 
            ' 
            ' 
            Me.radSchedulerNavigator1.RootElement.StretchVertically = False
            Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1007, 77)
            Me.radSchedulerNavigator1.TabIndex = 1
            Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
            Me.radSchedulerNavigator1.ThemeName = "MedicalAppTheme"
            '			Me.radSchedulerNavigator1.DayViewClick += New System.EventHandler(Me.DayViewButton_Click);
            ' 
            ' radScheduler1
            ' 
            Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.MultiDay
            Me.radScheduler1.AllowAppointmentCreateInline = False
            Me.radScheduler1.AllowAppointmentMove = False
            Me.radScheduler1.AllowAppointmentResize = False
            Me.radScheduler1.AllowAppointmentsMultiSelect = True
            Me.radScheduler1.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow
            Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radScheduler1.HeaderFormat = "dddd M\/d"
            Me.radScheduler1.Location = New System.Drawing.Point(19, 100)
            Me.radScheduler1.Margin = New System.Windows.Forms.Padding(0)
            Me.radScheduler1.Name = "radScheduler1"
            schedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            schedulerDailyPrintStyle1.DateEndRange = New System.DateTime(2015, 8, 22, 0, 0, 0, 0)
            schedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            schedulerDailyPrintStyle1.DateStartRange = New System.DateTime(2015, 8, 17, 0, 0, 0, 0)
            schedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0F, System.Drawing.FontStyle.Bold)
            Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
            Me.radScheduler1.Size = New System.Drawing.Size(1007, 488)
            Me.radScheduler1.TabIndex = 0
            Me.radScheduler1.Text = "radScheduler1"
            Me.radScheduler1.ThemeName = "MedicalAppTheme"
            '			Me.radScheduler1.AppointmentDeleted += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerAppointmentEventArgs)(Me.radScheduler1_AppointmentDeleted);
            '			Me.radScheduler1.DataBindingComplete += New System.EventHandler(Me.radScheduler1_DataBindingComplete);
            '			Me.radScheduler1.ContextMenuOpening += New Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(Me.radScheduler1_ContextMenuOpening);
            '			Me.radScheduler1.ActiveViewChanged += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerViewChangedEventArgs)(Me.radScheduler1_ActiveViewChanged);
            '			Me.radScheduler1.AppointmentEditDialogShowing += New System.EventHandler(Of Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs)(Me.radScheduler1_AppointmentEditDialogShowing);
            ' 
            ' radPageViewPageCharts
            ' 
            Me.radPageViewPageCharts.Controls.Add(Me.radPanel2)
            Me.radPageViewPageCharts.Controls.Add(Me.radButtonRegisternewPatientCharts)
            Me.radPageViewPageCharts.Controls.Add(Me.radGridViewPatients)
            Me.radPageViewPageCharts.ItemSize = New System.Drawing.SizeF(77.0F, 28.0F)
            Me.radPageViewPageCharts.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPageCharts.Margin = New System.Windows.Forms.Padding(0)
            Me.radPageViewPageCharts.Name = "radPageViewPageCharts"
            Me.radPageViewPageCharts.Padding = New System.Windows.Forms.Padding(15)
            Me.radPageViewPageCharts.Size = New System.Drawing.Size(1343, 603)
            Me.radPageViewPageCharts.Text = "CHARTS"
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.Controls.Add(Me.radButtonShowInfoCharts)
            Me.radPanel2.Controls.Add(Me.radListControl1)
            Me.radPanel2.Controls.Add(Me.radLabel11)
            Me.radPanel2.Controls.Add(Me.radLabelSelectedPatientAgeGenderCharts)
            Me.radPanel2.Controls.Add(Me.radLabelSelectedPatientNameCharts)
            Me.radPanel2.Controls.Add(Me.radLabelSelectedPatientImageCharts)
            Me.radPanel2.Location = New System.Drawing.Point(1057, 58)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Size = New System.Drawing.Size(286, 536)
            Me.radPanel2.TabIndex = 2
            Me.radPanel2.ThemeName = "MedicalAppTheme"
            ' 
            ' radButtonShowInfoCharts
            ' 
            Me.radButtonShowInfoCharts.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.radButtonShowInfoCharts.Location = New System.Drawing.Point(138, 88)
            Me.radButtonShowInfoCharts.Name = "radButtonShowInfoCharts"
            Me.radButtonShowInfoCharts.Size = New System.Drawing.Size(92, 24)
            Me.radButtonShowInfoCharts.TabIndex = 4
            Me.radButtonShowInfoCharts.Text = "Show info"
            Me.radButtonShowInfoCharts.ThemeName = "MedicalAppTheme"
            '			Me.radButtonShowInfoCharts.Click += New System.EventHandler(Me.radButtonShowInfoCharts_Click);
            ' 
            ' radListControl1
            ' 
            Me.radListControl1.AutoSizeItems = True
            Me.radListControl1.Location = New System.Drawing.Point(13, 156)
            Me.radListControl1.Name = "radListControl1"
            Me.radListControl1.Size = New System.Drawing.Size(263, 366)
            Me.radListControl1.TabIndex = 2
            Me.radListControl1.Text = "radListControl1"
            Me.radListControl1.ThemeName = "MedicalAppTheme"
            ' 
            ' radLabel11
            ' 
            Me.radLabel11.BackColor = System.Drawing.Color.Transparent
            Me.radLabel11.Font = New System.Drawing.Font("Segoe UI", 10.25F)
            Me.radLabel11.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(4))))), (CInt(Fix((CByte(69))))))
            Me.radLabel11.Location = New System.Drawing.Point(13, 128)
            Me.radLabel11.Name = "radLabel11"
            Me.radLabel11.Size = New System.Drawing.Size(90, 22)
            Me.radLabel11.TabIndex = 1
            Me.radLabel11.Text = "CONDITIONS"
            ' 
            ' radLabelSelectedPatientAgeGenderCharts
            ' 
            Me.radLabelSelectedPatientAgeGenderCharts.BackColor = System.Drawing.Color.Transparent
            Me.radLabelSelectedPatientAgeGenderCharts.Font = New System.Drawing.Font("Segoe UI", 10.25F)
            Me.radLabelSelectedPatientAgeGenderCharts.Location = New System.Drawing.Point(135, 52)
            Me.radLabelSelectedPatientAgeGenderCharts.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
            Me.radLabelSelectedPatientAgeGenderCharts.Name = "radLabelSelectedPatientAgeGenderCharts"
            Me.radLabelSelectedPatientAgeGenderCharts.Size = New System.Drawing.Size(82, 22)
            Me.radLabelSelectedPatientAgeGenderCharts.TabIndex = 1
            Me.radLabelSelectedPatientAgeGenderCharts.Text = "28 yo | male"
            ' 
            ' radLabelSelectedPatientNameCharts
            ' 
            Me.radLabelSelectedPatientNameCharts.BackColor = System.Drawing.Color.Transparent
            Me.radLabelSelectedPatientNameCharts.Font = New System.Drawing.Font("Segoe UI", 12.25F)
            Me.radLabelSelectedPatientNameCharts.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(192))))))
            Me.radLabelSelectedPatientNameCharts.Location = New System.Drawing.Point(133, 8)
            Me.radLabelSelectedPatientNameCharts.MaximumSize = New System.Drawing.Size(150, 0)
            Me.radLabelSelectedPatientNameCharts.Name = "radLabelSelectedPatientNameCharts"
            ' 
            ' 
            ' 
            Me.radLabelSelectedPatientNameCharts.RootElement.MaxSize = New System.Drawing.Size(150, 0)
            Me.radLabelSelectedPatientNameCharts.Size = New System.Drawing.Size(78, 26)
            Me.radLabelSelectedPatientNameCharts.TabIndex = 1
            Me.radLabelSelectedPatientNameCharts.Text = "John Doe"
            ' 
            ' radLabelSelectedPatientImageCharts
            ' 
            Me.radLabelSelectedPatientImageCharts.AutoSize = False
            Me.radLabelSelectedPatientImageCharts.BackColor = System.Drawing.Color.Transparent
            Me.radLabelSelectedPatientImageCharts.Image = Resources.no_image
            Me.radLabelSelectedPatientImageCharts.Location = New System.Drawing.Point(13, 8)
            Me.radLabelSelectedPatientImageCharts.Name = "radLabelSelectedPatientImageCharts"
            Me.radLabelSelectedPatientImageCharts.Size = New System.Drawing.Size(114, 114)
            Me.radLabelSelectedPatientImageCharts.TabIndex = 0
            ' 
            ' radButtonRegisternewPatientCharts
            ' 
            Me.radButtonRegisternewPatientCharts.Location = New System.Drawing.Point(1057, 19)
            Me.radButtonRegisternewPatientCharts.Name = "radButtonRegisternewPatientCharts"
            Me.radButtonRegisternewPatientCharts.Size = New System.Drawing.Size(286, 33)
            Me.radButtonRegisternewPatientCharts.TabIndex = 1
            Me.radButtonRegisternewPatientCharts.Text = "Register new patient"
            Me.radButtonRegisternewPatientCharts.ThemeName = "MedicalAppTheme"
            '			Me.radButtonRegisternewPatientCharts.Click += New System.EventHandler(Me.registerNewPatient_Click);
            ' 
            ' radGridViewPatients
            ' 
            Me.radGridViewPatients.Location = New System.Drawing.Point(19, 18)
            ' 
            ' 
            ' 
            Me.radGridViewPatients.MasterTemplate.AllowAddNewRow = False
            Me.radGridViewPatients.MasterTemplate.AllowEditRow = False
            Me.radGridViewPatients.MasterTemplate.AllowSearchRow = True
            Me.radGridViewPatients.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            gridViewDecimalColumn1.DataType = GetType(Integer)
            gridViewDecimalColumn1.FieldName = "Id"
            gridViewDecimalColumn1.HeaderText = "Id"
            gridViewDecimalColumn1.IsAutoGenerated = True
            gridViewDecimalColumn1.Name = "Id"
            gridViewDecimalColumn1.Width = 143
            gridViewTextBoxColumn1.FieldName = "First Name"
            gridViewTextBoxColumn1.HeaderText = "First Name"
            gridViewTextBoxColumn1.IsAutoGenerated = True
            gridViewTextBoxColumn1.Name = "First Name"
            gridViewTextBoxColumn1.Width = 143
            gridViewTextBoxColumn2.FieldName = "Last Name"
            gridViewTextBoxColumn2.HeaderText = "Last Name"
            gridViewTextBoxColumn2.IsAutoGenerated = True
            gridViewTextBoxColumn2.Name = "Last Name"
            gridViewTextBoxColumn2.Width = 143
            gridViewDecimalColumn2.DataType = GetType(Double)
            gridViewDecimalColumn2.FieldName = "Age"
            gridViewDecimalColumn2.HeaderText = "Age"
            gridViewDecimalColumn2.IsAutoGenerated = True
            gridViewDecimalColumn2.Name = "Age"
            gridViewDecimalColumn2.ReadOnly = True
            gridViewDecimalColumn2.Width = 143
            gridViewTextBoxColumn3.FieldName = "Sex"
            gridViewTextBoxColumn3.HeaderText = "Sex"
            gridViewTextBoxColumn3.IsAutoGenerated = True
            gridViewTextBoxColumn3.Name = "Sex"
            gridViewTextBoxColumn3.Width = 143
            gridViewDateTimeColumn1.CustomFormat = ""
            gridViewDateTimeColumn1.FieldName = "Date of Birth"
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            gridViewDateTimeColumn1.FormatString = "{0:d-M-yyyy}"
            gridViewDateTimeColumn1.HeaderText = "Date of Birth"
            gridViewDateTimeColumn1.IsAutoGenerated = True
            gridViewDateTimeColumn1.Name = "Date of Birth"
            gridViewDateTimeColumn1.Width = 143
            gridViewDateTimeColumn2.CustomFormat = ""
            gridViewDateTimeColumn2.FieldName = "Last Visit"
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            gridViewDateTimeColumn2.FormatString = "{0:d-M-yyyy}"
            gridViewDateTimeColumn2.HeaderText = "Last Visit"
            gridViewDateTimeColumn2.IsAutoGenerated = True
            gridViewDateTimeColumn2.Name = "Last Visit"
            gridViewDateTimeColumn2.ReadOnly = True
            gridViewDateTimeColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
            gridViewDateTimeColumn2.Width = 146
            Me.radGridViewPatients.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewDecimalColumn2, gridViewTextBoxColumn3, gridViewDateTimeColumn1, gridViewDateTimeColumn2})
            Me.radGridViewPatients.MasterTemplate.DataSource = Me.patientsBindingSource
            Me.radGridViewPatients.MasterTemplate.EnableAlternatingRowColor = True
            Me.radGridViewPatients.MasterTemplate.EnableFiltering = True
            Me.radGridViewPatients.MasterTemplate.ShowFilteringRow = False
            Me.radGridViewPatients.MasterTemplate.ShowHeaderCellButtons = True
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
            sortDescriptor1.PropertyName = "Last Visit"
            Me.radGridViewPatients.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {sortDescriptor1})
            Me.radGridViewPatients.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridViewPatients.Name = "radGridViewPatients"
            Me.radGridViewPatients.ShowHeaderCellButtons = True
            Me.radGridViewPatients.Size = New System.Drawing.Size(1018, 576)
            Me.radGridViewPatients.TabIndex = 0
            Me.radGridViewPatients.Text = "radGridView1"
            Me.radGridViewPatients.ThemeName = "MedicalAppTheme"
            '			Me.radGridViewPatients.CurrentRowChanged += New Telerik.WinControls.UI.CurrentRowChangedEventHandler(Me.radGridViewPatients_CurrentRowChanged);
            '			Me.radGridViewPatients.CellDoubleClick += New Telerik.WinControls.UI.GridViewCellEventHandler(Me.radGridViewPatients_CellDoubleClick);
            ' 
            ' patientsBindingSource
            ' 
            Me.patientsBindingSource.DataMember = "Patients"
            Me.patientsBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' patientsDataSet
            ' 
            Me.patientsDataSet.DataSetName = "PatientsDataSet"
            Me.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' appointmentsBindingSource
            ' 
            Me.appointmentsBindingSource.DataMember = "Appointments"
            Me.appointmentsBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' appointmentsTableAdapter
            ' 
            Me.appointmentsTableAdapter.ClearBeforeFill = True
            ' 
            ' conceptsBindingSource
            ' 
            Me.conceptsBindingSource.DataMember = "Concepts"
            Me.conceptsBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' conceptsTableAdapter
            ' 
            Me.conceptsTableAdapter.ClearBeforeFill = True
            ' 
            ' encountersBindingSource
            ' 
            Me.encountersBindingSource.DataMember = "Encounters"
            Me.encountersBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' encountersTableAdapter
            ' 
            Me.encountersTableAdapter.ClearBeforeFill = True
            ' 
            ' personImagesBindingSource
            ' 
            Me.personImagesBindingSource.DataMember = "PersonImages"
            Me.personImagesBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' personImagesTableAdapter
            ' 
            Me.personImagesTableAdapter.ClearBeforeFill = True
            ' 
            ' personsBindingSource
            ' 
            Me.personsBindingSource.DataMember = "Persons"
            Me.personsBindingSource.DataSource = Me.patientsDataSet
            ' 
            ' personsTableAdapter
            ' 
            Me.personsTableAdapter.ClearBeforeFill = True
            ' 
            ' patientsTableAdapter
            ' 
            Me.patientsTableAdapter.ClearBeforeFill = True
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1364, 740)
            Me.Controls.Add(Me.radPageView1)
            Me.Controls.Add(Me.mainPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Medical app"
            Me.ThemeName = "MedicalAppTheme"
            '			Me.Load += New System.EventHandler(Me.MainForm_Load);
            CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType(Me.radSplitButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelDoctorImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelButtonsContainer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelButtonsContainer.ResumeLayout(False)
            CType(Me.chartsToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduleToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageView1.ResumeLayout(False)
            Me.radPageViewPageDashboard.ResumeLayout(False)
            Me.radPageViewPageDashboard.PerformLayout()
            CType(Me.radListViewNextPatients, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonNewAppointment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonRegisterNewPatient, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardClockCalendarPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dashboardClockCalendarPanel.ResumeLayout(False)
            Me.dashboardClockCalendarPanel.PerformLayout()
            CType(Me.radCalendarDashboard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radClock1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelTomorrowAppointments, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelTomorrowAppointments.ResumeLayout(False)
            Me.radPanelTomorrowAppointments.PerformLayout()
            CType(Me.radLabelFirstAppointmentTomorrow, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTomorrowAppointmentsCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelTodaysAppointments.ResumeLayout(False)
            Me.radPanelTodaysAppointments.PerformLayout()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTodayAppointmentsCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageViewPageSchedule.ResumeLayout(False)
            Me.radPageViewPageSchedule.PerformLayout()
            CType(Me.radCalendarSchedule, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonNewAppointmentScheduler, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageViewPageCharts.ResumeLayout(False)
            CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            Me.radPanel2.PerformLayout()
            CType(Me.radButtonShowInfoCharts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSelectedPatientAgeGenderCharts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSelectedPatientNameCharts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSelectedPatientImageCharts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonRegisternewPatientCharts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridViewPatients.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridViewPatients, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.patientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.patientsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.conceptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.encountersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.personImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.personsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private mainPanel As Telerik.WinControls.UI.RadPanel
        Private WithEvents radPageView1 As Telerik.WinControls.UI.RadPageView
        Private radPageViewPageDashboard As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPageSchedule As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPageCharts As Telerik.WinControls.UI.RadPageViewPage
        Private WithEvents radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
        Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
        Private WithEvents radButtonNewAppointmentScheduler As Telerik.WinControls.UI.RadButton
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private WithEvents radButtonRegisternewPatientCharts As Telerik.WinControls.UI.RadButton
        Private WithEvents radGridViewPatients As Telerik.WinControls.UI.RadGridView
        Private radPanelButtonsContainer As Telerik.WinControls.UI.RadPanel
        Private radLabelDoctorImage As Telerik.WinControls.UI.RadLabel
        Private WithEvents radSplitButton1 As Telerik.WinControls.UI.RadSplitButton
        Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
        Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
        Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
        Private WithEvents radListViewNextPatients As Telerik.WinControls.UI.RadListView
        Private WithEvents radButtonNewAppointment As Telerik.WinControls.UI.RadButton
        Private WithEvents radButtonRegisterNewPatient As Telerik.WinControls.UI.RadButton
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private dashboardClockCalendarPanel As Telerik.WinControls.UI.RadPanel
        Private WithEvents radPanelTomorrowAppointments As Telerik.WinControls.UI.RadPanel
        Private WithEvents radPanelTodaysAppointments As Telerik.WinControls.UI.RadPanel
        Private WithEvents radCalendarDashboard As Telerik.WinControls.UI.RadCalendar
        Private radClock1 As Telerik.WinControls.UI.RadClock
        Private WithEvents radLabelFirstAppointmentTomorrow As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabel9 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabelTomorrowAppointmentsCount As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabel4 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabelLastAppointmentToday As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabel6 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabelTodayAppointmentsCount As Telerik.WinControls.UI.RadLabel
        Private WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radCalendarSchedule As Telerik.WinControls.UI.RadCalendar
        Private radLabelSelectedPatientAgeGenderCharts As Telerik.WinControls.UI.RadLabel
        Private radLabelSelectedPatientNameCharts As Telerik.WinControls.UI.RadLabel
        Private radLabelSelectedPatientImageCharts As Telerik.WinControls.UI.RadLabel
        Private radListControl1 As Telerik.WinControls.UI.RadListControl
        Private radLabel11 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radButtonShowInfoCharts As Telerik.WinControls.UI.RadButton
        Private WithEvents chartsToggleButton As Telerik.WinControls.UI.RadToggleButton
        Private WithEvents scheduleToggleButton As Telerik.WinControls.UI.RadToggleButton
        Private WithEvents dashboardToggleButton As Telerik.WinControls.UI.RadToggleButton
        Private patientsDataSet As PatientsDataSet
        Private appointmentsBindingSource As System.Windows.Forms.BindingSource
        Private appointmentsTableAdapter As PatientsDataSetTableAdapters.AppointmentsTableAdapter
        Private conceptsBindingSource As System.Windows.Forms.BindingSource
        Private conceptsTableAdapter As PatientsDataSetTableAdapters.ConceptsTableAdapter
        Private encountersBindingSource As System.Windows.Forms.BindingSource
        Private encountersTableAdapter As PatientsDataSetTableAdapters.EncountersTableAdapter
        Private personImagesBindingSource As System.Windows.Forms.BindingSource
        Private personImagesTableAdapter As PatientsDataSetTableAdapters.PersonImagesTableAdapter
        Private personsBindingSource As System.Windows.Forms.BindingSource
        Private personsTableAdapter As PatientsDataSetTableAdapters.PersonsTableAdapter
        Private patientsBindingSource As System.Windows.Forms.BindingSource
        Private patientsTableAdapter As PatientsDataSetTableAdapters.PatientsTableAdapter
    End Class
End Namespace

