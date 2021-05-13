using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.SmartLabels
{
    public class DataModel
    {
        public List<KeyValuePair<double, object>> GetPieData()
        {
            List<KeyValuePair<double, object>> data = new List<KeyValuePair<double, object>>();

            data.Add(new KeyValuePair<double, object>(46, "Samsung"));
            data.Add(new KeyValuePair<double, object>(43.5, "Apple"));
            data.Add(new KeyValuePair<double, object>(19, "RIM"));
            data.Add(new KeyValuePair<double, object>(15, "Huawei"));
            data.Add(new KeyValuePair<double, object>(14, "Other"));
            data.Add(new KeyValuePair<double, object>(12, "Siemens"));
            data.Add(new KeyValuePair<double, object>(11.5, "Panasonic"));
            data.Add(new KeyValuePair<double, object>(8, "Nokia"));
            data.Add(new KeyValuePair<double, object>(6.5, "Sony"));
            data.Add(new KeyValuePair<double, object>(3.5, "Fujitsu"));
            data.Add(new KeyValuePair<double, object>(3, "HTC"));
            data.Add(new KeyValuePair<double, object>(2, "Motorola"));

            return data;
        }

        public List<KeyValuePair<double, object>> GetBarData()
        {
            List<KeyValuePair<double, object>> data = new List<KeyValuePair<double, object>>();

            KeyValuePair<double, object> point = new KeyValuePair<double, object>(20.55, "Samsung");
            data.Add(point);
            point = new KeyValuePair<double, object>(20.2, "Apple");
            data.Add(point);
            point = new KeyValuePair<double, object>(19, "Other");
            data.Add(point);
            point = new KeyValuePair<double, object>(15, "Sony");
            data.Add(point);
            point = new KeyValuePair<double, object>(14, "HTC");
            data.Add(point);
            point = new KeyValuePair<double, object>(5.7, "Blackberry");
            data.Add(point);
            point = new KeyValuePair<double, object>(5.55, "Nokia");
            data.Add(point);

            return data;
        }

        public List<KeyValuePair<double, object>> GetLineOneData()
        {
            List<KeyValuePair<double, object>> data = new List<KeyValuePair<double, object>>();

            KeyValuePair<double, object> point = new KeyValuePair<double, object>(400, 2007);
            data.Add(point);
            point = new KeyValuePair<double, object>(550, 2008);
            data.Add(point);
            point = new KeyValuePair<double, object>(740, 2009);
            data.Add(point);
            point = new KeyValuePair<double, object>(940, 2010);
            data.Add(point);
            point = new KeyValuePair<double, object>(1170, 2011);
            data.Add(point);
            point = new KeyValuePair<double, object>(1388, 2012);
            data.Add(point);
            point = new KeyValuePair<double, object>(1540, 2013);
            data.Add(point);
            point = new KeyValuePair<double, object>(1720, 2014);
            data.Add(point);
            point = new KeyValuePair<double, object>(2000, 2015);
            data.Add(point);

            return data;
        }

        public List<KeyValuePair<double, object>> GetLineTwoData()
        {
            List<KeyValuePair<double, object>> data = new List<KeyValuePair<double, object>>();

            KeyValuePair<double, object> point = new KeyValuePair<double, object>(1120, 2007);
            data.Add(point);
            point = new KeyValuePair<double, object>(1240, 2008);
            data.Add(point);
            point = new KeyValuePair<double, object>(1350, 2009);
            data.Add(point);
            point = new KeyValuePair<double, object>(1400, 2010);
            data.Add(point);
            point = new KeyValuePair<double, object>(1490, 2011);
            data.Add(point);
            point = new KeyValuePair<double, object>(1535, 2012);
            data.Add(point);
            point = new KeyValuePair<double, object>(1610, 2013);
            data.Add(point);
            point = new KeyValuePair<double, object>(1680, 2014);
            data.Add(point);
            point = new KeyValuePair<double, object>(1700, 2015);
            data.Add(point);

            return data;
        }

        public List<KeyValuePair<double, double>> GetScatterData()
        {
            List<KeyValuePair<double, double>> data = new List<KeyValuePair<double, double>>();

            KeyValuePair<double, double> point = new KeyValuePair<double, double>(99, 36);
            data.Add(point);
            point = new KeyValuePair<double, double>(57, 11);
            data.Add(point);
            point = new KeyValuePair<double, double>(51, 34);
            data.Add(point);
            point = new KeyValuePair<double, double>(22, 50);
            data.Add(point);
            point = new KeyValuePair<double, double>(95, 35);
            data.Add(point);
            point = new KeyValuePair<double, double>(30, 26);
            data.Add(point);
            point = new KeyValuePair<double, double>(31, 78);
            data.Add(point);
            point = new KeyValuePair<double, double>(79, 87);
            data.Add(point);
            point = new KeyValuePair<double, double>(57, 57);
            data.Add(point);
            point = new KeyValuePair<double, double>(21, 101);
            data.Add(point);
            point = new KeyValuePair<double, double>(20, 66);
            data.Add(point);
            point = new KeyValuePair<double, double>(66, 20);
            data.Add(point);
            point = new KeyValuePair<double, double>(70, 64);
            data.Add(point);
            point = new KeyValuePair<double, double>(91, 72);
            data.Add(point);
            point = new KeyValuePair<double, double>(38, 32);
            data.Add(point);
            point = new KeyValuePair<double, double>(94, 48);
            data.Add(point);
            point = new KeyValuePair<double, double>(20, 51);
            data.Add(point);
            point = new KeyValuePair<double, double>(79, 65);
            data.Add(point);
            point = new KeyValuePair<double, double>(81, 23);
            data.Add(point);
            point = new KeyValuePair<double, double>(60, 43);
            data.Add(point);
            point = new KeyValuePair<double, double>(72, 65);
            data.Add(point);
            point = new KeyValuePair<double, double>(58, 50);
            data.Add(point);
            point = new KeyValuePair<double, double>(36, 80);
            data.Add(point);
            point = new KeyValuePair<double, double>(20, 69);
            data.Add(point);
            point = new KeyValuePair<double, double>(89, 13);
            data.Add(point);
            point = new KeyValuePair<double, double>(34, 90);
            data.Add(point);
            point = new KeyValuePair<double, double>(37, 40);
            data.Add(point);
            point = new KeyValuePair<double, double>(99, 17);
            data.Add(point);
            point = new KeyValuePair<double, double>(88, 81);
            data.Add(point);
            point = new KeyValuePair<double, double>(79, 91);
            data.Add(point);
            point = new KeyValuePair<double, double>(66, 37);
            data.Add(point);
            point = new KeyValuePair<double, double>(26, 96);
            data.Add(point);
            point = new KeyValuePair<double, double>(75, 95);
            data.Add(point);
            point = new KeyValuePair<double, double>(45, 69);
            data.Add(point);
            point = new KeyValuePair<double, double>(84, 98);
            data.Add(point);
            point = new KeyValuePair<double, double>(21, 17);
            data.Add(point);
            point = new KeyValuePair<double, double>(15, 99);
            data.Add(point);
            point = new KeyValuePair<double, double>(51, 20);
            data.Add(point);
            point = new KeyValuePair<double, double>(67, 77);
            data.Add(point);
            point = new KeyValuePair<double, double>(42, 71);
            data.Add(point);
            point = new KeyValuePair<double, double>(16, 29);
            data.Add(point);
            point = new KeyValuePair<double, double>(17, 48);
            data.Add(point);
            point = new KeyValuePair<double, double>(22, 26);
            data.Add(point);
            point = new KeyValuePair<double, double>(23, 52);
            data.Add(point);
            point = new KeyValuePair<double, double>(99, 34);
            data.Add(point);
            
            return data;
        }
    }
}