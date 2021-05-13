using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataEntry.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radPanel1;
            SetupControls();
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (this.IsTouchTheme())
            {
                Size newItemSize = new Size(300, 32);
                if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
                {
                    newItemSize.Height = 36;
                }

                this.radDataEntry1.ItemDefaultSize = newItemSize;
                this.radPanel1.Size = TelerikDpiHelper.ScaleSize(new Size(620, 571), this.radDataEntry1.RootElement.DpiScaleFactor);

                this.SuspendLayout();
                this.radDataEntry1.DataSource = null;
                this.radDataEntry1.DataSource = this.bindingSource1;
                this.ResumeLayout();
            }
        }

        private void SetupControls()
        {
            this.SuspendLayout();

            this.radDataEntry1.ItemInitializing += new ItemInitializingEventHandler(radDataEntry1_ItemInitializing);
            this.radDataEntry1.EditorInitializing += new EditorInitializingEventHandler(radDataEntry1_EditorInitializing);
            this.radDataEntry1.BindingCreating += new BindingCreatingEventHandler(radDataEntry1_BindingCreating);
            this.radDataEntry1.BindingCreated += new BindingCreatedEventHandler(radDataEntry1_BindingCreated);

            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);
            this.bindingSource1.AllowNew = true;

            this.radBindingNavigator1.BindingSource = this.bindingSource1;
            this.radBindingNavigator1AddNewItem.Click += new EventHandler(radBindingNavigator1AddNewItem_Click);
            this.radBindingNavigator1.ContextMenuOpening += radBindingNavigator1_ContextMenuOpening;

            this.radDataEntry1.DataSource = this.bindingSource1;

            this.ResumeLayout();
        }

        void radBindingNavigator1AddNewItem_Click(object sender, EventArgs e)
        {
            Telerik.Examples.WinControls.DataSources.FurnitureDataSet.ProductsRow row = this.furnitureDataSet.Products.NewProductsRow();
            row.Price = 0;
            row.Photo = ImageHelper.GetBytesFromImage(Properties.Resources.insert5);
            row.Lining = string.Empty;
            row.Manufacturer = string.Empty;
            row.ProductName = string.Empty;
            row.Quantity = 0;
            row.SalesRepresentative = string.Empty;
            row.Front = string.Empty;
            row.Dimensions = string.Empty;
            row.Condition = false;

            this.furnitureDataSet.Products.Rows.Add(row);

            this.furnitureDataSet.AcceptChanges();

            productsTableAdapter.Update(this.furnitureDataSet.Products);

            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }

        void radDataEntry1_BindingCreated(object sender, Telerik.WinControls.UI.BindingCreatedEventArgs e)
        {
            if (e.DataMember == "Photo")
            {
                e.Binding.Format += new ConvertEventHandler(Binding_Format);
            }
        }

        void radDataEntry1_BindingCreating(object sender, Telerik.WinControls.UI.BindingCreatingEventArgs e)
        {
            if (e.DataMember == "Photo")
            {
                e.PropertyName = "Image";
            }
        }

        void Binding_Format(object sender, ConvertEventArgs e)
        {
            Image img = Telerik.WinControls.ImageHelper.GetImageFromBytes((byte[])e.Value);
            e.Value = img;
        }

        void radDataEntry1_EditorInitializing(object sender, Telerik.WinControls.UI.EditorInitializingEventArgs e)
        {
            if (e.Property.Name == "Photo")
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                e.Editor = pictureBox;
            }
        }

        void radDataEntry1_ItemInitializing(object sender, Telerik.WinControls.UI.ItemInitializingEventArgs e)
        {
            if (e.Panel.Controls[1].Text == "Photo")
            {
                e.Panel.Location = new Point(8, 200);
                e.Panel.Size = new Size(500, 220);

                if (this.IsTouchTheme())
                {
                    e.Panel.Location = new Point(8, 300);
                }
            }
        }

        private void radBindingNavigator1_ContextMenuOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private bool IsTouchTheme()
        {
            return TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || this.CurrentThemeName == "TelerikMetroTouch";
        }
    }
}
