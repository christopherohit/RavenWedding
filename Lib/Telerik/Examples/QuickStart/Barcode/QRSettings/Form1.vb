Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Barcode.Symbology
Imports Telerik.WinControls.UI.Data

Namespace Telerik.Examples.WinControls.Barcode.QrSettings
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radGroupBox1

            Me.PopulateData()

            Me.UpdateLinkBarcodeValue()
            Me.UpdateTextBarcodeValue()
            Me.UpdateContactBarcodeValue()
            Me.UpdateLocationBarcodeValue()
        End Sub

        Private Sub PopulateData()
            Dim ecls As Dictionary(Of ErrorCorrectionLevel, String) = New Dictionary(Of ErrorCorrectionLevel, String)() From {{ErrorCorrectionLevel.H, "H"}, {ErrorCorrectionLevel.L, "L"}, {ErrorCorrectionLevel.M, "M"}, {ErrorCorrectionLevel.Q, "Q"}}
            Dim encodings As Dictionary(Of CodeMode, String) = New Dictionary(Of CodeMode, String)() From {{CodeMode.Alphanumeric, "Alphanumeric"}, {CodeMode.Byte, "Byte"}, {CodeMode.Kanji, "Kanji"}, {CodeMode.Numeric, "Numeric"}}
            Dim fnc1Modes As Dictionary(Of FNC1Mode, String) = New Dictionary(Of FNC1Mode, String)() From {{FNC1Mode.None, "None"}, {FNC1Mode.FirstPosition, "First position"}, {FNC1Mode.SecondPosition, "Second position"}}
            Dim eciNumbers As Dictionary(Of ECIMode, String) = New Dictionary(Of ECIMode, String)() From {{ECIMode.None, "None"}, {ECIMode.ISO8859_1, "ISO8859_7"}, {ECIMode.ISO8859_1En, "ISO8859_1En"}, {ECIMode.ISO8859_2, "ISO8859_2"}, {ECIMode.ISO8859_3, "ISO8859_3"}, {ECIMode.ISO8859_4, "ISO8859_4"}, {ECIMode.ISO8859_5, "ISO8859_5"}, {ECIMode.ISO8859_6, "ISO8859_6"}, {ECIMode.ISO8859_7, "ISO8859_7"}, {ECIMode.ISO8859_8, "ISO8859_8"}, {ECIMode.ISO8859_9, "ISO8859_9"}, {ECIMode.ISO8859_11, "ISO8859_11"}, {ECIMode.ISO8859_13, "ISO8859_13"}, {ECIMode.ISO8859_15, "ISO8859_15"}, {ECIMode.CP437, "CP437"}, {ECIMode.ISO646US, "ISO646US"}, {ECIMode.UTF8, "UTF8"}, {ECIMode.Windows1250, "Windows1250"}, {ECIMode.Windows1251, "Windows1251"}, {ECIMode.Windows1252, "Windows1252"}, {ECIMode.Windows1256, "Windows1256"}}
            Dim versions As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)() From {{0, "Auto"}, {1, "1"}, {2, "2"}, {3, "3"}, {4, "4"}, {5, "6"}, {7, "7"}, {8, "8"}, {9, "9"}, {10, "10"}, {11, "11"}, {12, "12"}, {13, "13"}, {14, "14"}, {15, "15"}, {16, "16"}, {17, "17"}, {18, "18"}, {19, "19"}, {20, "20"}, {21, "21"}, {22, "22"}, {23, "23"}, {24, "24"}, {25, "25"}, {26, "26"}, {27, "27"}, {28, "28"}, {29, "29"}, {30, "30"}, {31, "31"}, {32, "32"}, {33, "33"}, {34, "34"}, {35, "35"}, {36, "36"}, {37, "37"}, {38, "38"}, {39, "39"}, {40, "40"}}
            Me.radDropDownListLinkECL.ValueMember = "Key"
            Me.radDropDownListLinkECL.DisplayMember = "Value"
            Me.radDropDownListLinkECL.DataSource = ecls
            Me.radDropDownListLinkEncoding.ValueMember = "Key"
            Me.radDropDownListLinkEncoding.DisplayMember = "Value"
            Me.radDropDownListLinkEncoding.DataSource = encodings
            Me.radDropDownListLinkVersion.ValueMember = "Key"
            Me.radDropDownListLinkVersion.DisplayMember = "Value"
            Me.radDropDownListLinkVersion.DataSource = versions
            Me.radDropDownListTextECL.ValueMember = "Key"
            Me.radDropDownListTextECL.DisplayMember = "Value"
            Me.radDropDownListTextECL.DataSource = ecls
            Me.radDropDownListTextVersion.ValueMember = "Key"
            Me.radDropDownListTextVersion.DisplayMember = "Value"
            Me.radDropDownListTextVersion.DataSource = versions
            Me.radDropDownListTextFnc1Mode.ValueMember = "Key"
            Me.radDropDownListTextFnc1Mode.DisplayMember = "Value"
            Me.radDropDownListTextFnc1Mode.DataSource = fnc1Modes
            Me.radDropDownListTextEncoding.ValueMember = "Key"
            Me.radDropDownListTextEncoding.DisplayMember = "Value"
            Me.radDropDownListTextEncoding.DataSource = encodings
            Me.radDropDownListTextEciNumber.ValueMember = "Key"
            Me.radDropDownListTextEciNumber.DisplayMember = "Value"
            Me.radDropDownListTextEciNumber.DataSource = eciNumbers
            Me.radDropDownListContactECL.ValueMember = "Key"
            Me.radDropDownListContactECL.DisplayMember = "Value"
            Me.radDropDownListContactECL.DataSource = ecls
            Me.radDropDownListContactVersion.ValueMember = "Key"
            Me.radDropDownListContactVersion.DisplayMember = "Value"
            Me.radDropDownListContactVersion.DataSource = versions
            Me.radDropDownListLocationECL.ValueMember = "Key"
            Me.radDropDownListLocationECL.DisplayMember = "Value"
            Me.radDropDownListLocationECL.DataSource = ecls
            Me.radDropDownListLocationVersion.ValueMember = "Key"
            Me.radDropDownListLocationVersion.DisplayMember = "Value"
            Me.radDropDownListLocationVersion.DataSource = versions
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()
            AddHandler Me.radDropDownListTextFnc1Mode.SelectedIndexChanged, AddressOf radDropDownListTextFnc1Mode_SelectedIndexChanged
            AddHandler Me.radButtonLinkGenerate.Click, AddressOf Me.RadButtonLinkGenerate_Click
            AddHandler Me.radButtonLinkExport.Click, AddressOf Me.RadButtonLinkExport_Click
            AddHandler Me.radButtonTextGenerate.Click, AddressOf Me.RadButtonTextGenerate_Click
            AddHandler Me.radButtonTextExport.Click, AddressOf Me.RadButtonTextExport_Click
            AddHandler Me.radButtonContactGenerate.Click, AddressOf Me.RadButtonContactGenerate_Click
            AddHandler Me.radButtonContactExport.Click, AddressOf Me.RadButtonContactExport_Click
            AddHandler Me.radButtonLocationGenerate.Click, AddressOf Me.RadButtonLocationGenerate_Click
            AddHandler Me.radButtonLocationExport.Click, AddressOf Me.RadButtonLocationExport_Click
        End Sub

        Private Sub radDropDownListTextFnc1Mode_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)
            Me.radTextBoxAppIndicator.Enabled = Me.radDropDownListTextFnc1Mode.SelectedIndex <> 0
        End Sub

        Private Sub RadButtonLinkGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateLinkBarcodeValue()
        End Sub

        Private Sub RadButtonLinkExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateLinkBarcodeValue()
            Me.ExportBarcode(Me.radBarcodeLink)
        End Sub

        Private Sub RadButtonTextGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateTextBarcodeValue()
        End Sub

        Private Sub RadButtonTextExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateTextBarcodeValue()
            Me.ExportBarcode(Me.radBarcodeText)
        End Sub

        Private Sub RadButtonContactGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateContactBarcodeValue()
        End Sub

        Private Sub RadButtonContactExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateContactBarcodeValue()
            Me.ExportBarcode(Me.radBarcodeContact)
        End Sub

        Private Sub RadButtonLocationGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateLocationBarcodeValue()
        End Sub

        Private Sub RadButtonLocationExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateLocationBarcodeValue()
            Me.ExportBarcode(Me.radBarcodeLocation)
        End Sub

        Private Sub UpdateLinkBarcodeValue()
            Try
                Dim qrLink As QRCode = New QRCode(CType(Me.radDropDownListLinkEncoding.SelectedValue, CodeMode), CInt(Me.radDropDownListLinkVersion.SelectedValue), CType(Me.radDropDownListLinkECL.SelectedValue, ErrorCorrectionLevel), ECIMode.UTF8, FNC1Mode.None, Nothing)
                Me.radBarcodeLink.Symbology = qrLink
                Me.radBarcodeLink.Value = Me.radTextBoxLink.Text
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub UpdateTextBarcodeValue()
            Try
                Dim qrText As QRCode = New QRCode(CType(Me.radDropDownListTextEncoding.SelectedValue, CodeMode), CInt(Me.radDropDownListTextVersion.SelectedValue), CType(Me.radDropDownListTextECL.SelectedValue, ErrorCorrectionLevel), CType(Me.radDropDownListTextEciNumber.SelectedValue, ECIMode), CType(Me.radDropDownListTextFnc1Mode.SelectedValue, FNC1Mode), If(Me.radTextBoxAppIndicator.Enabled, Me.radTextBoxAppIndicator.Text, Nothing))
                Me.radBarcodeText.Symbology = qrText
                Me.radBarcodeText.Value = Me.radTextBoxText.Text
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub UpdateContactBarcodeValue()
            Try
                Dim vCardText As String = "BEGIN:VCARD" & vbCrLf & "VERSION:2.1" & vbCrLf & "N:"
                vCardText += Me.radTextBoxContactName.Text & " " + Me.radTextBoxContactFamily.Text & vbCrLf
                vCardText += "TEL;WORK;VOICE:" & Me.radTextBoxContactPhone.Text & vbCrLf
                vCardText += "EMAIL;PREF;INTERNET:" & Me.radTextBoxContactEmail.Text & vbCrLf
                vCardText += "END:VCARD"
                Dim qrContact As QRCode = New QRCode(CodeMode.Byte, CInt(Me.radDropDownListContactVersion.SelectedValue), CType(Me.radDropDownListContactECL.SelectedValue, ErrorCorrectionLevel), ECIMode.None, FNC1Mode.None, Nothing)
                Me.radBarcodeContact.Symbology = qrContact
                Me.radBarcodeContact.Value = vCardText
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub UpdateLocationBarcodeValue()
            Try
                Dim latDegrees As Double
                Dim longDegrees As Double
                Dim latMinutes As Double
                Dim longMinutes As Double
                Dim latSeconds As Double
                Dim longSeconds As Double
                Dim latitude, longitude As Double
                Double.TryParse(Me.radTextBoxLocationLatDegrees.Text, latDegrees)
                Double.TryParse(Me.radTextBoxLocationLatMinutes.Text, latMinutes)
                Double.TryParse(Me.radTextBoxLocationLatSeconds.Text, latSeconds)
                Double.TryParse(Me.radTextBoxLocationLongDegrees.Text, longDegrees)
                Double.TryParse(Me.radTextBoxLocationLongMinutes.Text, longMinutes)
                Double.TryParse(Me.radTextBoxLocationLongSeconds.Text, longSeconds)
                If latDegrees < -90 OrElse latDegrees > 90 Then
                    latDegrees = 1
                End If

                If longDegrees < -90 OrElse longDegrees > 90 Then
                    latDegrees = 1
                End If

                If latMinutes < 0 OrElse latMinutes > 59 Then
                    latMinutes = 1
                End If

                If longMinutes < 0 OrElse longMinutes > 59 Then
                    longMinutes = 1
                End If

                If latSeconds < 0 OrElse latSeconds > 59.99 Then
                    latSeconds = 1
                End If

                If longSeconds < 0 OrElse longSeconds > 59.99 Then
                    longSeconds = 1
                End If

                If latDegrees < 0 Then
                    latitude = latDegrees - (latMinutes / 60) - (latSeconds / 3600)
                Else
                    latitude = latDegrees + (latMinutes / 60) + (latSeconds / 3600)
                End If

                If longDegrees < 0 Then
                    longitude = longDegrees - (longMinutes / 60) - (longSeconds / 3600)
                Else
                    longitude = longDegrees + (longMinutes / 60) - (longSeconds / 3600)
                End If

                Math.Round(latitude, 10)
                Math.Round(longitude, 10)
                Dim url As String = "http://maps.google.com/maps?q=" & latitude.ToString() & "," + longitude.ToString() & "&num=1&t=m&z=12"
                Dim qrLocation As QRCode = New QRCode(CodeMode.Byte, CInt(Me.radDropDownListLinkVersion.SelectedValue), CType(Me.radDropDownListLocationECL.SelectedValue, ErrorCorrectionLevel), ECIMode.None, FNC1Mode.None, Nothing)
                Me.radBarcodeLocation.Symbology = qrLocation
                Me.radBarcodeLocation.Value = url
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub ExportBarcode(ByVal barcode As RadBarcode)
            Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Png (*.png)|*.png"
                saveFileDialog.FileName = "QRCode"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim img As Image = barcode.ExportToImage()
                    img.Save(saveFileDialog.FileName, ImageFormat.Png)
                End If
            End Using
        End Sub

    End Class
End Namespace