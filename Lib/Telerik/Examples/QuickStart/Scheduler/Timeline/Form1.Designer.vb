Namespace Telerik.Examples.WinControls.Scheduler.Timeline
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
            Dim dateTimeInterval2 As New Telerik.WinControls.UI.DateTimeInterval()
            Dim schedulerDailyPrintStyle2 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
            Me.radDateTimePickerStart = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radDateTimePickerEnd = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorTimeSlots = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radRadioButtonWeek = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonMonth = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHour = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonDay = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupBoxRenderingOptions = New Telerik.WinControls.UI.RadGroupBox()
            Me.radSpinEditorVerticalSpacing = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabelVerticalSpacing = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBoxAutoSizeAppointments = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxExactTimeRendering = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBoxColumnSizing = New Telerik.WinControls.UI.RadGroupBox()
            Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePickerStart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePickerEnd, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorTimeSlots, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonWeek, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonMonth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonDay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            CType(Me.radGroupBoxRenderingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxRenderingOptions.SuspendLayout()
            CType(Me.radSpinEditorVerticalSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelVerticalSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxAutoSizeAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBoxColumnSizing, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxColumnSizing.SuspendLayout()
            CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBoxColumnSizing)
            Me.settingsPanel.Controls.Add(Me.radGroupBoxRenderingOptions)
            Me.settingsPanel.Controls.Add(Me.radGroupBox3)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 832)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxRenderingOptions, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxColumnSizing, 0)
            ' 
            ' radScheduler1
            ' 
            dateTimeInterval2.[End] = New System.DateTime(CLng(0))
            dateTimeInterval2.Start = New System.DateTime(CLng(0))
            Me.radScheduler1.AccessibleInterval = dateTimeInterval2
            Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Timeline
            Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radScheduler1.DataSource = Nothing
            Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScheduler1.Location = New System.Drawing.Point(0, 0)
            Me.radScheduler1.Name = "radScheduler1"
            schedulerDailyPrintStyle2.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            schedulerDailyPrintStyle2.DateEndRange = New System.DateTime(2014, 6, 10, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            schedulerDailyPrintStyle2.DateStartRange = New System.DateTime(2014, 6, 5, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0F, System.Drawing.FontStyle.Bold)
            Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle2
            Me.radScheduler1.Size = New System.Drawing.Size(1531, 990)
            Me.radScheduler1.TabIndex = 1
            Me.radScheduler1.Text = "radScheduler1"
            ' 
            ' radDateTimePickerStart
            ' 
            Me.radDateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radDateTimePickerStart.Location = New System.Drawing.Point(5, 43)
            Me.radDateTimePickerStart.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, _
                0)
            Me.radDateTimePickerStart.Name = "radDateTimePickerStart"
            Me.radDateTimePickerStart.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, _
                0)
            Me.radDateTimePickerStart.Size = New System.Drawing.Size(170, 20)
            Me.radDateTimePickerStart.TabIndex = 1
            Me.radDateTimePickerStart.TabStop = False
            Me.radDateTimePickerStart.Text = "Tuesday, January 12, 2010"
            Me.radDateTimePickerStart.Value = New System.DateTime(2010, 1, 12, 9, 56, 48, _
                405)
            ' 
            ' radDateTimePickerEnd
            ' 
            Me.radDateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radDateTimePickerEnd.Location = New System.Drawing.Point(5, 91)
            Me.radDateTimePickerEnd.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, _
                0)
            Me.radDateTimePickerEnd.Name = "radDateTimePickerEnd"
            Me.radDateTimePickerEnd.NullDate = New System.DateTime(1900, 1, 1, 0, 0, 0, _
                0)
            Me.radDateTimePickerEnd.Size = New System.Drawing.Size(170, 20)
            Me.radDateTimePickerEnd.TabIndex = 2
            Me.radDateTimePickerEnd.TabStop = False
            Me.radDateTimePickerEnd.Text = "Tuesday, January 12, 2010"
            Me.radDateTimePickerEnd.Value = New System.DateTime(2010, 1, 12, 9, 57, 3, _
                799)
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(5, 23)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(90, 18)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Text = "Range Start Date"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel2.Location = New System.Drawing.Point(5, 71)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(85, 18)
            Me.radLabel2.TabIndex = 4
            Me.radLabel2.Text = "Range End Date"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox2.Controls.Add(Me.radLabel4)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorTimeSlots)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonWeek)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonMonth)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonHour)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonDay)
            Me.radGroupBox2.HeaderText = "Time scales"
            Me.radGroupBox2.Location = New System.Drawing.Point(10, 37)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox2.Size = New System.Drawing.Size(180, 179)
            Me.radGroupBox2.TabIndex = 6
            Me.radGroupBox2.Text = "Time scales"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel4.Location = New System.Drawing.Point(5, 128)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(92, 18)
            Me.radLabel4.TabIndex = 9
            Me.radLabel4.Text = "Visible Time Slots"
            ' 
            ' radSpinEditorTimeSlots
            ' 
            Me.radSpinEditorTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorTimeSlots.Location = New System.Drawing.Point(5, 148)
            Me.radSpinEditorTimeSlots.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditorTimeSlots.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.radSpinEditorTimeSlots.Name = "radSpinEditorTimeSlots"
            ' 
            ' 
            ' 
            Me.radSpinEditorTimeSlots.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorTimeSlots.Size = New System.Drawing.Size(170, 20)
            Me.radSpinEditorTimeSlots.TabIndex = 8
            Me.radSpinEditorTimeSlots.TabStop = False
            Me.radSpinEditorTimeSlots.Value = New Decimal(New Integer() {7, 0, 0, 0})
            ' 
            ' radRadioButtonWeek
            ' 
            Me.radRadioButtonWeek.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonWeek.Location = New System.Drawing.Point(5, 80)
            Me.radRadioButtonWeek.Name = "radRadioButtonWeek"
            Me.radRadioButtonWeek.Size = New System.Drawing.Size(48, 18)
            Me.radRadioButtonWeek.TabIndex = 2
            Me.radRadioButtonWeek.Text = "Week"
            ' 
            ' radRadioButtonMonth
            ' 
            Me.radRadioButtonMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonMonth.Location = New System.Drawing.Point(5, 104)
            Me.radRadioButtonMonth.Name = "radRadioButtonMonth"
            Me.radRadioButtonMonth.Size = New System.Drawing.Size(54, 18)
            Me.radRadioButtonMonth.TabIndex = 2
            Me.radRadioButtonMonth.Text = "Month"
            ' 
            ' radRadioButtonHour
            ' 
            Me.radRadioButtonHour.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHour.Location = New System.Drawing.Point(5, 56)
            Me.radRadioButtonHour.Name = "radRadioButtonHour"
            Me.radRadioButtonHour.Size = New System.Drawing.Size(45, 18)
            Me.radRadioButtonHour.TabIndex = 1
            Me.radRadioButtonHour.Text = "Hour"
            ' 
            ' radRadioButtonDay
            ' 
            Me.radRadioButtonDay.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonDay.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButtonDay.Location = New System.Drawing.Point(5, 32)
            Me.radRadioButtonDay.Name = "radRadioButtonDay"
            Me.radRadioButtonDay.Size = New System.Drawing.Size(39, 18)
            Me.radRadioButtonDay.TabIndex = 0
            Me.radRadioButtonDay.TabStop = True
            Me.radRadioButtonDay.Text = "Day"
            Me.radRadioButtonDay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radGroupBox3
            ' 
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox3.Controls.Add(Me.radLabel1)
            Me.radGroupBox3.Controls.Add(Me.radDateTimePickerEnd)
            Me.radGroupBox3.Controls.Add(Me.radDateTimePickerStart)
            Me.radGroupBox3.Controls.Add(Me.radLabel2)
            Me.radGroupBox3.HeaderText = "Date options"
            Me.radGroupBox3.Location = New System.Drawing.Point(10, 222)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox3.Size = New System.Drawing.Size(180, 128)
            Me.radGroupBox3.TabIndex = 7
            Me.radGroupBox3.Text = "Date options"
            ' 
            ' radGroupBoxRenderingOptions
            ' 
            Me.radGroupBoxRenderingOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxRenderingOptions.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxRenderingOptions.Controls.Add(Me.radSpinEditorVerticalSpacing)
            Me.radGroupBoxRenderingOptions.Controls.Add(Me.radLabelVerticalSpacing)
            Me.radGroupBoxRenderingOptions.Controls.Add(Me.radCheckBoxAutoSizeAppointments)
            Me.radGroupBoxRenderingOptions.Controls.Add(Me.radCheckBoxExactTimeRendering)
            Me.radGroupBoxRenderingOptions.HeaderText = "Rendering options"
            Me.radGroupBoxRenderingOptions.Location = New System.Drawing.Point(10, 356)
            Me.radGroupBoxRenderingOptions.Name = "radGroupBoxRenderingOptions"
            Me.radGroupBoxRenderingOptions.Size = New System.Drawing.Size(180, 127)
            Me.radGroupBoxRenderingOptions.TabIndex = 8
            Me.radGroupBoxRenderingOptions.Text = "Rendering options"
            ' 
            ' radSpinEditorVerticalSpacing
            ' 
            Me.radSpinEditorVerticalSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorVerticalSpacing.Location = New System.Drawing.Point(5, 94)
            Me.radSpinEditorVerticalSpacing.Name = "radSpinEditorVerticalSpacing"
            Me.radSpinEditorVerticalSpacing.Size = New System.Drawing.Size(170, 20)
            Me.radSpinEditorVerticalSpacing.TabIndex = 1
            Me.radSpinEditorVerticalSpacing.TabStop = False
            ' 
            ' radLabelVerticalSpacing
            ' 
            Me.radLabelVerticalSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabelVerticalSpacing.Location = New System.Drawing.Point(5, 70)
            Me.radLabelVerticalSpacing.Name = "radLabelVerticalSpacing"
            Me.radLabelVerticalSpacing.Size = New System.Drawing.Size(159, 18)
            Me.radLabelVerticalSpacing.TabIndex = 1
            Me.radLabelVerticalSpacing.Text = "Appointments Vertical Spacing"
            ' 
            ' radCheckBoxAutoSizeAppointments
            ' 
            Me.radCheckBoxAutoSizeAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxAutoSizeAppointments.Checked = True
            Me.radCheckBoxAutoSizeAppointments.Location = New System.Drawing.Point(5, 46)
            Me.radCheckBoxAutoSizeAppointments.Name = "radCheckBoxAutoSizeAppointments"
            Me.radCheckBoxAutoSizeAppointments.Size = New System.Drawing.Size(141, 18)
            Me.radCheckBoxAutoSizeAppointments.TabIndex = 0
            Me.radCheckBoxAutoSizeAppointments.Text = "Auto Size Appointments"
            ' 
            ' radCheckBoxExactTimeRendering
            ' 
            Me.radCheckBoxExactTimeRendering.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxExactTimeRendering.Location = New System.Drawing.Point(5, 22)
            Me.radCheckBoxExactTimeRendering.Name = "radCheckBoxExactTimeRendering"
            Me.radCheckBoxExactTimeRendering.Size = New System.Drawing.Size(128, 18)
            Me.radCheckBoxExactTimeRendering.TabIndex = 0
            Me.radCheckBoxExactTimeRendering.Text = "Exact Time Rendering"
            ' 
            ' radGroupBoxColumnSizing
            ' 
            Me.radGroupBoxColumnSizing.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxColumnSizing.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxColumnSizing.Controls.Add(Me.radTrackBar1)
            Me.radGroupBoxColumnSizing.HeaderText = "Resize the current column"
            Me.radGroupBoxColumnSizing.Location = New System.Drawing.Point(10, 489)
            Me.radGroupBoxColumnSizing.Name = "radGroupBoxColumnSizing"
            Me.radGroupBoxColumnSizing.Size = New System.Drawing.Size(180, 86)
            Me.radGroupBoxColumnSizing.TabIndex = 9
            Me.radGroupBoxColumnSizing.Text = "Resize the current column"
            ' 
            ' radTrackBar1
            ' 
            Me.radTrackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
            Me.radTrackBar1.LargeTickFrequency = 1
            Me.radTrackBar1.Location = New System.Drawing.Point(5, 21)
            Me.radTrackBar1.Maximum = 10.0F
            Me.radTrackBar1.Minimum = 1.0F
            Me.radTrackBar1.Name = "radTrackBar1"
            Me.radTrackBar1.Size = New System.Drawing.Size(170, 55)
            Me.radTrackBar1.TabIndex = 0
            Me.radTrackBar1.Text = "radTrackBar1"
            Me.radTrackBar1.Value = 1.0F
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radScheduler1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1541, 1000)
            Me.Tag = ""
            Me.Controls.SetChildIndex(Me.radScheduler1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePickerStart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePickerEnd, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorTimeSlots, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonWeek, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonMonth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonDay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.radGroupBox3.PerformLayout()
            CType(Me.radGroupBoxRenderingOptions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxRenderingOptions.ResumeLayout(False)
            Me.radGroupBoxRenderingOptions.PerformLayout()
            CType(Me.radSpinEditorVerticalSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelVerticalSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAutoSizeAppointments, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxExactTimeRendering, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxColumnSizing, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxColumnSizing.ResumeLayout(False)
            Me.radGroupBoxColumnSizing.PerformLayout()
            CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radDateTimePickerEnd As Telerik.WinControls.UI.RadDateTimePicker
        Private radDateTimePickerStart As Telerik.WinControls.UI.RadDateTimePicker
        Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radRadioButtonHour As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonDay As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonWeek As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonMonth As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorTimeSlots As Telerik.WinControls.UI.RadSpinEditor
        Private radGroupBoxColumnSizing As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBoxRenderingOptions As Telerik.WinControls.UI.RadGroupBox
        Private radSpinEditorVerticalSpacing As Telerik.WinControls.UI.RadSpinEditor
        Private radCheckBoxAutoSizeAppointments As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxExactTimeRendering As Telerik.WinControls.UI.RadCheckBox
        Private radLabelVerticalSpacing As Telerik.WinControls.UI.RadLabel
        Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
    End Class
End Namespace