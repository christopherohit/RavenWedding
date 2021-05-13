using System;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class AreaSeriesDataModel
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
                        new LineAreaSeriesData(50, "May"),
                        new LineAreaSeriesData(40, "Jun"),
                        new LineAreaSeriesData(80, "Jul"),
                        new LineAreaSeriesData(30, "Aug"),
                        new LineAreaSeriesData(50, "Sep"),
                        new LineAreaSeriesData(60, "Oct"),
                        new LineAreaSeriesData(90, "Nov"),
                        new LineAreaSeriesData(60, "Dec"),
                        new LineAreaSeriesData(50, "Jan")
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
                        new LineAreaSeriesData(150, "May"),
                        new LineAreaSeriesData(90, "Jun"),
                        new LineAreaSeriesData(140, "Jul"),
                        new LineAreaSeriesData(140, "Aug"),
                        new LineAreaSeriesData(160, "Sep"),
                        new LineAreaSeriesData(130, "Oct"),
                        new LineAreaSeriesData(100, "Nov"),
                        new LineAreaSeriesData(140, "Dec"),
                        new LineAreaSeriesData(130, "Jan")
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
                        new LineAreaSeriesData(180, "May"),
                        new LineAreaSeriesData(200, "Jun"),
                        new LineAreaSeriesData(190, "Jul"),
                        new LineAreaSeriesData(170, "Aug"),
                        new LineAreaSeriesData(220, "Sep"),
                        new LineAreaSeriesData(180, "Oct"),
                        new LineAreaSeriesData(200, "Nov"),
                        new LineAreaSeriesData(150, "Dec"),
                        new LineAreaSeriesData(160, "Jan")
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
                        new LineAreaSeriesData(210, "May"),
                        new LineAreaSeriesData(230, "Jun"),
                        new LineAreaSeriesData(220, "Jul"),
                        new LineAreaSeriesData(270, "Aug"),
                        new LineAreaSeriesData(270, "Sep"),
                        new LineAreaSeriesData(250, "Oct"),
                        new LineAreaSeriesData(230, "Nov"),
                        new LineAreaSeriesData(230, "Dec"),
                        new LineAreaSeriesData(200, "Jan")
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
                        new LineAreaSeriesData(310, "May"),
                        new LineAreaSeriesData(300, "Jun"),
                        new LineAreaSeriesData(320, "Jul"),
                        new LineAreaSeriesData(350, "Aug"),
                        new LineAreaSeriesData(320, "Sep"),
                        new LineAreaSeriesData(320, "Oct"),
                        new LineAreaSeriesData(300, "Nov"),
                        new LineAreaSeriesData(330, "Dec"),
                        new LineAreaSeriesData(310, "Jan")
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
                        new LineAreaSeriesData(360, "May"),
                        new LineAreaSeriesData(420, "Jun"),
                        new LineAreaSeriesData(370, "Jul"),
                        new LineAreaSeriesData(370, "Aug"),
                        new LineAreaSeriesData(370, "Sep"),
                        new LineAreaSeriesData(360, "Oct"),
                        new LineAreaSeriesData(350, "Nov"),
                        new LineAreaSeriesData(400, "Dec"),
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
                        new LineAreaSeriesData(450, "May"),
                        new LineAreaSeriesData(440, "Jun"),
                        new LineAreaSeriesData(450, "Jul"),
                        new LineAreaSeriesData(440, "Aug"),
                        new LineAreaSeriesData(430, "Sep"),
                        new LineAreaSeriesData(380, "Oct"),
                        new LineAreaSeriesData(400, "Nov"),
                        new LineAreaSeriesData(420, "Dec"),
                        new LineAreaSeriesData(430, "Jan")
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
                        new LineAreaSeriesData(480, "May"),
                        new LineAreaSeriesData(470, "Jun"),
                        new LineAreaSeriesData(470, "Jul"),
                        new LineAreaSeriesData(500, "Aug"),
                        new LineAreaSeriesData(480, "Sep"),
                        new LineAreaSeriesData(480, "Oct"),
                        new LineAreaSeriesData(430, "Nov"),
                        new LineAreaSeriesData(450, "Dec"),
                        new LineAreaSeriesData(480, "Jan")
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
