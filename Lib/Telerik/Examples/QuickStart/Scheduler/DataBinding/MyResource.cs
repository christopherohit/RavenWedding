using System;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.Scheduler.DataBinding
{
	public class MyResource : INotifyPropertyChanged
	{
		private Guid id = Guid.NewGuid();
		private string name = string.Empty;

		public MyResource(string name)
		{
			this.name = name;
		}

		public Guid Id
		{
			get
			{
				return this.id;
			}
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != value)
				{
					this.name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
