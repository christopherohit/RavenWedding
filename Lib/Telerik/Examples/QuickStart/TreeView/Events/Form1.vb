Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Events
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_email
		Private insertIndex As Integer = 0
		Private loading As Boolean = True

		Public Sub New()
			InitializeComponent()

			AddHandler Me.radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_Selected
			AddHandler radTreeView1.SelectedNodeChanging, AddressOf radTreeView1_Selecting
			AddHandler radTreeView1.EditorRequired, AddressOf radTreeView1_EditorRequired
			AddHandler radTreeView1.Editing, AddressOf radTreeView1_Editing
			AddHandler radTreeView1.Edited, AddressOf radTreeView1_Edited
			AddHandler radTreeView1.ValueChanging, AddressOf radTreeView1_ValueChanging
			AddHandler radTreeView1.ValueChanged, AddressOf radTreeView1_ValueChanged
			AddHandler radTreeView1.NodeExpandedChanging, AddressOf radTreeView1_NodeExpandedChanging
			AddHandler radTreeView1.NodeExpandedChanged, AddressOf radTreeView1_NodeExpandedChanged

			Me.SelectedControl = Me.radTreeView1
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler clearEventsBtn.Click, AddressOf clearEventsBtn_Click
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

		End Sub

		Private Sub AddEventRoot(ByVal text As String)
			Dim item As New RadListDataItem()
			item.Text = text
			Me.AddEventRoot(item)
		End Sub

		Private Sub AddEventRoot(ByVal item As RadListDataItem)
			If Not loading Then
				item.Text = "<html><b>" & item.Text
				radListBox1.Items.Insert(insertIndex, item)
				insertIndex += 1
				radListBox1.SelectedIndex = insertIndex - 1
				radListBox1.ListElement.ScrollToItem(item)
			End If
		End Sub

		Private Sub AddTextToListBox(ByVal item As RadListDataItem)
			If Not loading Then
				If radListBox1.Items.Count > 100 Then
					radListBox1.Items.Clear()
					insertIndex = 0
				End If
				radListBox1.Items.Insert(insertIndex, item)
				insertIndex += 1
				radListBox1.SelectedIndex = insertIndex - 1
				radListBox1.ListElement.ScrollToItem(item)
			End If
		End Sub

		Private Sub AddTextToListBox(ByVal text As String)
			If Not loading Then
				Dim label As New RadListDataItem()
				label.Text = text
				AddTextToListBox(label)
			End If
		End Sub

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			LoadData()

			Me.radTreeView1.AllowAdd = True
			Me.radTreeView1.AllowRemove = True
			Me.radTreeView1.ExpandAll()

			loading = False
		End Sub

		Private Sub radTreeView1_Selecting(ByVal sender As Object, ByVal e As RadTreeViewCancelEventArgs)
			AddEventRoot("Selecting")
		End Sub

		Private Sub radTreeView1_Selected(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			AddEventRoot("Selected")
		End Sub

		Private Sub radTreeView1_NodeExpandedChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			AddEventRoot("NodeExpandedChanged")
		End Sub

		Private Sub radTreeView1_NodeExpandedChanging(ByVal sender As Object, ByVal e As RadTreeViewCancelEventArgs)
			AddEventRoot("NodeExpandedChanging")
		End Sub

		Private Sub radTreeView1_ValueChanged(ByVal sender As Object, ByVal e As TreeNodeValueChangedEventArgs)
			AddEventRoot("ValueChanged")
		End Sub

		Private Sub radTreeView1_ValueChanging(ByVal sender As Object, ByVal e As TreeNodeValueChangingEventArgs)
			AddEventRoot("ValueChanging")
		End Sub

		Private Sub radTreeView1_Edited(ByVal sender As Object, ByVal e As TreeNodeEditedEventArgs)
			AddEventRoot("Edited")
			AddTextToListBox(String.Format("    Node: {0}", e.Node.Text))
		End Sub

		Private Sub radTreeView1_Editing(ByVal sender As Object, ByVal e As TreeNodeEditingEventArgs)
			AddEventRoot("Editing")
			AddTextToListBox(String.Format("    Node: {0}", e.Node.Text))
		End Sub

		Private Sub radTreeView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			AddEventRoot("EditorRequired")
			AddTextToListBox(String.Format("    Editor type: {0}", e.EditorType.ToString()))
		End Sub

		Private Sub clearEventsBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
			insertIndex = 0
			Me.radListBox1.Items.Clear()
		End Sub

		#End Region
	End Class
End Namespace


