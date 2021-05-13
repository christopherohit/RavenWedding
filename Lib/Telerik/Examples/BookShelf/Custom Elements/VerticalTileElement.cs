using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using BookShelf.Properties;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.Custom_Elements
{
    public class VerticalTileElement : BaseTileElement
    {
        private LightVisualElement toggleButton;
        private ToggleState toggle;
        private LightVisualElement imageElement;
        private LightVisualElement textElement;

        public VerticalTileElement(Book book, int column)
            : base(book)
        {
            if (book != null)
            {
                this.ToggleState = book.IsFavorite ? ToggleState.On : ToggleState.Off;
                this.Text = book.Title.Trim();
                this.BackColor = book.Color;
                SetImage();
            }
            this.Column = column;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            toggle = Telerik.WinControls.Enumerations.ToggleState.Off;

            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DrawText = false;
            this.ImageOpacity = 0;

            DockLayoutPanel stack = new DockLayoutPanel();
            stack.LastChildFill = true;

            imageElement = new LightVisualElement();
            imageElement.ShouldHandleMouseInput = false;
            imageElement.NotifyParentOnMouseInput = true;
            imageElement.MaxSize = new System.Drawing.Size(0, 160);
            imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            

            textElement = new LightVisualElement();
            textElement.Font = BookShelfApp.SegoeUI12;
            textElement.ForeColor = Color.Black;
            textElement.TextAlignment = ContentAlignment.TopLeft;
            textElement.TextWrap = true;
            textElement.ShouldHandleMouseInput = false;
            textElement.NotifyParentOnMouseInput = true;
            textElement.Padding = new Padding(10, 0, 10, 0);

            toggleButton = new LightVisualElement();
            toggleButton.Image = fav_empty;
            toggleButton.StretchHorizontally = false;
            toggleButton.Alignment = System.Drawing.ContentAlignment.BottomRight;
            toggleButton.Margin = new Padding(0, 0, 10, 10);
            toggleButton.MouseDown += new MouseEventHandler(toggleButton_MouseDown);

            imageElement.SetValue(DockLayoutPanel.DockProperty, Dock.Top);
            textElement.SetValue(DockLayoutPanel.DockProperty, Dock.Top);
            toggleButton.SetValue(DockLayoutPanel.DockProperty, Dock.Bottom);

            stack.Children.Add(imageElement);
            stack.Children.Add(toggleButton);
            stack.Children.Add(textElement);

            this.Children.Add(stack);
        }

        public override Image Image
        {
            get
            {
                return imageElement.Image;
            }
            set
            {
                imageElement.Image = value;
            }
        }

        public override string Text
        {
            get
            {
                return textElement.Text;
            }
            set
            {
                textElement.Text = value;
            }
        }        

        public ToggleState ToggleState
        {
            get
            {
                return this.toggle;
            }
            set
            {
                this.toggle = value;
                if (toggle == Telerik.WinControls.Enumerations.ToggleState.Off)
                {
                    toggleButton.Image = fav_empty;
                }
                else
                {
                    toggleButton.Image = fav_full;
                }
            }
        }

        void toggleButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bool result;

            if (toggle == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                toggle = Telerik.WinControls.Enumerations.ToggleState.On;
                toggleButton.Image = fav_full;
                result = true;
            }
            else
            {
                toggle = Telerik.WinControls.Enumerations.ToggleState.Off;
                toggleButton.Image = fav_empty;
                result = false;
            }

            if (Book != null)
            {
                this.Book.IsFavorite = result;
            }
            else
            {
                DetailsTileElement tileElement = FindAncestor<DetailsTileElement>();
                if (tileElement != null)
                {
                    tileElement.Book.IsFavorite = result;
                }                    
            }           
        }

        protected override Image ResizeImage()
        {
            return ResizeImage(Book.Image, 120.0 / (double)Book.Image.Width);
        }
    }
}
