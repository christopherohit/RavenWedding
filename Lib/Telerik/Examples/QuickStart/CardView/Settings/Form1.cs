using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CardView.Settings
{
    public partial class Form1 : ExamplesForm
    {
        private FontConverter fontConverter;
        public Form1()
        {
            InitializeComponent();
            this.fontConverter = new FontConverter();
            this.radCardView1.VisualItemFormatting += radCardView1_VisualItemFormatting;
            this.radCardView1.CardViewItemFormatting += radCardView1_CardViewItemFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetInitialValues();
            this.AddDataItems();
            this.radCardView1.ListViewElement.SynchronizeVisualItems();
        }

        private void radCardView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            e.VisualItem.ClipDrawing = false;
            e.VisualItem.Padding = new Padding(5);
        }

        private void radCardView1_CardViewItemFormatting(object sender, CardViewItemFormattingEventArgs e)
        {
            CardViewItem cardItem = e.Item as CardViewItem;
            if (cardItem != null)
            {
                if (cardItem.FieldName == "Column 0")
                {
                    cardItem.EditorItem.DrawText = false;
                    Image image = Image.FromFile(Application.StartupPath + @"\Resources\Cities\" + e.VisualItem.Data["Column 0"]);
                    cardItem.EditorItem.Image = image;
                    cardItem.EditorItem.ImageLayout = ImageLayout.Stretch;
                    cardItem.EditorItem.NotifyParentOnMouseInput = false;
                    cardItem.EditorItem.ShouldHandleMouseInput = false;
                    cardItem.Padding = new Padding(-5, -5, -5, 0);
                    return;
                }
                else if (cardItem.FieldName == "Column 2")
                {
                    cardItem.EditorItem.Text += " million";
                }

               // Font selectedItemFont = this.fontConverter.ConvertFromString(this.radBrowseEditorFont.Value) as Font;
               // if (selectedItemFont != cardItem.Font)
              //  {
                   // Font itemFont = new Font(cardItem.Font.FontFamily, cardItem.Font.Size, FontStyle.Bold);
                    Font editorFont = new Font(cardItem.Font.FontFamily, cardItem.Font.Size, FontStyle.Regular);

                   // cardItem.Font = itemFont;
                    cardItem.EditorItem.Font = editorFont;
              //  }
            }
        }

        private void AddDataItems()
        {
            // image path, city, population, country
            this.radCardView1.Items.Add("Bejing.jpg", "Bejing", 21.516f, "China");
            this.radCardView1.Items.Add("Berlin.jpg", "Berlin", 3.562f, "Germany");
            this.radCardView1.Items.Add("Bloemfontain.jpg", "Bloemfontain", 0.256f, "South Africa");
            this.radCardView1.Items.Add("Bombay.jpg", "Bombay", 12.479f, "India");
            this.radCardView1.Items.Add("Bonn.jpg", "Bonn", 0.314f, "Germany");
            this.radCardView1.Items.Add("Boston.jpg", "Boston", 0.656f, "United States");
            this.radCardView1.Items.Add("Buenos Aires.jpg", "Buenos Aires", 2.891f, "Argentina");
            this.radCardView1.Items.Add("Cairo.jpg", "Cairo", 10.230f, "Egypt");
            this.radCardView1.Items.Add("Cancun.jpg", "Cancun", 0.723f, "Mexico");
            this.radCardView1.Items.Add("Cannes.jpg", "Cannes", 0.074f, "France");
            this.radCardView1.Items.Add("Cape Town.jpg", "Cape Town", 3.750f, "South Africa");
            this.radCardView1.Items.Add("Frankfurt.jpg", "Frankfurt", 0.718f, "Germany");
            this.radCardView1.Items.Add("Jakarta.jpg", "Jakarta", 9.608f, "Indonesia");
            this.radCardView1.Items.Add("Liverpool.jpg", "Liverpool", 0.473f, "United Kingdom");
            this.radCardView1.Items.Add("London.jpg", "London", 8.539f, "United Kingdom");
            this.radCardView1.Items.Add("Los Angeles.jpg", "Los Angeles", 3.929f, "United States");
            this.radCardView1.Items.Add("Manchester.jpg", "Manchester", 0.520f, "United Kingdom");
            this.radCardView1.Items.Add("Melbourne.jpg", "Melbourne", 4.530f, "Australia");
            this.radCardView1.Items.Add("Mexico City.jpg", "Mexico City", 8.918f, "Mexico");
            this.radCardView1.Items.Add("Nairobi.jpg", "Nairobi", 3.138f, "Kenya");
            this.radCardView1.Items.Add("New Brazil.jpg", "Brasilia", 2.556f, "Brasil");
            this.radCardView1.Items.Add("New Delhi.jpg", "New Delhi", 18.686f, "India");
            this.radCardView1.Items.Add("New York.jpg", "New York", 8.550f, "United States");
            this.radCardView1.Items.Add("Nice.jpg", "Nice", 0.344f, "France");
            this.radCardView1.Items.Add("Ottawa.jpg", "Ottawa", 0.883f, "Canada");
            this.radCardView1.Items.Add("Paris.jpg", "Paris", 2.241f, "France");
            this.radCardView1.Items.Add("Pretoria.jpg", "Pretoria", 0.742f, "South Africa");
            this.radCardView1.Items.Add("Rio de Janeiro.jpg", "Rio de Janeiro", 6.454f, "Argentina");
            this.radCardView1.Items.Add("San Francisco.jpg", "San Francisco", 0.852f, "United States");
            this.radCardView1.Items.Add("Santiago.jpg", "Santiago", 6.158f, "Chile");
            this.radCardView1.Items.Add("Sao Paolo.jpg", "Sao Paolo", 11.967f, "Brazil");
            this.radCardView1.Items.Add("Seattle.jpg", "Seattle", 3.059, "United States");
            this.radCardView1.Items.Add("Sydney.jpg", "Sydney", 4.921f, "Australia");
            this.radCardView1.Items.Add("Toronto.jpg", "Toronto", 5.133f, "Canada");
            this.radCardView1.Items.Add("Vancouver.jpg", "Vancouver", 2.135f, "Canada");
            this.radCardView1.Items.Add("Wellington.jpg", "Wellington", 0.398f, "New Zeland");
        }

        private void SetInitialValues()
        {
            this.radCheckBoxAllowEdit.ToggleState = this.radCardView1.AllowEdit ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxShowGroups.ToggleState =
                this.radCardView1.ShowGroups ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxHotTracking.ToggleState = this.radCardView1.HotTracking ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxAllowCustomize.ToggleState =
                this.radCardView1.CardTemplate.AllowCustomize ? ToggleState.On : ToggleState.Off;
            this.radDropDownListOrientation.SelectedIndex =
                this.radCardView1.CardViewElement.ViewElement.Orientation == Orientation.Horizontal ? 0 : 1;
            CardListViewElement viewElement = this.radCardView1.CardViewElement.ViewElement as CardListViewElement;
            List<LayoutControlItemBase> items = viewElement.GetAllChildItems(this.radCardView1.CardTemplate.Items);
            foreach (CardViewItem item in items)
            {
                if (item.FieldName != "Column 0")
                {
                    string text = this.GetItemText(item.FieldName);
                    RadListDataItem dataItem = new RadListDataItem(text, item);
                    this.radDropDownListVisualItems.Items.Add(dataItem);
                }
            }
            this.radDropDownListVisualItems.SelectedIndex = 0;
        }

        private string GetItemText(string fieldName)
        {
            return this.radCardView1.Columns[fieldName].HeaderText;
        }

        private void radCheckBoxAllowEdit_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCardView1.AllowEdit = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxShowGroups_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool groupItems = args.ToggleState == ToggleState.On;
            if (groupItems)
            {
                this.radCardView1.ShowGroups = true;
                this.radCardView1.EnableGrouping = true;
                Telerik.WinControls.Data.GroupDescriptor groupByCountry = new Telerik.WinControls.Data.GroupDescriptor(new Telerik.WinControls.Data.SortDescriptor[] 
                {
                    new Telerik.WinControls.Data.SortDescriptor(this.radCardView1.Columns[3].Name, ListSortDirection.Descending), 
                });

                this.radCardView1.GroupDescriptors.Add(groupByCountry);
            }
            else
            {                
                this.radCardView1.ShowGroups = false;
                this.radCardView1.EnableGrouping = false;
                this.radCardView1.GroupDescriptors.Clear();
            }
        }

        private void radCheckBoxHotTracking_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCardView1.HotTracking = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxAllowCustomize_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCardView1.CardTemplate.AllowCustomize = args.ToggleState == ToggleState.On;
        }

        private void radDropDownListOrientation_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCardView1.CardViewElement.ViewElement.Orientation =
                e.Position == 0 ? Orientation.Horizontal : Orientation.Vertical;
        }

        private bool updatingItemValues = false;
        private void radDropDownListVisualItems_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            CardViewItem item = this.radDropDownListVisualItems.SelectedItem.Value as CardViewItem;
            if (item != null)
            {
                this.updatingItemValues = true;
                this.radColorBoxBackColor.Value = item.BackColor;
                this.radColorBoxForeColor.Value = item.ForeColor;
                string fontAsString = fontConverter.ConvertToString(item.Font);
                this.radBrowseEditorFont.Value = fontAsString;
                this.radColorBoxBorderColor.Value = item.BorderColor;
                this.updatingItemValues = false;
            }
        }

        private void radColorBoxBackColor_ValueChanged(object sender, EventArgs e)
        {
            if (this.updatingItemValues)
            {
                return;
            }

            CardViewItem item = this.radDropDownListVisualItems.SelectedItem.Value as CardViewItem;
            if (item != null)
            {
                item.DrawFill = true;
                item.BackColor = this.radColorBoxBackColor.Value;
                item.GradientStyle = GradientStyles.Solid;
            }
        }

        private void radColorBoxForeColor_ValueChanged(object sender, EventArgs e)
        {
            if (this.updatingItemValues)
            {
                return;
            }

            CardViewItem item = this.radDropDownListVisualItems.SelectedItem.Value as CardViewItem;
            if (item != null)
            {
                item.ForeColor = this.radColorBoxForeColor.Value;
            }
        }

        private void radBrowseEditorFont_ValueChanged(object sender, EventArgs e)
        {
            if (this.updatingItemValues)
            {
                return;
            }

            CardViewItem item = this.radDropDownListVisualItems.SelectedItem.Value as CardViewItem;
            if (item != null)
            {
                Font font = fontConverter.ConvertFromString(this.radBrowseEditorFont.Value) as Font;
                item.Font = font;
            }
        }

        private void radColorBoxBorderColor_ValueChanged(object sender, EventArgs e)
        {
            if (this.updatingItemValues)
            {
                return;
            }

            CardViewItem item = this.radDropDownListVisualItems.SelectedItem.Value as CardViewItem;
            if (item != null)
            {
                item.DrawBorder = true;
                item.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                item.BorderGradientStyle = GradientStyles.Solid;
                item.BorderColor = this.radColorBoxBorderColor.Value;
                item.BorderWidth = 1;
            }
        }
    }
}