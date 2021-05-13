Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Reflection
Imports System.IO
'using Telerik.WinControls.UI.Export;

Namespace Telerik.Examples.WinControls.GridView.Customize.ScreenTips
	Partial Public Class Form1
		Inherits ExamplesForm
		Private executingAssembly As System.Reflection.Assembly

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			Me.radGridView1.EnableFiltering = False
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			AddHandler radGridView1.ScreenTipNeeded, AddressOf radGridView1_ScreenTipNeeded
			Me.radGridView1.TableElement.RowHeight = 60
			Me.radGridView1.TableElement.TableHeaderHeight = 35

			Me.BindGrid()

			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)
		End Sub

		Private Sub BindGrid()
			Dim imageColumn As New GridViewImageColumn("CarPicture")
			imageColumn.ImageLayout = ImageLayout.Zoom
			imageColumn.MaxWidth = 80
			imageColumn.MinWidth = 80
			imageColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
			imageColumn.HeaderText = "Car Picture"

            Dim carNameColumn As New GridViewTextBoxColumn("CarName")
            carNameColumn.Width = 300
            carNameColumn.HeaderText = "Car"
            carNameColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter

            Dim priceColumn As New GridViewDecimalColumn("Price")
            priceColumn.HeaderText = "Price"
            priceColumn.Width = 100
            priceColumn.FormatString = "${0:N0}"
            priceColumn.TextAlignment = ContentAlignment.MiddleRight
            priceColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter

            Dim maxSpeedColumn As New GridViewDecimalColumn("MaxSpeed")
            maxSpeedColumn.TextAlignment = ContentAlignment.MiddleRight
            maxSpeedColumn.HeaderText = "Max Speed"
            maxSpeedColumn.FormatString = "{0} mph"
            maxSpeedColumn.Width = 100
            maxSpeedColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter

            Dim companyColumn As New GridViewTextBoxColumn("CompanyName")
            companyColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
            companyColumn.HeaderText = "Manufacturer"
            companyColumn.Width = 300

            Me.radGridView1.Columns.Add(imageColumn)
            Me.radGridView1.Columns.Add(carNameColumn)
            Me.radGridView1.Columns.Add(companyColumn)
            Me.radGridView1.Columns.Add(priceColumn)
            Me.radGridView1.Columns.Add(maxSpeedColumn)

			radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.DataSource = CreateDataTable()
		End Sub

		Private Function CreateDataTable() As DataTable
			Dim table As New DataTable("Cars")

			table.Columns.Add("CarID", GetType(Integer))
			table.Columns.Add("CarPicture", GetType(Image))
			table.Columns.Add("CarName", GetType(String))
			table.Columns.Add("MaxSpeed", GetType(Integer))
			table.Columns.Add("Acceleration", GetType(String))
			table.Columns.Add("HorsePower", GetType(String))
			table.Columns.Add("Price", GetType(Double))
			table.Columns.Add("CompanyName", GetType(String))

			table.Rows.Add(1, Me.GetImageFromResource("SSC Ultimate Aero.png"), "SSC Ultimate Aero", 257, 2.7f, "1,183", 654400, "America’s Shelby Supercars")
			table.Rows.Add(2, Me.GetImageFromResource("Bugatti Veyron.png"), "Bugatti Veyron", 253, 2.5f, "1,001", 1148600, "Bugatti Automobiles SAS")
			table.Rows.Add(3, Me.GetImageFromResource("Koenigsegg CCX.png"), "Koenigsegg CCX", 250, 3.2f, 806, 695000, "Koenigsegg")
			table.Rows.Add(4, Me.GetImageFromResource("Saleen S7 Twin-Turbo.png"), "Saleen S7 Twin-Turbo", 248, 3.2f, 750, 555000, "Saleen, Hidden Creek Industries")
			table.Rows.Add(5, Me.GetImageFromResource("McLaren F1.png"), "McLaren F1", 240, 3.2f, 627, 970000, "McLaren Automotive")
			table.Rows.Add(6, Me.GetImageFromResource("Ferrari Enzo.png"), "Ferrari Enzo", 217, 3.4f, 660, 670000, "Ferrari")
			table.Rows.Add(7, Me.GetImageFromResource("Jaguar XJ220.png"), "Jaguar XJ220", 217, 4.0f, 542, 345000, "Jaguar")
			table.Rows.Add(8, Me.GetImageFromResource("Pagani Zonda F.png"), "Pagani Zonda F", 215, 3.5f, 650, 741000, "Pagani")
			table.Rows.Add(9, Me.GetImageFromResource("Lamborghini Murcielago LP640.png"), "Lamborghini Murcielago LP640", 213, 3.3f, 640, 430000, "Lamborghini")
			table.Rows.Add(10, Me.GetImageFromResource("Porsche Carrera GT.png"), "Porsche Carrera GT", 209, 3.9f, 612, 440000, "Porsche AG")

			Return table
		End Function

		Private Function GetImageFromResource(ByVal imageFileName As String) As Image
			Dim img As Image
			Dim imageStream As Stream

			If executingAssembly Is Nothing Then
				Me.executingAssembly = System.Reflection.Assembly.GetExecutingAssembly()
			End If

            imageStream = Me.executingAssembly.GetManifestResourceStream(imageFileName)
			img = Bitmap.FromStream(imageStream)

			If img Is Nothing Then
				imageStream = Me.executingAssembly.GetManifestResourceStream(String.Format(imageFileName))
				img = Bitmap.FromStream(imageStream)
			End If

			Return img
		End Function

		Private Sub ShowScreenTipForCell(ByVal cell As GridDataCellElement)
			Dim row As DataRowView = CType(cell.RowInfo.DataBoundItem, DataRowView)

			Dim screenTip As New RadOffice2007ScreenTipElement()
			screenTip.CaptionLabel.Margin = New Padding(3)

			Dim carImage As Image = CType(row("CarPicture"), Image)
			screenTip.MainTextLabel.Image = carImage
			screenTip.MainTextLabel.ImageAlignment = ContentAlignment.MiddleCenter
			'screenTip.MainTextLabel.Margin = new Padding(1, 0, 1, 0);
			'screenTip.MainTextLabel.Padding = new Padding(0, 0, 0, 3);

			Dim text As String = String.Format("<html><b>MaxSpeed:</b> {0}mph<br><b>Acceleration 0-62mph:</b> {1}sec<br><b>Horse Power:</b> {2} bhp", row("MaxSpeed"), row("Acceleration"), row("HorsePower"))
			screenTip.CaptionLabel.Text = text

			screenTip.MainTextLabel.Text = String.Empty
			screenTip.EnableCustomSize = False

			cell.ScreenTip = screenTip
		End Sub

		#Region "Event handling"

		Private Sub radGridView1_ScreenTipNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ScreenTipNeededEventArgs)
			Dim cell As GridDataCellElement = TryCast(e.Item, GridDataCellElement)

			If cell IsNot Nothing Then
				Me.ShowScreenTipForCell(cell)
			End If
		End Sub

		Private Sub OnRadGridViewDemo_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement.RowElement.RowInfo Is GridViewTableHeaderRowInfo Then
				If e.CellElement.ColumnIndex = 0 Then
					e.CellElement.ToolTipText = "This is a picture column"
				ElseIf e.CellElement.ColumnIndex = 1 Then
					e.CellElement.ToolTipText = "This is a text column"
				ElseIf e.CellElement.ColumnIndex = 2 Then
					e.CellElement.ToolTipText = "This is a text column"
				ElseIf e.CellElement.ColumnIndex = 3 Then
					e.CellElement.ToolTipText = "This is a decimal column"
				ElseIf e.CellElement.ColumnIndex = 4 Then
					e.CellElement.ToolTipText = "This is a decimal column"
				End If
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.ViewCellFormatting, AddressOf OnRadGridViewDemo_ViewCellFormatting
		End Sub
	End Class
End Namespace
