using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.ListView.CustomItems
{
    public partial class Form1 : ListViewExamplesControl, ICustomThemeExamplesForm
    { 
        public Form1()
        {
            InitializeComponent();

            this.radListView1.ItemSize = new Size(200, 300);
            this.radListView1.AllowArbitraryItemHeight = true;
            this.radListView1.ItemSpacing = 10;
            this.radListView1.EnableKineticScrolling = true;

            this.radListView1.ListViewElement.ViewElement.ViewElement.Margin = new Padding(0, 10, 0, 10);
            this.radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal;
            this.radListView1.Dock = DockStyle.Fill;
        } 

        private void radListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new CustomVisualItem();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.albumsDataTableTableAdapter.Fill(this.musicCollectionDataSet.TableAlbumsDataTable);
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.EnableKineticScrolling = this.radCheckBox1.Checked;
        }
         
        public override Control ContentControl
        {
            get
            {
                return this.radListView1;
            }
        }

    }
}
