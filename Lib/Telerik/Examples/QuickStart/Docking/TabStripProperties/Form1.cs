using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.Docking.TabStripProperties
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.docTabsVisibleCheck.Checked = this.radDock1.DocumentTabsVisible;
            this.toolTabsVisibleCheck.Checked = this.radDock1.ToolTabsVisible;

            this.docCloseButtonCheck.Checked = this.radDock1.ShowDocumentCloseButton;
            this.toolCloseButtonCheck.Checked = this.radDock1.ShowToolCloseButton;

            this.FillTabStripAlignment(this.docTabAlignCombo, this.radDock1.DocumentTabsAlignment);
            this.FillTabStripAlignment(this.toolTabAlignCombo, this.radDock1.ToolTabsAlignment);

            this.FillTabStripTextOrientation(this.docTextOrientationCombo, this.radDock1.DocumentTabsTextOrientation);
            this.FillTabStripTextOrientation(this.toolTextOrientationCombo, this.radDock1.ToolTabsTextOrientation);

            this.FillPreviewTabsCombo();
        }

        #endregion

        #region Implementation

        private void FillPreviewTabsCombo()
        {
            this.docPreviewTabCombo.Items.Add(new RadListDataItem("(none)", null));

            foreach (DocumentWindow dw in this.radDock1.GetWindows<DocumentWindow>())
            {
                this.docPreviewTabCombo.Items.Add(new RadListDataItem(dw.Text, dw));
            }

            this.docPreviewTabCombo.SelectedIndex = 0;
            this.docPreviewTabCombo.SelectedIndexChanged += docPreviewTabCombo_SelectedIndexChanged;
            this.documentTabStrip1.TabStripElement.PropertyChanged += TabStripElement_PropertyChanged;
        }

        private void FillTabStripTextOrientation(RadDropDownList combo, TabStripTextOrientation selected)
        {
            combo.BeginUpdate();
            combo.Items.Clear();

            int counter = 0;
            int selectedIndex = -1;
            foreach (TabStripTextOrientation orientation in Enum.GetValues(typeof(TabStripTextOrientation)))
            {
                RadListDataItem item = new RadListDataItem(orientation.ToString());
                item.Value = orientation;
                combo.Items.Add(item);

                if (orientation == selected)
                {
                    selectedIndex = counter;
                }

                counter++;
            }

            combo.SelectedIndex = selectedIndex;
            combo.EndUpdate();
        }

        private void FillTabStripAlignment(RadDropDownList combo, TabStripAlignment selected)
        {
            combo.BeginUpdate();
            combo.Items.Clear();

            int counter = 0;
            int selectedIndex = -1;
            foreach (TabStripAlignment align in Enum.GetValues(typeof(TabStripAlignment)))
            {
                RadListDataItem item = new RadListDataItem(align.ToString());
                item.Value = align;
                combo.Items.Add(item);

                if (align == selected)
                {
                    selectedIndex = counter;
                }

                counter++;
            }

            combo.SelectedIndex = selectedIndex;
            combo.EndUpdate();
        }

        private TabStripAlignment? GetTabStripAlignment(RadDropDownList combo)
        {
            RadListDataItem item = combo.SelectedItem as RadListDataItem;
            if (item == null)
            {
                return null;
            }

            return (TabStripAlignment)item.Value;
        }

        private TabStripTextOrientation? GetTabStripTextOrientation(RadDropDownList combo)
        {
            RadListDataItem item = combo.SelectedItem as RadListDataItem;
            if (item == null)
            {
                return null;
            }

            return (TabStripTextOrientation)item.Value;
        }

        #endregion

        #region Event Handlers

        private void docTextOrientationCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabStripTextOrientation? orientation = this.GetTabStripTextOrientation(this.docTextOrientationCombo);
            if (orientation != null)
            {
                this.radDock1.DocumentTabsTextOrientation = orientation.Value;
            }
        }

        private void toolTextOrientationCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabStripTextOrientation? orientation = this.GetTabStripTextOrientation(this.toolTextOrientationCombo);
            if (orientation != null)
            {
                this.radDock1.ToolTabsTextOrientation = orientation.Value;
            }
        }

        private void docCloseButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDock1.ShowDocumentCloseButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void toolCloseButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDock1.ShowToolCloseButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void docTabAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabStripAlignment? align = this.GetTabStripAlignment(this.docTabAlignCombo);
            if (align != null)
            {
                this.radDock1.DocumentTabsAlignment = align.Value;
            }
        }

        private void toolTabAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabStripAlignment? align = this.GetTabStripAlignment(this.toolTabAlignCombo);
            if (align != null)
            {
                this.radDock1.ToolTabsAlignment = align.Value;
            }
        }

        private void docTabsVisibleCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDock1.DocumentTabsVisible = this.docTabsVisibleCheck.Checked;
        }

        private void toolTabsVisibleCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDock1.ToolTabsVisible = this.toolTabsVisibleCheck.Checked;
        }

        void docPinButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDock1.ShowDocumentPinButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        void docPreviewTabCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            DocumentWindow selectedDoc = this.docPreviewTabCombo.SelectedValue as DocumentWindow;
            this.documentTabStrip1.TabStripElement.PreviewItem = selectedDoc != null && selectedDoc.DockState != DockState.Hidden ? selectedDoc.TabStripItem : null;
        }

        void TabStripElement_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PreviewItem")
            {
                if (this.documentTabStrip1.TabStripElement.PreviewItem == null)
                {
                    this.docPreviewTabCombo.SelectedIndex = 0;
                }
                else
                {
                    this.docPreviewTabCombo.SelectedValue = ((TabStripItem)this.documentTabStrip1.TabStripElement.PreviewItem).TabPanel;
                }
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.docTabAlignCombo.SelectedIndexChanged +=  docTabAlignCombo_SelectedIndexChanged;
            this.toolTabAlignCombo.SelectedIndexChanged += toolTabAlignCombo_SelectedIndexChanged;
            this.docTabsVisibleCheck.ToggleStateChanged += docTabsVisibleCheck_ToggleStateChanged;
            this.toolTabsVisibleCheck.ToggleStateChanged += this.toolTabsVisibleCheck_ToggleStateChanged;
            this.docCloseButtonCheck.ToggleStateChanged += this.docCloseButtonCheck_ToggleStateChanged;
            this.docPinButtonCheck.ToggleStateChanged += docPinButtonCheck_ToggleStateChanged;
            this.docTextOrientationCombo.SelectedIndexChanged += this.docTextOrientationCombo_SelectedIndexChanged;
            this.toolCloseButtonCheck.ToggleStateChanged += toolCloseButtonCheck_ToggleStateChanged;
            this.toolTextOrientationCombo.SelectedIndexChanged += this.toolTextOrientationCombo_SelectedIndexChanged;
        }

    }
}
