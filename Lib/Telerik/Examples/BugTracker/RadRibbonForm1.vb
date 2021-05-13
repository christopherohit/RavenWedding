Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking
Imports System.ComponentModel


Namespace BugTracker
    Partial Public Class RadRibbonForm1
        Inherits Telerik.WinControls.UI.RadRibbonForm
#Region "Fields"
        Private dataSet As DataSet
#End Region

#Region "Enumerators"
        Private Enum Status
            InProgress
            Done
            ReadyForTest
            Deleted
            NotDone
        End Enum

        Private Enum Priority
            Low
            High
            Blocking
        End Enum

        Private Enum Type
            Bug
            Feature
        End Enum
#End Region

#Region "Constructor"

        Public Sub New()
            InitializeComponent()

            'the following function fills the source.xml and XMLSchema.xsd files with sample data
            'FillData()

            CustomizeRibbon()
            FillDataSet()
            SetupProjectTreeView()
            SetupBugsGrid()
            SetupFeaturesGrid()
            BindControls()
            SubscribeToEvents()
            ReadOnlyControls(True)
            For Each w As DocumentWindow In Me.RadDock1.DockWindows.DocumentWindows
                w.CloseAction = DockWindowCloseAction.Hide
            Next

            ThemeResolutionService.ApplicationThemeName = Me.telerikMetroTheme1.ThemeName
        End Sub

#End Region

#Region "Methods"

        Private Sub ReadOnlyControls(ByVal [readOnly] As Boolean)
            titleTextBox.[ReadOnly] = [readOnly]
            idSpinEditor.[ReadOnly] = [readOnly]
            descriptionTextBox.[ReadOnly] = [readOnly]
            stepsToReproduceTextBox.[ReadOnly] = [readOnly]
            idSpinEditor.ShowUpDownButtons = Not [readOnly]

            dateDateTimePicker.DateTimePickerElement.TextBoxElement.TextBoxItem.[ReadOnly] = [readOnly]
            Dim arrowButton As RadArrowButtonElement = dateDateTimePicker.DateTimePickerElement.ArrowButton
            arrowButton.Visibility = If([readOnly], Telerik.WinControls.ElementVisibility.Collapsed, Telerik.WinControls.ElementVisibility.Visible)

            priorityDropDownList.DropDownListElement.ArrowButton.Visibility = If([readOnly], Telerik.WinControls.ElementVisibility.Collapsed, Telerik.WinControls.ElementVisibility.Visible)
            priorityDropDownList.DropDownListElement.TextBox.TextBoxItem.[ReadOnly] = [readOnly]

            statusDropDownList.DropDownListElement.ArrowButton.Visibility = If([readOnly], Telerik.WinControls.ElementVisibility.Collapsed, Telerik.WinControls.ElementVisibility.Visible)
            statusDropDownList.DropDownListElement.TextBox.TextBoxItem.[ReadOnly] = [readOnly]

            ownerDropDownList.DropDownListElement.ArrowButton.Visibility = If([readOnly], Telerik.WinControls.ElementVisibility.Collapsed, Telerik.WinControls.ElementVisibility.Visible)
            ownerDropDownList.DropDownListElement.TextBox.TextBoxItem.[ReadOnly] = [readOnly]
        End Sub

        Private Sub BindControls()
            titleTextBox.DataBindings.Add(New Binding("Text", dataSet.Tables("Issue"), "Title"))
            idSpinEditor.DataBindings.Add(New Binding("Value", dataSet.Tables("Issue"), "Id"))
            dateDateTimePicker.DataBindings.Add(New Binding("Value", dataSet.Tables("Issue"), "Date"))
            descriptionTextBox.DataBindings.Add(New Binding("Text", dataSet.Tables("Issue"), "Description"))
            stepsToReproduceTextBox.DataBindings.Add(New Binding("Text", dataSet.Tables("Issue"), "StepsToReproduce"))

            Dim priorityDataSource As New BindingList(Of Priority)
            priorityDataSource.Add(Priority.Low)
            priorityDataSource.Add(Priority.High)
            priorityDataSource.Add(Priority.Blocking)

            priorityDropDownList.DataSource = priorityDataSource
            priorityDropDownList.DataBindings.Add(New Binding("SelectedValue", dataSet.Tables("Issue"), "Priority", False, DataSourceUpdateMode.OnPropertyChanged))
            priorityDropDownList.DataBindings.Add(New Binding("SelectedIndex", dataSet.Tables("Issue"), "Priority", False, DataSourceUpdateMode.OnPropertyChanged))

            Dim statusDataSource As New BindingList(Of Status)
            statusDataSource.Add(Status.InProgress)
            statusDataSource.Add(Status.Done)
            statusDataSource.Add(Status.ReadyForTest)
            statusDataSource.Add(Status.Deleted)
            statusDataSource.Add(Status.NotDone)
            statusDropDownList.DataSource = statusDataSource
            statusDropDownList.DataBindings.Add(New Binding("SelectedValue", dataSet.Tables("Issue"), "Status"))
            statusDropDownList.DataBindings.Add(New Binding("SelectedIndex", dataSet.Tables("Issue"), "Status"))

            ownerDropDownList.DataSource = dataSet.Tables("User")
            ownerDropDownList.DisplayMember = "Name"
            ownerDropDownList.ValueMember = "Id"
            ownerDropDownList.DataBindings.Add(New Binding("SelectedValue", dataSet.Tables("Issue"), "UserId"))
        End Sub

        Private Sub SubscribeToEvents()
            AddHandler bugsGrid.CurrentRowChanged, AddressOf rowChanged_CurrentRowChanged
            AddHandler featuresGrid.CurrentRowChanged, AddressOf rowChanged_CurrentRowChanged
            AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged

            AddHandler titleTextBox.KeyDown, AddressOf Controls_KeyDown
            AddHandler idSpinEditor.SpinElement.KeyDown, AddressOf Controls_KeyDown
            AddHandler dateDateTimePicker.KeyDown, AddressOf Controls_KeyDown
            AddHandler descriptionTextBox.KeyDown, AddressOf Controls_KeyDown
            AddHandler stepsToReproduceTextBox.KeyDown, AddressOf Controls_KeyDown
            AddHandler priorityDropDownList.KeyDown, AddressOf Controls_KeyDown
            AddHandler statusDropDownList.KeyDown, AddressOf Controls_KeyDown
            AddHandler ownerDropDownList.KeyDown, AddressOf Controls_KeyDown

            AddHandler office2010BlackButton.Click, AddressOf changeThemes
            AddHandler office2010BlueButton.Click, AddressOf changeThemes
            AddHandler office2010SilverButton.Click, AddressOf changeThemes
            AddHandler telerikButton.Click, AddressOf changeThemes
            AddHandler controlDefaultButton.Click, AddressOf changeThemes

            AddHandler dateAscendingMenuItem.Click, AddressOf sortGrids
            AddHandler ownerAscendingMenuItem.Click, AddressOf sortGrids
            AddHandler statusAscendingMenuItem.Click, AddressOf sortGrids
            AddHandler dateDescendingMenuItem.Click, AddressOf sortGrids
            AddHandler ownerDescendingMenuItem.Click, AddressOf sortGrids
            AddHandler statusDescendingMenuItem.Click, AddressOf sortGrids
            AddHandler sortNoneMenuItem.Click, AddressOf sortGrids

            AddHandler projectsButton.Click, AddressOf panelsChange_Click
            AddHandler detailsButton.Click, AddressOf panelsChange_Click
            AddHandler bugsButton.Click, AddressOf panelsChange_Click
            AddHandler featuresButton.Click, AddressOf panelsChange_Click

            AddHandler newCheckBox.ToggleStateChanged, AddressOf filter_grid
            AddHandler unassignedCheckBox.ToggleStateChanged, AddressOf filter_grid
            AddHandler openCheckBox.ToggleStateChanged, AddressOf filter_grid
            AddHandler readyForTestCheckBox.ToggleStateChanged, AddressOf filter_grid
            AddHandler doneCheckBox.ToggleStateChanged, AddressOf filter_grid

            AddHandler loadDatabaseMenuItem.Click, AddressOf loadDatabaseButton_Click
            AddHandler addMenuItem.Click, AddressOf addButton_Click
            AddHandler removeMenuItem.Click, AddressOf removeButton_Click
            AddHandler editMenuItem.Click, AddressOf editButton_Click
            AddHandler aboutMenuItem.Click, AddressOf aboutMenuItem_Click
            AddHandler exitMenuItem.Click, AddressOf exitMenuItem_Click
        End Sub

        Private Sub SetupProjectTreeView()
            projectsTreeView.DataSource = dataSet.Tables("Project")
            projectsTreeView.DisplayMember = "Name"
            projectsTreeView.ValueMember = "Id"
            projectsTreeView.ParentMember = "ParentId"
            projectsTreeView.ChildMember = "Id"
            AddHandler projectsTreeView.SelectedNodeChanged, AddressOf projectsTreeView_SelectedNodeChanged
            projectsTreeView.SelectedNode = projectsTreeView.Nodes(0)
        End Sub

        Private Sub SetupBugsGrid()
            bugsGrid.EnableFiltering = True
            bugsGrid.MasterTemplate.ShowFilteringRow = False
            bugsGrid.AllowAddNewRow = False
            bugsGrid.DataSource = dataSet.Tables("Issue")
            bugsGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            bugsGrid.MasterTemplate.SelectLastAddedRow = True
            bugsGrid.Columns("ProjectId").IsVisible = False
            bugsGrid.Columns("Type").IsVisible = False
            bugsGrid.Columns("Description").IsVisible = False
            bugsGrid.Columns("StepsToReproduce").IsVisible = False
            bugsGrid.Columns("UserId").IsVisible = False
            CType(bugsGrid.Columns("Date"), GridViewDateTimeColumn).FormatString = "{0: dd/M/yyyy}"

            Dim comboCol As GridViewComboBoxColumn = New GridViewComboBoxColumn()
            comboCol.Name = "Owner"
            comboCol.HeaderText = "Owner"
            comboCol.DataSource = dataSet.Tables("User")
            comboCol.DisplayMember = "Name"
            comboCol.ValueMember = "Id"
            comboCol.FieldName = "UserId"
            bugsGrid.Columns.Add(comboCol)

            comboCol.MaxWidth = 70
            bugsGrid.Columns("Id").MaxWidth = 20
            bugsGrid.Columns("Status").MaxWidth = 80
            bugsGrid.Columns("Date").MaxWidth = 70
            bugsGrid.Columns("Priority").MaxWidth = 60
            bugsGrid.Columns("Title").BestFit()

            bugsGrid.FilterDescriptors.Clear()
            Dim filterByBugs As FilterDescriptor = New FilterDescriptor()
            filterByBugs.PropertyName = "Type"
            filterByBugs.Operator = FilterOperator.IsEqualTo
            filterByBugs.Value = Type.Bug
            Me.bugsGrid.FilterDescriptors.Add(filterByBugs)

        End Sub

        Private Sub SetupFeaturesGrid()
            featuresGrid.EnableFiltering = True
            featuresGrid.MasterTemplate.ShowFilteringRow = False
            featuresGrid.AllowAddNewRow = False
            featuresGrid.DataSource = dataSet.Tables("Issue")
            featuresGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            featuresGrid.MasterTemplate.SelectLastAddedRow = True
            featuresGrid.Columns("ProjectId").IsVisible = False
            featuresGrid.Columns("Type").IsVisible = False
            featuresGrid.Columns("Description").IsVisible = False
            featuresGrid.Columns("StepsToReproduce").IsVisible = False
            featuresGrid.Columns("UserId").IsVisible = False
            CType(featuresGrid.Columns("Date"), GridViewDateTimeColumn).FormatString = "{0: dd/M/yyyy}"

            Dim comboCol As GridViewComboBoxColumn = New GridViewComboBoxColumn()
            comboCol.Name = "Owner"
            comboCol.HeaderText = "Owner"
            comboCol.DataSource = dataSet.Tables("User")
            comboCol.DisplayMember = "Name"
            comboCol.ValueMember = "Id"
            comboCol.FieldName = "UserId"
            featuresGrid.Columns.Add(comboCol)

            comboCol.MaxWidth = 70
            featuresGrid.Columns("Id").MaxWidth = 20
            featuresGrid.Columns("Status").MaxWidth = 80
            featuresGrid.Columns("Date").MaxWidth = 70
            featuresGrid.Columns("Priority").MaxWidth = 60
            featuresGrid.Columns("Title").BestFit()

            featuresGrid.FilterDescriptors.Clear()
            Dim filterByFeature As FilterDescriptor = New FilterDescriptor()
            filterByFeature.PropertyName = "Type"
            filterByFeature.Operator = FilterOperator.IsEqualTo
            filterByFeature.Value = Type.Feature
            Me.featuresGrid.FilterDescriptors.Add(filterByFeature)

        End Sub

        Private Sub CustomizeRibbon()
            radRibbonBar1.RibbonBarElement.ApplicationMenuRightColumnWidth = 0
            radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            RibbonBar.ExitButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            radRibbonBar1.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Hidden
            radRibbonBar1.RibbonBarElement.ApplicationButtonElement.Image = Resources.bug_logo
        End Sub

        Private Sub FillDataSet()
            dataSet = New DataSet()
            dataSet.ReadXmlSchema("..\XMLSchema.xsd")
            dataSet.ReadXml("..\source.xml")
        End Sub

        Private Sub FillData()
            Dim user As DataTable = New DataTable("User")
            Dim project As DataTable = New DataTable("Project")
            Dim issue As DataTable = New DataTable("Issue")

            dataSet = New DataSet()
            dataSet.Tables.Add(user)
            dataSet.Tables.Add(project)
            dataSet.Tables.Add(issue)

            user.Columns.Add("Id", GetType(Integer))
            user.Columns.Add("Name", GetType(String))

            user.Rows.Add(1, "")
            user.Rows.Add(2, "Charlie")
            user.Rows.Add(3, "Brandon")
            user.Rows.Add(4, "Dean")
            user.Rows.Add(5, "George")

            project.Columns.Add("Id", GetType(Integer))
            project.Columns.Add("ParentId", GetType(Integer))
            project.Columns.Add("Name", GetType(String))

            project.Rows.Add(0, DBNull.Value, "All")
            project.Rows.Add(1, 0, "Controls Team")
            project.Rows.Add(2, 0, "Input Controls Team")
            project.Rows.Add(3, 0, "Examples Team")
            project.Rows.Add(4, 0, "Themes Team")

            issue.Columns.Add("Id", GetType(Integer))
            issue.Columns.Add("Title", GetType(String))
            issue.Columns.Add("Description", GetType(String))
            issue.Columns.Add("StepsToReproduce", GetType(String))
            issue.Columns.Add("Status", GetType(Status))
            issue.Columns.Add("Date", GetType(DateTime))
            issue.Columns.Add("Priority", GetType(Priority))
            issue.Columns.Add("ProjectId", GetType(Integer))
            issue.Columns.Add("Type", GetType(Type))
            issue.Columns.Add("UserId", GetType(Integer))

            'Controls team
            issue.Rows.Add(1, "RadGridView databinding issue", "RadGridView does not display columns from dataset", "Bind the grid to a dataset with tables", Status.NotDone, DateTime.Now.AddDays(-1), _
             Priority.Blocking, 1, Type.Bug, Nothing)
            issue.Rows.Add(3, "RadGridView save/load layout issue", "RadGridView does not save the columns correctly", "Non-visible columns are also being saved", Status.ReadyForTest, DateTime.Now.AddDays(-2), _
             Priority.High, 1, Type.Bug, 2)
            issue.Rows.Add(4, "RadDropDownList add functionality for multiselect", "Add functionality to RadDropDownList to support multiselect", "", Status.NotDone, DateTime.Now, _
             Priority.High, 1, Type.Feature, Nothing)
            issue.Rows.Add(5, "RadCalendar add month picker functionality", "Add functionality to RadCalendar to support month selection", "", Status.Done, DateTime.Now.AddDays(-3), _
             Priority.High, 1, Type.Feature, 4)

            'Navigation team
            issue.Rows.Add(6, "RadTextBox focus issue", "The Focus() method of the control does not work", "Call radTextBox1.Focus()", Status.NotDone, DateTime.Now, _
             Priority.High, 2, Type.Bug, 5)
            issue.Rows.Add(7, "RadTextBox BackColor property is not taken into cosideration", "The control backcolor property is not taken into consideration", "Try to set a backcolor through the control BackColor property", Status.Done, New DateTime(2011, 5, 3), _
             Priority.High, 2, Type.Feature, 2)
            issue.Rows.Add(8, "RadMaskEditBox add phone mask", "Add new mask to support phone number format", "", Status.Done, DateTime.Now, _
             Priority.High, 2, Type.Feature, 3)
            issue.Rows.Add(9, "RadDateTimePicker add month and year picker functionality", "Add month and year picker modes", "", Status.InProgress, DateTime.Now.AddDays(-4), _
             Priority.High, 2, Type.Feature, 4)

            'Examples team
            issue.Rows.Add(10, "RadTreeView demo appearance glitches", "The node borders appear in double size", "Open the application from Demo > RadTreeView > First Look", Status.Done, DateTime.Now.AddDays(-5), _
             Priority.High, 3, Type.Bug, 4)
            issue.Rows.Add(11, "RadDateTimePicker demo exeption", "The application in Demo > RadDateTimePicker throws an exception in multiselect mode", "Open the demo, select the multiselect option, expand the drop down and click on a date", Status.ReadyForTest, New DateTime(2011, 3, 22), _
             Priority.High, 3, Type.Bug, 5)
            issue.Rows.Add(12, "RadGridView localization example spelling mistake", "Open Demo > RadGridView > Localization", "The word 'work' is misspeled", Status.Done, DateTime.Now.AddDays(-6), _
             Priority.High, 3, Type.Bug, 2)
            issue.Rows.Add(13, "Create new application for to demo POS", "Create sample POS application", "", Status.InProgress, DateTime.Now.AddDays(-7), _
             Priority.High, 3, Type.Feature, 1)

            'Themes team
            issue.Rows.Add(14, "RadGridView layout issue", "RadGridView shows double border", "Open bound RadGridView and observe the top border with ControlDefault theme", Status.NotDone, DateTime.Now.AddDays(-8), _
             Priority.Low, 1, Type.Bug, Nothing)
            issue.Rows.Add(15, "RadDropDownList items font size is incorrect", "The font size is 9.5 and it should be 8.25", "Open the dropdown with some items loaded and apply the Windows7 theme", Status.ReadyForTest, DateTime.Now.AddDays(-9), _
             Priority.Blocking, 4, Type.Bug, 3)
            issue.Rows.Add(16, "RadCalendar displays SpecialDays incorrect", "SpecialDays size and color is incorrect", "Load the Office2010Blue theme and observe the SpecialDays appearance.", Status.ReadyForTest, DateTime.Now.AddDays(-10), _
             Priority.High, 4, Type.Bug, 1)
            issue.Rows.Add(17, "RadProgreeBar shows no border", "RadProgressBar border is missing", "Load progress bar with Office2010Black theme", Status.InProgress, DateTime.Now.AddDays(-11), _
             Priority.High, 4, Type.Bug, 1)
            issue.Rows.Add(18, "Create new Telerik theme", "The new theme should be in metro style", "", Status.ReadyForTest, DateTime.Now, _
             Priority.High, 4, Type.Feature, 2)
            dataSet.WriteXml("..\source.xml")
            dataSet.WriteXmlSchema("..\XMLSchema.xsd")

        End Sub

        Private Function ConvertToStatus(ByVal value As Object) As Nullable(Of Status)
            If TypeOf value Is Status Then
                Return CType(value, Status)
            End If

            Return Nothing
        End Function


#End Region

#Region "Events"

        Private Sub radDock1_ActiveWindowChanged(sender As System.Object, e As Telerik.WinControls.UI.Docking.DockWindowEventArgs)
            'reset the currency manager position in order to update the controls in details tab
            If e.DockWindow IsNot detailsToolWindow Then
                Dim currentGrid As RadGridView = DirectCast(IIf(e.DockWindow Is bugDocumentWindow, bugsGrid, featuresGrid), RadGridView)
                Dim mgr As CurrencyManager = DirectCast(currentGrid.MasterTemplate.ListSource, ICurrencyManagerProvider).CurrencyManager
                If mgr Is Nothing Then
                    Exit Sub
                End If
                Dim savePos As Integer = mgr.Position
                mgr.Position = If(mgr.Position = mgr.List.Count - 1, Integer.MinValue, Integer.MaxValue)
                mgr.Position = savePos
                currentGrid.ChildRows(0).IsSelected = True
                currentGrid.ChildRows(0).IsCurrent = True
            End If
        End Sub

        Private Sub filter_grid(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Dim checkBox As RadCheckBoxElement = TryCast(sender, RadCheckBoxElement)
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Dim filter As FilterDescriptor = New FilterDescriptor()

                Select Case checkBox.Text
                    Case "Open"
                        filter.Operator = FilterOperator.IsEqualTo
                        filter.PropertyName = "Status"
                        filter.Value = Status.NotDone
                    Case "Ready For Test"
                        filter.Operator = FilterOperator.IsEqualTo
                        filter.PropertyName = "Status"
                        filter.Value = Status.ReadyForTest
                    Case "Done"
                        filter.Operator = FilterOperator.IsEqualTo
                        filter.PropertyName = "Status"
                        filter.Value = Status.Done
                    Case "Unassigned"
                        filter.Operator = FilterOperator.IsEqualTo
                        filter.PropertyName = "UserId"
                        filter.Value = 1
                    Case "New"
                        filter.Operator = FilterOperator.IsGreaterThan
                        filter.PropertyName = "Date"
                        filter.Value = DateTime.Now.AddDays(-7)
                    Case Else
                End Select

                Me.bugsGrid.FilterDescriptors.Add(filter)
                Me.featuresGrid.FilterDescriptors.Add(filter)
            Else

                Dim i As Integer = 0
                Do While i < bugsGrid.FilterDescriptors.Count
                    If checkBox.Text = "Open" AndAlso ConvertToStatus(bugsGrid.FilterDescriptors(i).Value) = Status.NotDone Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                        Return
                    End If
                    If checkBox.Text = "Ready For Test" AndAlso ConvertToStatus(bugsGrid.FilterDescriptors(i).Value) = Status.ReadyForTest Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                        Return
                    End If
                    If checkBox.Text = "Done" AndAlso ConvertToStatus(bugsGrid.FilterDescriptors(i).Value) = Status.Done Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                        Return
                    End If
                    If checkBox.Text = "Unassigned" AndAlso (Convert.ToInt32(bugsGrid.FilterDescriptors(i).Value)) = 1 Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                        Return
                    End If
                    If checkBox.Text = "New" AndAlso bugsGrid.FilterDescriptors(i).PropertyName = "Date" Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                        Return
                    End If
                    i += 1
                Loop
            End If
        End Sub

        Private Sub sortGrids(ByVal sender As Object, ByVal e As EventArgs)
            Dim itemClicked As RadMenuItem = TryCast(sender, RadMenuItem)
            Dim parentItem As RadMenuItem = TryCast(itemClicked.HierarchyParent, RadMenuItem)
            bugsGrid.SortDescriptors.Clear()
            featuresGrid.SortDescriptors.Clear()
            If itemClicked.Text = "None" Then
                Return
            Else
                If itemClicked.Text = "Ascending" Then
                    bugsGrid.SortDescriptors.Add(New SortDescriptor(parentItem.Text, ListSortDirection.Ascending))
                Else
                    bugsGrid.SortDescriptors.Add(New SortDescriptor(parentItem.Text, ListSortDirection.Descending))
                End If
                If itemClicked.Text = "Ascending" Then
                    featuresGrid.SortDescriptors.Add(New SortDescriptor(parentItem.Text, ListSortDirection.Ascending))
                Else
                    featuresGrid.SortDescriptors.Add(New SortDescriptor(parentItem.Text, ListSortDirection.Descending))
                End If
            End If
        End Sub

        Private Sub projectsTreeView_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
            If bugsGrid.FilterDescriptors.Count > 1 Then
                For i As Integer = 0 To bugsGrid.FilterDescriptors.Count - 1
                    If bugsGrid.FilterDescriptors(i).PropertyName = "ProjectId" Then
                        bugsGrid.FilterDescriptors.RemoveAt(i)
                    End If
                    If featuresGrid.FilterDescriptors(i).PropertyName = "ProjectId" Then
                        featuresGrid.FilterDescriptors.RemoveAt(i)
                    End If
                Next
            End If

            If CInt(Fix(e.Node.Value)) = 0 Then
                Return
            Else
                Dim filter As FilterDescriptor = New FilterDescriptor()

                filter.PropertyName = "ProjectId"
                filter.Operator = FilterOperator.IsEqualTo
                filter.Value = e.Node.Value
                Me.bugsGrid.FilterDescriptors.Add(filter)
                Me.featuresGrid.FilterDescriptors.Add(filter)
            End If
        End Sub

        Private Sub Controls_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = Keys.Enter Then
                'move the focus away from the editor to the tree view in order to submit the value to the data source
                projectsTreeView.TreeViewElement.Focus()
                If bugsGrid.CurrentRow IsNot Nothing Then
                    bugsGrid.CurrentRow.InvalidateRow()
                End If
                If featuresGrid.CurrentRow IsNot Nothing Then
                    featuresGrid.CurrentRow.InvalidateRow()
                End If
            End If
        End Sub

        Private Sub loadDatabaseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadDatabaseButton.Click
            bugsGrid.Columns.Clear()
            featuresGrid.Columns.Clear()
            FillDataSet()
            SetupBugsGrid()
            SetupFeaturesGrid()
        End Sub

        Private Sub saveDatabaseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveDatabaseButton.Click
            dataSet.WriteXml("..\source.xml")
            dataSet.WriteXmlSchema("..\XMLSchema.xsd")
        End Sub

        Private Sub addButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addButton.Click
            Dim currentGrid As RadGridView = DirectCast(IIf(documentTabStrip2.ActiveWindow Is bugDocumentWindow, bugsGrid, featuresGrid), RadGridView)
            Dim t As Type = DirectCast(IIf(documentTabStrip2.ActiveWindow Is bugDocumentWindow, Type.Bug, Type.Feature), Type)
            Dim highestId As Integer = -1
            For Each r As GridViewRowInfo In currentGrid.Rows
                If Convert.ToInt32(r.Cells("Id").Value) > highestId Then
                    highestId = Convert.ToInt32(r.Cells("Id").Value)
                End If
            Next
            highestId += 1

            Dim row As DataRow = dataSet.Tables("Issue").NewRow()
            row(0) = highestId
            row(1) = ""
            row(2) = ""
            row(3) = ""
            row(4) = Status.NotDone
            row(5) = DateTime.Now
            row(6) = Priority.High
            row(7) = projectsTreeView.SelectedNode.Value
            If documentTabStrip2.ActiveWindow Is bugDocumentWindow Then
                row(8) = Type.Bug
            Else
                row(8) = Type.Feature
            End If
            dataSet.Tables("Issue").Rows.Add(row)
        End Sub

        Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
            If documentTabStrip2.ActiveWindow Is bugDocumentWindow AndAlso Not bugsGrid.CurrentRow Is Nothing Then
                bugsGrid.CurrentRow.Delete()
            ElseIf documentTabStrip2.ActiveWindow Is featureDocumentWindow AndAlso Not featuresGrid.CurrentRow Is Nothing Then
                featuresGrid.CurrentRow.Delete()
            End If
        End Sub

        Private Sub editButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editButton.Click
            ReadOnlyControls(False)
        End Sub

        Private Sub saveLayoutButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveLayoutButton.Click
            radDock1.SaveToXml("..\..\dockLayout.xml")
        End Sub

        Private Sub loadLayoutButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadLayoutButton.Click
            radDock1.LoadFromXml("..\..\dockLayout.xml")
        End Sub

        Private Sub changeThemes(ByVal sender As Object, ByVal e As EventArgs)
            Dim element As RadGalleryItem = TryCast(sender, RadGalleryItem)
            ThemeResolutionService.ApplicationThemeName = element.Text
        End Sub

        Private Sub panelsChange_Click(ByVal sender As Object, ByVal e As EventArgs)

            bugDocumentWindow.CloseAction = DockWindowCloseAction.Hide
            featureDocumentWindow.CloseAction = DockWindowCloseAction.Hide

            Dim button As RadButtonElement = TryCast(sender, RadButtonElement)
            If button.Text = "Projects" Then
                projectsToolWindow.DockState = DockState.Docked
            End If
            If button.Text = "Details" Then
                detailsToolWindow.DockState = DockState.Docked
            End If
            If button.Text = "Bugs" Then
                bugDocumentWindow.DockState = DockState.TabbedDocument
            End If
            If button.Text = "Features" Then
                featureDocumentWindow.DockState = DockState.TabbedDocument
            End If
        End Sub

        Private Sub rowChanged_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)
            ReadOnlyControls(True)
        End Sub

        Private Sub exitMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Application.Exit()
        End Sub

        Private Sub aboutMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim radAboutBox1 As RadAboutBox1 = New RadAboutBox1()
            radAboutBox1.Show()
        End Sub

#End Region

    End Class
End Namespace
