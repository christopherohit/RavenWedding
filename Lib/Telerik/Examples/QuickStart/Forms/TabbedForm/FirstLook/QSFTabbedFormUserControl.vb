Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
    Partial Public Class QSFTabbedFormUserControl
        Inherits UserControl
        Implements ISupportThemeName

        Public Sub New()
            InitializeComponent()
            Me.SetTexts()
            AddHandler radButtonElement2.Click, AddressOf RadButtonElement2_Click
        End Sub

        Public Sub SetupVisibility()
            Dim tab As RadTabbedFormControlTab = TryCast(Me.Parent, RadTabbedFormControlTab)
            If tab Is Nothing OrElse tab.Owner Is Nothing Then Return
            Dim tabbedControl As RadTabbedFormControl = tab.Owner
            Dim tabCount As Integer = tabbedControl.Tabs.Count
            Me.radButton2.Visible = CSharpImpl.__Assign(Me.radLabel2.Visible, tabCount >= 2)
            Me.radButton3.Visible = CSharpImpl.__Assign(Me.radLabel3.Visible, tabCount >= 3)
            Me.radButton5.Visible = CSharpImpl.__Assign(Me.radLabel4.Visible, tabCount >= 4)
            Me.radButton4.Visible = CSharpImpl.__Assign(Me.radLabel5.Visible, tabCount >= 5)
        End Sub

        Private Sub SetTexts()
            SetText(Me.radButtonElement2, "")
            radButtonElement2.TextElement.CustomFontSize = 12
            SetText(Me.radButtonElement3, "")
            radButtonElement3.TextElement.CustomFontSize = 12
            SetText(Me.radButtonElement4, "")
            radButtonElement4.TextElement.CustomFontSize = 12
            SetText(Me.radButton1.ButtonElement, "")
            Me.radLabel1.Text = "google"
            SetText(Me.radButton2.ButtonElement, "")
            Me.radLabel2.Text = "new tab 1"
            SetText(Me.radButton3.ButtonElement, "")
            Me.radLabel3.Text = "new tab 2"
            SetText(Me.radButton4.ButtonElement, "")
            Me.radLabel4.Text = "new tab3"
            SetText(Me.radButton5.ButtonElement, "")
            Me.radLabel5.Text = "new tab4"
        End Sub

        Public Shared Sub SetText(ByVal buttonElement As RadButtonElement, ByVal text As String)
            buttonElement.TextElement.CustomFontSize = 18
            buttonElement.TextElement.CustomFont = "TelerikWebUI"
            buttonElement.Text = text
            buttonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias
        End Sub

        Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
            MyBase.OnParentChanged(e)
            Me.CenterControl(Me.Parent)
            Dim tab As RadTabbedFormControlTab = TryCast(Me.Parent, RadTabbedFormControlTab)

            If tab IsNot Nothing Then
                Dim tabbedControl As RadTabbedFormControl = tab.Owner
                AddHandler tabbedControl.TabAdded, AddressOf RadTabbedFormControl1_TabAdded
                AddHandler tabbedControl.TabRemoved, AddressOf RadTabbedFormControl1_TabRemoved
                AddHandler tabbedControl.TabAdded, AddressOf RadTabbedFormControl1_TabAdded
                AddHandler tabbedControl.TabRemoved, AddressOf RadTabbedFormControl1_TabRemoved

                If tabbedControl.FindForm() IsNot Nothing Then
                    AddHandler tabbedControl.FindForm().SizeChanged, AddressOf QSFTabbedFormUserControl_SizeChanged
                End If
            End If
        End Sub

        Private Sub QSFTabbedFormUserControl_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.CenterControl(Me.FindForm())
        End Sub

        Private Sub RadButtonElement2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try

                If Not String.IsNullOrEmpty(Me.radButtonTextBox1.Text) Then
                    System.Diagnostics.Process.Start("https://www.google.com/search?q=" & Me.radButtonTextBox1.Text)
                End If

            Catch
            End Try
        End Sub

        Private Sub RadTabbedFormControl1_TabRemoved(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTabbedFormControlEventArgs)
            Me.SetupVisibility()
        End Sub

        Private Sub RadTabbedFormControl1_TabAdded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTabbedFormControlEventArgs)
            Me.SetupVisibility()
        End Sub

        Public Sub CenterControl(ByVal parent As Control)
            If parent Is Nothing Then
                Return
            End If

            Dim location As Point = New Point(CInt(parent.ClientSize.Width / 2 - Me.Size.Width / 2), CInt(parent.ClientSize.Height / 2 - Me.Size.Height / 2))

            If location.X < 0 Then
                location.X = 0
            End If

            If location.Y < 0 Then
                location.Y = 0
            End If

            Me.Location = location
        End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
