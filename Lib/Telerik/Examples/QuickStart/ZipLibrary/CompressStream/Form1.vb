Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Zip

Namespace Telerik.Examples.WinControls.ZipLibrary.CompressStream
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			uncompressedTextBoxControl.Text = Constants.XmlText
			AddHandler uncompressedTextBoxControl.TextChanged, AddressOf uncompressedTextBoxControl_TextChanged

			uncompressedLabel.Text = "Uncompressed size: " & uncompressedTextBoxControl.Text.Length

			Dim itemValues As Array = System.Enum.GetValues(GetType(CompressionLevel))
			Dim itemNames As Array = System.Enum.GetNames(GetType(CompressionLevel))

			For i As Integer = 0 To itemNames.Length - 1
				Dim item As New RadListDataItem(itemNames.GetValue(i).ToString(), itemValues.GetValue(i))
				compressionMethodsDropDownList.Items.Add(item)
			Next i
			compressionMethodsDropDownList.SelectedIndex = 12
		End Sub

		Private Sub uncompressedTextBoxControl_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			uncompressedLabel.Text = "Uncompressed size: " & uncompressedTextBoxControl.Text.Length
		End Sub

		Private Sub CompressString(ByVal str As String)
			Dim memoryStream As New MemoryStream()
			Dim settings As New DeflateSettings()
			settings.CompressionLevel = CType(Me.compressionMethodsDropDownList.SelectedValue, CompressionLevel)
			Dim zipOutputStream As New CompressedStream(memoryStream, StreamOperationMode.Write, settings)
			Dim writer As New StreamWriter(zipOutputStream)
			writer.Write(str)
			writer.Flush()

			compressedTextBoxControl.Text = Convert.ToBase64String(memoryStream.ToArray())
			compressedLabel.Text = "Compressed size: " & compressedTextBoxControl.Text.Length
		End Sub

		Private Sub compressButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles compressButton.Click
			CompressString(uncompressedTextBoxControl.Text)
		End Sub
	End Class
End Namespace
