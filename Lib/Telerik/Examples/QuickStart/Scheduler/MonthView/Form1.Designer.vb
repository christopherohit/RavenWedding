Namespace Telerik.Examples.WinControls.Scheduler.MonthView
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.checkBoxCellsOverflow = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxAppointmentsScrolling = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxEnableWeeksHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxShowWeeksHeader = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxVerticalScroll = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.panel2 = New Panel()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.dropDownWorkWeekEnd = New Telerik.WinControls.UI.RadDropDownList()
			Me.dropDownWorkWeekStart = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.spinEditorWeekCount = New Telerik.WinControls.UI.RadSpinEditor()
			Me.checkBoxShowWeekend = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxShowFullMonth = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.trackBarColumnSize = New Telerik.WinControls.UI.RadTrackBar()
			Me.trackBarRowSize = New Telerik.WinControls.UI.RadTrackBar()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.panel1 = New Panel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.spinEditorAppointmentSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.checkBoxAutoSizeAppointments = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxExactTimeRendering = New Telerik.WinControls.UI.RadCheckBox()
			Me.timePickerRulerStart = New Telerik.WinControls.UI.RadTimePicker()
			Me.timePickerRulerEnd = New Telerik.WinControls.UI.RadTimePicker()
			Me.buttonBackToMonthView = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.checkBoxCellsOverflow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAppointmentsScrolling, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxEnableWeeksHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowWeeksHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxVerticalScroll, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dropDownWorkWeekEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dropDownWorkWeekStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorWeekCount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowWeekend, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxShowFullMonth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.trackBarColumnSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarRowSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditorAppointmentSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAutoSizeAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonBackToMonthView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 80)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.buttonBackToMonthView)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(230, 719)
			Me.settingsPanel.Size = New Size(230, 719)
			' 
			' radScheduler1
			' 
			dateTimeInterval1.End = New Date((CLng(0)))
			dateTimeInterval1.Start = New Date((CLng(0)))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval1
			Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.Dock = DockStyle.Fill
			Me.radScheduler1.Location = New Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2014, 6, 15, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2014, 6, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New Size(1473, 786)
			Me.radScheduler1.TabIndex = 2
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.checkBoxCellsOverflow)
			Me.radGroupBox1.Controls.Add(Me.checkBoxAppointmentsScrolling)
			Me.radGroupBox1.Controls.Add(Me.checkBoxEnableWeeksHeader)
			Me.radGroupBox1.Controls.Add(Me.checkBoxShowWeeksHeader)
			Me.radGroupBox1.Controls.Add(Me.checkBoxVerticalScroll)
			Me.radGroupBox1.HeaderText = "Visual settings"
			Me.radGroupBox1.Location = New Point(5, 76)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(220, 149)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Visual settings"
			' 
			' checkBoxCellsOverflow
			' 
			Me.checkBoxCellsOverflow.Anchor = AnchorStyles.Top
			Me.checkBoxCellsOverflow.Location = New Point(5, 117)
			Me.checkBoxCellsOverflow.Name = "checkBoxCellsOverflow"
			Me.checkBoxCellsOverflow.Size = New Size(161, 18)
			Me.checkBoxCellsOverflow.TabIndex = 4
			Me.checkBoxCellsOverflow.Text = "Enable cells overflow button"
			' 
			' checkBoxAppointmentsScrolling
			' 
			Me.checkBoxAppointmentsScrolling.Anchor = AnchorStyles.Top
			Me.checkBoxAppointmentsScrolling.Location = New Point(5, 93)
			Me.checkBoxAppointmentsScrolling.Name = "checkBoxAppointmentsScrolling"
			Me.checkBoxAppointmentsScrolling.Size = New Size(126, 18)
			Me.checkBoxAppointmentsScrolling.TabIndex = 3
			Me.checkBoxAppointmentsScrolling.Text = "Enable row scrollbars"
			' 
			' checkBoxEnableWeeksHeader
			' 
			Me.checkBoxEnableWeeksHeader.Anchor = AnchorStyles.Top
			Me.checkBoxEnableWeeksHeader.Location = New Point(5, 69)
			Me.checkBoxEnableWeeksHeader.Name = "checkBoxEnableWeeksHeader"
			Me.checkBoxEnableWeeksHeader.Size = New Size(125, 18)
			Me.checkBoxEnableWeeksHeader.TabIndex = 2
			Me.checkBoxEnableWeeksHeader.Text = "Enable weeks header"
			' 
			' checkBoxShowWeeksHeader
			' 
			Me.checkBoxShowWeeksHeader.Anchor = AnchorStyles.Top
			Me.checkBoxShowWeeksHeader.Location = New Point(5, 45)
			Me.checkBoxShowWeeksHeader.Name = "checkBoxShowWeeksHeader"
			Me.checkBoxShowWeeksHeader.Size = New Size(119, 18)
			Me.checkBoxShowWeeksHeader.TabIndex = 1
			Me.checkBoxShowWeeksHeader.Text = "Show weeks header"
			' 
			' checkBoxVerticalScroll
			' 
			Me.checkBoxVerticalScroll.Anchor = AnchorStyles.Top
			Me.checkBoxVerticalScroll.Location = New Point(5, 21)
			Me.checkBoxVerticalScroll.Name = "checkBoxVerticalScroll"
			Me.checkBoxVerticalScroll.Size = New Size(132, 18)
			Me.checkBoxVerticalScroll.TabIndex = 0
			Me.checkBoxVerticalScroll.Text = "Show vertical scrollbar"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.panel2)
			Me.radGroupBox2.Controls.Add(Me.checkBoxShowWeekend)
			Me.radGroupBox2.Controls.Add(Me.checkBoxShowFullMonth)
			Me.radGroupBox2.HeaderText = "View settings"
			Me.radGroupBox2.Location = New Point(5, 231)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(220, 145)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "View settings"
			' 
			' panel2
			' 
			Me.panel2.Anchor = AnchorStyles.Top
			Me.panel2.Controls.Add(Me.radLabel7)
			Me.panel2.Controls.Add(Me.radLabel8)
			Me.panel2.Controls.Add(Me.dropDownWorkWeekEnd)
			Me.panel2.Controls.Add(Me.dropDownWorkWeekStart)
			Me.panel2.Controls.Add(Me.radLabel6)
			Me.panel2.Controls.Add(Me.spinEditorWeekCount)
			Me.panel2.Location = New Point(5, 22)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New Size(210, 78)
			Me.panel2.TabIndex = 4
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New Point(0, 28)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(100, 18)
			Me.radLabel7.TabIndex = 25
			Me.radLabel7.Text = "Working week end"
			' 
			' radLabel8
			' 
			Me.radLabel8.Location = New Point(0, 3)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New Size(103, 18)
			Me.radLabel8.TabIndex = 24
			Me.radLabel8.Text = "Working week start"
			' 
			' dropDownWorkWeekEnd
			' 
			Me.dropDownWorkWeekEnd.Anchor = AnchorStyles.Top
			Me.dropDownWorkWeekEnd.DropDownAnimationEnabled = False
			Me.dropDownWorkWeekEnd.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.dropDownWorkWeekEnd.Location = New Point(126, 28)
			Me.dropDownWorkWeekEnd.Name = "dropDownWorkWeekEnd"
			Me.dropDownWorkWeekEnd.Size = New Size(78, 20)
			Me.dropDownWorkWeekEnd.TabIndex = 23
			Me.dropDownWorkWeekEnd.Text = "radDropDownList3"
			' 
			' dropDownWorkWeekStart
			' 
			Me.dropDownWorkWeekStart.Anchor = AnchorStyles.Top
			Me.dropDownWorkWeekStart.DropDownAnimationEnabled = False
			Me.dropDownWorkWeekStart.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.dropDownWorkWeekStart.Location = New Point(126, 2)
			Me.dropDownWorkWeekStart.Name = "dropDownWorkWeekStart"
			Me.dropDownWorkWeekStart.Size = New Size(78, 20)
			Me.dropDownWorkWeekStart.TabIndex = 22
			Me.dropDownWorkWeekStart.Text = "radDropDownList2"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New Point(0, 55)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(66, 18)
			Me.radLabel6.TabIndex = 21
			Me.radLabel6.Text = "Week count"
			' 
			' spinEditorWeekCount
			' 
			Me.spinEditorWeekCount.Anchor = AnchorStyles.Top
			Me.spinEditorWeekCount.Location = New Point(126, 54)
			Me.spinEditorWeekCount.Maximum = New Decimal(New Integer() { 8, 0, 0, 0})
			Me.spinEditorWeekCount.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditorWeekCount.Name = "spinEditorWeekCount"
			Me.spinEditorWeekCount.NullableValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinEditorWeekCount.Size = New Size(78, 20)
			Me.spinEditorWeekCount.TabIndex = 20
			Me.spinEditorWeekCount.TabStop = False
			Me.spinEditorWeekCount.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			' 
			' checkBoxShowWeekend
			' 
			Me.checkBoxShowWeekend.Anchor = AnchorStyles.Top
			Me.checkBoxShowWeekend.Location = New Point(5, 121)
			Me.checkBoxShowWeekend.Name = "checkBoxShowWeekend"
			Me.checkBoxShowWeekend.Size = New Size(95, 18)
			Me.checkBoxShowWeekend.TabIndex = 3
			Me.checkBoxShowWeekend.Text = "Show weekend"
			' 
			' checkBoxShowFullMonth
			' 
			Me.checkBoxShowFullMonth.Anchor = AnchorStyles.Top
			Me.checkBoxShowFullMonth.Location = New Point(5, 102)
			Me.checkBoxShowFullMonth.Name = "checkBoxShowFullMonth"
			Me.checkBoxShowFullMonth.Size = New Size(102, 18)
			Me.checkBoxShowFullMonth.TabIndex = 2
			Me.checkBoxShowFullMonth.Text = "Show full month"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.trackBarColumnSize)
			Me.radGroupBox3.Controls.Add(Me.trackBarRowSize)
			Me.radGroupBox3.Controls.Add(Me.radLabel3)
			Me.radGroupBox3.Controls.Add(Me.radLabel2)
			Me.radGroupBox3.Controls.Add(Me.panel1)
			Me.radGroupBox3.Controls.Add(Me.checkBoxAutoSizeAppointments)
			Me.radGroupBox3.Controls.Add(Me.checkBoxExactTimeRendering)
			Me.radGroupBox3.HeaderText = "Sizing options"
			Me.radGroupBox3.Location = New Point(5, 382)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Size = New Size(220, 278)
			Me.radGroupBox3.TabIndex = 3
			Me.radGroupBox3.Text = "Sizing options"
			' 
			' trackBarColumnSize
			' 
			Me.trackBarColumnSize.Anchor = AnchorStyles.Top
			Me.trackBarColumnSize.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
			Me.trackBarColumnSize.LargeTickFrequency = 1
			Me.trackBarColumnSize.Location = New Point(5, 202)
			Me.trackBarColumnSize.Maximum = 10F
			Me.trackBarColumnSize.Minimum = 1F
			Me.trackBarColumnSize.Name = "trackBarColumnSize"
			Me.trackBarColumnSize.Size = New Size(210, 52)
			Me.trackBarColumnSize.TabIndex = 6
			Me.trackBarColumnSize.Value = 1F
			' 
			' trackBarRowSize
			' 
			Me.trackBarRowSize.Anchor = AnchorStyles.Top
			Me.trackBarRowSize.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
			Me.trackBarRowSize.LargeTickFrequency = 1
			Me.trackBarRowSize.Location = New Point(5, 114)
			Me.trackBarRowSize.Maximum = 10F
			Me.trackBarRowSize.Minimum = 1F
			Me.trackBarRowSize.Name = "trackBarRowSize"
			Me.trackBarRowSize.Size = New Size(210, 52)
			Me.trackBarRowSize.TabIndex = 0
			Me.trackBarRowSize.Value = 1F
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 178)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(107, 18)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "Current column size:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 92)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(89, 18)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "Current row size:"
			' 
			' panel1
			' 
			Me.panel1.Anchor = AnchorStyles.Top
			Me.panel1.Controls.Add(Me.radLabel1)
			Me.panel1.Controls.Add(Me.spinEditorAppointmentSpacing)
			Me.panel1.Location = New Point(5, 61)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(210, 25)
			Me.panel1.TabIndex = 3
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(0, 4)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(114, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Appointment spacing"
			' 
			' spinEditorAppointmentSpacing
			' 
			Me.spinEditorAppointmentSpacing.Location = New Point(130, 3)
			Me.spinEditorAppointmentSpacing.Maximum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.spinEditorAppointmentSpacing.Name = "spinEditorAppointmentSpacing"
			Me.spinEditorAppointmentSpacing.Size = New Size(67, 20)
			Me.spinEditorAppointmentSpacing.TabIndex = 3
			Me.spinEditorAppointmentSpacing.TabStop = False
			' 
			' checkBoxAutoSizeAppointments
			' 
			Me.checkBoxAutoSizeAppointments.Anchor = AnchorStyles.Top
			Me.checkBoxAutoSizeAppointments.Location = New Point(5, 40)
			Me.checkBoxAutoSizeAppointments.Name = "checkBoxAutoSizeAppointments"
			Me.checkBoxAutoSizeAppointments.Size = New Size(139, 18)
			Me.checkBoxAutoSizeAppointments.TabIndex = 1
			Me.checkBoxAutoSizeAppointments.Text = "Auto size appointments"
			' 
			' checkBoxExactTimeRendering
			' 
			Me.checkBoxExactTimeRendering.Anchor = AnchorStyles.Top
			Me.checkBoxExactTimeRendering.Location = New Point(5, 21)
			Me.checkBoxExactTimeRendering.Name = "checkBoxExactTimeRendering"
			Me.checkBoxExactTimeRendering.Size = New Size(123, 18)
			Me.checkBoxExactTimeRendering.TabIndex = 0
			Me.checkBoxExactTimeRendering.Text = "Exact time rendering"
			' 
			' timePickerRulerStart
			' 
			Me.timePickerRulerStart.Anchor = AnchorStyles.Top
			Me.timePickerRulerStart.Location = New Point(90, 3)
			Me.timePickerRulerStart.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerStart.MinValue = New Date((CLng(0)))
			Me.timePickerRulerStart.Name = "timePickerRulerStart"
			Me.timePickerRulerStart.Size = New Size(107, 20)
			Me.timePickerRulerStart.TabIndex = 8
			Me.timePickerRulerStart.TabStop = False
			Me.timePickerRulerStart.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' timePickerRulerEnd
			' 
			Me.timePickerRulerEnd.Anchor = AnchorStyles.Top
			Me.timePickerRulerEnd.Location = New Point(90, 29)
			Me.timePickerRulerEnd.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
			Me.timePickerRulerEnd.MinValue = New Date((CLng(0)))
			Me.timePickerRulerEnd.Name = "timePickerRulerEnd"
			Me.timePickerRulerEnd.Size = New Size(107, 20)
			Me.timePickerRulerEnd.TabIndex = 9
			Me.timePickerRulerEnd.TabStop = False
			Me.timePickerRulerEnd.Value = New Date(2014, 6, 9, 14, 58, 13, 0)
			' 
			' buttonBackToMonthView
			' 
			Me.buttonBackToMonthView.Anchor = AnchorStyles.Top
			Me.buttonBackToMonthView.Location = New Point(5, 32)
			Me.buttonBackToMonthView.Name = "buttonBackToMonthView"
			Me.buttonBackToMonthView.Size = New Size(220, 24)
			Me.buttonBackToMonthView.TabIndex = 4
			Me.buttonBackToMonthView.Text = "Back to Month View"
'			Me.buttonBackToMonthView.Click += New System.EventHandler(Me.buttonBackToMonthView_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 796)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.checkBoxCellsOverflow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAppointmentsScrolling, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxEnableWeeksHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowWeeksHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxVerticalScroll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dropDownWorkWeekEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dropDownWorkWeekStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorWeekCount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowWeekend, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxShowFullMonth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.trackBarColumnSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarRowSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditorAppointmentSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAutoSizeAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePickerRulerEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonBackToMonthView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private panel1 As Panel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private spinEditorAppointmentSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private checkBoxAutoSizeAppointments As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxExactTimeRendering As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxCellsOverflow As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxAppointmentsScrolling As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxEnableWeeksHeader As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxShowWeeksHeader As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxVerticalScroll As Telerik.WinControls.UI.RadCheckBox
		Private trackBarColumnSize As Telerik.WinControls.UI.RadTrackBar
		Private trackBarRowSize As Telerik.WinControls.UI.RadTrackBar
		Private checkBoxShowWeekend As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxShowFullMonth As Telerik.WinControls.UI.RadCheckBox
		Private timePickerRulerStart As Telerik.WinControls.UI.RadTimePicker
		Private timePickerRulerEnd As Telerik.WinControls.UI.RadTimePicker
		Private panel2 As Panel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private spinEditorWeekCount As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private dropDownWorkWeekEnd As Telerik.WinControls.UI.RadDropDownList
		Private dropDownWorkWeekStart As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents buttonBackToMonthView As Telerik.WinControls.UI.RadButton
	End Class
End Namespace