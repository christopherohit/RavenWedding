Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.ItemDragDrop
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SetPreferences()
		End Sub

		Private Sub SetPreferences()
			Dim service As RadDragDropService = Me.radPageView1.ViewElement.ItemDragService
			AddHandler service.Starting, AddressOf ItemDragService_Starting
			AddHandler service.Started, AddressOf ItemDragService_Started
			AddHandler service.Stopping, AddressOf ItemDragService_Stopping
			AddHandler service.Stopped, AddressOf ItemDragService_Stopped
			AddHandler service.PreviewDropTarget, AddressOf ItemDragService_PreviewDropTarget

			Me.textBox1.ReadOnly = True

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView3.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.productsTableAdapter.Fill(Me.northwindDataSet.Products)
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Me.ordersTableAdapter.Fill(Me.northwindDataSet.Orders)
			Me.radGridView1.Columns("UnitPrice").FormatString = "${0}"
			Me.radGridView1.Columns("UnitPrice").TextAlignment = ContentAlignment.MiddleRight
			Me.radGridView2.TableElement.RowHeight += 5
			Me.radGridView3.Columns("OrderID").TextAlignment = ContentAlignment.MiddleRight

			For Each mode As PageViewItemDragMode In System.Enum.GetValues(GetType(PageViewItemDragMode))
				Dim item As New RadListDataItem(mode.ToString())
				Me.dragModeCombo.Items.Add(item)
			Next mode
			Me.dragModeCombo.SelectedIndex = 0
		End Sub

		#Region "Event Handlers"

		Private Sub ItemDragService_PreviewDropTarget(ByVal sender As Object, ByVal e As PreviewDropTargetEventArgs)
			Dim service As RadDragDropService = TryCast(sender, RadDragDropService)
			Dim item As RadPageViewItem = TryCast(e.DropTarget, RadPageViewItem)
			If item IsNot Nothing Then
				ShowEventMessage(item.Text, "ItemDragService.PreviewDropTarget")
			End If
		End Sub

		Private Sub ItemDragService_Stopped(ByVal sender As Object, ByVal e As EventArgs)
			Dim service As RadDragDropService = TryCast(sender, RadDragDropService)
			ShowEventMessage(String.Empty, "ItemDragService.Stopped")
		End Sub

		Private Sub ItemDragService_Stopping(ByVal sender As Object, ByVal e As RadServiceStoppingEventArgs)
			Dim service As RadDragDropService = TryCast(sender, RadDragDropService)
			ShowEventMessage((TryCast(service.Context, RadPageViewItem)).Text, "ItemDragService.Stopping")
		End Sub

		Private Sub ItemDragService_Started(ByVal sender As Object, ByVal e As EventArgs)
			Dim service As RadDragDropService = TryCast(sender, RadDragDropService)
			ShowEventMessage((TryCast(service.Context, RadPageViewItem)).Text, "ItemDragService.Started")
		End Sub

		Private Sub ItemDragService_Starting(ByVal sender As Object, ByVal e As RadServiceStartingEventArgs)
			Dim service As RadDragDropService = TryCast(sender, RadDragDropService)
			ShowEventMessage((TryCast(e.Context, RadPageViewItem)).Text, "ItemDragService.Starting")
		End Sub

		Private Sub ShowEventMessage(ByVal itemText As String, ByVal eventName As String)
			Me.textBox1.Text += String.Format("""{0}"" {1}" & Environment.NewLine, itemText, eventName)
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.textBox1.SelectionStart = Me.textBox1.Text.Length
			Me.textBox1.ScrollToCaret()
		End Sub

		Private Sub radButtonClear_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.textBox1.Text = ""
		End Sub

		Private Sub dragModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim selectedItem As RadListDataItem = Me.dragModeCombo.SelectedItem
			Me.radPageView1.ViewElement.ItemDragMode = CType(System.Enum.Parse(GetType(PageViewItemDragMode), selectedItem.Text), PageViewItemDragMode)
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radButtonClear.Click, AddressOf radButtonClear_Click
			AddHandler textBox1.TextChanged, AddressOf textBox1_TextChanged
			AddHandler dragModeCombo.SelectedIndexChanged, AddressOf dragModeCombo_SelectedIndexChanged
		End Sub
	End Class
End Namespace