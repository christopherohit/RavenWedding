using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.SchedulerDataSetTableAdapters;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using System.Data.OleDb;

namespace Telerik.Examples.WinControls.Scheduler.DataBinding
{
    public partial class Form1 : ExamplesForm
    {
		private List<MyAppointment> appointments = null;
		private List<MyResource> resources = null;
		private SchedulerDataSet schedulerDataSet = null;

        private AppointmentsTableAdapter appointmentsAdapter = new AppointmentsTableAdapter();

        public Form1()
        {
            InitializeComponent();

            appointmentsAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(Adapter_RowUpdated);
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.radSchedulerDemo.ActiveView.StartDate = new DateTime(2009, 3, 7);

			this.rbBusinessObjects.ToggleStateChanged += new StateChangedEventHandler(rbBusinessObjects_ToggleStateChanged);
			this.rbDataSet.ToggleStateChanged += new StateChangedEventHandler(rbDataSet_ToggleStateChanged);

            this.rbBusinessObjects.ToggleState = ToggleState.On;
            this.radLabel1.Visible = false;
            this.radLabel1.ForeColor = Color.Black;

			this.radSchedulerDemo.AppointmentFactory = new CustomAppointmentFactory();

			this.radSchedulerDemo.AppointmentEditDialogShowing += new EventHandler<AppointmentEditDialogShowingEventArgs>(radSchedulerDemo_AppointmentEditDialogShowing);
		}

		private IEditAppointmentDialog appointmentDialog = null;

		void radSchedulerDemo_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
		{
			if(this.appointmentDialog == null)
			{
				this.appointmentDialog = new CustomAppointmentEditForm();
			}
			e.AppointmentEditDialog = this.appointmentDialog;
		}

		void rbDataSet_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			if (args.ToggleState == ToggleState.On)
			{
				this.BindToDataSet();
				this.btnSave.Visible = true;
                this.radLabel1.Visible = true;
			}
		}

		void rbBusinessObjects_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			if (args.ToggleState == ToggleState.On)
			{
				this.BindToBusinessObjects();
				this.btnSave.Visible = false;
                this.radLabel1.Visible = false;
			}
		}

		private void BindToDataSet()
		{
			if (this.schedulerDataSet == null)
			{
				this.schedulerDataSet = new SchedulerDataSet();

				this.appointmentsAdapter.Fill(this.schedulerDataSet.Appointments);

				ResourcesTableAdapter resourcesAdapter = new ResourcesTableAdapter();
				resourcesAdapter.Fill(this.schedulerDataSet.Resources);

				AppointmentsResourcesTableAdapter appointmentsResourcesAdapter = new AppointmentsResourcesTableAdapter();
				appointmentsResourcesAdapter.Fill(this.schedulerDataSet.AppointmentsResources);
			}

			SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
			dataSource.EventProvider.AppointmentFactory = this.radSchedulerDemo.AppointmentFactory;

			AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
			appointmentMappingInfo.Mappings.Add(new SchedulerMapping("Email", "Email"));

			appointmentMappingInfo.UniqueId = "ID";
			appointmentMappingInfo.Start = "Start";
			appointmentMappingInfo.End = "End";
			appointmentMappingInfo.Summary = "Summary";
			appointmentMappingInfo.Description = "Description";
			appointmentMappingInfo.Location = "Location";
			appointmentMappingInfo.BackgroundId = "BackgroundID";
			appointmentMappingInfo.StatusId = "StatusID";
			appointmentMappingInfo.Resources = "AppointmentsAppointmentsResources";
			appointmentMappingInfo.ResourceId = "ResourceID";
			appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
			appointmentMappingInfo.Exceptions = "AppointmentsAppointments";
			appointmentMappingInfo.MasterEventId = "ParentID";
			appointmentMappingInfo.Visible = "Visible";

			dataSource.EventProvider.Mapping = appointmentMappingInfo;
			dataSource.EventProvider.DataSource = this.schedulerDataSet.Appointments;

			ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
			resourceMappingInfo.Id = "ID";
			resourceMappingInfo.Name = "ResourceName";

			dataSource.ResourceProvider.Mapping = resourceMappingInfo;
			dataSource.ResourceProvider.DataSource = this.schedulerDataSet.Resources;

			this.radSchedulerDemo.DataSource = dataSource;
		}

		private void BindToBusinessObjects()
		{
			this.appointments = new List<MyAppointment>();

			DateTime baseDate = new DateTime(2009, 3, 7);
			DateTime[] start = new DateTime[] { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) };
			DateTime[] end = new DateTime[] { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) };
			string[] summaries = new string[] { "Mr. Brown", "Mr. White", "Mrs. Green" };
			string[] descriptions = new string[] { "", "", "" };
			string[] locations = new string[] { "City", "Out of town", "Service Center" };


			MyAppointment appointment = null;
			for (int i = 0; i < summaries.Length; i++)
			{
				appointment = new MyAppointment(start[i], end[i], summaries[i],
					descriptions[i], locations[i]);
				this.appointments.Add(appointment);
			}

			MyAppointment recurringAppointment = new MyAppointment(baseDate.AddHours(7.0), baseDate.AddHours(10.0),
				"Recurring appointment with exceptions", null, null);
			recurringAppointment.RecurrenceRule = "FREQ=DAILY";
			MyAppointment notVisibleException = new MyAppointment(recurringAppointment.Start.AddDays(1.0), recurringAppointment.End.AddDays(1.0),
				"Recurring appointment with exceptions", null, null);
			notVisibleException.MasterAppointment = recurringAppointment;
			notVisibleException.Visible = false;
			recurringAppointment.Exceptions.Add(notVisibleException);
			this.appointments.Add(recurringAppointment);

			//int[] resourceIds = new int[] { 1, 2, 3 };
			string[] resourceNames = new string[] { "Dell Laptop", "Lenovo Laptop", "Toshiba Laptop" };
			this.resources = new List<MyResource>();
			for (int i = 0; i < resourceNames.Length; i++)
			{
				this.resources.Add(new MyResource(resourceNames[i]));
			}

			SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
			dataSource.EventProvider.AppointmentFactory = this.radSchedulerDemo.AppointmentFactory;

			AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
			appointmentMappingInfo.Mappings.Add(new SchedulerMapping("Email", "Email"));

			appointmentMappingInfo.Start = "Start";
			appointmentMappingInfo.End = "End";
			appointmentMappingInfo.Summary = "Subject";
			appointmentMappingInfo.Description = "Description";
			appointmentMappingInfo.Location = "Location";
			appointmentMappingInfo.UniqueId = "Id";
			appointmentMappingInfo.Resources = "Resources";
			appointmentMappingInfo.ResourceId = "Id";
			appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
			appointmentMappingInfo.Exceptions = "Exceptions";
			appointmentMappingInfo.MasterEventId = "MasterAppointment";
			appointmentMappingInfo.Visible = "Visible";
			dataSource.EventProvider.Mapping = appointmentMappingInfo;
			dataSource.EventProvider.DataSource = this.appointments;

			ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
			resourceMappingInfo.Id = "Id";
			resourceMappingInfo.Name = "Name";

			dataSource.ResourceProvider.Mapping = resourceMappingInfo;
			dataSource.ResourceProvider.DataSource = this.resources;

			this.radSchedulerDemo.DataSource = dataSource;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//see http://msdn.microsoft.com/en-us/library/ms171933.aspx
			AppointmentsResourcesTableAdapter appointmentsResourcesAdapter = new AppointmentsResourcesTableAdapter();
            appointmentsResourcesAdapter.Adapter.AcceptChangesDuringUpdate = false;

            SchedulerDataSet.AppointmentsResourcesDataTable newChildRecords = null;
            SchedulerDataSet.AppointmentsResourcesDataTable modifiedChildRecords = null;

			SchedulerDataSet.AppointmentsResourcesDataTable deletedChildRecords =
				this.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Deleted)
				as SchedulerDataSet.AppointmentsResourcesDataTable;

			try
			{
				if (deletedChildRecords != null)
				{
					appointmentsResourcesAdapter.Update(deletedChildRecords);
				}

                this.appointmentsAdapter.Update(this.schedulerDataSet.Appointments);
                //this.schedulerDataSet.Appointments.AcceptChanges();

                newChildRecords = this.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Added)
                as SchedulerDataSet.AppointmentsResourcesDataTable;

                modifiedChildRecords = this.schedulerDataSet.AppointmentsResources.GetChanges(DataRowState.Modified)
                    as SchedulerDataSet.AppointmentsResourcesDataTable;

				if (newChildRecords != null)
				{
					appointmentsResourcesAdapter.Update(newChildRecords);
				}

				if (modifiedChildRecords != null)
				{
					appointmentsResourcesAdapter.Update(modifiedChildRecords);
				}

				this.schedulerDataSet.AcceptChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred during the update process:\n{0}", ex.Message));
			}
			finally
			{
				if (deletedChildRecords != null)
				{
					deletedChildRecords.Dispose();
				}
				if (newChildRecords != null)
				{
					newChildRecords.Dispose();
				}
				if (modifiedChildRecords != null)
				{
					modifiedChildRecords.Dispose();
				}
			}
		}

        //synchronize the appointment id between the dataset and the database
        //http://msdn.microsoft.com/en-us/library/ks9f57t0%28VS.71%29.aspx
        void Adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                SchedulerDataSet.AppointmentsRow appointnmentsRow = e.Row as SchedulerDataSet.AppointmentsRow;
                if (appointnmentsRow != null)
                {
                    this.schedulerDataSet.EnforceConstraints = false;
                    bool oldReadOnly = this.schedulerDataSet.Appointments.IDColumn.ReadOnly;
                    this.schedulerDataSet.Appointments.IDColumn.ReadOnly = false;
                    int newId = GetIndentity();
                    
                    foreach (SchedulerDataSet.AppointmentsResourcesRow row in this.schedulerDataSet.AppointmentsResources)
                    {
                        if (row.RowState == DataRowState.Added && row.AppointmentID == appointnmentsRow.ID)
                        {
                            row.AppointmentID = newId;
                        }
                    }

                    foreach (SchedulerDataSet.AppointmentsRow row in this.schedulerDataSet.Appointments)
                    {
                        if (row.RowState == DataRowState.Added && row[this.schedulerDataSet.Appointments.ParentIDColumn] != DBNull.Value && row.ParentID == appointnmentsRow.ID)
                        {
                            row.ParentID = newId;
                        }
                    }
                    appointnmentsRow.ID = newId;
                    
                    this.schedulerDataSet.Appointments.IDColumn.ReadOnly = oldReadOnly;
                    this.schedulerDataSet.EnforceConstraints = true;
                }
            }
        }

        private int GetIndentity()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = this.appointmentsAdapter.Connection;
            command.CommandText = "Select @@IDENTITY";

            object obj = command.ExecuteScalar();

            return (int)obj;
        }

        protected override void WireEvents()
        {
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        }
    }

	public class AppointmentWithEmail : Appointment
	{
		public AppointmentWithEmail()
			: base()
		{
		}

		private string email = string.Empty;

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

		protected override Event CreateOccurrenceInstance()
		{
			AppointmentWithEmail occurrence = new AppointmentWithEmail();
			occurrence.email = this.email;
			return occurrence;
		}
	}

	public class CustomAppointmentFactory : IAppointmentFactory
	{
		#region IAppointmentFactory Members

		public IEvent CreateNewAppointment()
		{
			return new AppointmentWithEmail();
		}

		#endregion
	}
}
