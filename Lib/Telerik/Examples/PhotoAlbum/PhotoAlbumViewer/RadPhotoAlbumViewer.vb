Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports Telerik.WinControls

Namespace PhotoAlbumVB
    Public Class RadPhotoAlbumViewer
        Inherits RadControl
        Private albumElement_Renamed As PhotoAlbumViewerElement

        Public Sub New()
            Me.ThemeName = "no theme"
        End Sub

        Protected Overrides Sub OnLoad(ByVal desiredSize As System.Drawing.Size)
            MyBase.OnLoad(desiredSize)
            Me.EnableGesture(GestureType.All)
            Me.EnableGesture(GestureType.Pan)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property AlbumElement() As PhotoAlbumViewerElement
            Get
                Return albumElement_Renamed
            End Get
        End Property

        Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
            Me.albumElement_Renamed = New PhotoAlbumViewerElement()
            parent.Children.Add(Me.albumElement_Renamed)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(True), Category(RadDesignCategory.DataCategory), RadNewItem("Item", False)> _
        Public ReadOnly Property Items() As RadItemCollection
            Get
                Return Me.AlbumElement.Items
            End Get
        End Property
        Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
            MyBase.OnSizeChanged(e)
            Me.albumElement_Renamed.SelectedIndex = -1
        End Sub
    End Class
End Namespace
