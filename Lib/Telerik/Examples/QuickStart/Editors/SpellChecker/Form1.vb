Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Editors.SpellChecker
	Partial Public Class Form1
		Inherits ExternalExampleHostForm
		Private ReadOnly ExternalExampleName As String = "SpellCheckAsYouType"
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal themeName As String)
			Me.New()
			Me.ThemeName = themeName
		End Sub
		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\SpellCheckAsYouType\Bin\SpellCheckAsYouType.exe"
		End Function
		Protected Overrides Function GetExternalProcessArguments(ByVal excutablePath As String) As String
			Return String.Format("{0} {1}",If(String.IsNullOrEmpty(Me.ThemeName), Utils.ThemeName, Me.ThemeName), ExternalExampleName)
		End Function

		Protected Overrides ReadOnly Property CanOpenMultipleInstances() As Boolean
			Get
				Return True
			End Get
		End Property
	End Class
End Namespace

