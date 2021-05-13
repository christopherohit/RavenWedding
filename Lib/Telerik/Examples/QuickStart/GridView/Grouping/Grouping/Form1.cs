using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Xml.Serialization;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Threading;
using Telerik.WinControls.Data;

namespace Telerik.Examples.WinControls.GridView.Grouping.Grouping
{

    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            this.SelectedControl = this.radGridView1;
            this.radGridView1.Size = new Size(this.radGridView1.Width, 690);

            this.radGridView1.TableElement.BeginUpdate();

            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            radGridView1.MasterTemplate.AutoExpandGroups = true;
            radGridView1.MasterTemplate.EnableFiltering = true;
            radGridView1.ShowGroupPanel = true;
            radGridView1.EnableHotTracking = true;


            this.radGridView1.TableElement.EndUpdate(false);

            radGridView1.TableElement.CellSpacing = -1;
            radGridView1.TableElement.TableHeaderHeight = 35;
            radGridView1.TableElement.GroupHeaderHeight = 30;
            radGridView1.TableElement.RowHeight = 25;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.BindGrid();
            this.InitializeGrouping();
            this.InitializePreferences();
        }

        private void InitializeGrouping()
        {
            this.radRadioCityCountry.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.GroupByCountryCity();
        }

        private void InitializePreferences()
        {
            this.radCheckBoxShowGroupPanel.Checked = this.radGridView1.ShowGroupPanel;
            this.radRadioAnimSlide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Slide;
        }

        private void GroupByCountryCity()
        {
            this.ClearGrouping();

            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("Country as Country format \"{0}: {1}\" Group By Country"));
            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("City as City format \"{0}: {1}\" Group By City"));

        }


        private void GroupByCountry()
        {
            this.ClearGrouping();
            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("Country as Country format \"{0}: {1}\" Group By Country"));

        }

        private void ClearGrouping()
        {
            this.radGridView1.GroupDescriptors.Clear();
        }

        private void GroupByCity()
        {
            this.ClearGrouping();
            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("City as City format \"{0}: {1}\" Group By City"));
        }

        #region Expand/Collapse methods

        private void Collapse(GridViewGroupRowInfo row)
        {
            foreach (GridViewRowInfo childRow in row.ChildRows)
            {
                GridViewGroupRowInfo groupRow = childRow as GridViewGroupRowInfo;

                if (groupRow != null)
                {
                    groupRow.IsExpanded = false;
                    Collapse(groupRow);
                }
            }
        }

        #endregion

        #region Event handlers

        private void OnBtnExpand_Click(object sender, EventArgs e)
        {
            this.radGridView1.MasterTemplate.ExpandAllGroups();
        }

        private void OnBtnCollapse_Click(object sender, EventArgs e)
        {
            this.radGridView1.MasterTemplate.CollapseAllGroups();
        }

        private void OnCheckBoxShowGroupPanel_StateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.ShowGroupPanel = this.radCheckBoxShowGroupPanel.Checked;
        }

        private void OnRadioAnimation_StateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioAnimWipe.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.GradientWipe;
            }
            else if (this.radRadioAnimSlide.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Slide;
            }
            else if (this.radRadioAnimAccordion.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Accordion;
            }
            else if (this.radRadioAnimFade.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.Fade;
            }
            else
            {
                this.radGridView1.GroupExpandAnimationType = GridExpandAnimationType.None;
            }

        }

        #endregion

        private void OnRadioGroupType_StateChanged(object sender, StateChangedEventArgs args)
        {
            if (!this.radGridView1.MasterTemplate.AllowDragToGroup
                && this.radRadioDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                this.radGridView1.MasterTemplate.AllowDragToGroup = true;
                this.radGridView1.EnableGrouping = true;
            }

            if (this.radRadioCity.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.GroupByCity();
            }
            else if (this.radRadioCityCountry.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.GroupByCountryCity();
            }
            else if (this.radRadioCountry.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.GroupByCountry();
            }
            else if (this.radRadioNone.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.ClearGrouping();
            }
            else
            {
                this.ClearGrouping();
                this.radGridView1.MasterTemplate.AllowDragToGroup = false;
                this.radGridView1.MasterTemplate.EnableGrouping = false;
            }
        }

        protected override void WireEvents()
        {
            this.radRadioAnimNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioAnimation_StateChanged);
            this.radRadioAnimSlide.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioAnimation_StateChanged);
            this.radRadioAnimFade.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioAnimation_StateChanged);
            this.radRadioAnimWipe.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioAnimation_StateChanged);
            this.radRadioAnimAccordion.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioAnimation_StateChanged);
            this.radBtnCollapseAll.Click += new System.EventHandler(this.OnBtnCollapse_Click);
            this.radBtnExpandAll.Click += new System.EventHandler(this.OnBtnExpand_Click);
            this.radCheckBoxShowGroupPanel.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckBoxShowGroupPanel_StateChanged);
            this.radRadioCityCountry.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioGroupType_StateChanged);
            this.radRadioDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioGroupType_StateChanged);
            this.radRadioNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioGroupType_StateChanged);
            this.radRadioCity.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioGroupType_StateChanged);
            this.radRadioCountry.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioGroupType_StateChanged);
        }
    }
}
