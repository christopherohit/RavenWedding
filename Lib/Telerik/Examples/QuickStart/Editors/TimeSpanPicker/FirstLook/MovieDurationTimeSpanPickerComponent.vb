Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Public Class MovieDurationTimeSpanPickerComponent
        Inherits MinuteTimeSpanPickerComponent

        Public Sub New(ByVal owner As ITimeSpanPickerContentElement)
            MyBase.New(owner)
        End Sub

        Protected Overrides Sub InitializeFields()
            MyBase.InitializeFields()
            Me.DefaultSize = New System.Drawing.Size(120, 200)
        End Sub

        Public Overrides Function CreateVisualElement() As BaseTimeSpanPickerUIComponent
            Return New MovieDurationTimeSpanPickerUIComponent(Me)
        End Function
    End Class
End Namespace
