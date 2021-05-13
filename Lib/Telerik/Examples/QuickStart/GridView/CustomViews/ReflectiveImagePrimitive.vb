Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.GridView.CustomViews
	Public Class ReflectiveImagePrimitive
		Inherits LightVisualElement
		#Region "Fields"

		Private imagePrimitive As ImagePrimitive
		Private reflectionPrimitive As ReflectionPrimitive

		#End Region

		#Region "Properties"

		Public Overrides Property Image() As Image
			Get
				Return Me.imagePrimitive.Image
			End Get
			Set(ByVal value As Image)
				If Me.imagePrimitive.Image IsNot value Then
					Me.imagePrimitive.Image = value
					If Me.Parent IsNot Nothing Then
						Me.Parent.Invalidate()
					End If
				End If
			End Set
		End Property

		#End Region

		#Region "Initialization"

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchVertically = False
			Me.StretchHorizontally = False
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.imagePrimitive = New ImagePrimitive()
			Me.Children.Add(Me.imagePrimitive)

			Me.reflectionPrimitive = New ReflectionPrimitive(Me.imagePrimitive)
			Me.reflectionPrimitive.ItemReflectionPercentage = 0.5
			Me.Children.Add(Me.reflectionPrimitive)
		End Sub

		#End Region

		#Region "Layout"

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			MyBase.MeasureOverride(availableSize)
			Return New SizeF(Me.imagePrimitive.DesiredSize.Width, Me.imagePrimitive.DesiredSize.Height * CSng(Me.reflectionPrimitive.ItemReflectionPercentage))
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			MyBase.ArrangeOverride(finalSize)

			Me.imagePrimitive.Arrange(New RectangleF(0, 0, finalSize.Width, finalSize.Height / CSng(Me.reflectionPrimitive.ItemReflectionPercentage)))
			Me.reflectionPrimitive.Arrange(New RectangleF(0, Me.imagePrimitive.DesiredSize.Height, finalSize.Width, Me.reflectionPrimitive.DesiredSize.Height / 3f))

			Return finalSize
		End Function

		#End Region
	End Class
End Namespace
