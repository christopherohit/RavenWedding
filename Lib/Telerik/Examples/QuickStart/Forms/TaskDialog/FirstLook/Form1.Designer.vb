Namespace Telerik.Examples.WinControls.Forms.TaskDialog.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.buttonInstallation = New Telerik.WinControls.UI.RadButton()
            Me.MainTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radPanelGameDifficulty = New Telerik.WinControls.UI.RadPanel()
            Me.GameTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.buttonDiffuculty = New Telerik.WinControls.UI.RadButton()
            Me.radLabelGameImage = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelGameDescription = New Telerik.WinControls.UI.RadLabel()
            Me.radPanelWarning = New Telerik.WinControls.UI.RadPanel()
            Me.WarningTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.buttonWarning = New Telerik.WinControls.UI.RadButton()
            Me.radLabelWarningImage = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelWarningDescription = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabelGameDifficultySample = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelWarningSample = New Telerik.WinControls.UI.RadLabel()
            Me.radPanelInstallation = New Telerik.WinControls.UI.RadPanel()
            Me.InstallationTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabelInstallationImage = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelInstallationDescription = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelInstallationSample = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonInstallation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MainTableLayoutPanel.SuspendLayout()
            CType(Me.radPanelGameDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelGameDifficulty.SuspendLayout()
            Me.GameTableLayoutPanel.SuspendLayout()
            CType(Me.buttonDiffuculty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelGameImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelGameDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelWarning, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelWarning.SuspendLayout()
            Me.WarningTableLayoutPanel.SuspendLayout()
            CType(Me.buttonWarning, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelWarningImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelWarningDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelGameDifficultySample, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelWarningSample, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelInstallation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelInstallation.SuspendLayout()
            Me.InstallationTableLayoutPanel.SuspendLayout()
            CType(Me.radLabelInstallationImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelInstallationDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelInstallationSample, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.MainTableLayoutPanel)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(136, 116)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(730, 538)
            Me.settingsPanel.Location = New System.Drawing.Point(1063, 47)
            Me.buttonInstallation.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.buttonInstallation.Location = New System.Drawing.Point(135, 45)
            Me.buttonInstallation.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
            Me.buttonInstallation.Name = "buttonInstallation"
            Me.buttonInstallation.Size = New System.Drawing.Size(235, 36)
            Me.buttonInstallation.TabIndex = 1
            Me.buttonInstallation.Text = "Open Installation Sample"
            AddHandler Me.buttonInstallation.Click, New System.EventHandler(AddressOf Me.ButtonInstallation_Click)
            Me.MainTableLayoutPanel.ColumnCount = 1
            Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MainTableLayoutPanel.Controls.Add(Me.radPanelGameDifficulty, 0, 5)
            Me.MainTableLayoutPanel.Controls.Add(Me.radPanelWarning, 0, 3)
            Me.MainTableLayoutPanel.Controls.Add(Me.radLabelGameDifficultySample, 0, 4)
            Me.MainTableLayoutPanel.Controls.Add(Me.radLabelWarningSample, 0, 2)
            Me.MainTableLayoutPanel.Controls.Add(Me.radPanelInstallation, 0, 1)
            Me.MainTableLayoutPanel.Controls.Add(Me.radLabelInstallationSample, 0, 0)
            Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
            Me.MainTableLayoutPanel.RowCount = 6
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0F))
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F))
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0F))
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F))
            Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0F))
            Me.MainTableLayoutPanel.Size = New System.Drawing.Size(730, 538)
            Me.MainTableLayoutPanel.TabIndex = 0
            Me.radPanelGameDifficulty.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radPanelGameDifficulty.BackColor = System.Drawing.Color.Transparent
            Me.radPanelGameDifficulty.Controls.Add(Me.GameTableLayoutPanel)
            Me.radPanelGameDifficulty.Location = New System.Drawing.Point(8, 412)
            Me.radPanelGameDifficulty.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.radPanelGameDifficulty.Name = "radPanelGameDifficulty"
            Me.radPanelGameDifficulty.RootElement.EnableElementShadow = False
            Me.radPanelGameDifficulty.Size = New System.Drawing.Size(714, 126)
            Me.radPanelGameDifficulty.TabIndex = 5
            Me.GameTableLayoutPanel.ColumnCount = 3
            Me.GameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0F))
            Me.GameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0F))
            Me.GameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.GameTableLayoutPanel.Controls.Add(Me.buttonDiffuculty, 1, 1)
            Me.GameTableLayoutPanel.Controls.Add(Me.radLabelGameImage, 0, 0)
            Me.GameTableLayoutPanel.Controls.Add(Me.radLabelGameDescription, 1, 0)
            Me.GameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GameTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.GameTableLayoutPanel.Name = "GameTableLayoutPanel"
            Me.GameTableLayoutPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
            Me.GameTableLayoutPanel.RowCount = 3
            Me.GameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.GameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.GameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.GameTableLayoutPanel.Size = New System.Drawing.Size(714, 126)
            Me.GameTableLayoutPanel.TabIndex = 1
            Me.buttonDiffuculty.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.buttonDiffuculty.Location = New System.Drawing.Point(135, 45)
            Me.buttonDiffuculty.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
            Me.buttonDiffuculty.Name = "buttonDiffuculty"
            Me.buttonDiffuculty.Size = New System.Drawing.Size(235, 36)
            Me.buttonDiffuculty.TabIndex = 1
            Me.buttonDiffuculty.Text = "Open Game Difficulty Sample"
            AddHandler Me.buttonDiffuculty.Click, New System.EventHandler(AddressOf Me.ButtonDifficulty_Click)
            Me.radLabelGameImage.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelGameImage.AutoSize = False
            Me.radLabelGameImage.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.radLabelGameImage.Image = CType(resources.GetObject("radLabelGameImage.Image"), System.Drawing.Image)
            Me.radLabelGameImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabelGameImage.Location = New System.Drawing.Point(16, 13)
            Me.radLabelGameImage.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
            Me.radLabelGameImage.Name = "radLabelGameImage"
            Me.GameTableLayoutPanel.SetRowSpan(Me.radLabelGameImage, 3)
            Me.radLabelGameImage.Size = New System.Drawing.Size(100, 100)
            Me.radLabelGameImage.TabIndex = 2
            Me.radLabelGameDescription.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelGameDescription.AutoSize = False
            Me.GameTableLayoutPanel.SetColumnSpan(Me.radLabelGameDescription, 2)
            Me.radLabelGameDescription.Location = New System.Drawing.Point(130, 13)
            Me.radLabelGameDescription.Name = "radLabelGameDescription"
            Me.radLabelGameDescription.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.radLabelGameDescription.Size = New System.Drawing.Size(576, 26)
            Me.radLabelGameDescription.TabIndex = 3
            Me.radLabelGameDescription.Text = "At the start of a new game, you have to choose the level of difficulty you want t" & "o play!"
            Me.radPanelWarning.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radPanelWarning.BackColor = System.Drawing.Color.Transparent
            Me.radPanelWarning.Controls.Add(Me.WarningTableLayoutPanel)
            Me.radPanelWarning.Location = New System.Drawing.Point(8, 226)
            Me.radPanelWarning.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.radPanelWarning.Name = "radPanelWarning"
            Me.radPanelWarning.RootElement.EnableElementShadow = False
            Me.radPanelWarning.Size = New System.Drawing.Size(714, 126)
            Me.radPanelWarning.TabIndex = 4
            Me.WarningTableLayoutPanel.ColumnCount = 3
            Me.WarningTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0F))
            Me.WarningTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0F))
            Me.WarningTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.WarningTableLayoutPanel.Controls.Add(Me.buttonWarning, 1, 1)
            Me.WarningTableLayoutPanel.Controls.Add(Me.radLabelWarningImage, 0, 0)
            Me.WarningTableLayoutPanel.Controls.Add(Me.radLabelWarningDescription, 1, 0)
            Me.WarningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WarningTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.WarningTableLayoutPanel.Name = "WarningTableLayoutPanel"
            Me.WarningTableLayoutPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
            Me.WarningTableLayoutPanel.RowCount = 3
            Me.WarningTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.WarningTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.WarningTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.WarningTableLayoutPanel.Size = New System.Drawing.Size(714, 126)
            Me.WarningTableLayoutPanel.TabIndex = 1
            Me.buttonWarning.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.buttonWarning.Location = New System.Drawing.Point(135, 45)
            Me.buttonWarning.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
            Me.buttonWarning.Name = "buttonWarning"
            Me.buttonWarning.Size = New System.Drawing.Size(235, 36)
            Me.buttonWarning.TabIndex = 1
            Me.buttonWarning.Text = "Open Warning Sample"
            AddHandler Me.buttonWarning.Click, New System.EventHandler(AddressOf Me.ButtonWarning_Click)
            Me.radLabelWarningImage.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelWarningImage.AutoSize = False
            Me.radLabelWarningImage.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.radLabelWarningImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabelWarningImage.Location = New System.Drawing.Point(16, 13)
            Me.radLabelWarningImage.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
            Me.radLabelWarningImage.Name = "radLabelWarningImage"
            Me.WarningTableLayoutPanel.SetRowSpan(Me.radLabelWarningImage, 3)
            Me.radLabelWarningImage.Size = New System.Drawing.Size(100, 100)
            Me.radLabelWarningImage.TabIndex = 2
            Me.radLabelWarningDescription.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelWarningDescription.AutoSize = False
            Me.radLabelWarningDescription.CheckState = System.Windows.Forms.CheckState.Checked
            Me.WarningTableLayoutPanel.SetColumnSpan(Me.radLabelWarningDescription, 2)
            Me.radLabelWarningDescription.Location = New System.Drawing.Point(130, 13)
            Me.radLabelWarningDescription.Name = "radLabelWarningDescription"
            Me.radLabelWarningDescription.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.radLabelWarningDescription.[ReadOnly] = True
            Me.radLabelWarningDescription.Size = New System.Drawing.Size(576, 26)
            Me.radLabelWarningDescription.TabIndex = 3
            Me.radLabelWarningDescription.Text = " Enable protect mode."
            Me.radLabelWarningDescription.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radLabelGameDifficultySample.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelGameDifficultySample.AutoSize = False
            Me.radLabelGameDifficultySample.Font = New System.Drawing.Font("Segoe UI", 13.0F)
            Me.radLabelGameDifficultySample.Location = New System.Drawing.Point(3, 355)
            Me.radLabelGameDifficultySample.Name = "radLabelGameDifficultySample"
            Me.radLabelGameDifficultySample.Size = New System.Drawing.Size(724, 54)
            Me.radLabelGameDifficultySample.TabIndex = 3
            Me.radLabelGameDifficultySample.Text = "Game Difficulty Sample"
            Me.radLabelGameDifficultySample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelWarningSample.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelWarningSample.AutoSize = False
            Me.radLabelWarningSample.Font = New System.Drawing.Font("Segoe UI", 13.0F)
            Me.radLabelWarningSample.Location = New System.Drawing.Point(3, 169)
            Me.radLabelWarningSample.Name = "radLabelWarningSample"
            Me.radLabelWarningSample.Size = New System.Drawing.Size(724, 54)
            Me.radLabelWarningSample.TabIndex = 2
            Me.radLabelWarningSample.Text = "Warning Sample"
            Me.radLabelWarningSample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radPanelInstallation.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radPanelInstallation.BackColor = System.Drawing.Color.Transparent
            Me.radPanelInstallation.Controls.Add(Me.InstallationTableLayoutPanel)
            Me.radPanelInstallation.Location = New System.Drawing.Point(8, 40)
            Me.radPanelInstallation.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.radPanelInstallation.Name = "radPanelInstallation"
            Me.radPanelInstallation.RootElement.EnableElementShadow = False
            Me.radPanelInstallation.Size = New System.Drawing.Size(714, 126)
            Me.radPanelInstallation.TabIndex = 0
            Me.InstallationTableLayoutPanel.ColumnCount = 3
            Me.InstallationTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0F))
            Me.InstallationTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0F))
            Me.InstallationTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.InstallationTableLayoutPanel.Controls.Add(Me.buttonInstallation, 1, 1)
            Me.InstallationTableLayoutPanel.Controls.Add(Me.radLabelInstallationImage, 0, 0)
            Me.InstallationTableLayoutPanel.Controls.Add(Me.radLabelInstallationDescription, 1, 0)
            Me.InstallationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.InstallationTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.InstallationTableLayoutPanel.Name = "InstallationTableLayoutPanel"
            Me.InstallationTableLayoutPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
            Me.InstallationTableLayoutPanel.RowCount = 3
            Me.InstallationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.InstallationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0F))
            Me.InstallationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.InstallationTableLayoutPanel.Size = New System.Drawing.Size(714, 126)
            Me.InstallationTableLayoutPanel.TabIndex = 0
            Me.radLabelInstallationImage.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelInstallationImage.AutoSize = False
            Me.radLabelInstallationImage.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.radLabelInstallationImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radLabelInstallationImage.Location = New System.Drawing.Point(16, 13)
            Me.radLabelInstallationImage.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
            Me.radLabelInstallationImage.Name = "radLabelInstallationImage"
            Me.InstallationTableLayoutPanel.SetRowSpan(Me.radLabelInstallationImage, 3)
            Me.radLabelInstallationImage.Size = New System.Drawing.Size(100, 100)
            Me.radLabelInstallationImage.TabIndex = 2
            Me.radLabelInstallationDescription.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelInstallationDescription.AutoSize = False
            Me.InstallationTableLayoutPanel.SetColumnSpan(Me.radLabelInstallationDescription, 2)
            Me.radLabelInstallationDescription.Location = New System.Drawing.Point(130, 13)
            Me.radLabelInstallationDescription.Name = "radLabelInstallationDescription"
            Me.radLabelInstallationDescription.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.radLabelInstallationDescription.Size = New System.Drawing.Size(576, 26)
            Me.radLabelInstallationDescription.TabIndex = 3
            Me.radLabelInstallationDescription.Text = "Installation Warning!"
            Me.radLabelInstallationSample.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.radLabelInstallationSample.AutoSize = False
            Me.radLabelInstallationSample.Font = New System.Drawing.Font("Segoe UI", 13.0F)
            Me.radLabelInstallationSample.Location = New System.Drawing.Point(3, 3)
            Me.radLabelInstallationSample.Name = "radLabelInstallationSample"
            Me.radLabelInstallationSample.Size = New System.Drawing.Size(724, 34)
            Me.radLabelInstallationSample.TabIndex = 1
            Me.radLabelInstallationSample.Text = "Installation Sample"
            Me.radLabelInstallationSample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1454, 788)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonInstallation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MainTableLayoutPanel.ResumeLayout(False)
            CType(Me.radPanelGameDifficulty, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelGameDifficulty.ResumeLayout(False)
            Me.GameTableLayoutPanel.ResumeLayout(False)
            CType(Me.buttonDiffuculty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelGameImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelGameDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelWarning, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelWarning.ResumeLayout(False)
            Me.WarningTableLayoutPanel.ResumeLayout(False)
            CType(Me.buttonWarning, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelWarningImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelWarningDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelGameDifficultySample, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelWarningSample, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelInstallation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelInstallation.ResumeLayout(False)
            Me.InstallationTableLayoutPanel.ResumeLayout(False)
            CType(Me.radLabelInstallationImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelInstallationDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelInstallationSample, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private buttonInstallation As Telerik.WinControls.UI.RadButton
        Private MainTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabelGameDifficultySample As Telerik.WinControls.UI.RadLabel
        Private radLabelWarningSample As Telerik.WinControls.UI.RadLabel
        Private radPanelInstallation As Telerik.WinControls.UI.RadPanel
        Private radLabelInstallationSample As Telerik.WinControls.UI.RadLabel
        Private radPanelGameDifficulty As Telerik.WinControls.UI.RadPanel
        Private radPanelWarning As Telerik.WinControls.UI.RadPanel
        Private InstallationTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabelInstallationImage As Telerik.WinControls.UI.RadLabel
        Private radLabelInstallationDescription As Telerik.WinControls.UI.RadLabel
        Private GameTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private buttonDiffuculty As Telerik.WinControls.UI.RadButton
        Private radLabelGameImage As Telerik.WinControls.UI.RadLabel
        Private radLabelGameDescription As Telerik.WinControls.UI.RadLabel
        Private WarningTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private buttonWarning As Telerik.WinControls.UI.RadButton
        Private radLabelWarningImage As Telerik.WinControls.UI.RadLabel
        Private radLabelWarningDescription As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
