Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.Scheduler.CustomWorkTime
	Friend Class MyTypeConverter
		Inherits TypeConverter
		Public Overrides Overloads Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
			If sourceType Is GetType(Date) Then
				Return True
			End If

			Return MyBase.CanConvertFrom(context, sourceType)
		End Function

		Public Overrides Overloads Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
			If TypeOf value Is Date Then
				Return (CDate(value)).TimeOfDay
			End If

			Return MyBase.ConvertFrom(context, culture, value)
		End Function

		Public Overrides Overloads Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
			If destinationType Is GetType(String) OrElse destinationType Is GetType(TimeSpan) OrElse destinationType Is GetType(Date) Then
				Return True
			End If

			Return MyBase.CanConvertTo(context, destinationType)
		End Function

		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
			If destinationType Is GetType(String) AndAlso TypeOf context Is Telerik.WinControls.UI.GridDataCellElement Then
				Dim cell As Telerik.WinControls.UI.GridDataCellElement = CType(context, Telerik.WinControls.UI.GridDataCellElement)
				Dim span As TimeSpan = CType(value, TimeSpan)

				Return span.Hours.ToString("00") & ":" & span.Minutes.ToString("00")
			End If

			If destinationType Is GetType(TimeSpan) Then
				Return value
			End If

			If destinationType Is GetType(Date) Then
				Dim dt As Date
				If Date.TryParse(value.ToString(), dt) Then
					Return dt
				End If
			End If

			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function
	End Class
End Namespace