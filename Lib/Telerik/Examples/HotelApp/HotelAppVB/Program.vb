Namespace HotelApp
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            'we need this to load the needed references from other directory (for the standalone QSF)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

            'run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
            Dim m As Form = TryCast(Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType("HotelApp.HotelAppForm")), Form)
            Application.Run(m)
        End Sub

        Private Shared Function MyResolveEventHandler(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
            Dim strTempAssmbPath As String = ""
            Dim neededAssembly As String = args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll"
            Dim objExecutingAssemblies As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            For Each strAssmbName As System.Reflection.AssemblyName In objExecutingAssemblies.GetReferencedAssemblies()
                Dim currentAssembly As String = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) & ".dll"

                If currentAssembly = neededAssembly Then
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll")

                    If Not System.IO.File.Exists(strTempAssmbPath) Then ' we are in the case of QSF as exe, so the Path is different
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\..\..\..\bin\ReleaseTrial")
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly)
                    End If
                    Exit For
                End If
            Next strAssmbName

            Dim myAssembly As System.Reflection.Assembly = Nothing

            If Not String.IsNullOrEmpty(strTempAssmbPath) Then
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath)
            End If

            Return myAssembly
        End Function
    End Class
End Namespace
