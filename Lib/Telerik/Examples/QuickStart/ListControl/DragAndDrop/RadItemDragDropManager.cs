using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using System.Collections;

namespace Telerik.Examples.WinControls.ListControl.DragAndDrop
{
    public class RadDragEventArgs : CancelEventArgs
    {
        private readonly RadListDataItem item;
        private readonly RadListDataItem draggedItem;

        public RadDragEventArgs(RadListDataItem draggedItem)
        {
            this.draggedItem = draggedItem;
        }

        public RadDragEventArgs(RadListDataItem item, RadListDataItem draggedItem)
        {
            this.item = item;
            this.draggedItem = draggedItem;
        }

        public RadListDataItem Item
        {
            get { return item; }
        }

        public RadListDataItem DraggedItem
        {
            get { return draggedItem; }
        }
    }

    public class DragCancelEventArgs : CancelEventArgs
    {
        private readonly RadListDataItem item;
        private readonly RadListDataItem replacedItem;

        public DragCancelEventArgs(RadListDataItem item, RadListDataItem replacedItem)
        {
            this.item = item;
            this.replacedItem = replacedItem;
        }

        public RadListDataItem ReplacedItem
        {
            get { return replacedItem; }
        }

        public RadListDataItem Item
        {
            get { return item; }
        }
    }

    public class RadItemDragDropManager : IDisposable
    {
        private FeedBackForm feedBackForm;
        private bool allowDragDrop = true;
        private ICollection<RadListDataItem> items;
        private ICollection<RadListDataItem> items2;
        private System.Windows.Forms.Form outlineForm;
        private RadListDataItem draggedItem;
        private ComponentThemableElementTree sourceComponentElementTree;
        private ComponentThemableElementTree targetComponentElementTree;
        private bool isRealDrag;
        private bool dragging;
        private RadListDataItem replacedItem;
        private Point initialMousePosition;
        private RadControl control;
        private RadControl control2;
        private RadListControl sourceListBox;
        private RadListControl targetListBox;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool ShowWindow(HandleRef hWnd, int nCmdShow);

        public RadItemDragDropManager(RadControl control, RadControl control2)
        {
            this.control = control;
            control.MouseMove += this.Control_MouseMove;
            control.MouseUp += this.Control_MouseUp;

            this.control2 = control2;
            control2.MouseMove += this.Control_MouseMove;
            control2.MouseUp += this.Control_MouseUp;
        }

        public RadItemDragDropManager(RadControl control, ICollection<RadListDataItem> items, RadControl control2, ICollection<RadListDataItem> items2)
            : this(control, control2)
        {
            this.items = items;
            this.items2 = items2;
        }

        private void InitializeDragOperation(object sender, MouseEventArgs e)
        {
            sourceListBox = (RadListControl)sender;

            sourceComponentElementTree = sourceListBox.ElementTree;

            if (sourceComponentElementTree.RootElement.ElementTree != null && this.AllowDragDrop)
            {
                RadElement elementAtPoint = sourceComponentElementTree.GetElementAtPoint(e.Location);

                if (elementAtPoint is RadListVisualItem)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        sourceComponentElementTree.RootElement.ElementTree.Control.Capture = true;

                        BeginDrag(e);
                    }
                }
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (!this.dragging)
            {
                return;
            }

            if (targetListBox != null)
            {
                targetComponentElementTree = targetListBox.ElementTree;
                if (targetComponentElementTree.RootElement.ElementTree != null && this.AllowDragDrop)
                {
                    targetComponentElementTree.RootElement.ElementTree.Control.Capture = false;
                    if (e.Button == MouseButtons.Left)
                    {
                        if (this.outlineForm != null)
                            this.outlineForm.Hide();
                        if (this.feedBackForm != null)
                            this.feedBackForm.Hide();
                        EndDrag(e);
                    }
                }
            }
            if (this.outlineForm != null)
            {
                this.outlineForm.Hide();
                this.outlineForm.Dispose();
                this.outlineForm = null;
                this.draggedItem = null;
                this.replacedItem = null;
                this.dragging = false;
                this.isRealDrag = false;
            }
            if (this.feedBackForm != null)
            {
                this.feedBackForm.Hide();
                this.feedBackForm.Dispose();
                this.feedBackForm = null;
                this.dragging = false;
                this.isRealDrag = false;
            }
            sourceListBox.FindForm().Cursor = Cursors.Arrow;

        }

        private void SetOutLineForm(MouseEventArgs e)
        {
            if (this.draggedItem != null)
                if ((this.AllowDragDrop) && (this.isRealDrag) && (e.Button == MouseButtons.Left))
                    if (this.outlineForm != null)
                    {
                        if (!this.outlineForm.Visible)
                        {
                            HandleRef handleRef = new HandleRef(this.outlineForm, this.outlineForm.Handle);
                            ShowWindow(handleRef, 8);
                        }
                        this.outlineForm.Location = new Point(Cursor.Position.X + 2, Cursor.Position.Y + 2);

                    }
        }

        private void RefreshItemsAfterDragDrop(MouseEventArgs e)
        {
            if (this.draggedItem == this.replacedItem) return;

            DragCancelEventArgs args = new DragCancelEventArgs(this.draggedItem, this.replacedItem);

            if (args.Cancel)
            {
                this.draggedItem = null;
                this.replacedItem = null;
                return;
            }

            if (replacedItem != null)
            {
                int replacedItemIndex = targetListBox.Items.IndexOf(this.replacedItem);
                int draggedItemIndex = sourceListBox.Items.IndexOf(this.draggedItem);
                int UpperBound = replacedItem.VisualItem.Bounds.Height * replacedItemIndex;
                int MiddleBound = UpperBound + replacedItem.VisualItem.Bounds.Height / 2;

                if (sourceListBox == targetListBox && draggedItemIndex == replacedItemIndex) { return; }
                sourceListBox.Items.RemoveAt(draggedItemIndex);

                Point p1 = new Point(); 
                p1.X = e.X;
                p1.Y = e.Y;

                if (p1.Y <= MiddleBound && p1.Y > UpperBound)
                {
                    if (sourceListBox == targetListBox)
                    {
                        //the dragged item should be added above the replaced item  
                        if (draggedItemIndex < replacedItemIndex)
                        {
                            targetListBox.Items.Insert(replacedItemIndex - 1, this.draggedItem);
                        }
                        else
                        {
                            targetListBox.Items.Insert(replacedItemIndex, this.draggedItem);
                        }
                    }
                    else
                    {
                        targetListBox.Items.Insert(replacedItemIndex, this.draggedItem);
                    }
                }
                else
                {
                    if (sourceListBox == targetListBox)
                    {
                        //the dragged item should be added below the replaced item
                        if (draggedItemIndex > replacedItemIndex)
                        {
                            targetListBox.Items.Insert(replacedItemIndex + 1, this.draggedItem);
                        }
                        else
                        {
                            targetListBox.Items.Insert(replacedItemIndex, this.draggedItem);
                        }
                        //targetListBox.Items.Insert(replacedItemIndex, this.draggedItem);
                    }
                    else
                    {
                        targetListBox.Items.Insert(replacedItemIndex + 1, this.draggedItem);
                    }
                }
            }
            else
            {
                int idx = sourceListBox.Items.IndexOf(this.draggedItem);
                sourceListBox.Items.RemoveAt(idx);
                targetListBox.SelectedItem = null;
                targetListBox.Items.Add(this.draggedItem);

            }
            targetListBox.SelectedIndex = -1;
            targetListBox.SelectedItem = draggedItem;

            this.draggedItem = null;
            this.replacedItem = null;
        }

        protected virtual bool IsRealDrag(Point mousePosition)
        {
            if (!this.isRealDrag)
            {
                this.isRealDrag = (Math.Abs((int)(mousePosition.X - this.initialMousePosition.X)) >= SystemInformation.DragSize.Width) || (Math.Abs((int)(mousePosition.Y - this.initialMousePosition.Y)) >= SystemInformation.DragSize.Height);
            }
            return this.isRealDrag;
        }

        Color colorToSet = Color.Orange;

        private void BeginDrag(MouseEventArgs e)
        {
            this.initialMousePosition = new Point(e.X, e.Y);
            RadElement elementAtPoint = sourceComponentElementTree.GetElementAtPoint(this.initialMousePosition);

            if (elementAtPoint == null)
            {
                return;
            }
            else
            {
                if ((elementAtPoint.Visibility != ElementVisibility.Visible))
                    return;
            }

            if (elementAtPoint is RadListElement) return;
            if (elementAtPoint is RadListVisualItem) sourceListBox.SelectedItem = (elementAtPoint as RadListVisualItem).Data;

            this.draggedItem = (elementAtPoint as RadListVisualItem).Data;

            DragCancelEventArgs args = new DragCancelEventArgs(this.draggedItem, null);

            if (args.Cancel)
            {
                this.draggedItem = null;
                return;
            }

            RadDragEventArgs dragArgs = new RadDragEventArgs(this.draggedItem, null);

            this.isRealDrag = false;

            this.dragging = true;

            if (this.feedBackForm == null) { feedBackForm = new FeedBackForm(); }

            this.colorToSet = this.FeedbackFormLineColor();
            this.feedBackForm.LineColor = this.colorToSet;

            if (this.draggedItem != null)
                PrepareDragging(e);
        }

        // Set the color of the feedback form dynamically depending on the color blending.
        private Color FeedbackFormLineColor()
        {
            if (this.draggedItem == null)
            {
                return SystemColors.ControlDark;
            }

            return this.draggedItem.VisualItem.BorderColor;
        }

        private void EndDrag(MouseEventArgs e)
        {
            this.dragging = false;

            if (this.draggedItem != null)
            {
                if (targetListBox != null)
                {
                    if (targetListBox == sourceListBox && sourceListBox.Items.Count == 1) return;
                    
                    Point p2 = new Point();
                    p2 = sourceListBox.PointToScreen(new Point(e.X, e.Y));
                    p2 = targetListBox.PointToClient(p2);
                    RadElement elementAtPoint = targetComponentElementTree.GetElementAtPoint(p2);

                    if (elementAtPoint != null)
                    {
                        if ((elementAtPoint.Visibility != ElementVisibility.Visible))
                        {
                            return;
                        }

                        //RadListVisualItem visualItem = elementAtPoint as RadListVisualItem;
                        //if (visualItem != null)
                        {
                            //replacedItem = visualItem.Data;
                            if (draggedItem == replacedItem) return;
                            RefreshItemsAfterDragDrop(e);
                        }
                    }

                    if (this.outlineForm != null)
                    {
                        this.outlineForm.Dispose();
                        this.outlineForm = null;
                    }

                    if (this.feedBackForm != null)
                    {
                        this.feedBackForm.Dispose();
                        this.feedBackForm = null;
                    }

                    this.isRealDrag = false;
                }
            }
        }

        private void PrepareDragging(MouseEventArgs e)
        {
            if (this.draggedItem.VisualItem.Visibility == ElementVisibility.Visible)
            {
                this.outlineForm = TelerikHelper.CreateOutlineForm();
                this.outlineForm.ShowInTaskbar = false;
                this.outlineForm.ShowIcon = false;

                this.outlineForm.BackgroundImage = this.draggedItem.VisualItem.GetAsBitmap(Brushes.Transparent, 0, new SizeF(1, 1));
                this.outlineForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.outlineForm.Size = this.outlineForm.BackgroundImage.Size;
                this.outlineForm.MinimumSize = this.outlineForm.BackgroundImage.Size;
                this.outlineForm.Location = new Point(Cursor.Position.X + 2, Cursor.Position.Y + 2);
            }
        }

        public bool Dragging
        {
            get { return dragging; }
        }

        public void Dispose()
        {
            if (control != null)
            {
                control.MouseMove -= this.Control_MouseMove;
                control.MouseUp -= this.Control_MouseUp;
                control = null;
            }
            if (control2 != null)
            {
                control2.MouseMove -= this.Control_MouseMove;
                control2.MouseUp -= this.Control_MouseUp;
                control2 = null;
            }
        }

        public static RadListControl GetTreeViewUnderMouse(Point mousePosition)
        {
            return TelerikHelper.ControlAtPoint(Control.MousePosition) as RadListControl;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.dragging)
            {
                this.InitializeDragOperation(sender, e);
            }

            if (e.Button == MouseButtons.Left)
            {
                this.targetListBox = GetTreeViewUnderMouse(Control.MousePosition);

                if (this.draggedItem is RadListDataItem)
                {
                    if (this.targetListBox == null)
                    {
                        this.control.FindForm().Cursor = Cursors.No;
                    }
                    else this.control.FindForm().Cursor = Cursors.Arrow;
                }
                else
                {
                    this.control.FindForm().Cursor = Cursors.Arrow;
                }

                if (!this.AllowDragDrop)
                {
                    return;
                }

                if (e.Button != MouseButtons.Left)
                {
                    if (this.outlineForm != null)
                        this.outlineForm.Hide();
                }

                if (this.draggedItem == null)
                {
                    if (this.outlineForm != null)
                        this.outlineForm.Hide();

                    return;
                }

                RadElement elementAtPoint = this.sourceListBox.ElementTree.GetElementAtPoint(new Point(e.X, e.Y));

                this.IsRealDrag(e.Location);

                if (elementAtPoint != null)
                {
                    if (elementAtPoint.Visibility != ElementVisibility.Visible) { return; }
                }

                this.SetOutLineForm(e);
                this.DrawFeedBack(e);
            }
        }

        private void DrawFeedBack(MouseEventArgs e)
        {
            if (targetListBox == null) { feedBackForm.Hide(); return; }
            this.targetComponentElementTree = this.targetListBox.ElementTree;
            Point p4 = new Point();
            p4 = sourceListBox.PointToScreen(new Point(e.X, e.Y));
            p4 = targetListBox.PointToClient(p4);
            RadElement elementAtPoint = targetComponentElementTree.GetElementAtPoint(p4);

            RadListVisualItem visualReplacedItem = elementAtPoint as RadListVisualItem;
            this.replacedItem = visualReplacedItem != null ? visualReplacedItem.Data : null;

            if (visualReplacedItem == null) { feedBackForm.Hide(); return; }

            if (visualReplacedItem != null)
            {
                int UpperBound = visualReplacedItem.Bounds.Height * this.targetListBox.Items.IndexOf(this.replacedItem);
                int MiddleBound = UpperBound + visualReplacedItem.Bounds.Height / 2;
                int LowerBound = UpperBound + visualReplacedItem.Bounds.Height;

                if (p4.Y < UpperBound || p4.Y > LowerBound)
                {
                    //FeedBack shouldnt be drawn
                    feedBackForm.StartPoint = null;
                }

                if (p4.Y <= MiddleBound && p4.Y > UpperBound)
                {
                    //FeedBack should be drawn above the replceditem
                    feedBackForm.StartPoint = this.targetListBox.PointToScreen(new Point(0+3, UpperBound+1));
                }

                if (p4.Y <= LowerBound && p4.Y > MiddleBound)
                {
                    //FeedBack should be drawn below the replaceditem
                    feedBackForm.StartPoint = this.targetListBox.PointToScreen(new Point(0 + 3, UpperBound + 1 + visualReplacedItem.Bounds.Height));
                }
            }

            if (elementAtPoint is RadListElement)
            {
                if (targetListBox.Items.Count > 0)
                {
                    RadListDataItem lastItem = this.targetListBox.Items[this.targetListBox.Items.Count - 1];


                    //FeedBack should be drawn always below the last item of the targetListBox
                    if (feedBackForm == null) return;
                    feedBackForm.StartPoint = this.targetListBox.PointToScreen(new Point(3, 1 + lastItem.VisualItem.Bounds.Height * this.targetListBox.Items.IndexOf(lastItem) + lastItem.VisualItem.Bounds.Height));
                }
                else
                {
                    feedBackForm.StartPoint = null;
                }
            }
            SetFeedBackForm();
        }

        private void SetFeedBackForm()
        {
            if (this.feedBackForm != null)
            {
                if (!this.feedBackForm.Visible)
                {
                    HandleRef handleRef = new HandleRef(this.feedBackForm, this.feedBackForm.Handle);
                    ShowWindow(handleRef, 8);
                }

                if (feedBackForm.StartPoint != null)
                {
                    this.feedBackForm.Location = (Point)feedBackForm.StartPoint;
                }
                else
                {
                    feedBackForm.Hide();
                }
            }
        }

        private bool AllowDragDrop
        {
            get { return allowDragDrop; }
            set { allowDragDrop = value; }
        }

        public ICollection<RadListDataItem> Items
        {
            get { return items; }
            set { items = value; }
        }
    }

    public class FeedBackForm : Form
    {
        private Color lineColor;

        public FeedBackForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.White;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.ShowInTaskbar = false;
            this.MinimumSize = new Size(10, 5);
            this.MaximumSize = new Size(400, 15);
            this.Opacity = 0.5;

            _startPoint = new Point();
            _endPoint = new Point();
        }

        public Nullable<Point> EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }

        public Nullable<Point> StartPoint
        {
            get { return _startPoint; }
            set { _startPoint = value; }
        }

        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(lineColor);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            Graphics g = e.Graphics;
            pen.Width = 4;
            g.DrawLine(pen, 0, 0, 250, 0);
            pen.Dispose();
            base.OnPaint(e);
        }
        private Nullable<Point> _startPoint;
        private Nullable<Point> _endPoint;
    }
}

