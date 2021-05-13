
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports System

Namespace DiagramOrganizationChart
    Public Class OrgHeaderPresenterElement
        Inherits LightVisualElement
        Private ReadOnly toggleCollapseButton As RadToggleButtonElement
        Private label As RadLabelElement
        Private ReadOnly m_teamMembers As RadLabelElement

        ''' <summary>
        ''' HeaderPresenterElement
        ''' </summary>
        ''' <param name="toggleCollapseButton"></param>
        ''' <param name="label"></param>
        Public Sub New(toggleCollapseButton As RadToggleButtonElement, label As RadLabelElement)
            Me.StretchVertically = False

            Me.label = label
            Me.label.StretchHorizontally = False
            Me.label.Font = New Font(Me.label.Font.FontFamily, 14)
            Me.toggleCollapseButton = toggleCollapseButton
            Me.m_teamMembers = New RadLabelElement()

            Me.Children.Add(Me.label)
            Me.Children.Add(Me.toggleCollapseButton)
            Me.Children.Add(Me.m_teamMembers)

            Me.m_teamMembers.LabelFill.Visibility = Telerik.WinControls.ElementVisibility.Visible

            Me.m_teamMembers.ForeColor = Color.White
            Me.m_teamMembers.LabelFill.BackColor = Color.Black
            Me.m_teamMembers.LabelFill.NumberOfColors = 1
            AddHandler Me.m_teamMembers.Click, AddressOf Me.teamMembers_Click
        End Sub

        Public Property HeaderLabel() As RadLabelElement
            Get
                Return Me.label
            End Get
            Set(value As RadLabelElement)
                Me.label = value
            End Set
        End Property

        Private context As RadContextMenu

        Private addTeam As RadMenuItem
        Private renameTeam As RadMenuItem
        Private removeTeam As RadMenuItem

        Private Sub teamMembers_Click(sender As Object, e As EventArgs)
            Dim senderTeam = Me.FindAncestor(Of OrgContainerShape)()
            Dim diagramElement = Me.FindAncestor(Of RadDiagramElement)()

            If senderTeam.IsCollapsed Then
                Return
            End If

            If addTeam Is Nothing Then
                context = New RadContextMenu()
                addTeam = New RadMenuItem() With { _
                    .Text = "Add Team" _
                }
                AddHandler addTeam.Click, AddressOf addTeam_Click
                context.Items.Add(addTeam)

                renameTeam = New RadMenuItem() With { _
                    .Text = "Rename Team" _
                }
                AddHandler renameTeam.Click, AddressOf renameTeam_Click
                context.Items.Add(renameTeam)

                removeTeam = New RadMenuItem() With { _
                    .Text = "Remove Team" _
                }
                AddHandler removeTeam.Click, AddressOf removeTeam_Click
                context.Items.Add(addTeam)
                context.Items.Add(removeTeam)
            End If

            Dim count As Integer = 0
            For Each item As RadDiagramConnection In diagramElement.Connections
                If item.Source Is senderTeam Then count = count + 1
            Next

            removeTeam.Enabled = count > 0
            context.Show(System.Windows.Forms.Control.MousePosition)
        End Sub

        Private Sub renameTeam_Click(sender As Object, e As EventArgs)
            Dim senderTeam = Me.FindAncestor(Of OrgContainerShape)()
            senderTeam.IsEditable = True
            senderTeam.IsInEditMode = True
            Dim editor As RadTextBoxControlElement = senderTeam.FindDescendant(Of RadTextBoxControlElement)()
            Dim text = editor.Text
            editor.Text = ""
            editor.Text = text
            editor.SelectAll()
            RemoveHandler editor.KeyPress, AddressOf editor_KeyPress
            AddHandler editor.KeyPress, AddressOf editor_KeyPress
        End Sub

        Private Sub editor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                DirectCast(sender, RadTextBoxControlElement).FindAncestor(Of OrgContainerShape)().IsInEditMode = False
            End If
        End Sub

        Private Sub removeTeam_Click(sender As Object, e As EventArgs)
            Dim senderTeam As OrgContainerShape = Me.FindAncestor(Of OrgContainerShape)()
            Dim diagramElement As RadDiagramElement = Me.FindAncestor(Of RadDiagramElement)()
            Dim linkToDelete As Telerik.Windows.Diagrams.Core.IConnection = diagramElement.Connections.Where(Function(x) x.Target Is senderTeam).FirstOrDefault()
            If linkToDelete IsNot Nothing Then
                Dim sourceShape As OrgContainerShape = TryCast(linkToDelete.Source, OrgContainerShape)
                sourceShape.ShowCollapseButton = diagramElement.Connections.Where(Function(x) TryCast(x.Source, OrgContainerShape) Is sourceShape).Count() > 1
                diagramElement.RemoveConnection(linkToDelete)
            End If

            Dim teamMembers As IEnumerable(Of RadDiagramShape) = senderTeam.Items.Where(Function(x) TypeOf x Is RadDiagramShape)
            Dim i As Integer = teamMembers.Count() - 1
            While i >= 0
                Dim teamMember = teamMembers.Last()
                i -= 1
                diagramElement.RemoveShape(DirectCast(teamMember, RadDiagramShape))
            End While
            diagramElement.RemoveShape(senderTeam)
            OrgChartForm.currentLayoutSettings.Roots.Remove(senderTeam)
            diagramElement.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, OrgChartForm.currentLayoutSettings)
        End Sub

        Private Sub addTeam_Click(sender As Object, e As EventArgs)
            Dim parentTeam As OrgContainerShape = Me.FindAncestor(Of OrgContainerShape)()
            Dim newTeam As OrgContainerShape = New OrgContainerShape()
            newTeam.Name = "New " + parentTeam.Tag.ToString() + " Team"
            newTeam.BaseColor = parentTeam.BaseColor
            
                parentTeam.ShowCollapseButton = True
                newTeam.ToggleCollapseButton.ImagePrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden
                newTeam.Text = newTeam.Name
                newTeam.Tag = parentTeam.Tag.ToString()
                newTeam.Path = String.Format("{0}|{1}", parentTeam.Path, newTeam.Name)
                newTeam.TeamMembers = String.Format("0 Team Members")
                newTeam.ShowCollapseButton = False
                OrgChartForm.currentLayoutSettings.Roots.Add(newTeam)

                Dim diagramElement As RadDiagramElement = Me.FindAncestor(Of RadDiagramElement)()
                diagramElement.AddShape(newTeam)

                Dim connection As New RadDiagramConnection()
                connection.ConnectionType = Telerik.Windows.Diagrams.Core.ConnectionType.Polyline
                connection.Source = parentTeam
                connection.Target = newTeam
                connection.Route = True
                diagramElement.AddConnection(connection)

                diagramElement.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, OrgChartForm.currentLayoutSettings)

        End Sub


        Public ReadOnly Property TeamMembers() As RadLabelElement
            Get
                Return Me.m_teamMembers
            End Get
        End Property

        ''' <summary>
        ''' MeasureOverride
        ''' </summary>
        ''' <param name="availableSize"></param>
        ''' <returns></returns>
        Protected Overrides Function MeasureOverride(availableSize As System.Drawing.SizeF) As System.Drawing.SizeF
            MyBase.MeasureOverride(availableSize)
            Return New System.Drawing.SizeF(availableSize.Width, Math.Max(Me.label.DesiredSize.Height, Me.toggleCollapseButton.DesiredSize.Height) + Me.m_teamMembers.DesiredSize.Height)
        End Function

        ''' <summary>
        ''' ArrangeOverride
        ''' </summary>
        ''' <param name="finalSize"></param>
        ''' <returns></returns>
        Protected Overrides Function ArrangeOverride(finalSize As System.Drawing.SizeF) As System.Drawing.SizeF
            MyBase.ArrangeOverride(finalSize)

            Dim labelRect = New System.Drawing.RectangleF((finalSize.Width - Me.label.DesiredSize.Width) / 2.0F, 0, finalSize.Width - Me.toggleCollapseButton.DesiredSize.Width - 1, Me.label.DesiredSize.Height)
            Me.label.Arrange(labelRect)
            Me.toggleCollapseButton.Arrange(New System.Drawing.RectangleF(0, 0, Me.toggleCollapseButton.DesiredSize.Width, Me.toggleCollapseButton.DesiredSize.Height))

            Dim toggleRect = New System.Drawing.RectangleF(labelRect.X - Me.toggleCollapseButton.DesiredSize.Width, (finalSize.Height - Me.toggleCollapseButton.DesiredSize.Width) / 2.0F - 4, Me.toggleCollapseButton.DesiredSize.Width, Me.toggleCollapseButton.DesiredSize.Height)

            Me.toggleCollapseButton.Arrange(toggleRect)

            Dim teamMembersRect = New System.Drawing.RectangleF((finalSize.Width - Me.m_teamMembers.DesiredSize.Width) / 2.0F, Math.Max(labelRect.Height, Me.toggleCollapseButton.DesiredSize.Height) + 2, Me.m_teamMembers.DesiredSize.Width, Me.m_teamMembers.DesiredSize.Height)

            Me.m_teamMembers.Arrange(teamMembersRect)
            Return finalSize
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
