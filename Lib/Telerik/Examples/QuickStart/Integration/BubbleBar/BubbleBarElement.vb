Imports System.Text
Imports Telerik.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Namespace Telerik.Examples.WinControls.Integration.BubbleBar
	Public Class BubbleBarElement
		Inherits RadElement
		Private fill As FillPrimitive
		Private border As BorderPrimitive
		Private panel As StackLayoutPanel
'INSTANT VB NOTE: The variable items was renamed since Visual Basic does not allow class members with the same name:
		Private items_Renamed As RadItemOwnerCollection

		Public Sub New()
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.Shape = New RoundRectShape(12)

			Me.items_Renamed = New RadItemOwnerCollection()
			Me.items_Renamed.ItemTypes = New Type() { GetType(RadButtonElement) }
			AddHandler items_Renamed.ItemsChanged, AddressOf items_ItemsChanged
		End Sub

		Public ReadOnly Property Items() As RadItemOwnerCollection
			Get
				Return items_Renamed
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			fill = New FillPrimitive()
			fill.BackColor = Color.FromArgb(253, 253, 253)
			fill.BackColor2 = Color.FromArgb(112, 112, 112)
			fill.NumberOfColors = 2
			fill.GradientStyle = GradientStyles.Linear
			fill.GradientAngle = 90
			fill.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
			Me.Children.Add(fill)

			border = New BorderPrimitive()
			border.GradientStyle = GradientStyles.Solid
			border.ForeColor = Color.FromArgb(0, 0, 0)
			border.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize

			Me.Children.Add(border)

			panel = New StackLayoutPanel()
			panel.Orientation = Orientation.Horizontal
			'panel.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
			panel.Alignment = ContentAlignment.MiddleCenter
			panel.StretchHorizontally = False
			Me.Children.Add(panel)

			Me.items_Renamed.Owner = panel
		End Sub

		Private Sub items_ItemsChanged(ByVal changed As RadItemCollection, ByVal target As RadItem, ByVal operation As ItemsChangeOperation)
			If operation = ItemsChangeOperation.Inserted OrElse operation = ItemsChangeOperation.Set Then
				target.AddBehavior(New BubbleBarMouseOverBehavior())
			End If
		End Sub
	End Class
End Namespace
