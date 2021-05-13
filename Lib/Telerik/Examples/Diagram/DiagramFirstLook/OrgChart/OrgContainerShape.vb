Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace DiagramOrganizationChart
 Public Class OrgContainerShape
	 Inherits RadDiagramContainerShape
		Private Const BottomOffset As Integer = 25
		Private isUpdating As Boolean = False
		Private baseColor_Renamed As System.Drawing.Color
		Private showCollapseButton_Renamed As Boolean = True
		Private ReadOnly collapseElement As LightVisualElement = New LightVisualElement()
		Private Shared ReadOnly segoeUI As Font = New Font("Segoe UI Symbol", 11)
		Public Sub New()
			Me.IsConnectorsManipulationEnabled = False
			Me.HeaderPresenter.ZIndex = 10
			Me.HeaderPresenter.DrawFill = False
			Me.DrawBorder = True
			Me.IsDraggingEnabled = False
			Me.BaseColor = System.Drawing.Color.LightGray
			Me.ContentShapeElement.BorderColor = System.Drawing.Color.LightGray
			Me.ContentShapeElement.BorderWidth = 2
			Me.ContentShapeElement.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
			Me.ContentShapeElement.BorderDashPattern = New Single() { 4, 1 }
			Me.ContentShapeElement.Margin = New Padding(0, 0, 0, BottomOffset)
			Me.MinWidth = 325
			AddHandler Me.Items.CollectionChanged, AddressOf Items_CollectionChanged
			Me.IsResizingEnabled = False
			Me.collapseElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
			Me.collapseElement.MinSize = New Size(15, 15)
			Me.collapseElement.Text = "-"
			Me.collapseElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
			Me.collapseElement.DrawBorder = True
			AddHandler Me.collapseElement.Click, AddressOf collapseElement_Click
			Me.Children.Add(Me.collapseElement)
			Me.IsEditable = False
			AddHandler Me.ToggleCollapseButton.ToggleStateChanged, AddressOf toggleCollapseButton_ToggleStateChanged
			Me.ToggleCollapseButton.Image = Nothing
            Me.ToggleCollapseButton.Font = segoeUI
            Me.ToggleCollapseButton.ForeColor = Color.Black
            Me.ToggleCollapseButton.Text = "▼"

		End Sub

		Protected Sub toggleCollapseButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.ToggleCollapseButton.Image = Nothing
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.ToggleCollapseButton.ForeColor = Color.White
                Me.ToggleCollapseButton.Text = "▶"
			Else
				Me.ToggleCollapseButton.ForeColor = Color.Black
                Me.ToggleCollapseButton.Text = "▼"
			End If
		End Sub


		Public Property ShowCollapseButton() As Boolean
			Get
				Return Me.showCollapseButton_Renamed
			End Get
			Set
				Me.showCollapseButton_Renamed = Value
				If Value Then
					Me.collapseElement.Visibility = Telerik.WinControls.ElementVisibility.Visible
				Else
					Me.collapseElement.Visibility = Telerik.WinControls.ElementVisibility.Hidden
				End If
			End Set
		End Property

		Private Sub collapseElement_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim isNotVisible As Boolean = Me.collapseElement.Text = "+"
			Me.ChangeConnectionVisibility(Me, (Not isNotVisible))
			If (Not isNotVisible) Then
				Me.collapseElement.Text = "+"
			Else
				Me.collapseElement.Text = "-"
			End If
		End Sub

		Private Sub ChangeConnectionVisibility(ByVal sourceShape As Telerik.Windows.Diagrams.Core.IShape, ByVal isVisible As Boolean)
            For Each connection As Telerik.Windows.Diagrams.Core.IConnection In sourceShape.OutgoingLinks
                If isVisible Then
                    connection.Visibility = Telerik.WinControls.ElementVisibility.Hidden
                Else
                    connection.Visibility = Telerik.WinControls.ElementVisibility.Visible
                End If
                If isVisible Then
                    connection.Target.Visibility = Telerik.WinControls.ElementVisibility.Hidden
                Else
                    connection.Target.Visibility = Telerik.WinControls.ElementVisibility.Visible
                End If
                Dim container As RadDiagramContainerShape = TryCast(connection.Target, RadDiagramContainerShape)
                If Not container Is Nothing Then
                    For Each item As Telerik.Windows.Diagrams.Core.IDiagramItem In container.Items
                        If isVisible Then
                            item.Visibility = Telerik.WinControls.ElementVisibility.Hidden
                        Else
                            item.Visibility = Telerik.WinControls.ElementVisibility.Visible
                        End If
                    Next item
                End If

                Me.ChangeConnectionVisibility(connection.Target, isVisible)
            Next connection
        End Sub

        Public Property BaseColor() As Color
            Get
                Return Me.baseColor_Renamed
            End Get
            Set(value As Color)
                Me.baseColor_Renamed = Value
                For Each child As RadDiagramShape In Me.Items
                    child.BackColor = Me.BaseColor
                Next child

                CType(Me.HeaderPresenter, OrgHeaderPresenterElement).TeamMembers.LabelFill.BackColor = Me.BaseColor
            End Set
        End Property

        Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
            Dim sizeF = New SizeF(availableSize.Width, availableSize.Height - BottomOffset)
            Return MyBase.MeasureOverride(sizeF)
        End Function

        Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
            MyBase.ArrangeOverride(finalSize)
            Dim top As Single = Me.HeaderPresenter.DesiredSize.Height - Me.HeaderPresenter.DesiredSize.Height / 4.0F
            Dim contentRect As RectangleF = New RectangleF(0, top, finalSize.Width, finalSize.Height - top)
            Me.ContentShapeElement.Arrange(contentRect)
            Dim collapseRect = New RectangleF((finalSize.Width - Me.collapseElement.DesiredSize.Width) / 2, finalSize.Height - Me.collapseElement.DesiredSize.Height - Me.collapseElement.DesiredSize.Height / 3, Me.collapseElement.DesiredSize.Width, Me.collapseElement.DesiredSize.Height)
            Me.collapseElement.Arrange(collapseRect)
            Return finalSize
        End Function

        Protected Overrides Sub OnIsCollapsedChanged(ByVal newValue As Boolean, ByVal oldValue As Boolean)
            MyBase.OnIsCollapsedChanged(newValue, oldValue)
            Me.DrawBorder = Not Me.IsCollapsed
            If Me.IsCollapsed Then
                Me.Height = Me.MinHeight + BottomOffset
                CType(Me.HeaderPresenter, OrgHeaderPresenterElement).HeaderLabel.LabelText.ForeColor = Color.White
            Else
                CType(Me.HeaderPresenter, OrgHeaderPresenterElement).HeaderLabel.LabelText.ForeColor = Color.Black
            End If

            Me.ContentShapeElement.DrawFill = Not Me.IsCollapsed
            Me.HeaderPresenter.BackColor = Me.baseColor_Renamed
            Me.HeaderPresenter.DrawFill = Me.IsCollapsed
        End Sub

        Protected Overrides Function CreateHeaderPresenter() As LightVisualElement
            Return New OrgHeaderPresenterElement(Me.ToggleCollapseButton, Me.Label) With { _
                .MaxSize = New Size(250, 0), _
                .MinSize = New Size(0, 48), _
                .Alignment = ContentAlignment.TopCenter _
            }
        End Function


        Public Property Path() As String
            Get
                Return m_Path
            End Get
            Set(value As String)
                m_Path = Value
            End Set
        End Property
        Private m_Path As String

        Public Property TeamMembers() As String
            Get
                Return DirectCast(Me.HeaderPresenter, OrgHeaderPresenterElement).TeamMembers.Text
            End Get
            Set(value As String)
                DirectCast(Me.HeaderPresenter, OrgHeaderPresenterElement).TeamMembers.Text = value
            End Set
        End Property


        ''' <summary>
        ''' Height
        ''' </summary>
        Public Overrides Property Height() As Double
            Get
                Return MyBase.Height
            End Get
            Set(value As Double)
                If Me.isUpdating Then
                    Return
                End If

                Me.isUpdating = True
                MyBase.Height = value

                If Me.IsInValidState(True) Then
                    Dim bounds = Me.CalculateMinShapeBounds()
                    If Me.MinHeight <= bounds.Height + BottomOffset + 5 Then
                        Me.MinHeight = Me.Height + BottomOffset
                    End If
                End If

                'this.MinHeight = value + BottomOffset;

                Me.isUpdating = False
            End Set
        End Property


        Private Sub Items_CollectionChanged(sender As Object, e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            Me.TeamMembers = String.Format("{0} Team Members", Me.Items.Count)
            Me.MinHeight = 0
            If Not e.NewItems Is Nothing AndAlso TypeOf e.NewItems(0) Is RadDiagramShape Then
                CType(e.NewItems(0), RadDiagramShape).BackColor = Me.BaseColor
            End If

            Dim position = New Telerik.Windows.Diagrams.Core.Point(Me.Position.X + 10, Me.Position.Y + 50)

            Dim memberCount As Integer = 0

            For Each item As Telerik.WinControls.UI.Diagrams.RadDiagramItem In Me.Items
                Dim member = TryCast(item, RadDiagramShape)
                If member Is Nothing Then
                    Continue For
                End If
                member.Position = position
                position.X += member.Width + 20
                'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                'ORIGINAL LINE: if (memberCount += 1 Mod 2 == 0)
                memberCount = memberCount + 1
                If (memberCount Mod 2) = 0 Then
                    position = New Telerik.Windows.Diagrams.Core.Point(Me.Position.X + 10, position.Y + member.Height + 10)
                End If
            Next item

            If position.Y + 50 > Me.Position.Y + Me.Height Then
                Me.UpdateContentBounds()
                Me.UpdateContainerLayout()
                Me.MinHeight = Me.Height + BottomOffset
                Me.UpdateContentBounds()
                Me.UpdateContainerLayout()
            End If
        End Sub
    End Class
End Namespace