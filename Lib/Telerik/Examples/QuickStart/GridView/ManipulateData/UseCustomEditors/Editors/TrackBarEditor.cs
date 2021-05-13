using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
{
    public class TrackBarEditor : BaseGridEditor
    {
        public override object Value
        {
            get
            {
                return this.TrackBarElement.Value;
            }
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

        public TrackBarEditorElement TrackBarElement
        {
            get
            {
                return this.EditorElement as TrackBarEditorElement;
            }
        }

        public int Minimum
        {
            get
            {
                return (int)this.TrackBarElement.Minimum;
            }
            set
            {
                this.TrackBarElement.Minimum = value;
            }
        }

        public int Maximum
        {
            get
            {
                return (int)this.TrackBarElement.Maximum;
            }
            set
            {
                this.TrackBarElement.Maximum = value;
            }
        }

        public int TickFrequency
        {
            get
            {
                return this.TrackBarElement.TickFrequency;
            }
            set
            {
                this.TrackBarElement.TickFrequency = value;
            }
        }

        public override void Initialize(object owner, object value)
        {
            base.Initialize(owner, value);

            this.EditorElement.Focus();
            this.TrackBarElement.Value = (int)value;
        }

        public override void BeginEdit()
        {
            base.BeginEdit();

            ((GridCellElement)this.EditorElement.Parent).Text = this.Value + " %";
            ((TrackBarEditorElement)this.EditorElement).TrackPositionChanged += new EventHandler(TrackBarEditor_TrackPositionChanged);
        }

        public override bool EndEdit()
        {
            ((TrackBarEditorElement)this.EditorElement).TrackPositionChanged -= new EventHandler(TrackBarEditor_TrackPositionChanged);
            return base.EndEdit();
        }

        void TrackBarEditor_TrackPositionChanged(object sender, EventArgs e)
        {
            ((GridCellElement)this.EditorElement.Parent).Text = this.Value + " %";
            OnValueChanged();
        }

        protected override RadElement CreateEditorElement()
        {
            return new TrackBarEditorElement(this);
        }

        public override Type DataType
        {
            get
            {
                return typeof(Int32);
            }
        }

    }
}
