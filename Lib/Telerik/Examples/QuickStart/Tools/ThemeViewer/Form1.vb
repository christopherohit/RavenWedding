Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Tools.ThemeViewer
	Partial Public Class Form1
		Inherits Telerik.QuickStart.WinControls.ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			If File.Exists(Application.StartupPath & "\..\..\..\Bin\Release\ThemeViewer.exe") Then ' Release
				Return "\..\..\..\..\Bin\Release\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Release\net40\ThemeViewer.exe") Then ' Release40
				Return "\..\..\..\..\Bin\Release\net40\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe") Then ' ReleaseTrial
				Return "\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe") Then ' ReleaseTrial40, ReleaseTrial461
				Return "\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Debug\net40\ThemeViewer.exe") Then ' Debug40
				Return "\..\..\..\Bin\Debug\net40\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Debug\ThemeViewer.exe") Then '/ Debug
				Return "\..\..\..\Bin\Debug\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ThemeViewer.exe") Then
				Return "\..\..\..\Bin\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin40\ThemeViewer.exe") Then
				Return "\..\..\..\Bin40\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\Bin\ReleaseTrial\ThemeViewer.exe") Then 'qsf as exe case
				Return "\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\Bin\ReleaseTrial40\ThemeViewer.exe") Then 'qsf as exe case
				Return "\..\..\..\Bin\ReleaseTrial40\ThemeViewer.exe"
			Else
				RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error)
			End If

			Return String.Empty
		End Function

		Protected Overrides Function GetExternalProcessArguments(ByVal excutablePath As String) As String
            Return "Office2019Light"
        End Function
	End Class
End Namespace
