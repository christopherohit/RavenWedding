using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Docking.DragDropAutomation
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private const int MouseOffsetX = 10;
        private const int MouseOffsetY = 2;
        private DragDropService service;
        private DragOperation operation;
        private Point prevPosition;
        private Timer stopTimer;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.stopTimer = new Timer(this.components);
            this.stopTimer.Interval = 500;
            this.stopTimer.Tick += new EventHandler(stopTimer_Tick);

            this.timer1.Interval = 100;
            this.service = this.radDock1.GetService<DragDropService>();
            this.service.DragDropBehavior = DragDropBehavior.Manual;
            this.service.PreviewHitTest += new DragDropHitTestEventHandler(service_PreviewHitTest);
            this.service.Stopped += new EventHandler(service_Stopped);

            this.toolWindow1.AllowedDockState &= ~AllowedDockState.Hidden;
            this.toolWindow2.AllowedDockState &= ~AllowedDockState.Hidden;
            this.toolWindow3.AllowedDockState &= ~AllowedDockState.Hidden;
        }
        
        #endregion

        #region Event Handlers

        private void stopTimer_Tick(object sender, EventArgs e)
        {
            this.service.Stop(true);
            this.stopTimer.Stop();
        }

        private void service_Stopped(object sender, EventArgs e)
        {
            this.timer1.Stop();

            //enable buttons
            this.scenario1Button.Enabled = true;
            this.scenario2Button.Enabled = true;
            this.initialStateButton.Enabled = true;
        }

        private void service_PreviewHitTest(object sender, DragDropHitTestEventArgs e)
        {
            switch(this.operation)
            {
                case DragOperation.Scenario1:
                    if (e.HitTest.DockPosition != null && e.HitTest.DockPosition == DockPosition.Fill)
                    {
                        this.timer1.Stop();
                        this.stopTimer.Start();
                    }
                    break;
                case DragOperation.Scenario2:
                    if (e.DropTarget == this.toolWindow2.DockTabStrip &&
                        (e.HitTest.DockPosition != null && e.HitTest.DockPosition == DockPosition.Bottom))
                    {
                        this.timer1.Stop();
                        this.stopTimer.Start();
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.operation)
            {
                case DragOperation.Scenario1:
                    this.service.PerformDrag(this.GetAnchorPoint(DockPosition.Fill));
                    break;
                case DragOperation.Scenario2:
                    this.service.PerformDrag(this.GetAnchorPoint(DockPosition.Bottom));
                    break;
            }
        }

        private void scenario1Button_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.operation = DragOperation.Scenario1;

            this.Start();
        }

        private void scenario2Button_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.operation = DragOperation.Scenario2;
            this.toolWindow2.DockState = DockState.Floating;

            this.Start();
        }

        private void initialStateButton_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        #endregion

        #region Implementation

        //protected override void OnLoad(EventArgs e)
        //{
        //    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        //}

        private void Start()
        {
            Rectangle dockBounds = this.RectangleToScreen(this.radDock1.Bounds);
            this.prevPosition = dockBounds.Location;
            this.radDock1.FloatWindow(this.toolWindow1, new Rectangle(this.prevPosition, FloatingWindow.DefaultFloatingSize));
            this.service.Start(this.toolWindow1.FloatingParent, this.prevPosition);

            //start the timer
            this.timer1.Start();

            //disable buttons
            this.scenario1Button.Enabled = false;
            this.scenario2Button.Enabled = false;
            this.initialStateButton.Enabled = false;
        }

        private void Reset()
        {
            RedockService redockService = this.radDock1.GetService<RedockService>();
            foreach (ToolWindow toolWindow in this.radDock1.DockWindows.ToolWindows)
            {
                toolWindow.DockState = DockState.Docked;
                redockService.ClearState(toolWindow, DockState.Floating);
            }
        }

        private Point GetAnchorPoint(DockPosition position)
        {
            Point curr = this.prevPosition;
            curr.Offset(MouseOffsetX, MouseOffsetY);

            Size centerGuideSize = this.radDock1.DockingGuidesTemplate.CenterBackgroundImage.PreferredSize;
            Rectangle parentBounds;
            if (position == DockPosition.Fill)
            {
                parentBounds = this.radDock1.MainDocumentContainer.Parent.RectangleToScreen(this.radDock1.MainDocumentContainer.Bounds);
            }
            else
            {
                parentBounds = this.toolWindow2.DockTabStrip.Parent.RectangleToScreen(this.toolWindow2.DockTabStrip.Bounds);
            }

            Rectangle guideBounds = new Rectangle(parentBounds.X + (parentBounds.Width - centerGuideSize.Width) / 2, 
                                                  parentBounds.Y + (parentBounds.Height - centerGuideSize.Height) / 2, 
                                                  centerGuideSize.Width, 
                                                  centerGuideSize.Height);

            Point anchor = curr;
            switch (position)
            {
                case DockPosition.Fill:
                    anchor = new Point(guideBounds.X + (guideBounds.Width / 2), guideBounds.Y + (guideBounds.Height / 2));
                    break;
                case DockPosition.Bottom:
                    anchor = new Point(guideBounds.X + (guideBounds.Width / 2), guideBounds.Bottom - 10);
                    break;
            }
            //clamp the drag location
            if (curr.X > anchor.X)
            {
                curr.X = anchor.X;
            }
            if (curr.Y > anchor.Y)
            {
                curr.Y = anchor.Y;
            }

            this.prevPosition = curr;

            return curr;
        }

        #endregion

        #region Nested Types

        private enum DragOperation
        {
            Scenario1,
            Scenario2,
        }

        #endregion

        protected override void WireEvents()
        {
            this.scenario1Button.Click += new System.EventHandler(this.scenario1Button_Click);
            this.initialStateButton.Click += new System.EventHandler(initialStateButton_Click);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.scenario2Button.Click += new System.EventHandler(this.scenario2Button_Click);
        }
    }
}
