Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
	Partial Public Class Form1
		Inherits RadRibbonForm
		Implements ISupportThemeName
		Private mdiChildCount As Integer = 0

		Public Sub New()
			InitializeComponent()

			WireEvents()

			Me.AllowAero = False

			Me.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radRibbonBar1.RibbonBarElement.TabStripElement.Items(0)
			Me.radRibbonBar1.StartButtonImage = ResFinder.MenuIcon
			Me.radRibbonBar1.QuickAccessToolBar.InnerItem.ContentLayout.Margin = New Padding(2, 0, 2, 0)
			Me.IsMdiContainer = True
			Me.MinimumSize = New Size(210, 140)
		End Sub

		Private Sub radRibbonBarChunk2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddNewChildForm()
		End Sub

		Private Sub WireEvents()
			AddHandler radButtonElement5.Click, AddressOf radButtonElement5_Click
			AddHandler radRibbonBarChunk2.Click, AddressOf radRibbonBarChunk2_Click
			AddHandler radButtonElement29.Click, AddressOf radButtonElement29_Click
			AddHandler radButtonElement2.Click, AddressOf radButtonElement2_Click
			AddHandler radButtonElement3.Click, AddressOf radButtonElement3_Click
			AddHandler radButtonElement1.Click, AddressOf radButtonElement1_Click
		End Sub

		Private Sub PrepareMDIContainerForThemeChange()
			If Me.ActiveMdiChild Is Nothing Then
				Return
			End If
			If Me.ActiveMdiChild.WindowState = FormWindowState.Maximized Then
				Me.ActiveMdiChild.WindowState = FormWindowState.Normal
			End If
		End Sub

		Private Sub AddNewChildForm()
			Dim form As Form = If(Me.MdiChildren.Length Mod 2 = 0, New Form(), New RadForm())
			form.MdiParent = Me
			Me.mdiChildCount += 1
			form.Text = "MDI Child Form " & Me.mdiChildCount
			form.Show()
			If TypeOf form Is RadForm Then
				ThemeResolutionService.ApplyThemeToControlTree(form, Me.ThemeName)
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddNewChildForm()
			AddNewChildForm()
			AddNewChildForm()
			AddNewChildForm()
		End Sub

		Private Sub radButtonElement5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.AddNewChildForm()
		End Sub

		Private Sub radButtonElement29_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.ActiveMdiChild IsNot Nothing Then
				Me.ActiveMdiChild.Close()
			End If
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.PrepareMDIContainerForThemeChange()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub radButtonElement2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.PrepareMDIContainerForThemeChange()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Black")
		End Sub

		Private Sub radButtonElement3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.PrepareMDIContainerForThemeChange()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Silver")
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace