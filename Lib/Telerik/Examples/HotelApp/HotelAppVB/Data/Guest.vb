Imports System.ComponentModel
Imports System.Text

Namespace HotelApp
	Public Class Guest
		Implements System.ComponentModel.INotifyPropertyChanged
		Public Property Id() As String
			Get
				Return Me._id
			End Get
			Set(ByVal value As String)
				Me._id = value
				OnPropertyChanged("Id")
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

		Public Property Address() As String
			Get
				Return Me._address
			End Get
			Set(ByVal value As String)
				Me._address = value
				OnPropertyChanged("Address")
			End Set
		End Property

		Public Property City() As String
			Get
				Return Me._city
			End Get
			Set(ByVal value As String)
				Me._city = value
				OnPropertyChanged("City")
			End Set
		End Property

		Public Property Phone() As String
			Get
				Return Me._phone
			End Get
			Set(ByVal value As String)
				Me._phone = value
				OnPropertyChanged("Phone")
			End Set
		End Property

		Public Property CardDetails() As CreditCard
			Get
				Return Me._cardDetails
			End Get
			Set(ByVal value As CreditCard)
				Me._cardDetails = value
				OnPropertyChanged("CardDetails")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Private _id As String
		Private _name As String
		Private _address As String
		Private _city As String
		Private _phone As String
		Private _cardDetails As CreditCard

		Public Sub New()
		   Me._cardDetails = New CreditCard()
		End Sub

		Public Sub New(ByVal id As String, ByVal name As String, ByVal address As String, ByVal city As String, ByVal phone As String, ByVal cardDetails As CreditCard)
			Me.Id = id
			Me.Name = name
			Me.Address = address
			Me.City = city
			Me.Phone = phone
			Me.CardDetails = cardDetails
		End Sub
	End Class

	Public Class CreditCard
		Public Property CreditCardId() As String

		Public Property ExpiresOn() As Date

		Public Property CCV() As UInteger

		Public Sub New()
		End Sub

		Public Sub New(ByVal creditCardId As String, ByVal expiresOn As Date, ByVal ccv As UInteger)
			Me.CreditCardId = creditCardId
			Me.ExpiresOn = expiresOn
			Me.CCV = ccv
		End Sub
	End Class
End Namespace