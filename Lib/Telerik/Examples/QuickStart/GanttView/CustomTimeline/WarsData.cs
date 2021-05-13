using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
{
    public class WarsData
    {
        private DataTable wars;

        public DataTable Wars
        {
            get 
            {
                if (this.wars == null)
                {
                    this.wars = this.LoadWarData();
                }

                return wars; 
            }
        }

        private DataTable LoadWarData()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Title", typeof(string));
            result.Columns.Add("Start", typeof(DateTime));
            result.Columns.Add("End", typeof(DateTime));
            result.Columns.Add("Casualties", typeof(int));

            result.Rows.Add("The War of a Thousand Days", new DateTime(1899, 10, 17), new DateTime(1902, 11, 22), 100000);
            result.Rows.Add("Russo-Japanese war", new DateTime(1904, 2, 8), new DateTime(1905, 9, 6), 151831);
            result.Rows.Add("Mexican Revolution", new DateTime(1910, 10, 20), new DateTime(1920, 10, 20), 125000);
            result.Rows.Add("World War I", new DateTime(1914, 7, 28), new DateTime(1918, 11, 11), 10670868);
            result.Rows.Add("Russian Revolution and Civil War", new DateTime(1917, 10, 25), new DateTime(1922, 10, 25), 802225);
            result.Rows.Add("Polish-Soviet War", new DateTime(1919, 2, 14), new DateTime(1922, 3, 18), 100000);
            result.Rows.Add("Northern Expedition", new DateTime(1926, 7, 9), new DateTime(1928, 12, 31), 126500);
            result.Rows.Add("Communists vs Kuomintang", new DateTime(1930, 4, 12), new DateTime(1935, 12, 31), 500000);
            result.Rows.Add("Spanish Civil War", new DateTime(1936, 7, 17), new DateTime(1939, 4, 1), 466300);
            result.Rows.Add("Second Sino-Japanese War", new DateTime(1937, 7, 7), new DateTime(1945, 9, 9), 1000000);
            result.Rows.Add("The Winter War in Finland", new DateTime(1939, 11, 30), new DateTime(1940, 3, 13), 151798);
            result.Rows.Add("World War II", new DateTime(1939, 9, 1), new DateTime(1945, 9, 2), 50000000);
            result.Rows.Add("Chinese Civil War", new DateTime(1946, 3, 31), new DateTime(1950, 5, 1), 1200000);
            result.Rows.Add("First Indochina War Comm. vs France", new DateTime(1946, 12, 19), new DateTime(1954, 8, 1), 269500);
            result.Rows.Add("Indian Partition Communal Violence", new DateTime(1947, 8, 14), new DateTime(1948, 2, 4), 200000);
            result.Rows.Add("Korean War", new DateTime(1950, 6, 25), new DateTime(1953, 7, 27), 995000);
            result.Rows.Add("Algerian War of Independence", new DateTime(1954, 11, 1), new DateTime(1962, 3, 19), 182526);
            result.Rows.Add("Vietnam Civil War", new DateTime(1959, 4, 1), new DateTime(1963, 11, 1), 164923);
            result.Rows.Add("Vietnam War", new DateTime(1955, 11, 1), new DateTime(1975, 4, 30), 2048050);
            result.Rows.Add("Cambodian Civil War", new DateTime(1967, 3, 11), new DateTime(1975, 4, 17), 246204);
            result.Rows.Add("Chinese Cultural Revolution", new DateTime(1967, 1, 3), new DateTime(1976, 9, 9), 2050000);
            result.Rows.Add("Lebanese Civil War", new DateTime(1975, 4, 13), new DateTime(1990, 10, 13), 144000);
            result.Rows.Add("Angolan Gvt vs UNITA Guerilla", new DateTime(1975, 11, 11), new DateTime(2002, 4, 4), 157400);
            result.Rows.Add("Afghanistan Civil War", new DateTime(1978, 4, 27), new DateTime(2001, 10, 7), 121536);
            result.Rows.Add("Mozambique Govt vs Guerilla", new DateTime(1977, 5, 30), new DateTime(1992, 10, 4), 115600);
            result.Rows.Add("Iran vs Iraq", new DateTime(1980, 9, 22), new DateTime(1988, 8, 20), 644500);
            result.Rows.Add("Uganda Civil War", new DateTime(1981, 1, 11), new DateTime(1986, 12, 31), 116044);
            result.Rows.Add("Rwanda Civil War", new DateTime(1990, 10, 1), new DateTime(1994, 7, 4), 527145);
            result.Rows.Add("First and Second Congo Wars", new DateTime(1996, 8, 31), new DateTime(2003, 7, 18), 208367);

            return result;
        }
    }
}
