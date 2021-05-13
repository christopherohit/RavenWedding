Imports System.Data.OleDb
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
            AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit

            Me.WireEvents()

            Me.radGridView1.EnableFiltering = True
            Me.radGridView1.EnableCustomFiltering = True
        End Sub

        Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
            If TypeOf e.Row Is GridViewFilteringRowInfo Then
                Me.radGridView1.EnableCustomFiltering = False
            End If
        End Sub

        Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
            If e.CellType Is GetType(GridRowHeaderCellElement) AndAlso TypeOf e.Row.RowInfo Is ExpandableGridViewFilteringRowInfo Then
                e.CellType = GetType(GridFilterExpandableCellElement)
            End If
        End Sub

        Private Sub MasterTemplate_CreateRowInfo(ByVal sender As Object, ByVal e As GridViewCreateRowInfoEventArgs) Handles radGridView1.CreateRowInfo
            If TypeOf e.RowInfo Is GridViewFilteringRowInfo Then
                e.RowInfo = New ExpandableGridViewFilteringRowInfo(e.ViewInfo)
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoGenerateColumns = True
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

            Me.radGridView1.TableElement.BeginUpdate()

            Using command As New OleDbCommand("SELECT ShipName, ShipAddress, ShipCity, ShippedDate, Freight FROM Orders")
                command.Connection = New OleDbConnection(Settings.Default.NwindConnectionString)
                command.Connection.Open()
                Me.radGridView1.MasterTemplate.LoadFrom(command.ExecuteReader())
                command.Connection.Close()
            End Using

            Me.radGridView1.Columns("ShipName").HeaderText = "Ship Name"
            Me.radGridView1.Columns("ShipAddress").HeaderText = "Ship Address"
            Me.radGridView1.Columns("ShipCity").HeaderText = "Ship City"
            Me.radGridView1.Columns("ShippedDate").HeaderText = "Shipped Date"


            Me.radGridView1.TableElement.EndUpdate()
            Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)
            Me.radGridView1.Rows(0).IsSelected = True
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                Dim filterRow As ExpandableGridViewFilteringRowInfo = TryCast(radGridView1.MasterView.TableFilteringRow, ExpandableGridViewFilteringRowInfo)
                filterRow.ChildRows(0).MinHeight = 140
            End If
        End Sub
    End Class
End Namespace
