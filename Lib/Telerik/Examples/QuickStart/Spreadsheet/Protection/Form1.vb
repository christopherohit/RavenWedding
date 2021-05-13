Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.WinForms.Controls.Spreadsheet.Worksheets

Namespace Telerik.Examples.WinControls.Spreadsheet.Protection
    Partial Public Class Form1
        Inherits ExamplesForm
        Private Const SampleDocumentPath As String = "..\Spreadsheet\SampleData\BalanceSheet.xlsx"
        Private worksheetEditor As RadWorksheetEditor

        Public Sub New()
            Me.StartWaiting()
            InitializeComponent()

            Dim bytes As Byte() = File.ReadAllBytes(SampleDocumentPath)
            Me.radSpreadsheet1.SpreadsheetElement.Workbook = TryCast(WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider"), XlsxFormatProvider).Import(bytes)
            AddHandler Me.radSpreadsheet1.SpreadsheetElement.ActiveSheetEditorChanged, AddressOf Me.RadSpreadsheet_ActiveSheetEditorChanged

            Me.RadSpreadsheet_ActiveSheetEditorChanged(Nothing, EventArgs.Empty)
            Me.radSpreadsheet1.SpreadsheetElement.ThemesManager.CurrentFontScheme = Me.radSpreadsheet1.SpreadsheetElement.ThemesManager.BuiltInFontSchemes.First(Function(scheme)
                                                                                                                                                                     Return scheme.Name = "Angels"
                                                                                                                                                                 End Function)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.UpdateProtectButtonContent()
            Me.StopWaiting()
            Me.radSpreadsheet1.SpreadsheetElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        End Sub

        Private Sub RadSpreadsheet_ActiveSheetEditorChanged(sender As Object, e As EventArgs)
            If Me.worksheetEditor IsNot Nothing Then
                RemoveHandler Me.worksheetEditor.Selection.ActiveCellModeChanged, AddressOf Me.Selection_ActiveCellModeChanged
                If Me.worksheetEditor.Worksheet IsNot Nothing Then
                    RemoveHandler Me.worksheetEditor.Worksheet.IsProtectedChanged, AddressOf Me.Worksheet_IsProtectedChanged
                End If
            End If

            Me.worksheetEditor = Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor

            If Me.worksheetEditor IsNot Nothing Then
                AddHandler Me.worksheetEditor.Selection.ActiveCellModeChanged, AddressOf Me.Selection_ActiveCellModeChanged
                If Me.worksheetEditor.Worksheet IsNot Nothing Then
                    AddHandler Me.worksheetEditor.Worksheet.IsProtectedChanged, AddressOf Me.Worksheet_IsProtectedChanged
                End If
            End If
        End Sub

        Private Sub Worksheet_IsProtectedChanged(sender As Object, e As EventArgs)
            Me.UpdateProtectButtonContent()
        End Sub

        Private Sub Selection_ActiveCellModeChanged(sender As Object, e As EventArgs)
            Me.UpdateProtectionOptionsIsEnabled()
        End Sub

        Private Sub protectSheetButton_Click(sender As Object, e As EventArgs)
            If Me.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.IsProtected Then
                Dim requriesNoPassword As Boolean = Me.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.Unprotect(String.Empty)
                If Not requriesNoPassword Then
                    Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Commands.ShowUnprotectSheetDialog.Execute(Nothing)
                End If
            Else
                Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Commands.ShowProtectSheetDialog.Execute(Nothing)
            End If
        End Sub

        Private Sub UpdateProtectionOptionsIsEnabled()
            If Me.worksheetEditor IsNot Nothing Then
                Dim enabled As Boolean = Me.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Selection.ActiveCellMode = ActiveCellMode.Display
                Me.protectSheetButton.Enabled = enabled
                Me.saveSheetButton.Enabled = enabled
            End If
        End Sub

        Private Sub UpdateProtectButtonContent()
            Dim content As String = "Protect Sheet"
            If Me.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.IsProtected Then
                content = "Unprotect Sheet"
            End If

            Me.protectSheetButton.Text = content
        End Sub

        Private Sub saveSheetButton_Click(sender As Object, e As EventArgs)
            If Me.worksheetEditor IsNot Nothing Then
                Me.worksheetEditor.Commands.SaveFile.Execute(Nothing)
            End If
        End Sub
    End Class
End Namespace