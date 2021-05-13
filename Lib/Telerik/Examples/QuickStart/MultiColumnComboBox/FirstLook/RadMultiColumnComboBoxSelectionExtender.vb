Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
    <ToolboxItem(False)>
    Public Class RadMultiColumnComboBoxSelectionExtender
        Inherits Component

        Private autoCompleteBoxElement_Field As RadAutoCompleteBoxElement
        Private rows As Dictionary(Of String, GridViewRowInfo) = New Dictionary(Of String, GridViewRowInfo)()
        Private associatedRadMultiColumnComboBox_Field As RadMultiColumnComboBox
        Private originalSize As Size = Size.Empty

        Public ReadOnly Property AutoCompleteBoxElement As RadAutoCompleteBoxElement
            Get
                Return Me.autoCompleteBoxElement_Field
            End Get
        End Property

        Public ReadOnly Property Items As RadTokenizedTextItemCollection
            Get
                Return Me.autoCompleteBoxElement_Field.Items
            End Get
        End Property

        Public Property AssociatedRadMultiColumnComboBox As RadMultiColumnComboBox
            Get
                Return Me.associatedRadMultiColumnComboBox_Field
            End Get
            Set(ByVal value As RadMultiColumnComboBox)
                Me.SetAssociatedRadMultiColumnComboBox(value)
            End Set
        End Property

        Private Sub SetAssociatedRadMultiColumnComboBox(ByVal radMultiColumnComboBox As RadMultiColumnComboBox)
            If radMultiColumnComboBox Is Nothing AndAlso Me.associatedRadMultiColumnComboBox_Field IsNot Nothing Then
                Me.SetAssociatedRadMultiColumnComboBoxCoreToNull()
            End If

            Me.SetAssociatedRadMultiColumnComboBoxCore(radMultiColumnComboBox)
        End Sub

        Private Sub SetAssociatedRadMultiColumnComboBoxCoreToNull()
            RemoveHandler Me.associatedRadMultiColumnComboBox_Field.HandleCreated, AddressOf associatedRadMultiColumnComboBox_HandleCreated
            RemoveHandler Me.associatedRadMultiColumnComboBox_Field.DataBindingComplete, AddressOf associatedRadMultiColumnComboBox_DataBindingComplete
            RemoveHandler Me.associatedRadMultiColumnComboBox_Field.EditorControl.ViewCellFormatting, AddressOf EditorControl_ViewCellFormatting
            RemoveHandler Me.associatedRadMultiColumnComboBox_Field.DropDownClosing, AddressOf radMultiColumnCombobox1_DropDownClosing
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Visible
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.Children(2).Children.Remove(autoCompleteBoxElement)
            Me.autoCompleteBoxElement_Field.MaxSize = New Size(0, 0)
            Me.autoCompleteBoxElement_Field.AutoCompleteDataSource = Nothing
            Me.associatedRadMultiColumnComboBox_Field.Size = Me.originalSize

            For Each item As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Field.EditorControl.Rows
                item.Tag = Nothing
            Next

            RemoveHandler Me.autoCompleteBoxElement_Field.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            RemoveHandler Me.autoCompleteBoxElement_Field.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            Me.autoCompleteBoxElement_Field.Text = Me.associatedRadMultiColumnComboBox_Field.Text
            RemoveHandler Me.autoCompleteBoxElement_Field.KeyDown, AddressOf autoCompleteBoxElement_KeyDown
            Me.associatedRadMultiColumnComboBox_Field = Nothing
            Me.rows.Clear()
        End Sub

        Private Sub SetAssociatedRadMultiColumnComboBoxCore(ByVal radMultiColumnComboBox As RadMultiColumnComboBox)
            If radMultiColumnComboBox Is Nothing Then
                Return
            End If

            Me.originalSize = radMultiColumnComboBox.Size
            Me.associatedRadMultiColumnComboBox_Field = radMultiColumnComboBox
            AddHandler Me.associatedRadMultiColumnComboBox_Field.HandleCreated, AddressOf associatedRadMultiColumnComboBox_HandleCreated
            AddHandler Me.associatedRadMultiColumnComboBox_Field.DataBindingComplete, AddressOf associatedRadMultiColumnComboBox_DataBindingComplete
            AddHandler Me.associatedRadMultiColumnComboBox_Field.EditorControl.ViewCellFormatting, AddressOf EditorControl_ViewCellFormatting
            AddHandler Me.associatedRadMultiColumnComboBox_Field.DropDownClosing, AddressOf radMultiColumnCombobox1_DropDownClosing
            Me.autoCompleteBoxElement_Field = New RadAutoCompleteBoxElement()
            Me.autoCompleteBoxElement_Field.MaxSize = New Size(256, 0)
            Me.autoCompleteBoxElement_Field.DrawBorder = False
            AddHandler Me.autoCompleteBoxElement_Field.KeyDown, AddressOf autoCompleteBoxElement_KeyDown
            Me.autoCompleteBoxElement_Field.NullText = Me.associatedRadMultiColumnComboBox_Field.NullText
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.ArrowButton.ZIndex = 1
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Collapsed
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.ComboboxLayoutPanel.Content = Me.autoCompleteBoxElement
            Me.autoCompleteBoxElement_Field.AutoCompleteDataSource = New System.Collections.Generic.List(Of String)(GetAutoCompleteItems())
            Me.autoCompleteBoxElement_Field.Margin = New System.Windows.Forms.Padding(0)
            Me.autoCompleteBoxElement_Field.NullTextViewElement.Padding = New Padding(2, 6, 2, 6)
            AddHandler Me.autoCompleteBoxElement_Field.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            AddHandler Me.autoCompleteBoxElement_Field.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            Me.PopulateItems()
        End Sub

        Private Sub autoCompleteBoxElement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.F4 Then
                associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.ShowPopup()
            End If

            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.ClosePopup(RadPopupCloseReason.CloseCalled)
            End If
        End Sub

        Private Sub associatedRadMultiColumnComboBox_DataBindingComplete(ByVal sender As Object, ByVal e As GridViewBindingCompleteEventArgs)
            autoCompleteBoxElement_Field.AutoCompleteDataSource = New System.Collections.Generic.List(Of String)(GetAutoCompleteItems())
        End Sub

        Private Sub associatedRadMultiColumnComboBox_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
            autoCompleteBoxElement_Field.AutoCompleteDataSource = New System.Collections.Generic.List(Of String)(GetAutoCompleteItems())
        End Sub

        Private Sub PopulateItems()
            For Each row As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Field.EditorControl.Rows
                Dim value As String = row.Cells(Me.associatedRadMultiColumnComboBox_Field.DisplayMember).Value.ToString().Trim()

                If Not rows.ContainsKey(value) Then
                    Me.rows.Add(value, row)
                End If
            Next
        End Sub

        Private Iterator Function GetAutoCompleteItems() As System.Collections.Generic.IEnumerable(Of String)
            For Each row As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Field.EditorControl.Rows
                Dim value As String = row.Cells(Me.associatedRadMultiColumnComboBox_Field.DisplayMember).Value.ToString().Trim()

                If Not rows.ContainsKey(value) Then
                    Me.rows.Add(value, row)
                End If

                Yield (value)
            Next
        End Function

        Private Sub radMultiColumnCombobox1_DropDownClosing(ByVal sender As Object, ByVal args As RadPopupClosingEventArgs)
            args.Cancel = (args.CloseReason = RadPopupCloseReason.Mouse AndAlso Me.associatedRadMultiColumnComboBox_Field.EditorControl.ElementTree.GetElementAtPoint(Of RadCheckBoxElement)(Me.AssociatedRadMultiColumnComboBox.EditorControl.PointToClient(System.Windows.Forms.Cursor.Position)) IsNot Nothing)
            Me.SyncCollection()
        End Sub

        Private Sub EditorControl_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
            If e.ColumnIndex <> -1 OrElse e.CellElement.RowIndex = -1 Then
                Return
            End If

            If e.CellElement.Children.Count = 1 Then
                Dim checkBoxElement As RadCheckBoxElement = New RadCheckBoxElement()
                checkBoxElement.Padding = New System.Windows.Forms.Padding(0, 3, 1, 0)
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
            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.TextBoxElement.SuspendPropertyNotifications()
            Me.associatedRadMultiColumnComboBox_Field.Text = String.Empty

            For Each item As GridViewRowInfo In Me.associatedRadMultiColumnComboBox_Field.EditorControl.Rows

                If item.Tag IsNot Nothing AndAlso item.Tag.ToString() = Boolean.TrueString Then
                    Me.associatedRadMultiColumnComboBox_Field.Text += CStr(item.Cells(Me.associatedRadMultiColumnComboBox_Field.DisplayMember).Value) + "; "
                End If
            Next

            Me.associatedRadMultiColumnComboBox_Field.MultiColumnComboBoxElement.TextBoxElement.ResumePropertyNotifications()
            RemoveHandler autoCompleteBoxElement_Field.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
            RemoveHandler autoCompleteBoxElement_Field.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            autoCompleteBoxElement_Field.Text = Me.associatedRadMultiColumnComboBox_Field.Text
            AddHandler autoCompleteBoxElement_Field.TokenValidating, AddressOf autoCompleteBoxElement_TokenValidating
            AddHandler autoCompleteBoxElement_Field.CreateTextBlock, AddressOf autoCompleteBoxElement_CreateTextBlock
        End Sub

        Private Sub autoCompleteBoxElement_TokenValidating(ByVal sender As Object, ByVal e As TokenValidatingEventArgs)
            If Me.rows.ContainsKey(e.Text) Then

                If Me.rows(e.Text).Tag IsNot Nothing AndAlso Me.rows(e.Text).Tag.ToString() = Boolean.TrueString Then
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

        Public Sub UpdateItems(ByVal sender As Object, ByVal e As Telerik.WinControls.Data.NotifyCollectionChangedEventArgs)
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                Me.PopulateItems()

                For Each item As RadTokenizedTextItem In e.NewItems

                    If Me.rows.ContainsKey(item.Text.Trim()) Then
                        Dim itemText As String = item.Text.Trim()
                        Me.rows(itemText).Tag = Boolean.FalseString
                        Me.rows(itemText).InvalidateRow()
                    End If
                Next
            End If
        End Sub

        Private Sub checkBox_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkBox As RadCheckBoxElement = TryCast(sender, RadCheckBoxElement)
            Dim row As GridRowElement = checkBox.FindAncestor(Of GridRowElement)()
            row.RowInfo.Tag = checkBox.IsChecked.ToString()
        End Sub
    End Class
End Namespace
