Imports System.Drawing.Drawing2D
Imports Telerik.Examples.WinControls.Forms.AboutBox
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Forms.FormTitleBarStatusStrip
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesRadForm
        Implements ISupportThemeName
        Implements ICustomThemeExamplesForm
		Private toolTip As RadToolTip
		Private textPadding As Integer = 3

		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Me.FormElement.TitleBar.HelpButton.Visibility = ElementVisibility.Visible
			Me.radGridView1.TableElement.RowHeight = 60
			Me.radGridView1.TableElement.Text = ""
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler timer1.Tick, AddressOf timer1_Tick
			AddHandler radMenuItem26.Click, AddressOf OnRadMenuItemChangeTheme_Click
			AddHandler radMenuItem22.Click, AddressOf OnRadMenuItemChangeTheme_Click
			AddHandler radMenuItem17.Click, AddressOf radMenuItem17_Click
			AddHandler radMenuItem12.Click, AddressOf OnRadMenuItemChangeTheme_Click
			AddHandler Me.FormClosing, AddressOf Form1_FormClosing
		End Sub

		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			If Me.toolTip IsNot Nothing Then
				Me.toolTip.Hide()
			End If
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radProgressBarElement1.Value1 < Me.radProgressBarElement1.Maximum Then
				Me.radProgressBarElement1.Value1 += 1
			Else
				Me.radProgressBarElement1.Value1 = Me.radProgressBarElement1.Minimum
			End If
		End Sub

		Private Sub OnRadMenuItemChangeTheme_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim menuItem As RadMenuItem = CType(sender, RadMenuItem)

			For Each sibling As RadMenuItem In menuItem.HierarchyParent.Items
				sibling.IsChecked = False
			Next sibling

			menuItem.IsChecked = True

			Dim themeName As String = CStr((menuItem).Tag)
			ChangeThemeName(Me, themeName)
		End Sub

		Private Sub ChangeThemeName(ByVal control As Control, ByVal themeName As String)
			Dim radControl As IComponentTreeHandler = TryCast(control, IComponentTreeHandler)
			If radControl IsNot Nothing Then
				radControl.ThemeName = themeName
			End If

			For Each child As Control In control.Controls
				ChangeThemeName(child, themeName)
			Next child
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
		End Sub

		Private Sub radMenuItem17_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim aboutBox As New RadAboutBox1()

			aboutBox.ThemeName = Me.ThemeName
			aboutBox.ShowDialog(Me)
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

		Private Sub radMenu1_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radMenu1.HelpRequested
			Dim text As String = "RadMenu is used to build attractive navigation systems."
			Me.ProcessHelpRequestedEvent(text, Me.radMenu1, 4000)
		End Sub

		Private Sub radGridView1_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radGridView1.HelpRequested
			Dim text As String = "RadGridView is complex control that allows you to display and edit tabular data from many different kinds of data sources."
			Me.ProcessHelpRequestedEvent(text, Me.radGridView1, 4500)
		End Sub

		Private Sub radPageView1_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radPageView1.HelpRequested
			Dim text As String = "RadPageView represents a control that has a collection of pages and displays one page at a time."
			Me.ProcessHelpRequestedEvent(text, Me.radPageView1, 4500)
		End Sub

		Private Sub radStatusBar1_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radStatusBar1.HelpRequested
			Dim text As String = "RadStatusStrip provides a status area that can be composed of any number of RadElement types:" & Environment.NewLine & "buttons, repeat buttons, image buttons, labels, panels, progress bars and separators."
			Me.ProcessHelpRequestedEvent(text, Me.radStatusBar1, 4500)
		End Sub

		Private Sub RadioButton_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radRadioButton3.HelpRequested, radRadioButton2.HelpRequested, radRadioButton1.HelpRequested
			Dim text As String = "RadRadioButton replaces the WinForms RadioButton control and adds robust data binding, state management, and design options."
			Me.ProcessHelpRequestedEvent(text, TryCast(sender, RadRadioButton), 4000)
		End Sub

		Private Sub CheckBox_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radCheckBox3.HelpRequested, radCheckBox2.HelpRequested, radCheckBox1.HelpRequested
			Dim text As String = "RadCheckBox is designed to provide an interface element that can represent an on or off state using a check mark."
			Me.ProcessHelpRequestedEvent(text, TryCast(sender, RadCheckBox), 4000)
		End Sub

		Private Sub Button_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles radButton3.HelpRequested, radButton2.HelpRequested, radButton1.HelpRequested
			Dim text As String = "RadButton gives you full control over the visual appearance." & Environment.NewLine & "RadButton supports themes, images, text(HTML like text) and backgrounds"

			Me.ProcessHelpRequestedEvent(text, TryCast(sender, RadButton), 4000)
		End Sub

		Private Sub ProcessHelpRequestedEvent(ByVal text As String, ByVal control As RadControl, ByVal duration As Integer)
            Dim mouseLocation As Point = control.PointToClient(System.Windows.Forms.Control.MousePosition)
			Dim visualItem As RadElement = control.ElementTree.GetElementAtPoint(mouseLocation)
			If visualItem IsNot Nothing Then
				Dim type As String = visualItem.GetType().Name
				text = "Element under mouse is: " & type & Environment.NewLine & text
			End If

			Me.ShowToolTip(text, duration)
		End Sub

		Private Sub ShowToolTip(ByVal text As String, ByVal duration As Integer)
			If Me.toolTip IsNot Nothing Then
				Me.toolTip.Hide()
				RemoveHandler Me.toolTip.Draw, AddressOf toolTip_Draw
				RemoveHandler Me.toolTip.Popup, AddressOf toolTip_Popup
				Me.toolTip = Nothing
			End If

			Me.toolTip = New RadToolTip()
			Me.toolTip.OwnerDraw = True
			AddHandler Me.toolTip.Draw, AddressOf toolTip_Draw
			AddHandler Me.toolTip.Popup, AddressOf toolTip_Popup

			Me.toolTip.Show(text, Control.MousePosition, duration)
		End Sub

		Private Sub toolTip_Popup(ByVal sender As Object, ByVal e As PopupEventArgs)
			' Add some space for text padding.
			e.ToolTipSize = New Size(e.ToolTipSize.Width + 2 * Me.textPadding, e.ToolTipSize.Height + 2 * Me.textPadding)
		End Sub

		Private Sub toolTip_Draw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
			Dim toolTipSize As Size = e.Bounds.Size

			Dim gradientBrush As New LinearGradientBrush(e.Bounds.Location, New Point(e.Bounds.Left, e.Bounds.Top + toolTipSize.Height), Color.FromArgb(253, 253, 253), Color.FromArgb(227, 227, 239))
			e.Graphics.FillRectangle(gradientBrush, New Rectangle(e.Bounds.Location, toolTipSize))
			e.DrawBorder()
			Dim textBounds As New Rectangle(e.Bounds.Location, toolTipSize)
			textBounds.X += textPadding
			textBounds.Y += textPadding
			e.Graphics.DrawString(e.ToolTipText, New Font("Segoe UI", 9f), Brushes.Black, textBounds.Location)
		End Sub
	End Class
End Namespace
