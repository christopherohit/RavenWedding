Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports Telerik.WinControls.Layouts
Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.WinControls

Namespace DemoAppsHub.MagnifierExample
	Public Class MagnifierLayout
		Inherits LayoutPanel
		Private columns_Renamed As Integer = 3
		Private defaultCellSize_Renamed As Size = Size.Empty

		<DefaultValue(3), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property Columns() As Integer
			Get
				Return columns_Renamed
			End Get
			Set
				columns_Renamed = Value
			End Set
		End Property

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property DefaultCellSize() As Size
			Get
				Return defaultCellSize_Renamed
			End Get
			Set
				defaultCellSize_Renamed = Value
			End Set
		End Property

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim children As RadElementCollection = Me.Children
            Dim rows As Integer = CType(children.Count / Me.columns_Renamed, Integer)
			'SizeF cellSize = new SizeF(availableSize.Width / this.columns, availableSize.Height / rows);
			'SizeF cellSize = this.defaultCellSize;
			Dim cellSize As SizeF = availableSize

			Dim i As Integer = 0
			Do While i < children.Count
				Dim child As RadElement = children(i)
				child.Measure(cellSize)
				i += 1
			Loop

			Return New SizeF(Me.columns_Renamed * Me.defaultCellSize_Renamed.Width, rows * Me.defaultCellSize_Renamed.Height)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim children As RadElementCollection = Me.Children

			Dim x As Integer = 0
			Dim y As Integer = 0
			Dim i As Integer = 0
			Do While i < children.Count
				Dim child As RadElement = children(i)
				Dim elementPrefferedSize As SizeF = child.DesiredSize
				elementPrefferedSize.Width = Math.Max(elementPrefferedSize.Width, Me.defaultCellSize_Renamed.Width)
				elementPrefferedSize.Height = Math.Max(elementPrefferedSize.Height, Me.defaultCellSize_Renamed.Height)
				Dim elementPosition As PointF = New PointF(x * Me.defaultCellSize_Renamed.Width, y * Me.defaultCellSize_Renamed.Height)
				elementPosition.X += (Me.defaultCellSize_Renamed.Width - elementPrefferedSize.Width) / 2
				elementPosition.Y += (Me.defaultCellSize_Renamed.Height - elementPrefferedSize.Height) / 2

				child.Arrange(New RectangleF(elementPosition, elementPrefferedSize))

				If x < Me.columns_Renamed - 1 Then
					x += 1
				Else
					x = 0
					y += 1
				End If
				i += 1
			Loop

			Return finalSize
		End Function
	End Class
End Namespace
