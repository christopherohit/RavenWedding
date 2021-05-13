using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
{
    public class CustomTreeNodeElement : TreeNodeElement
    {
        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.StretchHorizontally = false;
        }

        protected override TreeNodeContentElement CreateContentElement()
        {
            return new CustomContentElement();
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(TreeNodeElement);
            }
        }
    }
}
