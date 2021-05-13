Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports System.Management

Namespace Telerik.Examples.WinControls.RichTextEditor.StructuredContent
	Partial Public Class Form1
		Inherits ExternalExampleHostForm
		Private ReadOnly ExternalExampleName As String = "StructuredContent"

		Public Sub New(ByVal themeName As String)
			Me.ThemeName = themeName
		End Sub

		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\RichTextEditor\bin\RichTextEditor.exe"
		End Function

		Protected Overrides Function GetEntryPointAsString() As String
			Return "RichTextEditor." & ExternalExampleName &".Form1"
		End Function

		Protected Overrides Function GetExternalProcessArguments(ByVal excutablePath As String) As String
			Return String.Format("{0} {1}", ExternalExampleName,If(String.IsNullOrEmpty(Me.ThemeName), Utils.ThemeName, Me.ThemeName))
		End Function

		Protected Overrides ReadOnly Property CanOpenMultipleInstances() As Boolean
			Get
				Return True
			End Get
		End Property
	End Class
End Namespace
