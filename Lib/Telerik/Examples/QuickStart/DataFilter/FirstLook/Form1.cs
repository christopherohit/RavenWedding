using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataFilter.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

            this.radDataFilter1.NodeRemoved += radDataFilter1_NodeRemoved;
            this.radDataFilter1.Edited += radDataFilter1_Edited;
            this.radDataFilter1.EditorInitialized += radDataFilter1_EditorInitialized;
            this.radDataFilter1.DragEnded += radDataFilter1_DragEnded;
        }

        private void radDataFilter1_EditorInitialized(object sender, TreeNodeEditorInitializedEventArgs e)
        {
            DataFilterCriteriaElement criteriaElement = e.NodeElement as DataFilterCriteriaElement;
            DataFilterCriteriaNode criteriaNode = e.Node as DataFilterCriteriaNode;
            TreeViewSpinEditor spinEditor = e.Editor as TreeViewSpinEditor;
            if (criteriaElement != null && criteriaElement.EditingElement == criteriaElement.ValueElement && spinEditor != null)
            {
                string propertyName = criteriaNode.PropertyName;
                decimal minValue = decimal.MinValue;
                decimal maxValue = decimal.MaxValue;

                if (propertyName == "OrderID")
                {
                    minValue = 10000;
                    maxValue = 12000;
                }
                else if (propertyName == "EmployeeID")
                {
                    minValue = 1;
                    maxValue = 10;
                }
                else if (propertyName == "ShipVia")
                {
                    minValue = 1;
                    maxValue = 5;
                }
                else if (propertyName == "Freight")
                {
                    minValue = 0;
                    maxValue = 20000;
                }

                spinEditor.MinValue = minValue;
                spinEditor.MaxValue = maxValue;
            }
            var editor = e.Editor as TreeViewDropDownListEditor;
            if (editor != null)
            {
                var element = editor.EditorElement as BaseDropDownListEditorElement;
                element.DropDownMinSize = new Size(170,0);
            }
        }

        void radDataFilter1_DragEnded(object sender, RadTreeViewDragEventArgs e)
        {
            this.ApplyFilter();
        }

        void radDataFilter1_NodeRemoved(object sender, RadTreeViewEventArgs e)
        {
            this.ApplyFilter();
        }

        void radDataFilter1_Edited(object sender, TreeNodeEditedEventArgs e)
        {
            DataFilterCriteriaNode criteriaNode = e.Node as DataFilterCriteriaNode;
            if (criteriaNode != null)
            {
                bool isFieldNameEmpty = TelerikHelper.StringIsNullOrWhiteSpace(criteriaNode.PropertyName);
                bool isOperatorValid = criteriaNode.FilterOperator != FilterOperator.None;
                bool isValueRequired = criteriaNode.FilterOperator != FilterOperator.IsNull && criteriaNode.FilterOperator != FilterOperator.IsNotNull;
                bool hasValue = criteriaNode.DescriptorValue != null && criteriaNode.DescriptorValue.ToString() != string.Empty;

                if (!isFieldNameEmpty &&
                    isOperatorValid &&
                    (!isValueRequired ||
                    (isValueRequired && hasValue)))
                {
                    this.ApplyFilter();
                }
            }

            DataFilterGroupNode groupNode = e.Node as DataFilterGroupNode;
            if (groupNode != null)
            {
                this.ApplyFilter();
            }
        }

        private void ApplyFilter()
        {
            try
            {
                this.radDataFilter1.ApplyFilter();
            }
            catch (Exception)
            {
                RadMessageBox.Show(this.radDataFilter1, "Please, enter valid parameters", "Expression is not valid");
            }
        }
    }
}