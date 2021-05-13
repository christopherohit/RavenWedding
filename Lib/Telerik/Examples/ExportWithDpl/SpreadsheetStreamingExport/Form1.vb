
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

Namespace ExportWithDpl.SpreadsheetStreamingExport
    Public Partial Class Form1
        Inherits RadForm
        Private viewModel As New ExampleViewModel()

        Public Sub New()
            InitializeComponent()
            Me.WireEvents()

            If Program.themeName <> "" Then
                'set the example theme to the same theme QSF uses
                Me.ThemeName = Program.themeName
            Else
                'set default theme
                Me.ThemeName = "TelerikMetro"
            End If

            ApplyThemeRecursively(Me.Controls)

            AddBindings()
        End Sub

        Private Sub ApplyThemeRecursively(controls As Control.ControlCollection)
            For Each control As Control In controls
                Dim radControl As RadControl = TryCast(control, RadControl)

                If radControl IsNot Nothing Then
                    radControl.ThemeName = Me.ThemeName
                End If

                Me.ApplyThemeRecursively(control.Controls)
            Next
        End Sub

        Private Sub WireEvents()
            AddHandler Me.radButtonExport.Click, AddressOf RadButtonExport_Click
        End Sub

        Private Sub RadButtonExport_Click(sender As Object, e As EventArgs)
            Me.viewModel.Export()
        End Sub

        Private Sub AddBindings()
            'this.radGridView1.DataSource = this.viewModel.Data;
            'this.radGridView1.Columns["Date"].FormatString = "{0:dd MMMM yyyy}";
            'this.radGridView1.Columns["Time"].FormatString = "{0:HH:MM}";
            'this.radGridView1.Columns["Discount"].FormatString = "{0:P0}";
            'this.radGridView1.BestFitColumns();
            'this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            Me.radSpinEditorRowsCount.DataBindings.Add("Value", Me.viewModel, "RowsCount", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radDropDownListExtension.DataSource = Me.viewModel.ExportFormats
            Me.radDropDownListExtension.DataBindings.Add("SelectedValue", Me.viewModel, "SelectedDocumentFormat", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radLabelNumberOfExportedCells.DataBindings.Add("Text", Me.viewModel, "ExportedCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radLabelExportTimeElapsed.DataBindings.Add("Text", Me.viewModel, "ExportTime", True, DataSourceUpdateMode.OnPropertyChanged, 0.0, _
                "F2")

            Me.radLabelMemory.DataBindings.Add("Text", Me.viewModel, "Memory", True, DataSourceUpdateMode.OnPropertyChanged, 0.0, _
                "F2")

            Me.radButtonExport.DataBindings.Add("Enabled", Me.viewModel, "CanExport", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.radProgressBarExportProgress.DataBindings.Add("Maximum", Me.viewModel, "TotalCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.radProgressBarExportProgress.DataBindings.Add("Value1", Me.viewModel, "ExportedCellsCount", False, DataSourceUpdateMode.OnPropertyChanged)
        End Sub
    End Class
End Namespace

