Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
	Public Class TrackBarEditor
		Inherits BaseGridEditor
		Public Overrides Property Value() As Object
			Get
				Return Me.TrackBarElement.Value
			End Get
			Set(ByVal value As Object)
				If value IsNot Nothing AndAlso value IsNot DBNull.Value Then
					Me.TrackBarElement.Value = Convert.ToInt32(value)
				Else
					Me.TrackBarElement.Value = 0
				End If
			End Set
		End Property

		Public ReadOnly Property TrackBarElement() As TrackBarEditorElement
			Get
				Return TryCast(Me.EditorElement, TrackBarEditorElement)
			End Get
		End Property

		Public Property Minimum() As Integer
			Get
				Return CInt(Fix(Me.TrackBarElement.Minimum))
			End Get
			Set(ByVal value As Integer)
				Me.TrackBarElement.Minimum = value
			End Set
		End Property

		Public Property Maximum() As Integer
			Get
				Return CInt(Fix(Me.TrackBarElement.Maximum))
			End Get
			Set(ByVal value As Integer)
				Me.TrackBarElement.Maximum = value
			End Set
		End Property

		Public Property TickFrequency() As Integer
			Get
				Return Me.TrackBarElement.TickFrequency
			End Get
			Set(ByVal value As Integer)
				Me.TrackBarElement.TickFrequency = value
			End Set
		End Property

		Public Overrides Sub Initialize(ByVal owner As Object, ByVal value As Object)
			MyBase.Initialize(owner, value)

			Me.EditorElement.Focus()
			Me.TrackBarElement.Value = CInt(Fix(value))
		End Sub

		Public Overrides Sub BeginEdit()
			MyBase.BeginEdit()

            CType(Me.EditorElement.Parent, GridCellElement).Text = Me.Value.ToString() & " %"
			AddHandler (CType(EditorElement, TrackBarEditorElement)).TrackPositionChanged, AddressOf TrackBarEditor_TrackPositionChanged
		End Sub

		Public Overrides Function EndEdit() As Boolean
			RemoveHandler (CType(EditorElement, TrackBarEditorElement)).TrackPositionChanged, AddressOf TrackBarEditor_TrackPositionChanged
			Return MyBase.EndEdit()
		End Function

		Private Sub TrackBarEditor_TrackPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(Me.EditorElement.Parent, GridCellElement).Text = Me.Value.ToString() & " %"
			OnValueChanged()
		End Sub

		Protected Overrides Function CreateEditorElement() As RadElement
			Return New TrackBarEditorElement(Me)
		End Function

		Public Overrides ReadOnly Property DataType() As Type
			Get
				Return GetType(Int32)
			End Get
		End Property

	End Class
End Namespace
