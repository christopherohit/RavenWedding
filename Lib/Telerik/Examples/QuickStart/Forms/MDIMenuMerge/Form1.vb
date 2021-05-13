Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		Private Shared ChildSize As New Size(580, 200)
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Me.IsMdiContainer = True
			Me.Text = "RadForm MDI Parent with RadMenu"
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem4.Click, AddressOf radMenuItem4_Click
			AddHandler radMenuItem5.Click, AddressOf radMenuItem5_Click
			AddHandler radMenuItem7.Click, AddressOf radMenuItem7_Click
			AddHandler radMenuItem8.Click, AddressOf radMenuItem8_Click
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim child1 As New Form()
			child1.Size = ChildSize
			child1.Text = "Standard Windows Form1 with no menu"
			child1.MdiParent = Me
			child1.Show()

			Dim child4 As New RadChildForm2()
			child4.Size = ChildSize
			child4.Text = "RadForm2 with no menu"
			child4.MdiParent = Me
			child4.Show()
			ThemeResolutionService.ApplyThemeToControlTree(child4, Me.ThemeName)

			Dim child2 As New RadChildForm()
			child2.Size = ChildSize
			child2.Text = "RadForm3 with RadMenu"
			child2.MdiParent = Me
			child2.Show()
			ThemeResolutionService.ApplyThemeToControlTree(child2, Me.ThemeName)
		End Sub

		Private Sub radMenuItem7_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.ActiveMdiChild IsNot Nothing Then
				Me.ActiveMdiChild.Close()
			End If
		End Sub

		Private Sub radMenuItem8_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each form As Form In Me.MdiChildren
				form.Close()
			Next form
		End Sub

		Private i As Integer = 4

		Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim child As New RadChildForm2()
			child.Size = ChildSize
			child.Text = "RadForm" & i.ToString()
			child.MdiParent = Me
			child.Show()
			ThemeResolutionService.ApplyThemeToControlTree(child, Me.ThemeName)
			i += 1
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace