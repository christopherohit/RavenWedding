Imports System.ComponentModel
Imports System.Globalization

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class OrderViewModel
		Implements INotifyPropertyChanged
		#Region "Fields"

'INSTANT VB NOTE: The variable data was renamed since Visual Basic does not allow class members with the same name:
		Private data_Renamed As List(Of OrderData)
'INSTANT VB NOTE: The variable regions was renamed since Visual Basic does not allow class members with the same name:
		Private regions_Renamed As List(Of OrdersByRegion)

		Private ordersSnacks As List(Of OrderData)
		Private ordersBeverages As List(Of OrderData)

'INSTANT VB NOTE: The variable barSnackData was renamed since Visual Basic does not allow class members with the same name:
		Private barSnackData_Renamed As IEnumerable(Of OrderByMonth)
'INSTANT VB NOTE: The variable barBeverageData was renamed since Visual Basic does not allow class members with the same name:
		Private barBeverageData_Renamed As IEnumerable(Of OrderByMonth)

'INSTANT VB NOTE: The variable lineStackData was renamed since Visual Basic does not allow class members with the same name:
		Private lineStackData_Renamed As IEnumerable(Of OrderByMonthTotalRange)
'INSTANT VB NOTE: The variable lineBeverageData was renamed since Visual Basic does not allow class members with the same name:
		Private lineBeverageData_Renamed As IEnumerable(Of OrderByMonthTotalRange)
		#End Region

		#Region "Constructor"

		Public Sub New()
			data_Renamed = ParseData()
			GetDataCompleted()
		End Sub
		#End Region

		#Region "Properties"

		Public Property BarSnackData() As IEnumerable(Of OrderByMonth)
			Get
				Return Me.barSnackData_Renamed
			End Get
			Private Set(ByVal value As IEnumerable(Of OrderByMonth))
				If Me.barSnackData_Renamed Is value Then
					Return
				End If

				Me.barSnackData_Renamed = value
				Me.OnPropertyChanged("BarSnackData")
			End Set
		End Property

		Public Property BarBeverageData() As IEnumerable(Of OrderByMonth)
			Get
				Return Me.barBeverageData_Renamed
			End Get
			Private Set(ByVal value As IEnumerable(Of OrderByMonth))
				If Me.barBeverageData_Renamed Is value Then
					Return
				End If

				Me.barBeverageData_Renamed = value
				Me.OnPropertyChanged("BarBeverageData")
			End Set
		End Property

		Public Property LineStackData() As IEnumerable(Of OrderByMonthTotalRange)
			Get
				Return Me.lineStackData_Renamed
			End Get
			Private Set(ByVal value As IEnumerable(Of OrderByMonthTotalRange))
				If Me.lineStackData_Renamed Is value Then
					Return
				End If

				Me.lineStackData_Renamed = value
				Me.OnPropertyChanged("LineStackData")
			End Set
		End Property

		Public Property LineBeverageData() As IEnumerable(Of OrderByMonthTotalRange)
			Get
				Return Me.lineBeverageData_Renamed
			End Get
			Private Set(ByVal value As IEnumerable(Of OrderByMonthTotalRange))
				If Me.lineBeverageData_Renamed Is value Then
					Return
				End If

				Me.lineBeverageData_Renamed = value
				Me.OnPropertyChanged("LineBeverageData")
			End Set
		End Property

		Public Property Data() As List(Of OrderData)
			Get
				Return Me.data_Renamed
			End Get
			Set(ByVal value As List(Of OrderData))
				If data_Renamed IsNot value Then
					data_Renamed = value
					OnPropertyChanged("Data")
				End If
			End Set
		End Property

		Public Property Regions() As List(Of OrdersByRegion)
			Get
				Return Me.regions_Renamed
			End Get
			Set(ByVal value As List(Of OrdersByRegion))
				If regions_Renamed IsNot value Then
					regions_Renamed = value
					OnPropertyChanged("Regions")
				End If
			End Set
		End Property
		#End Region

		#Region "Methods"

		Private allRegions() As String = { "Europe", "Asia", "North America", "Other" }

		Protected Sub GetDataCompleted()
			Me.Regions = InitializeRegionData()

			ordersSnacks = SeparateOrdersByProducts("Snacks", Me.Data)
			ordersBeverages = SeparateOrdersByProducts("Beverages", Me.Data)

			Me.BarSnackData = InitializeBarData(ordersSnacks)
			Me.BarBeverageData = InitializeBarData(ordersBeverages)

			Me.LineStackData = InitializeLineData(ordersSnacks)
			Me.LineBeverageData = InitializeLineData(ordersBeverages)
		End Sub

		Private Function SeparateOrdersByProducts(ByVal productName As String, ByVal data As List(Of OrderData)) As List(Of OrderData)
			Dim products As New List(Of OrderData)()

			For Each item As OrderData In data
				If item.Product = productName Then
					products.Add(item)
				End If
			Next item
			Return products
		End Function

		Private Function InitializeRegionData() As List(Of OrdersByRegion)
			Dim regions As New List(Of OrdersByRegion)()

			For Each region As String In allRegions
				Dim ov As New OrdersByRegion(region)

				For Each order As OrderData In Me.Data
					If order.Region = region Then
						ov.Data.Add(order)
					End If
				Next order
				regions.Add(ov)
			Next region

			Return regions
		End Function

		Private Function InitializeLineData(ByVal products As List(Of OrderData)) As List(Of OrderByMonthTotalRange)
			Dim productsByMonths As New List(Of OrderByMonthTotalRange)()
			For i As Integer = 0 To 11
				Dim month As String = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(i + 1)
				productsByMonths.Add(New OrderByMonthTotalRange(month))
			Next i

			For Each item As OrderData In products
				productsByMonths(item.Date.Month - 1).Data.Add(item)
			Next item
			Return productsByMonths
		End Function

		Private Function InitializeBarData(ByVal products As List(Of OrderData)) As List(Of OrderByMonth)
			Dim productsByMonths As New List(Of OrderByMonth)()
			For i As Integer = 0 To 11
				Dim month As String = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(i + 1)
				productsByMonths.Add(New OrderByMonth(month))
			Next i

			For Each item As OrderData In products
				productsByMonths(item.Date.Month - 1).Data.Add(item)
			Next item
			Return productsByMonths
		End Function

		Protected Function ParseData() As List(Of OrderData)
			Dim chartData As New List(Of OrderData)()

			Dim delimiter() As Char = { ControlChars.Cr, ControlChars.Lf }
			Dim fileContents As String = My.Resources.Dashboard
			Dim lines() As String = fileContents.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)

			For Each line As String In lines
				If String.IsNullOrEmpty(line) Then
					Continue For
				End If

				Dim data() As String = line.Split(","c)

				Dim newOrderData As New OrderData()
				newOrderData.Date = Date.Parse(data(0), CultureInfo.InvariantCulture)
				newOrderData.Amount = Integer.Parse(data(1), CultureInfo.InvariantCulture)
				newOrderData.Target = Integer.Parse(data(2), CultureInfo.InvariantCulture)
				newOrderData.Product = data(3).Trim()
				newOrderData.Country = data(4).Trim()
				newOrderData.Region = data(5).Trim()
				chartData.Add(newOrderData)
			Next line

			Return chartData
		End Function

		#End Region

		#Region "Impl"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		#End Region
	End Class
End Namespace
