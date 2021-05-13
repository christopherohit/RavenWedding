Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace ExportWithDpl.SpreadsheetStreaming
    Partial Public Class Form1
        Inherits RadForm
        Private viewModel As ExampleViewModel = New ExampleViewModel()

        Public Sub New()
            InitializeComponent()

            Me.WireEvents()

            If Program.themeName <> "" Then 'set the example theme to the same theme QSF uses
                Me.ThemeName = Program.themeName
            Else
                Me.ThemeName = "TelerikMetro" 'set default theme
            End If

            ApplyThemeRecursively(Me.Controls)

            AddBindings()
        End Sub

        Private Sub ApplyThemeRecursively(ByVal controls As Control.ControlCollection)
            For Each control As Control In controls
                Dim radControl As RadControl = TryCast(control, RadControl)

                If Not radControl Is Nothing Then
                    radControl.ThemeName = Me.ThemeName
                End If

                Me.ApplyThemeRecursively(control.Controls)
            Next control
        End Sub

        Private Sub WireEvents()
            AddHandler Me.radButtonExport.Click, AddressOf RadButtonExport_Click
        End Sub

        Private Sub RadButtonExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.viewModel.Export(Me.radGridView1)
        End Sub

        Private Sub AddBindings()
            Me.radGridView1.DataSource = Me.viewModel.Data
            Me.radGridView1.Columns("Date").FormatString = "{0:dd MMMM yyyy}"
            Me.radGridView1.Columns("Time").FormatString = "{0:HH:MM}"
            Me.radGridView1.Columns("Discount").FormatString = "{0:P0}"
            Me.radGridView1.BestFitColumns()
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

            Me.radSpinEditorRowsCount.DataBindings.Add("Value", Me.viewModel, "RowsCount", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radDropDownListExtension.DataSource = Me.viewModel.ExportFormats
            Me.radDropDownListExtension.DataBindings.Add("SelectedValue", Me.viewModel, "SelectedDocumentFormat", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radLabelNumberOfExportedCells.DataBindings.Add("Text", Me.viewModel, "ExportedCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radLabelExportTimeElapsed.DataBindings.Add("Text", Me.viewModel, "ExportTime", True, DataSourceUpdateMode.OnPropertyChanged, 0.0R, "F2")

            Me.radLabelMemory.DataBindings.Add("Text", Me.viewModel, "Memory", True, DataSourceUpdateMode.OnPropertyChanged, 0.0R, "F2")

            Me.radButtonExport.DataBindings.Add("Enabled", Me.viewModel, "CanExport", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radProgressBarExportProgress.DataBindings.Add("Maximum", Me.viewModel, "TotalCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.radProgressBarExportProgress.DataBindings.Add("Value1", Me.viewModel, "ExportedCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)
        End Sub
    End Class
End Namespace
