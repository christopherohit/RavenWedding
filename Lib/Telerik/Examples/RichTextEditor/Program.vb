
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes
Imports System
Imports Telerik.WinControls

Namespace RichTextEditor
    NotInheritable Class Program
        Private Sub New()
        End Sub
#Region "Fields"

        Public Shared ThemeName As String = ""
        Public Shared loadedExample As String = ""
        Private Shared splashForm As Form
        Private Shared exampleForm As Form
        Private Shared isSplashLoaded As Boolean = False

#End Region

#Region "Main"

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main(args As String())
            If args.Length = 1 Then
                Program.loadedExample = "FirstLook"
                Program.ThemeName = args(0)
            ElseIf args.Length = 2 Then
                Program.loadedExample = args(0)
                Program.ThemeName = args(1)
            Else
                Program.loadedExample = "FirstLook"
                Program.ThemeName = "Office2013Light"
            End If

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            'we need this to load the needed references from other directory (for the standalone QSF)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

            LoadThemes()
            ShowSplashScreen()

            exampleForm = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().[GetType]([String].Format("RichTextEditor.{0}.Form1", Program.loadedExample))), Form)
            AddHandler exampleForm.Shown, AddressOf exampleForm_Shown

            'Load the themes so the form can start with the QSF theme

            'run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
            Application.Run(exampleForm)
        End Sub

#End Region

#Region "Splash Form"

        Private Shared Sub exampleForm_Shown(sender As Object, e As EventArgs)
            HideSplashScreen()
        End Sub

        Private Shared Sub ShowSplashScreenCore()
            splashForm = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().[GetType]("RichTextEditor.SplashForm")), Form)
            splashForm.TopMost = True
            AddHandler splashForm.Load, AddressOf splashForm_Load

            Application.Run(splashForm)
        End Sub

        Private Shared Function splashForm_Load() As Object
            isSplashLoaded = True
        End Function

        Public Shared Sub ShowSplashScreen()
            Dim thread As New Thread(New ThreadStart(AddressOf ShowSplashScreenCore))
            thread.IsBackground = True
            thread.SetApartmentState(ApartmentState.STA)
            thread.Start()
            While splashForm Is Nothing OrElse splashForm.IsHandleCreated = False OrElse Not isSplashLoaded
                System.Threading.Thread.Sleep(50)
            End While
        End Sub

        Public Shared Sub HideSplashScreen()
            splashForm.Invoke(New MethodInvoker(Function()
                                                    splashForm.TopMost = False
                                                    splashForm.Close()

                                                End Function))

            While splashForm.Visible
                Thread.Sleep(10)
            End While

            Thread.Sleep(100)
            exampleForm.BringToFront()
            exampleForm.Activate()
        End Sub

#End Region

#Region "Assembly Resolve"

        Private Shared Function MyResolveEventHandler(sender As Object, args As ResolveEventArgs) As System.Reflection.Assembly
            Dim strTempAssmbPath As String = ""
            Dim neededAssembly As String = If(args.Name.Contains(","c), args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll", args.Name + ".dll")
            Dim objExecutingAssemblies As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            For Each strAssmbName As System.Reflection.AssemblyName In objExecutingAssemblies.GetReferencedAssemblies()
                Dim currentAssembly As String = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) + ".dll"

                If currentAssembly = neededAssembly Then
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll")

                    If Not System.IO.File.Exists(strTempAssmbPath) Then
                        ' we are in the case of QSF as exe, so the Path is different
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\..\..\bin\ReleaseTrial\")
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly)
                    End If
                    Exit For
                End If
            Next

            Dim myAssembly As System.Reflection.Assembly = Nothing

            If Not String.IsNullOrEmpty(strTempAssmbPath) Then
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath)
            End If
            Return myAssembly
        End Function

#End Region

#Region "Themes"

        Private Shared Sub LoadThemes()
            Dim theme
            theme = New AquaTheme()
            theme = New BreezeTheme()
            theme = New DesertTheme()
            theme = New HighContrastBlackTheme()
            theme = New Office2007BlackTheme()
            theme = New Office2007SilverTheme()
            theme = New Office2010BlackTheme()
            theme = New Office2010SilverTheme()
            theme = New Office2010BlueTheme()
            theme = New Office2013DarkTheme()
            theme = New Office2013LightTheme()
            theme = New TelerikMetroTheme()
            theme = New TelerikMetroBlueTheme()
            theme = New TelerikMetroTouchTheme()
            theme = New VisualStudio2012DarkTheme()
            theme = New VisualStudio2012LightTheme()
            theme = New Windows7Theme()
            theme = New Windows8Theme()
        End Sub

#End Region



    End Class
End Namespace
