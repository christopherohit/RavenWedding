using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CardView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radCardView1.CardViewItemFormatting += radCardView1_CardViewItemFormatting;
            this.radCardView1.CardViewElement.DrawBorder = false;
        }

        void radCardView1_CardViewItemFormatting(object sender, CardViewItemFormattingEventArgs e)
        {
            CardViewItem cardViewItem = e.Item as CardViewItem;
            if (cardViewItem != null)
            {
                if (cardViewItem.FieldName == "Notes")
                {
                    cardViewItem.EditorItem.TextWrap = true;
                    cardViewItem.EditorItem.AutoEllipsis = true;
                }
                else
                {
                    cardViewItem.EditorItem.ResetValue(LightVisualElement.TextWrapProperty, Telerik.WinControls.ValueResetFlags.Local);
                }

                if (cardViewItem.FieldName == "TitleOfCourtesy" || cardViewItem.FieldName == "FirstName" || cardViewItem.FieldName == "LastName")
                {
                    cardViewItem.Font = new Font(cardViewItem.Font.FontFamily, 10.5f, FontStyle.Regular);
                }
                else
                {
                    Font itemFont = new Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Bold);
                    Font editorFont = new Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Regular);

                    cardViewItem.Font = itemFont;
                    cardViewItem.EditorItem.Font = editorFont;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
        }
    }
}
