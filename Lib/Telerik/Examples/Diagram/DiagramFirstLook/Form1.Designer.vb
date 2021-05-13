Namespace DiagramFirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim listViewDataItemGroup1 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Basic")
            Dim listViewDataItemGroup2 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Arrow")
            Dim listViewDataItemGroup3 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Flowchart")
            Dim listViewDataItemGroup4 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Container")
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
            Me.radDiagramToolbox1 = New Telerik.WinControls.UI.RadDiagramToolbox()
            Me.diagramRibbonBar1 = New Telerik.WinControls.UI.RadDiagramRibbonBar()
            Me.radDiagram1 = New Telerik.WinControls.UI.RadDiagram()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.dropDownExample = New Telerik.WinControls.UI.RadDropDownListElement()
            Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
            Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.documentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
            Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
            Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDiagramToolbox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.diagramRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dropDownExample, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDock1.SuspendLayout()
            Me.toolWindow1.SuspendLayout()
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip1.SuspendLayout()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentContainer1.SuspendLayout()
            CType(Me.documentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentTabStrip2.SuspendLayout()
            Me.toolWindow3.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentTabStrip1.SuspendLayout()
            Me.documentWindow1.SuspendLayout()
            CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip2.SuspendLayout()
            Me.toolWindow2.SuspendLayout()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPropertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.Size = New System.Drawing.Size(258, 555)
            Me.radPropertyGrid1.TabIndex = 2
            Me.radPropertyGrid1.Text = "radPropertyGrid1"
            Me.radPropertyGrid1.ToolbarVisible = True
            Me.radDiagramToolbox1.AllowDragDrop = True
            Me.radDiagramToolbox1.AllowDrop = True
            Me.radDiagramToolbox1.AllowEdit = False
            Me.radDiagramToolbox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDiagramToolbox1.EnableCustomGrouping = True
            Me.radDiagramToolbox1.FullRowSelect = False
            Me.radDiagramToolbox1.ItemSize = New System.Drawing.Size(80, 80)
            Me.radDiagramToolbox1.ItemSpacing = 10
            Me.radDiagramToolbox1.Location = New System.Drawing.Point(0, 0)
            Me.radDiagramToolbox1.Name = "radDiagramToolbox1"
            Me.radDiagramToolbox1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.radDiagramToolbox1.ShowGroups = True
            Me.radDiagramToolbox1.Size = New System.Drawing.Size(226, 555)
            Me.radDiagramToolbox1.TabIndex = 1
            Me.radDiagramToolbox1.Text = "radDiagramToolbox1"
            Me.radDiagramToolbox1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
            CType(Me.radDiagramToolbox1.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.radDiagramToolbox1.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).Padding = New System.Windows.Forms.Padding(5, 10, 0, 0)
            CType(Me.radDiagramToolbox1.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).ClipDrawing = True
            Me.diagramRibbonBar1.AssociatedDiagram = Me.radDiagram1
            Me.diagramRibbonBar1.ExitButton.Text = "Exit"
            Me.diagramRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.diagramRibbonBar1.Name = "diagramRibbonBar1"
            Me.diagramRibbonBar1.OptionsButton.Text = "Options"
            Me.diagramRibbonBar1.Size = New System.Drawing.Size(1395, 164)
            Me.diagramRibbonBar1.TabIndex = 0
            Me.diagramRibbonBar1.Text = "Diagram"
            Me.radDiagram1.DisplayMemberPath = Nothing
            Me.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDiagram1.Location = New System.Drawing.Point(0, 0)
            Me.radDiagram1.Name = "radDiagram1"
            Me.radDiagram1.SerializedXml = resources.GetString("radDiagram1.SerializedXml")
            Me.radDiagram1.Size = New System.Drawing.Size(910, 524)
            Me.radDiagram1.TabIndex = 3
            Me.radDiagram1.Text = "radDiagram1"
            AddHandler Me.radDiagram1.SelectionChanged, New System.EventHandler(AddressOf Me.DiagramElement_SelectionChanged)
            Me.radDropDownList1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Tag = "radDiagram1.SerializedXml"
            radListDataItem1.Text = "Decision Flowchart"
            radListDataItem2.Tag = "String1"
            radListDataItem2.Text = "Cycle Diagram"
            radListDataItem3.Tag = "String2"
            radListDataItem3.Text = "Linear Process Diagram"
            radListDataItem4.Tag = "String3"
            radListDataItem4.Text = "Routing"
            radListDataItem5.Tag = "String4"
            radListDataItem5.Text = "Connection Gaps"
            radListDataItem6.Tag = ""
            radListDataItem6.Text = "DataBinding"
            radListDataItem7.Tag = "String5"
            radListDataItem7.Text = "Floor Plan"
            Me.radDropDownList1.Items.Add(radListDataItem1)
            Me.radDropDownList1.Items.Add(radListDataItem2)
            Me.radDropDownList1.Items.Add(radListDataItem3)
            Me.radDropDownList1.Items.Add(radListDataItem4)
            Me.radDropDownList1.Items.Add(radListDataItem5)
            Me.radDropDownList1.Items.Add(radListDataItem6)
            Me.radDropDownList1.Items.Add(radListDataItem7)
            Me.radDropDownList1.Location = New System.Drawing.Point(90, 5)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(196, 20)
            Me.radDropDownList1.TabIndex = 4
            AddHandler Me.radDropDownList1.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.radDropDownList1_SelectedIndexChanged)
            Me.dropDownExample.AutoCompleteAppend = Nothing
            Me.dropDownExample.AutoCompleteDataSource = Nothing
            Me.dropDownExample.AutoCompleteSuggest = Nothing
            Me.dropDownExample.DataMember = ""
            Me.dropDownExample.DataSource = Nothing
            Me.dropDownExample.DefaultValue = Nothing
            Me.dropDownExample.DisplayMember = ""
            Me.dropDownExample.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
            Me.dropDownExample.DropDownAnimationEnabled = True
            Me.dropDownExample.EditableElementText = ""
            Me.dropDownExample.EditorElement = Me.dropDownExample
            Me.dropDownExample.EditorManager = Nothing
            Me.dropDownExample.Filter = Nothing
            Me.dropDownExample.FilterExpression = ""
            Me.dropDownExample.Focusable = True
            Me.dropDownExample.FormatString = ""
            Me.dropDownExample.FormattingEnabled = True
            Me.dropDownExample.ItemHeight = 18
            Me.dropDownExample.MaxDropDownItems = 0
            Me.dropDownExample.MaxLength = 32767
            Me.dropDownExample.MaxValue = Nothing
            Me.dropDownExample.MinValue = Nothing
            Me.dropDownExample.Name = "dropDownExample"
            Me.dropDownExample.NullValue = Nothing
            Me.dropDownExample.OwnerOffset = 0
            Me.dropDownExample.ShowImageInEditorArea = True
            Me.dropDownExample.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
            Me.dropDownExample.Value = Nothing
            Me.dropDownExample.ValueMember = ""
            Me.radDock1.ActiveWindow = Me.toolWindow1
            Me.radDock1.CausesValidation = False
            Me.radDock1.Controls.Add(Me.toolTabStrip1)
            Me.radDock1.Controls.Add(Me.documentContainer1)
            Me.radDock1.Controls.Add(Me.toolTabStrip2)
            Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDock1.DocumentTabsVisible = False
            Me.radDock1.IsCleanUpTarget = True
            Me.radDock1.Location = New System.Drawing.Point(0, 164)
            Me.radDock1.MainDocumentContainer = Me.documentContainer1
            Me.radDock1.Name = "radDock1"
            Me.radDock1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.radDock1.Size = New System.Drawing.Size(1395, 591)
            Me.radDock1.TabIndex = 0
            Me.radDock1.TabStop = False
            Me.radDock1.Text = "radDock1"
            Me.toolWindow1.Caption = Nothing
            Me.toolWindow1.Controls.Add(Me.radDiagramToolbox1)
            Me.toolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.toolWindow1.Location = New System.Drawing.Point(1, 24)
            Me.toolWindow1.Name = "toolWindow1"
            Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolWindow1.Size = New System.Drawing.Size(226, 555)
            Me.toolWindow1.Text = "Toolbox"
            Me.toolTabStrip1.CanUpdateChildIndex = True
            Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
            Me.toolTabStrip1.Location = New System.Drawing.Point(5, 5)
            Me.toolTabStrip1.Name = "toolTabStrip1"
            Me.toolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.toolTabStrip1.SelectedIndex = 0
            Me.toolTabStrip1.Size = New System.Drawing.Size(228, 581)
            Me.toolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(228, 200)
            Me.toolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(28, 0)
            Me.toolTabStrip1.TabIndex = 1
            Me.toolTabStrip1.TabStop = False
            Me.documentContainer1.CausesValidation = False
            Me.documentContainer1.Controls.Add(Me.documentTabStrip2)
            Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
            Me.documentContainer1.Name = "documentContainer1"
            Me.documentContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.documentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(771, 200)
            Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.documentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-56, 0)
            Me.documentContainer1.TabIndex = 2
            Me.documentTabStrip2.CanUpdateChildIndex = True
            Me.documentTabStrip2.CausesValidation = False
            Me.documentTabStrip2.Controls.Add(Me.toolWindow3)
            Me.documentTabStrip2.Location = New System.Drawing.Point(0, 0)
            Me.documentTabStrip2.Name = "documentTabStrip2"
            Me.documentTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.documentTabStrip2.SelectedIndex = 0
            Me.documentTabStrip2.Size = New System.Drawing.Size(771, 41)
            Me.documentTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0F, -0.4281664F)
            Me.documentTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -226)
            Me.documentTabStrip2.TabIndex = 1
            Me.documentTabStrip2.TabStop = False
            Me.documentTabStrip2.TabStripVisible = False
            Me.toolWindow3.Caption = Nothing
            Me.toolWindow3.Controls.Add(Me.radLabel1)
            Me.toolWindow3.Controls.Add(Me.radDropDownList1)
            Me.toolWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.toolWindow3.Location = New System.Drawing.Point(6, 6)
            Me.toolWindow3.Name = "toolWindow3"
            Me.toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Floating
            Me.toolWindow3.Size = New System.Drawing.Size(909, 29)
            Me.toolWindow3.Text = "toolWindow3"
            Me.radLabel1.Location = New System.Drawing.Point(14, 6)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(76, 18)
            Me.radLabel1.TabIndex = 5
            Me.radLabel1.Text = "Diagram type:"
            Me.documentTabStrip1.CanUpdateChildIndex = True
            Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
            Me.documentTabStrip1.Location = New System.Drawing.Point(0, 45)
            Me.documentTabStrip1.Name = "documentTabStrip1"
            Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.documentTabStrip1.SelectedIndex = 0
            Me.documentTabStrip1.Size = New System.Drawing.Size(921, 536)
            Me.documentTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0F, 0.4281664F)
            Me.documentTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 226)
            Me.documentTabStrip1.TabIndex = 0
            Me.documentTabStrip1.TabStop = False
            Me.documentTabStrip1.TabStripVisible = False
            Me.documentWindow1.Controls.Add(Me.radDiagram1)
            Me.documentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.documentWindow1.Location = New System.Drawing.Point(6, 6)
            Me.documentWindow1.Name = "documentWindow1"
            Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
            Me.documentWindow1.Size = New System.Drawing.Size(909, 524)
            Me.documentWindow1.Text = "documentWindow1"
            Me.toolTabStrip2.CanUpdateChildIndex = True
            Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
            Me.toolTabStrip2.Location = New System.Drawing.Point(1130, 5)
            Me.toolTabStrip2.Name = "toolTabStrip2"
            Me.toolTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.toolTabStrip2.SelectedIndex = 0
            Me.toolTabStrip2.Size = New System.Drawing.Size(260, 581)
            Me.toolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(260, 200)
            Me.toolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(60, 0)
            Me.toolTabStrip2.TabIndex = 2
            Me.toolTabStrip2.TabStop = False
            Me.toolWindow2.Caption = Nothing
            Me.toolWindow2.Controls.Add(Me.radPropertyGrid1)
            Me.toolWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.toolWindow2.Location = New System.Drawing.Point(1, 24)
            Me.toolWindow2.Name = "toolWindow2"
            Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolWindow2.Size = New System.Drawing.Size(258, 555)
            Me.toolWindow2.Text = "Properties"
            Me.AllowAero = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(1395, 755)
            Me.Controls.Add(Me.radDock1)
            Me.Controls.Add(Me.diagramRibbonBar1)
            Me.Name = "Form1"
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Diagram"
            CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDiagramToolbox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.diagramRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dropDownExample, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDock1.ResumeLayout(False)
            Me.toolWindow1.ResumeLayout(False)
            CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip1.ResumeLayout(False)
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentContainer1.ResumeLayout(False)
            CType(Me.documentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentTabStrip2.ResumeLayout(False)
            Me.toolWindow3.ResumeLayout(False)
            Me.toolWindow3.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentTabStrip1.ResumeLayout(False)
            Me.documentWindow1.ResumeLayout(False)
            CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip2.ResumeLayout(False)
            Me.toolWindow2.ResumeLayout(False)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private diagramRibbonBar1 As Telerik.WinControls.UI.RadDiagramRibbonBar
        Private radDiagramToolbox1 As Telerik.WinControls.UI.RadDiagramToolbox
        Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
        Private dropDownExample As Telerik.WinControls.UI.RadDropDownListElement
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
        Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
        Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
        Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
        Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
        Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
        Private radDiagram1 As Telerik.WinControls.UI.RadDiagram
        Private documentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
        Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
