Imports Microsoft.VisualBasic
Imports System
Namespace ExportWithDpl.PropertyGrid
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
            Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
            Me.exportDescriptionsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.groupChildItemsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.exportVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.customizeVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.collapsedOptionDoNotExportRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.collapsedOptionExportAsHiddenRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.collapsedOptionExportAlwaysRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.exportFormatTxtRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatCsvRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatPdfRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatXlsxRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.exportDescriptionsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupChildItemsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.collapsedOptionDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapsedOptionExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapsedOptionExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.exportFormatTxtRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatCsvRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatPdfRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatXlsxRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.exportDescriptionsCheckBox)
            Me.settingsPanel.Controls.Add(Me.groupChildItemsCheckBox)
            Me.settingsPanel.Controls.Add(Me.exportVisualSettingsCheckBox)
            Me.settingsPanel.Controls.Add(Me.customizeVisualSettingsCheckBox)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.exportButton)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(381, 0)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(211, 570)
            Me.settingsPanel.TabIndex = 1
            '
            'exportDescriptionsCheckBox
            '
            Me.exportDescriptionsCheckBox.Location = New System.Drawing.Point(5, 132)
            Me.exportDescriptionsCheckBox.Name = "exportDescriptionsCheckBox"
            Me.exportDescriptionsCheckBox.Size = New System.Drawing.Size(114, 18)
            Me.exportDescriptionsCheckBox.TabIndex = 18
            Me.exportDescriptionsCheckBox.Text = "ExportDescriptions"
            '
            'groupChildItemsCheckBox
            '
            Me.groupChildItemsCheckBox.Location = New System.Drawing.Point(5, 107)
            Me.groupChildItemsCheckBox.Name = "groupChildItemsCheckBox"
            Me.groupChildItemsCheckBox.Size = New System.Drawing.Size(149, 18)
            Me.groupChildItemsCheckBox.TabIndex = 17
            Me.groupChildItemsCheckBox.Text = "ExportChildItemsGrouped"
            '
            'exportVisualSettingsCheckBox
            '
            Me.exportVisualSettingsCheckBox.Location = New System.Drawing.Point(5, 83)
            Me.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox"
            Me.exportVisualSettingsCheckBox.Size = New System.Drawing.Size(122, 18)
            Me.exportVisualSettingsCheckBox.TabIndex = 16
            Me.exportVisualSettingsCheckBox.Text = "ExportVisualSettings"
            '
            'customizeVisualSettingsCheckBox
            '
            Me.customizeVisualSettingsCheckBox.AutoSize = False
            Me.customizeVisualSettingsCheckBox.Location = New System.Drawing.Point(5, 42)
            Me.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox"
            Me.customizeVisualSettingsCheckBox.Size = New System.Drawing.Size(193, 35)
            Me.customizeVisualSettingsCheckBox.TabIndex = 14
            Me.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting"
            Me.customizeVisualSettingsCheckBox.TextWrap = True
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionDoNotExportRadioButton)
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionExportAsHiddenRadioButton)
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionExportAlwaysRadioButton)
            Me.radGroupBox2.HeaderText = "Collapsed item option"
            Me.radGroupBox2.Location = New System.Drawing.Point(6, 240)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(192, 100)
            Me.radGroupBox2.TabIndex = 13
            Me.radGroupBox2.Text = "Collapsed item option"
            '
            'collapsedOptionDoNotExportRadioButton
            '
            Me.collapsedOptionDoNotExportRadioButton.Location = New System.Drawing.Point(6, 46)
            Me.collapsedOptionDoNotExportRadioButton.Name = "collapsedOptionDoNotExportRadioButton"
            Me.collapsedOptionDoNotExportRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.collapsedOptionDoNotExportRadioButton.TabIndex = 1
            Me.collapsedOptionDoNotExportRadioButton.Text = "DoNotExport"
            '
            'collapsedOptionExportAsHiddenRadioButton
            '
            Me.collapsedOptionExportAsHiddenRadioButton.Location = New System.Drawing.Point(6, 70)
            Me.collapsedOptionExportAsHiddenRadioButton.Name = "collapsedOptionExportAsHiddenRadioButton"
            Me.collapsedOptionExportAsHiddenRadioButton.Size = New System.Drawing.Size(101, 18)
            Me.collapsedOptionExportAsHiddenRadioButton.TabIndex = 1
            Me.collapsedOptionExportAsHiddenRadioButton.Text = "ExportAsHidden"
            '
            'collapsedOptionExportAlwaysRadioButton
            '
            Me.collapsedOptionExportAlwaysRadioButton.Location = New System.Drawing.Point(6, 22)
            Me.collapsedOptionExportAlwaysRadioButton.Name = "collapsedOptionExportAlwaysRadioButton"
            Me.collapsedOptionExportAlwaysRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.collapsedOptionExportAlwaysRadioButton.TabIndex = 0
            Me.collapsedOptionExportAlwaysRadioButton.Text = "ExportAlways"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.exportFormatTxtRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatCsvRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatPdfRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatXlsxRadioButton)
            Me.radGroupBox1.HeaderText = "Export format"
            Me.radGroupBox1.Location = New System.Drawing.Point(6, 156)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(192, 77)
            Me.radGroupBox1.TabIndex = 12
            Me.radGroupBox1.Text = "Export format"
            '
            'exportFormatTxtRadioButton
            '
            Me.exportFormatTxtRadioButton.Location = New System.Drawing.Point(82, 46)
            Me.exportFormatTxtRadioButton.Name = "exportFormatTxtRadioButton"
            Me.exportFormatTxtRadioButton.Size = New System.Drawing.Size(39, 18)
            Me.exportFormatTxtRadioButton.TabIndex = 1
            Me.exportFormatTxtRadioButton.Text = "TXT"
            '
            'exportFormatCsvRadioButton
            '
            Me.exportFormatCsvRadioButton.Location = New System.Drawing.Point(6, 46)
            Me.exportFormatCsvRadioButton.Name = "exportFormatCsvRadioButton"
            Me.exportFormatCsvRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.exportFormatCsvRadioButton.TabIndex = 1
            Me.exportFormatCsvRadioButton.Text = "CSV"
            '
            'exportFormatPdfRadioButton
            '
            Me.exportFormatPdfRadioButton.Location = New System.Drawing.Point(82, 22)
            Me.exportFormatPdfRadioButton.Name = "exportFormatPdfRadioButton"
            Me.exportFormatPdfRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.exportFormatPdfRadioButton.TabIndex = 1
            Me.exportFormatPdfRadioButton.Text = "PDF"
            '
            'exportFormatXlsxRadioButton
            '
            Me.exportFormatXlsxRadioButton.Location = New System.Drawing.Point(6, 22)
            Me.exportFormatXlsxRadioButton.Name = "exportFormatXlsxRadioButton"
            Me.exportFormatXlsxRadioButton.Size = New System.Drawing.Size(45, 18)
            Me.exportFormatXlsxRadioButton.TabIndex = 0
            Me.exportFormatXlsxRadioButton.Text = "XLSX"
            '
            'exportButton
            '
            Me.exportButton.Location = New System.Drawing.Point(6, 12)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(192, 24)
            Me.exportButton.TabIndex = 11
            Me.exportButton.Text = "Export"
            '
            'radPropertyGrid1
            '
            Me.radPropertyGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radPropertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.SelectedObject = Me.exportButton
            Me.radPropertyGrid1.Size = New System.Drawing.Size(381, 570)
            Me.radPropertyGrid1.SortOrder = System.Windows.Forms.SortOrder.Ascending
            Me.radPropertyGrid1.TabIndex = 2
            Me.radPropertyGrid1.Text = "radPropertyGrid1"
            Me.radPropertyGrid1.ToolbarVisible = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(592, 570)
            Me.Controls.Add(Me.radPropertyGrid1)
            Me.Controls.Add(Me.settingsPanel)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Export with Document Processing Libraries"
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.exportDescriptionsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupChildItemsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.collapsedOptionDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapsedOptionExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapsedOptionExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.exportFormatTxtRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatCsvRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatPdfRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatXlsxRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private settingsPanel As Telerik.WinControls.UI.RadPanel
		Private groupChildItemsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private exportVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private customizeVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private collapsedOptionDoNotExportRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private collapsedOptionExportAsHiddenRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private collapsedOptionExportAlwaysRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private exportFormatTxtRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatCsvRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatPdfRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatXlsxRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportButton As Telerik.WinControls.UI.RadButton
		Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
		Private exportDescriptionsCheckBox As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace