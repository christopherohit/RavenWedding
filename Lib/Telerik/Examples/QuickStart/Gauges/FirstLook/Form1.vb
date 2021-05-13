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
Imports Telerik.WinControls.UI.Gauges

Namespace Telerik.Examples.WinControls.Gauges.FirstLook
	Public Partial Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
		Private timer As Timer = New Timer()

		Private step1 As Single=0f
		Private step2 As Single=0f
		Private step3 As Single=0f

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler Me.radRadialGauge3.ValueChanged, AddressOf radRadialGauge3_ValueChanged
			AddHandler Me.radRadialGauge2.ValueChanged, AddressOf radRadialGauge2_ValueChanged
			AddHandler Me.radRadialGauge1.ValueChanged, AddressOf radRadialGauge1_ValueChanged

			step1 = -CSng(radRadialGauge1.RangeEnd - radRadialGauge1.RangeStart) / 10f
			step2 = CSng(radRadialGauge2.RangeEnd - radRadialGauge2.RangeStart) / 10f
			step3 = -CSng(radRadialGauge3.RangeEnd - radRadialGauge3.RangeStart) / 10f

			timer.Interval = 1000
			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Start()
		End Sub

		Private Sub radRadialGauge1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radRadialGauge1.Value >= 6f Then
				Me.radialGaugeNeedle2.BackColor = Color.FromArgb(224, 90, 90)
				Me.radialGaugeNeedle2.BackColor2 = Color.FromArgb(224, 90, 90)
			Else
				Me.radialGaugeNeedle2.BackColor = Color.Black
				Me.radialGaugeNeedle2.BackColor2 = Color.Black
			End If
		End Sub


		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			Me.timer.Stop()
			Me.timer.Dispose()
			 If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			 End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)

			ApplyValueToGauge(Me.radRadialGauge1,step1)
			ApplyValueToGauge(Me.radRadialGauge2,step2)
			ApplyValueToGauge(Me.radRadialGauge3,step3)
		End Sub



		Private Sub ApplyValueToGauge(ByVal radRadialGauge As RadRadialGauge, ByRef [step] As Single)
			If radRadialGauge.Value + [step] > radRadialGauge.RangeEnd OrElse radRadialGauge.Value + [step] < radRadialGauge.RangeStart Then
				[step] = -[step]
			End If

			Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(RadRadialGaugeElement.ValueProperty, radRadialGauge.Value, radRadialGauge.Value + [step], 12, 40)
			setting.ApplyEasingType = RadEasingType.OutBounce
			setting.ApplyValue(radRadialGauge.GaugeElement)
		End Sub

		Private Sub radRadialGauge2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radRadialGauge2.Value >= 50 Then
				Me.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(119, 190, 79)
				Me.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(121, 191, 80)
			Else
				Me.radialGaugeArc3.BackColor = Color.FromArgb(224, 70, 71)
				Me.radialGaugeArc3.BackColor2 = Color.FromArgb(224, 70, 71)
			End If
		End Sub

		Private Sub radRadialGauge3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radRadialGauge3.Value < 50 Then
				Me.radialGaugeArc5.BackColor = System.Drawing.Color.FromArgb(119, 190, 79)
				Me.radialGaugeArc5.BackColor2 = System.Drawing.Color.FromArgb(121, 191, 80)
			Else
				Me.radialGaugeArc5.BackColor = Color.FromArgb(224, 70, 71)
				Me.radialGaugeArc5.BackColor2 = Color.FromArgb(224, 70, 71)
			End If
		End Sub

	End Class
End Namespace
