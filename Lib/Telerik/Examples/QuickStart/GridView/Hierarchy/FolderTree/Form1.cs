using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Drawing.Drawing2D;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.FolderTree
{
    public partial class Form1 : ExamplesForm
    {
        private bool showCellBorders = true;
        private DashStyle lineStyle = DashStyle.Dot;
        private Color lineColor = Color.FromArgb(123, 123, 123);

        public Form1()
        {
            InitializeComponent();
        }

        private static DataTable CreateDataSource()
        {
            DataTable dataSource = new DataTable("fileSystem");
            dataSource.Columns.Add("ID", typeof(int));
            dataSource.Columns.Add("ParentID", typeof(int));
            dataSource.Columns.Add("Name", typeof(string));
            dataSource.Columns.Add("Date", typeof(DateTime));
            dataSource.Columns.Add("Type", typeof(string));
            dataSource.Columns.Add("Size", typeof(int));

            dataSource.Rows.Add(1, null, "Program Files", DateTime.Now.AddDays(-100), "Folder", 5120);
            dataSource.Rows.Add(2, 1, "Visual Studio 2010", DateTime.Now.AddDays(-100), "Folder", 3220);
            dataSource.Rows.Add(3, 2, "bin", DateTime.Now.AddDays(-100), "Folder", 3220);
            dataSource.Rows.Add(4, 2, "READEME.txt", DateTime.Now.AddDays(-100), "Text Document", 3);

            dataSource.Rows.Add(5, 1, "Telerik RadControls", DateTime.Now.AddDays(-10), "Folder", 3120);
            dataSource.Rows.Add(6, 5, "Telerik UI for Winforms", DateTime.Now.AddDays(-10), "Folder", 101);
            dataSource.Rows.Add(7, 5, "Telerik UI for Silverlight", DateTime.Now.AddDays(-10), "Folder", 123);
            dataSource.Rows.Add(8, 5, "Telerik UI for WPF", DateTime.Now.AddDays(-10), "Folder", 221);
            dataSource.Rows.Add(9, 5, "Telerik UI for ASP.NET AJAX", DateTime.Now.AddDays(-10), "Folder", 121);

            dataSource.Rows.Add(10, 1, "Microsoft Office 2010", DateTime.Now.AddDays(-120), "Folder", 1230);
            dataSource.Rows.Add(11, 10, "Microsoft Word 2010", DateTime.Now.AddDays(-120), "Folder", 1230);
            dataSource.Rows.Add(12, 10, "Microsoft Excel 2010", DateTime.Now.AddDays(-120), "Folder", 1230);
            dataSource.Rows.Add(13, 10, "Microsoft Powerpoint 2010", DateTime.Now.AddDays(-120), "Folder", 1230);

            dataSource.Rows.Add(14, 1, "Debug Diagnostic Tools v1.0", DateTime.Now.AddDays(-400), "Folder", 2120);
            dataSource.Rows.Add(15, 1, "Designer's 3D Tools", DateTime.Now.AddDays(-500), "Folder", 1120);
            dataSource.Rows.Add(16, 1, "Communication", DateTime.Now.AddDays(-700), "Folder", 120);

            dataSource.Rows.Add(17, null, "My Documents", DateTime.Now.AddDays(-200), "Folder", 1024);
            dataSource.Rows.Add(18, 17, "Salaries.xlsx", DateTime.Now.AddDays(-200), "Excel File", 1);
            dataSource.Rows.Add(19, 17, "RecessionAnalysis.xlsx", DateTime.Now.AddDays(-200), "Excel File", 1);

            dataSource.Rows.Add(20, null, "Windows", DateTime.Now.AddDays(-100), "Folder", 10240);

            dataSource.Rows.Add(21, 20, "System32", DateTime.Now.AddDays(-220), "Folder", 510);
            dataSource.Rows.Add(22, 20, "assembly", DateTime.Now.AddDays(-20), "Folder", 240);

            dataSource.Rows.Add(23, 22, "System.Data.dll", DateTime.Now.AddDays(-20), "Assembly File", 4);
            dataSource.Rows.Add(24, 22, "System.Core.dll", DateTime.Now.AddDays(-20), "Assembly File", 2);
            dataSource.Rows.Add(25, 22, "System.Drawings.dll", DateTime.Now.AddDays(-20), "Assembly File", 3);
            dataSource.Rows.Add(26, 22, "Telerik.WinControls.UI.dll", DateTime.Now.AddDays(-20), "Assembly File", 5);

            dataSource.Rows.Add(27, null, "Users", DateTime.Now.AddDays(-100), "Folder", 5512);
            dataSource.Rows.Add(28, 27, "Administrator", DateTime.Now.AddDays(-100), "Folder", 1512);
            dataSource.Rows.Add(29, 27, "Guest", DateTime.Now.AddDays(-100), "Folder", 2512);
            dataSource.Rows.Add(30, 27, "User1", DateTime.Now.AddDays(-100), "Folder", 3512);

            dataSource.Rows.Add(31, null, "Share", DateTime.Now.AddDays(-50), "Folder", 15360);
            dataSource.Rows.Add(32, 31, "Photos", DateTime.Now.AddDays(-50), "Folder", 360);
            dataSource.Rows.Add(33, 32, "Flowers.JPG", DateTime.Now.AddDays(-50), "JPEG File", 1);
            dataSource.Rows.Add(34, 32, "Panda.GIF", DateTime.Now.AddDays(-50), "GIF File", 3);
            dataSource.Rows.Add(35, 32, "Landscape.png", DateTime.Now.AddDays(-50), "PNG File", 4);

            dataSource.Rows.Add(36, null, "Music", DateTime.Now.AddDays(-2), "Folder", 0);
            dataSource.Rows.Add(37, 36, "Mozart", DateTime.Now.AddDays(-3), "Folder", 0);
            dataSource.Rows.Add(38, 36, "Pavarotti", DateTime.Now.AddDays(-40), "Folder", 0);
            dataSource.Rows.Add(39, 36, "AC/DC", DateTime.Now.AddDays(-50), "Folder", 0);
            dataSource.Rows.Add(40, 36, "Queen", DateTime.Now.AddDays(-8), "Folder", 0);

            dataSource.Rows.Add(41, null, "Boot.ini", DateTime.Now.AddDays(-10), "INI File", 0);

            return dataSource;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.TableElement.RowHeight = 40;

            this.radGridView1.ReadOnly = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.DataSource = CreateDataSource();
            this.radGridView1.Relations.AddSelfReference(this.radGridView1.MasterTemplate, "ID", "ParentID");

            this.radGridView1.Columns["ID"].IsVisible = false;
            this.radGridView1.Columns["ParentID"].IsVisible = false;
            this.radGridView1.Columns["Size"].FormatString = "{0} MB";

            this.radDropDownList1.SelectedIndex = 2;
            this.radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;

            this.radColorBoxBackColor.Value = lineColor;
        }

        private void radGridView1_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Row is GridViewDataRowInfo)
            {
                if (showCellBorders)
                {
                    e.CellElement.ResetValue(GridDataCellElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local);
                }
                else
                {
                    e.CellElement.DrawBorder = false;
                }

                GridDataCellElement cell = e.CellElement as GridDataCellElement;
                if (cell != null && cell.SelfReferenceLayout != null)
                {
                    foreach (RadElement element in cell.SelfReferenceLayout.StackLayoutElement.Children)
                    {
                        GridLinkItem linkItem = element as GridLinkItem;
                        if (linkItem != null)
                        {
                            linkItem.LineStyle = lineStyle;
                            linkItem.ForeColor = lineColor;
                        }
                        GridExpanderItem expanderItem = element as GridExpanderItem;
                        if (expanderItem != null)
                        {
                            expanderItem.LinkLineStyle = lineStyle;
                            expanderItem.LinkLineColor = lineColor;
                        }
                    }
                }
            }
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridDataCellElement dataCell = e.CellElement as GridDataCellElement;

            if (dataCell.ColumnInfo.Name == "Name")
            {
                GridViewDataRowInfo dataRow = dataCell.RowInfo as GridViewDataRowInfo;
                dataCell.ImageAlignment = ContentAlignment.MiddleLeft;

                string valueType = Convert.ToString(dataRow.Cells["Type"].Value).ToUpperInvariant();

                if (valueType.Contains("FILE") || valueType.Contains("DOCUMENT"))
                {
                    dataCell.Image = this.imageList1.Images[2];
                }
                else if (dataRow.IsExpanded)
                {
                    dataCell.Image = this.imageList1.Images[1];
                }
                else
                {
                    dataCell.Image = this.imageList1.Images[0];
                }

                dataCell.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                dataCell.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.ImageAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.TextImageRelationProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.ImageLayoutProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void radCheckBoxShowCellBorders_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            showCellBorders = radCheckBoxShowCellBorders.IsChecked;
            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            lineStyle = (DashStyle)this.radDropDownList1.SelectedIndex;
            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radCheckBoxShowLines_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.TableElement.ShowSelfReferenceLines = this.radCheckBoxShowLines.IsChecked;
        }

        private void radColorBoxBackColor_ValueChanged(object sender, EventArgs e)
        {
            if (ImageHelper.AreColorsSame(this.radColorBoxBackColor.Value, this.lineColor))
            {
                return;
            }

            this.lineColor = this.radColorBoxBackColor.Value;
            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radButtonExpand_Click(object sender, System.EventArgs e)
        {
            this.radGridView1.MasterTemplate.ExpandAll();
        }

        private void radButtonCollapse_Click(object sender, System.EventArgs e)
        {
            this.radGridView1.MasterTemplate.CollapseAll();
        }

        protected override void WireEvents()
        {
            this.radButtonExpand.Click += new System.EventHandler(radButtonExpand_Click);
            this.radButtonCollapse.Click += new System.EventHandler(radButtonCollapse_Click);
            this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_ViewCellFormatting);
            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radCheckBoxShowCellBorders.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowCellBorders_ToggleStateChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            this.radCheckBoxShowLines.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowLines_ToggleStateChanged);
            this.radColorBoxBackColor.ValueChanged += new System.EventHandler(this.radColorBoxBackColor_ValueChanged);
        }
    }
}
