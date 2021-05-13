
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.Holidays

    Partial Public Class Form1
        Inherits ExamplesForm

        Private resourceName As String = "holidays.hol"
        Private fileName As String = String.Empty
        Private timer As Timer
        Private handler As EventHandler

        Public Sub New()
            InitializeComponent()

            Me.handler = New EventHandler(AddressOf Me.Timer_Tick)
            Me.timer = New Timer()
            AddHandler Me.timer.Tick, Me.handler
            Me.timer.Interval = 300

            Me.LoadSettings()
            Me.radScheduler1.SelectionBehavior.SelectCell(Me.radScheduler1.ViewElement.GetCellAtPosition(0, 0))
            Me.radScheduler1.ShowNavigationElements = True
            Me.radScheduler1.AllowAppointmentsMultiSelect = False
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            CType(Me.radCheckedDDLHolidays.Items.Last(), RadCheckedListDataItem).Checked = True
            Me.timer.Start()
        End Sub

        Private Sub Timer_Tick()
            RemoveHandler Me.timer.Tick, Me.handler
            Me.timer.Dispose()
            Me.handler = Nothing

            Me.radCheckedDDLHolidays.ShowDropDown()
        End Sub

        Private Sub LoadSettings()
            Dim assembly As Assembly = Assembly.GetExecutingAssembly()
            Using stream As Stream = assembly.GetManifestResourceStream(resourceName)
                Dim source As List(Of String) = Me.radScheduler1.Holidays.GetAllLocations(stream)
                Me.radCheckedDDLHolidays.DataSource = source
            End Using
        End Sub

        Private Sub radCheckedDDLHolidays_ItemCheckedChanged(ByVal sender As Object, ByVal e As RadCheckedListDataItemEventArgs) Handles radCheckedDDLHolidays.ItemCheckedChanged
            Me.radScheduler1.Appointments.Clear()
            Me.radScheduler1.Holidays.Clear()
            If String.IsNullOrEmpty(Me.fileName) Then
                Dim assembly As Assembly = Assembly.GetExecutingAssembly()
                Using stream As Stream = assembly.GetManifestResourceStream(resourceName)
                    Me.radScheduler1.Holidays.ReadHolidays(stream, True, Me.radCheckedDDLHolidays.CheckedItems.[Select](Function(l) l.Text))
                End Using
            Else
                Me.radScheduler1.Holidays.ReadHolidays(Me.fileName, True, Me.radCheckedDDLHolidays.CheckedItems.[Select](Function(l) l.Text))
            End If

            Me.radScheduler1.ViewElement.View.StartDate = FindFirstHoliday()
        End Sub

        Private Sub RadScheduler1_CellFormatting(ByVal sender As Object, ByVal e As SchedulerCellEventArgs) Handles radScheduler1.CellFormatting
            If Not Me.radCheckBoxColorCells.IsChecked Then
                Return
            End If

            If Not (TypeOf e.CellElement Is SchedulerHeaderCellElement) Then
                If Me.radScheduler1.Holidays.IsHoliday(e.CellElement.Date) Then
                    Dim s As String = String.Empty


                    For Each item As Holiday In Me.radScheduler1.Holidays.GetHolidays(e.CellElement.Date).OrderBy(Function(ae) ae.HolidayName)
                        If Not s.Contains(item.HolidayName) Then s += item.HolidayName + Environment.NewLine
                    Next

                    e.CellElement.DrawText = True
                    e.CellElement.Text = s.ToString()
                    e.CellElement.TextWrap = True
                    e.CellElement.TextAlignment = ContentAlignment.BottomCenter
                    Dim padding As Padding = e.CellElement.Padding
                    If Me.radScheduler1.ActiveViewType = SchedulerViewType.Month Then padding.Bottom = 22
                    e.CellElement.Padding = padding
                    If Me.radScheduler1.Holidays.GetHolidays(e.CellElement.Date).Where(Function(l) l.Location = "Bulgaria").Any() Then e.CellElement.BackColor = Color.LightGreen Else e.CellElement.BackColor = Color.Orange
                Else
                    e.CellElement.DrawText = False
                    e.CellElement.ResetValue(RadItem.BackColorProperty, ValueResetFlags.Local)
                End If
            End If
        End Sub

        Private Function FindFirstHoliday() As DateTime
            Dim now As DateTime = DateTime.Today
            Dim holidays As IEnumerable(Of Holiday) = Me.radScheduler1.Holidays.Where(Function(hol) hol.Date >= now)
            If Not holidays.Any() Then
                Return now
            End If

            Dim minDistance As TimeSpan = holidays.Min(Function(hol) (hol.Date - now).Duration())
            Return holidays.First(Function(hol) (hol.Date - now).Duration() = minDistance).Date
        End Function

        Private Sub radCheckBoxColorCells_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBoxColorCells.CheckStateChanged
            Me.radScheduler1.SchedulerElement.RefreshViewElement()
        End Sub

        Private Sub radButtonImportFromOutlook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonImportFromOutlook.Click
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog.FilterIndex = 1
            openFileDialog.FileName = "outlookhol_7130_5000_en - us.hol"
            openFileDialog.DefaultExt = "*.hol"
            openFileDialog.CheckFileExists = True
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Me.radScheduler1.Appointments.Clear()
                Me.radScheduler1.Holidays.Clear()
                Me.fileName = openFileDialog.FileName
                Dim source As List(Of String) = Me.radScheduler1.Holidays.GetAllLocations(Me.fileName)
                Me.radCheckedDDLHolidays.DataSource = source
            End If
        End Sub

    End Class
End Namespace
