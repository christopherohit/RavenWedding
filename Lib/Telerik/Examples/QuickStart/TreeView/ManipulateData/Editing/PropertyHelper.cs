using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.TreeView.ManipulateData.Editing
{
    public class PropertyHelper
    {
        object sourceObject;
        PropertyInfo propertyInfo;

        public PropertyHelper(object sourceObject, string propertyName)
        {
            this.sourceObject = sourceObject;
            propertyInfo = sourceObject.GetType().GetProperty(propertyName);
        }

        public object Value
        {
            get
            {
                return propertyInfo.GetValue(sourceObject, new object[] { });
            }
            set
            {
                propertyInfo.SetValue(sourceObject, value, new object[] { });
            }
        }

        public Type ValueType
        {
            get { return propertyInfo.PropertyType; }
        }

        public override string ToString()
        {
            object value = Value;
            if (value != null)
            {
                if (value.GetType() == typeof(Color))
                {
                    return ((Color)value).Name;
                }
                else if (value.GetType() == typeof(RoundRectShape))
                {
                    RoundRectShape shape = (RoundRectShape)value;
                    return shape.Radius.ToString();
                }
                return value.ToString();
            }
            return "";
        }
    }
}
