Namespace Telerik.Examples.WinControls.Buttons.ToggleSwitch
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radLabelNewAppointment = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabelReminder = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelReminderDate = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelReminderTime = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelRecurrence = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelRecurrenceDate = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelPlaySound = New Telerik.WinControls.UI.RadLabel()
            Me.radToggleSwitchReminder = New Telerik.WinControls.UI.RadToggleSwitch()
            Me.radToggleSwitchRecurrence = New Telerik.WinControls.UI.RadToggleSwitch()
            Me.radToggleSwitchPlaySound = New Telerik.WinControls.UI.RadToggleSwitch()
            Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radTimePicker1 = New Telerik.WinControls.UI.RadTimePicker()
            Me.radDropDownListRecurrence = New Telerik.WinControls.UI.RadDropDownList()
            Me.radButtonCreateAppointment = New Telerik.WinControls.UI.RadButton()
            Me.radCheckBoxAllowAnimation = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxRightToLeft = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabelSwitchElasticity = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorSwitchElasticity = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabelThumbTickness = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorThumbTickness = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabelAnimationFrames = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorAnimationFrames = New Telerik.WinControls.UI.RadSpinEditor()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelNewAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelReminder, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelReminderDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelReminderTime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelRecurrenceDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelPlaySound, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleSwitchReminder, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleSwitchRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleSwitchPlaySound, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonCreateAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxAllowAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSwitchElasticity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorSwitchElasticity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelThumbTickness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorThumbTickness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelAnimationFrames, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorAnimationFrames, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(739, 66)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditorAnimationFrames)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelAnimationFrames)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditorThumbTickness)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelThumbTickness)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditorSwitchElasticity)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelSwitchElasticity)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxRightToLeft)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxAllowAnimation)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 330)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 330)
            '
            'optionsLabel
            '
            Me.optionsLabel.Location = New System.Drawing.Point(24, 284)
            '
            'radLabelNewAppointment
            '
            Me.radLabelNewAppointment.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabelNewAppointment, 2)
            Me.radLabelNewAppointment.Font = New System.Drawing.Font("Segoe UI", 14.0!)
            Me.radLabelNewAppointment.Location = New System.Drawing.Point(0, 5)
            Me.radLabelNewAppointment.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelNewAppointment.Name = "radLabelNewAppointment"
            Me.radLabelNewAppointment.Size = New System.Drawing.Size(162, 29)
            Me.radLabelNewAppointment.TabIndex = 0
            Me.radLabelNewAppointment.Text = "New appointment"
            '
            'radTextBox1
            '
            Me.radTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radTextBox1, 2)
            Me.radTextBox1.Location = New System.Drawing.Point(3, 48)
            Me.radTextBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(294, 20)
            Me.radTextBox1.TabIndex = 1
            Me.radTextBox1.Text = "Team Meeting"
            '
            'radLabelReminder
            '
            Me.radLabelReminder.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabelReminder.Font = New System.Drawing.Font("Segoe UI", 10.25!)
            Me.radLabelReminder.Location = New System.Drawing.Point(0, 86)
            Me.radLabelReminder.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelReminder.Name = "radLabelReminder"
            Me.radLabelReminder.Size = New System.Drawing.Size(67, 22)
            Me.radLabelReminder.TabIndex = 2
            Me.radLabelReminder.Text = "Reminder"
            '
            'radLabelReminderDate
            '
            Me.radLabelReminderDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabelReminderDate.Font = New System.Drawing.Font("Segoe UI", 8.75!)
            Me.radLabelReminderDate.Location = New System.Drawing.Point(0, 134)
            Me.radLabelReminderDate.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelReminderDate.Name = "radLabelReminderDate"
            Me.radLabelReminderDate.Size = New System.Drawing.Size(31, 19)
            Me.radLabelReminderDate.TabIndex = 3
            Me.radLabelReminderDate.Text = "Date"
            '
            'radLabelReminderTime
            '
            Me.radLabelReminderTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.radLabelReminderTime.Font = New System.Drawing.Font("Segoe UI", 8.75!)
            Me.radLabelReminderTime.Location = New System.Drawing.Point(0, 212)
            Me.radLabelReminderTime.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelReminderTime.Name = "radLabelReminderTime"
            Me.radLabelReminderTime.Size = New System.Drawing.Size(32, 19)
            Me.radLabelReminderTime.TabIndex = 4
            Me.radLabelReminderTime.Text = "Time"
            '
            'radLabelRecurrence
            '
            Me.radLabelRecurrence.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabelRecurrence.Font = New System.Drawing.Font("Segoe UI", 10.25!)
            Me.radLabelRecurrence.Location = New System.Drawing.Point(0, 281)
            Me.radLabelRecurrence.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelRecurrence.Name = "radLabelRecurrence"
            Me.radLabelRecurrence.Size = New System.Drawing.Size(76, 22)
            Me.radLabelRecurrence.TabIndex = 5
            Me.radLabelRecurrence.Text = "Recurrence"
            '
            'radLabelRecurrenceDate
            '
            Me.radLabelRecurrenceDate.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabelRecurrenceDate.Font = New System.Drawing.Font("Segoe UI", 8.75!)
            Me.radLabelRecurrenceDate.Location = New System.Drawing.Point(0, 322)
            Me.radLabelRecurrenceDate.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelRecurrenceDate.Name = "radLabelRecurrenceDate"
            Me.radLabelRecurrenceDate.Size = New System.Drawing.Size(31, 19)
            Me.radLabelRecurrenceDate.TabIndex = 6
            Me.radLabelRecurrenceDate.Text = "Date"
            '
            'radLabelPlaySound
            '
            Me.radLabelPlaySound.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabelPlaySound.Font = New System.Drawing.Font("Segoe UI", 10.25!)
            Me.radLabelPlaySound.Location = New System.Drawing.Point(0, 398)
            Me.radLabelPlaySound.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.radLabelPlaySound.Name = "radLabelPlaySound"
            Me.radLabelPlaySound.Size = New System.Drawing.Size(75, 22)
            Me.radLabelPlaySound.TabIndex = 7
            Me.radLabelPlaySound.Text = "Play sound"
            '
            'radToggleSwitchReminder
            '
            Me.radToggleSwitchReminder.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.radToggleSwitchReminder.Location = New System.Drawing.Point(247, 87)
            Me.radToggleSwitchReminder.Name = "radToggleSwitchReminder"
            Me.radToggleSwitchReminder.Size = New System.Drawing.Size(50, 20)
            Me.radToggleSwitchReminder.TabIndex = 8
            AddHandler Me.radToggleSwitchReminder.ValueChanged, AddressOf Me.radToggleSwitchReminder_ValueChanged
            '
            'radToggleSwitchRecurrence
            '
            Me.radToggleSwitchRecurrence.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.radToggleSwitchRecurrence.Location = New System.Drawing.Point(247, 282)
            Me.radToggleSwitchRecurrence.Name = "radToggleSwitchRecurrence"
            Me.radToggleSwitchRecurrence.Size = New System.Drawing.Size(50, 20)
            Me.radToggleSwitchRecurrence.TabIndex = 9
            AddHandler Me.radToggleSwitchRecurrence.ValueChanged, AddressOf Me.radToggleSwitchRecurrence_ValueChanged
            '
            'radToggleSwitchPlaySound
            '
            Me.radToggleSwitchPlaySound.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.radToggleSwitchPlaySound.Location = New System.Drawing.Point(247, 399)
            Me.radToggleSwitchPlaySound.Name = "radToggleSwitchPlaySound"
            Me.radToggleSwitchPlaySound.Size = New System.Drawing.Size(50, 20)
            Me.radToggleSwitchPlaySound.TabIndex = 10
            Me.radToggleSwitchPlaySound.Value = False
            '
            'radDateTimePicker1
            '
            Me.radDateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radDateTimePicker1, 2)
            Me.radDateTimePicker1.CustomFormat = "dd\/MM\/yyyy"
            Me.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.radDateTimePicker1.Location = New System.Drawing.Point(3, 165)
            Me.radDateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radDateTimePicker1.Name = "radDateTimePicker1"
            Me.radDateTimePicker1.Size = New System.Drawing.Size(294, 20)
            Me.radDateTimePicker1.TabIndex = 11
            Me.radDateTimePicker1.TabStop = False
            Me.radDateTimePicker1.Text = "11/06/2015"
            Me.radDateTimePicker1.Value = New Date(2015, 6, 11, 11, 15, 0, 0)
            '
            'radTimePicker1
            '
            Me.radTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radTimePicker1, 2)
            Me.radTimePicker1.Location = New System.Drawing.Point(3, 243)
            Me.radTimePicker1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radTimePicker1.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
            Me.radTimePicker1.MinValue = New Date(CType(0, Long))
            Me.radTimePicker1.Name = "radTimePicker1"
            Me.radTimePicker1.Size = New System.Drawing.Size(294, 20)
            Me.radTimePicker1.TabIndex = 12
            Me.radTimePicker1.TabStop = False
            Me.radTimePicker1.Value = New Date(2015, 6, 11, 11, 15, 0, 0)
            '
            'radDropDownListRecurrence
            '
            Me.radDropDownListRecurrence.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radDropDownListRecurrence, 2)
            Me.radDropDownListRecurrence.DropDownHeight = 188
            RadListDataItem1.Text = "Every hour"
            RadListDataItem2.Selected = True
            RadListDataItem2.Text = "Every day"
            RadListDataItem3.Text = "Every week"
            RadListDataItem4.Text = "Every month"
            Me.radDropDownListRecurrence.Items.Add(RadListDataItem1)
            Me.radDropDownListRecurrence.Items.Add(RadListDataItem2)
            Me.radDropDownListRecurrence.Items.Add(RadListDataItem3)
            Me.radDropDownListRecurrence.Items.Add(RadListDataItem4)
            Me.radDropDownListRecurrence.Location = New System.Drawing.Point(3, 360)
            Me.radDropDownListRecurrence.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radDropDownListRecurrence.Name = "radDropDownListRecurrence"
            Me.radDropDownListRecurrence.Size = New System.Drawing.Size(294, 20)
            Me.radDropDownListRecurrence.TabIndex = 13
            Me.radDropDownListRecurrence.Text = "Every day"
            '
            'radButtonCreateAppointment
            '
            Me.radButtonCreateAppointment.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radButtonCreateAppointment, 2)
            Me.radButtonCreateAppointment.Location = New System.Drawing.Point(3, 436)
            Me.radButtonCreateAppointment.Name = "radButtonCreateAppointment"
            Me.radButtonCreateAppointment.Size = New System.Drawing.Size(120, 25)
            Me.radButtonCreateAppointment.TabIndex = 14
            Me.radButtonCreateAppointment.Text = "Create"
            AddHandler Me.radButtonCreateAppointment.Click, AddressOf Me.radButtonCreateAppointment_Click
            '
            'radCheckBoxAllowAnimation
            '
            Me.radCheckBoxAllowAnimation.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxAllowAnimation.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxAllowAnimation.Location = New System.Drawing.Point(5, 6)
            Me.radCheckBoxAllowAnimation.Name = "radCheckBoxAllowAnimation"
            Me.radCheckBoxAllowAnimation.Size = New System.Drawing.Size(103, 18)
            Me.radCheckBoxAllowAnimation.TabIndex = 1
            Me.radCheckBoxAllowAnimation.Text = "Allow Animation"
            Me.radCheckBoxAllowAnimation.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxAllowAnimation.ToggleStateChanged, AddressOf Me.radCheckBoxAllowAnimation_ToggleStateChanged
            '
            'radCheckBoxRightToLeft
            '
            Me.radCheckBoxRightToLeft.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxRightToLeft.Location = New System.Drawing.Point(5, 44)
            Me.radCheckBoxRightToLeft.Name = "radCheckBoxRightToLeft"
            Me.radCheckBoxRightToLeft.Size = New System.Drawing.Size(84, 18)
            Me.radCheckBoxRightToLeft.TabIndex = 2
            Me.radCheckBoxRightToLeft.Text = "Right To Left"
            AddHandler Me.radCheckBoxRightToLeft.ToggleStateChanged, AddressOf Me.radCheckBoxRightToLeft_ToggleStateChanged
            '
            'radLabelSwitchElasticity
            '
            Me.radLabelSwitchElasticity.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabelSwitchElasticity.Location = New System.Drawing.Point(5, 81)
            Me.radLabelSwitchElasticity.Name = "radLabelSwitchElasticity"
            Me.radLabelSwitchElasticity.Size = New System.Drawing.Size(85, 18)
            Me.radLabelSwitchElasticity.TabIndex = 3
            Me.radLabelSwitchElasticity.Text = "Switch Elasticity"
            '
            'radSpinEditorSwitchElasticity
            '
            Me.radSpinEditorSwitchElasticity.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorSwitchElasticity.DecimalPlaces = 2
            Me.radSpinEditorSwitchElasticity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.radSpinEditorSwitchElasticity.Location = New System.Drawing.Point(5, 109)
            Me.radSpinEditorSwitchElasticity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.radSpinEditorSwitchElasticity.Name = "radSpinEditorSwitchElasticity"
            Me.radSpinEditorSwitchElasticity.NullableValue = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.radSpinEditorSwitchElasticity.Size = New System.Drawing.Size(152, 20)
            Me.radSpinEditorSwitchElasticity.TabIndex = 4
            Me.radSpinEditorSwitchElasticity.TabStop = False
            Me.radSpinEditorSwitchElasticity.ThousandsSeparator = True
            Me.radSpinEditorSwitchElasticity.Value = New Decimal(New Integer() {5, 0, 0, 65536})
            AddHandler Me.radSpinEditorSwitchElasticity.ValueChanged, AddressOf Me.radSpinEditorSwitchElasticity_ValueChanged
            '
            'radLabelThumbTickness
            '
            Me.radLabelThumbTickness.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabelThumbTickness.Location = New System.Drawing.Point(5, 150)
            Me.radLabelThumbTickness.Name = "radLabelThumbTickness"
            Me.radLabelThumbTickness.Size = New System.Drawing.Size(86, 18)
            Me.radLabelThumbTickness.TabIndex = 5
            Me.radLabelThumbTickness.Text = "Thumb Tickness"
            '
            'radSpinEditorThumbTickness
            '
            Me.radSpinEditorThumbTickness.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorThumbTickness.Location = New System.Drawing.Point(5, 177)
            Me.radSpinEditorThumbTickness.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
            Me.radSpinEditorThumbTickness.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditorThumbTickness.Name = "radSpinEditorThumbTickness"
            Me.radSpinEditorThumbTickness.NullableValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorThumbTickness.Size = New System.Drawing.Size(152, 20)
            Me.radSpinEditorThumbTickness.TabIndex = 1
            Me.radSpinEditorThumbTickness.TabStop = False
            Me.radSpinEditorThumbTickness.Value = New Decimal(New Integer() {20, 0, 0, 0})
            AddHandler Me.radSpinEditorThumbTickness.ValueChanged, AddressOf Me.radSpinEditorThumbTickness_ValueChanged
            '
            'radLabelAnimationFrames
            '
            Me.radLabelAnimationFrames.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabelAnimationFrames.Location = New System.Drawing.Point(5, 217)
            Me.radLabelAnimationFrames.Name = "radLabelAnimationFrames"
            Me.radLabelAnimationFrames.Size = New System.Drawing.Size(97, 18)
            Me.radLabelAnimationFrames.TabIndex = 6
            Me.radLabelAnimationFrames.Text = "Animation Frames"
            '
            'radSpinEditorAnimationFrames
            '
            Me.radSpinEditorAnimationFrames.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radSpinEditorAnimationFrames.Location = New System.Drawing.Point(5, 247)
            Me.radSpinEditorAnimationFrames.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.radSpinEditorAnimationFrames.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.radSpinEditorAnimationFrames.Name = "radSpinEditorAnimationFrames"
            Me.radSpinEditorAnimationFrames.NullableValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorAnimationFrames.Size = New System.Drawing.Size(152, 20)
            Me.radSpinEditorAnimationFrames.TabIndex = 7
            Me.radSpinEditorAnimationFrames.TabStop = False
            Me.radSpinEditorAnimationFrames.Value = New Decimal(New Integer() {20, 0, 0, 0})
            AddHandler Me.radSpinEditorAnimationFrames.ValueChanged, AddressOf Me.radSpinEditorAnimationFrames_ValueChanged
            '
            'doubleBufferedTableLayoutPanel1
            '
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelNewAppointment, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonCreateAppointment, 0, 11)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelPlaySound, 0, 10)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radTextBox1, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelRecurrenceDate, 0, 8)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelReminder, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radTimePicker1, 0, 6)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radToggleSwitchRecurrence, 1, 7)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radToggleSwitchReminder, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker1, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelReminderDate, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelRecurrence, 0, 7)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelReminderTime, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownListRecurrence, 0, 9)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radToggleSwitchPlaySound, 1, 10)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(53, 39)
            Me.doubleBufferedTableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 12
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497465!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.527874!))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(300, 469)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 15
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2067, 1157)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelNewAppointment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelReminder, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelReminderDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelReminderTime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelRecurrenceDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelPlaySound, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleSwitchReminder, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleSwitchRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleSwitchPlaySound, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonCreateAppointment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxAllowAnimation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSwitchElasticity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorSwitchElasticity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelThumbTickness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorThumbTickness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelAnimationFrames, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorAnimationFrames, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private radDropDownListRecurrence As Telerik.WinControls.UI.RadDropDownList
        Private radTimePicker1 As Telerik.WinControls.UI.RadTimePicker
        Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
        Private radToggleSwitchPlaySound As Telerik.WinControls.UI.RadToggleSwitch
        Private radToggleSwitchRecurrence As Telerik.WinControls.UI.RadToggleSwitch
        Private radToggleSwitchReminder As Telerik.WinControls.UI.RadToggleSwitch
        Private radLabelPlaySound As Telerik.WinControls.UI.RadLabel
        Private radLabelRecurrenceDate As Telerik.WinControls.UI.RadLabel
        Private radLabelRecurrence As Telerik.WinControls.UI.RadLabel
        Private radLabelReminderTime As Telerik.WinControls.UI.RadLabel
        Private radLabelReminderDate As Telerik.WinControls.UI.RadLabel
        Private radLabelReminder As Telerik.WinControls.UI.RadLabel
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private radLabelNewAppointment As Telerik.WinControls.UI.RadLabel
        Private radButtonCreateAppointment As Telerik.WinControls.UI.RadButton
        Private radCheckBoxRightToLeft As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxAllowAnimation As Telerik.WinControls.UI.RadCheckBox
        Private radLabelSwitchElasticity As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorSwitchElasticity As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorThumbTickness As Telerik.WinControls.UI.RadSpinEditor
        Private radLabelThumbTickness As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorAnimationFrames As Telerik.WinControls.UI.RadSpinEditor
        Private radLabelAnimationFrames As Telerik.WinControls.UI.RadLabel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
