
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System.Management

Namespace Telerik.Examples.WinControls.GridView.Export.SpreadsheetStreaming
    Partial Public Class Form1
        Inherits ExternalExampleHostForm
        Private ReadOnly ExternalExampleName As String = "SpreadsheetStreaming"

        Public Sub New(themeName As String)
            Me.ThemeName = themeName
        End Sub

        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\ExportWithDpl\bin\ExportWithDpl.exe"
        End Function

        Protected Overrides Function GetEntryPointAsString() As String
            Return (Convert.ToString("ExportWithDpl.") & ExternalExampleName) + ".Form1"
        End Function

        Protected Overrides Function GetExternalProcessArguments(excutablePath As String) As String
            Return [String].Format("{0} {1}", ExternalExampleName, If([String].IsNullOrEmpty(Me.ThemeName), Utils.ThemeName, Me.ThemeName))
        End Function

        Protected Overrides ReadOnly Property CanOpenMultipleInstances() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
