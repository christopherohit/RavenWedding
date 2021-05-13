using System;
using System.Diagnostics;
using System.Drawing;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.Performance
{
    /// <summary>
    /// Form code
    /// </summary>
	public partial class Form1 : TreeExamplesControl
	{
        Bitmap bottomRightBitmap = Resources.TV_folders; 

		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radTreeViewDemo;
            //this.radTreeViewDemo.NodeFormatting += new TreeNodeFormattingEventHandler(radTreeViewDemo_NodeFormatting);
            this.radTreeViewDemo.TreeViewElement.Text = "Click the Load buton to load nodes";
            this.radTreeViewDemo.TreeViewElement.TextWrap = true;
            this.radTreeViewDemo.TreeViewElement.TextAlignment = ContentAlignment.MiddleCenter;
		}

        protected override void WireEvents()
        {
            this.radBtnLoad.Click += new System.EventHandler(this.radButton1_Click);
        }

        public override RadTreeView TreeControl
        {
            get { return this.radTreeViewDemo; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Performance"; }
        }

        void LoadNodes()
        {
            int index = 0;

            Stopwatch watch = Stopwatch.StartNew();
           
            using (this.radTreeViewDemo.DeferRefresh())
            {
                this.radTreeViewDemo.Nodes.Clear();
                for (int i = 0; i < 3125; i++)
                {
                    index++;
                    RadTreeNode node = new RadTreeNode("Node" + index);

                    for (int j = 0; j < 5; j++)
                    {
                        index++;
                        RadTreeNode child = new RadTreeNode("Node" + index);
                        node.Nodes.Add(child);
                        for (int p = 0; p < 2; p++)
                        {
                            index++;
                            RadTreeNode childChild = new RadTreeNode("Node" + index);
                            child.Nodes.Add(childChild);
                        }

                    }

                    this.radTreeViewDemo.Nodes.Add(node);
                }
            }

            watch.Stop();
            this.radProgressBar1.Value1 = 50000;            
            radLabel1.Text = "Time elapsed: " + (watch.ElapsedMilliseconds / 1000.0).ToString("0.00")  + " sec"; 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radTreeViewDemo.AllowAdd = true;
            this.radTreeViewDemo.AllowRemove = true;
        }

        private void radTreeViewDemo_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            e.NodeElement.ImageElement.Image = Resources.TV_Folder;
        }
        
        private void radButton1_Click(object sender, EventArgs e)
		{
            this.radTreeViewDemo.TreeViewElement.Text = "";
            LoadNodes();
        }
	}
}
