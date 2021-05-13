Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.RangeSelector.MSFTStocks
	Friend Class StringLimiterFormatProvider
		Implements IFormatProvider, ICustomFormatter
		Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
			Return Me
		End Function

'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
			Dim s As String = arg.ToString()
			If s IsNot Nothing Then
				If s.Length = 1 Then
					Return "0"
				End If

				Return s.Remove(s.Length - 6)
			Else
				Return Nothing
			End If
		End Function
	End Class
End Namespace
