Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataFilter.VirtualGrid
	Partial Public Class Form1
		Inherits ExamplesForm
		Private ReadOnly selectCommand As String = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
		Private ReadOnly selectProductNameCommand As String = "SELECT ProductID, ProductName FROM Products"
		Private columnNames() As String = { "Order Id", "Product Id", "Unit Price", "Quantity", "Discount" }
		Private data As New List(Of OrderDetail)()
		Private productNames As New Dictionary(Of Integer, String)()

		Public Sub New()
			InitializeComponent()

			Me.radChartView1.View.Margin = New Padding(10, 10, 0, 20)
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Title = "Product Sales"
			Me.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
			Me.radChartView1.ChartElement.TitleElement.Font = New Font("SegoeUI", 16f)
			Me.radChartView1.ChartElement.TitleElement.Padding = New Padding(0, 10, 0, 0)

			Me.radVirtualGrid1.ColumnCount = columnNames.Length
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.AllowDelete = False
			Me.radVirtualGrid1.AllowEdit = False
			Me.radVirtualGrid1.AllowRowResize = True
			Me.radVirtualGrid1.AllowColumnResize = True
			Me.radVirtualGrid1.AllowFiltering = False
			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded

			Me.radDataFilter1.AllowDragDrop = False

			Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill

			Dim descriptor1 As New DataFilterDescriptorItem("OrderId", GetType(Integer))
			Dim descriptor2 As New DataFilterDescriptorItem("ProductId", GetType(Integer))
			Dim descriptor3 As New DataFilterDescriptorItem("UnitPrice", GetType(Decimal))
			Dim descriptor4 As New DataFilterDescriptorItem("Quantity", GetType(Short))
			Dim descriptor5 As New DataFilterDescriptorItem("Discount", GetType(Single))

			Me.radDataFilter1.Descriptors.Add(descriptor1)
			Me.radDataFilter1.Descriptors.Add(descriptor2)
			Me.radDataFilter1.Descriptors.Add(descriptor3)
			Me.radDataFilter1.Descriptors.Add(descriptor4)
			Me.radDataFilter1.Descriptors.Add(descriptor5)

			Me.radDataFilter1.Expression = "[UnitPrice] > 10 AND [Quantity] > 20"

			AddHandler Me.radDataFilter1.NodeRemoved, AddressOf radDataFilter1_NodeRemoved
			AddHandler Me.radDataFilter1.Edited, AddressOf radDataFilter1_Edited
			AddHandler Me.radDataFilter1.DragEnded, AddressOf radDataFilter1_DragEnded

			Me.FillProductNames()
			Me.SelectData()
			radChartView1.BackColor = Color.White
		End Sub

		Private Sub radDataFilter1_DragEnded(ByVal sender As Object, ByVal e As RadTreeViewDragEventArgs)
			Me.ApplyFilter()
		End Sub

		Private Sub radDataFilter1_NodeRemoved(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			Me.ApplyFilter()
		End Sub

		Private Sub radDataFilter1_Edited(ByVal sender As Object, ByVal e As TreeNodeEditedEventArgs)
			Dim criteriaNode As DataFilterCriteriaNode = TryCast(e.Node, DataFilterCriteriaNode)
			If criteriaNode IsNot Nothing Then
				Dim isFieldNameEmpty As Boolean = TelerikHelper.StringIsNullOrWhiteSpace(criteriaNode.PropertyName)
				Dim isOperatorValid As Boolean = criteriaNode.FilterOperator <> FilterOperator.None
				Dim isValueRequired As Boolean = criteriaNode.FilterOperator <> FilterOperator.IsNull AndAlso criteriaNode.FilterOperator <> FilterOperator.IsNotNull
				Dim hasValue As Boolean = criteriaNode.DescriptorValue IsNot Nothing AndAlso criteriaNode.DescriptorValue.ToString() <> String.Empty

				If (Not isFieldNameEmpty) AndAlso isOperatorValid AndAlso ((Not isValueRequired) OrElse (isValueRequired AndAlso hasValue)) Then
					Me.ApplyFilter()
				End If
			End If

			Dim groupNode As DataFilterGroupNode = TryCast(e.Node, DataFilterGroupNode)
			If groupNode IsNot Nothing Then
				Me.ApplyFilter()
			End If
		End Sub

		Private Sub ApplyFilter()
			Try
				Me.SelectData()
			Catch e1 As Exception
				RadMessageBox.Show(Me.radDataFilter1, "Please, enter valid parameters", "Expression is not valid")
			End Try
		End Sub

		Private Sub UpdateChartData()
			Dim barSeriesValues As New List(Of Integer)()
			Dim productOrders As New Dictionary(Of Integer, Decimal)()

			For Each od As OrderDetail In Me.data
				If Not productOrders.ContainsKey(od.ProductId) Then
					productOrders.Add(od.ProductId, 0)
				Else
					Dim totalPrice As Decimal = od.Quantity * od.UnitPrice
					productOrders(od.ProductId) += totalPrice - totalPrice * CDec(od.Discount)
				End If
			Next od

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.Series.Clear()

			For Each kvp As KeyValuePair(Of Integer, Decimal) In productOrders
				If kvp.Value > 0 Then
					Dim serie As New BarSeries()
					Dim point As New CategoricalDataPoint(CDbl(kvp.Value), Me.productNames(kvp.Key))
					serie.DataPoints.Add(point)
					area.Series.Add(serie)
					serie.ShowLabels = True
					Dim horizontalAxis As CategoricalAxis = TryCast(serie.HorizontalAxis, CategoricalAxis)
					If horizontalAxis IsNot Nothing Then
						horizontalAxis.ClipLabels = False
					   ' if (productOrders.Count <= 8)
							horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
						'else
						'{
						   ' horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
						'}
					End If
				End If
			Next kvp
		End Sub

		Private Sub SelectData()
			Dim filterExpression As String = Me.radDataFilter1.Expression

			If Not String.IsNullOrEmpty(filterExpression) Then
				filterExpression = "WHERE " & filterExpression
			End If

			Dim commandString As String = String.Format("{0} {1}", selectCommand, filterExpression)

			'int productsCount = 0;
			Using command As New OleDbCommand(commandString)
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
                command.Connection.Open()
				Dim reader As IDataReader = command.ExecuteReader()
				data.Clear()

				Do While reader.Read()
					Dim customer As New OrderDetail(Convert.ToInt32(reader(0)), Convert.ToInt32(reader(1)), Convert.ToDecimal(reader(2)), Convert.ToInt16(reader(3)), Convert.ToSingle(reader(4)))

					If customer.ProductId <= 10 Then
						' limit number of records
						data.Add(customer)
					End If
				Loop

				command.Connection.Close()
			End Using



			Me.radVirtualGrid1.RowCount = data.Count
			Me.radVirtualGrid1.TableElement.SynchronizeRows()
			Me.UpdateChartData()
		End Sub

		Private Sub FillProductNames()
			Dim commandString As String = selectProductNameCommand
			Using command As New OleDbCommand(commandString)
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
                command.Connection.Open()
				Dim reader As IDataReader = command.ExecuteReader()
				Me.productNames.Clear()

				Do While reader.Read()
					Dim productId As Integer = Convert.ToInt32(reader(0))
					Dim productName As String = Convert.ToString(reader(1))
					Me.productNames(productId) = productName
				Loop

				command.Connection.Close()
			End Using
		End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = columnNames(e.ColumnIndex)
			End If

			If e.RowIndex < 0 Then
				e.FieldName = columnNames(e.ColumnIndex).Replace(" ", "")
			End If

			If e.RowIndex >= 0 AndAlso e.RowIndex < data.Count Then
				e.Value = data(e.RowIndex)(e.ColumnIndex)
			End If
		End Sub
	End Class

	Public Class OrderDetail
		Public Property OrderId() As Integer
		Public Property ProductId() As Integer
		Public Property UnitPrice() As Decimal
		Public Property Quantity() As Short
		Public Property Discount() As Single

		Public Sub New(ByVal orderId As Integer, ByVal productId As Integer, ByVal unitPrice As Decimal, ByVal quantity As Short, ByVal discount As Single)
			Me.OrderId = orderId
			Me.ProductId = productId
			Me.UnitPrice = unitPrice
			Me.Quantity = quantity
			Me.Discount = discount
		End Sub

		Default Public ReadOnly Property Item(ByVal i As Integer) As Object
			Get
				Select Case i
					Case 0
						Return OrderId
					Case 1
						Return ProductId
					Case 2
						Return UnitPrice
					Case 3
						Return Quantity
					Case 4
						Return Discount
					Case Else
						Return String.Empty
				End Select
			End Get
		End Property
	End Class
End Namespace
