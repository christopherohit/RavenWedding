using System;
using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.SpinEditor
{

    /// <summary>
    /// example forms
    /// </summary>
    public partial class Form1 : EditorExampleBaseForm
    {
        Font eventListItemFont;

        public Form1()
        {
            InitializeComponent();

            eventListItemFont = new Font("Lucida Sans Unicode", 7.2f);

            this.radSpinDemo.ValueChanging += new Telerik.WinControls.UI.ValueChangingEventHandler(radSpinEdit1_ValueChanging);
            this.radSpinDemo.ValueChanged += new EventHandler(radSpinEditor1_ValueChanged);
            this.radSpinDemo.RightToLeftChanged += new EventHandler(radSpinEditor1_RightToLeftChanged);
            this.radSpinDemo.PropertyChanged += new PropertyChangedEventHandler(radSpinEditor1_PropertyChanged);            
        }

        void radSpinEditor1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Font = eventListItemFont;
            item.Text = "PropertyChanged\n";
            this.radListBox1.Items.Add(item);
        }

        void radSpinEditor1_RightToLeftChanged(object sender, EventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Font = eventListItemFont;
            item.Text = "RightToLeftChanged fired\n";
            this.radListBox1.Items.Add(item);
        }

        void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Font = eventListItemFont;
            item.Text = "ValueChanged fired\n";
            this.radListBox1.Items.Add(item);
        }

        private void radSpinEdit1_ValueChanging(object sender, Telerik.WinControls.UI.ValueChangingEventArgs e)
        {
            RadListDataItem item = new RadListDataItem();
            item.Font = eventListItemFont;
            item.Text = "ValueChanging fired\n";
            this.radListBox1.Items.Add(item);
        }

        private void OnCheckRightToLeft_StateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radSpinDemo.RightToLeft = this.radCheckBox1.Checked ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radListBox1.Items.Clear();
        }

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckRightToLeft_StateChanged);
        }
    }
}