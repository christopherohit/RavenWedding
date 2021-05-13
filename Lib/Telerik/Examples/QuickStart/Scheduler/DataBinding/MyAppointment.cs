using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.Scheduler.DataBinding
{
	public class MyAppointment : INotifyPropertyChanged
	{
		private DateTime start = DateTime.Now;
		private DateTime end = DateTime.Now;
		private string subject = string.Empty;
		private string description = string.Empty;
		private string location = string.Empty;
		private bool visible = true;
		private string email = string.Empty;
		private Guid id = Guid.NewGuid();
		private List<MyResource> resources = null;
		private List<MyAppointment> exceptions = null;
		private string recurrenceRule = null;
		private MyAppointment masterAppointment = null;

		public MyAppointment()
		{
		}

		public MyAppointment(DateTime start, DateTime end, string subject, string description, string location)
		{
			this.start = start;
			this.end = end;
			this.subject = subject;
			this.description = description;
			this.location = location;
		}

		public Guid Id
		{
			get
			{
				return this.id;
			}
		}

		public DateTime Start
		{
			get
			{
				return this.start;
			}
			set
			{
				if (this.start != value)
				{
					this.start = value;
					this.OnPropertyChanged("Start");
				}
			}
		}

		public DateTime End
		{
			get
			{
				return this.end;
			}
			set
			{
				if (this.end != value)
				{
					this.end = value;
					this.OnPropertyChanged("End");
				}
			}
		}

		public string Subject
		{
			get
			{
				return this.subject;
			}
			set
			{
				if (this.subject != value)
				{
					this.subject = value;
					this.OnPropertyChanged("Subject");
				}
			}
		}

		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				if (this.description != value)
				{
					this.description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		public string Location
		{
			get
			{
				return this.location;
			}
			set
			{
				if (this.location != value)
				{
					this.location = value;
					this.OnPropertyChanged("Location");
				}
			}
		}

		public bool Visible
		{
			get
			{
				return this.visible;
			}
			set
			{
				if (this.visible != value)
				{
					this.visible = value;
					this.OnPropertyChanged("Visible");
				}
			}
		}

		public string RecurrenceRule
		{
			get
			{
				return this.recurrenceRule;
			}
			set
			{
				if (this.recurrenceRule != value)
				{
					this.recurrenceRule = value;
					this.OnPropertyChanged("RecurrenceRule");
				}
			}
		}

		public string Email
		{
			get
			{
				return this.email;
			}
			set
			{
				if (this.email != value)
				{
					this.email = value;
					this.OnPropertyChanged("Email");
				}
			}
		}

		public List<MyResource> Resources
		{
			get
			{
				if (this.resources == null)
				{
					this.resources = new List<MyResource>();
				}

				return this.resources;
			}
		}

		public List<MyAppointment> Exceptions
		{
			get
			{
				if (this.exceptions == null)
				{
					this.exceptions = new List<MyAppointment>();
				}
				return this.exceptions;
			}
		}

		public MyAppointment MasterAppointment
		{
			get
			{
				return this.masterAppointment;
			}
			set
			{
				if (this.masterAppointment != value)
				{
					this.masterAppointment = value;
					this.OnPropertyChanged("MasterAppointment");
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
