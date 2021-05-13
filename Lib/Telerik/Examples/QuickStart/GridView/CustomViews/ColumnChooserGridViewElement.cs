using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;

namespace Telerik.Examples.WinControls.GridView.CustomViews
{
    public class ColumnChooserGridViewElement : GridVisualElement, IGridView
    {
        #region Fields

        private RadTitleBarElement titleBar;
        private ColumnChooserElement columnChooser;
        private StackLayoutElement stackLayout;

        #endregion

        #region Initialization

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.StretchVertically = true;
            this.MinSize = new Size(200, 0);
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.stackLayout = new StackLayoutElement();
            this.stackLayout.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.stackLayout.StretchVertically = true;
            this.stackLayout.StretchHorizontally = true;
            this.Children.Add(this.stackLayout);

            this.titleBar = new RadTitleBarElement();
            this.titleBar.Text = "Column Chooser";
            this.titleBar.StretchVertically = false;
            this.titleBar.AllowResize = false;
            this.titleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
            this.titleBar.MinimizeButton.Visibility = ElementVisibility.Collapsed;
            this.titleBar.MaximizeRestore += new TitleBarSystemEventHandler(TitleBar_MaximizeRestore);
            this.stackLayout.Children.Add(this.titleBar);

            this.columnChooser = new ColumnChooserElement();
            this.columnChooser.StretchVertically = true;
            this.stackLayout.Children.Add(this.columnChooser);
        }

        private void SetElementStyles()
        {
            this.DrawFill = true;
            this.BackColor = Color.Gray;
            this.GradientStyle = GradientStyles.Solid;

            this.titleBar.BackColor = Color.WhiteSmoke;
            this.titleBar.ForeColor = Color.Black;
        }

        #endregion

        #region Event Handlers

        private void TitleBar_MaximizeRestore(object sender, EventArgs args)
        {
            this.Visibility = ElementVisibility.Collapsed;
            this.GridViewElement.GridControl.ShowColumnChooser(this.columnChooser.ViewTemplate);

            this.GridViewElement.ColumnChooser.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(ColumnChooser_FormClosed);
            this.GridViewElement.ColumnChooser.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ColumnChooser_FormClosed);
        }

        private void ColumnChooser_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this.Visibility = ElementVisibility.Visible;
        }

        #endregion

        #region IGridView Members

        public void Initialize(RadGridViewElement gridElement, GridViewInfo viewInfo)
        {
            columnChooser.Initialize(gridElement, viewInfo);
            this.SetElementStyles();
        }

        public void Detach()
        {
            columnChooser.Detach();
        }

        public void UpdateView()
        {
            columnChooser.UpdateView();
        }

        public RadGridViewElement GridViewElement
        {
            get { return columnChooser.GridViewElement; }
        }

        public GridViewInfo ViewInfo
        {
            get { return columnChooser.ViewInfo; }
        }

        #endregion
    }
}
