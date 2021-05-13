Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.DragAndDrop

	Partial Public Class Form1
		Inherits ExamplesForm
		Private dragDropMan1 As RadItemDragDropManager
		Private itemsFont As Font = Nothing

		Public Sub New()
			InitializeComponent()

			Dim font As New Font("Segoe Print", 12.0f, FontStyle.Bold)
			itemsFont = font
			For Each item As RadListDataItem In Me.radListBox1.Items
				item.Font = font
			Next item

			dragDropMan1 = New RadItemDragDropManager(Me.radListBox1, Me.radListBox1.Items, Me.radListBox2, Me.radListBox2.Items)

			Me.radListBox1.AutoSizeItems = True
			Me.radListBox2.AutoSizeItems = True

			AddHandler Disposed, AddressOf Form1_Disposed
		End Sub

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			itemsFont.Dispose()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves selectedItem from ListBox1 to ListBox2
			MoveToTargetListBox(radListBox1, radListBox2)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves selectedItem from ListBox2 to ListBox1
			MoveToTargetListBox(radListBox2, radListBox1)
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves all items from listBox1 to ListBox2
			MoveAllItems(radListBox1, radListBox2)
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves all items from listBox2 to ListBox1
			MoveAllItems(radListBox2, radListBox1)
		End Sub

		Private Sub radButton7_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves up SelectedItem in radListBox1 
			MoveUp(radListBox1)
		End Sub

		Private Sub radButton8_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves down SelectedItem in radListBox1
			MoveDown(radListBox1)
		End Sub

		Private Sub radButton5_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves up SelectedItem in radListBox2
			MoveUp(radListBox2)
		End Sub

		Private Sub radButton6_Click(ByVal sender As Object, ByVal e As EventArgs)
			'moves down SelectedItem in radListBox2
			MoveDown(radListBox2)
		End Sub

		Private Sub MoveUp(ByVal listBox As RadListControl)
			If listBox.Items.Count < 2 Then
				Return
			End If
			If listBox.SelectedItem Is Nothing Then
				Return
			End If
			If listBox.SelectedIndex = 0 Then
				Return
			End If
			Dim item As RadListDataItem = listBox.SelectedItem
			Dim index As Integer = listBox.SelectedIndex
			listBox.Items.Remove(item)
			listBox.Items.Insert(index - 1, item)
			listBox.SelectedItem = item
		End Sub

		Private Sub MoveDown(ByVal listBox As RadListControl)
			If listBox.Items.Count < 2 Then
				Return
			End If
			If listBox.SelectedItem Is Nothing Then
				Return
			End If
			If listBox.SelectedIndex = listBox.Items.Count - 1 Then
				Return
			End If
			Dim item As RadListDataItem = listBox.SelectedItem
			Dim index As Integer = listBox.SelectedIndex
			listBox.Items.Remove(item)
			listBox.Items.Insert(index + 1, item)
			listBox.SelectedItem = item
		End Sub

		Private Sub MoveAllItems(ByVal sourceListBox As RadListControl, ByVal targetListBox As RadListControl)
			Dim i As Integer = 0
			Do While i < sourceListBox.Items.Count
				Dim item As RadListDataItem = sourceListBox.Items(i)
				sourceListBox.Items.Remove(item)
				targetListBox.Items.Add(item)
			Loop
		End Sub

		Private Sub MoveToTargetListBox(ByVal sourceListBox As RadListControl, ByVal targetListBox As RadListControl)
			If sourceListBox.Items.Count = 0 Then
				Return
			End If
			If sourceListBox.SelectedItem Is Nothing Then
				Return
			End If

			Dim item As RadListDataItem = sourceListBox.SelectedItem
			sourceListBox.Items.Remove(item)
			targetListBox.Items.Add(item)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radButton2.Click, AddressOf radButton2_Click
			AddHandler radButton3.Click, AddressOf radButton3_Click
			AddHandler radButton4.Click, AddressOf radButton4_Click
			AddHandler radButton7.Click, AddressOf radButton7_Click
			AddHandler radButton8.Click, AddressOf radButton8_Click
			AddHandler radButton5.Click, AddressOf radButton5_Click
			AddHandler radButton6.Click, AddressOf radButton6_Click
		End Sub
	End Class
End Namespace
