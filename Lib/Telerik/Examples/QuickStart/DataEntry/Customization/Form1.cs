using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataEntry.Customization
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radDataEntry1;

            this.radDataEntry1.EditorInitializing += new EditorInitializingEventHandler(radDataEntry1_EditorInitializing);
            this.radDataEntry1.ItemInitialized += new ItemInitializedEventHandler(radDataEntry1_ItemInitialized);
            this.radDataEntry1.BindingCreated += new BindingCreatedEventHandler(radDataEntry1_BindingCreated);

            this.radDataEntry1.DataSource = new Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500);
        }

        private void radDataEntry1_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            if (e.DataMember == "Salary")
            {
                e.Binding.Parse += new ConvertEventHandler(Binding_Parse);
            }
        }

        private void radDataEntry1_ItemInitialized(object sender, ItemInitializedEventArgs e)
        {
            SizeF scaleFactor = this.radDataEntry1.RootElement.DpiScaleFactor;
            SizeF descaleFactor = new SizeF(1 / scaleFactor.Width, 1 / scaleFactor.Height);
            if (e.Panel.Controls[1].Text == "First Name")
            {
                e.Panel.Size = new Size(TelerikDpiHelper.ScaleInt(300, scaleFactor), TelerikDpiHelper.ScaleInt(this.radDataEntry1.ItemDefaultSize.Height, descaleFactor));
                e.Panel.Controls[1].Text = "Name";
            }
            else if (e.Panel.Controls[1].Text == "Last Name")
            {
                e.Panel.Size = new Size(TelerikDpiHelper.ScaleInt(160, scaleFactor), TelerikDpiHelper.ScaleInt(this.radDataEntry1.ItemDefaultSize.Height, descaleFactor));
                e.Panel.Controls[1].Visible = false;

                e.Panel.Location = TelerikDpiHelper.ScalePoint(new Point(310, 10), scaleFactor);
            }
            else
            {
                e.Panel.Location = new Point(e.Panel.Location.X, e.Panel.Location.Y - TelerikDpiHelper.ScaleInt(35, scaleFactor));
            }

            if (e.Panel.Controls[0] is RadDateTimePicker)
            {
                e.Panel.Controls[0].ForeColor = Color.MediumVioletRed;
            }

            if (e.Panel.Controls[1].Text == "Note")
            {
                e.Panel.Size = new Size(e.Panel.Size.Width, TelerikDpiHelper.ScaleInt(100, scaleFactor));
                (e.Panel.Controls[0] as RadTextBox).Multiline = true;
            }

            e.Panel.Controls[1].Font = new Font(e.Panel.Controls[1].Font.Name, 12.0F, FontStyle.Bold);
            e.Panel.Controls[1].ForeColor = Color.Red;
        }

        private void radDataEntry1_EditorInitializing(object sender, EditorInitializingEventArgs e)
        {
            if (e.Property.Name == "Salary")
            {
                RadMaskedEditBox radMaskedEditBox = new RadMaskedEditBox();
                radMaskedEditBox.MaskType = MaskType.Numeric;
                radMaskedEditBox.MaskedEditBoxElement.StretchVertically = true;

                e.Editor = radMaskedEditBox;
            }

            if (e.Property.Name == "Password")
            {
                (e.Editor as RadTextBox).PasswordChar = '*';
            }
        }

        private void Binding_Parse(object sender, ConvertEventArgs e)
        {
            int salary = int.Parse(e.Value.ToString(), NumberStyles.Currency);
            e.Value = salary;
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
                this.radDataEntry1.Size = TelerikDpiHelper.ScaleSize(new Size(489, 464), this.radDataEntry1.RootElement.DpiScaleFactor);

                this.SuspendLayout();
                this.radDataEntry1.DataSource = null;
                this.radDataEntry1.DataSource = new Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500);
                this.ResumeLayout();
            }
        }

        private bool IsTouchTheme()
        {
            return TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || this.CurrentThemeName == "TelerikMetroTouch";
        }
    }
}
