Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PanelsLabels.GroupBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton8.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Standard
			End If
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			End If
		End Sub

		Private Sub radRadioButton3_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Top
			End If
		End Sub

		Private Sub radRadioButton4_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Right
			End If
		End Sub

		Private Sub radRadioButton5_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Bottom
			End If
		End Sub

		Private Sub radRadioButton6_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
			End If
		End Sub

		Private Sub radRadioButton7_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageAboveText
			End If
		End Sub

		Private Sub radRadioButton8_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageBeforeText
			End If
		End Sub

		Private Sub radRadioButton9_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.Overlay
			End If
		End Sub

		Private Sub radRadioButton10_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextAboveImage
			End If
		End Sub

		Private Sub radRadioButton11_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextBeforeImage
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioButton2.ToggleStateChanged, AddressOf radRadioButton2_ToggleStateChanged
			AddHandler radRadioButton1.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radRadioButton3.ToggleStateChanged, AddressOf radRadioButton3_ToggleStateChanged
			AddHandler radRadioButton5.ToggleStateChanged, AddressOf radRadioButton5_ToggleStateChanged
			AddHandler radRadioButton6.ToggleStateChanged, AddressOf radRadioButton6_ToggleStateChanged
			AddHandler radRadioButton4.ToggleStateChanged, AddressOf radRadioButton4_ToggleStateChanged
			AddHandler radRadioButton11.ToggleStateChanged, AddressOf radRadioButton11_ToggleStateChanged
			AddHandler radRadioButton10.ToggleStateChanged, AddressOf radRadioButton10_ToggleStateChanged
			AddHandler radRadioButton9.ToggleStateChanged, AddressOf radRadioButton9_ToggleStateChanged
			AddHandler radRadioButton8.ToggleStateChanged, AddressOf radRadioButton8_ToggleStateChanged
			AddHandler radRadioButton7.ToggleStateChanged, AddressOf radRadioButton7_ToggleStateChanged
		End Sub
	End Class
End Namespace
