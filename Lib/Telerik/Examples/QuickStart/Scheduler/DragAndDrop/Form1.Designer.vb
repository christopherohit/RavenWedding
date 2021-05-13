Namespace Telerik.Examples.WinControls.Scheduler.DragAndDrop
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dateTimeInterval2 As New Telerik.WinControls.UI.DateTimeInterval()
            Dim schedulerDailyPrintStyle2 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Dim gridViewDecimalColumn10 As New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn13 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDateTimeColumn7 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim gridViewDateTimeColumn8 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim gridViewTextBoxColumn14 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn11 As New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewTextBoxColumn15 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewTextBoxColumn16 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim gridViewDecimalColumn12 As New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim gridViewCheckBoxColumn4 As New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim gridViewComboBoxColumn7 As New Telerik.WinControls.UI.GridViewComboBoxColumn()
            Dim gridViewComboBoxColumn8 As New Telerik.WinControls.UI.GridViewComboBoxColumn()
            Dim sortDescriptor4 As New Telerik.WinControls.Data.SortDescriptor()
            Me.appointmentStatusesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.schedulerDragAndDropDataDataSet = New Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSet()
            Me.appointmentBackgroundsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
            Me.appointmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
            Me.appointmentsTableAdapter = New Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSetTableAdapters.AppointmentsTableAdapter()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonAnywhere = New Telerik.WinControls.UI.RadRadioButton()
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel3 = New Telerik.WinControls.UI.SplitPanel()
            Me.splitPanel4 = New Telerik.WinControls.UI.SplitPanel()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.checkBoxChangeView = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxExceptionDialog = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxValidationDialogs = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxAutoScroll = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxCreateExceptions = New Telerik.WinControls.UI.RadCheckBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.appointmentStatusesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerDragAndDropDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentBackgroundsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButtonAnywhere, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            DirectCast(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            DirectCast(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            DirectCast(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer2.SuspendLayout()
            DirectCast(Me.splitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel3.SuspendLayout()
            DirectCast(Me.splitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel4.SuspendLayout()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            DirectCast(Me.checkBoxChangeView, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxExceptionDialog, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxValidationDialogs, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxAutoScroll, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkBoxCreateExceptions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox3)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 581)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
            ' 
            ' appointmentStatusesBindingSource
            ' 
            Me.appointmentStatusesBindingSource.DataMember = "AppointmentStatuses"
            Me.appointmentStatusesBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
            ' 
            ' schedulerDragAndDropDataDataSet
            ' 
            Me.schedulerDragAndDropDataDataSet.DataSetName = "SchedulerDragAndDropDataDataSet"
            Me.schedulerDragAndDropDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' appointmentBackgroundsBindingSource
            ' 
            Me.appointmentBackgroundsBindingSource.DataMember = "AppointmentBackgrounds"
            Me.appointmentBackgroundsBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
            ' 
            ' radListBox1
            ' 
            Me.radListBox1.DataSource = Me.appointmentsBindingSource1
            Me.radListBox1.DisplayMember = "Summary"
            Me.radListBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radListBox1.Location = New System.Drawing.Point(0, 0)
            Me.radListBox1.Name = "radListBox1"
            Me.radListBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.radListBox1.Size = New System.Drawing.Size(466, 232)
            Me.radListBox1.TabIndex = 8
            ' 
            ' appointmentsBindingSource1
            ' 
            Me.appointmentsBindingSource1.DataMember = "Appointments"
            Me.appointmentsBindingSource1.DataSource = Me.schedulerDragAndDropDataDataSet
            ' 
            ' radScheduler1
            ' 
            dateTimeInterval2.[End] = New System.DateTime(CLng(0))
            dateTimeInterval2.Start = New System.DateTime(CLng(0))
            Me.radScheduler1.AccessibleInterval = dateTimeInterval2
            Me.radScheduler1.AllowDrop = True
            Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radScheduler1.DataSource = Nothing
            Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScheduler1.Location = New System.Drawing.Point(0, 77)
            Me.radScheduler1.Name = "radScheduler1"
            schedulerDailyPrintStyle2.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            schedulerDailyPrintStyle2.DateEndRange = New System.DateTime(2014, 6, 11, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            schedulerDailyPrintStyle2.DateStartRange = New System.DateTime(2014, 6, 6, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0F, System.Drawing.FontStyle.Bold)
            Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle2
            Me.radScheduler1.Size = New System.Drawing.Size(1487, 594)
            Me.radScheduler1.TabIndex = 6
            Me.radScheduler1.Text = "radScheduler1"
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.BackColor = System.Drawing.SystemColors.Control
            Me.radGridView1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowDeleteRow = False
            gridViewDecimalColumn10.DataType = GetType(Integer)
            gridViewDecimalColumn10.FieldName = "ID"
            gridViewDecimalColumn10.HeaderText = "ID"
            gridViewDecimalColumn10.IsAutoGenerated = True
            gridViewDecimalColumn10.IsVisible = False
            gridViewDecimalColumn10.Name = "ID"
            gridViewTextBoxColumn13.FieldName = "Summary"
            gridViewTextBoxColumn13.HeaderText = "Summary"
            gridViewTextBoxColumn13.IsAutoGenerated = True
            gridViewTextBoxColumn13.Name = "Summary"
            gridViewDateTimeColumn7.FieldName = "Start"
            gridViewDateTimeColumn7.HeaderText = "Start"
            gridViewDateTimeColumn7.IsAutoGenerated = True
            gridViewDateTimeColumn7.Name = "Start"
            gridViewDateTimeColumn8.FieldName = "End"
            gridViewDateTimeColumn8.HeaderText = "End"
            gridViewDateTimeColumn8.IsAutoGenerated = True
            gridViewDateTimeColumn8.Name = "End"
            gridViewTextBoxColumn14.FieldName = "RecurrenceRule"
            gridViewTextBoxColumn14.HeaderText = "RecurrenceRule"
            gridViewTextBoxColumn14.IsAutoGenerated = True
            gridViewTextBoxColumn14.IsVisible = False
            gridViewTextBoxColumn14.Name = "RecurrenceRule"
            gridViewDecimalColumn11.DataType = GetType(Integer)
            gridViewDecimalColumn11.FieldName = "MasterEventID"
            gridViewDecimalColumn11.HeaderText = "MasterEventID"
            gridViewDecimalColumn11.IsAutoGenerated = True
            gridViewDecimalColumn11.IsVisible = False
            gridViewDecimalColumn11.Name = "MasterEventID"
            gridViewTextBoxColumn15.FieldName = "Location"
            gridViewTextBoxColumn15.HeaderText = "Location"
            gridViewTextBoxColumn15.IsAutoGenerated = True
            gridViewTextBoxColumn15.Name = "Location"
            gridViewTextBoxColumn16.FieldName = "Description"
            gridViewTextBoxColumn16.HeaderText = "Description"
            gridViewTextBoxColumn16.IsAutoGenerated = True
            gridViewTextBoxColumn16.MaxWidth = 50
            gridViewTextBoxColumn16.Name = "Description"
            gridViewTextBoxColumn16.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
            gridViewTextBoxColumn16.Width = 5
            gridViewDecimalColumn12.DataType = GetType(Integer)
            gridViewDecimalColumn12.FieldName = "ParentID"
            gridViewDecimalColumn12.HeaderText = "ParentID"
            gridViewDecimalColumn12.IsAutoGenerated = True
            gridViewDecimalColumn12.IsVisible = False
            gridViewDecimalColumn12.Name = "ParentID"
            gridViewCheckBoxColumn4.FieldName = "Visible"
            gridViewCheckBoxColumn4.HeaderText = "Visible"
            gridViewCheckBoxColumn4.IsAutoGenerated = True
            gridViewCheckBoxColumn4.IsVisible = False
            gridViewCheckBoxColumn4.Name = "Visible"
            gridViewComboBoxColumn7.DataSource = Me.appointmentStatusesBindingSource
            gridViewComboBoxColumn7.DataType = GetType(Integer)
            gridViewComboBoxColumn7.DisplayMember = "Name"
            gridViewComboBoxColumn7.FieldName = "StatusID"
            gridViewComboBoxColumn7.HeaderText = "Status"
            gridViewComboBoxColumn7.Name = "StatusID"
            gridViewComboBoxColumn7.ValueMember = "ID"
            gridViewComboBoxColumn8.DataSource = Me.appointmentBackgroundsBindingSource
            gridViewComboBoxColumn8.DataType = GetType(Integer)
            gridViewComboBoxColumn8.DisplayMember = "Name"
            gridViewComboBoxColumn8.FieldName = "BackgroundID"
            gridViewComboBoxColumn8.HeaderText = "Background"
            gridViewComboBoxColumn8.Name = "BackgroundID"
            gridViewComboBoxColumn8.ValueMember = "ID"
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {gridViewDecimalColumn10, gridViewTextBoxColumn13, gridViewDateTimeColumn7, gridViewDateTimeColumn8, gridViewTextBoxColumn14, gridViewDecimalColumn11, _
                gridViewTextBoxColumn15, gridViewTextBoxColumn16, gridViewDecimalColumn12, gridViewCheckBoxColumn4, gridViewComboBoxColumn7, gridViewComboBoxColumn8})
            Me.radGridView1.MasterTemplate.DataSource = Me.appointmentsBindingSource
            sortDescriptor4.PropertyName = "Description"
            Me.radGridView1.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {sortDescriptor4})
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.radGridView1.ShowGroupPanel = False
            Me.radGridView1.Size = New System.Drawing.Size(1017, 232)
            Me.radGridView1.TabIndex = 2
            ' 
            ' appointmentsBindingSource
            ' 
            Me.appointmentsBindingSource.DataMember = "Appointments"
            Me.appointmentsBindingSource.DataSource = Me.schedulerDragAndDropDataDataSet
            ' 
            ' radSchedulerNavigator1
            ' 
            Me.radSchedulerNavigator1.AssociatedScheduler = Nothing
            Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
            Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
            Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
            Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
            ' 
            ' 
            ' 
            Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
            Me.radSchedulerNavigator1.RootElement.StretchVertically = False
            Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1487, 77)
            Me.radSchedulerNavigator1.TabIndex = 9
            Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
            ' 
            ' appointmentsTableAdapter
            ' 
            Me.appointmentsTableAdapter.ClearBeforeFill = True
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonAnywhere)
            Me.radGroupBox1.HeaderText = "OLE Drag&Drop"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 37)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
            Me.radGroupBox1.Size = New System.Drawing.Size(180, 78)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "OLE Drag&Drop"
            ' 
            ' radRadioButton2
            ' 
            Me.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton2.Location = New System.Drawing.Point(5, 47)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(111, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.Text = "Keep original date"
            ' 
            ' radRadioButtonAnywhere
            ' 
            Me.radRadioButtonAnywhere.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonAnywhere.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButtonAnywhere.Location = New System.Drawing.Point(5, 23)
            Me.radRadioButtonAnywhere.Name = "radRadioButtonAnywhere"
            Me.radRadioButtonAnywhere.Size = New System.Drawing.Size(96, 18)
            Me.radRadioButtonAnywhere.TabIndex = 0
            Me.radRadioButtonAnywhere.TabStop = True
            Me.radRadioButtonAnywhere.Text = "Drop anywhere"
            Me.radRadioButtonAnywhere.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radSplitContainer1
            ' 
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            Me.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' 
            ' 
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.radSplitContainer1.Size = New System.Drawing.Size(1487, 907)
            Me.radSplitContainer1.TabIndex = 11
            Me.radSplitContainer1.TabStop = False
            Me.radSplitContainer1.Text = "radSplitContainer1"
            ' 
            ' splitPanel1
            ' 
            Me.splitPanel1.Controls.Add(Me.radScheduler1)
            Me.splitPanel1.Controls.Add(Me.radSchedulerNavigator1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            ' 
            ' 
            ' 
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.splitPanel1.Size = New System.Drawing.Size(1487, 671)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0F, 0.2433628F)
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 110)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            ' 
            ' splitPanel2
            ' 
            Me.splitPanel2.Controls.Add(Me.radSplitContainer2)
            Me.splitPanel2.Location = New System.Drawing.Point(0, 675)
            Me.splitPanel2.Name = "splitPanel2"
            ' 
            ' 
            ' 
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.splitPanel2.Size = New System.Drawing.Size(1487, 232)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0F, -0.2433628F)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -110)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            ' 
            ' radSplitContainer2
            ' 
            Me.radSplitContainer2.Controls.Add(Me.splitPanel3)
            Me.radSplitContainer2.Controls.Add(Me.splitPanel4)
            Me.radSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer2.Name = "radSplitContainer2"
            ' 
            ' 
            ' 
            Me.radSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.radSplitContainer2.Size = New System.Drawing.Size(1487, 232)
            Me.radSplitContainer2.TabIndex = 0
            Me.radSplitContainer2.TabStop = False
            Me.radSplitContainer2.Text = "radSplitContainer2"
            ' 
            ' splitPanel3
            ' 
            Me.splitPanel3.Controls.Add(Me.radGridView1)
            Me.splitPanel3.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel3.Name = "splitPanel3"
            ' 
            ' 
            ' 
            Me.splitPanel3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.splitPanel3.Size = New System.Drawing.Size(1017, 232)
            Me.splitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1857708F, 0.0F)
            Me.splitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(100, 0)
            Me.splitPanel3.TabIndex = 0
            Me.splitPanel3.TabStop = False
            Me.splitPanel3.Text = "splitPanel3"
            ' 
            ' splitPanel4
            ' 
            Me.splitPanel4.Controls.Add(Me.radListBox1)
            Me.splitPanel4.Location = New System.Drawing.Point(1021, 0)
            Me.splitPanel4.Name = "splitPanel4"
            ' 
            ' 
            ' 
            Me.splitPanel4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.splitPanel4.Size = New System.Drawing.Size(466, 232)
            Me.splitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1857708F, 0.0F)
            Me.splitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(-100, 0)
            Me.splitPanel4.TabIndex = 1
            Me.splitPanel4.TabStop = False
            Me.splitPanel4.Text = "splitPanel4"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox2.Controls.Add(Me.checkBoxValidationDialogs)
            Me.radGroupBox2.Controls.Add(Me.checkBoxExceptionDialog)
            Me.radGroupBox2.Controls.Add(Me.checkBoxChangeView)
            Me.radGroupBox2.HeaderText = "AppointmentDraggingBehavior"
            Me.radGroupBox2.Location = New System.Drawing.Point(10, 121)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(180, 100)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "AppointmentDraggingBehavior"
            ' 
            ' radGroupBox3
            ' 
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox3.Controls.Add(Me.checkBoxCreateExceptions)
            Me.radGroupBox3.Controls.Add(Me.checkBoxAutoScroll)
            Me.radGroupBox3.HeaderText = "DragDrop and Resize"
            Me.radGroupBox3.Location = New System.Drawing.Point(10, 227)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Size = New System.Drawing.Size(180, 72)
            Me.radGroupBox3.TabIndex = 2
            Me.radGroupBox3.Text = "DragDrop and Resize"
            ' 
            ' checkBoxChangeView
            ' 
            Me.checkBoxChangeView.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBoxChangeView.Location = New System.Drawing.Point(5, 22)
            Me.checkBoxChangeView.Name = "checkBoxChangeView"
            Me.checkBoxChangeView.Size = New System.Drawing.Size(126, 18)
            Me.checkBoxChangeView.TabIndex = 0
            Me.checkBoxChangeView.Text = "Navigate view on drag"
            ' 
            ' checkBoxExceptionDialog
            ' 
            Me.checkBoxExceptionDialog.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBoxExceptionDialog.Location = New System.Drawing.Point(5, 44)
            Me.checkBoxExceptionDialog.Name = "checkBoxExceptionDialog"
            Me.checkBoxExceptionDialog.Size = New System.Drawing.Size(139, 18)
            Me.checkBoxExceptionDialog.TabIndex = 1
            Me.checkBoxExceptionDialog.Text = "Ask to create exceptions on drag"
            ' 
            ' checkBoxValidationDialogs
            ' 
            Me.checkBoxValidationDialogs.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBoxValidationDialogs.Location = New System.Drawing.Point(5, 68)
            Me.checkBoxValidationDialogs.Name = "checkBoxValidationDialogs"
            Me.checkBoxValidationDialogs.Size = New System.Drawing.Size(168, 18)
            Me.checkBoxValidationDialogs.TabIndex = 2
            Me.checkBoxValidationDialogs.Text = "Occurrence validation dialogs"
            ' 
            ' checkBoxAutoScroll
            ' 
            Me.checkBoxAutoScroll.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBoxAutoScroll.Location = New System.Drawing.Point(5, 21)
            Me.checkBoxAutoScroll.Name = "checkBoxAutoScroll"
            Me.checkBoxAutoScroll.Size = New System.Drawing.Size(130, 18)
            Me.checkBoxAutoScroll.TabIndex = 1
            Me.checkBoxAutoScroll.Text = "AutoScroll in DayView"
            ' 
            ' checkBoxCreateExceptions
            ' 
            Me.checkBoxCreateExceptions.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBoxCreateExceptions.Location = New System.Drawing.Point(5, 45)
            Me.checkBoxCreateExceptions.Name = "checkBoxCreateExceptions"
            Me.checkBoxCreateExceptions.Size = New System.Drawing.Size(167, 18)
            Me.checkBoxCreateExceptions.TabIndex = 2
            Me.checkBoxCreateExceptions.Text = "Create occurrence exceptions"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1497, 917)
            Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.appointmentStatusesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerDragAndDropDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentBackgroundsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButtonAnywhere, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            DirectCast(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            Me.splitPanel1.PerformLayout()
            DirectCast(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            DirectCast(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer2.ResumeLayout(False)
            DirectCast(Me.splitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel3.ResumeLayout(False)
            DirectCast(Me.splitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel4.ResumeLayout(False)
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            DirectCast(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.radGroupBox3.PerformLayout()
            DirectCast(Me.checkBoxChangeView, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxExceptionDialog, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxValidationDialogs, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxAutoScroll, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkBoxCreateExceptions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radListBox1 As Telerik.WinControls.UI.RadListControl
        Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
        Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private schedulerDragAndDropDataDataSet As Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSet
        Private appointmentsBindingSource As System.Windows.Forms.BindingSource
        Private appointmentsTableAdapter As Telerik.Examples.WinControls.DataSources.SchedulerDragAndDropDataDataSetTableAdapters.AppointmentsTableAdapter
        Private appointmentStatusesBindingSource As System.Windows.Forms.BindingSource
        Private appointmentBackgroundsBindingSource As System.Windows.Forms.BindingSource
        Private appointmentsBindingSource1 As System.Windows.Forms.BindingSource
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonAnywhere As Telerik.WinControls.UI.RadRadioButton
        Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel3 As Telerik.WinControls.UI.SplitPanel
        Private splitPanel4 As Telerik.WinControls.UI.SplitPanel
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents checkBoxValidationDialogs As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents checkBoxExceptionDialog As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents checkBoxChangeView As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents checkBoxCreateExceptions As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents checkBoxAutoScroll As Telerik.WinControls.UI.RadCheckBox

	End Class
End Namespace
