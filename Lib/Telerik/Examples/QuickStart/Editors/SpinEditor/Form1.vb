Imports System.ComponentModel
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.SpinEditor

	''' <summary>
	''' example forms
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private eventListItemFont As Font

		Public Sub New()
			InitializeComponent()

			eventListItemFont = New Font("Lucida Sans Unicode", 7.2f)

			AddHandler radSpinDemo.ValueChanging, AddressOf radSpinEdit1_ValueChanging
			AddHandler radSpinDemo.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radSpinDemo.RightToLeftChanged, AddressOf radSpinEditor1_RightToLeftChanged
			AddHandler radSpinDemo.PropertyChanged, AddressOf radSpinEditor1_PropertyChanged
		End Sub

		Private Sub radSpinEditor1_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			Dim item As New RadListDataItem()
			item.Font = eventListItemFont
			item.Text = "PropertyChanged" & vbLf
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub radSpinEditor1_RightToLeftChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As New RadListDataItem()
			item.Font = eventListItemFont
			item.Text = "RightToLeftChanged fired" & vbLf
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As New RadListDataItem()
			item.Font = eventListItemFont
			item.Text = "ValueChanged fired" & vbLf
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub radSpinEdit1_ValueChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ValueChangingEventArgs)
			Dim item As New RadListDataItem()
			item.Font = eventListItemFont
			item.Text = "ValueChanging fired" & vbLf
			Me.radListBox1.Items.Add(item)
		End Sub

		Private Sub OnCheckRightToLeft_StateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radSpinDemo.RightToLeft = If(Me.radCheckBox1.Checked, RightToLeft.Yes, RightToLeft.No)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radListBox1.Items.Clear()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf OnCheckRightToLeft_StateChanged
		End Sub
	End Class
End Namespace