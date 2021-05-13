Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Globalization.RightToLeft
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_email

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radTreeView1
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxRightToLeft.ToggleStateChanged, AddressOf radCheckBoxRightToLeft_ToggleStateChanged
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

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radCheckBoxRightToLeft.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			LoadData()
			Me.radTreeView1.ExpandAll()
			Me.radTreeView1.SelectedNode = Me.radTreeView1.Nodes(0).Nodes(3)
		End Sub

		Private Sub radCheckBoxRightToLeft_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radCheckBoxRightToLeft.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes

            Else
                Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No

            End If
		End Sub
	End Class
End Namespace