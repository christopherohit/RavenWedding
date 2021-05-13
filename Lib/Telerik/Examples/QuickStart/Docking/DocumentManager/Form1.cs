using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.Docking.DocumentManager
{
    public partial class Form1 : ExamplesForm
    {
        private int docCounter = 11;

        public Form1()
        {
            InitializeComponent();

            this.radDock1.ShowDocumentCloseButton = true;
            this.radDock1.DocumentManager.DocumentCloseActivation = DocumentCloseActivation.FirstInZOrder;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radDock1.DocumentManager.ActivateNextDocument();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.radDock1.DocumentManager.ActivatePreviousDocument();
        }

        private void sortNone_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.None;
        }

        private void sortByName_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ByText;
        }

        private void sortByActivation_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.DocumentManager.ActiveDocumentMenuSortOrder = Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.ZOrdered;
        }

        private void addDoc_Click(object sender, EventArgs e)
        {
            DocumentWindow docWindow = new DocumentWindow("documentWindow" + docCounter++);
            this.radDock1.AddDocument(docWindow);
        }

        protected override void WireEvents()
        {
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.sortNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.sortNone_ToggleStateChanged);
            this.sortByActivation.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.sortByActivation_ToggleStateChanged);
            this.sortByText.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.sortByName_ToggleStateChanged);
            this.addDoc.Click += new System.EventHandler(this.addDoc_Click);
        }
    }
}
