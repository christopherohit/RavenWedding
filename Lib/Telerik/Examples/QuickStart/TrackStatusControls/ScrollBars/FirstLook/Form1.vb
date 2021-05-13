Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.FirstLook
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private currentScrollBar As Control = Nothing
		Public Sub New()
			InitializeComponent()
			UpdateScrollbars()
			Me.SelectedControl = Me.radHScrollBar1
		End Sub

		#Region "Utility Methods"
		Private Sub UpdateGUIForProperties(ByVal ctl As Control)
				Dim sb As RadScrollBar = CType(ctl, RadScrollBar)

				spinMax.Value = sb.Maximum
				spinMin.Value = sb.Minimum
				spinLargeChange.Value = sb.LargeChange
				spinSmallChange.Value = sb.SmallChange
				spinValue.Value = sb.Value

				spinThumbLength.Value = If(CDec(sb.ThumbLengthProportion) >= -1 AndAlso CDec(sb.ThumbLengthProportion) <=1, CDec(sb.ThumbLengthProportion), CDec(0.1))
				spinThumbLength.Enabled = True
				spinMinThumb.Value = sb.MinThumbLength
				spinMinThumb.Enabled = True
		End Sub

		Private Sub SetCurrentMaximum(ByVal newValue As Integer)

				CType(Me.radHScrollBar1, RadScrollBar).Maximum = newValue
				CType(Me.radVScrollBar1, RadScrollBar).Maximum = newValue
		End Sub

		Private Sub SetCurrentMinimum(ByVal newValue As Integer)
				CType(Me.radHScrollBar1, RadScrollBar).Minimum = newValue
				CType(Me.radVScrollBar1, RadScrollBar).Minimum = newValue
		End Sub

		Private Sub SetCurrentLargeChange(ByVal newValue As Integer)
			Try
					CType(Me.radHScrollBar1, RadScrollBar).LargeChange = newValue
					CType(Me.radVScrollBar1, RadScrollBar).LargeChange = newValue
			Catch e As ArgumentOutOfRangeException
				MessageBox.Show(e.Message, "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End Try
		End Sub

		Private Sub SetCurrentSmallChange(ByVal newValue As Integer)
			Try
					CType(Me.radVScrollBar1, RadScrollBar).SmallChange = newValue
					CType(Me.radHScrollBar1, RadScrollBar).SmallChange = newValue
			Catch e As ArgumentOutOfRangeException
				MessageBox.Show(e.Message, "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End Try
		End Sub

		Private Sub SetCurrentValue(ByVal newValue As Integer)
			Try
					CType(Me.radVScrollBar1, RadScrollBar).Value = newValue
					CType(Me.radHScrollBar1, RadScrollBar).Value = newValue
			Catch e As ArgumentOutOfRangeException
				MessageBox.Show(e.Message, "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End Try
		End Sub

		Private Function GetCurrentMaximum() As String
			If TypeOf Me.currentScrollBar Is ScrollBar Then
				Return (CType(Me.currentScrollBar, ScrollBar)).Maximum.ToString()
			Else
				Return (CType(Me.currentScrollBar, RadScrollBar)).Maximum.ToString()
			End If
		End Function

		Private Function GetCurrentMinimum() As String
			If TypeOf Me.currentScrollBar Is ScrollBar Then
				Return (CType(Me.currentScrollBar, ScrollBar)).Minimum.ToString()
			Else
				Return (CType(Me.currentScrollBar, RadScrollBar)).Minimum.ToString()
			End If
		End Function

		Private Function GetCurrentLargeChange() As String
			If TypeOf Me.currentScrollBar Is ScrollBar Then
				Return (CType(Me.currentScrollBar, ScrollBar)).LargeChange.ToString()
			Else
				Return (CType(Me.currentScrollBar, RadScrollBar)).LargeChange.ToString()
			End If
		End Function

		Private Function GetCurrentSmallChange() As String
			If TypeOf Me.currentScrollBar Is ScrollBar Then
				Return (CType(Me.currentScrollBar, ScrollBar)).SmallChange.ToString()
			Else
				Return (CType(Me.currentScrollBar, RadScrollBar)).SmallChange.ToString()
			End If
		End Function

		Private Function GetCurrentValue() As String
			If TypeOf Me.currentScrollBar Is ScrollBar Then
				Return (CType(Me.currentScrollBar, ScrollBar)).Value.ToString()
			Else
				Return (CType(Me.currentScrollBar, RadScrollBar)).Value.ToString()
			End If
		End Function
		#End Region

		#Region "Scroll Events"

		Private Sub radVScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			spinValue.Value = radVScrollBar1.Value
			radHScrollBar1.Value = radVScrollBar1.Value
		End Sub

		Private Sub radHScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			spinValue.Value = radHScrollBar1.Value
			radVScrollBar1.Value = radHScrollBar1.Value
		End Sub
		#End Region

		#Region "ScrollBar Context Menu"
		Private Function GetScrollBar(ByVal contextMenuEventSender As Object) As RadScrollBar
			Dim item As ToolStripDropDownItem = TryCast(contextMenuEventSender, ToolStripDropDownItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Dim menu As ContextMenuStrip = TryCast(item.Owner, ContextMenuStrip)
			If menu Is Nothing Then
				Return Nothing
			End If

			Return TryCast(menu.SourceControl, RadScrollBar)
		End Function

		Private Sub scrollToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformScrollTo(Cursor.Position)
			End If
		End Sub

		Private Sub leftTopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformFirst()
			End If
		End Sub

		Private Sub rightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLast()
			End If
		End Sub

		Private Sub pageLeftUpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLargeDecrement(1)
			End If
		End Sub

		Private Sub pageRightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLargeIncrement(1)
			End If
		End Sub

		Private Sub scrollLeftUpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformSmallDecrement(1)
			End If
		End Sub

		Private Sub scrollRightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformSmallIncrement(1)
			End If
		End Sub
		#End Region

		#Region "ScrollBar Properties Editing"
		Private Sub SetScrollBarValue(ByVal input As RadSpinEditor)
			Dim newValue As Integer = CInt(Fix(input.Value))
			If input Is Me.spinMax Then
				SetCurrentMaximum(newValue)
			ElseIf input Is Me.spinMin Then
				SetCurrentMinimum(newValue)
			ElseIf input Is Me.spinLargeChange Then
				SetCurrentLargeChange(newValue)
			ElseIf input Is Me.spinSmallChange Then
				SetCurrentSmallChange(newValue)
			ElseIf input Is Me.spinValue Then
				SetCurrentValue(newValue)
			End If

			UpdateScrollbars()
		End Sub

		#End Region

		#Region "ScrollBar Choosing"

		Private Sub UpdateScrollbars()
			UpdateGUIForProperties(Me.radVScrollBar1)
			UpdateGUIForProperties(Me.radHScrollBar1)
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler rightBottomToolStripMenuItem.Click, AddressOf rightBottomToolStripMenuItem_Click
			AddHandler scrollRightBottomToolStripMenuItem.Click, AddressOf scrollRightBottomToolStripMenuItem_Click
			AddHandler scrollLeftUpToolStripMenuItem.Click, AddressOf scrollLeftUpToolStripMenuItem_Click
			AddHandler radVScrollBar1.ValueChanged, AddressOf radVScrollBar1_ValueChanged
			AddHandler spinMin.ValueChanged, AddressOf spinMin_ValueChanged
			AddHandler spinSmallChange.ValueChanged, AddressOf spinSmallChange_ValueChanged
			AddHandler radHScrollBar1.ValueChanged, AddressOf radHScrollBar1_ValueChanged
			AddHandler spinMinThumb.ValueChanged, AddressOf spinMinThumb_ValueChanged
			AddHandler pageLeftUpToolStripMenuItem.Click, AddressOf pageLeftUpToolStripMenuItem_Click
			AddHandler pageRightBottomToolStripMenuItem.Click, AddressOf pageRightBottomToolStripMenuItem_Click
			AddHandler scrollToToolStripMenuItem.Click, AddressOf scrollToToolStripMenuItem_Click
			AddHandler leftTopToolStripMenuItem.Click, AddressOf leftTopToolStripMenuItem_Click
			AddHandler spinValue.ValueChanged, AddressOf spinValue_ValueChanged
			AddHandler spinThumbLength.ValueChanged, AddressOf spinThumbLength_ValueChanged
			AddHandler spinLargeChange.ValueChanged, AddressOf spinLargeChange_ValueChanged
			AddHandler spinMax.ValueChanged, AddressOf spinMax_ValueChanged
		End Sub

		Private Sub spinMax_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetScrollBarValue(CType(sender, RadSpinEditor))
		End Sub

		Private Sub spinMin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetScrollBarValue(CType(sender, RadSpinEditor))
		End Sub

		Private Sub spinLargeChange_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetScrollBarValue(CType(sender, RadSpinEditor))
		End Sub

		Private Sub spinSmallChange_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetScrollBarValue(CType(sender, RadSpinEditor))
		End Sub

		Private Sub spinValue_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetScrollBarValue(CType(sender, RadSpinEditor))
		End Sub

		Private Sub spinThumbLength_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim newValue As Double = CDbl(spinThumbLength.Value)
				CType(Me.radVScrollBar1, RadScrollBar).ThumbLengthProportion = newValue
				CType(Me.radHScrollBar1, RadScrollBar).ThumbLengthProportion = newValue

			UpdateScrollbars()
		End Sub

		Private Sub spinMinThumb_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim newValue As Integer = CInt(Fix(spinMinThumb.Value))
				CType(Me.radVScrollBar1, RadScrollBar).MinThumbLength = newValue
				CType(Me.radHScrollBar1, RadScrollBar).MinThumbLength = newValue

			UpdateScrollbars()
		End Sub
	End Class
End Namespace