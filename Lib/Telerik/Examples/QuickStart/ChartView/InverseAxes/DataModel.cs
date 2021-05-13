using System;
using System.Collections.Generic;
using System.Data;

namespace Telerik.Examples.WinControls.ChartView.InverseAxes
{
    public class DataModel
    {
        public DataSet GetRawData()
        {
            DataSet result = new DataSet();

            DataTable tableDryHoles = new DataTable("DryHoles");
            DataTable tableNaturalGas = new DataTable("NaturalGas");
            DataTable tableCrudeOil = new DataTable("CrudeOil");

            tableDryHoles.Columns.Add("Time", typeof(DateTime));
            tableDryHoles.Columns.Add("Depth", typeof(double));

            tableNaturalGas.Columns.Add("Time", typeof(DateTime));
            tableNaturalGas.Columns.Add("Depth", typeof(double));

            tableCrudeOil.Columns.Add("Time", typeof(DateTime));
            tableCrudeOil.Columns.Add("Depth", typeof(double));

            foreach (WellDrillData data in this.GetDryHolesDrillData())
            {
                tableDryHoles.Rows.Add(data.Date, data.Depth);
            }

            foreach (WellDrillData data in this.GetNaturalGasDrillData())
            {
                tableNaturalGas.Rows.Add(data.Date, data.Depth);
            }

            foreach (WellDrillData data in this.GetCrudeOilDrillData())
            {
                tableCrudeOil.Rows.Add(data.Date, data.Depth);
            }

            result.Tables.Add(tableDryHoles);
            result.Tables.Add(tableNaturalGas);
            result.Tables.Add(tableCrudeOil);

            return result;
        }

        public DataTable GetAggregatedData()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("AverageDepth", typeof(double));
            result.Columns.Add("MaximumDepth", typeof(double));

            result.Rows.Add("Dry Holes", Average(this.GetDryHolesDrillData()), Maximum(this.GetDryHolesDrillData()));
            result.Rows.Add("Natural Gas", Average(this.GetNaturalGasDrillData()), Maximum(this.GetNaturalGasDrillData()));
            result.Rows.Add("Crude Oil", Average(this.GetCrudeOilDrillData()), Maximum(this.GetCrudeOilDrillData()));

            return result;
        }

        private List<WellDrillData> GetDryHolesDrillData()
        {
            return new List<WellDrillData>()
			{
				new WellDrillData { Date = new DateTime(1949, 06, 30), Depth = 3225.0 },
				new WellDrillData { Date = new DateTime(1950, 06, 30), Depth = 3077.0 },
				new WellDrillData { Date = new DateTime(1951, 06, 30), Depth = 3255.0 },
				new WellDrillData { Date = new DateTime(1952, 06, 30), Depth = 3520.0 },
				new WellDrillData { Date = new DateTime(1953, 06, 30), Depth = 3401.0 },
				new WellDrillData { Date = new DateTime(1954, 06, 30), Depth = 3512.0 },
				new WellDrillData { Date = new DateTime(1955, 06, 30), Depth = 3699.0 },
				new WellDrillData { Date = new DateTime(1956, 06, 30), Depth = 3574.0 },
				new WellDrillData { Date = new DateTime(1957, 06, 30), Depth = 3605.0 },
				new WellDrillData { Date = new DateTime(1958, 06, 30), Depth = 3631.0 },
				new WellDrillData { Date = new DateTime(1959, 06, 30), Depth = 3844.0 },
				new WellDrillData { Date = new DateTime(1960, 06, 30), Depth = 3889.0 },
				new WellDrillData { Date = new DateTime(1961, 06, 30), Depth = 3782.0 },
				new WellDrillData { Date = new DateTime(1962, 06, 30), Depth = 4239.0 },
				new WellDrillData { Date = new DateTime(1963, 06, 30), Depth = 4143.0 },
				new WellDrillData { Date = new DateTime(1964, 06, 30), Depth = 4207.0 },
				new WellDrillData { Date = new DateTime(1965, 06, 30), Depth = 4446.0 },
				new WellDrillData { Date = new DateTime(1966, 06, 30), Depth = 3900.0 },
				new WellDrillData { Date = new DateTime(1967, 06, 30), Depth = 3901.0 },
				new WellDrillData { Date = new DateTime(1968, 06, 30), Depth = 4311.0 },
				new WellDrillData { Date = new DateTime(1969, 06, 30), Depth = 4437.0 },
				new WellDrillData { Date = new DateTime(1970, 06, 30), Depth = 4714.0 },
				new WellDrillData { Date = new DateTime(1971, 06, 30), Depth = 4633.0 },
				new WellDrillData { Date = new DateTime(1972, 06, 30), Depth = 4725.0 },
				new WellDrillData { Date = new DateTime(1973, 06, 30), Depth = 4851.0 },
				new WellDrillData { Date = new DateTime(1974, 06, 30), Depth = 4599.0 },
				new WellDrillData { Date = new DateTime(1975, 06, 30), Depth = 4415.0 },
				new WellDrillData { Date = new DateTime(1976, 06, 30), Depth = 4439.0 },
				new WellDrillData { Date = new DateTime(1977, 06, 30), Depth = 4662.0 },
				new WellDrillData { Date = new DateTime(1978, 06, 30), Depth = 4600.0 },
				new WellDrillData { Date = new DateTime(1979, 06, 30), Depth = 4517.0 },
				new WellDrillData { Date = new DateTime(1980, 06, 30), Depth = 4214.0 },
				new WellDrillData { Date = new DateTime(1981, 06, 30), Depth = 4226.0 },
				new WellDrillData { Date = new DateTime(1982, 06, 30), Depth = 4184.0 },
				new WellDrillData { Date = new DateTime(1983, 06, 30), Depth = 3974.0 },
				new WellDrillData { Date = new DateTime(1984, 06, 30), Depth = 4205.0 },
				new WellDrillData { Date = new DateTime(1985, 06, 30), Depth = 4306.0 },
				new WellDrillData { Date = new DateTime(1986, 06, 30), Depth = 4236.0 },
				new WellDrillData { Date = new DateTime(1987, 06, 30), Depth = 4390.0 },
				new WellDrillData { Date = new DateTime(1988, 06, 30), Depth = 4704.0 },
				new WellDrillData { Date = new DateTime(1989, 06, 30), Depth = 4684.0 },
				new WellDrillData { Date = new DateTime(1990, 06, 30), Depth = 4755.0 },
				new WellDrillData { Date = new DateTime(1991, 06, 30), Depth = 4629.0 },
				new WellDrillData { Date = new DateTime(1992, 06, 30), Depth = 4733.0 },
				new WellDrillData { Date = new DateTime(1993, 06, 30), Depth = 4704.0 },
				new WellDrillData { Date = new DateTime(1994, 06, 30), Depth = 5125.0 },
				new WellDrillData { Date = new DateTime(1995, 06, 30), Depth = 5204.0 },
				new WellDrillData { Date = new DateTime(1996, 06, 30), Depth = 5371.0 },
				new WellDrillData { Date = new DateTime(1997, 06, 30), Depth = 5405.0 },
				new WellDrillData { Date = new DateTime(1998, 06, 30), Depth = 5607.0 },
				new WellDrillData { Date = new DateTime(1999, 06, 30), Depth = 5481.0 },
				new WellDrillData { Date = new DateTime(2000, 06, 30), Depth = 5326.0 },
				new WellDrillData { Date = new DateTime(2001, 06, 30), Depth = 5187.0 },
				new WellDrillData { Date = new DateTime(2002, 06, 30), Depth = 5096.0 },
				new WellDrillData { Date = new DateTime(2003, 06, 30), Depth = 5224.0 },
				new WellDrillData { Date = new DateTime(2004, 06, 30), Depth = 5311.0 },
				new WellDrillData { Date = new DateTime(2005, 06, 30), Depth = 4935.0 },
				new WellDrillData { Date = new DateTime(2006, 06, 30), Depth = 4987.0 },
				new WellDrillData { Date = new DateTime(2007, 06, 30), Depth = 5243.0 },
				new WellDrillData { Date = new DateTime(2008, 06, 30), Depth = 5220.0 },
			};
        }

        private List<WellDrillData> GetNaturalGasDrillData()
        {
            return new List<WellDrillData>() 
            {
				new WellDrillData { Date = new DateTime(1949, 06, 30), Depth = 5682.0 },
				new WellDrillData { Date = new DateTime(1950, 06, 30), Depth = 5466.0 },
				new WellDrillData { Date = new DateTime(1951, 06, 30), Depth = 5497.0 },
				new WellDrillData { Date = new DateTime(1952, 06, 30), Depth = 6071.0 },
				new WellDrillData { Date = new DateTime(1953, 06, 30), Depth = 5654.0 },
				new WellDrillData { Date = new DateTime(1954, 06, 30), Depth = 6059.0 },
				new WellDrillData { Date = new DateTime(1955, 06, 30), Depth = 5964.0 },
				new WellDrillData { Date = new DateTime(1956, 06, 30), Depth = 6301.0 },
				new WellDrillData { Date = new DateTime(1957, 06, 30), Depth = 6898.0 },
				new WellDrillData { Date = new DateTime(1958, 06, 30), Depth = 6657.0 },
				new WellDrillData { Date = new DateTime(1959, 06, 30), Depth = 6613.0 },
				new WellDrillData { Date = new DateTime(1960, 06, 30), Depth = 6298.0 },
				new WellDrillData { Date = new DateTime(1961, 06, 30), Depth = 6457.0 },
				new WellDrillData { Date = new DateTime(1962, 06, 30), Depth = 6728.0 },
				new WellDrillData { Date = new DateTime(1963, 06, 30), Depth = 6370.0 },
				new WellDrillData { Date = new DateTime(1964, 06, 30), Depth = 7547.0 },
				new WellDrillData { Date = new DateTime(1965, 06, 30), Depth = 7295.0 },
				new WellDrillData { Date = new DateTime(1966, 06, 30), Depth = 8321.0 },
				new WellDrillData { Date = new DateTime(1967, 06, 30), Depth = 7478.0 },
				new WellDrillData { Date = new DateTime(1968, 06, 30), Depth = 7697.0 },
				new WellDrillData { Date = new DateTime(1969, 06, 30), Depth = 8092.0 },
				new WellDrillData { Date = new DateTime(1970, 06, 30), Depth = 7695.0 },
				new WellDrillData { Date = new DateTime(1971, 06, 30), Depth = 7649.0 },
				new WellDrillData { Date = new DateTime(1972, 06, 30), Depth = 7400.0 },
				new WellDrillData { Date = new DateTime(1973, 06, 30), Depth = 6596.0 },
				new WellDrillData { Date = new DateTime(1974, 06, 30), Depth = 6456.0 },
				new WellDrillData { Date = new DateTime(1975, 06, 30), Depth = 6748.0 },
				new WellDrillData { Date = new DateTime(1976, 06, 30), Depth = 6777.0 },
				new WellDrillData { Date = new DateTime(1977, 06, 30), Depth = 6625.0 },
				new WellDrillData { Date = new DateTime(1978, 06, 30), Depth = 6662.0 },
				new WellDrillData { Date = new DateTime(1979, 06, 30), Depth = 6630.0 },
				new WellDrillData { Date = new DateTime(1980, 06, 30), Depth = 6604.0 },
				new WellDrillData { Date = new DateTime(1981, 06, 30), Depth = 6772.0 },
				new WellDrillData { Date = new DateTime(1982, 06, 30), Depth = 6921.0 },
				new WellDrillData { Date = new DateTime(1983, 06, 30), Depth = 6395.0 },
				new WellDrillData { Date = new DateTime(1984, 06, 30), Depth = 6502.0 },
				new WellDrillData { Date = new DateTime(1985, 06, 30), Depth = 6787.0 },
				new WellDrillData { Date = new DateTime(1986, 06, 30), Depth = 6777.0 },
				new WellDrillData { Date = new DateTime(1987, 06, 30), Depth = 6698.0 },
				new WellDrillData { Date = new DateTime(1988, 06, 30), Depth = 6683.0 },
				new WellDrillData { Date = new DateTime(1989, 06, 30), Depth = 6606.0 },
				new WellDrillData { Date = new DateTime(1990, 06, 30), Depth = 7100.0 },
				new WellDrillData { Date = new DateTime(1991, 06, 30), Depth = 7122.0 },
				new WellDrillData { Date = new DateTime(1992, 06, 30), Depth = 6907.0 },
				new WellDrillData { Date = new DateTime(1993, 06, 30), Depth = 6482.0 },
				new WellDrillData { Date = new DateTime(1994, 06, 30), Depth = 6564.0 },
				new WellDrillData { Date = new DateTime(1995, 06, 30), Depth = 6264.0 },
				new WellDrillData { Date = new DateTime(1996, 06, 30), Depth = 6773.0 },
				new WellDrillData { Date = new DateTime(1997, 06, 30), Depth = 7188.0 },
				new WellDrillData { Date = new DateTime(1998, 06, 30), Depth = 7230.0 },
				new WellDrillData { Date = new DateTime(1999, 06, 30), Depth = 7015.0 },
				new WellDrillData { Date = new DateTime(2000, 06, 30), Depth = 7347.0 },
				new WellDrillData { Date = new DateTime(2001, 06, 30), Depth = 6990.0 },
				new WellDrillData { Date = new DateTime(2002, 06, 30), Depth = 6796.0 },
				new WellDrillData { Date = new DateTime(2003, 06, 30), Depth = 6589.0 },
				new WellDrillData { Date = new DateTime(2004, 06, 30), Depth = 5948.0 },
				new WellDrillData { Date = new DateTime(2005, 06, 30), Depth = 5732.0 },
				new WellDrillData { Date = new DateTime(2006, 06, 30), Depth = 5770.0 },
				new WellDrillData { Date = new DateTime(2007, 06, 30), Depth = 5901.0 },
				new WellDrillData { Date = new DateTime(2008, 06, 30), Depth = 5899.0 },
            };
        }

        private List<WellDrillData> GetCrudeOilDrillData()
        {
            return new List<WellDrillData>()
			{
				new WellDrillData { Date = new DateTime(1949, 06, 30), Depth = 3684.0 },
				new WellDrillData { Date = new DateTime(1950, 06, 30), Depth = 3861.0 },
				new WellDrillData { Date = new DateTime(1951, 06, 30), Depth = 4061.0 },
				new WellDrillData { Date = new DateTime(1952, 06, 30), Depth = 4167.0 },
				new WellDrillData { Date = new DateTime(1953, 06, 30), Depth = 3972.0 },
				new WellDrillData { Date = new DateTime(1954, 06, 30), Depth = 3974.0 },
				new WellDrillData { Date = new DateTime(1955, 06, 30), Depth = 3915.0 },
				new WellDrillData { Date = new DateTime(1956, 06, 30), Depth = 3865.0 },
				new WellDrillData { Date = new DateTime(1957, 06, 30), Depth = 3944.0 },
				new WellDrillData { Date = new DateTime(1958, 06, 30), Depth = 3831.0 },
				new WellDrillData { Date = new DateTime(1959, 06, 30), Depth = 3852.0 },
				new WellDrillData { Date = new DateTime(1960, 06, 30), Depth = 3809.0 },
				new WellDrillData { Date = new DateTime(1961, 06, 30), Depth = 3931.0 },
				new WellDrillData { Date = new DateTime(1962, 06, 30), Depth = 4008.0 },
				new WellDrillData { Date = new DateTime(1963, 06, 30), Depth = 4006.0 },
				new WellDrillData { Date = new DateTime(1964, 06, 30), Depth = 3947.0 },
				new WellDrillData { Date = new DateTime(1965, 06, 30), Depth = 3970.0 },
				new WellDrillData { Date = new DateTime(1966, 06, 30), Depth = 3884.0 },
				new WellDrillData { Date = new DateTime(1967, 06, 30), Depth = 3692.0 },
				new WellDrillData { Date = new DateTime(1968, 06, 30), Depth = 4027.0 },
				new WellDrillData { Date = new DateTime(1969, 06, 30), Depth = 4142.0 },
				new WellDrillData { Date = new DateTime(1970, 06, 30), Depth = 4269.0 },
				new WellDrillData { Date = new DateTime(1971, 06, 30), Depth = 4049.0 },
				new WellDrillData { Date = new DateTime(1972, 06, 30), Depth = 4231.0 },
				new WellDrillData { Date = new DateTime(1973, 06, 30), Depth = 4242.0 },
				new WellDrillData { Date = new DateTime(1974, 06, 30), Depth = 3675.0 },
				new WellDrillData { Date = new DateTime(1975, 06, 30), Depth = 3821.0 },
				new WellDrillData { Date = new DateTime(1976, 06, 30), Depth = 3756.0 },
				new WellDrillData { Date = new DateTime(1977, 06, 30), Depth = 3901.0 },
				new WellDrillData { Date = new DateTime(1978, 06, 30), Depth = 3883.0 },
				new WellDrillData { Date = new DateTime(1979, 06, 30), Depth = 3827.0 },
				new WellDrillData { Date = new DateTime(1980, 06, 30), Depth = 3691.0 },
				new WellDrillData { Date = new DateTime(1981, 06, 30), Depth = 3799.0 },
				new WellDrillData { Date = new DateTime(1982, 06, 30), Depth = 3681.0 },
				new WellDrillData { Date = new DateTime(1983, 06, 30), Depth = 3577.0 },
				new WellDrillData { Date = new DateTime(1984, 06, 30), Depth = 3695.0 },
				new WellDrillData { Date = new DateTime(1985, 06, 30), Depth = 3808.0 },
				new WellDrillData { Date = new DateTime(1986, 06, 30), Depth = 3875.0 },
				new WellDrillData { Date = new DateTime(1987, 06, 30), Depth = 3972.0 },
				new WellDrillData { Date = new DateTime(1988, 06, 30), Depth = 4171.0 },
				new WellDrillData { Date = new DateTime(1989, 06, 30), Depth = 4116.0 },
				new WellDrillData { Date = new DateTime(1990, 06, 30), Depth = 4326.0 },
				new WellDrillData { Date = new DateTime(1991, 06, 30), Depth = 4434.0 },
				new WellDrillData { Date = new DateTime(1992, 06, 30), Depth = 4877.0 },
				new WellDrillData { Date = new DateTime(1993, 06, 30), Depth = 4986.0 },
				new WellDrillData { Date = new DateTime(1994, 06, 30), Depth = 5278.0 },
				new WellDrillData { Date = new DateTime(1995, 06, 30), Depth = 4998.0 },
				new WellDrillData { Date = new DateTime(1996, 06, 30), Depth = 4735.0 },
				new WellDrillData { Date = new DateTime(1997, 06, 30), Depth = 4944.0 },
				new WellDrillData { Date = new DateTime(1998, 06, 30), Depth = 4941.0 },
				new WellDrillData { Date = new DateTime(1999, 06, 30), Depth = 4507.0 },
				new WellDrillData { Date = new DateTime(2000, 06, 30), Depth = 4493.0 },
				new WellDrillData { Date = new DateTime(2001, 06, 30), Depth = 4791.0 },
				new WellDrillData { Date = new DateTime(2002, 06, 30), Depth = 4496.0 },
				new WellDrillData { Date = new DateTime(2003, 06, 30), Depth = 4684.0 },
				new WellDrillData { Date = new DateTime(2004, 06, 30), Depth = 4675.0 },
				new WellDrillData { Date = new DateTime(2005, 06, 30), Depth = 4669.0 },
				new WellDrillData { Date = new DateTime(2006, 06, 30), Depth = 4706.0 },
				new WellDrillData { Date = new DateTime(2007, 06, 30), Depth = 4945.0 },
				new WellDrillData { Date = new DateTime(2008, 06, 30), Depth = 4938.0 },
			};
        }

        private double Average(List<WellDrillData> wellData)
        {
            double sum = 0d;

            foreach (WellDrillData well in wellData)
            {
                sum += well.Depth;
            }

            return (sum / wellData.Count);
        }

        private double Maximum(List<WellDrillData> wellData)
        {
            double max = double.MinValue;

            foreach (WellDrillData well in wellData)
            {
                if (max < well.Depth)
                {
                    max = well.Depth;
                }
            }

            return max;
        }
    }
}
