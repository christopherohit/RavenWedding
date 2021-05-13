Namespace Telerik.Examples.WinControls.Spreadsheet.SortingAndFiltering
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim workbook2 As Telerik.Windows.Documents.Spreadsheet.Model.Workbook = New Telerik.Windows.Documents.Spreadsheet.Model.Workbook()
            Me.radSpreadsheet1 = New Telerik.WinControls.UI.RadSpreadsheet()
            Me.radSpreadsheetRibbonBar1 = New Telerik.WinControls.UI.RadSpreadsheetRibbonBar()
            Me.filterByMonthSortByCompanyRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.filterByCompanySortByFillRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.topFilterAndCustomSortRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.removeFilterAndSortRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.radSpreadsheet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpreadsheetRibbonBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filterByMonthSortByCompanyRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filterByCompanySortByFillRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.topFilterAndCustomSortRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.removeFilterAndSortRadioButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(0, 54)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 241)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 241)
            Me.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSpreadsheet1.Location = New System.Drawing.Point(0, 168)
            Me.radSpreadsheet1.Name = "radSpreadsheet1"
            Me.radSpreadsheet1.Size = New System.Drawing.Size(1473, 618)
            Me.radSpreadsheet1.TabIndex = 2
            workbook2.ActiveTabIndex = -1
            workbook2.Name = "Book1"
            workbook2.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000")
            Me.radSpreadsheet1.Workbook = workbook2
            Me.radSpreadsheetRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
            Me.radSpreadsheetRibbonBar1.AssociatedSpreadsheet = Me.radSpreadsheet1
            Me.radSpreadsheetRibbonBar1.ExitButton.Text = "Exit"
            Me.radSpreadsheetRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.radSpreadsheetRibbonBar1.Name = "radSpreadsheetRibbonBar1"
            Me.radSpreadsheetRibbonBar1.OptionsButton.Text = "Options"
            Me.radSpreadsheetRibbonBar1.Size = New System.Drawing.Size(1473, 168)
            Me.radSpreadsheetRibbonBar1.TabIndex = 0
            Me.radSpreadsheetRibbonBar1.Text = "Sorting and Filtering"
            Me.filterByMonthSortByCompanyRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.filterByMonthSortByCompanyRadioButton.AutoSize = False
            Me.filterByMonthSortByCompanyRadioButton.Location = New System.Drawing.Point(6, 21)
            Me.filterByMonthSortByCompanyRadioButton.Name = "filterByMonthSortByCompanyRadioButton"
            Me.filterByMonthSortByCompanyRadioButton.Size = New System.Drawing.Size(199, 36)
            Me.filterByMonthSortByCompanyRadioButton.TabIndex = 1
            Me.filterByMonthSortByCompanyRadioButton.TabStop = False
            Me.filterByMonthSortByCompanyRadioButton.Tag = "NotAutoSized"
            Me.filterByMonthSortByCompanyRadioButton.Text = "Filter by June and Sort by company"
            Me.filterByMonthSortByCompanyRadioButton.TextWrap = True
            AddHandler Me.filterByMonthSortByCompanyRadioButton.Click, AddressOf Me.FilterByMonthSortByCompanyRadioButton_Click
            Me.filterByCompanySortByFillRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.filterByCompanySortByFillRadioButton.AutoSize = False
            Me.filterByCompanySortByFillRadioButton.Location = New System.Drawing.Point(6, 63)
            Me.filterByCompanySortByFillRadioButton.Name = "filterByCompanySortByFillRadioButton"
            Me.filterByCompanySortByFillRadioButton.Size = New System.Drawing.Size(199, 36)
            Me.filterByCompanySortByFillRadioButton.TabIndex = 2
            Me.filterByCompanySortByFillRadioButton.TabStop = False
            Me.filterByCompanySortByFillRadioButton.Tag = "NotAutoSized"
            Me.filterByCompanySortByFillRadioButton.Text = "Filter by ""Plan Smart"" Company and Sort by status"
            Me.filterByCompanySortByFillRadioButton.TextWrap = True
            AddHandler Me.filterByCompanySortByFillRadioButton.Click, AddressOf Me.FilterByCompanySortByFillRadioButton_Click
            Me.topFilterAndCustomSortRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.topFilterAndCustomSortRadioButton.AutoSize = False
            Me.topFilterAndCustomSortRadioButton.Location = New System.Drawing.Point(6, 105)
            Me.topFilterAndCustomSortRadioButton.Name = "topFilterAndCustomSortRadioButton"
            Me.topFilterAndCustomSortRadioButton.Size = New System.Drawing.Size(199, 36)
            Me.topFilterAndCustomSortRadioButton.TabIndex = 4
            Me.topFilterAndCustomSortRadioButton.TabStop = False
            Me.topFilterAndCustomSortRadioButton.Tag = "NotAutoSized"
            Me.topFilterAndCustomSortRadioButton.Text = "Filter Top 20 Percent of Discounts and Sort by shipping type"
            Me.topFilterAndCustomSortRadioButton.TextWrap = True
            AddHandler Me.topFilterAndCustomSortRadioButton.Click, AddressOf Me.TopFilterAndCustomSortRadioButton_Click
            Me.removeFilterAndSortRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.removeFilterAndSortRadioButton.AutoSize = False
            Me.removeFilterAndSortRadioButton.CheckState = System.Windows.Forms.CheckState.Checked
            Me.removeFilterAndSortRadioButton.Location = New System.Drawing.Point(6, 147)
            Me.removeFilterAndSortRadioButton.Name = "removeFilterAndSortRadioButton"
            Me.removeFilterAndSortRadioButton.Size = New System.Drawing.Size(199, 36)
            Me.removeFilterAndSortRadioButton.TabIndex = 3
            Me.removeFilterAndSortRadioButton.Tag = "NotAutoSized"
            Me.removeFilterAndSortRadioButton.Text = "No filters and sort conditions"
            Me.removeFilterAndSortRadioButton.TextWrap = True
            Me.removeFilterAndSortRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.removeFilterAndSortRadioButton.Click, AddressOf Me.RemoveFilterAndSortRadioButton_Click
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox1.Controls.Add(Me.filterByMonthSortByCompanyRadioButton)
            Me.radGroupBox1.Controls.Add(Me.topFilterAndCustomSortRadioButton)
            Me.radGroupBox1.Controls.Add(Me.removeFilterAndSortRadioButton)
            Me.radGroupBox1.Controls.Add(Me.filterByCompanySortByFillRadioButton)
            Me.radGroupBox1.HeaderText = "Sort and Filter Options"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 32)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(210, 192)
            Me.radGroupBox1.TabIndex = 5
            Me.radGroupBox1.Text = "Sort and Filter Options"
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
            CType((Me.radSpreadsheet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpreadsheetRibbonBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filterByMonthSortByCompanyRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filterByCompanySortByFillRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.topFilterAndCustomSortRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.removeFilterAndSortRadioButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private radSpreadsheet1 As Telerik.WinControls.UI.RadSpreadsheet
        Private radSpreadsheetRibbonBar1 As Telerik.WinControls.UI.RadSpreadsheetRibbonBar
        Private topFilterAndCustomSortRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private filterByCompanySortByFillRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private removeFilterAndSortRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private filterByMonthSortByCompanyRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    End Class
End Namespace
