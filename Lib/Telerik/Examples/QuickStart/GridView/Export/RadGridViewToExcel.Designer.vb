Imports Microsoft.VisualBasic
Imports Telerik.WinControls.UI
Imports System.Collections.Generic
Namespace Telerik.Examples.WinControls.GridView.Export
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
			Me.components = New System.ComponentModel.Container()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBoxSheet = New Telerik.WinControls.UI.RadTextBox()
			Me.radComboBoxSummaries = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radCheckBoxExportVisual = New Telerik.WinControls.UI.RadCheckBox()
			Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radLblProgress = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radListBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxSheet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxSummaries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxExportVisual, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1125, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.Dash = False
			Me.radProgressBar1.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar1.Location = New System.Drawing.Point(10, 323)
			Me.radProgressBar1.Name = "radProgressBar1"
			' 
			' 
			' 
			Me.radProgressBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar1.SeparatorWidth = 4
			Me.radProgressBar1.Size = New System.Drawing.Size(143, 17)
			Me.radProgressBar1.StepWidth = 13
			Me.radProgressBar1.TabIndex = 5
			Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radProgressBar1.Visible = False
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(9, 254)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(68, 18)
			Me.radLabel1.TabIndex = 7
			Me.radLabel1.Text = "Sheet name:"
			' 
			' radTextBoxSheet
			' 
			Me.radTextBoxSheet.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxSheet.Location = New System.Drawing.Point(9, 275)
			Me.radTextBoxSheet.Name = "radTextBoxSheet"
			' 
			' 
			' 
			Me.radTextBoxSheet.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxSheet.Size = New System.Drawing.Size(143, 20)
			Me.radTextBoxSheet.TabIndex = 6
			Me.radTextBoxSheet.TabStop = False
			' 
			' radComboBoxSummaries
			' 
			Me.radComboBoxSummaries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxSummaries.ForeColor = System.Drawing.Color.Black
			Me.radComboBoxSummaries.Items.AddRange(New List(Of RadListDataItem) (New RadListDataItem() { Me.radComboBoxItem3, Me.radComboBoxItem4, Me.radComboBoxItem5, Me.radComboBoxItem6}))
			Me.radComboBoxSummaries.Location = New System.Drawing.Point(9, 227)
			Me.radComboBoxSummaries.Name = "radComboBoxSummaries"
			Me.radComboBoxSummaries.NullText = "How to export summaries"
			' 
			' 
			' 
			Me.radComboBoxSummaries.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxSummaries.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboBoxSummaries.Size = New System.Drawing.Size(143, 20)
			Me.radComboBoxSummaries.TabIndex = 5
			Me.radComboBoxSummaries.TabStop = False
'			Me.radComboBoxSummaries.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radComboBoxSummaries_SelectedIndexChanged);
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "All Summaries"
			' 
			' radComboBoxItem4
			'
			Me.radComboBoxItem4.Text = "OnlyTop Summaries"
			' 
			' radComboBoxItem5
			' 
			Me.radComboBoxItem5.Text = "Only Bottom Summaries"
			' 
			' radComboBoxItem6
			' 
			Me.radComboBoxItem6.Text = "Do not export summaries"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Enabled = False
			Me.radRadioButton2.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton2.Location = New System.Drawing.Point(9, 191)
			Me.radRadioButton2.Name = "radRadioButton2"
			' 
			' 
			' 
			Me.radRadioButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton2.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButton2.TabIndex = 4
			Me.radRadioButton2.Text = "Max rows supported" & Constants.vbCrLf & "by prior versions"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Enabled = False
			Me.radRadioButton1.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.Location = New System.Drawing.Point(9, 155)
			Me.radRadioButton1.Name = "radRadioButton1"
			' 
			' 
			' 
			Me.radRadioButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.Size = New System.Drawing.Size(128, 29)
			Me.radRadioButton1.TabIndex = 3
			Me.radRadioButton1.Text = "Max rows supported" & Constants.vbCrLf & "by Excel 2007"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxExportVisual
			' 
			Me.radCheckBoxExportVisual.Enabled = False
			Me.radCheckBoxExportVisual.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportVisual.Location = New System.Drawing.Point(9, 131)
			Me.radCheckBoxExportVisual.Name = "radCheckBoxExportVisual"
			' 
			' 
			' 
			Me.radCheckBoxExportVisual.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxExportVisual.Size = New System.Drawing.Size(125, 18)
			Me.radCheckBoxExportVisual.TabIndex = 2
			Me.radCheckBoxExportVisual.Text = "Export visual settings"
			Me.radCheckBoxExportVisual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radButtonExport
			' 
			Me.radButtonExport.ForeColor = System.Drawing.Color.Black
			Me.radButtonExport.Location = New System.Drawing.Point(10, 347)
			Me.radButtonExport.Name = "radButtonExport"
			' 
			' 
			' 
			Me.radButtonExport.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButtonExport.Size = New System.Drawing.Size(144, 20)
			Me.radButtonExport.TabIndex = 1
			Me.radButtonExport.Text = "Run Export"
'			Me.radButtonExport.Click += New System.EventHandler(Me.radButtonExport_Click);
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			gridViewTextBoxColumn1.FieldName = "CompanyName"
			gridViewTextBoxColumn1.HeaderText = "Company Name"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "CompanyName"
			gridViewTextBoxColumn1.Width = 187
			gridViewTextBoxColumn2.FieldName = "ContactName"
			gridViewTextBoxColumn2.HeaderText = "Contact Name"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "ContactName"
			gridViewTextBoxColumn2.Width = 187
			gridViewTextBoxColumn3.FieldName = "ContactTitle"
			gridViewTextBoxColumn3.HeaderText = "Contact Title"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "ContactTitle"
			gridViewTextBoxColumn3.Width = 187
			gridViewTextBoxColumn4.FieldName = "Address"
			gridViewTextBoxColumn4.HeaderText = "Address"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Address"
			gridViewTextBoxColumn4.Width = 187
			gridViewTextBoxColumn5.FieldName = "City"
			gridViewTextBoxColumn5.HeaderText = "City"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "City"
			gridViewTextBoxColumn5.Width = 187
			gridViewTextBoxColumn6.FieldName = "Country"
			gridViewTextBoxColumn6.HeaderText = "Country"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "Country"
			gridViewTextBoxColumn6.Width = 187
			gridViewTextBoxColumn7.FieldName = "Phone"
			gridViewTextBoxColumn7.HeaderText = "Phone"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.Name = "Phone"
			gridViewTextBoxColumn7.Width = 190
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7})
			Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New System.Drawing.Size(1326, 749)
			Me.radGridView1.TabIndex = 7
			Me.radGridView1.Text = "radGridView1"
			' 
			' radLblProgress
			' 
			Me.radLblProgress.ForeColor = System.Drawing.Color.Black
			Me.radLblProgress.Location = New System.Drawing.Point(9, 302)
			Me.radLblProgress.Name = "radLblProgress"
			' 
			' 
			' 
			Me.radLblProgress.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblProgress.Size = New System.Drawing.Size(52, 18)
			Me.radLblProgress.TabIndex = 7
			Me.radLblProgress.Text = "Progress:"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radListBox1)
			Me.radGroupSettings.Controls.Add(Me.radTextBoxSheet)
			Me.radGroupSettings.Controls.Add(Me.radLabel1)
			Me.radGroupSettings.Controls.Add(Me.radButtonExport)
			Me.radGroupSettings.Controls.Add(Me.radRadioButton1)
			Me.radGroupSettings.Controls.Add(Me.radRadioButton2)
			Me.radGroupSettings.Controls.Add(Me.radProgressBar1)
			Me.radGroupSettings.Controls.Add(Me.radComboBoxSummaries)
			Me.radGroupSettings.Controls.Add(Me.radLblProgress)
			Me.radGroupSettings.Controls.Add(Me.radCheckBoxExportVisual)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSettings.HeaderText = "Export Settings"
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 424)
			Me.radGroupSettings.TabIndex = 8
			Me.radGroupSettings.Text = "Export Settings"
			' 
			' radListBox1
			' 
			Me.radListBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radListBoxItem1, Me.radListBoxItem2, Me.radListBoxItem3, Me.radListBoxItem4, Me.radListBoxItem5}))
			Me.radListBox1.Location = New System.Drawing.Point(9, 23)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Size = New System.Drawing.Size(143, 102)
			Me.radListBox1.TabIndex = 8
			Me.radListBox1.Text = "Export to Excel"
'			Me.radListBox1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radListBox1_SelectedIndexChanged);
			' 
			' radListBoxItem1
			' 
			Me.radListBoxItem1.Text = "Export to Excel"
			' 
			' radListBoxItem2
			' 
			Me.radListBoxItem2.Text = "Export to ExcelML"
			' 
			' radListBoxItem3
			' 
			Me.radListBoxItem3.Text = "Export to CSV"
			' 
			' radListBoxItem4
			' 
			Me.radListBoxItem4.Text = "Export to HTML"
			' 
			' radListBoxItem5
			' 
			Me.radListBoxItem5.Text = "Export to PDF"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1326, 749)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxSheet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxSummaries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxExportVisual, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblProgress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private saveFileDialog As System.Windows.Forms.SaveFileDialog
		Private radProgressBar1 As RadProgressBar
		Private radGridView1 As RadGridView
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private radRadioButton2 As RadRadioButton
		Private radRadioButton1 As RadRadioButton
		Private radCheckBoxExportVisual As RadCheckBox
		Private WithEvents radButtonExport As RadButton
		Private radTextBoxSheet As RadTextBox
		Private WithEvents radComboBoxSummaries As RadDropDownList
		Private radComboBoxItem3 As RadListDataItem
		Private radComboBoxItem4 As RadListDataItem
		Private radComboBoxItem5 As RadListDataItem
		Private radComboBoxItem6 As RadListDataItem
		Private radLabel1 As RadLabel
		Private radLblProgress As RadLabel
		Private radGroupSettings As RadGroupBox
		Private WithEvents radListBox1 As RadListControl
		Private radListBoxItem1 As RadListDataItem
		Private radListBoxItem2 As RadListDataItem
		Private radListBoxItem3 As RadListDataItem
		Private radListBoxItem4 As RadListDataItem
		Private radListBoxItem5 As RadListDataItem
	End Class
End Namespace

