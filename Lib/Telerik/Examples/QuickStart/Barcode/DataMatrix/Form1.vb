Imports System
Imports System.Text
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Barcode.Symbology
Imports Telerik.WinControls.UI.Data

Namespace Telerik.Examples.WinControls.Barcode.DataMatrix
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Implements ICustomThemeExamplesForm

        Private dataMatrix As UI.Barcode.Symbology.DataMatrix

        Public Sub New()

            InitializeComponent()

            Me.CenterPanel = True

            Me.dataMatrix = New UI.Barcode.Symbology.DataMatrix()
            Me.dataMatrix.Encodation = Encodation.Ascii
            Me.dataMatrix.SymbolSize = SymbolSize.SquareAuto
            Me.dataMatrix.Encoding = Encoding.UTF8

            Me.radBarcode1.Symbology = Me.dataMatrix
            Me.radBarcode1.Value = "7"

            Me.encodationDdl.DataSource = [Enum].GetValues(GetType(Encodation))
            Me.encodationDdl.SelectedValue = dataMatrix.Encodation
            Me.symbolSizeDdl.DataSource = [Enum].GetValues(GetType(SymbolSize))
            Me.symbolSizeDdl.SelectedValue = dataMatrix.SymbolSize

            Dim encodings As EncodingInfo() = Encoding.GetEncodings()
            Dim selectedEncoding As EncodingInfo = Nothing
            For Each item As EncodingInfo In encodings

                If item.DisplayName = dataMatrix.Encoding.EncodingName Then
                    selectedEncoding = item
                    Exit For
                End If
            Next

            Me.encodingDdl.DataSource = encodings
            Me.encodingDdl.DisplayMember = "DisplayName"
            Me.encodingDdl.SelectedValue = selectedEncoding

            AddHandler Me.encodationDdl.SelectedIndexChanging, AddressOf Me.EncodationDdl_SelectedIndexChanging
            AddHandler Me.symbolSizeDdl.SelectedIndexChanging, AddressOf Me.SymbolSizeDdl_SelectedIndexChanging
            AddHandler Me.encodingDdl.SelectedIndexChanging, AddressOf Me.EncodingDdl_SelectedIndexChanging

        End Sub

        Private Sub EncodationDdl_SelectedIndexChanging(ByVal sender As Object, ByVal e As PositionChangingCancelEventArgs)
            Try
                Me.dataMatrix.Encodation = CType(Me.encodationDdl.Items(e.Position).DataBoundItem, Encodation)
            Catch ex As Exception
                RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.[Error])

                e.Cancel = True
            End Try
        End Sub

        Private Sub SymbolSizeDdl_SelectedIndexChanging(ByVal sender As Object, ByVal e As PositionChangingCancelEventArgs)
            Try
                Me.dataMatrix.SymbolSize = CType(Me.symbolSizeDdl.Items(e.Position).DataBoundItem, SymbolSize)
            Catch ex As Exception
                RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.[Error])

                e.Cancel = True
            End Try
        End Sub

        Private Sub EncodingDdl_SelectedIndexChanging(ByVal sender As Object, ByVal e As PositionChangingCancelEventArgs)
            Try
                Dim encodingInfo As EncodingInfo = CType(Me.encodingDdl.Items(e.Position).DataBoundItem, EncodingInfo)
                Me.dataMatrix.Encoding = encodingInfo.GetEncoding()
            Catch ex As Exception
                RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.[Error])

                e.Cancel = True
            End Try
        End Sub
    End Class
End Namespace
