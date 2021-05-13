Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Diagrams.Core

Namespace DiagramFirstLook
    Partial Public Class Form1
        Inherits RadRibbonForm

        Private timer As Timer = New Timer()

        Public Sub New(ByVal exampleName As String)
            Program.exampleName = exampleName
            InitializeComponent()
            CustomizeExampleAppearance()
        End Sub

        Public Sub New()
            InitializeComponent()
            CustomizeExampleAppearance()
        End Sub

        Private Sub CustomizeExampleAppearance()
            Me.radDropDownList1.SelectedIndex = 0
            Me.toolWindow3.Hide()

            If Program.themeName <> "" Then
                Me.ThemeName = Program.themeName
            Else
                Me.ThemeName = "TelerikMetro"
            End If

            Me.ApplyThemeRecursively(Me.Controls)
            Me.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Visible

            Select Case Program.exampleName
                Case "Firstlook"
                    Me.radDropDownList1.SelectedIndex = 0
                    Me.toolWindow3.Hide()
                    Me.radDropDownList1.Visible = False
                    Me.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 1
                Case "CycleDiagram"
                    Me.radDropDownList1.SelectedIndex = 1
                    Me.toolWindow3.Hide()
                    Me.radDropDownList1.Visible = False
                    Me.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 2
                Case "LinearProcess"
                    Me.radDropDownList1.SelectedIndex = 2
                    Me.toolWindow3.Hide()
                    Me.radDropDownList1.Visible = False
                    Me.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 3
                Case "Gap"
                    Me.radDropDownList1.SelectedIndex = 4
                    Me.toolWindow3.Hide()
                    Me.radDropDownList1.Visible = False
                    Me.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 2
                    Me.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Collapsed
                Case "Routing"
                    Me.radDropDownList1.SelectedIndex = 3
                    Me.radDropDownList1.Visible = False
                    Me.toolWindow3.Hide()
                    Me.diagramRibbonBar1.radRibbonBarGroup3.Visibility = ElementVisibility.Collapsed
                Case "Databinding"
                    Me.radDropDownList1.SelectedIndex = 5
                    Me.radDropDownList1.Visible = False
                    Me.toolWindow3.Hide()
                Case "FloorPlan"
                    Me.radDropDownList1.SelectedIndex = 6
                    Me.radDropDownList1.Visible = False
                    Me.radDiagram1.DiagramElement.Position = New Telerik.Windows.Diagrams.Core.Point(Me.radDiagram1.DiagramElement.Position.X - 50, Me.radDiagram1.DiagramElement.Position.Y)
                    Me.toolWindow3.Hide()
            End Select

            AddHandler Me.diagramRibbonBar1.ThemeNameChanged, AddressOf diagramRibbonBar1_ThemeNameChanged
            Me.diagramRibbonBar1.RibbonBarElement.ApplicationButtonElement.Visibility = ElementVisibility.Collapsed
            Me.diagramRibbonBar1.RibbonBarElement.TabStripElement.ItemContainer.Margin = New Padding(0)
            AddHandler Me.radPropertyGrid1.PropertyValueChanging, AddressOf radPropertyGrid1_PropertyValueChanging
        End Sub

        Private Sub diagramRibbonBar1_ThemeNameChanged(source As Object, args As ThemeNameChangedEventArgs)
            If Me.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility <> ElementVisibility.Collapsed Then
                Return
            End If

            Me.diagramRibbonBar1.RibbonBarElement.ResetValue(RadRibbonBarElement.SimplifiedHeightProperty, ValueResetFlags.Local)
            Me.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Visible
            Me.diagramRibbonBar1.RibbonBarElement.RibbonCaption.InvalidateMeasure(True)
            Me.diagramRibbonBar1.RibbonBarElement.UpdateLayout()
            Me.diagramRibbonBar1.RibbonBarElement.SimplifiedHeight -= TelerikDpiHelper.ScaleInt(Me.diagramRibbonBar1.RibbonBarElement.RibbonCaption.BoundingRectangle.Height, Me.ElementTree.RootElement.DpiScaleFactor)
            Me.diagramRibbonBar1.RibbonBarElement.RibbonCaption.Visibility = ElementVisibility.Collapsed
        End Sub

        Private Sub radPropertyGrid1_PropertyValueChanging(ByVal sender As Object, ByVal e As PropertyGridItemValueChangingEventArgs)
            If ((CType(e.Item, PropertyGridItem))).[ReadOnly] OrElse TypeOf (CType(e.Item, PropertyGridItem)).Accessor Is Telerik.WinControls.UI.PropertyGridData.ImmutableItemAccessor Then
                Return
            End If

            Dim item As PropertyGridItemBase = e.Item
            Dim propertyName As String = item.Name

            While item.Parent IsNot Nothing
                propertyName = item.Parent.Name & "." & propertyName
                item = item.Parent
            End While

            Telerik.WinControls.UI.Diagrams.UndoRedoHelper.ValueChanged(CType(Me.radDiagram1.DiagramElement.SelectedItem, IDiagramItem), propertyName, e.NewValue, e.OldValue)
        End Sub

        Private Sub DiagramElement_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radPropertyGrid1.SelectedObject = Me.radDiagram1.DiagramElement.SelectedItem
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Me.radDropDownList1.SelectedIndex <> -1 Then
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
                Me.radDiagram1.DataSource = Nothing
                Me.radDiagram1.Items.Clear()
                Me.radDiagram1.SerializedXml = resources.GetString(Me.radDropDownList1.SelectedItem.Tag.ToString())
                RemoveHandler timer.Tick, AddressOf timer_TickGap
                RemoveHandler timer.Tick, AddressOf timer_Tick
                Me.radDiagram1.AllowDelete = True
                Me.timer.[Stop]()
                Me.radDiagram1.ConnectionBridge = BridgeType.None

                If Me.radDropDownList1.SelectedIndex = 3 Then
                    Me.PrepareRoutingExample()
                ElseIf Me.radDropDownList1.SelectedIndex = 4 Then
                    Me.PrepareGapExample()
                ElseIf Me.radDropDownList1.SelectedIndex = 5 Then
                    Me.SetupDataBindindngs()
                End If
            Else
                Me.radDiagram1.SerializedXml = ""
            End If
        End Sub

        Private Sub PrepareGapExample()
            Me.radDiagram1.ConnectionBridge = BridgeType.Bow
            Me.radDiagram1.AllowDelete = False
            timer.Interval = 30
            AddHandler timer.Tick, AddressOf timer_TickGap
            timer.Start()
        End Sub

        Private Sub PrepareRoutingExample()
            Me.radDiagram1.RouteConnections = False
            Me.radDiagram1.RoutingService.Router = New Telerik.Windows.Diagrams.Core.AStarRouter(Me.radDiagram1.DiagramElement) With {
                .AvoidShapes = True
            }
            Me.radDiagram1.RoutingService.AutoUpdate = True
            Me.radDiagram1.RouteConnections = True
            Me.radDiagram1.AllowDelete = False
            timer.Interval = 30
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub

        Private [step] As Integer = 1
        Private step1 As Integer = -1

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim shape As RadDiagramShape = CType(Me.radDiagram1.Shapes(3), RadDiagramShape)
            Dim shape1 As RadDiagramShape = CType(Me.radDiagram1.Shapes(4), RadDiagramShape)
            shape.Position = New Telerik.Windows.Diagrams.Core.Point(shape.Position.X - [step], shape.Position.Y)
            shape1.Position = New Telerik.Windows.Diagrams.Core.Point(shape1.Position.X - step1, shape1.Position.Y)
            If shape.Position.X < 380 OrElse shape.Position.X > 620 Then [step] = -[step]
            If shape1.Position.X < 380 OrElse shape1.Position.X > 620 Then step1 = -step1
        End Sub

        Private connectionStep As Integer = 1

        Private Sub timer_TickGap(ByVal sender As Object, ByVal e As EventArgs)
            Dim connection1 As RadDiagramShape = CType(Me.radDiagram1.Shapes(4), RadDiagramShape)
            Dim connection2 As RadDiagramShape = CType(Me.radDiagram1.Shapes(5), RadDiagramShape)
            connection1.Position = New Telerik.Windows.Diagrams.Core.Point(connection1.Position.X - [step], connection1.Position.Y)
            connection2.Position = New Telerik.Windows.Diagrams.Core.Point(connection2.Position.X - [step], connection2.Position.Y)
            If connection1.Position.X < 250 OrElse connection1.Position.X > 440 Then [step] = -[step]
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            Me.timer.Dispose()
            MyBase.OnClosing(e)
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
    End Class
End Namespace
