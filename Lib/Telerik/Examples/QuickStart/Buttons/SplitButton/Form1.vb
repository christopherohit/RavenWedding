Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.Buttons.SplitButton
	''' <summary>
	''' Main class for the split button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
            Me.SelectedControl = radSplitButton3
		End Sub

		Private rotatedElement As RadElement

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			rotatedElement = radButton1.RootElement.Children(0)
			Me.radButton1.ButtonElement.ShowBorder = False
			Me.radButton1.Image = Telerik.WinControls.ResFinder.WinFormsLogoWithText
			Me.radButton1.AutoSize = True
			SetDefaultItem(radMenuItem1)
		End Sub

		Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			rotatedElement.AngleTransform += 10f
			SetDefaultItem(radMenuItem1)
		End Sub

		Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
			rotatedElement.AngleTransform -= 10f
			SetDefaultItem(radMenuItem2)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			rotatedElement.AngleTransform = 0f
		End Sub

		Private Sub SetDefaultItem(ByVal item As RadMenuItem)
			radSplitButton3.DefaultItem = item
			radSplitButton3.ImageIndex = item.ImageIndex
			radSplitButton3.Text = item.Text
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem1.Click, AddressOf radMenuItem1_Click
			AddHandler radMenuItem2.Click, AddressOf radMenuItem2_Click
		End Sub
	End Class
End Namespace