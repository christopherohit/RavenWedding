using System;
using System.ComponentModel;
using System.Drawing.Design;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RichTextEditorRibbonUI
{
    public class RichTextEditorRibbonTab : RibbonTab
    {
        /// <summary>
        /// Gets the nested items.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(DesignerConsts.RadItemCollectionEditorString, typeof(UITypeEditor))]
        [RadNewItem("Add New Group...", true, false, false)]
        [Browsable(false)]
        public override RadItemOwnerCollection Items
        {
            get { return base.Items; }
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(RibbonTab); }
        }
    }
}
