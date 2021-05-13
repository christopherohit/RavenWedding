using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
{
    public class MockIntegerDataSource : IMockDataSource<WorkItem<int>>
    {
        private List<WorkItem<int>> data;
        private int rows;
        private int columns;

        public MockIntegerDataSource(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.Refresh();
        }

        public void Refresh()
        {
            this.data = new List<WorkItem<int>>(rows);
            Random random = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < rows; i++)
            {
                WorkItem<int> temp = new WorkItem<int>(columns);
                for (int j = 0; j < columns; j++)
                {
                    temp.Add( random.Next(5000));
                }

                this.data.Add(temp);
            }
        }

        #region IMockDataSource<int> Members

        public List<WorkItem<int>> Source
        {
            get 
            {
                return data; 
            }
        }

        public int Columns
        {
            get 
            {
                return this.data[0].Count;
            }
        }

        public int Rows
        {
            get
            {
                return this.data.Count;
            }
        }

        #endregion
    }

    public class WorkItem<T>
    {
        int columns = 0;

        public WorkItem()
        {
        }

        public WorkItem(int columns)
        {
            this.columns = columns;
            internalData = new List<T>(columns);
        }

        List<T> internalData = null;
        
        public void Add(T item) 
        {
            internalData.Add(item);
        }

        public int Count 
        {
            get 
            {
                return internalData.Count;
            }
        }

        public List<T> Data
        {
            get
            {
                return internalData;
            }
        }

        public T Column1
        {
            get { return internalData[0]; }
            set { internalData[0] = value; }
        }

        public T Column2
        {
            get { return internalData[1]; }
            set { internalData[1] = value; }
        }

        public T Column3
        {
            get { return internalData[2]; }
            set { internalData[2] = value; }
        }

        public T Column4
        {
            get { return internalData[3]; }
            set { internalData[3] = value; }
        }

        public T Column5
        {
            get { return internalData[4]; }
            set { internalData[4] = value; }
        }

        public T Column6
        {
            get { return internalData[5]; }
            set { internalData[5] = value; }
        }

        public T Column7
        {
            get { return internalData[6]; }
            set { internalData[6] = value; }
        }

        public T Column8
        {
            get { return internalData[7]; }
            set { internalData[7] = value; }
        }

        public T Column9
        {
            get { return internalData[8]; }
            set { internalData[8] = value; }
        }

        public T Column10
        {
            get { return internalData[9]; }
            set { internalData[9] = value; }
        }

        public T Column11
        {
            get { return internalData[10]; }
            set { internalData[10] = value; }
        }

        public T Column12
        {
            get { return internalData[11]; }
            set { internalData[11] = value; }
        }

    }
}
