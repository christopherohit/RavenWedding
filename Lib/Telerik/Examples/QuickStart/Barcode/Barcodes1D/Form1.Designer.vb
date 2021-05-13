Namespace Telerik.Examples.WinControls.Barcode.Barcodes1D

    Partial Class Form1

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim code1281 As Telerik.WinControls.UI.Barcode.Symbology.Code128 = New Telerik.WinControls.UI.Barcode.Symbology.Code128()
            Dim code391 As Telerik.WinControls.UI.Barcode.Symbology.Code39 = New Telerik.WinControls.UI.Barcode.Symbology.Code39()
            Dim eaN131 As Telerik.WinControls.UI.Barcode.Symbology.EAN13 = New Telerik.WinControls.UI.Barcode.Symbology.EAN13()
            Dim codabar1 As Telerik.WinControls.UI.Barcode.Symbology.Codabar = New Telerik.WinControls.UI.Barcode.Symbology.Codabar()
            Dim postnet1 As Telerik.WinControls.UI.Barcode.Symbology.Postnet = New Telerik.WinControls.UI.Barcode.Symbology.Postnet()
            Dim code93Extended1 As Telerik.WinControls.UI.Barcode.Symbology.Code93Extended = New Telerik.WinControls.UI.Barcode.Symbology.Code93Extended()
            Dim upca1 As Telerik.WinControls.UI.Barcode.Symbology.UPCA = New Telerik.WinControls.UI.Barcode.Symbology.UPCA()
            Dim upcSupplement51 As Telerik.WinControls.UI.Barcode.Symbology.UPCSupplement5 = New Telerik.WinControls.UI.Barcode.Symbology.UPCSupplement5()
            Dim code25Standard1 As Telerik.WinControls.UI.Barcode.Symbology.Code25Standard = New Telerik.WinControls.UI.Barcode.Symbology.Code25Standard()
            Me.doubleDufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radBarcode1 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode2 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode3 = New Telerik.WinControls.UI.RadBarcode()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radBarcode4 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode5 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode6 = New Telerik.WinControls.UI.RadBarcode()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radBarcode7 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode8 = New Telerik.WinControls.UI.RadBarcode()
            Me.radBarcode9 = New Telerik.WinControls.UI.RadBarcode()
            Me.doubleDufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radBarcode9), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.doubleDufferedTableLayoutPanel1.ColumnCount = 3
            Me.doubleDufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0F))
            Me.doubleDufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0F))
            Me.doubleDufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0F))
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 2, 0)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 1, 0)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode1, 0, 1)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode2, 1, 1)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode3, 2, 1)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 2)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel5, 1, 2)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel6, 2, 2)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode4, 0, 3)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode5, 1, 3)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode6, 2, 3)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel7, 0, 4)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel8, 1, 4)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radLabel9, 2, 4)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode7, 0, 5)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode8, 1, 5)
            Me.doubleDufferedTableLayoutPanel1.Controls.Add(Me.radBarcode9, 2, 5)
            Me.doubleDufferedTableLayoutPanel1.Location = New System.Drawing.Point(79, 52)
            Me.doubleDufferedTableLayoutPanel1.Name = "doubleDufferedTableLayoutPanel1"
            Me.doubleDufferedTableLayoutPanel1.RowCount = 6
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0F))
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0F))
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.0F))
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0F))
            Me.doubleDufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleDufferedTableLayoutPanel1.Size = New System.Drawing.Size(767, 521)
            Me.doubleDufferedTableLayoutPanel1.TabIndex = 0
            Me.radLabel3.AutoSize = False
            Me.radLabel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel3.Location = New System.Drawing.Point(516, 3)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(248, 35)
            Me.radLabel3.TabIndex = 2
            Me.radLabel3.Text = "EAN 13"
            Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel2.AutoSize = False
            Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel2.Location = New System.Drawing.Point(256, 3)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(254, 35)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Code 39"
            Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel1.AutoSize = False
            Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel1.Location = New System.Drawing.Point(3, 3)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(247, 35)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Code 128"
            Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radBarcode1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode1.Location = New System.Drawing.Point(3, 44)
            Me.radBarcode1.Name = "radBarcode1"
            Me.radBarcode1.Size = New System.Drawing.Size(247, 124)
            code1281.Checksum = True
            code1281.LineAlign = System.Drawing.StringAlignment.Far
            code1281.[Module] = 1
            code1281.ShowText = True
            code1281.Stretch = False
            code1281.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode1.Symbology = code1281
            Me.radBarcode1.TabIndex = 3
            Me.radBarcode1.Text = "radBarcode1"
            Me.radBarcode1.Value = "CODE 12827"
            Me.radBarcode2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode2.Location = New System.Drawing.Point(256, 44)
            Me.radBarcode2.Name = "radBarcode2"
            Me.radBarcode2.Size = New System.Drawing.Size(254, 124)
            code391.Checksum = True
            code391.LineAlign = System.Drawing.StringAlignment.Far
            code391.[Module] = 1
            code391.ShowText = True
            code391.Stretch = False
            code391.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode2.Symbology = code391
            Me.radBarcode2.TabIndex = 4
            Me.radBarcode2.Text = "radBarcode2"
            Me.radBarcode2.Value = "CODE 39R"
            Me.radBarcode3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode3.Location = New System.Drawing.Point(516, 44)
            Me.radBarcode3.Name = "radBarcode3"
            Me.radBarcode3.Size = New System.Drawing.Size(248, 124)
            eaN131.Checksum = False
            eaN131.LineAlign = System.Drawing.StringAlignment.Far
            eaN131.[Module] = 1
            eaN131.ShowText = True
            eaN131.Stretch = False
            eaN131.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode3.Symbology = eaN131
            Me.radBarcode3.TabIndex = 5
            Me.radBarcode3.Text = "radBarcode3"
            Me.radBarcode3.Value = "1234567890"
            Me.radLabel4.AutoSize = False
            Me.radLabel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel4.Location = New System.Drawing.Point(3, 174)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(247, 35)
            Me.radLabel4.TabIndex = 6
            Me.radLabel4.Text = "Codabar"
            Me.radLabel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel5.AutoSize = False
            Me.radLabel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel5.Location = New System.Drawing.Point(256, 174)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(254, 35)
            Me.radLabel5.TabIndex = 7
            Me.radLabel5.Text = "Postnet"
            Me.radLabel5.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel6.AutoSize = False
            Me.radLabel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel6.Location = New System.Drawing.Point(516, 174)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(248, 35)
            Me.radLabel6.TabIndex = 8
            Me.radLabel6.Text = "Code 93 Extended"
            Me.radLabel6.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radBarcode4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode4.Location = New System.Drawing.Point(3, 215)
            Me.radBarcode4.Name = "radBarcode4"
            Me.radBarcode4.Size = New System.Drawing.Size(247, 129)
            codabar1.Checksum = False
            codabar1.LineAlign = System.Drawing.StringAlignment.Far
            codabar1.[Module] = 1
            codabar1.ShowText = True
            codabar1.Stretch = True
            codabar1.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode4.Symbology = codabar1
            Me.radBarcode4.TabIndex = 9
            Me.radBarcode4.Text = "radBarcode4"
            Me.radBarcode4.Value = "1234567"
            Me.radBarcode5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode5.Location = New System.Drawing.Point(256, 215)
            Me.radBarcode5.Name = "radBarcode5"
            Me.radBarcode5.Size = New System.Drawing.Size(254, 129)
            postnet1.Checksum = True
            postnet1.LineAlign = System.Drawing.StringAlignment.Far
            postnet1.[Module] = 1
            postnet1.ShowText = True
            postnet1.Stretch = False
            postnet1.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode5.Symbology = postnet1
            Me.radBarcode5.TabIndex = 10
            Me.radBarcode5.Text = "radBarcode5"
            Me.radBarcode5.Value = "1234567890"
            Me.radBarcode6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode6.Location = New System.Drawing.Point(516, 215)
            Me.radBarcode6.Name = "radBarcode6"
            Me.radBarcode6.Size = New System.Drawing.Size(248, 129)
            code93Extended1.Checksum = True
            code93Extended1.LineAlign = System.Drawing.StringAlignment.Far
            code93Extended1.[Module] = 1
            code93Extended1.ShowText = True
            code93Extended1.Stretch = True
            code93Extended1.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode6.Symbology = code93Extended1
            Me.radBarcode6.TabIndex = 11
            Me.radBarcode6.Text = "radBarcode6"
            Me.radBarcode6.Value = "CODE 398Z"
            Me.radLabel7.AutoSize = False
            Me.radLabel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel7.Location = New System.Drawing.Point(3, 350)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(247, 35)
            Me.radLabel7.TabIndex = 12
            Me.radLabel7.Text = "UPCA"
            Me.radLabel7.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel8.AutoSize = False
            Me.radLabel8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel8.Location = New System.Drawing.Point(256, 350)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(254, 35)
            Me.radLabel8.TabIndex = 13
            Me.radLabel8.Text = "UPCSupplement5"
            Me.radLabel8.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radLabel9.AutoSize = False
            Me.radLabel9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel9.Location = New System.Drawing.Point(516, 350)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(248, 35)
            Me.radLabel9.TabIndex = 14
            Me.radLabel9.Text = "Code 25 Standard"
            Me.radLabel9.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.radBarcode7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode7.Location = New System.Drawing.Point(3, 391)
            Me.radBarcode7.Name = "radBarcode7"
            Me.radBarcode7.Size = New System.Drawing.Size(247, 127)
            upca1.Checksum = True
            upca1.LineAlign = System.Drawing.StringAlignment.Far
            upca1.[Module] = 1
            upca1.ShowText = True
            upca1.Stretch = False
            upca1.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode7.Symbology = upca1
            Me.radBarcode7.TabIndex = 15
            Me.radBarcode7.Text = "radBarcode7"
            Me.radBarcode7.Value = "1234567890"
            Me.radBarcode8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode8.Location = New System.Drawing.Point(256, 391)
            Me.radBarcode8.Name = "radBarcode8"
            Me.radBarcode8.Size = New System.Drawing.Size(254, 127)
            upcSupplement51.Checksum = False
            upcSupplement51.LineAlign = System.Drawing.StringAlignment.Far
            upcSupplement51.[Module] = 1
            upcSupplement51.ShowText = True
            upcSupplement51.Stretch = False
            upcSupplement51.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode8.Symbology = upcSupplement51
            Me.radBarcode8.TabIndex = 16
            Me.radBarcode8.Text = "radBarcode8"
            Me.radBarcode8.Value = "12345"
            Me.radBarcode9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radBarcode9.Location = New System.Drawing.Point(516, 391)
            Me.radBarcode9.Name = "radBarcode9"
            Me.radBarcode9.Size = New System.Drawing.Size(248, 127)
            code25Standard1.Checksum = False
            code25Standard1.LineAlign = System.Drawing.StringAlignment.Far
            code25Standard1.[Module] = 1
            code25Standard1.ShowText = True
            code25Standard1.Stretch = True
            code25Standard1.TextAlign = System.Drawing.StringAlignment.Center
            Me.radBarcode9.Symbology = code25Standard1
            Me.radBarcode9.TabIndex = 17
            Me.radBarcode9.Text = "radBarcode9"
            Me.radBarcode9.Value = "123456789"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(936, 628)
            Me.Controls.Add(Me.doubleDufferedTableLayoutPanel1)
            Me.Name = "Form3"
            Me.Text = "Form3"
            Me.doubleDufferedTableLayoutPanel1.ResumeLayout(False)
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radBarcode9), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private doubleDufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel

        Private radLabel3 As Telerik.WinControls.UI.RadLabel

        Private radLabel2 As Telerik.WinControls.UI.RadLabel

        Private radLabel1 As Telerik.WinControls.UI.RadLabel

        Private radBarcode1 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode2 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode3 As Telerik.WinControls.UI.RadBarcode

        Private radLabel4 As Telerik.WinControls.UI.RadLabel

        Private radLabel5 As Telerik.WinControls.UI.RadLabel

        Private radLabel6 As Telerik.WinControls.UI.RadLabel

        Private radBarcode4 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode5 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode6 As Telerik.WinControls.UI.RadBarcode

        Private radLabel7 As Telerik.WinControls.UI.RadLabel

        Private radLabel8 As Telerik.WinControls.UI.RadLabel

        Private radLabel9 As Telerik.WinControls.UI.RadLabel

        Private radBarcode7 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode8 As Telerik.WinControls.UI.RadBarcode

        Private radBarcode9 As Telerik.WinControls.UI.RadBarcode
    End Class
End Namespace