using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Carousel.FirstLook
{
    public partial class Form1 : ShapedForm
    {
        private bool searchTextIsDirty;
        private TextPrimitive selectedItemText = new TextPrimitive();

        public Form1()
        {
            InitializeComponent();

            WireEvents();

            selectedItemText.AutoSize = false;
            selectedItemText.Bounds = new Rectangle(175, 375, 502, 39);
            this.radCarouselAlbums.CarouselElement.Children.Add(selectedItemText);
            selectedItemText.Font = new Font("Arial Rounded MT Bold", 14.25f);
            selectedItemText.TextAlignment = ContentAlignment.MiddleCenter;


            //Prevent the titlebar to acquire a theme.
            this.radTitleBar1.ThemeName = "";
            this.radBtnAlbums.ThemeName = "MusicLibrary";
            this.radBtnDownloads.ThemeName = "MusicLibrary";
            this.radBtnSongs.ThemeName = "MusicLibrary";
            this.radBtnArtists.ThemeName = "MusicLibrary";
        }

        void WireEvents()
        {
            this.radCarouselAlbums.ItemDataBound += new Telerik.WinControls.UI.ItemDataBoundEventHandler(this.radCarousel1_ItemDataBound);
            this.radCarouselAlbums.SelectedIndexChanged += new System.EventHandler(this.radCarousel1_SelectedIndexChanged);
            this.radComboSearch.Validated += new System.EventHandler(this.radComboBox1_Validated);
            this.radComboSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radComboBox1_KeyDown);
            this.radComboSearch.TextChanged += new System.EventHandler(this.radComboBox1_TextChanged);
        }


        private void ManualTest()
        {
            this.ShowDialog();
        }

        private void radCarousel1_ItemDataBound(object sender, Telerik.WinControls.UI.ItemDataBoundEventArgs e)
        {
            RadButtonElement carouselItem = (RadButtonElement)e.DataBoundItem;
            carouselItem.TextImageRelation = TextImageRelation.TextAboveImage;
            carouselItem.Font = new Font("Verdana", 10f);
            carouselItem.ForeColor = Color.WhiteSmoke;
            //Store data to use later
            carouselItem.Tag = e.DataItem;

            Image image = this.GetImageFromBytes(EvaluatePropertyValue(e.DataItem, "Image"));

            if (image != null)
            {
                carouselItem.Image = new Bitmap(image, 165, 165);
            }

            carouselItem.Text = (string)EvaluatePropertyValue(e.DataItem, "AlbumName");
        }

        private object EvaluatePropertyValue(object dataItem, string property)
        {
            return TypeDescriptor.GetProperties(dataItem)[property].GetValue(dataItem);
        }

        private Image GetImageFromBytes(object data)
        {
            Image result = null;
            MemoryStream stream = null;

            try
            {
                if (data != null &&
                    typeof(byte[]).IsAssignableFrom(data.GetType()))
                {
                    byte[] bytes = null;
                    bytes = (byte[])data;
                    if (bytes.Length > 0)
                    {
                        int count;
                        int start;
                        count = bytes.Length;
                        start = 0;


                        stream = new MemoryStream(bytes, start, count);
                        result = Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return result;
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            // TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);

            if (this.radCarouselAlbums.Items.Count > 3)
            {
                this.radCarouselAlbums.SelectedIndex = 3;
            }
        }

        private void SearchCarouselItems()
        {
            if (searchTextIsDirty)
            {
                if (!string.IsNullOrEmpty(this.radComboSearch.Text))
                {
                    RadItem carouselItem = this.radCarouselAlbums.CarouselElement.FindItemContaining(this.radComboSearch.Text);
                    if (carouselItem != null)
                    {
                        if (this.radComboSearch.FindStringExact(this.radComboSearch.Text) == -1)
                        {
                            this.radComboSearch.Items.Add(this.radComboSearch.Text);
                        }

                        this.radCarouselAlbums.SelectedItem = carouselItem;
                        searchTextIsDirty = false;
                    }
                }
            }
        }

        private void radComboBox1_Validated(object sender, System.EventArgs e)
        {
            this.SearchCarouselItems();
        }

        private void radComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SearchCarouselItems();
            }
        }

        private void radComboBox1_TextChanged(object sender, System.EventArgs e)
        {
            searchTextIsDirty = true;
        }

        private void radCarousel1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RadItem item = (this.radCarouselAlbums.SelectedItem as RadItem);
            if (item != null && item.Tag != null)
            {
                this.selectedItemText.Text = (string)EvaluatePropertyValue(item.Tag, "AlbumName");

                AnimatedPropertySetting setting = new AnimatedPropertySetting(
                    VisualElement.ForeColorProperty,
                    Color.Transparent,
                    Color.WhiteSmoke,
                    10,
                    40);

                setting.ApplyValue(selectedItemText);
            }
        }

    }
}
