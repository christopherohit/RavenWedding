Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RibbonBar.ResizingDemo
	Partial Public Class Form1
		Inherits RadRibbonForm
		Implements ISupportThemeName
		Private recentDocsList As New List(Of String)() From {"<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly report.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work status.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Document101.rtf<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>"}

		Private recentPlacesList As New List(Of String)() From {"<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Work Items<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>References<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Details<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Results<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Documents<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Monthly reports<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Descriptions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Definitions<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Taxing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Accounting<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>Marketing<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>", "<html>New Folder(2)<br><span style=""color:#5e5e5e"">C:\Documents and Settings\Telerik\My Documents</span>"}

		Public Sub New()
			InitializeComponent()

			Me.radLabel23.Text = "What's new in " & VersionNumber.MarketingVersion

			AddHandler recentDocumentsListControl.VisualItemFormatting, AddressOf recentDocumentsListControl_VisualItemFormatting
			AddHandler recentDocumentsListControl.CreatingVisualListItem, AddressOf recentDocumentsListControl_CreatingVisualListItem
			recentDocumentsListControl.DataSource = recentDocsList

			AddHandler recentPlacesListControl.VisualItemFormatting, AddressOf recentPlacesListControl_VisualItemFormatting
			AddHandler recentPlacesListControl.CreatingVisualListItem, AddressOf recentPlacesListControl_CreatingVisualListItem
			recentPlacesListControl.DataSource = recentPlacesList

			Me.AllowAero = False

			Me.radRibbonBar1.StartButtonImage = ResFinder.MenuIcon
			Me.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radRibbonBar1.RibbonBarElement.TabStripElement.Items(0)
			Me.radRibbonBar1.QuickAccessToolBar.InnerItem.ContentLayout.Margin = New Padding(2, 0, 2, 0)

			Me.MinimumSize = New Size(210, 140)
			Me.DoubleBuffered = True

			WireEvents()
		End Sub

		Private Sub WireEvents()
			AddHandler radRibbonBarBackstageView1.ItemClicked, AddressOf radRibbonBarBackstageView1_ItemClicked
			AddHandler doubleBufferedFlowLayoutPanel2.Paint, AddressOf flowLayoutPanel2_Paint
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.ApplyGalleryStyle()

		End Sub

		Private Sub ApplyGalleryStyle()
			For Each item As RadGalleryItem In Me.radGalleryElement1.Items
				Dim childrenCount As Integer = item.Children.Count

				If childrenCount > 0 Then
					Dim element As RadElement = item.Children(0)

					If TypeOf element Is FillPrimitive Then
						Dim fillPrimitive As FillPrimitive = TryCast(element, FillPrimitive)
						fillPrimitive.BackColor = Color.White
					End If
				End If
			Next item
		End Sub

		Private Sub recentPlacesListControl_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New PinnedListVisualItem()
		End Sub

		Private Sub recentPlacesListControl_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			args.VisualItem.Image = My.Resources.open32
		End Sub

		Private Sub recentDocumentsListControl_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			args.VisualItem.Image = My.Resources.plain_text
		End Sub

		Private Sub recentDocumentsListControl_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New PinnedListVisualItem()
		End Sub

		Private Sub flowLayoutPanel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, doubleBufferedFlowLayoutPanel2.Width - 1, doubleBufferedFlowLayoutPanel2.Height - 1)

			MyBase.OnPaint(e)
		End Sub

		Private Sub radRibbonBarBackstageView1_ItemClicked(ByVal sender As Object, ByVal e As BackstageItemEventArgs)
			If TypeOf e.Item Is BackstageButtonItem Then
				Me.radRibbonBarBackstageView1.HidePopup()
			End If
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class

	Public Class PinnedListVisualItem
		Inherits RadListVisualItem
		Private pinImage As RadButtonElement

		Public Sub New()
			AdjustVisibility()
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			pinImage = New RadButtonElement()
			pinImage.Image = My.Resources.pin
			pinImage.Alignment = ContentAlignment.MiddleCenter
			pinImage.ImageAlignment = ContentAlignment.MiddleCenter
			pinImage.BorderElement.Visibility = ElementVisibility.Hidden
			pinImage.ButtonFillElement.Visibility = ElementVisibility.Hidden
			AddHandler pinImage.RadPropertyChanged, AddressOf pinImage_RadPropertyChanged
			Me.Children.Add(pinImage)
		End Sub

		Private Sub pinImage_RadPropertyChanged(ByVal sender As Object, ByVal e As RadPropertyChangedEventArgs)
            If e.Property Is ContainsMouseProperty Then
                AdjustVisibility()
            End If
        End Sub

		Private Sub AdjustVisibility()
			If pinImage.ContainsMouse Then
				pinImage.BorderElement.Visibility = ElementVisibility.Visible
				pinImage.ButtonFillElement.Visibility = ElementVisibility.Visible
			Else
				pinImage.BorderElement.Visibility = ElementVisibility.Hidden
				pinImage.ButtonFillElement.Visibility = ElementVisibility.Hidden
			End If
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			pinImage.Measure(availableSize)
			Return MyBase.MeasureOverride(availableSize)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			finalSize.Width -= 36
			MyBase.ArrangeOverride(finalSize)
			finalSize.Width += 36
			pinImage.Arrange(New RectangleF(finalSize.Width - 36, 0, 36, 36))

			Return finalSize
		End Function

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadListVisualItem)
			End Get
		End Property
	End Class
End Namespace