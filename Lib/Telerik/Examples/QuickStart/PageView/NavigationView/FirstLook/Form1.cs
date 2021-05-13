using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.NavigationView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.ParisPage.Item.Tag = this.ParisPage.Item.Image;
            this.LondonPage.Item.Tag = this.LondonPage.Item.Image;
            this.ViennaPage.Item.Tag = this.ViennaPage.Item.Image;
            this.VenicePage.Item.Tag = this.VenicePage.Item.Image;
            this.FlorencePage.Item.Tag = this.FlorencePage.Item.Image;
            this.EdinburghPage.Item.Tag = this.EdinburghPage.Item.Image;

            this.ParisPage.Item.PropertyChanged += Item_PropertyChanged;
            this.LondonPage.Item.PropertyChanged += Item_PropertyChanged;
            this.ViennaPage.Item.PropertyChanged += Item_PropertyChanged;
            this.VenicePage.Item.PropertyChanged += Item_PropertyChanged;
            this.FlorencePage.Item.PropertyChanged += Item_PropertyChanged;
            this.EdinburghPage.Item.PropertyChanged += Item_PropertyChanged;
        }
        
        private void SetWhitePageImage(RadPageViewPage page)
        {
            Image image = ImageHelper.ChangeImagePixels(page.Image, Color.White);
            page.Item.Image = image;            
        }
        
        private void Item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == LightVisualElement.BackColorProperty.Name)
            {
                RadPageViewNavigationViewItem item = sender as RadPageViewNavigationViewItem;
                Color backColor = item.BackColor;
                if (!item.DrawFill || backColor == Color.Transparent)
                {
                    RadElement parent = item.Parent;
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
                
                if (this.IsDarkColor(backColor))
                {
                    this.SetWhitePageImage(item.Page);
                }
                else if(item.Tag != null)
                {
                    item.Image = (Image)item.Tag;
                }
            }
        }

        private bool IsDarkColor(Color color)
        {
            double colorBrightness = Math.Sqrt(color.R * color.R * 0.241 + color.G * color.G * 0.691 + color.B * color.B * 0.068);
            return colorBrightness < 170;
        }
    }
}