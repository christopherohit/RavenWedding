Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Linq.Expressions
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
    Public Partial Class Form1
        Inherits ExamplesForm

        Private totalSumFormat As String = "<html>Total: <strong>{0}</strong></html>"
        Private selectionExtender As RadMultiColumnComboBoxSelectionExtender
        Private selectedEmployee_Field As NorthwindDataSet.EmployeesRow
        Private selectedCustomer_Field As NorthwindDataSet.CustomersRow
        Private quantity_Field As Integer = 1

        Public Sub New()
            InitializeComponent()
            Me.SelectedProducts = New ObservableCollection(Of NorthwindDataSet.ProductsRow)()
            AddHandler Me.SelectedProducts.CollectionChanged, AddressOf SelectedProducts_CollectionChanged
            Me.selectionExtender = New RadMultiColumnComboBoxSelectionExtender()
            Me.selectionExtender.AssociatedRadMultiColumnComboBox = Me.productsMultiColumnComboBox
            AddHandler Me.selectionExtender.AutoCompleteBoxElement.Items.CollectionChanged, AddressOf Items_CollectionChanged
        End Sub

        Public Property SelectedEmployee As NorthwindDataSet.EmployeesRow
            Get
                Return Me.selectedEmployee_Field
            End Get
            Set(ByVal value As NorthwindDataSet.EmployeesRow)
                Me.selectedEmployee_Field = value
                Me.CanExecuteSubmit()
            End Set
        End Property

        Public Property SelectedCustomer As NorthwindDataSet.CustomersRow
            Get
                Return Me.selectedCustomer_Field
            End Get
            Set(ByVal value As NorthwindDataSet.CustomersRow)
                Me.selectedCustomer_Field = value
                Me.CanExecuteSubmit()
            End Set
        End Property

        Public Property SelectedProducts As ObservableCollection(Of NorthwindDataSet.ProductsRow)

        Public Property Quantity As Integer
            Get
                Return Me.quantity_Field
            End Get
            Set(ByVal value As Integer)
                Me.quantity_Field = value
                Me.UpdateTotal()
                Me.CanExecuteSubmit()
            End Set
        End Property

        Public ReadOnly Property TotalCost As String
            Get
                Dim total As Decimal = 0

                For Each product As NorthwindDataSet.ProductsRow In Me.SelectedProducts
                    total += product.UnitPrice * Me.Quantity
                Next

                Return total.ToString("C")
            End Get
        End Property

        Private Sub SelectedProducts_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            Me.UpdateTotal()
            Me.CanExecuteSubmit()
        End Sub

        Private Sub Submit()
            Dim order As NorthwindDataSet.OrdersRow = Me.northwindDataSet.Orders.NewOrdersRow()
            order.CustomersRow = Me.SelectedCustomer
            order.EmployeesRow = Me.SelectedEmployee

            For Each product As NorthwindDataSet.ProductsRow In Me.SelectedProducts
                Dim orderDetail As NorthwindDataSet.Order_DetailsRow = Me.northwindDataSet.Order_Details.NewOrder_DetailsRow()
                orderDetail.ProductsRow = product
                orderDetail.OrdersRow = order
                orderDetail.Quantity = CShort(Me.Quantity)
                Me.northwindDataSet.Order_Details.AddOrder_DetailsRow(orderDetail)
            Next

            Me.AddOrder(order)
            Me.Clear()
        End Sub

        Private Sub AddOrder(ByVal order As NorthwindDataSet.OrdersRow)
            Dim orderInfo As OrderInfoUserControl = New OrderInfoUserControl()
            orderInfo.PopulateData(order)
            Dim count As Integer = Me.openOrdersScrollablePanel.PanelContainer.Controls.Count
            Dim location As Point = New Point(CInt((Me.openOrdersScrollablePanel.Width - orderInfo.Width) / 2), count * (orderInfo.Height + 10) - Me.openOrdersScrollablePanel.VerticalScrollbar.Value)
            Me.openOrdersScrollablePanel.PanelContainer.Controls.Add(orderInfo)
            orderInfo.Location = location
            If Me.openOrdersScrollablePanel.VerticalScrollbar.Visible Then
                Me.openOrdersScrollablePanel.VerticalScrollbar.Value = Me.openOrdersScrollablePanel.VerticalScrollbar.Maximum - Me.openOrdersScrollablePanel.VerticalScrollbar.LargeChange
            End If
        End Sub

        Private Sub CanExecuteSubmit()
            Me.submitButton.Enabled = Me.SelectedEmployee IsNot Nothing AndAlso Me.SelectedCustomer IsNot Nothing AndAlso Me.SelectedProducts.Count > 0 AndAlso Me.Quantity > 0
        End Sub

        Private Sub Clear()
            Me.SelectedCustomer = Nothing
            Me.SelectedEmployee = Nothing
            Me.employeeMultiColumnComboBox.SelectedItem = Nothing
            Me.customerMultiColumnComboBox.SelectedItem = Nothing
            Me.quantitySpinEditor.Value = 1
            Me.productsMultiColumnComboBox.MultiColumnComboBoxElement.Text = String.Empty
            Me.selectionExtender.AutoCompleteBoxElement.Clear()
            Me.SelectedProducts.Clear()

            For Each item As GridViewRowInfo In Me.selectionExtender.AssociatedRadMultiColumnComboBox.EditorControl.Rows
                item.Tag = Nothing
            Next
        End Sub

        Private Sub SeedOrders()
            Dim order As NorthwindDataSet.OrdersRow = Me.northwindDataSet.Orders.NewOrdersRow()
            order.CustomersRow = Me.northwindDataSet.Customers(0)
            order.EmployeesRow = Me.northwindDataSet.Employees(0)
            Dim products As IEnumerable(Of NorthwindDataSet.ProductsRow) = Me.northwindDataSet.Products.OfType(Of NorthwindDataSet.ProductsRow).Take(3)

            For Each product As NorthwindDataSet.ProductsRow In products
                Dim orderDetail As NorthwindDataSet.Order_DetailsRow = Me.northwindDataSet.Order_Details.NewOrder_DetailsRow()
                orderDetail.ProductsRow = product
                orderDetail.OrdersRow = order
                orderDetail.Quantity = 1
                Me.northwindDataSet.Order_Details.AddOrder_DetailsRow(orderDetail)
            Next

            Me.AddOrder(order)
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            Me.CenterControl(Me.radPanel1)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.customersTableAdapter.Fill(Me.northwindDataSet.Customers)
            Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
            Me.productsTableAdapter.Fill(Me.northwindDataSet.Products)
            Me.order_DetailsTableAdapter.Fill(Me.northwindDataSet.Order_Details)
            Me.SeedOrders()
            Me.Clear()
        End Sub

        Private Sub UpdateTotal()
            Me.totalLabel.Text = String.Format(Me.totalSumFormat, Me.TotalCost)
        End Sub

        Private Function GetDataRowView(ByVal rowInfo As GridViewRowInfo) As DataRowView
            If rowInfo IsNot Nothing Then
                Return TryCast(rowInfo.DataBoundItem, DataRowView)
            End If

            Return Nothing
        End Function

        Private Sub EmployeeMultiColumnComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRowView = Me.GetDataRowView(TryCast(Me.employeeMultiColumnComboBox.SelectedItem, GridViewDataRowInfo))

            If dataRow IsNot Nothing Then
                Me.SelectedEmployee = TryCast(dataRow.Row, NorthwindDataSet.EmployeesRow)
            End If
        End Sub

        Private Sub CustomerMultiColumnComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRowView = Me.GetDataRowView(TryCast(Me.customerMultiColumnComboBox.SelectedItem, GridViewDataRowInfo))

            If dataRow IsNot Nothing Then
                Me.SelectedCustomer = TryCast(dataRow.Row, NorthwindDataSet.CustomersRow)
            End If
        End Sub

        Private Sub Items_CollectionChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.Data.NotifyCollectionChangedEventArgs)
            Me.SelectedProducts.Clear()
            Me.selectionExtender.UpdateItems(sender, e)

            For Each item As GridViewRowInfo In Me.selectionExtender.AssociatedRadMultiColumnComboBox.EditorControl.Rows

                If item.Tag IsNot Nothing AndAlso item.Tag.ToString() = Boolean.TrueString Then
                    Dim dataRow As DataRowView = Me.GetDataRowView(TryCast(item, GridViewDataRowInfo))

                    If dataRow IsNot Nothing Then
                        Dim product As NorthwindDataSet.ProductsRow = TryCast(dataRow.Row, NorthwindDataSet.ProductsRow)
                        Me.SelectedProducts.Add(product)
                    End If
                End If
            Next
        End Sub

        Private Sub QuantitySpinEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Quantity = CInt(Me.quantitySpinEditor.Value)
        End Sub

        Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Submit()
        End Sub

        Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Clear()
        End Sub
    End Class
End Namespace
