using System;
using System.ComponentModel;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class PaletteObject : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private ChartPalette palette;

        #endregion

        #region Constructor
        public PaletteObject(string name, ChartPalette palette)
        {
            this.name = name;
            this.palette = palette;
        }
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

        public ChartPalette Palette
        {
            get
            {
                return this.palette;
            }
            set
            {
                if (this.palette == value)
                {
                    return;
                }

                this.palette = value;
                this.OnNotifyPropertyChanged("Palette");
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
}
