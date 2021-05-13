Namespace Telerik.Examples.WinControls.GridView.Columns.ColumnTypes
    Partial Class Form1
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
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.radGroupBoxColumns = New Telerik.WinControls.UI.RadGroupBox()
            Me.enableTimeSpanCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.enableSparklineCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radMultiComboBoxCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radDateTimeCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCommandCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCustom = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxBrowse = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCalculator = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxColor = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxHyperlink = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxMaskBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxLookUp = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxImage = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxText = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxDecimal = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxRating = New Telerik.WinControls.UI.RadCheckBox()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxColumns.SuspendLayout()
            CType(Me.enableTimeSpanCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.enableSparklineCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMultiComboBoxCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimeCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCommandCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCustom, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxHyperlink, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxMaskBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxRating, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBoxColumns)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(303, 747)
            Me.settingsPanel.Size = New System.Drawing.Size(303, 747)
            '
            'radGridView1
            '
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.ForeColor = System.Drawing.Color.Black
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            '
            '
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.Caption = Nothing
            Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
            Me.radGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(2046, 1156)
            Me.radGridView1.TabIndex = 0
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "NwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'carsBindingSource
            '
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.nwindDataSet
            '
            'carsTableAdapter
            '
            Me.carsTableAdapter.ClearBeforeFill = True
            '
            'employeesBindingSource
            '
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.nwindDataSet
            '
            'employeesTableAdapter
            '
            Me.employeesTableAdapter.ClearBeforeFill = True
            '
            'radGroupBoxColumns
            '
            Me.radGroupBoxColumns.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxColumns.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxColumns.Controls.Add(Me.enableTimeSpanCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.enableSparklineCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radMultiComboBoxCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radDateTimeCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCommandCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCustom)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCheckBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxBrowse)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxCalculator)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxColor)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxHyperlink)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxMaskBox)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxLookUp)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxImage)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxText)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxDecimal)
            Me.radGroupBoxColumns.Controls.Add(Me.radCheckBoxRating)
            Me.radGroupBoxColumns.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.radGroupBoxColumns.HeaderText = "Columns"
            Me.radGroupBoxColumns.Location = New System.Drawing.Point(46, 6)
            Me.radGroupBoxColumns.Name = "radGroupBoxColumns"
            Me.radGroupBoxColumns.Size = New System.Drawing.Size(283, 444)
            Me.radGroupBoxColumns.TabIndex = 1
            Me.radGroupBoxColumns.Text = "Columns"
            '
            'enableTimeSpanCheckBox
            '
            Me.enableTimeSpanCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.enableTimeSpanCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.enableTimeSpanCheckBox.Location = New System.Drawing.Point(5, 387)
            Me.enableTimeSpanCheckBox.Name = "enableTimeSpanCheckBox"
            Me.enableTimeSpanCheckBox.Size = New System.Drawing.Size(69, 18)
            Me.enableTimeSpanCheckBox.TabIndex = 38
            Me.enableTimeSpanCheckBox.Text = "TimeSpan"
            Me.enableTimeSpanCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'enableSparklineCheckBox
            '
            Me.enableSparklineCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.enableSparklineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.enableSparklineCheckBox.Location = New System.Drawing.Point(5, 411)
            Me.enableSparklineCheckBox.Name = "enableSparklineCheckBox"
            Me.enableSparklineCheckBox.Size = New System.Drawing.Size(66, 18)
            Me.enableSparklineCheckBox.TabIndex = 39
            Me.enableSparklineCheckBox.Text = "Sparkline"
            Me.enableSparklineCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radMultiComboBoxCheckBox
            '
            Me.radMultiComboBoxCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radMultiComboBoxCheckBox.Location = New System.Drawing.Point(5, 363)
            Me.radMultiComboBoxCheckBox.Name = "radMultiComboBoxCheckBox"
            Me.radMultiComboBoxCheckBox.Size = New System.Drawing.Size(101, 18)
            Me.radMultiComboBoxCheckBox.TabIndex = 37
            Me.radMultiComboBoxCheckBox.Text = "MultiComboBox"
            '
            'radDateTimeCheckBox
            '
            Me.radDateTimeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radDateTimeCheckBox.Location = New System.Drawing.Point(5, 339)
            Me.radDateTimeCheckBox.Name = "radDateTimeCheckBox"
            Me.radDateTimeCheckBox.Size = New System.Drawing.Size(68, 18)
            Me.radDateTimeCheckBox.TabIndex = 36
            Me.radDateTimeCheckBox.Text = "DateTime"
            '
            'radCommandCheckBox
            '
            Me.radCommandCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCommandCheckBox.Location = New System.Drawing.Point(5, 315)
            Me.radCommandCheckBox.Name = "radCommandCheckBox"
            Me.radCommandCheckBox.Size = New System.Drawing.Size(72, 18)
            Me.radCommandCheckBox.TabIndex = 35
            Me.radCommandCheckBox.Text = "Command"
            '
            'radCheckBoxCustom
            '
            Me.radCheckBoxCustom.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxCustom.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxCustom.Location = New System.Drawing.Point(5, 291)
            Me.radCheckBoxCustom.Name = "radCheckBoxCustom"
            '
            '
            '
            Me.radCheckBoxCustom.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCustom.Size = New System.Drawing.Size(59, 18)
            Me.radCheckBoxCustom.TabIndex = 34
            Me.radCheckBoxCustom.Text = "Custom"
            Me.radCheckBoxCustom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxCheckBox
            '
            Me.radCheckBoxCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxCheckBox.Location = New System.Drawing.Point(5, 243)
            Me.radCheckBoxCheckBox.Name = "radCheckBoxCheckBox"
            '
            '
            '
            Me.radCheckBoxCheckBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCheckBox.Size = New System.Drawing.Size(69, 18)
            Me.radCheckBoxCheckBox.TabIndex = 33
            Me.radCheckBoxCheckBox.Text = "CheckBox"
            Me.radCheckBoxCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxBrowse
            '
            Me.radCheckBoxBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxBrowse.Location = New System.Drawing.Point(5, 219)
            Me.radCheckBoxBrowse.Name = "radCheckBoxBrowse"
            '
            '
            '
            Me.radCheckBoxBrowse.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxBrowse.Size = New System.Drawing.Size(56, 18)
            Me.radCheckBoxBrowse.TabIndex = 32
            Me.radCheckBoxBrowse.Text = "Browse"
            '
            'radCheckBoxCalculator
            '
            Me.radCheckBoxCalculator.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxCalculator.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxCalculator.Location = New System.Drawing.Point(5, 195)
            Me.radCheckBoxCalculator.Name = "radCheckBoxCalculator"
            '
            '
            '
            Me.radCheckBoxCalculator.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxCalculator.Size = New System.Drawing.Size(70, 18)
            Me.radCheckBoxCalculator.TabIndex = 31
            Me.radCheckBoxCalculator.Text = "Calculator"
            Me.radCheckBoxCalculator.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxColor
            '
            Me.radCheckBoxColor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxColor.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxColor.Location = New System.Drawing.Point(5, 171)
            Me.radCheckBoxColor.Name = "radCheckBoxColor"
            '
            '
            '
            Me.radCheckBoxColor.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxColor.Size = New System.Drawing.Size(47, 18)
            Me.radCheckBoxColor.TabIndex = 28
            Me.radCheckBoxColor.Text = "Color"
            Me.radCheckBoxColor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxHyperlink
            '
            Me.radCheckBoxHyperlink.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxHyperlink.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxHyperlink.Location = New System.Drawing.Point(5, 147)
            Me.radCheckBoxHyperlink.Name = "radCheckBoxHyperlink"
            '
            '
            '
            Me.radCheckBoxHyperlink.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxHyperlink.Size = New System.Drawing.Size(68, 18)
            Me.radCheckBoxHyperlink.TabIndex = 28
            Me.radCheckBoxHyperlink.Text = "Hyperlink"
            Me.radCheckBoxHyperlink.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxMaskBox
            '
            Me.radCheckBoxMaskBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxMaskBox.Location = New System.Drawing.Point(5, 123)
            Me.radCheckBoxMaskBox.Name = "radCheckBoxMaskBox"
            '
            '
            '
            Me.radCheckBoxMaskBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxMaskBox.Size = New System.Drawing.Size(65, 18)
            Me.radCheckBoxMaskBox.TabIndex = 28
            Me.radCheckBoxMaskBox.Text = "MaskBox"
            '
            'radCheckBoxLookUp
            '
            Me.radCheckBoxLookUp.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxLookUp.Location = New System.Drawing.Point(5, 99)
            Me.radCheckBoxLookUp.Name = "radCheckBoxLookUp"
            '
            '
            '
            Me.radCheckBoxLookUp.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxLookUp.Size = New System.Drawing.Size(59, 18)
            Me.radCheckBoxLookUp.TabIndex = 30
            Me.radCheckBoxLookUp.Text = "LookUp"
            '
            'radCheckBoxImage
            '
            Me.radCheckBoxImage.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxImage.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxImage.Location = New System.Drawing.Point(5, 75)
            Me.radCheckBoxImage.Name = "radCheckBoxImage"
            '
            '
            '
            Me.radCheckBoxImage.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxImage.Size = New System.Drawing.Size(51, 18)
            Me.radCheckBoxImage.TabIndex = 29
            Me.radCheckBoxImage.Text = "Image"
            Me.radCheckBoxImage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxText
            '
            Me.radCheckBoxText.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxText.Location = New System.Drawing.Point(5, 51)
            Me.radCheckBoxText.Name = "radCheckBoxText"
            '
            '
            '
            Me.radCheckBoxText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxText.Size = New System.Drawing.Size(41, 18)
            Me.radCheckBoxText.TabIndex = 28
            Me.radCheckBoxText.Text = "Text"
            '
            'radCheckBoxDecimal
            '
            Me.radCheckBoxDecimal.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxDecimal.Location = New System.Drawing.Point(5, 27)
            Me.radCheckBoxDecimal.Name = "radCheckBoxDecimal"
            '
            '
            '
            Me.radCheckBoxDecimal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxDecimal.Size = New System.Drawing.Size(60, 18)
            Me.radCheckBoxDecimal.TabIndex = 27
            Me.radCheckBoxDecimal.Text = "Decimal"
            '
            'radCheckBoxRating
            '
            Me.radCheckBoxRating.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxRating.Location = New System.Drawing.Point(5, 267)
            Me.radCheckBoxRating.Name = "radCheckBoxRating"
            '
            '
            '
            Me.radCheckBoxRating.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radCheckBoxRating.Size = New System.Drawing.Size(52, 18)
            Me.radCheckBoxRating.TabIndex = 28
            Me.radCheckBoxRating.Text = "Rating"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2046, 1156)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxColumns.ResumeLayout(False)
            Me.radGroupBoxColumns.PerformLayout()
            CType(Me.enableTimeSpanCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.enableSparklineCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMultiComboBoxCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimeCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCommandCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCustom, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxBrowse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCalculator, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxHyperlink, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxMaskBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxLookUp, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxDecimal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxRating, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
        Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter
        Private employeesBindingSource As System.Windows.Forms.BindingSource
        Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private radGroupBoxColumns As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxDecimal As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxCustom As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxBrowse As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxCalculator As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxColor As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxHyperlink As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxMaskBox As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxLookUp As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxImage As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxText As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxRating As Telerik.WinControls.UI.RadCheckBox
        Private radMultiComboBoxCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radDateTimeCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radCommandCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private enableTimeSpanCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private enableSparklineCheckBox As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
