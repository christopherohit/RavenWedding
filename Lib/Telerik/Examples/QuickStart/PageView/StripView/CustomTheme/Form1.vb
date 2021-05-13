Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.StripView.CustomTheme
    Partial Public Class Form1
        Inherits ExamplesForm
#Region "Fields"

        Private view As RadPageView
        Private strip As RadPageViewStripElement

#End Region

#Region "Constructor"

        Public Sub New()
            Me.view = New Telerik.WinControls.UI.RadPageView()
            Me.view.Size = New Size(500, 400)
            Me.view.Parent = Me
            Me.view.Location = New Point(20, 20)
            Me.strip = TryCast(Me.view.ViewElement, RadPageViewStripElement)
            AddHandler Me.view.SelectedPageChanged, New EventHandler(AddressOf view_SelectedPageChanged)
            PageViewLabels.currIndex = 0

            Me.strip.StripButtons = StripViewButtons.Scroll Or StripViewButtons.ItemList

            InitializeComponent()

            For i As Integer = 0 To 9 - 1
                Dim page As RadPageViewPage = New RadPageViewPage()
                page.Text = PageViewImages.Names(i)
                page.Image = PageViewImages.Images(i)
                page.Controls.Add(PageViewLabels.CreateLabel(Me.view.RootElement.DpiScaleFactor))
                Me.view.Pages.Add(page)
            Next

            Me.enableAnimationCheck.Checked = strip.AnimatedStripScrolling
        End Sub

        Shared Sub New()
            ThemeResolutionService.LoadPackageResource("StripViewCheckButtons.tssp")
        End Sub

#End Region

#Region "Overrides"

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            ExamplesForm.FillComboFromEnum(Me.animationTypeCombo, GetType(RadEasingType), Me.strip.StripScrollingAnimation)
        End Sub

        Protected Overrides Function GetExampleDefaultTheme() As String
            Return "StripViewCheckButtons"
        End Function

#End Region

#Region "Event Handlers"

        Private Sub view_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.strip.Header.Image = Me.view.SelectedPage.Image
        End Sub

        Private Sub enableAnimationCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.strip.AnimatedStripScrolling = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub

        Private Sub animationTypeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim item As RadListDataItem = TryCast(Me.animationTypeCombo.SelectedItem, RadListDataItem)
            Me.strip.StripScrollingAnimation = CType(item.Value, RadEasingType)
        End Sub

        Private Sub shrinkItemsCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.strip.ItemFitMode = StripViewItemFitMode.Shrink
            Else
                Me.strip.ItemFitMode = StripViewItemFitMode.None
            End If
        End Sub

#End Region

        Protected Overrides Sub WireEvents()
            AddHandler enableAnimationCheck.ToggleStateChanged, AddressOf enableAnimationCheck_ToggleStateChanged
            AddHandler animationTypeCombo.SelectedIndexChanged, AddressOf animationTypeCombo_SelectedIndexChanged
            AddHandler shrinkItemsCheck.ToggleStateChanged, AddressOf shrinkItemsCheck_ToggleStateChanged
        End Sub
    End Class
End Namespace
