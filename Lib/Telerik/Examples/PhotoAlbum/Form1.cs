using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PhotoAlbumCS
{
    public partial class Form1 : RadForm
    {
        private RadTitleBarElement titleBar;
        public const int WM_SIZE = 5;

        public Form1()
        {
            InitializeComponent();
            ThemeResolutionService.LoadPackageResource("PhotoAlbum.PhotoAlbumDemo.tssp");
            ThemeResolutionService.ApplyThemeToControlTree(this, "PhotoAlbumDemo");
             
            this.Text = "Photo album viewer";
            this.FormElement.TitleBar.MaxSize = new Size(0, 3);
            PrepareTitleBar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radRadPhotoAlbumViewer1.BackgroundImage = Image.FromFile(@"background.jpg");
            this.radRadPhotoAlbumViewer1.Items.Clear();
            foreach (string file in Directory.GetFiles(@"Photos\", "*.jpg"))
            {
                Image img = Image.FromFile(file);
                PhotoElement imageItem = new PhotoElement();
                imageItem.ToolTipText = "Double click to resize";
                imageItem.Image = img;
                imageItem.MouseHover += new EventHandler(imageItem_MouseHover);
                imageItem.MouseLeave += new EventHandler(imageItem_MouseLeave);
                this.radRadPhotoAlbumViewer1.Items.Add(imageItem);
            }
        }

        void imageItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        void imageItem_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }


        private void PrepareTitleBar()
        {
            titleBar = new RadTitleBarElement();
            titleBar.Text = "<html><span style=\"font-family:segoe ui light;font-size:24\">Photo Album </span><span style=\"font-family:segoe ui;font-size:24\">Viewer</span>";
            titleBar.ForeColor = Color.FromArgb(255, 67, 44, 18);
            
            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden;
            titleBar.CaptionElement.Margin = new Padding(35, 5, 0, 0);
            titleBar.MaxSize = new Size(0, 45);
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
            this.radRadPhotoAlbumViewer1.AlbumElement.Children.Add(titleBar);
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