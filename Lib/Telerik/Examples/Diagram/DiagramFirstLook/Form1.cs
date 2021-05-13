using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;

namespace DiagramFirstLook
{ 
    public partial class Form1 : RadRibbonForm
    {
        Timer timer = new Timer();

        public Form1(string exampleName)
        {
            Program.exampleName = exampleName;
            InitializeComponent();          
            CustomizeExampleAppearance();
        }

        public Form1()
        { 
            InitializeComponent();          
            CustomizeExampleAppearance();
        }

        private void CustomizeExampleAppearance()
        {
            this.radDropDownList1.SelectedIndex = 0;
            this.toolWindow3.Hide();
            if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;                      
            }
            else
            {
                this.ThemeName = "TelerikMetro";                
            }

            this.ApplyThemeRecursively(this.Controls);
            this.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Visible;
            switch (Program.exampleName)
            {
                case "Firstlook":
                    this.radDropDownList1.SelectedIndex = 0;
                    this.toolWindow3.Hide();
                    this.radDropDownList1.Visible = false;
                    this.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 1;
                    break;
                case "CycleDiagram":
                    this.radDropDownList1.SelectedIndex = 1;
                    this.toolWindow3.Hide();
                    this.radDropDownList1.Visible = false;
                    this.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 2;
                    break;
                case "LinearProcess":
                    this.radDropDownList1.SelectedIndex = 2;
                    this.toolWindow3.Hide();
                    this.radDropDownList1.Visible = false;
                    this.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 3;
                    break;
                case "Gap":
                    this.radDropDownList1.SelectedIndex = 4;
                    this.toolWindow3.Hide();
                    this.radDropDownList1.Visible = false;
                    this.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 2;
                    this.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Collapsed;
                    break;
                case "Routing":
                    this.radDropDownList1.SelectedIndex = 3;
                    this.radDropDownList1.Visible = false;
                    this.toolWindow3.Hide();
                    this.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Collapsed;
                    break;
                case "Databinding":
                    this.radDropDownList1.SelectedIndex = 5;
                    this.radDropDownList1.Visible = false;                   
                    this.toolWindow3.Hide();
                    break;
                case "FloorPlan":
                    this.radDropDownList1.SelectedIndex = 6;
                    this.radDropDownList1.Visible = false;
                    this.radDiagram1.DiagramElement.Position =  new Telerik.Windows.Diagrams.Core.Point(this.radDiagram1.DiagramElement.Position.X -50,this.radDiagram1.DiagramElement.Position.Y);
                    this.toolWindow3.Hide();
                    break;
            }

            this.diagramRibbonBar1.ThemeNameChanged += this.diagramRibbonBar1_ThemeNameChanged;
            this.diagramRibbonBar1.RibbonBarElement.ApplicationButtonElement.Visibility = ElementVisibility.Collapsed;
            this.diagramRibbonBar1.RibbonBarElement.TabStripElement.ItemContainer.Margin = new Padding(0);
            this.radPropertyGrid1.PropertyValueChanging += radPropertyGrid1_PropertyValueChanging;
        }

        private void diagramRibbonBar1_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            if (this.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility != ElementVisibility.Collapsed)
            {
                return;
            }

            this.diagramRibbonBar1.RibbonBarElement.ResetValue(RadRibbonBarElement.SimplifiedHeightProperty, ValueResetFlags.Local);
            this.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Visible;
            this.diagramRibbonBar1.RibbonBarElement.RibbonCaption.InvalidateMeasure(true);
            this.diagramRibbonBar1.RibbonBarElement.UpdateLayout();
            this.diagramRibbonBar1.RibbonBarElement.SimplifiedHeight -= TelerikDpiHelper.ScaleInt(this.diagramRibbonBar1.RibbonBarElement.RibbonCaption.BoundingRectangle.Height, this.ElementTree.RootElement.DpiScaleFactor);

            this.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Collapsed;
        }

        void radPropertyGrid1_PropertyValueChanging(object sender, PropertyGridItemValueChangingEventArgs e)
        {
            if ((((PropertyGridItem)e.Item)).ReadOnly || ((PropertyGridItem)e.Item).Accessor is Telerik.WinControls.UI.PropertyGridData.ImmutableItemAccessor)
            {
                return;
            }

            PropertyGridItemBase item = e.Item;
            string propertyName = item.Name;
            while(item.Parent!=null)
            {
                propertyName = item.Parent.Name + "." + propertyName;
                item = item.Parent;
            }

            Telerik.WinControls.UI.Diagrams.UndoRedoHelper.ValueChanged((IDiagramItem)this.radDiagram1.DiagramElement.SelectedItem, propertyName, e.NewValue, e.OldValue);            
        }        

        void DiagramElement_SelectionChanged(object sender, EventArgs e)
        {
            this.radPropertyGrid1.SelectedObject = this.radDiagram1.DiagramElement.SelectedItem;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radDropDownList1.SelectedIndex != -1)
            {  
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                this.radDiagram1.DataSource = null;
                this.radDiagram1.Items.Clear();
                this.radDiagram1.SerializedXml = resources.GetString(this.radDropDownList1.SelectedItem.Tag.ToString());

                timer.Tick -=timer_TickGap;
                timer.Tick -=timer_Tick;
                this.radDiagram1.AllowDelete = true;
                this.timer.Stop();
                this.radDiagram1.ConnectionBridge = BridgeType.None;
                
                if (this.radDropDownList1.SelectedIndex == 3)
                {
                    this.PrepareRoutingExample();
                }
                else if (this.radDropDownList1.SelectedIndex == 4)
                {
                    this.PrepareGapExample();                   
                }
                else if (this.radDropDownList1.SelectedIndex == 5)
                {
                    this.SetupDataBindindngs();
                }

            }
            else
            {
                this.radDiagram1.SerializedXml = "";
            }
        }
 
        private void PrepareGapExample()
        {
            this.radDiagram1.ConnectionBridge = BridgeType.Bow;
            this.radDiagram1.AllowDelete = false;
            timer.Interval = 30;
            timer.Tick +=timer_TickGap;
            timer.Start();
        }

        private void PrepareRoutingExample()
        {
            this.radDiagram1.RouteConnections = false;
            this.radDiagram1.RoutingService.Router = new Telerik.Windows.Diagrams.Core.AStarRouter(this.radDiagram1.DiagramElement) { AvoidShapes = true};
            this.radDiagram1.RoutingService.AutoUpdate = true;
            this.radDiagram1.RouteConnections = true;
            this.radDiagram1.AllowDelete = false;
            
            timer.Interval = 30;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        int step = 1;
        int step1 = -1;

        void timer_Tick(object sender, EventArgs e)
        {
            RadDiagramShape shape = (RadDiagramShape)this.radDiagram1.Shapes[3];
            RadDiagramShape shape1 = (RadDiagramShape)this.radDiagram1.Shapes[4];            

            shape.Position = new Telerik.Windows.Diagrams.Core.Point( shape.Position.X-step,shape.Position.Y);
            shape1.Position = new Telerik.Windows.Diagrams.Core.Point( shape1.Position.X-step1,shape1.Position.Y);
            if (shape.Position.X < 380 || shape.Position.X > 620) step = -step;
            if (shape1.Position.X < 380 || shape1.Position.X > 620) step1 = -step1;            
        }

        int connectionStep = 1;
        void timer_TickGap(object sender, EventArgs e)
        {
            RadDiagramShape connection1 = (RadDiagramShape)this.radDiagram1.Shapes[4]; 
            RadDiagramShape connection2 = (RadDiagramShape)this.radDiagram1.Shapes[5]; 
            connection1.Position = new Telerik.Windows.Diagrams.Core.Point( connection1.Position.X-step,connection1.Position.Y);
            connection2.Position = new Telerik.Windows.Diagrams.Core.Point( connection2.Position.X-step,connection2.Position.Y);

         
            if ( connection1.Position.X < 250 ||  connection1.Position.X > 440) step = -step;
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.timer.Dispose();
            base.OnClosing(e);            
        }        

        void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null )
                {                    
                    radControl.ThemeName = this.ThemeName;                    
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }
    }
}