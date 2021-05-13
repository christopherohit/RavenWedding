using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Editors.DomainUpDown
{
    public partial class Form1 : EditorExampleBaseForm
    {
        Dictionary<string, Dictionary<string, decimal>> currencyData = new Dictionary<string, Dictionary<string, decimal>>();

        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;

            FillConversionRates();
            this.convertButton.Click += convertButton_Click;
            this.convertSymbolLabel.Click += convertSymbolLabel_Click;
            this.amountDomainUpDown.SelectedIndex = 4;
            this.fromDomainUpDown.SelectedIndex = 0;
            this.toDomainUpDown.SelectedIndex = 1;
            Calculate();
        }

        private void convertSymbolLabel_Click(object sender, EventArgs e)
        {
            int selectionIndex = this.fromDomainUpDown.SelectedIndex;
            this.fromDomainUpDown.SelectedIndex = this.toDomainUpDown.SelectedIndex;
            this.toDomainUpDown.SelectedIndex = selectionIndex;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            decimal amount = 0m;
            string fromCurrency = this.fromDomainUpDown.SelectedItem + string.Empty;
            string toCurrency = this.toDomainUpDown.SelectedItem + string.Empty;
            if (this.amountDomainUpDown.SelectedItem != null && decimal.TryParse(this.amountDomainUpDown.SelectedItem.Text + string.Empty, out amount) &&
                fromCurrency != string.Empty && toCurrency != string.Empty && currencyData.ContainsKey(fromCurrency) &&
                currencyData[fromCurrency].ContainsKey(toCurrency))
            {
                this.radLabelEUR.Text = "<html><b><size=10>EUR</b><br>" + currencyData[fromCurrency]["EUR"];
                this.radLabelUSD.Text = "<html><b><size=10>USD</b><br>" + currencyData[fromCurrency]["USD"];
                this.radLabelGBP.Text = "<html><b><size=10>GBP</b><br>" + currencyData[fromCurrency]["GBP"];
                this.radLabelCHF.Text = "<html><b><size=10>CHF</b><br>" + currencyData[fromCurrency]["CHF"];
                this.radLabelRUB.Text = "<html><b><size=10>RUB</b><br>" + currencyData[fromCurrency]["RUB"];
                this.radLabelCAD.Text = "<html><b><size=10>CAD</b><br>" + currencyData[fromCurrency]["CAD"];

                this.convertedResultLabel.Text = amount + " " + fromCurrency + " = " + amount * currencyData[fromCurrency][toCurrency] + " " + toCurrency;
                this.rateLabel.Text = "1 " + fromCurrency + " = " + currencyData[fromCurrency][toCurrency] + toCurrency + " , 1 " +
                                      toCurrency + " = " + currencyData[toCurrency][fromCurrency] + " " + fromCurrency;
                this.unitLabel.Text = "1 " + fromCurrency;
            }
        }

        private void FillConversionRates()
        {
            Dictionary<string, decimal> conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 1m);
            conversionData.Add("EUR", 0.8872m);
            conversionData.Add("GBP", 0.7614m);
            conversionData.Add("CHF", 1.0074m);
            conversionData.Add("RUB", 65.6900m);
            conversionData.Add("CAD", 1.3372m);
            currencyData.Add("USD", conversionData);

            conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 1.1271m);
            conversionData.Add("EUR", 1m);
            conversionData.Add("GBP", 0.8582m);
            conversionData.Add("CHF", 1.1355m);
            conversionData.Add("RUB", 74.0419m);
            conversionData.Add("CAD", 1.5072m);
            currencyData.Add("EUR", conversionData);

            conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 1.3099m);
            conversionData.Add("EUR", 1.1602m);
            conversionData.Add("GBP", 1m);
            conversionData.Add("CHF", 1.3196m);
            conversionData.Add("RUB", 85.9494m);
            conversionData.Add("CAD", 1.7491m);
            currencyData.Add("GBP", conversionData);

            conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 0.9927m);
            conversionData.Add("EUR", 0.8792m);
            conversionData.Add("GBP", 0.7578m);
            conversionData.Add("CHF", 1m);
            conversionData.Add("RUB", 65.1318m);
            conversionData.Add("CAD", 1.3255m);
            currencyData.Add("CHF", conversionData);

            conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 0.0152m);
            conversionData.Add("EUR", 0.0135m);
            conversionData.Add("GBP", 0.0116m);
            conversionData.Add("CHF", 0.0154m);
            conversionData.Add("RUB", 1m);
            conversionData.Add("CAD", 0.0204m);
            currencyData.Add("RUB", conversionData);

            conversionData = new Dictionary<string, decimal>();
            conversionData.Add("USD", 0.7489m);
            conversionData.Add("EUR", 0.6633m);
            conversionData.Add("GBP", 0.5717m);
            conversionData.Add("CHF", 0.7544m);
            conversionData.Add("RUB", 49.1379m);
            conversionData.Add("CAD", 1m);
            currencyData.Add("CAD", conversionData);
        }

        private void radCheckBoxWrap_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.amountDomainUpDown.Wrap = !this.amountDomainUpDown.Wrap;
            this.fromDomainUpDown.Wrap = !this.fromDomainUpDown.Wrap;
            this.toDomainUpDown.Wrap = !this.toDomainUpDown.Wrap;
        }

        private void radCheckBoxAutoComplete_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.amountDomainUpDown.AutoComplete = !this.amountDomainUpDown.AutoComplete;
            this.fromDomainUpDown.AutoComplete = !this.fromDomainUpDown.AutoComplete;
            this.toDomainUpDown.AutoComplete = !this.toDomainUpDown.AutoComplete;
        }

        private void radCheckBoxReadOnly_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.amountDomainUpDown.ReadOnly = !this.amountDomainUpDown.ReadOnly;
            this.fromDomainUpDown.ReadOnly = !this.fromDomainUpDown.ReadOnly;
            this.toDomainUpDown.ReadOnly = !this.toDomainUpDown.ReadOnly;
        }

        private void radCheckBoxSelectNext_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.amountDomainUpDown.SelectNextOnDoubleClick = !this.amountDomainUpDown.SelectNextOnDoubleClick;
            this.fromDomainUpDown.SelectNextOnDoubleClick = !this.fromDomainUpDown.SelectNextOnDoubleClick;
            this.toDomainUpDown.SelectNextOnDoubleClick = !this.toDomainUpDown.SelectNextOnDoubleClick;
        }
    }
}