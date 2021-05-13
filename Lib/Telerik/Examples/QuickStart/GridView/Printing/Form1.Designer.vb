Namespace Telerik.Examples.WinControls.GridView.Printing
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim RadPrintWatermark1 As Telerik.WinControls.UI.RadPrintWatermark = New Telerik.WinControls.UI.RadPrintWatermark()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.radRadioButtonTable = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHtml = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonColumnGroups = New Telerik.WinControls.UI.RadRadioButton()
            Me.radButtonPrint = New Telerik.WinControls.UI.RadButton()
            Me.radButtonPrintPreview = New Telerik.WinControls.UI.RadButton()
            Me.radButtonPrintSettings = New Telerik.WinControls.UI.RadButton()
            Me.radPrintDocument1 = New Telerik.WinControls.UI.RadPrintDocument()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonTable, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonColumnGroups, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.settingsPanel.Location = New System.Drawing.Point(381, 90)
            Me.settingsPanel.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonPrint)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonPrintPreview)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonPrintSettings)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(223, 289)
            Me.settingsPanel.Size = New System.Drawing.Size(243, 289)
            '
            'radGridView1
            '
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            '
            '
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoExpandGroups = True
            GridViewDecimalColumn1.DataType = GetType(Integer)
            GridViewDecimalColumn1.FieldName = "EmployeeID"
            GridViewDecimalColumn1.HeaderText = "EmployeeID"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "EmployeeID"
            GridViewTextBoxColumn1.FieldName = "TitleOfCourtesy"
            GridViewTextBoxColumn1.HeaderText = "TitleOfCourtesy"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "TitleOfCourtesy"
            GridViewTextBoxColumn2.FieldName = "FirstName"
            GridViewTextBoxColumn2.HeaderText = "FirstName"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "FirstName"
            GridViewTextBoxColumn2.Width = 100
            GridViewTextBoxColumn3.FieldName = "LastName"
            GridViewTextBoxColumn3.HeaderText = "LastName"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "LastName"
            GridViewTextBoxColumn3.Width = 100
            GridViewTextBoxColumn4.FieldName = "Title"
            GridViewTextBoxColumn4.HeaderText = "Title"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Title"
            GridViewTextBoxColumn4.Width = 80
            GridViewDateTimeColumn1.FieldName = "BirthDate"
            GridViewDateTimeColumn1.HeaderText = "BirthDate"
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.IsVisible = False
            GridViewDateTimeColumn1.Name = "BirthDate"
            GridViewDateTimeColumn2.FieldName = "HireDate"
            GridViewDateTimeColumn2.HeaderText = "HireDate"
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.IsVisible = False
            GridViewDateTimeColumn2.Name = "HireDate"
            GridViewTextBoxColumn5.FieldName = "Country"
            GridViewTextBoxColumn5.HeaderText = "Country"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "Country"
            GridViewImageColumn1.DataType = GetType(Byte())
            GridViewImageColumn1.FieldName = "Photo"
            GridViewImageColumn1.HeaderText = "Photo"
            GridViewImageColumn1.IsAutoGenerated = True
            GridViewImageColumn1.IsVisible = False
            GridViewImageColumn1.Name = "Photo"
            GridViewTextBoxColumn6.FieldName = "Address"
            GridViewTextBoxColumn6.HeaderText = "Address"
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.Name = "Address"
            GridViewTextBoxColumn6.Width = 150
            GridViewTextBoxColumn7.FieldName = "City"
            GridViewTextBoxColumn7.HeaderText = "City"
            GridViewTextBoxColumn7.IsAutoGenerated = True
            GridViewTextBoxColumn7.IsVisible = False
            GridViewTextBoxColumn7.Name = "City"
            GridViewTextBoxColumn8.FieldName = "Region"
            GridViewTextBoxColumn8.HeaderText = "Region"
            GridViewTextBoxColumn8.IsAutoGenerated = True
            GridViewTextBoxColumn8.IsVisible = False
            GridViewTextBoxColumn8.Name = "Region"
            GridViewTextBoxColumn9.FieldName = "PostalCode"
            GridViewTextBoxColumn9.HeaderText = "PostalCode"
            GridViewTextBoxColumn9.IsAutoGenerated = True
            GridViewTextBoxColumn9.IsVisible = False
            GridViewTextBoxColumn9.Name = "PostalCode"
            GridViewTextBoxColumn10.FieldName = "HomePhone"
            GridViewTextBoxColumn10.HeaderText = "Phone"
            GridViewTextBoxColumn10.IsAutoGenerated = True
            GridViewTextBoxColumn10.Name = "HomePhone"
            GridViewTextBoxColumn10.Width = 80
            GridViewTextBoxColumn11.FieldName = "Extension"
            GridViewTextBoxColumn11.HeaderText = "Extension"
            GridViewTextBoxColumn11.IsAutoGenerated = True
            GridViewTextBoxColumn11.IsVisible = False
            GridViewTextBoxColumn11.Name = "Extension"
            GridViewTextBoxColumn12.FieldName = "Notes"
            GridViewTextBoxColumn12.HeaderText = "Notes"
            GridViewTextBoxColumn12.IsAutoGenerated = True
            GridViewTextBoxColumn12.IsVisible = False
            GridViewTextBoxColumn12.Name = "Notes"
            GridViewDecimalColumn2.DataType = GetType(Integer)
            GridViewDecimalColumn2.FieldName = "ReportsTo"
            GridViewDecimalColumn2.HeaderText = "ReportsTo"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "ReportsTo"
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewTextBoxColumn5, GridViewImageColumn1, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewDecimalColumn2})
            Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
            Me.radGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(2011, 1157)
            Me.radGridView1.TabIndex = 0
            '
            'employeesBindingSource
            '
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.northwindDataSet
            '
            'northwindDataSet
            '
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'radRadioButtonTable
            '
            Me.radRadioButtonTable.Location = New System.Drawing.Point(5, 21)
            Me.radRadioButtonTable.Name = "radRadioButtonTable"
            Me.radRadioButtonTable.Size = New System.Drawing.Size(47, 18)
            Me.radRadioButtonTable.TabIndex = 1
            Me.radRadioButtonTable.Text = "Table"
            '
            'radRadioButtonHtml
            '
            Me.radRadioButtonHtml.Location = New System.Drawing.Point(5, 45)
            Me.radRadioButtonHtml.Name = "radRadioButtonHtml"
            Me.radRadioButtonHtml.Size = New System.Drawing.Size(50, 18)
            Me.radRadioButtonHtml.TabIndex = 1
            Me.radRadioButtonHtml.Text = "HTML"
            '
            'radRadioButtonColumnGroups
            '
            Me.radRadioButtonColumnGroups.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButtonColumnGroups.Location = New System.Drawing.Point(5, 69)
            Me.radRadioButtonColumnGroups.Name = "radRadioButtonColumnGroups"
            Me.radRadioButtonColumnGroups.Size = New System.Drawing.Size(97, 18)
            Me.radRadioButtonColumnGroups.TabIndex = 1
            Me.radRadioButtonColumnGroups.Text = "Column groups"
            Me.radRadioButtonColumnGroups.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radButtonPrint
            '
            Me.radButtonPrint.Location = New System.Drawing.Point(11, 170)
            Me.radButtonPrint.Name = "radButtonPrint"
            Me.radButtonPrint.Size = New System.Drawing.Size(210, 24)
            Me.radButtonPrint.TabIndex = 2
            Me.radButtonPrint.Text = "Print"
            '
            'radButtonPrintPreview
            '
            Me.radButtonPrintPreview.Location = New System.Drawing.Point(11, 200)
            Me.radButtonPrintPreview.Name = "radButtonPrintPreview"
            Me.radButtonPrintPreview.Size = New System.Drawing.Size(210, 24)
            Me.radButtonPrintPreview.TabIndex = 2
            Me.radButtonPrintPreview.Text = "Print preview"
            '
            'radButtonPrintSettings
            '
            Me.radButtonPrintSettings.Location = New System.Drawing.Point(11, 230)
            Me.radButtonPrintSettings.Name = "radButtonPrintSettings"
            Me.radButtonPrintSettings.Size = New System.Drawing.Size(210, 24)
            Me.radButtonPrintSettings.TabIndex = 2
            Me.radButtonPrintSettings.Text = "Print settings"
            '
            'radPrintDocument1
            '
            Me.radPrintDocument1.AssociatedObject = Me.radGridView1
            Me.radPrintDocument1.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radPrintDocument1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            RadPrintWatermark1.Pages = Nothing
            RadPrintWatermark1.Text = Nothing
            Me.radPrintDocument1.Watermark = RadPrintWatermark1
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonTable)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonColumnGroups)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonHtml)
            Me.radGroupBox1.HeaderText = "Print style"
            Me.radGroupBox1.Location = New System.Drawing.Point(11, 47)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(210, 100)
            Me.radGroupBox1.TabIndex = 3
            Me.radGroupBox1.Text = "Print style"
            '
            'employeesTableAdapter
            '
            Me.employeesTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonTable, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHtml, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonColumnGroups, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonPrint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radRadioButtonTable As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonHtml As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonColumnGroups As Telerik.WinControls.UI.RadRadioButton
        Private radButtonPrint As Telerik.WinControls.UI.RadButton
        Private radButtonPrintPreview As Telerik.WinControls.UI.RadButton
        Private radButtonPrintSettings As Telerik.WinControls.UI.RadButton
        Private radPrintDocument1 As Telerik.WinControls.UI.RadPrintDocument
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private employeesBindingSource As System.Windows.Forms.BindingSource
        Private employeesTableAdapter As DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
    End Class
End Namespace