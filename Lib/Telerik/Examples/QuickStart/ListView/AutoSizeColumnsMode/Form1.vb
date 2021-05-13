Imports System
Imports System.Drawing
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ListView.AutoSizeColumnsMode
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
        End Sub

        Private Sub RadListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
            If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
            Else
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local)
            End If
        End Sub

        Private Sub RadButtonBestFitColumns_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim detailView As DetailListViewElement = TryCast(Me.radListView1.ListViewElement.ViewElement, DetailListViewElement)

            If detailView IsNot Nothing Then
                detailView.BestFitColumns(ListViewBestFitColumnMode.AllCells)
            End If
        End Sub

        Private Sub RadRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radListView1.AutoSizeColumnsMode = If(Me.radRadioButton1.IsChecked, ListViewAutoSizeColumnsMode.Fill, ListViewAutoSizeColumnsMode.None)

            If Me.radListView1.AutoSizeColumnsMode = ListViewAutoSizeColumnsMode.None Then

                For Each column As ListViewDetailColumn In Me.radListView1.Columns
                    column.Width = 50.0F
                Next
            End If

            Me.radListView1.ListViewElement.InvalidateMeasure(True)
        End Sub
    End Class
End Namespace
