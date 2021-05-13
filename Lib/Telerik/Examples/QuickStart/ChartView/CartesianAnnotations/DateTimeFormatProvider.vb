Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
	Public Class DateTimeFormatProvider
		Implements IFormatProvider, ICustomFormatter
		Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
			Return Me
		End Function

'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
			Dim val As Date = CDate(arg)

			If val.Month = 1 Then
				Return val.ToString("MMM") & Environment.NewLine & val.Year
			Else
				Return val.ToString("MMM")
			End If
		End Function
	End Class
End Namespace
