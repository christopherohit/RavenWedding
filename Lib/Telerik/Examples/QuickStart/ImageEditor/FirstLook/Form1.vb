Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.ImageEditor.FirstLook

    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.radImageEditor1.OpenImage(My.Resources.ballons_image)
        End Sub
    End Class
End Namespace