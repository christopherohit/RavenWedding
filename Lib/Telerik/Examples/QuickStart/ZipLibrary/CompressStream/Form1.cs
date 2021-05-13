using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Zip;

namespace Telerik.Examples.WinControls.ZipLibrary.CompressStream
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            uncompressedTextBoxControl.Text = Constants.XmlText;
            uncompressedTextBoxControl.TextChanged += uncompressedTextBoxControl_TextChanged;

            uncompressedLabel.Text = "Uncompressed size: " + uncompressedTextBoxControl.Text.Length;
            
            Array itemValues = System.Enum.GetValues(typeof(CompressionLevel));
            Array itemNames = System.Enum.GetNames(typeof(CompressionLevel));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                RadListDataItem item = new RadListDataItem(itemNames.GetValue(i).ToString(), itemValues.GetValue(i));
                compressionMethodsDropDownList.Items.Add(item);
            }
            compressionMethodsDropDownList.SelectedIndex = 12;
        }

        void uncompressedTextBoxControl_TextChanged(object sender, EventArgs e)
        {
            uncompressedLabel.Text = "Uncompressed size: " + uncompressedTextBoxControl.Text.Length;
        }

        private void CompressString(string str)
        {
            MemoryStream memoryStream = new MemoryStream();
            DeflateSettings settings = new DeflateSettings();
            settings.CompressionLevel = (CompressionLevel)this.compressionMethodsDropDownList.SelectedValue;
            CompressedStream zipOutputStream = new CompressedStream(memoryStream, StreamOperationMode.Write, settings);
            StreamWriter writer = new StreamWriter(zipOutputStream);
            writer.Write(str);
            writer.Flush();

            compressedTextBoxControl.Text = Convert.ToBase64String(memoryStream.ToArray());
            compressedLabel.Text = "Compressed size: " + compressedTextBoxControl.Text.Length;
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            CompressString(uncompressedTextBoxControl.Text);
        }
    }
}
