Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		'protected override void OnSizeChanged(EventArgs e)
		'{
		'    base.OnSizeChanged(e);
		'    if (this.radSplitContainer1 != null)
		'    {
		'        int width = this.ClientSize.Width;
		'        int height = this.ClientSize.Height;
		'        this.radSplitContainer1.Location = new Point((width - radSplitContainer1.Size.Width) / 2, (height - radSplitContainer1.Size.Height) / 2);
		'    }
		'}


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim button As New RadButtonElement()
			button.Text = "button"
			button.MinSize = New Size(button.MinSize.Width, 24)
			surface1.BackColor = Color.Transparent
			surface1.Element.Children.Add(New SurfaceObject(65, 154, button))
			AddHandler surface1.Element.CurrentObjectChanged, AddressOf Element_CurrentObjectChanged
			surface1.Element.CurrentObject = CType(surface1.Element.Children(0), SurfaceObject)

			radButtonRemove.Enabled = False
		End Sub

		Private Sub Element_CurrentObjectChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim currentObject As SurfaceObject = (CType(sender, SurfaceElement)).CurrentObject
			Me.radPropertyGrid1.SelectedObject = New RadElementWrapper(currentObject, CType(currentObject.Children(0), RadItem))
		End Sub

		Private Sub radMenuItem1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim button As New RadButtonElement()
			button.Text = "button"
			button.MinSize = New Size(button.MinSize.Width, 24)
			surface1.Element.Children.Add(New SurfaceObject(10, 10, button))
			radButtonRemove.Enabled = True
			surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
		End Sub

		Private Sub radMenuItem2_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim label As New RadLabelElement()
			label.Text = "label"
			surface1.Element.Children.Add(New SurfaceObject(10, 10, label))
			radButtonRemove.Enabled = True
			surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
		End Sub

		Private Sub radMenuItem3_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim checkbox As New RadCheckBoxElement()
			checkbox.Text = "checkbox"
			surface1.Element.Children.Add(New SurfaceObject(10, 10, checkbox))
			radButtonRemove.Enabled = True
			surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
		End Sub

		Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim radioButton As New RadRadioButtonElement()
			radioButton.Text = "radio button"
			surface1.Element.Children.Add(New SurfaceObject(10, 10, radioButton))
			radButtonRemove.Enabled = True
			surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
		End Sub

		Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollbar As New RadScrollBarElement()
			surface1.Element.Children.Add(New SurfaceObject(10, 10, scrollbar))
			radButtonRemove.Enabled = True
			surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
		End Sub

		Private Sub radButtonRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
			If surface1.Element.Children.Count > 1 Then
				surface1.Element.Children.Remove(surface1.Element.CurrentObject)
				surface1.Element.CurrentObject = CType(surface1.Element.Children(surface1.Element.Children.Count - 1), SurfaceObject)
				surface1.Element.Invalidate()
			End If

			radButtonRemove.Enabled = surface1.Element.Children.Count > 1
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem1.Click, AddressOf radMenuItem1_Click_1
			AddHandler radMenuItem2.Click, AddressOf radMenuItem2_Click_1
			AddHandler radMenuItem3.Click, AddressOf radMenuItem3_Click_1
			AddHandler radMenuItem4.Click, AddressOf radMenuItem4_Click
			AddHandler radMenuItem5.Click, AddressOf radMenuItem5_Click
			AddHandler radButtonRemove.Click, AddressOf radButtonRemove_Click
		End Sub
	End Class
End Namespace
