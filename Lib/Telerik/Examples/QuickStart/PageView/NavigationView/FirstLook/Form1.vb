Imports System
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PageView.NavigationView.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.ParisPage.Item.Tag = Me.ParisPage.Item.Image
            Me.LondonPage.Item.Tag = Me.LondonPage.Item.Image
            Me.ViennaPage.Item.Tag = Me.ViennaPage.Item.Image
            Me.VenicePage.Item.Tag = Me.VenicePage.Item.Image
            Me.FlorencePage.Item.Tag = Me.FlorencePage.Item.Image
            Me.EdinburghPage.Item.Tag = Me.EdinburghPage.Item.Image
            AddHandler Me.ParisPage.Item.PropertyChanged, AddressOf Item_PropertyChanged
            AddHandler Me.LondonPage.Item.PropertyChanged, AddressOf Item_PropertyChanged
            AddHandler Me.ViennaPage.Item.PropertyChanged, AddressOf Item_PropertyChanged
            AddHandler Me.VenicePage.Item.PropertyChanged, AddressOf Item_PropertyChanged
            AddHandler Me.FlorencePage.Item.PropertyChanged, AddressOf Item_PropertyChanged
            AddHandler Me.EdinburghPage.Item.PropertyChanged, AddressOf Item_PropertyChanged
        End Sub

        Private Sub SetWhitePageImage(ByVal page As RadPageViewPage)
            Dim image As Image = ImageHelper.ChangeImagePixels(page.Image, Color.White)
            page.Item.Image = image
        End Sub

        Private Sub Item_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If e.PropertyName = LightVisualElement.BackColorProperty.Name Then
                Dim item As RadPageViewNavigationViewItem = TryCast(sender, RadPageViewNavigationViewItem)
                Dim backColor As Color = item.BackColor

                If Not item.DrawFill OrElse backColor = Color.Transparent Then
                    Dim parent As RadElement = item.Parent

                    While parent IsNot Nothing
                        Dim lve As LightVisualElement = TryCast(parent, LightVisualElement)

                        If lve IsNot Nothing AndAlso lve.DrawFill AndAlso lve.BackColor <> Color.Transparent Then
                            backColor = lve.BackColor
                            Exit While
                        End If

                        parent = parent.Parent
                    End While
                End If

                If Me.IsDarkColor(backColor) Then
                    Me.SetWhitePageImage(item.Page)
                ElseIf item.Tag IsNot Nothing Then
                    item.Image = CType(item.Tag, Image)
                End If
            End If
        End Sub

        Private Function IsDarkColor(ByVal color As Color) As Boolean
            Dim r As Integer = CInt(color.R)
            Dim g As Integer = CInt(color.G)
            Dim b As Integer = CInt(color.B)

            Dim colorBrightness As Double = Math.Sqrt(r * r * 0.241F + g * g * 0.691F + b * b * 0.068F)
            Return colorBrightness < 170
        End Function
    End Class
End Namespace
