Imports System.Text
Imports System.Reflection
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.TreeView.ManipulateData.Editing
	Public Class PropertyHelper
		Private sourceObject As Object
		Private propertyInfo As PropertyInfo

		Public Sub New(ByVal sourceObject As Object, ByVal propertyName As String)
			Me.sourceObject = sourceObject
			propertyInfo = sourceObject.GetType().GetProperty(propertyName)
		End Sub

		Public Property Value() As Object
			Get
				Return propertyInfo.GetValue(sourceObject, New Object() { })
			End Get
			Set(ByVal value As Object)
				propertyInfo.SetValue(sourceObject, value, New Object() { })
			End Set
		End Property

		Public ReadOnly Property ValueType() As Type
			Get
				Return propertyInfo.PropertyType
			End Get
		End Property

		Public Overrides Function ToString() As String
			Dim value As Object = Me.Value
			If value IsNot Nothing Then
				If value.GetType() Is GetType(Color) Then
					Return (CType(value, Color)).Name
				ElseIf value.GetType() Is GetType(RoundRectShape) Then
					Dim shape As RoundRectShape = CType(value, RoundRectShape)
					Return shape.Radius.ToString()
				End If
				Return value.ToString()
			End If
			Return ""
		End Function
	End Class
End Namespace
