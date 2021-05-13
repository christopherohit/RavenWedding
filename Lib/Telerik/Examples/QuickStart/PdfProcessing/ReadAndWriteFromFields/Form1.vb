Imports System
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Fixed.Model.InteractiveForms

Namespace Telerik.Examples.WinControls.PdfProcessing.ReadAndWriteFromFields
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private sampleFile As String = "..\PdfProcessing\ReadAndWriteFromFields\SampleData\InteractiveForms.pdf"

        Public Sub New()
            InitializeComponent()
            Me.ProcessDocument(FieldsProcessingType.Read)
            Dim sampleImageDocument As Image = Image.FromFile("..\PdfProcessing\ReadAndWriteFromFields\SampleData\InteractiveForms.png")
            Me.radLabel5.Image = sampleImageDocument
            Me.radLabel5.ImageAlignment = ContentAlignment.MiddleCenter
            Me.splitPanel2.SplitPanelElement.Fill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            AddHandler Me.splitPanel2.ThemeNameChanged, AddressOf SplitPanel2_ThemeNameChanged
        End Sub

        Private Sub SplitPanel2_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
            Me.splitPanel2.BackColor = Me.splitPanel1.SplitPanelElement.Fill.BackColor
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        End Sub

        Private Sub ClearAllButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            radListView1.Items.Clear()
        End Sub

        Private Sub AddNewButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ListViewDataItem = New ListViewDataItem()
            Me.radListView1.Items.Add(item)
            Me.radListView1.SelectedItem = item
            Me.radListView1.BeginEdit()
        End Sub

        Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ProcessDocument(FieldsProcessingType.Write)
        End Sub

        Private Sub LoadTemplateButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ProcessDocument(FieldsProcessingType.Read)
        End Sub

        Private Sub ProcessDocument(ByVal processingType As FieldsProcessingType)
            Using stream As Stream = New FileStream(sampleFile, FileMode.Open, FileAccess.Read)
                Dim document As Windows.Documents.Fixed.Model.RadFixedDocument = New Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider().Import(stream)

                For Each field As FormField In document.AcroForm.FormFields

                    Select Case field.FieldType
                        Case FormFieldType.TextBox
                            ProcessTextBox(processingType, CType(field, TextBoxField))
                        Case FormFieldType.ListBox
                            Me.ProcessListBox(processingType, CType(field, Telerik.Windows.Documents.Fixed.Model.InteractiveForms.ListBoxField))
                        Case FormFieldType.RadioButton
                            ProcessRadioButtons(processingType, CType(field, Telerik.Windows.Documents.Fixed.Model.InteractiveForms.RadioButtonField))
                        Case FormFieldType.CheckBox
                            ProcessCheckBoxes(processingType, CType(field, CheckBoxField))
                    End Select
                Next

                If processingType = FieldsProcessingType.Write Then
                    Dim dialog As SaveFileDialog = New SaveFileDialog()
                    dialog.Filter = String.Format("{0} files|*.{1}", "Pdf", "pdf")
                    dialog.FileName = "Result.pdf"

                    If dialog.ShowDialog() = DialogResult.OK Then

                        Using saveStream As Stream = dialog.OpenFile()
                            Dim pdfFormatProvider As Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider = New Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider()
                            pdfFormatProvider.Export(document, saveStream)
                        End Using
                    End If
                End If
            End Using
        End Sub

        Private Sub ProcessTextBox(ByVal processingType As FieldsProcessingType, ByVal textBoxField As TextBoxField)
            If processingType = FieldsProcessingType.Read Then
                Me.radTextBox1.Text = textBoxField.Value
            Else
                textBoxField.Value = Me.radTextBox1.Text
            End If
        End Sub

        Private Sub ProcessListBox(ByVal processingType As FieldsProcessingType, ByVal listField As Telerik.Windows.Documents.Fixed.Model.InteractiveForms.ListBoxField)
            If processingType = FieldsProcessingType.Read Then
                Me.radListView1.Items.Clear()

                For Each [option] As Windows.Documents.Fixed.Model.InteractiveForms.ChoiceOption In listField.Options
                    Dim listItem As ListViewDataItem = New ListViewDataItem()
                    listItem.Value = [option].Value

                    If listField.Value IsNot Nothing AndAlso listField.Value.Contains([option]) Then
                        radListView1.SelectedItem = listItem
                    End If

                    Me.radListView1.Items.Add(listItem)
                Next
            Else
                listField.Options.Clear()

                For Each listViewItem As ListViewDataItem In Me.radListView1.Items
                    Dim value As String = If(listViewItem.Value Is Nothing, " ", listViewItem.Value.ToString())
                    Dim [option] As ChoiceOption = New ChoiceOption(value)
                    listField.Options.Add([option])

                    If listViewItem.Selected Then
                        listField.Value = New ChoiceOption() {[option]}
                    End If
                Next
            End If
        End Sub

        Private Sub ProcessRadioButtons(ByVal processingType As FieldsProcessingType, ByVal radioField As Telerik.Windows.Documents.Fixed.Model.InteractiveForms.RadioButtonField)
            If processingType = FieldsProcessingType.Read Then
                Me.radRadioButton1.IsChecked = radioField.Value.Value = Me.radRadioButton1.Text
                Me.radRadioButton2.IsChecked = radioField.Value.Value = Me.radRadioButton2.Text
                Me.radRadioButton3.IsChecked = radioField.Value.Value = Me.radRadioButton3.Text
            Else
                Dim checkedContent As Object = Nothing

                If Me.radRadioButton1.IsChecked Then
                    checkedContent = radRadioButton1.Text
                ElseIf Me.radRadioButton2.IsChecked Then
                    checkedContent = radRadioButton2.Text
                ElseIf Me.radRadioButton3.IsChecked Then
                    checkedContent = radRadioButton3.Text
                End If

                If checkedContent IsNot Nothing Then
                    radioField.Value = radioField.Options.Where(Function(x) x.Value = checkedContent.ToString()).FirstOrDefault()
                End If
            End If
        End Sub

        Private Sub ProcessCheckBoxes(ByVal processingType As FieldsProcessingType, ByVal checkBoxField As CheckBoxField)
            If processingType = FieldsProcessingType.Read Then

                If checkBoxField.Name.Contains("1") Then
                    Me.checkBox1.IsChecked = checkBoxField.IsChecked
                ElseIf checkBoxField.Name.Contains("2") Then
                    Me.checkBox2.IsChecked = checkBoxField.IsChecked
                ElseIf checkBoxField.Name.Contains("3") Then
                    Me.checkBox3.IsChecked = checkBoxField.IsChecked
                End If
            Else

                If checkBoxField.Name.Contains("1") Then
                    checkBoxField.IsChecked = Me.checkBox1.IsChecked
                ElseIf checkBoxField.Name.Contains("2") Then
                    checkBoxField.IsChecked = Me.checkBox2.IsChecked
                ElseIf checkBoxField.Name.Contains("3") Then
                    checkBoxField.IsChecked = Me.checkBox3.IsChecked
                End If
            End If
        End Sub
    End Class

    Public Enum FieldsProcessingType
        ''' <summary>
        ''' Writes the field values.
        ''' </summary>
        Write

        ''' <summary>
        ''' Reads the field values.
        ''' </summary>
        Read
    End Enum
End Namespace
