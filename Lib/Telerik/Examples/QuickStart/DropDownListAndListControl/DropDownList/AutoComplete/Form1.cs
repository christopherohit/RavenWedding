using System;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.AutoComplete
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Timer dropDownShowTimeOut;

		public Form1()
		{
			InitializeComponent();     
       
            this.dropDownShowTimeOut = new Timer(this.components);
            this.dropDownShowTimeOut.Interval = 1000;
            this.dropDownShowTimeOut.Tick += new EventHandler(dropDownShowTimeOut_Tick);
            this.components.Add(this.dropDownShowTimeOut);
			this.SelectedControl = radComboDemo;
            this.radComboAutoCompl.SelectedText = this.radComboDemo.AutoCompleteMode.ToString();
            this.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.radComboDemo.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.radComboDemo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboDemo_SelectedIndexChanged);
		}

        void radComboDemo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateDropDown(sender, e);
        }

        #region Event handling

        private void OnAutoCompleteMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListDataItem selectedItem = this.radComboAutoCompl.SelectedItem; 

            if (selectedItem == null)
                return;

            switch (selectedItem.Text)
            {
                case "None":
                    this.radComboDemo.AutoCompleteMode = AutoCompleteMode.None;
                    break;
                case "Suggest":
                    this.radComboDemo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    break;
                case "Append":
                    this.radComboDemo.AutoCompleteMode = AutoCompleteMode.Append;
                    break;
                case "SuggestAppend":
                    this.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    break;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radComboAutoCompl.SelectedIndex = 3;
            this.dropDownShowTimeOut.Start();
            this.radComboDemo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.radComboDemo.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        protected override void WireEvents()
        {
            this.radBtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.radBtnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.radTxtText.TextChanged += new System.EventHandler(this.radTxtText_TextChanged);
            this.radCheckCaseSens.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chBoxCaseSensitive_CheckedChanged);
            this.radComboAutoCompl.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.OnAutoCompleteMode_SelectedIndexChanged);
        }

		private void radComboAutoCompleteMode_SelectedIndexChanged(object sender, EventArgs e)
		{
            radComboDemo.AutoCompleteMode = (AutoCompleteMode)radComboAutoCompl.SelectedIndex;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            RadListDataItem element = new RadListDataItem();
			int num = radComboDemo.Items.Count + 1;
			element.Text = "New item " + num.ToString();
			radComboDemo.Items.Add(element);
            radComboDemo.SelectedItem = element;
            UpdateDropDown(radComboDemo, EventArgs.Empty);
		}

        private void dropDownShowTimeOut_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.Focus();
            this.radComboDemo.ShowDropDown();
            this.dropDownShowTimeOut.Stop();
            
        }

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (radComboDemo.SelectedIndex != -1)
			{
				radComboDemo.Items.Remove(radComboDemo.Items[radComboDemo.SelectedIndex]);
                UpdateDropDown(radComboDemo, EventArgs.Empty);
			}
		}

		private void radTxtText_TextChanged(object sender, EventArgs e)
		{
			RadListDataItem item = radComboDemo.SelectedItem;
			if ((item != null) && (item.Text != radTxtText.Text))
			{
                radComboDemo.SelectedItem.Text = radTxtText.Text;
			}
		}

        private void chBoxCaseSensitive_CheckedChanged(object sender, StateChangedEventArgs args)
        {
            radComboDemo.CaseSensitive = radCheckCaseSens.Checked;
        }

        private void UpdateDropDown(object sender, EventArgs e)
        {
            if (radComboDemo.SelectedIndex != -1)
            {
                radTxtIndex.Text = radComboDemo.SelectedIndex.ToString();
                RadListDataItem item = radComboDemo.SelectedItem;
                radTxtText.Text = item.Text;
            }
            else
            {
                radTxtIndex.Text = radComboDemo.SelectedIndex.ToString();
                radTxtText.Text = "";
            }
        }
        #endregion
    }
}
