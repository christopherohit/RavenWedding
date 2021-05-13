using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Customize.NodeFormatting
{
    public partial class Form1 : TreeExamplesControl
    {
        Font boldFont;
        Bitmap bottomRightBitmap = Resources.TV_email;

        public Form1()
        {
            InitializeComponent();

            this.radTreeView1.TreeViewElement.NodeFormatting += new TreeNodeFormattingEventHandler(TreeViewElement_NodeFormatting);
        }

        protected override void WireEvents()
        {
            this.radCheckBoxFormatting.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFormatting_ToggleStateChanged);
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override RadTreeView TreeControl
        {
            get { return this.radTreeView1; }
        }

        public override string HeaderText
        {
            get { return "Mail"; }
        }

        private void LoadData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ParentID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Icon", typeof(Image));
            table.Columns.Add("IsNew", typeof(bool));
            table.Columns.Add("NewItemCount", typeof(int));
            table.Columns.Add("IsImportant", typeof(bool));
            table.Columns.Add("HasFlag", typeof(bool));

            table.Rows.Add(0, null, "Personal Folders", null, Resources.TV_RootFolder);
            table.Rows.Add(1, 0, "Deleted Items", null, Resources.TV_RecycleBin, false, 1);
            table.Rows.Add(2, 0, "Drafts", null, Resources.TV_DraftFolder);
            table.Rows.Add(3, 0, "Inbox", null, Resources.TV_DraftFolder, false, 3);
            table.Rows.Add(4, 0, "Junk E-mails", null, Resources.TV_DraftFolder);
            table.Rows.Add(5, 0, "Outbox", null, Resources.TV_DraftFolder);
            table.Rows.Add(6, 0, "Send Items", null, Resources.TV_DraftFolder);
            table.Rows.Add(7, 0, "Search Folder", null, Resources.TV_DraftFolder);

            table.Rows.Add(8, 1, "Adam Smith", "You`ve got to see this!", Resources.TV_MailNew, true);
            table.Rows.Add(9, 3, "Lewis Clark", "This is extremely urgent", Resources.TV_MailNew, true, null, true);
            table.Rows.Add(10, 3, "Tomas Brown", "Need your help with this article", Resources.TV_MailOpened, false, null, false, true);
            table.Rows.Add(11, 3, "Jeff Patel", "Please, check this our and report by Tomorow!", Resources.TV_MailNew, true);
            table.Rows.Add(12, 3, "Smith Jones", "Seend this yet?", Resources.TV_MailNew, true);
            table.Rows.Add(13, 3, "Denis Cooper", "Great new tool", Resources.TV_MailOpened, false);
            table.Rows.Add(14, 3, "Jackie Turner", "Team Building Session - All Hands", Resources.TV_MailOpened, false, null, true);

            this.radTreeView1.DataSource = table;
            this.radTreeView1.DisplayMember = "Name";
            this.radTreeView1.ChildMember = "ID";
            this.radTreeView1.ParentMember = "ParentID";
            this.radTreeView1.ExpandAll();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
            this.radTreeView1.AllowEdit = false;
            this.radTreeView1.Size = new Size(460, 500);
        }

        private void TreeViewElement_NodeFormatting(object sender, Telerik.WinControls.UI.TreeNodeFormattingEventArgs args)
        {
            if (!radCheckBoxFormatting.IsChecked)
            {
                args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local);
                args.NodeElement.ContentElement.DisableHTMLRendering = true;
                ((LightVisualElement)args.NodeElement.Children[0]).Image = null;
                return;
            }

            DataRowView rowView = (DataRowView)args.Node.DataBoundItem;
            args.NodeElement.ImageElement.Image = (Image)rowView["Icon"];

            args.NodeElement.ClipDrawing = false;

            RadElement element = args.NodeElement.Children[0];

            LightVisualElement imageElement = null;
            if (element.Name != "StateImage")
            {
                imageElement = new LightVisualElement();
                imageElement.Name = "StateImage";
                imageElement.StretchHorizontally = false;
                imageElement.ImageLayout = ImageLayout.Center;
                imageElement.MinSize = new System.Drawing.Size(20, 20);
                imageElement.DrawBorder = true;
                imageElement.DrawFill = true;
                imageElement.GradientStyle = GradientStyles.Linear;
                imageElement.GradientAngle = 0;
                imageElement.NumberOfColors = 2;
                imageElement.BorderBoxStyle = BorderBoxStyle.FourBorders;

                imageElement.BorderRightWidth = 1;
                imageElement.FitToSizeMode = RadFitToSizeMode.FitToParentBounds;
                args.NodeElement.Children.Insert(0, imageElement);

                imageElement.BackColor = Color.FromArgb(255, 255, 255);
                imageElement.BackColor2 = Color.FromArgb(226, 226, 226);
                imageElement.BorderRightColor = Color.FromArgb(180, 184, 191);
                imageElement.BorderRightShadowColor = Color.FromArgb(241, 241, 241);
                imageElement.BorderLeftWidth = 0;
                imageElement.BorderTopWidth = 0;
                imageElement.BorderBottomWidth = 0;
            }
            else
            {
                imageElement = (LightVisualElement)args.NodeElement.Children[0];
            }


            if (rowView["Title"] != DBNull.Value)
            {
                args.NodeElement.ContentElement.Text = (string)rowView["Name"] + " - " + (string)rowView["Title"];
                if ((bool)rowView["IsNew"])
                {
                    if (boldFont == null)
                    {
                        boldFont = new Font(this.Font, FontStyle.Bold);
                    }
                    args.NodeElement.ContentElement.Font = boldFont;
                }
                else
                {
                    args.NodeElement.ContentElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local);
                }

                if (rowView["IsImportant"] != DBNull.Value)
                {
                    if ((bool)rowView["IsImportant"])
                    {
                        ((LightVisualElement)args.NodeElement.Children[0]).Image = Resources.TV_Exclamation;
                    }
                    else
                    {
                        ((LightVisualElement)args.NodeElement.Children[0]).Image = null;
                    }
                }

                if (rowView["HasFlag"] != DBNull.Value)
                {
                    if ((bool)rowView["HasFlag"])
                    {
                        ((LightVisualElement)args.NodeElement.Children[0]).Image = Resources.TV_RedFlag;
                    }
                    else
                    {
                        ((LightVisualElement)args.NodeElement.Children[0]).Image = null;
                    }
                }
            }
            else if (rowView["NewItemCount"] != DBNull.Value)
            {
                int newItemCount = (int)rowView["NewItemCount"];
                args.NodeElement.ContentElement.DisableHTMLRendering = false;
                string color = "blue";
                Color backColor = args.NodeElement.BackColor;
                if (!args.NodeElement.DrawFill || backColor == Color.Transparent)
                {
                    RadElement parent = args.NodeElement.Parent;
                    while (parent != null)
                    {
                        LightVisualElement lve = parent as LightVisualElement;
                        if (lve != null && lve.DrawFill && lve.BackColor != Color.Transparent)
                        {
                            backColor = lve.BackColor;
                            break;
                        }

                        parent = parent.Parent;
                    }
                }

                if (ImageHelper.IsDarkColor(backColor))
                {
                    color = "cyan";
                }

                args.NodeElement.ContentElement.Text = string.Format("<html> {0}<color={2}>({1})", args.Node.Text, newItemCount, color);
            }
        }

        private void radCheckBoxFormatting_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radTreeView1.TreeViewElement.Update(RadTreeViewElement.UpdateActions.StateChanged);
        }
    }
}
