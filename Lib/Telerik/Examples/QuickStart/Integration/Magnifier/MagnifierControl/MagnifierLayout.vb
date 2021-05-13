Imports System.Text
Imports Telerik.WinControls.Layouts
Imports System.ComponentModel
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Integration.Magnifier
	Public Class MagnifierLayout
		Inherits LayoutPanel
'INSTANT VB NOTE: The variable columns was renamed since Visual Basic does not allow class members with the same name:
		Private columns_Renamed As Integer = 3
'INSTANT VB NOTE: The variable defaultCellSize was renamed since Visual Basic does not allow class members with the same name:
		Private defaultCellSize_Renamed As Size = Size.Empty

		<DefaultValue(3), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property Columns() As Integer
			Get
				Return columns_Renamed
			End Get
			Set(ByVal value As Integer)
				columns_Renamed = value
			End Set
		End Property

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property DefaultCellSize() As Size
			Get
				Return defaultCellSize_Renamed
			End Get
			Set(ByVal value As Size)
				defaultCellSize_Renamed = value
			End Set
		End Property

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim children As RadElementCollection = Me.Children
            Dim rows As Integer = CInt(children.Count / Me.columns_Renamed)
			Dim cellSize As SizeF = availableSize

			For i As Integer = 0 To children.Count - 1
				Dim child As RadElement = children(i)
				child.Measure(cellSize)
			Next i

			Return New SizeF(Me.columns_Renamed * Me.defaultCellSize_Renamed.Width, rows * Me.defaultCellSize_Renamed.Height)
		End Function

        Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
            Dim children As RadElementCollection = Me.Children
            Dim offset As PointF = New PointF((finalSize.Width - Me.DesiredSize.Width) / 2, (finalSize.Height - Me.DesiredSize.Height) / 2)

            If offset.X < 0 Then
                offset.X = 0
            End If

            If offset.Y < 0 Then
                offset.Y = 0
            End If

            Dim x As Integer = 0
            Dim y As Integer = 0

            For i As Integer = 0 To children.Count - 1
                Dim child As RadElement = children(i)
                Dim elementPrefferedSize As SizeF = child.DesiredSize
                elementPrefferedSize.Width = Math.Max(elementPrefferedSize.Width, Me.defaultCellSize.Width)
                elementPrefferedSize.Height = Math.Max(elementPrefferedSize.Height, Me.defaultCellSize.Height)
                Dim elementPosition As PointF = New PointF(x * Me.defaultCellSize.Width, y * Me.defaultCellSize.Height)
                elementPosition.X += offset.X + (Me.defaultCellSize.Width - elementPrefferedSize.Width) / 2
                elementPosition.Y += offset.Y + (Me.defaultCellSize.Height - elementPrefferedSize.Height) / 2
                child.Arrange(New RectangleF(elementPosition, elementPrefferedSize))

                If x < Me.columns - 1 Then
                    x += 1
                Else
                    x = 0
                    y += 1
                End If
            Next

            Return finalSize
        End Function
	End Class
End Namespace
