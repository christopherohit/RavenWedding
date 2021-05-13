using System.Data;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bubble
{
    public static class DataModel
    {
        public static DataSet GetData()
        {
            DataSet result = new DataSet();

            DataTable tableEurope = new DataTable("Europe");
            DataTable tableNorthAmerica = new DataTable("NorthAmerica");
            DataTable tableMiddleEast = new DataTable("MiddleEast");

            tableEurope.Columns.Add("Country", typeof(string));
            tableEurope.Columns.Add("LifeExpectancy", typeof(double));
            tableEurope.Columns.Add("FertilityRate", typeof(double));
            tableEurope.Columns.Add("Population", typeof(int));

            tableNorthAmerica.Columns.Add("Country", typeof(string));
            tableNorthAmerica.Columns.Add("LifeExpectancy", typeof(double));
            tableNorthAmerica.Columns.Add("FertilityRate", typeof(double));
            tableNorthAmerica.Columns.Add("Population", typeof(int));

            tableMiddleEast.Columns.Add("Country", typeof(string));
            tableMiddleEast.Columns.Add("LifeExpectancy", typeof(double));
            tableMiddleEast.Columns.Add("FertilityRate", typeof(double));
            tableMiddleEast.Columns.Add("Population", typeof(int));

            tableEurope.Rows.Add("Russia", 68.6d, 1.54d, 141850000);
            tableEurope.Rows.Add("Danmark", 78.6d, 1.84d, 5523095);
            tableEurope.Rows.Add("Great Britain", 80.05d, 2.0d, 61801570);
            tableEurope.Rows.Add("Germany", 79.84d, 1.36d, 81902307);

            tableNorthAmerica.Rows.Add("USA", 78.09d, 2.05d, 307007000);
            tableNorthAmerica.Rows.Add("Canada", 80.66d, 1.67d, 33739900);

            tableMiddleEast.Rows.Add("Iraq", 68.09d, 4.77d, 31090763);
            tableMiddleEast.Rows.Add("Egypt", 72.73d, 2.78d, 79716203);
            tableMiddleEast.Rows.Add("Iran", 72.49d, 1.7d, 73137148);
            tableMiddleEast.Rows.Add("Israel", 81.55d, 2.96d, 7485600);

            result.Tables.Add(tableEurope);
            result.Tables.Add(tableNorthAmerica);
            result.Tables.Add(tableMiddleEast);

            return result;
        }
    }
}
