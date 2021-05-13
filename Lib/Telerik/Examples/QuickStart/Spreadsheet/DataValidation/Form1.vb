Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx

Namespace Telerik.Examples.WinControls.Spreadsheet.DataValidation
    Partial Public Class Form1
        Inherits ExamplesForm
        Private Const SampleDocumentPath As String = "..\Spreadsheet\SampleData\MonthlyReport.xlsx"

        Public Sub New()
            Me.StartWaiting()
            InitializeComponent()
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(3).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(4)
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.SystemButtons.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.ShouldHandleMouseInput = False
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.CanManageOwnerForm = False

            Dim bytes As Byte() = File.ReadAllBytes(SampleDocumentPath)
            Me.radSpreadsheet1.SpreadsheetElement.Workbook = TryCast(WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider"), XlsxFormatProvider).Import(bytes)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.StopWaiting()
            Me.radSpreadsheet1.SpreadsheetElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        End Sub

        Private Sub CircleInvalidDataRadioButton_Click(sender As Object, e As EventArgs)
            Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.CircleInvalidData()
        End Sub

        Private Sub ClearInvalidDataCirclesRadioButton_Click(sender As Object, e As EventArgs)
            Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.ClearInvalidDataCircles()
        End Sub
    End Class
End Namespace