Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.ManipulateData.OptionsTree
	Partial Public Class Form1
		Inherits TreeExamplesControl
        Private bottomRightBitmap As Bitmap = My.Resources.TV_car
		Private suspendCheckTypeChange As Boolean = False

		Public Sub New()
			InitializeComponent()

			Me.radTreeView1.ExpandAll()
			AddHandler radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_SelectedNodeChanged
			Me.radTreeView1.SelectedNode = Me.radTreeView1.Nodes(0)
			Me.rcbTriState.IsChecked = Me.radTreeView1.TriStateMode
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler rrbNone.ToggleStateChanged, AddressOf rrbNone_ToggleStateChanged
			AddHandler rrbShowRadioButton.ToggleStateChanged, AddressOf rbbShowRadioButton_ToggleStateChanged
			AddHandler rrbShowCheckBox.ToggleStateChanged, AddressOf rrbShowCheckBox_ToggleStateChanged
			AddHandler rcbTriState.ToggleStateChanged, AddressOf rcbTriState_ToggleStateChanged
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Car configurator"
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radTreeView1.AllowEdit = False
		End Sub

		Private Sub SetEnabled(ByVal groupBox As RadGroupBox, ByVal value As Boolean)
			For Each child As Control In groupBox.Controls
				child.Enabled = value
			Next child
		End Sub

		Private Sub SetSelectedNodeNodeCheckType(ByVal type As CheckType)
			Dim node As RadTreeNode = Me.radTreeView1.SelectedNode

			If node IsNot Nothing AndAlso (Not suspendCheckTypeChange) Then
				node.CheckType = type
			End If
		End Sub

		Private Sub rcbTriState_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.TriStateMode = Me.rcbTriState.IsChecked
		End Sub

		Private Sub rrbShowCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.SetSelectedNodeNodeCheckType(CheckType.CheckBox)
		End Sub

		Private Sub rbbShowRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.SetSelectedNodeNodeCheckType(CheckType.RadioButton)
		End Sub

		Private Sub rrbNone_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.SetSelectedNodeNodeCheckType(CheckType.None)
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			Dim selectedNode As RadTreeNode = Me.radTreeView1.SelectedNode

			If selectedNode IsNot Nothing Then
				Me.SetEnabled(Me.radGroupBox1, True)
				Me.suspendCheckTypeChange = True
				Me.rrbShowCheckBox.IsChecked = selectedNode.CheckType = CheckType.CheckBox
				Me.rrbShowRadioButton.IsChecked = selectedNode.CheckType = CheckType.RadioButton
				Me.rrbNone.IsChecked = selectedNode.CheckType = CheckType.None
				Me.suspendCheckTypeChange = False

			Else
				Me.SetEnabled(Me.radGroupBox1, False)
			End If
		End Sub
	End Class
End Namespace
