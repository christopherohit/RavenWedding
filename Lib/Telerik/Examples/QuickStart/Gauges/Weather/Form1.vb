Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Gauges

Namespace Telerik.Examples.WinControls.Gauges.Weather
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
        Private resourceNames As String() = New String() {"partly-cloudy.png", "rainy.png", "sunny.png", "thunderstorm.png"}

        Private weatherNames As String() = New String() {"Partly Cloudy", "Rainy", "Sunny", "Thunderstorm"}

        Private weatherImages As New List(Of Bitmap)(4)

        Public Sub New()
            Me.LoadImages()
            InitializeComponent()

            Me.pictureBox1.Image = Me.weatherImages(0)
            Me.UpdateIndicatorValues()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub ApplyValueToGauge(radRadialGauge As RadLinearGauge, value As Single)
            Dim setting As New AnimatedPropertySetting(RadLinearGaugeElement.ValueProperty, radRadialGauge.Value, value, 12, 40)
            setting.ApplyEasingType = RadEasingType.Linear
            setting.ApplyValue(radRadialGauge.GaugeElement)
        End Sub

        Private Sub LoadImages()
            Dim assembly As Assembly = GetType(Telerik.Examples.WinControls.Gauges.Weather.Form1).Assembly
            For Each imageName As String In Me.resourceNames
                Dim stream As Stream = assembly.GetManifestResourceStream(imageName)
                If stream Is Nothing Then
                    Exit For
                End If

                weatherImages.Add(New Bitmap(stream))
            Next
        End Sub

        Private Sub radTrackBar1_ValueChanged(sender As Object, e As EventArgs)
            UpdateIndicatorValues()
        End Sub

        Private Sub UpdateIndicatorValues()
            Dim index As Integer = Me.GetRand(0, 3)

            Me.pictureBox1.Image = Me.weatherImages(index)
            Me.labelSunny.Text = Me.weatherNames(index)

            Dim degree As Integer = Me.GetRand(15, 36)

            Me.labelDegree.Text = degree.ToString()
            Me.labelFeelsLike.Text = "Feels like " + (degree + Me.GetRand(-8, 8)).ToString()

            Me.ApplyValueToGauge(Me.radLinearGauge1, degree)
            Dim rainFail As Single = GetRand(0.0F, 3.0F)
            Me.labelRainfall.Text = String.Format("{0:n1}mm", rainFail)
            Me.ApplyValueToGauge(Me.radLinearGauge2, rainFail)

            Dim humidity As Single = GetRand(10.0F, 100.0F)
            Me.labelHumidity.Text = String.Format("{0:p0}", humidity / 100)
            Me.ApplyValueToGauge(Me.radLinearGauge3, humidity)

            Dim pressure As Single = GetRand(0.0F, 100.0F)
            Me.labelPressure.Text = String.Format("{0:n0}hPa", pressure)
            Me.ApplyValueToGauge(Me.radLinearGauge4, pressure)

            Dim windSpeed As Single = GetRand(0.0F, 9.0F)
            Me.labelWindSpeed.Text = String.Format("{0:n0}m/s", windSpeed)
            Me.ApplyValueToGauge(Me.radLinearGauge5, windSpeed)
        End Sub

        Public Function GetRand(minimum As Single, maximum As Single) As Single
            Dim random As New Random(DateTime.Now.Millisecond - CInt(Me.radTrackBar1.Value))
            Return CSng(random.NextDouble() * (maximum - minimum) + minimum)
        End Function

        Public Function GetRand(minimum As Integer, maximum As Integer) As Integer
            Dim random As New Random(DateTime.Now.Millisecond + CInt(Me.radTrackBar1.Value))
            Return random.[Next](minimum, maximum)
        End Function
    End Class
End Namespace