using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataEntry.Validation
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radPanel1;

            SetupControls();
        }

        private void SetupControls()
        {
            this.radDataEntry1.ShowValidationPanel = true;
            this.radDataEntry1.ItemDefaultSize = new Size(460, 25);
            this.radDataEntry1.ItemSpace = 8;

            this.radDataEntry1.ItemValidated += new ItemValidatedEventHandler(radDataEntry1_ItemValidated);
            this.radDataEntry1.ItemValidating += new ItemValidatingEventHandler(radDataEntry1_ItemValidating);

            this.radBindingNavigator1.ContextMenuOpening += radBindingNavigator1_ContextMenuOpening;

            BindingList<Person> list = new BindingList<Person>()
            {
                new Person(DateTime.Now, "Adam", "Johnson", Person.OccupationPositions.SuppliesManager, "(555) 222 3333", 1500),
                new Person(DateTime.Now, "Michael", "Philips", Person.OccupationPositions.StaffManager, "(555) 444 4567", 1450),
                new Person(DateTime.Now, "Paul", "Carter", Person.OccupationPositions.Consultant, "(555) 555 4567", 1499)
            };

            this.bindingSource1.DataSource = list;
            this.bindingSource1.AllowNew = true;

            this.radBindingNavigator1.BindingSource = this.bindingSource1;
            this.radDataEntry1.DataSource = this.bindingSource1;
        }

        void radDataEntry1_ItemValidating(object sender, ItemValidatingEventArgs e)
        {
            if (this.radDropDownList1.SelectedItem.Text == "ItemValidating")
            {
                Person person = this.radDataEntry1.CurrentObject as Person;
                string propertyName = e.Label.Text;

                if (propertyName == "First Name")
                {
                    if (person.FirstName.Length < 2 || person.FirstName.Length > 15 || !Regex.IsMatch(person.FirstName, @"^[a-zA-Z]+$"))
                    {
                        string errorMessage = "First Name should be between 2 and 15 chars and can contain only letters.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);
                        e.Cancel = true;

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("First Name");
                    }
                }
                else if (e.Label.Text == "Last Name")
                {
                    if (person.LastName.Length < 2 || person.LastName.Length > 15 || !Regex.IsMatch(person.LastName, @"^[a-zA-Z]+$"))
                    {
                        string errorMessage = "Last Name should be between 2 and 15 chars and can contain only letters.";

                        e.ErrorProvider.SetError((sender as Control), errorMessage);
                        e.Cancel = true;

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Last Name");
                    }
                }
                else if (e.Label.Text == "Salary")
                {
                    if (person.Salary < e.RangeAttribute.MinValue || person.Salary > e.RangeAttribute.MaxValue || !Regex.IsMatch(person.Salary.ToString(), @"^[0-9]+$"))
                    {
                        string errorMessage = "Salary can contain only numbers and should be in range 1500 - 1700.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);
                        e.Cancel = true;

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Salary");
                    }
                }
                else if (e.Label.Text == "Phone Number")
                {
                    bool foundInvalidChar = false;
                    foreach (char c in person.PhoneNumber.ToCharArray())
                    {
                        if (c != ' ' && c != '(' && c != ')' && !char.IsNumber(c))
                        {
                            foundInvalidChar = true;
                            break;
                        }
                    }

                    if (foundInvalidChar)
                    {
                        string errorMessage = "Phone number can contain only numbers.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);
                        e.Cancel = true;

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Phone Number");
                    }
                }
            }
        }

        void radDataEntry1_ItemValidated(object sender, ItemValidatedEventArgs e)
        {
            if (this.radDropDownList1.SelectedItem.Text == "ItemValidated")
            {
                Person person = this.radDataEntry1.CurrentObject as Person;
                string propertyName = e.Label.Text;

                if (e.Label.Text == "First Name")
                {
                    if (person.FirstName.Length < 2 || person.FirstName.Length > 15 || !Regex.IsMatch(person.FirstName, @"^[a-zA-Z]+$"))
                    {
                        string errorMessage = "First Name should be between 2 and 15 chars and can contain only letters.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("First Name");
                    }
                }
                else if (e.Label.Text == "Last Name")
                {
                    if (person.LastName.Length < 2 || person.LastName.Length > 15 || !Regex.IsMatch(person.LastName, @"^[a-zA-Z]+$"))
                    {
                        string errorMessage = "Last Name should be between 2 and 15 chars and can contain only letters.";

                        e.ErrorProvider.SetError((sender as Control), errorMessage);

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Last Name");
                    }
                }
                else if (e.Label.Text == "Salary")
                {
                    if (person.Salary < e.RangeAttribute.MinValue || person.Salary > e.RangeAttribute.MaxValue || !Regex.IsMatch(person.Salary.ToString(), @"^[0-9]+$"))
                    {
                        string errorMessage = "Salary can contain only numbers and should be in range 1500 - 1700.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Salary");
                    }
                }
                else if (e.Label.Text == "Phone Number")
                {
                    bool foundInvalidChar = false;
                    foreach (char c in person.PhoneNumber.ToCharArray())
                    {
                        if (c != ' ' && c != '(' && c != ')' && !char.IsNumber(c))
                        {
                            foundInvalidChar = true;
                            break;
                        }
                    }

                    if (foundInvalidChar)
                    {
                        string errorMessage = "Phone number can contain only numbers.";
                        e.ErrorProvider.SetError((sender as Control), errorMessage);

                        AddErrorLabel(propertyName, errorMessage);
                    }
                    else
                    {
                        e.ErrorProvider.Clear();
                        this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey("Phone Number");
                    }
                }
            }
        }

        private void AddErrorLabel(string propertyName, string errorMessage)
        {
            if (!this.radDataEntry1.ValidationPanel.PanelContainer.Controls.ContainsKey(propertyName))
            {
                RadLabel label = new RadLabel();
                label.Name = propertyName;
                label.Text = "<html><size=10><b>" + propertyName + " : </b>" + errorMessage;
                label.Dock = DockStyle.Top;
                label.MaximumSize = new System.Drawing.Size(480, 0);
                label.TextWrap = true;
                this.radDataEntry1.ValidationPanel.PanelContainer.Controls.Add(label);
            }
        }

        private void radBindingNavigator1_ContextMenuOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (this.IsTouchTheme())
            {
                Size newItemSize = new Size(460, 32);
                if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
                {
                    newItemSize.Height = 36;
                }

                this.radDataEntry1.ItemDefaultSize = newItemSize;
                this.radPanel1.Size = TelerikDpiHelper.ScaleSize(new Size(480, 450), this.radDataEntry1.RootElement.DpiScaleFactor);

                this.SuspendLayout();
                this.radDataEntry1.DataSource = null;
                this.radDataEntry1.DataSource = this.bindingSource1;
                this.ResumeLayout();
            }
        }

        private bool IsTouchTheme()
        {
            return TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || this.CurrentThemeName == "TelerikMetroTouch";
        }
    }
}
