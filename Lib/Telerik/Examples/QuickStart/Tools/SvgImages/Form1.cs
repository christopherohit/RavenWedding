using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Tools.SvgImages
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;

#if NET4 || DOTNET
            this.radGridView1.TableElement.RowHeight = 132;
            this.radGridView1.CellFormatting += this.RadGridView1_CellFormatting;
            this.SetupData();
#endif
        }

#if NET4 || DOTNET
        private void RadGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name.StartsWith("SVG"))
            {
                // Assign the svg image to the current visual cell element
                RadSvgImage svgImage = e.Row.Cells[e.Column.Name].Value as RadSvgImage;
                e.CellElement.Text = string.Empty;
                e.CellElement.SvgImage = svgImage;
            }

            e.CellElement.ImageLayout = ImageLayout.Center;
        }

        private void SetupData()
        {
            GridViewTextBoxColumn nameColumn = new GridViewTextBoxColumn("Name");
            nameColumn.Width = 100;
            this.radGridView1.Columns.Add(nameColumn);

            GridViewTextBoxColumn svgColumn = new GridViewTextBoxColumn("SVG 100%");
            svgColumn.Width = 80;
            svgColumn.DataType = typeof(RadSvgImage);
            this.radGridView1.Columns.Add(svgColumn);

            GridViewTextBoxColumn svgColumn200 = new GridViewTextBoxColumn("SVG 200%");
            svgColumn200.Width = 90;
            svgColumn200.DataType = typeof(RadSvgImage);
            this.radGridView1.Columns.Add(svgColumn200);

            GridViewTextBoxColumn svgColumn400 = new GridViewTextBoxColumn("SVG 400%");
            svgColumn400.Width = 130;
            svgColumn400.DataType = typeof(RadSvgImage);
            this.radGridView1.Columns.Add(svgColumn400);

            GridViewImageColumn imageColumn = new GridViewImageColumn("Image 100%");
            imageColumn.Width = 80;
            this.radGridView1.Columns.Add(imageColumn);

            GridViewImageColumn imageColumn200 = new GridViewImageColumn("Image 200%");
            imageColumn200.Width = 90;
            this.radGridView1.Columns.Add(imageColumn200);

            GridViewImageColumn imageColumn400 = new GridViewImageColumn("Image 400%");
            imageColumn400.Width = 130;
            this.radGridView1.Columns.Add(imageColumn400);

            string[] allResources = typeof(Form1).Assembly.GetManifestResourceNames();
            IEnumerable<string> svgs = allResources.Where(r => r.StartsWith("Telerik.Examples.WinControls.Tools.SvgImages.SampleSVGs"));
            foreach (string file in svgs)
            {
                RadSvgImage svgImage;
                using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(file))
                {
                    // create svg image from given stream
                    svgImage = RadSvgImage.FromStream(stream);
                }

                Size size = svgImage.Size;
                // Clone the original SVG for the other columns 200 and 400%
                RadSvgImage svgImage200 = svgImage.Clone() as RadSvgImage;
                // change default size of the SVG image to 200%
                svgImage200.Size = new Size(size.Width * 2, size.Height * 2);

                RadSvgImage svgImage400 = svgImage.Clone() as RadSvgImage;
                // change default size of the SVG image to 400%
                svgImage400.Size = new Size(size.Width * 4, size.Height * 4);
                
                // create image with the default size of the SVG image
                Image image = svgImage.GetRasterImage();

                // Get raster image scaled to 200% of its original size
                Image image200 = new Bitmap(image, svgImage200.Size);

                // Get raster image scaled to 400% of its original size
                Image image400 = new Bitmap(image, svgImage400.Size);

                // Get the readable name of the file by removing the file extension and the full namespace
                string name = Path.GetFileNameWithoutExtension(file);
                name = name.Substring(name.LastIndexOf('.') + 1);
                name = name.Substring(0, name.Length - 3);
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                this.radGridView1.Rows.Add(textInfo.ToTitleCase(name), svgImage, svgImage200, svgImage400, image, image200, image400);
            }
        }
#endif
    }
}
