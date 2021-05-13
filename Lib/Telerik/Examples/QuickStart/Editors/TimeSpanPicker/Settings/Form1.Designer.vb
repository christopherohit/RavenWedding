Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.exampleTimeSpanPicker = New Telerik.WinControls.UI.RadTimeSpanPicker()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.editModeDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.formatTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.daysStepSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.hoursStepSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.minutesStepSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.secondsStepSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.millisecondsStepSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.minValueTimeSpanPicker = New Telerik.WinControls.UI.RadTimeSpanPicker()
            Me.maxValueTimeSpanPicker = New Telerik.WinControls.UI.RadTimeSpanPicker()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.spinButtonsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.changeStylesCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.formatGroupBox = New Telerik.WinControls.UI.RadGroupBox()
            Me.setFormatButton = New Telerik.WinControls.UI.RadButton()
            Me.enableNullValueCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.nullTextTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exampleTimeSpanPicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editModeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.formatTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.daysStepSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hoursStepSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minutesStepSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.secondsStepSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.millisecondsStepSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minValueTimeSpanPicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.maxValueTimeSpanPicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinButtonsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.changeStylesCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.formatGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.formatGroupBox.SuspendLayout()
            CType(Me.setFormatButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.enableNullValueCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nullTextTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.exampleTimeSpanPicker)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(500, 131)
            Me.settingsPanel.Location = New System.Drawing.Point(766, 222)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel2)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.nullTextTextBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.enableNullValueCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.formatGroupBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.changeStylesCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.spinButtonsCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.maxValueTimeSpanPicker)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.minValueTimeSpanPicker)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel9)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel8)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.millisecondsStepSpinEditor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.secondsStepSpinEditor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel7)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.minutesStepSpinEditor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel6)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.hoursStepSpinEditor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel5)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.daysStepSpinEditor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel4)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel3)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.editModeDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 452)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 452)
            Me.optionsLabel.Location = New System.Drawing.Point(98, 421)
            Me.optionsLabel.Size = New System.Drawing.Size(2, 2)
            Me.optionsLabel.Text = ""
            Me.exampleTimeSpanPicker.Format = "dd'days 'hh'hours 'mm'minutes 'ss'seconds 'fff'milliseconds'"
            Me.exampleTimeSpanPicker.Location = New System.Drawing.Point(85, 54)
            Me.exampleTimeSpanPicker.Name = "exampleTimeSpanPicker"
            Me.exampleTimeSpanPicker.NullText = "The value is NULL."
            Me.exampleTimeSpanPicker.Size = New System.Drawing.Size(330, 22)
            Me.exampleTimeSpanPicker.TabIndex = 0
            Me.exampleTimeSpanPicker.TabStop = False
            Me.radLabel1.Location = New System.Drawing.Point(3, 9)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(58, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "Edit Mode"
            Me.editModeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.editModeDropDownList.Location = New System.Drawing.Point(66, 7)
            Me.editModeDropDownList.Name = "editModeDropDownList"
            Me.editModeDropDownList.Size = New System.Drawing.Size(131, 20)
            Me.editModeDropDownList.TabIndex = 2
            Me.editModeDropDownList.Tag = "Right"
            AddHandler Me.editModeDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.EditModeDropDownList_SelectedIndexChanged)
            Me.formatTextBox.Location = New System.Drawing.Point(5, 25)
            Me.formatTextBox.Name = "formatTextBox"
            Me.formatTextBox.Size = New System.Drawing.Size(183, 20)
            Me.formatTextBox.TabIndex = 4
            Me.formatTextBox.Text = "dd'days 'hh'hours 'mm'minutes 'ss'seconds 'fff'milliseconds'"
            Me.radLabel3.Location = New System.Drawing.Point(4, 304)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(56, 18)
            Me.radLabel3.TabIndex = 5
            Me.radLabel3.Text = "Days Step"
            Me.daysStepSpinEditor.Location = New System.Drawing.Point(108, 302)
            Me.daysStepSpinEditor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.daysStepSpinEditor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.daysStepSpinEditor.Name = "daysStepSpinEditor"
            Me.daysStepSpinEditor.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.daysStepSpinEditor.Size = New System.Drawing.Size(89, 20)
            Me.daysStepSpinEditor.TabIndex = 6
            Me.daysStepSpinEditor.Tag = "Right"
            Me.daysStepSpinEditor.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.daysStepSpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.DaysStepSpinEditor_ValueChanged)
            Me.hoursStepSpinEditor.Location = New System.Drawing.Point(108, 332)
            Me.hoursStepSpinEditor.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.hoursStepSpinEditor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.hoursStepSpinEditor.Name = "hoursStepSpinEditor"
            Me.hoursStepSpinEditor.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.hoursStepSpinEditor.Size = New System.Drawing.Size(89, 20)
            Me.hoursStepSpinEditor.TabIndex = 8
            Me.hoursStepSpinEditor.Tag = "Right"
            Me.hoursStepSpinEditor.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.hoursStepSpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.HoursStepSpinEditor_ValueChanged)
            Me.radLabel4.Location = New System.Drawing.Point(4, 334)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(62, 18)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Text = "Hours Step"
            Me.minutesStepSpinEditor.Location = New System.Drawing.Point(108, 362)
            Me.minutesStepSpinEditor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.minutesStepSpinEditor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.minutesStepSpinEditor.Name = "minutesStepSpinEditor"
            Me.minutesStepSpinEditor.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.minutesStepSpinEditor.Size = New System.Drawing.Size(89, 20)
            Me.minutesStepSpinEditor.TabIndex = 10
            Me.minutesStepSpinEditor.Tag = "Right"
            Me.minutesStepSpinEditor.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.minutesStepSpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.MinutesStepSpinEditor_ValueChanged)
            Me.radLabel5.Location = New System.Drawing.Point(4, 364)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(72, 18)
            Me.radLabel5.TabIndex = 9
            Me.radLabel5.Text = "Minutes Step"
            Me.secondsStepSpinEditor.Location = New System.Drawing.Point(108, 393)
            Me.secondsStepSpinEditor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.secondsStepSpinEditor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.secondsStepSpinEditor.Name = "secondsStepSpinEditor"
            Me.secondsStepSpinEditor.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.secondsStepSpinEditor.Size = New System.Drawing.Size(89, 20)
            Me.secondsStepSpinEditor.TabIndex = 10
            Me.secondsStepSpinEditor.Tag = "Right"
            Me.secondsStepSpinEditor.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.secondsStepSpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.SecondsStepSpinEditor_ValueChanged)
            Me.radLabel6.Location = New System.Drawing.Point(4, 395)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(73, 18)
            Me.radLabel6.TabIndex = 9
            Me.radLabel6.Text = "Seconds Step"
            Me.millisecondsStepSpinEditor.Location = New System.Drawing.Point(108, 423)
            Me.millisecondsStepSpinEditor.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.millisecondsStepSpinEditor.Name = "millisecondsStepSpinEditor"
            Me.millisecondsStepSpinEditor.NullableValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.millisecondsStepSpinEditor.Size = New System.Drawing.Size(89, 20)
            Me.millisecondsStepSpinEditor.TabIndex = 10
            Me.millisecondsStepSpinEditor.Tag = "Right"
            Me.millisecondsStepSpinEditor.Value = New Decimal(New Integer() {5, 0, 0, 0})
            AddHandler Me.millisecondsStepSpinEditor.ValueChanged, New System.EventHandler(AddressOf Me.MillisecondsStepSpinEditor_ValueChanged)
            Me.radLabel7.Location = New System.Drawing.Point(4, 425)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(93, 18)
            Me.radLabel7.TabIndex = 9
            Me.radLabel7.Text = "Milliseconds Step"
            Me.radLabel8.Location = New System.Drawing.Point(4, 240)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(85, 18)
            Me.radLabel8.TabIndex = 10
            Me.radLabel8.Text = "Minimum Value"
            Me.minValueTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Mask
            Me.minValueTimeSpanPicker.Format = "ddd'days 'hh'hours'"
            Me.minValueTimeSpanPicker.Location = New System.Drawing.Point(95, 238)
            Me.minValueTimeSpanPicker.MaxValue = System.TimeSpan.Parse("100.00:00:00")
            Me.minValueTimeSpanPicker.MinValue = System.TimeSpan.Parse("-100.00:00:00")
            Me.minValueTimeSpanPicker.Name = "minValueTimeSpanPicker"
            Me.minValueTimeSpanPicker.Size = New System.Drawing.Size(102, 22)
            Me.minValueTimeSpanPicker.TabIndex = 11
            Me.minValueTimeSpanPicker.TabStop = False
            Me.minValueTimeSpanPicker.Tag = "Right"
            AddHandler Me.minValueTimeSpanPicker.ValueChanging, New System.ComponentModel.CancelEventHandler(AddressOf Me.MinValueTimeSpanPicker_ValueChanging)
            AddHandler Me.minValueTimeSpanPicker.ValueChanged, New System.EventHandler(AddressOf Me.MinValueTimeSpanPicker_ValueChanged)
            Me.maxValueTimeSpanPicker.EditMode = Telerik.WinControls.UI.TimeSpanEditMode.Mask
            Me.maxValueTimeSpanPicker.Format = "ddd'days 'hh'hours'"
            Me.maxValueTimeSpanPicker.Location = New System.Drawing.Point(95, 270)
            Me.maxValueTimeSpanPicker.MaxValue = System.TimeSpan.Parse("100.00:00:00")
            Me.maxValueTimeSpanPicker.MinValue = System.TimeSpan.Parse("-100.00:00:00")
            Me.maxValueTimeSpanPicker.Name = "maxValueTimeSpanPicker"
            Me.maxValueTimeSpanPicker.Size = New System.Drawing.Size(102, 22)
            Me.maxValueTimeSpanPicker.TabIndex = 13
            Me.maxValueTimeSpanPicker.TabStop = False
            Me.maxValueTimeSpanPicker.Tag = "Right"
            Me.maxValueTimeSpanPicker.Value = System.TimeSpan.Parse("100.00:00:00")
            AddHandler Me.maxValueTimeSpanPicker.ValueChanging, New System.ComponentModel.CancelEventHandler(AddressOf Me.MaxValueTimeSpanPicker_ValueChanging)
            AddHandler Me.maxValueTimeSpanPicker.ValueChanged, New System.EventHandler(AddressOf Me.MaxValueTimeSpanPicker_ValueChanged)
            Me.radLabel9.Location = New System.Drawing.Point(4, 272)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(87, 18)
            Me.radLabel9.TabIndex = 12
            Me.radLabel9.Text = "Maximum Value"
            Me.spinButtonsCheckBox.Location = New System.Drawing.Point(4, 128)
            Me.spinButtonsCheckBox.Name = "spinButtonsCheckBox"
            Me.spinButtonsCheckBox.Size = New System.Drawing.Size(113, 18)
            Me.spinButtonsCheckBox.TabIndex = 14
            Me.spinButtonsCheckBox.Text = "Show spin buttons"
            AddHandler Me.spinButtonsCheckBox.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.spinButtonsCheckBox_ToggleStateChanged)
            Me.changeStylesCheckBox.Location = New System.Drawing.Point(3, 156)
            Me.changeStylesCheckBox.Name = "changeStylesCheckBox"
            Me.changeStylesCheckBox.Size = New System.Drawing.Size(125, 18)
            Me.changeStylesCheckBox.TabIndex = 15
            Me.changeStylesCheckBox.Text = "Change popup styles"
            Me.formatGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.formatGroupBox.Controls.Add(Me.setFormatButton)
            Me.formatGroupBox.Controls.Add(Me.formatTextBox)
            Me.formatGroupBox.HeaderText = "Format String (Mask)"
            Me.formatGroupBox.Location = New System.Drawing.Point(4, 33)
            Me.formatGroupBox.Name = "formatGroupBox"
            Me.formatGroupBox.Size = New System.Drawing.Size(193, 88)
            Me.formatGroupBox.TabIndex = 16
            Me.formatGroupBox.Text = "Format String (Mask)"
            Me.setFormatButton.Location = New System.Drawing.Point(5, 56)
            Me.setFormatButton.Name = "setFormatButton"
            Me.setFormatButton.Size = New System.Drawing.Size(183, 24)
            Me.setFormatButton.TabIndex = 5
            Me.setFormatButton.Text = "Set Format"
            AddHandler Me.setFormatButton.Click, New System.EventHandler(AddressOf Me.SetFormatButton_Click)
            Me.enableNullValueCheckBox.Location = New System.Drawing.Point(4, 184)
            Me.enableNullValueCheckBox.Name = "enableNullValueCheckBox"
            Me.enableNullValueCheckBox.Size = New System.Drawing.Size(161, 18)
            Me.enableNullValueCheckBox.TabIndex = 17
            Me.enableNullValueCheckBox.Text = "Enable Null Values(Ctrl+Del)"
            AddHandler Me.enableNullValueCheckBox.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.EnablNullValueCheckBox_ToggleStateChanged)
            CType(Me.enableNullValueCheckBox.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Enable Null Values(Ctrl+Del)"
            CType(Me.enableNullValueCheckBox.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).ToolTipText = "To set the value to NULL you need to press Ctrl+Del or Ctrl+0 key combination."
            Me.nullTextTextBox.Enabled = False
            Me.nullTextTextBox.Location = New System.Drawing.Point(66, 208)
            Me.nullTextTextBox.Name = "nullTextTextBox"
            Me.nullTextTextBox.Size = New System.Drawing.Size(131, 20)
            Me.nullTextTextBox.TabIndex = 18
            Me.nullTextTextBox.Tag = "Right"
            Me.nullTextTextBox.Text = "The value is NULL."
            AddHandler Me.nullTextTextBox.TextChanged, New System.EventHandler(AddressOf Me.NullTextTextBox_TextChanged)
            Me.radLabel2.Location = New System.Drawing.Point(4, 210)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(51, 18)
            Me.radLabel2.TabIndex = 19
            Me.radLabel2.Text = "Null Text"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1963, 1157)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exampleTimeSpanPicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editModeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.formatTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.daysStepSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hoursStepSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minutesStepSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.secondsStepSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.millisecondsStepSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minValueTimeSpanPicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.maxValueTimeSpanPicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinButtonsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.changeStylesCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.formatGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.formatGroupBox.ResumeLayout(False)
            Me.formatGroupBox.PerformLayout()
            CType(Me.setFormatButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.enableNullValueCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nullTextTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private exampleTimeSpanPicker As Telerik.WinControls.UI.RadTimeSpanPicker
        Private changeStylesCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private spinButtonsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private maxValueTimeSpanPicker As Telerik.WinControls.UI.RadTimeSpanPicker
        Private minValueTimeSpanPicker As Telerik.WinControls.UI.RadTimeSpanPicker
        Private radLabel9 As Telerik.WinControls.UI.RadLabel
        Private radLabel8 As Telerik.WinControls.UI.RadLabel
        Private millisecondsStepSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private secondsStepSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private minutesStepSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private hoursStepSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private daysStepSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private formatTextBox As Telerik.WinControls.UI.RadTextBox
        Private editModeDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private formatGroupBox As Telerik.WinControls.UI.RadGroupBox
        Private setFormatButton As Telerik.WinControls.UI.RadButton
        Private enableNullValueCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private nullTextTextBox As Telerik.WinControls.UI.RadTextBox
    End Class
End Namespace
