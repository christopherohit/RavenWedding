
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Customize.Basics
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_email

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub LoadData()
			Me.radTreeView1.Nodes.Add(New RadTreeNode("Personal Folders", Resources.TV_RootFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Deleted Items", Resources.TV_RecycleBin))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Drafts", Resources.TV_DraftFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Inbox", Resources.TV_InboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Junk E-mails", Resources.TV_JunkFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Outbox", Resources.TV_OutboxFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Sent Items", Resources.TV_SentFolder))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Search Folder", Resources.TV_SearchFolder))

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes.Add(New RadTreeNode("Folders", Resources.TV_Folder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("From Follow up", Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Large Mail", Resources.TV_SearchFolder))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Unread Mail", Resources.TV_SearchFolder))

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).ItemHeight = 50
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxShowLines.ToggleStateChanged, AddressOf radCheckBoxShowLines_ToggleStateChanged
			AddHandler radCheckBoxAlternatingRowColor.ToggleStateChanged, AddressOf radCheckBoxAlternatingRowColor_ToggleStateChanged
			AddHandler radButtonAlternatingRowColor.Click, AddressOf radButtonAlternatingRowColor_Click
			AddHandler radSpinEditorItemHeight.ValueChanged, AddressOf radSpinEditorItemHeight_ValueChanged
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radCheckBoxShowRootLines.ToggleStateChanged, AddressOf radCheckBoxShowRootLines_ToggleStateChanged
			AddHandler radCheckBoxExpandCollapse.ToggleStateChanged, AddressOf radCheckBoxExpandCollapse_ToggleStateChanged
			AddHandler radCheckBoxFullRowSelect.ToggleStateChanged, AddressOf radCheckBoxFullRowSelect_ToggleStateChanged
			AddHandler radButtonLineColor.Click, AddressOf radButtonLineColor_Click
			AddHandler radCheckBoxAutoSizeItems.ToggleStateChanged, AddressOf radCheckBoxAutoSizeItems_ToggleStateChanged
			AddHandler radCheckBoxAnimations.ToggleStateChanged, AddressOf radCheckBoxAnimations_ToggleStateChanged
			AddHandler radSpinEditorItemSpacing.ValueChanged, AddressOf radSpinEditorItemSpacing_ValueChanged
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
				Return "Mail"
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radTreeView1.ItemHeight = 27

			Me.radCheckBoxShowLines.IsChecked = Me.radTreeView1.ShowLines
			Me.radCheckBoxShowRootLines.IsChecked = Me.radTreeView1.ShowRootLines
			Me.radCheckBoxExpandCollapse.IsChecked = Me.radTreeView1.ShowExpandCollapse
			Me.radCheckBoxFullRowSelect.IsChecked = Me.radTreeView1.FullRowSelect
			Me.radCheckBoxAlternatingRowColor.IsChecked = Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor
			Me.radCheckBoxAutoSizeItems.IsChecked = Me.radTreeView1.TreeViewElement.AutoSizeItems
			Me.radSpinEditorItemHeight.Value = Me.radTreeView1.ItemHeight
			Me.radSpinEditorItemSpacing.Value = Me.radTreeView1.SpacingBetweenNodes

			Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = Me.radTreeView1.TreeViewElement.AlternatingRowColor

			Me.radButtonLineColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = Me.radTreeView1.LineColor
			Me.radButtonLineColor.Enabled = False
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.AllowDefaultContextMenu = True

			LoadData()

			Me.radTreeView1.ExpandAll()
			Me.radTreeView1.Nodes(0).Nodes(1).Current = True
			Me.radTreeView1.Nodes(0).Nodes(1).Selected = True
			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True

			Me.radDropDownList1.SelectedIndex = 2
			Me.radDropDownList1.Enabled = False

			Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
			Me.radTreeView1.AllowPlusMinusAnimation = False
			Me.radTreeView1.PlusMinusAnimationStep = 1
		End Sub

		Private Sub radButtonAlternatingRowColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As New RadColorDialog()
            DirectCast(dialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName
            dialog.SelectedColor = Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radTreeView1.TreeViewElement.AlternatingRowColor = dialog.SelectedColor
			End If
		End Sub

		Private Sub radButtonLineColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As New RadColorDialog()
            DirectCast(dialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName
            dialog.SelectedColor = Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radTreeView1.LineColor = dialog.SelectedColor
			End If
		End Sub

		Private Sub radSpinEditorItemHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTreeView1.ItemHeight = CInt(Fix(radSpinEditorItemHeight.Value))
		End Sub

		Private Sub radSpinEditorItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTreeView1.SpacingBetweenNodes = CInt(Fix(radSpinEditorItemSpacing.Value))
		End Sub

		Private Sub radCheckBoxAutoSizeItems_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.TreeViewElement.AutoSizeItems = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radSpinEditorItemHeight.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			If Me.radSpinEditorItemHeight.Enabled Then
				Me.radTreeView1.Nodes(0).Nodes(2).Nodes(0).ItemHeight = 50
			End If
		End Sub

		Private Sub radCheckBoxAlternatingRowColor_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButtonAlternatingRowColor.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxFullRowSelect_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.FullRowSelect = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxExpandCollapse_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.ShowExpandCollapse = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxShowRootLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.ShowRootLines = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxShowLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.ShowLines = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButtonLineColor.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radDropDownList1.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTreeView1.LineStyle = CType(e.Position, TreeLineStyle)
		End Sub

		Private Sub radCheckBoxAnimations_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radTreeView1.ExpandAnimation = ExpandAnimation.Opacity
				Me.radTreeView1.AllowPlusMinusAnimation = True
			Else
				Me.radTreeView1.ExpandAnimation = ExpandAnimation.None
				Me.radTreeView1.AllowPlusMinusAnimation = False
			End If
		End Sub
	End Class
End Namespace
