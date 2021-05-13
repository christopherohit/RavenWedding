Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.Documents.SpreadsheetStreaming
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI

Namespace ExportWithDpl.SpreadsheetStreaming
    Public Class ExampleViewModel
        Implements INotifyPropertyChanged
        Private Shared ReadOnly ColumnsCount As Integer = 8

        Private exportedCellsCount_Renamed As Integer
        Private exportTime_Renamed As Double
        Private rowIndex As Integer = -1
        Private rowsCount_Renamed As Integer
        Private selectedDocumentFormat_Renamed As SpreadStreamExportFormat
        Private totalCellsCount_Renamed As Integer
        Private exportStarted As DateTime
        Private canExport_Renamed As Boolean
        Private memory_Renamed As Long
        Private data_Renamed As BindingSource
        Private rows As List(Of DocumentRow)

        Public Sub New()
            Me.data_Renamed = New BindingSource()
            Me.rows = New List(Of DocumentRow)()
            Me.data_Renamed.DataSource = Me.rows
            Me.RowsCount = 5000
            Me.CanExport = True

            Me.AddRemoveData()
        End Sub

        Public ReadOnly Property Data() As BindingSource
            Get
                Return Me.data_Renamed
            End Get
        End Property

        Public Property SelectedDocumentFormat() As SpreadStreamExportFormat
            Get
                Return Me.selectedDocumentFormat_Renamed
            End Get
            Set(value As SpreadStreamExportFormat)
                If Not Me.selectedDocumentFormat_Renamed <> Value Then
                    Me.selectedDocumentFormat_Renamed = Value
                    Me.OnPropertyChanged("SelectedDocumentFormat")
                End If
            End Set
        End Property

        Public ReadOnly Property ExportFormats() As IEnumerable(Of SpreadStreamExportFormat)
            Get
                Return System.Enum.GetValues(GetType(SpreadStreamExportFormat)).Cast(Of SpreadStreamExportFormat)()
            End Get
        End Property

        Public Property RowsCount() As Integer
            Get
                Return Me.rowsCount_Renamed
            End Get
            Set(value As Integer)
                If Me.rowsCount_Renamed <> Value Then
                    Me.rowsCount_Renamed = Value
                    Me.ExportedCellsCount = 0
                    Me.TotalCellsCount = ColumnsCount * Value
                    Me.AddRemoveData()
                    Me.OnPropertyChanged("RowsCount")
                End If
            End Set
        End Property

        Public Property ExportedCellsCount() As Integer
            Get
                Return Me.exportedCellsCount_Renamed
            End Get
            Set(value As Integer)
                If Me.exportedCellsCount_Renamed <> Value Then
                    Me.exportedCellsCount_Renamed = Value
                    Me.OnPropertyChanged("ExportedCellsCount")
                End If
            End Set
        End Property

        Public Property TotalCellsCount() As Integer
            Get
                Return Me.totalCellsCount_Renamed
            End Get
            Set(value As Integer)
                If Me.totalCellsCount_Renamed <> Value Then
                    Me.totalCellsCount_Renamed = Value
                    Me.OnPropertyChanged("TotalCellsCount")
                End If
            End Set
        End Property

        Public Property ExportTime() As Double
            Get
                Return Me.exportTime_Renamed
            End Get
            Set(value As Double)
                If Me.exportTime_Renamed <> Value Then
                    Me.exportTime_Renamed = Value
                    Me.OnPropertyChanged("ExportTime")
                End If
            End Set
        End Property

        Public Property Memory() As Long
            Get
                Return memory_Renamed
            End Get
            Set(value As Long)
                If Me.memory_Renamed <> Value Then
                    Me.memory_Renamed = Value
                    Me.OnPropertyChanged("Memory")
                End If
            End Set
        End Property

        Public Property CanExport() As Boolean
            Get
                Return Me.canExport_Renamed
            End Get
            Set(value As Boolean)
                If Me.canExport_Renamed <> Value Then
                    Me.canExport_Renamed = Value
                    Me.OnPropertyChanged("CanExport")
                End If
            End Set
        End Property

        Private Sub AddRemoveData()
            Me.Data.SuspendBinding()

            Do While Me.rows.Count < Me.RowsCount
                Me.rows.Add(DocumentHelper.GenerateDocumentRow(rowsCount_Renamed, Me.rows.Count))
            Loop

            Do While Me.rows.Count > Me.RowsCount
                Me.rows.RemoveAt(Me.rows.Count - 1)
            Loop

            Me.Data.ResumeBinding()
            Me.Data.ResetBindings(False)
        End Sub

        Public Sub Export(ByVal gridToExport As RadGridView)
            Dim dialog As SaveFileDialog = New SaveFileDialog()

            dialog.Filter = String.Format("{0} files|*.{1}|All files (*.*)|*.*", Me.SelectedDocumentFormat.ToString().ToLower(), Me.SelectedDocumentFormat.ToString().ToLower())
            dialog.FileName = "GridViewSpreadStreamExport"
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.CanExport = False
                Me.ExportedCellsCount = 0
                Me.ExportTime = 0
                Me.exportStarted = DateTime.Now
                rowIndex = -1

                Dim spreadStreamExport As GridViewSpreadStreamExport = New GridViewSpreadStreamExport(gridToExport)
                AddHandler spreadStreamExport.RowCreated, AddressOf spreadStreamExport_RowCreated
                spreadStreamExport.RunExport(dialog.FileName, New SpreadStreamExportRenderer())
                Me.CanExport = True
            End If
        End Sub

        Private Sub spreadStreamExport_RowCreated(ByVal sender As Object, ByVal e As SpreadStreamRowEventArgs)
            rowIndex += 1

            If rowIndex Mod (Me.RowsCount / 100) = 0 OrElse rowIndex = Me.RowsCount - 1 Then
                Me.ExportTime = (DateTime.Now - Me.exportStarted).TotalMilliseconds / 1000
                Me.ExportedCellsCount = ColumnsCount * rowIndex
                Me.Memory = GC.GetTotalMemory(False) / 1024L / 1024L
                Application.DoEvents()
            End If
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            Dim handler As PropertyChangedEventHandler = Me.PropertyChangedEvent

            If Not handler Is Nothing Then
                handler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
End Namespace
