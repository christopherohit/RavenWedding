Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Charting
Imports Telerik.Charting.Styles

Namespace Telerik.Examples.WinControls.PageView.StripView.StripButtons
	''' <summary>
	''' Example beautifying 
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private strip As RadPageViewStripElement
		Private Shared ChartSkins() As String = { "Default", "Blue", "Brick", "Classic", "Colorful", "ExcelClassic", "Gradient", "Green", "Pastel", "Web", "Office2007", "BabyBlue", "BlueStripes", "DeepBlue", "DeepGreen", "DeepGray", "DeepRed", "GreenStripes", "GrayStripes", "LightBlue", "LightBrown", "LightGreen", "UltraGreen", "Vista", "Black", "Default2006", "Mac", "Inox", "Outlook", "Web20", "Telerik", "WebBlue", "Desert", "Hay", "Marble", "Metal", "Wood", "Sunset", "Gray", "SkyBlue", "Forest" }


		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler Me.radPageView1.PageRemoved, AddressOf radPageView1_PageRemoved
			AddHandler Me.radPageView1.SelectedPageChanged, AddressOf radPageView1_SelectedPageChanged

			Me.strip = TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement)
			Me.strip.StripButtons = StripViewButtons.All
			Me.animatedScrollingCheck.Checked = Me.strip.AnimatedStripScrolling

			Me.PopulatePages()
			Me.PopulateDropDownLists()
		End Sub

		Private Sub PopulateDropDownLists()
			Dim buttons As New List(Of StripViewButtons)()
			For Each button As StripViewButtons In System.Enum.GetValues(GetType(StripViewButtons))
				buttons.Add(button)
			Next button
			Me.stripButtonsCombo.DataSource = buttons
			Me.stripButtonsCombo.SelectedValue = Me.strip.StripButtons

			Me.selectedPageCombo.DisplayMember = "Text"
			Me.selectedPageCombo.DataSource = Me.radPageView1.Pages
			Me.selectedPageCombo.SelectedValue = Me.radPageView1.SelectedPage
		End Sub

		Private Sub PopulatePages()
			Dim skinIndex As Integer = 0
			For Each seriesType As ChartSeriesType In System.Enum.GetValues(GetType(ChartSeriesType))
				Dim page As New RadPageViewPage()
				page.Text = seriesType.ToString()

				Dim chart As New RadChart()
				chart.DefaultType = seriesType
				chart.Dock = DockStyle.Fill
				chart.Skin = ChartSkins(skinIndex)
				skinIndex += 1
				chart.SkinsOverrideStyles = True

				Dim series As New Telerik.Charting.ChartSeries("StripMode")
				series.AddItem(10, series.Name)
				chart.Series.Add(series)

				series = New Telerik.Charting.ChartSeries("StackMode")
				series.AddItem(20, series.Name)
				chart.Series.Add(series)

				series = New Telerik.Charting.ChartSeries("OutlookMode")
				series.AddItem(30, series.Name)
				chart.Series.Add(series)

				page.Controls.Add(chart)
				Me.radPageView1.Pages.Add(page)
			Next seriesType
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub radPageView1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.selectedPageCombo.SelectedValue = Me.radPageView1.SelectedPage
		End Sub

		Private Sub radPageView1_PageRemoved(ByVal sender As Object, ByVal e As RadPageViewEventArgs)
			Me.selectedPageCombo.DataSource = Nothing
			Me.selectedPageCombo.DataSource = Me.radPageView1.Pages
			Me.selectedPageCombo.DisplayMember = "Text"
			Me.selectedPageCombo.SelectedValue = Me.radPageView1.SelectedPage
		End Sub

		Private Sub animatedScrollingCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.strip.AnimatedStripScrolling = Me.animatedScrollingCheck.Checked
		End Sub

		Private Sub stripButtonsCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.stripButtonsCombo.SelectedValue IsNot Nothing Then
				Me.strip.StripButtons = CType(Me.stripButtonsCombo.SelectedValue, StripViewButtons)
			End If
		End Sub

		Private Sub selectedPageCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.selectedPageCombo.SelectedValue IsNot Nothing Then
				Me.radPageView1.SelectedPage = CType(Me.selectedPageCombo.SelectedValue, RadPageViewPage)
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler animatedScrollingCheck.ToggleStateChanged, AddressOf animatedScrollingCheck_ToggleStateChanged
			AddHandler stripButtonsCombo.SelectedIndexChanged, AddressOf stripButtonsCombo_SelectedIndexChanged
			AddHandler selectedPageCombo.SelectedIndexChanged, AddressOf selectedPageCombo_SelectedIndexChanged
		End Sub
	End Class
End Namespace
