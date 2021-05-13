using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.Carousel.Events
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radCarouselDemo.BackColorChanged += new EventHandler(radCarousel1_BackColorChanged);
            this.radCarouselDemo.Click += new EventHandler(radCarousel1_Click);
            this.radCarouselDemo.ItemDataBound += new ItemDataBoundEventHandler(CarouselElement_ItemDataBound);
            this.radCarouselDemo.Items.ItemsChanged += new ItemChangedDelegate(Items_ItemsChanged);
            this.radCarouselDemo.SelectedIndexChanged += new EventHandler(CarouselElement_SelectedIndexChanged);
            this.radCarouselDemo.SelectedItemChanged += new EventHandler(radCarousel1_SelectedItemChanged);
            this.radCarouselDemo.SelectedValueChanged += new EventHandler(radCarousel1_SelectedValueChanged);

            this.radCarouselDemo.ImageList = this.imageList4;
            this.radCarouselDemo.VisibleItemCount = 7;
            CreateCarouselItems();

            this.radRadioBezier.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCarouselDemo.NavigationButtonsOffset = new Size(10, 10);

            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");

            this.radCarouselDemo.ButtonNext.BorderElement.Visibility = ElementVisibility.Collapsed;
            this.radCarouselDemo.ButtonNext.Text = "";
            this.radCarouselDemo.ButtonPrevious.BorderElement.Visibility = ElementVisibility.Collapsed;
            this.radCarouselDemo.ButtonPrevious.Text = "";
            this.radCarouselDemo.CarouselElement.Children[1].Visibility = ElementVisibility.Collapsed;
            this.radCarouselDemo.CarouselElement.Children[0].Visibility = ElementVisibility.Collapsed;
        }

        private void CreateCarouselItems()
        {
            foreach (Image image in this.radCarouselDemo.ImageList.Images)
            {
                RadButtonElement carouselItem = new RadButtonElement();
                carouselItem.ImageAlignment = ContentAlignment.MiddleCenter;
                carouselItem.TextAlignment = ContentAlignment.MiddleCenter;
                carouselItem.DisplayStyle = DisplayStyle.Image;
                carouselItem.TextImageRelation = TextImageRelation.ImageAboveText;
                carouselItem.ShowBorder = false;

                carouselItem.ForeColor = Color.WhiteSmoke;
                    
                carouselItem.BackColor = Color.YellowGreen;
                carouselItem.Image = new Bitmap( image, image.Size.Width/2, image.Size.Height/2);
                
                this.radCarouselDemo.Items.Add(carouselItem);
            }
        }

        void radCarousel1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.AddTextToListBox("SelectedValueChanged");
        }

        void radCarousel1_SelectedItemChanged(object sender, EventArgs e)
        {
            this.AddTextToListBox("SelectedItemChanged "+radCarouselDemo.SelectedItem.ToString());
        }

        void CarouselElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AddTextToListBox("SelectedIndexChanged "+radCarouselDemo.SelectedIndex.ToString());
        }

        void Items_ItemsChanged(RadItemCollection changed, RadItem target, ItemsChangeOperation operation)
        {
            if( target != null )
                this.AddTextToListBox(string.Format("Element {0} is {1}",target.ToString() ,operation.ToString()));
            else
                this.AddTextToListBox(string.Format("Element is {0}" ,operation.ToString()));
        }

        void CarouselElement_ItemDataBound(object sender, ItemDataBoundEventArgs e)
        {
            this.AddTextToListBox("ItemDataBound");
        }

        void radCarousel1_Click(object sender, EventArgs e)
        {
            this.AddTextToListBox("Click");
        }

        void radCarousel1_BackColorChanged(object sender, EventArgs e)
        {
            this.AddTextToListBox("BackColorChanged");
        }

        private void AddTextToListBox(string text)
        {
            RadListDataItem label = new RadListDataItem();
            label.Text = string.Format("{0} {1}", text, DateTime.Now.ToString());
            AddTextToListBox(label);
        }

        private void AddTextToListBox(RadListDataItem item)
        {
            if (radListEvents.IsDisposed)
                return;

            if (radListEvents.Items.Count > 40)
            {
                radListEvents.Items.Clear();
            }
            if (radListEvents.RootElement.ElementState != ElementState.Loaded)
            {
                return;
            }

            radListEvents.Items.Add(item);
            radListEvents.ScrollToItem(item);
        }

        private void radSpinReflection(object sender, EventArgs e)
        {
            this.radCarouselDemo.ItemReflectionPercentage = (double) radSpinEditor1.Value;
        }

        private void radCheckEnableLooping_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCarouselDemo.EnableLooping = !this.radCarouselDemo.EnableLooping;
        }

        private void radCheckAutoLoop_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCarouselDemo.EnableAutoLoop = !this.radCarouselDemo.EnableAutoLoop;
        }

        private void OnRadRadioPath_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            switch (this.radRadioBezier.ToggleState)
            {
                case ToggleState.On:
                    CarouselBezierPath carouselPath = new CarouselBezierPath();
                    carouselPath.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(125, 150, 400);
                    carouselPath.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(64, -80, -200);
                    carouselPath.FirstPoint = new Telerik.WinControls.UI.Point3D(10, 10, -0);
                    carouselPath.LastPoint = new Telerik.WinControls.UI.Point3D(19, 80, -100);
                    carouselPath.ZScale = 200;

                    this.radCarouselDemo.CarouselPath = carouselPath;
                    break;
                case ToggleState.Off:
                    CarouselEllipsePath ellipsePath = new CarouselEllipsePath();
                    ellipsePath.Center = new Telerik.WinControls.UI.Point3D(50, 47, 0);
                    ellipsePath.FinalAngle = 270;
                    ellipsePath.InitialAngle = 270;
                    ellipsePath.U = new Telerik.WinControls.UI.Point3D(31, -21, 0);
                    ellipsePath.V = new Telerik.WinControls.UI.Point3D(0, 22, 200);
                    ellipsePath.ZScale = 400;
                    this.radCarouselDemo.CarouselPath = ellipsePath;
                    break;
            }
        }

        protected override void WireEvents()
        {
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinReflection);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckEnableLooping_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckAutoLoop_ToggleStateChanged);
            this.radRadioBezier.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadRadioPath_ToggleStateChanged);
        }
    }
}