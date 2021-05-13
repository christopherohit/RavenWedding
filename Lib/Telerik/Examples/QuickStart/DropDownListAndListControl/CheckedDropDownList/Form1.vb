Imports System
Imports System.Linq
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.CheckedDropDownList
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub radButton1_Click(sender As Object, e As System.EventArgs) Handles radButton1.Click
            Telerik.WinControls.RadMessageBox.Instance.ThemeName = CurrentThemeName
            Telerik.WinControls.RadMessageBox.Show("Appointment created.", "Message")
        End Sub

        Private Sub radToggleButton1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radToggleButton1.ToggleStateChanged
            Dim check As Boolean = Me.radToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckedDropDownList1.ShowCheckAllItems = check
            Me.radCheckedDropDownList2.ShowCheckAllItems = check
        End Sub
    End Class
End Namespace