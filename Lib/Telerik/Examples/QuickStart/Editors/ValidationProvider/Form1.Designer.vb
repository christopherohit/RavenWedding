
Namespace Telerik.Examples.WinControls.Editors.ValidationProvider

    Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing _
                        AndAlso (Not (Me.components) Is Nothing)) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub
#Region "Windows Form Designer generated code"

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim radValidationRule1 As Telerik.WinControls.UI.RadValidationRule = New Telerik.WinControls.UI.RadValidationRule
            Dim radValidationRule2 As Telerik.WinControls.UI.RadValidationRule = New Telerik.WinControls.UI.RadValidationRule
            Dim radValidationRule3 As Telerik.WinControls.UI.RadValidationRule = New Telerik.WinControls.UI.RadValidationRule
            Dim radValidationRule4 As Telerik.WinControls.UI.RadValidationRule = New Telerik.WinControls.UI.RadValidationRule
            Dim radValidationRule5 As Telerik.WinControls.UI.RadValidationRule = New Telerik.WinControls.UI.RadValidationRule
            Me.FirstNameTextBox = New Telerik.WinControls.UI.RadTextBox
            Me.LastNameTextBox = New Telerik.WinControls.UI.RadTextBox
            Me.EmailMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.AmountMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.PhoneNumberMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.SocialSecurityNumberMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.IDNumberMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.DateMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox
            Me.editorsPanel = New Telerik.WinControls.UI.RadPanel
            Me.editorsScrollablePanel = New Telerik.WinControls.UI.RadScrollablePanel
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
            Me.headerPanel = New Telerik.WinControls.UI.RadPanel
            Me.highlightValidationErrorsLabel = New Telerik.WinControls.UI.RadLabel
            Me.fillOutLabel = New Telerik.WinControls.UI.RadLabel
            Me.firstNameLabel = New Telerik.WinControls.UI.RadLabel
            Me.lastNameLabel = New Telerik.WinControls.UI.RadLabel
            Me.phoneNumberLabel = New Telerik.WinControls.UI.RadLabel
            Me.ssnLabel = New Telerik.WinControls.UI.RadLabel
            Me.totalAmountLabel = New Telerik.WinControls.UI.RadLabel
            Me.dateLabel = New Telerik.WinControls.UI.RadLabel
            Me.idNumberLabel = New Telerik.WinControls.UI.RadLabel
            Me.emailLabel = New Telerik.WinControls.UI.RadLabel
            Me.buttonSubmit = New Telerik.WinControls.UI.RadButton
            Me.changeRequestLabel = New Telerik.WinControls.UI.RadLabel
            Me.radValidationProvider1 = New Telerik.WinControls.UI.RadValidationProvider(Me.components)
            Me.validationModeDropDownList = New Telerik.WinControls.UI.RadDropDownList
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FirstNameTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LastNameTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmailMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AmountMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PhoneNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SocialSecurityNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editorsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.editorsPanel.SuspendLayout()
            CType(Me.editorsScrollablePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.editorsScrollablePanel.PanelContainer.SuspendLayout()
            Me.editorsScrollablePanel.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.headerPanel.SuspendLayout()
            CType(Me.highlightValidationErrorsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fillOutLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.firstNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lastNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.phoneNumberLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ssnLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.totalAmountLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.idNumberLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emailLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.changeRequestLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.validationModeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.Controls.Add(Me.editorsPanel)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(80, 44)
            ' 
            ' 
            ' 
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(737, 509)
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(942, 59)
            Me.settingsPanel.Margin = New System.Windows.Forms.Padding(4)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            ' 
            ' optionsLabel
            ' 
            Me.optionsLabel.Location = New System.Drawing.Point(3, 63)
            Me.optionsLabel.Margin = New System.Windows.Forms.Padding(2)
            ' 
            ' FirstNameTextBox
            ' 
            Me.FirstNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.FirstNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.FirstNameTextBox, New System.Windows.Forms.Padding(2))
            Me.FirstNameTextBox.Location = New System.Drawing.Point(20, 141)
            Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.FirstNameTextBox.Name = "FirstNameTextBox"
            Me.FirstNameTextBox.Size = New System.Drawing.Size(337, 20)
            Me.FirstNameTextBox.TabIndex = 4
            Me.radValidationProvider1.SetValidationRule(Me.FirstNameTextBox, radValidationRule1)
            ' 
            ' LastNameTextBox
            ' 
            Me.LastNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.LastNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.LastNameTextBox, New System.Windows.Forms.Padding(2))
            Me.LastNameTextBox.Location = New System.Drawing.Point(371, 141)
            Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.LastNameTextBox.Name = "LastNameTextBox"
            Me.LastNameTextBox.Size = New System.Drawing.Size(344, 20)
            Me.LastNameTextBox.TabIndex = 4
            Me.radValidationProvider1.SetValidationRule(Me.LastNameTextBox, radValidationRule1)
            ' 
            ' EmailMaskedEditBox
            ' 
            Me.EmailMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.EmailMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.EmailMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.EmailMaskedEditBox.Location = New System.Drawing.Point(371, 293)
            Me.EmailMaskedEditBox.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.EmailMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.EMail
            Me.EmailMaskedEditBox.Name = "EmailMaskedEditBox"
            Me.EmailMaskedEditBox.Size = New System.Drawing.Size(344, 20)
            Me.EmailMaskedEditBox.TabIndex = 39
            Me.EmailMaskedEditBox.TabStop = False
            Me.radValidationProvider1.SetValidationRule(Me.EmailMaskedEditBox, radValidationRule2)
            ' 
            ' AmountMaskedEditBox
            ' 
            Me.AmountMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.AmountMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.AmountMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.AmountMaskedEditBox.Location = New System.Drawing.Point(20, 293)
            Me.AmountMaskedEditBox.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.AmountMaskedEditBox.Mask = "c"
            Me.AmountMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
            Me.AmountMaskedEditBox.Name = "AmountMaskedEditBox"
            Me.AmountMaskedEditBox.Size = New System.Drawing.Size(337, 20)
            Me.AmountMaskedEditBox.TabIndex = 29
            Me.AmountMaskedEditBox.TabStop = False
            Me.AmountMaskedEditBox.Text = "$0.00"
            Me.AmountMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
            Me.radValidationProvider1.SetValidationRule(Me.AmountMaskedEditBox, radValidationRule3)
            ' 
            ' PhoneNumberMaskedEditBox
            ' 
            Me.PhoneNumberMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.PhoneNumberMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.PhoneNumberMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.PhoneNumberMaskedEditBox.Location = New System.Drawing.Point(371, 217)
            Me.PhoneNumberMaskedEditBox.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.PhoneNumberMaskedEditBox.Mask = "(999) 000-0000"
            Me.PhoneNumberMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.PhoneNumberMaskedEditBox.Name = "PhoneNumberMaskedEditBox"
            ' 
            ' 
            ' 
            Me.PhoneNumberMaskedEditBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.PhoneNumberMaskedEditBox.Size = New System.Drawing.Size(344, 20)
            Me.PhoneNumberMaskedEditBox.TabIndex = 41
            Me.PhoneNumberMaskedEditBox.TabStop = False
            Me.PhoneNumberMaskedEditBox.Text = "(___) ___-____"
            Me.radValidationProvider1.SetValidationRule(Me.PhoneNumberMaskedEditBox, radValidationRule4)
            ' 
            ' SocialSecurityNumberMaskedEditBox
            ' 
            Me.SocialSecurityNumberMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.SocialSecurityNumberMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.SocialSecurityNumberMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.SocialSecurityNumberMaskedEditBox.Location = New System.Drawing.Point(20, 217)
            Me.SocialSecurityNumberMaskedEditBox.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.SocialSecurityNumberMaskedEditBox.Mask = "000-00-0000"
            Me.SocialSecurityNumberMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.SocialSecurityNumberMaskedEditBox.Name = "SocialSecurityNumberMaskedEditBox"
            ' 
            ' 
            ' 
            Me.SocialSecurityNumberMaskedEditBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.SocialSecurityNumberMaskedEditBox.Size = New System.Drawing.Size(337, 20)
            Me.SocialSecurityNumberMaskedEditBox.TabIndex = 28
            Me.SocialSecurityNumberMaskedEditBox.TabStop = False
            Me.SocialSecurityNumberMaskedEditBox.Text = "___-__-____"
            Me.radValidationProvider1.SetValidationRule(Me.SocialSecurityNumberMaskedEditBox, radValidationRule4)
            ' 
            ' IDNumberMaskedEditBox
            ' 
            Me.IDNumberMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.IDNumberMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.IDNumberMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.IDNumberMaskedEditBox.Location = New System.Drawing.Point(371, 369)
            Me.IDNumberMaskedEditBox.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.IDNumberMaskedEditBox.Mask = "00000"
            Me.IDNumberMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
            Me.IDNumberMaskedEditBox.Name = "IDNumberMaskedEditBox"
            ' 
            ' 
            ' 
            Me.IDNumberMaskedEditBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.IDNumberMaskedEditBox.Size = New System.Drawing.Size(344, 20)
            Me.IDNumberMaskedEditBox.TabIndex = 43
            Me.IDNumberMaskedEditBox.TabStop = False
            Me.IDNumberMaskedEditBox.Text = "_____"
            Me.radValidationProvider1.SetValidationRule(Me.IDNumberMaskedEditBox, radValidationRule4)
            ' 
            ' DateMaskedEditBox
            ' 
            Me.DateMaskedEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radValidationProvider1.SetIconAlignment(Me.DateMaskedEditBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.DateMaskedEditBox, New System.Windows.Forms.Padding(2))
            Me.DateMaskedEditBox.Location = New System.Drawing.Point(20, 369)
            Me.DateMaskedEditBox.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.DateMaskedEditBox.Mask = "g"
            Me.DateMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.DateTime
            Me.DateMaskedEditBox.Name = "DateMaskedEditBox"
            ' 
            ' 
            ' 
            Me.DateMaskedEditBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.DateMaskedEditBox.SelectedText = "11"
            Me.DateMaskedEditBox.SelectionLength = 2
            Me.DateMaskedEditBox.Size = New System.Drawing.Size(337, 20)
            Me.DateMaskedEditBox.TabIndex = 42
            Me.DateMaskedEditBox.TabStop = False
            Me.DateMaskedEditBox.Text = "11-Jan-07 00:00"
            Me.radValidationProvider1.SetValidationRule(Me.DateMaskedEditBox, radValidationRule5)
            ' 
            ' editorsPanel
            ' 
            Me.editorsPanel.Controls.Add(Me.editorsScrollablePanel)
            Me.editorsPanel.Controls.Add(Me.changeRequestLabel)
            Me.editorsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editorsPanel.Location = New System.Drawing.Point(0, 0)
            Me.editorsPanel.Name = "editorsPanel"
            Me.editorsPanel.Size = New System.Drawing.Size(737, 509)
            Me.editorsPanel.TabIndex = 1
            ' 
            ' editorsScrollablePanel
            ' 
            Me.editorsScrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editorsScrollablePanel.Location = New System.Drawing.Point(0, 55)
            Me.editorsScrollablePanel.Name = "editorsScrollablePanel"
            ' 
            ' editorsScrollablePanel.PanelContainer
            ' 
            Me.editorsScrollablePanel.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.editorsScrollablePanel.PanelContainer.Size = New System.Drawing.Size(735, 452)
            Me.editorsScrollablePanel.Size = New System.Drawing.Size(737, 454)
            Me.editorsScrollablePanel.TabIndex = 3
            ' 
            ' doubleBufferedTableLayoutPanel1
            ' 
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.IDNumberMaskedEditBox, 1, 8)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.DateMaskedEditBox, 0, 8)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.PhoneNumberMaskedEditBox, 1, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.SocialSecurityNumberMaskedEditBox, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.headerPanel, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.firstNameLabel, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.lastNameLabel, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.phoneNumberLabel, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.ssnLabel, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.totalAmountLabel, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.dateLabel, 0, 7)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.idNumberLabel, 1, 7)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.FirstNameTextBox, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.LastNameTextBox, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.AmountMaskedEditBox, 0, 6)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.EmailMaskedEditBox, 1, 6)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.emailLabel, 1, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.buttonSubmit, 1, 9)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.Padding = New System.Windows.Forms.Padding(20, 12, 20, 10)
            Me.doubleBufferedTableLayoutPanel1.RowCount = 10
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(735, 452)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
            ' 
            ' headerPanel
            ' 
            Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.headerPanel, 2)
            Me.headerPanel.Controls.Add(Me.highlightValidationErrorsLabel)
            Me.headerPanel.Controls.Add(Me.fillOutLabel)
            Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.headerPanel.Location = New System.Drawing.Point(20, 12)
            Me.headerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.headerPanel.Name = "headerPanel"
            Me.headerPanel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            ' 
            ' 
            ' 
            Me.headerPanel.RootElement.EnableElementShadow = False
            Me.headerPanel.Size = New System.Drawing.Size(695, 82)
            Me.headerPanel.TabIndex = 2
            CType(Me.headerPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            CType(Me.headerPanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' highlightValidationErrorsLabel
            ' 
            Me.highlightValidationErrorsLabel.AutoSize = False
            Me.highlightValidationErrorsLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.highlightValidationErrorsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
            Me.highlightValidationErrorsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(188, Byte), Integer))
            Me.highlightValidationErrorsLabel.Location = New System.Drawing.Point(5, 47)
            Me.highlightValidationErrorsLabel.Name = "highlightValidationErrorsLabel"
            Me.highlightValidationErrorsLabel.Size = New System.Drawing.Size(685, 35)
            Me.highlightValidationErrorsLabel.TabIndex = 1
            Me.highlightValidationErrorsLabel.Text = "Any validation errors will be highlighted next to the invalid field"
            Me.highlightValidationErrorsLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            ' 
            ' fillOutLabel
            ' 
            Me.fillOutLabel.AutoSize = False
            Me.fillOutLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.fillOutLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
            Me.fillOutLabel.ForeColor = System.Drawing.Color.Black
            Me.fillOutLabel.Location = New System.Drawing.Point(5, 0)
            Me.fillOutLabel.Name = "fillOutLabel"
            Me.fillOutLabel.Size = New System.Drawing.Size(685, 47)
            Me.fillOutLabel.TabIndex = 0
            Me.fillOutLabel.Text = ("Please fill out the new account form below to request the needed changes. You wil" + "l be notified when the change has been made.")
            ' 
            ' firstNameLabel
            ' 
            Me.firstNameLabel.AutoSize = False
            Me.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.firstNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.firstNameLabel.Location = New System.Drawing.Point(20, 94)
            Me.firstNameLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.firstNameLabel.Name = "firstNameLabel"
            Me.firstNameLabel.Size = New System.Drawing.Size(347, 38)
            Me.firstNameLabel.TabIndex = 2
            Me.firstNameLabel.Text = "First Name:"
            Me.firstNameLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.firstNameLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.firstNameLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "First Name:"
            CType(Me.firstNameLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Padding = New System.Windows.Forms.Padding(-4, 0, 0, 0)
            ' 
            ' lastNameLabel
            ' 
            Me.lastNameLabel.AutoSize = False
            Me.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lastNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lastNameLabel.Location = New System.Drawing.Point(367, 94)
            Me.lastNameLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.lastNameLabel.Name = "lastNameLabel"
            Me.lastNameLabel.Size = New System.Drawing.Size(348, 38)
            Me.lastNameLabel.TabIndex = 2
            Me.lastNameLabel.Text = "Last Name:"
            Me.lastNameLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            ' 
            ' phoneNumberLabel
            ' 
            Me.phoneNumberLabel.AutoSize = False
            Me.phoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.phoneNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.phoneNumberLabel.Location = New System.Drawing.Point(367, 170)
            Me.phoneNumberLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.phoneNumberLabel.Name = "phoneNumberLabel"
            Me.phoneNumberLabel.Size = New System.Drawing.Size(348, 38)
            Me.phoneNumberLabel.TabIndex = 2
            Me.phoneNumberLabel.Text = "Phone Number:"
            Me.phoneNumberLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            ' 
            ' ssnLabel
            ' 
            Me.ssnLabel.AutoSize = False
            Me.ssnLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ssnLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.ssnLabel.Location = New System.Drawing.Point(20, 170)
            Me.ssnLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.ssnLabel.Name = "ssnLabel"
            Me.ssnLabel.Size = New System.Drawing.Size(347, 38)
            Me.ssnLabel.TabIndex = 2
            Me.ssnLabel.Text = "Social Security Number:"
            Me.ssnLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.ssnLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.ssnLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Social Security Number:"
            CType(Me.ssnLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Padding = New System.Windows.Forms.Padding(-4, 0, 0, 0)
            ' 
            ' totalAmountLabel
            ' 
            Me.totalAmountLabel.AutoSize = False
            Me.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.totalAmountLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.totalAmountLabel.Location = New System.Drawing.Point(20, 246)
            Me.totalAmountLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.totalAmountLabel.Name = "totalAmountLabel"
            Me.totalAmountLabel.Size = New System.Drawing.Size(347, 38)
            Me.totalAmountLabel.TabIndex = 2
            Me.totalAmountLabel.Text = "Total Amount:"
            Me.totalAmountLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.totalAmountLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.totalAmountLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Total Amount:"
            CType(Me.totalAmountLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Padding = New System.Windows.Forms.Padding(-4, 0, 0, 0)
            ' 
            ' dateLabel
            ' 
            Me.dateLabel.AutoSize = False
            Me.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.dateLabel.Location = New System.Drawing.Point(20, 322)
            Me.dateLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.dateLabel.Name = "dateLabel"
            Me.dateLabel.Size = New System.Drawing.Size(347, 38)
            Me.dateLabel.TabIndex = 2
            Me.dateLabel.Text = "Date:"
            Me.dateLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.dateLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            CType(Me.dateLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Date:"
            CType(Me.dateLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Padding = New System.Windows.Forms.Padding(-4, 0, 0, 0)
            ' 
            ' idNumberLabel
            ' 
            Me.idNumberLabel.AutoSize = False
            Me.idNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.idNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.idNumberLabel.Location = New System.Drawing.Point(367, 322)
            Me.idNumberLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.idNumberLabel.Name = "idNumberLabel"
            Me.idNumberLabel.Size = New System.Drawing.Size(348, 38)
            Me.idNumberLabel.TabIndex = 2
            Me.idNumberLabel.Text = "ID Number:"
            Me.idNumberLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            ' 
            ' emailLabel
            ' 
            Me.emailLabel.AutoSize = False
            Me.emailLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.emailLabel.Location = New System.Drawing.Point(367, 246)
            Me.emailLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.emailLabel.Name = "emailLabel"
            Me.emailLabel.Size = New System.Drawing.Size(348, 34)
            Me.emailLabel.TabIndex = 40
            Me.emailLabel.Text = "EMail:"
            Me.emailLabel.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            ' 
            ' buttonSubmit
            ' 
            Me.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(188, Byte), Integer))
            Me.buttonSubmit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.buttonSubmit.ForeColor = System.Drawing.Color.White
            Me.buttonSubmit.Location = New System.Drawing.Point(604, 408)
            Me.buttonSubmit.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
            Me.buttonSubmit.Name = "buttonSubmit"
            Me.buttonSubmit.Size = New System.Drawing.Size(111, 24)
            Me.buttonSubmit.TabIndex = 3
            Me.buttonSubmit.Text = "Submit"
            Me.buttonSubmit.ButtonElement.Shape = New Telerik.WinControls.RoundRectShape(2)
            AddHandler Me.buttonSubmit.Click, AddressOf Me.ButtonSubmit_Click
            ' 
            ' changeRequestLabel
            ' 
            Me.changeRequestLabel.AutoSize = False
            Me.changeRequestLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(164, Byte), Integer))
            Me.changeRequestLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.changeRequestLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
            Me.changeRequestLabel.ForeColor = System.Drawing.Color.White
            Me.changeRequestLabel.Location = New System.Drawing.Point(0, 0)
            Me.changeRequestLabel.Name = "changeRequestLabel"
            Me.changeRequestLabel.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
            Me.changeRequestLabel.Size = New System.Drawing.Size(737, 55)
            Me.changeRequestLabel.TabIndex = 0
            Me.changeRequestLabel.Text = "Change Request Form"
            ' 
            ' radValidationProvider1
            ' 
            radValidationRule1.AutoToolTip = True
            radValidationRule1.Controls.Add(Me.FirstNameTextBox)
            radValidationRule1.Controls.Add(Me.LastNameTextBox)
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike
            radValidationRule1.ToolTipText = "Name cannot be empty!"
            radValidationRule1.Value = ""
            radValidationRule2.AutoToolTip = True
            radValidationRule2.Controls.Add(Me.EmailMaskedEditBox)
            radValidationRule2.ToolTipText = "Please enter valid EMail"
            radValidationRule2.Value = "@"
            radValidationRule3.AutoToolTip = True
            radValidationRule3.Controls.Add(Me.AmountMaskedEditBox)
            radValidationRule3.Operator = Telerik.WinControls.Data.FilterOperator.IsGreaterThan
            radValidationRule3.PropertyName = "Value"
            radValidationRule3.ToolTipText = "Enter amount larger than 5"
            radValidationRule3.Value = 5.0
            radValidationRule4.AutoToolTip = True
            radValidationRule4.Controls.Add(Me.PhoneNumberMaskedEditBox)
            radValidationRule4.Controls.Add(Me.SocialSecurityNumberMaskedEditBox)
            radValidationRule4.Controls.Add(Me.IDNumberMaskedEditBox)
            radValidationRule4.Operator = Telerik.WinControls.Data.FilterOperator.NotContains
            radValidationRule4.ToolTipText = "Please enter valid Number"
            radValidationRule4.Value = "_"
            radValidationRule5.AutoToolTip = True
            radValidationRule5.Controls.Add(Me.DateMaskedEditBox)
            radValidationRule5.Operator = Telerik.WinControls.Data.FilterOperator.IsGreaterThan
            radValidationRule5.PropertyName = "Value"
            radValidationRule5.ToolTipText = "Please enter Date greater than 01.01.2010"
            radValidationRule5.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
            Me.radValidationProvider1.ValidationRules.AddRange(New Telerik.WinControls.Data.FilterDescriptor() {radValidationRule1, radValidationRule2, radValidationRule3, radValidationRule4, radValidationRule5})
            ' 
            ' validationModeDropDownList
            ' 
            Me.validationModeDropDownList.DropDownAnimationEnabled = False
            Me.validationModeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radValidationProvider1.SetIconAlignment(Me.validationModeDropDownList, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.radValidationProvider1.SetIconPadding(Me.validationModeDropDownList, New System.Windows.Forms.Padding(2))
            Me.validationModeDropDownList.Location = New System.Drawing.Point(5, 26)
            Me.validationModeDropDownList.Name = "validationModeDropDownList"
            Me.validationModeDropDownList.Size = New System.Drawing.Size(184, 20)
            Me.validationModeDropDownList.TabIndex = 1
            Me.validationModeDropDownList.Text = "radDropDownList1"
            Me.radValidationProvider1.SetValidationRule(Me.validationModeDropDownList, Nothing)
            AddHandler Me.validationModeDropDownList.SelectedIndexChanged, AddressOf Me.ValidationModeDropDownList_SelectedIndexChanged
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.validationModeDropDownList)
            Me.radGroupBox1.HeaderText = "Validation Mode:"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(194, 55)
            Me.radGroupBox1.TabIndex = 2
            Me.radGroupBox1.Text = "Validation Mode:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1413, 826)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FirstNameTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LastNameTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmailMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AmountMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PhoneNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SocialSecurityNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDNumberMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editorsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.editorsPanel.ResumeLayout(False)
            Me.editorsScrollablePanel.PanelContainer.ResumeLayout(False)
            CType(Me.editorsScrollablePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.editorsScrollablePanel.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.headerPanel.ResumeLayout(False)
            CType(Me.highlightValidationErrorsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fillOutLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.firstNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lastNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.phoneNumberLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ssnLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.totalAmountLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.idNumberLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emailLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonSubmit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.changeRequestLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.validationModeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub
#End Region

        Private editorsPanel As Telerik.WinControls.UI.RadPanel

        Private changeRequestLabel As Telerik.WinControls.UI.RadLabel

        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel

        Private editorsScrollablePanel As Telerik.WinControls.UI.RadScrollablePanel

        Private headerPanel As Telerik.WinControls.UI.RadPanel

        Private highlightValidationErrorsLabel As Telerik.WinControls.UI.RadLabel

        Private fillOutLabel As Telerik.WinControls.UI.RadLabel

        Private firstNameLabel As Telerik.WinControls.UI.RadLabel

        Private lastNameLabel As Telerik.WinControls.UI.RadLabel

        Private phoneNumberLabel As Telerik.WinControls.UI.RadLabel

        Private ssnLabel As Telerik.WinControls.UI.RadLabel

        Private totalAmountLabel As Telerik.WinControls.UI.RadLabel

        Private dateLabel As Telerik.WinControls.UI.RadLabel

        Private idNumberLabel As Telerik.WinControls.UI.RadLabel

        Private buttonSubmit As Telerik.WinControls.UI.RadButton

        Private FirstNameTextBox As Telerik.WinControls.UI.RadTextBox

        Private LastNameTextBox As Telerik.WinControls.UI.RadTextBox

        Private SocialSecurityNumberMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private AmountMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private EmailMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private emailLabel As Telerik.WinControls.UI.RadLabel

        Private PhoneNumberMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private DateMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private IDNumberMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox

        Private radValidationProvider1 As Telerik.WinControls.UI.RadValidationProvider

        Private validationModeDropDownList As Telerik.WinControls.UI.RadDropDownList

        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    End Class
End Namespace