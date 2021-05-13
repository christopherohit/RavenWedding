using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ListControl.DragAndDrop
{

    public partial class Form1 : ExamplesForm
    {
        RadItemDragDropManager dragDropMan1;
        private Font itemsFont = null;

        public Form1()
        {
            InitializeComponent();

            Font font = new Font("Segoe Print", 12.0f, FontStyle.Bold);
            itemsFont = font;
            foreach (RadListDataItem item in this.radListBox1.Items)
            {
                item.Font = font;
            }

            dragDropMan1 = new RadItemDragDropManager(this.radListBox1, this.radListBox1.Items, this.radListBox2, this.radListBox2.Items);

            this.radListBox1.AutoSizeItems = true;
            this.radListBox2.AutoSizeItems = true;

            this.Disposed += new EventHandler(Form1_Disposed);
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            itemsFont.Dispose();   
        }

        void radButton1_Click(object sender, EventArgs e)
        {
            //moves selectedItem from ListBox1 to ListBox2
            MoveToTargetListBox(radListBox1, radListBox2);
        }

        void radButton2_Click(object sender, EventArgs e)
        {
            //moves selectedItem from ListBox2 to ListBox1
            MoveToTargetListBox(radListBox2, radListBox1);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            //moves all items from listBox1 to ListBox2
            MoveAllItems(radListBox1, radListBox2);
        }

        void radButton4_Click(object sender, EventArgs e)
        {
            //moves all items from listBox2 to ListBox1
            MoveAllItems(radListBox2, radListBox1);
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            //moves up SelectedItem in radListBox1 
            MoveUp(radListBox1);
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            //moves down SelectedItem in radListBox1
            MoveDown(radListBox1);
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            //moves up SelectedItem in radListBox2
            MoveUp(radListBox2);
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            //moves down SelectedItem in radListBox2
            MoveDown(radListBox2);
        }

        private void MoveUp(RadListControl listBox)
        {
            if (listBox.Items.Count < 2) { return; }
            if (listBox.SelectedItem == null) { return; }
            if (listBox.SelectedIndex == 0) { return; }
            RadListDataItem item = listBox.SelectedItem;
            int index = listBox.SelectedIndex;
            listBox.Items.Remove(item);
            listBox.Items.Insert(index - 1, item);
            listBox.SelectedItem = item;
        }

        private void MoveDown(RadListControl listBox)
        {
            if (listBox.Items.Count < 2) { return; }
            if (listBox.SelectedItem == null) { return; }
            if (listBox.SelectedIndex == listBox.Items.Count - 1) { return; }
            RadListDataItem item = listBox.SelectedItem;
            int index = listBox.SelectedIndex;
            listBox.Items.Remove(item);
            listBox.Items.Insert(index + 1, item);
            listBox.SelectedItem = item;
        }

        private void MoveAllItems(RadListControl sourceListBox, RadListControl targetListBox)
        {
            for (int i = 0; i < sourceListBox.Items.Count; )
            {
                RadListDataItem item = sourceListBox.Items[i];
                sourceListBox.Items.Remove(item);
                targetListBox.Items.Add(item);
            }
        }

        private void MoveToTargetListBox(RadListControl sourceListBox, RadListControl targetListBox)
        {
            if (sourceListBox.Items.Count == 0) { return; }
            if (sourceListBox.SelectedItem == null) { return; }

            RadListDataItem item = sourceListBox.SelectedItem;
            sourceListBox.Items.Remove(item);
            targetListBox.Items.Add(item);
        }

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            this.radButton7.Click += new System.EventHandler(this.radButton7_Click);
            this.radButton8.Click += new System.EventHandler(this.radButton8_Click);
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            this.radButton6.Click += new System.EventHandler(this.radButton6_Click);
        }
    }
}
