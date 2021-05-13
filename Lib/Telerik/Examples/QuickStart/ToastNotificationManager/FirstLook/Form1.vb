Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ToastNotificationManager.FirstLook
    Partial Public Class Form1
        Inherits ExternalExampleHostForm
        Implements ICustomThemeExamplesForm

        Private ReadOnly ExternalExampleName As String = "FirstLook"

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal themeName As String)
            Me.New()
            Me.ThemeName = themeName
        End Sub

        Public Overrides ReadOnly Property ExampleName As String
            Get
                Return ExternalExampleName
            End Get
        End Property

        Protected Overrides Function GetEntryPointAsString() As String
            Return "ToastNotificationManagerExamples.FirstLook.Form1"
        End Function

        Protected Overrides Function GetExecutablePath() As String
            Return "\..\..\ToastNotificationManagerExamples\bin\ToastNotificationManagerExamples.exe"
        End Function

        Protected Overrides Function GetExternalProcessArguments(ByVal excutablePath As String) As String
            Return String.Format("{0} {1}", If(String.IsNullOrEmpty(Me.ThemeName), Utils.ThemeName, Me.ThemeName), ExternalExampleName)
        End Function

        Protected Overrides ReadOnly Property CanOpenMultipleInstances As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
