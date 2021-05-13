Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes

Namespace ExportWithDpl
	Friend Class Program
		Public Shared themeName As String = ""
		Public Shared loadedExample As String = ""

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main(ByVal args As String())
			If args.Length = 1 Then
				Program.loadedExample = "GridView"
				Program.themeName = args(0)
			ElseIf args.Length = 2 Then
				Program.loadedExample = args(0)
				Program.themeName = args(1)
			Else
                Program.loadedExample = "GridView"
				Program.themeName = "TelerikMetro"
			End If

			'reuse the database from Examples\DataSources
			Dim executable As String = System.Reflection.Assembly.GetExecutingAssembly().Location
            Dim myPath As String = (Path.GetDirectoryName(executable))

            Dim testPathForDebuggingCase As String = Path.GetFullPath(Path.Combine(myPath, "..\..\..\Examples\DataSources"))
			Dim fileName As String = "Nwind.mdb"

			If File.Exists(Path.Combine(testPathForDebuggingCase, fileName)) Then
				AppDomain.CurrentDomain.SetData("DataDirectory", testPathForDebuggingCase)
			End If

            Dim testPathForInstallationCase As String = Path.GetFullPath(Path.Combine(myPath, "..\..\QuickStart\DataSources"))

			If File.Exists(Path.Combine(testPathForInstallationCase, fileName)) Then
				AppDomain.CurrentDomain.SetData("DataDirectory", testPathForInstallationCase)
			End If

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			'we need this to load the needed references from other directory (for the standalone QSF)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

			'Load the themes so the form can start with the QSF theme
			LoadThemes()

			'run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
			CType(New ExportWithDplExamplesApplication(), ExportWithDplExamplesApplication).Run(args)
		End Sub

		Private Class ExportWithDplExamplesApplication
			Inherits Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
			Protected Overrides Sub OnCreateMainForm()
				Dim exampleForm As Form = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType(String.Format("ExportWithDpl.{0}.Form1", Program.loadedExample))), Form)
				Me.MainForm = exampleForm
			End Sub
		End Class

        Private Shared Function MyResolveEventHandler(sender As Object, args As ResolveEventArgs) As System.Reflection.Assembly
            Dim strTempAssmbPath As String = ""
            Dim neededAssembly As String = If(args.Name.Contains(","c), args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll", args.Name + ".dll")
            Dim objExecutingAssemblies As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            For Each strAssmbName As System.Reflection.AssemblyName In objExecutingAssemblies.GetReferencedAssemblies()
                Dim currentAssembly As String = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) & ".dll"

                If currentAssembly = neededAssembly Then
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll")

                    If (Not System.IO.File.Exists(strTempAssmbPath)) Then ' we are in the case of QSF as exe, so the Path is different
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\..\..\bin\ReleaseTrial\")
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly)
                    End If
                    Exit For
                End If
            Next strAssmbName

            Dim myAssembly As System.Reflection.Assembly = Nothing

            If (Not String.IsNullOrEmpty(strTempAssmbPath)) Then
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath)
            End If
            Return myAssembly
        End Function

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
	End Class
End Namespace
