Imports System
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private suspendUpdate As Boolean

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.CenteredControl = Me.radBrowseEditor1
            Me.radDropDownList1.DataSource = [Enum].GetValues(GetType(BrowseEditorDialogType))
            AddHandler Me.radDropDownList1.SelectedIndexChanged, AddressOf Me.RadDropDownList1_SelectedIndexChanged
        End Sub

        Private Sub RadDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radBrowseEditor1.DialogType = CType(e.Position, BrowseEditorDialogType)
        End Sub

        Private Sub ReadOnlyCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.suspendUpdate Then
                Return
            End If

            Me.suspendUpdate = True
            Me.radBrowseEditor1.[ReadOnly] = Me.radBrowseEditor1.[ReadOnly] Xor True

            If Me.radBrowseEditor1.[ReadOnly] Then
                Me.clearButtonCheckBox.Checked = False
                Me.radBrowseEditor1.BrowseElement.ShowClearButton = False
            End If

            Me.suspendUpdate = False
        End Sub

        Private Sub ClearButtonCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.suspendUpdate Then
                Return
            End If

            Me.suspendUpdate = True

            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                Me.radBrowseEditor1.[ReadOnly] = False
                Me.readOnlyCheckBox.Checked = False
                Me.radBrowseEditor1.BrowseElement.ShowClearButton = True
            Else
                Me.radBrowseEditor1.BrowseElement.ShowClearButton = False
            End If

            Me.suspendUpdate = False
        End Sub
    End Class
End Namespace
