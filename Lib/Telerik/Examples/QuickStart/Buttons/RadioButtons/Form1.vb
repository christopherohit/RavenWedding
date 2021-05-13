Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.Buttons.RadioButtons
	''' <summary>
	''' Represents the RadRadioButtons example form
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private customShape1 As CustomShape

		Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True

            Me.customShape1 = New CustomShape()
			customShape1.CreateClosedShape(CreateInitialShape(5, 100, 60))
			SetShapes()

			Me.SelectedControl = Me.radRadioCustShape
		End Sub

		Private Shared Function CreateInitialShape(ByVal vertices As Integer, ByVal radius1 As Double, ByVal radius2 As Double) As List(Of PointF)
			Dim pts As New List(Of PointF)()

			If radius1 = 0 Then
				Return Nothing
			End If

			If radius2 = 0 Then
				Return Nothing
			End If

			For i As Integer = 0 To vertices - 1
				Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices)
				Dim angle2 As Double = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices)
				pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
				pts.Add(New PointF(CSng(Math.Cos(angle2) * radius2), CSng(Math.Sin(angle2) * radius2)))
			Next i

			Return pts
		End Function

		Private Sub SetShapes()
			Me.radRadioCustShape.RootElement.Children(0).Children(1).Children(1).Shape = customShape1
			Me.radRadioDonut.RootElement.Children(0).Children(1).Children(1).Shape = New DonutShape()
			Dim square As New RoundRectShape()
			square.Radius = 0
			Me.radRadioSquare.RootElement.Children(0).Children(1).Children(1).Shape = square
			Me.radRadioRound.RootElement.Children(0).Children(1).Children(1).Shape = New RoundRectShape()
			Me.radRadioOffice.RootElement.Children(0).Children(1).Children(1).Shape = New OfficeShape()
		End Sub

		Private Sub radRadioCustShape_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim s As String = " on"
			If (TryCast(sender, RadRadioButton)).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				s = " off"
			End If

			Me.radTextBoxEvents.Text += String.Format("{0} toggled" & s & Environment.NewLine, (TryCast(sender, RadRadioButton)).Text)
			Me.radTextBoxEvents.SelectionStart = Me.radTextBoxEvents.Text.Length
			Me.radTextBoxEvents.ScrollToCaret()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioOffice.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
			AddHandler radRadioSquare.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
			AddHandler radRadioDonut.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
			AddHandler radRadioCustShape.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
			AddHandler radRadioRegular.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
			AddHandler radRadioRound.ToggleStateChanged, AddressOf radRadioCustShape_ToggleStateChanged
		End Sub
	End Class
End Namespace