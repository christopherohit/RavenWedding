Imports System.Text
Imports Telerik.WinControls
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.LiveData
	<ToolboxItem(True)>
	Friend Class ExampleCustomShapeControl
		Inherits RadControl
'INSTANT VB NOTE: The variable element was renamed since Visual Basic does not allow class members with the same name:
		Private element_Renamed As ExampleCustomShapeElement

		Public ReadOnly Property Element() As ExampleCustomShapeElement
			Get
				Return element_Renamed
			End Get
		End Property

		Public Property LeftText() As String
			Get
				Return Me.element_Renamed.LeftText
			End Get
			Set(ByVal value As String)
				Me.element_Renamed.LeftText = value
			End Set
		End Property

		Public Property RightText() As String
			Get
				Return Me.element_Renamed.RightText
			End Get
			Set(ByVal value As String)
				Me.element_Renamed.RightText = value
			End Set
		End Property

		Public Sub New()

		End Sub

		Protected Overrides ReadOnly Property DefaultSize() As Size
			Get
				Return New Size(200, 30)
			End Get
		End Property

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Me.element_Renamed = New ExampleCustomShapeElement()
			Me.RootElement.Children.Add(element_Renamed)
			MyBase.CreateChildItems(parent)
		End Sub
	End Class
End Namespace
