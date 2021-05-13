Imports System.Linq
Imports System.Windows
Imports Telerik.Windows.Controls
Imports Telerik.Windows.Controls.GridView
Imports System.Windows.Controls

Namespace Telerik.Windows.Examples.GridView.FirstLook
	Public Class RowStyleSelector
		Inherits StyleSelector

		Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
			If CType(container, GridViewRow).GridViewDataControl.Items.IndexOf(item) = 0 Then
				Dim style As New Style(GetType(GridViewRow)) With {.BasedOn = DirectCast(Application.Current.Resources("GridViewRowStyle"), Style)}
				Dim setter As New Setter(GridViewRow.DetailsVisibilityProperty, Visibility.Visible)
				style.Setters.Add(setter)
				Return style
			End If

			Return New Style(GetType(GridViewRow)) With {.BasedOn = DirectCast(Application.Current.Resources("GridViewRowStyle"), Style)}
		End Function
	End Class
End Namespace
