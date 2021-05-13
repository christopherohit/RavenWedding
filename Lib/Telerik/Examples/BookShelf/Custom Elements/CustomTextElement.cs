using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;

namespace BookShelf.Custom_Elements
{
    public class CustomTextElement : LightVisualElement
    {
        //trim the element text
        protected override Telerik.WinControls.Primitives.TextParams CreateTextParams()
        {
            TextParams textParams = base.CreateTextParams();
            textParams.lineLimit = true;
            return textParams;
        }
    }
}
