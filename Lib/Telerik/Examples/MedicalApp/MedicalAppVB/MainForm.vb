Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Imports MedicalAppCS.Properties

Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Enumerations
Imports System.Globalization

Namespace MedicalAppCS
    Partial Public Class MainForm
        Inherits RadForm
        Public ReadOnly Property CurrentDate() As DateTime
            Get
                Return New DateTime(2015, 6, 17, DateTime.Now.Hour, DateTime.Now.Minute, 0)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.LoadPackageResource("MedicalAppTheme.tssp")
            RadMessageBox.Instance.ThemeName = "MedicalAppTheme"
            Me.SetToggleButtonsStateImages()
            DataSources.PatientsDataSet = Me.patientsDataSet
            AddHandler DataSources.PatientsDataSet.Appointments.AppointmentsRowChanged, AddressOf Appointments_AppointmentsRowChanged
        End Sub

#Region "Main screen"

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.personsTableAdapter.Fill(Me.patientsDataSet.Persons)
            Me.personImagesTableAdapter.Fill(Me.patientsDataSet.PersonImages)
            Me.encountersTableAdapter.Fill(Me.patientsDataSet.Encounters)
            Me.conceptsTableAdapter.Fill(Me.patientsDataSet.Concepts)
            Me.appointmentsTableAdapter.Fill(Me.patientsDataSet.Appointments)
            Me.patientsTableAdapter.Fill(Me.patientsDataSet.Patients)

            Me.SetPageViewPageVisualStyles(Me.radPageViewPageDashboard)
            Me.SetPageViewPageVisualStyles(Me.radPageViewPageSchedule)
            Me.SetPageViewPageVisualStyles(Me.radPageViewPageCharts)
            Me.SetCurrentPageViewPage(Me.radPageViewPageDashboard)
            Me.UpdateSelectedPageData()

            ' Main panel
            Me.FormElement.TitleBar.MaximizeButton.Enabled = False
            Me.FormElement.ImageBorder.BorderThickness = New Padding(0)
            Me.mainPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.radPanelButtonsContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.radSplitButton1.DropDownButtonElement.DropDownMenu.PopupElement.Alignment = ContentAlignment.MiddleRight

            ' Dashboard
            Me.dashboardClockCalendarPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.radCalendarDashboard.FocusedDate = CurrentDate

            ' Schedule
            Me.radCalendarSchedule.FocusedDate = CurrentDate
            Me.CustomizeCurrentSchedulerView()
            Me.radSchedulerNavigator1.TimelineViewButton.Visibility = ElementVisibility.Hidden
            Me.radScheduler1.SchedulerElement.ViewElement.AppointmentMargin = New Padding(0, 0, 0, 1)
            Me.AddSchedulerAppointmentBackgrounds()
            Me.BindScheduler()

            Dim navigationElement As CalendarNavigationElement = Me.radCalendarSchedule.CalendarElement.CalendarNavigationElement
            navigationElement.PreviousButton.Visibility = ElementVisibility.Visible
            navigationElement.NextButton.Visibility = ElementVisibility.Visible
            navigationElement.BackColor = Color.FromArgb(242, 242, 243)
            navigationElement.MinSize = New Size(0, 32)
            navigationElement.Padding = New Padding(3, 6, 3, 6)

            ' Charts
            Me.radGridViewPatients.TableElement.RowHeight = 30
        End Sub

        Private Sub Appointments_AppointmentsRowChanged(ByVal sender As Object, ByVal e As PatientsDataSet.AppointmentsRowChangeEvent)
            Me.AddNextPatients()
            Me.UpdateTodayAndTomorrowLabels()
        End Sub

        Private Sub dashboardToggleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dashboardToggleButton.Click
            Me.ResetToggleButtons(Me.dashboardToggleButton)
            Me.SetCurrentPageViewPage(Me.radPageViewPageDashboard)
        End Sub

        Private Sub scheduleToggleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scheduleToggleButton.Click
            Me.ResetToggleButtons(Me.scheduleToggleButton)
            Me.SetCurrentPageViewPage(Me.radPageViewPageSchedule)
        End Sub

        Private Sub chartsToggleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chartsToggleButton.Click
            Me.ResetToggleButtons(Me.chartsToggleButton)
            Me.SetCurrentPageViewPage(Me.radPageViewPageCharts)
        End Sub

        Private Sub radSplitButton1_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles radSplitButton1.DropDownOpening
            Dim args As RadPopupOpeningEventArgs = TryCast(e, RadPopupOpeningEventArgs)
            args.CustomLocation = New Point(args.CustomLocation.X + Me.radSplitButton1.Width - 20, args.CustomLocation.Y)
        End Sub

        Private Sub radPageView1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radPageView1.SelectedPageChanged
            Me.UpdateSelectedPageData()
        End Sub

        Private Sub UpdateSelectedPageData()
            If Not Me.radPageView1.SelectedPage Is Nothing AndAlso Me.radPageView1.Pages.IndexOf(Me.radPageView1.SelectedPage) < 3 Then
                TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement).ContentArea.BackColor = Color.White
            Else
                TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement).ContentArea.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If

            If Me.radPageView1.SelectedPage Is Me.radPageViewPageDashboard Then
                Me.AddNextPatients()
                Me.UpdateTodayAndTomorrowLabels()
            ElseIf Me.radPageView1.SelectedPage Is Me.radPageViewPageCharts Then
                Me.FillPatientInfo()
            End If
        End Sub

        Private Sub SetPageViewPageVisualStyles(ByVal page As RadPageViewPage)
            TryCast(page.Item, RadPageViewStripItem).ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed
            page.Item.Padding = New Padding(14, 10, 14, 10)
            page.Item.BackColor = Color.FromArgb(36, 24, 58)
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.White, "")
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "Selected")
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseOver")
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseDown")
        End Sub

        Private Sub SetCurrentPageViewPage(ByVal page As RadPageViewPage)
            Me.radPageViewPageDashboard.Item.Visibility = ElementVisibility.Collapsed
            Me.radPageViewPageSchedule.Item.Visibility = ElementVisibility.Collapsed
            Me.radPageViewPageCharts.Item.Visibility = ElementVisibility.Collapsed
            page.Item.Visibility = ElementVisibility.Visible
            Me.radPageView1.SelectedPage = page
        End Sub

        Private Sub SetToggleButtonsStateImages()
            Me.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard, "")
            Me.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "ToggleState=On")
            Me.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "MouseOver")
            Me.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "Pressed")
            Me.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule, "")
            Me.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "ToggleState=On")
            Me.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "MouseOver")
            Me.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "Pressed")
            Me.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts, "")
            Me.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "ToggleState=On")
            Me.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "MouseOver")
            Me.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "Pressed")
        End Sub

        Private Sub ResetToggleButtons(ByVal currentButton As RadToggleButton)
            If Not Me.dashboardToggleButton Is currentButton Then
                Me.dashboardToggleButton.ToggleState = ToggleState.Off
            End If
            If Not Me.scheduleToggleButton Is currentButton Then
                Me.scheduleToggleButton.ToggleState = ToggleState.Off
            End If
            If Not Me.chartsToggleButton Is currentButton Then
                Me.chartsToggleButton.ToggleState = ToggleState.Off
            End If
        End Sub

#End Region

#Region "Dashboard"

        Private Sub radListViewNextPatients_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs) Handles radListViewNextPatients.VisualItemCreating
            e.VisualItem = New PatientsListViewVisualItem()
        End Sub

        Private Sub radListViewNextPatients_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs) Handles radListViewNextPatients.VisualItemFormatting
            TryCast(e.VisualItem, PatientsListViewVisualItem).TopRightElement.Text = (CDate(e.VisualItem.Data("Time"))).ToString("HH:mm")
            Dim itemIndex As Integer = Me.radListViewNextPatients.Items.IndexOf(e.VisualItem.Data)
            Dim padding As Padding
            If itemIndex = 0 Then
                Dim fullName As String = e.VisualItem.Data("Name").ToString()
                If fullName.Length > 17 Then
                    Dim names As String() = fullName.Split(New Char() {" "c})
                    fullName = names(0) & "<br>  " & names(1)
                End If
                e.VisualItem.Text = "<html>" & "<span style=""color:#006DC0;font-size:24pt;font-family:Segoe UI Light;"">  " & fullName & "</span>" & "<br>" & "<span style=""color:#4F4C4C;font-size:13pt;font-family:Segoe UI;"">    " & e.VisualItem.Data("Age") & " yo | " & e.VisualItem.Data("Gender") & "</span>" & "</html>"

                e.VisualItem.BorderTopColor = Color.Transparent
                padding = New Padding(2, 1, 2, 9)
            Else
                If itemIndex = 1 Then
                    padding = New Padding(2, 10, 2, 10)
                Else
                    padding = New Padding(2, 10, 2, 1)
                    e.VisualItem.BorderBottomColor = Color.Transparent
                End If

                e.VisualItem.Font = New Font("Segoe UI Light", 16.0F)
                e.VisualItem.ForeColor = Color.FromArgb(0, 109, 192)
                e.VisualItem.Text = "   " & e.VisualItem.Data("Name").ToString()
            End If

            e.VisualItem.Padding = padding
            e.VisualItem.TextAlignment = ContentAlignment.TopLeft
        End Sub

        Private Sub radListViewNextPatients_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles radListViewNextPatients.DoubleClick
            If Me.radListViewNextPatients.SelectedItem Is Nothing Then
                Return
            End If

            Dim patientId As Integer = CInt(Fix(Me.radListViewNextPatients.SelectedItem("PersonId")))
            Me.CreatePatientEncountersInfoTab(patientId)
        End Sub

        Private Sub registerNewPatient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonRegisterNewPatient.Click, radButtonRegisternewPatientCharts.Click
            Dim addPatientForm As AddPatientForm = New AddPatientForm()
            addPatientForm.StartPosition = FormStartPosition.CenterParent
            addPatientForm.ShowDialog(Me)
        End Sub

        Private Sub newAppointment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonNewAppointment.Click, radButtonNewAppointmentScheduler.Click
            Dim addAppointmentForm As AppointmentForm = New AppointmentForm()
            addAppointmentForm.StartPosition = FormStartPosition.CenterParent
            addAppointmentForm.ShowDialog(Me)

            Me.SetSchedulerAppointmentsBackground()
        End Sub

        Private Sub radPanelTodaysAppointments_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radPanelTodaysAppointments.Click, radLabel6.Click, radLabelLastAppointmentToday.Click, radLabelTodayAppointmentsCount.Click, radLabel3.Click
            Me.SetSchedulerPageActive(CurrentDate)
        End Sub

        Private Sub radPanelTomorrowAppointments_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radPanelTomorrowAppointments.Click, radLabelFirstAppointmentTomorrow.Click, radLabel9.Click, radLabelTomorrowAppointmentsCount.Click, radLabel4.Click
            Me.SetSchedulerPageActive(CurrentDate.AddDays(1))
        End Sub

        Private Sub radCalendarDashboard_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radCalendarDashboard.SelectionChanged
            Me.SetSchedulerPageActive(Me.radCalendarDashboard.SelectedDate)
        End Sub

        Private Sub SetSchedulerPageActive(ByVal [date] As DateTime)
            Me.scheduleToggleButton.ToggleState = ToggleState.On
            Me.scheduleToggleButton_Click(Nothing, Nothing)
            Me.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay
            Me.radScheduler1.FocusedDate = [date]
        End Sub

        Private Sub AddNextPatients()
            'Select incoming three encounters and add them
            Dim appointments As PatientsDataSet.AppointmentsDataTable = Me.patientsDataSet.Appointments
            Dim nextAppointments As DataRow() = appointments.Select("Start >= #" & CurrentDate.ToString(CultureInfo.InvariantCulture) & "#")

            Dim table As DataTable = New DataTable()
            table.Columns.Add("Name", GetType(String))
            table.Columns.Add("Age", GetType(Integer))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("Time", GetType(DateTime))
            table.Columns.Add("PersonId", GetType(Integer))
            table.Columns.Add("PersonImageId", GetType(Integer))

            Dim i As Integer = 0
            Do While i < nextAppointments.Length
                Dim nextAppointment As PatientsDataSet.AppointmentsRow = CType(nextAppointments(i), PatientsDataSet.AppointmentsRow)

                If i > 2 Then
                    ' add only next three items
                    Exit Do
                End If

                Dim person As PatientsDataSet.PersonsRow = Me.patientsDataSet.Persons.FindById(nextAppointment.PersonId)
                Dim today As DateTime = CurrentDate
                Dim age As Integer = today.Year - person.BirthDate.Year
                If person.BirthDate > today.AddYears(-age) Then
                    age -= 1
                End If
                If person.Gender = "M" Then
                    table.Rows.Add(person.FirstName & " " & person.FamilyName, age, "male", nextAppointment.Start, person.Id, person.PersonImageId)
                Else
                    table.Rows.Add(person.FirstName & " " & person.FamilyName, age, "female", nextAppointment.Start, person.Id, person.PersonImageId)
                End If
                i += 1
            Loop

            If nextAppointments.Length <> 0 Then
                Me.radListViewNextPatients.DataSource = table

                i = 0
                Do While i < radListViewNextPatients.Items.Count
                    Dim personImageId As Integer = CInt(Fix(radListViewNextPatients.Items(i)("PersonImageId")))
                    Dim imageSize As Size
                    If i = 0 Then
                        imageSize = New Size(110, 112)
                    Else
                        imageSize = New Size(72, 72)
                    End If

                    Dim bitmap As Bitmap = Me.GetPersonImageById(personImageId, imageSize)

                    Me.radListViewNextPatients.Items(i).Image = bitmap
                    i += 1
                Loop
            End If
        End Sub

        Private Sub UpdateTodayAndTomorrowLabels()
            Dim todaysAndTomorrowsAppointments As DataRow() = Me.patientsDataSet.Appointments.Select("Start > #" & CurrentDate.ToString("d", CultureInfo.InvariantCulture) & "# AND Start < #" & CurrentDate.AddDays(2).ToString("d", CultureInfo.InvariantCulture) & "#")
            Dim todayAppointmentsCount As Integer = 0
            Dim tomorrowAppointmentsCount As Integer = 0
            Dim lastAppointmentTodayDateTime As DateTime = DateTime.MinValue
            Dim firstAppointmentTodayDateTime As DateTime = DateTime.MaxValue
            For Each appointment As PatientsDataSet.AppointmentsRow In todaysAndTomorrowsAppointments
                If appointment.Start.Day = CurrentDate.Day Then
                    todayAppointmentsCount += 1
                    If lastAppointmentTodayDateTime < appointment.Start Then
                        lastAppointmentTodayDateTime = appointment.Start
                    End If
                ElseIf appointment.Start.Day = CurrentDate.AddDays(1).Day Then
                    tomorrowAppointmentsCount += 1
                    If firstAppointmentTodayDateTime > appointment.Start Then
                        firstAppointmentTodayDateTime = appointment.Start
                    End If
                End If
            Next appointment

            Me.radLabelTodayAppointmentsCount.Text = todayAppointmentsCount.ToString()
            Me.radLabelLastAppointmentToday.Text = "last one at " & lastAppointmentTodayDateTime.ToString("H:mm")

            Me.radLabelTomorrowAppointmentsCount.Text = tomorrowAppointmentsCount.ToString()
            Me.radLabelFirstAppointmentTomorrow.Text = "first one at " & firstAppointmentTodayDateTime.ToString("H:mm")
        End Sub

#End Region

#Region "Scheduler"

        Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs) Handles radScheduler1.ActiveViewChanged
            Me.CustomizeCurrentSchedulerView()
        End Sub

        Private Sub radScheduler1_DataBindingComplete(ByVal sender As Object, ByVal e As EventArgs) Handles radScheduler1.DataBindingComplete
            Me.SetSchedulerAppointmentsBackground()
        End Sub

        Private Sub radScheduler1_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs) Handles radScheduler1.AppointmentEditDialogShowing
            e.Cancel = True

            ' if creating new appointment
            Dim addAppointmentForm As AppointmentForm = New AppointmentForm()
            If Not e.Appointment.DataItem Is Nothing Then
                Dim rowView As DataRowView = TryCast(e.Appointment.DataItem, DataRowView)
                addAppointmentForm.Tag = rowView.Row
            Else
                addAppointmentForm.Tag = New Appointment(e.Appointment.Start, e.Appointment.End)
            End If

            addAppointmentForm.StartPosition = FormStartPosition.CenterParent
            addAppointmentForm.ShowDialog(Me)
            Me.SetSchedulerAppointmentsBackground()
        End Sub

        Private Sub radScheduler1_AppointmentDeleted(ByVal sender As Object, ByVal e As SchedulerAppointmentEventArgs) Handles radScheduler1.AppointmentDeleted
            Me.appointmentsTableAdapter.Update(DataSources.PatientsDataSet.Appointments)
        End Sub

        Private Sub DayViewButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radSchedulerNavigator1.DayViewClick
            Me.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay
        End Sub

        Private Sub radCalendarSchedule_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radCalendarSchedule.SelectionChanged
            Me.radScheduler1.FocusedDate = Me.radCalendarSchedule.SelectedDate
        End Sub

        Private Sub BindScheduler()
            Dim dataSource As SchedulerBindingDataSource = New SchedulerBindingDataSource()
            Dim appointmentMappingInfo As AppointmentMappingInfo = New AppointmentMappingInfo()
            appointmentMappingInfo.Start = "Start"
            appointmentMappingInfo.End = "End"
            appointmentMappingInfo.Summary = "Subject"
            appointmentMappingInfo.Description = "Description"
            appointmentMappingInfo.Location = "Location"

            dataSource.EventProvider.Mapping = appointmentMappingInfo
            dataSource.EventProvider.DataSource = Me.appointmentsBindingSource

            Me.radScheduler1.DataSource = dataSource
        End Sub

        Private Sub CustomizeCurrentSchedulerView()
            Me.radScheduler1.FocusedDate = CurrentDate
            Dim dayViewBase As SchedulerDayViewBase = Nothing
            If Me.radScheduler1.ActiveViewType = SchedulerViewType.Day Then
                dayViewBase = Me.radScheduler1.GetDayView()
            ElseIf Me.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay Then
                dayViewBase = Me.radScheduler1.GetMultiDayView()
            ElseIf Me.radScheduler1.ActiveViewType = SchedulerViewType.Week Then
                dayViewBase = Me.radScheduler1.GetWeekView()
            End If

            If Not dayViewBase Is Nothing Then
                dayViewBase.RulerFormatStrings.HoursFormatString = "HH"
                dayViewBase.RulerFormatStrings.MinutesFormatString = ":mm"
                dayViewBase.RulerStartScale = 7
                dayViewBase.RulerEndScale = 20
                dayViewBase.RulerWidth = 55
                dayViewBase.RangeFactor = ScaleRange.QuarterHour
            End If
        End Sub

        Private Sub AddSchedulerAppointmentBackgrounds()
            Me.radScheduler1.Backgrounds.Clear()
            Me.AddSchedulerAppointmentbacroundInfo(1, "Purple", Color.FromArgb(218, 219, 255))
            Me.AddSchedulerAppointmentbacroundInfo(2, "Yellow", Color.FromArgb(255, 252, 223))
            Me.AddSchedulerAppointmentbacroundInfo(3, "Red", Color.FromArgb(252, 218, 202))
            Me.AddSchedulerAppointmentbacroundInfo(4, "Green", Color.FromArgb(216, 245, 179))
        End Sub

        Private Sub AddSchedulerAppointmentbacroundInfo(ByVal id As Integer, ByVal name As String, ByVal backColor As Color)
            Dim backInfo As AppointmentBackgroundInfo = New AppointmentBackgroundInfo(id, name, backColor, backColor)
            backInfo.ForeColor = Color.Black
            backInfo.ShadowStyle = ShadowStyles.Solid
            backInfo.ShadowWidth = 0
            backInfo.BorderBoxStyle = BorderBoxStyle.SingleBorder
            backInfo.BorderColor = Color.FromArgb(198, 202, 185)
            backInfo.BorderGradientStyle = GradientStyles.Solid
            backInfo.DateTimeColor = Me.radScheduler1.SchedulerElement.DefaultDateTimeTitleColor
            backInfo.DateTimeFont = Me.radScheduler1.SchedulerElement.DefaultDateTimeTitleFont
            Me.radScheduler1.Backgrounds.Add(backInfo)
        End Sub

        Private Sub SetSchedulerAppointmentsBackground()
            Dim colorIndex As Integer = 1
            For Each appointment As IEvent In Me.radScheduler1.Appointments
                appointment.BackgroundId = colorIndex
                colorIndex += 1
                If Me.radScheduler1.Backgrounds.Count < colorIndex Then
                    colorIndex = 1
                End If
            Next appointment
        End Sub

#End Region

#Region "Charts"

        Private Sub radGridViewPatients_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs) Handles radGridViewPatients.CurrentRowChanged
            Me.FillPatientInfo()
        End Sub

        Private Sub radGridViewPatients_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles radGridViewPatients.CellDoubleClick
            If TypeOf e.Row Is GridViewDataRowInfo Then
                Dim currentRow As GridViewRowInfo = Me.radGridViewPatients.CurrentRow
                If currentRow Is Nothing Then
                    Return
                End If

                Me.CreatePatientEncountersInfoTab(CInt(Fix(currentRow.Cells("Id").Value)))
            End If
        End Sub

        Private Sub FillPatientInfo()
            Dim currentRow As GridViewRowInfo = Me.radGridViewPatients.CurrentRow
            If currentRow Is Nothing Then
                Return
            End If

            Me.radLabelSelectedPatientNameCharts.Text = currentRow.Cells("First Name").Value.ToString() & " " & currentRow.Cells("Last Name").Value.ToString()
            If currentRow.Cells("Sex").Value.ToString() = "M" Then
                Me.radLabelSelectedPatientAgeGenderCharts.Text = String.Format("{0} yo | {1}", currentRow.Cells("Age").Value.ToString(), ("male"))
            Else
                Me.radLabelSelectedPatientAgeGenderCharts.Text = String.Format("{0} yo | {1}", currentRow.Cells("Age").Value.ToString(), ("female"))
            End If
            Dim personId As Integer = CInt(Fix(currentRow.Cells("Id").Value))
            Dim person As PatientsDataSet.PersonsRow = Me.patientsDataSet.Persons.FindById(personId)
            Dim personImageId As Integer = -1
            If Not person("PersonImageId") Is DBNull.Value Then
                personImageId = person.PersonImageId
            End If
            Dim bitmap As Bitmap = Me.GetPersonImageById(personImageId, New Size(114, 114))
            Me.radLabelSelectedPatientImageCharts.Image = bitmap

            Me.FillSelectedPersonConditions(personId)
        End Sub

        Private Sub radButtonShowInfoCharts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonShowInfoCharts.Click
            Dim currentRow As GridViewRowInfo = Me.radGridViewPatients.CurrentRow
            If currentRow Is Nothing Then
                Return
            End If

            Me.CreatePatientEncountersInfoTab(CInt(Fix(currentRow.Cells("Id").Value)))
        End Sub

        Private Sub CreatePatientEncountersInfoTab(ByVal personId As Integer)
            Dim person As PatientsDataSet.PersonsRow = Me.patientsDataSet.Persons.FindById(personId)
            If person Is Nothing Then
                Return
            End If

            Dim patientEncountersPage As RadPageViewPage = New RadPageViewPage()
            Dim patientEncounters As PatientEncounters = New PatientEncounters()
            patientEncounters.Tag = personId
            patientEncountersPage.Text = person.FirstName.ToUpper() & " " & person.FamilyName.ToUpper()
            patientEncountersPage.Controls.Add(patientEncounters)
            Me.radPageView1.Pages.Add(patientEncountersPage)
            Me.radPageView1.SelectedPage = patientEncountersPage
        End Sub

        Private Sub FillSelectedPersonConditions(ByVal personId As Integer)
            Me.radListControl1.Items.Clear()
            Dim results As DataRow() = Me.patientsDataSet.Encounters.Select("PersonId = " & personId)
            For Each row As DataRow In results
                Dim primaryId As Integer
                If Integer.TryParse(row("PrimaryDiagnosisId").ToString(), primaryId) Then
                    Dim concept As PatientsDataSet.ConceptsRow = Me.patientsDataSet.Concepts.FindById(primaryId)
                    Dim item As RadListDataItem = New RadListDataItem(concept.Name)
                    item.TextWrap = True
                    Me.radListControl1.Items.Add(item)
                End If

                Dim secondaryId As Integer
                If Integer.TryParse(row("SecondaryDiagnosisId").ToString(), secondaryId) Then
                    Dim concept As PatientsDataSet.ConceptsRow = Me.patientsDataSet.Concepts.FindById(secondaryId)
                    Dim item As RadListDataItem = New RadListDataItem(concept.Name)
                    item.TextWrap = True
                    Me.radListControl1.Items.Add(item)
                End If
            Next row
        End Sub

#End Region

        Private Function GetPersonImageById(ByVal personImageId As Integer, ByVal size As Size) As Bitmap
            Dim personImage As PatientsDataSet.PersonImagesRow = Me.patientsDataSet.PersonImages.FindById(personImageId)
            Dim image As Image
            If Not personImage Is Nothing AndAlso Not personImage("Picture") Is DBNull.Value Then
                Using ms As MemoryStream = New MemoryStream(personImage.Picture)
                    image = image.FromStream(ms)
                End Using
            Else
                image = Resources.no_image
            End If

            Dim bitmap As Bitmap = New Bitmap(image, size)
            Return bitmap
        End Function

        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Const CS_DROPSHADOW As Integer = &H20000
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            End Get
        End Property

        Protected Overrides Function InitializeFormBehavior() As FormControlBehavior
            Return New MyFormBehavior(Me, True)
        End Function

        Private Sub radScheduler1_ContextMenuOpening(ByVal sender As Object, ByVal e As SchedulerContextMenuOpeningEventArgs) Handles radScheduler1.ContextMenuOpening
            e.Menu.Items.RemoveAt(2)
        End Sub
    End Class

    Public Class MyFormBehavior
        Inherits RadFormBehavior
        Public Sub New(ByVal treeHandler As IComponentTreeHandler, ByVal shouldCreateChildren As Boolean)
            MyBase.New(treeHandler, shouldCreateChildren)
        End Sub

        Public Overrides ReadOnly Property BorderWidth() As Padding
            Get
                Return New Padding(1)
            End Get
        End Property
    End Class

    Public Class PatientsListViewVisualItem
        Inherits SimpleListViewVisualItem
        Private topRightElement_Renamed As LightVisualElement

        Public ReadOnly Property TopRightElement() As LightVisualElement
            Get
                Return Me.topRightElement_Renamed
            End Get
        End Property

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(SimpleListViewVisualItem)
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.topRightElement_Renamed = New LightVisualElement()
            Me.topRightElement_Renamed.StretchHorizontally = False
            Me.topRightElement_Renamed.StretchVertically = False
            Me.topRightElement_Renamed.DrawFill = True
            Me.topRightElement_Renamed.NumberOfColors = 1
            Me.topRightElement_Renamed.BackColor = Color.FromArgb(27, 4, 69)
            Me.topRightElement_Renamed.ForeColor = Color.White
            Me.topRightElement_Renamed.Font = New Font("Segoe UI Semibold", 11.0F)
            Me.topRightElement_Renamed.Alignment = ContentAlignment.TopRight
            Me.topRightElement_Renamed.Padding = New Padding(2)

            Me.Children.Add(Me.topRightElement_Renamed)
        End Sub
    End Class
End Namespace