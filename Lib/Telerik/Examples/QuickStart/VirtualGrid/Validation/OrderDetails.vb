Namespace Telerik.Examples.WinControls.VirtualGrid.Validation
	Public Class OrderDetails
		Public Property OrderId() As String
			Get
				Return m_OrderId
			End Get
			Set
				m_OrderId = Value
			End Set
		End Property
		Private m_OrderId As String
		Public Property ProductId() As String
			Get
				Return m_ProductId
			End Get
			Set
				m_ProductId = Value
			End Set
		End Property
		Private m_ProductId As String
		Public Property UnitPrice() As String
			Get
				Return m_UnitPrice
			End Get
			Set
				m_UnitPrice = Value
			End Set
		End Property
		Private m_UnitPrice As String
		Public Property Quantity() As String
			Get
				Return m_Quantity
			End Get
			Set
				m_Quantity = Value
			End Set
		End Property
		Private m_Quantity As String
		Public Property Discount() As String
			Get
				Return m_Discount
			End Get
			Set
				m_Discount = Value
			End Set
		End Property
		Private m_Discount As String

		Public Sub New(orderId As String, productId As String, unitPrice As String, quantity As String, discount As String)

			Me.OrderId = orderId
			Me.ProductId = productId
			Me.UnitPrice = unitPrice
			Me.Quantity = quantity
			Me.Discount = discount
		End Sub

		Public Default Property Item(i As Integer) As String
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
						Return [String].Empty
				End Select
			End Get
			Set
				Select Case i
					Case 0
						Me.OrderId = value
						Exit Select
					Case 1
						Me.ProductId = value
						Exit Select
					Case 2
						Me.UnitPrice = value
						Exit Select
					Case 3
						Me.Quantity = value
						Exit Select
					Case 4
						Me.Discount = value
						Exit Select
				End Select
			End Set
		End Property
	End Class
End Namespace