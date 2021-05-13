Imports System.Linq
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.PopupEditor
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            Me.InitializeComponent()
            Me.radCalendar1.SelectedDate = Date.Now
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            Me.radPopupEditor1.Text = String.Format("{0} {1}", Me.radCalendar1.FocusedDate.Date.ToString("yyyy/MM/dd"), Date.Now.ToString("HH:mm:ss"))
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace