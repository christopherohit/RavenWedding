Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
	''' <summary>
	''' Form code
	''' </summary>
	Partial Public Class Form1
        Inherits TreeExamplesControl

        Private bottomRightBitmap As Bitmap = My.Resources.TV_email
        Private clickedNode As RadTreeNode

        Public Sub New()
            InitializeComponent()

            Me.radLblSelectedNode.Text = ""
            Me.radLblSelectedItem.Text = ""

            Me.SelectedControl = Me.radTreeViewDemo
            Me.radTreeViewDemo.AllowEdit = True

            AddHandler radContextMenu1.DropDownOpening, AddressOf radContextMenu1_DropDownOpening
            AddHandler radTreeViewDemo.SelectedNodeChanged, AddressOf radTreeViewDemo_SelectedNodeChanged
        End Sub

        Public Overrides ReadOnly Property TreeControl() As RadTreeView
            Get
                Return Me.radTreeViewDemo
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

            AddHandler radMenuItem1.Click, AddressOf radMenuItem1_Click
            AddHandler radMenuItem2.Click, AddressOf radMenuItem2_Click
            AddHandler radMenuItem4.Click, AddressOf radMenuItem4_Click
            AddHandler radMenuItem5.Click, AddressOf radMenuItem5_Click

        End Sub

        Private Sub SetLabel(ByVal sender As Object)
            Dim item As RadMenuItem = TryCast(sender, RadMenuItem)

            If item IsNot Nothing Then
                radLblSelectedItem.Text = item.Text
            End If
        End Sub

        Private Sub radContextMenu1_DropDownOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

            Dim mousePosition As Point = Me.radTreeViewDemo.PointToClient(Control.MousePosition)
            Dim nodeElement As TreeNodeElement = TryCast(Me.radTreeViewDemo.ElementTree.GetElementAtPoint(mousePosition), TreeNodeElement)

            If (nodeElement Is Nothing) Then
                Return
            End If

            Dim node As RadTreeNode = nodeElement.Data

            If (node Is Nothing) Then
                Return
            End If

            Me.clickedNode = node

            If node IsNot Nothing Then
                Me.radMenuItem1.Enabled = node.Enabled
                Me.radMenuItem4.Enabled = node.Enabled
                Me.radMenuItem5.Enabled = node.Enabled
                If node.Enabled Then
                    Me.radMenuItem2.Text = "Disable"
                Else
                    Me.radMenuItem2.Text = "Enable"
                End If
            End If

        End Sub

        Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)

            SetLabel(sender)

            If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
                Me.radTreeViewDemo.BeginEdit()
            End If

        End Sub

        Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)

            SetLabel(sender)

            If (Me.clickedNode Is Nothing) Then
                Return
            End If

            Me.clickedNode.Enabled = Not Me.clickedNode.Enabled

        End Sub

        Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)

            SetLabel(sender)

            If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
                Me.radTreeViewDemo.SelectedNode.Remove()
            End If

        End Sub

        Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)

            SetLabel(sender)

            If Me.radTreeViewDemo.SelectedNode IsNot Nothing Then
                Me.radTreeViewDemo.SelectedNode.Expand()
                Dim newNode As RadTreeNode = Me.radTreeViewDemo.SelectedNode.Nodes.Add("New Folder")
                If newNode IsNot Nothing Then
                    Me.radTreeViewDemo.SelectedNode = newNode
                    Me.radTreeViewDemo.BeginEdit()
                End If
            End If

        End Sub

        Private Sub radTreeViewDemo_SelectedNodeChanged(sender As Object, e As RadTreeViewEventArgs)
            Me.radLblSelectedNode.Text = e.Node.Text
        End Sub

    End Class

End Namespace
