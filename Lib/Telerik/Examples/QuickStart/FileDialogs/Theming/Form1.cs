using System;
using Telerik.Examples.WinControls.Editors;

namespace Telerik.Examples.WinControls.FileDialogs.Theming
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;
        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            this.radOpenFileDialog1.OpenFileDialogForm.ThemeName = this.CurrentThemeName;
            this.radOpenFileDialog1.ShowDialog(this);
        }

        private void OpenFolderDialogButton_Click(object sender, EventArgs e)
        {
            this.radOpenFolderDialog1.OpenFolderDialogForm.ThemeName = this.CurrentThemeName;
            this.radOpenFolderDialog1.ShowDialog(this);
        }

        private void SaveFileDialogButton_Click(object sender, EventArgs e)
        {
            this.radSaveFileDialog1.SaveFileDialogForm.ThemeName = this.CurrentThemeName;
            this.radSaveFileDialog1.ShowDialog(this);
        }
    }
}
