using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PictureBoxExamples.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private IList<RadPictureBox> pictureBoxes;
        private RadPanel overlayPanel;
        private RadPictureBox previewPictureBox;

        private IList<RadSvgImage> insertSvgs;
        private IList<RadSvgImage> pageLayoutSvgs;
        private IList<RadSvgImage> mailingSvgs;

        public Form1()
        {
            this.InitializeSvgs();

            this.InitializeComponent();
            this.CenterPanel = true;

            this.InitializeOverlay();

            this.radLabelApplicationAlbums.ForeColor = MainForm.AccentColor;

            this.SetupButton(this.radButtonAddImage.ButtonElement, "", "Add Image");
            this.SetupButton(this.radButtonSaveImage.ButtonElement, "", "Save Image");
            this.SetupButton(this.radButtonDownloadImage.ButtonElement, "", "Download Image");

            this.pictureBoxes = new List<RadPictureBox>();
            for (int i = 0; i < 12; i++)
            {
                this.AddPictureBox();
            }

            this.radButtonAddAlbum.ButtonElement.ToolTipText = "Add New Album";
            this.radButtonAddAlbum.SvgImage = RadSvgImage.FromByteArray(Resources.symbol_add_SVG);
            this.radButtonAllAlbums.SvgImage = RadSvgImage.FromByteArray(Resources.pictures_SVG);

            this.RadButtonAllAlbums_Click(null, EventArgs.Empty);
        }

        private IList<RadSvgImage> AllSvgs
        {
            get
            {
                List<RadSvgImage> allImages = new List<RadSvgImage>();
                allImages.AddRange(this.insertSvgs.Take(4));
                allImages.AddRange(this.pageLayoutSvgs.Take(4));
                allImages.AddRange(this.mailingSvgs.Take(4));
                return allImages;
            }
        }

        private void InitializeSvgs()
        {
            this.insertSvgs = new List<RadSvgImage>();
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.InserthyperlinkModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.PictureModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.NewCommentModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.CodeBlockModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.InsertTableModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.EditHeaderModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.EditFooterModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.PageBreakModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.InsertBookmarkModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.InsertDateTimeModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.InsertPageNumberModern32Svg));
            this.insertSvgs.Add(RadSvgImage.FromByteArray(Resources.SymbolModern32Svg));

            this.pageLayoutSvgs = new List<RadSvgImage>();
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.WatermarkModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.PageSizeModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.PageMarginModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.ColumnBreakModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.ContinuousSectionBreakModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.LineBreakModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.NextPageSectionBreakModern32Svg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.OneModernSvg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.TwoModernSvg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.ThreeModernSvg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.LeftModernSvg));
            this.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(Resources.RightModernSvg));

            this.mailingSvgs = new List<RadSvgImage>();
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.MailMergeModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.InsertMergeFieldModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.HighlightMergeFieldsModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.ShowAllFieldsCodesModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.ShowAllFieldsDisplayNamesModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.ShowAllFieldsResultsModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.FirstModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.PreviousModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.NextModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.LastModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.AcceptChangeModern32Svg));
            this.mailingSvgs.Add(RadSvgImage.FromByteArray(Resources.RejectChangeModern32Svg));
        }

        private void InitializeOverlay()
        {
            this.overlayPanel = new RadPanel();
            this.overlayPanel.RootElement.EnableElementShadow = false;
            this.overlayPanel.Parent = this.radPanelDemoHolder;
            this.overlayPanel.BringToFront();
            this.overlayPanel.Dock = DockStyle.Fill;
            this.overlayPanel.BackColor = Color.FromArgb(197, 197, 197);
            this.overlayPanel.Click += this.CloseButton_Click;
            this.overlayPanel.PanelElement.ToolTipText = "Close image";

            RadButton closeButton = new RadButton();
            this.SetupButton(closeButton.ButtonElement, "", "Close image");
            closeButton.Padding = new Padding(0, 2, 0, 0);
            closeButton.Size = new Size(24, 24);
            closeButton.Parent = this.overlayPanel;
            closeButton.Location = new Point(this.overlayPanel.Width - closeButton.Width - 5, 5);
            closeButton.Click += this.CloseButton_Click;

            this.previewPictureBox = new RadPictureBox();
            this.previewPictureBox.ShowBackground = true;
            this.previewPictureBox.ShowBorder = true;
            this.previewPictureBox.Parent = this.overlayPanel;
            this.previewPictureBox.Location = new Point(30, 30);
            this.previewPictureBox.Width = this.overlayPanel.Width - 60;
            this.previewPictureBox.Height = this.overlayPanel.Height + this.doubleBufferedTableLayoutPanel1.Height - 60;

            this.HideOverlay();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.HideOverlay();
        }

        private void ShowOverlay(RadPictureBox clickedPictureBox)
        {
            this.previewPictureBox.Image = clickedPictureBox.Image;
            this.previewPictureBox.SvgImage = clickedPictureBox.SvgImage;
            this.previewPictureBox.Tag = clickedPictureBox;

            this.doubleBufferedTableLayoutPanel1.Hide();
            this.overlayPanel.Show();
        }

        private void HideOverlay()
        {
            this.overlayPanel.Hide();
            this.doubleBufferedTableLayoutPanel1.Show();

            RadPictureBox clickedPictureBox = (RadPictureBox)this.previewPictureBox.Tag;
            if (clickedPictureBox != null)
            {
                clickedPictureBox.Image = this.previewPictureBox.Image;
                clickedPictureBox.SvgImage = this.previewPictureBox.SvgImage;
                clickedPictureBox.ZoomProperties.ZoomFactor = 2;
                clickedPictureBox.CallOnMouseLeave(EventArgs.Empty); // to hide the panel with two buttons we must call the MouseLeave event
            }

            this.previewPictureBox.Image = null;
            this.previewPictureBox.SvgImage = null;
        }

        private void SetupButton(RadButtonElement button, string glyph, string tooltipText)
        {
            button.TextElement.CustomFont = "TelerikWebUI";
            button.Text = glyph;
            button.ToolTipText = tooltipText;
        }

        private RadPictureBox AddPictureBox()
        {
            RadPictureBox pictureBox = new RadPictureBox();
            RadButtonElement shareButton = new RadButtonElement();
            this.SetupButton(shareButton, "", "Share Image");
            shareButton.Padding = new Padding(1);
            shareButton.Click += this.ShareButton_Click;
            shareButton.EnableElementShadow = false;
            pictureBox.TopPanel.RightItems.Add(shareButton);

            RadButtonElement deleteButton = new RadButtonElement();
            this.SetupButton(deleteButton, "", "Delete Image");
            deleteButton.Padding = new Padding(1);
            deleteButton.Click += this.RemoveButton_Click;
            deleteButton.EnableElementShadow = false;
            pictureBox.TopPanel.RightItems.Add(deleteButton);

            pictureBox.TopPanel.DrawFill = false;
            pictureBox.TopPanel.DrawBorder = false;

            pictureBox.TopPanel.RightElementsStack.Padding = new Padding(1);
            pictureBox.TopPanel.RightElementsStack.DrawFill = true;
            pictureBox.TopPanel.RightElementsStack.BackColor = Color.FromArgb(100, Color.Black);

            pictureBox.Cursor = Cursors.Hand;
            pictureBox.PictureBoxElement.ToolTipText = "Open image";
            pictureBox.ContextMenuEnabled = false;
            pictureBox.ZoomProperties.AllowZoom = false;
            pictureBox.ImageLayout = RadImageLayout.FitIntoBounds;
            pictureBox.Size = new Size(150, 100);
            pictureBox.Margin = new Padding(10);
            pictureBox.Parent = this.doubleBufferedFlowLayoutPanel1;
            pictureBox.ThemeName = this.CurrentThemeName;
            pictureBox.ShowBorder = true;
            pictureBox.ShowBackground = true;
            pictureBox.Click += this.PictureBox_Click;

            this.pictureBoxes.Add(pictureBox);
            pictureBox.SvgImage = this.pictureBoxes[0].SvgImage;
            pictureBox.ZoomProperties.ZoomFactor = 2;

            this.radScrollablePanel1.VerticalScrollbar.Value = this.radScrollablePanel1.VerticalScrollbar.Maximum;

            return pictureBox;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            RadPictureBox clickedPictureBox = (RadPictureBox)sender;
            Point clientPoint = clickedPictureBox.PointToClient(Control.MousePosition);
            RadButtonElement itemUnderMouse = clickedPictureBox.ElementTree.GetElementAtPoint<RadButtonElement>(clientPoint);
            if (itemUnderMouse != null)
            {
                // Clicked on Share or Remove button.
                return;
            }

            this.ShowOverlay(clickedPictureBox);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RadTaskDialogPage page = new RadTaskDialogPage();
            page.Icon = RadTaskDialogIcon.ShieldWarningYellowBar;
            page.Caption = "Delete Image Warning";
            page.Heading = "Are you sure you want to delete the image?";
            page.Text = "Deleting the image will remove it from this album and you will no longer be able to restore it!";
            page.AllowCancel = true;
            page.CommandAreaButtons.Add(RadTaskDialogButton.Yes);
            RadTaskDialogButton noButton = RadTaskDialogButton.No;
            page.CommandAreaButtons.Add(noButton);
            page.DefaultButton = noButton;

            RadTaskDialog.CurrentForm.ThemeName = this.CurrentThemeName;
            RadTaskDialogButton clickedButton = RadTaskDialog.ShowDialog(this, page);
            if (clickedButton == null || clickedButton != RadTaskDialogButton.Yes)
            {
                return;
            }

            RadButtonElement removeButton = sender as RadButtonElement;
            RadPictureBox pictureBox = removeButton.ElementTree.Control as RadPictureBox;
            if (this.insertSvgs.Contains(pictureBox.SvgImage))
            {
                this.insertSvgs.Remove(pictureBox.SvgImage);
            }
            else if (this.pageLayoutSvgs.Contains(pictureBox.SvgImage))
            {
                this.pageLayoutSvgs.Remove(pictureBox.SvgImage);
            }
            else if (this.mailingSvgs.Contains(pictureBox.SvgImage))
            {
                this.mailingSvgs.Remove(pictureBox.SvgImage);
            }

            this.pictureBoxes.Remove(pictureBox);
            this.doubleBufferedFlowLayoutPanel1.Controls.Remove(pictureBox);
        }

        private void UpdateImages(IList<RadSvgImage> svgImages)
        {
            int maxIndex = Math.Min(svgImages.Count, this.pictureBoxes.Count);
            for (int index = 0; index < maxIndex; index++)
            {
                RadPictureBox pictureBox = this.pictureBoxes[index];
                pictureBox.SvgImage = svgImages[index];
                pictureBox.ZoomProperties.ZoomFactor = 2;
            }
        }

        private void RadButtonAddAlbum_Click(object sender, EventArgs e)
        {
            this.radButtonNewAlbum.Show();
            this.radButtonNewAlbum.PerformClick();
            this.radButtonAddAlbum.Enabled = false;
        }

        private void RadButtonAllAlbums_Click(object sender, EventArgs e)
        {
            this.radLabelSelectedAlbum.Text = "All";

            this.UpdateImages(this.AllSvgs);
        }

        private void RadButtonInsertAlbum_Click(object sender, EventArgs e)
        {
            this.radLabelSelectedAlbum.Text = "Insert";

            this.UpdateImages(this.insertSvgs);
        }

        private void RadButtonPageLayoutAlbum_Click(object sender, EventArgs e)
        {
            this.radLabelSelectedAlbum.Text = "Page Layout";

            this.UpdateImages(this.pageLayoutSvgs);
        }

        private void RadButtonMailingsAlbum_Click(object sender, EventArgs e)
        {
            this.radLabelSelectedAlbum.Text = "Mailings";

            this.UpdateImages(this.mailingSvgs);
        }

        private void RadButtonNewAlbum_Click(object sender, EventArgs e)
        {
            this.radLabelSelectedAlbum.Text = "New Album";

            this.UpdateImages(this.AllSvgs);
        }

        private void RadButtonAddImage_Click(object sender, EventArgs e)
        {
            this.AddPictureBox();
        }

        private void RadButtonSaveImage_Click(object sender, EventArgs e)
        {
            RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(this, "Save button clicked.", "RadPictureBox");
        }

        private void RadButtonDownloadImage_Click(object sender, EventArgs e)
        {
            RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(this, "Download button clicked.", "RadPictureBox");
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(this, "Share button clicked.", "RadPictureBox");
        }
    }
}