Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Editors.ButtonTextBox
    Partial Public Class Form1
        Inherits ExamplesForm

        Private glyphs As List(Of String) = New List(Of String)()

        Public Sub New()
            Me.InitializeComponent()
            Me.glyphs.Add("")
            Me.glyphs.Add("")
            Me.glyphs.Add("")
            Me.glyphs.Add("")
            Me.SetupButtons()
            Me.CreateButtonElement(Me.glyphs(0))
            Me.radButtonTextBox1.AutoSize = False
            Me.radButtonTextBox1.Text = String.Empty
        End Sub

        Public Sub SetupButtons()
            For Each glyph As String In Me.glyphs
                Dim button As RadButton = New RadButton()
                button.DisplayStyle = DisplayStyle.Text
                button.ButtonElement.TextElement.CustomFont = "TelerikWebUI"
                button.ButtonElement.TextElement.CustomFontSize = 18
                button.ButtonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias
                button.Text = glyph
                button.Size = New Size(56, 56)
                button.Margin = New Padding(12)
                Me.doubleBufferedFlowLayoutPanel1.Controls.Add(button)
                button.Scale(Me.radButtonTextBox1.RootElement.DpiScaleFactor)
                AddHandler button.Click, AddressOf Button_Click
            Next
        End Sub

        Private Sub CreateButtonElement(ByVal text As String)
            Dim radButtonElement As RadButtonElement = New RadButtonElement()
            radButtonElement.DisplayStyle = DisplayStyle.Text
            radButtonElement.TextElement.CustomFont = "TelerikWebUI"
            radButtonElement.TextElement.CustomFontSize = 12
            radButtonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias
            radButtonElement.Text = text
            AddHandler radButtonElement.Click, AddressOf RadButtonElement_Click

            If Me.radRadioButton1.IsChecked Then
                Me.radButtonTextBox1.RightButtonItems.Add(radButtonElement)
            Else
                Me.radButtonTextBox1.LeftButtonItems.Add(radButtonElement)
            End If
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CreateButtonElement((CType(sender, RadButton)).Text)
        End Sub

        Private Sub RadButtonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://www.google.com/search?q=" & Me.radButtonTextBox1.Text.TrimEnd())
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radButtonTextBox1.RightButtonItems.Clear()
            Me.radButtonTextBox1.LeftButtonItems.Clear()
        End Sub
    End Class
End Namespace
