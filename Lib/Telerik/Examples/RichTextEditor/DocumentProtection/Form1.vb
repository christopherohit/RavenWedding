Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinControls.RichTextEditor.UI
Imports RichTextEditor.SampleData

Namespace RichTextEditor.DocumentProtection
    Partial Public Class Form1
        Inherits RadRibbonForm
        Private Const SampleDocumentPath As String = "RadRichTextBoxProtection.xaml"
        Private comboBoxLoggedUser As RadDropDownListElement

        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

            Dim dataContext As ExamplesDataContext = New ExamplesDataContext()

            Me.radRichTextEditor1.Users = dataContext.Users

            Dim reviewTab As RibbonTab = CType(Me.richTextEditorRibbonBar1.CommandTabs(Me.richTextEditorRibbonBar1.CommandTabs.Count - 2), RibbonTab)
            reviewTab.Items(0).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            reviewTab.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            reviewTab.Items(2).Visibility = Telerik.WinControls.ElementVisibility.Collapsed

            Me.comboBoxLoggedUser = New RadDropDownListElement()
            CType(reviewTab.Items.Last, RadRibbonBarGroup).Items.Add(Me.comboBoxLoggedUser)
            Me.comboBoxLoggedUser.DataSource = dataContext.CurrentUsers
            Me.comboBoxLoggedUser.DisplayMember = "RealName"
            Me.comboBoxLoggedUser.SelectedIndex = 0
            Me.radRichTextEditor1.CurrentUser = TryCast(Me.comboBoxLoggedUser.SelectedValue, UserInfo)
            Me.comboBoxLoggedUser.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.comboBoxLoggedUser.Alignment = ContentAlignment.MiddleCenter
            AddHandler Me.comboBoxLoggedUser.SelectedValueChanged, AddressOf comboBoxLoggedUser_SelectedValueChanged
        End Sub

        Private Sub comboBoxLoggedUser_SelectedValueChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.ValueChangedEventArgs)
            Me.radRichTextEditor1.CurrentUser = TryCast(Me.comboBoxLoggedUser.SelectedValue, UserInfo)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized

            MyBase.OnLoad(e)
            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(SampleDocumentPath)
                Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
            End Using

        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub
    End Class
End Namespace
