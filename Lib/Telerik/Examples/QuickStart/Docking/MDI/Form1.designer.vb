Namespace Telerik.Examples.WinControls.Docking.MDI
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
			Dim guidToNameMapping1 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping2 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Me.logRadTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.imageMDIRadButton = New Telerik.WinControls.UI.RadButton()
			Me.reportMDIRadButton = New Telerik.WinControls.UI.RadButton()
			Me.orderMDIRadButton = New Telerik.WinControls.UI.RadButton()
			Me.customerMDIRadButton = New Telerik.WinControls.UI.RadButton()
			Me.label1 = New Label()
			Me.newMDIRadButton = New Telerik.WinControls.UI.RadButton()
			Me.openFileDialog = New OpenFileDialog()
			Me.saveFileDialog = New SaveFileDialog()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			CType(Me.logRadTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageMDIRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportMDIRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderMDIRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customerMDIRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newMDIRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			Me.toolWindow1.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip2.SuspendLayout()
			Me.toolWindow2.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' logRadTextBox
			' 
			Me.logRadTextBox.AutoSize = False
			Me.logRadTextBox.Dock = DockStyle.Fill
			Me.logRadTextBox.Location = New Point(0, 0)
			Me.logRadTextBox.Multiline = True
			Me.logRadTextBox.Name = "logRadTextBox"
			' 
			' 
			' 
			Me.logRadTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.logRadTextBox.ScrollBars = ScrollBars.Vertical
			Me.logRadTextBox.Size = New Size(287, 249)
			Me.logRadTextBox.TabIndex = 0
			Me.logRadTextBox.TabStop = False
			' 
			' imageMDIRadButton
			' 
			Me.imageMDIRadButton.Image = My.Resources.msIcon1
			Me.imageMDIRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.imageMDIRadButton.Location = New Point(3, 153)
			Me.imageMDIRadButton.Name = "imageMDIRadButton"
			Me.imageMDIRadButton.Size = New Size(185, 27)
			Me.imageMDIRadButton.TabIndex = 4
			Me.imageMDIRadButton.Text = "Add Image child form"
			Me.imageMDIRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' reportMDIRadButton
			' 
			Me.reportMDIRadButton.Image = My.Resources.msIcon1
			Me.reportMDIRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.reportMDIRadButton.Location = New Point(3, 118)
			Me.reportMDIRadButton.Name = "reportMDIRadButton"
			Me.reportMDIRadButton.Size = New Size(185, 27)
			Me.reportMDIRadButton.TabIndex = 3
			Me.reportMDIRadButton.Text = "Add Report child form"
			Me.reportMDIRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' orderMDIRadButton
			' 
			Me.orderMDIRadButton.Image = My.Resources.msIcon1
			Me.orderMDIRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.orderMDIRadButton.Location = New Point(3, 83)
			Me.orderMDIRadButton.Name = "orderMDIRadButton"
			Me.orderMDIRadButton.Size = New Size(185, 27)
			Me.orderMDIRadButton.TabIndex = 2
			Me.orderMDIRadButton.Text = "Add Order child form"
			Me.orderMDIRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' customerMDIRadButton
			' 
			Me.customerMDIRadButton.Image = My.Resources.msIcon1
			Me.customerMDIRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.customerMDIRadButton.Location = New Point(3, 48)
			Me.customerMDIRadButton.Name = "customerMDIRadButton"
			Me.customerMDIRadButton.Size = New Size(185, 27)
			Me.customerMDIRadButton.TabIndex = 1
			Me.customerMDIRadButton.Text = "Add Customer child form"
			Me.customerMDIRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' label1
			' 
			Me.label1.BorderStyle = BorderStyle.Fixed3D
			Me.label1.Location = New Point(3, 208)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(185, 75)
			Me.label1.TabIndex = 6
			Me.label1.Text = "Right click on tab or drag and drop tabbed document item to show context menu."
			' 
			' newMDIRadButton
			' 
			Me.newMDIRadButton.Image = My.Resources.msIcon1
			Me.newMDIRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.newMDIRadButton.Location = New Point(3, 13)
			Me.newMDIRadButton.Name = "newMDIRadButton"
			Me.newMDIRadButton.Size = New Size(185, 27)
			Me.newMDIRadButton.TabIndex = 0
			Me.newMDIRadButton.Text = "New MDI child form"
			Me.newMDIRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' openFileDialog
			' 
			Me.openFileDialog.FileName = "openFileDialog"
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow1
			Me.radDock1.Controls.Add(Me.documentContainer1)
			Me.radDock1.Controls.Add(Me.radSplitContainer1)
			Me.radDock1.Dock = DockStyle.Fill
			guidToNameMapping1.Guid = New Guid("3e428570-705e-4bed-9d7b-62cc6f7ea32f")
			guidToNameMapping1.Name = "toolWindow1"
			guidToNameMapping2.Guid = New Guid("b489d229-833b-49fa-92e1-e7992b2fcc56")
			guidToNameMapping2.Name = "toolWindow2"
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping1)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping2)
			Me.radDock1.IsCleanUpTarget = True
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(0, 0)
			Me.radDock1.Size = New Size(900, 650)
			Me.radDock1.TabIndex = 5
			Me.radDock1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Controls.Add(Me.imageMDIRadButton)
			Me.toolWindow1.Controls.Add(Me.reportMDIRadButton)
			Me.toolWindow1.Controls.Add(Me.orderMDIRadButton)
			Me.toolWindow1.Controls.Add(Me.customerMDIRadButton)
			Me.toolWindow1.Controls.Add(Me.label1)
			Me.toolWindow1.Controls.Add(Me.newMDIRadButton)
			Me.toolWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
            Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(287, 335)
            Me.toolWindow1.Text = "Settings"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(0, 0)
			Me.documentContainer1.SizeInfo.AbsoluteSize = New Size(597, 200)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.SizeInfo.SplitterCorrection = New Size(-89, 0)
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(606, 5)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Orientation = Orientation.Horizontal
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer1.Size = New Size(289, 640)
			Me.radSplitContainer1.SizeInfo.AbsoluteSize = New Size(289, 200)
			Me.radSplitContainer1.SizeInfo.SplitterCorrection = New Size(89, 0)
			Me.radSplitContainer1.TabIndex = 1
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.CanUpdateChildIndex = True
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(289, 361)
			Me.toolTabStrip1.SizeInfo.AutoSizeScale = New SizeF(0F, 0.06761006F)
			Me.toolTabStrip1.SizeInfo.SplitterCorrection = New Size(0, 43)
			Me.toolTabStrip1.TabIndex = 0
			Me.toolTabStrip1.TabStop = False
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.CanUpdateChildIndex = True
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 365)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(289, 275)
			Me.toolTabStrip2.SizeInfo.AutoSizeScale = New SizeF(0F, -0.06761006F)
			Me.toolTabStrip2.SizeInfo.SplitterCorrection = New Size(0, -43)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Controls.Add(Me.logRadTextBox)
			Me.toolWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(287, 249)
			Me.toolWindow2.Text = "Log"
			' 
			' Form1
			' 
			Me.AutoScaleMode = AutoScaleMode.None
			Me.ClientSize = New Size(900, 650)
			Me.Controls.Add(Me.radDock1)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "MDI Parent Form"
			Me.ThemeName = "TelerikMetro"
			CType(Me.logRadTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageMDIRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportMDIRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderMDIRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customerMDIRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.newMDIRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			Me.toolWindow1.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip2.ResumeLayout(False)
			Me.toolWindow2.ResumeLayout(False)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private newMDIRadButton As Telerik.WinControls.UI.RadButton
		Private logRadTextBox As Telerik.WinControls.UI.RadTextBox
		Private label1 As Label
		Private openFileDialog As OpenFileDialog
		Private saveFileDialog As SaveFileDialog
		Private reportMDIRadButton As Telerik.WinControls.UI.RadButton
		Private orderMDIRadButton As Telerik.WinControls.UI.RadButton
		Private customerMDIRadButton As Telerik.WinControls.UI.RadButton
		Private imageMDIRadButton As Telerik.WinControls.UI.RadButton
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow

	End Class
End Namespace