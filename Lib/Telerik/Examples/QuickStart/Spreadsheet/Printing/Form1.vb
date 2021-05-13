Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.WinForms.Controls.Spreadsheet

Namespace Telerik.Examples.WinControls.Spreadsheet.Printing
    Partial Public Class Form1
        Inherits ExamplesForm
        Private Const SampleDocumentPath As String = "..\Spreadsheet\SampleData\Printing.xlsx"

        Public Sub New()
            Me.StartWaiting()
            InitializeComponent()
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(3).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(2)
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
    End Class
End Namespace