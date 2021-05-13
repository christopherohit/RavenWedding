Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			SetupTrackBars()
			SetupSettings()

		End Sub

		Private Sub SetupSettings()
			EnumToListBox(GetType(TickStyles), Me.radDropDownList1)
			EnumToListBox(GetType(TrackBarLabelStyle), Me.radDropDownList2)
			EnumToListBox(GetType(TrackBarSnapModes), Me.radDropDownList3)

			Me.radDropDownList1.SelectedIndex = 3
			Me.radDropDownList2.SelectedIndex = 3
			Me.radDropDownList3.SelectedIndex = 1
			Me.radSpinEditor1.Value = Me.radTrackBar1.LargeTickFrequency
			Me.radSpinEditor2.Value = Me.radTrackBar1.SmallTickFrequency
			Me.radSpinEditor3.Value = Me.radTrackBar1.ThumbSize.Width
			Me.radSpinEditor4.Value = Me.radTrackBar1.ThumbSize.Height

			If Me.radTrackBar1.Orientation = Orientation.Horizontal Then
				Me.radRadioButton1.IsChecked = True
			Else
				Me.radRadioButton2.IsChecked = True
			End If

			If Me.radTrackBar1.RightToLeft = RightToLeft.Yes Then
				Me.radCheckBox1.IsChecked = True
			Else
				Me.radCheckBox1.IsChecked = False
			End If

			Me.radCheckBox2.IsChecked = Me.radTrackBar1.ShowSlideArea
			Me.radCheckBox3.IsChecked = Me.radTrackBar1.ShowButtons
		End Sub

		Public Shared Sub EnumToListBox(ByVal EnumType As Type, ByVal TheListBox As RadDropDownList)
			Dim Values As Array = System.Enum.GetValues(EnumType)

			For Each Value As Integer In Values
				Dim Display As String = System.Enum.GetName(EnumType, Value)

				Dim Item As New RadListDataItem(Display, Value.ToString())

				TheListBox.Items.Add(Item)
			Next Value
		End Sub

		Private Sub SetupTrackBars()
            'TrackBar1
            Me.radTrackBar1.SnapFrequency = TrackBarSnapFrequency.Ticks
            Me.radTrackBar1.TrackBarMode = TrackBarRangeMode.SingleThumb
			Me.radTrackBar1.Value = 7

            'TrackBar2
            Me.radTrackBar2.SnapFrequency = TrackBarSnapFrequency.Ticks
            Me.radTrackBar2.TrackBarMode = TrackBarRangeMode.Range

			Me.radTrackBar2.Ranges(0).End = 10
			Me.radTrackBar2.Ranges(0).Start = 5


            'TrackBar3
            Me.radTrackBar3.SnapFrequency = TrackBarSnapFrequency.Ticks
            Me.radTrackBar3.TrackBarMode = TrackBarRangeMode.Range
			Me.radTrackBar3.Ranges.Add(New TrackBarRange(12,18))

			Me.radTrackBar3.Ranges(0).End = 10
			Me.radTrackBar3.Ranges(0).Start = 5

            'TrackBar4
            Me.radTrackBar4.SnapFrequency = TrackBarSnapFrequency.Ticks
            Me.radTrackBar4.TrackBarMode = TrackBarRangeMode.StartFromTheBeginning

			Me.radTrackBar4.Ranges.Add(New TrackBarRange(0, 8))
			Me.radTrackBar4.Ranges.Add(New TrackBarRange(5, 12))
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTrackBar1.TickStyle = CType(e.Position, TickStyles)
			Me.radTrackBar2.TickStyle = CType(e.Position, TickStyles)
			Me.radTrackBar3.TickStyle = CType(e.Position, TickStyles)
			Me.radTrackBar4.TickStyle = CType(e.Position, TickStyles)
		End Sub

		Private Sub radDropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTrackBar1.LabelStyle = CType(e.Position, TrackBarLabelStyle)
			Me.radTrackBar2.LabelStyle = CType(e.Position, TrackBarLabelStyle)
			Me.radTrackBar3.LabelStyle = CType(e.Position, TrackBarLabelStyle)
			Me.radTrackBar4.LabelStyle = CType(e.Position, TrackBarLabelStyle)
		End Sub


		Private Sub radDropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radTrackBar1.SnapMode = CType(e.Position, TrackBarSnapModes)
			Me.radTrackBar2.SnapMode = CType(e.Position, TrackBarSnapModes)
			Me.radTrackBar3.SnapMode = CType(e.Position, TrackBarSnapModes)
			Me.radTrackBar4.SnapMode = CType(e.Position, TrackBarSnapModes)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTrackBar1.LargeTickFrequency = CInt(Fix(Me.radSpinEditor1.Value))
			Me.radTrackBar2.LargeTickFrequency = CInt(Fix(Me.radSpinEditor1.Value))
			Me.radTrackBar3.LargeTickFrequency = CInt(Fix(Me.radSpinEditor1.Value))
			Me.radTrackBar4.LargeTickFrequency = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTrackBar1.SmallTickFrequency = CInt(Fix(Me.radSpinEditor2.Value))
			Me.radTrackBar2.SmallTickFrequency = CInt(Fix(Me.radSpinEditor2.Value))
			Me.radTrackBar3.SmallTickFrequency = CInt(Fix(Me.radSpinEditor2.Value))
			Me.radTrackBar4.SmallTickFrequency = CInt(Fix(Me.radSpinEditor2.Value))
		End Sub

		Private Sub radSpinEditor3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTrackBar1.ThumbSize = New Size(CInt(Fix(Me.radSpinEditor3.Value)), Me.radTrackBar1.ThumbSize.Height)
			Me.radTrackBar2.ThumbSize = New Size(CInt(Fix(Me.radSpinEditor3.Value)), Me.radTrackBar2.ThumbSize.Height)
			Me.radTrackBar3.ThumbSize = New Size(CInt(Fix(Me.radSpinEditor3.Value)), Me.radTrackBar3.ThumbSize.Height)
			Me.radTrackBar4.ThumbSize = New Size(CInt(Fix(Me.radSpinEditor3.Value)), Me.radTrackBar4.ThumbSize.Height)

		End Sub

		Private Sub radSpinEditor4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radTrackBar1.ThumbSize = New Size(Me.radTrackBar1.ThumbSize.Width, CInt(Fix(Me.radSpinEditor4.Value)))
			Me.radTrackBar2.ThumbSize = New Size(Me.radTrackBar2.ThumbSize.Width, CInt(Fix(Me.radSpinEditor4.Value)))
			Me.radTrackBar3.ThumbSize = New Size(Me.radTrackBar3.ThumbSize.Width, CInt(Fix(Me.radSpinEditor4.Value)))
			Me.radTrackBar4.ThumbSize = New Size(Me.radTrackBar4.ThumbSize.Width, CInt(Fix(Me.radSpinEditor4.Value)))
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTrackBar1.Orientation = Orientation.Horizontal
			Me.radTrackBar2.Orientation = Orientation.Horizontal
			Me.radTrackBar3.Orientation = Orientation.Horizontal
			Me.radTrackBar4.Orientation = Orientation.Horizontal

			Me.radTrackBar1.Width = 500
			Me.radTrackBar2.Width = 500
			Me.radTrackBar3.Width = 500
			Me.radTrackBar4.Width = 500

			Me.radLabel1.Location = New Point(120, 40)
			Me.radTrackBar1.Location = New Point(120, 60)

			Me.radLabel2.Location = New Point(120, 160)
			Me.radTrackBar2.Location = New Point(120, 180)

			Me.radLabel3.Location = New Point(120, 280)
			Me.radTrackBar3.Location = New Point(120, 300)

			Me.radLabel4.Location = New Point(120, 400)
			Me.radTrackBar4.Location = New Point(120, 420)
        End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTrackBar1.Orientation = Orientation.Vertical
			Me.radTrackBar2.Orientation = Orientation.Vertical
			Me.radTrackBar3.Orientation = Orientation.Vertical
			Me.radTrackBar4.Orientation = Orientation.Vertical

			Me.radTrackBar1.Height = 500
			Me.radTrackBar2.Height = 500
			Me.radTrackBar3.Height = 500
			Me.radTrackBar4.Height = 500

            Me.radLabel1.Location = New Point(35, 15)
            Me.radTrackBar1.Location = New Point(50, 40)

            Me.radLabel2.Location = New Point(200, 15)
            Me.radTrackBar2.Location = New Point(260, 40)

            Me.radLabel3.Location = New Point(410, 15)
            Me.radTrackBar3.Location = New Point(470, 40)

            Me.radLabel4.Location = New Point(635, 15)
            Me.radTrackBar4.Location = New Point(680, 40)
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radCheckBox1.IsChecked Then
				Me.radTrackBar1.RightToLeft = RightToLeft.Yes
				Me.radTrackBar2.RightToLeft = RightToLeft.Yes
				Me.radTrackBar3.RightToLeft = RightToLeft.Yes
				Me.radTrackBar4.RightToLeft = RightToLeft.Yes
			Else
				Me.radTrackBar1.RightToLeft = RightToLeft.No
				Me.radTrackBar2.RightToLeft = RightToLeft.No
				Me.radTrackBar3.RightToLeft = RightToLeft.No
				Me.radTrackBar4.RightToLeft = RightToLeft.No
			End If
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTrackBar1.ShowSlideArea = Me.radCheckBox2.IsChecked
			Me.radTrackBar2.ShowSlideArea = Me.radCheckBox2.IsChecked
			Me.radTrackBar3.ShowSlideArea = Me.radCheckBox2.IsChecked
			Me.radTrackBar4.ShowSlideArea = Me.radCheckBox2.IsChecked
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTrackBar1.ShowButtons = Me.radCheckBox3.IsChecked
			Me.radTrackBar2.ShowButtons = Me.radCheckBox3.IsChecked
			Me.radTrackBar3.ShowButtons = Me.radCheckBox3.IsChecked
			Me.radTrackBar4.ShowButtons = Me.radCheckBox3.IsChecked
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radSpinEditor4.ValueChanged, AddressOf radSpinEditor4_ValueChanged
			AddHandler radSpinEditor3.ValueChanged, AddressOf radSpinEditor3_ValueChanged
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
			AddHandler radRadioButton1.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radRadioButton2.ToggleStateChanged, AddressOf radRadioButton2_ToggleStateChanged
			AddHandler radDropDownList2.SelectedIndexChanged, AddressOf radDropDownList2_SelectedIndexChanged
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radDropDownList3.SelectedIndexChanged, AddressOf radDropDownList3_SelectedIndexChanged
			AddHandler radCheckBox3.ToggleStateChanged, AddressOf radCheckBox3_ToggleStateChanged
		End Sub
	End Class
End Namespace