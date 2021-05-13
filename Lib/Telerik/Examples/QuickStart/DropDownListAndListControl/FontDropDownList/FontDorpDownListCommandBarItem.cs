using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList
{
    class FontDropDownListCommandBarItem : RadCommandBarBaseItem
    {
        RadFontPopupEditorElement fontDropDownList;

        public RadFontPopupEditorElement FontDropDownList
        {
            get { return this.fontDropDownList; }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.fontDropDownList = new RadFontPopupEditorElement();

            this.fontDropDownList.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;
            this.fontDropDownList.AutoSize = true;
            this.StretchHorizontally = this.StretchVertically = false;
            this.MinSize = new System.Drawing.Size(170, 22);

            this.Children.Add(this.fontDropDownList);
        }
    }
}