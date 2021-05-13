using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Editors
{
    public class VirtualGridTrackBarEditor : BaseVirtualGridEditor
    {
        public override object Value
        {
            get { return this.TrackBarElement.Value; }
            set
            {
                if (value != null && value != DBNull.Value)
                {
                    this.TrackBarElement.Value = Convert.ToInt32(value);
                }
                else
                {
                    this.TrackBarElement.Value = 0;
                }
            }
        }

        public RadTrackBarEditorElement TrackBarElement
        {
            get { return this.EditorElement as RadTrackBarEditorElement; }
        }

        public int Minimum
        {
            get { return (int)this.TrackBarElement.Minimum; }
            set { this.TrackBarElement.Minimum = value; }
        }

        public int Maximum
        {
            get { return (int)this.TrackBarElement.Maximum; }
            set { this.TrackBarElement.Maximum = value; }
        }

        public int TickFrequency
        {
            get { return this.TrackBarElement.TickFrequency; }
            set { this.TrackBarElement.TickFrequency = value; }
        }

        public override void Initialize(object owner, object value)
        {
            base.Initialize(owner, value);

            this.EditorElement.Focus();
            this.TrackBarElement.Value = Convert.ToInt32(value);
        }

        public override void BeginEdit()
        {
            base.BeginEdit();

            ((VirtualGridCellElement)this.EditorElement.Parent).Text = this.Value + " %";
            ((RadTrackBarEditorElement)this.EditorElement).TrackPositionChanged += new EventHandler(TrackBarEditor_TrackPositionChanged);
        }

        public override bool EndEdit()
        {
            ((RadTrackBarEditorElement)this.EditorElement).TrackPositionChanged -= new EventHandler(TrackBarEditor_TrackPositionChanged);
            return base.EndEdit();
        }

        private void TrackBarEditor_TrackPositionChanged(object sender, EventArgs e)
        {
            ((VirtualGridCellElement)this.EditorElement.Parent).Text = this.Value + " %";
            OnValueChanged();
        }

        protected override RadElement CreateEditorElement()
        {
            return new RadTrackBarEditorElement(this);
        }

        public override Type DataType
        {
            get { return typeof(Int32); }
        }
    }
}
