using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace DiagramOrganizationChart
{
 public class OrgContainerShape : RadDiagramContainerShape
    { 
        private const int BottomOffset = 25;
        private bool isUpdating = false;
        private System.Drawing.Color baseColor;
        private bool showCollapseButton = true;
        private readonly LightVisualElement collapseElement = new LightVisualElement();
        private static readonly Font segoeUI = new Font("Segoe UI Symbol", 11);
        public OrgContainerShape()
        {
            this.IsConnectorsManipulationEnabled = false;
            this.HeaderPresenter.ZIndex = 10;
            this.HeaderPresenter.DrawFill = false;
            this.DrawBorder = true;
            this.IsDraggingEnabled = false;
            this.BaseColor = System.Drawing.Color.LightGray;
            this.ContentShapeElement.BorderColor = System.Drawing.Color.LightGray;
            this.ContentShapeElement.BorderWidth = 2;
            this.ContentShapeElement.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ContentShapeElement.BorderDashPattern = new float[] { 4, 1 };
            this.ContentShapeElement.Margin = new Padding(0, 0, 0, BottomOffset);
            this.MinWidth = 325;
            this.Items.CollectionChanged += this.Items_CollectionChanged;
            this.IsResizingEnabled = false;
            this.collapseElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.collapseElement.MinSize = new Size(15, 15);
            this.collapseElement.Text = "-";
            this.collapseElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.collapseElement.DrawBorder = true;
            this.collapseElement.Click += this.collapseElement_Click;
            this.Children.Add(this.collapseElement);
            this.IsEditable = false;
            this.ToggleCollapseButton.ToggleStateChanged+=toggleCollapseButton_ToggleStateChanged;
            this.ToggleCollapseButton.Image = null;
            this.ToggleCollapseButton.Font = segoeUI;
            this.ToggleCollapseButton.ForeColor = Color.Black;
            this.ToggleCollapseButton.Text = "▼";
            
        }
        
        protected void toggleCollapseButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {  
            this.ToggleCollapseButton.Image = null;
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.ToggleCollapseButton.ForeColor = Color.White;
                this.ToggleCollapseButton.Text = "▶";
            }
            else
            {
                this.ToggleCollapseButton.ForeColor = Color.Black;
                this.ToggleCollapseButton.Text = "▼";
            }            
        }


        public bool ShowCollapseButton
        {
            get
            {
                return this.showCollapseButton;
            }
            set
            {
                this.showCollapseButton = value;
                this.collapseElement.Visibility = value ? Telerik.WinControls.ElementVisibility.Visible : Telerik.WinControls.ElementVisibility.Hidden;
            }
        }
        
        private void collapseElement_Click(object sender, EventArgs e)
        {
            bool isNotVisible = this.collapseElement.Text == "+";
            this.ChangeConnectionVisibility(this, !isNotVisible);
            this.collapseElement.Text = !isNotVisible ? "+" : "-";
        }
        
        private void ChangeConnectionVisibility(Telerik.Windows.Diagrams.Core.IShape sourceShape, bool isVisible)
        {
            foreach (var connection in sourceShape.OutgoingLinks)
            {
                connection.Visibility = isVisible ? Telerik.WinControls.ElementVisibility.Hidden : Telerik.WinControls.ElementVisibility.Visible;
                connection.Target.Visibility = isVisible ? Telerik.WinControls.ElementVisibility.Hidden : Telerik.WinControls.ElementVisibility.Visible;
                RadDiagramContainerShape container = connection.Target as RadDiagramContainerShape;
                if (container != null)
                {
                    foreach (var item in container.Items)
                    {
                        item.Visibility = isVisible? Telerik.WinControls.ElementVisibility.Hidden : Telerik.WinControls.ElementVisibility.Visible;
                    }
                }
                
                this.ChangeConnectionVisibility(connection.Target, isVisible);
            }
        }
        
        public Color BaseColor
        {
            get
            {
                return this.baseColor;
            }
            set
            {
                this.baseColor = value;                
                foreach (RadDiagramShape child in this.Items)
                {
                    child.BackColor = this.BaseColor;
                }
                
                ((OrgHeaderPresenterElement)this.HeaderPresenter).TeamMembers.LabelFill.BackColor = this.BaseColor;
            }
        }
        
        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            var sizeF = new SizeF(availableSize.Width, availableSize.Height - BottomOffset);
            return base.MeasureOverride(sizeF);
        }
        
        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);
            float top = this.HeaderPresenter.DesiredSize.Height - this.HeaderPresenter.DesiredSize.Height / 4f;
            RectangleF contentRect = new RectangleF(0, top, finalSize.Width, finalSize.Height - top);
            this.ContentShapeElement.Arrange(contentRect);
            var collapseRect = new RectangleF((finalSize.Width - this.collapseElement.DesiredSize.Width) / 2, finalSize.Height - this.collapseElement.DesiredSize.Height - this.collapseElement.DesiredSize.Height / 3 , this.collapseElement.DesiredSize.Width, this.collapseElement.DesiredSize.Height);
            this.collapseElement.Arrange(collapseRect);
            return finalSize;
        }
        
        protected override void OnIsCollapsedChanged(bool newValue, bool oldValue)
        {
            base.OnIsCollapsedChanged(newValue, oldValue);
            this.DrawBorder = !this.IsCollapsed;
            if (this.IsCollapsed)
            {
                this.Height = this.MinHeight + BottomOffset;
                ((OrgHeaderPresenterElement)this.HeaderPresenter).HeaderLabel.LabelText.ForeColor = Color.White;
            }
            else
            {
                ((OrgHeaderPresenterElement)this.HeaderPresenter).HeaderLabel.LabelText.ForeColor = Color.Black;
            }

            this.ContentShapeElement.DrawFill = !this.IsCollapsed;
            this.HeaderPresenter.BackColor = this.baseColor;
            this.HeaderPresenter.DrawFill = this.IsCollapsed;
        }
        
        protected override LightVisualElement CreateHeaderPresenter()
        {
            return new OrgHeaderPresenterElement(this.ToggleCollapseButton, this.Label) { MaxSize = new Size(250,0), MinSize = new Size(0,48), Alignment = ContentAlignment.TopCenter };
        }
        
        public string Path { get; set; }
        
        public string TeamMembers
        {
            set
            {
                ((OrgHeaderPresenterElement)this.HeaderPresenter).TeamMembers.Text = value;
            }
            get
            {
                return ((OrgHeaderPresenterElement)this.HeaderPresenter).TeamMembers.Text;
            }
        }
        
        /// <summary>
        /// Height
        /// </summary>
        public override double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                if (this.isUpdating)
                {
                    return;
                }
                
                this.isUpdating = true;
                base.Height = value;
                
                if (this.IsInValidState(true))
                {
                    var bounds = this.CalculateMinShapeBounds();
                    if (this.MinHeight <= bounds.Height + BottomOffset + 5)
                    {
                        this.MinHeight = this.Height + BottomOffset;
                    }
                }
                
                //this.MinHeight = value + BottomOffset;
                
                this.isUpdating = false;
            }
        }
        
        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.TeamMembers = string.Format("{0} Team Members", this.Items.Count);
            this.MinHeight = 0;
            if (e.NewItems != null && e.NewItems[0] is RadDiagramShape)
            {
                ((RadDiagramShape)e.NewItems[0]).BackColor = this.BaseColor;
            }
            
            var position = new Telerik.Windows.Diagrams.Core.Point(this.Position.X + 10, this.Position.Y + 50);
            
            int memberCount = 0;
            
            foreach (var item in this.Items)
            {
                var member = item as RadDiagramShape;
                if (member == null)
                {
                    continue;
                }
                member.Position = position;
                position.X += member.Width + 20;
                if (++memberCount % 2 == 0)
                {
                    position = new Telerik.Windows.Diagrams.Core.Point(this.Position.X + 10, position.Y + member.Height + 10);
                }
            }
            
            if (position.Y + 50 > this.Position.Y + this.Height)
            {
                this.UpdateContentBounds();
                this.UpdateContainerLayout();
                this.MinHeight = this.Height + BottomOffset;
                this.UpdateContentBounds();
                this.UpdateContainerLayout();
            }
        }
    }
}
