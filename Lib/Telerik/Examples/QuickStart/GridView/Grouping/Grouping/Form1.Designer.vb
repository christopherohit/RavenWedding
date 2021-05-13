Namespace Telerik.Examples.WinControls.GridView.Grouping.Grouping
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
			Me.customersBindingSource = New BindingSource(Me.components)
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
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(230, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.ImeMode = ImeMode.NoControl
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			gridViewTextBoxColumn1.FieldName = "ContactName"
			gridViewTextBoxColumn1.HeaderText = "Contact Name"
			gridViewTextBoxColumn1.HeaderTextAlignment = ContentAlignment.MiddleLeft
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "ContactName"
			gridViewTextBoxColumn1.Width = 314
			gridViewTextBoxColumn2.FieldName = "CompanyName"
			gridViewTextBoxColumn2.HeaderText = "Company Name"
			gridViewTextBoxColumn2.HeaderTextAlignment = ContentAlignment.MiddleLeft
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "CompanyName"
			gridViewTextBoxColumn2.Width = 314
			gridViewTextBoxColumn3.FieldName = "City"
			gridViewTextBoxColumn3.HeaderText = "City"
			gridViewTextBoxColumn3.HeaderTextAlignment = ContentAlignment.MiddleLeft
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "City"
			gridViewTextBoxColumn3.Width = 314
			gridViewTextBoxColumn4.FieldName = "Country"
			gridViewTextBoxColumn4.HeaderText = "Country"
			gridViewTextBoxColumn4.HeaderTextAlignment = ContentAlignment.MiddleLeft
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Country"
			gridViewTextBoxColumn4.Width = 316
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4})
			Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource
			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.MasterTemplate.ShowFilteringRow = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.RightToLeft = RightToLeft.No
			Me.radGridView1.Size = New Size(1276, 519)
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
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.BackColor = Color.Transparent
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimNone)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimSlide)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimFade)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimWipe)
			Me.radGroupBox1.Controls.Add(Me.radRadioAnimAccordion)
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = " Animation "
			Me.radGroupBox1.Location = New Point(10, 299)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(210, 133)
			Me.radGroupBox1.TabIndex = 10
			Me.radGroupBox1.Text = " Animation "
			' 
			' radRadioAnimNone
			' 
			Me.radRadioAnimNone.Location = New Point(19, 21)
			Me.radRadioAnimNone.Name = "radRadioAnimNone"
			Me.radRadioAnimNone.Size = New Size(48, 18)
			Me.radRadioAnimNone.TabIndex = 1
			Me.radRadioAnimNone.Text = "None"

			' 
			' radRadioAnimSlide
			' 
			Me.radRadioAnimSlide.Location = New Point(19, 109)
			Me.radRadioAnimSlide.Name = "radRadioAnimSlide"
			Me.radRadioAnimSlide.Size = New Size(44, 18)
			Me.radRadioAnimSlide.TabIndex = 0
			Me.radRadioAnimSlide.Text = "Slide"

			' 
			' radRadioAnimFade
			' 
			Me.radRadioAnimFade.Location = New Point(19, 87)
			Me.radRadioAnimFade.Name = "radRadioAnimFade"
			Me.radRadioAnimFade.Size = New Size(44, 18)
			Me.radRadioAnimFade.TabIndex = 0
			Me.radRadioAnimFade.Text = "Fade"

			' 
			' radRadioAnimWipe
			' 
			Me.radRadioAnimWipe.Location = New Point(19, 65)
			Me.radRadioAnimWipe.Name = "radRadioAnimWipe"
			Me.radRadioAnimWipe.Size = New Size(92, 18)
			Me.radRadioAnimWipe.TabIndex = 0
			Me.radRadioAnimWipe.Text = "Gradient Wipe"

			' 
			' radRadioAnimAccordion
			' 
			Me.radRadioAnimAccordion.Location = New Point(19, 43)
			Me.radRadioAnimAccordion.Name = "radRadioAnimAccordion"
			Me.radRadioAnimAccordion.Size = New Size(71, 18)
			Me.radRadioAnimAccordion.TabIndex = 0
			Me.radRadioAnimAccordion.Text = "Accordion"

			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.BackColor = Color.Transparent
			Me.radGroupBox2.Controls.Add(Me.radBtnCollapseAll)
			Me.radGroupBox2.Controls.Add(Me.radBtnExpandAll)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxShowGroupPanel)
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox2.HeaderText = " Grouping Options "
			Me.radGroupBox2.Location = New Point(10, 32)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(210, 116)
			Me.radGroupBox2.TabIndex = 10
			Me.radGroupBox2.Text = " Grouping Options "
			' 
			' radBtnCollapseAll
			' 
			Me.radBtnCollapseAll.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radBtnCollapseAll.Location = New Point(19, 26)
			Me.radBtnCollapseAll.Name = "radBtnCollapseAll"
			Me.radBtnCollapseAll.Size = New Size(178, 23)
			Me.radBtnCollapseAll.TabIndex = 10
			Me.radBtnCollapseAll.Text = "Collapse All"
			' 
			' radBtnExpandAll
			' 
			Me.radBtnExpandAll.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radBtnExpandAll.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radBtnExpandAll.Location = New Point(19, 55)
			Me.radBtnExpandAll.Name = "radBtnExpandAll"
			Me.radBtnExpandAll.Size = New Size(178, 23)
			Me.radBtnExpandAll.TabIndex = 10
			Me.radBtnExpandAll.Text = "Expand All"
			' 
			' radCheckBoxShowGroupPanel
			' 
			Me.radCheckBoxShowGroupPanel.Location = New Point(19, 84)
			Me.radCheckBoxShowGroupPanel.Name = "radCheckBoxShowGroupPanel"
			Me.radCheckBoxShowGroupPanel.Size = New Size(128, 18)
			Me.radCheckBoxShowGroupPanel.TabIndex = 9
			Me.radCheckBoxShowGroupPanel.Text = "Show Grouping Panel"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.BackColor = Color.Transparent
			Me.radGroupBox3.Controls.Add(Me.radRadioCityCountry)
			Me.radGroupBox3.Controls.Add(Me.radRadioDisable)
			Me.radGroupBox3.Controls.Add(Me.radRadioNone)
			Me.radGroupBox3.Controls.Add(Me.radRadioCountry)
			Me.radGroupBox3.Controls.Add(Me.radRadioCity)
			Me.radGroupBox3.FooterText = ""
			Me.radGroupBox3.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox3.HeaderText = " Group By "
			Me.radGroupBox3.Location = New Point(10, 154)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New Size(210, 136)
			Me.radGroupBox3.TabIndex = 10
			Me.radGroupBox3.Text = " Group By "
			' 
			' radRadioCityCountry
			' 
			Me.radRadioCityCountry.Location = New Point(19, 22)
			Me.radRadioCityCountry.Name = "radRadioCityCountry"
			Me.radRadioCityCountry.Size = New Size(104, 18)
			Me.radRadioCityCountry.TabIndex = 0
			Me.radRadioCityCountry.Text = "Country and City"
			' 
			' radRadioDisable
			' 
			Me.radRadioDisable.Location = New Point(19, 110)
			Me.radRadioDisable.Name = "radRadioDisable"
			Me.radRadioDisable.Size = New Size(57, 18)
			Me.radRadioDisable.TabIndex = 0
			Me.radRadioDisable.Text = "Disable"
			' 
			' radRadioNone
			' 
			Me.radRadioNone.Location = New Point(19, 88)
			Me.radRadioNone.Name = "radRadioNone"
			Me.radRadioNone.Size = New Size(48, 18)
			Me.radRadioNone.TabIndex = 0
			Me.radRadioNone.Text = "None"
			' 
			' radRadioCountry
			' 
			Me.radRadioCountry.Location = New Point(19, 66)
			Me.radRadioCountry.Name = "radRadioCountry"
			Me.radRadioCountry.Size = New Size(60, 18)
			Me.radRadioCountry.TabIndex = 0
			Me.radRadioCountry.Text = "Country"
			' 
			' radRadioCity
			' 
			Me.radRadioCity.Location = New Point(19, 44)
			Me.radRadioCity.Name = "radRadioCity"
			Me.radRadioCity.Size = New Size(39, 18)
			Me.radRadioCity.TabIndex = 0
			Me.radRadioCity.Text = "City"
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1276, 519)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioAnimNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimSlide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimFade, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimWipe, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAnimAccordion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radBtnCollapseAll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnExpandAll, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowGroupPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
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
		Private radCheckBoxShowGroupPanel As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioCity As Telerik.WinControls.UI.RadRadioButton
		Private radRadioCityCountry As Telerik.WinControls.UI.RadRadioButton
		Private radRadioCountry As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAnimAccordion As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAnimWipe As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAnimFade As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAnimSlide As Telerik.WinControls.UI.RadRadioButton
		Private radBtnExpandAll As Telerik.WinControls.UI.RadButton
		Private radBtnCollapseAll As Telerik.WinControls.UI.RadButton
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private radRadioNone As Telerik.WinControls.UI.RadRadioButton
		Private customersBindingSource As BindingSource
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private radRadioAnimNone As Telerik.WinControls.UI.RadRadioButton
		Private radRadioDisable As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
