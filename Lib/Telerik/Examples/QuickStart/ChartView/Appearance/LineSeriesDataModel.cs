using System;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class LineSeriesDataModel
    {
        private IEnumerable<LineAreaSeriesData> s1;
        private IEnumerable<LineAreaSeriesData> s2;
        private IEnumerable<LineAreaSeriesData> s3;
        private IEnumerable<LineAreaSeriesData> s4;
        private IEnumerable<LineAreaSeriesData> s5;
        private IEnumerable<LineAreaSeriesData> s6;
        private IEnumerable<LineAreaSeriesData> s7;
        private IEnumerable<LineAreaSeriesData> s8;

        public IEnumerable<LineAreaSeriesData> S1
        {
            get
            {
                if (this.s1 == null)
                {
                    this.s1 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(30, "May"),
                        new LineAreaSeriesData(20, "Jun"),
                        new LineAreaSeriesData(60, "Jul"),
                        new LineAreaSeriesData(110, "Aug"),
                        new LineAreaSeriesData(150, "Sep"),
                        new LineAreaSeriesData(200, "Oct"),
                        new LineAreaSeriesData(160, "Nov"),
                        new LineAreaSeriesData(150, "Dec"),
                        new LineAreaSeriesData(100, "Jan")
                    };
                }

                return this.s1;
            }
        }

        public IEnumerable<LineAreaSeriesData> S2
        {
            get
            {
                if (this.s2 == null)
                {
                    this.s2 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(70, "May"),
                        new LineAreaSeriesData(60, "Jun"),
                        new LineAreaSeriesData(100, "Jul"),
                        new LineAreaSeriesData(50, "Aug"),
                        new LineAreaSeriesData(60, "Sep"),
                        new LineAreaSeriesData(80, "Oct"),
                        new LineAreaSeriesData(100, "Nov"),
                        new LineAreaSeriesData(80, "Dec"),
                        new LineAreaSeriesData(50, "Jan")
                    };
                }

                return this.s2;
            }
        }

        public IEnumerable<LineAreaSeriesData> S3
        {
            get
            {
                if (this.s3 == null)
                {
                    this.s3 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(150, "May"),
                        new LineAreaSeriesData(170, "Jun"),
                        new LineAreaSeriesData(160, "Jul"),
                        new LineAreaSeriesData(110, "Aug"),
                        new LineAreaSeriesData(200, "Sep"),
                        new LineAreaSeriesData(130, "Oct"),
                        new LineAreaSeriesData(210, "Nov"),
                        new LineAreaSeriesData(210, "Dec"),
                        new LineAreaSeriesData(210, "Jan")
                    };
                }

                return this.s3;
            }
        }

        public IEnumerable<LineAreaSeriesData> S4
        {
            get
            {
                if (this.s4 == null)
                {
                    this.s4 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(190, "May"),
                        new LineAreaSeriesData(210, "Jun"),
                        new LineAreaSeriesData(200, "Jul"),
                        new LineAreaSeriesData(230, "Aug"),
                        new LineAreaSeriesData(230, "Sep"),
                        new LineAreaSeriesData(300, "Oct"),
                        new LineAreaSeriesData(290, "Nov"),
                        new LineAreaSeriesData(280, "Dec"),
                        new LineAreaSeriesData(270, "Jan")
                    };
                }

                return this.s4;
            }
        }

        public IEnumerable<LineAreaSeriesData> S5
        {
            get
            {
                if (this.s5 == null)
                {
                    this.s5 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(280, "May"),
                        new LineAreaSeriesData(260, "Jun"),
                        new LineAreaSeriesData(270, "Jul"),
                        new LineAreaSeriesData(310, "Aug"),
                        new LineAreaSeriesData(270, "Sep"),
                        new LineAreaSeriesData(260, "Oct"),
                        new LineAreaSeriesData(230, "Nov"),
                        new LineAreaSeriesData(250, "Dec"),
                        new LineAreaSeriesData(260, "Jan")
                    };
                }

                return this.s5;
            }
        }

        public IEnumerable<LineAreaSeriesData> S6
        {
            get
            {
                if (this.s6 == null)
                {
                    this.s6 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(330, "May"),
                        new LineAreaSeriesData(320, "Jun"),
                        new LineAreaSeriesData(380, "Jul"),
                        new LineAreaSeriesData(330, "Aug"),
                        new LineAreaSeriesData(330, "Sep"),
                        new LineAreaSeriesData(330, "Oct"),
                        new LineAreaSeriesData(350, "Nov"),
                        new LineAreaSeriesData(340, "Dec"),
                        new LineAreaSeriesData(380, "Jan")
                    };
                }

                return this.s6;
            }
        }

        public IEnumerable<LineAreaSeriesData> S7
        {
            get
            {
                if (this.s7 == null)
                {
                    this.s7 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(420, "May"),
                        new LineAreaSeriesData(410, "Jun"),
                        new LineAreaSeriesData(420, "Jul"),
                        new LineAreaSeriesData(500, "Aug"),
                        new LineAreaSeriesData(450, "Sep"),
                        new LineAreaSeriesData(440, "Oct"),
                        new LineAreaSeriesData(380, "Nov"),
                        new LineAreaSeriesData(420, "Dec"),
                        new LineAreaSeriesData(450, "Jan")
                    };
                }

                return this.s7;
            }
        }

        public IEnumerable<LineAreaSeriesData> S8
        {
            get
            {
                if (this.s8 == null)
                {
                    this.s8 = new List<LineAreaSeriesData>() {
                        new LineAreaSeriesData(450, "May"),
                        new LineAreaSeriesData(440, "Jun"),
                        new LineAreaSeriesData(440, "Jul"),
                        new LineAreaSeriesData(430, "Aug"),
                        new LineAreaSeriesData(420, "Sep"),
                        new LineAreaSeriesData(460, "Oct"),
                        new LineAreaSeriesData(490, "Nov"),
                        new LineAreaSeriesData(460, "Dec"),
                        new LineAreaSeriesData(420, "Jan")
                    };
                }

                return this.s8;
            }
        }

        public IEnumerable<LineAreaSeriesData> GetData(int index)
        {
            if (index == 0)
            {
                return this.S1;
            }

            if (index == 1)
            {
                return this.S2;
            }

            if (index == 2)
            {
                return this.S3;
            }

            if (index == 3)
            {
                return this.S4;
            }

            if (index == 4)
            {
                return this.S5;
            }

            if (index == 5)
            {
                return this.S6;
            }

            if (index == 6)
            {
                return this.S7;
            }

            if (index == 7)
            {
                return this.S8;
            }

            return null;
        }
    }
}
