Namespace Telerik.Examples.WinControls.LayoutControl.FirstLook
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.radLayoutControl1 = New Telerik.WinControls.UI.RadLayoutControl()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBox2 = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBox4 = New Telerik.WinControls.UI.RadTextBox()
            Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.employeeOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.radTextBox3 = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBox5 = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBox6 = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBox7 = New Telerik.WinControls.UI.RadTextBox()
            Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.layoutControlItem2 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlTabbedGroup1 = New Telerik.WinControls.UI.LayoutControlTabbedGroup()
            Me.layoutControlGroupItem1 = New Telerik.WinControls.UI.LayoutControlGroupItem()
            Me.layoutControlItem5 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlGroupItem2 = New Telerik.WinControls.UI.LayoutControlGroupItem()
            Me.layoutControlItem11 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem12 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem13 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem3 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem4 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem10 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem18 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem1 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlSeparatorItem1 = New Telerik.WinControls.UI.LayoutControlSeparatorItem()
            Me.layoutControlGroupItem3 = New Telerik.WinControls.UI.LayoutControlGroupItem()
            Me.layoutControlItem6 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlSplitterItem1 = New Telerik.WinControls.UI.LayoutControlSplitterItem()
            Me.layoutControlSplitterItem2 = New Telerik.WinControls.UI.LayoutControlSplitterItem()
            Me.employeeOrdersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter()
            CType(Me.radLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radLayoutControl1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radLayoutControl1
            '
            Me.radLayoutControl1.Controls.Add(Me.pictureBox1)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox1)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox2)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox4)
            Me.radLayoutControl1.Controls.Add(Me.radDateTimePicker1)
            Me.radLayoutControl1.Controls.Add(Me.radGridView1)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox3)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox5)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox6)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox7)
            Me.radLayoutControl1.Controls.Add(Me.radDateTimePicker2)
            Me.radLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLayoutControl1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlItem2, Me.layoutControlTabbedGroup1, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem10, Me.layoutControlItem18, Me.layoutControlItem1, Me.layoutControlLabelItem1, Me.layoutControlSeparatorItem1, Me.layoutControlGroupItem3, Me.layoutControlSplitterItem1, Me.layoutControlSplitterItem2})
            Me.radLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.radLayoutControl1.Name = "radLayoutControl1"
            Me.radLayoutControl1.Size = New System.Drawing.Size(900, 800)
            Me.radLayoutControl1.TabIndex = 0
            '
            'pictureBox1
            '
            Me.pictureBox1.BackgroundImage = Global.My.Resources.Janet
            Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pictureBox1.Location = New System.Drawing.Point(693, 3)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(204, 480)
            Me.pictureBox1.TabIndex = 3
            Me.pictureBox1.TabStop = False
            '
            'radTextBox1
            '
            Me.radTextBox1.Location = New System.Drawing.Point(3, 38)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(338, 20)
            Me.radTextBox1.TabIndex = 4
            Me.radTextBox1.Text = "Janet"
            '
            'radTextBox2
            '
            Me.radTextBox2.Location = New System.Drawing.Point(3, 172)
            Me.radTextBox2.Name = "radTextBox2"
            Me.radTextBox2.Size = New System.Drawing.Size(338, 20)
            Me.radTextBox2.TabIndex = 5
            Me.radTextBox2.Text = "Sales Representative"
            '
            'radTextBox4
            '
            Me.radTextBox4.AutoSize = False
            Me.radTextBox4.Location = New System.Drawing.Point(7, 233)
            Me.radTextBox4.Multiline = True
            Me.radTextBox4.Name = "radTextBox4"
            Me.radTextBox4.Size = New System.Drawing.Size(672, 246)
            Me.radTextBox4.TabIndex = 7
            Me.radTextBox4.Text = resources.GetString("radTextBox4.Text")
            '
            'radDateTimePicker1
            '
            Me.radDateTimePicker1.Location = New System.Drawing.Point(347, 172)
            Me.radDateTimePicker1.Name = "radDateTimePicker1"
            Me.radDateTimePicker1.Size = New System.Drawing.Size(336, 20)
            Me.radDateTimePicker1.TabIndex = 13
            Me.radDateTimePicker1.TabStop = False
            Me.radDateTimePicker1.Text = "Wednesday, 1 April, 1992"
            Me.radDateTimePicker1.Value = New Date(1992, 4, 1, 0, 0, 0, 0)
            '
            'radGridView1
            '
            Me.radGridView1.Location = New System.Drawing.Point(13, 613)
            '
            '
            '
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            GridViewTextBoxColumn1.FieldName = "LastName"
            GridViewTextBoxColumn1.HeaderText = "LastName"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "LastName"
            GridViewTextBoxColumn1.Width = 131
            GridViewTextBoxColumn2.FieldName = "FirstName"
            GridViewTextBoxColumn2.HeaderText = "FirstName"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "FirstName"
            GridViewTextBoxColumn2.Width = 131
            GridViewTextBoxColumn3.FieldName = "Title"
            GridViewTextBoxColumn3.HeaderText = "Title"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Title"
            GridViewTextBoxColumn3.Width = 131
            GridViewTextBoxColumn4.FieldName = "City"
            GridViewTextBoxColumn4.HeaderText = "City"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "City"
            GridViewTextBoxColumn4.Width = 131
            GridViewTextBoxColumn5.FieldName = "Country"
            GridViewTextBoxColumn5.HeaderText = "Country"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "Country"
            GridViewTextBoxColumn5.Width = 131
            GridViewTextBoxColumn6.FieldName = "ShipName"
            GridViewTextBoxColumn6.HeaderText = "ShipName"
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.Name = "ShipName"
            GridViewTextBoxColumn6.Width = 131
            GridViewDecimalColumn1.FieldName = "UnitPrice"
            GridViewDecimalColumn1.HeaderText = "UnitPrice"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.Name = "UnitPrice"
            GridViewDecimalColumn1.Width = 131
            GridViewDecimalColumn2.DataType = GetType(Short)
            GridViewDecimalColumn2.FieldName = "Quantity"
            GridViewDecimalColumn2.HeaderText = "Quantity"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "Quantity"
            GridViewDecimalColumn2.Width = 125
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDecimalColumn1, GridViewDecimalColumn2})
            Me.radGridView1.MasterTemplate.DataSource = Me.employeeOrdersBindingSource
            Me.radGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(1056, 282)
            Me.radGridView1.TabIndex = 14
            '
            'employeeOrdersBindingSource
            '
            Me.employeeOrdersBindingSource.DataMember = "EmployeeOrders"
            Me.employeeOrdersBindingSource.DataSource = Me.northwindDataSet
            '
            'northwindDataSet
            '
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'radTextBox3
            '
            Me.radTextBox3.AutoSize = False
            Me.radTextBox3.Location = New System.Drawing.Point(13, 628)
            Me.radTextBox3.Multiline = True
            Me.radTextBox3.Name = "radTextBox3"
            Me.radTextBox3.Size = New System.Drawing.Size(873, 157)
            Me.radTextBox3.TabIndex = 15
            Me.radTextBox3.Text = "507 - 20th Ave. E."
            '
            'radTextBox5
            '
            Me.radTextBox5.Location = New System.Drawing.Point(692, 574)
            Me.radTextBox5.Name = "radTextBox5"
            Me.radTextBox5.Size = New System.Drawing.Size(194, 20)
            Me.radTextBox5.TabIndex = 16
            Me.radTextBox5.Text = "Seattle"
            '
            'radTextBox6
            '
            Me.radTextBox6.Location = New System.Drawing.Point(13, 574)
            Me.radTextBox6.Name = "radTextBox6"
            Me.radTextBox6.Size = New System.Drawing.Size(673, 20)
            Me.radTextBox6.TabIndex = 17
            Me.radTextBox6.Text = "USA"
            '
            'radTextBox7
            '
            Me.radTextBox7.Location = New System.Drawing.Point(347, 38)
            Me.radTextBox7.Name = "radTextBox7"
            Me.radTextBox7.Size = New System.Drawing.Size(336, 20)
            Me.radTextBox7.TabIndex = 23
            Me.radTextBox7.Text = "Leverling"
            '
            'radDateTimePicker2
            '
            Me.radDateTimePicker2.Location = New System.Drawing.Point(3, 105)
            Me.radDateTimePicker2.Name = "radDateTimePicker2"
            Me.radDateTimePicker2.Size = New System.Drawing.Size(338, 20)
            Me.radDateTimePicker2.TabIndex = 25
            Me.radDateTimePicker2.TabStop = False
            Me.radDateTimePicker2.Text = "Saturday, 17 August, 1963"
            Me.radDateTimePicker2.Value = New Date(1963, 8, 17, 0, 0, 0, 0)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.AssociatedControl = Me.pictureBox1
            Me.layoutControlItem2.Bounds = New System.Drawing.Rectangle(690, 0, 210, 486)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            '
            'layoutControlTabbedGroup1
            '
            Me.layoutControlTabbedGroup1.Bounds = New System.Drawing.Rectangle(0, 490, 900, 310)
            Me.layoutControlTabbedGroup1.ItemGroups.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlGroupItem1, Me.layoutControlGroupItem2})
            Me.layoutControlTabbedGroup1.Name = "layoutControlTabbedGroup1"
            Me.layoutControlTabbedGroup1.SelectedGroup = Me.layoutControlGroupItem2
            '
            'layoutControlGroupItem1
            '
            Me.layoutControlGroupItem1.AccessibleDescription = "layoutControlGroupItem1"
            Me.layoutControlGroupItem1.AccessibleName = "layoutControlGroupItem1"
            Me.layoutControlGroupItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlItem5})
            Me.layoutControlGroupItem1.Name = "layoutControlGroupItem1"
            Me.layoutControlGroupItem1.Text = "Sales"
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.AssociatedControl = Me.radGridView1
            Me.layoutControlItem5.Bounds = New System.Drawing.Rectangle(0, 0, 1062, 288)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            '
            'layoutControlGroupItem2
            '
            Me.layoutControlGroupItem2.AccessibleDescription = "layoutControlGroupItem2"
            Me.layoutControlGroupItem2.AccessibleName = "layoutControlGroupItem2"
            Me.layoutControlGroupItem2.Bounds = New System.Drawing.Rectangle(0, 0, 879, 262)
            Me.layoutControlGroupItem2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlItem11, Me.layoutControlItem12, Me.layoutControlItem13})
            Me.layoutControlGroupItem2.Name = "layoutControlGroupItem2"
            Me.layoutControlGroupItem2.Text = "Address"
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.AssociatedControl = Me.radTextBox3
            Me.layoutControlItem11.Bounds = New System.Drawing.Rectangle(0, 78, 879, 183)
            Me.layoutControlItem11.DrawText = True
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Text = "Street Address"
            Me.layoutControlItem11.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem11.TextFixedSize = 20
            Me.layoutControlItem11.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem11.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.AssociatedControl = Me.radTextBox5
            Me.layoutControlItem12.Bounds = New System.Drawing.Rectangle(679, 0, 200, 78)
            Me.layoutControlItem12.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem12.DrawText = True
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Text = "City"
            Me.layoutControlItem12.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem12.TextFixedSize = 22
            Me.layoutControlItem12.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            '
            'layoutControlItem13
            '
            Me.layoutControlItem13.AssociatedControl = Me.radTextBox6
            Me.layoutControlItem13.Bounds = New System.Drawing.Rectangle(0, 0, 679, 78)
            Me.layoutControlItem13.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem13.DrawText = True
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Text = "Country"
            Me.layoutControlItem13.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem13.TextFixedSize = 22
            Me.layoutControlItem13.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.AssociatedControl = Me.radTextBox1
            Me.layoutControlItem3.Bounds = New System.Drawing.Rectangle(0, 0, 344, 76)
            Me.layoutControlItem3.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem3.DrawText = True
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Text = "First Name"
            Me.layoutControlItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem3.TextFixedSize = 20
            Me.layoutControlItem3.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem3.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.AssociatedControl = Me.radTextBox2
            Me.layoutControlItem4.Bounds = New System.Drawing.Rectangle(0, 139, 344, 67)
            Me.layoutControlItem4.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem4.DrawText = True
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Text = "Job Title"
            Me.layoutControlItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem4.TextFixedSize = 20
            Me.layoutControlItem4.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem4.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.AssociatedControl = Me.radDateTimePicker1
            Me.layoutControlItem10.Bounds = New System.Drawing.Rectangle(344, 139, 342, 67)
            Me.layoutControlItem10.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem10.DrawText = True
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Text = "Hire Date"
            Me.layoutControlItem10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem10.TextFixedSize = 20
            Me.layoutControlItem10.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem10.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.AssociatedControl = Me.radTextBox7
            Me.layoutControlItem18.Bounds = New System.Drawing.Rectangle(344, 0, 342, 76)
            Me.layoutControlItem18.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem18.DrawText = True
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Text = "Last Name"
            Me.layoutControlItem18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem18.TextFixedSize = 20
            Me.layoutControlItem18.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem18.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.AssociatedControl = Me.radDateTimePicker2
            Me.layoutControlItem1.Bounds = New System.Drawing.Rectangle(0, 76, 344, 59)
            Me.layoutControlItem1.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
            Me.layoutControlItem1.DrawText = True
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Text = "Birth date"
            Me.layoutControlItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem1.TextFixedSize = 20
            Me.layoutControlItem1.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem1.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlLabelItem1
            '
            Me.layoutControlLabelItem1.Bounds = New System.Drawing.Rectangle(344, 76, 342, 59)
            Me.layoutControlLabelItem1.DrawText = False
            Me.layoutControlLabelItem1.Name = "layoutControlLabelItem1"
            '
            'layoutControlSeparatorItem1
            '
            Me.layoutControlSeparatorItem1.Bounds = New System.Drawing.Rectangle(0, 135, 686, 4)
            Me.layoutControlSeparatorItem1.Name = "layoutControlSeparatorItem1"
            '
            'layoutControlGroupItem3
            '
            Me.layoutControlGroupItem3.Bounds = New System.Drawing.Rectangle(0, 206, 686, 280)
            Me.layoutControlGroupItem3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlItem6})
            Me.layoutControlGroupItem3.Name = "layoutControlGroupItem3"
            Me.layoutControlGroupItem3.Text = "Description"
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.AssociatedControl = Me.radTextBox4
            Me.layoutControlItem6.Bounds = New System.Drawing.Rectangle(0, 0, 678, 252)
            Me.layoutControlItem6.DrawText = False
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(46, 60)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Text = "Details"
            Me.layoutControlItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem6.TextFixedSize = 22
            Me.layoutControlItem6.TextOrientation = System.Windows.Forms.Orientation.Horizontal
            Me.layoutControlItem6.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem6.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            '
            'layoutControlSplitterItem1
            '
            Me.layoutControlSplitterItem1.Bounds = New System.Drawing.Rectangle(0, 486, 900, 4)
            Me.layoutControlSplitterItem1.Name = "layoutControlSplitterItem1"
            '
            'layoutControlSplitterItem2
            '
            Me.layoutControlSplitterItem2.Bounds = New System.Drawing.Rectangle(686, 0, 4, 486)
            Me.layoutControlSplitterItem2.Name = "layoutControlSplitterItem2"
            '
            'employeeOrdersTableAdapter
            '
            Me.employeeOrdersTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(900, 800)
            Me.Controls.Add(Me.radLayoutControl1)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Layout Control First Look"
            CType(Me.radLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radLayoutControl1.ResumeLayout(False)
            Me.radLayoutControl1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radLayoutControl1 As Telerik.WinControls.UI.RadLayoutControl
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private layoutControlItem2 As Telerik.WinControls.UI.LayoutControlItem
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private radTextBox2 As Telerik.WinControls.UI.RadTextBox
        Private radTextBox4 As Telerik.WinControls.UI.RadTextBox
        Private layoutControlTabbedGroup1 As Telerik.WinControls.UI.LayoutControlTabbedGroup
        Private layoutControlGroupItem1 As Telerik.WinControls.UI.LayoutControlGroupItem
        Private layoutControlGroupItem2 As Telerik.WinControls.UI.LayoutControlGroupItem
        Private layoutControlItem3 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem4 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem6 As Telerik.WinControls.UI.LayoutControlItem
        Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radTextBox3 As Telerik.WinControls.UI.RadTextBox
        Private layoutControlItem5 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem11 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem10 As Telerik.WinControls.UI.LayoutControlItem
        Private radTextBox5 As Telerik.WinControls.UI.RadTextBox
        Private radTextBox6 As Telerik.WinControls.UI.RadTextBox
        Private layoutControlItem12 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem13 As Telerik.WinControls.UI.LayoutControlItem
        Private radTextBox7 As Telerik.WinControls.UI.RadTextBox
        Private layoutControlItem18 As Telerik.WinControls.UI.LayoutControlItem
        Private radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
        Private layoutControlItem1 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlSeparatorItem1 As Telerik.WinControls.UI.LayoutControlSeparatorItem
        Private layoutControlGroupItem3 As Telerik.WinControls.UI.LayoutControlGroupItem
        Private layoutControlSplitterItem1 As Telerik.WinControls.UI.LayoutControlSplitterItem
        Private layoutControlSplitterItem2 As Telerik.WinControls.UI.LayoutControlSplitterItem
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private employeeOrdersBindingSource As System.Windows.Forms.BindingSource
        Private employeeOrdersTableAdapter As DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter
    End Class
End Namespace
