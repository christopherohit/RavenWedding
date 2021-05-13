using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.ValidationProvider
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;
            ((RegexMaskTextBoxProvider)this.EmailMaskedEditBox.MaskedEditBoxElement.Provider).ErrorMessage = string.Empty;

            string xml =
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" >" +
                    "<circle cx=\"8\" cy=\"8\" r=\"8\" fill=\"#00BFE8\" />" +
                    "<text x=\"4\" y=\"13\" fill=\"white\" font-family=\"Consolas, Helvetica, sans-serif\" font-size=\"14px\" font-weight=\"bold\">i</text>" +
                "</svg>";
            this.highlightValidationErrorsLabel.SvgImage = RadSvgImage.FromXml(xml);

            FillComboFromEnum(this.validationModeDropDownList, typeof(ValidationMode), ValidationMode.OnValidating);
            this.validationModeDropDownList.SelectedValue = ValidationMode.Programmatically;
            this.radValidationProvider1.ControlValidation += RadValidationProvider1_ControlValidation;            
        }

        private void RadValidationProvider1_ControlValidation(object sender, RadValidationEventArgs e)
        {
            e.EnableToolTipShadow = false;
            e.ToolTipDuration = 3000;
        }

        private void ValidationModeDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radValidationProvider1.ValidationMode = (ValidationMode)this.validationModeDropDownList.SelectedValue;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.doubleBufferedTableLayoutPanel1.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        this.radValidationProvider1.Validate(editorControl);
                    }
                }
            }
        }
    }
}