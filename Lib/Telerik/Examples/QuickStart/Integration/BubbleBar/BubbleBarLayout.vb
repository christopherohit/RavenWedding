Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls
Imports System.Drawing

Namespace Telerik.Examples.WinControls.Integration.BubbleBar
    Public Class BubbleBarLayout
        Inherits LayoutPanel
        Private prefferedSize As Size

        'Public Overrides Sub PerformLayoutCore(ByVal affectedElement As RadElement)
        '    prefferedSize = Size.Empty
        '    For Each element As RadElement In Me.Children
        '        Dim elementPrefferedSize As Size = element.GetPreferredSize(Me.AvailableSize)
        '        elementPrefferedSize.Width = CInt(Fix(elementPrefferedSize.Width * element.ScaleTransform.Width))
        '        prefferedSize.Width += elementPrefferedSize.Width
        '        prefferedSize.Height = Math.Max(prefferedSize.Height, elementPrefferedSize.Height)
        '    Next element

        '    Dim xoffset As Integer = 0
        '    For Each element As RadElement In Me.Children
        '        Dim elementPrefferedSize As Size = element.GetPreferredSize(Me.AvailableSize)
        '        element.Bounds = New Rectangle(New Point(xoffset, prefferedSize.Height - CInt(Fix(elementPrefferedSize.Height * element.ScaleTransform.Height))), elementPrefferedSize)
        '        xoffset += CInt(Fix(elementPrefferedSize.Width * element.ScaleTransform.Width))
        '    Next element
        'End Sub

        'Public Overrides Function GetPreferredSizeCore(ByVal proposedSize As Size) As Size
        '    Return prefferedSize
        'End Function
    End Class

End Namespace
