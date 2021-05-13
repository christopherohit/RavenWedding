Namespace Telerik.Examples.WinControls.Forms.TaskDialog.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxExpander = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBoxPageText = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabelVerification = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelText = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelProgressbar = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelCaption = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelIcon = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelHeading = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelExpander = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelFootnote = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxCaption = New Telerik.WinControls.UI.RadTextBox()
            Me.radDropDownListIcon = New Telerik.WinControls.UI.RadDropDownList()
            Me.radTextBoxHeading = New Telerik.WinControls.UI.RadTextBox()
            Me.radDropDownListProgressbarState = New Telerik.WinControls.UI.RadDropDownList()
            Me.radTextBoxVerification = New Telerik.WinControls.UI.RadTextBox()
            Me.radTextBoxFootnote = New Telerik.WinControls.UI.RadTextBox()
            Me.radCheckBoxRadioButtons = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCommandLinkButtons = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckedDropDownListCommandButtons = New Telerik.WinControls.UI.RadCheckedDropDownList()
            Me.radButtonShowDialog = New Telerik.WinControls.UI.RadButton()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxExpander, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxPageText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelVerification, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelProgressbar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelHeading, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelExpander, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelFootnote, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxHeading, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListProgressbarState, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxVerification, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxFootnote, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxRadioButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCommandLinkButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckedDropDownListCommandButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonShowDialog, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(115, 71)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(2)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(756, 430)
            Me.settingsPanel.Location = New System.Drawing.Point(1186, 16)
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 8)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxExpander, 1, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxPageText, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelVerification, 0, 6)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelText, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelProgressbar, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelCaption, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelIcon, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelHeading, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelExpander, 1, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelFootnote, 1, 6)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxCaption, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radDropDownListIcon, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxHeading, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radDropDownListProgressbarState, 1, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxVerification, 0, 7)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxFootnote, 1, 7)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxRadioButtons, 1, 8)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckBoxCommandLinkButtons, 1, 9)
            Me.tableLayoutPanel1.Controls.Add(Me.radCheckedDropDownListCommandButtons, 0, 9)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonShowDialog, 1, 11)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 13
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.33568F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.33568F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.33568F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67136F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.33568F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.169014F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.802815F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(752, 426)
            Me.tableLayoutPanel1.TabIndex = 0
            Me.radLabel1.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabel1.AutoSize = False
            Me.radLabel1.Location = New System.Drawing.Point(9, 295)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(358, 31)
            Me.radLabel1.TabIndex = 17
            Me.radLabel1.Text = "Choose Command buttons"
            Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radTextBoxExpander.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxExpander.Location = New System.Drawing.Point(388, 164)
            Me.radTextBoxExpander.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxExpander.Multiline = True
            Me.radTextBoxExpander.Name = "radTextBoxExpander"
            Me.radTextBoxExpander.RootElement.StretchVertically = True
            Me.radTextBoxExpander.Size = New System.Drawing.Size(352, 61)
            Me.radTextBoxExpander.TabIndex = 12
            Me.radTextBoxExpander.Text = "This is the alternative of the details text compared to a message box. It can be " & "positioned after the text or after the footnote."
            Me.radTextBoxPageText.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxPageText.Location = New System.Drawing.Point(12, 164)
            Me.radTextBoxPageText.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxPageText.Multiline = True
            Me.radTextBoxPageText.Name = "radTextBoxPageText"
            Me.radTextBoxPageText.RootElement.StretchVertically = True
            Me.radTextBoxPageText.Size = New System.Drawing.Size(352, 61)
            Me.radTextBoxPageText.TabIndex = 11
            Me.radTextBoxPageText.Text = "The Telerik TaskDialog for WinForms is a window that allows users to perform a co" & "mmand, ask a question, provide them with information or indicate the progress of" & " an ongoing task. "
            Me.radLabelVerification.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelVerification.AutoSize = False
            Me.radLabelVerification.Location = New System.Drawing.Point(9, 228)
            Me.radLabelVerification.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelVerification.Name = "radLabelVerification"
            Me.radLabelVerification.Size = New System.Drawing.Size(358, 24)
            Me.radLabelVerification.TabIndex = 5
            Me.radLabelVerification.Text = "Verification checkbox text"
            Me.radLabelVerification.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelText.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelText.AutoSize = False
            Me.radLabelText.Location = New System.Drawing.Point(9, 137)
            Me.radLabelText.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelText.Name = "radLabelText"
            Me.radLabelText.Size = New System.Drawing.Size(358, 24)
            Me.radLabelText.TabIndex = 4
            Me.radLabelText.Text = "Text"
            Me.radLabelText.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelProgressbar.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelProgressbar.AutoSize = False
            Me.radLabelProgressbar.Location = New System.Drawing.Point(385, 70)
            Me.radLabelProgressbar.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelProgressbar.Name = "radLabelProgressbar"
            Me.radLabelProgressbar.Size = New System.Drawing.Size(358, 24)
            Me.radLabelProgressbar.TabIndex = 3
            Me.radLabelProgressbar.Text = "ProgressBar State"
            Me.radLabelProgressbar.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelCaption.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelCaption.AutoSize = False
            Me.radLabelCaption.Location = New System.Drawing.Point(9, 3)
            Me.radLabelCaption.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelCaption.Name = "radLabelCaption"
            Me.radLabelCaption.Size = New System.Drawing.Size(358, 24)
            Me.radLabelCaption.TabIndex = 0
            Me.radLabelCaption.Text = "Form Caption"
            Me.radLabelCaption.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelIcon.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelIcon.AutoSize = False
            Me.radLabelIcon.Location = New System.Drawing.Point(385, 3)
            Me.radLabelIcon.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelIcon.Name = "radLabelIcon"
            Me.radLabelIcon.Size = New System.Drawing.Size(358, 24)
            Me.radLabelIcon.TabIndex = 1
            Me.radLabelIcon.Text = "Icon"
            Me.radLabelIcon.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelHeading.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelHeading.AutoSize = False
            Me.radLabelHeading.Location = New System.Drawing.Point(9, 70)
            Me.radLabelHeading.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelHeading.Name = "radLabelHeading"
            Me.radLabelHeading.Size = New System.Drawing.Size(358, 24)
            Me.radLabelHeading.TabIndex = 2
            Me.radLabelHeading.Text = "Heading"
            Me.radLabelHeading.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelExpander.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelExpander.AutoSize = False
            Me.radLabelExpander.Location = New System.Drawing.Point(385, 137)
            Me.radLabelExpander.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelExpander.Name = "radLabelExpander"
            Me.radLabelExpander.Size = New System.Drawing.Size(358, 24)
            Me.radLabelExpander.TabIndex = 5
            Me.radLabelExpander.Text = "Expander text"
            Me.radLabelExpander.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radLabelFootnote.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelFootnote.AutoSize = False
            Me.radLabelFootnote.Location = New System.Drawing.Point(385, 228)
            Me.radLabelFootnote.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
            Me.radLabelFootnote.Name = "radLabelFootnote"
            Me.radLabelFootnote.Size = New System.Drawing.Size(358, 24)
            Me.radLabelFootnote.TabIndex = 6
            Me.radLabelFootnote.Text = "Footnote text"
            Me.radLabelFootnote.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radTextBoxCaption.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxCaption.Location = New System.Drawing.Point(12, 38)
            Me.radTextBoxCaption.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxCaption.Name = "radTextBoxCaption"
            Me.radTextBoxCaption.Size = New System.Drawing.Size(352, 20)
            Me.radTextBoxCaption.TabIndex = 7
            Me.radTextBoxCaption.Text = "This is the caption of the form."
            Me.radDropDownListIcon.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radDropDownListIcon.DropDownAnimationEnabled = False
            Me.radDropDownListIcon.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListIcon.Location = New System.Drawing.Point(388, 38)
            Me.radDropDownListIcon.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radDropDownListIcon.Name = "radDropDownListIcon"
            Me.radDropDownListIcon.Size = New System.Drawing.Size(352, 20)
            Me.radDropDownListIcon.TabIndex = 8
            Me.radDropDownListIcon.Text = "radDropDownList1"
            Me.radTextBoxHeading.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxHeading.Location = New System.Drawing.Point(12, 105)
            Me.radTextBoxHeading.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxHeading.Name = "radTextBoxHeading"
            Me.radTextBoxHeading.Size = New System.Drawing.Size(352, 20)
            Me.radTextBoxHeading.TabIndex = 9
            Me.radTextBoxHeading.Text = "This is the page heading."
            Me.radDropDownListProgressbarState.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radDropDownListProgressbarState.DropDownAnimationEnabled = False
            Me.radDropDownListProgressbarState.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListProgressbarState.Location = New System.Drawing.Point(388, 105)
            Me.radDropDownListProgressbarState.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radDropDownListProgressbarState.Name = "radDropDownListProgressbarState"
            Me.radDropDownListProgressbarState.Size = New System.Drawing.Size(352, 20)
            Me.radDropDownListProgressbarState.TabIndex = 10
            Me.radDropDownListProgressbarState.Text = "radDropDownList2"
            Me.radTextBoxVerification.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxVerification.Location = New System.Drawing.Point(12, 263)
            Me.radTextBoxVerification.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxVerification.Name = "radTextBoxVerification"
            Me.radTextBoxVerification.Size = New System.Drawing.Size(352, 20)
            Me.radTextBoxVerification.TabIndex = 13
            Me.radTextBoxVerification.Text = "Don't show again."
            Me.radTextBoxFootnote.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxFootnote.Location = New System.Drawing.Point(388, 263)
            Me.radTextBoxFootnote.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radTextBoxFootnote.Name = "radTextBoxFootnote"
            Me.radTextBoxFootnote.Size = New System.Drawing.Size(352, 20)
            Me.radTextBoxFootnote.TabIndex = 14
            Me.radTextBoxFootnote.Text = "This is the fottnote."
            Me.radCheckBoxRadioButtons.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radCheckBoxRadioButtons.AutoSize = False
            Me.radCheckBoxRadioButtons.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxRadioButtons.Location = New System.Drawing.Point(387, 295)
            Me.radCheckBoxRadioButtons.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
            Me.radCheckBoxRadioButtons.Name = "radCheckBoxRadioButtons"
            Me.radCheckBoxRadioButtons.Size = New System.Drawing.Size(354, 31)
            Me.radCheckBoxRadioButtons.TabIndex = 15
            Me.radCheckBoxRadioButtons.Text = "Show radio buttons"
            Me.radCheckBoxRadioButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radCheckBoxCommandLinkButtons.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radCheckBoxCommandLinkButtons.AutoSize = False
            Me.radCheckBoxCommandLinkButtons.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxCommandLinkButtons.Location = New System.Drawing.Point(387, 332)
            Me.radCheckBoxCommandLinkButtons.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
            Me.radCheckBoxCommandLinkButtons.Name = "radCheckBoxCommandLinkButtons"
            Me.radCheckBoxCommandLinkButtons.Size = New System.Drawing.Size(354, 31)
            Me.radCheckBoxCommandLinkButtons.TabIndex = 16
            Me.radCheckBoxCommandLinkButtons.Text = "Show CommandLink buttons"
            Me.radCheckBoxCommandLinkButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radCheckedDropDownListCommandButtons.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radCheckedDropDownListCommandButtons.DropDownAnimationEnabled = False
            Me.radCheckedDropDownListCommandButtons.Location = New System.Drawing.Point(12, 337)
            Me.radCheckedDropDownListCommandButtons.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.radCheckedDropDownListCommandButtons.Name = "radCheckedDropDownListCommandButtons"
            Me.radCheckedDropDownListCommandButtons.Size = New System.Drawing.Size(352, 20)
            Me.radCheckedDropDownListCommandButtons.TabIndex = 18
            Me.radButtonShowDialog.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.radButtonShowDialog.Location = New System.Drawing.Point(600, 382)
            Me.radButtonShowDialog.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
            Me.radButtonShowDialog.Name = "radButtonShowDialog"
            Me.radButtonShowDialog.Size = New System.Drawing.Size(140, 31)
            Me.radButtonShowDialog.TabIndex = 19
            Me.radButtonShowDialog.Text = "Show Dialog"
            AddHandler Me.radButtonShowDialog.Click, New System.EventHandler(AddressOf Me.RadButtonShowDialog_Click)
            Me.radPanel1.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(2, 2)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(752, 426)
            Me.radPanel1.TabIndex = 1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1456, 796)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxExpander, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxPageText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelVerification, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelProgressbar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelCaption, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelIcon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelHeading, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelExpander, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelFootnote, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxCaption, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListIcon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxHeading, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListProgressbarState, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxVerification, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxFootnote, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxRadioButtons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCommandLinkButtons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckedDropDownListCommandButtons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonShowDialog, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabelProgressbar As Telerik.WinControls.UI.RadLabel
        Private radLabelCaption As Telerik.WinControls.UI.RadLabel
        Private radLabelIcon As Telerik.WinControls.UI.RadLabel
        Private radLabelHeading As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radTextBoxExpander As Telerik.WinControls.UI.RadTextBox
        Private radTextBoxPageText As Telerik.WinControls.UI.RadTextBox
        Private radLabelVerification As Telerik.WinControls.UI.RadLabel
        Private radLabelText As Telerik.WinControls.UI.RadLabel
        Private radLabelExpander As Telerik.WinControls.UI.RadLabel
        Private radLabelFootnote As Telerik.WinControls.UI.RadLabel
        Private radTextBoxCaption As Telerik.WinControls.UI.RadTextBox
        Private radDropDownListIcon As Telerik.WinControls.UI.RadDropDownList
        Private radTextBoxHeading As Telerik.WinControls.UI.RadTextBox
        Private radDropDownListProgressbarState As Telerik.WinControls.UI.RadDropDownList
        Private radTextBoxVerification As Telerik.WinControls.UI.RadTextBox
        Private radTextBoxFootnote As Telerik.WinControls.UI.RadTextBox
        Private radCheckBoxRadioButtons As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxCommandLinkButtons As Telerik.WinControls.UI.RadCheckBox
        Private radCheckedDropDownListCommandButtons As Telerik.WinControls.UI.RadCheckedDropDownList
        Private radButtonShowDialog As Telerik.WinControls.UI.RadButton
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace
