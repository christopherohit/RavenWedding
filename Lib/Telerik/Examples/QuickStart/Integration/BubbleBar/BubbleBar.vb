Imports System.Text
Imports Telerik.WinControls
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.Integration.BubbleBar
	Public Class BubbleBar
		Inherits RadControl
'INSTANT VB NOTE: The variable element was renamed since Visual Basic does not allow class members with the same name:
		Private element_Renamed As BubbleBarElement

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Element() As BubbleBarElement
			Get
				Return Me.element_Renamed
			End Get
		End Property

		<RadEditItemsAction, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Items() As RadItemOwnerCollection
			Get
				Return Me.element_Renamed.Items
			End Get
		End Property

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Me.element_Renamed = New BubbleBarElement()
			Me.element_Renamed.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
			parent.Children.Add(Me.element_Renamed)
		End Sub
	End Class
End Namespace
