using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    public partial class CinemaMovieUserControl : UserControl
    {
        private const int DefaultHeight = 100;
        private CinemaMovieInfo movieInfo;

        public CinemaMovieUserControl(CinemaMovieInfo movieInfo)
        {
            InitializeComponent();

            this.movieInfo = movieInfo;
            this.SynchronizeValues();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            e.Graphics.DrawRectangle(Pens.LightGray, rect);
        }

        public CinemaMovieInfo MovieInfo
        {
            get { return this.movieInfo; }
        }

        private void SynchronizeValues()
        {
            this.imageLabel.Image = this.movieInfo.GenreIcon;
            this.movieNameLabel.Text = this.movieInfo.Title;
            this.genreLabel.Text = this.movieInfo.Genre;
            this.descriptionLabel.Text = this.movieInfo.Description;
            this.startTimeLabel.Text = string.Format("Start Time - {0:t}", this.movieInfo.StartTime);
            this.durationLabel.Text = string.Format("Duration - {0:t}", this.movieInfo.Duration);
        }

        public Size GetDesiredSize(int maximalWidth, SizeF dpiScaleFactor)
        {
            int height = TelerikDpiHelper.ScaleInt(DefaultHeight, dpiScaleFactor);
            int labelMaxWidth = maximalWidth - this.Padding.Horizontal - this.imageLabel.Width;
            labelMaxWidth = TelerikDpiHelper.ScaleInt(labelMaxWidth, new SizeF(1 / dpiScaleFactor.Width, 1 / dpiScaleFactor.Height));

            this.descriptionLabel.MaximumSize = new Size(labelMaxWidth, 0);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();

            return new Size(maximalWidth, this.descriptionLabel.Height + height);
        }
    }
}
