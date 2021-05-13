Namespace Telerik.Examples.WinControls.Spreadsheet.DataValidation
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim workbook1 As Telerik.Windows.Documents.Spreadsheet.Model.Workbook = New Telerik.Windows.Documents.Spreadsheet.Model.Workbook()
            Me.clearInvalidDataCirclesRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.circleInvalidDataRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radSpreadsheet1 = New Telerik.WinControls.UI.RadSpreadsheet()
            Me.radSpreadsheetRibbonBar1 = New Telerik.WinControls.UI.RadSpreadsheetRibbonBar()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.clearInvalidDataCirclesRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circleInvalidDataRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpreadsheet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpreadsheetRibbonBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(0, 221)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 156)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 156)
            Me.clearInvalidDataCirclesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.clearInvalidDataCirclesRadioButton.AutoSize = False
            Me.clearInvalidDataCirclesRadioButton.CheckState = System.Windows.Forms.CheckState.Checked
            Me.clearInvalidDataCirclesRadioButton.Location = New System.Drawing.Point(5, 63)
            Me.clearInvalidDataCirclesRadioButton.Name = "clearInvalidDataCirclesRadioButton"
            Me.clearInvalidDataCirclesRadioButton.Size = New System.Drawing.Size(200, 36)
            Me.clearInvalidDataCirclesRadioButton.TabIndex = 4
            Me.clearInvalidDataCirclesRadioButton.Tag = "NotAutoSized"
            Me.clearInvalidDataCirclesRadioButton.Text = "Clear invalid data circles"
            Me.clearInvalidDataCirclesRadioButton.TextWrap = True
            Me.clearInvalidDataCirclesRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.clearInvalidDataCirclesRadioButton.Click, AddressOf Me.ClearInvalidDataCirclesRadioButton_Click
            Me.circleInvalidDataRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.circleInvalidDataRadioButton.AutoSize = False
            Me.circleInvalidDataRadioButton.Location = New System.Drawing.Point(5, 21)
            Me.circleInvalidDataRadioButton.Name = "circleInvalidDataRadioButton"
            Me.circleInvalidDataRadioButton.Size = New System.Drawing.Size(200, 36)
            Me.circleInvalidDataRadioButton.TabIndex = 3
            Me.circleInvalidDataRadioButton.Tag = "NotAutoSized"
            Me.circleInvalidDataRadioButton.Text = "Circle invalid data"
            Me.circleInvalidDataRadioButton.TextWrap = True
            AddHandler Me.circleInvalidDataRadioButton.Click, AddressOf Me.CircleInvalidDataRadioButton_Click
            Me.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSpreadsheet1.Location = New System.Drawing.Point(0, 168)
            Me.radSpreadsheet1.Name = "radSpreadsheet1"
            Me.radSpreadsheet1.Size = New System.Drawing.Size(1473, 618)
            Me.radSpreadsheet1.TabIndex = 2
            workbook1.ActiveTabIndex = -1
            workbook1.Name = "Book1"
            workbook1.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000")
            Me.radSpreadsheet1.Workbook = workbook1
            Me.radSpreadsheetRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.radSpreadsheetRibbonBar1.AssociatedSpreadsheet = Me.radSpreadsheet1
            Me.radSpreadsheetRibbonBar1.ExitButton.Text = "Exit"
            Me.radSpreadsheetRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.radSpreadsheetRibbonBar1.Name = "radSpreadsheetRibbonBar1"
            Me.radSpreadsheetRibbonBar1.OptionsButton.Text = "Options"
            Me.radSpreadsheetRibbonBar1.Size = New System.Drawing.Size(1473, 168)
            Me.radSpreadsheetRibbonBar1.TabIndex = 0
            Me.radSpreadsheetRibbonBar1.Text = "Data Validation"
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox1.Controls.Add(Me.circleInvalidDataRadioButton)
            Me.radGroupBox1.Controls.Add(Me.clearInvalidDataCirclesRadioButton)
            Me.radGroupBox1.HeaderText = "Data Validation Options"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 32)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(210, 108)
            Me.radGroupBox1.TabIndex = 5
            Me.radGroupBox1.Text = "Data Validation Options"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSpreadsheet1)
            Me.Controls.Add(Me.radSpreadsheetRibbonBar1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1483, 796)
            Me.Controls.SetChildIndex(Me.radSpreadsheetRibbonBar1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radSpreadsheet1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.clearInvalidDataCirclesRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circleInvalidDataRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpreadsheet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpreadsheetRibbonBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private clearInvalidDataCirclesRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private circleInvalidDataRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private radSpreadsheet1 As Telerik.WinControls.UI.RadSpreadsheet
        Private radSpreadsheetRibbonBar1 As Telerik.WinControls.UI.RadSpreadsheetRibbonBar
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    End Class
End Namespace
