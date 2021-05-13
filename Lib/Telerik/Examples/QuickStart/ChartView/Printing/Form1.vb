Imports System.Drawing.Imaging
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.Printing
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private radChartView1 As RadChartView
		Private radPrintDocument1 As RadPrintDocument

		Public Sub New()
			Me.radChartView1 = New RadChartView()
			Me.radChartView1.Dock = DockStyle.Fill

			Me.radPrintDocument1 = New RadPrintDocument()
			Me.radPrintDocument1.Landscape = True
			Me.radPrintDocument1.AssociatedObject = Me.radChartView1

			Me.Controls.Add(Me.radChartView1)

			InitializeComponent()


		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.LoadData()

			Me.radChartView1.ShowLegend = True
			Me.radChartView1.ChartElement.LegendElement.LegendTitle = "Expenses"
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Title = "Personal monthly expenses"

			Dim formats As New List(Of ImageFormat)() From {ImageFormat.Bmp, ImageFormat.Gif, ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Tiff}

			Me.radDropDownList1.DataSource = formats
			Me.radDropDownList1.SelectedValue = ImageFormat.Png

			Me.radSpinEditorWidth.Value = Me.radChartView1.Size.Width
			Me.radSpinEditorHeight.Value = Me.radChartView1.Size.Height
		End Sub

		Private Sub LoadData()
			Dim lineSeries As LineSeries
			Dim model As New LineSeriesDataModel()

			For i As Integer = 0 To 10
				lineSeries = New LineSeries()
				lineSeries.CategoryMember = "Month"
				lineSeries.ValueMember = "Expense"
				lineSeries.LegendTitle = model.GetLegendText(i)
				lineSeries.DataSource = model.GetData(i)
				lineSeries.PointSize = New SizeF(3f, 3f)

				Me.radChartView1.Series.Add(lineSeries)
			Next i
		End Sub

		Private Sub buttonPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radChartView1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radChartView1.PrintPreview(Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As Form = Me.radChartView1.GetSettingsDialog(Me.radPrintDocument1)

			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radChartView1.PrintPreview(Me.radPrintDocument1)
			End If
		End Sub

		Private Sub radButtonExport_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New SaveFileDialog()
			dialog.Filter = String.Format("Image (*.{0};)|*.{0}", Me.radDropDownList1.Text.ToLower())

			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radChartView1.ExportToImage(dialog.FileName, New Size(CInt(Fix(Me.radSpinEditorWidth.Value)), CInt(Fix(Me.radSpinEditorHeight.Value))), TryCast(Me.radDropDownList1.SelectedValue, ImageFormat))

				RadMessageBox.Instance.ThemeName = Me.CurrentThemeName

				If RadMessageBox.Show("Export complete. Would you like to open the file?", "Export complete", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
					Process.Start(dialog.FileName)
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.buttonPrint.Click, AddressOf buttonPrint_Click
			AddHandler Me.buttonPrintPreview.Click, AddressOf buttonPrintPreview_Click
			AddHandler Me.buttonPrintSettings.Click, AddressOf buttonPrintSettings_Click
			AddHandler Me.radButtonExport.Click, AddressOf radButtonExport_Click
		End Sub
	End Class
End Namespace
