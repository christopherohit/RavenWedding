using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace ExportWithDpl.TreeView
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
            this.LoadTreeData();
            this.WireEvents();
            this.SetupInitialSettings();

           if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;
            }
            else
            {
                this.ThemeName = "TelerikMetro"; //set default theme
            }

            ApplyThemeRecursively(this.Controls);
        }

        void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null )
                {                    
                    radControl.ThemeName = this.ThemeName;                    
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }

        private void LoadTreeData()
        {
            this.radTreeView1.Nodes.Add(new RadTreeNode("Personal Folders", ExportWithDpl.Properties.Resources.Root));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Deleted Items", ExportWithDpl.Properties.Resources.RecycleBin));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Drafts", ExportWithDpl.Properties.Resources.DraftFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Inbox", ExportWithDpl.Properties.Resources.InboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Junk E-mails", ExportWithDpl.Properties.Resources.JunkFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Outbox", ExportWithDpl.Properties.Resources.OutboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Sent Items", ExportWithDpl.Properties.Resources.SentFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Search Folder", ExportWithDpl.Properties.Resources.SearchFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("New Item", ExportWithDpl.Properties.Resources.SentFolder));

            this.radTreeView1.Nodes[0].Nodes[2].Nodes.Add(new RadTreeNode("Folders", ExportWithDpl.Properties.Resources.Folder1));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("From Follow up", ExportWithDpl.Properties.Resources.SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Large Mail", ExportWithDpl.Properties.Resources.SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Unread Mail", ExportWithDpl.Properties.Resources.SearchFolder));

            this.radTreeView1.TreeViewElement.AutoSizeItems = false;
            this.radTreeView1.ItemHeight = 25;
            this.radTreeView1.ExpandAll();
        }

        private void WireEvents()
        {
            this.exportButton.Click += exportButton_Click;
            this.allowAlternatingRowColorCheckBox.ToggleStateChanged += allowAlternatingRowColorCheckBox_ToggleStateChanged;
        }

        private void SetupInitialSettings()
        {
            this.exportVisualSettingsCheckBox.ToggleState = ToggleState.On;
            this.exportImagesCheckBox.ToggleState = ToggleState.On;
            this.groupChildNodesCheckBox.ToggleState = ToggleState.On;
            this.exportFormatXlsxRadioButton.ToggleState = ToggleState.On;
            this.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On;
        }

        private void allowAlternatingRowColorCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.TreeViewElement.AllowAlternatingRowColor = args.ToggleState == ToggleState.On;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            TreeViewSpreadExport exporter = new TreeViewSpreadExport(this.radTreeView1);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            if (this.exportFormatXlsxRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Xlsx;
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            }
            else if (this.exportFormatPdfRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Pdf;
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            }
            else if (this.exportFormatCsvRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Csv;
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            }
            else if (this.exportFormatTxtRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Txt;
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (this.customizeVisualSettingsCheckBox.ToggleState == ToggleState.On)
                {
                    exporter.CellFormatting += exporter_CellFormatting;
                }

                exporter.ExportVisualSettings = this.exportVisualSettingsCheckBox.ToggleState == ToggleState.On;
                exporter.ExportImages = this.exportImagesCheckBox.ToggleState == ToggleState.On;
                exporter.ExportChildNodesGrouped = this.groupChildNodesCheckBox.ToggleState == ToggleState.On;

                if (this.collapsedOptionExportAlwaysRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedNodeOption = HiddenOption.ExportAlways;
                }
                else if (this.collapsedOptionDoNotExportRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedNodeOption = HiddenOption.DoNotExport;
                }
                else if (this.collapsedOptionExportAsHiddenRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedNodeOption = HiddenOption.ExportAsHidden;
                }

                SpreadExportRenderer renderer = new SpreadExportRenderer();
                exporter.RunExport(dialog.FileName, renderer);
            }
        }

        private void exporter_CellFormatting(object sender, TreeViewSpreadExportCellFormattingEventArgs e)
        {
            if (e.TreeNode.Nodes.Count > 0)
            {
                e.ExportCell.BackColor = Color.LightBlue;
                e.ExportCell.ForeColor = Color.DarkMagenta;
                e.ExportCell.Font = new Font("SegoeUI", 12, FontStyle.Underline);
            }
            else
            {
                e.ExportCell.BackColor = Color.LightYellow;
            }
        }
    }
}
