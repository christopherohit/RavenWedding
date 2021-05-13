Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace FileExplorer
	Friend Class CustomToggleButton
		Inherits RadToggleButtonElement

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

		End Sub

		Protected Overrides Sub OnToggleStateChanged(ByVal e As StateChangedEventArgs)
			If e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
                Me.ButtonFillElement.ResetValue(FillPrimitive.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
                Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor2Property, Telerik.WinControls.ValueResetFlags.Local)
                Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor3Property, Telerik.WinControls.ValueResetFlags.Local)
                Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor4Property, Telerik.WinControls.ValueResetFlags.Local)
			Else
                Me.ButtonFillElement.BackColor = Color.Transparent
                Me.ButtonFillElement.BackColor2 = Color.Transparent
                Me.ButtonFillElement.BackColor3 = Color.Transparent
                Me.ButtonFillElement.BackColor4 = Color.Transparent
                Me.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
			MyBase.OnToggleStateChanged(e)
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadToggleButtonElement)
			End Get
		End Property
	End Class
End Namespace
