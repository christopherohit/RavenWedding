Imports System.Text
Imports System.ComponentModel
Imports System.Globalization

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.StockSeries
    Public Class CandlestickViewModel
        Implements INotifyPropertyChanged
        'INSTANT VB NOTE: The variable data was renamed since Visual Basic does not allow class members with the same name:
        Private data_Renamed As BindingList(Of CandleDataInfo)

        Public Sub New()
            data_Renamed = ParseData()
        End Sub

        Public Property Data() As BindingList(Of CandleDataInfo)
            Get
                Return data_Renamed
            End Get
            Set(ByVal value As BindingList(Of CandleDataInfo))
                If Me.data_Renamed IsNot value Then
                    Me.data_Renamed = value
                    Me.OnPropertyChanged("Data")
                End If
            End Set
        End Property

        Friend Shared Function ParseData() As BindingList(Of CandleDataInfo)
            Dim chartData As New BindingList(Of CandleDataInfo)()
            Dim separator() As Char = {ControlChars.Cr, ControlChars.Lf}
            Dim fileContents As String = My.Resources.OhlcData
            Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            For Each line As String In lines
                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data() As String = line.Split(","c)
                Dim dataItem As New CandleDataInfo() With {.Date = Date.Parse(data(0), CultureInfo.InvariantCulture), .Open = Double.Parse(data(1), CultureInfo.InvariantCulture), .High = Double.Parse(data(2), CultureInfo.InvariantCulture), .Low = Double.Parse(data(3), CultureInfo.InvariantCulture), .Close = Double.Parse(data(4), CultureInfo.InvariantCulture)}

                chartData.Add(dataItem)
            Next line
            Return chartData
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            If Me.PropertyChangedEvent IsNot Nothing Then
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
End Namespace
