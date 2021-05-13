using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using System.IO;
using Telerik.WinControls.Layouts;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.CustomViews
{
    public class GridViewDetailElement : GridVisualElement, IGridView
    {
        #region Fields

        private RadGridViewElement gridElement;
        private GridViewInfo viewInfo;

        private ReflectiveImagePrimitive imagePrimitive;
        private RadGroupBoxElement groupBoxElement;

        private RadLabelElement labelPosition;
        private RadLabelElement labelHireDate;
        private RadLabelElement labelBirthDate;
        private LightVisualElement labelNotes;

        private StackLayoutElement groupBoxStackLayout;
        private StackLayoutElement groupBoxStackLayoutFirstColumn;

        #endregion

        #region Initialization

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Padding = new System.Windows.Forms.Padding(10);
            this.StretchHorizontally = true;
            this.MinSize = new Size(0, 190);
            this.MaxSize = new Size(0, 190);
            this.DrawFill = true;
            this.Class = "RowFill";
        }

        private void SetElementStyles()
        {
            this.DrawFill = true;
            this.BackColor = Color.Gray;
            this.GradientStyle = GradientStyles.Solid;

            this.groupBoxElement.BackColor = Color.White;
            this.groupBoxElement.ForeColor = Color.Black;
            this.groupBoxElement.Header.BackColor = Color.White;
            this.groupBoxElement.Header.ForeColor = Color.Black;
            this.groupBoxElement.Content.BackColor = Color.White;
            this.groupBoxElement.Content.ForeColor = Color.Black;
            this.labelPosition.BackColor = Color.White;
            this.labelPosition.ForeColor = Color.Black;
            this.labelBirthDate.BackColor = Color.White;
            this.labelBirthDate.ForeColor = Color.Black;
            this.labelHireDate.BackColor = Color.White;
            this.labelHireDate.ForeColor = Color.Black;
            this.labelNotes.BackColor = Color.White;
            this.labelNotes.ForeColor = Color.Black;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            StackLayoutElement stack = new StackLayoutElement();
            stack.StretchVertically = true;
            stack.StretchHorizontally = true;
            stack.Orientation = System.Windows.Forms.Orientation.Horizontal;
            stack.ElementSpacing = 10;
            this.Children.Add(stack);

            this.imagePrimitive = new ReflectiveImagePrimitive();
            this.imagePrimitive.StretchVertically = true;
            stack.Children.Add(this.imagePrimitive);

            this.groupBoxElement = new RadGroupBoxElement();
            this.groupBoxElement.Header.Font = new Font(this.groupBoxElement.Header.Font.FontFamily, 10, FontStyle.Bold);
            this.groupBoxElement.Content.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxElement.StretchHorizontally = true;
            this.groupBoxElement.StretchVertically = true;
            stack.Children.Add(this.groupBoxElement);

            this.groupBoxStackLayout = new StackLayoutElement();
            this.groupBoxStackLayout.StretchHorizontally = true;
            this.groupBoxStackLayout.StretchVertically = true;
            this.groupBoxElement.Content.Children.Add(this.groupBoxStackLayout);

            this.groupBoxStackLayoutFirstColumn = new StackLayoutElement();
            this.groupBoxStackLayoutFirstColumn.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.groupBoxStackLayout.Children.Add(this.groupBoxStackLayoutFirstColumn);

            this.labelPosition = new RadLabelElement();
            this.groupBoxStackLayoutFirstColumn.Children.Add(labelPosition);

            this.labelBirthDate = new RadLabelElement();
            this.groupBoxStackLayoutFirstColumn.Children.Add(labelBirthDate);

            this.labelHireDate = new RadLabelElement();
            this.groupBoxStackLayoutFirstColumn.Children.Add(labelHireDate);

            this.labelNotes = new NoteElement();
            this.groupBoxStackLayout.Children.Add(labelNotes);
        }

        #endregion

        #region Properties

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridTableHeaderRowElement);
            }
        }

        #endregion

        #region IGridView Members

        public void Initialize(RadGridViewElement gridElement, GridViewInfo viewInfo)
        {
            this.gridElement = gridElement;
            this.viewInfo = viewInfo;

            this.gridElement.GridControl.CurrentRowChanged += new CurrentRowChangedEventHandler(GridControl_CurrentRowChanged);
            
            this.SetElementStyles();
        }

        public void Detach()
        {
            this.gridElement.GridControl.CurrentRowChanged -= new CurrentRowChangedEventHandler(GridControl_CurrentRowChanged);
            this.gridElement = null;
            this.viewInfo = null;
        }

        public void UpdateView()
        {
            GridViewDataRowInfo dataRow = this.GridViewElement.GridControl.CurrentRow as GridViewDataRowInfo;

            if (dataRow != null)
            {
                byte[] photo = dataRow.Cells["Photo"].Value as byte[];
                using (Image originalImage = ImageHelper.GetImageFromBytes(photo))
                using (Bitmap bitmap2 = new Bitmap(originalImage))
                {
                    imagePrimitive.Image = bitmap2.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }

                string name = String.Format("{0} {1} {2}", dataRow.Cells["TitleOfCourtesy"].Value, dataRow.Cells["FirstName"].Value, dataRow.Cells["LastName"].Value);
                string position = String.Format("<html><b>Position:</b><br/> {0} ", dataRow.Cells["Title"].Value);
                string dateOfBirth = String.Format(@"<html><b>Date of Birth:</b><br/> {0:D}", dataRow.Cells["BirthDate"].Value);
                string hiredDate = String.Format(@"<html><b>Date of Hire:</b><br/> {0:D}", dataRow.Cells["HireDate"].Value);
                string notes = String.Format(@"<html><b>Notes: </b><br/> {0}", dataRow.Cells["Notes"].Value);
                
                this.groupBoxElement.HeaderText = name;

                this.labelPosition.Text = position;
                this.labelBirthDate.Text = dateOfBirth;
                this.labelHireDate.Text = hiredDate;
                this.labelNotes.Text = notes;               
            }
        }

        public RadGridViewElement GridViewElement
        {
            get { return this.gridElement; }
        }

        public GridViewInfo ViewInfo
        {
            get { return this.viewInfo; }
        }

        #endregion

        #region Event Handlers

        private void GridControl_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            this.UpdateView();
        }

        #endregion
    }
}
