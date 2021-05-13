Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Tools.VisualStyleBuilder
	Partial Public Class Form1
		Inherits Telerik.QuickStart.WinControls.ExternalProcessForm
		Protected Overrides Function GetExecutablePath() As String
			If File.Exists(Application.StartupPath & "\..\..\..\Bin\Release\VisualStyleBuilder.exe") Then ' Release
				Return "\..\..\..\..\Bin\Release\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Release\net40\VisualStyleBuilder.exe") Then ' Release40
				Return "\..\..\..\..\Bin\Release\net40\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe") Then ' ReleaseTrial
				Return "\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe") Then ' ReleaseTrial40, ReleaseTrial461
				Return "\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Debug\VisualStyleBuilder.exe") Then ' Debug
				Return "\..\..\..\Bin\Debug\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\Debug\net40\VisualStyleBuilder.exe") Then ' Debug40
				Return "\..\..\..\Bin\Debug\net40\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\VisualStyleBuilder.exe") Then
				Return "\..\..\..\Bin\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin40\VisualStyleBuilder.exe") Then
				Return "\..\..\..\Bin40\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe") Then 'qsf as exe case
				Return "\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe"
			ElseIf File.Exists(Application.StartupPath & "\..\..\Bin\ReleaseTrial40\VisualStyleBuilder.exe") Then 'qsf as exe case
				Return "\..\..\Bin\ReleaseTrial40\VisualStyleBuilder.exe"
			Else
				RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error)
			End If

			Return String.Empty
		End Function
	End Class
End Namespace
