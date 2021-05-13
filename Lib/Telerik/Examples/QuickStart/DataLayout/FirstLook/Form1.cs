using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataLayout.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radPanel1;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupControls();
            ArrangePictureBox();
        }

        private void SetupControls()
        {
            this.radDataLayout1.AutoSizeLabels = true;

            this.radDataLayout1.EditorInitializing += new Telerik.WinControls.UI.EditorInitializingEventHandler(radDataEntry1_EditorInitializing);
            this.radDataLayout1.BindingCreating += new Telerik.WinControls.UI.BindingCreatingEventHandler(radDataEntry1_BindingCreating);
            this.radDataLayout1.BindingCreated += new Telerik.WinControls.UI.BindingCreatedEventHandler(radDataEntry1_BindingCreated);

            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);
            this.bindingSource1.AllowNew = true;

            this.radBindingNavigator1.BindingSource = this.bindingSource1;
            this.radBindingNavigator1.AutoHandleAddNew = false;
            this.radBindingNavigator1.ContextMenuOpening += radBindingNavigator1_ContextMenuOpening;
            this.radBindingNavigator1AddNewItem.Click += new EventHandler(radBindingNavigator1AddNewItem_Click);

            this.radDataLayout1.DataSource = this.bindingSource1;
        }

        private void ArrangePictureBox()
        {
            RadLayoutControl layoutControl = this.radDataLayout1.LayoutControl;

            layoutControl.AddItem((LayoutControlItemBase)layoutControl.Items[5], 
                (LayoutControlItemBase)layoutControl.Items[11], LayoutControlDropPosition.Top);

            layoutControl.ResizeItem((LayoutControlItemBase)layoutControl.Items[5], 22 - layoutControl.Items[5].Bounds.Height);
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

        void radDataEntry1_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            if (e.DataMember == "Photo")
            {
                e.Binding.Format += new ConvertEventHandler(Binding_Format);
            }
        }

        void radDataEntry1_BindingCreating(object sender, BindingCreatingEventArgs e)
        {
            if (e.DataMember == "Photo")
            {
                e.PropertyName = "Image";
            }
        }

        void Binding_Format(object sender, ConvertEventArgs e)
        {
            Image img = ImageHelper.GetImageFromBytes((byte[])e.Value);
            e.Value = img;
        }

        void radDataEntry1_EditorInitializing(object sender, EditorInitializingEventArgs e)
        {
            if (e.Property.Name == "Photo")
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "PictureBoxPhoto";
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                e.Editor = pictureBox;
            }
        }

        private void radButtonCustomize_Click(object sender, EventArgs e)
        {
            this.radDataLayout1.LayoutControl.ShowCustomizeDialog();
        }

        private void radButtonSaveLayout_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = ".xml";
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.radDataLayout1.LayoutControl.SaveLayout(sfd.FileName);
                }
            }
        }

        private void radButtonLoadLayout_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.DefaultExt = ".xml";
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.radDataLayout1.LayoutControl.LoadLayout(ofd.FileName);
                }
            }
        }

        private void radBindingNavigator1_ContextMenuOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (this.IsTouchTheme())
            {
                int newItemSize = 36;
                if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
                {
                    newItemSize = 40;
                }

                this.radDataLayout1.ItemDefaultHeight = newItemSize;
                this.radPanel1.Size = TelerikDpiHelper.ScaleSize(new Size(629, 602), this.radDataLayout1.RootElement.DpiScaleFactor);

                this.SuspendLayout();
                this.radDataLayout1.DataSource = null;
                this.radDataLayout1.DataSource = this.bindingSource1;
                this.ResumeLayout();
            }
        }

        private bool IsTouchTheme()
        {
            return TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || this.CurrentThemeName == "TelerikMetroTouch";
        }
    }
}
