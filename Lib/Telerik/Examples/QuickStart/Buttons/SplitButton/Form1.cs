using System;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Buttons.SplitButton
{
	/// <summary>
	/// Main class for the split button example
	/// </summary>
    public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();

            this.CenterPanel = true;
			this.SelectedControl = radSplitButton3;
		}

		private RadElement rotatedElement;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            rotatedElement = radButton1.RootElement.Children[0];
            this.radButton1.ButtonElement.ShowBorder = false;
            this.radButton1.Image = Telerik.WinControls.ResFinder.WinFormsLogoWithText;
            this.radButton1.AutoSize = true;
            SetDefaultItem(radMenuItem1);
        }

		private void radMenuItem1_Click(object sender, EventArgs e)
		{
			rotatedElement.AngleTransform += 10f;
			SetDefaultItem(radMenuItem1);
		}

		private void radMenuItem2_Click(object sender, EventArgs e)
		{
			rotatedElement.AngleTransform -= 10f;
			SetDefaultItem(radMenuItem2);
		}

		private void radButton1_Click(object sender, EventArgs e)
		{			
			rotatedElement.AngleTransform = 0f;
		}

		private void SetDefaultItem(RadMenuItem item)
		{
			radSplitButton3.DefaultItem = item;
			radSplitButton3.ImageIndex = item.ImageIndex;
			radSplitButton3.Text = item.Text;
		}

        protected override void WireEvents()
        {
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
        }
	}
}