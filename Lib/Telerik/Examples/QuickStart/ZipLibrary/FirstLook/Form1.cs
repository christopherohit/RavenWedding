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

namespace Telerik.Examples.WinControls.ZipLibrary.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 7; i++)
            {
                ListViewDataItem item = new ListViewDataItem("sample text file " + i + ".txt");
                item.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                checkedListView.Items.Add(item);
            }
        }

        private void saveZipFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Zip File | *.zip";
            dialog.FileName = "sample zip file.zip";
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    using (ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Create, false,null))
                    {
                        foreach (ListViewDataItem file in checkedListView.CheckedItems)
                        {
                            using (ZipArchiveEntry entry = zipArchive.CreateEntry(file.Text))
                            {
                                using (MemoryStream ms = CreateNewFile(file.Text))
                                {
                                    Stream entryStream = entry.Open();
                                    Telerik.WinControls.Zip.Extensions.ZipFile.CopyStreamTo(ms, entryStream);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void readZipFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Zip File | *.zip";
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Stream stream = dialog.OpenFile();
                using (ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Read, false,null))
                {
                    radGridView1.DataSource = zipArchive.Entries;
                    foreach (ZipArchiveEntry asd in zipArchive.Entries)
                    {

                    }
                }
            }
        }

        private void clearZipFileButton_Click(object sender, EventArgs e)
        {
            radGridView1.DataSource = null;
        }

        private MemoryStream CreateNewFile(string file)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream, new UTF8Encoding());
            writer.Write(file);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}