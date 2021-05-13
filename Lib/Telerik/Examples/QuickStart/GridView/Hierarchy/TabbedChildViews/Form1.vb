Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.Charting.Styles
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Hierarchy.TabbedChildViews
    Partial Public Class Form1
        Inherits ExamplesForm

        '#Pragma warning disable 618
        Private chart As New RadChart()

        Public Sub New()
            InitializeComponent()
            Me.SelectedControl = Me.radGridView1
        End Sub

#Region "Event handlers"

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.BeginUpdate()

            Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
            Me.ordersTableAdapter.Fill(Me.northwindDataSet.Orders)

            PrepareChartControl()
            LoadDetailsTable()
            LoadPerformanceTable()

            Me.radGridView1.UseScrollbarsInHierarchy = True
            Me.radGridView1.[ReadOnly] = True
            Me.radGridView1.AutoExpandGroups = True
            Me.radGridView1.GroupDescriptors.Add("City", ListSortDirection.Ascending)

            Me.radGridView1.EndUpdate()

            Me.radGridView1.Rows(0).IsExpanded = True
        End Sub

        Private Sub radGridView1_ChildViewExpanded(sender As Object, e As ChildViewExpandedEventArgs)
            e.ChildRow.ChildViewInfos(0).ChildRows(0).Height = 152
            e.ChildRow.ChildViewInfos(2).ChildRows(0).Height = 152
            e.ChildRow.Height = 224
        End Sub

        Private Sub radGridView1_CellFormatting(sender As Object, e As CellFormattingEventArgs)
            Dim column As GridViewDataColumn = TryCast(e.CellElement.ColumnInfo, GridViewDataColumn)
            If column IsNot Nothing AndAlso column.OwnerTemplate.Caption = "Details" Then
                If column.FieldName = "FirstName" Then
                    e.CellElement.Text = "<html><b>Name:</b> " + e.CellElement.RowInfo.Cells("LastName").Value.ToString() + ", " + e.CellElement.RowInfo.Cells("FirstName").Value.ToString()
                End If
                If column.FieldName = "BirthDate" Then
                    e.CellElement.Text = String.Format("<html><b>Birth Date:</b> {0:d}", e.CellElement.RowInfo.Cells("BirthDate").Value)
                End If
                If column.FieldName = "Title" Then
                    e.CellElement.Text = "<html><b>Title:</b> " + e.CellElement.RowInfo.Cells("Title").Value.ToString()
                End If
                If column.FieldName = "Address" Then
                    e.CellElement.Text = "<html><b>Address:</b> " + e.CellElement.RowInfo.Cells("Address").Value.ToString()
                End If
                If TypeOf e.CellElement Is GridImageCellElement Then
                    DirectCast(e.CellElement, GridImageCellElement).ImageLayout = ImageLayout.Zoom
                End If
            End If
            If column IsNot Nothing AndAlso column.OwnerTemplate.Caption = "Performance" Then
                If e.CellElement.RowInfo.Tag Is Nothing Then
                    chart.Series.Clear()
                    chart.Series.Add(GetRowData(DirectCast(e.CellElement.RowInfo, GridViewRowInfo)))
                    e.CellElement.RowInfo.Tag = chart.GetBitmap()
                End If
                e.CellElement.Image = TryCast(e.CellElement.RowInfo.Tag, Image)
                e.CellElement.DrawBorder = False
                e.CellElement.DrawFill = False
                e.CellElement.Text = ""
                e.CellElement.Padding = New Padding(10, 0, 0, 0)
            End If
        End Sub

        Private Sub radGridView1_CreateCell(sender As Object, e As GridViewCreateCellEventArgs)
            If e.CellType Is GetType(GridDetailViewCellElement) Then
                e.CellElement = New CustomDetailViewCellElement(e.Column, e.Row)
            End If
        End Sub

        Private Sub radRadioButton1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterTemplate.ChildViewTabsPosition = Telerik.WinControls.UI.TabPositions.Top
        End Sub

        Private Sub radRadioButton2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Bottom
        End Sub

        Private Sub radRadioButton3_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Left
        End Sub

        Private Sub radRadioButton4_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Right
        End Sub

        Private Sub radRadioButton5_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.TableElement.PageViewMode = PageViewMode.Strip
        End Sub

        Private Sub radRadioButton6_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.TableElement.PageViewMode = PageViewMode.Stack
        End Sub

        Private Sub radRadioButton7_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.TableElement.PageViewMode = PageViewMode.Outlook
        End Sub

        Private Sub radRadioButton8_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radGridView1.TableElement.PageViewMode = PageViewMode.ExplorerBar
        End Sub

#End Region

        Private Sub PrepareChartControl()
            chart.Size = New Size(600, 150)
            chart.Chart.ChartTitle.Visible = False
            chart.Legend.Visible = False
            chart.Appearance.Border.Visible = False
            chart.Appearance.FillStyle.MainColor = Color.White
            chart.AutoLayout = True
            chart.ChartTitle.Visible = False
            chart.ChartTitle.TextBlock.Text = ""
            chart.PlotArea.Appearance.Border.Visible = False
            chart.PlotArea.Appearance.FillStyle.FillType = FillType.Solid
            chart.PlotArea.Appearance.FillStyle.MainColor = Color.Transparent
            chart.PlotArea.Appearance.FillStyle.SecondColor = Color.Transparent
            chart.PlotArea.YAxis.Appearance.CustomFormat = "C0"
            chart.PlotArea.YAxis.LabelStep = 2
            chart.PlotArea.XAxis.Appearance.ValueFormat = ChartValueFormat.ShortDate
            chart.PlotArea.XAxis.Appearance.CustomFormat = "dd/MM"
        End Sub

        Private Sub LoadDetailsTable()
            Dim table As New DataTable("Details")
            table.Columns.Add("EmployeeID", GetType(Integer))
            table.Columns.Add("Photo", GetType(Byte()))
            table.Columns.Add("FirstName", GetType(String))
            table.Columns.Add("LastName", GetType(String))
            table.Columns.Add("Title", GetType(String))
            table.Columns.Add("Address", GetType(String))
            table.Columns.Add("City", GetType(String))
            table.Columns.Add("BirthDate", GetType(DateTime))
            table.Columns.Add("Country", GetType(String))
            For Each row As DataRow In Me.northwindDataSet.Employees.Rows
                table.Rows.Add(row("EmployeeID"), row("Photo"), row("FirstName"), row("LastName"), row("Title"), row("Address"), _
                 row("City"), row("BirthDate"), row("Country"))
            Next

            Dim template As New GridViewTemplate()
            template.Caption = "Details"
            template.DataSource = table
            template.AllowRowResize = False
            template.ShowColumnHeaders = False
            template.Columns("Photo").Width = 125
            template.Columns("City").Width = 70
            template.Columns("Country").Width = 70
            template.Columns("FirstName").DisableHTMLRendering = False
            template.Columns("Title").DisableHTMLRendering = False
            template.Columns("BirthDate").DisableHTMLRendering = False
            template.Columns("Address").Width = 200
            template.Columns("Address").DisableHTMLRendering = False
            Me.radGridView1.Templates.Insert(0, template)


            Dim relation As New GridViewRelation(Me.radGridView1.MasterTemplate)
            relation.ChildTemplate = template
            relation.ParentColumnNames.Add("EmployeeID")
            relation.ChildColumnNames.Add("EmployeeID")
            Me.radGridView1.Relations.Add(relation)

            Dim viewDef As New HtmlViewDefinition()
            viewDef.RowTemplate.Rows.Add(New RowDefinition())
            viewDef.RowTemplate.Rows.Add(New RowDefinition())
            viewDef.RowTemplate.Rows.Add(New RowDefinition())
            viewDef.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Photo", 0, 1, 3))
            viewDef.RowTemplate.Rows(0).Cells.Add(New CellDefinition("FirstName", 0, 1, 1))
            viewDef.RowTemplate.Rows(0).Cells.Add(New CellDefinition("BirthDate", 0, 2, 1))
            viewDef.RowTemplate.Rows(1).Cells.Add(New CellDefinition("Title", 0, 3, 1))
            viewDef.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Address", 0, 1, 1))
            viewDef.RowTemplate.Rows(2).Cells.Add(New CellDefinition("City", 0, 1, 1))
            viewDef.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Country", 0, 1, 1))
            template.ViewDefinition = viewDef
        End Sub

        Private Sub LoadPerformanceTable()
            Dim r As New Random()
            Dim chartTable As New DataTable()
            chartTable.Columns.Add("EmployeeID", GetType(Integer))
            For i As Integer = 0 To 11
                chartTable.Columns.Add("Month" + (i + 1).ToString(), GetType(Integer))
            Next
            For Each row As DataRow In Me.northwindDataSet.Employees.Rows
                Dim dataRow As DataRow = chartTable.NewRow()
                dataRow("EmployeeID") = row("EmployeeID")
                For i As Integer = 0 To 11
                    dataRow(i + 1) = r.[Next](1000) * 10
                Next
                chartTable.Rows.Add(dataRow)
            Next
            Dim template2 As New GridViewTemplate()
            template2.Caption = "Performance"
            template2.DataSource = chartTable
            template2.AllowRowResize = False
            template2.ShowColumnHeaders = False
            template2.ShowRowHeaderColumn = False
            template2.Columns(0).Width = 600
            For i As Integer = 1 To template2.Columns.Count - 1
                template2.Columns(i).IsVisible = False
            Next
            Me.radGridView1.Templates.Add(template2)

            Dim relation2 As New GridViewRelation(Me.radGridView1.MasterTemplate)
            relation2.ChildTemplate = template2
            relation2.ParentColumnNames.Add("EmployeeID")
            relation2.ChildColumnNames.Add("EmployeeID")
            Me.radGridView1.Relations.Add(relation2)
        End Sub

        Private Function GetRowData(row As GridViewRowInfo) As Telerik.Charting.ChartSeries
            Dim series As New Telerik.Charting.ChartSeries()
            series.Type = ChartSeriesType.Bar
            series.Name = "Sales"
            series.Appearance.LabelAppearance.Visible = False
            For i As Integer = 0 To 11
                series.Items.Add(New ChartSeriesItem(CInt(row.Cells(i + 1).Value)))
            Next
            Return series
        End Function

        Protected Overrides Sub WireEvents()
            AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
            AddHandler radGridView1.ChildViewExpanded, AddressOf radGridView1_ChildViewExpanded
            AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
            AddHandler radRadioButton4.ToggleStateChanged, AddressOf radRadioButton4_ToggleStateChanged
            AddHandler radRadioButton3.ToggleStateChanged, AddressOf radRadioButton3_ToggleStateChanged
            AddHandler radRadioButton2.ToggleStateChanged, AddressOf radRadioButton2_ToggleStateChanged
            AddHandler radRadioButton1.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
            AddHandler radRadioButton5.ToggleStateChanged, AddressOf radRadioButton5_ToggleStateChanged
            AddHandler radRadioButton6.ToggleStateChanged, AddressOf radRadioButton6_ToggleStateChanged
            AddHandler radRadioButton7.ToggleStateChanged, AddressOf radRadioButton7_ToggleStateChanged
            AddHandler radRadioButton8.ToggleStateChanged, AddressOf radRadioButton8_ToggleStateChanged
        End Sub
    End Class
End Namespace
