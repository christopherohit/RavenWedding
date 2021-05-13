using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PhotoAlbum.Properties;

namespace PhotoAlbumCS
{
    public class PhotoAlbumViewerElement : RadItem
    {
        private bool arranged = false;
        private RadItemOwnerCollection items;

        private int selectedIndex = -1;

        //variables to store selected item's location parameters
        private Rectangle originalItemLocation = new Rectangle(Point.Empty, new Size(100, 100));
        private int originalItemZIndex = 0;
        private SizeF originalItemScale;
        private float originalItemAngleTransform = 0f;

        private float itemScaleFactor = 0.2f;

        //stores the original item size to be used as a reference when scaling up/down 
        private Size originalItemSize = new Size(250, 150);

        public PhotoAlbumViewerElement()
        {
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.items = new RadItemOwnerCollection();
            this.items.ItemTypes = new Type[] { typeof(RadButtonElement) };
            this.items.ItemsChanged += new ItemChangedDelegate(items_ItemsChanged);
        }

        private void items_ItemsChanged(RadItemCollection changed, RadItem target, ItemsChangeOperation operation)
        {
            if (operation == ItemsChangeOperation.Inserted ||
                operation == ItemsChangeOperation.Set)
            {
                target.AutoSize = false;

                RadButtonElement button = target as RadButtonElement;
                if (button != null)
                {
                    button.ShowBorder = false;
                    button.ButtonFillElement.Visibility = ElementVisibility.Hidden;
                    button.BorderElement.ZIndex = 1;

                    //Get item original size from the image if available
                    if (button.Image != null)
                        this.originalItemSize = button.Image.Size;

                    ImagePrimitive imagePrimitive = (ImagePrimitive)button.Children[1].Children[0];
                    this.CreatePrevNextButtons(imagePrimitive);
                }
            }

            this.arranged = false;
            this.Invalidate();
        }



        private void CreatePrevNextButtons(ImagePrimitive imagePrimitive)
        {
            RadButtonElement btnPrev;
            RadButtonElement btnNext;

            btnPrev = new RadImageButtonElement();
            btnPrev.Image = Resources.PA_left_arr;
            btnPrev.StretchHorizontally = false;
            btnPrev.StretchVertically = false;
            btnPrev.ShowBorder = false;
            imagePrimitive.Children.Add(btnPrev);
            btnPrev.Click += new EventHandler(btnPrev_Click);
            btnPrev.Location = new Point(17, this.originalItemSize.Height - 90);
            btnPrev.ScaleTransform = new SizeF(1F, 1F);
            btnPrev.Visibility = ElementVisibility.Hidden;
            btnPrev.ButtonFillElement.Visibility = ElementVisibility.Hidden;

            btnNext = new RadImageButtonElement();
            btnNext.Image = Resources.PA_right_arr;
            btnNext.StretchVertically = false;
            btnNext.StretchHorizontally = false;
            btnNext.ShowBorder = false;
            btnNext.ScaleTransform = new SizeF(1F, 1F);
            imagePrimitive.Children.Add(btnNext);
            btnNext.Click += new EventHandler(btnNext_Click);
            btnNext.Location = new Point(this.originalItemSize.Width - 90, this.originalItemSize.Height - 90);
            btnNext.Visibility = ElementVisibility.Hidden;
            btnNext.ButtonFillElement.Visibility = ElementVisibility.Hidden;
        }

        void btnPrev_Click(object sender, EventArgs e)
        {
            int newIndex = this.SelectedIndex - 1;
            if (newIndex < 0)
            {
                newIndex = this.Items.Count - 1;
            }

            this.SelectedIndex = newIndex;
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            int newIndex = this.SelectedIndex + 1;
            if (newIndex > this.Items.Count - 1)
            {
                newIndex = this.Items.Count > 0 ? 0 : -1;
            }

            this.SelectedIndex = newIndex;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category(RadDesignCategory.DataCategory)]
        public RadItemOwnerCollection Items
        {
            get
            {
                return this.items;
            }
        }

        private class CustomLayout : LayoutPanel
        {
            public CustomLayout()
            {
            }
        }

        protected override void CreateChildElements()
        {
            this.Children.Add(new FillPrimitive());

            CustomLayout panel = new CustomLayout();
            this.Children.Add(panel);
            this.Items.Owner = panel;
        }

        private const int numFrames = 15;
        private const int frameInterval = 40;

        private void Rearrange()
        {
            if (this.Size == Size.Empty)
            {
                return;
            }

            Size itemScaledSize = new Size(
                (int)(this.OriginalItemSize.Width * ItemScaleFactor),
                (int)(this.OriginalItemSize.Height * ItemScaleFactor));

            Random rX = new Random(DateTime.Now.Second);
            float frontItemScaleFactor = 0.55f;
            Point frontItemLocation = new Point(270, 180);
            int frontItemIndex = rX.Next(this.Items.Count - 1);

            int maxX = Math.Max(0, this.Size.Width - itemScaledSize.Width);
            int maxY = Math.Max(0, this.Size.Height - itemScaledSize.Height);

            for (int i = 0; i < this.Items.Count; i++)
            {
                int initX = 0;
                int initY = 0;
                if (i % 2 == 0)
                    initX = rX.Next(this.Size.Width);
                else
                    initY = rX.Next(this.Size.Height);

                System.Threading.Thread.Sleep(5);

                RadItem item = this.Items[i];
                if (i != frontItemIndex)
                {
                    int nextX = rX.Next(maxX);
                    int nextY = rX.Next(maxY);

                    if (nextY > frontItemLocation.Y && nextY < frontItemLocation.Y + (int)((items[frontItemIndex] as PhotoElement).Image.Height * frontItemScaleFactor))
                    {
                        int newX = rX.Next(maxX - (int)((items[frontItemIndex] as PhotoElement).Image.Width * frontItemScaleFactor));
                        if (newX > frontItemLocation.X)
                        {
                            newX += (int)((items[frontItemIndex] as PhotoElement).Image.Width * frontItemScaleFactor);
                        }
                        nextX = newX;
                    }  

                AnimatedPropertySetting setting = new AnimatedPropertySetting(
                    RadElement.BoundsProperty,
                    new Rectangle(new Point(initX, initY), OriginalItemSize),
                    new Rectangle(new Point(nextX, nextY), OriginalItemSize),
                    numFrames,
                    frameInterval
                    );

                setting.ApplyEasingType = RadEasingType.OutExponential;
                setting.ApplyValue(item);
                setting.RemoveAfterApply = true;
                item.ZIndex = rX.Next(this.Items.Count);

                
                    this.SetStyleValue(item, RadElement.AngleTransformProperty, (float)rX.Next(90) - 45);
                    this.SetStyleValue(item, RadElement.ScaleTransformProperty, new SizeF(itemScaleFactor, itemScaleFactor));
                }
                else
                {
                    this.SetStyleValue(item, RadElement.BoundsProperty, new Rectangle(frontItemLocation, this.OriginalItemSize));
                    this.SetStyleValue(item, RadElement.AngleTransformProperty, 0F);
                    this.SetStyleValue(item, RadElement.ScaleTransformProperty, new SizeF(frontItemScaleFactor, frontItemScaleFactor));
                    item.BringToFront();
                }
            }

            arranged = true;
        }

        private void SetStyleValue(RadElement element, RadProperty property, object value)
        {
            PropertySetting setting = new PropertySetting(property, value);
            setting.ApplyValue(element);
        }

        [DefaultValue(-1)]
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                if (selectedIndex < -1 || selectedIndex >= this.Items.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (this.selectedIndex != value)
                {
                    if (this.selectedIndex >= 0)
                    {
                        this.AnimateSelectedItem(false);
                    }

                    this.selectedIndex = value;

                    if (this.selectedIndex >= 0)
                    {
                        this.AnimateSelectedItem(true);
                    }
                }
            }
        }

        [DefaultValue(0.5f)]
        public float ItemScaleFactor
        {
            get { return itemScaleFactor; }
            set { itemScaleFactor = value; }
        }

        [DefaultValue("250, 150")]
        public Size OriginalItemSize
        {
            get { return originalItemSize; }
            set { originalItemSize = value; }
        }

        private void AnimateSelectedItem(bool zoomIn)
        {
            RadItem item = this.Items[this.selectedIndex];

            float itemZoomFactor = Math.Min(
                this.Size.Width * 0.9f / this.originalItemSize.Width,
                this.Size.Height * 0.9f / this.originalItemSize.Height);

            Size zoomedItemSize = new Size(
                (int)(originalItemSize.Width * itemZoomFactor),
                (int)(originalItemSize.Height * itemZoomFactor));

            Point zoomedItemLocation = new Point(
                (int)(this.Size.Width / 2f - zoomedItemSize.Width / 2f),
                (int)(this.Size.Height / 2f - zoomedItemSize.Height / 2f));

            AnimatedPropertySetting setting1 = new AnimatedPropertySetting(
                    RadElement.BoundsProperty,
                    null,
                    new Rectangle(zoomedItemLocation, OriginalItemSize),
                    numFrames,
                    frameInterval
                    );

            AnimatedPropertySetting setting2 = new AnimatedPropertySetting(
                RadElement.ScaleTransformProperty,
                null,
                new SizeF(itemZoomFactor, itemZoomFactor),
                numFrames,
                frameInterval
                );

            AnimatedPropertySetting setting3 = new AnimatedPropertySetting(
                RadElement.AngleTransformProperty,
                null,
                0f,
                12,
                frameInterval
                );

            if (zoomIn)
            {
                item.BringToFront();

                originalItemLocation = item.Bounds;
                originalItemZIndex = item.ZIndex;
                originalItemAngleTransform = item.AngleTransform;
                originalItemScale = item.ScaleTransform;
                //item.ZIndex = this.Items.Count + 1;

                RadButtonItem button = item as RadButtonItem;
                if (button != null)
                {
                    ImagePrimitive imagePrimitive = (ImagePrimitive)button.Children[1].Children[0];

                    imagePrimitive.Children[0].Visibility = ElementVisibility.Visible;
                    imagePrimitive.Children[1].Visibility = ElementVisibility.Visible;
                }
            }
            else
            {
                setting1.EndValue = originalItemLocation;
                setting2.EndValue = originalItemScale;
                setting3.EndValue = originalItemAngleTransform;

                setting1.RemoveAfterApply = true;
                setting2.RemoveAfterApply = true;
                setting3.RemoveAfterApply = true;

                //originalItemZIndex = item.ZIndex;

                RadButtonItem button = item as RadButtonItem;
                if (button != null)
                {
                    ImagePrimitive imagePrimitive = (ImagePrimitive)button.Children[1].Children[0];

                    imagePrimitive.Children[0].Visibility = ElementVisibility.Hidden;
                    imagePrimitive.Children[1].Visibility = ElementVisibility.Hidden;
                }

                //item.ZIndex = originalItemZIndex;
            }

            setting1.ApplyEasingType = RadEasingType.OutExponential;
            setting2.ApplyEasingType = RadEasingType.OutExponential;
            setting3.ApplyEasingType = RadEasingType.OutExponential;

            setting1.ApplyValue(item);
            setting2.ApplyValue(item);
            setting3.ApplyValue(item);
        }

        protected override void OnBubbleEvent(RadElement sender, RoutedEventArgs args)
        {
            if (args.RoutedEvent == RadElement.MouseClickedEvent)
            {
                RadItem item = sender as RadItem;
                if (item != null)
                {
                    item.BringToFront();
                }
            }
            else if (args.RoutedEvent == RadElement.MouseDoubleClickedEvent)
            {
                int newSelectedIndex = -1;
                if (sender is RadItem)
                {
                    newSelectedIndex = this.Items.IndexOf(sender as RadItem);
                }

                if (newSelectedIndex >= 0)
                {
                    if (newSelectedIndex != this.SelectedIndex)
                    {
                        this.SelectedIndex = newSelectedIndex;
                    }
                    else
                    {
                        this.SelectedIndex = -1;
                    }
                }
            }
            else if (args.RoutedEvent == RadElement.MouseDownEvent)
            {
                if (this.items.Contains(sender as RadButtonElement))
                {
                    MouseEventArgs e = args.OriginalEventArgs as MouseEventArgs;
                    if (e != null)
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            this.dragItem = sender as RadButtonElement;
                            this.BeginDrag(e);

                        }
                    }
                }
            }
            else if (args.RoutedEvent == RadElement.MouseUpEvent)
            {
                if (this.ElementTree != null)
                {
                    MouseEventArgs e = args.OriginalEventArgs as MouseEventArgs;
                    if (e != null && e.Button == MouseButtons.Left)
                    {
                        this.dragItem = null;
                        EndDrag();
                    }
                }
            }
        }



        protected override void PaintChildren(Telerik.WinControls.Paint.IGraphics graphics, Rectangle clipRectange, float angle, SizeF scale, bool useRelativeTransformation)
        {
            //use paint as a trigger for item rearrangement
            if (!arranged)
                Rearrange();

            base.PaintChildren(graphics, clipRectange, angle, scale, useRelativeTransformation);
        }

        #region Drag&Drop helpers

        private bool isDragging = false;
        private int currentX;
        private int currentY;
        private RadButtonElement dragItem = null;
        private bool isRealDrag = false;
        private Point point = Point.Empty;

        protected virtual bool IsRealDrag(int mousePositionX, int mousePositionY)
        {
            if (!this.isRealDrag)
            {
                this.isRealDrag = (Math.Abs((int)(mousePositionX - dragItem.Location.X - this.currentX)) >= SystemInformation.DragSize.Width) ||
                                  (Math.Abs((int)(mousePositionY - dragItem.Location.Y - this.currentY)) >= SystemInformation.DragSize.Height);
            }
            return this.isRealDrag;
        }

        private void EndDrag()
        {
            this.Capture = false;
            isDragging = false;
            isRealDrag = false;
        }

        private void BeginDrag(MouseEventArgs e)
        {
            if (!IsRealDrag(e.X, e.Y))
                return;
            dragItem.BringToFront();
            this.Capture = true;
            this.isDragging = true;
            this.currentX = e.X - dragItem.Location.X;
            this.currentY = e.Y - dragItem.Location.Y;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (isDragging)
            {

                dragItem.Location = new Point((e.X - currentX),
                                                (e.Y - currentY));
            }
        }

        #endregion
    }

}