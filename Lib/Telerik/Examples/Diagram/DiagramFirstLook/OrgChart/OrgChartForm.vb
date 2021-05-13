Imports DiagramFirstLook
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace DiagramOrganizationChart
    Partial Public Class OrgChartForm
        Inherits RadForm

        Private width As Integer = 2000
        Private topPoint As Telerik.Windows.Diagrams.Core.Point = New Telerik.Windows.Diagrams.Core.Point(200, 200)
        Friend Shared currentLayoutSettings As Telerik.Windows.Diagrams.Core.TreeLayoutSettings
        Private groupColor As Color() = New Color() {Color.FromArgb(49, 49, 49), Color.FromArgb(47, 153, 69), Color.FromArgb(36, 159, 217)}

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub InitializeDiagram()
            If Program.themeName <> "" Then
                'set the example theme to the same theme QSF uses
                Me.ThemeName = Program.themeName
            Else
                Me.ThemeName = "TelerikMetro"
            End If

            Me.ApplyThemeRecursively(Me.Controls)
            Me.radDiagram1.BackColor = System.Drawing.Color.White
            Me.radDiagram1.ForeColor = System.Drawing.Color.Black
            Me.radDiagram1.IsInformationAdornerVisible = False
            Me.radDiagram1.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PanTool
            Me.radDiagram1.IsSnapToGridEnabled = False
            Me.radDiagram1.IsSnapToItemsEnabled = False
            Me.radDiagram1.RouteConnections = False
            Me.radDiagram1.RoutingService.Router = New Telerik.Windows.Diagrams.Core.OrgTreeRouter() With {
                .TreeLayoutType = Telerik.Windows.Diagrams.Core.TreeLayoutType.TreeDown
            }
            Me.radDiagram1.RoutingService.AutoUpdate = True
            Me.radDiagram1.RouteConnections = True
            Me.radDiagram1.BackgroundGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden
            Me.radDiagram1.BackgroundPageGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden
            Me.radDiagram1.IsSettingsPaneEnabled = False
            currentLayoutSettings = New Telerik.Windows.Diagrams.Core.TreeLayoutSettings() With {
                .HorizontalSeparation = 120.0R,
                .VerticalSeparation = 180.0R,
                .UnderneathVerticalTopOffset = 50.0R,
                .UnderneathHorizontalOffset = 230.0R,
                .UnderneathVerticalSeparation = 40.0R,
                .VerticalDistance = 10.0R
            }
            Me.PopulateWithData()
            Me.radDiagram1.Zoom = 0.8
            Me.radDiagram1.DiagramElement.HorizontalScrollbar.Value = 250
            Me.radDiagram1.DiagramElement.VerticalScrollbar.Value = 100
            Me.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings)
        End Sub

        Private Sub ApplyThemeRecursively(ByVal controls As Control.ControlCollection)
            For Each control As Control In controls
                Dim radControl As RadControl = TryCast(control, RadControl)

                If radControl IsNot Nothing Then
                    radControl.ThemeName = Me.ThemeName
                End If

                Me.ApplyThemeRecursively(control.Controls)
            Next
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.InitializeDiagram()
        End Sub

        Public Function GetImageFromResource(ByVal fileName As String) As Image
            Using stream As Stream = Me.[GetType]().Assembly.GetManifestResourceStream(String.Format("DiagramFirstLook.Resources.{0}.png", fileName))
                Return New Bitmap(Image.FromStream(stream), 40, 40)
            End Using
        End Function

        Private Sub PopulateWithData()
            Dim dataXml As XElement = XElement.Load(Me.[GetType]().Assembly.GetManifestResourceStream("DiagramFirstLook.Resources.Organization.xml"))

            For Each element As XElement In dataXml.Elements("Node")
                Dim node As OrgContainerShape = Me.CreateNode(element, Nothing)
                node.BaseColor = Me.groupColor(0)
                Me.radDiagram1.AddShape(node)
                currentLayoutSettings.Roots.Add(node)
                Me.GetSubNodes(element, node, 2)
            Next
        End Sub

        Private Function CreateNode(ByVal element As XElement, ByVal parentNode As OrgContainerShape) As OrgContainerShape
            Dim orgTeam As OrgContainerShape = New OrgContainerShape()
            orgTeam.Name = element.Attribute("Name").Value

            orgTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden
            orgTeam.Text = orgTeam.Name
            orgTeam.Tag = element.Attribute("Branch").Value
            orgTeam.Path = If(parentNode Is Nothing, orgTeam.Name, String.Format("{0}|{1}", parentNode.Path, orgTeam.Name))
            currentLayoutSettings.Roots.Add(orgTeam)

            If parentNode IsNot Nothing Then
                Dim connection As RadDiagramConnection = New RadDiagramConnection()
                connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline
                connection.Source = parentNode
                connection.Target = orgTeam
                Me.radDiagram1.AddConnection(connection)
            End If

            Dim teamMembers = Me.GetTeamMembers(element, orgTeam)
            Dim position = New Telerik.Windows.Diagrams.Core.Point(10, 50)
            Dim memberCount As Integer = 0

            For Each member As RadDiagramShape In teamMembers
                Me.radDiagram1.AddShape(member)
                orgTeam.Items.Add(member)
                member.Position = position
                position.X += member.Width + 20

                If System.Threading.Interlocked.Increment(memberCount) Mod 2 = 0 Then
                    position = New Telerik.Windows.Diagrams.Core.Point(10, position.Y + member.Height + 10)
                End If
            Next

            AddHandler orgTeam.IsCollapsedChanged, AddressOf Me.orgTeam_IsCollapsedChanged
            Return orgTeam
        End Function

        Private Function GetTeamMembers(ByVal element As XContainer, ByVal team As OrgContainerShape) As ObservableCollection(Of RadDiagramShape)
            Dim members = New ObservableCollection(Of RadDiagramShape)()

            For Each xmlNodeMember As XElement In element.Elements("NodeMember")
                Dim member As RadDiagramShape = Me.CreateMemberShape(team, xmlNodeMember)
                members.Add(member)
            Next

            Return members
        End Function

        Private Function CreateMemberShape(ByVal team As OrgContainerShape, ByVal xmlNodeMember As XElement) As RadDiagramShape
            Dim member As RadDiagramShape = New RadDiagramShape()
            member.IsConnectorsManipulationEnabled = False
            member.ForeColor = Color.White
            member.IsRotationEnabled = False
            member.IsResizingEnabled = False
            member.Shape = New Telerik.WinControls.RoundRectShape(0)
            member.BackColor = Color.LightBlue
            member.Width = 190
            member.Height = 50
            member.Tag = team
            member.Name = xmlNodeMember.Attribute("Name").Value
            member.DiagramShapeElement.TextAlignment = ContentAlignment.MiddleLeft
            member.DiagramShapeElement.ImageLayout = ImageLayout.None
            member.DiagramShapeElement.Padding = New System.Windows.Forms.Padding(5, 2, 2, 0)
            member.DiagramShapeElement.Image = Me.GetImageFromResource(member.Name)
            member.DiagramShapeElement.ImageAlignment = ContentAlignment.MiddleLeft
            member.DiagramShapeElement.TextImageRelation = TextImageRelation.ImageBeforeText
            member.DiagramShapeElement.TextWrap = False
            member.Text = String.Format(" {0}\n{1}", member.Name, xmlNodeMember.Attribute("Position").Value)
            Return member
        End Function

        Private Const LastLevel As Integer = 3

        Private Function GetSubNodes(ByVal element As XContainer, ByVal parent As OrgContainerShape, ByVal level As Integer) As ObservableCollection(Of OrgContainerShape)
            Dim nodes = New ObservableCollection(Of OrgContainerShape)()
            Dim elements As List(Of XElement) = New List(Of XElement)(element.Elements("Node"))

            If elements.Count = 0 Then
                Return nodes
            End If

            For Each subElement As XElement In elements
                Dim node As OrgContainerShape = Me.CreateNode(subElement, parent)
                node.ShowCollapseButton = level < 3

                If node.Path.Contains("Development") Then
                    node.BaseColor = Me.groupColor(2)
                End If

                If node.Path.Contains("Marketing") Then
                    node.BaseColor = Me.groupColor(1)
                End If

                Me.radDiagram1.AddShape(node)
                Me.GetSubNodes(subElement, node, level + 1)
                nodes.Add(node)
            Next

            Return nodes
        End Function

        Private Sub orgTeam_IsCollapsedChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Diagrams.RoutedEventArgs)
            Me.radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings)
        End Sub
    End Class
End Namespace
