using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private IDictionary<CinemaMovieInfo, CinemaMovieUserControl> moviesUserControls;

        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.cinemaProgramLabel.Text += DateTime.Now.ToShortDateString();
            this.UpdateLabels();
            this.FilterMovies();

            this.CreatePopupClearButton(this.durationTimeSpanPicker);
            this.CreatePopupClearButton(this.minStartTimeTimeSpanPicker);
        }

        private void CreatePopupClearButton(RadTimeSpanPicker timeSpanPicker)
        {
            TimeSpanPickerDoneButtonElement buttonPanel = (timeSpanPicker.PopupContentElement as RadTimeSpanPickerContentElement).FooterPanel;

            RadButtonElement clearButton = new RadButtonElement("Clear");
            clearButton.Click += ClearButton_Click;
            buttonPanel.LayoutPanel.Children.Add(clearButton);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RadButtonElement button = (RadButtonElement)sender;
            TimeSpanPickerDoneButtonElement buttonPanel = button.FindAncestor<TimeSpanPickerDoneButtonElement>();
            buttonPanel.Owner.SetValueAndClose(null);
        }

        protected override void WireEvents()
        {
            base.WireEvents();
            this.durationTimeSpanPicker.PopupContentElement.ComponentsCreated += PopupContentElement_ComponentsCreated;
        }

        public void SetupMovies()
        {
            this.moviesUserControls = new Dictionary<CinemaMovieInfo, CinemaMovieUserControl>();
            IList<CinemaMovieInfo> movies = CinemaMovieRepository.LoadMovies();
            foreach (CinemaMovieInfo movieInfo in movies)
            {
                CinemaMovieUserControl userControl = new CinemaMovieUserControl(movieInfo);
                this.moviesUserControls.Add(movieInfo, userControl);
            }
        }

        public IDictionary<CinemaMovieInfo, CinemaMovieUserControl> MoviesUserControls
        {
            get
            {
                if (this.moviesUserControls == null)
                {
                    this.SetupMovies();
                }

                return this.moviesUserControls;
            }
        }

        private void MoviesScrollablePanel_RootElement_DpiScaleFactorChanged(object sender, EventArgs e)
        {
            this.ArrangeMovieUserControls();
        }

        private void PopupContentElement_ComponentsCreated(object sender, EventArgs e)
        {
            ITimeSpanPickerContentElement contentElement = sender as ITimeSpanPickerContentElement;
            contentElement.Components.Clear();
            MovieDurationTimeSpanPickerComponent durationComponent = new MovieDurationTimeSpanPickerComponent(contentElement);
            contentElement.Components.Add(durationComponent);
        }

        private void MovieFilterTimeSpanPicker_ValueChanged(object sender, EventArgs e)
        {
            this.FilterMovies();
            this.UpdateLabels();
        }

        private void UpdateLabels()
        {
            TimeSpan? selectedDuration = this.durationTimeSpanPicker.Value;
            TimeSpan? selectedMinStartTime = this.minStartTimeTimeSpanPicker.Value;
            string cinemaProgramHeader = string.Empty;
            if (selectedMinStartTime == null && selectedDuration == null)
            {
                cinemaProgramHeader = "All movies screening today";
            }
            else
            {
                if (selectedMinStartTime != null && selectedDuration == null)
                {
                    if (DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).Date.CompareTo(DateTime.Now.Date) == 0)
                    {
                        cinemaProgramHeader = "Movies starting today after " + DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToShortTimeString();
                    }
                    else
                    {
                        cinemaProgramHeader = "The program for " + DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToString("d") + " is not available yet!";
                    }
                }
                else
                {
                    if (selectedMinStartTime == null)
                    {
                        cinemaProgramHeader = "Movies with minimum duration of " + selectedDuration.Value.TotalMinutes + " minutes";
                    }
                    else
                    {
                        if (DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).Date.CompareTo(DateTime.Now.Date) == 0)
                        {
                            cinemaProgramHeader = "Movies starting today after " + DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToShortTimeString() + " with minimum duration " + selectedDuration.Value.TotalMinutes + " minutes";
                        }
                        else
                        {
                            cinemaProgramHeader = "The program for " + DateTime.Now.AddMinutes(selectedMinStartTime.Value.TotalMinutes).ToString("d") + " is not available yet!";
                        }
                    }
                }
            }

            this.moviesStartingAfterLabel.Text = cinemaProgramHeader;
        }

        private void FilterMovies()
        {
            IList<CinemaMovieInfo> filteredMovies = new List<CinemaMovieInfo>();
            foreach (CinemaMovieInfo movieInfo in this.MoviesUserControls.Keys)
            {
                bool shouldAdd = false;
                TimeSpan? selectedDuration = this.durationTimeSpanPicker.Value;
                TimeSpan? selectedMinStartTime = this.minStartTimeTimeSpanPicker.Value;

                if (selectedMinStartTime != null)
                {
                    shouldAdd = (DateTime.Now + selectedMinStartTime) <= movieInfo.StartTime &&
                        (selectedDuration == null || selectedDuration <= movieInfo.Duration);
                }
                else
                {
                    shouldAdd = selectedDuration == null || selectedDuration <= movieInfo.Duration;
                }

                if (shouldAdd)
                {
                    filteredMovies.Add(movieInfo);
                }
            }

            this.UpdateMovies(filteredMovies);
        }

        private void UpdateMovies(IList<CinemaMovieInfo> filteredMovies)
        {
            foreach (CinemaMovieUserControl control in this.MoviesUserControls.Values)
            {
                control.Visible = false;
            }

            foreach (CinemaMovieInfo movieInfo in filteredMovies)
            {
                CinemaMovieUserControl movieUserControl = this.MoviesUserControls[movieInfo];
                movieUserControl.Visible = true;
                if (!this.moviesScrollablePanel.PanelContainer.Controls.Contains(movieUserControl))
                {
                    this.moviesScrollablePanel.PanelContainer.Controls.Add(movieUserControl);
                }
            }

            this.ArrangeMovieUserControls();
        }

        private void ArrangeMovieUserControls()
        {
            this.moviesScrollablePanel.VerticalScrollbar.Value = 0;

            IOrderedEnumerable<CinemaMovieUserControl> userControls =
                this.moviesScrollablePanel.PanelContainer.Controls.OfType<CinemaMovieUserControl>().
                Where(c => c.Visible == true).
                OrderBy(c => c.MovieInfo.StartTime);

            Point currentLocation = new Point(5, 5);
            int width = this.moviesScrollablePanel.PanelContainer.Width;
            SizeF dpiScaleFactor = new SizeF(1f, 1f);
            if (this.moviesScrollablePanel != null && this.moviesScrollablePanel.RootElement != null)
            {
                dpiScaleFactor = this.moviesScrollablePanel.RootElement.DpiScaleFactor;
            }

            width -= TelerikDpiHelper.ScaleInt(SystemInformation.VerticalScrollBarWidth, dpiScaleFactor);

            foreach (CinemaMovieUserControl movieUserControl in userControls)
            {
                currentLocation.Y += movieUserControl.Margin.Top;
                movieUserControl.Location = currentLocation;
                int controlWidth = width - movieUserControl.Margin.Horizontal;
                movieUserControl.Size = movieUserControl.GetDesiredSize(controlWidth, dpiScaleFactor);
                currentLocation.Y += movieUserControl.Height + movieUserControl.Margin.Bottom;
            }
        }
    }
}