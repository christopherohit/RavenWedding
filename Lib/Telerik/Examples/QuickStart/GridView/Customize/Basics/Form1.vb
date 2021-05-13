Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.Customize.Basics
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting

			Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)

			Me.radGridView1.TableElement.RowHeight = 50
			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.EnableAlternatingRowColor = True

			Me.radSpinEditorRowHeight.Value = Me.radGridView1.TableElement.RowHeight
			Me.radSpinEditorHeaderHeight.Value = Me.radGridView1.TableElement.TableHeaderHeight
			Me.radSpinEditorGroupRowHeight.Value = Me.radGridView1.TableElement.GroupHeaderHeight
			Me.radSpinEditorCellSpacing.Value = Me.radGridView1.TableElement.CellSpacing
			Me.radSpinEditorRowSpacing.Value = Me.radGridView1.TableElement.RowSpacing
			Me.radCheckBoxGroupPanel.ToggleState = If(Me.radGridView1.ShowGroupPanel, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxColumnHeaders.ToggleState = If(Me.radGridView1.MasterTemplate.ShowColumnHeaders, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxRowHeader.ToggleState = If(Me.radGridView1.MasterTemplate.ShowRowHeaderColumn, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxAutoSize.ToggleState = If(Me.radGridView1.AutoSizeRows, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxAlternate.ToggleState = If(Me.radGridView1.EnableAlternatingRowColor, ToggleState.On, ToggleState.Off)
			Me.radCheckBoxHotTracking.ToggleState = If(Me.radGridView1.EnableHotTracking, ToggleState.On, ToggleState.Off)

			If Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill Then
				Me.radCheckBoxFit.ToggleState = ToggleState.On
			Else
				Me.radCheckBoxFit.ToggleState = ToggleState.Off
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
			If TypeOf e.CellElement Is GridImageCellElement Then
				e.CellElement.ImageLayout = ImageLayout.Zoom
			End If
		End Sub

		Private Sub radSpinEditorRowHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.RowHeight = CInt(Fix(Me.radSpinEditorRowHeight.Value))
		End Sub

		Private Sub radSpinEditorHeaderHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.TableHeaderHeight = CInt(Fix(Me.radSpinEditorHeaderHeight.Value))
		End Sub

		Private Sub radSpinEditorGroupRowHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.GroupHeaderHeight = CInt(Fix(Me.radSpinEditorGroupRowHeight.Value))
		End Sub

		Private Sub radSpinEditorCellSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(Me.radSpinEditorCellSpacing.Value))
		End Sub

		Private Sub radSpinEditorRowSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(Me.radSpinEditorRowSpacing.Value))
		End Sub

		Private Sub radCheckBoxGroupPanel_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.ShowGroupPanel = If(Me.radCheckBoxGroupPanel.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxColumnHeaders_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.ShowColumnHeaders = If(Me.radCheckBoxColumnHeaders.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxRowHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.ShowRowHeaderColumn = If(Me.radCheckBoxRowHeader.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxAutoSize_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.AutoSizeRows = If(Me.radCheckBoxAutoSize.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxFit_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If radCheckBoxFit.ToggleState = ToggleState.On Then
				Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Else
				Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If
		End Sub

		Private Sub radCheckBoxAlternate_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.EnableAlternatingRowColor = If(radCheckBoxAlternate.ToggleState = ToggleState.On, True, False)
		End Sub

		Private Sub radCheckBoxHotTracking_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.EnableHotTracking = If(Me.radCheckBoxHotTracking.ToggleState = ToggleState.On, True, False)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxHotTracking.ToggleStateChanged, AddressOf radCheckBoxHotTracking_ToggleStateChanged
			AddHandler radSpinEditorGroupRowHeight.ValueChanged, AddressOf radSpinEditorGroupRowHeight_ValueChanged
			AddHandler radCheckBoxGroupPanel.ToggleStateChanged, AddressOf radCheckBoxGroupPanel_ToggleStateChanged
			AddHandler radSpinEditorRowSpacing.ValueChanged, AddressOf radSpinEditorRowSpacing_ValueChanged
			AddHandler radSpinEditorCellSpacing.ValueChanged, AddressOf radSpinEditorCellSpacing_ValueChanged
			AddHandler radSpinEditorRowHeight.ValueChanged, AddressOf radSpinEditorRowHeight_ValueChanged
			AddHandler radCheckBoxColumnHeaders.ToggleStateChanged, AddressOf radCheckBoxColumnHeaders_ToggleStateChanged
			AddHandler radCheckBoxFit.ToggleStateChanged, AddressOf radCheckBoxFit_ToggleStateChanged
			AddHandler radCheckBoxAlternate.ToggleStateChanged, AddressOf radCheckBoxAlternate_ToggleStateChanged
			AddHandler radSpinEditorHeaderHeight.ValueChanged, AddressOf radSpinEditorHeaderHeight_ValueChanged
			AddHandler radCheckBoxRowHeader.ToggleStateChanged, AddressOf radCheckBoxRowHeader_ToggleStateChanged
			AddHandler radCheckBoxAutoSize.ToggleStateChanged, AddressOf radCheckBoxAutoSize_ToggleStateChanged
		End Sub
	End Class
End Namespace
