using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    public partial class SparklineUserControl : UserControl
    {
        private CallType callType;
        private Timer timer;
        private SparkCartesianSeries series;
        private CalleeViewModel owner;

        public SparklineUserControl()
        {
            InitializeComponent();

            FontFamily webUIFont = ThemeResolutionService.GetCustomFont("TelerikWebUI");
            this.alertLabel.LabelElement.CustomFont = webUIFont.Name;
            this.alertLabel.LabelElement.CustomFontSize = 8;
            this.alertLabel.ForeColor = Color.Red;
            this.alertLabel.Text = "\ue403";

            this.timeLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            this.timer = new Timer();
            this.timer.Interval = 750;
            this.timer.Tick += this.Timer_Tick;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CalleeViewModel Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (this.owner != value)
                {
                    this.owner = value;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CallType CallType
        {
            get
            {
                return this.callType;
            }
            set
            {
                if (this.callType != value || this.radSparkline1.Series == null)
                {
                    this.timer.Stop();

                    this.callType = value;
                    this.CreateSeries();
                    this.UpdateSeriesStyles();

                    this.timer.Start();
                }
            }
        }

        public override string ToString()
        {
            switch (this.CallType)
            {
                case CallType.Duration:
                    return "Call Duration";
                case CallType.HoldTime:
                    return "Hold Time";
                case CallType.ResolvedIssues:
                    return "Issues Resolved"; ;
                default:
                    return base.ToString();
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Owner == null)
            {
                return;
            }

            this.Owner.AddRandomCall();

            if (this.CallType == CallType.Duration)
            {
                this.alertLabel.LabelElement.Visibility = this.Owner.AverageDuration.Minutes >= 20 ? ElementVisibility.Visible : ElementVisibility.Hidden;
                this.timeLabel.Text = this.Owner.AverageDuration.ToString();
                this.timeLabel.ForeColor = this.Owner.AverageDuration.Minutes >= 20 ? Color.Red : Color.Empty;
            }
            else if (this.CallType == CallType.HoldTime)
            {
                this.alertLabel.LabelElement.Visibility = this.Owner.AverageHoldTime.Minutes >= 10 ? ElementVisibility.Visible : ElementVisibility.Hidden;
                this.timeLabel.Text = this.Owner.AverageHoldTime.ToString();
                this.timeLabel.ForeColor = this.Owner.AverageHoldTime.Minutes >= 10 ? Color.Red : Color.Empty;
            }
        }

        private void CreateSeries()
        {
            this.radSparkline1.Series = null;
            this.series = this.GetSeries();
            this.series.ValueMember = this.GetValueMember(this.CallType);
            this.series.DataSource = this.Owner.Calls;

            this.radSparkline1.Series = series;
        }

        private SparkCartesianSeries GetSeries()
        {
            switch (this.CallType)
            {
                case CallType.Duration:
                case CallType.HoldTime:
                    return new SparkLineSeries();
                case CallType.ResolvedIssues:
                    SparkWinLossSeries winLoss = new SparkWinLossSeries();
                    winLoss.ShowNegativePointIndicators = true;
                    return winLoss;
                default:
                    return new SparkLineSeries();
            }
        }

        private string GetValueMember(CallType callType)
        {
            switch (callType)
            {
                case CallType.Duration:
                    return "DurationSeconds";
                case CallType.HoldTime:
                    return "HoldTimeSeconds";
                case CallType.ResolvedIssues:
                    return "IssueResolved"; ;
                default:
                    return string.Empty;
            }
        }

        private void UpdateSeriesStyles()
        {
            if (this.CallType == CallType.ResolvedIssues)
            {
                this.alertLabel.Visible = false;
                this.timeLabel.Visible = false;
                this.radSparkline1.View.Margin = new Padding(0, 5, 0, 5);
            }
            else
            {
                this.alertLabel.Visible = true;
                this.timeLabel.Visible = true;
                this.radSparkline1.View.Margin = new Padding(5);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            this.timer.Tick -= this.Timer_Tick;

            base.Dispose(disposing);
        }
    }

    public enum CallType
    {
        Duration,
        HoldTime,
        ResolvedIssues
    }
}
