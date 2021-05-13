using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;
using BugTracker.Properties;
using System.IO;

namespace BugTracker
{
    public partial class RadRibbonForm1 : Telerik.WinControls.UI.RadRibbonForm
    {
        #region Fields
        private DataSet dataSet;
        #endregion

        #region Enumerators
        enum Status
        {
            InProgress,
            Done,
            ReadyForTest,
            Deleted,
            NotDone
        };

        enum Priority
        {
            Low,
            High,
            Blocking
        }

        enum Type
        {
            Bug,
            Feature
        }
        #endregion

        #region Constructor

        public RadRibbonForm1()
        {
            InitializeComponent();

            //the following function fills the source.xml and XMLSchema.xsd files with sample data
            //FillData();

            CustomizeRibbon();
            FillDataSet();
            SetupProjectTreeView();
            SetupBugsGrid();
            SetupFeaturesGrid();
            BindControls();
            SubscribeToEvents();
            ReadOnlyControls(true);

            ThemeResolutionService.ApplicationThemeName = this.telerikMetroTheme1.ThemeName;

            foreach (DocumentWindow w in this.radDock1.DockWindows.DocumentWindows)
            {
                w.CloseAction = DockWindowCloseAction.Hide;
            }

            ThemeResolutionService.ApplicationThemeName = this.telerikMetroTheme1.ThemeName;
        }

        #endregion

        #region Methods

        private void ReadOnlyControls(bool readOnly)
        {
            titleTextBox.ReadOnly = readOnly;
            idSpinEditor.ReadOnly = readOnly;
            descriptionTextBox.ReadOnly = readOnly;
            stepsToReproduceTextBox.ReadOnly = readOnly;
            idSpinEditor.ShowUpDownButtons = !readOnly;

            dateDateTimePicker.DateTimePickerElement.TextBoxElement.TextBoxItem.ReadOnly = readOnly;
            RadArrowButtonElement arrowButton = dateDateTimePicker.DateTimePickerElement.ArrowButton;
            arrowButton.Visibility = readOnly ? Telerik.WinControls.ElementVisibility.Collapsed : Telerik.WinControls.ElementVisibility.Visible;

            priorityDropDownList.DropDownListElement.ArrowButton.Visibility = readOnly ? Telerik.WinControls.ElementVisibility.Collapsed : Telerik.WinControls.ElementVisibility.Visible;
            priorityDropDownList.DropDownListElement.TextBox.TextBoxItem.ReadOnly = readOnly;

            statusDropDownList.DropDownListElement.ArrowButton.Visibility = readOnly ? Telerik.WinControls.ElementVisibility.Collapsed : Telerik.WinControls.ElementVisibility.Visible;
            statusDropDownList.DropDownListElement.TextBox.TextBoxItem.ReadOnly = readOnly;

            ownerDropDownList.DropDownListElement.ArrowButton.Visibility = readOnly ? Telerik.WinControls.ElementVisibility.Collapsed : Telerik.WinControls.ElementVisibility.Visible;
            ownerDropDownList.DropDownListElement.TextBox.TextBoxItem.ReadOnly = readOnly;
        }

        private void BindControls()
        {
            titleTextBox.DataBindings.Add(new Binding("Text", dataSet.Tables["Issue"], "Title"));
            idSpinEditor.DataBindings.Add(new Binding("Value", dataSet.Tables["Issue"], "Id"));
            dateDateTimePicker.DataBindings.Add(new Binding("Value", dataSet.Tables["Issue"], "Date"));
            descriptionTextBox.DataBindings.Add(new Binding("Text", dataSet.Tables["Issue"], "Description"));
            stepsToReproduceTextBox.DataBindings.Add(new Binding("Text", dataSet.Tables["Issue"], "StepsToReproduce"));

            priorityDropDownList.DataSource = new BindingList<Priority>() { Priority.Low, Priority.High, Priority.Blocking };
            priorityDropDownList.DataBindings.Add(new Binding("SelectedValue", dataSet.Tables["Issue"], "Priority", false, DataSourceUpdateMode.OnPropertyChanged));
            priorityDropDownList.DataBindings.Add(new Binding("SelectedIndex", dataSet.Tables["Issue"], "Priority", false, DataSourceUpdateMode.OnPropertyChanged));

            statusDropDownList.DataSource = new BindingList<Status>() { Status.InProgress, Status.Done, Status.ReadyForTest, Status.Deleted, Status.NotDone };
            statusDropDownList.DataBindings.Add(new Binding("SelectedValue", dataSet.Tables["Issue"], "Status"));
            statusDropDownList.DataBindings.Add(new Binding("SelectedIndex", dataSet.Tables["Issue"], "Status"));

            ownerDropDownList.DataSource = dataSet.Tables["User"];
            ownerDropDownList.DisplayMember = "Name";
            ownerDropDownList.ValueMember = "Id";
            ownerDropDownList.DataBindings.Add(new Binding("SelectedValue", dataSet.Tables["Issue"], "UserId"));
        }

        private void SubscribeToEvents()
        {
            bugsGrid.CurrentRowChanged += new CurrentRowChangedEventHandler(rowChanged_CurrentRowChanged);
            featuresGrid.CurrentRowChanged += new CurrentRowChangedEventHandler(rowChanged_CurrentRowChanged);
            radDock1.ActiveWindowChanged += new DockWindowEventHandler(radDock1_ActiveWindowChanged);

            titleTextBox.KeyDown += new KeyEventHandler(Controls_KeyDown);
            idSpinEditor.SpinElement.KeyDown += new KeyEventHandler(Controls_KeyDown);
            dateDateTimePicker.KeyDown += new KeyEventHandler(Controls_KeyDown);
            descriptionTextBox.KeyDown += new KeyEventHandler(Controls_KeyDown);
            stepsToReproduceTextBox.KeyDown += new KeyEventHandler(Controls_KeyDown);
            priorityDropDownList.KeyDown += new KeyEventHandler(Controls_KeyDown);
            statusDropDownList.KeyDown += new KeyEventHandler(Controls_KeyDown);
            ownerDropDownList.KeyDown += new KeyEventHandler(Controls_KeyDown);

            office2010BlackButton.Click += new EventHandler(changeThemes);
            office2010BlueButton.Click += new EventHandler(changeThemes);
            office2010SilverButton.Click += new EventHandler(changeThemes);
            telerikButton.Click += new EventHandler(changeThemes);
            controlDefaultButton.Click += new EventHandler(changeThemes);

            dateAscendingMenuItem.Click += new EventHandler(sortGrids);
            ownerAscendingMenuItem.Click += new EventHandler(sortGrids);
            statusAscendingMenuItem.Click += new EventHandler(sortGrids);
            dateDescendingMenuItem.Click += new EventHandler(sortGrids);
            ownerDescendingMenuItem.Click += new EventHandler(sortGrids);
            statusDescendingMenuItem.Click += new EventHandler(sortGrids);
            sortNoneMenuItem.Click += new EventHandler(sortGrids);

            projectsButton.Click += new EventHandler(panelsChange_Click);
            detailsButton.Click += new EventHandler(panelsChange_Click);
            bugsButton.Click += new EventHandler(panelsChange_Click);
            featuresButton.Click += new EventHandler(panelsChange_Click);

            newCheckBox.ToggleStateChanged += new StateChangedEventHandler(filter_grid);
            unassignedCheckBox.ToggleStateChanged += new StateChangedEventHandler(filter_grid);
            openCheckBox.ToggleStateChanged += new StateChangedEventHandler(filter_grid);
            readyForTestCheckBox.ToggleStateChanged += new StateChangedEventHandler(filter_grid);
            doneCheckBox.ToggleStateChanged += new StateChangedEventHandler(filter_grid);

            loadDatabaseMenuItem.Click += new EventHandler(loadDatabaseButton_Click);
            addMenuItem.Click += new EventHandler(addButton_Click);
            removeMenuItem.Click += new EventHandler(removeButton_Click);
            editMenuItem.Click += new EventHandler(editButton_Click);
            aboutMenuItem.Click += new EventHandler(aboutMenuItem_Click);
            exitMenuItem.Click += new EventHandler(exitMenuItem_Click);
        }

        private void SetupProjectTreeView()
        {
            projectsTreeView.DataSource = dataSet.Tables["Project"];
            projectsTreeView.DisplayMember = "Name";
            projectsTreeView.ValueMember = "Id";
            projectsTreeView.ParentMember = "ParentId";
            projectsTreeView.ChildMember = "Id";
            projectsTreeView.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(projectsTreeView_SelectedNodeChanged);
            projectsTreeView.SelectedNode = projectsTreeView.Nodes[0];
        }

        private void SetupBugsGrid()
        {
            bugsGrid.EnableFiltering = true;
            bugsGrid.MasterTemplate.ShowFilteringRow = false;
            bugsGrid.AllowAddNewRow = false;
            bugsGrid.DataSource = dataSet.Tables["Issue"];
            bugsGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            bugsGrid.MasterTemplate.SelectLastAddedRow = true;
            bugsGrid.Columns["ProjectId"].IsVisible = false;
            bugsGrid.Columns["Type"].IsVisible = false;
            bugsGrid.Columns["Description"].IsVisible = false;
            bugsGrid.Columns["StepsToReproduce"].IsVisible = false;
            bugsGrid.Columns["UserId"].IsVisible = false;
            ((GridViewDateTimeColumn)bugsGrid.Columns["Date"]).FormatString = "{0: dd/M/yyyy}";

            GridViewComboBoxColumn comboCol = new GridViewComboBoxColumn();
            comboCol.Name = "Owner";
            comboCol.HeaderText = "Owner";
            comboCol.DataSource = dataSet.Tables["User"];
            comboCol.DisplayMember = "Name";
            comboCol.ValueMember = "Id";
            comboCol.FieldName = "UserId";
            bugsGrid.Columns.Add(comboCol);

            comboCol.MaxWidth = 70;
            bugsGrid.Columns["Id"].MaxWidth = 20;
            bugsGrid.Columns["Status"].MaxWidth = 80;
            bugsGrid.Columns["Date"].MaxWidth = 70;
            bugsGrid.Columns["Priority"].MaxWidth = 60;
            bugsGrid.Columns["Title"].BestFit();

            bugsGrid.FilterDescriptors.Clear();
            FilterDescriptor filterByBugs = new FilterDescriptor();
            filterByBugs.PropertyName = "Type";
            filterByBugs.Operator = FilterOperator.IsEqualTo;
            filterByBugs.Value = Type.Bug;
            this.bugsGrid.FilterDescriptors.Add(filterByBugs);

        }

        private void SetupFeaturesGrid()
        {
            featuresGrid.EnableFiltering = true;
            featuresGrid.MasterTemplate.ShowFilteringRow = false;
            featuresGrid.AllowAddNewRow = false;
            featuresGrid.DataSource = dataSet.Tables["Issue"];
            featuresGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            featuresGrid.MasterTemplate.SelectLastAddedRow = true;
            featuresGrid.Columns["ProjectId"].IsVisible = false;
            featuresGrid.Columns["Type"].IsVisible = false;
            featuresGrid.Columns["Description"].IsVisible = false;
            featuresGrid.Columns["StepsToReproduce"].IsVisible = false;
            featuresGrid.Columns["UserId"].IsVisible = false;
            ((GridViewDateTimeColumn)featuresGrid.Columns["Date"]).FormatString = "{0: dd/M/yyyy}";

            GridViewComboBoxColumn comboCol = new GridViewComboBoxColumn();
            comboCol.Name = "Owner";
            comboCol.HeaderText = "Owner";
            comboCol.DataSource = dataSet.Tables["User"];
            comboCol.DisplayMember = "Name";
            comboCol.ValueMember = "Id";
            comboCol.FieldName = "UserId";
            featuresGrid.Columns.Add(comboCol);

            comboCol.MaxWidth = 70;
            featuresGrid.Columns["Id"].MaxWidth = 20;
            featuresGrid.Columns["Status"].MaxWidth = 80;
            featuresGrid.Columns["Date"].MaxWidth = 70;
            featuresGrid.Columns["Priority"].MaxWidth = 60;
            featuresGrid.Columns["Title"].BestFit();

            featuresGrid.FilterDescriptors.Clear();
            FilterDescriptor filterByFeature = new FilterDescriptor();
            filterByFeature.PropertyName = "Type";
            filterByFeature.Operator = FilterOperator.IsEqualTo;
            filterByFeature.Value = Type.Feature;
            this.featuresGrid.FilterDescriptors.Add(filterByFeature);

        }

        private void CustomizeRibbon()
        {
            radRibbonBar1.RibbonBarElement.ApplicationMenuRightColumnWidth = 0;
            radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            RibbonBar.ExitButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            Telerik.WinControls.UI.InnerItem item = RibbonBar.RibbonBarElement.QuickAccessToolBar.InnerItem;
            item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            radRibbonBar1.StartButtonImage = Resources.bug_logo;
        }

        private void FillDataSet()
        {
            dataSet = new DataSet();
            dataSet.ReadXmlSchema(@"XMLSchema.xsd");
            dataSet.ReadXml(@"source.xml");
        }

        private void FillData()
        {
            DataTable user = new DataTable("User");
            DataTable project = new DataTable("Project");
            DataTable issue = new DataTable("Issue");

            dataSet = new DataSet();
            dataSet.Tables.Add(user);
            dataSet.Tables.Add(project);
            dataSet.Tables.Add(issue);

            user.Columns.Add("Id", typeof(int));
            user.Columns.Add("Name", typeof(string));

            user.Rows.Add(1, "");
            user.Rows.Add(2, "Charlie");
            user.Rows.Add(3, "Brandon");
            user.Rows.Add(4, "Dean");
            user.Rows.Add(5, "George");

            project.Columns.Add("Id", typeof(int));
            project.Columns.Add("ParentId", typeof(int));
            project.Columns.Add("Name", typeof(string));

            project.Rows.Add(0, DBNull.Value, "All");
            project.Rows.Add(1, 0, "Controls Team");
            project.Rows.Add(2, 0, "Input Controls Team");
            project.Rows.Add(3, 0, "Examples Team");
            project.Rows.Add(4, 0, "Themes Team");

            issue.Columns.Add("Id", typeof(int));
            issue.Columns.Add("Title", typeof(string));
            issue.Columns.Add("Description", typeof(string));
            issue.Columns.Add("StepsToReproduce", typeof(string));
            issue.Columns.Add("Status", typeof(Status));
            issue.Columns.Add("Date", typeof(DateTime));
            issue.Columns.Add("Priority", typeof(Priority));
            issue.Columns.Add("ProjectId", typeof(int));
            issue.Columns.Add("Type", typeof(Type));
            issue.Columns.Add("UserId", typeof(int));

            //Controls team
            issue.Rows.Add(1, "RadGridView databinding issue", "RadGridView does not display columns from dataset", "Bind the grid to a dataset with tables",
                Status.NotDone, DateTime.Now.AddDays(-1), Priority.Blocking, 1, Type.Bug, null);
            issue.Rows.Add(3, "RadGridView save/load layout issue", "RadGridView does not save the columns correctly", "Non-visible columns are also being saved",
                Status.ReadyForTest, DateTime.Now.AddDays(-2), Priority.High, 1, Type.Bug, 2);
            issue.Rows.Add(4, "RadDropDownList add functionality for multiselect", "Add functionality to RadDropDownList to support multiselect", "",
                Status.NotDone, DateTime.Now, Priority.High, 1, Type.Feature, null);
            issue.Rows.Add(5, "RadCalendar add month picker functionality", "Add functionality to RadCalendar to support month selection", "",
                Status.Done, DateTime.Now.AddDays(-3), Priority.High, 1, Type.Feature, 4);

            //Navigation team
            issue.Rows.Add(6, "RadTextBox focus issue", "The Focus() method of the control does not work", "Call radTextBox1.Focus()",
                Status.NotDone, DateTime.Now, Priority.High, 2, Type.Bug, 5);
            issue.Rows.Add(7, "RadTextBox BackColor property is not taken into cosideration", "The control backcolor property is not taken into consideration", "Try to set a backcolor through the control BackColor property",
                Status.Done, new DateTime(2011, 05, 03), Priority.High, 2, Type.Feature, 2);
            issue.Rows.Add(8, "RadMaskEditBox add phone mask", "Add new mask to support phone number format", "",
                Status.Done, DateTime.Now, Priority.High, 2, Type.Feature, 3);
            issue.Rows.Add(9, "RadDateTimePicker add month and year picker functionality", "Add month and year picker modes", "",
                Status.InProgress, DateTime.Now.AddDays(-4), Priority.High, 2, Type.Feature, 4);

            //Examples team
            issue.Rows.Add(10, "RadTreeView demo appearance glitches", "The node borders appear in double size", "Open the application from Demo > RadTreeView > First Look",
               Status.Done, DateTime.Now.AddDays(-5), Priority.High, 3, Type.Bug, 4);
            issue.Rows.Add(11, "RadDateTimePicker demo exeption", "The application in Demo > RadDateTimePicker throws an exception in multiselect mode", "Open the demo, select the multiselect option, expand the drop down and click on a date",
                Status.ReadyForTest, new DateTime(2011, 03, 22), Priority.High, 3, Type.Bug, 5);
            issue.Rows.Add(12, "RadGridView localization example spelling mistake", "Open Demo > RadGridView > Localization", "The word 'work' is misspeled",
                Status.Done, DateTime.Now.AddDays(-6), Priority.High, 3, Type.Bug, 2);
            issue.Rows.Add(13, "Create new application for to demo POS", "Create sample POS application", "",
                Status.InProgress, DateTime.Now.AddDays(-7), Priority.High, 3, Type.Feature, 1);

            //Themes team
            issue.Rows.Add(14, "RadGridView layout issue", "RadGridView shows double border", "Open bound RadGridView and observe the top border with ControlDefault theme",
                Status.NotDone, DateTime.Now.AddDays(-8), Priority.Low, 1, Type.Bug, null);
            issue.Rows.Add(15, "RadDropDownList items font size is incorrect", "The font size is 9.5 and it should be 8.25", "Open the dropdown with some items loaded and apply the Windows7 theme",
                Status.ReadyForTest, DateTime.Now.AddDays(-9), Priority.Blocking, 4, Type.Bug, 3);
            issue.Rows.Add(16, "RadCalendar displays SpecialDays incorrect", "SpecialDays size and color is incorrect", "Load the Office2010Blue theme and observe the SpecialDays appearance.",
                Status.ReadyForTest, DateTime.Now.AddDays(-10), Priority.High, 4, Type.Bug, 1);
            issue.Rows.Add(17, "RadProgreeBar shows no border", "RadProgressBar border is missing", "Load progress bar with Office2010Black theme",
                Status.InProgress, DateTime.Now.AddDays(-11), Priority.High, 4, Type.Bug, 1);
            issue.Rows.Add(18, "Create new Telerik theme", "The new theme should be in metro style", "",
                Status.ReadyForTest, DateTime.Now, Priority.High, 4, Type.Feature, 2);

            dataSet.WriteXml(@"..\..\source.xml");
            dataSet.WriteXmlSchema(@"..\..\XMLSchema.xsd");

        }

        private Status? ConvertToStatus(object value)
        {
            if (value is Status)
            {
                return (Status)value;
            }

            return null;
        }

        #endregion

        #region Events

        void radDock1_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            //reset the currency manager position in order to update the controls in details tab
            if (e.DockWindow != detailsToolWindow)
            {
                RadGridView currentGrid = e.DockWindow == bugDocumentWindow ? bugsGrid : featuresGrid;
                CurrencyManager mgr = ((ICurrencyManagerProvider)currentGrid.MasterTemplate.ListSource).CurrencyManager;
                if (mgr == null)
                {
                    return;
                }
                int savePos = mgr.Position;
                mgr.Position = mgr.Position == mgr.List.Count - 1 ? int.MinValue : int.MaxValue;
                mgr.Position = savePos;
                if (currentGrid.ChildRows.Count > 0)
                {
                    currentGrid.ChildRows[0].IsSelected = true;
                    currentGrid.ChildRows[0].IsCurrent = true;
                }
            }
        }

        private void filter_grid(object sender, StateChangedEventArgs args)
        {
            RadCheckBoxElement checkBox = sender as RadCheckBoxElement;
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                FilterDescriptor filter = new FilterDescriptor();

                switch (checkBox.Text)
                {
                    case "Open":
                        filter.Operator = FilterOperator.IsEqualTo;
                        filter.PropertyName = "Status";
                        filter.Value = Status.NotDone;
                        break;
                    case "Ready For Test":
                        filter.Operator = FilterOperator.IsEqualTo;
                        filter.PropertyName = "Status";
                        filter.Value = Status.ReadyForTest;
                        break;
                    case "Done":
                        filter.Operator = FilterOperator.IsEqualTo;
                        filter.PropertyName = "Status";
                        filter.Value = Status.Done;
                        break;
                    case "Unassigned":
                        filter.Operator = FilterOperator.IsEqualTo;
                        filter.PropertyName = "UserId";
                        filter.Value = 1;
                        break;
                    case "New":
                        filter.Operator = FilterOperator.IsGreaterThan;
                        filter.PropertyName = "Date";
                        filter.Value = DateTime.Now.AddDays(-7);
                        break;
                    default:
                        break;
                }

                this.bugsGrid.FilterDescriptors.Add(filter);
                this.featuresGrid.FilterDescriptors.Add(filter);
            }
            else
            {

                for (int i = 0; i < bugsGrid.FilterDescriptors.Count; i++)
                {
                    if (checkBox.Text == "Open" && ConvertToStatus(bugsGrid.FilterDescriptors[i].Value) == Status.NotDone)
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                        return;
                    }
                    if (checkBox.Text == "Ready For Test" && ConvertToStatus(bugsGrid.FilterDescriptors[i].Value) == Status.ReadyForTest)
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                        return;
                    }
                    if (checkBox.Text == "Done" && ConvertToStatus(bugsGrid.FilterDescriptors[i].Value) == Status.Done)
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                        return;
                    }
                    if (checkBox.Text == "Unassigned" && (bugsGrid.FilterDescriptors[i].Value as int?) == 1)
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                        return;
                    }
                    if (checkBox.Text == "New" && bugsGrid.FilterDescriptors[i].PropertyName == "Date")
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        void sortGrids(object sender, EventArgs e)
        {
            RadMenuItem itemClicked = sender as RadMenuItem;
            RadMenuItem parentItem = itemClicked.HierarchyParent as RadMenuItem;
            bugsGrid.SortDescriptors.Clear();
            featuresGrid.SortDescriptors.Clear();
            if (itemClicked.Text == "None")
            {
                return;
            }
            else
            {
                bugsGrid.SortDescriptors.Add(new SortDescriptor(parentItem.Text, itemClicked.Text == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending));
                featuresGrid.SortDescriptors.Add(new SortDescriptor(parentItem.Text, itemClicked.Text == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending));
            }
        }

        private void projectsTreeView_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (bugsGrid.FilterDescriptors.Count > 1)
            {
                for (int i = 0; i < bugsGrid.FilterDescriptors.Count; i++)
                {
                    if (bugsGrid.FilterDescriptors[i].PropertyName == "ProjectId")
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                    }
                    if (featuresGrid.FilterDescriptors[i].PropertyName == "ProjectId")
                    {
                        featuresGrid.FilterDescriptors.RemoveAt(i);
                    }
                }
            }

            if ((int)e.Node.Value == 0)
            {
                return;
            }
            else
            {
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = "ProjectId";
                filter.Operator = FilterOperator.IsEqualTo;
                filter.Value = e.Node.Value;
                this.bugsGrid.FilterDescriptors.Add(filter);
                this.featuresGrid.FilterDescriptors.Add(filter);
            }
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //move the focus away from the editor to the tree view in order to submit the value to the data source
                projectsTreeView.TreeViewElement.Focus();
                if (bugsGrid.CurrentRow != null)
                {
                    bugsGrid.CurrentRow.InvalidateRow();
                }
                if (featuresGrid.CurrentRow != null)
                {
                    featuresGrid.CurrentRow.InvalidateRow();
                }
            }
        }

        private void loadDatabaseButton_Click(object sender, EventArgs e)
        {
            bugsGrid.Columns.Clear();
            featuresGrid.Columns.Clear();
            FillDataSet();
            SetupBugsGrid();
            SetupFeaturesGrid();
        }

        private void saveDatabaseButton_Click(object sender, EventArgs e)
        {
            dataSet.WriteXml(@"..\..\source.xml");
            dataSet.WriteXmlSchema(@"..\..\XMLSchema.xsd");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RadGridView currentGrid = documentTabStrip2.ActiveWindow == bugDocumentWindow ? bugsGrid : featuresGrid;
            Type t = documentTabStrip2.ActiveWindow == bugDocumentWindow ? Type.Bug : Type.Feature;
            int highestId = -1;
            foreach (GridViewRowInfo r in currentGrid.Rows)
            {
                if (Convert.ToInt32(r.Cells["Id"].Value) > highestId)
                {
                    highestId = Convert.ToInt32(r.Cells["Id"].Value);
                }
            }

            DataRow row = dataSet.Tables["Issue"].NewRow();
            row[0] = ++highestId;
            row[1] = "";
            row[2] = "";
            row[3] = "";
            row[4] = Status.NotDone;
            row[5] = DateTime.Now;
            row[6] = Priority.High;
            row[7] = projectsTreeView.SelectedNode.Value;
            row[8] = documentTabStrip2.ActiveWindow == bugDocumentWindow ? Type.Bug : Type.Feature;
            dataSet.Tables["Issue"].Rows.Add(row);
            //the following code, reselects the selected row, in order to update the controls values. It seems that there is a bug in the Currency manager syncronization.
            CurrencyManager mgr = ((ICurrencyManagerProvider)bugsGrid.MasterTemplate.ListSource).CurrencyManager;
            if (mgr == null)
            {
                return;
            }
            int savePos = mgr.Position;
            mgr.Position = -1;
            mgr.Position = savePos;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (documentTabStrip2.ActiveWindow == bugDocumentWindow && bugsGrid.CurrentRow != null)
            {
                bugsGrid.CurrentRow.Delete();
            }
            else if (documentTabStrip2.ActiveWindow == featureDocumentWindow && featuresGrid.CurrentRow != null)
            {
                featuresGrid.CurrentRow.Delete();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
        }

        private void saveLayoutButton_Click(object sender, EventArgs e)
        {
            radDock1.SaveToXml(@"..\..\dockLayout.xml");
        }

        private void loadLayoutButton_Click(object sender, EventArgs e)
        {
            string loadFile = @"..\..\dockLayout.xml";
            if (File.Exists(loadFile))
            {
                radDock1.LoadFromXml(loadFile);
            }
        }

        void changeThemes(object sender, EventArgs e)
        {
            RadGalleryItem element = sender as RadGalleryItem;
            ThemeResolutionService.ApplicationThemeName = element.Text;
        }

        void panelsChange_Click(object sender, EventArgs e)
        {

            bugDocumentWindow.CloseAction = DockWindowCloseAction.Hide;
            featureDocumentWindow.CloseAction = DockWindowCloseAction.Hide;

            RadButtonElement button = sender as RadButtonElement;
            if (button.Text == "Projects")
            {
                projectsToolWindow.DockState = DockState.Docked;
            }
            if (button.Text == "Details")
            {
                detailsToolWindow.DockState = DockState.Docked;
            }
            if (button.Text == "Bugs")
            {
                bugDocumentWindow.DockState = DockState.TabbedDocument;
            }
            if (button.Text == "Features")
            {
                featureDocumentWindow.DockState = DockState.TabbedDocument;
            }
        }

        void rowChanged_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReadOnlyControls(true);
        }

        void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void aboutMenuItem_Click(object sender, EventArgs e)
        {
            RadAboutBox1 radAboutBox1 = new RadAboutBox1();
            radAboutBox1.Show();
        }

        #endregion
    }
}
