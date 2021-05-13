Imports System.Text
Imports Telerik.WinControls.UI
Imports CS.RSS_Library
Imports System.Text.RegularExpressions

Namespace CS
	Public Class RssItemElement
		Inherits RadListVisualItem

		#Region "Fields"

		Private imageElement As LightVisualElement
'INSTANT VB NOTE: The variable headerElement was renamed since Visual Basic does not allow class members with the same name:
		Private headerElement_Renamed As LightVisualElement
		Private descriptionElement As LightVisualElement
		Private pubDateElement As LightVisualElement
		Private stackElement As StackLayoutElement
'INSTANT VB NOTE: The variable supportedRssFeed was renamed since Visual Basic does not allow class members with the same name:
		Private supportedRssFeed_Renamed As Boolean = True
		Private isRead As Boolean = False

		#End Region

		#Region "Overrides"

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.ClipDrawing = True
		End Sub

		Protected Overrides Sub CreateChildElements()
			imageElement = New LightVisualElement()
			imageElement.StretchHorizontally = False
			imageElement.StretchVertically = True
			imageElement.ImageLayout = ImageLayout.Zoom
			imageElement.Margin = New Padding(0,1,0,1)
			imageElement.NotifyParentOnMouseInput = True
			Me.Children.Add(imageElement)

			stackElement = New StackLayoutElement()
			stackElement.StretchVertically = True
			stackElement.FitInAvailableSize = True
			stackElement.Orientation = Orientation.Vertical
			stackElement.StretchVertically = True
			stackElement.NotifyParentOnMouseInput = True
			Me.Children.Add(stackElement)

			headerElement_Renamed = New LightVisualElement()
			headerElement_Renamed.StretchVertically = False
			headerElement_Renamed.TextAlignment = ContentAlignment.MiddleLeft
			headerElement_Renamed.Font = New Font("Segoe UI", 9.25f, FontStyle.Bold)
			headerElement_Renamed.TextWrap = True
			headerElement_Renamed.NotifyParentOnMouseInput = True
			stackElement.Children.Add(headerElement_Renamed)

			descriptionElement = New LightVisualElement()
			descriptionElement.StretchVertically = False
			descriptionElement.Font = New Font("Segoe UI", 9.25f)
			descriptionElement.TextAlignment = ContentAlignment.MiddleLeft
			descriptionElement.TextWrap = True
			descriptionElement.NotifyParentOnMouseInput = True
			descriptionElement.AutoEllipsis = True
			stackElement.Children.Add(descriptionElement)

			pubDateElement = New LightVisualElement()
			pubDateElement.Font = New Font("Segoe UI", 9.25f)
			pubDateElement.NotifyParentOnMouseInput = True
			pubDateElement.StretchVertically = False
			pubDateElement.TextAlignment = ContentAlignment.MiddleLeft
			stackElement.Children.Add(pubDateElement)
		End Sub

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim originalAvailableSize As SizeF = availableSize
			Dim desiredSize As SizeF = SizeF.Empty

			Dim borderThickness As Padding = Me.GetBorderThickness(False)
			availableSize.Width -= borderThickness.Horizontal + Me.Padding.Horizontal
			availableSize.Height -= borderThickness.Vertical + Me.Padding.Vertical

			imageElement.Measure(availableSize)
			availableSize.Width -= imageElement.DesiredSize.Width

			stackElement.Measure(availableSize)

			desiredSize.Width = imageElement.DesiredSize.Width + stackElement.DesiredSize.Width
			desiredSize.Height = Math.Max(imageElement.DesiredSize.Height, stackElement.DesiredSize.Height)

			desiredSize.Width += borderThickness.Horizontal + Me.Padding.Horizontal
			desiredSize.Height += borderThickness.Vertical + Me.Padding.Vertical

			desiredSize.Width = Math.Min(desiredSize.Width, originalAvailableSize.Width)
			desiredSize.Height = Math.Min(desiredSize.Height, originalAvailableSize.Height)

			Return desiredSize
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim clientRect As RectangleF = GetClientRectangle(finalSize)
			Dim x As Single = clientRect.X

			imageElement.Arrange(New RectangleF(x, clientRect.Y, imageElement.DesiredSize.Width, imageElement.DesiredSize.Height))
			x += imageElement.DesiredSize.Width
			stackElement.Arrange(New RectangleF(x, clientRect.Y, stackElement.DesiredSize.Width, stackElement.DesiredSize.Height))

			Return finalSize
		End Function

		Public Overrides Sub Synchronize()
			MyBase.Synchronize()

			Dim item As RssItem = CType(Me.Data.DataBoundItem, RssItem)
			Me.imageElement.Image = item.GetImage()
			Me.headerElement_Renamed.Text = item.Title

			Dim pubdate As Date
			Date.TryParse(item.PubDate, pubdate)
            If pubdate <> Date.MinValue Then
                Me.pubDateElement.Text = pubdate.ToShortDateString()
            Else
                Me.pubDateElement.Text = String.Format("{0:g}", item.PubDate)
            End If


			If item.Description IsNot Nothing Then
				Me.descriptionElement.Text = Regex.Replace(item.Description, "<[^>]*>", "")
				Me.descriptionElement.Text = Me.descriptionElement.Text.Replace("&#160;", "")
				Me.descriptionElement.Text = Me.descriptionElement.Text.Replace("&nbsp;", "")
			Else
				supportedRssFeed_Renamed = False
			End If

			'TODO
			'Regex reg = new Regex("<.*?[^>]+>", RegexOptions.Multiline);
			'string text = reg.Replace(HTMLText, "");
			'text = text.Replace("&nbsp;", "");
		End Sub

		Public Overrides Sub Attach(ByVal data As RadListDataItem, ByVal context As Object)
			'occurs when attached to the data source
			MyBase.Attach(data, context)

			Dim item As RssItem = CType(Me.Data.DataBoundItem, RssItem)
			AddHandler item.ImageDownloaded, AddressOf item_ImageDownloaded
		End Sub

		Public Overrides Sub Detach()
			Dim item As RssItem = CType(Me.Data.DataBoundItem, RssItem)
			RemoveHandler item.ImageDownloaded, AddressOf item_ImageDownloaded
			MyBase.Detach()
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadListVisualItem)
			End Get
		End Property

		#End Region

		#Region "Methods"

		Private Sub item_ImageDownloaded(ByVal sender As Object, ByVal e As EventArgs)
			'when the image is downloaded, synchromize the content
			Synchronize()
			Dim item As RssItem = TryCast(sender, RssItem)
			RemoveHandler item.ImageDownloaded, AddressOf item_ImageDownloaded
		End Sub

		#End Region

		#Region "Properties"

		Public ReadOnly Property SupportedRssFeed() As Boolean
			Get
				Return Me.supportedRssFeed_Renamed
			End Get
		End Property

		Public ReadOnly Property HeaderElement() As LightVisualElement
			Get
				Return Me.headerElement_Renamed
			End Get
		End Property

		#End Region

	End Class
End Namespace
