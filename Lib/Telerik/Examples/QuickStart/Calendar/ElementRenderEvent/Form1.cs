using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.ElementRenderEvent
{
	public partial class Form1 : ExamplesForm
	{
        private int daysInMonth = 30;

		public Form1()
		{
			InitializeComponent();

            this.radCalendar1.FocusedDate = DateTime.Now;
			this.SelectedControl = this.radCalendar1;
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.PopulateCombo();
            this.PopulateColors();
        }

        #region Event Handlers
        private void radButton1_Click(object sender, EventArgs e)
        {            
			if (this.DatesList.SelectedValue != null)
			{
                this.radCalendar1.FocusedDate = (DateTime)this.DatesList.SelectedValue;
				this.radCalendar1.InvalidateCalendar();
			}
        }
        #endregion

        protected void PopulateCombo() 
        {
            DateTime temp = radCalendar1.DefaultView.ViewStartDate;
            int year = radCalendar1.CurrentCalendar.GetYear(radCalendar1.DefaultView.ViewStartDate);
            int month = radCalendar1.CurrentCalendar.GetMonth(radCalendar1.DefaultView.ViewStartDate);
            this.daysInMonth = radCalendar1.CurrentCalendar.GetDaysInMonth(year, month);
            for (int i = 0; i < this.daysInMonth; i++)
            {
                temp = radCalendar1.CurrentCalendar.AddDays(temp, 1);
                RadListDataItem item = new RadListDataItem(temp.ToShortDateString());
                item.Value = temp;
                this.DatesList.Items.Add(item);
            }

            this.DatesList.DropDownStyle = RadDropDownStyle.DropDownList;
        }

        protected void PopulateColors()
        {
            RadListDataItem item = new RadListDataItem(Color.WhiteSmoke.ToString());
            item.Value = Color.WhiteSmoke;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Yellow.ToString());
            item.Value = Color.Yellow;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Orange.ToString());
            item.Value = Color.Orange;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Pink.ToString());
            item.Value = Color.Pink;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Magenta.ToString());
            item.Value = Color.Magenta;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Red.ToString());
            item.Value = Color.Red;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Purple.ToString());
            item.Value = Color.Purple;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Blue.ToString());
            item.Value = Color.Blue;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Cyan.ToString());
            item.Value = Color.Cyan;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Green.ToString());
            item.Value = Color.Green;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Gray.ToString());
            item.Value = Color.Gray;
            this.ColorList.Items.Add(item);

            item = new RadListDataItem(Color.Brown.ToString());
            item.Value = Color.Brown;
            this.ColorList.Items.Add(item);
        }

		private Color cellBackColor = Color.Empty;

		private void radCalendar1_ElementRender(object sender, RenderElementEventArgs e)
		{
            if (this.DatesList.SelectedItem == null)
            {
                return;
            }

			DateTime renderDate = (DateTime)this.DatesList.SelectedValue;
			if (renderDate.Equals(e.Day.Date))
			{
				if (this.ColorList.SelectedItem != null)
				{
					e.Element.Text = this.radTextBox1.Text;
					e.Element.DrawFill = true;

                    if (cellBackColor == Color.Empty)
                    {
                        cellBackColor = e.Element.BackColor;
                    }

					e.Element.BackColor = (Color)this.ColorList.SelectedValue;
					e.Element.Invalidate();
				}
			}
            else
            {
                e.Element.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.Element.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);             
            }
		}

        protected override void WireEvents()
        {
            this.radCalendar1.ElementRender += new Telerik.WinControls.UI.RenderElementEventHandler(this.radCalendar1_ElementRender);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }

	}
}