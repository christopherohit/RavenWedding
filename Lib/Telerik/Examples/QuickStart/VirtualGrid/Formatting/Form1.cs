using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Formatting
{
    public partial class Form1 : ExamplesForm
    {
        Timer timer = new Timer();
        Random rnd = new Random();
        DataTable stocks = new DataTable();
        Dictionary<int, bool> changes = new Dictionary<int, bool>();
        Dictionary<int, int> changeDuration = new Dictionary<int, int>();
        int secondsToKeepChangesVisible = 4;

        public Form1()
        {
            InitializeComponent();

            this.PrepareData();

            this.radVirtualGrid1.ColumnCount = this.stocks.Columns.Count;
            this.radVirtualGrid1.RowCount = this.stocks.Rows.Count;

            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.TableElement.ColumnWidth = 150;

            this.radVirtualGrid1.CellValueNeeded += radVirtualGrid1_CellValueNeeded;
            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.RowFormatting += radVirtualGrid1_RowFormatting;
            this.radVirtualGrid1.EditorRequired += radVirtualGrid1_EditorRequired;
            
            timer.Interval = 1000;
            timer.Start();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            timer.Tick += timer_Tick;           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.radVirtualGrid1.BeginUpdate();
            int numberOfchanges = this.rnd.Next(0, 3);

            List<int> changesToRemove = new List<int>();
            List<int> changesToIncrement = new List<int>();

            foreach (KeyValuePair<int, int> pair in this.changeDuration)
            {
                if (pair.Value == this.secondsToKeepChangesVisible)
                {
                    changesToRemove.Add(pair.Key);
                }
                else
                {
                    changesToIncrement.Add(pair.Key);
                }
            }

            foreach (int index in changesToRemove)
            {
                this.changeDuration.Remove(index);
                this.changes.Remove(index);
            }

            foreach (int index in changesToIncrement)
            {
                this.changeDuration[index]++;
            }
            
            for (int i = 0; i < numberOfchanges; i++)
            {
                int stockIndex = this.rnd.Next(0, this.stocks.Rows.Count);

                double price = (double)this.stocks.Rows[stockIndex]["Price"];
                double change = (double)this.stocks.Rows[stockIndex]["Change"];
                double delta = (this.rnd.NextDouble() - 0.5d) * this.rnd.Next(1, 4);
                double open = (double)this.stocks.Rows[stockIndex]["Open"];

                price += delta;

                this.stocks.Rows[stockIndex]["Price"] = price;
                this.stocks.Rows[stockIndex]["Change"] = change + delta;
                this.stocks.Rows[stockIndex]["Percentage"] = change / open / 100d;

                if (changes.ContainsKey(stockIndex))
                {
                    this.changes[stockIndex] = delta > 0d;
                }
                else
                {
                    this.changes.Add(stockIndex, delta > 0d);
                }

                if (this.changeDuration.ContainsKey(stockIndex))
                {
                    this.changeDuration[stockIndex] = 0;
                }
                else
                {
                    this.changeDuration.Add(stockIndex, 0);
                }
            }

            this.radVirtualGrid1.EndUpdate();        
            this.radVirtualGrid1.VirtualGridElement.TableElement.SynchronizeRows();    
        }

        private void PrepareData()
        {
            this.stocks.Columns.Add("Symbol");
            this.stocks.Columns.Add("Price", typeof(double));
            this.stocks.Columns.Add("Open", typeof(double));
            this.stocks.Columns.Add("High", typeof(double));
            this.stocks.Columns.Add("Low", typeof(double));
            this.stocks.Columns.Add("Change", typeof(double));
            this.stocks.Columns.Add("Percentage", typeof(double));

            for (int i = 0; i < 20; i++)
            {
                string symbol = "" + (char)(65 + this.rnd.Next(25)) + (char)(65 + this.rnd.Next(25)) + (char)(65 + this.rnd.Next(25)) + (char)(65 + this.rnd.Next(25));
                double price = this.rnd.Next(100, 600) + (this.rnd.NextDouble() - 0.5d);
                double low = (double)this.rnd.Next(80, 95) / 100d * price;
                double high = (double)this.rnd.Next(105, 120) / 100d * price;
                double open = this.rnd.Next((int)(low + 2d), (int)(high - 2d)) + this.rnd.NextDouble();
                double change = price - open;
                double percentage = change / open / 100d;

                this.stocks.Rows.Add(symbol, price, open, high, low, change, percentage);
            }
        }

        private void radVirtualGrid1_EditorRequired(object sender, VirtualGridEditorRequiredEventArgs e)
        {
            e.Cancel = true;
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0 || e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            string columnName = this.stocks.Columns[e.CellElement.ColumnIndex].ColumnName;

            switch (columnName)
            {
                case "Symbol":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
                case "Price":
                case "Open":
                case "High":
                case "Low":
                case "Close":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    e.CellElement.Text = string.Format("{0:F2}", double.Parse(Convert.ToString(e.CellElement.Value)));
                    break;
                case "Change":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    double value = double.Parse(Convert.ToString(e.CellElement.Value));
                    bool raising = value >= 0;
                    e.CellElement.Text = string.Format("{0:F2} " + (raising ? "▲" : "▼"), value);
                    e.CellElement.UseCompatibleTextRendering = false;

                    if (this.changeDuration.ContainsKey(e.CellElement.RowIndex) && this.changeDuration[e.CellElement.RowIndex] < 2)
                    {
                        e.CellElement.BorderWidth = 2;
                        e.CellElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
                        e.CellElement.ZIndex = 5;
                        e.CellElement.RowElement.ZIndex = 5;

                        if (this.changes[e.CellElement.RowIndex])
                        {
                            e.CellElement.BorderColor = Color.FromArgb(250, Color.Green);
                        }
                        else
                        {
                            e.CellElement.BorderColor = Color.FromArgb(250, Color.Red);
                        }
                    }
                    else
                    {
                        e.CellElement.ResetValue(LightVisualElement.BorderColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BorderWidthProperty, Telerik.WinControls.ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BorderBoxStyleProperty, Telerik.WinControls.ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.ZIndexProperty, Telerik.WinControls.ValueResetFlags.Local);
                        e.CellElement.RowElement.ResetValue(LightVisualElement.ZIndexProperty, Telerik.WinControls.ValueResetFlags.Local);
                    }

                    break;
                case "Percentage":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    e.CellElement.Text = string.Format("{0:P2}", double.Parse(Convert.ToString(e.CellElement.Value)));
                    break;

            }
        }

        private void radVirtualGrid1_RowFormatting(object sender, VirtualGridRowElementEventArgs e)
        {
            if (e.RowElement.RowIndex < 0)
            {
                return;
            }

            if (this.changeDuration.ContainsKey(e.RowElement.RowIndex))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;

                if (this.changes[e.RowElement.RowIndex])
                {
                    e.RowElement.BackColor = Color.FromArgb(50, Color.Green);
                }
                else
                {
                    e.RowElement.BackColor = Color.FromArgb(50, Color.Red);
                }
            }
            else
            {
                e.RowElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.stocks.Columns[e.ColumnIndex].ColumnName;
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            e.FieldName = this.stocks.Columns[e.ColumnIndex].ColumnName;
            e.Value = this.stocks.Rows[e.RowIndex][e.FieldName];
        }
    }
}
