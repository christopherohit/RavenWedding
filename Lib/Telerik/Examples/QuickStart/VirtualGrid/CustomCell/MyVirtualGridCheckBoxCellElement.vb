Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.CustomCell
	Public Class MyVirtualGridCheckBoxCellElement
		Inherits VirtualGridCellElement
		Private checkBox As RadCheckBoxElement

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.checkBox = New RadCheckBoxElement()
			Me.Children.Add(Me.checkBox)
		End Sub

		Protected Overrides Sub UpdateInfo(ByVal args As VirtualGridCellValueNeededEventArgs)
			MyBase.UpdateInfo(args)

			If TypeOf args.Value Is Boolean Then
				Me.checkBox.Checked = CBool(args.Value)
			End If

			Me.Text = String.Empty
		End Sub

		Public Overrides Function IsCompatible(ByVal data As Integer, ByVal context As Object) As Boolean
			Dim rowElement As VirtualGridRowElement = TryCast(context, VirtualGridRowElement)

			Return data >= 0 AndAlso rowElement.RowIndex >= 0
		End Function

		Public Overrides Sub Attach(ByVal data As Integer, ByVal context As Object)
			MyBase.Attach(data, context)

			AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
		End Sub

		Public Overrides Sub Detach()
			RemoveHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

			MyBase.Detach()
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(VirtualGridCellElement)
			End Get
		End Property

		Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.TableElement.GridElement.SetCellValue(Me.checkBox.Checked, Me.RowIndex, Me.ColumnIndex, Me.ViewInfo)
		End Sub

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim size As SizeF = MyBase.ArrangeOverride(finalSize)

			Me.checkBox.Arrange(New RectangleF((finalSize.Width - Me.checkBox.DesiredSize.Width) / 2f, (finalSize.Height - Me.checkBox.DesiredSize.Height) / 2f, Me.checkBox.DesiredSize.Width, Me.checkBox.DesiredSize.Height))

			Return size
		End Function
	End Class
End Namespace
