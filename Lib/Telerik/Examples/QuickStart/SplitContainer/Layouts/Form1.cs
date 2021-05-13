using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.SplitContainer.Layouts
{
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
    {
        #region Fields

        private Random random;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.random = new Random();

            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        #region Implementation

        private void BeginLayout()
        {
            ControlHelper.BeginUpdate(this.rootContainer);
            this.rootContainer.SuspendLayout();
            this.DisposeChildPanels();
        }

        private void EndLayout()
        {
            this.rootContainer.ResumeLayout(true);
            ControlHelper.EndUpdate(this.rootContainer, true);
        }

        private void DisposeChildPanels()
        {
            int count = this.rootContainer.SplitPanels.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                rootContainer.SplitPanels[0].Dispose();
            }
        }

        private SplitPanel CreateSplitPanel()
        {
            SplitPanel panel = new SplitPanel();
            Color back = Color.FromArgb(this.random.Next(155, 255), this.random.Next(155, 255), this.random.Next(155, 255));
            FillPrimitive fill = panel.SplitPanelElement.Children[0] as FillPrimitive;
            fill.BackColor = back;
            fill.GradientStyle = GradientStyles.Solid;

            return panel;
        }

        private void CreateLine(int count, Orientation orientation)
        {
            this.BeginLayout();

            this.rootContainer.Orientation = orientation;

            for (int i = 0; i < count; i++)
            {
                this.rootContainer.SplitPanels.Add(this.CreateSplitPanel());
            }

            this.rootContainer.ResumeLayout(true);

            this.EndLayout();
        }

        private void CreateGrid(int cols, int rows, bool centerFill)
        {
            this.CreateGrid(cols, rows, Orientation.Horizontal, centerFill);
        }

        private void CreateGrid(int cols, int rows, Orientation orientation, bool centerFill)
        {
            this.BeginLayout();

            this.rootContainer.Orientation = orientation;

            for (int i = 0; i < rows; i++)
            {
                RadSplitContainer container = new RadSplitContainer();
                container.Orientation = Orientation.Vertical;
                container.SizeInfo.AbsoluteSize = new Size(100, 100);

                for (int j = 0; j < cols; j++)
                {
                    SplitPanel panel = this.CreateSplitPanel();
                    panel.SizeInfo.AbsoluteSize = new Size(100, 100);
                    container.SplitPanels.Add(panel);
                }

                this.rootContainer.SplitPanels.Add(container);
            }

            if (centerFill)
            {
                (this.rootContainer.SplitPanels[rows / 2] as RadSplitContainer).SplitPanels[cols / 2].SizeInfo.SizeMode = SplitPanelSizeMode.Fill;
            }

            this.EndLayout();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.CreateGrid(5, 5, true);
        }

        #endregion

        #region Event Handlers

        private void colX9Button_Click(object sender, EventArgs e)
        {
            this.CreateLine(9, Orientation.Horizontal);
        }

        private void rowX9_Click(object sender, EventArgs e)
        {
            this.CreateLine(9, Orientation.Vertical);
        }

        private void gridX9Button_Click(object sender, EventArgs e)
        {
            this.CreateGrid(3, 3, false);
        }

        private void gridX25Button_Click(object sender, EventArgs e)
        {
            this.CreateGrid(5, 5, false);
        }

        private void grixX25FillButton_Click(object sender, EventArgs e)
        {
            this.CreateGrid(5, 5, true);
        }

        private void absHorizontalButton_Click(object sender, EventArgs e)
        {
            this.BeginLayout();
            this.CreateLine(3, Orientation.Horizontal);

            SplitPanelSizeInfo sizeInfo = this.rootContainer.SplitPanels[0].SizeInfo;
            sizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            sizeInfo.AbsoluteSize = new Size(200, 100);

            sizeInfo = this.rootContainer.SplitPanels[this.rootContainer.SplitPanels.Count - 1].SizeInfo;
            sizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            sizeInfo.AbsoluteSize = new Size(200, 100);

            this.EndLayout();
        }

        private void absVerticalButton_Click(object sender, EventArgs e)
        {
            this.BeginLayout();
            this.CreateLine(3, Orientation.Vertical);

            SplitPanelSizeInfo sizeInfo = this.rootContainer.SplitPanels[0].SizeInfo;
            sizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            sizeInfo.AbsoluteSize = new Size(100, 200);

            sizeInfo = this.rootContainer.SplitPanels[this.rootContainer.SplitPanels.Count - 1].SizeInfo;
            sizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            sizeInfo.AbsoluteSize = new Size(100, 200);

            this.EndLayout();
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            this.CreateLine(3, Orientation.Vertical);

            SplitPanelSizeInfo sizeInfo = this.rootContainer.SplitPanels[1].SizeInfo;
            sizeInfo.MinimumSize = new Size(200, 0);
            sizeInfo.MaximumSize = new Size(300, 0);

            Label label = new Label();
            label.AutoSize = false;
            label.Dock = DockStyle.Top;
            label.Height = 100;
            label.BackColor = Color.Transparent;
            label.Text = "SizeInfo.MinimumSize = [200, 0]\r\n" + "SizeInfo.MaximumSize = [300, 0]";
            this.rootContainer.SplitPanels[1].Padding = new Padding(1);
            this.rootContainer.SplitPanels[1].Controls.Add(label);

        }

        private void AddThreePanels()
        {
            RadSplitContainer rootContainer = new RadSplitContainer();
            for (int i = 0; i < 3; i++)
            {
                rootContainer.SplitPanels.Add(new SplitPanel());
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.absVerticalButton.Click += new EventHandler(this.absVerticalButton_Click);
            this.absHorizontalButton.Click += new EventHandler(this.absHorizontalButton_Click);
            this.rowX9.Click += new EventHandler(this.rowX9_Click);
            this.colX9Button.Click += new EventHandler(this.colX9Button_Click);
            this.grixX25FillButton.Click += new EventHandler(this.grixX25FillButton_Click);
            this.gridX9Button.Click += new EventHandler(this.gridX9Button_Click);
            this.gridX25Button.Click += new EventHandler(this.gridX25Button_Click);
            this.minMaxButton.Click += new EventHandler(this.minMaxButton_Click);
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}
