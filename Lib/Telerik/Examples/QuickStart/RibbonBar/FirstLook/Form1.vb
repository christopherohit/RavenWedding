Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.RibbonBar.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Shared ReadOnly PaleteColors(,) As Color = { { Color.Black, Color.FromArgb(127, 127, 127), Color.FromArgb(136, 0, 21), Color.FromArgb(237, 28, 36), Color.FromArgb(255, 127, 39), Color.FromArgb(255, 242, 0), Color.FromArgb(34, 177, 76), Color.FromArgb(0, 162, 232) }, { Color.White, Color.FromArgb(195, 195, 195), Color.FromArgb(185, 122, 87), Color.FromArgb(255, 174, 201), Color.FromArgb(255, 201, 14), Color.FromArgb(239, 228, 176), Color.FromArgb(181, 230, 29), Color.FromArgb(153, 217, 234) }, { Color.FromArgb(103, 91, 234), Color.FromArgb(33, 71, 201), Color.FromArgb(192, 221, 42), Color.FromArgb(40, 17, 41), Color.FromArgb(218, 74, 20), Color.FromArgb(64, 0, 192), Color.FromArgb(12, 100, 89), Color.FromArgb(45, 225, 241) } }

		Public Sub New()
			InitializeComponent()

			Me.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radRibbonBar1.RibbonBarElement.TabStripElement.Items(0)

			Me.radGalleryElement1.SelectedItem = TryCast(Me.radGalleryElement1.Items(0), RadGalleryItem)

			Me.radRibbonBar1.StartButtonImage = Telerik.WinControls.ResFinder.MenuIcon
			Me.radRibbonBar1.QuickAccessToolBar.InnerItem.ContentLayout.Margin = New Padding(2, 0, 2, 0)
			TryCast(Me.radRibbonBarChunk10.Children(1).Children(1).Children(1).Children(0).Children(2).Children(1).Children(0), RadImageButtonElement).Margin = New Padding(0)

			Me.InitializeButtonGroupAsColorPalete(Me.radRibbonBarButtonGroup14, 6)
			Me.InitializeButtonGroupAsColorPalete(Me.radRibbonBarButtonGroup15, 8)

			AddHandler radRibbonBarBackstageView1.ItemClicked, AddressOf radRibbonBarBackstageView1_ItemClicked
		End Sub

		Private Sub InitializeButtonGroupAsColorPalete(ByVal group As RadRibbonBarButtonGroup, ByVal colorBoxesPerRow As Integer)
			group.Orientation = Orientation.Vertical
			group.ShowBackColor = False
			group.ShowBorder = False

			Dim rows As Integer = 3

			For i As Integer = 1 To rows
				Dim newRow As New RadRibbonBarButtonGroup()
				newRow.Name = "row" & i
				newRow.Orientation = Orientation.Horizontal
				newRow.ShowBackColor = False
				newRow.ShowBorder = False
				newRow.Padding = New Padding(2)
				group.Items.Add(newRow)

				Me.AddColorButtonsInButtonGroup(i - 1, colorBoxesPerRow, newRow)
			Next i
		End Sub

		Private Sub AddColorButtonsInButtonGroup(ByVal rowIndex As Integer, ByVal colorBoxesPerRow As Integer, ByVal group As RadRibbonBarButtonGroup)
			Dim count As Integer = colorBoxesPerRow

			For i As Integer = 1 To count
				Dim button As New RadButtonElement()
				button.Name = "button" & rowIndex + i
				button.Text = String.Empty
				button.Margin = New Padding(1)
				button.MinSize = New Size(16, 16)
				button.MaxSize = New Size(16, 16)
				button.ShowBorder = False

				Dim fillPrimitive As FillPrimitive = button.ButtonFillElement
				fillPrimitive.Margin = New Padding(1)
				fillPrimitive.BackColor = PaleteColors(rowIndex, i - 1)
				fillPrimitive.GradientStyle = GradientStyles.Solid

				group.Items.Add(button)
			Next i
		End Sub

		Private Sub radButtonElement49_Click(ByVal sender As Object, ByVal e As EventArgs)
			Using dialog As New RadColorDialog()
				CType(dialog.ColorDialogForm, RadForm).ThemeName = Me.GetExampleDefaultTheme()
				dialog.ShowDialog()
			End Using
		End Sub

		Private Sub radRibbonBarBackstageView1_ItemClicked(ByVal sender As Object, ByVal e As BackstageItemEventArgs)
			If TypeOf e.Item Is BackstageButtonItem Then
				Me.radRibbonBarBackstageView1.HidePopup()
			End If
		End Sub

		Private Sub radButtonSetBlackTheme_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.ApplicationMenu
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2007Black")
		End Sub

		Private Sub radButtonSetDefaultTheme_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub radButtonSetSilverTheme_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.ApplicationMenu
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2007Silver")
		End Sub

		Private Sub radGalleryElement1_GalleryItemHover(ByVal sender As Object, ByVal args As GalleryItemHoverEventArgs)
			Me.pictureBoxTool.Image = args.GalleryItem.Image
		End Sub

		Private Sub radButtonElement54_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Black")
		End Sub

		Private Sub radButtonElement55_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Blue")
		End Sub

		Private Sub radButtonElement56_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView
			ThemeResolutionService.ApplyThemeToControlTree(Me, "Office2010Silver")
		End Sub

		Private Sub SetThemeName(ByVal themeName As String)
			Me.radRibbonBar1.ThemeName = themeName
			Me.radScrollablePanel1.ThemeName = themeName
			Me.radRibbonBarBackstageView1.ThemeName = themeName
			Me.radSeparator1.ThemeName = themeName
			Me.radSeparator2.ThemeName = themeName
			Me.radSeparator3.ThemeName = themeName

			Me.radButton1.ThemeName = themeName
			Me.radButton2.ThemeName = themeName
			Me.radButton3.ThemeName = themeName
			Me.radButton4.ThemeName = themeName
			Me.radButton5.ThemeName = themeName
			Me.radButton6.ThemeName = themeName
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGalleryElement1.GalleryItemHover, AddressOf radGalleryElement1_GalleryItemHover
			AddHandler radButtonElement49.Click, AddressOf radButtonElement49_Click
			AddHandler radButtonElement46.Click, AddressOf radButtonSetBlackTheme_Click
			AddHandler radButtonElement50.Click, AddressOf radButtonSetDefaultTheme_Click
			AddHandler radButtonElement51.Click, AddressOf radButtonSetSilverTheme_Click
			AddHandler radButtonElement45.Click, AddressOf radButtonElement49_Click
			AddHandler radButtonElement54.Click, AddressOf radButtonElement54_Click
			AddHandler radButtonElement55.Click, AddressOf radButtonElement55_Click
			AddHandler radButtonElement56.Click, AddressOf radButtonElement56_Click
		End Sub
	End Class
End Namespace