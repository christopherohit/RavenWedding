using System;
using Telerik.WinControls.UI;

namespace RichTextEditorRibbonUI
{
    public class RichTextEditorQuickAccessToolbarButtonElement : RadButtonElement
    {
        protected override Type ThemeEffectiveType
        {
            get { return typeof(RadButtonElement); }
        }
    }
}
