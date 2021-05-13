using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
{
    interface IMockDataSource<T>
    {
        List<T> Source { get;}
        void Refresh();
        int Rows { get;}
        int Columns { get;}
    }
}
