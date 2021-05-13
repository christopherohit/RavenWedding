using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Text.RegularExpressions;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PropertyGrid.Validation
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    if (this.radPropertyGrid1 != null)
        //    {
        //        int width = this.ClientSize.Width;
        //        int height = this.ClientSize.Height;
        //        this.radPropertyGrid1.Location = new Point((width - radPropertyGrid1.Size.Width) / 2, (height - radPropertyGrid1.Size.Height) / 2);
        //    }
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AutoScroll = false;

            this.radPropertyGrid1.PropertyValidating += new Telerik.WinControls.UI.PropertyValidatingEventHandler(radPropertyGrid1_PropertyValidating);
            this.radPropertyGrid1.Edited += new PropertyGridItemEditedEventHandler(radPropertyGrid1_Edited);

            PersonInfo person = new PersonInfo();
            person.Name = "John";
            person.Family = "Smith";
            person.Gender = Gender.Male;
            person.Age = 34;
            person.City = "London";
            person.Country = "England";
            person.Phone = "555-343-3456    ";
            person.EMail = "john.smith@microsoft.com";

            radPropertyGrid1.SelectedObject = person;
            radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical;
            radPropertyGrid1.HelpVisible = true;
            radPropertyGrid1.ToolbarVisible = true;
            radPropertyGrid1.PropertyGridElement.SplitElement.HelpElementHeight = 110;

            Timer timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();
            timer.Dispose();

            radPropertyGrid1.Items["Age"].Select();
            radPropertyGrid1.Items["Age"].BeginEdit();
            radPropertyGrid1.ActiveEditor.Value = 12;
            radPropertyGrid1.EndEdit();
        }

        void radPropertyGrid1_Edited(object sender, PropertyGridItemEditedEventArgs e)
        {
            PropertyGridItem item = e.Item as PropertyGridItem;
            item.ErrorMessage = "";
        }

        void radPropertyGrid1_PropertyValidating(object sender, Telerik.WinControls.UI.PropertyValidatingEventArgs e)
        {
            PropertyGridItem item = (PropertyGridItem)e.Item;

            if (e.Item.Name == "Age" && ((decimal)e.NewValue < 18 || (decimal)e.NewValue > 56))
            {
                item.ErrorMessage = "Age must be between 18 and 56!";
                e.Cancel = true;
            }

            if (e.Item.Name == "Phone")
            {
                Regex regex = new Regex("^(\\(?[0-9]{3}\\)?)?\\-?[0-9]{3}\\-?[0-9]{4}$");
                if (e.NewValue == null || !regex.IsMatch(e.NewValue.ToString()))
                {
                    item.ErrorMessage = "This is not a valid phone. Please enter valid phone to continue.";
                    e.Cancel = true;
                }
            }

            if (e.Item.Name == "EMail")
            {
                Regex regex = new Regex("^[A-Za-z0-9_\\-\\.]+@(([A-Za-z0-9\\-])+\\.)+([A-Za-z\\-])+$");
                if (e.NewValue == null || !regex.IsMatch(e.NewValue.ToString()))
                {
                    item.ErrorMessage = "This is not a valid email address. Please enter valid email address to continue.";
                    e.Cancel = true;
                }
            }

            if (e.Item.Name == "Country" || e.Item.Name == "City" || e.Item.Name == "Name" || e.Item.Name == "Family")
            {
                if (string.IsNullOrEmpty(e.NewValue as string))
                {
                    item.ErrorMessage = "Please enter valid data!";
                    e.Cancel = true;
                }
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
