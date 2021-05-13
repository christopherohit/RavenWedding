Imports HotelApp.Data
Imports System.ComponentModel
Imports System.Text

Namespace HotelApp
	Public Class Booking
		Implements System.ComponentModel.INotifyPropertyChanged
		Public Sub New()
			Me.Guests = New List(Of Guest)()
		End Sub

		Public Property Id() As UInteger
			Get
				Return Me._id
			End Get
			Set(ByVal value As UInteger)
				Me._id = value
				OnPropertyChanged("Id")
			End Set
		End Property

		Public Property Guests() As List(Of Guest)
			Get
				Return Me._guests
			End Get
			Set(ByVal value As List(Of Guest))
				Me._guests = value
				OnPropertyChanged("Guests")
			End Set
		End Property

		Public Property Name() As String
			Get
				Return Me._name
			End Get
			Set(ByVal value As String)
				Me._name = value
				OnPropertyChanged("Name")
			End Set
		End Property

		Public Property RoomId() As Integer
			Get
				Return Me._roomId
			End Get
			Set(ByVal value As Integer)
				Me._roomId = value
				OnPropertyChanged("RoomId")
			End Set
		End Property

		Public Property [From]() As Date
			Get
				Return Me._from
			End Get
			Set(ByVal value As Date)
				Me._from = value
				OnPropertyChanged("From")
			End Set
		End Property

		Public Property [To]() As Date
			Get
				Return Me._to
			End Get
			Set(ByVal value As Date)
				Me._to = value
				OnPropertyChanged("To")
			End Set
		End Property

		Public Property Price() As Decimal
			Get
				Return Me._pricePerDay * CDec(Me.To.Subtract(Me.From).TotalDays)
			End Get
			Set(ByVal value As Decimal)
				Me._price = value
				OnPropertyChanged("Price")
			End Set
		End Property

		Public Property PricePerDay() As Decimal
			Get
				Return Me._pricePerDay
			End Get
			Set(ByVal value As Decimal)
				Me._pricePerDay = value
				OnPropertyChanged("PricePerDay")
			End Set
		End Property

		Public Property Status() As BookingStatus
			Get
				Return Me._status
			End Get
			Set(ByVal value As BookingStatus)
				Me._status = value
				OnPropertyChanged("Status")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Private _id As UInteger
		Private _guests As List(Of Guest)
		Private _name As String
		Private _roomId As Integer
		Private _from As Date
		Private _to As Date
		Private _price As Decimal
		Private _pricePerDay As Decimal
		Private _status As BookingStatus

		Public ReadOnly Property FullInfo() As String
			Get
				Return "Room#" & Me.RoomId & " " & Me.Name & " " & Me.From.ToShortDateString() & "-" & Me.To.ToShortDateString()
			End Get
		End Property

        Public Sub New(ByVal id As UInteger, ByVal guest As Guest, ByVal roomId As Integer, ByVal [from] As Date, ByVal [to] As Date, ByVal pricePerDay As Decimal, ByVal status As BookingStatus)
            Me.Id = id
            Me.Guests = New List(Of Guest)() From {guest}
            Me.Name = guest.Name
            Me.RoomId = roomId
            Me.From = [from]
            Me.To = [to]
            Me.PricePerDay = pricePerDay
            Me.Status = status
        End Sub

		Public Function GetBookingStatusAtDate(ByVal date_Renamed As Date, ByVal booking_Renamed As Booking) As BookingStatus
			Dim status As BookingStatus = BookingStatus.Reservation

			If booking_Renamed.Status = BookingStatus.Cancelled OrElse booking_Renamed.Status = BookingStatus.NoShow Then
				Return booking_Renamed.Status
			End If

			If booking_Renamed.From <= date_Renamed AndAlso booking_Renamed.To = date_Renamed AndAlso Me.Status <> BookingStatus.Actual Then
				status = BookingStatus.CheckedOut
			ElseIf booking_Renamed.From <= date_Renamed AndAlso booking_Renamed.To >= date_Renamed AndAlso Me.Status <> BookingStatus.Reservation Then
				status = BookingStatus.Actual
			Else
				If date_Renamed < booking_Renamed.From Then
					status = BookingStatus.Reservation
				End If
			End If

			Return status
		End Function
	End Class

	Public Enum BookingStatus
		Reservation = 1
		Actual = 2
		Cancelled = 3
		CheckedOut = 4
		NoShow = 5
	End Enum
End Namespace