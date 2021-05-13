Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Events
    Partial Public Class Form1
        Inherits ExamplesForm

        Protected lookUpColumn As GridViewComboBoxColumn = Nothing
        Protected commandColumn As GridViewCommandColumn = Nothing

        Public Sub New()
            InitializeComponent()
            Me.SelectedControl = Me.radGridView1
            Me.radGridView1.EnableHotTracking = True
            Me.radLabel4.Text = ""
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.carsTableAdapter.Fill(Me.nwindDataSet.Cars)
            radGridView1.DataSource = Me.carsBindingSource
            Me.radGridView1.Columns(1).IsVisible = False
            Me.radGridView1.Columns(4).IsVisible = False
            Me.radGridView1.Columns("Picture").IsVisible = False
            Dim table As DataTable = New DataTable()
            table.Columns.Add("KBytes")
            table.Rows.Add(21)
            table.Rows.Add(30)
            table.Rows.Add(99)
            table.Rows.Add(50)
            lookUpColumn = New GridViewComboBoxColumn()
            radGridView1.MasterTemplate.Columns.Add(lookUpColumn)
            lookUpColumn.HeaderText = "ComboBox"
            lookUpColumn.TextAlignment = ContentAlignment.MiddleRight
            lookUpColumn.DataSource = table
            lookUpColumn.FieldName = "KBytes"
            lookUpColumn.ValueMember = "KBytes"
            lookUpColumn.Name = "comboColumnKBytes"
            radGridView1.Columns("Date").TextAlignment = ContentAlignment.MiddleRight
            commandColumn = New GridViewCommandColumn()
            commandColumn.HeaderText = "Command"
            radGridView1.MasterTemplate.Columns.Add(commandColumn)
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            AddHandler radGridView1.CommandCellClick, New CommandCellClickEventHandler(AddressOf radGridView1_CommandCellClick)
            AddHandler radGridView1.CellBeginEdit, New GridViewCellCancelEventHandler(AddressOf radGridView1_CellBeginEdit)
            AddHandler radGridView1.CellEndEdit, New GridViewCellEventHandler(AddressOf radGridView1_CellEndEdit)
            AddHandler radGridView1.EditorRequired, New EditorRequiredEventHandler(AddressOf radGridView1_EditorRequired)
            AddHandler radGridView1.DoubleClick, New EventHandler(AddressOf radGridView1_DoubleClick)
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.radPanel1.PanelElement.PanelFill.BackColor = radGridView1.TableElement.BackColor
        End Sub

        Private Sub radGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
            AddTextToListBox("     EditorRequired  " & e.EditorType.ToString())
        End Sub

        Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
            If TypeOf e.CellElement Is GridCommandCellElement Then
                e.CellElement.Text = "Btn " & Convert.ToString(e.CellElement.RowInfo.Cells("Id").Value)
            ElseIf TypeOf e.CellElement Is GridDateTimeCellElement Then
                Dim dateTimeCell As GridDateTimeCellElement = TryCast(e.CellElement, GridDateTimeCellElement)
                dateTimeCell.Text = String.Format("{0:ddd, MM/dd}", dateTimeCell.Value)
            End If
        End Sub

        Private Sub radGridView1_CellEndEdit(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
            AddTextToListBox(String.Format(" Cell end edit column:{0}, row:{1}", e.ColumnIndex, e.RowIndex))
        End Sub

        Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
            AddTextToListBox(String.Format(" Cell begin edit column:{0}, row:{1}", e.ColumnIndex, e.RowIndex))
        End Sub

        Private Sub radGridView1_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddEventRoot("Click")
        End Sub

        Private Sub radGridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If radGridView1.MasterView.CurrentRow IsNot Nothing Then
                RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                RadMessageBox.Show(radGridView1.MasterView.CurrentRow.Cells(1).Value.ToString(), "Current Row")
            End If
        End Sub

        Private Sub radGridView1_CellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
            AddEventRoot("CellClick")
            AddTextToListBox(String.Format("    Cell value: {0}", (TryCast(sender, GridCellElement)).Text))
        End Sub

        Private Sub radGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
            AddEventRoot("CellDoubleClick")
            AddTextToListBox(String.Format("    Cell value: {0}", (TryCast(sender, GridCellElement)).Text))
        End Sub

        Private Sub radGridView1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            AddEventRoot("MouseClick")
            AddTextToListBox(String.Format("    MouseClick {0}, btn: {1}", e.Location, e.Button))
        End Sub

        Private Sub radGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            AddEventRoot("MouseDoubleClick")
            AddTextToListBox(String.Format("    MouseClick {0}, btn: {1}", e.Location, e.Button))
        End Sub

        Private Sub radGridView1_CommandCellClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim clickedCommandColumn As GridCommandCellElement = TryCast(sender, GridCommandCellElement)
            AddEventRoot("CommandCellClick")
            AddTextToListBox(String.Format("    CommandCellClick on row with id = {0}", clickedCommandColumn.RowInfo.Cells("Id").Value))
        End Sub

        Private Sub radGridView1_CellMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim cell As GridDataCellElement = TryCast(sender, GridDataCellElement)

            If cell Is Nothing Then
                Return
            End If

            radLabel4.Text = String.Format("{0} [{1}, btn: {2}]", cell.Value, e.Location, e.Button)
        End Sub

        Private messageBoxShow As Boolean = True

        Private Sub radGridView1_CurrentRowChanging(ByVal sender As Object, ByVal e As CurrentRowChangingEventArgs)
            If e.NewRow Is Nothing Then
                AddEventRoot("CurrentRowChanging")
                AddTextToListBox("   non-data-bound row")
                Return
            End If

            If e.NewRow.Cells("Id").Value Is Nothing Then Return
            If Not (TypeOf e.NewRow.Cells("Id").Value Is Integer) Then Return
            Dim value As Integer = CInt(e.NewRow.Cells("Id").Value)
            Dim label As RadListDataItem = New RadListDataItem()

            If value = 3 Then
                e.Cancel = True
                label.Text = String.Format("   CurrentRowChanging, row (Id = 3) selection cancelled.")
                label.ForeColor = Color.Orange

                If Me.messageBoxShow Then
                    RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
                    RadMessageBox.Show("The column with Id = 3 selection is cancelled.", "Selection cancellation though CurrentRowChanging event", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Me.messageBoxShow = False
                Else
                    Me.messageBoxShow = True
                End If
            Else

                If e.CurrentRow IsNot Nothing Then
                    label.Text = String.Format("   CurrentRowChanging, current Id = {0}, new Id = {1}", e.CurrentRow.Cells("Id").Value, value)
                Else
                    label.Text = String.Format("   CurrentRowChanging, new Id = {0}", value)
                End If
            End If

            AddEventRoot("CurrentRowChanging")
            AddTextToListBox(label)
        End Sub

        Private Sub radGridView1_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)
            Dim text As String

            If e.CurrentRow Is Nothing Then

                If e.OldRow IsNot Nothing Then
                    text = String.Format("   CurrentRowChanged, old Id = {0}, current row is non-data-bound", e.OldRow.Cells("Id").Value)
                Else
                    text = "   CurrentRowChanged, old and current rows are non-data-bound"
                End If
            Else

                If e.OldRow IsNot Nothing Then
                    text = String.Format("   CurrentRowChanged, old Id = {0}, current Id = {1}", e.OldRow.Cells("Id").Value, e.CurrentRow.Cells("Id").Value)
                Else
                    text = String.Format("   CurrentRowChanged, current Id = {0}", e.CurrentRow.Cells("Id").Value)
                End If
            End If

            AddEventRoot("CurrentRowChanged")
            AddTextToListBox(text)
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            radListBoxEvents.Items.Clear()
            insertIndex = 0
        End Sub

        Private insertIndex As Integer = 0

        Private Sub AddEventRoot(ByVal text As String)
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = text
            Me.AddEventRoot(item)
        End Sub

        Private Sub AddEventRoot(ByVal item As RadListDataItem)
            item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            radListBoxEvents.Items.Insert(insertIndex, item)
            insertIndex += 1
        End Sub

        Private Sub AddTextToListBox(ByVal item As RadListDataItem)
            If radListBoxEvents.Items.Count > 100 Then
                radListBoxEvents.Items.Clear()
                insertIndex = 0
            End If

            radListBoxEvents.Items.Insert(insertIndex, item)
            insertIndex += 1
        End Sub

        Private Sub AddTextToListBox(ByVal text As String)
            Dim label As RadListDataItem = New RadListDataItem()
            label.Text = text
            AddTextToListBox(label)
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radButton1.Click, New System.EventHandler(AddressOf Me.radButton1_Click)
            AddHandler Me.radGridView1.CellMouseMove, New Telerik.WinControls.UI.CellMouseMoveEventHandler(AddressOf Me.radGridView1_CellMouseMove)
            AddHandler Me.radGridView1.CellDoubleClick, New Telerik.WinControls.UI.GridViewCellEventHandler(AddressOf Me.radGridView1_CellDoubleClick)
            AddHandler Me.radGridView1.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.radGridView1_MouseDoubleClick)
            AddHandler Me.radGridView1.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.radGridView1_MouseClick)
            AddHandler Me.radGridView1.Click, New System.EventHandler(AddressOf Me.radGridView1_Click)
            AddHandler Me.radGridView1.CellClick, New Telerik.WinControls.UI.GridViewCellEventHandler(AddressOf Me.radGridView1_CellClick)
            AddHandler Me.radGridView1.CurrentRowChanged, New Telerik.WinControls.UI.CurrentRowChangedEventHandler(AddressOf Me.radGridView1_CurrentRowChanged)
            AddHandler Me.radGridView1.CurrentRowChanging, New Telerik.WinControls.UI.CurrentRowChangingEventHandler(AddressOf Me.radGridView1_CurrentRowChanging)
        End Sub
    End Class
End Namespace
