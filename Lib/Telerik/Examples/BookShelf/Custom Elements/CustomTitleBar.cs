using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using System.Windows.Forms;
using BookShelf.Properties;
using System.Drawing;
using Telerik.WinControls.Layouts;

namespace BookShelf.Custom_Elements
{
    public class CustomTitleBar : RadTitleBar
    {
        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);

            this.TitleBarElement.FillPrimitive.Visibility = ElementVisibility.Collapsed;
            ((BorderPrimitive)this.TitleBarElement.Children[1]).Visibility = ElementVisibility.Collapsed;
            //this.TitleBarElement.Children[2].Children[2].Visibility = ElementVisibility.Collapsed; //hide the title bar text

            StackLayoutElement stack = new StackLayoutElement();
            //stack.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            stack.StretchHorizontally = true;
            stack.NotifyParentOnMouseInput = true;
            stack.Orientation = Orientation.Vertical;

            LightVisualElement upperTitleBarElement = new LightVisualElement();
            upperTitleBarElement.NotifyParentOnMouseInput = true;
            upperTitleBarElement.MinSize = new System.Drawing.Size(0, 10);
            upperTitleBarElement.StretchVertically = false;

            RadImageShape titleBarShape = new RadImageShape();
            titleBarShape.Image = Resources.title_bar_pattern;
            titleBarShape.PaintMode = ImagePaintMode.StretchYTileX;
            upperTitleBarElement.BackgroundShape = titleBarShape;

            stack.Children.Add(upperTitleBarElement);

            LightVisualElement bottomTitleBarElement = new LightVisualElement();
            bottomTitleBarElement.NotifyParentOnMouseInput = true;
        
            RadImageShape backgroundShape = new RadImageShape();
            backgroundShape.Image = Resources.bg_pattern;
            backgroundShape.PaintMode = ImagePaintMode.Tile;
            bottomTitleBarElement.BackgroundShape = backgroundShape;

            DockLayoutPanel dockLayoutPanel = (DockLayoutPanel)this.TitleBarElement.Children[2];
            bottomTitleBarElement.Children.Add(dockLayoutPanel);

            stack.Children.Add(bottomTitleBarElement);
            this.TitleBarElement.Children.Add(stack);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            //base.OnTextChanged(e);
        }

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadTitleBar).FullName;
            }
            set
            {
                base.ThemeClassName = value;
            }
        }

        #region Maximize/Minimize logic

        int previousClick = SystemInformation.DoubleClickTime;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int now = System.Environment.TickCount;
            if (now - previousClick <= SystemInformation.DoubleClickTime)
            {
                DoubleClickExecuted();
            }
            previousClick = now;

            base.OnMouseDown(e);
        }

        void DoubleClickExecuted()
        {
            Form form = this.FindForm();

            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
                this.TitleBarElement.MaximizeButton.Image = Resources.restore_btn;


            }
        }

        #endregion

        #region Button images logic

        public CustomTitleBar()
        {
            this.TitleBarElement.CloseButton.Image = Resources.close_btn;
            this.TitleBarElement.MinimizeButton.Image = Resources.minimize_btn;
            this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn;

            this.TitleBarElement.CloseButton.MouseEnter += new EventHandler(CloseButton_MouseEnter);
            this.TitleBarElement.CloseButton.MouseLeave += new EventHandler(CloseButton_MouseLeave);
            this.TitleBarElement.CloseButton.MouseDown += new MouseEventHandler(CloseButton_MouseDown);
            this.TitleBarElement.CloseButton.MouseUp += new MouseEventHandler(CloseButton_MouseUp);

            this.TitleBarElement.MinimizeButton.MouseEnter += new EventHandler(MinimizeButton_MouseEnter);
            this.TitleBarElement.MinimizeButton.MouseLeave += new EventHandler(MinimizeButton_MouseLeave);
            this.TitleBarElement.MinimizeButton.MouseDown += new MouseEventHandler(MinimizeButton_MouseDown);
            this.TitleBarElement.MinimizeButton.MouseUp += new MouseEventHandler(MinimizeButton_MouseUp);
            
            this.TitleBarElement.MaximizeButton.MouseEnter += new EventHandler(MaximizeButton_MouseEnter);
            this.TitleBarElement.MaximizeButton.MouseLeave += new EventHandler(MaximizeButton_MouseLeave);
            this.TitleBarElement.MaximizeButton.MouseDown += new MouseEventHandler(MaximizeButton_MouseDown);
            this.TitleBarElement.MaximizeButton.MouseUp += new MouseEventHandler(MaximizeButton_MouseUp);

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            this.TitleBarElement.CloseButton.MouseEnter -= new EventHandler(CloseButton_MouseEnter);
            this.TitleBarElement.CloseButton.MouseLeave -= new EventHandler(CloseButton_MouseLeave);
            this.TitleBarElement.CloseButton.MouseDown -= new MouseEventHandler(CloseButton_MouseDown);
            this.TitleBarElement.CloseButton.MouseUp -= new MouseEventHandler(CloseButton_MouseUp);

            this.TitleBarElement.MinimizeButton.MouseEnter -= new EventHandler(MinimizeButton_MouseEnter);
            this.TitleBarElement.MinimizeButton.MouseLeave -= new EventHandler(MinimizeButton_MouseLeave);
            this.TitleBarElement.MinimizeButton.MouseDown -= new MouseEventHandler(MinimizeButton_MouseDown);
            this.TitleBarElement.MinimizeButton.MouseUp -= new MouseEventHandler(MinimizeButton_MouseUp);

            this.TitleBarElement.MaximizeButton.MouseEnter -= new EventHandler(MaximizeButton_MouseEnter);
            this.TitleBarElement.MaximizeButton.MouseLeave -= new EventHandler(MaximizeButton_MouseLeave);
            this.TitleBarElement.MaximizeButton.MouseDown -= new MouseEventHandler(MaximizeButton_MouseDown);
            this.TitleBarElement.MaximizeButton.MouseUp -= new MouseEventHandler(MaximizeButton_MouseUp);
        }

        void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.TitleBarElement.CloseButton.Image = Resources.close_btn_tapped;
        }

        void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.TitleBarElement.CloseButton.Image = Resources.close_btn;
        }

        void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.TitleBarElement.CloseButton.Image = Resources.close_btn;
        }

        void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.TitleBarElement.CloseButton.Image = Resources.close_btn_hover;
        }

        void MinimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.TitleBarElement.MinimizeButton.Image = Resources.minimize_btn_tapped;
        }

        void MinimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.TitleBarElement.MinimizeButton.Image = Resources.minimize_btn;
        }

        void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.TitleBarElement.MinimizeButton.Image = Resources.minimize_btn;
        }

        void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.TitleBarElement.MinimizeButton.Image = Resources.minimize_btn_hover;
        }

        void MaximizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            Form f = this.FindForm();
            if (f != null)
            {
                if (f.WindowState != FormWindowState.Maximized)
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.restore_btn_tapped;
                }
                else
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn_tapped;
                }
            }

        }

        void MaximizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            Form f = this.FindForm();
            if (f != null)
            {
                if (f.WindowState != FormWindowState.Maximized)
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.restore_btn;
                }
                else
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn;
                }
            }
        }

        void MaximizeButton_MouseLeave(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            if (f != null)
            {
                if (f.WindowState == FormWindowState.Maximized)
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.restore_btn;
                }
                else
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn;
                }
            }
        }

        void MaximizeButton_MouseEnter(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            if (f != null)
            {
                if (f.WindowState == FormWindowState.Maximized)
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.restore_btn_hover;
                }
                else
                {
                    this.TitleBarElement.MaximizeButton.Image = Resources.maximize_btn_hover;
                }
            }
        }

        #endregion
    }
}
