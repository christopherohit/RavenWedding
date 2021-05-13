﻿Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Diagram.OrgChart
	Partial Public Class Form1
		Inherits ExternalExampleHostForm
		Private ReadOnly ExternalExampleName As String = "OrgChart"
		Public Sub New()

		End Sub
		Public Sub New(ByVal themeName As String)
			Me.ThemeName = themeName
		End Sub

		Public Overrides ReadOnly Property ExampleName() As String
			Get
				Return ExternalExampleName
			End Get
		End Property

		Protected Overrides Function GetEntryPointAsString() As String
			Return "DiagramOrganizationChart.OrgChartForm"
		End Function


		Protected Overrides Function GetExecutablePath() As String
			Return "\..\..\Diagram\DiagramFirstLook\bin\DiagramFirstLook.exe"
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