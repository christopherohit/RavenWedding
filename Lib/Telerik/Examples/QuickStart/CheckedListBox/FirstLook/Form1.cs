using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CheckedListBox.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.InitializeData();
            ListViewDetailColumn nameColumn = new ListViewDetailColumn("Product");
            nameColumn.Width = 132;
            this.radListView1.Columns.Add(nameColumn);
            ListViewDetailColumn priceColumn = new ListViewDetailColumn("Price");
            priceColumn.Width = 60;
            this.radListView1.Columns.Add(priceColumn);

            ListViewDetailColumn totalColumn = new ListViewDetailColumn("Total");
            totalColumn.Width = 132;
            this.radListView2.Columns.Add(totalColumn);
            ListViewDetailColumn totalPriceColumn = new ListViewDetailColumn("TotalPrice");
            totalPriceColumn.Width = 60;
            this.radListView2.Columns.Add(totalPriceColumn);

            this.radListView1.CellFormatting += radListView1_CellFormatting;
            this.radListView2.CellFormatting += radListView2_CellFormatting;
            this.radCheckedListBox1.VisualItemFormatting += radCheckedListBox1_VisualItemFormatting;
            this.radCheckedListBox1.SelectedItemsChanged += radCheckedListBox1_SelectedItemsChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewDataItem item = new ListViewDataItem();
            this.radListView2.Items.Add(item);

            item["Total"] = "Total";
            item["TotalPrice"] = string.Format("{0:C2}", 0);
        }

        private void InitializeData()
        {
            IEnumerable<Product> mealProducts = this.CreateProducts();

            foreach (Product product in mealProducts)
            {
                this.radCheckedListBox1.Items.Add(this.CreateItem(product));
            }
        }

        private IEnumerable<Product> CreateProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "Beef Burger", Price = 7.95m, Weight = 350, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\beef-burger.jpg") },
                new Product() { Name = "Big Burger", Price = 7.45m, Weight = 450, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\big-burger.jpg") },
                new Product() { Name = "Burger with fries", Price = 5.95m, Weight = 480, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\burger-fries.jpg") }, 
                new Product() { Name = "Classical Burger", Price = 3.45m, Weight = 250, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\burger.jpg") },
                new Product() { Name = "Chicken Toast", Price = 4.99m, Weight = 300, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\chicken-toast.jpg") },
                new Product() { Name = "Chicken Wings", Price = 5.90m, Weight = 300, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\chicken-wings.jpg") },
                new Product() { Name = "Crab meat sandwich", Price = 5.50m, Weight = 290, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\crab-sandwich.jpg") },
                new Product() { Name = "Ham sandwich", Price = 2.95m, Weight = 300, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\ham-cheese-sandwich.jpg") }, 
                new Product() { Name = "Hot dog", Price = 2m, Weight = 250, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\hot-dog.jpg") },
                new Product() { Name = "Meatballs", Price = 4.35m, Weight = 200, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\meatballs.jpg") }, 
                new Product() { Name = "Pork ribs", Price = 9.99m, Weight = 450, Image = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\pork-ribs.jpg") }
            };

            return products;
        }

        private ListViewDataItem CreateItem(Product product)
        {
            ListViewDataItem item = new ListViewDataItem();
            item.Image = product.Image.GetThumbnailImage(139, 84, null, IntPtr.Zero);
            item.Text = product.Name;
            item.Tag = product;

            return item;
        }

        private void radCheckedListBox1_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            Product product = e.Item.Tag as Product;

            if (e.Item.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                ListViewDataItem item = new ListViewDataItem();
                item.Tag = product;
                this.radListView1.Items.Add(item);

                item["Product"] = product.Name;
                item["Price"] = product.Price;
            }
            else
            {
                foreach (ListViewDataItem item in this.radListView1.Items)
                {
                    if (item["Product"].ToString() == product.Name)
                    {
                        this.radListView1.Items.Remove(item);
                        break;
                    }
                }
            }

            decimal total = 0;
            foreach (ListViewDataItem item in radListView1.Items)
            {
                total += Convert.ToDecimal(item["Price"]);
            }

            this.radListView2.Items.Clear();
            ListViewDataItem totalItem = new ListViewDataItem();
            this.radListView2.Items.Add(totalItem);

            totalItem["Total"] = "Total";
            totalItem["TotalPrice"] = string.Format("{0:C2}", total);

            if (this.radCheckedListBox1.Items.Count == this.radCheckedListBox1.CheckedItems.Count)
            {
                this.radCheckAllButton.Text = "Uncheck all";
            }
            else
            {
                this.radCheckAllButton.Text = "Check all";
            }

            this.UpdateSelectedButtonText();
        }

        void radCheckedListBox1_SelectedItemsChanged(object sender, EventArgs e)
        {
            this.UpdateSelectedButtonText();
        }

        private void radCheckedListBox1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            SimpleListViewVisualItem item = e.VisualItem as SimpleListViewVisualItem;

            Product product = item.Data.Tag as Product;
            string color = "#681406";
            if (TelerikHelper.IsDarkTheme(this.radListView1.ThemeName))
            {
                color = "#FFFFFF";
            }

            if (item.Children.Count > 0)
            {
                ListViewItemCheckbox checkBoxItem = item.Children[0] as ListViewItemCheckbox;
                checkBoxItem.Margin = new Padding(2, 2, 3, 2);
            }

            item.Data.Text = "<html>" +
                   "<span style=\"font-size:14.5pt;font-family:Segoe UI Semibold;\">  " + product.Name + "</span>" +
                   "<br><span style=\"font-size:10.5pt;\"><i>   " + product.Weight + "gr</i></span>" +
                   "<br><span style=\"font-size:19pt;\"> </span>" +
                   "<span style=\"color:" + color + ";font-size:14.5pt;\"> " + string.Format("{0:C2}", product.Price) + "</span>";

            item.ImageLayout = ImageLayout.Center;
            item.ImageAlignment = ContentAlignment.MiddleLeft;
        }

        private void radListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            DetailListViewDataCellElement cell = e.CellElement as DetailListViewDataCellElement;
            if (cell != null)
            {
                if (cell.Text != string.Empty)
                {
                    decimal price = 0;
                    if (decimal.TryParse(cell.Text, out price))
                    {
                        cell.Text = new string(' ', 5) + string.Format("{0:C2}", price);
                    }
                    else
                    {
                        cell.Text = new string(' ', 2) + string.Format("{0}", cell.Text);
                    }

                    e.CellElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                }
                else
                {
                    e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty, Telerik.WinControls.ValueResetFlags.Local);
                }
            }
        }

        private void radListView2_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            this.radListView1_CellFormatting(sender, e);
            DetailListViewDataCellElement cell = e.CellElement as DetailListViewDataCellElement;
            if (cell != null && cell.Text != string.Empty)
            {
                decimal price = 0;
                if (decimal.TryParse(cell.Text.Substring(3), out price))
                {
                    Color color = Color.FromArgb(255, 104, 20, 6);
                    if (TelerikHelper.IsDarkTheme(this.radListView1.ThemeName))
                    {
                        color = Color.FromArgb(255, 255, 255, 255);
                    }

                    int indent = 4;
                    if (price >= 10)
                    {
                        indent = 3;
                    }

                    cell.Text = new string(' ', indent) + string.Format("{0:C2}", price);
                    e.CellElement.ForeColor = color;
                }
                else
                {
                    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                }

                e.CellElement.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void radClearAllButton_Click(object sender, EventArgs e)
        {
            this.radCheckedListBox1.UncheckAllItems();
        }

        private void radOrderButton_Click(object sender, EventArgs e)
        {
            if (this.radListView1.Items.Count < 1)
            {
                return;
            }

            List<string> orderedItemsTexts = new List<string>();
            foreach (ListViewDataItem item in this.radListView1.Items)
            {
                orderedItemsTexts.Add((item.Tag as Product).Name);
            }

            string message = "You ordered:" + Environment.NewLine + string.Join(Environment.NewLine, orderedItemsTexts.ToArray()) +
            Environment.NewLine + "Total: " + this.radListView2.Items[0]["TotalPrice"];
            RadMessageBox.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(message);
            this.radCheckedListBox1.UncheckAllItems();
        }

        private void radCheckAllButton_Click(object sender, EventArgs e)
        {
            if (this.radCheckAllButton.Text == "Check all")
            {
                this.radCheckedListBox1.CheckAllItems();
                this.radCheckAllButton.Text = "Uncheck all";
            }
            else
            {
                this.radCheckedListBox1.UncheckAllItems();
                this.radCheckAllButton.Text = "Check all";
            }
        }

        private void radCheckSelectedButton_Click(object sender, EventArgs e)
        {
            if (this.radCheckSelectedButton.Text == "Check selected")
            {
                this.radCheckedListBox1.CheckSelectedItems();
                this.radCheckSelectedButton.Text = "Uncheck selected";
            }
            else
            {
                this.radCheckedListBox1.UncheckSelectedItems();
                this.radCheckSelectedButton.Text = "Check selected";
            }
        }

        private void UpdateSelectedButtonText()
        {
            foreach (ListViewDataItem item in this.radCheckedListBox1.SelectedItems)
            {
                if (item.CheckState != Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    this.radCheckSelectedButton.Text = "Check selected";
                    return;
                }
            }

            this.radCheckSelectedButton.Text = "Uncheck selected";
        }
    }

    internal class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Weight { get; set; }

        public Image Image { get; set; }
    }
}
