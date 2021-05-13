Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.ValidationProvider
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            CType(Me.EmailMaskedEditBox.MaskedEditBoxElement.Provider, RegexMaskTextBoxProvider).ErrorMessage = String.Empty

            Dim xml As String = "<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" viewBox=""0 0 16 16"" >" &
                "<circle cx=""8"" cy=""8"" r=""8"" fill=""#00BFE8"" />" &
                "<text x=""4"" y=""13"" fill=""white"" font-family=""Consolas, Helvetica, sans-serif"" font-size=""14px"" font-weight=""bold"">i</text>" &
                "</svg>"
            Me.highlightValidationErrorsLabel.SvgImage = RadSvgImage.FromXml(xml)

            FillComboFromEnum(Me.validationModeDropDownList, GetType(ValidationMode), ValidationMode.OnValidating)
            Me.validationModeDropDownList.SelectedValue = ValidationMode.Programmatically
        End Sub

        Private Sub ValidationModeDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radValidationProvider1.ValidationMode = CType(Me.validationModeDropDownList.SelectedValue, ValidationMode)
        End Sub

        Private Sub ButtonSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radValidationProvider1.ValidationMode = ValidationMode.Programmatically Then

                For Each control As Control In Me.doubleBufferedTableLayoutPanel1.Controls
                    Dim editorControl As RadEditorControl = TryCast(control, RadEditorControl)

                    If editorControl IsNot Nothing Then
                        Me.radValidationProvider1.Validate(editorControl)
                    End If
                Next
            End If
        End Sub
    End Class
End Namespace
