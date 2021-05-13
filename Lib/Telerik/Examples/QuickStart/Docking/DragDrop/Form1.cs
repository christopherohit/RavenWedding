using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Docking.DragDrop
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.WireServiceEvents();
        }

        #endregion

        #region Implementation

        //protected override void OnLoad(EventArgs e)
        //{
        //    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        //}

        private void WireServiceEvents()
        {
            DragDropService service = this.radDock1.GetService<DragDropService>();
            service.Starting += new StateServiceStartingEventHandler(OnDragDropService_Starting);
            service.PreviewDropTarget += new DragDropTargetEventHandler(OnDragDropService_PreviewDropTarget);
            service.PreviewDockPosition += new DragDropDockPositionEventHandler(OnDragDropService_PreviewDockPosition);
        }

        private void OnDragDropService_PreviewDockPosition(object sender, DragDropDockPositionEventArgs e)
        {
            if (this.allowDockBottom.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                e.AllowedDockPosition = AllowedDockPosition.Bottom;
            }
        }

        private void OnDragDropService_PreviewDropTarget(object sender, DragDropTargetEventArgs e)
        {
            if (this.tool3Drop.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (e.DropTarget != this.toolWindow3.TabStrip)
                {
                    e.DropTarget = null;
                }
            }
        }

        private void OnDragDropService_Starting(object sender, StateServiceStartingEventArgs e)
        {
            Control context = e.Context as Control;
            if(context == null)
            {
                return;
            }

            if (context == this.toolWindow1 || ControlHelper.IsDescendant(context, this.toolWindow1))
            {
                e.Cancel = this.tool1Drag.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off;
            }
            else if (context == this.toolWindow2 || ControlHelper.IsDescendant(context, this.toolWindow2))
            {
                e.Cancel = this.tool2Drag.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off;
            }
        }

        #endregion

        #region Event Handlers

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radDock1.DragDropMode = DragDropMode.Preview;
            }
            else
            {
                this.radDock1.DragDropMode = DragDropMode.Auto;
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
        }
    }
}
