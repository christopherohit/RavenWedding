Imports System.Drawing

Namespace Telerik.Examples.WinControls.Editors.DomainUpDown
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem16 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem17 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem18 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem19 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.mainDoubleBufferedTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.topDoubleBufferedTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.headerLabel = New Telerik.WinControls.UI.RadLabel()
            Me.amountLabel = New Telerik.WinControls.UI.RadLabel()
            Me.fromLabel = New Telerik.WinControls.UI.RadLabel()
            Me.toLabel = New Telerik.WinControls.UI.RadLabel()
            Me.amountDomainUpDown = New Telerik.WinControls.UI.RadDomainUpDown()
            Me.fromDomainUpDown = New Telerik.WinControls.UI.RadDomainUpDown()
            Me.toDomainUpDown = New Telerik.WinControls.UI.RadDomainUpDown()
            Me.convertSymbolLabel = New Telerik.WinControls.UI.RadLabel()
            Me.convertButton = New Telerik.WinControls.UI.RadButton()
            Me.convertedResultLabel = New Telerik.WinControls.UI.RadLabel()
            Me.rateLabel = New Telerik.WinControls.UI.RadLabel()
            Me.bottomDoubleBufferedTableLayoutPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.ratesLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            Me.radSeparator3 = New Telerik.WinControls.UI.RadSeparator()
            Me.radSeparator4 = New Telerik.WinControls.UI.RadSeparator()
            Me.radSeparator5 = New Telerik.WinControls.UI.RadSeparator()
            Me.radSeparator2 = New Telerik.WinControls.UI.RadSeparator()
            Me.radSeparator6 = New Telerik.WinControls.UI.RadSeparator()
            Me.unitLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelEUR = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelUSD = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelGBP = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelCHF = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelRUB = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelCAD = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBoxWrap = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxAutoComplete = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxReadOnly = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxSelectNext = New Telerik.WinControls.UI.RadCheckBox()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainDoubleBufferedTableLayoutPanel.SuspendLayout()
            Me.topDoubleBufferedTableLayoutPanel.SuspendLayout()
            CType(Me.headerLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.amountLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fromLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.amountDomainUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fromDomainUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toDomainUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.convertSymbolLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.convertButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.convertedResultLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rateLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bottomDoubleBufferedTableLayoutPanel.SuspendLayout()
            CType((Me.ratesLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSeparator6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.unitLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelEUR), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelUSD), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelGBP), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelCHF), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelRUB), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelCAD), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxWrap), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxAutoComplete), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxReadOnly), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxSelectNext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.mainDoubleBufferedTableLayoutPanel)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(404, 285)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(720, 410)
            Me.settingsPanel.Location = New System.Drawing.Point(207, 117)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxSelectNext)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxReadOnly)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxAutoComplete)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxWrap)
            Me.optionsLabel.Location = New System.Drawing.Point(60, 168)
            Me.optionsLabel.Size = New System.Drawing.Size(87, 27)
            Me.mainDoubleBufferedTableLayoutPanel.ColumnCount = 1
            Me.mainDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.mainDoubleBufferedTableLayoutPanel.Controls.Add(Me.topDoubleBufferedTableLayoutPanel, 0, 0)
            Me.mainDoubleBufferedTableLayoutPanel.Controls.Add(Me.bottomDoubleBufferedTableLayoutPanel, 0, 1)
            Me.mainDoubleBufferedTableLayoutPanel.Location = New System.Drawing.Point(10, 10)
            Me.mainDoubleBufferedTableLayoutPanel.Name = "mainDoubleBufferedTableLayoutPanel"
            Me.mainDoubleBufferedTableLayoutPanel.RowCount = 2
            Me.mainDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.mainDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.mainDoubleBufferedTableLayoutPanel.Size = New System.Drawing.Size(645, 330)
            Me.mainDoubleBufferedTableLayoutPanel.TabIndex = 0
            Me.topDoubleBufferedTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.topDoubleBufferedTableLayoutPanel.ColumnCount = 5
            Me.topDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0F))
            Me.topDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0F))
            Me.topDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.topDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0F))
            Me.topDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.headerLabel, 0, 0)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.amountLabel, 0, 1)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.fromLabel, 1, 1)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.toLabel, 3, 1)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.amountDomainUpDown, 0, 2)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.fromDomainUpDown, 1, 2)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.toDomainUpDown, 3, 2)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.convertSymbolLabel, 2, 2)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.convertButton, 4, 2)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.convertedResultLabel, 0, 3)
            Me.topDoubleBufferedTableLayoutPanel.Controls.Add(Me.rateLabel, 1, 3)
            Me.topDoubleBufferedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.topDoubleBufferedTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.topDoubleBufferedTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.topDoubleBufferedTableLayoutPanel.Name = "topDoubleBufferedTableLayoutPanel"
            Me.topDoubleBufferedTableLayoutPanel.RowCount = 4
            Me.topDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F))
            Me.topDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.topDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0F))
            Me.topDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.topDoubleBufferedTableLayoutPanel.Size = New System.Drawing.Size(645, 165)
            Me.topDoubleBufferedTableLayoutPanel.TabIndex = 0
            Me.headerLabel.AutoSize = False
            Me.topDoubleBufferedTableLayoutPanel.SetColumnSpan(Me.headerLabel, 2)
            Me.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.headerLabel.Font = New System.Drawing.Font("Segoe UI", 13.5F)
            Me.headerLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((3)))))), (CInt(((CByte((3)))))), (CInt(((CByte((3)))))))
            Me.headerLabel.Location = New System.Drawing.Point(17, 3)
            Me.headerLabel.Margin = New System.Windows.Forms.Padding(17, 3, 3, 3)
            Me.headerLabel.Name = "headerLabel"
            Me.headerLabel.Size = New System.Drawing.Size(300, 54)
            Me.headerLabel.TabIndex = 0
            Me.headerLabel.Text = "Progress Currency Converter"
            Me.amountLabel.AutoSize = False
            Me.amountLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.amountLabel.ForeColor = System.Drawing.Color.Black
            Me.amountLabel.Location = New System.Drawing.Point(17, 60)
            Me.amountLabel.Margin = New System.Windows.Forms.Padding(17, 0, 0, 0)
            Me.amountLabel.Name = "amountLabel"
            Me.amountLabel.Size = New System.Drawing.Size(173, 22)
            Me.amountLabel.TabIndex = 1
            Me.amountLabel.Text = "Amount"
            Me.fromLabel.AutoSize = False
            Me.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fromLabel.ForeColor = System.Drawing.Color.Black
            Me.fromLabel.Location = New System.Drawing.Point(190, 60)
            Me.fromLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.fromLabel.Name = "fromLabel"
            Me.fromLabel.Size = New System.Drawing.Size(130, 22)
            Me.fromLabel.TabIndex = 2
            Me.fromLabel.Text = "From"
            Me.toLabel.AutoSize = False
            Me.toLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toLabel.ForeColor = System.Drawing.Color.Black
            Me.toLabel.Location = New System.Drawing.Point(360, 60)
            Me.toLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.toLabel.Name = "toLabel"
            Me.toLabel.Size = New System.Drawing.Size(130, 22)
            Me.toLabel.TabIndex = 3
            Me.toLabel.Text = "To"
            Me.amountDomainUpDown.AutoComplete = True
            Me.amountDomainUpDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.amountDomainUpDown.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            radListDataItem1.Text = "1000"
            radListDataItem2.Text = "500"
            radListDataItem3.Text = "100"
            radListDataItem4.Text = "50"
            radListDataItem5.Text = "10"
            radListDataItem6.Text = "5"
            radListDataItem7.Text = "1"
            Me.amountDomainUpDown.Items.Add(radListDataItem1)
            Me.amountDomainUpDown.Items.Add(radListDataItem2)
            Me.amountDomainUpDown.Items.Add(radListDataItem3)
            Me.amountDomainUpDown.Items.Add(radListDataItem4)
            Me.amountDomainUpDown.Items.Add(radListDataItem5)
            Me.amountDomainUpDown.Items.Add(radListDataItem6)
            Me.amountDomainUpDown.Items.Add(radListDataItem7)
            Me.amountDomainUpDown.Location = New System.Drawing.Point(20, 82)
            Me.amountDomainUpDown.Margin = New System.Windows.Forms.Padding(20, 0, 10, 0)
            Me.amountDomainUpDown.Name = "amountDomainUpDown"
            Me.amountDomainUpDown.SelectNextOnDoubleClick = True
            Me.amountDomainUpDown.Size = New System.Drawing.Size(160, 33)
            Me.amountDomainUpDown.TabIndex = 4
            Me.amountDomainUpDown.Wrap = True
            Me.fromDomainUpDown.AutoComplete = True
            Me.fromDomainUpDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fromDomainUpDown.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            radListDataItem8.Text = "USD"
            radListDataItem9.Text = "EUR"
            radListDataItem10.Text = "GBP"
            radListDataItem11.Text = "CHF"
            radListDataItem12.Text = "RUB"
            radListDataItem13.Text = "CAD"
            Me.fromDomainUpDown.Items.Add(radListDataItem8)
            Me.fromDomainUpDown.Items.Add(radListDataItem9)
            Me.fromDomainUpDown.Items.Add(radListDataItem10)
            Me.fromDomainUpDown.Items.Add(radListDataItem11)
            Me.fromDomainUpDown.Items.Add(radListDataItem12)
            Me.fromDomainUpDown.Items.Add(radListDataItem13)
            Me.fromDomainUpDown.Location = New System.Drawing.Point(190, 82)
            Me.fromDomainUpDown.Margin = New System.Windows.Forms.Padding(0)
            Me.fromDomainUpDown.Name = "fromDomainUpDown"
            Me.fromDomainUpDown.SelectNextOnDoubleClick = True
            Me.fromDomainUpDown.Size = New System.Drawing.Size(130, 33)
            Me.fromDomainUpDown.TabIndex = 5
            Me.fromDomainUpDown.Wrap = True
            Me.toDomainUpDown.AutoComplete = True
            Me.toDomainUpDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toDomainUpDown.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            radListDataItem14.Text = "USD"
            radListDataItem15.Text = "EUR"
            radListDataItem16.Text = "GBP"
            radListDataItem17.Text = "CHF"
            radListDataItem18.Text = "RUB"
            radListDataItem19.Text = "CAD"
            Me.toDomainUpDown.Items.Add(radListDataItem14)
            Me.toDomainUpDown.Items.Add(radListDataItem15)
            Me.toDomainUpDown.Items.Add(radListDataItem16)
            Me.toDomainUpDown.Items.Add(radListDataItem17)
            Me.toDomainUpDown.Items.Add(radListDataItem18)
            Me.toDomainUpDown.Items.Add(radListDataItem19)
            Me.toDomainUpDown.Location = New System.Drawing.Point(360, 82)
            Me.toDomainUpDown.Margin = New System.Windows.Forms.Padding(0)
            Me.toDomainUpDown.Name = "toDomainUpDown"
            Me.toDomainUpDown.SelectNextOnDoubleClick = True
            Me.toDomainUpDown.Size = New System.Drawing.Size(130, 33)
            Me.toDomainUpDown.TabIndex = 6
            Me.toDomainUpDown.Wrap = True
            Me.convertSymbolLabel.AutoSize = False
            Me.convertSymbolLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.convertSymbolLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((80)))))), (CInt(((CByte((80)))))), (CInt(((CByte((80)))))))
            Me.convertSymbolLabel.Location = New System.Drawing.Point(323, 85)
            Me.convertSymbolLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
            Me.convertSymbolLabel.Name = "convertSymbolLabel"
            Me.convertSymbolLabel.RootElement.AccessibleDescription = " "
            Me.convertSymbolLabel.RootElement.AccessibleName = " "
            Me.convertSymbolLabel.RootElement.ApplyShapeToControl = True
            Me.convertSymbolLabel.Size = New System.Drawing.Size(34, 20)
            Me.convertSymbolLabel.TabIndex = 7
            Me.convertSymbolLabel.Text = " "
            Me.convertSymbolLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType((Me.convertSymbolLabel.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType((Me.convertSymbolLabel.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = " "
            CType((Me.convertSymbolLabel.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).CustomFont = "TelerikWebUI"
            CType((Me.convertSymbolLabel.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).CustomFontSize = 12.0F
            CType((Me.convertSymbolLabel.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).AngleTransform = 90.0F
            Me.convertButton.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.convertButton.Location = New System.Drawing.Point(500, 82)
            Me.convertButton.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.convertButton.Name = "convertButton"
            Me.convertButton.Size = New System.Drawing.Size(110, 24)
            Me.convertButton.TabIndex = 8
            Me.convertButton.Text = "Convert"
            Me.convertedResultLabel.AutoSize = False
            Me.convertedResultLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.convertedResultLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.convertedResultLabel.ForeColor = System.Drawing.Color.Black
            Me.convertedResultLabel.Location = New System.Drawing.Point(17, 115)
            Me.convertedResultLabel.Margin = New System.Windows.Forms.Padding(17, 0, 0, 0)
            Me.convertedResultLabel.Name = "convertedResultLabel"
            Me.convertedResultLabel.Size = New System.Drawing.Size(173, 50)
            Me.convertedResultLabel.TabIndex = 9
            Me.convertedResultLabel.Text = "1USD = 0.873698 EUR &"
            Me.rateLabel.AutoSize = False
            Me.topDoubleBufferedTableLayoutPanel.SetColumnSpan(Me.rateLabel, 4)
            Me.rateLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.rateLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((102)))))), (CInt(((CByte((102)))))), (CInt(((CByte((102)))))))
            Me.rateLabel.Location = New System.Drawing.Point(190, 115)
            Me.rateLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.rateLabel.Name = "rateLabel"
            Me.rateLabel.Size = New System.Drawing.Size(455, 50)
            Me.rateLabel.TabIndex = 10
            Me.rateLabel.Text = "1 EUR = 1.14456 USD , 1 USD = 0.873698 EUR"
            Me.bottomDoubleBufferedTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((62)))))), (CInt(((CByte((62)))))), (CInt(((CByte((66)))))))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnCount = 11
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.675F))
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.ratesLabel, 0, 0)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator1, 0, 1)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator3, 3, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator4, 5, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator5, 7, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator2, 1, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radSeparator6, 9, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.unitLabel, 10, 0)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelEUR, 0, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelUSD, 2, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelGBP, 4, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelCHF, 6, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelRUB, 8, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Controls.Add(Me.radLabelCAD, 10, 2)
            Me.bottomDoubleBufferedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.bottomDoubleBufferedTableLayoutPanel.Location = New System.Drawing.Point(0, 165)
            Me.bottomDoubleBufferedTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.bottomDoubleBufferedTableLayoutPanel.Name = "bottomDoubleBufferedTableLayoutPanel"
            Me.bottomDoubleBufferedTableLayoutPanel.RowCount = 3
            Me.bottomDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0F))
            Me.bottomDoubleBufferedTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.bottomDoubleBufferedTableLayoutPanel.Size = New System.Drawing.Size(645, 165)
            Me.bottomDoubleBufferedTableLayoutPanel.TabIndex = 1
            Me.ratesLabel.AutoSize = False
            Me.bottomDoubleBufferedTableLayoutPanel.SetColumnSpan(Me.ratesLabel, 5)
            Me.ratesLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ratesLabel.Font = New System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold)
            Me.ratesLabel.ForeColor = System.Drawing.Color.White
            Me.ratesLabel.Location = New System.Drawing.Point(17, 20)
            Me.ratesLabel.Margin = New System.Windows.Forms.Padding(17, 20, 3, 3)
            Me.ratesLabel.Name = "ratesLabel"
            Me.ratesLabel.Size = New System.Drawing.Size(299, 37)
            Me.ratesLabel.TabIndex = 0
            Me.ratesLabel.Text = "Exchange Rates"
            Me.bottomDoubleBufferedTableLayoutPanel.SetColumnSpan(Me.radSeparator1, 11)
            Me.radSeparator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator1.Location = New System.Drawing.Point(20, 63)
            Me.radSeparator1.Margin = New System.Windows.Forms.Padding(20, 3, 15, 3)
            Me.radSeparator1.Name = "radSeparator1"
            Me.radSeparator1.Size = New System.Drawing.Size(610, 4)
            Me.radSeparator1.TabIndex = 2
            Me.radSeparator3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator3.Location = New System.Drawing.Point(211, 90)
            Me.radSeparator3.Margin = New System.Windows.Forms.Padding(0, 20, 0, 40)
            Me.radSeparator3.Name = "radSeparator3"
            Me.radSeparator3.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radSeparator3.Size = New System.Drawing.Size(5, 40)
            Me.radSeparator3.TabIndex = 4
            Me.radSeparator4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator4.Location = New System.Drawing.Point(319, 90)
            Me.radSeparator4.Margin = New System.Windows.Forms.Padding(0, 20, 0, 40)
            Me.radSeparator4.Name = "radSeparator4"
            Me.radSeparator4.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radSeparator4.Size = New System.Drawing.Size(5, 40)
            Me.radSeparator4.TabIndex = 5
            Me.radSeparator5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator5.Location = New System.Drawing.Point(427, 90)
            Me.radSeparator5.Margin = New System.Windows.Forms.Padding(0, 20, 0, 40)
            Me.radSeparator5.Name = "radSeparator5"
            Me.radSeparator5.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radSeparator5.Size = New System.Drawing.Size(5, 40)
            Me.radSeparator5.TabIndex = 6
            Me.radSeparator2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator2.Location = New System.Drawing.Point(103, 90)
            Me.radSeparator2.Margin = New System.Windows.Forms.Padding(0, 20, 0, 40)
            Me.radSeparator2.Name = "radSeparator2"
            Me.radSeparator2.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radSeparator2.Size = New System.Drawing.Size(5, 40)
            Me.radSeparator2.TabIndex = 3
            Me.radSeparator6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSeparator6.Location = New System.Drawing.Point(535, 90)
            Me.radSeparator6.Margin = New System.Windows.Forms.Padding(0, 20, 0, 40)
            Me.radSeparator6.Name = "radSeparator6"
            Me.radSeparator6.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radSeparator6.Size = New System.Drawing.Size(5, 40)
            Me.radSeparator6.TabIndex = 7
            Me.unitLabel.AutoSize = False
            Me.unitLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.unitLabel.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
            Me.unitLabel.ForeColor = System.Drawing.Color.White
            Me.unitLabel.Location = New System.Drawing.Point(557, 20)
            Me.unitLabel.Margin = New System.Windows.Forms.Padding(17, 20, 0, 0)
            Me.unitLabel.Name = "unitLabel"
            Me.unitLabel.Size = New System.Drawing.Size(88, 40)
            Me.unitLabel.TabIndex = 1
            Me.unitLabel.Text = "1 USD"
            Me.radLabelEUR.AutoSize = False
            Me.radLabelEUR.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelEUR.ForeColor = System.Drawing.Color.White
            Me.radLabelEUR.Location = New System.Drawing.Point(20, 70)
            Me.radLabelEUR.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelEUR.Name = "radLabelEUR"
            Me.radLabelEUR.Size = New System.Drawing.Size(83, 85)
            Me.radLabelEUR.TabIndex = 8
            Me.radLabelEUR.Text = "<html><b><size=10>EUR</b><br>0.51129"
            Me.radLabelUSD.AutoSize = False
            Me.radLabelUSD.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelUSD.ForeColor = System.Drawing.Color.White
            Me.radLabelUSD.Location = New System.Drawing.Point(128, 70)
            Me.radLabelUSD.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelUSD.Name = "radLabelUSD"
            Me.radLabelUSD.Size = New System.Drawing.Size(83, 85)
            Me.radLabelUSD.TabIndex = 9
            Me.radLabelUSD.Text = "<html><b><size=10>USD</b><br>0.58559"
            Me.radLabelGBP.AutoSize = False
            Me.radLabelGBP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelGBP.ForeColor = System.Drawing.Color.White
            Me.radLabelGBP.Location = New System.Drawing.Point(236, 70)
            Me.radLabelGBP.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelGBP.Name = "radLabelGBP"
            Me.radLabelGBP.Size = New System.Drawing.Size(83, 85)
            Me.radLabelGBP.TabIndex = 10
            Me.radLabelGBP.Text = "<html><b><size=10>GBP</b><br>0.44813"
            Me.radLabelCHF.AutoSize = False
            Me.radLabelCHF.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelCHF.ForeColor = System.Drawing.Color.White
            Me.radLabelCHF.Location = New System.Drawing.Point(344, 70)
            Me.radLabelCHF.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelCHF.Name = "radLabelCHF"
            Me.radLabelCHF.Size = New System.Drawing.Size(83, 85)
            Me.radLabelCHF.TabIndex = 11
            Me.radLabelCHF.Text = "<html><b><size=10>CHF</b><br>0.58377"
            Me.radLabelRUB.AutoSize = False
            Me.radLabelRUB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelRUB.ForeColor = System.Drawing.Color.White
            Me.radLabelRUB.Location = New System.Drawing.Point(452, 70)
            Me.radLabelRUB.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelRUB.Name = "radLabelRUB"
            Me.radLabelRUB.Size = New System.Drawing.Size(83, 85)
            Me.radLabelRUB.TabIndex = 12
            Me.radLabelRUB.Text = "<html><b><size=10>RUB</b><br>38.4453"
            Me.radLabelCAD.AutoSize = False
            Me.radLabelCAD.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabelCAD.ForeColor = System.Drawing.Color.White
            Me.radLabelCAD.Location = New System.Drawing.Point(560, 70)
            Me.radLabelCAD.Margin = New System.Windows.Forms.Padding(20, 0, 0, 15)
            Me.radLabelCAD.Name = "radLabelCAD"
            Me.radLabelCAD.Size = New System.Drawing.Size(85, 85)
            Me.radLabelCAD.TabIndex = 13
            Me.radLabelCAD.Text = "<html><b><size=10>CAD</b><br>0.76674"
            Me.radCheckBoxWrap.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxWrap.Location = New System.Drawing.Point(3, 14)
            Me.radCheckBoxWrap.Name = "radCheckBoxWrap"
            Me.radCheckBoxWrap.Size = New System.Drawing.Size(94, 18)
            Me.radCheckBoxWrap.TabIndex = 1
            Me.radCheckBoxWrap.Text = "Wrap selection"
            Me.radCheckBoxWrap.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxWrap.ToggleStateChanged, AddressOf Me.radCheckBoxWrap_ToggleStateChanged
            Me.radCheckBoxAutoComplete.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxAutoComplete.Location = New System.Drawing.Point(3, 38)
            Me.radCheckBoxAutoComplete.Name = "radCheckBoxAutoComplete"
            Me.radCheckBoxAutoComplete.Size = New System.Drawing.Size(96, 18)
            Me.radCheckBoxAutoComplete.TabIndex = 2
            Me.radCheckBoxAutoComplete.Text = "Auto-complete"
            Me.radCheckBoxAutoComplete.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxAutoComplete.ToggleStateChanged, AddressOf Me.radCheckBoxAutoComplete_ToggleStateChanged
            Me.radCheckBoxReadOnly.Location = New System.Drawing.Point(3, 62)
            Me.radCheckBoxReadOnly.Name = "radCheckBoxReadOnly"
            Me.radCheckBoxReadOnly.Size = New System.Drawing.Size(71, 18)
            Me.radCheckBoxReadOnly.TabIndex = 3
            Me.radCheckBoxReadOnly.Text = "Read-only"
            AddHandler Me.radCheckBoxReadOnly.ToggleStateChanged, AddressOf Me.radCheckBoxReadOnly_ToggleStateChanged
            Me.radCheckBoxSelectNext.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxSelectNext.Location = New System.Drawing.Point(3, 86)
            Me.radCheckBoxSelectNext.Name = "radCheckBoxSelectNext"
            Me.radCheckBoxSelectNext.Size = New System.Drawing.Size(155, 18)
            Me.radCheckBoxSelectNext.TabIndex = 4
            Me.radCheckBoxSelectNext.Text = "Select next on double-click"
            Me.radCheckBoxSelectNext.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxSelectNext.ToggleStateChanged, AddressOf Me.radCheckBoxSelectNext_ToggleStateChanged
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1459, 744)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainDoubleBufferedTableLayoutPanel.ResumeLayout(False)
            Me.topDoubleBufferedTableLayoutPanel.ResumeLayout(False)
            Me.topDoubleBufferedTableLayoutPanel.PerformLayout()
            CType((Me.headerLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.amountLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fromLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.amountDomainUpDown), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fromDomainUpDown), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toDomainUpDown), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.convertSymbolLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.convertButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.convertedResultLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rateLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.bottomDoubleBufferedTableLayoutPanel.ResumeLayout(False)
            CType((Me.ratesLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSeparator6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.unitLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelEUR), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelUSD), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelGBP), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelCHF), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelRUB), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelCAD), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxWrap), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxAutoComplete), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxReadOnly), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxSelectNext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private mainDoubleBufferedTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private topDoubleBufferedTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private bottomDoubleBufferedTableLayoutPanel As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private headerLabel As Telerik.WinControls.UI.RadLabel
        Private amountLabel As Telerik.WinControls.UI.RadLabel
        Private fromLabel As Telerik.WinControls.UI.RadLabel
        Private toLabel As Telerik.WinControls.UI.RadLabel
        Private amountDomainUpDown As Telerik.WinControls.UI.RadDomainUpDown
        Private toDomainUpDown As Telerik.WinControls.UI.RadDomainUpDown
        Private fromDomainUpDown As Telerik.WinControls.UI.RadDomainUpDown
        Private convertSymbolLabel As Telerik.WinControls.UI.RadLabel
        Private convertButton As Telerik.WinControls.UI.RadButton
        Private convertedResultLabel As Telerik.WinControls.UI.RadLabel
        Private rateLabel As Telerik.WinControls.UI.RadLabel
        Private ratesLabel As Telerik.WinControls.UI.RadLabel
        Private unitLabel As Telerik.WinControls.UI.RadLabel
        Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
        Private radSeparator2 As Telerik.WinControls.UI.RadSeparator
        Private radSeparator3 As Telerik.WinControls.UI.RadSeparator
        Private radSeparator4 As Telerik.WinControls.UI.RadSeparator
        Private radSeparator5 As Telerik.WinControls.UI.RadSeparator
        Private radSeparator6 As Telerik.WinControls.UI.RadSeparator
        Private radLabelEUR As Telerik.WinControls.UI.RadLabel
        Private radLabelUSD As Telerik.WinControls.UI.RadLabel
        Private radLabelGBP As Telerik.WinControls.UI.RadLabel
        Private radLabelCHF As Telerik.WinControls.UI.RadLabel
        Private radLabelRUB As Telerik.WinControls.UI.RadLabel
        Private radLabelCAD As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxWrap As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxSelectNext As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxReadOnly As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxAutoComplete As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
