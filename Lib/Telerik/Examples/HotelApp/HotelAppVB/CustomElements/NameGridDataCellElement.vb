Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class NameGridDataCellElement
        Inherits GridDataCellElement

        Private stack As StackLayoutElement
        Private nameElement As LightVisualElement
        Private durationElement As LightVisualElement

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
            nameElement = New LightVisualElement()
            durationElement = New LightVisualElement()
            stack.Orientation = Orientation.Horizontal
            stack.StretchHorizontally = True
            stack.StretchVertically = True
            nameElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            nameElement.MaxSize = New Size(100, 100)
            nameElement.MinSize = New Size(100, 0)
            nameElement.StretchHorizontally = False
            durationElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            durationElement.ForeColor = Color.Gray
            stack.Children.Add(nameElement)
            stack.Children.Add(durationElement)

            Me.Children.Add(stack)
        End Sub

		Protected Overrides Sub SetContentCore(ByVal value As Object)
			MyBase.SetContentCore(value)
			Me.DrawText = False
			Dim booking_Renamed As Booking = TryCast(Me.RowInfo.DataBoundItem, Booking)
			If booking_Renamed IsNot Nothing Then
				nameElement.Text = booking_Renamed.Name
				durationElement.Text = (booking_Renamed.To - booking_Renamed.From).Days.ToString()
				If durationElement.Text = "1" Then
					durationElement.Text = "1 day"
				Else
					durationElement.Text &= " days"
				End If
			End If
		End Sub

		Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
			Return data.Name = "Name" AndAlso TypeOf context Is GridViewDataRowInfo
		End Function
	End Class

End Namespace