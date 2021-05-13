using System.Data;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Waterfall
{
    public static class DataModel
    {
        public static DataTable GetData()
        {
            DataTable data = new DataTable("Europe");

            data.Columns.Add("Value", typeof(decimal));
            data.Columns.Add("Category", typeof(string));
            data.Columns.Add("Summary", typeof(bool));
            data.Columns.Add("Total", typeof(bool));

            data.Rows.Add(40000, "Beginning\nBalance", false, false);
            data.Rows.Add(15000, "Jan", false, false);
            data.Rows.Add(14000, "Feb", false, false);
            data.Rows.Add(-5000, "Mar", false, false);
            data.Rows.Add(64000, "Q1", true, false);
            data.Rows.Add(-20000, "Apr", false, false);
            data.Rows.Add(-8000, "May", false, false);
            data.Rows.Add(10000, "Jun", false, false);
            data.Rows.Add(-18000, "Q2", true, false);
            data.Rows.Add(46000, "Ending\nBalance", false, true);

            return data;
        }
    }
}
