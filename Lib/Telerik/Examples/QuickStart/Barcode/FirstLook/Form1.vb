Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Barcode.Symbology

Namespace Telerik.Examples.WinControls.Barcode.FirstLook

    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.ScrollableArea.BackColor = Color.Transparent
            Me.BackgroundImage = My.Resources.bcard_export
            Me.BackgroundImageLayout = ImageLayout.Center
            Dim qRCode As QRCode = New QRCode(CodeMode.Byte, 9, ErrorCorrectionLevel.L, ECIMode.UTF8, FNC1Mode.None, Nothing)
            qRCode.[Module] = 2
            Me.radBarcode1.Symbology = qRCode
            Me.radBarcode1.Value = "BEGIN:VCARD" &
"VERSION:2.1" &
"N:Steven Buchannan" &
"TEL;WORK;VOICE:+44.71.555.48.48" &
"ADR;WORK:;;14 Garrett Hill, SW 1 8JR, London, UK" &
"EMAIL;PREF;INTERNET:buchannan@company.com" &
"END:VCARD"
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)

            If Me.radBarcode1 IsNot Nothing Then
                Me.CenterControl(Me.radBarcode1)
                Me.radBarcode1.Left -= 130
                Me.radBarcode1.Top += 60
            End If
        End Sub
    End Class
End Namespace