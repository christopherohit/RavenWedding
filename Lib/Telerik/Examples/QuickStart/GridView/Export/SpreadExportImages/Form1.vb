Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Export.SpreadExportImages

    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.radGridView1.TableElement.RowHeight = 160
            ExamplesForm.FillComboFromEnum(Me.imageLayoutDropDownList, GetType(ImageLayout), ImageLayout.None)
            Me.imageLayoutDropDownList.Items.RemoveAt(1)
            ExamplesForm.FillComboFromEnum(Me.imageAlignmentDropDownList, GetType(ContentAlignment), ContentAlignment.TopLeft)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)

            Me.ResizeImages()
        End Sub

        Private Sub ResizeImages()
            For productIndex As Integer = 0 To Me.furnitureDataSet.Products.Count - 1
                Dim bytes As Byte() = Me.furnitureDataSet.Products(productIndex).Photo
                Dim result As Object = Nothing
                RadDataConverter.Instance.TryFormat(bytes, GetType(Image), Me.radGridView1.Columns("Photo"), result)
                Dim image As Image = TryCast(result, Image)
                If image IsNot Nothing Then
                    image = New Bitmap(image, New Size(200, 150))
                    bytes = GridExportUtils.ConvertImageToByteArray(image)
                    Me.furnitureDataSet.Products(productIndex).Photo = bytes
                End If
            Next
        End Sub

        Private Sub imageLayoutDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radGridView1.BeginUpdate()
            Me.radGridView1.Columns("Photo").ImageLayout = CType(Me.imageLayoutDropDownList.SelectedValue, ImageLayout)
            Me.imageAlignmentDropDownList.Enabled = Me.radGridView1.Columns("Photo").ImageLayout = ImageLayout.None
            Me.radGridView1.EndUpdate(True)
        End Sub

        Private Sub imageAlignmentDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radGridView1.BeginUpdate()
            TryCast(Me.radGridView1.Columns("Photo"), GridViewImageColumn).ImageAlignment = CType(Me.imageAlignmentDropDownList.SelectedValue, ContentAlignment)
            Me.radGridView1.EndUpdate(True)
        End Sub

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()
            saveDialog.Filter = "Excel (*.xls)|*.xlsx"
            saveDialog.FileName = "exportedFile"
            If saveDialog.ShowDialog(Me) = DialogResult.OK Then
                Dim spreadExport As GridViewSpreadExport = New GridViewSpreadExport(Me.radGridView1)
                spreadExport.ExportVisualSettings = True
                spreadExport.RunExport(saveDialog.FileName, New SpreadExportRenderer())
            End If
        End Sub
    End Class
End Namespace