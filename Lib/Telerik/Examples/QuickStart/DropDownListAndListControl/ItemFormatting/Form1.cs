using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Globalization;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.ItemFormatting
{
    public partial class Form1 : ExamplesForm
    {
        private const int NumberOfItems = 37;

        private string[] bgColors = new string[]{
            "#f3f3f3",
            "#eff1ea",                              
            "#ebefe0",                              
            "#e3eccf",                              
            "#dce9c0",                               
            "#d3e9a3",                              
            "#c7e97d"                               
        };

        private string[] textColors = new string[]{
            "#85b949",
            "#9cb97b",                              
            "#a9b997",                              
            "#8d9c90",                              
            "#757575",                               
            "#575757",                              
            "#000000"                               
        };

        public Form1()
        {
            InitializeComponent();

            this.radListControl1.ListElement.AutoSizeItems = true;
            this.radDropDownList1.ListElement.AutoSizeItems = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string[] list = new string[NumberOfItems];
            for (int i = 0;i < NumberOfItems;++i)
            {
                string text = "<html><color=" + textColors[i % 7] + "><size=" + (i + 8).ToString() + ">Item " + (i + 1).ToString();            
                list[i] = text;
            }

            this.radListControl1.DataSource = list;
            this.radDropDownList1.DataSource = list;
        }
      
        void radListControl1_VisualItemFormatting(object sender, Telerik.WinControls.UI.VisualItemFormattingEventArgs args)
        {
            RadListVisualItem item = args.VisualItem;
            int rowIndex = item.Data.RowIndex;
            System.ComponentModel.TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(Color));
            item.DrawFill = true;
            item.BackColor = (Color)typeConverter.ConvertFromString(null, CultureInfo.InvariantCulture, bgColors[rowIndex % 7]);
            item.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            if (item.Selected)
            {
                item.BorderColor = Color.Black;
                item.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                item.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
                item.DrawBorder = true;
            }
            else 
            {
                item.ResetValue(RadListVisualItem.BorderColorProperty, ValueResetFlags.Local);
                item.ResetValue(RadListVisualItem.BorderGradientStyleProperty, ValueResetFlags.Local);
                item.ResetValue(RadListVisualItem.BorderBoxStyleProperty, ValueResetFlags.Local);
                item.ResetValue(RadListVisualItem.DrawBorderProperty, ValueResetFlags.Local);
            }

        }

        protected override void WireEvents()
        {
            this.radListControl1.VisualItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.radListControl1_VisualItemFormatting);
            this.radDropDownList1.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.radListControl1_VisualItemFormatting);
        }
    }
}
