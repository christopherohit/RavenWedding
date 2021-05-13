Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.Integration.Magnifier
	Public Class MagnifierElement
		Inherits RadScrollViewer
'INSTANT VB NOTE: The variable layout was renamed since Visual Basic does not allow class members with the same name:
		Private layout_Renamed As MagnifierLayout
'INSTANT VB NOTE: The variable items was renamed since Visual Basic does not allow class members with the same name:
		Private items_Renamed As RadItemOwnerCollection

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Layout() As MagnifierLayout
			Get
				Return layout_Renamed
			End Get
		End Property

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.items_Renamed = New RadItemOwnerCollection()
			Me.items_Renamed.ItemTypes = New Type() { GetType(RadButtonElement) }
		End Sub

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Items() As RadItemOwnerCollection
			Get
				Return items_Renamed
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.layout_Renamed = New MagnifierLayout()
			Me.Viewport = layout_Renamed
			Me.items_Renamed.Owner = layout_Renamed

			Me.ShowBorder = False
			Me.ShowFill = False

		End Sub
	End Class
End Namespace
