Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.Aggregates
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.Enumerations

Namespace ExportWithDpl.PivotGrid
    Partial Public Class Form1
        Inherits RadForm
        Private orders As List(Of Order2) = New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Private spreadExporter As PivotGridSpreadExport
        Private pdfExporter As PivotGridPdfExport

        Public Sub New()
            InitializeComponent()

            If Program.themeName <> "" Then 'set the example theme to the same theme QSF uses
                Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = Program.themeName
            Else
                Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "TelerikMetro" 'set default theme
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.LoadData()

            Me.provider = New LocalDataSourceProvider() With { _
                .ItemsSource = orders _
            }

            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
                .PropertyName = "Product" _
            })
            provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
                .PropertyName = "Promotion" _
            })

            provider.RowGroupDescriptions.Add(New DateTimeGroupDescription() With { _
                .PropertyName = "Date", _
                .[Step] = DateTimeStep.Day _
            })

            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
                .PropertyName = "Quantity", _
                .AggregateFunction = AggregateFunctions.Sum _
            })
            provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
                .PropertyName = "Net", _
                .AggregateFunction = AggregateFunctions.Sum _
            })

            provider.AggregatesPosition = PivotAxis.Rows
            provider.AggregatesLevel = 21

            Me.radPivotGrid1.ColumnGrandTotalsPosition = TotalsPos.Last
            Me.radPivotGrid1.ColumnsSubTotalsPosition = TotalsPos.Last

            Me.radPivotGrid1.RowGrandTotalsPosition = TotalsPos.Last
            Me.radPivotGrid1.RowsSubTotalsPosition = TotalsPos.None

            Me.radPivotGrid1.PivotGridElement.DataProvider = provider
            Me.radPivotGrid1.PivotGridElement.BestFitHelper.BestFitColumns()

            Me.spreadExporter = New PivotGridSpreadExport(Me.radPivotGrid1)
            AddHandler Me.spreadExporter.CellFormatting, AddressOf spreadExporter_CellFormatting

            Me.pdfExporter = New PivotGridPdfExport(Me.radPivotGrid1)
            Me.pdfExporter.PageMargins = New Padding(15)
            AddHandler Me.pdfExporter.CellFormatting, AddressOf pdfExporter_CellFormatting

            Me.SetupInitialSettings()
        End Sub

        Private Sub LoadData()
            Dim stream As Stream = Me.[GetType]().Assembly.GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
                While streamReader.Peek() <> -1
                    Dim items As String() = streamReader.ReadLine().Split(ControlChars.Tab)
                    Dim o As New Order2() With { _
                        .[Date] = DateTime.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), _
                        .Product = items(1), _
                        .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), _
                        .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), _
                        .Promotion = items(4), _
                        .Advertisement = items(5) _
                    }
                    orders.Add(o)
                End While
            End Using
        End Sub

        Private Sub SetupInitialSettings()
            Me.exportVisualSettingsCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            Me.xlsxRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

            Me.radCheckBoxExportVisualSettingsPdfExport.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub

#Region "Events"

        Private Sub spreadExporter_CellFormatting(ByVal sender As Object, ByVal e As PivotGridSpreadExportCellFormattingEventArgs)
            If Me.customizeVisualSettingsCheckBox.ToggleState <> ToggleState.On Then
                Return
            End If

            Dim value As Decimal
            If Decimal.TryParse(e.Cell.Text, value) Then
                If value > 1000 Then
                    e.Cell.BackColor = System.Drawing.Color.Red
                    e.Cell.ForeColor = Color.White
                End If
                If value < 100 Then
                    e.Cell.BackColor = System.Drawing.Color.Green
                    e.Cell.ForeColor = Color.White
                End If
            End If
        End Sub

        Private Sub pdfExporter_CellFormatting(ByVal sender As Object, ByVal e As PivotGridPdfExportCellFormattingEventArgs)
            If Me.radCheckBoxCustomizeVisualSettingsPdfExport.ToggleState <> ToggleState.On Then
                Return
            End If

            Dim value As Decimal
            If Decimal.TryParse(e.Cell.Text, value) Then
                If value > 1000 Then
                    e.Cell.BackColor = System.Drawing.Color.Red
                    e.Cell.ForeColor = Color.White
                End If
                If value < 100 Then
                    e.Cell.BackColor = System.Drawing.Color.Green
                    e.Cell.ForeColor = Color.White
                End If
            End If
        End Sub

        Private Sub exportFlatDataCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles exportFlatDataCheckBox.ToggleStateChanged
            Me.spreadExporter.ExportFlatData = args.ToggleState = ToggleState.On
        End Sub

        Private Sub radCheckBoxExportFlatDataPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxExportFlatDataPdfExport.ToggleStateChanged
            Me.pdfExporter.ExportFlatData = args.ToggleState = ToggleState.On
        End Sub

        Private Sub exportVisualSettingsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.spreadExporter.ExportVisualSettings = args.ToggleState = ToggleState.On
        End Sub

        Private Sub radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.pdfExporter.ExportVisualSettings = args.ToggleState = ToggleState.On
        End Sub

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.FileName = "exportedFile"
            If Me.xlsxRadioButton.ToggleState = ToggleState.On Then
                Me.spreadExporter.ExportFormat = SpreadExportFormat.Xlsx
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            ElseIf Me.csvRadioButton.ToggleState = ToggleState.On Then
                Me.spreadExporter.ExportFormat = SpreadExportFormat.Csv
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
            ElseIf Me.pdfRadioButton.ToggleState = ToggleState.On Then
                Me.spreadExporter.ExportFormat = SpreadExportFormat.Pdf
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
            ElseIf Me.txtRadioButton.ToggleState = ToggleState.On Then
                Me.spreadExporter.ExportFormat = SpreadExportFormat.Txt
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            End If

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.spreadExporter.RunExport(dialog.FileName, New SpreadExportRenderer())
            End If
        End Sub

        Private Sub radButtonPdfExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.FileName = "exportedFile"
            dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.pdfExporter.FitToPageWidth = Me.radCheckBoxFitToPageWidth.ToggleState = ToggleState.On
                Me.pdfExporter.RunExport(dialog.FileName, New PdfExportRenderer())
            End If
        End Sub

#End Region

        Private Sub radCheckBoxShowHeaderAndFooter_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowHeaderAndFooter.ToggleStateChanged
            If args.ToggleState = ToggleState.On Then
                Me.pdfExporter.ShowHeaderAndFooter = True
                Me.pdfExporter.LeftHeader = "Date: " & PivotGridPdfExport.DatePrintedString
                Me.pdfExporter.MiddleHeader = "Time: " & PivotGridPdfExport.TimePrintedString
                Me.pdfExporter.RightHeader = "User: " & PivotGridPdfExport.UserNamePrintedString
                Me.pdfExporter.FooterHeight = 20
                Me.pdfExporter.MiddleFooter = String.Format("Page {0} of {1}", PivotGridPdfExport.PageNumberString, PivotGridPdfExport.TotalPagesString)
            Else
                Me.pdfExporter.ShowHeaderAndFooter = False
            End If
        End Sub
    End Class

    Public Class Order2
        Private m_net As Double

        Public Sub New()
        End Sub

        Public Property [Date]() As DateTime
            Get
                Return m_Date
            End Get
            Set(value As DateTime)
                m_Date = value
            End Set
        End Property
        Private m_Date As DateTime
        Public Property Product() As String
            Get
                Return m_Product
            End Get
            Set(value As String)
                m_Product = value
            End Set
        End Property
        Private m_Product As String
        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(value As Integer)
                m_Quantity = value
            End Set
        End Property
        Private m_Quantity As Integer

        Public Property Net() As Double
            Get
                ' throw new Exception("Example for error value");
                If Me.m_net = 1025.64 Then
                End If
                Return Me.m_net
            End Get
            Set(value As Double)
                Me.m_net = value
            End Set
        End Property

        Public Property Promotion() As String
            Get
                Return m_Promotion
            End Get
            Set(value As String)
                m_Promotion = value
            End Set
        End Property
        Private m_Promotion As String
        Public Property Advertisement() As String
            Get
                Return m_Advertisement
            End Get
            Set(value As String)
                m_Advertisement = value
            End Set
        End Property
        Private m_Advertisement As String

        Public Overrides Function ToString() As String
            Return (Me.Product & Me.Promotion) + Me.Quantity
        End Function
    End Class
End Namespace