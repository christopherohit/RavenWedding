Imports System
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.AboutBox
    Partial Class RadAboutBox1
        Inherits ExamplesRadForm

        Private executingAssembly_field As Assembly

        Public Sub New()
            InitializeComponent()
            Me.Text = String.Format("About {0}", Me.AssemblyTitle)
            Me.radLabelProductName.Text = Me.AssemblyProduct
            Me.radLabelVersion.Text = String.Format("Version {0}", Me.AssemblyVersion)
            Dim assemblyCopyright As String = Me.AssemblyCopyright
            Me.radLabelCopyright.Text = assemblyCopyright.Substring(0, assemblyCopyright.IndexOf("."))
            Me.radLabelCompanyName.Text = Me.AssemblyCompany
            Me.radTextBoxDescription.Text = VersionNumber.ProductName & " includes over 140 UI controls that you can " & "use to easily build unique and visually stunning Line of Business applications. " & "Boasting a well-designed architecture and CAB support, RadControls are perfectly " & "suited for your Enterprise desktop development."
            Me.logoPictureBox.Image = Me.GetAboutBoxImage()
        End Sub

        Public ReadOnly Property ExecutingAssembly As Assembly
            Get
                If Me.executingAssembly_field Is Nothing Then
                    Me.executingAssembly_field = Assembly.GetExecutingAssembly()
                End If

                Return Me.executingAssembly_field
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            Dim themeName As String = Me.ThemeName
            MyBase.OnLoad(e)
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

        Private Function GetAboutBoxImage() As Image
            Dim img As Image
            Dim imageStream As Stream
            Dim imageFileName As String = "AboutBox.png"
            imageStream = Me.ExecutingAssembly.GetManifestResourceStream(imageFileName)
            img = Bitmap.FromStream(imageStream)

            Return img
        End Function

        Private Function GetAssemblyAttribute(Of T)() As T
            Dim attributes As Object() = Me.ExecutingAssembly.GetCustomAttributes(GetType(T), False)

            If attributes.Length = 0 Then
                Return Nothing
            End If

            Return CType(attributes(0), T)
        End Function

        Public ReadOnly Property AssemblyTitle As String
            Get
                Dim titleAttribute As AssemblyTitleAttribute = Me.GetAssemblyAttribute(Of AssemblyTitleAttribute)()

                If titleAttribute IsNot Nothing AndAlso titleAttribute.Title <> String.Empty Then
                    Return titleAttribute.Title
                End If

                Return Path.GetFileNameWithoutExtension(Me.ExecutingAssembly.CodeBase)
            End Get
        End Property

        Public ReadOnly Property AssemblyVersion As String
            Get
                Return Me.ExecutingAssembly.GetName().Version.ToString()
            End Get
        End Property

        Public ReadOnly Property AssemblyDescription As String
            Get
                Dim attr As AssemblyDescriptionAttribute = Me.GetAssemblyAttribute(Of AssemblyDescriptionAttribute)()

                If attr Is Nothing Then
                    Return String.Empty
                End If

                Return attr.Description
            End Get
        End Property

        Public ReadOnly Property AssemblyProduct As String
            Get
                Dim attr As AssemblyProductAttribute = Me.GetAssemblyAttribute(Of AssemblyProductAttribute)()

                If attr Is Nothing Then
                    Return String.Empty
                End If

                Return attr.Product
            End Get
        End Property

        Public ReadOnly Property AssemblyCopyright As String
            Get
                Dim attr As AssemblyCopyrightAttribute = Me.GetAssemblyAttribute(Of AssemblyCopyrightAttribute)()

                If attr Is Nothing Then
                    Return String.Empty
                End If

                Return attr.Copyright
            End Get
        End Property

        Public ReadOnly Property AssemblyCompany As String
            Get
                Dim attr As AssemblyCompanyAttribute = Me.GetAssemblyAttribute(Of AssemblyCompanyAttribute)()

                If attr Is Nothing Then
                    Return String.Empty
                End If

                Return attr.Company
            End Get
        End Property
    End Class
End Namespace
