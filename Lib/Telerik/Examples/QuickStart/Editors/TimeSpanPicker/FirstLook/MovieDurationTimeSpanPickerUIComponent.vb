Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Public Class MovieDurationTimeSpanPickerUIComponent
        Inherits ListTimeSpanPickerUIComponent

        Public Sub New(ByVal owner As ITimeSpanPickerComponent)
            MyBase.New(owner)
        End Sub

        Protected Overrides Sub CreateItemsSource()
            Dim minutes As Integer = 30

            For i As Integer = 0 To 10
                Dim item As RadListDataItem = New RadListDataItem(minutes & " minutes", minutes)

                If minutes >= 90 AndAlso minutes < 180 Then
                    minutes += 15
                Else
                    minutes += 30

                    If minutes > 240 Then
                        minutes = 240
                    End If
                End If

                Me.ListElement.Items.Add(item)
            Next
        End Sub
    End Class
End Namespace
