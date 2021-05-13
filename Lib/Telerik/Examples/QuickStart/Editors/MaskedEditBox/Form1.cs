using System;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.MaskedEditBox
{
	public partial class Form1 : ExamplesForm

	{
		public Form1()
		{
			InitializeComponent();

            this.LoadCultureInfos();

            foreach (Control control in this.doubleBufferedTableLayoutPanel1.Controls)
            {
                
                if (control is RadLabel)
                {
                    control.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                    
                }
            }
        }

        private void LoadCultureInfos()
        {
            SortedList cultures = new SortedList();

			CultureInfo temp;
            for (int i = 0; i < CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length; i++)
            {
                temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)[i];

                if (!cultures.ContainsKey(temp.EnglishName))
                {
                    cultures.Add(temp.EnglishName, temp);
                }
            }

			IEnumerator ie = cultures.Keys.GetEnumerator();
			while (ie.MoveNext())
			{
				string name = (string)ie.Current;
				this.radComboCultures.Items.Add(new RadListDataItem(name, cultures[name]/*.ToString()*/));
			}

            radComboCultures.SelectedItem = radComboCultures.Items[radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName)];
            this.radComboCultures.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(CulturesList_SelectedIndexChanged);
		}

        void CulturesList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
            foreach (Control control in this.doubleBufferedTableLayoutPanel1.Controls)
            {
                if (control is RadMaskedEditBox)
                {
                    RadMaskedEditBox maskEdit = control as RadMaskedEditBox;

                    maskEdit.Culture = (radComboCultures.SelectedValue as CultureInfo);
                    if (maskEdit.MaskType == MaskType.DateTime)
                    {
                        maskEdit.Value = DateTime.Now;
                    }
                }
                 
            }
		}

        private void radTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            this.radMaskedEditBox19.Mask = radTextBox1.Text;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RadMaskedEditBox1.Value = DateTime.Now;
            this.RadMaskedEditBox2.Value = DateTime.Now;
            this.RadMaskedEditBox3.Value = DateTime.Now;
            this.RadMaskedEditBox4.Value = DateTime.Now;
            this.RadMaskedEditBox5.Value = DateTime.Now;
        }

        protected override void WireEvents()
        {
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
        }
	}
}