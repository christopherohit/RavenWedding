Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes

Namespace DiagramFirstLook
	Friend Class Program
		Public Shared themeName As String = ""
		Public Shared exampleName As String = ""
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main(ByVal args As String())
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			'we need this to load the needed references from other directory (for the standalone QSF)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

			If args.Length >= 1 Then
				Program.themeName = args(0)
			End If
			If args.Length >= 2 Then
				Program.exampleName = args(1)
			End If


			LoadThemes()
			Dim form As Form
			If Program.exampleName <> "OrgChart" Then
				form = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType("DiagramFirstLook.Form1")), Form)
			Else
				form = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType("DiagramOrganizationChart.OrgChartForm")), Form)
			End If
			'Load the themes so the form can start with the QSF theme


			'run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
			Application.Run(form)
		End Sub

		Private Shared Function MyResolveEventHandler(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
			Dim strTempAssmbPath As String = ""
			Dim neededAssembly As String = args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll"
			Dim objExecutingAssemblies As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

			For Each strAssmbName As System.Reflection.AssemblyName In objExecutingAssemblies.GetReferencedAssemblies()
				Dim currentAssembly As String = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) & ".dll"

				If currentAssembly = neededAssembly Then
					strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll")

					If (Not System.IO.File.Exists(strTempAssmbPath)) Then ' we are in the case of QSF as exe, so the Path is different
						strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\..\..\..\bin\ReleaseTrial\")
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
			Dim TempAquaTheme As AquaTheme = New AquaTheme()
			Dim TempBreezeTheme As BreezeTheme = New BreezeTheme()
			Dim TempDesertTheme As DesertTheme = New DesertTheme()
			Dim TempHighContrastBlackTheme As HighContrastBlackTheme = New HighContrastBlackTheme()
			Dim TempOffice2007BlackTheme As Office2007BlackTheme = New Office2007BlackTheme()
			Dim TempOffice2007SilverTheme As Office2007SilverTheme = New Office2007SilverTheme()
			Dim TempOffice2010BlackTheme As Office2010BlackTheme = New Office2010BlackTheme()
			Dim TempOffice2010SilverTheme As Office2010SilverTheme = New Office2010SilverTheme()
			Dim TempOffice2010BlueTheme As Office2010BlueTheme = New Office2010BlueTheme()
			Dim TempOffice2013DarkTheme As Office2013DarkTheme = New Office2013DarkTheme()
			Dim TempOffice2013LightTheme As Office2013LightTheme = New Office2013LightTheme()
			Dim TempTelerikMetroTheme As TelerikMetroTheme = New TelerikMetroTheme()
			Dim TempTelerikMetroBlueTheme As TelerikMetroBlueTheme = New TelerikMetroBlueTheme()
			Dim TempTelerikMetroTouchTheme As TelerikMetroTouchTheme = New TelerikMetroTouchTheme()
			Dim TempVisualStudio2012DarkTheme As VisualStudio2012DarkTheme = New VisualStudio2012DarkTheme()
			Dim TempVisualStudio2012LightTheme As VisualStudio2012LightTheme = New VisualStudio2012LightTheme()
			Dim TempWindows7Theme As Windows7Theme = New Windows7Theme()
			Dim TempWindows8Theme As Windows8Theme = New Windows8Theme()
		End Sub
	End Class
End Namespace
