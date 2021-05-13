using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PictureBoxExamples.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;

            this.radPictureBox1.Image = Resources.ballons_image;

            this.radPictureBox1.ImageLayout = RadImageLayout.Zoom;
            FillComboFromEnum(this.radDropDownListImageLayout, typeof(RadImageLayout), this.radPictureBox1.ImageLayout);

            this.radPictureBox1.ImageAlignment = ContentAlignment.TopCenter;
            FillComboFromEnum(this.radDropDownListImageAlignment, typeof(ContentAlignment), this.radPictureBox1.ImageAlignment);

            FillComboFromEnum(this.radDropDownListPanelDisplayMode, typeof(PictureBoxPanelDisplayMode), this.radPictureBox1.PanelDisplayMode);

            FillComboFromEnum(this.radDropDownListPanelOverflowMode, typeof(PictureBoxPanelOverflowMode), this.radPictureBox1.PanelOverflowMode);

            this.CreatePanelButton("Left Button", this.radPictureBox1.TopPanel.LeftItems);
            this.CreatePanelButton("Center Button", this.radPictureBox1.TopPanel.CenterItems);
            this.CreatePanelButton("Right Button", this.radPictureBox1.TopPanel.RightItems);

            this.CreatePanelButton("Top Button", this.radPictureBox1.LeftPanel.TopItems);
            this.CreatePanelButton("Center Button", this.radPictureBox1.LeftPanel.CenterItems);
            this.CreatePanelButton("Bottom Button", this.radPictureBox1.LeftPanel.BottomItems);
        }

        private void CreatePanelButton(string text, RadItemOwnerCollection parent)
        {
            RadButtonElement button = new RadButtonElement(text);
            button.Padding = new System.Windows.Forms.Padding(3);
            button.Click += this.PanelButton_Click;
            parent.Add(button);
        }

        private void PanelButton_Click(object sender, EventArgs e)
        {
            RadButtonElement button = sender as RadButtonElement;
            RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(button.Text + " clicked.");
        }

        private void RadButtonChooseImage_Click(object sender, EventArgs e)
        {
            this.radPictureBox1.LoadImage();
        }

        private void RadDropDownListImageLayout_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radPictureBox1.ImageLayout = (RadImageLayout)this.radDropDownListImageLayout.SelectedValue;
            this.radDropDownListImageAlignment.Enabled = this.radPictureBox1.ImageLayout == RadImageLayout.None;
        }

        private void RadDropDownListImageAlignment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radPictureBox1.ImageAlignment = (ContentAlignment)this.radDropDownListImageAlignment.SelectedValue;
        }

        private void RadCheckBoxShowBorder_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPictureBox1.ShowBorder = this.radCheckBoxShowBorder.IsChecked;
        }

        private void RadCheckBoxShowBackground_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPictureBox1.ShowBackground = this.radCheckBoxShowBackground.IsChecked;
        }

        private void RadCheckBoxEnableContextMenu_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPictureBox1.ContextMenuEnabled = this.radCheckBoxEnableContextMenu.IsChecked;
        }

        private void RadCheckBoxEnableZoom_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPictureBox1.ZoomProperties.AllowZoom = this.radCheckBoxEnableZoom.IsChecked;

            this.radSpinEditorMinZoomFactor.Enabled = this.radPictureBox1.ZoomProperties.AllowZoom;
            this.radSpinEditorMaxZoomFactor.Enabled = this.radPictureBox1.ZoomProperties.AllowZoom;
        }

        private void RadSpinEditorMinZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            this.radPictureBox1.ZoomProperties.MinZoomFactor = (double)this.radSpinEditorMinZoomFactor.Value;
        }

        private void RadSpinEditorMaxZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            this.radPictureBox1.ZoomProperties.MaxZoomFactor = (double)this.radSpinEditorMaxZoomFactor.Value;
        }

        private void RadCheckBoxShowPanels_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBoxShowPanels.IsChecked)
            {
                this.radDropDownListPanelDisplayMode.SelectedValue = PictureBoxPanelDisplayMode.Always;
            }
            else
            {
                this.radDropDownListPanelDisplayMode.SelectedValue = PictureBoxPanelDisplayMode.None;
            }

            this.radDropDownListPanelDisplayMode.Enabled = this.radCheckBoxShowPanels.IsChecked;
        }

        private void RadDropDownListPanelDisplayMode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radPictureBox1.PanelDisplayMode = (PictureBoxPanelDisplayMode)this.radDropDownListPanelDisplayMode.SelectedValue;

            this.radDropDownListPanelOverflowMode.Enabled = this.radPictureBox1.PanelDisplayMode != PictureBoxPanelDisplayMode.None;
        }

        private void RadDropDownListPanelOverflowMode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radPictureBox1.PanelOverflowMode = (PictureBoxPanelOverflowMode)this.radDropDownListPanelOverflowMode.SelectedValue;
        }
    }
}