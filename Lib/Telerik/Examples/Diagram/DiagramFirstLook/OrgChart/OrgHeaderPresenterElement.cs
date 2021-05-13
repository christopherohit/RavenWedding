using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace DiagramOrganizationChart
{
    public class OrgHeaderPresenterElement : LightVisualElement
    {
        private readonly RadToggleButtonElement toggleCollapseButton;
        private RadLabelElement label;
        private readonly RadLabelElement teamMembers;
        
        /// <summary>
        /// HeaderPresenterElement
        /// </summary>
        /// <param name="toggleCollapseButton"></param>
        /// <param name="label"></param>
        public OrgHeaderPresenterElement(RadToggleButtonElement toggleCollapseButton, RadLabelElement label)
        {
            this.StretchVertically = false;
            
            this.label = label;
            this.label.StretchHorizontally = false;
            this.label.Font = new Font(this.label.Font.FontFamily, 14);
            this.toggleCollapseButton = toggleCollapseButton;
            this.teamMembers = new RadLabelElement();
            
            this.Children.Add(this.label);
            this.Children.Add(this.toggleCollapseButton);
            this.Children.Add(this.teamMembers);
            
            this.teamMembers.LabelFill.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            
            this.teamMembers.ForeColor = Color.White;
            this.teamMembers.LabelFill.BackColor = Color.Black;
            this.teamMembers.LabelFill.NumberOfColors = 1;
            this.teamMembers.Click += this.teamMembers_Click;
        }
        
        public RadLabelElement HeaderLabel
        {
            get
            {
                return this.label;
            }
            set
            {
                this.label = value;
            }
        }

        RadContextMenu context;

        RadMenuItem addTeam;
        RadMenuItem renameTeam;
        RadMenuItem removeTeam;

        private void teamMembers_Click(object sender, EventArgs e)
        {
            var senderTeam = this.FindAncestor<OrgContainerShape>();
            var diagramElement = this.FindAncestor<RadDiagramElement>();

            if (senderTeam.IsCollapsed) return;

            if (addTeam == null)
            {
                context = new RadContextMenu();
                addTeam = new RadMenuItem() { Text = "Add Team" };
                addTeam.Click += addTeam_Click;
                context.Items.Add(addTeam);

                renameTeam = new RadMenuItem() { Text = "Rename Team" };
                renameTeam.Click += renameTeam_Click;
                context.Items.Add(renameTeam);

                removeTeam = new RadMenuItem() { Text = "Remove Team" };
                removeTeam.Click += removeTeam_Click;
                context.Items.Add(addTeam);
                context.Items.Add(removeTeam);
            }
         
          
            removeTeam.Enabled = !diagramElement.Connections.Where(x => x.Source == senderTeam).Any();
            context.Show(System.Windows.Forms.Control.MousePosition);
        }

        void renameTeam_Click(object sender, EventArgs e)
        {
             var senderTeam = this.FindAncestor<OrgContainerShape>();
             senderTeam.IsEditable = true;
             senderTeam.IsInEditMode = true;
             var editor = senderTeam.FindDescendant<RadTextBoxControlElement>();
             var text = editor.Text;
             editor.Text = "";
             editor.Text = text;
             editor.SelectAll();
             editor.KeyPress -= editor_KeyPress;
             editor.KeyPress += editor_KeyPress;
        }

        void editor_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                ((RadTextBoxControlElement)sender).FindAncestor<OrgContainerShape>().IsInEditMode = false;
            }
        }

        void removeTeam_Click(object sender, EventArgs e)
        {
            var senderTeam = this.FindAncestor<OrgContainerShape>();
            var diagramElement = this.FindAncestor<RadDiagramElement>();
            var linkToDelete = diagramElement.Connections.Where(x => x.Target == senderTeam).FirstOrDefault();
            if (linkToDelete != null)
            {
                var sourceShape = linkToDelete.Source as OrgContainerShape;
                sourceShape.ShowCollapseButton = diagramElement.Connections.Where(x => x.Source == sourceShape).Count() > 1;
                diagramElement.RemoveConnection(linkToDelete);
            }

            var teamMembers = senderTeam.Items.Where(x => x is RadDiagramShape);
            int i = teamMembers.Count() - 1;
            while(i>=0)
            {
                var teamMember = teamMembers.Last();
                i--;
                diagramElement.RemoveShape((RadDiagramShape)teamMember);
            }
            diagramElement.RemoveShape(senderTeam);
            OrgChartForm.currentLayoutSettings.Roots.Remove(senderTeam);
            diagramElement.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, OrgChartForm.currentLayoutSettings);
        }

        void addTeam_Click(object sender, EventArgs e)
        {
            var parentTeam = this.FindAncestor<OrgContainerShape>();
            var newTeam = new OrgContainerShape()
            {
                Name = "New " + parentTeam.Tag.ToString() + " Team",
                BaseColor = parentTeam.BaseColor,
            };

            parentTeam.ShowCollapseButton = true;
            newTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            newTeam.Text = newTeam.Name;
            newTeam.Tag = parentTeam.Tag.ToString();
            newTeam.Path = string.Format("{0}|{1}", parentTeam.Path, newTeam.Name);
            newTeam.TeamMembers = string.Format("0 Team Members");
            newTeam.ShowCollapseButton = false;
            OrgChartForm.currentLayoutSettings.Roots.Add(newTeam);

            var diagramElement = this.FindAncestor<RadDiagramElement>();
            diagramElement.AddShape(newTeam);

            RadDiagramConnection connection = new RadDiagramConnection();
            connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline;
            connection.Source = parentTeam;
            connection.Target = newTeam;
            connection.Route = true;
            diagramElement.AddConnection(connection);
         
            diagramElement.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, OrgChartForm.currentLayoutSettings);

        }

        public RadLabelElement TeamMembers
        {
            get
            {
                return this.teamMembers;
            }
        }
        
        /// <summary>
        /// MeasureOverride
        /// </summary>
        /// <param name="availableSize"></param>
        /// <returns></returns>
        protected override System.Drawing.SizeF MeasureOverride(System.Drawing.SizeF availableSize)
        {
            base.MeasureOverride(availableSize);
            return new System.Drawing.SizeF(availableSize.Width, Math.Max(this.label.DesiredSize.Height, this.toggleCollapseButton.DesiredSize.Height) + this.teamMembers.DesiredSize.Height);
        }
        
        /// <summary>
        /// ArrangeOverride
        /// </summary>
        /// <param name="finalSize"></param>
        /// <returns></returns>
        protected override System.Drawing.SizeF ArrangeOverride(System.Drawing.SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);
            
            var labelRect = new System.Drawing.RectangleF((finalSize.Width - this.label.DesiredSize.Width) / 2f , 0, finalSize.Width - this.toggleCollapseButton.DesiredSize.Width - 1, this.label.DesiredSize.Height);
            this.label.Arrange(labelRect);
            this.toggleCollapseButton.Arrange(new System.Drawing.RectangleF(
                0,
                0,
                this.toggleCollapseButton.DesiredSize.Width,
                this.toggleCollapseButton.DesiredSize.Height));
            
            var toggleRect = new System.Drawing.RectangleF(
                labelRect.X - this.toggleCollapseButton.DesiredSize.Width,
                (finalSize.Height - this.toggleCollapseButton.DesiredSize.Width) / 2f - 4,
                this.toggleCollapseButton.DesiredSize.Width,
                this.toggleCollapseButton.DesiredSize.Height);
            
            this.toggleCollapseButton.Arrange(toggleRect);
            
            var teamMembersRect = new System.Drawing.RectangleF(
                (finalSize.Width - this.teamMembers.DesiredSize.Width) / 2f ,
                Math.Max(labelRect.Height, this.toggleCollapseButton.DesiredSize.Height) + 2,
                this.teamMembers.DesiredSize.Width,
                this.teamMembers.DesiredSize.Height);           
            
            this.teamMembers.Arrange(teamMembersRect);
            return finalSize;
        }
    }
}
