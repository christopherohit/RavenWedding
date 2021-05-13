Namespace Telerik.Examples.WinControls.MultiColumnComboBox.Settings
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
            If disposing AndAlso (components IsNot Nothing) Then
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
            Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
            Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
            Me.radMultiColumnComboBox1 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
            Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLblAutoComplete = New Telerik.WinControls.UI.RadLabel()
            Me.radComboAutoCompl = New Telerik.WinControls.UI.RadDropDownList()
            Me.radCheckRotate = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckRTL = New Telerik.WinControls.UI.RadCheckBox()
            Me.radMultipleSelectionCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupSettings.SuspendLayout()
            CType(Me.radLblAutoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radComboAutoCompl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckRotate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMultipleSelectionCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.Controls.Add(Me.radMultiColumnComboBox1)
            Me.radPanelDemoHolder.ForeColor = Color.Black
            Me.radPanelDemoHolder.MaximumSize = New Size(362, 100)
            Me.radPanelDemoHolder.MinimumSize = New Size(362, 100)
            ' 
            ' 
            ' 
            Me.radPanelDemoHolder.RootElement.MaxSize = New Size(362, 100)
            Me.radPanelDemoHolder.RootElement.MinSize = New Size(362, 100)
            Me.radPanelDemoHolder.Size = New Size(362, 100)
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupSettings)
            Me.settingsPanel.Location = New Point(779, 1)
            Me.settingsPanel.Size = New Size(200, 784)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
            ' 
            ' radMultiColumnComboBox1
            ' 
            ' 
            ' radMultiColumnComboBox1.NestedRadGridView
            ' 
            Me.radMultiColumnComboBox1.EditorControl.BackColor = SystemColors.ControlLightLight
            Me.radMultiColumnComboBox1.EditorControl.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
            Me.radMultiColumnComboBox1.EditorControl.ForeColor = SystemColors.ControlText
            Me.radMultiColumnComboBox1.EditorControl.Location = New Point(4, 1)
            ' 
            ' 
            ' 
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
            Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
            Me.radMultiColumnComboBox1.EditorControl.ReadOnly = True
            Me.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
            Me.radMultiColumnComboBox1.EditorControl.Size = New Size(282, 104)
            Me.radMultiColumnComboBox1.EditorControl.TabIndex = 0
            Me.radMultiColumnComboBox1.Location = New Point(0, 0)
            Me.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1"
            ' 
            ' 
            ' 
            Me.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radMultiColumnComboBox1.Size = New Size(306, 21)
            Me.radMultiColumnComboBox1.TabIndex = 0
            Me.radMultiColumnComboBox1.TabStop = False
            ' 
            ' radGroupSettings
            ' 
            Me.radGroupSettings.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupSettings.Anchor = AnchorStyles.Top
            Me.radGroupSettings.Controls.Add(Me.radLblAutoComplete)
            Me.radGroupSettings.Controls.Add(Me.radComboAutoCompl)
            Me.radGroupSettings.Controls.Add(Me.radCheckRotate)
            Me.radGroupSettings.Controls.Add(Me.radMultipleSelectionCheckBox)
            Me.radGroupSettings.Controls.Add(Me.radCheckRTL)
            Me.radGroupSettings.FooterText = ""
            Me.radGroupSettings.HeaderText = "Settings"
            Me.radGroupSettings.Location = New Point(10, 6)
            Me.radGroupSettings.Name = "radGroupSettings"
            Me.radGroupSettings.Size = New Size(180, 152)
            Me.radGroupSettings.TabIndex = 0
            Me.radGroupSettings.Text = "Settings"
            ' 
            ' radLblAutoComplete
            ' 
            Me.radLblAutoComplete.Anchor = AnchorStyles.Top
            Me.radLblAutoComplete.Location = New Point(5, 21)
            Me.radLblAutoComplete.Name = "radLblAutoComplete"
            Me.radLblAutoComplete.Size = New Size(113, 18)
            Me.radLblAutoComplete.TabIndex = 2
            Me.radLblAutoComplete.Text = "AutoComplete Mode:"
            ' 
            ' radComboAutoCompl
            ' 
            Me.radComboAutoCompl.Anchor = AnchorStyles.Top
            Me.radComboAutoCompl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboAutoCompl.FormatString = "{0}"
            radListDataItem1.Text = "None"
            radListDataItem2.Text = "Suggest"
            radListDataItem3.Text = "Append"
            radListDataItem4.Text = "SuggestAppend"
            Me.radComboAutoCompl.Items.Add(radListDataItem1)
            Me.radComboAutoCompl.Items.Add(radListDataItem2)
            Me.radComboAutoCompl.Items.Add(radListDataItem3)
            Me.radComboAutoCompl.Items.Add(radListDataItem4)
            Me.radComboAutoCompl.Location = New Point(5, 44)
            Me.radComboAutoCompl.Name = "radComboAutoCompl"
            ' 
            ' 
            ' 
            Me.radComboAutoCompl.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboAutoCompl.Size = New Size(170, 20)
            Me.radComboAutoCompl.TabIndex = 1
            Me.radComboAutoCompl.Text = "Select mode:"
            ' 
            ' radCheckRotate
            ' 
            Me.radCheckRotate.Anchor = AnchorStyles.Top
            Me.radCheckRotate.Location = New Point(5, 78)
            Me.radCheckRotate.Name = "radCheckRotate"
            Me.radCheckRotate.Size = New Size(138, 18)
            Me.radCheckRotate.TabIndex = 0
            Me.radCheckRotate.Text = "Rotate On Double-Click"
            ' 
            ' radCheckRTL
            ' 
            Me.radCheckRTL.Anchor = AnchorStyles.Top
            Me.radCheckRTL.Location = New Point(5, 101)
            Me.radCheckRTL.Name = "radCheckRTL"
            Me.radCheckRTL.Size = New Size(84, 18)
            Me.radCheckRTL.TabIndex = 0
            Me.radCheckRTL.Text = "Right To Left"
            ' 
            ' radMultipleSelectionCheckBox
            ' 
            Me.radMultipleSelectionCheckBox.Anchor = AnchorStyles.Top
            Me.radMultipleSelectionCheckBox.Location = New Point(5, 124)
            Me.radMultipleSelectionCheckBox.Name = "radMultipleSelectionCheckBox"
            Me.radMultipleSelectionCheckBox.Size = New Size(110, 18)
            Me.radMultipleSelectionCheckBox.TabIndex = 0
            Me.radMultipleSelectionCheckBox.Text = "Multiple Selection"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New Size(1677, 746)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupSettings.ResumeLayout(False)
            Me.radGroupSettings.PerformLayout()
            CType(Me.radLblAutoComplete, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radComboAutoCompl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckRotate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMultipleSelectionCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radMultiColumnComboBox1 As Telerik.WinControls.UI.RadMultiColumnComboBox
        Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
        Private radCheckRotate As Telerik.WinControls.UI.RadCheckBox
        Private radCheckRTL As Telerik.WinControls.UI.RadCheckBox
        Private radComboAutoCompl As Telerik.WinControls.UI.RadDropDownList
        Private radLblAutoComplete As Telerik.WinControls.UI.RadLabel
        Private radMultipleSelectionCheckBox As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace