using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.GridView.CustomViews
{
    public class NoteElement: LightVisualElement
    {
        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.StretchHorizontally = true;
            this.StretchVertically = true;
            this.ForeColor = Color.Black;
            this.TextAlignment = ContentAlignment.TopLeft;
            this.TextWrap = true;
            this.DisableHTMLRendering = false;
            this.ClipDrawing = true;
            this.BypassLayoutPolicies = true;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            base.MeasureOverride(availableSize);
            return new SizeF(1, 1);
        }
    }
}
