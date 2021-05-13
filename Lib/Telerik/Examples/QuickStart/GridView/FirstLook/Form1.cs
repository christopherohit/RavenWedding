using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.IO;
using System.Reflection;
using Telerik.WinControls.Primitives;


namespace Telerik.Examples.WinControls.GridView.FirstLook
{
    /// <summary>
    /// represent the busness grid form
    /// </summary>
    public partial class Form1
        : ShapedForm
    {
        private int columnIDCounter = 0;
        private const int OleHeaderSize = 78;
        private Font segoeFont = new Font("Segoe UI", 8.25f, FontStyle.Regular);
        private Font buttonFont = new Font("Segoe UI", 9f, FontStyle.Bold);
        
        public Form1()
        {
            InitializeComponent();

            this.Shape = new RoundRectShape(7);
            this.BorderWidth = 1;
            this.radGridView1.TableElement.RowHeight = 80;

            this.radGridView1.RowsChanging += new GridViewCollectionChangingEventHandler(radGridView1_RowsChanging);
            this.radGridView1.DefaultValuesNeeded += new GridViewRowEventHandler(radGridView1_DefaultValuesNeeded);

            this.deleteButton.ButtonElement.Font = buttonFont;
            this.newButton.ButtonElement.Font = buttonFont;            
        }

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // TODO: This line of code loads data into the 'furnitureDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.furnitureDataSet2.Products);

            this.BackgroundImage = this.LoadImage("Telerik.Examples.WinControls.GridView.FirstLook.Images.bg.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.newButton.Image = this.LoadImage("Telerik.Examples.WinControls.GridView.FirstLook.Images.buttonNew.png");
            this.deleteButton.Image = this.LoadImage("Telerik.Examples.WinControls.GridView.FirstLook.Images.buttonDelete.png");
            this.radPanel2.BackgroundImage = this.LoadImage("Telerik.Examples.WinControls.GridView.FirstLook.Images.f1.PNG");
            this.radTitleBar1.BackgroundImage = this.LoadImage("Telerik.Examples.WinControls.GridView.FirstLook.Images.logo.png");
            this.radTitleBar1.BackgroundImageLayout = ImageLayout.Center;
            ((TextPrimitive)this.radTitleBar1.TitleBarElement.Children[2].Children[2]).Text = String.Empty;
            ((ImagePrimitive)this.radTitleBar1.TitleBarElement.Children[2].Children[0]).Image = null;

            RoundRectShape panelShapeTopRounded = new RoundRectShape(3);
            panelShapeTopRounded.BottomRightRounded = false;
            panelShapeTopRounded.BottomLeftRounded = false;
            radPanel4.PanelElement.Shape = panelShapeTopRounded;

            RoundRectShape panelShapeBottomRounded = new RoundRectShape(3);
            panelShapeBottomRounded.TopLeftRounded = false;
            panelShapeBottomRounded.TopRightRounded = false;
            radPanel1.PanelElement.Shape = panelShapeBottomRounded;

            radPanel3.PanelElement.Shape = panelShapeTopRounded;

            radTextBoxDimension.Font = segoeFont;
            radTextBoxManufacturer.Font = segoeFont;
            radTextBoxMaterial.Font = segoeFont;
            radTextBoxProductName.Font = segoeFont;
            updateButton.Font = segoeFont;
            cancelButton.Font = segoeFont;
            radLabel2.Font = segoeFont;
            radLabel3.Font = segoeFont;
            radLabel4.Font = segoeFont;
            radLabel5.Font = segoeFont;
            radLabel6.Font = segoeFont;

            this.radGridView1.TableElement.Padding = new Padding(0);
            this.radGridView1.TableElement.DrawBorder = false;
            this.radGridView1.TableElement.CellSpacing = -1;
            this.radGridView1.TableElement.Text = "";

            this.radGridView1.MasterTemplate.BestFitColumns();
            this.radGridView1.Columns["Photo"].Width = 106;
            this.radGridView1.Columns["ProductName"].Width = 104;

            this.FillComboBox();
            this.UpdatePanelInfo(this.radGridView1.CurrentRow);

            WireEvents();
        }

        private void radGridView1_DefaultValuesNeeded(object sender, GridViewRowEventArgs e)
        {
            e.Rows[0].Cells["Price"].Value = 0;
            e.Rows[0].Cells["Quantity"].Value = 0;
            e.Rows[0].Cells["ID"].Value = this.columnIDCounter++;
        }

        private void radGridView1_RowsChanging(object sender, GridViewCollectionChangingEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(this.radGridView1.CurrentRow);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateGridInfo(this.radGridView1.CurrentRow);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.radGridView1.CurrentRow != null)
            {
                UpdatePanelInfo(this.radGridView1.CurrentRow);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.radGridView1.AllowAddNewRow = !this.radGridView1.AllowAddNewRow;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            GridViewDataRowInfo dataRowInfo = this.radGridView1.CurrentRow as GridViewDataRowInfo;
            if (dataRowInfo != null)
            {
                this.radGridView1.Rows.Remove(dataRowInfo);
                this.UpdatePanelInfo(this.radGridView1.CurrentRow);
            }
        }

        #endregion

        private void WireEvents()
        {
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            this.radGridView1.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.radGridView1_CurrentRowChanged);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
        }

        private void UpdatePanelInfo(GridViewRowInfo currentRow)
        {
            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.radTextBoxProductName.Text = this.GetSafeString(currentRow.Cells["ProductName"].Value);
                this.radTextBoxManufacturer.Text = this.GetSafeString(currentRow.Cells["Manufacturer"].Value);
                this.radTextBoxMaterial.Text = this.GetSafeString(currentRow.Cells["Lining"].Value);
                this.radTextBoxDimension.Text = this.GetSafeString(currentRow.Cells["Dimensions"].Value);

                object photoValue = currentRow.Cells["Photo"].Value;

                if (!Convert.IsDBNull(photoValue) && photoValue != null)
                {
                    Image image = GetImageFromBytes(currentRow.Cells["Photo"].Value as byte[]);
                    this.radPanel2.BackgroundImage = new Bitmap(image);
                }
                else
                {
                    this.radPanel2.BackgroundImage = new Bitmap(10, 10);
                }

                string salesPerson = this.GetSafeString(currentRow.Cells["SalesRepresentative"].Value);

                if (!string.IsNullOrEmpty(salesPerson.Trim()))
                {
                    this.radComboBox1.SelectedIndex = this.radComboBox1.FindString(salesPerson);
                }
                else
                {
                    this.radComboBox1.SelectedIndex = -1;
                    this.radComboBox1.Text = string.Empty;
                }
            }
            else
            {
                this.radTextBoxProductName.Text = string.Empty;
                this.radTextBoxManufacturer.Text = string.Empty;
                this.radTextBoxMaterial.Text = string.Empty;
                this.radTextBoxDimension.Text = string.Empty;
                this.radPanel2.BackgroundImage = new Bitmap(10, 10);
                this.radComboBox1.SelectedIndex = -1;
                this.radComboBox1.Text = string.Empty;
            }
        }

        private void UpdateGridInfo(GridViewRowInfo currentRow)
        {
            if (currentRow == null)
            {
                return;
            }

            this.radGridView1.CloseEditor();

            currentRow.Cells["ProductName"].Value = this.radTextBoxProductName.Text;
            currentRow.Cells["Manufacturer"].Value = this.radTextBoxManufacturer.Text;
            currentRow.Cells["Lining"].Value = this.radTextBoxMaterial.Text;
            currentRow.Cells["Dimensions"].Value = this.radTextBoxDimension.Text;

            if (this.radComboBox1.SelectedIndex != -1)
            {
                currentRow.Cells["SalesRepresentative"].Value = this.radComboBox1.SelectedItem.Text;
            }

            GridViewNewRowInfo newRowInfo = currentRow as GridViewNewRowInfo;
            if (newRowInfo != null)
            {
                currentRow.InvalidateRow();
            }
            else
            {
                ((IEditableObject)this.radGridView1.CurrentRow.DataBoundItem).EndEdit();
            }
        }

        private void FillComboBox()
        {
            this.radComboBox1.Items.Clear();
            string basePath = Path.GetDirectoryName(Application.ExecutablePath);
            foreach (string fileName in Directory.GetFiles(Path.Combine(basePath, "..\\GridView\\FirstLook\\Images\\People"), "*.jpg"))
            {
                Image image = Image.FromFile(fileName);
                RadListDataItem comboboxItem = new RadListDataItem();
                comboboxItem.Font = this.radComboBox1.Font;
                comboboxItem.ForeColor = Color.Black;
                comboboxItem.TextImageRelation = TextImageRelation.ImageBeforeText;
                comboboxItem.Text = Path.GetFileNameWithoutExtension(fileName);
                comboboxItem.Image = image;
                this.radComboBox1.Items.Add(comboboxItem);
            }

            this.radComboBox1.ShowImageInEditorArea = false;
        }

        private string GetSafeString(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        private Image LoadImage(string name)
        {
            Stream stream = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(name);

            if (stream == null)
            {
                throw new NullReferenceException("Cannot find " + name);
            }

            return new Bitmap(stream);
        }

        private Image GetImageFromBytes(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            Image result = null;
            MemoryStream stream = null;

            try
            {
                int count;
                int start;

                if (IsOleContainer(bytes))
                {
                    count = bytes.Length - OleHeaderSize;
                    start = OleHeaderSize;
                }
                else
                {
                    count = bytes.Length;
                    start = 0;
                }

                stream = new MemoryStream(bytes, start, count);
                result = Image.FromStream(stream);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return result;
        }

        private bool IsOleContainer(byte[] imageData)
        {
            return (imageData != null
                && imageData[0] == 0x15
                && imageData[1] == 0x1C);
        }
    }
}
