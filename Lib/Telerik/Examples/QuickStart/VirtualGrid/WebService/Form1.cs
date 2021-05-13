using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.WebService
{
    public partial class Form1 : ExamplesForm
    {
        private const int IMAGE_REQUEST_SIZE = 10;
        private BackgroundWorker initialLoader;
        private BackgroundWorker imageLoader;
        private List<Product> data;
        private string[] fieldNames = new string[] {"Image", "ProductName", "UnitPrice", "UnitsInStock", "Discontinued"};
        private int loadedRowCount = IMAGE_REQUEST_SIZE;
        
        public Form1()
        {
            InitializeComponent();
            
            this.radVirtualGrid1.TableElement.RowHeight = 150;
            this.radVirtualGrid1.RowCount = 0;
            this.radVirtualGrid1.ColumnCount = 5;
            
            this.initialLoader = new BackgroundWorker();
            this.initialLoader.DoWork += initialLoader_DoWork;
            this.initialLoader.RunWorkerCompleted += initialLoader_RunWorkerCompleted;

            this.imageLoader = new BackgroundWorker();
            this.imageLoader.DoWork += imageLoader_DoWork;
            this.imageLoader.RunWorkerCompleted += imageLoader_RunWorkerCompleted;
        }

        #region VirtualGrid handling

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radButton1.Visible = false;
            this.radVirtualGrid1.MasterViewInfo.IsWaiting = true;
            this.initialLoader.RunWorkerAsync();
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || this.data == null)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = fieldNames[e.ColumnIndex];
            }

            if (e.RowIndex == e.ViewInfo.RowCount - 1 && e.ViewInfo.RowCount < this.data.Count)
            {
                e.Value = null;
                e.ViewInfo.StartRowWaiting(e.RowIndex);
                if (!this.imageLoader.IsBusy)
                {
                    this.imageLoader.RunWorkerAsync();
                }
            }
            else if (e.RowIndex >= 0)
            {
                e.Value = this.data[e.RowIndex][e.ColumnIndex];
            }

        }

        private void radVirtualGrid1_CellFormatting(object sender, Telerik.WinControls.UI.VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.Value is Image)
            {
                e.CellElement.Text = "";
                e.CellElement.Image = (Image)e.CellElement.Value;
            }
            else if (!(e.CellElement is VirtualGridIndentCellElement))
            {
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }
 
        #endregion

        #region Background Workers

        void initialLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            WebRequest request = WebRequest.Create("http://demos.telerik.com/kendo-ui/service/Products");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                string responseFromServer = reader.ReadToEnd();
                List<Product> parsedData = ParseServerResponce(responseFromServer);
                e.Result = parsedData;
                RequestImages(parsedData, 0, IMAGE_REQUEST_SIZE);
            }
        }

        void imageLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            this.RequestImages(this.data, loadedRowCount, loadedRowCount + IMAGE_REQUEST_SIZE);
        }

        void initialLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.radVirtualGrid1.IsDisposed)
            {
                return;
            }

            List<Product> parsedResult = e.Result as List<Product>;
            this.data = parsedResult;
            this.radVirtualGrid1.RowCount = Math.Min(loadedRowCount + 1, this.data.Count);
            this.radVirtualGrid1.MasterViewInfo.IsWaiting = false;
        }

        void imageLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.radVirtualGrid1.IsDisposed)
            {
                return;
            }

            int waitingRow = this.radVirtualGrid1.RowCount - 1;
            this.radVirtualGrid1.RowCount = Math.Min(loadedRowCount + 1, this.data.Count);
            this.radVirtualGrid1.MasterViewInfo.StopRowWaiting(waitingRow);
        }

        #endregion

        #region WebRequest handling

        private void RequestImages(List<Product> data, int startIndex, int endIndex)
        {
            endIndex = Math.Min(endIndex, data.Count);
            for (int i = startIndex; i < endIndex; i++)
            {
                if (data[i].Image == null)
                {
                    WebRequest request = WebRequest.Create("http://demos.telerik.com/kendo-ui/content/web/foods/" + data[i].ProductID + ".jpg");
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        data[i].Image = Image.FromStream(dataStream);
                    }
                }
            }

            this.loadedRowCount = endIndex;
        }

        private List<Product> ParseServerResponce(string responseFromServer)
        {
            int openArrayBracket = responseFromServer.IndexOf('[');
            int closeArrayBracket = responseFromServer.IndexOf(']');
            string json = responseFromServer.Substring(openArrayBracket + 1, closeArrayBracket - openArrayBracket - 1);
            string[] items = json.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            List<Product> result = new List<Product>();
            foreach (string item in items)
            {
                Product product = new Product();
                string[] fields = item.Trim('{', '}').Split(',');
                foreach (string field in fields)
                {
                    string[] prop = field.Split(':');
                    prop[0] = prop[0].Trim(' ', '"');
                    prop[1] = prop[1].Trim(' ', '"');

                    switch (prop[0])
                    {
                        case "ProductID":
                            product.ProductID = int.Parse(prop[1]);
                            break;
                        case "ProductName":
                            product.ProductName = prop[1];
                            break;
                        case "UnitPrice":
                            product.UnitPrice = decimal.Parse(prop[1], System.Globalization.CultureInfo.InvariantCulture);
                            break;
                        case "UnitsInStock":
                            product.UnitsInStock = int.Parse(prop[1]);
                            break;
                        case "Discontinued":
                            product.Discontinued = bool.Parse(prop[1]);
                            break;
                    }

                }

                result.Add(product);
            }

            return result;
        }

        #endregion
   }
}
