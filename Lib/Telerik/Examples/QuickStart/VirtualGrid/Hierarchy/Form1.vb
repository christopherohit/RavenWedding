Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
    Partial Public Class Form1
        Inherits ExamplesForm
#Region "Initialization"

        Private data As List(Of Employee) = New List(Of Employee)()
        Private expandTimer As Timer = New Timer()
        Private rowToExpand As Integer
        Private viewInfoToExpand As VirtualGridViewInfo

        Public Sub New()
            InitializeComponent()
            LoadData()
            Me.radVirtualGrid1.TableElement.RowHeight = 120

            expandTimer.Interval = 1000
            AddHandler expandTimer.Tick, AddressOf expandTimer_Tick
        End Sub

#End Region

#Region "Populate Data"

   Private Sub LoadData()

            employeesTableAdapter.Fill(northwindDataSet.Employees)
            customersTableAdapter.Fill(northwindDataSet.Customers)
            Dim random As New Random()

            For i As Integer = 0 To northwindDataSet.Employees.Count - 1
                Dim row As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow = northwindDataSet.Employees(i)
                Dim employee__1 As New Employee()
                employee__1.Name = row.FirstName + " " + row.LastName
                employee__1.Photo = GetImageFromBytes(row.Photo)
                employee__1.Salary = random.[Next](45000)
                employee__1.HireDate = row.HireDate
                employee__1.Title = row.Title

                Dim rowCount As Integer = random.[Next](3, 10)

                For j As Integer = 0 To rowCount - 1
                    Dim customerIndex As Integer = random.[Next](0, northwindDataSet.Customers.Count)
                    Dim customerRow As Telerik.Examples.WinControls.DataSources.NorthwindDataSet.CustomersRow = northwindDataSet.Customers(customerIndex)

                    Dim customer As New Customer() With { _
                        .CompanyName = customerRow.CompanyName, _
                        .Country = customerRow.Country, _
                        .City = customerRow.City, _
                        .ContactName = customerRow.ContactName _
                    }

                    Dim salesCount As Integer = random.[Next](2, 6)

                    For k As Integer = 0 To salesCount - 1
                        customer.Sales.Add(New Sale() With { _
                            .ProductNumber = random.[Next](1000), _
                            .Quantity = random.[Next](50), _
                            .Discount = random.[Next](100), _
                            .Total = random.[Next](10000) _
                        })
                    Next

                    employee__1.Customers.Add(Customer)
                Next

                data.Add(employee__1)
            Next

            Me.radVirtualGrid1.RowCount = data.Count
            Me.radVirtualGrid1.ColumnCount = Employee.FieldNames.Length
        End Sub

        Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
            If e.ViewInfo.Equals(Me.radVirtualGrid1.MasterViewInfo) Then
                If e.ColumnIndex < 0 Then
                    Return
                End If

                e.FieldName = Employee.FieldNames(e.ColumnIndex)

                If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                    e.Value = e.FieldName
                ElseIf e.RowIndex >= 0 Then
                    e.Value = data(e.RowIndex)(e.ColumnIndex)
                    If e.ColumnIndex = 2 Then
                        e.FormatString = "${0:#,###}"
                    ElseIf e.ColumnIndex = 3 Then
                        e.FormatString = "{0:MM/dd/yy}"
                    End If
                End If
            ElseIf e.ViewInfo.HierarchyLevel = 1 Then
                If e.ColumnIndex < 0 Then
                    Return
                End If

                e.FieldName = Customer.FieldNames(e.ColumnIndex)

                If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                    e.Value = e.FieldName
                ElseIf e.RowIndex >= 0 Then
                    e.Value = data(e.ViewInfo.ParentRowIndex).Customers(e.RowIndex)(e.ColumnIndex)
                End If
            Else
                If e.ColumnIndex < 0 Then
                    Return
                End If

                e.FieldName = Sale.FieldNames(e.ColumnIndex)

                If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
                    e.Value = e.FieldName
                ElseIf e.RowIndex >= 0 Then
                    e.Value = data(e.ViewInfo.ParentViewInfo.ParentRowIndex).Customers(e.ViewInfo.ParentRowIndex).Sales(e.RowIndex)(e.ColumnIndex)

                    If e.ColumnIndex = 0 Then
                        e.FormatString = "#{0}"
                    ElseIf e.ColumnIndex = 2 Then
                        e.FormatString = "{0:F2}%"
                    ElseIf e.ColumnIndex = 3 Then
                        e.FormatString = "${0}"
                    End If
                End If
            End If

        End Sub

        Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting

            If e.CellElement.ColumnIndex < 0 Then
                Return
            End If

            If TypeOf e.CellElement.Value Is Image Then
                e.CellElement.Image = DirectCast(e.CellElement.Value, Image)
                e.CellElement.ImageLayout = ImageLayout.Zoom
                e.CellElement.Text = ""
            Else
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If

            If e.ViewInfo.HierarchyLevel = 1 Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
            Else
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty)
            End If

        End Sub

#End Region

#Region "Hierarchy"

        Private Sub radVirtualGrid1_QueryHasChildRows(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridQueryHasChildRowsEventArgs) Handles radVirtualGrid1.QueryHasChildRows
            e.HasChildRows = (e.RowIndex >= 0 AndAlso e.ViewInfo.HierarchyLevel < 2)
        End Sub

        Private Sub expandTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            expandTimer.Stop()
            viewInfoToExpand.StopRowWaiting(rowToExpand)
            viewInfoToExpand.ExpandRow(rowToExpand)
            viewInfoToExpand = Nothing
        End Sub

        Private Sub radVirtualGrid1_RowExpanding(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridRowExpandingEventArgs) Handles radVirtualGrid1.RowExpanding
            If viewInfoToExpand Is Nothing Then
                e.Cancel = True
                e.ViewInfo.StartRowWaiting(e.RowIndex)
                viewInfoToExpand = e.ViewInfo
                rowToExpand = e.RowIndex
                expandTimer.Start()
            Else
                If rowToExpand <> e.RowIndex Then
                    e.Cancel = True
                Else
                    If e.ChildViewInfo.HierarchyLevel = 1 Then
                        e.ChildViewInfo.ColumnCount = Customer.FieldNames.Length
                        e.ChildViewInfo.RowCount = data(e.ChildViewInfo.ParentRowIndex).Customers.Count
                    Else
                        e.ChildViewInfo.ColumnCount = Sale.FieldNames.Length
                        e.ChildViewInfo.RowCount = data(e.ChildViewInfo.ParentViewInfo.ParentRowIndex).Customers(e.ChildViewInfo.ParentRowIndex).Sales.Count
                    End If
                End If
            End If
        End Sub

#End Region

#Region "Helper Methods"

        Private Function GetImageFromBytes(ByVal bytes As Byte()) As Image
            Dim result As Image = Nothing
            Dim stream As MemoryStream = Nothing

            Try
                stream = New MemoryStream(bytes, 78, bytes.Length - 78)
                result = Image.FromStream(stream)
            Catch
                Try
                    stream = New MemoryStream(bytes, 0, bytes.Length)
                    result = Image.FromStream(stream)
                Catch
                    result = Nothing
                End Try
            Finally
                If Not stream Is Nothing Then
                    stream.Close()
                End If
            End Try

            Return result
        End Function

#End Region

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
