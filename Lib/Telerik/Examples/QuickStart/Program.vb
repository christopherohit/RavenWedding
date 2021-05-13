Imports Telerik.WinControls.UI
Imports System.Threading
Imports System.IO
Imports System.Text
Imports System.Reflection

Namespace Telerik.QuickStart.WinControls
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

            Application.Run(New MainForm())
        End Sub

        Private Shared Function MyResolveEventHandler(sender As Object, args As ResolveEventArgs) As Assembly
            Dim strTempAssmbPath As String = ""
            Dim neededAssembly As String = ""
            If args.Name.Contains(",") Then
                neededAssembly = (args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll")
            Else
                neededAssembly = args.Name
            End If

            Dim objExecutingAssemblies As System.Reflection.Assembly = System.Reflection.Assembly.GetCallingAssembly
            For Each strAssmbName As System.Reflection.AssemblyName In objExecutingAssemblies.GetReferencedAssemblies
                Dim currentAssembly As String = (strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) + ".dll")
                If (currentAssembly = neededAssembly) Then
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory, neededAssembly)
                    If Not System.IO.File.Exists(strTempAssmbPath) Then
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory, "..\..\bin\ReleaseTrial\")
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly)
                    End If

                    Exit For
                End If

            Next
            Dim myAssembly As System.Reflection.Assembly = Nothing
            If Not String.IsNullOrEmpty(strTempAssmbPath) Then
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath)
            Else
                strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory, "..\..\bin\ReleaseTrial\")
                If System.IO.Directory.Exists(strTempAssmbPath) Then
                    For Each fileName As String In System.IO.Directory.GetFiles(strTempAssmbPath, "*.dll")
                        If fileName.EndsWith(neededAssembly) Then
                            myAssembly = System.Reflection.Assembly.LoadFrom(Path.Combine(strTempAssmbPath, fileName))
                            Exit For
                        End If

                    Next
                End If

            End If

            Return myAssembly
        End Function
    End Class
End Namespace