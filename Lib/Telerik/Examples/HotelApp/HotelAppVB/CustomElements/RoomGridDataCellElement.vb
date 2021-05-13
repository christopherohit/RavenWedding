Imports HotelApp.Data
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class RoomGridDataCellElement
        Inherits GridDataCellElement

        Private stack As StackLayoutElement
        Private roomIdElement As LightVisualElement
        Private roomTypeElement As LightVisualElement

        Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
            MyBase.New(column, row)
        End Sub

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(GridDataCellElement)
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            stack = New StackLayoutElement()
            roomIdElement = New LightVisualElement()
            roomTypeElement = New LightVisualElement()
            stack.Orientation = Orientation.Horizontal
            stack.StretchHorizontally = True
            stack.StretchVertically = True
            roomIdElement.Padding = New Padding(10, 0, 0, 0)
            roomIdElement.TextImageRelation = TextImageRelation.ImageBeforeText
            roomIdElement.ImageAlignment = ContentAlignment.MiddleLeft
            roomIdElement.TextAlignment = ContentAlignment.MiddleLeft
            roomIdElement.MaxSize = New Size(80, 100)
            roomIdElement.MinSize = New Size(80, 0)
            roomIdElement.StretchHorizontally = False
            roomTypeElement.Padding = New Padding(0, 0, 15, 0)
            roomTypeElement.StretchHorizontally = True
            roomTypeElement.TextAlignment = ContentAlignment.MiddleRight
            stack.Children.Add(roomIdElement)
            stack.Children.Add(roomTypeElement)

            Me.Children.Add(stack)
        End Sub

		Protected Overrides Sub SetContentCore(ByVal value As Object)
			MyBase.SetContentCore(value)
			Me.DrawText = False
			Dim booking_Renamed As Booking = TryCast(Me.RowInfo.DataBoundItem, Booking)
			If booking_Renamed IsNot Nothing Then
				Dim room_Renamed As Room = Utils.GetRoomById(booking_Renamed.RoomId, TryCast(Me.RowInfo.ViewTemplate.Tag, BindingList(Of Room)))
				roomIdElement.Image = Utils.GetRoomIconByType(room_Renamed.Type)
				roomIdElement.Text = booking_Renamed.RoomId.ToString()
				roomTypeElement.Text = Utils.GetRoomType(room_Renamed.Type).ToLower()
			End If
		End Sub

		Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
			Return data.Name = "RoomId" AndAlso TypeOf context Is GridViewDataRowInfo
		End Function
	End Class

End Namespace