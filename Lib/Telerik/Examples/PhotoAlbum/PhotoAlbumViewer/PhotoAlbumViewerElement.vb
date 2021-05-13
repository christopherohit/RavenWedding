Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace PhotoAlbumVB
   Public Class PhotoAlbumViewerElement
	Inherits RadItem
	Private arranged As Boolean = False
	Private m_items As RadItemOwnerCollection

	Private m_selectedIndex As Integer = -1

	'variables to store selected item's location parameters
	Private originalItemLocation As New Rectangle(Point.Empty, New Size(100, 100))
	Private originalItemZIndex As Integer = 0
	Private originalItemScale As SizeF
	Private originalItemAngleTransform As Single = 0F

	Private m_itemScaleFactor As Single = 0.2F

	'stores the original item size to be used as a reference when scaling up/down 
	Private m_originalItemSize As New Size(250, 150)

	Public Sub New()
	End Sub

	Protected Overrides Sub InitializeFields()
		MyBase.InitializeFields()

		Me.m_items = New RadItemOwnerCollection()
		Me.m_items.ItemTypes = New Type() {GetType(RadButtonElement)}
		AddHandler Me.m_items.ItemsChanged, AddressOf items_ItemsChanged
	End Sub

	Private Sub items_ItemsChanged(changed As RadItemCollection, target As RadItem, operation As ItemsChangeOperation)
		If operation = ItemsChangeOperation.Inserted OrElse operation = ItemsChangeOperation.[Set] Then
			target.AutoSize = False

			Dim button As RadButtonElement = TryCast(target, RadButtonElement)
			If button IsNot Nothing Then
				button.ShowBorder = False
				button.ButtonFillElement.Visibility = ElementVisibility.Hidden
				button.BorderElement.ZIndex = 1

				'Get item original size from the image if available
				If button.Image IsNot Nothing Then
					Me.m_originalItemSize = button.Image.Size
				End If

				Dim imagePrimitive As ImagePrimitive = DirectCast(button.Children(1).Children(0), ImagePrimitive)
				Me.CreatePrevNextButtons(imagePrimitive)
			End If
		End If

		Me.arranged = False
		Me.Invalidate()
	End Sub



	Private Sub CreatePrevNextButtons(imagePrimitive As ImagePrimitive)
		Dim btnPrev As RadButtonElement
		Dim btnNext As RadButtonElement

		btnPrev = New RadImageButtonElement()
		btnPrev.Image = My.Resources.PA_left_arr
		btnPrev.StretchHorizontally = False
		btnPrev.StretchVertically = False
		btnPrev.ShowBorder = False
		imagePrimitive.Children.Add(btnPrev)
		AddHandler btnPrev.Click, AddressOf btnPrev_Click
		btnPrev.Location = New Point(17, Me.m_originalItemSize.Height - 90)
		btnPrev.ScaleTransform = New SizeF(1F, 1F)
		btnPrev.Visibility = ElementVisibility.Hidden
		btnPrev.ButtonFillElement.Visibility = ElementVisibility.Hidden

		btnNext = New RadImageButtonElement()
		btnNext.Image = My.Resources.PA_right_arr
		btnNext.StretchVertically = False
		btnNext.StretchHorizontally = False
		btnNext.ShowBorder = False
		btnNext.ScaleTransform = New SizeF(1F, 1F)
		imagePrimitive.Children.Add(btnNext)
		AddHandler btnNext.Click, AddressOf btnNext_Click
		btnNext.Location = New Point(Me.m_originalItemSize.Width - 90, Me.m_originalItemSize.Height - 90)
		btnNext.Visibility = ElementVisibility.Hidden
		btnNext.ButtonFillElement.Visibility = ElementVisibility.Hidden
	End Sub

	Private Sub btnPrev_Click(sender As Object, e As EventArgs)
		Dim newIndex As Integer = Me.SelectedIndex - 1
		If newIndex < 0 Then
			newIndex = Me.Items.Count - 1
		End If

		Me.SelectedIndex = newIndex
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs)
		Dim newIndex As Integer = Me.SelectedIndex + 1
		If newIndex > Me.Items.Count - 1 Then
			newIndex = If(Me.Items.Count > 0, 0, -1)
		End If

		Me.SelectedIndex = newIndex
	End Sub

	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
	<Browsable(True), Category(RadDesignCategory.DataCategory)> _
	Public ReadOnly Property Items() As RadItemOwnerCollection
		Get
			Return Me.m_items
		End Get
	End Property

	Private Class CustomLayout
		Inherits LayoutPanel
		Public Sub New()
		End Sub
	End Class

	Protected Overrides Sub CreateChildElements()
		Me.Children.Add(New FillPrimitive())

		Dim panel As New CustomLayout()
		Me.Children.Add(panel)
		Me.Items.Owner = panel
	End Sub

	Private Const numFrames As Integer = 15
	Private Const frameInterval As Integer = 40

	Private Sub Rearrange()
		If Me.Size = Size.Empty Then
			Return
		End If


		Dim itemScaledSize As New Size(CInt(Me.OriginalItemSize.Width * ItemScaleFactor), CInt(Me.OriginalItemSize.Height * ItemScaleFactor))

		Dim rX As New Random(DateTime.Now.Second)
		Dim frontItemScaleFactor As Single = 0.55F
		Dim frontItemLocation As New Point(270, 180)
		Dim frontItemIndex As Integer = rX.[Next](Me.Items.Count - 1)

		Dim maxX As Integer = Math.Max(0, Me.Size.Width - itemScaledSize.Width)
		Dim maxY As Integer = Math.Max(0, Me.Size.Height - itemScaledSize.Height)

		For i As Integer = 0 To Me.Items.Count - 1
			Dim initX As Integer = 0
			Dim initY As Integer = 0
			If i Mod 2 = 0 Then
				initX = rX.[Next](Me.Size.Width)
			Else
				initY = rX.[Next](Me.Size.Height)
			End If

			System.Threading.Thread.Sleep(5)

			Dim item As RadItem = Me.Items(i)
			If i <> frontItemIndex Then
				Dim nextX As Integer = rX.[Next](maxX)
				Dim nextY As Integer = rX.[Next](maxY)

				If nextY > frontItemLocation.Y AndAlso nextY < frontItemLocation.Y + CInt(TryCast(m_items(frontItemIndex), PhotoElement).Image.Height * frontItemScaleFactor) Then
					Dim newX As Integer = rX.[Next](maxX - CInt(TryCast(m_items(frontItemIndex), PhotoElement).Image.Width * frontItemScaleFactor))
					If newX > frontItemLocation.X Then
						newX += CInt(TryCast(m_items(frontItemIndex), PhotoElement).Image.Width * frontItemScaleFactor)
					End If
					nextX = newX
				End If

				Dim setting As New AnimatedPropertySetting(RadElement.BoundsProperty, New Rectangle(New Point(initX, initY), OriginalItemSize), New Rectangle(New Point(nextX, nextY), OriginalItemSize), numFrames, frameInterval)

				setting.ApplyEasingType = RadEasingType.OutExponential
				setting.ApplyValue(item)
				setting.RemoveAfterApply = True
				item.ZIndex = rX.[Next](Me.Items.Count)


				Me.SetStyleValue(item, RadElement.AngleTransformProperty, CSng(rX.[Next](90)) - 45)
				Me.SetStyleValue(item, RadElement.ScaleTransformProperty, New SizeF(m_itemScaleFactor, m_itemScaleFactor))
			Else
				Me.SetStyleValue(item, RadElement.BoundsProperty, New Rectangle(frontItemLocation, Me.OriginalItemSize))
				Me.SetStyleValue(item, RadElement.AngleTransformProperty, 0F)
				Me.SetStyleValue(item, RadElement.ScaleTransformProperty, New SizeF(frontItemScaleFactor, frontItemScaleFactor))
				item.BringToFront()
			End If
		Next

		arranged = True
	End Sub

	Private Sub SetStyleValue(element As RadElement, [property] As RadProperty, value As Object)
		Dim setting As New PropertySetting([property], value)
		setting.ApplyValue(element)
	End Sub

	<DefaultValue(-1)> _
	Public Property SelectedIndex() As Integer
		Get
			Return m_selectedIndex
		End Get
		Set
			If m_selectedIndex < -1 OrElse m_selectedIndex >= Me.Items.Count Then
				Throw New IndexOutOfRangeException()
			End If

			If Me.m_selectedIndex <> value Then
				If Me.m_selectedIndex >= 0 Then
					Me.AnimateSelectedItem(False)
				End If

				Me.m_selectedIndex = value

				If Me.m_selectedIndex >= 0 Then
					Me.AnimateSelectedItem(True)
				End If
			End If
		End Set
	End Property

	<DefaultValue(0.5F)> _
	Public Property ItemScaleFactor() As Single
		Get
			Return m_itemScaleFactor
		End Get
		Set
			m_itemScaleFactor = value
		End Set
	End Property

	<DefaultValue("250, 150")> _
	Public Property OriginalItemSize() As Size
		Get
			Return m_originalItemSize
		End Get
		Set
			m_originalItemSize = value
		End Set
	End Property

	Private Sub AnimateSelectedItem(zoomIn As Boolean)
		Dim item As RadItem = Me.Items(Me.m_selectedIndex)

		Dim itemZoomFactor As Single = Math.Min(Me.Size.Width * 0.9F / Me.m_originalItemSize.Width, Me.Size.Height * 0.9F / Me.m_originalItemSize.Height)

		Dim zoomedItemSize As New Size(CInt(m_originalItemSize.Width * itemZoomFactor), CInt(m_originalItemSize.Height * itemZoomFactor))

		Dim zoomedItemLocation As New Point(CInt(Me.Size.Width / 2F - zoomedItemSize.Width / 2F), CInt(Me.Size.Height / 2F - zoomedItemSize.Height / 2F))

            Dim setting1 As New AnimatedPropertySetting(RadElement.BoundsProperty, Nothing, New Rectangle(zoomedItemLocation, OriginalItemSize), numFrames, frameInterval)

            Dim setting2 As New AnimatedPropertySetting(RadElement.ScaleTransformProperty, Nothing, New SizeF(itemZoomFactor, itemZoomFactor), numFrames, frameInterval)

            Dim setting3 As New AnimatedPropertySetting(RadElement.AngleTransformProperty, Nothing, 0.0F, 12, frameInterval)

		If zoomIn Then
			item.BringToFront()

			originalItemLocation = item.Bounds
			originalItemZIndex = item.ZIndex
			originalItemAngleTransform = item.AngleTransform
			originalItemScale = item.ScaleTransform
			'item.ZIndex = this.Items.Count + 1;

			Dim button As RadButtonItem = TryCast(item, RadButtonItem)
			If button IsNot Nothing Then
				Dim imagePrimitive As ImagePrimitive = DirectCast(button.Children(1).Children(0), ImagePrimitive)

				imagePrimitive.Children(0).Visibility = ElementVisibility.Visible
				imagePrimitive.Children(1).Visibility = ElementVisibility.Visible
			End If
		Else
			setting1.EndValue = originalItemLocation
			setting2.EndValue = originalItemScale
			setting3.EndValue = originalItemAngleTransform

			setting1.RemoveAfterApply = True
			setting2.RemoveAfterApply = True
			setting3.RemoveAfterApply = True

			'originalItemZIndex = item.ZIndex;

			Dim button As RadButtonItem = TryCast(item, RadButtonItem)
			If button IsNot Nothing Then
				Dim imagePrimitive As ImagePrimitive = DirectCast(button.Children(1).Children(0), ImagePrimitive)

				imagePrimitive.Children(0).Visibility = ElementVisibility.Hidden
				imagePrimitive.Children(1).Visibility = ElementVisibility.Hidden

				'item.ZIndex = originalItemZIndex;
			End If
		End If

		setting1.ApplyEasingType = RadEasingType.OutExponential
		setting2.ApplyEasingType = RadEasingType.OutExponential
		setting3.ApplyEasingType = RadEasingType.OutExponential

		setting1.ApplyValue(item)
		setting2.ApplyValue(item)
		setting3.ApplyValue(item)
	End Sub

	Protected Overrides Sub OnBubbleEvent(sender As RadElement, args As RoutedEventArgs)
		If args.RoutedEvent Is RadElement.MouseClickedEvent Then
			Dim item As RadItem = TryCast(sender, RadItem)
			If item IsNot Nothing Then
				item.BringToFront()
			End If
		ElseIf args.RoutedEvent Is RadElement.MouseDoubleClickedEvent Then
			Dim newSelectedIndex As Integer = -1
			If TypeOf sender Is RadItem Then
				newSelectedIndex = Me.Items.IndexOf(TryCast(sender, RadItem))
			End If

			If newSelectedIndex >= 0 Then
				If newSelectedIndex <> Me.SelectedIndex Then
					Me.SelectedIndex = newSelectedIndex
				Else
					Me.SelectedIndex = -1
				End If
			End If
		ElseIf args.RoutedEvent Is RadElement.MouseDownEvent Then
			If Me.m_items.Contains(TryCast(sender, RadButtonElement)) Then
				Dim e As MouseEventArgs = TryCast(args.OriginalEventArgs, MouseEventArgs)
				If e IsNot Nothing Then
					If e.Button = MouseButtons.Left Then
						Me.dragItem = TryCast(sender, RadButtonElement)

						Me.BeginDrag(e)
					End If
				End If
			End If
		ElseIf args.RoutedEvent Is RadElement.MouseUpEvent Then
			If Me.ElementTree IsNot Nothing Then
				Dim e As MouseEventArgs = TryCast(args.OriginalEventArgs, MouseEventArgs)
				If e IsNot Nothing AndAlso e.Button = MouseButtons.Left Then
					Me.dragItem = Nothing
					EndDrag()
				End If
			End If
		End If
	End Sub



	Protected Overrides Sub PaintChildren(graphics As Telerik.WinControls.Paint.IGraphics, clipRectange As Rectangle, angle As Single, scale As SizeF, useRelativeTransformation As Boolean)
		'use paint as a trigger for item rearrangement
		If Not arranged Then
			Rearrange()
		End If

		MyBase.PaintChildren(graphics, clipRectange, angle, scale, useRelativeTransformation)
	End Sub

	#Region "Drag&Drop helpers"

	Private isDragging As Boolean = False
	Private currentX As Integer
	Private currentY As Integer
	Private dragItem As RadButtonElement = Nothing
	Private m_isRealDrag As Boolean = False
	Private point As Point = Point.Empty

	Protected Overridable Function IsRealDrag(mousePositionX As Integer, mousePositionY As Integer) As Boolean
		If Not Me.m_isRealDrag Then
			Me.m_isRealDrag = (Math.Abs(CInt(mousePositionX - dragItem.Location.X - Me.currentX)) >= SystemInformation.DragSize.Width) OrElse (Math.Abs(CInt(mousePositionY - dragItem.Location.Y - Me.currentY)) >= SystemInformation.DragSize.Height)
		End If
		Return Me.m_isRealDrag
	End Function

	Private Sub EndDrag()
		Me.Capture = False
		isDragging = False
		m_isRealDrag = False
	End Sub

	Private Sub BeginDrag(e As MouseEventArgs)
		If Not IsRealDrag(e.X, e.Y) Then
			Return
		End If
		dragItem.BringToFront()
		Me.Capture = True
		Me.isDragging = True
		Me.currentX = e.X - dragItem.Location.X
		Me.currentY = e.Y - dragItem.Location.Y
	End Sub

	Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
		MyBase.OnMouseMove(e)

		If isDragging Then

			dragItem.Location = New Point((e.X - currentX), (e.Y - currentY))
		End If
	End Sub

	#End Region
End Class
End Namespace
