using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Buttons.Button
{
	public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();

            this.CenterPanel = true;
            this.radRadioImgBeforeTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
             
        }

        private void radRadioImgAboveTxt_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioImgAboveTxt.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radButton3.TextImageRelation = TextImageRelation.ImageAboveText;
                radButton3.TextAlignment = ContentAlignment.BottomCenter;
            }

            if (this.radRadioImgBeforeTxt.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
                radButton3.TextAlignment = ContentAlignment.MiddleCenter;
            }

            if (this.radRadioTxtAboveImg.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radButton3.TextImageRelation = TextImageRelation.TextAboveImage;
                radButton3.TextAlignment = ContentAlignment.TopCenter;
            }

            if (this.radRadioTxtBeforeImg.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radButton3.TextImageRelation = TextImageRelation.TextBeforeImage;
                radButton3.TextAlignment = ContentAlignment.MiddleCenter;
            }

            if (this.radRadioOverlay.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radButton3.TextImageRelation = TextImageRelation.Overlay;
                radButton3.TextAlignment = ContentAlignment.MiddleCenter;
            }
        }

        protected override void WireEvents()
        {
            this.radRadioTxtAboveImg.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            this.radRadioImgBeforeTxt.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            this.radRadioTxtBeforeImg.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            this.radRadioOverlay.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
        }
	}
}