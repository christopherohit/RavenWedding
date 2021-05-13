Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.GridView.Grouping
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
			Me.components = New System.ComponentModel.Container()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAnimNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAnimSlide = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAnimFade = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAnimWipe = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAnimAccordion = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radBtnCollapseAll = New Telerik.WinControls.UI.RadButton()
			Me.radBtnExpandAll = New Telerik.WinControls.UI.RadButton()
			Me.radCheckBoxShowGroupPanel = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioCityCountry = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCountry = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCity = New Telerik.WinControls.UI.RadRadioButton()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioAnimNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAnimSlide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAnimFade, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAnimWipe, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAnimAccordion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radBtnCollapseAll, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnExpandAll, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowGroupPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radRadioCityCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCity, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn1.FieldName = "ContactName"
			gridViewTextBoxColumn1.HeaderText = "Contact Name"
			gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "ContactName"
			gridViewTextBoxColumn1.Width = 240
			gridViewTextBoxColumn2.FieldName = "CompanyName"
			gridViewTextBoxColumn2.HeaderText = "Company Name"
			gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "CompanyName"
			gridViewTextBoxColumn2.Width = 240
			gridViewTextBoxColumn3.FieldName = "City"
			gridViewTextBoxColumn3.HeaderText = "City"
			gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "City"
			gridViewTextBoxColumn3.Width = 240
			gridViewTextBoxColumn4.FieldName = "Country"
			gridViewTextBoxColumn4.HeaderText = "Country"
			gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Country"
			gridViewTextBoxColumn4.Width = 240
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource
			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.MasterTemplate.ShowFilteringRow = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(1224, 737)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "ControlDefault"
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.BackColor = System.Drawing.Color.Transparent
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimNone)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimSlide)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimFade)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimWipe)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimAccordion)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = " Animation "
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 247)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 133)
			Me.radGroupBox1.TabIndex = 10
			Me.radGroupBox1.Text = " Animation "
			' 
			' radRadioAnimNone
			' 
			Me.radRadioAnimNone.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimNone.Location = New System.Drawing.Point(19, 21)
			Me.radRadioAnimNone.Name = "radRadioAnimNone"
			' 
			' 
			' 
			Me.radRadioAnimNone.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimNone.Size = New System.Drawing.Size(47, 16)
			Me.radRadioAnimNone.TabIndex = 1
			Me.radRadioAnimNone.Text = "None"
'			Me.radRadioAnimNone.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioAnimation_StateChanged);
			' 
			' radRadioAnimSlide
			' 
			Me.radRadioAnimSlide.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimSlide.Location = New System.Drawing.Point(19, 109)
			Me.radRadioAnimSlide.Name = "radRadioAnimSlide"
			' 
			' 
			' 
			Me.radRadioAnimSlide.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimSlide.Size = New System.Drawing.Size(45, 16)
			Me.radRadioAnimSlide.TabIndex = 0
			Me.radRadioAnimSlide.Text = "Slide"
'			Me.radRadioAnimSlide.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioAnimation_StateChanged);
			' 
			' radRadioAnimFade
			' 
			Me.radRadioAnimFade.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimFade.Location = New System.Drawing.Point(19, 87)
			Me.radRadioAnimFade.Name = "radRadioAnimFade"
			' 
			' 
			' 
			Me.radRadioAnimFade.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimFade.Size = New System.Drawing.Size(46, 16)
			Me.radRadioAnimFade.TabIndex = 0
			Me.radRadioAnimFade.Text = "Fade"
'			Me.radRadioAnimFade.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioAnimation_StateChanged);
			' 
			' radRadioAnimWipe
			' 
			Me.radRadioAnimWipe.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimWipe.Location = New System.Drawing.Point(19, 65)
			Me.radRadioAnimWipe.Name = "radRadioAnimWipe"
			' 
			' 
			' 
			Me.radRadioAnimWipe.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimWipe.Size = New System.Drawing.Size(93, 16)
			Me.radRadioAnimWipe.TabIndex = 0
			Me.radRadioAnimWipe.Text = "Gradient Wipe"
'			Me.radRadioAnimWipe.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioAnimation_StateChanged);
			' 
			' radRadioAnimAccordion
			' 
			Me.radRadioAnimAccordion.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimAccordion.Location = New System.Drawing.Point(19, 43)
			Me.radRadioAnimAccordion.Name = "radRadioAnimAccordion"
			' 
			' 
			' 
			Me.radRadioAnimAccordion.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioAnimAccordion.Size = New System.Drawing.Size(71, 16)
			Me.radRadioAnimAccordion.TabIndex = 0
			Me.radRadioAnimAccordion.Text = "Accordion"
'			Me.radRadioAnimAccordion.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioAnimation_StateChanged);
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.BackColor = System.Drawing.Color.Transparent
			Me.radGroupBox2.Controls.Add(Me.radBtnCollapseAll)
			Me.radGroupBox2.Controls.Add(Me.radBtnExpandAll)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxShowGroupPanel)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox2.HeaderText = " Grouping Options "
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 87)
			Me.radGroupBox2.TabIndex = 10
			Me.radGroupBox2.Text = " Grouping Options "
			' 
			' radBtnCollapseAll
			' 
			Me.radBtnCollapseAll.Location = New System.Drawing.Point(85, 25)
			Me.radBtnCollapseAll.Name = "radBtnCollapseAll"
			Me.radBtnCollapseAll.Size = New System.Drawing.Size(71, 23)
			Me.radBtnCollapseAll.TabIndex = 10
			Me.radBtnCollapseAll.Text = "Collapse All"
'			Me.radBtnCollapseAll.Click += New System.EventHandler(Me.OnBtnCollapse_Click);
			' 
			' radBtnExpandAll
			' 
			Me.radBtnExpandAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radBtnExpandAll.Location = New System.Drawing.Point(8, 25)
			Me.radBtnExpandAll.Name = "radBtnExpandAll"
			Me.radBtnExpandAll.Size = New System.Drawing.Size(71, 23)
			Me.radBtnExpandAll.TabIndex = 10
			Me.radBtnExpandAll.Text = "Expand All"
'			Me.radBtnExpandAll.Click += New System.EventHandler(Me.OnBtnExpand_Click);
			' 
			' radCheckBoxShowGroupPanel
			' 
			Me.radCheckBoxShowGroupPanel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxShowGroupPanel.Location = New System.Drawing.Point(19, 58)
			Me.radCheckBoxShowGroupPanel.Name = "radCheckBoxShowGroupPanel"
			' 
			' 
			' 
			Me.radCheckBoxShowGroupPanel.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBoxShowGroupPanel.Size = New System.Drawing.Size(132, 17)
			Me.radCheckBoxShowGroupPanel.TabIndex = 9
			Me.radCheckBoxShowGroupPanel.Text = "Show Grouping Panel"
'			Me.radCheckBoxShowGroupPanel.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnCheckBoxShowGroupPanel_StateChanged);
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox3.BackColor = System.Drawing.Color.Transparent
			Me.radGroupBox3.Controls.Add(Me.radRadioCityCountry)
			Me.radGroupBox3.Controls.Add(Me.radRadioDisable)
			Me.radGroupBox3.Controls.Add(Me.radRadioNone)
			Me.radGroupBox3.Controls.Add(Me.radRadioCountry)
			Me.radGroupBox3.Controls.Add(Me.radRadioCity)
			Me.radGroupBox3.FooterImageIndex = -1
			Me.radGroupBox3.FooterImageKey = ""
			Me.radGroupBox3.FooterText = ""
			Me.radGroupBox3.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.HeaderImageIndex = -1
			Me.radGroupBox3.HeaderImageKey = ""
			Me.radGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox3.HeaderText = " Group By "
			Me.radGroupBox3.Location = New System.Drawing.Point(10, 102)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New System.Drawing.Size(180, 136)
			Me.radGroupBox3.TabIndex = 10
			Me.radGroupBox3.Text = " Group By "
			' 
			' radRadioCityCountry
			' 
			Me.radRadioCityCountry.ForeColor = System.Drawing.Color.Black
			Me.radRadioCityCountry.Location = New System.Drawing.Point(19, 22)
			Me.radRadioCityCountry.Name = "radRadioCityCountry"
			' 
			' 
			' 
			Me.radRadioCityCountry.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCityCountry.Size = New System.Drawing.Size(104, 16)
			Me.radRadioCityCountry.TabIndex = 0
			Me.radRadioCityCountry.Text = "Country and City"
'			Me.radRadioCityCountry.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioGroupType_StateChanged);
			' 
			' radRadioDisable
			' 
			Me.radRadioDisable.ForeColor = System.Drawing.Color.Black
			Me.radRadioDisable.Location = New System.Drawing.Point(19, 110)
			Me.radRadioDisable.Name = "radRadioDisable"
			' 
			' 
			' 
			Me.radRadioDisable.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDisable.Size = New System.Drawing.Size(58, 16)
			Me.radRadioDisable.TabIndex = 0
			Me.radRadioDisable.Text = "Disable"
'			Me.radRadioDisable.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioGroupType_StateChanged);
			' 
			' radRadioNone
			' 
			Me.radRadioNone.ForeColor = System.Drawing.Color.Black
			Me.radRadioNone.Location = New System.Drawing.Point(19, 88)
			Me.radRadioNone.Name = "radRadioNone"
			' 
			' 
			' 
			Me.radRadioNone.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioNone.Size = New System.Drawing.Size(47, 16)
			Me.radRadioNone.TabIndex = 0
			Me.radRadioNone.Text = "None"
'			Me.radRadioNone.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioGroupType_StateChanged);
			' 
			' radRadioCountry
			' 
			Me.radRadioCountry.ForeColor = System.Drawing.Color.Black
			Me.radRadioCountry.Location = New System.Drawing.Point(19, 66)
			Me.radRadioCountry.Name = "radRadioCountry"
			' 
			' 
			' 
			Me.radRadioCountry.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCountry.Size = New System.Drawing.Size(60, 16)
			Me.radRadioCountry.TabIndex = 0
			Me.radRadioCountry.Text = "Country"
'			Me.radRadioCountry.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioGroupType_StateChanged);
			' 
			' radRadioCity
			' 
			Me.radRadioCity.ForeColor = System.Drawing.Color.Black
			Me.radRadioCity.Location = New System.Drawing.Point(19, 44)
			Me.radRadioCity.Name = "radRadioCity"
			' 
			' 
			' 
			Me.radRadioCity.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCity.Size = New System.Drawing.Size(40, 16)
			Me.radRadioCity.TabIndex = 0
			Me.radRadioCity.Text = "City"
'			Me.radRadioCity.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnRadioGroupType_StateChanged);
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radRadioAnimNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimSlide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimFade, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimWipe, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimAccordion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radBtnCollapseAll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnExpandAll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowGroupPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			CType(Me.radRadioCityCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCity, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckBoxShowGroupPanel As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioCity As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioCityCountry As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioCountry As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAnimAccordion As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAnimWipe As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAnimFade As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioAnimSlide As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radBtnExpandAll As Telerik.WinControls.UI.RadButton
		Private WithEvents radBtnCollapseAll As Telerik.WinControls.UI.RadButton
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private WithEvents radRadioNone As Telerik.WinControls.UI.RadRadioButton
		Private customersBindingSource As BindingSource
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private WithEvents radRadioAnimNone As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioDisable As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
