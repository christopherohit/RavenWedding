using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using DemoAppsHub.Properties;
using System.IO;
using System.Diagnostics;

namespace DemoAppsHub
{
    public partial class Form1 : RadForm
    {
        public const int WM_SIZE = 5;

        private LightVisualElement examplePage;
        private RadButtonElement backButton;
        private LightVisualElement headerLabel;
        private RadTitleBarElement titleBar;

        private bool isFormMoving = false;
        private string currentExample = string.Empty;
        private Dictionary<string, UserControl> exampleControls;

        #region Initialization

        public Form1()
        {
            InitializeComponent();

            new TelerikMetroBlueTheme();
            ThemeResolutionService.LoadPackageResource("DemoAppsHub.PanoramaDemo.tssp");
            this.ThemeName = "PanoramaDemo";

            this.radPanorama1.ThemeName = "PanoramaDemo";
            this.radPanorama1.ScrollingBackground = true;
            this.radPanorama1.PanelImage = Resources.bg_pattern;
            this.radPanorama1.PanoramaElement.BackgroundImagePrimitive.ImageLayout = ImageLayout.Tile;
            this.radPanorama1.SizeChanged += new EventHandler(radTilePanel1_SizeChanged);
            this.radPanorama1.ScrollBarAlignment = HorizontalScrollAlignment.Bottom;
            this.radPanorama1.ScrollBarThickness = 5;
            this.radPanorama1.PanoramaElement.GradientStyle = GradientStyles.Solid;
            this.radPanorama1.PanoramaElement.DrawFill = true;
            this.radPanorama1.PanoramaElement.BackColor = System.Drawing.Color.FromArgb(1, 23, 117);
            this.FormElement.TitleBar.MaxSize = new Size(0, 1);
            this.Text = "Demo Apps Hub";

            this.LoadPhotoAlbumTileContent();
            this.PrepareHeader();
            this.PrepareTitleBar();
            this.PrepareExamples();
            this.SetupLinks();
        }

        private void SetupLinks()
        {
            this.linkTile1.Tag = "http://www.telerik.com/demos/";

            this.linkTile1.Click += new EventHandler(linkTile_Click);
        }

        private void PrepareExamples()
        {
            examplePage = new LightVisualElement();
            examplePage.DrawText = false;
            examplePage.DrawFill = true;
            examplePage.BackColor = Color.White;
            examplePage.GradientStyle = GradientStyles.Solid;
            examplePage.Visibility = ElementVisibility.Collapsed;
            this.radPanorama1.PanoramaElement.Children.Add(examplePage);
            examplePage.Margin = new Padding(0, 140, 0, 0);

            this.exampleControls = new Dictionary<string, UserControl>();
            this.exampleControls.Add("GridView", new DemoAppsHub.GridExample.GridExampleUserControl());
            this.exampleControls.Add("TreeView", new DemoAppsHub.TreeExample.TreeExampleUserControl());
            this.exampleControls.Add("ListView", new DemoAppsHub.ListViewExample.ListViewExampleUserControl());
            this.exampleControls.Add("Scheduler", new DemoAppsHub.SchedulerExample.SchedulerExampleUserControl());
            this.exampleControls.Add("Magnifier", new DemoAppsHub.MagnifierExample.MagnifierExampleUserControl());
            this.exampleControls.Add("ChartViewRotate", new DemoAppsHub.ChartViewExample.ChartViewRotateExampleUserControl());
            this.exampleControls.Add("ChartViewZoomScroll", new DemoAppsHub.ChartViewExample.ChartViewZoomScrollExampleUserControl());
            this.PreloadControls();
        }

        private void PreloadControls()
        {
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                this.Controls.Add(entry.Value);
                entry.Value.Location = new Point(120, 180);
            }
        }

        private void PrepareTitleBar()
        {
            titleBar = new RadTitleBarElement();

            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden;
            titleBar.MaxSize = new Size(0, 50);
            titleBar.Children[1].Visibility = ElementVisibility.Hidden;

            titleBar.CloseButton.Parent.PositionOffset = new SizeF(0, -10);
            titleBar.CloseButton.MinSize = new Size(50, 50);
            titleBar.CloseButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MinimizeButton.MinSize = new Size(50, 50);
            titleBar.MinimizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MaximizeButton.MinSize = new Size(50, 50);
            titleBar.MaximizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.CloseButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MinimizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MaximizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);

            titleBar.Close += new TitleBarSystemEventHandler(titleBar_Close);
            titleBar.Minimize += new TitleBarSystemEventHandler(titleBar_Minimize);
            titleBar.MaximizeRestore += new TitleBarSystemEventHandler(titleBar_MaximizeRestore);
            this.radPanorama1.PanoramaElement.PanGesture += new PanGestureEventHandler(radTilePanel1_PanGesture);
            this.radPanorama1.PanoramaElement.Children.Add(titleBar);
        }

        protected override void OnShown(EventArgs e)
        {
            this.radTilePanel1_SizeChanged(this, EventArgs.Empty);
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                entry.Value.PerformLayout();
                this.Controls.Remove(entry.Value);
            }

            base.OnShown(e);
        }

        private void PrepareHeader()
        {
            StackLayoutElement headerLayout = new StackLayoutElement();
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            headerLayout.NotifyParentOnMouseInput = true;
            headerLayout.ShouldHandleMouseInput = false;
            headerLayout.StretchHorizontally = false;

            this.backButton = new RadButtonElement() { StretchHorizontally = false };
            this.backButton.Margin = new Padding(40, 0, 28, 0);
            this.backButton.Click += new EventHandler(backButton_Click);
            this.backButton.Visibility = ElementVisibility.Hidden;
            headerLayout.Children.Add(this.backButton);

            this.headerLabel = new LightVisualElement();
            this.headerLabel.Text = "Demo Apps Hub";
            this.headerLabel.Font = new Font("Segoe UI Light", 42, GraphicsUnit.Point);
            this.headerLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.headerLabel.ForeColor = Color.White;
            this.headerLabel.TextAlignment = ContentAlignment.MiddleLeft;
            this.headerLabel.MaxSize = new Size(630, 110);
            this.headerLabel.NotifyParentOnMouseInput = true;
            this.headerLabel.ShouldHandleMouseInput = false;
            this.headerLabel.StretchHorizontally = false;
            headerLayout.Children.Add(this.headerLabel);

            this.radPanorama1.PanoramaElement.Children.Add(headerLayout);
        }

        #endregion

        #region Event Handlers

        void linkTile_Click(object sender, EventArgs e)
        {
            RadTileElement senderTile = sender as RadTileElement;
            if (senderTile != null)
            {
                string link = (string)senderTile.Tag;
                System.Diagnostics.Process.Start(new ProcessStartInfo(link));
            }
        }

        void radTilePanel1_PanGesture(object sender, PanGestureEventArgs e)
        {
            if (e.IsBegin && this.titleBar.ControlBoundingRectangle.Contains(e.Location))
            {
                isFormMoving = true;
            }

            if (isFormMoving)
            {
                this.Location = new Point(this.Location.X + e.Offset.Width, this.Location.Y + e.Offset.Height);
            }
            else
            {
                e.Handled = false;
            }

            if (e.IsEnd)
            {
                isFormMoving = false;
            }
        }

        void qsfTile_Click(object sender, System.EventArgs e)
        {
            string path1 = Application.StartupPath + @"\..\..\QuickStart\Bin\TelerikExamples.exe";
            string path2 = Application.StartupPath + @"\..\..\..\Examples\Bin\TelerikExamples.exe";
            if (File.Exists(path1))
            {
                RunProcess(path1);
            }
            else
            {
                RunProcess(path2);
            }
        }

        private void vsbTile_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\VisualStyleBuilder.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin40\VisualStyleBuilder.exe")) // installation
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin40\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\..\Bin\VisualStyleBuilder.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\Release\VisualStyleBuilder.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\Release\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")) // ReleaseTrial
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe")) // ReleaseTrial40, ReleaseTrial461
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\Debug\VisualStyleBuilder.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\Debug\VisualStyleBuilder.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")) //qsf as exe
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe");
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void themeViewerTile_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\..\..\Bin\ThemeViewer.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\Bin\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ThemeViewer.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin40\ThemeViewer.exe")) // installation
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin40\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\Release\ThemeViewer.exe")) // Release
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\Release\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\Release\net40\ThemeViewer.exe")) // Release40
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\Release\net40\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe")) // ReleaseTrial
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe")) // ReleaseTrial40, ReleaseTrial461
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\..\Bin\Debug\ThemeViewer.exe"))
            {
                RunProcess(Application.StartupPath + @"\..\..\..\..\Bin\Debug\ThemeViewer.exe");
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe")) // qsf as exe
            {
                RunProcess(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe");
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        void photoAlbumTile_Click(object sender, System.EventArgs e)
        {
            RunProcess(Application.StartupPath + @"\..\..\PhotoAlbum\Bin\PhotoAlbum.exe");
        }

        void fileExplorerTile_Click(object sender, System.EventArgs e)
        {
            RunProcess(Application.StartupPath + @"\..\..\FileExplorer\Bin\FileExplorer.exe");
        }

        void bugTrackerTile_Click(object sender, System.EventArgs e)
        {
            RunProcess(Application.StartupPath + @"\..\..\BugTracker\Bin\BugTracker.exe");
        }

        void rssReaderTile_Click(object sender, System.EventArgs e)
        {
            RunProcess(Application.StartupPath + @"\..\..\RssReader\Bin\RssReader.exe");
        }

        private void RunProcess(string executablePath)
        {
            if (File.Exists(executablePath))
            {
                ProcessStartInfo proc = new ProcessStartInfo(executablePath);
                proc.WorkingDirectory = Path.GetDirectoryName(executablePath);
                Process.Start(proc);
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        void radTilePanel1_SizeChanged(object sender, EventArgs e)
        {
            int width = this.radPanorama1.Width + Math.Max((this.radPanorama1.PanoramaElement.ScrollBar.Maximum - this.radPanorama1.Width) / 4, 1);
            this.radPanorama1.PanelImageSize = new Size(width, 768);
            this.radPanorama1.PanoramaElement.UpdateViewOnScroll();

            UpdateExampleControlPosition();
        }

        void backButton_Click(object sender, EventArgs e)
        {
            UnloadExample();
        }

        private void LoadPhotoAlbumTileContent()
        {
            this.photoAlbumTile.Text = "";
            this.photoAlbumTile.ContentChangeInterval = 7000;
            this.photoAlbumTile.TransitionType = ContentTransitionType.SlideUp;
            this.photoAlbumTile.Items.Add(new LightVisualElement()
            {
                Image = Resources.img1,
                ImageLayout = ImageLayout.Zoom,
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.Items.Add(new LightVisualElement()
            {
                Image = Resources.img2,
                ImageLayout = ImageLayout.Zoom,
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.Items.Add(new LightVisualElement()
            {
                Image = Resources.img3,
                ImageLayout = ImageLayout.Zoom,
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.Items.Add(new LightVisualElement()
            {
                Image = Resources.img4,
                ImageLayout = ImageLayout.Zoom,
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.Items.Add(new LightVisualElement()
            {
                Image = Resources.img5,
                ImageLayout = ImageLayout.Zoom,
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.Children.Add(new LightVisualElement()
            {
                Text = "Photo Album",
                TextAlignment = ContentAlignment.BottomLeft,
                ZIndex = 1000,
                Padding = new Padding(10),
                Font = new Font("Segoue UI Light", 9, GraphicsUnit.Point),
                ShouldHandleMouseInput = false,
                NotifyParentOnMouseInput = true
            });
            this.photoAlbumTile.CurrentItem = this.photoAlbumTile.Items[0];
        }

        void titleBar_MaximizeRestore(object sender, EventArgs args)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        void titleBar_Minimize(object sender, EventArgs args)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void titleBar_Close(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void gridTile_Click(object sender, EventArgs e)
        {
            LoadExample("GridView", (RadTileElement)sender);
        }

        private void treeViewTile_Click(object sender, EventArgs e)
        {
            LoadExample("TreeView", (RadTileElement)sender);
        }

        private void listViewTile_Click(object sender, EventArgs e)
        {
            LoadExample("ListView", (RadTileElement)sender);
        }

        private void schedulerTile_Click(object sender, EventArgs e)
        {
            LoadExample("Scheduler", (RadTileElement)sender);
        }

        private void magnifierTile_Click(object sender, EventArgs e)
        {
            LoadExample("Magnifier", (RadTileElement)sender);
        }

        private void chartViewRotateTile_Click(object sender, EventArgs e)
        {
            LoadExample("ChartViewRotate", (RadTileElement)sender);
        }

        private void chartViewZoomScrollTile_Click(object sender, EventArgs e)
        {
            LoadExample("ChartViewZoomScroll", (RadTileElement)sender);
        }

        #endregion

        private void LoadExample(string exampleName, RadTileElement tile)
        {
            if (currentExample != string.Empty)
            {
                return;
            }

            this.currentExample = exampleName;

            this.headerLabel.Text = tile.Text;
            this.backButton.Visibility = ElementVisibility.Visible;

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        SizeF.Empty, (int)(10d * 800d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleOpened);
            setting.ApplyValue(this.examplePage);
        }

        private void UnloadExample()
        {
            this.Controls.Remove(this.GetCurrentExampleControl());

            this.backButton.Visibility = ElementVisibility.Hidden;
            this.headerLabel.Text = "Demo Apps Hub";

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        SizeF.Empty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        (int)(10d * 800d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleClosed);
            setting.ApplyValue(this.examplePage);
        }

        private void OnExampleOpened(object sender, AnimationStatusEventArgs e)
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                this.Controls.Add(ctrl);
                ctrl.BringToFront();
                this.UpdateExampleControlPosition();
            }
        }

        private void OnExampleClosed(object sender, AnimationStatusEventArgs e)
        {
            ((AnimatedPropertySetting)sender).AnimationFinished -= OnExampleClosed;
            this.examplePage.Visibility = ElementVisibility.Collapsed;
            this.currentExample = string.Empty;
        }

        private void UpdateExampleControlPosition()
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                ctrl.Bounds = new Rectangle(
                    new Point(120, this.examplePage.ControlBoundingRectangle.Y + 60),
                    new Size(this.Width - 180, this.Height - this.examplePage.ControlBoundingRectangle.Y - 120));
            }
        }

        private UserControl GetCurrentExampleControl()
        {
            if (this.currentExample != "" && this.exampleControls.ContainsKey(this.currentExample))
            {
                return this.exampleControls[this.currentExample];
            }

            return null;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SIZE && titleBar != null)
            {
                titleBar.CloseButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MinimizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MaximizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
            }

            base.WndProc(ref m);
        }

        protected override FormControlBehavior InitializeFormBehavior()
        {
            return new MyFormBehavior(this, true);
        }
    }

    public class MyFormBehavior : RadFormBehavior
    {
        public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
            base(treeHandler, shouldCreateChildren)
        {
        }

        public override Padding BorderWidth
        {
            get
            {
                return new Padding(1);
            }
        }
    }
}
