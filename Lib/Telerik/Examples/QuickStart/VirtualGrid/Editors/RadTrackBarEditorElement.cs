using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Editors
{
    public class RadTrackBarEditorElement : RadTrackBarElement
    {
        VirtualGridTrackBarEditor editor;

        public RadTrackBarEditorElement(VirtualGridTrackBarEditor editor)
        {
            this.CanFocus = true;
            this.editor = editor;
            this.Maximum = 100;
            this.TickStyle = Telerik.WinControls.Enumerations.TickStyles.Both;
            this.SmallTickFrequency = 5;
            this.LargeTickFrequency = 20;
            this.BodyElement.ScaleContainerElement.TopScaleElement.StretchVertically = true;
            this.BodyElement.ScaleContainerElement.BottomScaleElement.StretchVertically = true;
            this.StretchVertically = false;
        }

        public event EventHandler TrackPositionChanged;

        protected override Type ThemeEffectiveType
        {
            get { return typeof(RadTrackBarElement); }
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            foreach (RadElement element in this.Children)
            {
                element.Measure(new SizeF(availableSize.Width, availableSize.Height));
            }

            return new SizeF(1, availableSize.Height);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            SizeF size = finalSize;
            size.Width -= 40;

            return base.ArrangeOverride(size);
        }

        public override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);

            if (this.Parent != null && this.TrackPositionChanged != null)
            {
                this.TrackPositionChanged(this, EventArgs.Empty);
            }
        }
    }
}
