Imports HotelApp.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class CustomResourceHeaderCell
		Inherits SchedulerResourceHeaderCellElement
		Public Sub New(ByVal scheduler As RadScheduler, ByVal view As SchedulerView)
			MyBase.New(scheduler, view)
		End Sub

        Private panel As StackLayoutElement
        Private roomHeader As LightVisualElement
        Private roomType As LightVisualElement

		Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            panel = New StackLayoutElement()
            roomHeader = New LightVisualElement()
            roomType = New LightVisualElement()
			Me.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
			Me.BorderColor = Color.FromArgb(191, 198, 209)
			panel.Orientation = Orientation.Vertical
			panel.StretchHorizontally = True
			panel.StretchVertically = True
			roomType.TextImageRelation = TextImageRelation.ImageAboveText
			panel.Children.Add(roomHeader)
			roomHeader.StretchVertically = False
			roomHeader.MinSize = New Size(0, 40)
			roomType.StretchHorizontally = True
			roomType.StretchVertically = True
			panel.Children.Add(roomType)
			Me.Children.Add(panel)
			Me.DrawText = False

			roomType.CustomFont = Utils.MainFont
			roomType.CustomFontSize = 9f
			roomType.ForeColor = Color.FromArgb(102, 102, 102)
			roomType.EnableElementShadow = False
			roomHeader.EnableElementShadow=False
			panel.EnableElementShadow = False
		End Sub

		Public Overrides Property Text() As String
			Get
				Return MyBase.Text
			End Get
			Set(ByVal value As String)
				MyBase.Text = value
                roomHeader.Text = Me.ResourceId.KeyValue.ToString() & ""
				Dim form As HotelAppForm = TryCast(Me.Scheduler.FindForm(), HotelAppForm)
				If form IsNot Nothing AndAlso Me.ResourceId IsNot Nothing Then
					Dim room_Renamed As Room = Utils.GetRoomById(Integer.Parse(Me.ResourceId.ToString()), form.Rooms)
					roomType.Text = Utils.GetRoomType(room_Renamed.Type)
					roomType.Image = Utils.GetImageByRoomType(room_Renamed.Type)
				End If
			End Set
		End Property

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(SchedulerResourceHeaderCellElement)
			End Get
		End Property
	End Class

	Public Class MyElementProvider
		Inherits SchedulerElementProvider
		Public Sub New(ByVal scheduler As RadScheduler)
			MyBase.New(scheduler)
		End Sub

        Protected Overrides Function CreateElement(Of T As SchedulerVisualElement)(ByVal view As SchedulerView, ByVal context As Object) As T
            If GetType(T) Is GetType(SchedulerResourceHeaderCellElement) Then
                Return TryCast(New CustomResourceHeaderCell(Me.Scheduler, view), T)
            End If

            Return MyBase.CreateElement(Of T)(view, context)
        End Function
	End Class
End Namespace