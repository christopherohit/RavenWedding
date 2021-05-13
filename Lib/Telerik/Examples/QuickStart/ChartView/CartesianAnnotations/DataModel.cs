using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
{
    public class DataModel
    {
        private DataSet dataSet;

        public IEnumerable<CompanyEvent> GetGoogleEventData()
        {
            yield return new CompanyEvent(new DateTime(2007, 11, 1), string.Format("Nov 01, 2007{0}Android is announced", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2008, 9, 1), string.Format("Sep 01, 2008{0}Google introduced new{0}open source browser -{0}Chrome", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2009, 6, 1), string.Format("Jun, 2009{0}The Google Translator{0}Toolkit is released", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2009, 12, 1), string.Format("Dec, 2009{0}New real-time search{0}feature is added", Environment.NewLine), new SizeF(0, 50));
            yield return new CompanyEvent(new DateTime(2010, 3, 1), string.Format("Mar, 2010{0}The Google Apps Market-{0}place is live", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2011, 2, 1), string.Format("Feb, 2011{0}A new search algorithm is{0}implemented", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2011, 6, 1), string.Format("Jun, 2011{0}The Google+ project is{0}launched", Environment.NewLine), new SizeF(0, 50));
        }

        public IEnumerable<CompanyEvent> GetMicrosoftEventData()
        {
            yield return new CompanyEvent(new DateTime(2007, 1, 30), string.Format("Jan 30, 2007{0}Microsoft releases Windows{0}Vista and Office 2007 to the{0}general public", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2008, 10, 27), string.Format("Oct 27, 2008{0}Microsoft launched Azure{0}Services Platform", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2009, 10, 22), string.Format("Oct 22, 2009{0}Microsoft officially released{0}Windows 7", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2011, 2, 11), string.Format("Feb 11, 2011{0}Microsoft in partnership{0}with Nokia", Environment.NewLine), SizeF.Empty);
        }

        public IEnumerable<CompanyEvent> GetAppleEventData()
        {
            yield return new CompanyEvent(new DateTime(2007, 6, 29), string.Format("Jun 29, 2007{0}The first Iphone{0}was released", Environment.NewLine), new SizeF(0, 50));
            yield return new CompanyEvent(new DateTime(2007, 9, 1), string.Format("Sep, 2007{0}iPod touch was released", Environment.NewLine), new SizeF(0, 100));
            yield return new CompanyEvent(new DateTime(2008, 1, 1), string.Format("Jan, 2008{0}MacBook Air - the thinnest{0}Apple laptop was{0}announced", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2010, 1, 27), string.Format("Jan 27, 2010{0}Apple announced a large{0}screen, table-like media{0}device known as the iPad", Environment.NewLine), new SizeF(0, 50));
            yield return new CompanyEvent(new DateTime(2010, 6, 1), string.Format("Jun, 2010{0}Apple introduced iPhone 4", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2011, 3, 1), string.Format("Mar, 2011{0}iPad2 was introduced", Environment.NewLine), new SizeF(0, 100));
            yield return new CompanyEvent(new DateTime(2011, 6, 1), string.Format("Jun, 2011{0}Steve Jobs Unveiled iCloud", Environment.NewLine), new SizeF(0, 50));
            yield return new CompanyEvent(new DateTime(2011, 8, 24), string.Format("Aug 24, 2011{0}Steve Jobs resigned{0}his position as CEO", Environment.NewLine), SizeF.Empty);
        }

        public IEnumerable<CompanyEvent> GetAdobeEventData()
        {
            yield return new CompanyEvent(new DateTime(2007, 3, 27), string.Format("Mar 27, 2007{0}Adobe announced CS3", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2008, 2, 25), string.Format("Feb 25, 2008{0}Adobe AIR was launched", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2008, 10, 15), string.Format("Oct 15, 2008{0}Adobe CS4 was officially{0}released", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2009, 9, 15), string.Format("Sep 15, 2009{0}Adobe acquires Omniture", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2010, 4, 30), string.Format("Apr 30, 2010{0}Adobe CS5 was released", Environment.NewLine), SizeF.Empty);
            yield return new CompanyEvent(new DateTime(2011, 11, 9), string.Format("Nov 09, 2011{0}The development of flash{0}for mobile devices will stop{0}and the focus will be on{0}HTML 5", Environment.NewLine), SizeF.Empty);
        }

        public DataSet GetData()
        {
            return this.dataSet;
        }

        public DataModel()
        {
            this.dataSet = new DataSet();
            this.dataSet.Tables.Add("Google Inc.");
            this.dataSet.Tables.Add("Microsoft Corporation");
            this.dataSet.Tables.Add("Apple Inc.");
            this.dataSet.Tables.Add("Adobe Systems Inc.");

            foreach (DataTable table in this.dataSet.Tables)
            {
                table.Columns.Add("Date", typeof(DateTime));
                table.Columns.Add("Value", typeof(double));
            }

            this.GetData(@"..\ChartView\CartesianAnnotations\USRecessionCompanyData.csv");
        }

        private void GetData(string fileName)
        {
            using (StreamReader fileReader = new StreamReader(fileName))
            {
                this.GetDataCompleted(this.ParseData(fileReader));
            }
        }

        protected void GetDataCompleted(IEnumerable<CompanyStats> data)
        {
            foreach (CompanyStats entry in data)
            {
                this.dataSet.Tables[entry.Name].Rows.Add(entry.Date, entry.Value);
            }
        }

        protected IEnumerable<CompanyStats> ParseData(TextReader dataReader)
        {
            string line;

            while ((line = dataReader.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                string[] data = line.Split(',');

                CompanyStats stat = new CompanyStats();
                stat.Name = data[0].Trim();
                stat.Date = DateTime.Parse(data[1], CultureInfo.InvariantCulture);
                stat.Value = double.Parse(data[2], CultureInfo.InvariantCulture);

                yield return stat;
            }
        }
    }
}
