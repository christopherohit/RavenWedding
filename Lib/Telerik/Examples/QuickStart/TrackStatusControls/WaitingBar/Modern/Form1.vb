Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Modern
    Partial Public Class Form1
        Inherits ExamplesForm
        Private timer As Timer
        Private panels As RadPanel()
        Private waitingBars As RadWaitingBar()
        Private currentPanelIndex As Integer
        Private currentWaitingBar As RadWaitingBar

        Public Sub New()
            InitializeComponent()

            Me.SetInitialValues()
        End Sub

        Private Sub SetInitialValues()
            Me.currentWaitingBar = Me.radWaitingBar1

            Me.timer = New Timer()
            Me.timer.Interval = 1500
            AddHandler Me.timer.Tick, AddressOf timer_Tick

            Me.currentPanelIndex = 0

            Me.panels = New RadPanel(5) {}
            Me.panels(0) = Me.radPanel1
            Me.panels(1) = Me.radPanel2
            Me.panels(2) = Me.radPanel3
            Me.panels(3) = Me.radPanel4
            Me.panels(4) = Me.radPanel5
            Me.panels(5) = Me.radPanel6

            For Each panel As RadPanel In Me.panels
                panel.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Hidden
                panel.PanelElement.PanelBorder.ForeColor = Color.FromArgb(238, 238, 238)
            Next

            Me.waitingBars = New RadWaitingBar(5) {}
            Me.waitingBars(0) = New RadWaitingBar()
            Me.waitingBars(1) = New RadWaitingBar()
            Me.waitingBars(2) = New RadWaitingBar()
            Me.waitingBars(3) = New RadWaitingBar()
            Me.waitingBars(4) = New RadWaitingBar()
            Me.waitingBars(5) = New RadWaitingBar()

            For index As Integer = 0 To Me.waitingBars.Length - 1
                Dim wb As RadWaitingBar = Me.waitingBars(index)
                wb.AssociatedControl = Me.panels(index)
                wb.Size = New System.Drawing.Size(80, 80)
                wb.StartWaiting()
                Me.Controls.Add(wb)
            Next
        End Sub

        Private Sub StartLoadingImages()
            Me.currentPanelIndex = 0
            Me.timer.[Stop]()
            Me.RemovePanelImages()
            For panelIndex As Integer = 0 To 5
                Me.waitingBars(panelIndex).ThemeName = Me.CurrentThemeName
                Me.waitingBars(panelIndex).WaitingSpeed = Me.currentWaitingBar.WaitingSpeed
                Me.waitingBars(panelIndex).WaitingStep = Me.currentWaitingBar.WaitingStep
                Me.waitingBars(panelIndex).WaitingStyle = Me.currentWaitingBar.WaitingStyle
                If Me.waitingBars(panelIndex).IsWaiting Then
                    Me.waitingBars(panelIndex).StopWaiting()
                    Me.waitingBars(panelIndex).ResetWaiting()
                End If

                Me.waitingBars(panelIndex).StartWaiting()
            Next

            Me.timer.Start()
        End Sub

        Private Sub RemovePanelImages()
            Me.radPanel1.BackgroundImage = Nothing
            Me.radPanel2.BackgroundImage = Nothing
            Me.radPanel3.BackgroundImage = Nothing
            Me.radPanel4.BackgroundImage = Nothing
            Me.radPanel5.BackgroundImage = Nothing
            Me.radPanel6.BackgroundImage = Nothing
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Me.radWaitingBar1.StartWaiting()
            Me.radWaitingBar2.StartWaiting()
            Me.radWaitingBar3.StartWaiting()
            Me.radWaitingBar4.StartWaiting()
            Me.radWaitingBar5.StartWaiting()
            Me.radWaitingBar6.StartWaiting()
            Me.radWaitingBar7.StartWaiting()

            Me.StartLoadingImages()
        End Sub

        Private Sub timer_Tick(sender As Object, e As EventArgs)
            If Me.currentPanelIndex >= Me.panels.Length Then
                Me.timer.[Stop]()
                Me.currentPanelIndex = 0
                Return
            End If

            Me.waitingBars(currentPanelIndex).StopWaiting()
            Me.waitingBars(currentPanelIndex).ResetWaiting()

            Dim panelImage As Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\240-160\meal" & (Me.currentPanelIndex + 1) & ".jpg")
            Me.panels(currentPanelIndex).BackgroundImage = panelImage

            Me.currentPanelIndex += 1
        End Sub

        Private Sub radRadioButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim radioButton As RadRadioButton = TryCast(sender, RadRadioButton)
            If radioButton.Name = Me.radRadioButtonDotsLine.Name Then
                Me.currentWaitingBar = Me.radWaitingBar1
            ElseIf radioButton.Name = Me.radRadioButtonDotsSpinner.Name Then
                Me.currentWaitingBar = Me.radWaitingBar2
            ElseIf radioButton.Name = Me.radRadioButtonDotsRing.Name Then
                Me.currentWaitingBar = Me.radWaitingBar3
            ElseIf radioButton.Name = Me.radRadioButtonFadingRing.Name Then
                Me.currentWaitingBar = Me.radWaitingBar4
            ElseIf radioButton.Name = Me.radRadioButtonLineRing.Name Then
                Me.currentWaitingBar = Me.radWaitingBar5
            ElseIf radioButton.Name = Me.radRadioButtonSegmentedRing.Name Then
                Me.currentWaitingBar = Me.radWaitingBar6
            ElseIf radioButton.Name = Me.radRadioButtonRotatingRings.Name Then
                Me.currentWaitingBar = Me.radWaitingBar7
            End If

            Me.StartLoadingImages()
        End Sub

        Private Sub radButtonLoadImages_Click(sender As Object, e As EventArgs)
            Me.StartLoadingImages()
        End Sub
    End Class
End Namespace