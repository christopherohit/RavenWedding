using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PageView.StripView.ItemDragDrop
{
	public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
			InitializeComponent();
            this.SetPreferences();
        }

        private void SetPreferences()
        {
            RadDragDropService service = this.radPageView1.ViewElement.ItemDragService;
            service.Starting += ItemDragService_Starting;
            service.Started += ItemDragService_Started;
            service.Stopping += ItemDragService_Stopping;
            service.Stopped += ItemDragService_Stopped;
            service.PreviewDropTarget += ItemDragService_PreviewDropTarget;

            this.textBox1.ReadOnly = true;

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView3.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            this.radGridView1.Columns["UnitPrice"].FormatString = "${0}";
            this.radGridView1.Columns["UnitPrice"].TextAlignment = ContentAlignment.MiddleRight;
            this.radGridView2.TableElement.RowHeight += 5;
            this.radGridView3.Columns["OrderID"].TextAlignment = ContentAlignment.MiddleRight;

            foreach (PageViewItemDragMode mode in Enum.GetValues(typeof(PageViewItemDragMode)))
            {
                RadListDataItem item = new RadListDataItem(mode.ToString());
                this.dragModeCombo.Items.Add(item);
            }
            this.dragModeCombo.SelectedIndex = 0;
        }

        #region Event Handlers

        private void ItemDragService_PreviewDropTarget(object sender, PreviewDropTargetEventArgs e)
        {
            RadDragDropService service = sender as RadDragDropService;
            RadPageViewItem item = e.DropTarget as RadPageViewItem;
            if (item != null)
            {
                ShowEventMessage(item.Text, "ItemDragService.PreviewDropTarget");
            }
        }

        private void ItemDragService_Stopped(object sender, EventArgs e)
        {
            RadDragDropService service = sender as RadDragDropService;
            ShowEventMessage(string.Empty, "ItemDragService.Stopped");
        }

        private void ItemDragService_Stopping(object sender, RadServiceStoppingEventArgs e)
        {
            RadDragDropService service = sender as RadDragDropService;
            ShowEventMessage((service.Context as RadPageViewItem).Text, "ItemDragService.Stopping");
        }

        private void ItemDragService_Started(object sender, EventArgs e)
        {
            RadDragDropService service = sender as RadDragDropService;
            ShowEventMessage((service.Context as RadPageViewItem).Text, "ItemDragService.Started");
        }

        private void ItemDragService_Starting(object sender, RadServiceStartingEventArgs e)
        {
            RadDragDropService service = sender as RadDragDropService;
            ShowEventMessage((e.Context as RadPageViewItem).Text, "ItemDragService.Starting");
        }

		private void ShowEventMessage(string itemText, string eventName)
		{
			this.textBox1.Text += string.Format("\"{0}\" {1}" + Environment.NewLine, itemText, eventName);
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
            this.textBox1.ScrollToCaret();
        }

        private void radButtonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void dragModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem selectedItem = this.dragModeCombo.SelectedItem;
            this.radPageView1.ViewElement.ItemDragMode = (PageViewItemDragMode)Enum.Parse(typeof(PageViewItemDragMode), selectedItem.Text);
        }

        #endregion

        protected override void WireEvents()
        {
            this.radButtonClear.Click += new System.EventHandler(this.radButtonClear_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.dragModeCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dragModeCombo_SelectedIndexChanged);
        }
    }
}