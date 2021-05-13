Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Chat.FirstLook

    Partial Public Class Form1
        Inherits ExternalExampleHostForm

        Private ExternalExampleName As String = "FirstLook"

        Public Sub New()
            MyBase.New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal themeName As String)
            MyBase.New()
            Me.ThemeName = themeName
        End Sub

        Public Overrides ReadOnly Property ExampleName As String
            Get
                Return Me.ExternalExampleName
            End Get
        End Property

        Protected Overrides Function GetEntryPointAsString() As String
            Return "RadChatExamples.FirstLook.Form1"
        End Function

        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\RadChatExamples\bin\RadChatExamples.exe"
        End Function

        Protected Overrides Function GetExternalProcessArguments(ByVal excutablePath As String) As String
            Return String.Format("{0} {1}", If(String.IsNullOrEmpty(Me.ThemeName), Utils.ThemeName, Me.ThemeName), ExternalExampleName)
        End Function

        Protected Overrides ReadOnly Property CanOpenMultipleInstances As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace