using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.Printing
{
    public partial class Form1 : ExamplesForm
    {
        private RadPrintDocument radPrintDocument1;

        public Form1()
        {
            InitializeComponent();

            InitializeGanttView();

            this.radPrintDocument1 = new RadPrintDocument();
            this.radPrintDocument1.AssociatedObject = this.radGanttView1;
        }

        public void InitializeGanttView()
        {
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Id"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("ParentId"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Title"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Start"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Finish"));

            this.radGanttView1.GanttViewElement.Columns[0].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[1].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[2].Width = 350;
            this.radGanttView1.GanttViewElement.Columns[3].Width = 120;
            this.radGanttView1.GanttViewElement.Columns[4].Width = 120;

            this.radGanttView1.GanttViewElement.TaskDataMember = "Tasks";
            this.radGanttView1.GanttViewElement.ChildMember = "Id";
            this.radGanttView1.GanttViewElement.ParentMember = "ParentId";
            this.radGanttView1.GanttViewElement.TitleMember = "Title";
            this.radGanttView1.GanttViewElement.StartMember = "Start";
            this.radGanttView1.GanttViewElement.EndMember = "Finish";
            this.radGanttView1.GanttViewElement.ProgressMember = "Progress";
            this.radGanttView1.GanttViewElement.LinkDataMember = "Links";
            this.radGanttView1.GanttViewElement.LinkStartMember = "StartId";
            this.radGanttView1.GanttViewElement.LinkEndMember = "EndId";
            this.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType";

            DataSet telerikWeddingPlanner = new DataSet();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string resourceName = "Telerik.Examples.WinControls.Resources.TelerikWeddingPlanner.xml";

            using (Stream resourceStream = executingAssembly.GetManifestResourceStream(resourceName))
            {
                telerikWeddingPlanner.ReadXml(resourceStream);
            }

            this.radGanttView1.DataSource = telerikWeddingPlanner;

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(2006, 8, 21);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2007, 4, 3);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.radGanttView1.Print(true, this.radPrintDocument1);
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            this.radGanttView1.PrintPreview(this.radPrintDocument1);
        }

        private void buttonPrintSettings_Click(object sender, EventArgs e)
        {
            GanttViewPrintSettingsDialog dialog = (GanttViewPrintSettingsDialog)this.radGanttView1.GetSettingsDialog(this.radPrintDocument1);
            dialog.ThemeName = this.CurrentThemeName;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radGanttView1.PrintPreview(this.radPrintDocument1);
            }
        }

        protected override void WireEvents()
        {
            this.buttonPrint.Click += this.buttonPrint_Click;
            this.buttonPrintPreview.Click += this.buttonPrintPreview_Click;
            this.buttonPrintSettings.Click += this.buttonPrintSettings_Click;
        }
    }
}
