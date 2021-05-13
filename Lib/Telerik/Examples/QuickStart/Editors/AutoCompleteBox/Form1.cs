using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupAutoComplete(this.radAutoCompleteBox1);
            this.SetupAutoComplete(this.radAutoCompleteBox2);

            this.radDropDownListAutoCompleteMode.DropDownStyle = RadDropDownStyle.DropDownList;
            this.radDropDownListAutoCompleteMode.SelectedIndex = 0;
            this.radDropDownListAutoCompleteMode.SelectedIndexChanged += this.OnRadDropDownListAutoCompleteModeSelectedIndexChanged;
        }


        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //    if (this.radPanel1 != null)
        //    {
        //        float xCoord = ((float)(this.Width - this.radPanel1.Width)) / 2;
        //        float yCoord = ((float)(this.Height - this.radPanel1.Height)) / 2;
        //        this.radPanel1.Location = Point.Round(new PointF(xCoord, yCoord));
        //    }
        //}

        private void SetupAutoComplete(RadAutoCompleteBox radAutoCompleteBox)
        {
            radAutoCompleteBox.Items.CollectionChanged += this.OnItemsCollectionChanged;
            radAutoCompleteBox.AutoCompleteDisplayMember = "Name";
            radAutoCompleteBox.AutoCompleteValueMember = "Email";
            radAutoCompleteBox.ListElement.VisualItemFormatting += this.OnListElementVisualItemFormatting;
            radAutoCompleteBox.AutoCompleteDataSource = new BindingSource(this.GetAutoCompleteDataSource(), string.Empty);
            radAutoCompleteBox.DropDownMaxSize = new Size(200, 0);
            this.FillList(radAutoCompleteBox.Items);
        }

        private void OnListElementVisualItemFormatting(object sender, VisualItemFormattingEventArgs e)
        {
            RadListDataItem dataItem = e.VisualItem.Data;
            e.VisualItem.Text = string.Format("{0} <{1}>", dataItem.Text, dataItem.Value);
        }

        private DataTable GetAutoCompleteDataSource()
        {
            DataTable table = new DataTable("Contacts");
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("Joe Smith", "joe@fakecompany.com");
            table.Rows.Add("Adam Petersen", "adam@qwerty.com");
            table.Rows.Add("Jack Russel", "jack@russel.nocom");
            table.Rows.Add("Daniel Finger", "daniel.pinger@gmail.com");
            table.Rows.Add("Richard Vail", "rvail@richardvail.com");
            table.Rows.Add("Sebastian Jonnson", "s.jonnson@sjonnson.com");
            table.Rows.Add("Lee Cooper", "lee.cooper@coopercoorp.com");
            table.Rows.Add("Kelvin Clain", "kclain@clainkevin.com");
            table.Rows.Add("Maria Jenson", "mjenson@mariajenson.com");
            table.Rows.Add("Chelsea Maarten", "chelsea@maarten.com");
            table.Rows.Add("Jenson Chew", "jenson.chew@nospam.com");
            table.Rows.Add("Martin Williams", "m.williams@martinandwilliams.com");
            table.Rows.Add("Telerik", "clientservice@telerik.com");
            table.Rows.Add("James Stone", "james.stone@manystones.com");
            table.Rows.Add("Samuel Jackson", "samuel.jackson@nojackson.com");

            return table;
        }


        private void OnRadDropDownListAutoCompleteModeSelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radDropDownListAutoCompleteMode.SelectedItem != null)
            {
                string text = this.radDropDownListAutoCompleteMode.SelectedItem.Text;
                AutoCompleteMode mode = (AutoCompleteMode)Enum.Parse(typeof(AutoCompleteMode), text);
                this.radAutoCompleteBox1.AutoCompleteMode = mode;
                this.radAutoCompleteBox2.AutoCompleteMode = mode;
            }
        }

        private void OnItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            RadTokenizedTextItemCollection items = sender as RadTokenizedTextItemCollection;
            this.FillList(items);
        }

        private void FillList(RadTokenizedTextItemCollection items)
        {
            RadListControl control = this.radAutoCompleteBox1.Items != items ?
             this.radListControlRecipients : this.radListControlCarbonCopy;

            control.Items.Clear();

            foreach (RadTokenizedTextItem item in items)
            {
                string text = item.Text;

                if (item.Value != null)
                {
                    text = string.Format("{0} <{1}>", text, item.Value);
                }

                control.Items.Add(new RadListDataItem(text));
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
