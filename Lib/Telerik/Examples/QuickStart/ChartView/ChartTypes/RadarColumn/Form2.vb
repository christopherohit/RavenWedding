Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.RadarColumn
    Public Class Form1
        Inherits ExamplesForm
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Dim categories As New List(Of String) From {"Df", "Pr", "A", "C", "D", "E", "Th", "Ri", "Ni", "B", "F", "Se", "Mn", "Cu", "Zn", "K", "P", "Fe", "Ca", "Na", "Ch", "Sf"}

            Dim values As New List(Of Integer)() From {5, 1, 1, 5, 0, 1, 1, 2, 1, 2, 1, 0, 0, 2, 1, 0, 3, 1, 1, 1, 0, 0}

            Dim series As New RadarColumnSeries()


            For i As Integer = 0 To categories.Count - 1
                series.DataPoints.Add(New CategoricalDataPoint(values(i), categories(i)))
            Next i
            RadChartView1.AreaType = ChartAreaType.Polar
            RadChartView1.Series.Add(series)

            For i As Integer = 0 To series.Children.Count - 1
                If i Mod 2 = 0 Then
                    series.Children(i).BackColor = Color.FromArgb(61, 153, 231)
                Else
                    series.Children(i).BackColor = Color.FromArgb(249, 196, 0)
                End If
            Next i

        End Sub

    End Class

End Namespace
