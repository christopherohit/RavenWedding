using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.Model.InteractiveForms;

namespace Telerik.Examples.WinControls.PdfProcessing.ReadAndWriteFromFields
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        string sampleFile = @"..\PdfProcessing\ReadAndWriteFromFields\SampleData\InteractiveForms.pdf";
        public Form1()
        {
            InitializeComponent();
            
            this.ProcessDocument(FieldsProcessingType.Read);
            Image sampleImageDocument = Image.FromFile(@"..\PdfProcessing\ReadAndWriteFromFields\SampleData\InteractiveForms.png");
            this.radLabel5.Image = sampleImageDocument;
            this.radLabel5.ImageAlignment = ContentAlignment.MiddleCenter;

            this.splitPanel2.SplitPanelElement.Fill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            this.splitPanel2.ThemeNameChanged += SplitPanel2_ThemeNameChanged;
        }

        private void SplitPanel2_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            this.splitPanel2.BackColor = this.splitPanel1.SplitPanelElement.Fill.BackColor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            radListView1.Items.Clear();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            var item = new ListViewDataItem();
            this.radListView1.Items.Add(item);
            this.radListView1.SelectedItem = item;
            this.radListView1.BeginEdit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.ProcessDocument(FieldsProcessingType.Write);
        }

        private void LoadTemplateButton_Click(object sender, EventArgs e)
        {
            this.ProcessDocument(FieldsProcessingType.Read);
        }

        private void ProcessDocument(FieldsProcessingType processingType)
        {
            using (Stream stream = new FileStream(sampleFile, FileMode.Open, FileAccess.Read))
            {
                var document = new Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider().Import(stream);
                foreach (FormField field in document.AcroForm.FormFields)
                {
                    switch (field.FieldType)
                    {
                        case FormFieldType.TextBox:
                            ProcessTextBox(processingType, (TextBoxField)field);
                            break;
                        case FormFieldType.ListBox:
                            this.ProcessListBox(processingType, (Telerik.Windows.Documents.Fixed.Model.InteractiveForms.ListBoxField)field);
                            break;
                        case FormFieldType.RadioButton:
                            ProcessRadioButtons(processingType, (Telerik.Windows.Documents.Fixed.Model.InteractiveForms.RadioButtonField)field);

                            break;
                        case FormFieldType.CheckBox:
                            ProcessCheckBoxes(processingType, (CheckBoxField)field);
                            break;
                    }
                }

                if (processingType == FieldsProcessingType.Write)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = String.Format("{0} files|*.{1}", "Pdf", "pdf");
                    dialog.FileName = "Result.pdf";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var saveStream = dialog.OpenFile())
                        {
                            var pdfFormatProvider = new Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider();
                            pdfFormatProvider.Export(document, saveStream);
                        }
                    }
                }
            }
        }

        private void ProcessTextBox(FieldsProcessingType processingType, TextBoxField textBoxField)
        {
            if (processingType == FieldsProcessingType.Read)
            {
                this.radTextBox1.Text = textBoxField.Value;
            }
            else
            {
                textBoxField.Value = this.radTextBox1.Text;
            }
        }

        private void ProcessListBox(FieldsProcessingType processingType, Telerik.Windows.Documents.Fixed.Model.InteractiveForms.ListBoxField listField)
        {
            if (processingType == FieldsProcessingType.Read)
            {
                this.radListView1.Items.Clear();
                foreach (Windows.Documents.Fixed.Model.InteractiveForms.ChoiceOption option in listField.Options)
                {
                    var listItem = new ListViewDataItem();
                    listItem.Value = option.Value;
                    if (listField.Value != null && listField.Value.Contains(option))
                    {
                        radListView1.SelectedItem = listItem;
                    }


                    this.radListView1.Items.Add(listItem);
                }
            }
            else
            {
                listField.Options.Clear();

                foreach (ListViewDataItem listViewItem in this.radListView1.Items)
                {
                    string value = listViewItem.Value == null ? " " : listViewItem.Value.ToString();
                    ChoiceOption option = new ChoiceOption(value);
                    listField.Options.Add(option);
                    if (listViewItem.Selected)
                    {
                        listField.Value = new ChoiceOption[] { option };
                    }
                }
            }
        }

        private void ProcessRadioButtons(FieldsProcessingType processingType,   Telerik.Windows.Documents.Fixed.Model.InteractiveForms.RadioButtonField radioField)
        {
            if (processingType == FieldsProcessingType.Read)
            {

                this.radRadioButton1.IsChecked = radioField.Value.Value == this.radRadioButton1.Text;
                this.radRadioButton2.IsChecked = radioField.Value.Value == this.radRadioButton2.Text;
                this.radRadioButton3.IsChecked = radioField.Value.Value == this.radRadioButton3.Text;
            }
            else
            {
                object checkedContent = null;
                if (this.radRadioButton1.IsChecked)
                {
                    checkedContent = radRadioButton1.Text;
                }
                else if (this.radRadioButton2.IsChecked)
                {
                    checkedContent = radRadioButton2.Text;
                }
                else if (this.radRadioButton3.IsChecked)
                {
                    checkedContent = radRadioButton3.Text;
                }

                if (checkedContent != null)
                {
                    radioField.Value = radioField.Options.Where(x => x.Value == checkedContent.ToString()).FirstOrDefault();
                }
            }
        }

        private void ProcessCheckBoxes(FieldsProcessingType processingType, CheckBoxField checkBoxField)
        {
            if (processingType == FieldsProcessingType.Read)
            {
                if (checkBoxField.Name.Contains("1"))
                {
                    this.checkBox1.IsChecked = checkBoxField.IsChecked;
                }
                else if (checkBoxField.Name.Contains("2"))
                {
                    this.checkBox2.IsChecked = checkBoxField.IsChecked;
                }
                else if (checkBoxField.Name.Contains("3"))
                {
                    this.checkBox3.IsChecked = checkBoxField.IsChecked;
                }
            }
            else
            {
                if (checkBoxField.Name.Contains("1"))
                {
                    checkBoxField.IsChecked = this.checkBox1.IsChecked;
                }
                else if (checkBoxField.Name.Contains("2"))
                {
                    checkBoxField.IsChecked = this.checkBox2.IsChecked;
                }
                else if (checkBoxField.Name.Contains("3"))
                {
                    checkBoxField.IsChecked = this.checkBox3.IsChecked;
                }
            }
        }
    }

    public enum FieldsProcessingType
    {
        /// <summary>
        /// Writes the field values.
        /// </summary>
        Write,

        /// <summary>
        /// Reads the field values.
        /// </summary>
        Read,
    }
}
