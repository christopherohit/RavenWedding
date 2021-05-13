using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
{
    class ViewModel
    {
        private DataSet dataSet;

        public ViewModel()
        {
            dataSet = new DataSet();
            dataSet.Tables.Add("public");
            dataSet.Tables.Add("private");

            foreach (DataTable table in this.dataSet.Tables)
            {
                table.Columns.Add("Age", typeof(int));
                table.Columns.Add("Wage", typeof(double));
            }

            this.GetData(@"..\ChartView\ChartTypes\Scatter\EarningsPublicvsPrivateByAge.csv");
        }

        public DataSet GetData()
        {
            return this.dataSet;
        }

        private void GetData(string fileName)
        {
            using (StreamReader fileReader = new StreamReader(fileName))
            {
                this.GetDataCompleted(this.ParseData(fileReader));
            }
        }

        protected void GetDataCompleted(IEnumerable<HourlyEarnings> data)
        {
            foreach (HourlyEarnings entry in data)
            {
                this.dataSet.Tables[entry.Sector].Rows.Add(entry.Age, entry.Wage);
            }
        }
        
        protected IEnumerable<HourlyEarnings> ParseData(TextReader dataReader)
        {
            List<HourlyEarnings> chartData = new List<HourlyEarnings>();
            string line;

            while ((line = dataReader.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                string[] data = line.Split(',');
                int age = int.Parse(data[0], CultureInfo.InvariantCulture);
                double wage = double.Parse(data[1], CultureInfo.InvariantCulture);
                string sector = data[2];

                HourlyEarnings hourlyEarningsData = new HourlyEarnings(sector, wage, age);
                chartData.Add(hourlyEarningsData);
            }

            return chartData;
        } 
    }
}
