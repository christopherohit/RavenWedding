Namespace Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.commandBarButton1 = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarButton2 = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.radFontDropDownList1 = New Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList.FontDropDownListCommandBarItem()
            Me.sizeDDL = New Telerik.WinControls.UI.CommandBarDropDownList()
            Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.commandBarButton5 = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarButton6 = New Telerik.WinControls.UI.CommandBarButton()
            Me.commandBarButton7 = New Telerik.WinControls.UI.CommandBarButton()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.borderPanel = New Telerik.WinControls.UI.RadPanel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditor1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCommandBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.borderPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.borderPanel.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(837, 198)
            Me.settingsPanel.Margin = New System.Windows.Forms.Padding(4)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBox2)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditor1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel2)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBox1)
            Me.settingsPanel.PanelContainer.Margin = New System.Windows.Forms.Padding(4)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(291, 295)
            Me.settingsPanel.Size = New System.Drawing.Size(291, 295)
            Me.optionsLabel.Location = New System.Drawing.Point(5, 5)
            Me.optionsLabel.Margin = New System.Windows.Forms.Padding(4)
            Me.radLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.radLabel1.AutoSize = False
            Me.radLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((230)))))), (CInt(((CByte((241)))))), (CInt(((CByte((247)))))))
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabel1, 2)
            Me.radLabel1.Location = New System.Drawing.Point(30, 400)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(30, 4, 30, 4)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radLabel1.Size = New System.Drawing.Size(1949, 120)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "The RadFontDropDpwnList enumerates and shows a preview of all installed fonts. With this control, you can easily provide your end users with the ability to change the Font not only in the text editing controls but in any other control where such change is needed."
            Me.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox1.Location = New System.Drawing.Point(5, 59)
            Me.radCheckBox1.Margin = New System.Windows.Forms.Padding(4)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(152, 18)
            Me.radCheckBox1.TabIndex = 1
            Me.radCheckBox1.Text = "Show Recently Used Items"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox1.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBox1_ToggleStateChanged)
            Me.radLabel2.Location = New System.Drawing.Point(0, 169)
            Me.radLabel2.Margin = New System.Windows.Forms.Padding(4)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(141, 18)
            Me.radLabel2.TabIndex = 2
            Me.radLabel2.Text = "Recently Used Items Count"
            Me.radSpinEditor1.Location = New System.Drawing.Point(5, 208)
            Me.radSpinEditor1.Margin = New System.Windows.Forms.Padding(4)
            Me.radSpinEditor1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.radSpinEditor1.Name = "radSpinEditor1"
            Me.radSpinEditor1.NullableValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditor1.Size = New System.Drawing.Size(183, 20)
            Me.radSpinEditor1.TabIndex = 3
            Me.radSpinEditor1.Value = New Decimal(New Integer() {10, 0, 0, 0})
            AddHandler Me.radSpinEditor1.ValueChanged, New System.EventHandler(AddressOf Me.radSpinEditor1_ValueChanged)
            Me.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox2.Location = New System.Drawing.Point(5, 98)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(140, 18)
            Me.radCheckBox2.TabIndex = 4
            Me.radCheckBox2.Text = "Preview on MouseMove"
            Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox2.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBox2_ToggleStateChanged)
            Me.doubleBufferedTableLayoutPanel1.BackColor = System.Drawing.Color.White
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCommandBar1, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel5, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel6, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
            Me.doubleBufferedTableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 7
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.428571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.285714F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.142858F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.28572F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.85714F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75456F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(2009, 1155)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 3
            Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((96)))))), (CInt(((CByte((207)))))))
            Me.radLabel3.Location = New System.Drawing.Point(30, 17)
            Me.radLabel3.Margin = New System.Windows.Forms.Padding(30, 17, 2, 2)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(262, 28)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "MY EXAMPLE DESCRIPTION"
            CType((Me.radLabel3.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = "MY EXAMPLE DESCRIPTION"
            CType((Me.radLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "Roboto"
            CType((Me.radLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFontSize = 14.5F
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCommandBar1, 2)
            Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radCommandBar1.Location = New System.Drawing.Point(30, 166)
            Me.radCommandBar1.Margin = New System.Windows.Forms.Padding(30, 0, 30, 0)
            Me.radCommandBar1.Name = "radCommandBar1"
            Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.commandBarRowElement1})
            Me.radCommandBar1.Size = New System.Drawing.Size(1949, 30)
            Me.radCommandBar1.TabIndex = 0
            Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.commandBarRowElement1.Name = "commandBarRowElement1"
            Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.commandBarStripElement1})
            Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
            Me.commandBarStripElement1.EnableDragging = False
            Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.commandBarButton1, Me.commandBarButton2, Me.commandBarSeparator1, Me.radFontDropDownList1, Me.sizeDDL, Me.commandBarSeparator2, Me.commandBarButton5, Me.commandBarButton6, Me.commandBarButton7})
            Me.commandBarStripElement1.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.commandBarStripElement1.Name = "commandBarStripElement1"
            Me.commandBarStripElement1.StretchHorizontally = True
            Me.commandBarButton1.DisplayName = "commandBarButton1"
            Me.commandBarButton1.DrawImage = False
            Me.commandBarButton1.DrawText = True
            Me.commandBarButton1.Name = "commandBarButton1"
            Me.commandBarButton1.Text = ""
            Me.commandBarButton2.DisplayName = "commandBarButton2"
            Me.commandBarButton2.DrawImage = False
            Me.commandBarButton2.DrawText = True
            Me.commandBarButton2.Name = "commandBarButton2"
            Me.commandBarButton2.Text = ""
            Me.commandBarSeparator1.DisplayName = "commandBarSeparator1"
            Me.commandBarSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.commandBarSeparator1.Name = "commandBarSeparator1"
            Me.commandBarSeparator1.VisibleInOverflowMenu = False
            Me.radFontDropDownList1.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.radFontDropDownList1.Name = "radFontDropDownList1"
            Me.sizeDDL.DisplayName = "commandBarButton4"
            Me.sizeDDL.DropDownAnimationEnabled = True
            Me.sizeDDL.MaxDropDownItems = 0
            Me.sizeDDL.MaxSize = New System.Drawing.Size(50, 0)
            Me.sizeDDL.Name = "sizeDDL"
            Me.sizeDDL.Text = "12"
            Me.commandBarSeparator2.DisplayName = "commandBarSeparator2"
            Me.commandBarSeparator2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.commandBarSeparator2.Name = "commandBarSeparator2"
            Me.commandBarSeparator2.VisibleInOverflowMenu = False
            Me.commandBarButton5.DisplayName = "commandBarButton5"
            Me.commandBarButton5.DrawImage = False
            Me.commandBarButton5.DrawText = True
            Me.commandBarButton5.Name = "commandBarButton5"
            Me.commandBarButton5.Text = ""
            Me.commandBarButton6.DisplayName = "commandBarButton6"
            Me.commandBarButton6.DrawImage = False
            Me.commandBarButton6.DrawText = True
            Me.commandBarButton6.Name = "commandBarButton6"
            Me.commandBarButton6.Text = ""
            Me.commandBarButton7.DisplayName = "commandBarButton7"
            Me.commandBarButton7.DrawImage = False
            Me.commandBarButton7.DrawText = True
            Me.commandBarButton7.Name = "commandBarButton7"
            Me.commandBarButton7.Text = ""
            Me.radLabel4.Location = New System.Drawing.Point(30, 94)
            Me.radLabel4.Margin = New System.Windows.Forms.Padding(30, 2, 2, 2)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(264, 20)
            Me.radLabel4.TabIndex = 1
            Me.radLabel4.Text = "Controls / Editors / RadFontDropDownList"
            CType((Me.radLabel4.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = "Controls / Editors / RadFontDropDownList"
            CType((Me.radLabel4.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "Roboto"
            CType((Me.radLabel4.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFontSize = 10.0F
            Me.radLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.radLabel5.Location = New System.Drawing.Point(30, 318)
            Me.radLabel5.Margin = New System.Windows.Forms.Padding(30, 2, 2, 14)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(450, 23)
            Me.radLabel5.TabIndex = 2
            Me.radLabel5.Text = "RadFontDropDownList shows a preview of all installed fonts"
            CType((Me.radLabel5.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = "RadFontDropDownList shows a preview of all installed fonts"
            CType((Me.radLabel5.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "Roboto Medium"
            Me.radLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((96)))))), (CInt(((CByte((207)))))))
            Me.radLabel6.Location = New System.Drawing.Point(1667, 320)
            Me.radLabel6.Margin = New System.Windows.Forms.Padding(2, 2, 30, 18)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(312, 17)
            Me.radLabel6.TabIndex = 3
            Me.radLabel6.Text = "Change the font from RadFontDropDownList "
            Me.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType((Me.radLabel6.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType((Me.radLabel6.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = "Change the font from RadFontDropDownList "
            CType((Me.radLabel6.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType((Me.radLabel6.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "TelerikWebUI"
            CType((Me.radLabel6.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).CustomFontSize = 10.0F
            Me.borderPanel.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.borderPanel.Location = New System.Drawing.Point(0, 0)
            Me.borderPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.borderPanel.Name = "borderPanel"
            Me.borderPanel.Padding = New System.Windows.Forms.Padding(1)
            Me.borderPanel.Size = New System.Drawing.Size(2011, 1157)
            Me.borderPanel.TabIndex = 4
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.borderPanel)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.borderPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditor1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBox2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCommandBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.borderPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.borderPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private borderPanel As Telerik.WinControls.UI.RadPanel
        Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
        Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
        Private commandBarButton1 As Telerik.WinControls.UI.CommandBarButton
        Private commandBarButton2 As Telerik.WinControls.UI.CommandBarButton
        Private radFontDropDownList1 As FontDropDownListCommandBarItem
        Private sizeDDL As Telerik.WinControls.UI.CommandBarDropDownList
        Private commandBarButton5 As Telerik.WinControls.UI.CommandBarButton
        Private commandBarButton6 As Telerik.WinControls.UI.CommandBarButton
        Private commandBarButton7 As Telerik.WinControls.UI.CommandBarButton
        Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    End Class
End Namespace
