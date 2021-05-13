using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.CreatingNewItems
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        const int NumberOfObjects = 5;
        private BussinessObject[] list = new BussinessObject[NumberOfObjects];

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();

            this.radListControl1.ItemDataBinding += this.ItemDataBinding;
            this.radListControl1.ItemDataBound += this.ItemDataBound;

            this.radDropDownList1.ItemDataBinding += this.ItemDataBinding;
            this.radDropDownList1.ItemDataBound += this.ItemDataBound;

            this.radDropDownList1.CreatingVisualListItem += new CreatingVisualListItemEventHandler(CreatingVisualListItem);
            this.radListControl1.CreatingVisualListItem += new CreatingVisualListItemEventHandler(CreatingVisualListItem);
       
            this.CreateObjects();            
            this.PrepareDataSourceAndShowDropDown();    
        }

        private void CreateObjects()
        {
            for (int i = 0; i < NumberOfObjects; ++i)
            {
                BussinessObject businessObject = new BussinessObject();
                businessObject.Available = (i % 2) == 0;
                businessObject.Name = " Item " + (i + 1);
                list[i] = businessObject;
                businessObject.PropertyChanged += new PropertyChangedEventHandler(businessObject_PropertyChanged);
            }
        }

        void businessObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.radDropDownList1.Update();
            this.radListControl1.Update();
        }

        private void PrepareDataSourceAndShowDropDown()
        {
            this.radDropDownList1.DataSource = null;
            this.radDropDownList1.DisplayMember = "Name";
            this.radDropDownList1.ValueMember = "Available";
            this.radDropDownList1.DataSource = list;

            this.radListControl1.DataSource = null;
            this.radListControl1.DisplayMember = "Name";
            this.radListControl1.ValueMember = "Available";
            this.radListControl1.DataSource = list;

            this.radDropDownList1.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            this.radDropDownList1.ShowDropDown();
        }

        #endregion

        #region Event Handlers

        private void ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            CustomListDataItem listDataItem = (CustomListDataItem)args.NewItem;
            BussinessObject dataObject = (BussinessObject)listDataItem.DataBoundItem;

            listDataItem.Name = dataObject.Name;
            listDataItem.Available = dataObject.Available;
        }

        private void ItemDataBinding(object sender, ListItemDataBindingEventArgs args)
        {
            args.NewItem = new CustomListDataItem();
        }

        private void CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new CustomListVisualItem();
        }

        #endregion

        protected override void WireEvents()
        {
        }
    }

    public class BussinessObject : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private bool available;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (this.name == value)
                {
                    return;
                }

                this.name = value;
                this.OnNotifyPropertyChanged("Name");
            }
        }

        public bool Available
        {
            get
            {
                return this.available;
            }
            set
            {
                if (this.available == value)
                {
                    return;
                }

                this.available = value;
                this.OnNotifyPropertyChanged("Available");
            }
        }

        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #endregion
    }

    public class CustomListDataItem : RadListDataItem
    {
        #region RadProperties

        public static readonly RadProperty AvailableProperty = RadProperty.Register("Available", typeof(bool), typeof(CustomListDataItem), new RadElementPropertyMetadata(false));
        public static readonly RadProperty NameProperty = RadProperty.Register("Name", typeof(string), typeof(CustomListDataItem), new RadElementPropertyMetadata(""));

        #endregion

        #region Properties

        public bool Available
        {
            get
            {
                return (bool)this.GetValue(CustomListDataItem.AvailableProperty);
            }
            set
            {
                this.SetValue(CustomListDataItem.AvailableProperty, value);
            }
        }

        public string Name
        {
            get
            {
                return (string)this.GetValue(CustomListDataItem.NameProperty);
            }
            set
            {
                this.SetValue(CustomListDataItem.NameProperty, value);
            }
        }

        #endregion

        #region Overrides

        protected override void SetDataBoundItem(bool dataBinding, object value)
        {
            base.SetDataBoundItem(dataBinding, value);
            if (value is INotifyPropertyChanged)
            {
                INotifyPropertyChanged item = value as INotifyPropertyChanged;
                item.PropertyChanged += item_PropertyChanged;
            }
        }

        #endregion

        #region Private Methods

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Available")
            {
                this.Available = (this.DataBoundItem as BussinessObject).Available;
            }

            if (e.PropertyName == "Name")
            {
                this.Name = (this.DataBoundItem as BussinessObject).Name;
            }
        }

        #endregion
    }

    public class CustomListVisualItem : RadListVisualItem
    {
        #region Fields

        private RadLabelElement label = new RadLabelElement();
        private RadCheckBoxElement checkBox = new RadCheckBoxElement();

        #endregion

        #region Initialization

        static CustomListVisualItem()
        {
            RadListVisualItem.SynchronizationProperties.Add(CustomListDataItem.AvailableProperty);
            RadListVisualItem.SynchronizationProperties.Add(CustomListDataItem.NameProperty);
            
        }

        #endregion

        #region Overrides

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.checkBox.ToggleStateChanged += this.ToggleStateChanged;
            this.label.StretchHorizontally = true;
            this.label.TextAlignment = ContentAlignment.MiddleCenter;
            StackLayoutPanel stack = new StackLayoutPanel();
            stack.Orientation = Orientation.Horizontal;
            stack.Children.Add(checkBox);
            stack.Children.Add(label);
            this.Children.Add(stack);
        }

        protected override void PropertySynchronized(RadProperty property)
        {
            CustomListDataItem dataItem = (CustomListDataItem)this.Data;

            if (property == CustomListDataItem.AvailableProperty)
            {
                bool newValue = dataItem.Available;

                this.checkBox.Checked = newValue;

                string itemName = dataItem.Name;
                this.label.Text = this.GetAvailabilityText(itemName, newValue);
            }

            if (property == CustomListDataItem.NameProperty)
            {
                string itemName = dataItem.Name;
                bool available = dataItem.Available;
                this.label.Text = this.GetAvailabilityText(itemName, available);
            }

            this.Text = "";
        }
        
        #endregion

        #region Private Methods

        private string GetAvailabilityText(string itemName, bool available)
        {
            string yesno = available ? " " : " not ";
            return itemName + " is" + yesno + "available";
        }

        private void ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ((BussinessObject)this.Data.DataBoundItem).Available = this.checkBox.Checked;
        }

        #endregion
    }
}
