Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.StripView.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private strip As RadPageViewStripElement
		Private imageIndex As Integer

		#End Region

		#Region "Constructor/Initialization"

		Public Sub New()
			InitializeComponent()

			Me.strip = TryCast(Me.radPageView1.ViewElement, RadPageViewStripElement)
			Me.strip.ItemDragMode = PageViewItemDragMode.Preview

			ExamplesForm.FillComboFromEnum(Me.stripAlignCombo, GetType(StripViewAlignment), Me.strip.StripAlignment)
			ExamplesForm.FillComboFromEnum(Me.itemAlignCombo, GetType(StripViewItemAlignment), Me.strip.ItemAlignment)
			ExamplesForm.FillComboFromEnum(Me.fitModeCombo, GetType(StripViewItemFitMode), Me.strip.ItemFitMode)
			ExamplesForm.FillComboFromEnum(Me.sizeModeCombo, GetType(PageViewItemSizeMode), Me.strip.ItemSizeMode)
			ExamplesForm.FillComboFromEnum(Me.orientationCombo, GetType(PageViewContentOrientation), Me.strip.ItemContentOrientation)
			ExamplesForm.FillComboFromEnum(Me.multiLineFitCombo, GetType(MultiLineItemFitMode), Me.strip.MultiLineItemFitMode)

			Me.spacingSpin.Value = Me.strip.ItemSpacing

			For Each page As RadPageViewPage In Me.radPageView1.Pages
				page.Image = PageViewImages.Images(Me.imageIndex)
				Me.imageIndex += 1
                page.Controls.Add(PageViewLabels.CreateLabel(Me.radPageView1.RootElement.DpiScaleFactor))
			Next page

			AddHandler Me.radPageView1.NewPageRequested, AddressOf radPageView1_NewPageRequested
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radPageView1.Location = Point.Empty

			MyBase.OnLoad(e)
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub radPageView1_NewPageRequested(ByVal sender As Object, ByVal e As EventArgs)
			Me.addPageButton_Click(Nothing, EventArgs.Empty)
		End Sub

		Private Sub stripAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.stripAlignCombo.SelectedItem, RadListDataItem)
			Me.strip.StripAlignment = CType(item.Value, StripViewAlignment)
		End Sub

		Private Sub itemAlignCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.itemAlignCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemAlignment = CType(item.Value, StripViewItemAlignment)
		End Sub

		Private Sub fitModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.fitModeCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemFitMode = CType(item.Value, StripViewItemFitMode)
			If Me.strip.ItemFitMode <> StripViewItemFitMode.MultiLine Then
				Me.multiLineFitCombo.Enabled = False
			Else
				Me.multiLineFitCombo.Enabled = True
			End If
		End Sub

		Private Sub sizeModeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.sizeModeCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemSizeMode = CType(item.Value, PageViewItemSizeMode)
		End Sub

		Private Sub orientationCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.orientationCombo.SelectedItem, RadListDataItem)
			Me.strip.ItemContentOrientation = CType(item.Value, PageViewContentOrientation)
		End Sub

		Private Sub multiLineFitCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim item As RadListDataItem = TryCast(Me.multiLineFitCombo.SelectedItem, RadListDataItem)
			Me.strip.MultiLineItemFitMode = CType(item.Value, MultiLineItemFitMode)
		End Sub

		Private Sub spacingSpin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			strip.ItemSpacing = CInt(Fix(Me.spacingSpin.Value))
		End Sub

		Private Sub addPageButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim page As New RadPageViewPage()
			page.Text = "Page " & (strip.Items.Count + 1)

			If Me.imageIndex = PageViewImages.Images.Length Then
				Me.imageIndex = 0
			End If

			page.Image = PageViewImages.Images(Me.imageIndex)
            Me.imageIndex += 1
            page.Controls.Add(PageViewLabels.CreateLabel(Me.radPageView1.RootElement.DpiScaleFactor))

			Me.radPageView1.Pages.Add(page)
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler stripAlignCombo.SelectedIndexChanged, AddressOf stripAlignCombo_SelectedIndexChanged
			AddHandler itemAlignCombo.SelectedIndexChanged, AddressOf itemAlignCombo_SelectedIndexChanged
			AddHandler fitModeCombo.SelectedIndexChanged, AddressOf fitModeCombo_SelectedIndexChanged
			AddHandler sizeModeCombo.SelectedIndexChanged, AddressOf sizeModeCombo_SelectedIndexChanged
			AddHandler orientationCombo.SelectedIndexChanged, AddressOf orientationCombo_SelectedIndexChanged
			AddHandler multiLineFitCombo.SelectedIndexChanged, AddressOf multiLineFitCombo_SelectedIndexChanged
			AddHandler spacingSpin.ValueChanged, AddressOf spacingSpin_ValueChanged
			AddHandler addPageButton.Click, AddressOf addPageButton_Click
		End Sub
	End Class
End Namespace
