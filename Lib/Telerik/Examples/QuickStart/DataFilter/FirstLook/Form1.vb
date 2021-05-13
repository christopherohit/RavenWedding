Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataFilter.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.ordersTableAdapter.Fill(Me.northwindDataSet.Orders)

            AddHandler Me.radDataFilter1.NodeRemoved, AddressOf radDataFilter1_NodeRemoved
            AddHandler Me.radDataFilter1.Edited, AddressOf radDataFilter1_Edited
            AddHandler Me.radDataFilter1.EditorInitialized, AddressOf radDataFilter1_EditorInitialized
            AddHandler Me.radDataFilter1.DragEnded, AddressOf radDataFilter1_DragEnded
        End Sub

        Private Sub radDataFilter1_EditorInitialized(sender As Object, e As TreeNodeEditorInitializedEventArgs)
            Dim criteriaElement As DataFilterCriteriaElement = TryCast(e.NodeElement, DataFilterCriteriaElement)
            Dim criteriaNode As DataFilterCriteriaNode = TryCast(e.Node, DataFilterCriteriaNode)
            Dim spinEditor As TreeViewSpinEditor = TryCast(e.Editor, TreeViewSpinEditor)
            If criteriaElement IsNot Nothing AndAlso ReferenceEquals(criteriaElement.EditingElement, criteriaElement.ValueElement) AndAlso spinEditor IsNot Nothing Then
                Dim propertyName As String = criteriaNode.PropertyName
                Dim minValue As Decimal = Decimal.MinValue
                Dim maxValue As Decimal = Decimal.MaxValue

                If propertyName = "OrderID" Then
                    minValue = 10000
                    maxValue = 12000
                ElseIf propertyName = "EmployeeID" Then
                    minValue = 1
                    maxValue = 10
                ElseIf propertyName = "ShipVia" Then
                    minValue = 1
                    maxValue = 5
                ElseIf propertyName = "Freight" Then
                    minValue = 0
                    maxValue = 20000
                End If

                spinEditor.MinValue = minValue
                spinEditor.MaxValue = maxValue
            End If
        End Sub

        Private Sub radDataFilter1_DragEnded(sender As Object, e As RadTreeViewDragEventArgs)
            Me.ApplyFilter()
        End Sub

        Private Sub radDataFilter1_NodeRemoved(sender As Object, e As RadTreeViewEventArgs)
            Me.ApplyFilter()
        End Sub

        Private Sub radDataFilter1_Edited(sender As Object, e As TreeNodeEditedEventArgs)
            Dim criteriaNode As DataFilterCriteriaNode = TryCast(e.Node, DataFilterCriteriaNode)
            If criteriaNode IsNot Nothing Then
                Dim isFieldNameEmpty As Boolean = TelerikHelper.StringIsNullOrWhiteSpace(criteriaNode.PropertyName)
                Dim isOperatorValid As Boolean = criteriaNode.FilterOperator <> FilterOperator.None
                Dim isValueRequired As Boolean = criteriaNode.FilterOperator <> FilterOperator.IsNull AndAlso criteriaNode.FilterOperator <> FilterOperator.IsNotNull
                Dim hasValue As Boolean = criteriaNode.DescriptorValue IsNot Nothing AndAlso criteriaNode.DescriptorValue.ToString() <> String.Empty

                If Not isFieldNameEmpty AndAlso isOperatorValid AndAlso (Not isValueRequired OrElse (isValueRequired AndAlso hasValue)) Then
                    Me.ApplyFilter()
                End If
            End If

            Dim groupNode As DataFilterGroupNode = TryCast(e.Node, DataFilterGroupNode)
            If groupNode IsNot Nothing Then
                Me.ApplyFilter()
            End If
        End Sub

        Private Sub ApplyFilter()
            Try
                Me.radDataFilter1.ApplyFilter()
            Catch generatedExceptionName As Exception
                RadMessageBox.Show(Me.radDataFilter1, "Please, enter valid parameters", "Expression is not valid")
            End Try
        End Sub
    End Class
End Namespace