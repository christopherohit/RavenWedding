Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Editors
	Public Class VirtualGridTrackBarEditor
		Inherits BaseVirtualGridEditor
		Public Overrides Property Value() As Object
			Get
				Return Me.TrackBarElement.Value
			End Get
			Set
				If Not Value Is Nothing AndAlso Not Value Is DBNull.Value Then
					Me.TrackBarElement.Value = Convert.ToInt32(Value)
				Else
					Me.TrackBarElement.Value = 0
				End If
			End Set
		End Property

		Public ReadOnly Property TrackBarElement() As RadTrackBarEditorElement
			Get
				Return TryCast(Me.EditorElement, RadTrackBarEditorElement)
			End Get
		End Property

		Public Property Minimum() As Integer
			Get
				Return CInt(Fix(Me.TrackBarElement.Minimum))
			End Get
			Set
				Me.TrackBarElement.Minimum = Value
			End Set
		End Property

		Public Property Maximum() As Integer
			Get
				Return CInt(Fix(Me.TrackBarElement.Maximum))
			End Get
			Set
				Me.TrackBarElement.Maximum = Value
			End Set
		End Property

		Public Property TickFrequency() As Integer
			Get
				Return Me.TrackBarElement.TickFrequency
			End Get
			Set
				Me.TrackBarElement.TickFrequency = Value
			End Set
		End Property

		Public Overrides Sub Initialize(ByVal owner As Object, ByVal value As Object)
			MyBase.Initialize(owner, value)

			Me.EditorElement.Focus()
			Me.TrackBarElement.Value = Convert.ToInt32(value)
		End Sub

		Public Overrides Sub BeginEdit()
			MyBase.BeginEdit()

            CType(Me.EditorElement.Parent, VirtualGridCellElement).Text = Me.Value.ToString() & " %"
			AddHandler (CType(EditorElement, RadTrackBarEditorElement)).TrackPositionChanged, AddressOf TrackBarEditor_TrackPositionChanged
		End Sub

		Public Overrides Function EndEdit() As Boolean
			RemoveHandler (CType(EditorElement, RadTrackBarEditorElement)).TrackPositionChanged, AddressOf TrackBarEditor_TrackPositionChanged
			Return MyBase.EndEdit()
		End Function

		Private Sub TrackBarEditor_TrackPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(Me.EditorElement.Parent, VirtualGridCellElement).Text = Me.Value.ToString() & " %"
			OnValueChanged()
		End Sub

		Protected Overrides Function CreateEditorElement() As RadElement
			Return New RadTrackBarEditorElement(Me)
		End Function

		Public Overrides ReadOnly Property DataType() As Type
			Get
				Return GetType(Int32)
			End Get
		End Property
	End Class
End Namespace
