using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Layouts;
using System.Drawing;
using BookShelf.Properties;
using Telerik.WinControls.Primitives;
using System.Windows.Forms;

namespace BookShelf.Custom_Elements
{
    public class HorizontalTileElement : BaseTileElement
    {
        private LightVisualElement toggleButton;
        private ToggleState toggle;
        private LightVisualElement imageElement;
        private LightVisualElement textElement;
        private double maxHeight;

        public HorizontalTileElement(Book book, double maxHeight)
            : base(book)
        {
            this.maxHeight = maxHeight;
            this.ToggleState = book.IsFavorite ? ToggleState.On : ToggleState.Off;
            this.Text = book.Title.Trim();
            this.BackColor = book.Color; 
            SetImage();
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            toggle = Telerik.WinControls.Enumerations.ToggleState.Off;

            this.Margin = new Padding(5);
            this.DrawText = false;
            this.ImageOpacity = 0;
            this.MaxSize = this.Size;
            this.ClipDrawing = true;

            DockLayoutPanel horizontalDock = new DockLayoutPanel();
            horizontalDock.LastChildFill = true;

            imageElement = new LightVisualElement();
            imageElement.Margin = new Padding(5, 0, 5, 0);
            horizontalDock.Children.Add(imageElement);
            imageElement.SetValue(DockLayoutPanel.DockProperty, Dock.Left);
            imageElement.NotifyParentOnMouseInput = true;
            imageElement.ShouldHandleMouseInput = false;

            DockLayoutPanel dockPanel = new DockLayoutPanel();
            dockPanel.LastChildFill = true;

            toggleButton = new LightVisualElement();
            toggleButton.Image = fav_empty;
            toggleButton.StretchHorizontally = false;
            toggleButton.StretchVertically = false;
            toggleButton.Alignment = ContentAlignment.BottomRight;
            toggleButton.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);

            toggleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(toggleButton_MouseDown);

            textElement = new CustomTextElement();
            textElement.Font = BookShelfApp.SegoeUI12;
            textElement.ForeColor = Color.Black;
            textElement.TextAlignment = ContentAlignment.TopLeft;
            textElement.TextWrap = true;
            textElement.NotifyParentOnMouseInput = true;
            textElement.ShouldHandleMouseInput = false;

            toggleButton.SetValue(DockLayoutPanel.DockProperty, Dock.Right);
            textElement.SetValue(DockLayoutPanel.DockProperty, Dock.Left);

            dockPanel.Children.Add(toggleButton);
            dockPanel.Children.Add(textElement);

            horizontalDock.Children.Add(dockPanel);

            this.Children.Add(horizontalDock);

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

        public LightVisualElement TextElement
        {
            get { return this.textElement; }
        }

        public LightVisualElement ToggleButton
        {
            get { return this.toggleButton; }
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
                this.Book.IsFavorite = value == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            }
        }

        void toggleButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (toggle == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                toggle = Telerik.WinControls.Enumerations.ToggleState.On;
                this.Book.IsFavorite = true;
                toggleButton.Image = fav_full;
            }
            else
            {
                toggle = Telerik.WinControls.Enumerations.ToggleState.Off;
                toggleButton.Image = fav_empty;
                this.Book.IsFavorite = false;
            }
        }   

        protected override Image ResizeImage()
        {
            return Book.Image.Height > maxHeight ? ResizeImage(Book.Image, maxHeight / (double)Book.Image.Height) : Book.Image;
        }
    }
}
