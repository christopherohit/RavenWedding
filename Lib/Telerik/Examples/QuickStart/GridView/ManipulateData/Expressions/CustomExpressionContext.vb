Imports System.Text
Imports Telerik.Data.Expressions

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.Expressions
	Public Class CustomExpressionContext
		Inherits ExpressionContext
		''' <summary>
		''' Custom function, which returns Pi.
		''' </summary>
		''' <returns></returns>
		Public Function Pi() As Double
			Return Math.PI
		End Function
	End Class
End Namespace
