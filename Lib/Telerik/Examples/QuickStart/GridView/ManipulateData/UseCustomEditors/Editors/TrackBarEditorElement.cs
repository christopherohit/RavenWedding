using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
{
    public class TrackBarEditorElement : RadTrackBarElement
    {
        TrackBarEditor editor;

        public TrackBarEditorElement(TrackBarEditor editor)
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
            get
            {
                return typeof(RadTrackBarElement);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            RadGridView grid = this.ElementTree.Control as RadGridView;
            if (grid != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                    case Keys.Enter:
                    case Keys.Up:
                    case Keys.Down:
                        grid.GridBehavior.ProcessKeyDown(e);
                        break;

                    case Keys.Left:
                        if (this.Value > this.Minimum)
                        {
                            this.Value--;
                        }
                        break;

                    case Keys.Right:
                        if (this.Value < this.Maximum)
                        {
                            this.Value++;
                        }
                        break;

                    case Keys.Home:
                        this.Value = this.Minimum;
                        break;

                    case Keys.End:
                        this.Value = this.Maximum;
                        break;
                }
            }
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            int desiredHeight = 40;
            foreach (RadElement element in this.Children)
            {
                element.Measure(new SizeF(availableSize.Width, desiredHeight));
            }
            return new SizeF(1, desiredHeight);
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
