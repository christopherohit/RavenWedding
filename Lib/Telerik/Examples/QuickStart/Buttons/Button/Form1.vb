Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Buttons.Button
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True

            Me.radRadioImgBeforeTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text

		End Sub

		Private Sub radRadioImgAboveTxt_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioImgAboveTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.ImageAboveText
				radButton3.TextAlignment = ContentAlignment.BottomCenter
			End If

			If Me.radRadioImgBeforeTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.ImageBeforeText
				radButton3.TextAlignment = ContentAlignment.MiddleCenter
			End If

			If Me.radRadioTxtAboveImg.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.TextAboveImage
				radButton3.TextAlignment = ContentAlignment.TopCenter
			End If

			If Me.radRadioTxtBeforeImg.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.TextBeforeImage
				radButton3.TextAlignment = ContentAlignment.MiddleCenter
			End If

			If Me.radRadioOverlay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.Overlay
				radButton3.TextAlignment = ContentAlignment.MiddleCenter
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioTxtAboveImg.ToggleStateChanged, AddressOf radRadioImgAboveTxt_ToggleStateChanged
			AddHandler radRadioImgBeforeTxt.ToggleStateChanged, AddressOf radRadioImgAboveTxt_ToggleStateChanged
			AddHandler radRadioTxtBeforeImg.ToggleStateChanged, AddressOf radRadioImgAboveTxt_ToggleStateChanged
			AddHandler radRadioOverlay.ToggleStateChanged, AddressOf radRadioImgAboveTxt_ToggleStateChanged
		End Sub
	End Class
End Namespace