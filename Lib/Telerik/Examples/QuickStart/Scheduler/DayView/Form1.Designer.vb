Namespace Telerik.Examples.WinControls.Scheduler.DayView
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
			If disposing AndAlso (components IsNot Nothing) Then
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
			Dim dateTimeInterval1 As New Telerik.WinControls.UI.DateTimeInterval()
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.spinEditorPointerWidth = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinEditorRulerWidth = New Telerik.WinControls.UI.RadSpinEditor()
            Me.dropDownRangeFactor = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.spinEditorScaleSize = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.timePickerRulerEnd = New Telerik.WinControls.UI.RadTimePicker()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.timePickerRulerStart = New Telerik.WinControls.UI.RadTimePicker()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.dropDownWorkWeekEnd = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.dropDownWorkWeekStart = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
            Me.timePickerWorkTimeEnd = New Telerik.WinControls.UI.RadTimePicker()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.timePickerWorkTimeStart = New Telerik.WinControls.UI.RadTimePicker()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.tableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.checkBoxShowWeekend = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxShowRuler = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxExactTimeRendering = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxShowAllDayArea = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxShowHeader = New Telerik.WinControls.UI.RadCheckBox()
            Me.tableLayoutPanel4 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.spinEditorAppointmentSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinEditorAllDayMaxHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinEditorAllDayHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel13 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.spinEditorPointerWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorRulerWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dropDownRangeFactor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorScaleSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			CType(Me.dropDownWorkWeekEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dropDownWorkWeekStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerWorkTimeEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerWorkTimeStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			Me.tableLayoutPanel3.SuspendLayout()
			CType(Me.checkBoxShowWeekend, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowRuler, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowAllDayArea, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel4.SuspendLayout()
			CType(Me.spinEditorAppointmentSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorAllDayMaxHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorAllDayHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 22)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox4)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(230, 741)
			Me.settingsPanel.Size = New Size(230, 741)
			' 
			' radScheduler1
			' 
			dateTimeInterval1.End = New Date((CLng(0)))
			dateTimeInterval1.Start = New Date((CLng(0)))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval1
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.Location = New Point(0, 77)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2014, 6, 14, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2014, 6, 9, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New Size(1473, 764)
			Me.radScheduler1.TabIndex = 2
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1473, 77)
			Me.radSchedulerNavigator1.TabIndex = 3
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.tableLayoutPanel1)
			Me.radGroupBox1.HeaderText = "Ruler options"
			Me.radGroupBox1.Location = New Point(5, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(220, 187)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Ruler options"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.spinEditorPointerWidth, 1, 5)
			Me.tableLayoutPanel1.Controls.Add(Me.spinEditorRulerWidth, 1, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.dropDownRangeFactor, 1, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel6, 0, 5)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel5, 0, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.spinEditorScaleSize, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.timePickerRulerEnd, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.timePickerRulerStart, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 2)
			Me.tableLayoutPanel1.Location = New Point(5, 18)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 6
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.Size = New Size(210, 164)
			Me.tableLayoutPanel1.TabIndex = 10
			' 
			' spinEditorPointerWidth
			' 
			Me.spinEditorPointerWidth.Dock = DockStyle.Fill
			Me.spinEditorPointerWidth.Location = New Point(108, 138)
			Me.spinEditorPointerWidth.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinEditorPointerWidth.Name = "spinEditorPointerWidth"
			Me.spinEditorPointerWidth.Size = New Size(99, 20)
			Me.spinEditorPointerWidth.TabIndex = 11
			Me.spinEditorPointerWidth.TabStop = False
			' 
			' spinEditorRulerWidth
			' 
			Me.spinEditorRulerWidth.Dock = DockStyle.Fill
			Me.spinEditorRulerWidth.Location = New Point(108, 111)
			Me.spinEditorRulerWidth.Name = "spinEditorRulerWidth"
			Me.spinEditorRulerWidth.Size = New Size(99, 20)
			Me.spinEditorRulerWidth.TabIndex = 12
			Me.spinEditorRulerWidth.TabStop = False
			' 
			' dropDownRangeFactor
			' 
			Me.dropDownRangeFactor.Dock = DockStyle.Fill
			Me.dropDownRangeFactor.DropDownAnimationEnabled = False
			Me.dropDownRangeFactor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.dropDownRangeFactor.Location = New Point(108, 84)
			Me.dropDownRangeFactor.Name = "dropDownRangeFactor"
			Me.dropDownRangeFactor.Size = New Size(99, 20)
			Me.dropDownRangeFactor.TabIndex = 13
			Me.dropDownRangeFactor.Text = "radDropDownList1"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New Point(3, 138)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(73, 18)
			Me.radLabel6.TabIndex = 19
			Me.radLabel6.Text = "Pointer width"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(3, 3)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(57, 18)
			Me.radLabel1.TabIndex = 14
			Me.radLabel1.Text = "Ruler start"
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New Point(3, 111)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(63, 18)
			Me.radLabel5.TabIndex = 18
			Me.radLabel5.Text = "Ruler width"
			' 
			' spinEditorScaleSize
			' 
			Me.spinEditorScaleSize.Dock = DockStyle.Fill
			Me.spinEditorScaleSize.Location = New Point(108, 57)
			Me.spinEditorScaleSize.Minimum = New Decimal(New Integer() { 21, 0, 0, 0})
			Me.spinEditorScaleSize.Name = "spinEditorScaleSize"
			Me.spinEditorScaleSize.NullableValue = New Decimal(New Integer() { 22, 0, 0, 0})
			Me.spinEditorScaleSize.Size = New Size(99, 20)
			Me.spinEditorScaleSize.TabIndex = 10
			Me.spinEditorScaleSize.TabStop = False
			Me.spinEditorScaleSize.Value = New Decimal(New Integer() { 22, 0, 0, 0})
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 30)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(54, 18)
			Me.radLabel2.TabIndex = 15
			Me.radLabel2.Text = "Ruler end"
			' 
			' timePickerRulerEnd
			' 
			Me.timePickerRulerEnd.Dock = DockStyle.Fill
			Me.timePickerRulerEnd.Location = New Point(108, 30)
			Me.timePickerRulerEnd.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerEnd.MinValue = New Date((CLng(0)))
			Me.timePickerRulerEnd.Name = "timePickerRulerEnd"
			Me.timePickerRulerEnd.Size = New Size(99, 20)
			Me.timePickerRulerEnd.TabIndex = 9
			Me.timePickerRulerEnd.TabStop = False
			Me.timePickerRulerEnd.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(3, 84)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(70, 18)
			Me.radLabel4.TabIndex = 17
			Me.radLabel4.Text = "Range factor"
			' 
			' timePickerRulerStart
			' 
			Me.timePickerRulerStart.Dock = DockStyle.Fill
			Me.timePickerRulerStart.Location = New Point(108, 3)
			Me.timePickerRulerStart.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerStart.MinValue = New Date((CLng(0)))
			Me.timePickerRulerStart.Name = "timePickerRulerStart"
			Me.timePickerRulerStart.Size = New Size(99, 20)
			Me.timePickerRulerStart.TabIndex = 8
			Me.timePickerRulerStart.TabStop = False
			Me.timePickerRulerStart.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(3, 57)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(54, 18)
			Me.radLabel3.TabIndex = 16
			Me.radLabel3.Text = "Scale size"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.tableLayoutPanel2)
			Me.radGroupBox2.HeaderText = "Working time options"
			Me.radGroupBox2.Location = New Point(5, 225)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(220, 147)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "Working time options"
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel2.ColumnCount = 2
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel2.Controls.Add(Me.dropDownWorkWeekEnd, 1, 3)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel7, 0, 3)
			Me.tableLayoutPanel2.Controls.Add(Me.dropDownWorkWeekStart, 1, 2)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel10, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.timePickerWorkTimeEnd, 1, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel8, 0, 2)
			Me.tableLayoutPanel2.Controls.Add(Me.timePickerWorkTimeStart, 1, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel9, 0, 1)
			Me.tableLayoutPanel2.Location = New Point(5, 18)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 4
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.Size = New Size(210, 124)
			Me.tableLayoutPanel2.TabIndex = 10
			' 
			' dropDownWorkWeekEnd
			' 
			Me.dropDownWorkWeekEnd.Dock = DockStyle.Fill
			Me.dropDownWorkWeekEnd.DropDownAnimationEnabled = False
			Me.dropDownWorkWeekEnd.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.dropDownWorkWeekEnd.Location = New Point(108, 96)
			Me.dropDownWorkWeekEnd.Name = "dropDownWorkWeekEnd"
			Me.dropDownWorkWeekEnd.Size = New Size(99, 20)
			Me.dropDownWorkWeekEnd.TabIndex = 13
			Me.dropDownWorkWeekEnd.Text = "radDropDownList3"
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New Point(3, 96)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(94, 18)
			Me.radLabel7.TabIndex = 21
			Me.radLabel7.Text = "Working week end"
			' 
			' dropDownWorkWeekStart
			' 
			Me.dropDownWorkWeekStart.Dock = DockStyle.Fill
			Me.dropDownWorkWeekStart.DropDownAnimationEnabled = False
			Me.dropDownWorkWeekStart.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.dropDownWorkWeekStart.Location = New Point(108, 65)
			Me.dropDownWorkWeekStart.Name = "dropDownWorkWeekStart"
			Me.dropDownWorkWeekStart.Size = New Size(99, 20)
			Me.dropDownWorkWeekStart.TabIndex = 12
			Me.dropDownWorkWeekStart.Text = "radDropDownList2"
			' 
			' radLabel10
			' 
			Me.radLabel10.Location = New Point(3, 3)
			Me.radLabel10.Name = "radLabel10"
			Me.radLabel10.Size = New Size(84, 18)
			Me.radLabel10.TabIndex = 18
			Me.radLabel10.Text = "Work time start"
			' 
			' timePickerWorkTimeEnd
			' 
			Me.timePickerWorkTimeEnd.Dock = DockStyle.Fill
			Me.timePickerWorkTimeEnd.Location = New Point(108, 34)
			Me.timePickerWorkTimeEnd.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerWorkTimeEnd.MinValue = New Date((CLng(0)))
			Me.timePickerWorkTimeEnd.Name = "timePickerWorkTimeEnd"
			Me.timePickerWorkTimeEnd.Size = New Size(99, 20)
			Me.timePickerWorkTimeEnd.TabIndex = 11
			Me.timePickerWorkTimeEnd.TabStop = False
			Me.timePickerWorkTimeEnd.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' radLabel8
			' 
			Me.radLabel8.Location = New Point(3, 65)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New Size(94, 18)
			Me.radLabel8.TabIndex = 20
			Me.radLabel8.Text = "Working week start"
			' 
			' timePickerWorkTimeStart
			' 
			Me.timePickerWorkTimeStart.Dock = DockStyle.Fill
			Me.timePickerWorkTimeStart.Location = New Point(108, 3)
			Me.timePickerWorkTimeStart.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerWorkTimeStart.MinValue = New Date((CLng(0)))
			Me.timePickerWorkTimeStart.Name = "timePickerWorkTimeStart"
			Me.timePickerWorkTimeStart.Size = New Size(99, 20)
			Me.timePickerWorkTimeStart.TabIndex = 10
			Me.timePickerWorkTimeStart.TabStop = False
			Me.timePickerWorkTimeStart.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' radLabel9
			' 
			Me.radLabel9.Location = New Point(3, 34)
			Me.radLabel9.Name = "radLabel9"
			Me.radLabel9.Size = New Size(80, 18)
			Me.radLabel9.TabIndex = 19
			Me.radLabel9.Text = "Work time end"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.tableLayoutPanel3)
			Me.radGroupBox3.Controls.Add(Me.tableLayoutPanel4)
			Me.radGroupBox3.HeaderText = "General options"
			Me.radGroupBox3.Location = New Point(5, 378)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Size = New Size(220, 240)
			Me.radGroupBox3.TabIndex = 3
			Me.radGroupBox3.Text = "General options"
			' 
			' tableLayoutPanel3
			' 
			Me.tableLayoutPanel3.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel3.ColumnCount = 1
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel3.Controls.Add(Me.checkBoxShowWeekend, 0, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.checkBoxShowRuler, 0, 1)
			Me.tableLayoutPanel3.Controls.Add(Me.checkBoxExactTimeRendering, 0, 4)
			Me.tableLayoutPanel3.Controls.Add(Me.checkBoxShowAllDayArea, 0, 2)
			Me.tableLayoutPanel3.Controls.Add(Me.checkBoxShowHeader, 0, 3)
			Me.tableLayoutPanel3.Location = New Point(5, 18)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 5
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel3.Size = New Size(210, 114)
			Me.tableLayoutPanel3.TabIndex = 10
			' 
			' checkBoxShowWeekend
			' 
			Me.checkBoxShowWeekend.Dock = DockStyle.Fill
			Me.checkBoxShowWeekend.Location = New Point(3, 3)
			Me.checkBoxShowWeekend.Name = "checkBoxShowWeekend"
			Me.checkBoxShowWeekend.Size = New Size(114, 18)
			Me.checkBoxShowWeekend.TabIndex = 0
			Me.checkBoxShowWeekend.Text = "Show the weekend"
			' 
			' checkBoxShowRuler
			' 
			Me.checkBoxShowRuler.Dock = DockStyle.Fill
			Me.checkBoxShowRuler.Location = New Point(3, 25)
			Me.checkBoxShowRuler.Name = "checkBoxShowRuler"
			Me.checkBoxShowRuler.Size = New Size(93, 18)
			Me.checkBoxShowRuler.TabIndex = 1
			Me.checkBoxShowRuler.Text = "Show the ruler"
			' 
			' checkBoxExactTimeRendering
			' 
			Me.checkBoxExactTimeRendering.Dock = DockStyle.Fill
			Me.checkBoxExactTimeRendering.Location = New Point(3, 91)
			Me.checkBoxExactTimeRendering.Name = "checkBoxExactTimeRendering"
			Me.checkBoxExactTimeRendering.Size = New Size(123, 18)
			Me.checkBoxExactTimeRendering.TabIndex = 4
			Me.checkBoxExactTimeRendering.Text = "Exact time rendering"
			' 
			' checkBoxShowAllDayArea
			' 
			Me.checkBoxShowAllDayArea.Dock = DockStyle.Fill
			Me.checkBoxShowAllDayArea.Location = New Point(3, 47)
			Me.checkBoxShowAllDayArea.Name = "checkBoxShowAllDayArea"
			Me.checkBoxShowAllDayArea.Size = New Size(126, 18)
			Me.checkBoxShowAllDayArea.TabIndex = 2
			Me.checkBoxShowAllDayArea.Text = "Show the AllDay area"
			' 
			' checkBoxShowHeader
			' 
			Me.checkBoxShowHeader.Dock = DockStyle.Fill
			Me.checkBoxShowHeader.Location = New Point(3, 69)
			Me.checkBoxShowHeader.Name = "checkBoxShowHeader"
			Me.checkBoxShowHeader.Size = New Size(151, 18)
			Me.checkBoxShowHeader.TabIndex = 3
			Me.checkBoxShowHeader.Text = "Show the DayView header"
			' 
			' tableLayoutPanel4
			' 
			Me.tableLayoutPanel4.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel4.ColumnCount = 2
			Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.80952F))
			Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.19048F))
			Me.tableLayoutPanel4.Controls.Add(Me.spinEditorAppointmentSpacing, 1, 2)
			Me.tableLayoutPanel4.Controls.Add(Me.spinEditorAllDayMaxHeight, 1, 1)
			Me.tableLayoutPanel4.Controls.Add(Me.spinEditorAllDayHeight, 1, 0)
			Me.tableLayoutPanel4.Controls.Add(Me.radLabel13, 0, 1)
			Me.tableLayoutPanel4.Controls.Add(Me.radLabel11, 0, 2)
			Me.tableLayoutPanel4.Controls.Add(Me.radLabel12, 0, 0)
			Me.tableLayoutPanel4.Location = New Point(5, 148)
			Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
			Me.tableLayoutPanel4.RowCount = 4
			Me.tableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
			Me.tableLayoutPanel4.Size = New Size(210, 87)
			Me.tableLayoutPanel4.TabIndex = 11
			' 
			' spinEditorAppointmentSpacing
			' 
			Me.spinEditorAppointmentSpacing.Dock = DockStyle.Fill
			Me.spinEditorAppointmentSpacing.Location = New Point(137, 57)
			Me.spinEditorAppointmentSpacing.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.spinEditorAppointmentSpacing.Name = "spinEditorAppointmentSpacing"
			Me.spinEditorAppointmentSpacing.Size = New Size(70, 20)
			Me.spinEditorAppointmentSpacing.TabIndex = 7
			Me.spinEditorAppointmentSpacing.TabStop = False
			' 
			' spinEditorAllDayMaxHeight
			' 
			Me.spinEditorAllDayMaxHeight.Dock = DockStyle.Fill
			Me.spinEditorAllDayMaxHeight.Location = New Point(137, 30)
			Me.spinEditorAllDayMaxHeight.Maximum = New Decimal(New Integer() { 500, 0, 0, 0})
			Me.spinEditorAllDayMaxHeight.Name = "spinEditorAllDayMaxHeight"
			Me.spinEditorAllDayMaxHeight.Size = New Size(70, 20)
			Me.spinEditorAllDayMaxHeight.TabIndex = 18
			Me.spinEditorAllDayMaxHeight.TabStop = False
			' 
			' spinEditorAllDayHeight
			' 
			Me.spinEditorAllDayHeight.Dock = DockStyle.Fill
			Me.spinEditorAllDayHeight.Location = New Point(137, 3)
			Me.spinEditorAllDayHeight.Name = "spinEditorAllDayHeight"
			Me.spinEditorAllDayHeight.Size = New Size(70, 20)
			Me.spinEditorAllDayHeight.TabIndex = 8
			Me.spinEditorAllDayHeight.TabStop = False
			' 
			' radLabel13
			' 
			Me.radLabel13.Location = New Point(3, 30)
			Me.radLabel13.Name = "radLabel13"
			Me.radLabel13.Size = New Size(94, 18)
			Me.radLabel13.TabIndex = 19
			Me.radLabel13.Text = "All day area max height"
			' 
			' radLabel11
			' 
			Me.radLabel11.Location = New Point(3, 57)
			Me.radLabel11.Name = "radLabel11"
			Me.radLabel11.Size = New Size(94, 18)
			Me.radLabel11.TabIndex = 17
			Me.radLabel11.Text = "Appointments spacing"
			' 
			' radLabel12
			' 
			Me.radLabel12.Location = New Point(3, 3)
			Me.radLabel12.Name = "radLabel12"
			Me.radLabel12.Size = New Size(94, 18)
			Me.radLabel12.TabIndex = 16
			Me.radLabel12.Text = "All day area height"
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Anchor = AnchorStyles.Top
			Me.radGroupBox4.Controls.Add(Me.radTrackBar1)
			Me.radGroupBox4.HeaderText = "Resize the selected column"
			Me.radGroupBox4.Location = New Point(5, 624)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Size = New Size(220, 84)
			Me.radGroupBox4.TabIndex = 4
			Me.radGroupBox4.Text = "Resize the selected column"
			' 
			' radTrackBar1
			' 
			Me.radTrackBar1.Anchor = AnchorStyles.Top
			Me.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
			Me.radTrackBar1.LargeTickFrequency = 1
			Me.radTrackBar1.Location = New Point(5, 21)
			Me.radTrackBar1.Maximum = 10F
			Me.radTrackBar1.Minimum = 1F
			Me.radTrackBar1.Name = "radTrackBar1"
			Me.radTrackBar1.Size = New Size(210, 52)
			Me.radTrackBar1.TabIndex = 0
			Me.radTrackBar1.Value = 1F
'			Me.radTrackBar1.ValueChanged += New System.EventHandler(Me.radTrackBar1_ValueChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 851)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			CType(Me.spinEditorPointerWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorRulerWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dropDownRangeFactor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorScaleSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.tableLayoutPanel2.ResumeLayout(False)
			Me.tableLayoutPanel2.PerformLayout()
			CType(Me.dropDownWorkWeekEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dropDownWorkWeekStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerWorkTimeEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerWorkTimeStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.tableLayoutPanel3.ResumeLayout(False)
			Me.tableLayoutPanel3.PerformLayout()
			CType(Me.checkBoxShowWeekend, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowRuler, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowAllDayArea, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel4.ResumeLayout(False)
			Me.tableLayoutPanel4.PerformLayout()
			CType(Me.spinEditorAppointmentSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorAllDayMaxHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorAllDayHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private checkBoxShowHeader As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxShowAllDayArea As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxShowRuler As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxShowWeekend As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private spinEditorAllDayHeight As Telerik.WinControls.UI.RadSpinEditor
		Private spinEditorAppointmentSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private checkBoxExactTimeRendering As Telerik.WinControls.UI.RadCheckBox
		Private dropDownRangeFactor As Telerik.WinControls.UI.RadDropDownList
		Private spinEditorRulerWidth As Telerik.WinControls.UI.RadSpinEditor
		Private spinEditorPointerWidth As Telerik.WinControls.UI.RadSpinEditor
		Private spinEditorScaleSize As Telerik.WinControls.UI.RadSpinEditor
		Private timePickerRulerEnd As Telerik.WinControls.UI.RadTimePicker
		Private timePickerRulerStart As Telerik.WinControls.UI.RadTimePicker
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private dropDownWorkWeekEnd As Telerik.WinControls.UI.RadDropDownList
		Private dropDownWorkWeekStart As Telerik.WinControls.UI.RadDropDownList
		Private timePickerWorkTimeEnd As Telerik.WinControls.UI.RadTimePicker
		Private timePickerWorkTimeStart As Telerik.WinControls.UI.RadTimePicker
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private radLabel12 As Telerik.WinControls.UI.RadLabel
		Private radLabel13 As Telerik.WinControls.UI.RadLabel
		Private spinEditorAllDayMaxHeight As Telerik.WinControls.UI.RadSpinEditor
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
		Private tableLayoutPanel4 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel3 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace