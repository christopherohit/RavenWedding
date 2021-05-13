Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GanttView.Settings
    Partial Public Class Form1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
            Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
            Me.ribbonTab1 = New Telerik.WinControls.UI.RibbonTab()
            Me.radRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radButtonElementAddTask = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementDeleteTask = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementAddMilestone = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radButtonElementProgress25 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementProgress50 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementProgress100 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup3 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radButtonElementWeek = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementMonth = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementYear = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup6 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radRibbonBarButtonGroup1 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
            Me.radDateTimePickerElementStart = New Telerik.WinControls.UI.RadDateTimePickerElement()
            Me.radRibbonBarButtonGroup2 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
            Me.radDateTimePickerElementEnd = New Telerik.WinControls.UI.RadDateTimePickerElement()
            Me.radRibbonBarGroup4 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radButtonElementPrevious = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElementNext = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup5 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radTrackBarElementZoom = New Telerik.WinControls.UI.RadTrackBarElement()
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radGanttView1
            ' 
            Me.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGanttView1.Location = New System.Drawing.Point(0, 150)
            Me.radGanttView1.Name = "radGanttView1"
            Me.radGanttView1.Size = New System.Drawing.Size(1004, 413)
            Me.radGanttView1.TabIndex = 0
            Me.radGanttView1.Text = "radGanttView1"
            Me.radGanttView1.ThemeName = "TelerikMetroBlue"
            Me.radGanttView1.Ratio = 0.3169399F
            Me.radGanttView1.GanttViewElement.AllowDefaultContextMenu = False
            ' 
            ' radRibbonBar1
            ' 
            Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.ribbonTab1})
            Me.radRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.radRibbonBar1.Name = "radRibbonBar1"
            Me.radRibbonBar1.Size = New System.Drawing.Size(1016, 150)
            Me.radRibbonBar1.StartButtonImage = (CType(resources.GetObject("radRibbonBar1.StartButtonImage"), System.Drawing.Image))
            Me.radRibbonBar1.TabIndex = 4
            Me.radRibbonBar1.Text = "RadGanttViewExample"
            Me.radRibbonBar1.ThemeName = "TelerikMetroBlue"
            CType(Me.radRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "RadGanttViewExample"
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRibbonBarCaption).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadQuickAccessToolBar).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0), Telerik.WinControls.UI.StripViewItemContainer).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RadApplicationMenuButtonElement).Image = (CType(resources.GetObject("resource.Image"), System.Drawing.Image))
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RadApplicationMenuButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).Margin = New System.Windows.Forms.Padding(0)
            CType(Me.radRibbonBar1.GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' ribbonTab1
            ' 
            Me.ribbonTab1.AccessibleDescription = "s"
            Me.ribbonTab1.AccessibleName = "s"
            Me.ribbonTab1.IsSelected = True
            Me.ribbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarGroup1, Me.radRibbonBarGroup2, Me.radRibbonBarGroup3, Me.radRibbonBarGroup6, Me.radRibbonBarGroup4, Me.radRibbonBarGroup5})
            Me.ribbonTab1.Name = "ribbonTab1"
            Me.ribbonTab1.Text = "s"
            Me.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup1
            ' 
            Me.radRibbonBarGroup1.AccessibleDescription = "ITEMS"
            Me.radRibbonBarGroup1.AccessibleName = "ITEMS"
            Me.radRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElementAddTask, Me.radButtonElementDeleteTask, Me.radButtonElementAddMilestone})
            Me.radRibbonBarGroup1.Name = "radRibbonBarGroup1"
            Me.radRibbonBarGroup1.Text = "ITEMS"
            Me.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementAddTask
            ' 
            Me.radButtonElementAddTask.AccessibleDescription = "Add child to selected item"
            Me.radButtonElementAddTask.AccessibleName = "Add child to selected item"
            Me.radButtonElementAddTask.Image = My.Resources.GanttAdd
            Me.radButtonElementAddTask.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElementAddTask.MaxSize = New System.Drawing.Size(100, 0)
            Me.radButtonElementAddTask.Name = "radButtonElementAddTask"
            Me.radButtonElementAddTask.StretchHorizontally = True
            Me.radButtonElementAddTask.Text = "Add child to selected item"
            Me.radButtonElementAddTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElementAddTask.TextWrap = True
            Me.radButtonElementAddTask.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementDeleteTask
            ' 
            Me.radButtonElementDeleteTask.AccessibleDescription = "Delete selected task"
            Me.radButtonElementDeleteTask.AccessibleName = "Delete selected task"
            Me.radButtonElementDeleteTask.Image = My.Resources.GanttDelete
            Me.radButtonElementDeleteTask.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElementDeleteTask.MaxSize = New System.Drawing.Size(100, 0)
            Me.radButtonElementDeleteTask.Name = "radButtonElementDeleteTask"
            Me.radButtonElementDeleteTask.Text = "Delete selected task"
            Me.radButtonElementDeleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElementDeleteTask.TextWrap = True
            Me.radButtonElementDeleteTask.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementAddMilestone
            ' 
            Me.radButtonElementAddMilestone.AccessibleDescription = "Add milestone"
            Me.radButtonElementAddMilestone.AccessibleName = "Add milestone"
            Me.radButtonElementAddMilestone.Image = My.Resources.GanttAddMilestone
            Me.radButtonElementAddMilestone.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElementAddMilestone.MaxSize = New System.Drawing.Size(100, 0)
            Me.radButtonElementAddMilestone.Name = "radButtonElementAddMilestone"
            Me.radButtonElementAddMilestone.Text = "Add milestone"
            Me.radButtonElementAddMilestone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElementAddMilestone.TextWrap = True
            Me.radButtonElementAddMilestone.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup2
            ' 
            Me.radRibbonBarGroup2.AccessibleDescription = "TASK PROGRESS"
            Me.radRibbonBarGroup2.AccessibleName = "TASK PROGRESS"
            Me.radRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElementProgress25, Me.radButtonElementProgress50, Me.radButtonElementProgress100})
            Me.radRibbonBarGroup2.Name = "radRibbonBarGroup2"
            Me.radRibbonBarGroup2.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarGroup2.Text = "TASK PROGRESS"
            Me.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementProgress25
            ' 
            Me.radButtonElementProgress25.AccessibleDescription = "25%"
            Me.radButtonElementProgress25.AccessibleName = "25%"
            Me.radButtonElementProgress25.Image = My.Resources.Gantt25
            Me.radButtonElementProgress25.Name = "radButtonElementProgress25"
            Me.radButtonElementProgress25.Text = "25%"
            Me.radButtonElementProgress25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementProgress25.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementProgress50
            ' 
            Me.radButtonElementProgress50.AccessibleDescription = "50%"
            Me.radButtonElementProgress50.AccessibleName = "50%"
            Me.radButtonElementProgress50.Image = My.Resources.Gantt50
            Me.radButtonElementProgress50.Name = "radButtonElementProgress50"
            Me.radButtonElementProgress50.Text = "50%"
            Me.radButtonElementProgress50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementProgress50.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementProgress100
            ' 
            Me.radButtonElementProgress100.AccessibleDescription = "100%"
            Me.radButtonElementProgress100.AccessibleName = "100%"
            Me.radButtonElementProgress100.Image = My.Resources.Gantt100
            Me.radButtonElementProgress100.Name = "radButtonElementProgress100"
            Me.radButtonElementProgress100.Text = "100%"
            Me.radButtonElementProgress100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementProgress100.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup3
            ' 
            Me.radRibbonBarGroup3.AccessibleDescription = "NAVIGATE"
            Me.radRibbonBarGroup3.AccessibleName = "NAVIGATE"
            Me.radRibbonBarGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElementWeek, Me.radButtonElementMonth, Me.radButtonElementYear})
            Me.radRibbonBarGroup3.Name = "radRibbonBarGroup3"
            Me.radRibbonBarGroup3.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarGroup3.Text = "VIEW MODE"
            Me.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementWeek
            ' 
            Me.radButtonElementWeek.AccessibleDescription = "Week"
            Me.radButtonElementWeek.AccessibleName = "Week"
            Me.radButtonElementWeek.Image = My.Resources.GanttWeek
            Me.radButtonElementWeek.Name = "radButtonElementWeek"
            Me.radButtonElementWeek.Text = "Week"
            Me.radButtonElementWeek.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.radButtonElementWeek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementWeek.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementMonth
            ' 
            Me.radButtonElementMonth.AccessibleDescription = "Month"
            Me.radButtonElementMonth.AccessibleName = "Month"
            Me.radButtonElementMonth.Image = My.Resources.GanttMonth
            Me.radButtonElementMonth.Name = "radButtonElementMonth"
            Me.radButtonElementMonth.Text = "Month"
            Me.radButtonElementMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.radButtonElementMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementMonth.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementYear
            ' 
            Me.radButtonElementYear.AccessibleDescription = "Year"
            Me.radButtonElementYear.AccessibleName = "Year"
            Me.radButtonElementYear.Image = My.Resources.GanttYear
            Me.radButtonElementYear.Name = "radButtonElementYear"
            Me.radButtonElementYear.Text = "Year"
            Me.radButtonElementYear.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.radButtonElementYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElementYear.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup6
            ' 
            Me.radRibbonBarGroup6.AccessibleDescription = "TIMERANGE"
            Me.radRibbonBarGroup6.AccessibleName = "TIMERANGE"
            Me.radRibbonBarGroup6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarButtonGroup1, Me.radRibbonBarButtonGroup2})
            Me.radRibbonBarGroup6.MinSize = New System.Drawing.Size(165, 86)
            Me.radRibbonBarGroup6.Name = "radRibbonBarGroup6"
            Me.radRibbonBarGroup6.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarGroup6.Text = "TIMELINE RANGE"
            Me.radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarButtonGroup1
            ' 
            Me.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement1, Me.radDateTimePickerElementStart})
            Me.radRibbonBarButtonGroup1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Padding = New System.Windows.Forms.Padding(1)
            Me.radRibbonBarButtonGroup1.ShowBackColor = False
            Me.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radLabelElement1
            ' 
            Me.radLabelElement1.AccessibleDescription = "Start"
            Me.radLabelElement1.AccessibleName = "Start"
            Me.radLabelElement1.MinSize = New System.Drawing.Size(35, 0)
            Me.radLabelElement1.Name = "radLabelElement1"
            Me.radLabelElement1.Text = "Start"
            Me.radLabelElement1.TextWrap = True
            Me.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radDateTimePickerElementStart
            ' 
            Me.radDateTimePickerElementStart.AccessibleDescription = "radButtonElement9"
            Me.radDateTimePickerElementStart.AccessibleName = "radButtonElement9"
            Me.radDateTimePickerElementStart.Format = System.Windows.Forms.DateTimePickerFormat.Long
            Me.radDateTimePickerElementStart.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
            Me.radDateTimePickerElementStart.MinDate = New System.DateTime((CLng(Fix(0))))
            Me.radDateTimePickerElementStart.MinSize = New System.Drawing.Size(150, 0)
            Me.radDateTimePickerElementStart.Name = "radDateTimePickerElementStart"
            Me.radDateTimePickerElementStart.NullDate = New System.DateTime((CLng(Fix(0))))
            Me.radDateTimePickerElementStart.StretchVertically = False
            Me.radDateTimePickerElementStart.Text = "radButtonElement9"
            Me.radDateTimePickerElementStart.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarButtonGroup2
            ' 
            Me.radRibbonBarButtonGroup2.AccessibleDescription = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.AccessibleName = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement2, Me.radDateTimePickerElementEnd})
            Me.radRibbonBarButtonGroup2.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Padding = New System.Windows.Forms.Padding(1)
            Me.radRibbonBarButtonGroup2.ShowBackColor = False
            Me.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radLabelElement2
            ' 
            Me.radLabelElement2.AccessibleDescription = "End"
            Me.radLabelElement2.AccessibleName = "End"
            Me.radLabelElement2.MinSize = New System.Drawing.Size(35, 0)
            Me.radLabelElement2.Name = "radLabelElement2"
            Me.radLabelElement2.Text = "End"
            Me.radLabelElement2.TextWrap = True
            Me.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radDateTimePickerElementEnd
            ' 
            Me.radDateTimePickerElementEnd.AccessibleDescription = "radButtonElement10"
            Me.radDateTimePickerElementEnd.AccessibleName = "radButtonElement10"
            Me.radDateTimePickerElementEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long
            Me.radDateTimePickerElementEnd.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
            Me.radDateTimePickerElementEnd.MinDate = New System.DateTime((CLng(Fix(0))))
            Me.radDateTimePickerElementEnd.MinSize = New System.Drawing.Size(150, 0)
            Me.radDateTimePickerElementEnd.Name = "radDateTimePickerElementEnd"
            Me.radDateTimePickerElementEnd.NullDate = New System.DateTime((CLng(Fix(0))))
            Me.radDateTimePickerElementEnd.StretchVertically = False
            Me.radDateTimePickerElementEnd.Text = "radButtonElement10"
            Me.radDateTimePickerElementEnd.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup4
            ' 
            Me.radRibbonBarGroup4.AccessibleDescription = "ZOOM"
            Me.radRibbonBarGroup4.AccessibleName = "ZOOM"
            Me.radRibbonBarGroup4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElementPrevious, Me.radButtonElementNext})
            Me.radRibbonBarGroup4.Name = "radRibbonBarGroup4"
            Me.radRibbonBarGroup4.Text = "NAVIGATE"
            Me.radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementPrevious
            ' 
            Me.radButtonElementPrevious.AccessibleDescription = "Previous"
            Me.radButtonElementPrevious.AccessibleName = "Previous"
            Me.radButtonElementPrevious.Image = My.Resources.GanttPrevious
            Me.radButtonElementPrevious.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElementPrevious.MinSize = New System.Drawing.Size(60, 0)
            Me.radButtonElementPrevious.Name = "radButtonElementPrevious"
            Me.radButtonElementPrevious.Text = "Previous"
            Me.radButtonElementPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElementPrevious.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radButtonElementNext
            ' 
            Me.radButtonElementNext.AccessibleDescription = "Next"
            Me.radButtonElementNext.AccessibleName = "Next"
            Me.radButtonElementNext.Image = My.Resources.GanttNext
            Me.radButtonElementNext.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElementNext.MinSize = New System.Drawing.Size(60, 0)
            Me.radButtonElementNext.Name = "radButtonElementNext"
            Me.radButtonElementNext.Text = "Next"
            Me.radButtonElementNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElementNext.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRibbonBarGroup5
            ' 
            Me.radRibbonBarGroup5.AccessibleDescription = "ZOOM"
            Me.radRibbonBarGroup5.AccessibleName = "ZOOM"
            Me.radRibbonBarGroup5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radTrackBarElementZoom})
            Me.radRibbonBarGroup5.Name = "radRibbonBarGroup5"
            Me.radRibbonBarGroup5.Text = "ZOOM"
            Me.radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radTrackBarElementZoom
            ' 
            Me.radTrackBarElementZoom.AccessibleDescription = "radButtonElement9"
            Me.radTrackBarElementZoom.AccessibleName = "radButtonElement9"
            Me.radTrackBarElementZoom.FitInAvailableSize = True
            Me.radTrackBarElementZoom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
            Me.radTrackBarElementZoom.Maximum = 60.0F
            Me.radTrackBarElementZoom.Minimum = 1.0F
            Me.radTrackBarElementZoom.Value = 30.0F
            Me.radTrackBarElementZoom.Name = "radTrackBarElementZoom"
            Me.radTrackBarElementZoom.Text = "radButtonElement9"
            Me.radTrackBarElementZoom.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 651)
            Me.Controls.Add(Me.radGanttView1)
            Me.Controls.Add(Me.radRibbonBar1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.Text = "RadGanttViewExample"
            CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
        Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
        Private ribbonTab1 As Telerik.WinControls.UI.RibbonTab
        Private radRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radButtonElementAddTask As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementDeleteTask As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementAddMilestone As Telerik.WinControls.UI.RadButtonElement
        Private radRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radRibbonBarGroup3 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radRibbonBarGroup4 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radButtonElementProgress25 As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementProgress50 As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementProgress100 As Telerik.WinControls.UI.RadButtonElement
        Private radRibbonBarGroup5 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radButtonElementWeek As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementMonth As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementYear As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementPrevious As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElementNext As Telerik.WinControls.UI.RadButtonElement
        Private radRibbonBarGroup6 As Telerik.WinControls.UI.RadRibbonBarGroup
        Private radDateTimePickerElementStart As Telerik.WinControls.UI.RadDateTimePickerElement
        Private radDateTimePickerElementEnd As Telerik.WinControls.UI.RadDateTimePickerElement
        Private radRibbonBarButtonGroup1 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
        Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
        Private radRibbonBarButtonGroup2 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
        Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
        Private radTrackBarElementZoom As Telerik.WinControls.UI.RadTrackBarElement
    End Class
End Namespace

