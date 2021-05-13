Imports Microsoft.VisualBasic
Imports System
Namespace ExportWithDpl.PivotGrid
	Public Partial Class Form1
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
            Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
            Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
            Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
            Me.radPageViewPageSpreadExport = New Telerik.WinControls.UI.RadPageViewPage()
            Me.exportFlatDataCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.customizeVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.pdfRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.csvRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.xlsxRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radPageViewPagePdfExport = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radCheckBoxShowHeaderAndFooter = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxFitToPageWidth = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxExportFlatDataPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCustomizeVisualSettingsPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonPdfExport = New Telerik.WinControls.UI.RadButton()
            Me.radCheckBoxExportVisualSettingsPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageView1.SuspendLayout()
            Me.radPageViewPageSpreadExport.SuspendLayout()
            CType(Me.exportFlatDataCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.txtRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdfRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.csvRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xlsxRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageViewPagePdfExport.SuspendLayout()
            CType(Me.radCheckBoxShowHeaderAndFooter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxFitToPageWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxExportFlatDataPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxExportVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPivotGrid1
            '
            Me.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPivotGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPivotGrid1.Name = "radPivotGrid1"
            Me.radPivotGrid1.Size = New System.Drawing.Size(828, 748)
            Me.radPivotGrid1.TabIndex = 5
            Me.radPivotGrid1.Text = "radPivotGrid1"
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radPageView1)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(828, 0)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(198, 748)
            Me.settingsPanel.TabIndex = 4
            Me.settingsPanel.ThemeName = "ControlDefault"
            '
            'radPageView1
            '
            Me.radPageView1.Controls.Add(Me.radPageViewPageSpreadExport)
            Me.radPageView1.Controls.Add(Me.radPageViewPagePdfExport)
            Me.radPageView1.Location = New System.Drawing.Point(0, 3)
            Me.radPageView1.Name = "radPageView1"
            Me.radPageView1.SelectedPage = Me.radPageViewPageSpreadExport
            Me.radPageView1.Size = New System.Drawing.Size(198, 745)
            Me.radPageView1.TabIndex = 2
            Me.radPageView1.Text = "radPageView1"
            Me.radPageView1.ThemeName = "ControlDefault"
            CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
            CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = False
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.StripViewButtonsPanel).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Left"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Right"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Close Selected Page"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radPageViewPageSpreadExport
            '
            Me.radPageViewPageSpreadExport.Controls.Add(Me.exportFlatDataCheckBox)
            Me.radPageViewPageSpreadExport.Controls.Add(Me.customizeVisualSettingsCheckBox)
            Me.radPageViewPageSpreadExport.Controls.Add(Me.exportButton)
            Me.radPageViewPageSpreadExport.Controls.Add(Me.radGroupBox1)
            Me.radPageViewPageSpreadExport.Controls.Add(Me.exportVisualSettingsCheckBox)
            Me.radPageViewPageSpreadExport.ItemSize = New System.Drawing.SizeF(83.0!, 28.0!)
            Me.radPageViewPageSpreadExport.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPageSpreadExport.Name = "radPageViewPageSpreadExport"
            Me.radPageViewPageSpreadExport.Size = New System.Drawing.Size(177, 697)
            Me.radPageViewPageSpreadExport.Text = "SpreadExport"
            '
            'exportFlatDataCheckBox
            '
            Me.exportFlatDataCheckBox.Location = New System.Drawing.Point(6, 108)
            Me.exportFlatDataCheckBox.Name = "exportFlatDataCheckBox"
            Me.exportFlatDataCheckBox.Size = New System.Drawing.Size(93, 18)
            Me.exportFlatDataCheckBox.TabIndex = 8
            Me.exportFlatDataCheckBox.Text = "ExportFlatData"
            '
            'customizeVisualSettingsCheckBox
            '
            Me.customizeVisualSettingsCheckBox.AutoSize = False
            Me.customizeVisualSettingsCheckBox.Location = New System.Drawing.Point(6, 40)
            Me.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox"
            Me.customizeVisualSettingsCheckBox.Size = New System.Drawing.Size(165, 38)
            Me.customizeVisualSettingsCheckBox.TabIndex = 7
            Me.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting"
            Me.customizeVisualSettingsCheckBox.TextWrap = True
            CType(Me.customizeVisualSettingsCheckBox.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Customize visual settings when exporting"
            '
            'exportButton
            '
            Me.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.exportButton.Location = New System.Drawing.Point(6, 11)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(165, 23)
            Me.exportButton.TabIndex = 0
            Me.exportButton.Text = "Export"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.txtRadioButton)
            Me.radGroupBox1.Controls.Add(Me.pdfRadioButton)
            Me.radGroupBox1.Controls.Add(Me.csvRadioButton)
            Me.radGroupBox1.Controls.Add(Me.xlsxRadioButton)
            Me.radGroupBox1.HeaderText = "Export format"
            Me.radGroupBox1.Location = New System.Drawing.Point(6, 132)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(165, 119)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Export format"
            '
            'txtRadioButton
            '
            Me.txtRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.txtRadioButton.Location = New System.Drawing.Point(14, 94)
            Me.txtRadioButton.Name = "txtRadioButton"
            Me.txtRadioButton.Size = New System.Drawing.Size(39, 18)
            Me.txtRadioButton.TabIndex = 2
            Me.txtRadioButton.TabStop = False
            Me.txtRadioButton.Text = "TXT"
            '
            'pdfRadioButton
            '
            Me.pdfRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.pdfRadioButton.Location = New System.Drawing.Point(14, 70)
            Me.pdfRadioButton.Name = "pdfRadioButton"
            Me.pdfRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.pdfRadioButton.TabIndex = 1
            Me.pdfRadioButton.TabStop = False
            Me.pdfRadioButton.Text = "PDF"
            '
            'csvRadioButton
            '
            Me.csvRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.csvRadioButton.Location = New System.Drawing.Point(14, 46)
            Me.csvRadioButton.Name = "csvRadioButton"
            Me.csvRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.csvRadioButton.TabIndex = 1
            Me.csvRadioButton.TabStop = False
            Me.csvRadioButton.Text = "CSV"
            '
            'xlsxRadioButton
            '
            Me.xlsxRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.xlsxRadioButton.Location = New System.Drawing.Point(14, 22)
            Me.xlsxRadioButton.Name = "xlsxRadioButton"
            Me.xlsxRadioButton.Size = New System.Drawing.Size(45, 18)
            Me.xlsxRadioButton.TabIndex = 0
            Me.xlsxRadioButton.TabStop = False
            Me.xlsxRadioButton.Text = "XLSX"
            '
            'exportVisualSettingsCheckBox
            '
            Me.exportVisualSettingsCheckBox.Location = New System.Drawing.Point(6, 84)
            Me.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox"
            Me.exportVisualSettingsCheckBox.Size = New System.Drawing.Size(122, 18)
            Me.exportVisualSettingsCheckBox.TabIndex = 6
            Me.exportVisualSettingsCheckBox.Text = "ExportVisualSettings"
            '
            'radPageViewPagePdfExport
            '
            Me.radPageViewPagePdfExport.Controls.Add(Me.radCheckBoxShowHeaderAndFooter)
            Me.radPageViewPagePdfExport.Controls.Add(Me.radCheckBoxFitToPageWidth)
            Me.radPageViewPagePdfExport.Controls.Add(Me.radCheckBoxExportFlatDataPdfExport)
            Me.radPageViewPagePdfExport.Controls.Add(Me.radCheckBoxCustomizeVisualSettingsPdfExport)
            Me.radPageViewPagePdfExport.Controls.Add(Me.radButtonPdfExport)
            Me.radPageViewPagePdfExport.Controls.Add(Me.radCheckBoxExportVisualSettingsPdfExport)
            Me.radPageViewPagePdfExport.ItemSize = New System.Drawing.SizeF(65.0!, 28.0!)
            Me.radPageViewPagePdfExport.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPagePdfExport.Name = "radPageViewPagePdfExport"
            Me.radPageViewPagePdfExport.Size = New System.Drawing.Size(177, 697)
            Me.radPageViewPagePdfExport.Text = "PdfExport"
            '
            'radCheckBoxShowHeaderAndFooter
            '
            Me.radCheckBoxShowHeaderAndFooter.Location = New System.Drawing.Point(6, 156)
            Me.radCheckBoxShowHeaderAndFooter.Name = "radCheckBoxShowHeaderAndFooter"
            Me.radCheckBoxShowHeaderAndFooter.Size = New System.Drawing.Size(137, 18)
            Me.radCheckBoxShowHeaderAndFooter.TabIndex = 18
            Me.radCheckBoxShowHeaderAndFooter.Text = "ShowHeaderAndFooter"
            '
            'radCheckBoxFitToPageWidth
            '
            Me.radCheckBoxFitToPageWidth.Location = New System.Drawing.Point(6, 132)
            Me.radCheckBoxFitToPageWidth.Name = "radCheckBoxFitToPageWidth"
            Me.radCheckBoxFitToPageWidth.Size = New System.Drawing.Size(100, 18)
            Me.radCheckBoxFitToPageWidth.TabIndex = 17
            Me.radCheckBoxFitToPageWidth.Text = "FitToPageWidth"
            '
            'radCheckBoxExportFlatDataPdfExport
            '
            Me.radCheckBoxExportFlatDataPdfExport.Location = New System.Drawing.Point(6, 108)
            Me.radCheckBoxExportFlatDataPdfExport.Name = "radCheckBoxExportFlatDataPdfExport"
            Me.radCheckBoxExportFlatDataPdfExport.Size = New System.Drawing.Size(93, 18)
            Me.radCheckBoxExportFlatDataPdfExport.TabIndex = 16
            Me.radCheckBoxExportFlatDataPdfExport.Text = "ExportFlatData"
            '
            'radCheckBoxCustomizeVisualSettingsPdfExport
            '
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.AutoSize = False
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Location = New System.Drawing.Point(6, 40)
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Name = "radCheckBoxCustomizeVisualSettingsPdfExport"
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Size = New System.Drawing.Size(165, 38)
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.TabIndex = 15
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Text = "Customize visual settings when exporting"
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.TextWrap = True
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Customize visual settings when exporting"
            '
            'radButtonPdfExport
            '
            Me.radButtonPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonPdfExport.Location = New System.Drawing.Point(6, 11)
            Me.radButtonPdfExport.Name = "radButtonPdfExport"
            Me.radButtonPdfExport.Size = New System.Drawing.Size(165, 23)
            Me.radButtonPdfExport.TabIndex = 8
            Me.radButtonPdfExport.Text = "Export"
            '
            'radCheckBoxExportVisualSettingsPdfExport
            '
            Me.radCheckBoxExportVisualSettingsPdfExport.Location = New System.Drawing.Point(6, 84)
            Me.radCheckBoxExportVisualSettingsPdfExport.Name = "radCheckBoxExportVisualSettingsPdfExport"
            Me.radCheckBoxExportVisualSettingsPdfExport.Size = New System.Drawing.Size(122, 18)
            Me.radCheckBoxExportVisualSettingsPdfExport.TabIndex = 14
            Me.radCheckBoxExportVisualSettingsPdfExport.Text = "ExportVisualSettings"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1026, 748)
            Me.Controls.Add(Me.radPivotGrid1)
            Me.Controls.Add(Me.settingsPanel)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Export with DPL"
            CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageView1.ResumeLayout(False)
            Me.radPageViewPageSpreadExport.ResumeLayout(False)
            Me.radPageViewPageSpreadExport.PerformLayout()
            CType(Me.exportFlatDataCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.txtRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdfRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.csvRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xlsxRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageViewPagePdfExport.ResumeLayout(False)
            Me.radPageViewPagePdfExport.PerformLayout()
            CType(Me.radCheckBoxShowHeaderAndFooter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxFitToPageWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxExportFlatDataPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxExportVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
		Private settingsPanel As Telerik.WinControls.UI.RadPanel
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPageSpreadExport As Telerik.WinControls.UI.RadPageViewPage
		Private customizeVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private exportButton As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private txtRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private pdfRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private csvRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private xlsxRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private radPageViewPagePdfExport As Telerik.WinControls.UI.RadPageViewPage
		Private radCheckBoxCustomizeVisualSettingsPdfExport As Telerik.WinControls.UI.RadCheckBox
		Private radButtonPdfExport As Telerik.WinControls.UI.RadButton
		Private radCheckBoxExportVisualSettingsPdfExport As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents exportFlatDataCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxExportFlatDataPdfExport As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFitToPageWidth As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxShowHeaderAndFooter As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace