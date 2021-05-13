using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.GridView.Export.SaveLoadLayout
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.None;

            this.radGridView1.TableElement.BeginUpdate();

            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;


            this.radGridView1.DataSource = customersBindingSource;

            this.radGridView1.MasterTemplate.Columns[0].VisibleInColumnChooser = false;
            this.radGridView1.MasterTemplate.Columns[1].AllowGroup = false;

            this.radGridView1.TableElement.EndUpdate();

            this.SelectedControl = this.radGridView1;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string s = "default.xml";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter =
               "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                s = dialog.FileName;
            }

            this.radGridView1.SaveLayout(s);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            string s = "default.xml";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                s = dialog.FileName;
            }

            this.radGridView1.LoadLayout(s);
        }

        protected override void WireEvents()
        {
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}