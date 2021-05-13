Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Editors.DomainUpDown
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private currencyData As Dictionary(Of String, Dictionary(Of String, Decimal)) = New Dictionary(Of String, Dictionary(Of String, Decimal))()

        Public Sub New()

            InitializeComponent()

            Me.CenterPanel = True
            FillConversionRates()
            AddHandler Me.convertButton.Click, AddressOf convertButton_Click
            AddHandler Me.convertSymbolLabel.Click, AddressOf convertSymbolLabel_Click

            Me.amountDomainUpDown.SelectedIndex = 4
            Me.fromDomainUpDown.SelectedIndex = 0
            Me.toDomainUpDown.SelectedIndex = 1
            Calculate()
        End Sub

        Private Sub convertSymbolLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectionIndex As Integer = Me.fromDomainUpDown.SelectedIndex
            Me.fromDomainUpDown.SelectedIndex = Me.toDomainUpDown.SelectedIndex
            Me.toDomainUpDown.SelectedIndex = selectionIndex
        End Sub

        Private Sub convertButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Calculate()
        End Sub

        Private Sub Calculate()
            Dim amount As Decimal = 0D
            Dim fromCurrency As String = Me.fromDomainUpDown.SelectedItem.ToString()
            Dim toCurrency As String = Me.toDomainUpDown.SelectedItem.ToString()

            If Me.amountDomainUpDown.SelectedItem IsNot Nothing AndAlso Decimal.TryParse(Me.amountDomainUpDown.SelectedItem.Text & String.Empty, amount) AndAlso fromCurrency <> String.Empty AndAlso toCurrency <> String.Empty AndAlso currencyData.ContainsKey(fromCurrency) AndAlso currencyData(fromCurrency).ContainsKey(toCurrency) Then
                Me.radLabelEUR.Text = "<html><b><size=10>EUR</b><br>" & currencyData(fromCurrency)("EUR")
                Me.radLabelUSD.Text = "<html><b><size=10>USD</b><br>" & currencyData(fromCurrency)("USD")
                Me.radLabelGBP.Text = "<html><b><size=10>GBP</b><br>" & currencyData(fromCurrency)("GBP")
                Me.radLabelCHF.Text = "<html><b><size=10>CHF</b><br>" & currencyData(fromCurrency)("CHF")
                Me.radLabelRUB.Text = "<html><b><size=10>RUB</b><br>" & currencyData(fromCurrency)("RUB")
                Me.radLabelCAD.Text = "<html><b><size=10>CAD</b><br>" & currencyData(fromCurrency)("CAD")
                Me.convertedResultLabel.Text = amount & " " & fromCurrency & " = " & amount * currencyData(fromCurrency)(toCurrency) & " " & toCurrency
                Me.rateLabel.Text = "1 " & fromCurrency & " = " & currencyData(fromCurrency)(toCurrency) & toCurrency & " , 1 " & toCurrency & " = " & currencyData(toCurrency)(fromCurrency) & " " & fromCurrency
                Me.unitLabel.Text = "1 " & fromCurrency
            End If
        End Sub

        Private Sub FillConversionRates()
            Dim conversionData As Dictionary(Of String, Decimal) = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 1D)
            conversionData.Add("EUR", 0.8872D)
            conversionData.Add("GBP", 0.7614D)
            conversionData.Add("CHF", 1.0074D)
            conversionData.Add("RUB", 65.69D)
            conversionData.Add("CAD", 1.3372D)
            currencyData.Add("USD", conversionData)
            conversionData = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 1.1271D)
            conversionData.Add("EUR", 1D)
            conversionData.Add("GBP", 0.8582D)
            conversionData.Add("CHF", 1.1355D)
            conversionData.Add("RUB", 74.0419D)
            conversionData.Add("CAD", 1.5072D)
            currencyData.Add("EUR", conversionData)
            conversionData = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 1.3099D)
            conversionData.Add("EUR", 1.1602D)
            conversionData.Add("GBP", 1D)
            conversionData.Add("CHF", 1.3196D)
            conversionData.Add("RUB", 85.9494D)
            conversionData.Add("CAD", 1.7491D)
            currencyData.Add("GBP", conversionData)
            conversionData = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 0.9927D)
            conversionData.Add("EUR", 0.8792D)
            conversionData.Add("GBP", 0.7578D)
            conversionData.Add("CHF", 1D)
            conversionData.Add("RUB", 65.1318D)
            conversionData.Add("CAD", 1.3255D)
            currencyData.Add("CHF", conversionData)
            conversionData = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 0.0152D)
            conversionData.Add("EUR", 0.0135D)
            conversionData.Add("GBP", 0.0116D)
            conversionData.Add("CHF", 0.0154D)
            conversionData.Add("RUB", 1D)
            conversionData.Add("CAD", 0.0204D)
            currencyData.Add("RUB", conversionData)
            conversionData = New Dictionary(Of String, Decimal)()
            conversionData.Add("USD", 0.7489D)
            conversionData.Add("EUR", 0.6633D)
            conversionData.Add("GBP", 0.5717D)
            conversionData.Add("CHF", 0.7544D)
            conversionData.Add("RUB", 49.1379D)
            conversionData.Add("CAD", 1D)
            currencyData.Add("CAD", conversionData)
        End Sub

        Private Sub radCheckBoxWrap_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.amountDomainUpDown.Wrap = Not Me.amountDomainUpDown.Wrap
            Me.fromDomainUpDown.Wrap = Not Me.fromDomainUpDown.Wrap
            Me.toDomainUpDown.Wrap = Not Me.toDomainUpDown.Wrap
        End Sub

        Private Sub radCheckBoxAutoComplete_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.amountDomainUpDown.AutoComplete = Not Me.amountDomainUpDown.AutoComplete
            Me.fromDomainUpDown.AutoComplete = Not Me.fromDomainUpDown.AutoComplete
            Me.toDomainUpDown.AutoComplete = Not Me.toDomainUpDown.AutoComplete
        End Sub

        Private Sub radCheckBoxReadOnly_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.amountDomainUpDown.[ReadOnly] = Not Me.amountDomainUpDown.[ReadOnly]
            Me.fromDomainUpDown.[ReadOnly] = Not Me.fromDomainUpDown.[ReadOnly]
            Me.toDomainUpDown.[ReadOnly] = Not Me.toDomainUpDown.[ReadOnly]
        End Sub

        Private Sub radCheckBoxSelectNext_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.amountDomainUpDown.SelectNextOnDoubleClick = Not Me.amountDomainUpDown.SelectNextOnDoubleClick
            Me.fromDomainUpDown.SelectNextOnDoubleClick = Not Me.fromDomainUpDown.SelectNextOnDoubleClick
            Me.toDomainUpDown.SelectNextOnDoubleClick = Not Me.toDomainUpDown.SelectNextOnDoubleClick
        End Sub
    End Class
End Namespace
