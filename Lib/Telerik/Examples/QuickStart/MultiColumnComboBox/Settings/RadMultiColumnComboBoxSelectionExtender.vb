Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.MultiColumnComboBox.Settings
    <ToolboxItem(False)>
    Public Class RadMultiColumnComboBoxSelectionExtender
        Inherits System.ComponentModel.Component
        Private m_associatedRadMultiColumnComboBox As RadAutoCompleteBoxElement
        Private rows As New Dictionary(Of String, GridViewRowInfo)()
        Private associatedRadMultiColumnComboBox_Control As RadMultiColumnComboBox
        Private originalSize As Size = Size.Empty

        Public ReadOnly Property AutoCompleteBoxElement() As RadAutoCompleteBoxElement
            Get
                Return Me.m_associatedRadMultiColumnComboBox
            End Get
        End Property

        ''' <summary>
        ''' Gets the tokenized items.
        ''' </summary>
        Public ReadOnly Property Items() As RadTokenizedTextItemCollection
            Get
                Return Me.m_associatedRadMultiColumnComboBox.Items
            End Get
        End Property

        Public Property AssociatedRadMultiColumnComboBox() As RadMultiColumnComboBox
            Get
                Return Me.associatedRadMultiColumnComboBox_Control
            End Get
            Set(ByVal value As RadMultiColumnComboBox)
                Me.SetAssociatedRadMultiColumnComboBox(value)
            End Set
        End Property

        Private Sub SetAssociatedRadMultiColumnComboBox(ByVal radMultiColumnComboBox As RadMultiColumnComboBox)
            If radMultiColumnComboBox Is Nothing AndAlso Me.associatedRadMultiColumnComboBox_Control IsNot Nothing Then
                Me.SetAssociatedRadMultiColumnComboBoxCoreToNull()
            End If

            Me.SetAssociatedRadMultiColumnComboBoxCore(radMultiColumnComboBox)
        End Sub

        Private Sub SetAssociatedRadMultiColumnComboBoxCoreToNull()
            RemoveHandler Me.associatedRadMultiColumnComboBox_Control.HandleCreated, AddressOf associatedRadMultiColumnComboBox_HandleCreated
            RemoveHandler Me.associatedRadMultiColumnComboBox_Control.DataBindingComplete, AddressOf associatedRadMultiColumnComboBox_DataBindingComplete
            RemoveHandler Me.associatedRadMultiColumnComboBox_Control.EditorControl.ViewCellFormatting, AddressOf EditorControl_ViewCellFormatting
            RemoveHandler Me.associatedRadMultiColumnComboBox_Control.DropDownClosing, AddressOf radMultiColumnCombobox1_DropDownClosing
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Visible
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.Children(2).Children.Remove(m_associatedRadMultiColumnComboBox)
            Me.m_associatedRadMultiColumnComboBox.MaxSize = New Size(0, 0)
            Me.m_associatedRadMultiColumnComboBox.AutoCompleteDataSource = Nothing
            Me.associatedRadMultiColumnComboBox_Control.AutoSize = False
            Me.associatedRadMultiColumnComboBox_Control.Size = Me.originalSize

            For Each item As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Control.EditorControl.Rows
                item.Tag = Nothing
            Next item
            RemoveHandler Me.m_associatedRadMultiColumnComboBox.Items.CollectionChanged, AddressOf Items_CollectionChanged
            RemoveHandler Me.m_associatedRadMultiColumnComboBox.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            RemoveHandler Me.m_associatedRadMultiColumnComboBox.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            Me.m_associatedRadMultiColumnComboBox.Text = Me.associatedRadMultiColumnComboBox_Control.Text
            RemoveHandler Me.m_associatedRadMultiColumnComboBox.KeyDown, AddressOf autoCompleteBoxElement_KeyDown
            Me.associatedRadMultiColumnComboBox_Control = Nothing

            Me.rows.Clear()
        End Sub

        Private Sub SetAssociatedRadMultiColumnComboBoxCore(ByVal radMultiColumnComboBox As RadMultiColumnComboBox)
            If radMultiColumnComboBox Is Nothing Then
                Return
            End If

            Me.originalSize = radMultiColumnComboBox.Size
            Me.associatedRadMultiColumnComboBox_Control = radMultiColumnComboBox
            Me.associatedRadMultiColumnComboBox_Control.AutoSize = True
            AddHandler Me.associatedRadMultiColumnComboBox_Control.ThemeNameChanged, AddressOf associatedRadMultiColumnComboBox_ThemeNameChanged
            AddHandler Me.associatedRadMultiColumnComboBox_Control.HandleCreated, AddressOf associatedRadMultiColumnComboBox_HandleCreated
            AddHandler Me.associatedRadMultiColumnComboBox_Control.DataBindingComplete, AddressOf associatedRadMultiColumnComboBox_DataBindingComplete
            Me.associatedRadMultiColumnComboBox_Control.DropDownStyle = RadDropDownStyle.DropDownList
            AddHandler Me.associatedRadMultiColumnComboBox_Control.EditorControl.ViewCellFormatting, AddressOf EditorControl_ViewCellFormatting
            AddHandler Me.associatedRadMultiColumnComboBox_Control.DropDownClosing, AddressOf radMultiColumnCombobox1_DropDownClosing
            Me.m_associatedRadMultiColumnComboBox = New RadAutoCompleteBoxElement()
            Me.m_associatedRadMultiColumnComboBox.MinSize = New Size(150, 24)
            Me.m_associatedRadMultiColumnComboBox.Multiline = True
            Me.m_associatedRadMultiColumnComboBox.DrawBorder = False
            AddHandler Me.m_associatedRadMultiColumnComboBox.KeyDown, AddressOf autoCompleteBoxElement_KeyDown
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.ArrowButton.ZIndex = 1
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Hidden
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.Children(2).Children.Add(Me.m_associatedRadMultiColumnComboBox)
            Me.m_associatedRadMultiColumnComboBox.MaxSize = New Size(Me.associatedRadMultiColumnComboBox_Control.Size.Width - Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.ArrowButton.Size.Width, 0)
            Me.m_associatedRadMultiColumnComboBox.AutoCompleteDataSource = New List(Of String)(GetAutoCompleteItems())
            Me.m_associatedRadMultiColumnComboBox.Margin = New Padding(0)

            AddHandler Me.m_associatedRadMultiColumnComboBox.Items.CollectionChanged, AddressOf Items_CollectionChanged
            AddHandler Me.m_associatedRadMultiColumnComboBox.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            AddHandler Me.m_associatedRadMultiColumnComboBox.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
        End Sub

        Private Sub associatedRadMultiColumnComboBox_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
            Me.m_associatedRadMultiColumnComboBox.MaxSize = New Size(Me.associatedRadMultiColumnComboBox_Control.Size.Width - Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.ArrowButton.Size.Width, 0)
            'this.autoCompleteBoxElement.MinSize = new Size(150, this.associatedRadMultiColumnComboBox.Size.Height); 
        End Sub




        Private Sub autoCompleteBoxElement_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.F4 Then
                associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.ShowPopup()
            End If

            If e.KeyCode = Keys.Escape Then
                associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.ClosePopup(RadPopupCloseReason.CloseCalled)
            End If
        End Sub

        Private Sub associatedRadMultiColumnComboBox_DataBindingComplete(ByVal sender As Object, ByVal e As GridViewBindingCompleteEventArgs)
            m_associatedRadMultiColumnComboBox.AutoCompleteDataSource = New List(Of String)(GetAutoCompleteItems())
        End Sub

        Private Sub associatedRadMultiColumnComboBox_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
            m_associatedRadMultiColumnComboBox.AutoCompleteDataSource = New List(Of String)(GetAutoCompleteItems())
        End Sub

        Private Function GetAutoCompleteItems() As System.Collections.Generic.IEnumerable(Of String)
            Dim items As New List(Of String)
            For Each row As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Control.EditorControl.Rows
                Dim value As String = row.Cells(Me.associatedRadMultiColumnComboBox_Control.DisplayMember).Value.ToString().Trim()
                If Not rows.ContainsKey(value) Then
                    Me.rows.Add(value, row)
                End If
                items.Add(value)
            Next
            Return items
        End Function

        Private Sub radMultiColumnCombobox1_DropDownClosing(ByVal sender As Object, ByVal args As RadPopupClosingEventArgs)
            args.Cancel = (args.CloseReason = RadPopupCloseReason.Mouse AndAlso Me.associatedRadMultiColumnComboBox_Control.EditorControl.ElementTree.GetElementAtPoint(Of RadCheckBoxElement)(Me.associatedRadMultiColumnComboBox_Control.EditorControl.PointToClient(Cursor.Position)) IsNot Nothing) 'args.CloseReason == RadPopupCloseReason.Keyboard ||
            Me.SyncCollection()
        End Sub

        Private Sub EditorControl_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
            If e.ColumnIndex <> -1 OrElse e.CellElement.RowIndex = -1 Then
                Return
            End If

            If e.CellElement.Children.Count = 1 Then
                Dim checkBoxElement As New RadCheckBoxElement()
                checkBoxElement.Padding = New Padding(0, 3, 1, 0)
                checkBoxElement.Alignment = ContentAlignment.MiddleCenter
                checkBoxElement.NotifyParentOnMouseInput = False
                e.CellElement.Children.Add(checkBoxElement)
            End If

            Dim checkBox As RadCheckBoxElement = e.CellElement.FindDescendant(Of RadCheckBoxElement)()
            RemoveHandler checkBox.CheckStateChanged, AddressOf checkBox_CheckStateChanged
            checkBox.IsChecked = e.Row.Tag IsNot Nothing AndAlso e.Row.Tag.ToString() = Boolean.TrueString
            AddHandler checkBox.CheckStateChanged, AddressOf checkBox_CheckStateChanged

        End Sub

        Private Sub SyncCollection()
            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.TextBoxElement.SuspendPropertyNotifications()
            Me.associatedRadMultiColumnComboBox_Control.Text = String.Empty
            For Each item As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Control.EditorControl.Rows
                If item.Tag IsNot Nothing AndAlso item.Tag.ToString() = Boolean.TrueString Then
                    Me.associatedRadMultiColumnComboBox_Control.Text &= item.Cells(Me.associatedRadMultiColumnComboBox_Control.DisplayMember).Value.ToString & "; "
                End If
            Next item

            Me.associatedRadMultiColumnComboBox_Control.MultiColumnComboBoxElement.TextBoxElement.ResumePropertyNotifications()

            RemoveHandler m_associatedRadMultiColumnComboBox.Items.CollectionChanged, AddressOf Items_CollectionChanged
            RemoveHandler m_associatedRadMultiColumnComboBox.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            RemoveHandler m_associatedRadMultiColumnComboBox.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            m_associatedRadMultiColumnComboBox.Text = Me.associatedRadMultiColumnComboBox_Control.Text
            AddHandler m_associatedRadMultiColumnComboBox.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            AddHandler m_associatedRadMultiColumnComboBox.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            AddHandler m_associatedRadMultiColumnComboBox.Items.CollectionChanged, AddressOf Items_CollectionChanged
        End Sub

        Private Sub autoCompleteBoxElement_TokenValidating(ByVal sender As Object, ByVal e As TokenValidatingEventArgs)
            If Me.rows.ContainsKey(e.Text) Then
                If Me.rows(e.Text).Tag.ToString() = Boolean.TrueString Then
                    e.IsValidToken = False
                End If
            Else
                e.IsValidToken = False
            End If
        End Sub

        Private Sub autoCompleteBoxElement_CreateTextBlock(ByVal sender As Object, ByVal e As CreateTextBlockEventArgs)
            If Me.rows.ContainsKey(e.Text) AndAlso TypeOf e.TextBlock Is TokenizedTextBlockElement Then
                Me.rows(e.Text).Tag = Boolean.TrueString
                Me.rows(e.Text).InvalidateRow()
            End If
        End Sub

        Private Sub Items_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            If e.Action = NotifyCollectionChangedAction.Remove Then
                For Each item As RadTokenizedTextItem In e.NewItems
                    If Me.rows.ContainsKey(item.Text.Trim()) Then
                        Dim itemText As String = item.Text.Trim()
                        Me.rows(itemText).Tag = Boolean.FalseString
                        Me.rows(itemText).InvalidateRow()
                    End If
                Next item
            End If
        End Sub

        Private Sub checkBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkBox As RadCheckBoxElement = TryCast(sender, RadCheckBoxElement)
            Dim row As GridRowElement = checkBox.FindAncestor(Of GridRowElement)()
            row.RowInfo.Tag = checkBox.IsChecked.ToString()
        End Sub
    End Class
End Namespace

