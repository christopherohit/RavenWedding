Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView
	Public Class TreeExamplesControl
		Inherits ExamplesForm
		Private topRightBitmap As Bitmap = Resources.TV_gradient

		Public Sub New()
		End Sub

		Public Overridable ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property HeaderText() As String
			Get
				Return ""
			End Get
		End Property

		Public Overridable ReadOnly Property TopRightImage() As Bitmap
			Get
				Return Me.topRightBitmap
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If TreeControl IsNot Nothing Then
				Me.TreeControl.ItemHeight = 27
				Me.TreeControl.ShowLines = False
				Me.TreeControl.FullRowSelect = True
				Me.TreeControl.ExpandAnimation = ExpandAnimation.None
				'this.headerPanel.Text = HeaderText;
				Me.TreeControl.AllowEdit = True
				Me.TreeControl.AllowAdd = False
				Me.TreeControl.AllowRemove = False
				Me.TreeControl.AllowDefaultContextMenu = True
				Me.TreeControl.Size = New Size(300, 0)
				Me.TreeControl.Dock = DockStyle.Left
			End If
		End Sub

		Protected Overrides Sub WireEvents()

		End Sub
	End Class
End Namespace
