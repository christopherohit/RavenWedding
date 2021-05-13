Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
	Public Class Product
'INSTANT VB NOTE: The variable productID was renamed since Visual Basic does not allow class members with the same name:
		Private productID_Renamed As Integer
'INSTANT VB NOTE: The variable productName was renamed since Visual Basic does not allow class members with the same name:
		Private productName_Renamed As String
'INSTANT VB NOTE: The variable category was renamed since Visual Basic does not allow class members with the same name:
		Private category_Renamed As String
'INSTANT VB NOTE: The variable unitsInStock was renamed since Visual Basic does not allow class members with the same name:
		Private unitsInStock_Renamed As Integer
'INSTANT VB NOTE: The variable unitPrice was renamed since Visual Basic does not allow class members with the same name:
		Private unitPrice_Renamed As Double
'INSTANT VB NOTE: The variable isOrganic was renamed since Visual Basic does not allow class members with the same name:
		Private isOrganic_Renamed As Char
'INSTANT VB NOTE: The variable deliveryDate was renamed since Visual Basic does not allow class members with the same name:
		Private deliveryDate_Renamed As Double

		Public Sub New(ByVal productID As Integer, ByVal productName As String, ByVal category As String, ByVal unitPrice As Double, ByVal unitsInStock As Integer)
			Me.productID_Renamed = productID
			Me.productName_Renamed = productName
			Me.category_Renamed = category
			Me.unitPrice_Renamed = unitPrice
			Me.unitsInStock_Renamed = unitsInStock
		End Sub

		Public Property ProductID() As Integer
			Get
				Return Me.productID_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.productID_Renamed = value
			End Set
		End Property

		Public Property ProductName() As String
			Get
				Return Me.productName_Renamed
			End Get
			Set(ByVal value As String)
				Me.productName_Renamed = value
			End Set
		End Property

		Public Property Category() As String
			Get
				Return Me.category_Renamed
			End Get
			Set(ByVal value As String)
				Me.category_Renamed = value
			End Set
		End Property

		Public Property UnitsInStock() As Integer
			Get
				Return Me.unitsInStock_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.unitsInStock_Renamed = value
			End Set
		End Property

		<TypeConverter(GetType(UnitPriceConverter))> _
		Public Property UnitPrice() As Double
			Get
				Return Me.unitPrice_Renamed
			End Get
			Set(ByVal value As Double)
				Me.unitPrice_Renamed = value
			End Set
		End Property

		<TypeConverter(GetType(ToggleStateConverter))> _
		Public Property IsOrganic() As Char
			Get
				Return Me.isOrganic_Renamed
			End Get
			Set(ByVal value As Char)
				Me.isOrganic_Renamed = value
			End Set
		End Property

		<TypeConverter(GetType(DateTimeConverter))> _
		Public Property DeliveryDate() As Double
			Get
				Return Me.deliveryDate_Renamed
			End Get
			Set(ByVal value As Double)
				Me.deliveryDate_Renamed = value
			End Set
		End Property

		Public Shared Function Generate() As List(Of Product)
			Dim result As New List(Of Product)()

			result.Add(New Product(1, "Chai", "Beverages", 18.0000, 39))
			result.Add(New Product(2, "Chang", "Beverages", 19.0000, 17))
			result.Add(New Product(3, "Aniseed Syrup", Nothing, 10.0000, 13))
			result.Add(New Product(4, "Chef Anton's Cajun Seasoning", "Condiments", 22.0000, 53))
			result.Add(New Product(5, "Chef Anton's Gumbo Mix", "Condiments", 21.3500, 0))
			result.Add(New Product(6, "Grandma's Boysenberry Spread", "Condiments", 25.0000, 120))
			result.Add(New Product(7, "Uncle Bob's Organic Dried Pears", "Produce", 30.0000, 15))
			result.Add(New Product(8, "Northwoods Cranberry Sauce", "Condiments", 40.0000, 6))
			result.Add(New Product(9, "Mishi Kobe Niku", "Meat/Poultry", 97.0000, 29))
			result.Add(New Product(10, "Ikura", "Seafood", 31.0000, 31))
			result.Add(New Product(11, "Queso Cabrales", "Dairy Products", 21.0000, 22))
			result.Add(New Product(12, "Queso Manchego La Pastora", Nothing, 38.0000, 86))
			result.Add(New Product(13, "Konbu", "Seafood", 6.0000, 24))
			result.Add(New Product(14, "Tofu", "Produce", 23.2500, 35))
			result.Add(New Product(15, "Genen Shouyu", "Condiments", 15.5000, 39))
			result.Add(New Product(16, "Pavlova", "Confections", 17.4500, 29))
			result.Add(New Product(17, "Alice Mutton", "Meat/Poultry", 39.0000, 0))
			result.Add(New Product(18, "Carnarvon Tigers", "Seafood", 62.5000, 42))
			result.Add(New Product(19, "Teatime Chocolate Biscuits", "Confections", 9.2000, 25))
			result.Add(New Product(20, "Sir Rodney's Marmalade", "Confections", 81.0000, 40))
			result.Add(New Product(21, "Sir Rodney's Scones", Nothing, 10.0000, 3))
			result.Add(New Product(22, "Gustaf's Knäckebröd", "Grains/Cereals", 21.0000, 104))
			result.Add(New Product(23, "Tunnbröd", "Grains/Cereals", 9.0000, 61))
			result.Add(New Product(24, "Guaraná Fantástica", Nothing, 4.5000, 20))
			result.Add(New Product(25, "NuNuCa Nuß-Nougat-Creme", "Confections", 14.0000, 76))
			result.Add(New Product(26, "Gumbär Gummibärchen", "Confections", 31.2300, 15))
			result.Add(New Product(27, "Schoggi Schokolade", "Confections", 43.9000, 49))
			result.Add(New Product(28, "Rössle Sauerkraut", "Produce", 45.6000, 26))
			result.Add(New Product(29, "Thüringer Rostbratwurst", "Meat/Poultry", 123.7900, 0))
			result.Add(New Product(30, "Nord-Ost Matjeshering", "Seafood", 25.8900, 10))
			result.Add(New Product(31, "Gorgonzola Telino", "Dairy Products", 12.5000, 0))
			result.Add(New Product(32, "Mascarpone Fabioli", "Dairy Products", 32.0000, 9))
			result.Add(New Product(33, "Geitost", "Dairy Products", 2.5000, 112))
			result.Add(New Product(34, "Sasquatch Ale", "Beverages", 14.0000, 111))
			result.Add(New Product(35, "Steeleye Stout", "Beverages", 18.0000, 20))
			result.Add(New Product(36, "Inlagd Sill", "Seafood", 19.0000, 112))
			result.Add(New Product(37, "Gravad lax", "Seafood", 26.0000, 11))
			result.Add(New Product(38, "Côte de Blaye", "Beverages", 263.5000, 17))
			result.Add(New Product(39, "Chartreuse verte", Nothing, 18.0000, 69))
			result.Add(New Product(40, "Boston Crab Meat", Nothing, 18.4000, 123))
			result.Add(New Product(41, "Jack's New England Clam Chowder", "Seafood", 9.6500, 85))
			result.Add(New Product(42, "Singaporean Hokkien Fried Mee", "Grains/Cereals", 14.0000, 26))
			result.Add(New Product(43, "Ipoh Coffee", Nothing, 46.0000, 17))
			result.Add(New Product(44, "Gula Malacca", "Condiments", 19.4500, 27))
			result.Add(New Product(45, "Rogede sild", Nothing, 9.5000, 5))
			result.Add(New Product(46, "Spegesild", "Seafood", 12.0000, 95))
			result.Add(New Product(47, "Zaanse koeken", "Confections", 9.5000, 36))
			result.Add(New Product(48, "Chocolade", "Confections", 12.7500, 15))
			result.Add(New Product(49, "Maxilaku", "Confections", 20.0000, 10))
			result.Add(New Product(50, "Valkoinen suklaa", Nothing, 16.2500, 65))
			result.Add(New Product(51, "Manjimup Dried Apples", "Produce", 53.0000, 20))
			result.Add(New Product(52, "Filo Mix", "Grains/Cereals", 7.0000, 38))
			result.Add(New Product(53, "Perth Pasties", "Meat/Poultry", 32.8000, 0))
			result.Add(New Product(54, "Tourtière", "Meat/Poultry", 7.4500, 21))
			result.Add(New Product(55, "Pâté chinois", "Meat/Poultry", 24.0000, 115))
			result.Add(New Product(56, "Gnocchi di nonna Alice", "Grains/Cereals", 38.0000, 21))
			result.Add(New Product(57, "Ravioli Angelo", "Grains/Cereals", 19.5000, 36))
			result.Add(New Product(58, "Escargots de Bourgogne", "Seafood", 13.2500, 62))
			result.Add(New Product(59, "Raclette Courdavault", "Dairy Products", 55.0000, 79))
			result.Add(New Product(60, "Camembert Pierrot", "Dairy Products", 34.0000, 19))
			result.Add(New Product(61, "Sirop d'érable", "Condiments", 28.5000, 113))
			result.Add(New Product(62, "Tarte au sucre", "Confections", 49.3000, 17))
			result.Add(New Product(63, "Vegie-spread", "Condiments", 43.9000, 24))
			result.Add(New Product(64, "Wimmers gute Semmelknödel", "Grains/Cereals", 33.2500, 22))
			result.Add(New Product(65, "Louisiana Fiery Hot Pepper Sauce", "Condiments", 21.0500, 76))
			result.Add(New Product(66, "Louisiana Hot Spiced Okra", "Condiments", 17.0000, 4))
			result.Add(New Product(67, "Laughing Lumberjack Lager", "Beverages", 14.0000, 52))
			result.Add(New Product(68, "Scottish Longbreads", "Confections", 12.5000, 6))
			result.Add(New Product(69, "Gudbrandsdalsost", "Dairy Products", 36.0000, 26))
			result.Add(New Product(70, "Outback Lager", "Beverages", 15.0000, 15))
			result.Add(New Product(71, "Flotemysost", "Dairy Products", 21.5000, 26))
			result.Add(New Product(72, "Mozzarella di Giovanni", "Dairy Products", 34.8000, 14))
			result.Add(New Product(73, "Röd Kaviar", Nothing, 15.0000, 101))
			result.Add(New Product(74, "Longlife Tofu", Nothing, 10.0000, 4))
			result.Add(New Product(75, "Rhönbräu Klosterbier", "Beverages", 7.7500, 125))
			result.Add(New Product(76, "Lakkalikööri", "Beverages", 18.0000, 57))
			result.Add(New Product(77, "Original Frankfurter grüne Soße", "Condiments", 13.0000, 32))


			For i As Integer = 0 To result.Count - 1
				Dim product As Product = result(i)
				Select Case i Mod 3
					Case 0
						product.IsOrganic = "Y"c
					Case 1
						product.IsOrganic = "N"c
					Case 2
						product.IsOrganic = "M"c
					Case Else
				End Select

				product.DeliveryDate = Date.UtcNow.AddDays(-i * 5).ToOADate()
			Next i

			Return result
		End Function
	End Class
End Namespace
