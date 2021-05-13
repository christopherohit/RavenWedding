Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Selection
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
			AddHandler radCheckBoxAllowMultiSelect.ToggleStateChanged, AddressOf radCheckBoxAllowMultiSelect_ToggleStateChanged
			AddHandler radButtonSelectAll.Click, AddressOf radButtonSelectAll_Click
			AddHandler radButtonClearSelection.Click, AddressOf radButtonClearSelection_Click
            AddHandler radButtonToggleSelection.Click, AddressOf radButtonToggleSelection_Click
            AddHandler RadCheckBoxAllowKeyboardSelecttion.ToggleStateChanged, AddressOf RadCheckBoxAllowKeyboardSelection_ToggleStateChanged
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
            LoadData()
            Me.radTreeView1.ExpandAll()
            Me.radTreeView1.MultiSelect = True
            Me.radTreeView1.AllowEdit = False
            Me.radTreeView1.KeyboardSearchEnabled = True
        End Sub

        Private Sub radCheckBoxAllowMultiSelect_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radTreeView1.MultiSelect = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub

        Private Sub radButtonSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radTreeView1.SelectAll()
        End Sub

        Private Sub radButtonClearSelection_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radTreeView1.ClearSelection()
        End Sub

        Private Sub radButtonToggleSelection_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radTreeView1.SelectedNode IsNot Nothing Then
                Me.radTreeView1.SelectedNode.Selected = Not Me.radTreeView1.SelectedNode.Selected
            End If
        End Sub

        Private Sub RadCheckBoxAllowKeyboardSelection_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radTreeView1.KeyboardSearchEnabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub
    End Class
End Namespace