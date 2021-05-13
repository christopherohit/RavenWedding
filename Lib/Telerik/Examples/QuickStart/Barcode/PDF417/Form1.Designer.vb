
Namespace Telerik.Examples.WinControls.Barcode.PDF417

    Partial Class Form1

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
            Me.radTextBoxOrderNumber = New Telerik.WinControls.UI.RadTextBox()
            Me.radButtonGenerate = New Telerik.WinControls.UI.RadButton()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radBarcode1 = New Telerik.WinControls.UI.RadBarcode()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radDateTimePickerDate = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radTextBoxPhoneNumber = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxFullName = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radTextBoxAddress = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBoxCity = New Telerik.WinControls.UI.RadTextBox()
            Me.radDropDownListCountry = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox4.SuspendLayout()
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            CType(Me.radDateTimePickerDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxPhoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxFullName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.radTextBoxAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListCountry, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radButtonExport)
            Me.radGroupBox1.Controls.Add(Me.radTextBoxOrderNumber)
            Me.radGroupBox1.Controls.Add(Me.radButtonGenerate)
            Me.radGroupBox1.Controls.Add(Me.radLabel7)
            Me.radGroupBox1.Controls.Add(Me.radGroupBox4)
            Me.radGroupBox1.Controls.Add(Me.radGroupBox3)
            Me.radGroupBox1.Controls.Add(Me.radGroupBox2)
            Me.radGroupBox1.HeaderText = "PDF 417"
            Me.radGroupBox1.Location = New System.Drawing.Point(83, 112)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(674, 344)
            Me.radGroupBox1.TabIndex = 0
            Me.radGroupBox1.Text = "PDF 417"
            '
            'radButtonExport
            '
            Me.radButtonExport.Location = New System.Drawing.Point(218, 169)
            Me.radButtonExport.Name = "radButtonExport"
            Me.radButtonExport.Size = New System.Drawing.Size(110, 24)
            Me.radButtonExport.TabIndex = 2
            Me.radButtonExport.Text = "Export"
            '
            'radTextBoxOrderNumber
            '
            Me.radTextBoxOrderNumber.Enabled = False
            Me.radTextBoxOrderNumber.Location = New System.Drawing.Point(459, 171)
            Me.radTextBoxOrderNumber.Name = "radTextBoxOrderNumber"
            Me.radTextBoxOrderNumber.Size = New System.Drawing.Size(186, 20)
            Me.radTextBoxOrderNumber.TabIndex = 2
            Me.radTextBoxOrderNumber.Text = "7374369"
            '
            'radButtonGenerate
            '
            Me.radButtonGenerate.Location = New System.Drawing.Point(6, 169)
            Me.radButtonGenerate.Name = "radButtonGenerate"
            Me.radButtonGenerate.Size = New System.Drawing.Size(110, 24)
            Me.radButtonGenerate.TabIndex = 2
            Me.radButtonGenerate.Text = "Generate"
            '
            'radLabel7
            '
            Me.radLabel7.Location = New System.Drawing.Point(371, 172)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(82, 18)
            Me.radLabel7.TabIndex = 0
            Me.radLabel7.Text = "Order Number:"
            '
            'radGroupBox4
            '
            Me.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox4.Controls.Add(Me.radBarcode1)
            Me.radGroupBox4.HeaderText = "PDF 417 barcode"
            Me.radGroupBox4.Location = New System.Drawing.Point(6, 208)
            Me.radGroupBox4.Name = "radGroupBox4"
            Me.radGroupBox4.Size = New System.Drawing.Size(660, 126)
            Me.radGroupBox4.TabIndex = 1
            Me.radGroupBox4.Text = "PDF 417 barcode"
            '
            'radBarcode1
            '
            Me.radBarcode1.Location = New System.Drawing.Point(6, 22)
            Me.radBarcode1.Name = "radBarcode1"
            Me.radBarcode1.Size = New System.Drawing.Size(649, 95)
            Me.radBarcode1.TabIndex = 0
            Me.radBarcode1.Text = "radBarcode1"
            '
            'radGroupBox3
            '
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Controls.Add(Me.radDateTimePickerDate)
            Me.radGroupBox3.Controls.Add(Me.radTextBoxPhoneNumber)
            Me.radGroupBox3.Controls.Add(Me.radLabel6)
            Me.radGroupBox3.Controls.Add(Me.radTextBoxFullName)
            Me.radGroupBox3.Controls.Add(Me.radLabel4)
            Me.radGroupBox3.Controls.Add(Me.radLabel5)
            Me.radGroupBox3.HeaderText = "ORDER DETAILS"
            Me.radGroupBox3.Location = New System.Drawing.Point(339, 22)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Size = New System.Drawing.Size(327, 130)
            Me.radGroupBox3.TabIndex = 1
            Me.radGroupBox3.Text = "ORDER DETAILS"
            '
            'radDateTimePickerDate
            '
            Me.radDateTimePickerDate.Location = New System.Drawing.Point(120, 22)
            Me.radDateTimePickerDate.Name = "radDateTimePickerDate"
            Me.radDateTimePickerDate.Size = New System.Drawing.Size(186, 20)
            Me.radDateTimePickerDate.TabIndex = 3
            Me.radDateTimePickerDate.TabStop = False
            Me.radDateTimePickerDate.Text = "Monday, 20 November, 2017"
            Me.radDateTimePickerDate.Value = New Date(2017, 11, 20, 16, 24, 15, 633)
            '
            'radTextBoxPhoneNumber
            '
            Me.radTextBoxPhoneNumber.Location = New System.Drawing.Point(120, 87)
            Me.radTextBoxPhoneNumber.Name = "radTextBoxPhoneNumber"
            Me.radTextBoxPhoneNumber.Size = New System.Drawing.Size(186, 20)
            Me.radTextBoxPhoneNumber.TabIndex = 2
            '
            'radLabel6
            '
            Me.radLabel6.Location = New System.Drawing.Point(32, 88)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(85, 18)
            Me.radLabel6.TabIndex = 0
            Me.radLabel6.Text = "Phone Number:"
            '
            'radTextBoxFullName
            '
            Me.radTextBoxFullName.Location = New System.Drawing.Point(120, 55)
            Me.radTextBoxFullName.Name = "radTextBoxFullName"
            Me.radTextBoxFullName.Size = New System.Drawing.Size(186, 20)
            Me.radTextBoxFullName.TabIndex = 2
            '
            'radLabel4
            '
            Me.radLabel4.Location = New System.Drawing.Point(84, 22)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(32, 18)
            Me.radLabel4.TabIndex = 0
            Me.radLabel4.Text = "Date:"
            '
            'radLabel5
            '
            Me.radLabel5.Location = New System.Drawing.Point(57, 56)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(59, 18)
            Me.radLabel5.TabIndex = 0
            Me.radLabel5.Text = "Full Name:"
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.radTextBoxAddress)
            Me.radGroupBox2.Controls.Add(Me.radTextBoxCity)
            Me.radGroupBox2.Controls.Add(Me.radDropDownListCountry)
            Me.radGroupBox2.Controls.Add(Me.radLabel3)
            Me.radGroupBox2.Controls.Add(Me.radLabel2)
            Me.radGroupBox2.Controls.Add(Me.radLabel1)
            Me.radGroupBox2.HeaderText = "SHIPPING ADDRESS"
            Me.radGroupBox2.Location = New System.Drawing.Point(6, 22)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(327, 130)
            Me.radGroupBox2.TabIndex = 1
            Me.radGroupBox2.Text = "SHIPPING ADDRESS"
            '
            'radTextBoxAddress
            '
            Me.radTextBoxAddress.Location = New System.Drawing.Point(136, 87)
            Me.radTextBoxAddress.Name = "radTextBoxAddress"
            Me.radTextBoxAddress.Size = New System.Drawing.Size(186, 20)
            Me.radTextBoxAddress.TabIndex = 2
            '
            'radTextBoxCity
            '
            Me.radTextBoxCity.Location = New System.Drawing.Point(136, 55)
            Me.radTextBoxCity.Name = "radTextBoxCity"
            Me.radTextBoxCity.Size = New System.Drawing.Size(186, 20)
            Me.radTextBoxCity.TabIndex = 2
            '
            'radDropDownListCountry
            '
            Me.radDropDownListCountry.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListCountry.Location = New System.Drawing.Point(136, 22)
            Me.radDropDownListCountry.Name = "radDropDownListCountry"
            Me.radDropDownListCountry.Size = New System.Drawing.Size(186, 20)
            Me.radDropDownListCountry.TabIndex = 1
            Me.radDropDownListCountry.Text = "radDropDownList1"
            '
            'radLabel3
            '
            Me.radLabel3.Location = New System.Drawing.Point(84, 88)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(46, 18)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "Address"
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(105, 56)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(25, 18)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "City"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(84, 23)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(46, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Country"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGroupBox1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2040, 1157)
            Me.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonGenerate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox4.ResumeLayout(False)
            CType(Me.radBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.radGroupBox3.PerformLayout()
            CType(Me.radDateTimePickerDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxPhoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxFullName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.radTextBoxAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListCountry, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox

        Private radButtonExport As Telerik.WinControls.UI.RadButton

        Private radTextBoxOrderNumber As Telerik.WinControls.UI.RadTextBox

        Private radButtonGenerate As Telerik.WinControls.UI.RadButton

        Private radLabel7 As Telerik.WinControls.UI.RadLabel

        Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox

        Private radBarcode1 As Telerik.WinControls.UI.RadBarcode

        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox

        Private radDateTimePickerDate As Telerik.WinControls.UI.RadDateTimePicker

        Private radTextBoxPhoneNumber As Telerik.WinControls.UI.RadTextBox

        Private radLabel6 As Telerik.WinControls.UI.RadLabel

        Private radTextBoxFullName As Telerik.WinControls.UI.RadTextBox

        Private radLabel4 As Telerik.WinControls.UI.RadLabel

        Private radLabel5 As Telerik.WinControls.UI.RadLabel

        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox

        Private radTextBoxAddress As Telerik.WinControls.UI.RadTextBox

        Private radTextBoxCity As Telerik.WinControls.UI.RadTextBox

        Private radDropDownListCountry As Telerik.WinControls.UI.RadDropDownList

        Private radLabel3 As Telerik.WinControls.UI.RadLabel

        Private radLabel2 As Telerik.WinControls.UI.RadLabel

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
