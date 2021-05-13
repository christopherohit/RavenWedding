Imports System.ComponentModel
Imports System.Globalization
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
	Public Class ToggleStateConverter
		Inherits TypeConverter
		#Region "Convert To Methods"

		Public Overrides Overloads Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
			Return destinationType Is GetType(ToggleState)
		End Function

		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
			Dim charValue As Char = CChar(value)

			Select Case charValue
				Case "Y"c
					Return ToggleState.On
				Case "N"c
					Return ToggleState.Off
				Case "M"c, ControlChars.NullChar
					Return ToggleState.Indeterminate
			End Select

			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function

		#End Region

		#Region "Convert From Methods"

		Public Overrides Overloads Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
			Return sourceType Is GetType(ToggleState)
		End Function

		Public Overrides Overloads Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
			Dim state As ToggleState = CType(value, ToggleState)

			Select Case state
				Case ToggleState.On
					Return "Y"c
				Case ToggleState.Off
					Return "N"c
				Case ToggleState.Indeterminate
					Return "M"c
			End Select

			Return MyBase.ConvertFrom(context, culture, value)
		End Function

		#End Region
	End Class
End Namespace
