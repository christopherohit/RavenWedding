Imports Microsoft.VisualBasic
Imports System
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

Namespace Telerik.Examples.WinControls.Gauges.Gallery
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
        Private timer As Timer = New Timer()
        Private activePanel As RadScrollablePanel
        Public Sub New()
            InitializeComponent()
            Me.activePanel = Me.radPanel2
            CType(Me.activePanel.PanelElement.Children(0), FillPrimitive).BackColor = Color.White
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            timer.Interval = 1000
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            For Each childControl As Control In activePanel.Controls(0).Controls
                ApplyValueToGauge(TryCast(childControl, RadRadialGauge))
            Next childControl
        End Sub

        Private lastSeed As Integer = DateTime.Now.Millisecond
        Private Sub ApplyValueToGauge(ByVal radRadialGauge As RadRadialGauge)
            If radRadialGauge Is Nothing Then
                Return
            End If
            lastSeed += 1
            Dim rnd As Random = New Random(DateTime.Now.Millisecond + lastSeed)
            Dim seed As Double = (radRadialGauge.RangeEnd - radRadialGauge.RangeStart) / 10.0R
            Dim val As Double = rnd.NextDouble() * seed - seed / 2
            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(RadRadialGaugeElement.ValueProperty, radRadialGauge.Value, radRadialGauge.Value + CSng(val), 12, 40)
            setting.ApplyEasingType = RadEasingType.OutBounce
            setting.ApplyValue(radRadialGauge.GaugeElement)

            If radRadialGauge.Controls.Count > 0 Then
                ApplyValueToGauge(TryCast(radRadialGauge.Controls(0), RadRadialGauge))
            End If
        End Sub

        Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton3.ToggleStateChanged, radRadioButton2.ToggleStateChanged, radRadioButton1.ToggleStateChanged
            If Me.radRadioButton1.IsChecked Then
                Me.activePanel = Me.radPanel1
                Me.radPanel1.Visible = True
                Me.radPanel2.Visible = False
                Me.radPanel3.Visible = False
            End If
            If Me.radRadioButton3.IsChecked Then
                Me.activePanel = Me.radPanel2
                Me.radPanel1.Visible = False
                Me.radPanel2.Visible = True
                Me.radPanel3.Visible = False
            End If
            If Me.radRadioButton2.IsChecked Then
                Me.activePanel = Me.radPanel3
                Me.radPanel1.Visible = False
                Me.radPanel2.Visible = False
                Me.radPanel3.Visible = True
            End If

            CType(Me.activePanel.PanelElement.Children(0), FillPrimitive).BackColor = Color.White
        End Sub
    End Class
End Namespace
