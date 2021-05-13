Imports System
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.SetupLayout()
        End Sub

        Private Sub Element_PreviewFontChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetFont(radFontDropDownList1.FontDropDownList.PreviewFont)
        End Sub

        Private Sub RadFontDropDownList1_SelectedFontChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetFont(radFontDropDownList1.FontDropDownList.SelectedFont)
        End Sub

        Public Sub SetFont(ByVal fontName As String)
            Dim ff As FontFamily = New FontFamily(fontName)

            If ff.IsStyleAvailable(FontStyle.Regular) Then
                Dim font As Font = New Font(ff.Name, 10, FontStyle.Regular)
                Me.radLabel1.Font = font
            Else

                For Each style As FontStyle In [Enum].GetValues(GetType(FontStyle))

                    If ff.IsStyleAvailable(style) Then
                        Dim font As Font = New Font(ff.Name, 10, style)
                        Me.radLabel1.Font = font
                        Exit For
                    End If
                Next
            End If
        End Sub

        Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radFontDropDownList1.FontDropDownList.ShowRecentlyUsedFonts = radCheckBox1.Checked
        End Sub

        Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radFontDropDownList1.FontDropDownList.RecentlyUsedItemsCount = CInt(Me.radSpinEditor1.Value)
        End Sub

        Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radFontDropDownList1.FontDropDownList.SelectOnHover = Me.radCheckBox2.Checked
        End Sub

        Public Sub SetupLayout()
            Me.radFontDropDownList1.FontDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            AddHandler Me.radFontDropDownList1.FontDropDownList.SelectedFontChanged, AddressOf RadFontDropDownList1_SelectedFontChanged
            Me.radFontDropDownList1.FontDropDownList.SelectedFont = "Segoe UI"
            AddHandler Me.radFontDropDownList1.FontDropDownList.PreviewFontChanged, AddressOf Element_PreviewFontChanged
            Me.radFontDropDownList1.FontDropDownList.SelectOnHover = True
            Me.commandBarButton1.CustomFont = "TelerikWebUI"
            Me.commandBarButton2.CustomFont = "TelerikWebUI"
            Me.commandBarButton5.CustomFont = "TelerikWebUI"
            Me.commandBarButton6.CustomFont = "TelerikWebUI"
            Me.commandBarButton7.CustomFont = "TelerikWebUI"
            Me.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.OnThemeChanged()
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            Select Case Me.CurrentThemeName
                Case "Crystal"
                    SetColor(Color.FromArgb(0, 96, 207), Color.FromArgb(180, 0, 0, 0), Color.FromArgb(45, 45, 45), Color.FromArgb(0, 96, 207), Color.FromArgb(230, 241, 247), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(211, 211, 211), Color.FromArgb(234, 234, 234))
                Case "CrystalDark"
                    SetColor(Color.FromArgb(0, 96, 207), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(124, 183, 249), Color.FromArgb(52, 52, 52), Color.FromArgb(255, 255, 255), Color.FromArgb(37, 37, 37), Color.FromArgb(77, 77, 77), Color.FromArgb(52, 52, 52))
                Case "FluentDark"
                    SetColor(Color.FromArgb(0, 153, 188), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 191, 232), Color.FromArgb(43, 43, 43), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(76, 76, 76), Color.FromArgb(0, 0, 0))
                Case "ControlDefault"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 191, 232), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(233, 240, 249), Color.FromArgb(110, 153, 210), Color.FromArgb(191, 219, 255))
                Case "Fluent"
                    SetColor(Color.FromArgb(0, 153, 188), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 191, 232), Color.FromArgb(242, 242, 242), Color.FromArgb(0, 0, 0), Color.FromArgb(249, 249, 249), Color.FromArgb(197, 197, 197), Color.FromArgb(197, 197, 197))
                Case "Aqua"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(45, 137, 220), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(236, 236, 236), Color.FromArgb(114, 114, 114), Color.FromArgb(139, 139, 139))
                Case "Office2013Dark", "Office2013Light"
                    SetColor(Color.FromArgb(0, 114, 198), Color.FromArgb(0, 0, 0), Color.FromArgb(68, 68, 68), Color.FromArgb(0, 114, 198), Color.FromArgb(205, 230, 247), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(198, 198, 198), Color.FromArgb(255, 255, 255))
                Case "Breeze"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 50, 152), Color.FromArgb(240, 246, 254), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(207, 207, 207), Color.FromArgb(255, 255, 255))
                Case "Windows8"
                    SetColor(Color.FromArgb(0, 102, 204), Color.FromArgb(0, 0, 0), Color.FromArgb(68, 68, 68), Color.FromArgb(0, 102, 204), Color.FromArgb(209, 232, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(217, 217, 217), Color.FromArgb(239, 239, 239))
                Case "VisualStudio2012Dark"
                    SetColor(Color.FromArgb(241, 241, 241), Color.FromArgb(255, 255, 255), Color.FromArgb(241, 241, 241), Color.FromArgb(0, 122, 204), Color.FromArgb(62, 62, 66), Color.FromArgb(241, 241, 241), Color.FromArgb(45, 45, 48), Color.FromArgb(63, 63, 70), Color.FromArgb(37, 37, 38))
                Case "VisualStudio2012Light"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 122, 204), Color.FromArgb(239, 239, 242), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(204, 206, 219), Color.FromArgb(239, 239, 242))
                Case "TelerikMetro"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(128, 181, 2), Color.FromArgb(244, 246, 236), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255))
                Case "TelerikMetroTouch"
                    SetColor(Color.FromArgb(128, 181, 2), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(128, 181, 2), Color.FromArgb(244, 246, 236), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255))
                Case "TelerikMetroBlue"
                    SetColor(Color.FromArgb(27, 161, 226), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(27, 161, 226), Color.FromArgb(243, 248, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255))
                Case "Office2010Black"
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(216, 80, 0), Color.FromArgb(224, 224, 224), Color.FromArgb(0, 0, 0), Color.FromArgb(207, 207, 207), Color.FromArgb(110, 110, 110), Color.FromArgb(146, 146, 146))
                Case "Office2010Silver"
                    SetColor(Color.FromArgb(39, 45, 52), Color.FromArgb(0, 0, 0), Color.FromArgb(39, 45, 52), Color.FromArgb(216, 80, 0), Color.FromArgb(246, 247, 248), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(183, 187, 192), Color.FromArgb(225, 228, 232))
                Case "HighContrastBlack"
                    SetColor(Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 128, 0), Color.FromArgb(169, 169, 169), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0))
                Case "Windows7"
                    SetColor(Color.FromArgb(0, 51, 153), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 51, 153), Color.FromArgb(32, 136, 220), Color.FromArgb(225, 234, 245), Color.FromArgb(0, 0, 0), Color.FromArgb(250, 254, 255), Color.FromArgb(157, 178, 199), Color.FromArgb(255, 255, 255))
                Case "Material"
                    SetColor(Color.FromArgb(63, 81, 181), Color.FromArgb(0, 0, 0), Color.FromArgb(63, 81, 181), Color.FromArgb(255, 145, 0), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255))
                Case "Office2007Silver"
                    SetColor(Color.FromArgb(0, 28, 85), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 28, 85), Color.FromArgb(251, 105, 0), Color.FromArgb(220, 224, 231), Color.FromArgb(0, 0, 0), Color.FromArgb(243, 246, 251), Color.FromArgb(185, 188, 194), Color.FromArgb(220, 224, 231))
                Case "Office2007Black"
                    SetColor(Color.FromArgb(86, 87, 91), Color.FromArgb(0, 0, 0), Color.FromArgb(86, 87, 91), Color.FromArgb(251, 105, 0), Color.FromArgb(220, 224, 231), Color.FromArgb(0, 0, 0), Color.FromArgb(227, 229, 234), Color.FromArgb(77, 77, 77), Color.FromArgb(240, 241, 242))
                Case "Desert"
                    SetColor(Color.FromArgb(74, 72, 58), Color.FromArgb(74, 72, 58), Color.FromArgb(74, 72, 58), Color.FromArgb(196, 97, 36), Color.FromArgb(246, 246, 237), Color.FromArgb(74, 72, 58), Color.FromArgb(255, 255, 255), Color.FromArgb(138, 137, 119), Color.FromArgb(221, 221, 208))
                Case "Office2010Blue"
                    SetColor(Color.FromArgb(15, 76, 144), Color.FromArgb(0, 0, 0), Color.FromArgb(15, 76, 144), Color.FromArgb(216, 80, 0), Color.FromArgb(239, 246, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(191, 215, 245), Color.FromArgb(239, 246, 255))
                Case "MaterialTeal"
                    SetColor(Color.FromArgb(0, 150, 136), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 150, 136), Color.FromArgb(255, 82, 82), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255))
                Case "MaterialPink"
                    SetColor(Color.FromArgb(233, 30, 99), Color.FromArgb(0, 0, 0), Color.FromArgb(233, 30, 99), Color.FromArgb(68, 138, 255), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255))
                Case "MaterialBlueGrey"
                    SetColor(Color.FromArgb(96, 125, 139), Color.FromArgb(0, 0, 0), Color.FromArgb(96, 125, 139), Color.FromArgb(0, 230, 118), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255))
            End Select

            If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                Me.doubleBufferedTableLayoutPanel1.RowStyles(6).Height = 1.0F
            End If
        End Sub

        Public Sub SetColor(ByVal mainLabel As Color, ByVal secondLabel As Color, ByVal thirdLabel As Color, ByVal fourtLabel As Color, ByVal textBackColor As Color, ByVal textForeColor As Color, ByVal panelColor As Color, ByVal borderColor As Color, ByVal paddingColor As Color)
            Me.radLabel3.ForeColor = mainLabel
            Me.radLabel4.ForeColor = secondLabel
            Me.radLabel5.ForeColor = thirdLabel
            Me.radLabel1.BackColor = textBackColor
            Me.radLabel6.ForeColor = fourtLabel
            Me.radLabel1.ForeColor = textForeColor
            Me.doubleBufferedTableLayoutPanel1.BackColor = panelColor
            Me.borderPanel.PanelElement.PanelBorder.ForeColor = borderColor
        End Sub
    End Class
End Namespace
