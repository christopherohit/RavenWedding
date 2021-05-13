Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls

Namespace CS
	Partial Public Class BrowserForm
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property WebBrowser() As WebBrowser
			Get
				Return Me.webBrowser1
			End Get
		End Property
	End Class
End Namespace
