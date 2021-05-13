Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Tools.SvgImages
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True

            Me.radGridView1.TableElement.RowHeight = 132
            AddHandler Me.radGridView1.CellFormatting, AddressOf Me.RadGridView1_CellFormatting
            Me.SetupData()
        End Sub

        Private Sub RadGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
            If e.Column.Name.StartsWith("SVG") Then
                Dim svgImage As RadSvgImage = TryCast(e.Row.Cells(e.Column.Name).Value, RadSvgImage)
                e.CellElement.Text = String.Empty
                e.CellElement.SvgImage = svgImage
            End If

            e.CellElement.ImageLayout = ImageLayout.Center
        End Sub

        Private Sub SetupData()
            Dim nameColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("Name")
            nameColumn.Width = 100
            Me.radGridView1.Columns.Add(nameColumn)
            Dim svgColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("SVG 100%")
            svgColumn.Width = 80
            svgColumn.DataType = GetType(RadSvgImage)
            Me.radGridView1.Columns.Add(svgColumn)
            Dim svgColumn200 As GridViewTextBoxColumn = New GridViewTextBoxColumn("SVG 200%")
            svgColumn200.Width = 90
            svgColumn200.DataType = GetType(RadSvgImage)
            Me.radGridView1.Columns.Add(svgColumn200)
            Dim svgColumn400 As GridViewTextBoxColumn = New GridViewTextBoxColumn("SVG 400%")
            svgColumn400.Width = 130
            svgColumn400.DataType = GetType(RadSvgImage)
            Me.radGridView1.Columns.Add(svgColumn400)
            Dim imageColumn As GridViewImageColumn = New GridViewImageColumn("Image 100%")
            imageColumn.Width = 80
            Me.radGridView1.Columns.Add(imageColumn)
            Dim imageColumn200 As GridViewImageColumn = New GridViewImageColumn("Image 200%")
            imageColumn200.Width = 90
            Me.radGridView1.Columns.Add(imageColumn200)
            Dim imageColumn400 As GridViewImageColumn = New GridViewImageColumn("Image 400%")
            imageColumn400.Width = 130
            Me.radGridView1.Columns.Add(imageColumn400)
            Dim allResources As String() = GetType(Form1).Assembly.GetManifestResourceNames()
            Dim svgs As IEnumerable(Of String) = allResources.Where(Function(r) r.EndsWith(".svg"))

            For Each file As String In svgs
                Dim svgImage As RadSvgImage

                Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                    svgImage = RadSvgImage.FromStream(stream)
                End Using

                Dim size As Size = svgImage.Size
                Dim svgImage200 As RadSvgImage = TryCast(svgImage.Clone(), RadSvgImage)
                svgImage200.Size = New Size(size.Width * 2, size.Height * 2)
                Dim svgImage400 As RadSvgImage = TryCast(svgImage.Clone(), RadSvgImage)
                svgImage400.Size = New Size(size.Width * 4, size.Height * 4)
                Dim image As Image = svgImage.GetRasterImage()
                Dim image200 As Image = New Bitmap(image, svgImage200.Size)
                Dim image400 As Image = New Bitmap(image, svgImage400.Size)
                Dim name As String = Path.GetFileNameWithoutExtension(file)
                name = name.Substring(name.LastIndexOf("."c) + 1)
                name = name.Substring(0, name.Length - 3)
                Dim textInfo As TextInfo = New CultureInfo("en-US", False).TextInfo
                Me.radGridView1.Rows.Add(textInfo.ToTitleCase(name), svgImage, svgImage200, svgImage400, image, image200, image400)
            Next
        End Sub
    End Class
End Namespace
