using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.Data;

namespace Telerik.Examples.WinControls.GridView.Grouping.CustomGrouping
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radGridView.EnableGrouping = true;
            this.radGridView.EnableCustomGrouping = true;
            this.radGridView.ShowGroupedColumns = true;
        }

        private void SetConditions()
        {
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Grey, applied to cell", ConditionTypes.NotEqual, "Germany", "", false);
            c3.RowBackColor = Color.FromArgb(169, 183, 201);
            c3.CellBackColor = Color.FromArgb(169, 183, 201);
            this.radGridView.Columns["Country"].ConditionalFormattingObjectList.Add(c3);

            ConditionalFormattingObject c1 = new ConditionalFormattingObject("Blue , applied to cell", ConditionTypes.Equal, "Germany", "", false);
            c1.RowBackColor = Color.FromArgb(163, 191, 226);
            c1.CellBackColor = Color.FromArgb(163, 191, 226);
            this.radGridView.Columns["Country"].ConditionalFormattingObjectList.Add(c1);

            ConditionalFormattingObject c2 = new ConditionalFormattingObject("LightPurple, applied to cell", ConditionTypes.Equal, "France", "", false);
            c2.RowBackColor = Color.FromArgb(212, 210, 241);
            c2.CellBackColor = Color.FromArgb(212, 210, 241);
            this.radGridView.Columns["Country"].ConditionalFormattingObjectList.Add(c2);
        }

        private void radGridView1_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        {
            if (this.UseDefaultGrouping(e.Level))
            {
                e.Handled = false;
                return;
            }

            int color = Color.White.ToArgb();
            int columnIndex = this.radGridView.Columns["Country"].Index;
            ConditionalFormattingObjectCollection conditions = this.radGridView.Columns[columnIndex].ConditionalFormattingObjectList;

            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i].Evaluate(e.Row, this.radGridView.Columns["Country"]))
                {
                    color = conditions[i].CellBackColor.ToArgb();
                }
            }

            e.GroupKey = color;
        }

        private bool UseDefaultGrouping(int level)
        {
            GroupDescriptor groupDescriptor = this.radGridView.GroupDescriptors[level];
            for (int i = 0; i < groupDescriptor.GroupNames.Count; i++)
            {
                if (groupDescriptor.GroupNames[i].PropertyName.Equals("Country", StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }

        void radGridView_ViewRowFormatting(object sender, RowFormattingEventArgs e)
        {
            GridViewGroupRowInfo groupRow = e.RowElement.RowInfo as GridViewGroupRowInfo;
            if (groupRow != null && groupRow.Group.Key is int)
            {
                e.RowElement.BackColor = Color.FromArgb((int)groupRow.Group.Key);
            }
        }

        void radGridView_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (this.UseDefaultGrouping(e.Group.Level))
            {
                return;
            }

            e.FormatString = this.GetColorName(e.Group.Key.ToString());
        }

        private string GetColorName(string p)
        {
            switch (p)
            {
                case "-6045726":
                    return "Blue";
                case "-5654583":
                    return "Grey";
                case "-2829583":
                    return "LightPurple";
                default:
                    return "White";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.SetConditions();
            this.radGridView.GroupDescriptors.Expression = "Country";

            this.SelectedControl = this.radGridView;
        }

        protected override void WireEvents()
        {
            this.radGridView.GroupSummaryEvaluate += new GroupSummaryEvaluateEventHandler(radGridView_GroupSummaryEvaluate);
            this.radGridView.ViewRowFormatting += new RowFormattingEventHandler(radGridView_ViewRowFormatting);
            this.radGridView.CustomGrouping += new Telerik.WinControls.UI.GridViewCustomGroupingEventHandler(this.radGridView1_CustomGrouping);
        }
    }
}
