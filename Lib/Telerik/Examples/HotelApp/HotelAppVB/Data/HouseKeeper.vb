Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace HotelApp.Data
	Public Class HouseKeeper
		Public Property Id() As Integer

		Public Property Name() As String

		Public Property Photo() As Bitmap

		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal img As Bitmap)
			Me.Id = id
			Me.Name = name
			Me.Photo = img
		End Sub
	End Class
End Namespace