Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.Animation
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radComboAnimation.DataSource = System.Enum.GetValues(GetType(RadEasingType))
			Me.radCheckEnabled.Checked = Me.radMenuDemo.DropDownAnimationEnabled
			Me.radComboAnimation.SelectedIndex = Me.radComboAnimation.FindStringExact(Me.radMenuDemo.DropDownAnimationEasing.ToString())
			Me.WireEvents()
			MyBase.OnLoad(e)
		End Sub

		Private Sub radSpinEditorFrames_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radMenuDemo.DropDownAnimationFrames = CInt(Fix(Me.radSpinEditorFrames.Value))
		End Sub

		Private Sub radComboAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case Me.radComboAnimation.SelectedText
				Case "Linear"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.Linear
				Case "InQuad"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuad
				Case "OutQuad"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuad
				Case "InOutQuad"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuad
				Case "InCubic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InCubic
				Case "OutCubic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutCubic
				Case "InOutCubic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutCubic
				Case "InQuart"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuart
				Case "OutQuart"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuart
				Case "InOutQuart"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuart
				Case "InQuint"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuint
				Case "OutQuint"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuint
				Case "InOutQuint"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuint
				Case "InSine"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InSine
				Case "OutSine"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutSine
				Case "InOutSine"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutSine
				Case "InExponential"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InExponential
				Case "OutExponential"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutExponential
				Case "InOutExponential"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutExponential
				Case "InCircular"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InCircular
				Case "OutCircular"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutCircular
				Case "InOutCircular"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutCircular
				Case "InElastic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InElastic
				Case "OutElastic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutElastic
				Case "InOutElastic"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutElastic
				Case "InBack"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InBack
				Case "OutBack"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutBack
				Case "InOutBack"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutBack
				Case "InBounce"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InBounce
				Case "OutBounce"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutBounce
				Case "InOutBounce"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutBounce
				Case "Default"
					Me.radMenuDemo.DropDownAnimationEasing = RadEasingType.Default
			End Select
		End Sub

		Private Sub OnRadCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radMenuDemo.DropDownAnimationEnabled = Me.radCheckEnabled.Checked

		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckEnabled.ToggleStateChanged, AddressOf OnRadCheck_ToggleStateChanged
			AddHandler radSpinEditorFrames.ValueChanged, AddressOf radSpinEditorFrames_ValueChanged
			AddHandler radComboAnimation.SelectedIndexChanged, AddressOf radComboAnimation_SelectedIndexChanged
		End Sub
	End Class
End Namespace
