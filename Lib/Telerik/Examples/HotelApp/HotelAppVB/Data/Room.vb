Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class Room
		Implements System.ComponentModel.INotifyPropertyChanged
		Public Sub New()
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Integer
'INSTANT VB NOTE: The variable status was renamed since Visual Basic does not allow class members with the same name:
		Private status_Renamed As RoomStatus
'INSTANT VB NOTE: The variable type was renamed since Visual Basic does not allow class members with the same name:
		Private type_Renamed As RoomType
'INSTANT VB NOTE: The variable houseKeepingStatus was renamed since Visual Basic does not allow class members with the same name:
		Private houseKeepingStatus_Renamed As HouseKeepingStatus
'INSTANT VB NOTE: The variable houseKeeperId was renamed since Visual Basic does not allow class members with the same name:
		Private houseKeeperId_Renamed? As Integer
'INSTANT VB NOTE: The variable needsRepairs was renamed since Visual Basic does not allow class members with the same name:
		Private needsRepairs_Renamed As Boolean
'INSTANT VB NOTE: The variable pricePerDay was renamed since Visual Basic does not allow class members with the same name:
		Private pricePerDay_Renamed As Decimal
'INSTANT VB NOTE: The variable priority was renamed since Visual Basic does not allow class members with the same name:
		Private priority_Renamed As RoomPriority
'INSTANT VB NOTE: The variable houseKeepingStart was renamed since Visual Basic does not allow class members with the same name:
		Private houseKeepingStart_Renamed As Date
'INSTANT VB NOTE: The variable houseKeepingEnd was renamed since Visual Basic does not allow class members with the same name:
		Private houseKeepingEnd_Renamed As Date
'INSTANT VB NOTE: The variable visible was renamed since Visual Basic does not allow class members with the same name:
		Private visible_Renamed As Boolean

		Public Property Id() As Integer
			Get
				Return Me.id_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.id_Renamed = value
				OnPropertyChanged("Id")
			End Set
		End Property

		Public ReadOnly Property Name() As String
			Get
				Return Me.Id.ToString()
			End Get
		End Property

		Public Property Status() As RoomStatus
			Get
				Return Me.status_Renamed
			End Get
			Set(ByVal value As RoomStatus)
				Me.status_Renamed = value
				OnPropertyChanged("Status")
			End Set
		End Property

		Public Property Type() As RoomType
			Get
				Return Me.type_Renamed
			End Get
			Set(ByVal value As RoomType)
				Me.type_Renamed = value
				OnPropertyChanged("Type")
			End Set
		End Property

		Public Property HouseKeepingStatus() As HouseKeepingStatus
			Get
				Return Me.houseKeepingStatus_Renamed
			End Get
			Set(ByVal value As HouseKeepingStatus)
				Me.houseKeepingStatus_Renamed = value
				OnPropertyChanged("HouseKeepingStatus")
			End Set
		End Property

		Public Property HouseKeeperId() As Integer?
			Get
				Return Me.houseKeeperId_Renamed
			End Get
			Set(ByVal value? As Integer)
				Me.houseKeeperId_Renamed = value
				OnPropertyChanged("HouseKeeperId")
			End Set
		End Property

		Public Property NeedsRepairs() As Boolean
			Get
				Return Me.needsRepairs_Renamed
			End Get
			Set(ByVal value As Boolean)
				Me.needsRepairs_Renamed = value
				OnPropertyChanged("NeedsRepairs")
			End Set
		End Property

		Public Property PricePerDay() As Decimal
			Get
				Return Me.pricePerDay_Renamed
			End Get
			Set(ByVal value As Decimal)
				Me.pricePerDay_Renamed = value
				OnPropertyChanged("PricePerDay")
			End Set
		End Property

		Public Property Priority() As RoomPriority
			Get
				Return Me.priority_Renamed
			End Get
			Set(ByVal value As RoomPriority)
				Me.priority_Renamed = value
				OnPropertyChanged("Priority")
			End Set
		End Property

		Public Property HouseKeepingStart() As Date
			Get
				Return Me.houseKeepingStart_Renamed
			End Get
			Set(ByVal value As Date)
				Me.houseKeepingStart_Renamed = value
				OnPropertyChanged("HouseKeepingStart")
			End Set
		End Property

		Public Property HouseKeepingEnd() As Date
			Get
				Return Me.houseKeepingEnd_Renamed
			End Get
			Set(ByVal value As Date)
				Me.houseKeepingEnd_Renamed = value
				OnPropertyChanged("HouseKeepingEnd")
			End Set
		End Property

		Public Property Visible() As Boolean
			Get
				Return Me.visible_Renamed
			End Get
			Set(ByVal value As Boolean)
				Me.visible_Renamed = value
				OnPropertyChanged("Visible")
			End Set
		End Property

		Public Sub New(ByVal id As Integer, ByVal status As RoomStatus, ByVal type As RoomType, ByVal houseKeepingStatus_Renamed As HouseKeepingStatus, ByVal needsRepairs As Boolean, ByVal price As Decimal)
			Me.id_Renamed = id
			Me.status_Renamed = status
			Me.type_Renamed = type
			Me.houseKeepingStatus_Renamed = houseKeepingStatus_Renamed
			Me.needsRepairs_Renamed = needsRepairs
			Me.priority_Renamed = RoomPriority.Low
			Me.pricePerDay_Renamed = price
			Me.houseKeeperId_Renamed = Nothing
			Me.houseKeepingStart_Renamed = Date.Now
			Me.houseKeepingEnd_Renamed = Date.Now
			Me.visible_Renamed = True
		End Sub

		Public Function GetStatusAtDate(ByVal date_Renamed As Date, ByVal bookings As BindingList(Of Booking)) As RoomStatus ', bool IsToday)
			Dim status As RoomStatus = RoomStatus.Available

			For Each booking_Renamed As Booking In bookings
				If booking_Renamed.RoomId = Me.Id Then
					If booking_Renamed.From <= date_Renamed AndAlso booking_Renamed.To = date_Renamed Then
						status = RoomStatus.CheckedOut
						Exit For
					ElseIf booking_Renamed.From <= date_Renamed AndAlso booking_Renamed.To >= date_Renamed Then
						status = RoomStatus.Occupied
						Exit For
					Else
						If date_Renamed < booking_Renamed.From Then
							status = RoomStatus.Reserved
						End If
					End If
				End If
			Next booking_Renamed
			Return status
		End Function

		Public Function GetStatusByBooking(ByVal date_Renamed As Date, ByVal bookings As BindingList(Of Booking)) As RoomStatus
			For Each booking_Renamed As Booking In bookings
				If booking_Renamed.RoomId = Me.Id Then
					If date_Renamed >= booking_Renamed.From AndAlso date_Renamed <= booking_Renamed.To Then
						If booking_Renamed.Status = BookingStatus.Actual Then
							Return RoomStatus.Occupied
						ElseIf booking_Renamed.Status = BookingStatus.NoShow Then
							Return RoomStatus.Available
						ElseIf booking_Renamed.Status = BookingStatus.CheckedOut Then
							Return RoomStatus.CheckedOut
						ElseIf booking_Renamed.Status = BookingStatus.Reservation Then
							Return RoomStatus.Reserved
						End If
					End If
				End If
			Next booking_Renamed
			Return RoomStatus.Available
		End Function
	End Class

	Public Enum RoomPriority
		Low = 1
		Medium = 2
		High = 3
	End Enum

	Public Enum RoomStatus
		Reserved
		Occupied
		Available
		CheckedOut
	End Enum

	Public Enum RoomType
		[Single]
		[Double]
		Triple
		Family
	End Enum

	Public Enum HouseKeepingStatus
		Clean = 1
		NotClean = 2
		InProgress = 3
	End Enum
End Namespace