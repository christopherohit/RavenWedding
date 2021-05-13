Imports System
Imports System.Drawing
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PictureBoxExamples.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.radPictureBox1.Image = My.Resources.ballons_image
            Me.radPictureBox1.ImageLayout = RadImageLayout.Zoom
            FillComboFromEnum(Me.radDropDownListImageLayout, GetType(RadImageLayout), Me.radPictureBox1.ImageLayout)
            Me.radPictureBox1.ImageAlignment = ContentAlignment.TopCenter
            FillComboFromEnum(Me.radDropDownListImageAlignment, GetType(ContentAlignment), Me.radPictureBox1.ImageAlignment)
            FillComboFromEnum(Me.radDropDownListPanelDisplayMode, GetType(PictureBoxPanelDisplayMode), Me.radPictureBox1.PanelDisplayMode)
            FillComboFromEnum(Me.radDropDownListPanelOverflowMode, GetType(PictureBoxPanelOverflowMode), Me.radPictureBox1.PanelOverflowMode)
            Me.CreatePanelButton("Left Button", Me.radPictureBox1.TopPanel.LeftItems)
            Me.CreatePanelButton("Center Button", Me.radPictureBox1.TopPanel.CenterItems)
            Me.CreatePanelButton("Right Button", Me.radPictureBox1.TopPanel.RightItems)
            Me.CreatePanelButton("Top Button", Me.radPictureBox1.LeftPanel.TopItems)
            Me.CreatePanelButton("Center Button", Me.radPictureBox1.LeftPanel.CenterItems)
            Me.CreatePanelButton("Bottom Button", Me.radPictureBox1.LeftPanel.BottomItems)
        End Sub

        Private Sub CreatePanelButton(ByVal text As String, ByVal parent As RadItemOwnerCollection)
            Dim button As RadButtonElement = New RadButtonElement(text)
            button.Padding = New System.Windows.Forms.Padding(3)
            AddHandler button.Click, AddressOf Me.PanelButton_Click
            parent.Add(button)
        End Sub

        Private Sub PanelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim button As RadButtonElement = TryCast(sender, RadButtonElement)
            RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
            RadMessageBox.Show(button.Text & " clicked.")
        End Sub

        Private Sub RadButtonChooseImage_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radPictureBox1.LoadImage()
        End Sub

        Private Sub RadDropDownListImageLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radPictureBox1.ImageLayout = CType(Me.radDropDownListImageLayout.SelectedValue, RadImageLayout)
            Me.radDropDownListImageAlignment.Enabled = Me.radPictureBox1.ImageLayout = RadImageLayout.None
        End Sub

        Private Sub RadDropDownListImageAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radPictureBox1.ImageAlignment = CType(Me.radDropDownListImageAlignment.SelectedValue, ContentAlignment)
        End Sub

        Private Sub RadCheckBoxShowBorder_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radPictureBox1.ShowBorder = Me.radCheckBoxShowBorder.IsChecked
        End Sub

        Private Sub RadCheckBoxShowBackground_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radPictureBox1.ShowBackground = Me.radCheckBoxShowBackground.IsChecked
        End Sub

        Private Sub RadCheckBoxEnableContextMenu_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radPictureBox1.ContextMenuEnabled = Me.radCheckBoxEnableContextMenu.IsChecked
        End Sub

        Private Sub RadCheckBoxEnableZoom_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radPictureBox1.ZoomProperties.AllowZoom = Me.radCheckBoxEnableZoom.IsChecked
            Me.radSpinEditorMinZoomFactor.Enabled = Me.radPictureBox1.ZoomProperties.AllowZoom
            Me.radSpinEditorMaxZoomFactor.Enabled = Me.radPictureBox1.ZoomProperties.AllowZoom
        End Sub

        Private Sub RadSpinEditorMinZoomFactor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radPictureBox1.ZoomProperties.MinZoomFactor = CDbl(Me.radSpinEditorMinZoomFactor.Value)
        End Sub

        Private Sub RadSpinEditorMaxZoomFactor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radPictureBox1.ZoomProperties.MaxZoomFactor = CDbl(Me.radSpinEditorMaxZoomFactor.Value)
        End Sub

        Private Sub RadCheckBoxShowPanels_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.radCheckBoxShowPanels.IsChecked Then
                Me.radDropDownListPanelDisplayMode.SelectedValue = PictureBoxPanelDisplayMode.Always
            Else
                Me.radDropDownListPanelDisplayMode.SelectedValue = PictureBoxPanelDisplayMode.None
            End If

            Me.radDropDownListPanelDisplayMode.Enabled = Me.radCheckBoxShowPanels.IsChecked
        End Sub

        Private Sub RadDropDownListPanelDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radPictureBox1.PanelDisplayMode = CType(Me.radDropDownListPanelDisplayMode.SelectedValue, PictureBoxPanelDisplayMode)
            Me.radDropDownListPanelOverflowMode.Enabled = Me.radPictureBox1.PanelDisplayMode <> PictureBoxPanelDisplayMode.None
        End Sub

        Private Sub RadDropDownListPanelOverflowMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radPictureBox1.PanelOverflowMode = CType(Me.radDropDownListPanelOverflowMode.SelectedValue, PictureBoxPanelOverflowMode)
        End Sub
    End Class
End Namespace
