Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Carousel.CarouselSettings
	Partial Public Class Form1
		Inherits ShapedForm
		Public Sub New()
			InitializeComponent()

			WireEvents()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboAutoLoop.DataSource = System.Enum.GetNames(GetType(AutoLoopDirections))
			Me.radTitleBar.TitleBarElement.SetValue(RadFormElement.IsFormActiveProperty, True)
			Me.radCarouselDemo.AutoLoopDirection = AutoLoopDirections.Forward
			Me.radCarouselDemo.EnableLooping = True
			Me.radCheckEnableLooping.Checked = Me.radCarouselDemo.EnableLooping
			Me.radSpinRestoreDuration.Value = Me.radCarouselDemo.AutoLoopPauseInterval
			Me.radSpinVisibleElements.Value = Me.radCarouselDemo.VisibleItemCount
			Me.radCheckAutoLoop.Checked = Me.radCarouselDemo.EnableAutoLoop
			Me.radCheckVirtualMode.Checked = Me.radCarouselDemo.VirtualMode
		End Sub

		Private Sub WireEvents()
			AddHandler radComboAutoLoop.SelectedIndexChanged, AddressOf radComboAutoLoop_SelectedIndexChanged
			AddHandler radCheckEnableLooping.ToggleStateChanged, AddressOf OnEnableLooping_ToggleStateChanged
			AddHandler radCheckAutoLoop.ToggleStateChanged, AddressOf radCheckBox3_ToggleStateChanged
			AddHandler radCheckVirtualMode.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
			AddHandler radSpinRestoreDuration.ValueChanged, AddressOf radSpinEditor2_ValueChanged
			AddHandler radSpinVisibleElements.ValueChanged, AddressOf OnVisibleItemsCount_ValueChanged
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radCarouselDemo.VirtualMode = Me.radCheckVirtualMode.Checked
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radCarouselDemo.EnableAutoLoop = Me.radCheckAutoLoop.Checked
		End Sub

		Private Sub radComboAutoLoop_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim direction As AutoLoopDirections = CType(Me.radComboAutoLoop.SelectedIndex, AutoLoopDirections)
			Me.radCarouselDemo.AutoLoopDirection = direction
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCarouselDemo.AutoLoopPauseInterval = CInt(Fix(Me.radSpinRestoreDuration.Value))
		End Sub

		Private Sub OnVisibleItemsCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim itemCount As Integer

			If Integer.TryParse(Me.radSpinVisibleElements.Value.ToString(), itemCount) Then
				Me.radCarouselDemo.VisibleItemCount = itemCount
			End If
		End Sub

		Private Sub OnEnableLooping_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radCarouselDemo.EnableLooping = Me.radCheckEnableLooping.Checked
		End Sub
	End Class
End Namespace