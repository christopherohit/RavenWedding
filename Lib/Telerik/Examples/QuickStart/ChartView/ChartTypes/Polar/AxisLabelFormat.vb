Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
	Public Class AxisLabelFormat
		Implements IFormatProvider, ICustomFormatter
		Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
			If formatType Is GetType(ICustomFormatter) Then
				Return Me
			End If

			Return Nothing
		End Function

'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
			Dim value As Double

			If Double.TryParse(arg.ToString(), value) Then
				Return String.Format("-{0}dB", 25 * (1 - value))
			End If

			Return String.Empty
		End Function
	End Class
End Namespace
