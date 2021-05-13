Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.Appearance
	Public Class PaletteListDataItem
		Inherits RadListDataItem
		Public Shared ReadOnly PaletteProperty As RadProperty = RadProperty.Register("Palette", GetType(ChartPalette), GetType(PaletteListDataItem), New RadElementPropertyMetadata(False))

		Public Property Palette() As ChartPalette
			Get
				Return CType(Me.GetValue(PaletteListDataItem.PaletteProperty), ChartPalette)
			End Get
			Set(ByVal value As ChartPalette)
				Me.SetValue(PaletteListDataItem.PaletteProperty, value)
			End Set
		End Property
	End Class
End Namespace
