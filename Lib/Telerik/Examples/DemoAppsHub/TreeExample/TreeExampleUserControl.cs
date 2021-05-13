using System;
using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls.Data;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Telerik.WinControls;
using DemoAppsHub.Properties;

namespace DemoAppsHub.TreeExample
{
    /// <summary>
    /// Example beautifying
    /// </summary>
    public partial class TreeExampleUserControl : UserControl
    {
        Bitmap level1;
        Bitmap level2;
        Bitmap level3;

        public TreeExampleUserControl()
        {
            InitializeComponent();

            level1 = Resources.level1;
            level2 = Resources.level2;
            level3 = Resources.level3;

            ThemeResolutionService.ApplyThemeToControlTree(this, "TelerikMetroBlue");

            RadMenuItem item = new RadMenuItem("None");
            item.Click += new EventHandler(item_Click);
            this.radDropDownButton1.Items.Add(item);

            item = new RadMenuItem("Alphabetically");
            item.Click += new EventHandler(item_Click);
            this.radDropDownButton1.Items.Add(item);

            ImagePrimitive searchIcon = new ImagePrimitive();
            searchIcon.Image = DemoAppsHub.Properties.Resources.TV_search;
            searchIcon.Alignment = ContentAlignment.MiddleRight;
            this.radTextBox1.TextBoxElement.Children.Add(searchIcon);
            this.radTextBox1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft;
            this.radTextBox1.TextBoxElement.TextBoxItem.PropertyChanged += new PropertyChangedEventHandler(TextBoxItem_PropertyChanged);
            this.radTreeView1.TreeViewElement.AllowAlternatingRowColor = true;
            this.radTreeView1.AllowEdit = false;
            this.radTreeView1.AllowAdd = false;
            this.radTreeView1.AllowRemove = false;
            this.radTreeView1.ItemHeight = 34;
            this.radTreeView1.AllowDefaultContextMenu = false;
            
            this.AutoScroll = false;

            this.radPanel3.PanelElement.PanelFill.BackColor = Color.White;
            this.radPanel3.BackColor = Color.White;
            this.radPanel3.PanelElement.PanelFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.radPanel3.PanelElement.PanelBorder.TopColor = Color.FromArgb(196, 199, 182);
            this.radPanel3.PanelElement.PanelBorder.LeftColor = Color.FromArgb(196, 199, 182);
            this.radPanel3.PanelElement.PanelBorder.RightColor = Color.FromArgb(196, 199, 182);
            this.radPanel3.PanelElement.PanelBorder.BottomColor = Color.White;
            this.radPanel3.PanelElement.PanelBorder.BoxStyle = BorderBoxStyle.FourBorders;
            this.radPanel3.PanelElement.PanelBorder.BorderDrawMode = BorderDrawModes.VerticalOverHorizontal;
            this.radPanel3.PanelElement.PanelBorder.GradientStyle = GradientStyles.Solid;

            this.radPanel1.PanelElement.PanelFill.BackColor = Color.FromArgb(26, 93, 192);
            this.radPanel1.PanelElement.PanelFill.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radPanel1.PanelElement.Font = new Font("Segoe UI Light", 20, FontStyle.Regular);
            this.radPanel1.ForeColor = Color.White;
            this.radPanel1.PanelElement.Padding = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.radPanel1.Text = "Music Collection";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.artistsTableAdapter.Fill(musicCollectionDataSet.Artists);
            this.albumsTableAdapter.Fill(musicCollectionDataSet.Albums);
            this.songsTableAdapter.Fill(musicCollectionDataSet.Songs);

            using (this.radTreeView1.DeferRefresh())
            {
                this.radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID");
                this.radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID");
                this.radTreeView1.DisplayMember = "ArtistName";
                this.radTreeView1.DataSource = artistsBindingSource;
            }

            foreach (RadTreeNode node in this.radTreeView1.Nodes)
            {
                node.Expand();
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            RadMenuItem item = (RadMenuItem)sender;
            this.radDropDownButton1.Text = item.Text;
            if (item.Text == "None")
            {
                radTreeView1.SortOrder = SortOrder.None;   
            }
            else
            {
                radTreeView1.SortOrder = SortOrder.Ascending;  
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.radTreeView1.Filter = this.radTextBox1.Text;
        }

        private void radTreeView1_NodeExpandedChanging(object sender, Telerik.WinControls.UI.RadTreeViewCancelEventArgs e)
        {
           RadTreeNodeCollection nodes = e.Node.Nodes;
           if (e.Node.Level == 0)
           {
               e.Node.Image = level1;
           }
            foreach (RadTreeNode node in nodes)
            {
                if (node.Level == 0)
                {
                    node.Image = level1;
                }
                else if (node.Level == 1)
                {
                    node.Image = level2;
                }
                else
                {
                    node.Image = level3;
                }
            }
        }

        private void TextBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                radTextBox1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = new Size(radTextBox1.Size.Width - 28, 0);
            }
        }
    }
}
