Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports System.Collections
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.DragAndDrop
	Public Class RadDragEventArgs
		Inherits CancelEventArgs
'INSTANT VB NOTE: The variable item was renamed since Visual Basic does not allow class members with the same name:
		Private ReadOnly item_Renamed As RadListDataItem
'INSTANT VB NOTE: The variable draggedItem was renamed since Visual Basic does not allow class members with the same name:
		Private ReadOnly draggedItem_Renamed As RadListDataItem

		Public Sub New(ByVal draggedItem As RadListDataItem)
			Me.draggedItem_Renamed = draggedItem
		End Sub

		Public Sub New(ByVal item As RadListDataItem, ByVal draggedItem As RadListDataItem)
			Me.item_Renamed = item
			Me.draggedItem_Renamed = draggedItem
		End Sub

		Public ReadOnly Property Item() As RadListDataItem
			Get
				Return item_Renamed
			End Get
		End Property

		Public ReadOnly Property DraggedItem() As RadListDataItem
			Get
				Return draggedItem_Renamed
			End Get
		End Property
	End Class

	Public Class DragCancelEventArgs
		Inherits CancelEventArgs
'INSTANT VB NOTE: The variable item was renamed since Visual Basic does not allow class members with the same name:
		Private ReadOnly item_Renamed As RadListDataItem
'INSTANT VB NOTE: The variable replacedItem was renamed since Visual Basic does not allow class members with the same name:
		Private ReadOnly replacedItem_Renamed As RadListDataItem

		Public Sub New(ByVal item As RadListDataItem, ByVal replacedItem As RadListDataItem)
			Me.item_Renamed = item
			Me.replacedItem_Renamed = replacedItem
		End Sub

		Public ReadOnly Property ReplacedItem() As RadListDataItem
			Get
				Return replacedItem_Renamed
			End Get
		End Property

		Public ReadOnly Property Item() As RadListDataItem
			Get
				Return item_Renamed
			End Get
		End Property
	End Class

	Public Class RadItemDragDropManager
		Implements IDisposable
		Private feedBackForm As FeedBackForm
'INSTANT VB NOTE: The variable allowDragDrop was renamed since Visual Basic does not allow class members with the same name:
		Private allowDragDrop_Renamed As Boolean = True
'INSTANT VB NOTE: The variable items was renamed since Visual Basic does not allow class members with the same name:
		Private items_Renamed As ICollection(Of RadListDataItem)
		Private items2 As ICollection(Of RadListDataItem)
		Private outlineForm As Form
		Private draggedItem As RadListDataItem
		Private sourceComponentElementTree As ComponentThemableElementTree
		Private targetComponentElementTree As ComponentThemableElementTree
'INSTANT VB NOTE: The variable isRealDrag was renamed since Visual Basic does not allow class members with the same name:
		Private isRealDrag_Renamed As Boolean
'INSTANT VB NOTE: The variable dragging was renamed since Visual Basic does not allow class members with the same name:
		Private dragging_Renamed As Boolean
		Private replacedItem As RadListDataItem
		Private initialMousePosition As Point
		Private control As RadControl
		Private control2 As RadControl
		Private sourceListBox As RadListControl
		Private targetListBox As RadListControl

		<DllImport("user32.dll", CharSet := CharSet.Auto, ExactSpelling := True)> _
		Public Shared Function ShowWindow(ByVal hWnd As HandleRef, ByVal nCmdShow As Integer) As Boolean
		End Function

		Public Sub New(ByVal control As RadControl, ByVal control2 As RadControl)
			Me.control = control
			AddHandler control.MouseMove, AddressOf Control_MouseMove
			AddHandler control.MouseUp, AddressOf Control_MouseUp

			Me.control2 = control2
			AddHandler control2.MouseMove, AddressOf Control_MouseMove
			AddHandler control2.MouseUp, AddressOf Control_MouseUp
		End Sub

		Public Sub New(ByVal control As RadControl, ByVal items As ICollection(Of RadListDataItem), ByVal control2 As RadControl, ByVal items2 As ICollection(Of RadListDataItem))
			Me.New(control, control2)
			Me.items_Renamed = items
			Me.items2 = items2
		End Sub

		Private Sub InitializeDragOperation(ByVal sender As Object, ByVal e As MouseEventArgs)
			sourceListBox = CType(sender, RadListControl)

			sourceComponentElementTree = sourceListBox.ElementTree

			If sourceComponentElementTree.RootElement.ElementTree IsNot Nothing AndAlso Me.AllowDragDrop Then
				Dim elementAtPoint As RadElement = sourceComponentElementTree.GetElementAtPoint(e.Location)

				If TypeOf elementAtPoint Is RadListVisualItem Then
					If e.Button = MouseButtons.Left Then
						sourceComponentElementTree.RootElement.ElementTree.Control.Capture = True

						BeginDrag(e)
					End If
				End If
			End If
		End Sub

		Private Sub Control_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Not Me.dragging_Renamed Then
				Return
			End If

			If targetListBox IsNot Nothing Then
				targetComponentElementTree = targetListBox.ElementTree
				If targetComponentElementTree.RootElement.ElementTree IsNot Nothing AndAlso Me.AllowDragDrop Then
					targetComponentElementTree.RootElement.ElementTree.Control.Capture = False
					If e.Button = MouseButtons.Left Then
						If Me.outlineForm IsNot Nothing Then
							Me.outlineForm.Hide()
						End If
						If Me.feedBackForm IsNot Nothing Then
							Me.feedBackForm.Hide()
						End If
						EndDrag(e)
					End If
				End If
			End If
			If Me.outlineForm IsNot Nothing Then
				Me.outlineForm.Hide()
				Me.outlineForm.Dispose()
				Me.outlineForm = Nothing
				Me.draggedItem = Nothing
				Me.replacedItem = Nothing
				Me.dragging_Renamed = False
				Me.isRealDrag_Renamed = False
			End If
			If Me.feedBackForm IsNot Nothing Then
				Me.feedBackForm.Hide()
				Me.feedBackForm.Dispose()
				Me.feedBackForm = Nothing
				Me.dragging_Renamed = False
				Me.isRealDrag_Renamed = False
			End If
			sourceListBox.FindForm().Cursor = Cursors.Arrow

		End Sub

		Private Sub SetOutLineForm(ByVal e As MouseEventArgs)
			If Me.draggedItem IsNot Nothing Then
				If (Me.AllowDragDrop) AndAlso (Me.isRealDrag_Renamed) AndAlso (e.Button = MouseButtons.Left) Then
					If Me.outlineForm IsNot Nothing Then
						If Not Me.outlineForm.Visible Then
							Dim handleRef As New HandleRef(Me.outlineForm, Me.outlineForm.Handle)
							ShowWindow(handleRef, 8)
						End If
						Me.outlineForm.Location = New Point(Cursor.Position.X + 2, Cursor.Position.Y + 2)

					End If
				End If
			End If
		End Sub

		Private Sub RefreshItemsAfterDragDrop(ByVal e As MouseEventArgs)
			If Me.draggedItem Is Me.replacedItem Then
				Return
			End If

			Dim args As New DragCancelEventArgs(Me.draggedItem, Me.replacedItem)

			If args.Cancel Then
				Me.draggedItem = Nothing
				Me.replacedItem = Nothing
				Return
			End If

			If replacedItem IsNot Nothing Then
				Dim replacedItemIndex As Integer = targetListBox.Items.IndexOf(Me.replacedItem)
				Dim draggedItemIndex As Integer = sourceListBox.Items.IndexOf(Me.draggedItem)
				Dim UpperBound As Integer = replacedItem.VisualItem.Bounds.Height * replacedItemIndex
				Dim MiddleBound As Integer = UpperBound + replacedItem.VisualItem.Bounds.Height \ 2

				If sourceListBox Is targetListBox AndAlso draggedItemIndex = replacedItemIndex Then
					Return
				End If
				sourceListBox.Items.RemoveAt(draggedItemIndex)

				Dim p1 As New Point()
				p1.X = e.X
				p1.Y = e.Y

				If p1.Y <= MiddleBound AndAlso p1.Y > UpperBound Then
					If sourceListBox Is targetListBox Then
						'the dragged item should be added above the replaced item  
						If draggedItemIndex < replacedItemIndex Then
							targetListBox.Items.Insert(replacedItemIndex - 1, Me.draggedItem)
						Else
							targetListBox.Items.Insert(replacedItemIndex, Me.draggedItem)
						End If
					Else
						targetListBox.Items.Insert(replacedItemIndex, Me.draggedItem)
					End If
				Else
					If sourceListBox Is targetListBox Then
						'the dragged item should be added below the replaced item
						If draggedItemIndex > replacedItemIndex Then
							targetListBox.Items.Insert(replacedItemIndex + 1, Me.draggedItem)
						Else
							targetListBox.Items.Insert(replacedItemIndex, Me.draggedItem)
						End If
						'targetListBox.Items.Insert(replacedItemIndex, this.draggedItem);
					Else
						targetListBox.Items.Insert(replacedItemIndex + 1, Me.draggedItem)
					End If
				End If
			Else
				Dim idx As Integer = sourceListBox.Items.IndexOf(Me.draggedItem)
				sourceListBox.Items.RemoveAt(idx)
				targetListBox.SelectedItem = Nothing
				targetListBox.Items.Add(Me.draggedItem)

			End If
			targetListBox.SelectedIndex = -1
			targetListBox.SelectedItem = draggedItem

			Me.draggedItem = Nothing
			Me.replacedItem = Nothing
		End Sub

		Protected Overridable Function IsRealDrag(ByVal mousePosition As Point) As Boolean
			If Not Me.isRealDrag_Renamed Then
				Me.isRealDrag_Renamed = (Math.Abs(CInt(Fix(mousePosition.X - Me.initialMousePosition.X))) >= SystemInformation.DragSize.Width) OrElse (Math.Abs(CInt(Fix(mousePosition.Y - Me.initialMousePosition.Y))) >= SystemInformation.DragSize.Height)
			End If
			Return Me.isRealDrag_Renamed
		End Function

		Private colorToSet As Color = Color.Orange

		Private Sub BeginDrag(ByVal e As MouseEventArgs)
			Me.initialMousePosition = New Point(e.X, e.Y)
			Dim elementAtPoint As RadElement = sourceComponentElementTree.GetElementAtPoint(Me.initialMousePosition)

			If elementAtPoint Is Nothing Then
				Return
			Else
				If (elementAtPoint.Visibility <> ElementVisibility.Visible) Then
					Return
				End If
			End If

			If TypeOf elementAtPoint Is RadListElement Then
				Return
			End If
			If TypeOf elementAtPoint Is RadListVisualItem Then
				sourceListBox.SelectedItem = (TryCast(elementAtPoint, RadListVisualItem)).Data
			End If

			Me.draggedItem = (TryCast(elementAtPoint, RadListVisualItem)).Data

			Dim args As New DragCancelEventArgs(Me.draggedItem, Nothing)

			If args.Cancel Then
				Me.draggedItem = Nothing
				Return
			End If

			Dim dragArgs As New RadDragEventArgs(Me.draggedItem, Nothing)

			Me.isRealDrag_Renamed = False

			Me.dragging_Renamed = True

			If Me.feedBackForm Is Nothing Then
				feedBackForm = New FeedBackForm()
			End If

			Me.colorToSet = Me.FeedbackFormLineColor()
			Me.feedBackForm.LineColor = Me.colorToSet

			If Me.draggedItem IsNot Nothing Then
				PrepareDragging(e)
			End If
		End Sub

		' Set the color of the feedback form dynamically depending on the color blending.
		Private Function FeedbackFormLineColor() As Color
			If Me.draggedItem Is Nothing Then
				Return SystemColors.ControlDark
			End If

			Return Me.draggedItem.VisualItem.BorderColor
		End Function

		Private Sub EndDrag(ByVal e As MouseEventArgs)
			Me.dragging_Renamed = False

			If Me.draggedItem IsNot Nothing Then
				If targetListBox IsNot Nothing Then
					If targetListBox Is sourceListBox AndAlso sourceListBox.Items.Count = 1 Then
						Return
					End If

					Dim p2 As New Point()
					p2 = sourceListBox.PointToScreen(New Point(e.X, e.Y))
					p2 = targetListBox.PointToClient(p2)
					Dim elementAtPoint As RadElement = targetComponentElementTree.GetElementAtPoint(p2)

					If elementAtPoint IsNot Nothing Then
						If (elementAtPoint.Visibility <> ElementVisibility.Visible) Then
							Return
						End If

						'RadListVisualItem visualItem = elementAtPoint as RadListVisualItem;
						'if (visualItem != null)
							'replacedItem = visualItem.Data;
							If draggedItem Is replacedItem Then
								Return
							End If
							RefreshItemsAfterDragDrop(e)
					End If

					If Me.outlineForm IsNot Nothing Then
						Me.outlineForm.Dispose()
						Me.outlineForm = Nothing
					End If

					If Me.feedBackForm IsNot Nothing Then
						Me.feedBackForm.Dispose()
						Me.feedBackForm = Nothing
					End If

					Me.isRealDrag_Renamed = False
				End If
			End If
		End Sub

		Private Sub PrepareDragging(ByVal e As MouseEventArgs)
			If Me.draggedItem.VisualItem.Visibility = ElementVisibility.Visible Then
				Me.outlineForm = TelerikHelper.CreateOutlineForm()
				Me.outlineForm.ShowInTaskbar = False
				Me.outlineForm.ShowIcon = False

				Me.outlineForm.BackgroundImage = Me.draggedItem.VisualItem.GetAsBitmap(Brushes.Transparent, 0, New SizeF(1, 1))
				Me.outlineForm.FormBorderStyle = FormBorderStyle.None
				Me.outlineForm.Size = Me.outlineForm.BackgroundImage.Size
				Me.outlineForm.MinimumSize = Me.outlineForm.BackgroundImage.Size
				Me.outlineForm.Location = New Point(Cursor.Position.X + 2, Cursor.Position.Y + 2)
			End If
		End Sub

		Public ReadOnly Property Dragging() As Boolean
			Get
				Return dragging_Renamed
			End Get
		End Property

		Public Sub Dispose() Implements IDisposable.Dispose
			If control IsNot Nothing Then
				RemoveHandler control.MouseMove, AddressOf Control_MouseMove
				RemoveHandler control.MouseUp, AddressOf Control_MouseUp
				control = Nothing
			End If
			If control2 IsNot Nothing Then
				RemoveHandler control2.MouseMove, AddressOf Control_MouseMove
				RemoveHandler control2.MouseUp, AddressOf Control_MouseUp
				control2 = Nothing
			End If
		End Sub

		Public Shared Function GetTreeViewUnderMouse(ByVal mousePosition As Point) As RadListControl
            Return TryCast(TelerikHelper.ControlAtPoint(System.Windows.Forms.Control.MousePosition), RadListControl)
		End Function

		Private Sub Control_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Not Me.dragging_Renamed Then
				Me.InitializeDragOperation(sender, e)
			End If

			If e.Button = MouseButtons.Left Then
                Me.targetListBox = GetTreeViewUnderMouse(System.Windows.Forms.Control.MousePosition)

				If TypeOf Me.draggedItem Is RadListDataItem Then
					If Me.targetListBox Is Nothing Then
						Me.control.FindForm().Cursor = Cursors.No
					Else
						Me.control.FindForm().Cursor = Cursors.Arrow
					End If
				Else
					Me.control.FindForm().Cursor = Cursors.Arrow
				End If

				If Not Me.AllowDragDrop Then
					Return
				End If

				If e.Button <> MouseButtons.Left Then
					If Me.outlineForm IsNot Nothing Then
						Me.outlineForm.Hide()
					End If
				End If

				If Me.draggedItem Is Nothing Then
					If Me.outlineForm IsNot Nothing Then
						Me.outlineForm.Hide()
					End If

					Return
				End If

				Dim elementAtPoint As RadElement = Me.sourceListBox.ElementTree.GetElementAtPoint(New Point(e.X, e.Y))

				Me.IsRealDrag(e.Location)

				If elementAtPoint IsNot Nothing Then
					If elementAtPoint.Visibility <> ElementVisibility.Visible Then
						Return
					End If
				End If

				Me.SetOutLineForm(e)
				Me.DrawFeedBack(e)
			End If
		End Sub

		Private Sub DrawFeedBack(ByVal e As MouseEventArgs)
			If targetListBox Is Nothing Then
				feedBackForm.Hide()
				Return
			End If
			Me.targetComponentElementTree = Me.targetListBox.ElementTree
			Dim p4 As New Point()
			p4 = sourceListBox.PointToScreen(New Point(e.X, e.Y))
			p4 = targetListBox.PointToClient(p4)
			Dim elementAtPoint As RadElement = targetComponentElementTree.GetElementAtPoint(p4)

			Dim visualReplacedItem As RadListVisualItem = TryCast(elementAtPoint, RadListVisualItem)
			Me.replacedItem = If(visualReplacedItem IsNot Nothing, visualReplacedItem.Data, Nothing)

			If visualReplacedItem Is Nothing Then
				feedBackForm.Hide()
				Return
			End If

			If visualReplacedItem IsNot Nothing Then
				Dim UpperBound As Integer = visualReplacedItem.Bounds.Height * Me.targetListBox.Items.IndexOf(Me.replacedItem)
				Dim MiddleBound As Integer = UpperBound + visualReplacedItem.Bounds.Height \ 2
				Dim LowerBound As Integer = UpperBound + visualReplacedItem.Bounds.Height

				If p4.Y < UpperBound OrElse p4.Y > LowerBound Then
					'FeedBack shouldnt be drawn
					feedBackForm.StartPoint = Nothing
				End If

				If p4.Y <= MiddleBound AndAlso p4.Y > UpperBound Then
					'FeedBack should be drawn above the replceditem
					feedBackForm.StartPoint = Me.targetListBox.PointToScreen(New Point(0+3, UpperBound+1))
				End If

				If p4.Y <= LowerBound AndAlso p4.Y > MiddleBound Then
					'FeedBack should be drawn below the replaceditem
					feedBackForm.StartPoint = Me.targetListBox.PointToScreen(New Point(0 + 3, UpperBound + 1 + visualReplacedItem.Bounds.Height))
				End If
			End If

			If TypeOf elementAtPoint Is RadListElement Then
				If targetListBox.Items.Count > 0 Then
					Dim lastItem As RadListDataItem = Me.targetListBox.Items(Me.targetListBox.Items.Count - 1)


					'FeedBack should be drawn always below the last item of the targetListBox
					If feedBackForm Is Nothing Then
						Return
					End If
					feedBackForm.StartPoint = Me.targetListBox.PointToScreen(New Point(3, 1 + lastItem.VisualItem.Bounds.Height * Me.targetListBox.Items.IndexOf(lastItem) + lastItem.VisualItem.Bounds.Height))
				Else
					feedBackForm.StartPoint = Nothing
				End If
			End If
			SetFeedBackForm()
		End Sub

		Private Sub SetFeedBackForm()
			If Me.feedBackForm IsNot Nothing Then
				If Not Me.feedBackForm.Visible Then
					Dim handleRef As New HandleRef(Me.feedBackForm, Me.feedBackForm.Handle)
					ShowWindow(handleRef, 8)
				End If

				If feedBackForm.StartPoint IsNot Nothing Then
					Me.feedBackForm.Location = CType(feedBackForm.StartPoint, Point)
				Else
					feedBackForm.Hide()
				End If
			End If
		End Sub

		Private Property AllowDragDrop() As Boolean
			Get
				Return allowDragDrop_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowDragDrop_Renamed = value
			End Set
		End Property

		Public Property Items() As ICollection(Of RadListDataItem)
			Get
				Return items_Renamed
			End Get
			Set(ByVal value As ICollection(Of RadListDataItem))
				items_Renamed = value
			End Set
		End Property
	End Class

	Public Class FeedBackForm
		Inherits Form
'INSTANT VB NOTE: The variable lineColor was renamed since Visual Basic does not allow class members with the same name:
		Private lineColor_Renamed As Color

		Public Sub New()
			Me.FormBorderStyle = FormBorderStyle.None
			Me.TransparencyKey = Color.White
			Me.BackColor = Color.White
			Me.ForeColor = Color.Black
			Me.ShowInTaskbar = False
			Me.MinimumSize = New Size(10, 5)
			Me.MaximumSize = New Size(400, 15)
			Me.Opacity = 0.5

			_startPoint = New Point()
			_endPoint = New Point()
		End Sub

		Public Property EndPoint() As Point?
			Get
				Return _endPoint
			End Get
			Set(ByVal value? As Point)
				_endPoint = value
			End Set
		End Property

		Public Property StartPoint() As Point?
			Get
				Return _startPoint
			End Get
			Set(ByVal value? As Point)
				_startPoint = value
			End Set
		End Property

		Public Property LineColor() As Color
			Get
				Return lineColor_Renamed
			End Get
			Set(ByVal value As Color)
				lineColor_Renamed = value
			End Set
		End Property

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim pen As New Pen(lineColor_Renamed)
			pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot

			Dim g As Graphics = e.Graphics
			pen.Width = 4
			g.DrawLine(pen, 0, 0, 250, 0)
			pen.Dispose()
			MyBase.OnPaint(e)
		End Sub
		Private _startPoint? As Point
		Private _endPoint? As Point
	End Class
End Namespace

