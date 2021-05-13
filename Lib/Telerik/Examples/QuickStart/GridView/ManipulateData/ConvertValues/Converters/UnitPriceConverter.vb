Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports Microsoft.CSharp

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
	Public Class UnitPriceConverter
		Inherits TypeConverter
		#Region "Static Fields"

		Private Shared ReadOnly ClassTemplate As String = "using System; " & "public class DynamicUnitPriceExpression: {0}.IUnitPriceExpression " & "{{ " & "       public double Evaluate(double price) " & "       {{" & "            return Convert.ToDouble({1});" & "       }}" & "}}"

		#End Region

		#Region "Nested Types"

		Public Interface IUnitPriceExpression
			Function Evaluate(ByVal price As Double) As Double
		End Interface

		#End Region

		#Region "Fields"

		Private expression As IUnitPriceExpression = Nothing

		#End Region

		#Region "Properties"

		Public Function SetExpression(ByVal expression As String) As CompilerErrorCollection
			Dim compilerErrors As New CompilerErrorCollection()

			Dim newExpression As IUnitPriceExpression = CreateDynamicExpression(expression, compilerErrors)

			If Not compilerErrors.HasErrors Then
				Me.expression = newExpression
			End If

			Return compilerErrors
		End Function

		#End Region

		#Region "Dynamic Expression Creation"

		Private Shared Function CreateDynamicExpression(ByVal expression As String, <System.Runtime.InteropServices.Out()> ByRef errors As CompilerErrorCollection) As IUnitPriceExpression
			errors = New CompilerErrorCollection()

			If String.IsNullOrEmpty(expression) Then
				Return Nothing
			End If

			Dim parms As New CompilerParameters()

			parms.GenerateExecutable = False
			parms.GenerateInMemory = True
			parms.IncludeDebugInformation = False

			Dim assemblyFileName As String = Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location)
			parms.ReferencedAssemblies.Add("System.dll")
			parms.ReferencedAssemblies.Add(assemblyFileName)

			Dim compiler As CodeDomProvider = CSharpCodeProvider.CreateProvider("CSharp")
			Dim classCode As String = String.Format(ClassTemplate, GetType(UnitPriceConverter).FullName, expression)

			Dim compilerResults As CompilerResults = compiler.CompileAssemblyFromSource(parms, classCode)

			If compilerResults.Errors.HasErrors Then
				errors = compilerResults.Errors
				Return Nothing
			End If

			Dim [assembly] As System.Reflection.Assembly = compilerResults.CompiledAssembly
			Dim unitPriceExpression As IUnitPriceExpression = TryCast([assembly].CreateInstance("DynamicUnitPriceExpression"), IUnitPriceExpression)
			Return unitPriceExpression
		End Function

		#End Region

		#Region "Convert To Methods"

		Public Overrides Overloads Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
			Return destinationType Is GetType(Double) OrElse destinationType Is GetType(Decimal)
		End Function

		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
			If value Is Nothing Then
				If destinationType Is GetType(Double) Then
					Return 0R
				End If

				Return 0D
			End If

			Dim doubleValue As Double = Convert.ToDouble(value)

			If Me.expression IsNot Nothing Then
				doubleValue = Me.expression.Evaluate(doubleValue)
			End If

			If destinationType Is GetType(Decimal) Then
				Return Convert.ToDecimal(doubleValue)
			End If

			Return doubleValue
		End Function

		#End Region

		#Region "Convert From Methods"

		Public Overrides Overloads Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
			Return sourceType Is GetType(Decimal)
		End Function

		Public Overrides Overloads Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
			If value Is Nothing Then
				Return 0R
			End If

			Dim decimalValue As Decimal = CDec(value)
			Return Convert.ToDouble(decimalValue)
		End Function

		#End Region
	End Class
End Namespace
