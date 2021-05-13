Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DesktopAlert.Settings
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()

			Me.FillDropDownThemes()
            Me.radDesktopAlert1.ThemeName = Me.ddThemeName.SelectedItem.Text
            Me.CenterPanel = True
		End Sub

		Protected Overrides Sub WireEvents()
            AddHandler Me.closeButtonCheck.ToggleStateChanged, AddressOf Me.closeButtonCheck_ToggleStateChanged
            AddHandler Me.pinButtonCheck.ToggleStateChanged, AddressOf Me.pinButtonCheck_ToggleStateChanged
            AddHandler Me.ddScreenPosition.SelectedIndexChanged, AddressOf Me.OnPositionList_IndexChaned
            AddHandler Me.ddThemeName.SelectedIndexChanged, AddressOf Me.OnThemesList_IndexChanged
            AddHandler Me.fadeOutCheck.ToggleStateChanged, AddressOf Me.fadeOutCheck_ToggleStateChanged
            AddHandler Me.checkPopupAnimation.ToggleStateChanged, AddressOf Me.checkPopupAnimation_ToggleStateChanged
            AddHandler Me.fadeInCheck.ToggleStateChanged, AddressOf Me.fadeInCheck_ToggleStateChanged
            AddHandler Me.spinPopupAnimationFrames.ValueChanged, AddressOf Me.spinPopupAnimationFrames_ValueChanged
            AddHandler Me.btnPreview.Click, AddressOf Me.btnPreview_Click
            AddHandler Me.spinFadeDuration.ValueChanged, AddressOf Me.spinFadeDuration_ValueChanged
            AddHandler Me.autoCloseCheck.ToggleStateChanged, AddressOf Me.autoCloseCheck_ToggleStateChanged
            AddHandler Me.spinFadeDuration.ValueChanged, AddressOf Me.spinFadeDuration_ValueChanged
            AddHandler Me.spinOpacity.ValueChanged, AddressOf Me.SpinOpacity_ValueChanged
            AddHandler Me.optionsButtonCheck.ToggleStateChanged, AddressOf Me.optionsButtonCheck_ToggleStateChanged
            AddHandler Me.spinEditorHeight.ValueChanged, AddressOf Me.SpinEditorHeight_ValueChanged
            AddHandler Me.spinEditorWidth.ValueChanged, AddressOf Me.SpinEditorWidth_ValueChanged
            AddHandler Me.autoCloseDelaySpin.ValueChanged, AddressOf Me.autoCloseDelaySpin_ValueChanged
            AddHandler Me.autoCloseCheck.ToggleStateChanged, AddressOf Me.autoCloseCheck_ToggleStateChanged
            AddHandler Me.ddAnimationDirection.SelectedIndexChanged, AddressOf Me.ddAnimationDirection_SelectedIndexChanged
            AddHandler Me.ddThemeName.ThemeNameChanged, AddressOf ddThemeName_ThemeNameChanged
            AddHandler Me.autoSizeCheck.ToggleStateChanged, AddressOf autoSizeCheck_ToggleStateChanged
		End Sub

		Private Sub FillDropDownThemes()
			For Each themeName As String In Utils.AllThemes
				Me.ddThemeName.Items.Add(themeName)
			Next themeName

			' This is needed to set the order of themes in the DropDownList the same as ThemePanel.
			Me.ddThemeName.Items.RemoveAt(Me.ddThemeName.Items.IndexOf(Utils.ThemeName))
			Me.ddThemeName.Items.Insert(0, New RadListDataItem(Utils.ThemeName))
			Me.ddThemeName.Items(0).Selected = True
		End Sub

		#Region "Event handling"

		Private Sub autoSizeCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.AutoSize = Me.autoSizeCheck.IsChecked
			If Me.radDesktopAlert1.AutoSize Then
				Me.radDesktopAlert1.FixedSize = Size.Empty
			Else
				Me.radDesktopAlert1.FixedSize = New Size(CInt(Fix(Me.spinEditorWidth.Value)), CInt(Fix(Me.spinEditorHeight.Value)))
			End If
		End Sub

		Private Sub OnThemesList_IndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radDesktopAlert1.ThemeName = Me.ddThemeName.SelectedItem.Text
		End Sub

		Private Sub OnPositionList_IndexChaned(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radDesktopAlert1.ScreenPosition = CType(System.Enum.Parse(GetType(AlertScreenPosition), Me.ddScreenPosition.SelectedItem.Text), AlertScreenPosition)
		End Sub

		Private Sub SpinEditorWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.FixedSize = New Size(CInt(Fix(Me.spinEditorWidth.Value)), CInt(Fix(Me.spinEditorHeight.Value)))
        End Sub

		Private Sub SpinEditorHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.FixedSize = New Size(CInt(Fix(Me.spinEditorWidth.Value)), CInt(Fix(Me.spinEditorHeight.Value)))
		End Sub

		Private Sub fadeInCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.fadeInCheck.ToggleState = ToggleState.On Then
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType Or FadeAnimationType.FadeIn
			Else
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType And Not FadeAnimationType.FadeIn
			End If
		End Sub

		Private Sub fadeOutCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.fadeOutCheck.ToggleState = ToggleState.On Then
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType Or FadeAnimationType.FadeOut
			Else
				Me.radDesktopAlert1.FadeAnimationType = (Me.radDesktopAlert1.FadeAnimationType And (Not FadeAnimationType.FadeOut))
			End If
		End Sub

		Private Sub spinFadeDuration_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.FadeAnimationFrames = CInt(Fix(Me.spinFadeDuration.Value))
		End Sub

		Private Sub autoCloseCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.AutoClose = Me.autoCloseCheck.ToggleState = ToggleState.On
		End Sub

		Private Sub closeButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.ShowCloseButton = args.ToggleState = ToggleState.On
		End Sub

		Private Sub pinButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.ShowPinButton = args.ToggleState = ToggleState.On
		End Sub

		Private Sub optionsButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.ShowOptionsButton = args.ToggleState = ToggleState.On
		End Sub

		Private Sub checkPopupAnimation_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radDesktopAlert1.PopupAnimation = args.ToggleState = ToggleState.On
		End Sub

		Private Sub ddAnimationDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radDesktopAlert1.PopupAnimationDirection = CType(System.Enum.Parse(GetType(RadDirection), Me.ddAnimationDirection.SelectedItem.Text), RadDirection)
		End Sub

		Private Sub spinPopupAnimationFrames_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.PopupAnimationFrames = CInt(Fix(Me.spinPopupAnimationFrames.Value))
		End Sub

		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.CaptionText = Me.txtCaption.Text
			Me.radDesktopAlert1.ContentText = Me.txtContent.Text
			Me.radDesktopAlert1.Show()
		End Sub

		Private Sub SpinOpacity_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.Opacity = CSng(Me.spinOpacity.Value)
		End Sub

		Private Sub autoCloseDelaySpin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radDesktopAlert1.AutoCloseDelay = CInt(Fix(Me.autoCloseDelaySpin.Value))
		End Sub

		Private Sub ddThemeName_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
			Me.ddThemeName.SelectedIndex = Me.ddThemeName.Items.IndexOf(args.newThemeName)
		End Sub

		#End Region
	End Class
End Namespace