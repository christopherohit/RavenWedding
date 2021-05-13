Imports System.ComponentModel
Imports System.Linq

Namespace Telerik.Examples.WinControls.WordsProcessing.WordConvertion
    Public Class Product
        Implements INotifyPropertyChanged
        Private id_Renamed As Integer
        Private name_Renamed As String
        Private unitPrice_Renamed As Double
        Private quantity_Renamed As Integer
        Private date_Renamed As Date
        Private subTotal_Renamed As Double

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal unitPrice As Double, ByVal quantity As Integer, ByVal [date] As Date)
            Me.ID = id
            Me.Name = name
            Me.UnitPrice = unitPrice
            Me.Quantity = quantity
            Me.Date = [date]
            Me.SubTotal = Me.quantity_Renamed * Me.unitPrice_Renamed
        End Sub

        Public Property ID() As Integer
            Get
                Return Me.id_Renamed
            End Get
            Set(ByVal value As Integer)
                If Me.id_Renamed <> value Then
                    Me.id_Renamed = value
                    Me.OnPropertyChanged("ID")
                End If
            End Set
        End Property

        Public Property Name() As String
            Get
                Return Me.name_Renamed
            End Get
            Set(ByVal value As String)
                If Me.name_Renamed <> value Then
                    Me.name_Renamed = value
                    Me.OnPropertyChanged("Name")
                End If
            End Set
        End Property

        Public Property UnitPrice() As Double
            Get
                Return Me.unitPrice_Renamed
            End Get
            Set(ByVal value As Double)
                If Me.unitPrice_Renamed <> value Then
                    Me.unitPrice_Renamed = value
                    Me.OnPropertyChanged("UnitPrice")
                End If
            End Set
        End Property

        Public Property Quantity() As Integer
            Get
                Return Me.quantity_Renamed
            End Get
            Set(ByVal value As Integer)
                If Me.quantity_Renamed <> value Then
                    Me.quantity_Renamed = value
                    Me.OnPropertyChanged("Quantity")
                End If
            End Set
        End Property

        Public Property [Date]() As Date
            Get
                Return Me.date_Renamed
            End Get
            Set(ByVal value As Date)
                If Me.date_Renamed <> value Then
                    Me.date_Renamed = value
                    Me.OnPropertyChanged("Date")
                End If
            End Set
        End Property

        Public Property SubTotal() As Double
            Get
                Return Me.subTotal_Renamed
            End Get
            Set(ByVal value As Double)
                If Me.subTotal_Renamed <> value Then
                    Me.subTotal_Renamed = value
                    Me.OnPropertyChanged("SubTotal")
                End If
            End Set
        End Property

#Region "INotifyPropertyChanged Members"

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region
    End Class

    Public Class Products
        Private Shared ReadOnly names() As String = {"Côte de Blaye", "Boston Crab Meat", "Singaporean Hokkien Fried Mee", "Gula Malacca", "Rogede sild", "Spegesild", "Zaanse koeken", "Chocolade", "Maxilaku", "Valkoinen suklaa"}

        Private Shared ReadOnly prizes() As Double = {23.25, 9.0, 45.6, 32.0, 14.0, 19.0, 263.5, 18.4, 3.0, 14.0}

        Private Shared ReadOnly dates() As Date = {New Date(2007, 5, 10), New Date(2008, 9, 13), New Date(2008, 2, 22), New Date(2009, 1, 2), New Date(2007, 4, 13), New Date(2008, 5, 12), New Date(2008, 1, 19), New Date(2008, 8, 26), New Date(2008, 7, 31), New Date(2007, 7, 16)}


        Public Function GetData(ByVal itemCount As Integer) As IEnumerable(Of Product)
            Dim rnd As New Random()

            Return From i In Enumerable.Range(1, itemCount)
                   Select New Product(i, names(rnd.Next(9)), prizes(rnd.Next(9)), rnd.Next(1, 9), dates(rnd.Next(9)))
        End Function
    End Class
End Namespace
