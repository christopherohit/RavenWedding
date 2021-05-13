Imports Microsoft.VisualBasic
Imports System
Namespace ExportWithDpl.GridView
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
            Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
            Me.radPageViewPageSpreadExport = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radGroupBox11 = New Telerik.WinControls.UI.RadGroupBox()
            Me.exportViewDefinitionCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.createHtmlViewDefinitionCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox9 = New Telerik.WinControls.UI.RadGroupBox()
            Me.freezePinnedColumnsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.freezePinnedRowsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.freezeHeaderRowCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.pinSomeRowsAndColumnsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.exportChildRowsGroupedCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
            Me.enablePagingCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.pagingAllPagesRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.pagingCurrentPageOnlyRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.customizeVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
            Me.showSummaryCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.summariesDoNotExportRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.summariesExportOnlyBottomRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.summariesExportOnlyTopRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.summariesExportAllRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.spreadExportButton = New Telerik.WinControls.UI.RadButton()
            Me.exportHierarchyCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.hideColumnsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.hiddenColumnExportAsHiddenRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.hiddenColumnDoNotExportRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.hiddenColumnExportAlwaysRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.pdfRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.csvRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.xlsxRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.hideFirstRowCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.hiddenRowExportAsHiddenRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.hiddenRowDoNotExportRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.hiddenRowExportAlwaysRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radPageViewPagePdfExport = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radScrollablePanel2 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radGroupBox12 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxExportViewDefinitionPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCreateViewDefinitionPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonPdfExport = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxEnablePagingPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButtonPagingOptionAllPAgesPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radCheckBoxExportVisualSettingsPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCustomizeVisualSettingsPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox10 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxHideFirstRowPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHiddenRowDoNotExportPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox7 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxShowSummaryPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButtonSummariesDoNotExportPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonSummariesExportOnlyTopPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonSummariesExportAllPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox8 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxHideSomeColumnsPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport = New Telerik.WinControls.UI.RadRadioButton()
            Me.radCheckBoxExportHierarchyPdfExport = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.NwindDataSet = New NwindDataSet()
            Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CustomersTableAdapter = New NwindDataSetTableAdapters.CustomersTableAdapter()
            Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.Order_DetailsTableAdapter = New NwindDataSetTableAdapters.Order_DetailsTableAdapter()
            Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OrdersTableAdapter = New NwindDataSetTableAdapters.OrdersTableAdapter()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageView1.SuspendLayout()
            Me.radPageViewPageSpreadExport.SuspendLayout()
            CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel1.PanelContainer.SuspendLayout()
            Me.radScrollablePanel1.SuspendLayout()
            CType(Me.radGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox11.SuspendLayout()
            CType(Me.exportViewDefinitionCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.createHtmlViewDefinitionCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox9.SuspendLayout()
            CType(Me.freezePinnedColumnsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.freezePinnedRowsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.freezeHeaderRowCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pinSomeRowsAndColumnsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportChildRowsGroupedCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox5.SuspendLayout()
            CType(Me.enablePagingCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pagingAllPagesRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pagingCurrentPageOnlyRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox4.SuspendLayout()
            CType(Me.showSummaryCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.summariesDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.summariesExportOnlyBottomRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.summariesExportOnlyTopRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.summariesExportAllRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spreadExportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportHierarchyCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.hideColumnsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenColumnExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenColumnDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenColumnExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.txtRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdfRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.csvRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xlsxRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            CType(Me.hideFirstRowCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenRowExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenRowDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hiddenRowExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageViewPagePdfExport.SuspendLayout()
            CType(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel2.PanelContainer.SuspendLayout()
            Me.radScrollablePanel2.SuspendLayout()
            CType(Me.radGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox12.SuspendLayout()
            CType(Me.radCheckBoxExportViewDefinitionPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCreateViewDefinitionPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox6.SuspendLayout()
            CType(Me.radCheckBoxEnablePagingPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonPagingOptionAllPAgesPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxExportVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox10.SuspendLayout()
            CType(Me.radCheckBoxHideFirstRowPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenRowExportAsHiddenPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenRowDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenRowExportAlwaysPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox7.SuspendLayout()
            CType(Me.radCheckBoxShowSummaryPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonSummariesDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonSummariesExportOnlyBottomPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonSummariesExportOnlyTopPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonSummariesExportAllPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox8.SuspendLayout()
            CType(Me.radCheckBoxHideSomeColumnsPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenColumnDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHiddenColumnExportAlwaysPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxExportHierarchyPdfExport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.radPageView1)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(762, 0)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(264, 748)
            Me.settingsPanel.TabIndex = 3
            Me.settingsPanel.ThemeName = "ControlDefault"
            '
            'radPageView1
            '
            Me.radPageView1.Controls.Add(Me.radPageViewPageSpreadExport)
            Me.radPageView1.Controls.Add(Me.radPageViewPagePdfExport)
            Me.radPageView1.Dock = System.Windows.Forms.DockStyle.Right
            Me.radPageView1.Location = New System.Drawing.Point(-1, 0)
            Me.radPageView1.Name = "radPageView1"
            Me.radPageView1.SelectedPage = Me.radPageViewPagePdfExport
            Me.radPageView1.Size = New System.Drawing.Size(265, 748)
            Me.radPageView1.TabIndex = 2
            Me.radPageView1.Text = "radPageView1"
            CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.StripViewButtonsPanel).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Left"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Right"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Close Selected Page"
            CType(Me.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radPageViewPageSpreadExport
            '
            Me.radPageViewPageSpreadExport.Controls.Add(Me.radScrollablePanel1)
            Me.radPageViewPageSpreadExport.ItemSize = New System.Drawing.SizeF(128.0!, 28.0!)
            Me.radPageViewPageSpreadExport.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPageSpreadExport.Name = "radPageViewPageSpreadExport"
            Me.radPageViewPageSpreadExport.Size = New System.Drawing.Size(244, 700)
            Me.radPageViewPageSpreadExport.Text = "GridViewSpreadExport"
            '
            'radScrollablePanel1
            '
            Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel1.Name = "radScrollablePanel1"
            '
            'radScrollablePanel1.PanelContainer
            '
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox11)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox9)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.exportChildRowsGroupedCheckBox)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox5)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.customizeVisualSettingsCheckBox)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox4)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.spreadExportButton)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.exportHierarchyCheckBox)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox2)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radGroupBox3)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.exportVisualSettingsCheckBox)
            Me.radScrollablePanel1.PanelContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(225, 698)
            Me.radScrollablePanel1.Size = New System.Drawing.Size(244, 700)
            Me.radScrollablePanel1.TabIndex = 0
            Me.radScrollablePanel1.Text = "radScrollablePanel1"
            '
            'radGroupBox11
            '
            Me.radGroupBox11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox11.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox11.Controls.Add(Me.exportViewDefinitionCheckBox)
            Me.radGroupBox11.Controls.Add(Me.createHtmlViewDefinitionCheckBox)
            Me.radGroupBox11.HeaderText = "View Definition Export"
            Me.radGroupBox11.Location = New System.Drawing.Point(0, 764)
            Me.radGroupBox11.Name = "radGroupBox11"
            Me.radGroupBox11.Size = New System.Drawing.Size(220, 65)
            Me.radGroupBox11.TabIndex = 21
            Me.radGroupBox11.Text = "View Definition Export"
            '
            'exportViewDefinitionCheckBox
            '
            Me.exportViewDefinitionCheckBox.Location = New System.Drawing.Point(6, 43)
            Me.exportViewDefinitionCheckBox.Name = "exportViewDefinitionCheckBox"
            Me.exportViewDefinitionCheckBox.Size = New System.Drawing.Size(125, 18)
            Me.exportViewDefinitionCheckBox.TabIndex = 1
            Me.exportViewDefinitionCheckBox.Text = "ExportViewDefinition"
            '
            'createHtmlViewDefinitionCheckBox
            '
            Me.createHtmlViewDefinitionCheckBox.Location = New System.Drawing.Point(6, 20)
            Me.createHtmlViewDefinitionCheckBox.Name = "createHtmlViewDefinitionCheckBox"
            Me.createHtmlViewDefinitionCheckBox.Size = New System.Drawing.Size(164, 18)
            Me.createHtmlViewDefinitionCheckBox.TabIndex = 0
            Me.createHtmlViewDefinitionCheckBox.Text = "Create HTML view definition."
            '
            'radGroupBox9
            '
            Me.radGroupBox9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox9.Controls.Add(Me.freezePinnedColumnsCheckBox)
            Me.radGroupBox9.Controls.Add(Me.freezePinnedRowsCheckBox)
            Me.radGroupBox9.Controls.Add(Me.freezeHeaderRowCheckBox)
            Me.radGroupBox9.Controls.Add(Me.pinSomeRowsAndColumnsCheckBox)
            Me.radGroupBox9.HeaderText = "Export pinned rows and columns"
            Me.radGroupBox9.Location = New System.Drawing.Point(0, 656)
            Me.radGroupBox9.Name = "radGroupBox9"
            Me.radGroupBox9.Size = New System.Drawing.Size(220, 102)
            Me.radGroupBox9.TabIndex = 20
            Me.radGroupBox9.Text = "Export pinned rows and columns"
            '
            'freezePinnedColumnsCheckBox
            '
            Me.freezePinnedColumnsCheckBox.Location = New System.Drawing.Point(6, 81)
            Me.freezePinnedColumnsCheckBox.Name = "freezePinnedColumnsCheckBox"
            Me.freezePinnedColumnsCheckBox.Size = New System.Drawing.Size(131, 18)
            Me.freezePinnedColumnsCheckBox.TabIndex = 3
            Me.freezePinnedColumnsCheckBox.Text = "FreezePinnedColumns"
            '
            'freezePinnedRowsCheckBox
            '
            Me.freezePinnedRowsCheckBox.Location = New System.Drawing.Point(6, 60)
            Me.freezePinnedRowsCheckBox.Name = "freezePinnedRowsCheckBox"
            Me.freezePinnedRowsCheckBox.Size = New System.Drawing.Size(113, 18)
            Me.freezePinnedRowsCheckBox.TabIndex = 2
            Me.freezePinnedRowsCheckBox.Text = "FreezePinnedRows"
            '
            'freezeHeaderRowCheckBox
            '
            Me.freezeHeaderRowCheckBox.Location = New System.Drawing.Point(6, 40)
            Me.freezeHeaderRowCheckBox.Name = "freezeHeaderRowCheckBox"
            Me.freezeHeaderRowCheckBox.Size = New System.Drawing.Size(110, 18)
            Me.freezeHeaderRowCheckBox.TabIndex = 1
            Me.freezeHeaderRowCheckBox.Text = "FreezeHeaderRow"
            '
            'pinSomeRowsAndColumnsCheckBox
            '
            Me.pinSomeRowsAndColumnsCheckBox.Location = New System.Drawing.Point(6, 22)
            Me.pinSomeRowsAndColumnsCheckBox.Name = "pinSomeRowsAndColumnsCheckBox"
            Me.pinSomeRowsAndColumnsCheckBox.Size = New System.Drawing.Size(162, 18)
            Me.pinSomeRowsAndColumnsCheckBox.TabIndex = 0
            Me.pinSomeRowsAndColumnsCheckBox.Text = "Pin some rows and columns."
            '
            'exportChildRowsGroupedCheckBox
            '
            Me.exportChildRowsGroupedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.exportChildRowsGroupedCheckBox.Location = New System.Drawing.Point(-1, 117)
            Me.exportChildRowsGroupedCheckBox.Name = "exportChildRowsGroupedCheckBox"
            Me.exportChildRowsGroupedCheckBox.Size = New System.Drawing.Size(148, 18)
            Me.exportChildRowsGroupedCheckBox.TabIndex = 19
            Me.exportChildRowsGroupedCheckBox.Text = "ExportChildRowsGrouped"
            '
            'radGroupBox5
            '
            Me.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox5.Controls.Add(Me.enablePagingCheckBox)
            Me.radGroupBox5.Controls.Add(Me.pagingAllPagesRadioButton)
            Me.radGroupBox5.Controls.Add(Me.pagingCurrentPageOnlyRadioButton)
            Me.radGroupBox5.HeaderText = "Paging export option"
            Me.radGroupBox5.Location = New System.Drawing.Point(0, 565)
            Me.radGroupBox5.Name = "radGroupBox5"
            Me.radGroupBox5.Size = New System.Drawing.Size(220, 85)
            Me.radGroupBox5.TabIndex = 15
            Me.radGroupBox5.Text = "Paging export option"
            '
            'enablePagingCheckBox
            '
            Me.enablePagingCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.enablePagingCheckBox.Location = New System.Drawing.Point(6, 21)
            Me.enablePagingCheckBox.Name = "enablePagingCheckBox"
            Me.enablePagingCheckBox.Size = New System.Drawing.Size(91, 18)
            Me.enablePagingCheckBox.TabIndex = 8
            Me.enablePagingCheckBox.Text = "Enable paging"
            '
            'pagingAllPagesRadioButton
            '
            Me.pagingAllPagesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.pagingAllPagesRadioButton.Location = New System.Drawing.Point(6, 64)
            Me.pagingAllPagesRadioButton.Name = "pagingAllPagesRadioButton"
            Me.pagingAllPagesRadioButton.Size = New System.Drawing.Size(62, 18)
            Me.pagingAllPagesRadioButton.TabIndex = 1
            Me.pagingAllPagesRadioButton.Text = "AllPages"
            '
            'pagingCurrentPageOnlyRadioButton
            '
            Me.pagingCurrentPageOnlyRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.pagingCurrentPageOnlyRadioButton.Location = New System.Drawing.Point(6, 42)
            Me.pagingCurrentPageOnlyRadioButton.Name = "pagingCurrentPageOnlyRadioButton"
            Me.pagingCurrentPageOnlyRadioButton.Size = New System.Drawing.Size(106, 18)
            Me.pagingCurrentPageOnlyRadioButton.TabIndex = 0
            Me.pagingCurrentPageOnlyRadioButton.Text = "CurrentPageOnly"
            '
            'customizeVisualSettingsCheckBox
            '
            Me.customizeVisualSettingsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.customizeVisualSettingsCheckBox.AutoSize = False
            Me.customizeVisualSettingsCheckBox.Location = New System.Drawing.Point(-1, 32)
            Me.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox"
            Me.customizeVisualSettingsCheckBox.Size = New System.Drawing.Size(221, 37)
            Me.customizeVisualSettingsCheckBox.TabIndex = 17
            Me.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting"
            Me.customizeVisualSettingsCheckBox.TextWrap = True
            CType(Me.customizeVisualSettingsCheckBox.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Customize visual settings when exporting"
            '
            'radGroupBox4
            '
            Me.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox4.Controls.Add(Me.showSummaryCheckBox)
            Me.radGroupBox4.Controls.Add(Me.summariesDoNotExportRadioButton)
            Me.radGroupBox4.Controls.Add(Me.summariesExportOnlyBottomRadioButton)
            Me.radGroupBox4.Controls.Add(Me.summariesExportOnlyTopRadioButton)
            Me.radGroupBox4.Controls.Add(Me.summariesExportAllRadioButton)
            Me.radGroupBox4.HeaderText = "Summaries option"
            Me.radGroupBox4.Location = New System.Drawing.Point(0, 434)
            Me.radGroupBox4.Name = "radGroupBox4"
            Me.radGroupBox4.Size = New System.Drawing.Size(220, 125)
            Me.radGroupBox4.TabIndex = 13
            Me.radGroupBox4.Text = "Summaries option"
            '
            'showSummaryCheckBox
            '
            Me.showSummaryCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showSummaryCheckBox.Location = New System.Drawing.Point(6, 20)
            Me.showSummaryCheckBox.Name = "showSummaryCheckBox"
            Me.showSummaryCheckBox.Size = New System.Drawing.Size(96, 18)
            Me.showSummaryCheckBox.TabIndex = 11
            Me.showSummaryCheckBox.Text = "Show summary"
            '
            'summariesDoNotExportRadioButton
            '
            Me.summariesDoNotExportRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.summariesDoNotExportRadioButton.Location = New System.Drawing.Point(6, 104)
            Me.summariesDoNotExportRadioButton.Name = "summariesDoNotExportRadioButton"
            Me.summariesDoNotExportRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.summariesDoNotExportRadioButton.TabIndex = 2
            Me.summariesDoNotExportRadioButton.Text = "DoNotExport"
            '
            'summariesExportOnlyBottomRadioButton
            '
            Me.summariesExportOnlyBottomRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.summariesExportOnlyBottomRadioButton.Location = New System.Drawing.Point(6, 83)
            Me.summariesExportOnlyBottomRadioButton.Name = "summariesExportOnlyBottomRadioButton"
            Me.summariesExportOnlyBottomRadioButton.Size = New System.Drawing.Size(113, 18)
            Me.summariesExportOnlyBottomRadioButton.TabIndex = 1
            Me.summariesExportOnlyBottomRadioButton.Text = "ExportOnlyBottom"
            '
            'summariesExportOnlyTopRadioButton
            '
            Me.summariesExportOnlyTopRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.summariesExportOnlyTopRadioButton.Location = New System.Drawing.Point(6, 62)
            Me.summariesExportOnlyTopRadioButton.Name = "summariesExportOnlyTopRadioButton"
            Me.summariesExportOnlyTopRadioButton.Size = New System.Drawing.Size(95, 18)
            Me.summariesExportOnlyTopRadioButton.TabIndex = 1
            Me.summariesExportOnlyTopRadioButton.Text = "ExportOnlyTop"
            '
            'summariesExportAllRadioButton
            '
            Me.summariesExportAllRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.summariesExportAllRadioButton.Location = New System.Drawing.Point(6, 41)
            Me.summariesExportAllRadioButton.Name = "summariesExportAllRadioButton"
            Me.summariesExportAllRadioButton.Size = New System.Drawing.Size(65, 18)
            Me.summariesExportAllRadioButton.TabIndex = 0
            Me.summariesExportAllRadioButton.Text = "ExportAll"
            '
            'spreadExportButton
            '
            Me.spreadExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.spreadExportButton.Location = New System.Drawing.Point(0, 3)
            Me.spreadExportButton.Name = "spreadExportButton"
            Me.spreadExportButton.Size = New System.Drawing.Size(220, 23)
            Me.spreadExportButton.TabIndex = 10
            Me.spreadExportButton.Text = "Export"
            '
            'exportHierarchyCheckBox
            '
            Me.exportHierarchyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.exportHierarchyCheckBox.Location = New System.Drawing.Point(-1, 95)
            Me.exportHierarchyCheckBox.Name = "exportHierarchyCheckBox"
            Me.exportHierarchyCheckBox.Size = New System.Drawing.Size(100, 18)
            Me.exportHierarchyCheckBox.TabIndex = 18
            Me.exportHierarchyCheckBox.Text = "ExportHierarchy"
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox2.Controls.Add(Me.hideColumnsCheckBox)
            Me.radGroupBox2.Controls.Add(Me.hiddenColumnExportAsHiddenRadioButton)
            Me.radGroupBox2.Controls.Add(Me.hiddenColumnDoNotExportRadioButton)
            Me.radGroupBox2.Controls.Add(Me.hiddenColumnExportAlwaysRadioButton)
            Me.radGroupBox2.HeaderText = "Hidden column option"
            Me.radGroupBox2.Location = New System.Drawing.Point(0, 212)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(220, 105)
            Me.radGroupBox2.TabIndex = 12
            Me.radGroupBox2.Text = "Hidden column option"
            '
            'hideColumnsCheckBox
            '
            Me.hideColumnsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hideColumnsCheckBox.Location = New System.Drawing.Point(6, 19)
            Me.hideColumnsCheckBox.Name = "hideColumnsCheckBox"
            Me.hideColumnsCheckBox.Size = New System.Drawing.Size(119, 18)
            Me.hideColumnsCheckBox.TabIndex = 9
            Me.hideColumnsCheckBox.Text = "Hide some columns"
            '
            'hiddenColumnExportAsHiddenRadioButton
            '
            Me.hiddenColumnExportAsHiddenRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenColumnExportAsHiddenRadioButton.Location = New System.Drawing.Point(6, 84)
            Me.hiddenColumnExportAsHiddenRadioButton.Name = "hiddenColumnExportAsHiddenRadioButton"
            Me.hiddenColumnExportAsHiddenRadioButton.Size = New System.Drawing.Size(101, 18)
            Me.hiddenColumnExportAsHiddenRadioButton.TabIndex = 1
            Me.hiddenColumnExportAsHiddenRadioButton.Text = "ExportAsHidden"
            '
            'hiddenColumnDoNotExportRadioButton
            '
            Me.hiddenColumnDoNotExportRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenColumnDoNotExportRadioButton.Location = New System.Drawing.Point(6, 62)
            Me.hiddenColumnDoNotExportRadioButton.Name = "hiddenColumnDoNotExportRadioButton"
            Me.hiddenColumnDoNotExportRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.hiddenColumnDoNotExportRadioButton.TabIndex = 1
            Me.hiddenColumnDoNotExportRadioButton.Text = "DoNotExport"
            '
            'hiddenColumnExportAlwaysRadioButton
            '
            Me.hiddenColumnExportAlwaysRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenColumnExportAlwaysRadioButton.Location = New System.Drawing.Point(6, 41)
            Me.hiddenColumnExportAlwaysRadioButton.Name = "hiddenColumnExportAlwaysRadioButton"
            Me.hiddenColumnExportAlwaysRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.hiddenColumnExportAlwaysRadioButton.TabIndex = 0
            Me.hiddenColumnExportAlwaysRadioButton.Text = "ExportAlways"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.txtRadioButton)
            Me.radGroupBox1.Controls.Add(Me.pdfRadioButton)
            Me.radGroupBox1.Controls.Add(Me.csvRadioButton)
            Me.radGroupBox1.Controls.Add(Me.xlsxRadioButton)
            Me.radGroupBox1.HeaderText = "Export format"
            Me.radGroupBox1.Location = New System.Drawing.Point(0, 140)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(220, 67)
            Me.radGroupBox1.TabIndex = 11
            Me.radGroupBox1.Text = "Export format"
            '
            'txtRadioButton
            '
            Me.txtRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.txtRadioButton.Location = New System.Drawing.Point(77, 45)
            Me.txtRadioButton.Name = "txtRadioButton"
            Me.txtRadioButton.Size = New System.Drawing.Size(39, 18)
            Me.txtRadioButton.TabIndex = 2
            Me.txtRadioButton.TabStop = False
            Me.txtRadioButton.Text = "TXT"
            '
            'pdfRadioButton
            '
            Me.pdfRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.pdfRadioButton.Location = New System.Drawing.Point(77, 21)
            Me.pdfRadioButton.Name = "pdfRadioButton"
            Me.pdfRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.pdfRadioButton.TabIndex = 1
            Me.pdfRadioButton.TabStop = False
            Me.pdfRadioButton.Text = "PDF"
            '
            'csvRadioButton
            '
            Me.csvRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.csvRadioButton.Location = New System.Drawing.Point(6, 45)
            Me.csvRadioButton.Name = "csvRadioButton"
            Me.csvRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.csvRadioButton.TabIndex = 1
            Me.csvRadioButton.TabStop = False
            Me.csvRadioButton.Text = "CSV"
            '
            'xlsxRadioButton
            '
            Me.xlsxRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.xlsxRadioButton.Location = New System.Drawing.Point(6, 21)
            Me.xlsxRadioButton.Name = "xlsxRadioButton"
            Me.xlsxRadioButton.Size = New System.Drawing.Size(45, 18)
            Me.xlsxRadioButton.TabIndex = 0
            Me.xlsxRadioButton.TabStop = False
            Me.xlsxRadioButton.Text = "XLSX"
            '
            'radGroupBox3
            '
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox3.Controls.Add(Me.hideFirstRowCheckBox)
            Me.radGroupBox3.Controls.Add(Me.hiddenRowExportAsHiddenRadioButton)
            Me.radGroupBox3.Controls.Add(Me.hiddenRowDoNotExportRadioButton)
            Me.radGroupBox3.Controls.Add(Me.hiddenRowExportAlwaysRadioButton)
            Me.radGroupBox3.HeaderText = "Hidden row option"
            Me.radGroupBox3.Location = New System.Drawing.Point(0, 323)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Size = New System.Drawing.Size(220, 105)
            Me.radGroupBox3.TabIndex = 14
            Me.radGroupBox3.Text = "Hidden row option"
            '
            'hideFirstRowCheckBox
            '
            Me.hideFirstRowCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hideFirstRowCheckBox.Location = New System.Drawing.Point(6, 21)
            Me.hideFirstRowCheckBox.Name = "hideFirstRowCheckBox"
            Me.hideFirstRowCheckBox.Size = New System.Drawing.Size(87, 18)
            Me.hideFirstRowCheckBox.TabIndex = 10
            Me.hideFirstRowCheckBox.Text = "Hide first row"
            '
            'hiddenRowExportAsHiddenRadioButton
            '
            Me.hiddenRowExportAsHiddenRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenRowExportAsHiddenRadioButton.Location = New System.Drawing.Point(6, 84)
            Me.hiddenRowExportAsHiddenRadioButton.Name = "hiddenRowExportAsHiddenRadioButton"
            Me.hiddenRowExportAsHiddenRadioButton.Size = New System.Drawing.Size(101, 18)
            Me.hiddenRowExportAsHiddenRadioButton.TabIndex = 1
            Me.hiddenRowExportAsHiddenRadioButton.Text = "ExportAsHidden"
            '
            'hiddenRowDoNotExportRadioButton
            '
            Me.hiddenRowDoNotExportRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenRowDoNotExportRadioButton.Location = New System.Drawing.Point(6, 63)
            Me.hiddenRowDoNotExportRadioButton.Name = "hiddenRowDoNotExportRadioButton"
            Me.hiddenRowDoNotExportRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.hiddenRowDoNotExportRadioButton.TabIndex = 1
            Me.hiddenRowDoNotExportRadioButton.Text = "DoNotExport"
            '
            'hiddenRowExportAlwaysRadioButton
            '
            Me.hiddenRowExportAlwaysRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.hiddenRowExportAlwaysRadioButton.Location = New System.Drawing.Point(6, 42)
            Me.hiddenRowExportAlwaysRadioButton.Name = "hiddenRowExportAlwaysRadioButton"
            Me.hiddenRowExportAlwaysRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.hiddenRowExportAlwaysRadioButton.TabIndex = 0
            Me.hiddenRowExportAlwaysRadioButton.Text = "ExportAlways"
            '
            'exportVisualSettingsCheckBox
            '
            Me.exportVisualSettingsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.exportVisualSettingsCheckBox.Location = New System.Drawing.Point(-1, 72)
            Me.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox"
            Me.exportVisualSettingsCheckBox.Size = New System.Drawing.Size(122, 18)
            Me.exportVisualSettingsCheckBox.TabIndex = 16
            Me.exportVisualSettingsCheckBox.Text = "ExportVisualSettings"
            '
            'radPageViewPagePdfExport
            '
            Me.radPageViewPagePdfExport.Controls.Add(Me.radScrollablePanel2)
            Me.radPageViewPagePdfExport.ItemSize = New System.Drawing.SizeF(110.0!, 28.0!)
            Me.radPageViewPagePdfExport.Location = New System.Drawing.Point(10, 37)
            Me.radPageViewPagePdfExport.Name = "radPageViewPagePdfExport"
            Me.radPageViewPagePdfExport.Size = New System.Drawing.Size(244, 700)
            Me.radPageViewPagePdfExport.Text = "GridViewPdfExport"
            '
            'radScrollablePanel2
            '
            Me.radScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel2.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel2.Name = "radScrollablePanel2"
            '
            'radScrollablePanel2.PanelContainer
            '
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radGroupBox12)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radButtonPdfExport)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radGroupBox6)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radCheckBoxExportVisualSettingsPdfExport)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radCheckBoxCustomizeVisualSettingsPdfExport)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radGroupBox10)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radGroupBox7)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radGroupBox8)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radCheckBoxExportHierarchyPdfExport)
            Me.radScrollablePanel2.PanelContainer.Size = New System.Drawing.Size(242, 698)
            Me.radScrollablePanel2.Size = New System.Drawing.Size(244, 700)
            Me.radScrollablePanel2.TabIndex = 17
            Me.radScrollablePanel2.Text = "radScrollablePanel2"
            '
            'radGroupBox12
            '
            Me.radGroupBox12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox12.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox12.Controls.Add(Me.radCheckBoxExportViewDefinitionPdfExport)
            Me.radGroupBox12.Controls.Add(Me.radCheckBoxCreateViewDefinitionPdfExport)
            Me.radGroupBox12.HeaderText = "Export View Definition"
            Me.radGroupBox12.Location = New System.Drawing.Point(9, 604)
            Me.radGroupBox12.Name = "radGroupBox12"
            Me.radGroupBox12.Size = New System.Drawing.Size(220, 70)
            Me.radGroupBox12.TabIndex = 17
            Me.radGroupBox12.Text = "Export View Definition"
            '
            'radCheckBoxExportViewDefinitionPdfExport
            '
            Me.radCheckBoxExportViewDefinitionPdfExport.Location = New System.Drawing.Point(7, 47)
            Me.radCheckBoxExportViewDefinitionPdfExport.Name = "radCheckBoxExportViewDefinitionPdfExport"
            Me.radCheckBoxExportViewDefinitionPdfExport.Size = New System.Drawing.Size(125, 18)
            Me.radCheckBoxExportViewDefinitionPdfExport.TabIndex = 1
            Me.radCheckBoxExportViewDefinitionPdfExport.Text = "ExportViewDefinition"
            '
            'radCheckBoxCreateViewDefinitionPdfExport
            '
            Me.radCheckBoxCreateViewDefinitionPdfExport.Location = New System.Drawing.Point(7, 22)
            Me.radCheckBoxCreateViewDefinitionPdfExport.Name = "radCheckBoxCreateViewDefinitionPdfExport"
            Me.radCheckBoxCreateViewDefinitionPdfExport.Size = New System.Drawing.Size(161, 18)
            Me.radCheckBoxCreateViewDefinitionPdfExport.TabIndex = 0
            Me.radCheckBoxCreateViewDefinitionPdfExport.Text = "Create HTML view definition"
            '
            'radButtonPdfExport
            '
            Me.radButtonPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonPdfExport.Location = New System.Drawing.Point(9, 3)
            Me.radButtonPdfExport.Name = "radButtonPdfExport"
            Me.radButtonPdfExport.Size = New System.Drawing.Size(220, 23)
            Me.radButtonPdfExport.TabIndex = 8
            Me.radButtonPdfExport.Text = "Export"
            '
            'radGroupBox6
            '
            Me.radGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox6.Controls.Add(Me.radCheckBoxEnablePagingPdfExport)
            Me.radGroupBox6.Controls.Add(Me.radRadioButtonPagingOptionAllPAgesPdfExport)
            Me.radGroupBox6.Controls.Add(Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport)
            Me.radGroupBox6.HeaderText = "Paging export option"
            Me.radGroupBox6.Location = New System.Drawing.Point(9, 506)
            Me.radGroupBox6.Name = "radGroupBox6"
            Me.radGroupBox6.Size = New System.Drawing.Size(220, 92)
            Me.radGroupBox6.TabIndex = 13
            Me.radGroupBox6.Text = "Paging export option"
            '
            'radCheckBoxEnablePagingPdfExport
            '
            Me.radCheckBoxEnablePagingPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxEnablePagingPdfExport.Location = New System.Drawing.Point(6, 24)
            Me.radCheckBoxEnablePagingPdfExport.Name = "radCheckBoxEnablePagingPdfExport"
            Me.radCheckBoxEnablePagingPdfExport.Size = New System.Drawing.Size(91, 18)
            Me.radCheckBoxEnablePagingPdfExport.TabIndex = 8
            Me.radCheckBoxEnablePagingPdfExport.Text = "Enable paging"
            '
            'radRadioButtonPagingOptionAllPAgesPdfExport
            '
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.Location = New System.Drawing.Point(6, 72)
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.Name = "radRadioButtonPagingOptionAllPAgesPdfExport"
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.Size = New System.Drawing.Size(62, 18)
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.TabIndex = 1
            Me.radRadioButtonPagingOptionAllPAgesPdfExport.Text = "AllPages"
            '
            'radRadioButtonPagingOptionCurrentPageOnlyPdfExport
            '
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.Location = New System.Drawing.Point(6, 48)
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.Name = "radRadioButtonPagingOptionCurrentPageOnlyPdfExport"
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.Size = New System.Drawing.Size(106, 18)
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.TabIndex = 0
            Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.Text = "CurrentPageOnly"
            '
            'radCheckBoxExportVisualSettingsPdfExport
            '
            Me.radCheckBoxExportVisualSettingsPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxExportVisualSettingsPdfExport.Location = New System.Drawing.Point(8, 72)
            Me.radCheckBoxExportVisualSettingsPdfExport.Name = "radCheckBoxExportVisualSettingsPdfExport"
            Me.radCheckBoxExportVisualSettingsPdfExport.Size = New System.Drawing.Size(122, 18)
            Me.radCheckBoxExportVisualSettingsPdfExport.TabIndex = 14
            Me.radCheckBoxExportVisualSettingsPdfExport.Text = "ExportVisualSettings"
            '
            'radCheckBoxCustomizeVisualSettingsPdfExport
            '
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.AutoSize = False
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Location = New System.Drawing.Point(8, 32)
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Name = "radCheckBoxCustomizeVisualSettingsPdfExport"
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Size = New System.Drawing.Size(221, 37)
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.TabIndex = 15
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.Text = "Customize visual settings when exporting"
            Me.radCheckBoxCustomizeVisualSettingsPdfExport.TextWrap = True
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = "Customize visual settings when exporting"
            '
            'radGroupBox10
            '
            Me.radGroupBox10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox10.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox10.Controls.Add(Me.radCheckBoxHideFirstRowPdfExport)
            Me.radGroupBox10.Controls.Add(Me.radRadioButtonHiddenRowExportAsHiddenPdfExport)
            Me.radGroupBox10.Controls.Add(Me.radRadioButtonHiddenRowDoNotExportPdfExport)
            Me.radGroupBox10.Controls.Add(Me.radRadioButtonHiddenRowExportAlwaysPdfExport)
            Me.radGroupBox10.HeaderText = "Hidden row option"
            Me.radGroupBox10.Location = New System.Drawing.Point(9, 242)
            Me.radGroupBox10.Name = "radGroupBox10"
            Me.radGroupBox10.Size = New System.Drawing.Size(220, 115)
            Me.radGroupBox10.TabIndex = 12
            Me.radGroupBox10.Text = "Hidden row option"
            '
            'radCheckBoxHideFirstRowPdfExport
            '
            Me.radCheckBoxHideFirstRowPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxHideFirstRowPdfExport.Location = New System.Drawing.Point(5, 23)
            Me.radCheckBoxHideFirstRowPdfExport.Name = "radCheckBoxHideFirstRowPdfExport"
            Me.radCheckBoxHideFirstRowPdfExport.Size = New System.Drawing.Size(87, 18)
            Me.radCheckBoxHideFirstRowPdfExport.TabIndex = 10
            Me.radCheckBoxHideFirstRowPdfExport.Text = "Hide first row"
            '
            'radRadioButtonHiddenRowExportAsHiddenPdfExport
            '
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.Location = New System.Drawing.Point(5, 92)
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.Name = "radRadioButtonHiddenRowExportAsHiddenPdfExport"
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.Size = New System.Drawing.Size(101, 18)
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.TabIndex = 1
            Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.Text = "ExportAsHidden"
            '
            'radRadioButtonHiddenRowDoNotExportPdfExport
            '
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.Location = New System.Drawing.Point(5, 69)
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.Name = "radRadioButtonHiddenRowDoNotExportPdfExport"
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.Size = New System.Drawing.Size(86, 18)
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.TabIndex = 1
            Me.radRadioButtonHiddenRowDoNotExportPdfExport.Text = "DoNotExport"
            '
            'radRadioButtonHiddenRowExportAlwaysPdfExport
            '
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.Location = New System.Drawing.Point(5, 46)
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.Name = "radRadioButtonHiddenRowExportAlwaysPdfExport"
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.Size = New System.Drawing.Size(86, 18)
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.TabIndex = 0
            Me.radRadioButtonHiddenRowExportAlwaysPdfExport.Text = "ExportAlways"
            '
            'radGroupBox7
            '
            Me.radGroupBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox7.Controls.Add(Me.radCheckBoxShowSummaryPdfExport)
            Me.radGroupBox7.Controls.Add(Me.radRadioButtonSummariesDoNotExportPdfExport)
            Me.radGroupBox7.Controls.Add(Me.radRadioButtonSummariesExportOnlyBottomPdfExport)
            Me.radGroupBox7.Controls.Add(Me.radRadioButtonSummariesExportOnlyTopPdfExport)
            Me.radGroupBox7.Controls.Add(Me.radRadioButtonSummariesExportAllPdfExport)
            Me.radGroupBox7.HeaderText = "Summaries option"
            Me.radGroupBox7.Location = New System.Drawing.Point(9, 363)
            Me.radGroupBox7.Name = "radGroupBox7"
            Me.radGroupBox7.Size = New System.Drawing.Size(220, 137)
            Me.radGroupBox7.TabIndex = 11
            Me.radGroupBox7.Text = "Summaries option"
            '
            'radCheckBoxShowSummaryPdfExport
            '
            Me.radCheckBoxShowSummaryPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxShowSummaryPdfExport.Location = New System.Drawing.Point(5, 22)
            Me.radCheckBoxShowSummaryPdfExport.Name = "radCheckBoxShowSummaryPdfExport"
            Me.radCheckBoxShowSummaryPdfExport.Size = New System.Drawing.Size(96, 18)
            Me.radCheckBoxShowSummaryPdfExport.TabIndex = 11
            Me.radCheckBoxShowSummaryPdfExport.Text = "Show summary"
            '
            'radRadioButtonSummariesDoNotExportPdfExport
            '
            Me.radRadioButtonSummariesDoNotExportPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonSummariesDoNotExportPdfExport.Location = New System.Drawing.Point(5, 114)
            Me.radRadioButtonSummariesDoNotExportPdfExport.Name = "radRadioButtonSummariesDoNotExportPdfExport"
            Me.radRadioButtonSummariesDoNotExportPdfExport.Size = New System.Drawing.Size(86, 18)
            Me.radRadioButtonSummariesDoNotExportPdfExport.TabIndex = 2
            Me.radRadioButtonSummariesDoNotExportPdfExport.Text = "DoNotExport"
            '
            'radRadioButtonSummariesExportOnlyBottomPdfExport
            '
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.Location = New System.Drawing.Point(5, 91)
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.Name = "radRadioButtonSummariesExportOnlyBottomPdfExport"
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.Size = New System.Drawing.Size(113, 18)
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.TabIndex = 1
            Me.radRadioButtonSummariesExportOnlyBottomPdfExport.Text = "ExportOnlyBottom"
            '
            'radRadioButtonSummariesExportOnlyTopPdfExport
            '
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.Location = New System.Drawing.Point(5, 68)
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.Name = "radRadioButtonSummariesExportOnlyTopPdfExport"
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.Size = New System.Drawing.Size(95, 18)
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.TabIndex = 1
            Me.radRadioButtonSummariesExportOnlyTopPdfExport.Text = "ExportOnlyTop"
            '
            'radRadioButtonSummariesExportAllPdfExport
            '
            Me.radRadioButtonSummariesExportAllPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonSummariesExportAllPdfExport.Location = New System.Drawing.Point(5, 45)
            Me.radRadioButtonSummariesExportAllPdfExport.Name = "radRadioButtonSummariesExportAllPdfExport"
            Me.radRadioButtonSummariesExportAllPdfExport.Size = New System.Drawing.Size(65, 18)
            Me.radRadioButtonSummariesExportAllPdfExport.TabIndex = 0
            Me.radRadioButtonSummariesExportAllPdfExport.Text = "ExportAll"
            '
            'radGroupBox8
            '
            Me.radGroupBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox8.Controls.Add(Me.radCheckBoxHideSomeColumnsPdfExport)
            Me.radGroupBox8.Controls.Add(Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport)
            Me.radGroupBox8.Controls.Add(Me.radRadioButtonHiddenColumnDoNotExportPdfExport)
            Me.radGroupBox8.Controls.Add(Me.radRadioButtonHiddenColumnExportAlwaysPdfExport)
            Me.radGroupBox8.HeaderText = "Hidden column option"
            Me.radGroupBox8.Location = New System.Drawing.Point(9, 118)
            Me.radGroupBox8.Name = "radGroupBox8"
            Me.radGroupBox8.Size = New System.Drawing.Size(220, 118)
            Me.radGroupBox8.TabIndex = 10
            Me.radGroupBox8.Text = "Hidden column option"
            '
            'radCheckBoxHideSomeColumnsPdfExport
            '
            Me.radCheckBoxHideSomeColumnsPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxHideSomeColumnsPdfExport.Location = New System.Drawing.Point(6, 21)
            Me.radCheckBoxHideSomeColumnsPdfExport.Name = "radCheckBoxHideSomeColumnsPdfExport"
            Me.radCheckBoxHideSomeColumnsPdfExport.Size = New System.Drawing.Size(119, 18)
            Me.radCheckBoxHideSomeColumnsPdfExport.TabIndex = 9
            Me.radCheckBoxHideSomeColumnsPdfExport.Text = "Hide some columns"
            '
            'radRadioButtonHiddenColumnExportAsHiddenPdfExport
            '
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.Location = New System.Drawing.Point(6, 96)
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.Name = "radRadioButtonHiddenColumnExportAsHiddenPdfExport"
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.Size = New System.Drawing.Size(101, 18)
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.TabIndex = 1
            Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.Text = "ExportAsHidden"
            '
            'radRadioButtonHiddenColumnDoNotExportPdfExport
            '
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.Location = New System.Drawing.Point(6, 72)
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.Name = "radRadioButtonHiddenColumnDoNotExportPdfExport"
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.Size = New System.Drawing.Size(86, 18)
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.TabIndex = 1
            Me.radRadioButtonHiddenColumnDoNotExportPdfExport.Text = "DoNotExport"
            '
            'radRadioButtonHiddenColumnExportAlwaysPdfExport
            '
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.Location = New System.Drawing.Point(6, 48)
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.Name = "radRadioButtonHiddenColumnExportAlwaysPdfExport"
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.Size = New System.Drawing.Size(86, 18)
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.TabIndex = 0
            Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.Text = "ExportAlways"
            '
            'radCheckBoxExportHierarchyPdfExport
            '
            Me.radCheckBoxExportHierarchyPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxExportHierarchyPdfExport.Location = New System.Drawing.Point(8, 95)
            Me.radCheckBoxExportHierarchyPdfExport.Name = "radCheckBoxExportHierarchyPdfExport"
            Me.radCheckBoxExportHierarchyPdfExport.Size = New System.Drawing.Size(100, 18)
            Me.radCheckBoxExportHierarchyPdfExport.TabIndex = 16
            Me.radCheckBoxExportHierarchyPdfExport.Text = "ExportHierarchy"
            '
            'radGridView1
            '
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            '
            '
            Me.radGridView1.MasterTemplate.PageSize = 10
            Me.radGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(762, 748)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridView1"
            '
            'NwindDataSet
            '
            Me.NwindDataSet.DataSetName = "NwindDataSet"
            Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CustomersBindingSource
            '
            Me.CustomersBindingSource.DataMember = "Customers"
            Me.CustomersBindingSource.DataSource = Me.NwindDataSet
            '
            'CustomersTableAdapter
            '
            Me.CustomersTableAdapter.ClearBeforeFill = True
            '
            'OrderDetailsBindingSource
            '
            Me.OrderDetailsBindingSource.DataMember = "Order Details"
            Me.OrderDetailsBindingSource.DataSource = Me.NwindDataSet
            '
            'Order_DetailsTableAdapter
            '
            Me.Order_DetailsTableAdapter.ClearBeforeFill = True
            '
            'OrdersBindingSource
            '
            Me.OrdersBindingSource.DataMember = "Orders"
            Me.OrdersBindingSource.DataSource = Me.NwindDataSet
            '
            'OrdersTableAdapter
            '
            Me.OrdersTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1026, 748)
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(Me.settingsPanel)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Export with Document Processing Libraries"
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageView1.ResumeLayout(False)
            Me.radPageViewPageSpreadExport.ResumeLayout(False)
            Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
            Me.radScrollablePanel1.PanelContainer.PerformLayout()
            CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.ResumeLayout(False)
            CType(Me.radGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox11.ResumeLayout(False)
            Me.radGroupBox11.PerformLayout()
            CType(Me.exportViewDefinitionCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.createHtmlViewDefinitionCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox9.ResumeLayout(False)
            Me.radGroupBox9.PerformLayout()
            CType(Me.freezePinnedColumnsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.freezePinnedRowsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.freezeHeaderRowCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pinSomeRowsAndColumnsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportChildRowsGroupedCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox5.ResumeLayout(False)
            Me.radGroupBox5.PerformLayout()
            CType(Me.enablePagingCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pagingAllPagesRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pagingCurrentPageOnlyRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox4.ResumeLayout(False)
            Me.radGroupBox4.PerformLayout()
            CType(Me.showSummaryCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.summariesDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.summariesExportOnlyBottomRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.summariesExportOnlyTopRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.summariesExportAllRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spreadExportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportHierarchyCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.hideColumnsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenColumnExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenColumnDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenColumnExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.txtRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdfRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.csvRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xlsxRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.radGroupBox3.PerformLayout()
            CType(Me.hideFirstRowCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenRowExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenRowDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hiddenRowExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageViewPagePdfExport.ResumeLayout(False)
            Me.radScrollablePanel2.PanelContainer.ResumeLayout(False)
            Me.radScrollablePanel2.PanelContainer.PerformLayout()
            CType(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel2.ResumeLayout(False)
            CType(Me.radGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox12.ResumeLayout(False)
            Me.radGroupBox12.PerformLayout()
            CType(Me.radCheckBoxExportViewDefinitionPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCreateViewDefinitionPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox6.ResumeLayout(False)
            Me.radGroupBox6.PerformLayout()
            CType(Me.radCheckBoxEnablePagingPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonPagingOptionAllPAgesPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxExportVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxCustomizeVisualSettingsPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox10.ResumeLayout(False)
            Me.radGroupBox10.PerformLayout()
            CType(Me.radCheckBoxHideFirstRowPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenRowExportAsHiddenPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenRowDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenRowExportAlwaysPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox7.ResumeLayout(False)
            Me.radGroupBox7.PerformLayout()
            CType(Me.radCheckBoxShowSummaryPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonSummariesDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonSummariesExportOnlyBottomPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonSummariesExportOnlyTopPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonSummariesExportAllPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox8.ResumeLayout(False)
            Me.radGroupBox8.PerformLayout()
            CType(Me.radCheckBoxHideSomeColumnsPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenColumnDoNotExportPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHiddenColumnExportAlwaysPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxExportHierarchyPdfExport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private settingsPanel As Telerik.WinControls.UI.RadPanel
        Private radPageView1 As Telerik.WinControls.UI.RadPageView
        Private radPageViewPageSpreadExport As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPagePdfExport As Telerik.WinControls.UI.RadPageViewPage
        Private radGroupBox6 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxEnablePagingPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radRadioButtonPagingOptionAllPAgesPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonPagingOptionCurrentPageOnlyPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radCheckBoxCustomizeVisualSettingsPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox7 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxShowSummaryPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radRadioButtonSummariesDoNotExportPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonSummariesExportOnlyBottomPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonSummariesExportOnlyTopPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonSummariesExportAllPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radButtonPdfExport As Telerik.WinControls.UI.RadButton
        Private radCheckBoxExportHierarchyPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox8 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxHideSomeColumnsPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radRadioButtonHiddenColumnExportAsHiddenPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonHiddenColumnDoNotExportPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonHiddenColumnExportAlwaysPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox10 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxHideFirstRowPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radRadioButtonHiddenRowExportAsHiddenPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonHiddenRowDoNotExportPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonHiddenRowExportAlwaysPdfExport As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radCheckBoxExportVisualSettingsPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
        Private radGroupBox9 As Telerik.WinControls.UI.RadGroupBox
        Private exportChildRowsGroupedCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
        Private enablePagingCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private pagingAllPagesRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private pagingCurrentPageOnlyRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private customizeVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
        Private showSummaryCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private summariesDoNotExportRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private summariesExportOnlyBottomRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private summariesExportOnlyTopRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private summariesExportAllRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private spreadExportButton As Telerik.WinControls.UI.RadButton
        Private exportHierarchyCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private hideColumnsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private hiddenColumnExportAsHiddenRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private hiddenColumnDoNotExportRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private hiddenColumnExportAlwaysRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private txtRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private pdfRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private csvRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private xlsxRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private hideFirstRowCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private hiddenRowExportAsHiddenRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private hiddenRowDoNotExportRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private hiddenRowExportAlwaysRadioButton As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents exportVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private freezePinnedColumnsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private freezePinnedRowsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private freezeHeaderRowCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private pinSomeRowsAndColumnsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox11 As Telerik.WinControls.UI.RadGroupBox
        Private createHtmlViewDefinitionCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private exportViewDefinitionCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radScrollablePanel2 As Telerik.WinControls.UI.RadScrollablePanel
        Private radGroupBox12 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxExportViewDefinitionPdfExport As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxCreateViewDefinitionPdfExport As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents NwindDataSet As NwindDataSet
        Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CustomersTableAdapter As NwindDataSetTableAdapters.CustomersTableAdapter
        Friend WithEvents OrderDetailsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents Order_DetailsTableAdapter As NwindDataSetTableAdapters.Order_DetailsTableAdapter
        Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents OrdersTableAdapter As NwindDataSetTableAdapters.OrdersTableAdapter
    End Class
End Namespace
