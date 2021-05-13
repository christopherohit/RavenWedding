using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataFilter.Settings
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radDataFilter1.Descriptors.Add(new DataFilterDescriptorItem("TextItem", typeof(string)));
            this.radDataFilter1.Descriptors.Add(new DataFilterDescriptorItem("IntegerItem", typeof(int)));
            this.radDataFilter1.Descriptors.Add(new DataFilterDescriptorItem("DoubleItem", typeof(double)));
            this.radDataFilter1.Descriptors.Add(new DataFilterDescriptorItem("DateItem", typeof(DateTime)));
            this.radDataFilter1.Descriptors.Add(new DataFilterDescriptorItem("BoolItem", typeof(bool)));

            this.radDataFilter1.Expression = "[TextItem] LIKE 'f%' AND [IntegerItem] > '10' AND [DoubleItem] < '12' AND [DateItem] < #01/18/2017 00:00:00# AND [BoolItem] = True";

            ExamplesForm.FillComboFromEnum(this.radDropDownListLineStyle, typeof(TreeLineStyle), TreeLineStyle.Solid);
        }

        private void radCheckBoxAllowAdd_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDataFilter1.AllowAdd = this.radCheckBoxAllowAdd.IsChecked;
        }

        private void radCheckBoxAllowRemove_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDataFilter1.AllowRemove = this.radCheckBoxAllowRemove.IsChecked;
        }

        private void radCheckBoxAllowDragDrop_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDataFilter1.AllowDragDrop = this.radCheckBoxAllowDragDrop.IsChecked;
        }

        private void radCheckBoxSortFieldNames_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDataFilter1.SortFieldNames = this.radCheckBoxSortFieldNames.IsChecked;
        }

        private void radColorBoxLineColor_ValueChanged(object sender, EventArgs e)
        {
            this.radDataFilter1.LineColor = this.radColorBoxLineColor.Value;
        }

        private void radDropDownListLineStyle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDataFilter1.LineStyle = (TreeLineStyle)this.radDropDownListLineStyle.SelectedItem.Value;
        }

        private void radSpinEditorNodeSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radDataFilter1.DataFilterElement.NodeSpacing = (int)this.radSpinEditorNodeSpacing.Value;
        }

        private void radSpinEditorTreeIndent_ValueChanged(object sender, EventArgs e)
        {
            this.radDataFilter1.TreeIndent = (int)this.radSpinEditorTreeIndent.Value;
        }

        private void radCheckBoxShowLines_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDataFilter1.ShowLines = this.radCheckBoxShowLines.IsChecked;
        }

        private void radCheckBoxAllowEdit_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool allowEdit = this.radCheckBoxAllowEdit.IsChecked;
            this.radDataFilter1.AllowEdit = allowEdit;
            if (allowEdit)
            {
                this.radCheckBoxAllowAdd.Enabled = true;
            }
            else
            {
                this.radCheckBoxAllowAdd.IsChecked = false;
                this.radCheckBoxAllowAdd.Enabled = false;
            }
        }

        private void radButtonLoadXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = ".xml";
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radDataFilter1.LoadXML(openFileDialog.FileName);
                this.radSpinEditorTreeIndent.Value = this.radDataFilter1.TreeIndent;
                this.radSpinEditorNodeSpacing.Value = this.radDataFilter1.SpacingBetweenNodes;
                this.radDropDownListLineStyle.SelectedValue = this.radDataFilter1.LineStyle;
                this.radColorBoxLineColor.Value = this.radDataFilter1.LineColor;
                this.radCheckBoxSortFieldNames.IsChecked = this.radDataFilter1.SortFieldNames;
                this.radCheckBoxShowLines.IsChecked = this.radDataFilter1.ShowLines;
                this.radCheckBoxAllowEdit.IsChecked = this.radDataFilter1.AllowEdit;
                this.radCheckBoxAllowDragDrop.IsChecked = this.radDataFilter1.AllowDragDrop;
                this.radCheckBoxAllowRemove.IsChecked = this.radDataFilter1.AllowRemove;
                this.radCheckBoxAllowAdd.IsChecked = this.radDataFilter1.AllowAdd;
            }
        }

        private void radButtonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.FileName = "DataFilterXml";            
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radDataFilter1.SaveXML(saveFileDialog.FileName);
            }
        }
    }
}
