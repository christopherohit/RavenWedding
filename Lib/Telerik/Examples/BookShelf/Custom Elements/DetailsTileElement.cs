using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using BookShelf.Properties;
using System.Windows.Forms;

namespace BookShelf.Custom_Elements
{
    public class DetailsTileElement : BaseTileElement 
    {
        VerticalTileElement verticalTile;
        LightVisualElement label;

        public DetailsTileElement(Book book)
            : base(book)
        {
            this.ToggleState = book.IsFavorite ? ToggleState.On : ToggleState.Off;
            this.Image = book.Image;
            this.VerticalTileElement.BackColor = book.Color;
            this.Description = "<html><span style=\"font-family:segoe ui\"><size=14.5><b>" + book.Title.ToUpper() + "</span></b></html>" + "\n\n\n" + SampleText;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.BackColor = Color.Transparent;

            verticalTile = new VerticalTileElement(null, 0);
            this.verticalTile.Margin = new Padding(0, 0, 10, 0);
            this.verticalTile.Padding = new Padding(-2, 10, -2, 0);
            verticalTile.StretchHorizontally = false;
            verticalTile.MinSize = new System.Drawing.Size(125, 0);

            label = new LightVisualElement();
            label.Padding = new Padding(25);
            label.DrawFill = true;
            label.ForeColor = Color.Black;
            label.BackColor = Color.White;
            label.Font = BookShelfApp.SegoeUI10;
            label.TextWrap = true;
            label.TextAlignment = ContentAlignment.TopLeft;
            //enables scrolling with mouse via the label element
            label.ShouldHandleMouseInput = false;
            label.NotifyParentOnMouseInput = true;
            //
            DockLayoutPanel dockPanel = new DockLayoutPanel();
            dockPanel.StretchHorizontally = true;
            dockPanel.StretchVertically = true;
            dockPanel.LastChildFill = true;

            dockPanel.Children.Add(verticalTile);
            dockPanel.Children.Add(label);

            verticalTile.SetValue(DockLayoutPanel.DockProperty, Dock.Left);
            label.SetValue(DockLayoutPanel.DockProperty, Dock.Right);

            this.Children.Add(dockPanel);

        }

        public ToggleState ToggleState
        {
            get
            {
                return this.verticalTile.ToggleState;
            }
            set
            {
                this.verticalTile.ToggleState = value;
                this.Book.IsFavorite = value == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            }
        }

        public string Description
        {
            get
            {
                return this.label.Text;
            }
            set
            {
                this.label.Text = value;
            }
        }

        public new Image Image
        {
            get
            {
                return verticalTile.Image;
            }
            set
            {
                verticalTile.Image = value;
            }
        }

        public VerticalTileElement VerticalTileElement
        {
            get
            {
                return this.verticalTile;
            }
        }
    }
}
