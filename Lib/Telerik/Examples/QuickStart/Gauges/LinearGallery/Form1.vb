Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Gauges

Namespace Telerik.Examples.WinControls.Gauges.LinearGallery
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
        Private timer As New Timer()
        Private activePanel As RadScrollablePanel
        Public Sub New()
            InitializeComponent()
            Me.activePanel = Me.radScrollablePanel3
            DirectCast(Me.activePanel.PanelElement.Children(0), FillPrimitive).BackColor = Color.White
            radScrollablePanel1.GetChildAt(0).GetChildAt(1).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            DirectCast(Me.radScrollablePanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            timer.Interval = 1000
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub

        Private Sub timer_Tick(sender As Object, e As EventArgs)
            For Each childControl As Control In activePanel.Controls(0).Controls
                ApplyValueToGauge(TryCast(childControl, RadLinearGauge))
            Next
        End Sub

        Private lastSeed As Integer = DateTime.Now.Millisecond
        Private Sub ApplyValueToGauge(radRadialGauge As RadLinearGauge)
            If radRadialGauge Is Nothing Then
                Return
            End If
            lastSeed += 1
            Dim rnd As New Random(DateTime.Now.Millisecond + lastSeed)
            Dim seed As Double = (radRadialGauge.RangeEnd - radRadialGauge.RangeStart) / 10.0
            Dim val As Double = rnd.NextDouble() * seed - seed / 2
            Dim setting As New AnimatedPropertySetting(RadLinearGaugeElement.ValueProperty, radRadialGauge.Value, radRadialGauge.Value + CSng(val), 12, 40)
            setting.ApplyEasingType = RadEasingType.OutBounce
            setting.ApplyValue(radRadialGauge.GaugeElement)

            If radRadialGauge.Controls.Count > 0 Then
                ApplyValueToGauge(TryCast(radRadialGauge.Controls(0), RadLinearGauge))
            End If
        End Sub

        Private Sub radRadioButton1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            If Me.radRadioButton1.IsChecked Then
                Me.activePanel = Me.radScrollablePanel1
                Me.radScrollablePanel1.Visible = True
                Me.radScrollablePanel2.Visible = False
                Me.radScrollablePanel3.Visible = False
            End If
            If Me.radRadioButton2.IsChecked Then
                Me.activePanel = Me.radScrollablePanel2
                Me.radScrollablePanel1.Visible = False
                Me.radScrollablePanel2.Visible = True
                Me.radScrollablePanel3.Visible = False
            End If
            If Me.radRadioButton3.IsChecked Then
                Me.activePanel = Me.radScrollablePanel3
                Me.radScrollablePanel1.Visible = False
                Me.radScrollablePanel2.Visible = False
                Me.radScrollablePanel3.Visible = True
            End If

            DirectCast(Me.activePanel.PanelElement.Children(0), FillPrimitive).BackColor = Color.White
            DirectCast(Me.activePanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End Sub
    End Class
End Namespace