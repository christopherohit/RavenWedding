Namespace Telerik.Examples.WinControls.Scheduler.CustomWorkTime
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditor3 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditor4 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radSpinEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			Me.tableLayoutPanel3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 12)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radButton1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(192, 1240)
			Me.settingsPanel.Size = New Size(192, 1240)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.tableLayoutPanel1)
			Me.radGroupBox1.HeaderText = "WorkTime Settings"
			Me.radGroupBox1.Location = New Point(5, 48)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(182, 143)
			Me.radGroupBox1.TabIndex = 5
			Me.radGroupBox1.Text = "WorkTime Settings"
			' 
			' radDateTimePicker2
			' 
			Me.radDateTimePicker2.CustomFormat = "HH:mm"
			Me.radDateTimePicker2.Format = DateTimePickerFormat.Custom
			Me.radDateTimePicker2.Location = New Point(3, 81)
			Me.radDateTimePicker2.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.Name = "radDateTimePicker2"
			Me.radDateTimePicker2.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker2.ShowUpDown = True
			Me.radDateTimePicker2.Size = New Size(127, 20)
			Me.radDateTimePicker2.TabIndex = 3
			Me.radDateTimePicker2.TabStop = False
			Me.radDateTimePicker2.Text = "16:45"
			Me.radDateTimePicker2.Value = New Date(2010, 1, 18, 16, 45, 7, 444)
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 55)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(20, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "To:"
			' 
			' radDateTimePicker1
			' 
			Me.radDateTimePicker1.CustomFormat = "HH:mm"
			Me.radDateTimePicker1.Format = DateTimePickerFormat.Custom
			Me.radDateTimePicker1.Location = New Point(3, 29)
			Me.radDateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.Name = "radDateTimePicker1"
			Me.radDateTimePicker1.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
			Me.radDateTimePicker1.ShowUpDown = True
			Me.radDateTimePicker1.Size = New Size(127, 20)
			Me.radDateTimePicker1.TabIndex = 1
			Me.radDateTimePicker1.TabStop = False
			Me.radDateTimePicker1.Text = "16:44"
			Me.radDateTimePicker1.Value = New Date(2010, 1, 18, 16, 44, 48, 954)
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(3, 3)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(33, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "From:"
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
			schedulerDailyPrintStyle1.DateEndRange = New Date(2014, 6, 15, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2014, 6, 10, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
			Me.radScheduler1.Size = New Size(1230, 709)
			Me.radScheduler1.TabIndex = 1
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Nothing
			Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
			Me.radSchedulerNavigator1.Dock = DockStyle.Top
			Me.radSchedulerNavigator1.Location = New Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New Size(1230, 77)
			Me.radSchedulerNavigator1.TabIndex = 2
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.tableLayoutPanel2)
			Me.radGroupBox2.HeaderText = "WorkWeek Settings"
			Me.radGroupBox2.Location = New Point(5, 197)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(182, 147)
			Me.radGroupBox2.TabIndex = 6
			Me.radGroupBox2.Text = "WorkWeek Settings"
			' 
			' radDropDownList2
			' 
			Me.radDropDownList2.DropDownAnimationEnabled = False
			Me.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList2.Location = New Point(3, 87)
			Me.radDropDownList2.Name = "radDropDownList2"
			Me.radDropDownList2.Size = New Size(127, 20)
			Me.radDropDownList2.TabIndex = 4
			Me.radDropDownList2.Text = "radDropDownList2"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(3, 31)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(127, 20)
			Me.radDropDownList1.TabIndex = 3
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(3, 59)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(20, 18)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "To:"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(3, 3)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(33, 18)
			Me.radLabel4.TabIndex = 0
			Me.radLabel4.Text = "From:"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.tableLayoutPanel3)
			Me.radGroupBox3.HeaderText = "Ruler Settings"
			Me.radGroupBox3.Location = New Point(5, 350)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New Size(182, 277)
			Me.radGroupBox3.TabIndex = 7
			Me.radGroupBox3.Text = "Ruler Settings"
			' 
			' radSpinEditor3
			' 
			Me.radSpinEditor3.Location = New Point(3, 199)
			Me.radSpinEditor3.Maximum = New Decimal(New Integer() { 59, 0, 0, 0})
			Me.radSpinEditor3.Name = "radSpinEditor3"
			Me.radSpinEditor3.Size = New Size(142, 20)
			Me.radSpinEditor3.TabIndex = 8
			Me.radSpinEditor3.TabStop = False
'			Me.radSpinEditor3.ValueChanged += New System.EventHandler(Me.radSpinEditor3_ValueChanged)
			' 
			' radSpinEditor4
			' 
			Me.radSpinEditor4.Location = New Point(3, 143)
			Me.radSpinEditor4.Maximum = New Decimal(New Integer() { 24, 0, 0, 0})
			Me.radSpinEditor4.Name = "radSpinEditor4"
			Me.radSpinEditor4.Size = New Size(142, 20)
			Me.radSpinEditor4.TabIndex = 7
			Me.radSpinEditor4.TabStop = False
'			Me.radSpinEditor4.ValueChanged += New System.EventHandler(Me.radSpinEditor4_ValueChanged)
			' 
			' radLabel7
			' 
			Me.radLabel7.Location = New Point(3, 171)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(92, 18)
			Me.radLabel7.TabIndex = 6
			Me.radLabel7.Text = "EndScaleMinutes:"
			' 
			' radLabel8
			' 
			Me.radLabel8.Location = New Point(3, 115)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New Size(52, 18)
			Me.radLabel8.TabIndex = 5
			Me.radLabel8.Text = "EndScale:"
			' 
			' radSpinEditor2
			' 
			Me.radSpinEditor2.Location = New Point(3, 87)
			Me.radSpinEditor2.Maximum = New Decimal(New Integer() { 59, 0, 0, 0})
			Me.radSpinEditor2.Name = "radSpinEditor2"
			Me.radSpinEditor2.Size = New Size(142, 20)
			Me.radSpinEditor2.TabIndex = 4
			Me.radSpinEditor2.TabStop = False
'			Me.radSpinEditor2.ValueChanged += New System.EventHandler(Me.radSpinEditor2_ValueChanged)
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(3, 31)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 24, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			Me.radSpinEditor1.Size = New Size(142, 20)
			Me.radSpinEditor1.TabIndex = 3
			Me.radSpinEditor1.TabStop = False
'			Me.radSpinEditor1.ValueChanged += New System.EventHandler(Me.radSpinEditor1_ValueChanged)
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New Point(3, 59)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(97, 18)
			Me.radLabel5.TabIndex = 2
			Me.radLabel5.Text = "StartScaleMinutes:"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New Point(3, 3)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(57, 18)
			Me.radLabel6.TabIndex = 0
			Me.radLabel6.Text = "StartScale:"
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(5, 646)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(182, 24)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Show WorkTime Exceptions"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.radDateTimePicker2, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radDateTimePicker1, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
			Me.tableLayoutPanel1.Location = New Point(5, 23)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 4
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.Size = New Size(172, 107)
			Me.tableLayoutPanel1.TabIndex = 4
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel2.ColumnCount = 1
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel4, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.radDropDownList2, 0, 3)
			Me.tableLayoutPanel2.Controls.Add(Me.radDropDownList1, 0, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.radLabel3, 0, 2)
			Me.tableLayoutPanel2.Location = New Point(5, 19)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 4
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.Size = New Size(172, 115)
			Me.tableLayoutPanel2.TabIndex = 5
			' 
			' tableLayoutPanel3
			' 
			Me.tableLayoutPanel3.Anchor = AnchorStyles.Top
			Me.tableLayoutPanel3.ColumnCount = 1
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
			Me.tableLayoutPanel3.Controls.Add(Me.radLabel6, 0, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.radSpinEditor3, 0, 7)
			Me.tableLayoutPanel3.Controls.Add(Me.radSpinEditor1, 0, 1)
			Me.tableLayoutPanel3.Controls.Add(Me.radLabel7, 0, 6)
			Me.tableLayoutPanel3.Controls.Add(Me.radSpinEditor4, 0, 5)
			Me.tableLayoutPanel3.Controls.Add(Me.radLabel5, 0, 2)
			Me.tableLayoutPanel3.Controls.Add(Me.radSpinEditor2, 0, 3)
			Me.tableLayoutPanel3.Controls.Add(Me.radLabel8, 0, 4)
			Me.tableLayoutPanel3.Location = New Point(5, 23)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 8
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
			Me.tableLayoutPanel3.Size = New Size(172, 228)
			Me.tableLayoutPanel3.TabIndex = 9
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New Size(1240, 796)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			CType(Me.radSpinEditor3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.tableLayoutPanel2.ResumeLayout(False)
			Me.tableLayoutPanel2.PerformLayout()
			Me.tableLayoutPanel3.ResumeLayout(False)
			Me.tableLayoutPanel3.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditor3 As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditor4 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private tableLayoutPanel3 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace