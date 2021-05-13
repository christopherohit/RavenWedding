Imports Microsoft.VisualBasic
Imports RichTextEditor.SampleData
Imports System
Imports System.Drawing
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports System.Collections.Generic

Namespace RichTextEditor.MailMerge
    Partial Public Class Form1
        Inherits RadRibbonForm
        Private Const SampleDocumentPath As String = "RadRichTextBoxMailMerge.xaml"

        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName
            PopulateListView()

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Telerik.WinControls.RichTextEditor.UI.Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

        Private Sub PopulateListView()
            radListView1.Items.Add(Me.CreateItem("female1.png", 0, "Maria Anders"))
            radListView1.Items.Add(Me.CreateItem("female2.png", 4, "Anabela Domingues"))
            radListView1.Items.Add(Me.CreateItem("female3.png", 5, "Anne Dodsworth"))
            radListView1.Items.Add(Me.CreateItem("male1.png", 1, "Antonio Taqueria"))
            radListView1.Items.Add(Me.CreateItem("male2.png", 2, "Thomas Hardy"))
            radListView1.Items.Add(Me.CreateItem("male3.png", 3, "Martin Sommer"))
        End Sub

        Private Function CreateItem(ByVal imageFileName As String, ByVal index As Integer, ByVal name As String) As ListViewDataItem
            Dim item As ListViewDataItem = New ListViewDataItem()
            item.Text = name
            item.TextAlignment = ContentAlignment.MiddleCenter
            item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            item.Image = Image.FromStream(GetType(Form1).Assembly.GetManifestResourceStream(imageFileName))
            item.ImageAlignment = ContentAlignment.MiddleCenter
            item.Tag = index

            Return item
        End Function

        Private Sub radListView1_ItemMouseClick(ByVal sender As Object, ByVal e As ListViewItemEventArgs) Handles radListView1.ItemMouseClick
            Me.radRichTextEditor1.Document.MailMergeDataSource.MoveToIndex(CInt(Fix(e.Item.Tag)))
            Me.radRichTextEditor1.UpdateAllFields(FieldDisplayMode.Result)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)

            MyBase.OnLoad(e)

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(SampleDocumentPath)
                Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
            End Using

            Me.radRichTextEditor1.Document.MailMergeDataSource.ItemsSource = New ExamplesDataContext().MailMessageInfos
            AddHandler Me.radRichTextEditor1.CommandExecuting, AddressOf radRichTextEditor1_CommandExecuting
            AddHandler Me.radRichTextEditor1.StreamFromUriResolving, AddressOf radRichTextEditor1_StreamFromUriResolving

            radListView1.SelectedIndex = 0
            Me.radRichTextEditor1.Document.MailMergeDataSource.MoveToIndex(0)
            Me.radRichTextEditor1.UpdateAllFields(FieldDisplayMode.Result)
        End Sub

        Private Sub radRichTextEditor1_StreamFromUriResolving(ByVal sender As Object, ByVal e As StreamFromUriResolvingEventArgs)
            e.Stream = GetType(Form1).Assembly.GetManifestResourceStream(e.Uri)
        End Sub

        Private Sub radRichTextEditor1_CommandExecuting(ByVal sender As Object, ByVal e As Telerik.WinForms.Documents.RichTextBoxCommands.CommandExecutingEventArgs)
            If TypeOf e.Command Is InsertFieldCommand AndAlso TypeOf e.CommandParameter Is MergeField Then
                Dim fieldName As String = (TryCast(e.CommandParameter, MergeField)).PropertyPath

                If fieldName.ToUpper() = "RECIPIENTPHOTO" Then
                    e.Cancel = True

                    Dim mf As MergeField = New MergeField()
                    mf.PropertyPath = fieldName
                    Dim picField As IncludePictureField = New IncludePictureField()
                    picField.SetPropertyValue(IncludePictureField.ImageUriProperty, mf)
                    Me.radRichTextEditor1.InsertField(picField)
                End If
            End If
        End Sub
    End Class
End Namespace
