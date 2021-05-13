using DiagramFirstLook;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DiagramOrganizationChart
{
    public partial class OrgChartForm : RadForm
    {
        private int width = 2000;
        private Telerik.Windows.Diagrams.Core.Point topPoint = new Telerik.Windows.Diagrams.Core.Point(200,200);
        internal static Telerik.Windows.Diagrams.Core.TreeLayoutSettings currentLayoutSettings;
        private Color[] groupColor = new Color[] { Color.FromArgb(49, 49, 49), Color.FromArgb(47, 153, 69), Color.FromArgb(36, 159, 217) };

        public OrgChartForm()
        {
            this.InitializeComponent();
        
          
        }

        private void InitializeDiagram()
        {
            if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;
            }
            else
            {
                this.ThemeName = "TelerikMetro";
            }
            this.ApplyThemeRecursively(this.Controls);
            this.radDiagram1.BackColor = System.Drawing.Color.White;
            this.radDiagram1.ForeColor = System.Drawing.Color.Black;
            this.radDiagram1.IsInformationAdornerVisible = false;
            this.radDiagram1.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PanTool;
            this.radDiagram1.IsSnapToGridEnabled = false;
            this.radDiagram1.IsSnapToItemsEnabled = false;
            this.radDiagram1.RouteConnections = false;
            this.radDiagram1.RoutingService.Router = new Telerik.Windows.Diagrams.Core.OrgTreeRouter() { TreeLayoutType = Telerik.Windows.Diagrams.Core.TreeLayoutType.TreeDown };
            this.radDiagram1.RoutingService.AutoUpdate = true;
            this.radDiagram1.RouteConnections = true;
            this.radDiagram1.BackgroundGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radDiagram1.BackgroundPageGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radDiagram1.IsSettingsPaneEnabled = false;
            currentLayoutSettings = new Telerik.Windows.Diagrams.Core.TreeLayoutSettings()
            {
                HorizontalSeparation = 120d,
                VerticalSeparation = 180d,
                UnderneathVerticalTopOffset = 50d,
                UnderneathHorizontalOffset = 230d,
                UnderneathVerticalSeparation = 40d,
                VerticalDistance = 10d,
            };

            this.PopulateWithData();
            this.radDiagram1.Zoom = 0.8;
            this.radDiagram1.DiagramElement.HorizontalScrollbar.Value = 250;
            this.radDiagram1.DiagramElement.VerticalScrollbar.Value = 100;
            this.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings);
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
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InitializeDiagram();
        }

        public Image GetImageFromResource(string fileName)
        {
            using (Stream stream = this.GetType().Assembly.
            GetManifestResourceStream(string.Format("DiagramFirstLook.Resources.{0}.png", fileName)))
            {
                return new Bitmap(Image.FromStream(stream), 40,40);
            }
        }

        #region OrgExample
                
        private void PopulateWithData()
        { 
            XElement dataXml = XElement.Load(this.GetType().Assembly.GetManifestResourceStream("DiagramFirstLook.Resources.Organization.xml"));
            
            foreach (XElement element in dataXml.Elements("Node"))
            {
                OrgContainerShape node = this.CreateNode(element, null);
                node.BaseColor = this.groupColor[0];
                this.radDiagram1.AddShape(node);
                currentLayoutSettings.Roots.Add(node);
                this.GetSubNodes(element, node, 2);
            }
        }
        
        private OrgContainerShape CreateNode(XElement element, OrgContainerShape parentNode)
        {
            OrgContainerShape orgTeam = new OrgContainerShape()
            {
                Name = element.Attribute("Name").Value,
            };
            orgTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            orgTeam.Text = orgTeam.Name;
            orgTeam.Tag = element.Attribute("Branch").Value;
            orgTeam.Path = parentNode == null ? orgTeam.Name : string.Format("{0}|{1}", parentNode.Path, orgTeam.Name);
            currentLayoutSettings.Roots.Add(orgTeam);
            if (parentNode != null)
            {
                RadDiagramConnection connection = new RadDiagramConnection();
                connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline;
                connection.Source = parentNode;
                connection.Target = orgTeam;
                
                this.radDiagram1.AddConnection(connection);
            }
            
            var teamMembers = this.GetTeamMembers(element, orgTeam);
            var position = new Telerik.Windows.Diagrams.Core.Point(10, 50);

            int memberCount = 0;
            foreach (var member in teamMembers)
            {
                this.radDiagram1.AddShape(member);
                orgTeam.Items.Add(member);
                member.Position = position;
                position.X += member.Width + 20;
                if (++memberCount % 2 == 0)
                {
                    position = new Telerik.Windows.Diagrams.Core.Point(10, position.Y + member.Height + 10);
                }
            }
            
            orgTeam.IsCollapsedChanged += this.orgTeam_IsCollapsedChanged;           
            return orgTeam;
        }
        
        private ObservableCollection<RadDiagramShape> GetTeamMembers(XContainer element, OrgContainerShape team)
        {
            var members = new ObservableCollection<RadDiagramShape>();
            foreach (var xmlNodeMember in element.Elements("NodeMember"))
            {
                RadDiagramShape member = this.CreateMemberShape(team, xmlNodeMember);
                members.Add(member);
            }
            
            return members;
        }
 
        private RadDiagramShape CreateMemberShape(OrgContainerShape team, XElement xmlNodeMember)
        {
            RadDiagramShape member = new RadDiagramShape();
            member.IsConnectorsManipulationEnabled = false;
            member.ForeColor = Color.White;
            member.IsRotationEnabled = false;
            member.IsResizingEnabled = false;
            member.Shape = new Telerik.WinControls.RoundRectShape(0);
            member.BackColor = Color.LightBlue;
            member.Width = 190;
            member.Height = 50;
            member.Tag = team;
            member.Name = xmlNodeMember.Attribute("Name").Value;
            member.DiagramShapeElement.TextAlignment = ContentAlignment.MiddleLeft;
            member.DiagramShapeElement.ImageLayout = ImageLayout.None;
            member.DiagramShapeElement.Padding = new System.Windows.Forms.Padding(5, 2, 2, 0);
            member.DiagramShapeElement.Image = this.GetImageFromResource(member.Name);
            member.DiagramShapeElement.ImageAlignment = ContentAlignment.MiddleLeft;
            member.DiagramShapeElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            member.DiagramShapeElement.TextWrap = false;
            member.Text = string.Format(" {0}\n {1}", member.Name, xmlNodeMember.Attribute("Position").Value);
            return member;
        }
        
        private const int LastLevel = 3;

        private ObservableCollection<OrgContainerShape> GetSubNodes(XContainer element, OrgContainerShape parent, int level)
        {
            var nodes = new ObservableCollection<OrgContainerShape>();
            List<XElement> elements = new List<XElement>(element.Elements("Node"));
            if (elements.Count == 0)
            {
                return nodes;
            }            
          
            
            foreach (var subElement in elements)
            { 
                OrgContainerShape node = this.CreateNode(subElement, parent);
                node.ShowCollapseButton = level < 3;
                if (node.Path.Contains("Development"))
                {
                    node.BaseColor = this.groupColor[2];
                }
                if (node.Path.Contains("Marketing"))
                {
                    node.BaseColor = this.groupColor[1];
                }

                this.radDiagram1.AddShape(node);
               
                this.GetSubNodes(subElement, node, level + 1);
                nodes.Add(node);
            }

            return nodes;
        }
        
        private void orgTeam_IsCollapsedChanged(object sender, Telerik.WinControls.UI.Diagrams.RoutedEventArgs e)
        {
               this.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings);
        }
        
        #endregion
    }

   
}