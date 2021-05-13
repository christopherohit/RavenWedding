using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.GridView.Customize.Basics
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(radGridView1_CellFormatting);

            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);

            this.radGridView1.TableElement.RowHeight = 50;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.EnableAlternatingRowColor = true;

            this.radSpinEditorRowHeight.Value = this.radGridView1.TableElement.RowHeight;
            this.radSpinEditorHeaderHeight.Value = this.radGridView1.TableElement.TableHeaderHeight;
            this.radSpinEditorGroupRowHeight.Value = this.radGridView1.TableElement.GroupHeaderHeight;
            this.radSpinEditorCellSpacing.Value = this.radGridView1.TableElement.CellSpacing;
            this.radSpinEditorRowSpacing.Value = this.radGridView1.TableElement.RowSpacing;
            this.radCheckBoxGroupPanel.ToggleState = this.radGridView1.ShowGroupPanel ?  ToggleState.On : ToggleState.Off;
            this.radCheckBoxColumnHeaders.ToggleState = this.radGridView1.MasterTemplate.ShowColumnHeaders ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxRowHeader.ToggleState = this.radGridView1.MasterTemplate.ShowRowHeaderColumn ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxAutoSize.ToggleState = this.radGridView1.AutoSizeRows ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxAlternate.ToggleState = this.radGridView1.EnableAlternatingRowColor ? ToggleState.On : ToggleState.Off;
            this.radCheckBoxHotTracking.ToggleState = this.radGridView1.EnableHotTracking ? ToggleState.On : ToggleState.Off;            
            
            if (this.radGridView1.MasterTemplate.AutoSizeColumnsMode == GridViewAutoSizeColumnsMode.Fill)
            {
                this.radCheckBoxFit.ToggleState = ToggleState.On;
            }
            else
            {
                this.radCheckBoxFit.ToggleState = ToggleState.Off;
            }
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridImageCellElement)
            {
                e.CellElement.ImageLayout = ImageLayout.Zoom;
            }
        }

        private void radSpinEditorRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.RowHeight = (int)this.radSpinEditorRowHeight.Value;
        }

        private void radSpinEditorHeaderHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.TableHeaderHeight = (int)this.radSpinEditorHeaderHeight.Value;
        }

        private void radSpinEditorGroupRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.GroupHeaderHeight = (int)this.radSpinEditorGroupRowHeight.Value;
        }

        private void radSpinEditorCellSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.CellSpacing = (int)this.radSpinEditorCellSpacing.Value;
        }

        private void radSpinEditorRowSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.RowSpacing = (int)this.radSpinEditorRowSpacing.Value;
        }

        private void radCheckBoxGroupPanel_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.ShowGroupPanel = this.radCheckBoxGroupPanel.ToggleState == ToggleState.On ? true : false;
        }

        private void radCheckBoxColumnHeaders_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ShowColumnHeaders = this.radCheckBoxColumnHeaders.ToggleState == ToggleState.On ? true : false;
        }

        private void radCheckBoxRowHeader_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = this.radCheckBoxRowHeader.ToggleState == ToggleState.On ? true : false;
        }

        private void radCheckBoxAutoSize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.AutoSizeRows = this.radCheckBoxAutoSize.ToggleState == ToggleState.On ? true : false;
        }

        private void radCheckBoxFit_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheckBoxFit.ToggleState == ToggleState.On)
            {
                this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            }
        }

        private void radCheckBoxAlternate_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.EnableAlternatingRowColor = radCheckBoxAlternate.ToggleState == ToggleState.On ? true : false;
        }

        private void radCheckBoxHotTracking_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.EnableHotTracking = this.radCheckBoxHotTracking.ToggleState == ToggleState.On ? true : false;
        }

        protected override void WireEvents()
        {
            this.radCheckBoxHotTracking.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxHotTracking_ToggleStateChanged);
            this.radSpinEditorGroupRowHeight.ValueChanged += new System.EventHandler(this.radSpinEditorGroupRowHeight_ValueChanged);
            this.radCheckBoxGroupPanel.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxGroupPanel_ToggleStateChanged);
            this.radSpinEditorRowSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorRowSpacing_ValueChanged);
            this.radSpinEditorCellSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorCellSpacing_ValueChanged);
            this.radSpinEditorRowHeight.ValueChanged += new System.EventHandler(this.radSpinEditorRowHeight_ValueChanged);
            this.radCheckBoxColumnHeaders.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColumnHeaders_ToggleStateChanged);
            this.radCheckBoxFit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFit_ToggleStateChanged);
            this.radCheckBoxAlternate.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAlternate_ToggleStateChanged);
            this.radSpinEditorHeaderHeight.ValueChanged += new System.EventHandler(this.radSpinEditorHeaderHeight_ValueChanged);
            this.radCheckBoxRowHeader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxRowHeader_ToggleStateChanged);
            this.radCheckBoxAutoSize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAutoSize_ToggleStateChanged);
        }
    }
}
