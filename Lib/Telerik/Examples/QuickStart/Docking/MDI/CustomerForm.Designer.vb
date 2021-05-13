Namespace Telerik.Examples.WinControls.Docking.MDI
    Partial Public Class CustomerForm
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
            Dim customerIDLabel As Label
            Dim companyNameLabel As Label
            Dim contactNameLabel As Label
            Dim contactTitleLabel As Label
            Dim addressLabel As Label
            Dim cityLabel As Label
            Dim regionLabel As Label
            Dim postalCodeLabel As Label
            Dim countryLabel As Label
            Dim phoneLabel As Label
            Dim faxLabel As Label
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomerForm))
            Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn11 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewCheckBoxColumn1 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.customersBindingSource = New BindingSource(Me.components)
            Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
            Me.customersBindingNavigator = New BindingNavigator(Me.components)
            Me.bindingNavigatorCountItem = New ToolStripLabel()
            Me.bindingNavigatorMoveFirstItem = New ToolStripButton()
            Me.bindingNavigatorMovePreviousItem = New ToolStripButton()
            Me.bindingNavigatorSeparator = New ToolStripSeparator()
            Me.bindingNavigatorPositionItem = New ToolStripTextBox()
            Me.bindingNavigatorSeparator1 = New ToolStripSeparator()
            Me.bindingNavigatorMoveNextItem = New ToolStripButton()
            Me.bindingNavigatorMoveLastItem = New ToolStripButton()
            Me.bindingNavigatorSeparator2 = New ToolStripSeparator()
            Me.customerIDTextBox = New TextBox()
            Me.companyNameTextBox = New TextBox()
            Me.contactNameTextBox = New TextBox()
            Me.contactTitleTextBox = New TextBox()
            Me.addressTextBox = New TextBox()
            Me.cityTextBox = New TextBox()
            Me.regionTextBox = New TextBox()
            Me.postalCodeTextBox = New TextBox()
            Me.countryTextBox = New TextBox()
            Me.phoneTextBox = New TextBox()
            Me.faxTextBox = New TextBox()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            customerIDLabel = New Label()
            companyNameLabel = New Label()
            contactNameLabel = New Label()
            contactTitleLabel = New Label()
            addressLabel = New Label()
            cityLabel = New Label()
            regionLabel = New Label()
            postalCodeLabel = New Label()
            countryLabel = New Label()
            phoneLabel = New Label()
            faxLabel = New Label()
            CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.customersBindingNavigator.SuspendLayout()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customerIDLabel
            ' 
            customerIDLabel.AutoSize = True
            customerIDLabel.ForeColor = System.Drawing.Color.Black
            customerIDLabel.Location = New Point(26, 330)
            customerIDLabel.Name = "customerIDLabel"
            customerIDLabel.Size = New Size(68, 13)
            customerIDLabel.TabIndex = 2
            customerIDLabel.Text = "Customer ID:"
            ' 
            ' companyNameLabel
            ' 
            companyNameLabel.AutoSize = True
            companyNameLabel.ForeColor = System.Drawing.Color.Black
            companyNameLabel.Location = New Point(9, 356)
            companyNameLabel.Name = "companyNameLabel"
            companyNameLabel.Size = New Size(85, 13)
            companyNameLabel.TabIndex = 4
            companyNameLabel.Text = "Company Name:"
            ' 
            ' contactNameLabel
            ' 
            contactNameLabel.AutoSize = True
            contactNameLabel.ForeColor = System.Drawing.Color.Black
            contactNameLabel.Location = New Point(16, 382)
            contactNameLabel.Name = "contactNameLabel"
            contactNameLabel.Size = New Size(78, 13)
            contactNameLabel.TabIndex = 6
            contactNameLabel.Text = "Contact Name:"
            ' 
            ' contactTitleLabel
            ' 
            contactTitleLabel.AutoSize = True
            contactTitleLabel.ForeColor = System.Drawing.Color.Black
            contactTitleLabel.Location = New Point(24, 408)
            contactTitleLabel.Name = "contactTitleLabel"
            contactTitleLabel.Size = New Size(70, 13)
            contactTitleLabel.TabIndex = 8
            contactTitleLabel.Text = "Contact Title:"
            ' 
            ' addressLabel
            ' 
            addressLabel.AutoSize = True
            addressLabel.ForeColor = System.Drawing.Color.Black
            addressLabel.Location = New Point(296, 330)
            addressLabel.Name = "addressLabel"
            addressLabel.Size = New Size(48, 13)
            addressLabel.TabIndex = 10
            addressLabel.Text = "Address:"
            ' 
            ' cityLabel
            ' 
            cityLabel.AutoSize = True
            cityLabel.ForeColor = System.Drawing.Color.Black
            cityLabel.Location = New Point(67, 434)
            cityLabel.Name = "cityLabel"
            cityLabel.Size = New Size(27, 13)
            cityLabel.TabIndex = 12
            cityLabel.Text = "City:"
            ' 
            ' regionLabel
            ' 
            regionLabel.AutoSize = True
            regionLabel.ForeColor = System.Drawing.Color.Black
            regionLabel.Location = New Point(300, 408)
            regionLabel.Name = "regionLabel"
            regionLabel.Size = New Size(44, 13)
            regionLabel.TabIndex = 14
            regionLabel.Text = "Region:"
            ' 
            ' postalCodeLabel
            ' 
            postalCodeLabel.AutoSize = True
            postalCodeLabel.ForeColor = System.Drawing.Color.Black
            postalCodeLabel.Location = New Point(27, 460)
            postalCodeLabel.Name = "postalCodeLabel"
            postalCodeLabel.Size = New Size(67, 13)
            postalCodeLabel.TabIndex = 16
            postalCodeLabel.Text = "Postal Code:"
            ' 
            ' countryLabel
            ' 
            countryLabel.AutoSize = True
            countryLabel.ForeColor = System.Drawing.Color.Black
            countryLabel.Location = New Point(298, 434)
            countryLabel.Name = "countryLabel"
            countryLabel.Size = New Size(46, 13)
            countryLabel.TabIndex = 18
            countryLabel.Text = "Country:"
            ' 
            ' phoneLabel
            ' 
            phoneLabel.AutoSize = True
            phoneLabel.ForeColor = System.Drawing.Color.Black
            phoneLabel.Location = New Point(303, 356)
            phoneLabel.Name = "phoneLabel"
            phoneLabel.Size = New Size(41, 13)
            phoneLabel.TabIndex = 20
            phoneLabel.Text = "Phone:"
            ' 
            ' faxLabel
            ' 
            faxLabel.AutoSize = True
            faxLabel.ForeColor = System.Drawing.Color.Black
            faxLabel.Location = New Point(317, 382)
            faxLabel.Name = "faxLabel"
            faxLabel.Size = New Size(27, 13)
            faxLabel.TabIndex = 22
            faxLabel.Text = "Fax:"
            ' 
            ' nwindRadGridView
            ' 
            Me.nwindRadGridView.DataSetName = "NwindRadGridView"
            Me.nwindRadGridView.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            ' 
            ' customersBindingSource
            ' 
            Me.customersBindingSource.DataMember = "Customers"
            Me.customersBindingSource.DataSource = Me.nwindRadGridView
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' customersBindingNavigator
            ' 
            Me.customersBindingNavigator.AddNewItem = Nothing
            Me.customersBindingNavigator.BindingSource = Me.customersBindingSource
            Me.customersBindingNavigator.CountItem = Me.bindingNavigatorCountItem
            Me.customersBindingNavigator.DeleteItem = Nothing
            Me.customersBindingNavigator.ForeColor = System.Drawing.Color.Black
            Me.customersBindingNavigator.Items.AddRange(New ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
            Me.customersBindingNavigator.Location = New Point(0, 0)
            Me.customersBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
            Me.customersBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
            Me.customersBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
            Me.customersBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
            Me.customersBindingNavigator.Name = "customersBindingNavigator"
            Me.customersBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
            Me.customersBindingNavigator.Size = New Size(601, 25)
            Me.customersBindingNavigator.TabIndex = 0
            Me.customersBindingNavigator.Text = "bindingNavigator1"
            ' 
            ' bindingNavigatorCountItem
            ' 
            Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
            Me.bindingNavigatorCountItem.Size = New Size(35, 22)
            Me.bindingNavigatorCountItem.Text = "of {0}"
            Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
            ' 
            ' bindingNavigatorMoveFirstItem
            ' 
            Me.bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveFirstItem.Image = (CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), Image))
            Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
            Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveFirstItem.Size = New Size(23, 22)
            Me.bindingNavigatorMoveFirstItem.Text = "Move first"
            ' 
            ' bindingNavigatorMovePreviousItem
            ' 
            Me.bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMovePreviousItem.Image = (CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), Image))
            Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
            Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMovePreviousItem.Size = New Size(23, 22)
            Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
            ' 
            ' bindingNavigatorSeparator
            ' 
            Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
            Me.bindingNavigatorSeparator.Size = New Size(6, 25)
            ' 
            ' bindingNavigatorPositionItem
            ' 
            Me.bindingNavigatorPositionItem.AccessibleName = "Position"
            Me.bindingNavigatorPositionItem.AutoSize = False
            Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
            Me.bindingNavigatorPositionItem.Size = New Size(50, 23)
            Me.bindingNavigatorPositionItem.Text = "0"
            Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
            ' 
            ' bindingNavigatorSeparator1
            ' 
            Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
            Me.bindingNavigatorSeparator1.Size = New Size(6, 25)
            ' 
            ' bindingNavigatorMoveNextItem
            ' 
            Me.bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveNextItem.Image = (CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), Image))
            Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
            Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveNextItem.Size = New Size(23, 22)
            Me.bindingNavigatorMoveNextItem.Text = "Move next"
            ' 
            ' bindingNavigatorMoveLastItem
            ' 
            Me.bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveLastItem.Image = (CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), Image))
            Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
            Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveLastItem.Size = New Size(23, 22)
            Me.bindingNavigatorMoveLastItem.Text = "Move last"
            ' 
            ' bindingNavigatorSeparator2
            ' 
            Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
            Me.bindingNavigatorSeparator2.Size = New Size(6, 25)
            ' 
            ' customerIDTextBox
            ' 
            Me.customerIDTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "CustomerID", True))
            Me.customerIDTextBox.Location = New Point(100, 327)
            Me.customerIDTextBox.Name = "customerIDTextBox"
            Me.customerIDTextBox.Size = New Size(157, 20)
            Me.customerIDTextBox.TabIndex = 3
            ' 
            ' companyNameTextBox
            ' 
            Me.companyNameTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "CompanyName", True))
            Me.companyNameTextBox.Location = New Point(100, 353)
            Me.companyNameTextBox.Name = "companyNameTextBox"
            Me.companyNameTextBox.Size = New Size(157, 20)
            Me.companyNameTextBox.TabIndex = 5
            ' 
            ' contactNameTextBox
            ' 
            Me.contactNameTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "ContactName", True))
            Me.contactNameTextBox.Location = New Point(100, 379)
            Me.contactNameTextBox.Name = "contactNameTextBox"
            Me.contactNameTextBox.Size = New Size(157, 20)
            Me.contactNameTextBox.TabIndex = 7
            ' 
            ' contactTitleTextBox
            ' 
            Me.contactTitleTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "ContactTitle", True))
            Me.contactTitleTextBox.Location = New Point(100, 405)
            Me.contactTitleTextBox.Name = "contactTitleTextBox"
            Me.contactTitleTextBox.Size = New Size(157, 20)
            Me.contactTitleTextBox.TabIndex = 9
            ' 
            ' addressTextBox
            ' 
            Me.addressTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "Address", True))
            Me.addressTextBox.Location = New Point(350, 327)
            Me.addressTextBox.Name = "addressTextBox"
            Me.addressTextBox.Size = New Size(157, 20)
            Me.addressTextBox.TabIndex = 11
            ' 
            ' cityTextBox
            ' 
            Me.cityTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "City", True))
            Me.cityTextBox.Location = New Point(100, 431)
            Me.cityTextBox.Name = "cityTextBox"
            Me.cityTextBox.Size = New Size(157, 20)
            Me.cityTextBox.TabIndex = 13
            ' 
            ' regionTextBox
            ' 
            Me.regionTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "Region", True))
            Me.regionTextBox.Location = New Point(350, 405)
            Me.regionTextBox.Name = "regionTextBox"
            Me.regionTextBox.Size = New Size(157, 20)
            Me.regionTextBox.TabIndex = 15
            ' 
            ' postalCodeTextBox
            ' 
            Me.postalCodeTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "PostalCode", True))
            Me.postalCodeTextBox.Location = New Point(100, 457)
            Me.postalCodeTextBox.Name = "postalCodeTextBox"
            Me.postalCodeTextBox.Size = New Size(157, 20)
            Me.postalCodeTextBox.TabIndex = 17
            ' 
            ' countryTextBox
            ' 
            Me.countryTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "Country", True))
            Me.countryTextBox.Location = New Point(350, 431)
            Me.countryTextBox.Name = "countryTextBox"
            Me.countryTextBox.Size = New Size(157, 20)
            Me.countryTextBox.TabIndex = 19
            ' 
            ' phoneTextBox
            ' 
            Me.phoneTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "Phone", True))
            Me.phoneTextBox.Location = New Point(350, 353)
            Me.phoneTextBox.Name = "phoneTextBox"
            Me.phoneTextBox.Size = New Size(157, 20)
            Me.phoneTextBox.TabIndex = 21
            ' 
            ' faxTextBox
            ' 
            Me.faxTextBox.DataBindings.Add(New Binding("Text", Me.customersBindingSource, "Fax", True))
            Me.faxTextBox.Location = New Point(350, 379)
            Me.faxTextBox.Name = "faxTextBox"
            Me.faxTextBox.Size = New Size(157, 20)
            Me.faxTextBox.TabIndex = 23
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = DockStyle.Top
            Me.radGridView1.Location = New Point(0, 25)
            ' 
            ' 
            ' 
            gridViewTextBoxColumn1.FieldName = "CustomerID"
            gridViewTextBoxColumn1.HeaderText = "CustomerID"
            gridViewTextBoxColumn1.Name = "CustomerID"
            gridViewTextBoxColumn2.FieldName = "CompanyName"
            gridViewTextBoxColumn2.HeaderText = "CompanyName"
            gridViewTextBoxColumn2.Name = "CompanyName"
            gridViewTextBoxColumn3.FieldName = "ContactName"
            gridViewTextBoxColumn3.HeaderText = "ContactName"
            gridViewTextBoxColumn3.Name = "ContactName"
            gridViewTextBoxColumn4.FieldName = "ContactTitle"
            gridViewTextBoxColumn4.HeaderText = "ContactTitle"
            gridViewTextBoxColumn4.Name = "ContactTitle"
            gridViewTextBoxColumn5.FieldName = "Address"
            gridViewTextBoxColumn5.HeaderText = "Address"
            gridViewTextBoxColumn5.Name = "Address"
            gridViewTextBoxColumn6.FieldName = "City"
            gridViewTextBoxColumn6.HeaderText = "City"
            gridViewTextBoxColumn6.Name = "City"
            gridViewTextBoxColumn7.FieldName = "Region"
            gridViewTextBoxColumn7.HeaderText = "Region"
            gridViewTextBoxColumn7.Name = "Region"
            gridViewTextBoxColumn8.FieldName = "PostalCode"
            gridViewTextBoxColumn8.HeaderText = "PostalCode"
            gridViewTextBoxColumn8.Name = "PostalCode"
            gridViewTextBoxColumn9.FieldName = "Country"
            gridViewTextBoxColumn9.HeaderText = "Country"
            gridViewTextBoxColumn9.Name = "Country"
            gridViewTextBoxColumn10.FieldName = "Phone"
            gridViewTextBoxColumn10.HeaderText = "Phone"
            gridViewTextBoxColumn10.Name = "Phone"
            gridViewTextBoxColumn11.FieldName = "Fax"
            gridViewTextBoxColumn11.HeaderText = "Fax"
            gridViewTextBoxColumn11.Name = "Fax"
            gridViewCheckBoxColumn1.DataType = GetType(Boolean)
            gridViewCheckBoxColumn1.FieldName = "Bool"
            gridViewCheckBoxColumn1.HeaderText = "Bool"
            gridViewCheckBoxColumn1.Name = "Bool"
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn6)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn7)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn11)
            Me.radGridView1.MasterTemplate.Columns.Add(gridViewCheckBoxColumn1)
            Me.radGridView1.MasterTemplate.DataSource = Me.customersBindingSource

            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New Size(601, 280)
            Me.radGridView1.TabIndex = 24
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' CustomerForm
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(601, 510)
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(faxLabel)
            Me.Controls.Add(Me.faxTextBox)
            Me.Controls.Add(phoneLabel)
            Me.Controls.Add(Me.phoneTextBox)
            Me.Controls.Add(countryLabel)
            Me.Controls.Add(Me.countryTextBox)
            Me.Controls.Add(postalCodeLabel)
            Me.Controls.Add(Me.postalCodeTextBox)
            Me.Controls.Add(regionLabel)
            Me.Controls.Add(Me.regionTextBox)
            Me.Controls.Add(cityLabel)
            Me.Controls.Add(Me.cityTextBox)
            Me.Controls.Add(addressLabel)
            Me.Controls.Add(Me.addressTextBox)
            Me.Controls.Add(contactTitleLabel)
            Me.Controls.Add(Me.contactTitleTextBox)
            Me.Controls.Add(contactNameLabel)
            Me.Controls.Add(Me.contactNameTextBox)
            Me.Controls.Add(companyNameLabel)
            Me.Controls.Add(Me.companyNameTextBox)
            Me.Controls.Add(customerIDLabel)
            Me.Controls.Add(Me.customerIDTextBox)
            Me.Controls.Add(Me.customersBindingNavigator)
            Me.Name = "CustomerForm"
            Me.Text = "CustomerForm"
            CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
            Me.customersBindingNavigator.ResumeLayout(False)
            Me.customersBindingNavigator.PerformLayout()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
        Private customersBindingSource As BindingSource
        Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
        Private customersBindingNavigator As BindingNavigator
        Private bindingNavigatorCountItem As ToolStripLabel
        Private bindingNavigatorMoveFirstItem As ToolStripButton
        Private bindingNavigatorMovePreviousItem As ToolStripButton
        Private bindingNavigatorSeparator As ToolStripSeparator
        Private bindingNavigatorPositionItem As ToolStripTextBox
        Private bindingNavigatorSeparator1 As ToolStripSeparator
        Private bindingNavigatorMoveNextItem As ToolStripButton
        Private bindingNavigatorMoveLastItem As ToolStripButton
        Private bindingNavigatorSeparator2 As ToolStripSeparator
        Private customerIDTextBox As TextBox
        Private companyNameTextBox As TextBox
        Private contactNameTextBox As TextBox
        Private contactTitleTextBox As TextBox
        Private addressTextBox As TextBox
        Private cityTextBox As TextBox
        Private regionTextBox As TextBox
        Private postalCodeTextBox As TextBox
        Private countryTextBox As TextBox
        Private phoneTextBox As TextBox
        Private faxTextBox As TextBox
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
    End Class
End Namespace