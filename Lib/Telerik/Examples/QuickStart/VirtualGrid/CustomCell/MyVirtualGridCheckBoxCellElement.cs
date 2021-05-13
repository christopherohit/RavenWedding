using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.CustomCell
{
    public class MyVirtualGridCheckBoxCellElement : VirtualGridCellElement
    {
        private RadCheckBoxElement checkBox;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.checkBox = new RadCheckBoxElement();
            this.Children.Add(this.checkBox);
        }

        protected override void UpdateInfo(VirtualGridCellValueNeededEventArgs args)
        {
            base.UpdateInfo(args);

            if (args.Value is bool)
            {
                this.checkBox.Checked = (bool)args.Value;
            }

            this.Text = String.Empty;
        }

        public override bool IsCompatible(int data, object context)
        {
            VirtualGridRowElement rowElement = context as VirtualGridRowElement;

            return data == 3 && rowElement.RowIndex >= 0;
        }

        public override void Attach(int data, object context)
        {
            base.Attach(data, context);

            this.checkBox.ToggleStateChanged += checkBox_ToggleStateChanged;
        }

        public override void Detach()
        {
            this.checkBox.ToggleStateChanged -= checkBox_ToggleStateChanged;

            base.Detach();
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(VirtualGridCellElement); }
        }

        private void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.TableElement.GridElement.SetCellValue(this.checkBox.Checked, this.RowIndex, this.ColumnIndex, this.ViewInfo);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            SizeF size = base.ArrangeOverride(finalSize);

            this.checkBox.Arrange(new RectangleF((finalSize.Width - this.checkBox.DesiredSize.Width) / 2f, (finalSize.Height - this.checkBox.DesiredSize.Height) / 2f, this.checkBox.DesiredSize.Width, this.checkBox.DesiredSize.Height));

            return size;
        }
    }
}
