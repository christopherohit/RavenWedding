Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace FileExplorer
	Friend Class CustomButton
		Inherits RadButtonElement
		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            Me.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.ButtonFillElement.ResetValue(FillPrimitive.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
            Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor2Property, Telerik.WinControls.ValueResetFlags.Local)
            Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor3Property, Telerik.WinControls.ValueResetFlags.Local)
            Me.ButtonFillElement.ResetValue(FillPrimitive.BackColor4Property, Telerik.WinControls.ValueResetFlags.Local)
			MyBase.OnMouseEnter(e)
			Console.WriteLine("reset")
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            Me.ButtonFillElement.BackColor = Color.Transparent
            Me.ButtonFillElement.BackColor2 = Color.Transparent
            Me.ButtonFillElement.BackColor3 = Color.Transparent
            Me.ButtonFillElement.BackColor4 = Color.Transparent
            Me.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			MyBase.OnMouseLeave(e)
			Console.WriteLine("transparent")
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadButtonElement)
			End Get
		End Property
	End Class
End Namespace
