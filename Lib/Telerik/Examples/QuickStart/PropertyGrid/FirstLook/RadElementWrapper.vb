Imports System.Text
Imports System.ComponentModel
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
    Public Class RadElementWrapper
        Private element As RadItem
        Private owner As SurfaceObject

        Public Sub New(ByVal owner As SurfaceObject, ByVal element As RadItem)
            Me.element = element
            Me.owner = owner
        End Sub

#Region "Properties"

        <Description("Gets or sets the text displayed in the control."), Category("Text"), DefaultValue("RadPropertyGrid"), Browsable(True)> _
        Public Property Text() As String
            Get
                Return Me.element.Text
            End Get
            Set(ByVal value As String)
                Me.element.Text = value
            End Set
        End Property

        <Description("Gets or sets the size of the text displayed in the control."), Category("Text"), DefaultValue(12), Browsable(True)> _
        Public Property FontSize() As Single
            Get
                Return Me.element.Font.Size
            End Get
            Set(ByVal value As Single)
                Me.element.Font = New Font(Me.element.Font.FontFamily, value)
            End Set
        End Property

        <Description("Gets or sets the width of the control border."), Category("Border"), DefaultValue(2.0F), Browsable(True)> _
        Public Property BorderWidth() As Single
            Get
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    Return lve.BorderWidth
                End If
                Dim border As BorderPrimitive = element.FindDescendant(Of BorderPrimitive)()
                If border IsNot Nothing Then
                    Return border.Width
                End If
                Return 1
            End Get
            Set(ByVal value As Single)
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    lve.BorderWidth = value
                End If
                Dim border As BorderPrimitive = element.FindDescendant(Of BorderPrimitive)()
                If border IsNot Nothing Then
                    border.Width = value
                End If
            End Set
        End Property

        <Description("Gets or sets the color of the control border.")> _
        <Category("Border")> _
        <Browsable(True)> _
        Public Property BorderColor() As Color
            Get
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    Return lve.BorderColor
                End If
                Dim border As BorderPrimitive = element.FindDescendant(Of BorderPrimitive)()
                If border IsNot Nothing Then
                    Return border.ForeColor
                End If
                Return Color.Black
            End Get
            Set(ByVal value As Color)
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    lve.BorderColor = value
                End If
                Dim border As BorderPrimitive = element.FindDescendant(Of BorderPrimitive)()
                If border IsNot Nothing Then
                    border.Width = Math.Max(1, border.Width)
                    border.BoxStyle = BorderBoxStyle.SingleBorder
                    border.GradientStyle = GradientStyles.Solid
                    border.Visibility = ElementVisibility.Visible
                    border.ForeColor = value
                    border.ShouldPaint = True
                End If
            End Set
        End Property

        <Description("Gets or sets the color of the fill of the control border.")> _
              <Category("Background")> _
              <Browsable(True)> _
        Public Property BackColor() As Color
            Get
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    Return lve.BackColor
                End If
                Dim fill As FillPrimitive = element.FindDescendant(Of FillPrimitive)()
                If fill IsNot Nothing Then
                    Return fill.BackColor
                End If
                Return Color.Black
            End Get
            Set(ByVal value As Color)
                Dim lve As LightVisualElement = TryCast(element, LightVisualElement)
                If lve IsNot Nothing Then
                    lve.BackColor = value
                End If
                Dim fill As FillPrimitive = element.FindDescendant(Of FillPrimitive)()
                If fill IsNot Nothing Then
                    fill.Visibility = ElementVisibility.Visible
                    fill.ShouldPaint = True
                    fill.GradientStyle = GradientStyles.Solid
                    fill.BackColor = value
                End If
            End Set
        End Property

        <Description("Gets or sets the color of the text of the control border.")> _
                <Category("Text")> _
                <Browsable(True)> _
        Public Property ForeColor() As Color
            Get
                Return Me.element.ForeColor
            End Get
            Set(ByVal value As Color)
                Me.element.ForeColor = value
            End Set
        End Property

        <Description("Gets or sets location of the control.")> _
      <Category("Layout")> _
      <Browsable(True)> _
        Public Property Location() As Point
            Get
                Return Me.owner.Offset
            End Get
            Set(ByVal value As Point)
                Me.owner.Offset = value
            End Set
        End Property

        <Description("Gets or sets padding of the control.")> _
              <Category("Layout")> _
              <Browsable(True)> _
        Public Property Padding() As Padding
            Get
                Return Me.element.Padding
            End Get
            Set(ByVal value As Padding)
                Me.element.Padding = value
                Me.owner.InvalidateMeasure(True)
            End Set
        End Property

#End Region
    End Class
End Namespace
