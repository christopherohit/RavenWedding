Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PictureBoxExamples.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private pictureBoxes As IList(Of RadPictureBox)
        Private WithEvents overlayPanel As RadPanel
        Private previewPictureBox As RadPictureBox
        Private insertSvgs As IList(Of RadSvgImage)
        Private pageLayoutSvgs As IList(Of RadSvgImage)
        Private mailingSvgs As IList(Of RadSvgImage)

        Public Sub New()
            Me.InitializeComponent()
            Me.InitializeSvgs()
            Me.CenterPanel = True
            Me.InitializeOverlay()
            Me.radLabelApplicationAlbums.ForeColor = MainForm.AccentColor
            Me.SetupButton(Me.radButtonAddImage.ButtonElement, "", "Add Image")
            Me.SetupButton(Me.radButtonSaveImage.ButtonElement, "", "Save Image")
            Me.SetupButton(Me.radButtonDownloadImage.ButtonElement, "", "Download Image")
            Me.pictureBoxes = New List(Of RadPictureBox)()

            For i As Integer = 0 To 12 - 1
                Me.AddPictureBox()
            Next

            Me.radButtonAddAlbum.ButtonElement.ToolTipText = "Add New Album"
            Me.radButtonAddAlbum.SvgImage = RadSvgImage.FromByteArray(My.Resources.symbol_add_SVG)
            Me.radButtonAllAlbums.SvgImage = RadSvgImage.FromByteArray(My.Resources.pictures_SVG)
            Me.RadButtonAllAlbums_Click(Nothing, EventArgs.Empty)
        End Sub

        Private ReadOnly Property AllSvgs As IList(Of RadSvgImage)
            Get
                Dim allImages As List(Of RadSvgImage) = New List(Of RadSvgImage)()
                allImages.AddRange(Me.insertSvgs.Take(4))
                allImages.AddRange(Me.pageLayoutSvgs.Take(4))
                allImages.AddRange(Me.mailingSvgs.Take(4))
                Return allImages
            End Get
        End Property

        Private Sub InitializeSvgs()
            Me.insertSvgs = New List(Of RadSvgImage)()

            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InserthyperlinkModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.PictureModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.NewCommentModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.CodeBlockModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InsertTableModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.EditHeaderModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.EditFooterModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.PageBreakModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InsertBookmarkModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InsertDateTimeModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InsertPageNumberModern32Svg))
            Me.insertSvgs.Add(RadSvgImage.FromByteArray(My.Resources.SymbolModern32Svg))
            Me.pageLayoutSvgs = New List(Of RadSvgImage)()
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.WatermarkModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.PageSizeModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.PageMarginModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ColumnBreakModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ContinuousSectionBreakModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.LineBreakModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.NextPageSectionBreakModern32Svg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.OneModernSvg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.TwoModernSvg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ThreeModernSvg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.LeftModernSvg))
            Me.pageLayoutSvgs.Add(RadSvgImage.FromByteArray(My.Resources.RightModernSvg))
            Me.mailingSvgs = New List(Of RadSvgImage)()
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.MailMergeModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.InsertMergeFieldModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.HighlightMergeFieldsModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ShowAllFieldsCodesModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ShowAllFieldsDisplayNamesModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.ShowAllFieldsResultsModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.FirstModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.PreviousModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.NextModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.LastModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.AcceptChangeModern32Svg))
            Me.mailingSvgs.Add(RadSvgImage.FromByteArray(My.Resources.RejectChangeModern32Svg))
        End Sub

        Private Sub InitializeOverlay()
            Me.overlayPanel = New RadPanel()
            Me.overlayPanel.RootElement.EnableElementShadow = False
            Me.overlayPanel.Parent = Me.radPanelDemoHolder
            Me.overlayPanel.BringToFront()
            Me.overlayPanel.Dock = DockStyle.Fill
            Me.overlayPanel.BackColor = Color.FromArgb(197, 197, 197)
            Me.overlayPanel.PanelElement.ToolTipText = "Close image"
            Dim closeButton As RadButton = New RadButton()
            Me.SetupButton(closeButton.ButtonElement, "", "Close image")
            closeButton.Padding = New Padding(0, 2, 0, 0)
            closeButton.Size = New Size(24, 24)
            closeButton.Parent = Me.overlayPanel
            closeButton.Location = New Point(Me.overlayPanel.Width - closeButton.Width - 5, 5)
            AddHandler closeButton.Click, AddressOf CloseButton_Click
            Me.previewPictureBox = New RadPictureBox()
            Me.previewPictureBox.ShowBackground = True
            Me.previewPictureBox.ShowBorder = True
            Me.previewPictureBox.Parent = Me.overlayPanel
            Me.previewPictureBox.Location = New Point(30, 30)
            Me.previewPictureBox.Width = Me.overlayPanel.Width - 60
            Me.previewPictureBox.Height = Me.overlayPanel.Height + Me.doubleBufferedTableLayoutPanel1.Height - 60
            Me.HideOverlay()
        End Sub

        Private Sub CloseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles overlayPanel.Click
            Me.HideOverlay()
        End Sub

        Private Sub ShowOverlay(ByVal clickedPictureBox As RadPictureBox)
            Me.previewPictureBox.Image = clickedPictureBox.Image
            Me.previewPictureBox.SvgImage = clickedPictureBox.SvgImage
            Me.previewPictureBox.Tag = clickedPictureBox
            Me.doubleBufferedTableLayoutPanel1.Hide()
            Me.overlayPanel.Show()
        End Sub

        Private Sub HideOverlay()
            Me.overlayPanel.Hide()
            Me.doubleBufferedTableLayoutPanel1.Show()
            Dim clickedPictureBox As RadPictureBox = CType(Me.previewPictureBox.Tag, RadPictureBox)

            If clickedPictureBox IsNot Nothing Then
                clickedPictureBox.Image = Me.previewPictureBox.Image
                clickedPictureBox.SvgImage = Me.previewPictureBox.SvgImage
                clickedPictureBox.ZoomProperties.ZoomFactor = 2
                clickedPictureBox.CallOnMouseLeave(EventArgs.Empty)
            End If

            Me.previewPictureBox.Image = Nothing
            Me.previewPictureBox.SvgImage = Nothing
        End Sub

        Private Sub SetupButton(ByVal button As RadButtonElement, ByVal glyph As String, ByVal tooltipText As String)
            button.TextElement.CustomFont = "TelerikWebUI"
            button.Text = glyph
            button.ToolTipText = tooltipText
        End Sub

        Private Function AddPictureBox() As RadPictureBox
            Dim pictureBox As RadPictureBox = New RadPictureBox()
            Dim shareButton As RadButtonElement = New RadButtonElement()
            Me.SetupButton(shareButton, "", "Share Image")
            shareButton.Padding = New Padding(1)
            AddHandler shareButton.Click, AddressOf Me.ShareButton_Click
            shareButton.EnableElementShadow = False
            pictureBox.TopPanel.RightItems.Add(shareButton)
            Dim deleteButton As RadButtonElement = New RadButtonElement()
            Me.SetupButton(deleteButton, "", "Delete Image")
            deleteButton.Padding = New Padding(1)
            AddHandler deleteButton.Click, AddressOf Me.RemoveButton_Click
            deleteButton.EnableElementShadow = False
            pictureBox.TopPanel.RightItems.Add(deleteButton)
            pictureBox.TopPanel.DrawFill = False
            pictureBox.TopPanel.DrawBorder = False
            pictureBox.TopPanel.RightElementsStack.Padding = New Padding(1)
            pictureBox.TopPanel.RightElementsStack.DrawFill = True
            pictureBox.TopPanel.RightElementsStack.BackColor = Color.FromArgb(100, Color.Black)
            pictureBox.Cursor = Cursors.Hand
            pictureBox.PictureBoxElement.ToolTipText = "Open image"
            pictureBox.ContextMenuEnabled = False
            pictureBox.ZoomProperties.AllowZoom = False
            pictureBox.ImageLayout = RadImageLayout.FitIntoBounds
            pictureBox.Size = New Size(150, 100)
            pictureBox.Margin = New Padding(10)
            pictureBox.Parent = Me.doubleBufferedFlowLayoutPanel1
            pictureBox.ThemeName = Me.CurrentThemeName
            pictureBox.ShowBorder = True
            pictureBox.ShowBackground = True
            AddHandler pictureBox.Click, AddressOf Me.PictureBox_Click
            Me.pictureBoxes.Add(pictureBox)
            pictureBox.SvgImage = Me.pictureBoxes(0).SvgImage
            pictureBox.ZoomProperties.ZoomFactor = 2
            Me.radScrollablePanel1.VerticalScrollbar.Value = Me.radScrollablePanel1.VerticalScrollbar.Maximum
            Return pictureBox
        End Function

        Private Sub PictureBox_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim clickedPictureBox As RadPictureBox = CType(sender, RadPictureBox)
            Dim clientPoint As Point = clickedPictureBox.PointToClient(Control.MousePosition)
            Dim itemUnderMouse As RadButtonElement = clickedPictureBox.ElementTree.GetElementAtPoint(Of RadButtonElement)(clientPoint)

            If itemUnderMouse IsNot Nothing Then
                Return
            End If

            Me.ShowOverlay(clickedPictureBox)
        End Sub

        Private Sub RemoveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim page As RadTaskDialogPage = New RadTaskDialogPage()
            page.Icon = RadTaskDialogIcon.ShieldWarningYellowBar
            page.Caption = "Delete Image Warning"
            page.Heading = "Are you sure you want to delete the image?"
            page.Text = "Deleting the image will remove it from this album and you will no longer be able to restore it!"
            page.AllowCancel = True
            page.CommandAreaButtons.Add(RadTaskDialogButton.Yes)
            Dim noButton As RadTaskDialogButton = RadTaskDialogButton.No
            page.CommandAreaButtons.Add(noButton)
            page.DefaultButton = noButton
            RadTaskDialog.CurrentForm.ThemeName = Me.CurrentThemeName
            Dim clickedButton As RadTaskDialogButton = RadTaskDialog.ShowDialog(Me, page)

            If clickedButton Is Nothing OrElse clickedButton <> RadTaskDialogButton.Yes Then
                Return
            End If

            Dim removeButton As RadButtonElement = TryCast(sender, RadButtonElement)
            Dim pictureBox As RadPictureBox = TryCast(removeButton.ElementTree.Control, RadPictureBox)

            If Me.insertSvgs.Contains(pictureBox.SvgImage) Then
                Me.insertSvgs.Remove(pictureBox.SvgImage)
            ElseIf Me.pageLayoutSvgs.Contains(pictureBox.SvgImage) Then
                Me.pageLayoutSvgs.Remove(pictureBox.SvgImage)
            ElseIf Me.mailingSvgs.Contains(pictureBox.SvgImage) Then
                Me.mailingSvgs.Remove(pictureBox.SvgImage)
            End If

            Me.pictureBoxes.Remove(pictureBox)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Remove(pictureBox)
        End Sub

        Private Sub UpdateImages(ByVal svgImages As IList(Of RadSvgImage))
            Dim maxIndex As Integer = Math.Min(svgImages.Count, Me.pictureBoxes.Count)

            For index As Integer = 0 To maxIndex - 1
                Dim pictureBox As RadPictureBox = Me.pictureBoxes(index)
                pictureBox.SvgImage = svgImages(index)
                pictureBox.ZoomProperties.ZoomFactor = 2
            Next
        End Sub

        Private Sub RadButtonAddAlbum_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radButtonNewAlbum.Show()
            Me.radButtonNewAlbum.PerformClick()
            Me.radButtonAddAlbum.Enabled = False
        End Sub

        Private Sub RadButtonAllAlbums_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radLabelSelectedAlbum.Text = "All"
            Me.UpdateImages(Me.AllSvgs)
        End Sub

        Private Sub RadButtonInsertAlbum_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radLabelSelectedAlbum.Text = "Insert"
            Me.UpdateImages(Me.insertSvgs)
        End Sub

        Private Sub RadButtonPageLayoutAlbum_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radLabelSelectedAlbum.Text = "Page Layout"
            Me.UpdateImages(Me.pageLayoutSvgs)
        End Sub

        Private Sub RadButtonMailingsAlbum_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radLabelSelectedAlbum.Text = "Mailings"
            Me.UpdateImages(Me.mailingSvgs)
        End Sub

        Private Sub RadButtonNewAlbum_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radLabelSelectedAlbum.Text = "New Album"
            Me.UpdateImages(Me.AllSvgs)
        End Sub

        Private Sub RadButtonAddImage_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddPictureBox()
        End Sub

        Private Sub RadButtonSaveImage_Click(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
            RadMessageBox.Show(Me, "Save button clicked.", "RadPictureBox")
        End Sub

        Private Sub RadButtonDownloadImage_Click(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
            RadMessageBox.Show(Me, "Download button clicked.", "RadPictureBox")
        End Sub

        Private Sub ShareButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
            RadMessageBox.Show(Me, "Share button clicked.", "RadPictureBox")
        End Sub
    End Class
End Namespace
