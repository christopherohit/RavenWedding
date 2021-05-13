namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
{
    partial class CustomEditAppointmentDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomEditAppointmentDialog));
            this.timeEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.timeStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblEndTime = new Telerik.WinControls.UI.RadLabel();
            this.lblStartTime = new Telerik.WinControls.UI.RadLabel();
            this.chkAllDay = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.txtLocation = new Telerik.WinControls.UI.RadTextBox();
            this.txtSubject = new Telerik.WinControls.UI.RadTextBox();
            this.lblLocation = new Telerik.WinControls.UI.RadLabel();
            this.lblSubject = new Telerik.WinControls.UI.RadLabel();
            this.cmbShowTimeAs = new Telerik.WinControls.UI.RadDropDownList();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.ribbonBarAppointment = new Telerik.WinControls.UI.RadRibbonBar();
            this.tabAppointment = new Telerik.WinControls.UI.RibbonTab();
            this.grActions = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnSave = new Telerik.WinControls.UI.RadButtonElement();
            this.btnDelete = new Telerik.WinControls.UI.RadButtonElement();
            this.grOptions = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnRecurrence = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.lblEmail = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBarAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEnd.Checked = true;
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(211, 242);
            this.timeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(88, 22);
            this.timeEnd.TabIndex = 5;
            this.timeEnd.TabStop = false;
            this.timeEnd.Value = new System.DateTime(2008, 9, 12, 16, 55, 40, 944);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEnd.Checked = true;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(89, 242);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Size = new System.Drawing.Size(116, 22);
            this.dateEnd.TabIndex = 4;
            this.dateEnd.TabStop = false;
            this.dateEnd.Value = new System.DateTime(2008, 9, 12, 16, 55, 37, 429);
            // 
            // timeStart
            // 
            this.timeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStart.Checked = true;
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(211, 214);
            this.timeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(88, 22);
            this.timeStart.TabIndex = 3;
            this.timeStart.TabStop = false;
            this.timeStart.Value = new System.DateTime(2008, 9, 12, 16, 55, 34, 944);
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.Checked = true;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(89, 214);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStart.Size = new System.Drawing.Size(116, 22);
            this.dateStart.TabIndex = 2;
            this.dateStart.TabStop = false;
  
            this.dateStart.Value = new System.DateTime(2008, 9, 12, 16, 51, 38, 596);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(7, 243);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(54, 16);
            this.lblEndTime.TabIndex = 14;
            this.lblEndTime.Text = "End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(7, 220);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 16);
            this.lblStartTime.TabIndex = 13;
            this.lblStartTime.Text = "Start time:";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAllDay.Location = new System.Drawing.Point(305, 219);
            this.chkAllDay.Name = "chkAllDay";
            this.chkAllDay.Size = new System.Drawing.Size(87, 17);
            this.chkAllDay.TabIndex = 6;
            this.chkAllDay.Text = "All day event";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(7, 340);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            // 
            // 
            // 
            this.txtDescription.RootElement.StretchVertically = true;
            this.txtDescription.Size = new System.Drawing.Size(573, 205);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TabStop = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(89, 185);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(491, 20);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TabStop = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(89, 159);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(491, 20);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(7, 189);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(52, 16);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(7, 162);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(47, 16);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Subject:";
            // 
            // cmbShowTimeAs
            // 
            this.cmbShowTimeAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShowTimeAs.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbShowTimeAs.Location = new System.Drawing.Point(89, 275);
            this.cmbShowTimeAs.Name = "cmbShowTimeAs";
            // 
            // 
            // 
            this.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cmbShowTimeAs.Size = new System.Drawing.Size(210, 20);
            this.cmbShowTimeAs.TabIndex = 7;
            this.cmbShowTimeAs.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(7, 275);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Show time as:";
            // 
            // ribbonBarAppointment
            // 
            this.ribbonBarAppointment.AutoSize = true;
            this.ribbonBarAppointment.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabAppointment});
            this.ribbonBarAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBarAppointment.EnableKeyMap = true;
            // 
            // 
            // 
            this.ribbonBarAppointment.ExitButton.Text = "Exit";
            this.ribbonBarAppointment.Location = new System.Drawing.Point(0, 0);
            this.ribbonBarAppointment.Name = "ribbonBarAppointment";
            // 
            // 
            // 
            this.ribbonBarAppointment.OptionsButton.Text = "Options";
            this.ribbonBarAppointment.Size = new System.Drawing.Size(616, 153);
            this.ribbonBarAppointment.TabIndex = 10;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.ribbonBarAppointment.GetChildAt(0))).Text = "";
            this.ribbonBarAppointment.RibbonBarElement.QuickAccessToolBar.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // tabAppointment
            // 
            this.tabAppointment.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabAppointment.ContentPanel
            // 
            this.tabAppointment.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabAppointment.ContentPanel.CausesValidation = true;
            this.tabAppointment.ContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabAppointment.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabAppointment.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.tabAppointment.ContentPanel.Size = new System.Drawing.Size(200, 100);
            this.tabAppointment.IsSelected = true;
            this.tabAppointment.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.grActions,
            this.grOptions});
            this.tabAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.StretchHorizontally = false;
            this.tabAppointment.Text = "Appointment";
            // 
            // grActions
            // 
            this.grActions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSave,
            this.btnDelete});
            this.grActions.Name = "grActions";
            this.grActions.Text = "Actions";
            // 
            // btnSave
            // 
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Class = "RibbonBarButtonElement";
            this.btnSave.Image = global::Telerik.Examples.WinControls.Properties.Resources.SaveAppointment;
            this.btnSave.ImageIndex = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save &&\nClose";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.MeasureTrailingSpaces = false;
  
            // 
            // btnDelete
            // 
            this.btnDelete.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Class = "RibbonBarButtonElement";
            this.btnDelete.Image = global::Telerik.Examples.WinControls.Properties.Resources.DeleteAppointment;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.StretchVertically = false;
   
            // 
            // grOptions
            // 
            this.grOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRecurrence});
            this.grOptions.Name = "grOptions";
            this.grOptions.Text = "Options";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Class = "RibbonBarButtonElement";
            this.btnRecurrence.Image = global::Telerik.Examples.WinControls.Properties.Resources.RecurrenceAppointment;
            this.btnRecurrence.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecurrence.ImageIndex = 2;
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.Text = "Recurrence";
            this.btnRecurrence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(89, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(7, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // CustomEditAppointmentDialog
            // 
            //this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(616, 590);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbShowTimeAs);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkAllDay);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.ribbonBarAppointment);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.MinimumSize = new System.Drawing.Size(600, 365);
            this.Name = "CustomEditAppointmentDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(600, 365);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBarAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar ribbonBarAppointment;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RibbonTab tabAppointment;
        private Telerik.WinControls.UI.RadRibbonBarGroup grActions;
        private Telerik.WinControls.UI.RadButtonElement btnSave;
        protected Telerik.WinControls.UI.RadDateTimePicker timeEnd;
        protected Telerik.WinControls.UI.RadDateTimePicker dateEnd;
        protected Telerik.WinControls.UI.RadDateTimePicker timeStart;
        protected Telerik.WinControls.UI.RadDateTimePicker dateStart;
        private Telerik.WinControls.UI.RadLabel lblEndTime;
        private Telerik.WinControls.UI.RadLabel lblStartTime;
        protected Telerik.WinControls.UI.RadCheckBox chkAllDay;
        protected Telerik.WinControls.UI.RadTextBox txtLocation;
        protected Telerik.WinControls.UI.RadTextBox txtSubject;
        private Telerik.WinControls.UI.RadLabel lblLocation;
        private Telerik.WinControls.UI.RadLabel lblSubject;
        protected Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadButtonElement btnDelete;
        private Telerik.WinControls.UI.RadRibbonBarGroup grOptions;
        private Telerik.WinControls.UI.RadButtonElement btnRecurrence;
        protected Telerik.WinControls.UI.RadDropDownList cmbShowTimeAs;
        private Telerik.WinControls.UI.RadLabel lblStatus;
        protected Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel lblEmail;
    }
}