Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Barcode.PDF417

    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radGroupBox1

            Dim rnd As Random = New Random()
            Me.radTextBoxOrderNumber.Text = rnd.[Next](1000000, 10000000).ToString()
            Me.radDropDownListCountry.DataSource = Countries.CountryNames
            Me.radBarcode1.Symbology = New Telerik.WinControls.UI.Barcode.Symbology.PDF417(11, 6, 1)
            AddHandler Me.radButtonGenerate.Click, AddressOf Me.RadButtonGenerate_Click
            AddHandler Me.radButtonExport.Click, AddressOf Me.RadButtonExport_Click
        End Sub

        Private Sub SetBarcodeValue()
            Dim barcodeValue As String = Me.radTextBoxOrderNumber.Text & " " & Me.radDropDownListCountry.SelectedItem.Text & " " & Me.radTextBoxCity.Text & " " & Me.radTextBoxAddress.Text & " " & Me.radDateTimePickerDate.Value.ToShortDateString() & " " & Me.radTextBoxFullName.Text & " " & Me.radTextBoxPhoneNumber.Text
            Me.radBarcode1.Value = barcodeValue
        End Sub

        Private Sub RadButtonGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetBarcodeValue()
        End Sub

        Private Sub RadButtonExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetBarcodeValue()
            Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Png (*.png)|*.png"
                saveFileDialog.FileName = "PDF417Code"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim img As Image = Me.radBarcode1.ExportToImage()
                    img.Save(saveFileDialog.FileName, ImageFormat.Png)
                End If
            End Using
        End Sub
    End Class
End Namespace
