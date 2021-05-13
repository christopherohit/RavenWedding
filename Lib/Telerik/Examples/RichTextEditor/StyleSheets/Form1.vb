Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Model.Styles

Namespace RichTextEditor.StyleSheets
	Public Partial Class Form1
		Inherits RadRibbonForm
		#Region "Constants"

        Private Const DefaultStyleSheetPath As String = "StyleSheetDefault.xaml"
        Private Const CustomStyleSheetPath As String = "StyleSheetDemo.xaml"

		#End Region

		Public Sub New()
			InitializeComponent()

            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = Program.ThemeName

			Me.SetupRibbonBar()

            Using stream = GetType(Form1).Assembly.GetManifestResourceStream("StyleSheetDemoDocument.xaml")
                Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
            End Using

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Telerik.WinControls.RichTextEditor.UI.Colors.White
                Next

                Dim headerFooters As List(Of Telerik.WinControls.RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As Telerik.WinControls.RadElement) TypeOf x Is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer, Telerik.WinControls.TreeTraversalMode.BreadthFirst)
                For Each container As Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

		#Region "Methods"

		Private Sub SetupRibbonBar()
			Dim homeTab As RibbonTab = CType(Me.richTextEditorRibbonBar1.CommandTabs(0), RibbonTab)
			homeTab.Items(0).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			homeTab.Items(3).Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Dim customStylesGroup As RadRibbonBarGroup = New RadRibbonBarGroup()
			customStylesGroup.StretchVertically = True
			customStylesGroup.Text = "Load Styles"
			customStylesGroup.Margin = New System.Windows.Forms.Padding(-1, -1, 0, -1)


			Dim defaultStyleButton As RadButtonElement = New RadButtonElement()
			defaultStyleButton.Text = "Load Default"
			defaultStyleButton.TextAlignment = ContentAlignment.MiddleLeft
			defaultStyleButton.Padding = New System.Windows.Forms.Padding(2)
			AddHandler defaultStyleButton.Click, AddressOf loadDefaultStyleSheet_Click

			Dim customStyleButton As RadButtonElement = New RadButtonElement()
			customStyleButton.Text = "Load Custom"
			customStyleButton.TextAlignment = ContentAlignment.MiddleLeft
			customStyleButton.Padding = New System.Windows.Forms.Padding(2)
			AddHandler customStyleButton.Click, AddressOf loadCustomStyleSheet_Click

			Dim externalStyleButton As RadDropDownButtonElement = New RadDropDownButtonElement()
			externalStyleButton.Text = "External Styles"
			externalStyleButton.TextAlignment = ContentAlignment.MiddleLeft
			externalStyleButton.Padding = New System.Windows.Forms.Padding(2)

			Dim loadStyleSheetItem As RadMenuItem = New RadMenuItem("Load Style Sheet")
			AddHandler loadStyleSheetItem.Click, AddressOf LoadStyleSheet_Click

			Dim saveStyleSheetItem As RadMenuItem = New RadMenuItem("Save Style Sheet")
			AddHandler saveStyleSheetItem.Click, AddressOf SaveStyleSheet_Click

			externalStyleButton.Items.Add(loadStyleSheetItem)
			externalStyleButton.Items.Add(saveStyleSheetItem)

			Dim group As RadRibbonBarButtonGroup = New RadRibbonBarButtonGroup()
			group.Orientation = Orientation.Vertical

			group.Items.Add(defaultStyleButton)
			group.Items.Add(customStyleButton)
			group.Items.Add(externalStyleButton)

			customStylesGroup.Items.Add(group)

			homeTab.Items.Insert(0, customStylesGroup)
		End Sub

		Private Sub LoadStyleSheet_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim ofd As OpenFileDialog = New OpenFileDialog()
			ofd.Filter = "Xaml Files|*.xaml"
			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Using stream = ofd.OpenFile()
                    Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
					stylesheet.ApplyStylesheetToDocument(Me.radRichTextEditor1.Document)
				End Using
			End If
		End Sub

		Private Sub SaveStyleSheet_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim sfd As SaveFileDialog = New SaveFileDialog()
			sfd.Filter = "Xaml Files|*.xaml"
			If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Using stream = sfd.OpenFile()
					Dim stylesheet As Stylesheet = New Stylesheet()
					stylesheet.ExtractStylesheetFromDocument(Me.radRichTextEditor1.Document)
					XamlFormatProvider.SaveStylesheet(stylesheet, stream)
				End Using
			End If
		End Sub

		Private Sub loadDefaultStyleSheet_Click(ByVal sender As Object, ByVal e As EventArgs)
			LoadStyleSheetFromResource(DefaultStyleSheetPath)
		End Sub

		Private Sub loadCustomStyleSheet_Click(ByVal sender As Object, ByVal e As EventArgs)
			LoadStyleSheetFromResource(CustomStyleSheetPath)
		End Sub

		Private Sub LoadStyleSheetFromResource(ByVal rsourcePath As String)
			Using stream = GetType(Form1).Assembly.GetManifestResourceStream(rsourcePath)
				Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
				stylesheet.ApplyStylesheetToDocument(Me.radRichTextEditor1.Document)
			End Using
		End Sub

		#End Region

	End Class
End Namespace
