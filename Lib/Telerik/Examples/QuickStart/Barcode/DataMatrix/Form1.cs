using System;
using System.Text;
using Telerik.Examples.WinControls.Editors;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI.Barcode.Symbology;
using Telerik.WinControls.UI.Data;

namespace Telerik.Examples.WinControls.Barcode.DataMatrix
{
    public partial class Form1 : EditorExampleBaseForm, ICustomThemeExamplesForm
    {
        Telerik.WinControls.UI.Barcode.Symbology.DataMatrix dataMatrix;

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;

            this.dataMatrix = new Telerik.WinControls.UI.Barcode.Symbology.DataMatrix();
            this.dataMatrix.Encodation = Encodation.Ascii;
            this.dataMatrix.SymbolSize = SymbolSize.SquareAuto;
            this.dataMatrix.Encoding = Encoding.UTF8;

            this.radBarcode1.Symbology = this.dataMatrix;
            this.radBarcode1.Value = "7";

            this.encodationDdl.DataSource = Enum.GetValues(typeof(Encodation));
            this.encodationDdl.SelectedValue = dataMatrix.Encodation;

            this.symbolSizeDdl.DataSource = Enum.GetValues(typeof(SymbolSize));
            this.symbolSizeDdl.SelectedValue = dataMatrix.SymbolSize;

            EncodingInfo[] encodings = Encoding.GetEncodings();
            EncodingInfo selectedEncoding = null;
            foreach (var item in encodings)
            {
                if (item.DisplayName == dataMatrix.Encoding.EncodingName)
                {
                    selectedEncoding = item;
                    break;
                }
            }

            this.encodingDdl.DataSource = encodings;
            this.encodingDdl.DisplayMember = "DisplayName";
            this.encodingDdl.SelectedValue = selectedEncoding;

            this.encodationDdl.SelectedIndexChanging += this.EncodationDdl_SelectedIndexChanging;
            this.symbolSizeDdl.SelectedIndexChanging += this.SymbolSizeDdl_SelectedIndexChanging;
            this.encodingDdl.SelectedIndexChanging += this.EncodingDdl_SelectedIndexChanging;
        }

        private void EncodationDdl_SelectedIndexChanging(object sender, PositionChangingCancelEventArgs e)
        {
            try
            {
                this.dataMatrix.Encodation = (Encodation)this.encodationDdl.Items[e.Position].DataBoundItem;
            }
            catch (Exception ex)
            {
                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);

                e.Cancel = true;
            }
        }

        private void SymbolSizeDdl_SelectedIndexChanging(object sender, PositionChangingCancelEventArgs e)
        {
            try
            {
                this.dataMatrix.SymbolSize = (SymbolSize)this.symbolSizeDdl.Items[e.Position].DataBoundItem;
            }
            catch (Exception ex)
            {
                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);

                e.Cancel = true;
            }
        }

        private void EncodingDdl_SelectedIndexChanging(object sender, PositionChangingCancelEventArgs e)
        {
            try
            {
                EncodingInfo encodingInfo = (EncodingInfo)this.encodingDdl.Items[e.Position].DataBoundItem;
                this.dataMatrix.Encoding = encodingInfo.GetEncoding();
            }
            catch (Exception ex)
            {
                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);

                e.Cancel = true;
            }
        }
    }
}
