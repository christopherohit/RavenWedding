using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.Docking.TabbedDocument
{
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
	{
        private int newDocument = 3;
        private bool processSelIndexChanged = true;

		public Form1()
		{
			InitializeComponent();
            this.Icon = ResFinder.ProgressIcon;

            this.toolWindow1.AllowedDockState = AllowedDockState.All & ~AllowedDockState.TabbedDocument;
            this.toolWindow2.AllowedDockState = AllowedDockState.All & ~AllowedDockState.TabbedDocument;

            this.radDock1.DockWindow(this.toolWindow2, DockPosition.Bottom);
            this.radDock1.DockStateChanging += new DockStateChangingEventHandler(radDock1_DockStateChanging);
            this.radDock1.DockStateChanged += new DockWindowEventHandler(radDock1_DockStateChanged);
            this.radDock1.DockWindowAdded += new DockWindowEventHandler(radDock1_DockWindowAdded);
            this.radDock1.DockWindowRemoved += new DockWindowEventHandler(radDock1_DockWindowRemoved);
            this.radDock1.ActiveWindowChanged += new DockWindowEventHandler(radDock1_ActiveWindowChanged);
            this.radDock1.ReleaseMemoryOnClose = true;
            
            this.UpdateCombo();

            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser2.ScriptErrorsSuppressed = true;
		}

        private void radDock1_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            this.AddLog("ActiveWindow changed; current active window: " + e.DockWindow, true);
            if (e.DockWindow is DocumentWindow)
            {
                this.SetSelectedDocument((DocumentWindow)e.DockWindow);
            }
        }

        private void SetSelectedDocument(DocumentWindow selected)
        {
            int currIndex = 0;
            foreach (RadListDataItem item in this.currentRadComboBox.Items)
            {
                DocumentWindow window = item.Value as DocumentWindow;
                if (window == selected)
                {
                    this.currentRadComboBox.SelectedIndex = currIndex;
                    break;
                }
                currIndex++;
            }
        }

        protected override void WireEvents()
        {
            this.currentRadComboBox.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.currentRadComboBox_SelectedIndexChanged);
            this.contextRadDropDownButton.MouseDown += new MouseEventHandler(this.contextRadDropDownButton_MouseDown);
            this.newRadButton.Click += new EventHandler(this.newRadButton_Click);
        }

        private void radDock1_DockWindowRemoved(object sender, DockWindowEventArgs e)
        {
            this.UpdateCombo();
        }

        private void radDock1_DockWindowAdded(object sender, DockWindowEventArgs e)
        {
            this.UpdateCombo();
        }

        private void radDock1_DockStateChanged(object sender, DockWindowEventArgs e)
        {
            this.AddLog("Dock State for window " + e.DockWindow + " changed to " + e.DockWindow.DockState, true);
        }

        private void radDock1_DockStateChanging(object sender, DockStateChangingEventArgs e)
        {
            this.AddLog("Window " + e.NewWindow + " DockState changing to " + e.NewDockState + "; current state: " + e.NewWindow.DockState, true);
        }

        private void newRadButton_Click(object sender, EventArgs e)
        {
            DocumentWindow docWindow = new DocumentWindow("Document " + newDocument++);
            this.radDock1.AddDocument(docWindow);
        }

        private void AddLog(string text, bool newLine)
        {
            logRadTextBox.Text += text + ((newLine) ? "\r\n" : "");
            logRadTextBox.Select(logRadTextBox.Text.Length, -1);
            logRadTextBox.ScrollToCaret();
        }

        private void currentRadComboBox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!this.processSelIndexChanged)
            {
                return;
            }

            this.processSelIndexChanged = false;

            DocumentWindow window = this.GetSelectedDocument();
            if (window != null)
            {
                this.radDock1.ActiveWindow = window;
            }

            this.processSelIndexChanged = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            UpdateCombo();
        }

        private void UpdateCombo()
        {
            ElementState rootState = this.currentRadComboBox.RootElement.ElementState;
            if (rootState != ElementState.Constructed && rootState != ElementState.Loaded && rootState != ElementState.Unloaded)
            {
                return;
            }

            this.currentRadComboBox.BeginUpdate();
            this.currentRadComboBox.Items.Clear();

            DockWindow active = this.radDock1.ActiveWindow;
            int selIndex = 0;
            int currIndex = 0;

            foreach (DocumentWindow window in ControlHelper.GetChildControls<DocumentWindow>(this.radDock1.MainDocumentContainer, true))
            {
                RadListDataItem item = new RadListDataItem(window.Text);
                item.Value = window;
                this.currentRadComboBox.Items.Add(item);
                if (window == active)
                {
                    selIndex = currIndex;
                }
                currIndex++;
            }

            if (currIndex > 0)
            {
                this.currentRadComboBox.SelectedIndex = selIndex;
            }
            this.currentRadComboBox.EndUpdate();
        }

        private void contextRadDropDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            DockWindow active = this.radDock1.DocumentManager.ActiveDocument;
            if (active == null)
            {
                return;
            }

            ContextMenuService service = this.radDock1.GetService<ContextMenuService>();
            if (service == null)
            {
                return;
            }

            Rectangle bounds = this.contextRadDropDownButton.Bounds;
            bounds = this.contextRadDropDownButton.Parent.RectangleToScreen(bounds);
            Point location = new Point(bounds.X, bounds.Bottom + 1);
            service.DisplayContextMenu(active, location);
        }

        private DocumentWindow GetSelectedDocument()
        {
            RadListDataItem item = this.currentRadComboBox.SelectedItem as RadListDataItem;
            if (item == null)
            {
                return null;
            }

            return item.Value as DocumentWindow;
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
	}
}