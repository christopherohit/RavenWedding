Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
	Public Class BrowseEditor
		Inherits BaseGridEditor
'INSTANT VB NOTE: The variable filter was renamed since Visual Basic does not allow class members with the same name:
		Private filter_Renamed As String
'INSTANT VB NOTE: The variable endEditOnLostFocus was renamed since Visual Basic does not allow class members with the same name:
		Private endEditOnLostFocus_Renamed As Boolean = True

		Public Overrides Property Value() As Object
			Get
				Dim editor As BrowseEditorElement = CType(Me.EditorElement, BrowseEditorElement)
				Return editor.TextBox.Text
			End Get
			Set(ByVal value As Object)
				Dim editor As BrowseEditorElement = CType(Me.EditorElement, BrowseEditorElement)
				If value IsNot Nothing AndAlso value IsNot DBNull.Value Then
					editor.TextBox.Text = value.ToString()
				Else
					editor.TextBox.Text = ""
				End If
			End Set
		End Property

		Public Overrides ReadOnly Property EndEditOnLostFocus() As Boolean
			Get
				Return endEditOnLostFocus_Renamed
			End Get
		End Property

		Public Property Filter() As String
			Get
				Return filter_Renamed
			End Get
			Set(ByVal value As String)
				filter_Renamed = value
			End Set
		End Property

		Public Overrides Sub Initialize(ByVal owner As Object, ByVal value As Object)
			MyBase.Initialize(owner, value)

			Me.Filter = "JPEG files|*.jpg|All files|*.*"
		End Sub

		Public Overrides Sub BeginEdit()
			MyBase.BeginEdit()
			Dim editor As BrowseEditorElement = CType(Me.EditorElement, BrowseEditorElement)
			editor.TextBox.SelectAll()
			editor.TextBox.HostedControl.Focus()
			AddHandler editor.TextBox.TextChanging, AddressOf TextBox_TextChanging
			AddHandler editor.TextBox.TextChanged, AddressOf TextBox_TextChanged
			AddHandler editor.TextBox.KeyDown, AddressOf TextBox_KeyDown
			AddHandler editor.Button.Click, AddressOf Button_Click

		End Sub

		Public Overrides Function EndEdit() As Boolean
			Dim editor As BrowseEditorElement = CType(Me.EditorElement, BrowseEditorElement)
			RemoveHandler editor.TextBox.TextChanging, AddressOf TextBox_TextChanging
			RemoveHandler editor.TextBox.TextChanged, AddressOf TextBox_TextChanged
			RemoveHandler editor.TextBox.KeyDown, AddressOf TextBox_KeyDown
			RemoveHandler editor.Button.Click, AddressOf Button_Click
			Return MyBase.EndEdit()
		End Function

		Protected Overrides Function CreateEditorElement() As RadElement
			Return New BrowseEditorElement()
		End Function

		Private Sub TextBox_TextChanging(ByVal sender As Object, ByVal e As TextChangingEventArgs)
			Dim args As New ValueChangingEventArgs(e.NewValue)
			args.OldValue = e.OldValue
			OnValueChanging(args)
			e.Cancel = args.Cancel
		End Sub

		Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			OnValueChanged()
		End Sub

		Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim grid As RadGridView = TryCast((CType(sender, RadElement)).ElementTree.Control, RadGridView)
			If grid IsNot Nothing Then
				Select Case e.KeyCode
					Case Keys.Escape, Keys.Enter, Keys.Up, Keys.Down
						grid.GridBehavior.ProcessKeyDown(e)
				End Select
			End If
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
			endEditOnLostFocus_Renamed = False
			Dim editor As BrowseEditorElement = CType(Me.EditorElement, BrowseEditorElement)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = filter_Renamed
			dialog.FileName = editor.TextBox.Text
			If dialog.ShowDialog() = DialogResult.OK Then
				editor.TextBox.Text = dialog.FileName
			End If
			'editor.TextBox.SelectAll();
			'editor.TextBox.Focus();
			endEditOnLostFocus_Renamed = True
			CType(editor.ElementTree.Control, RadGridView).EndEdit()
		End Sub

		Public Overrides ReadOnly Property DataType() As Type
			Get
				Return GetType(String)
			End Get
		End Property
	End Class
End Namespace
