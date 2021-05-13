Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Docking.Programming
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
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.documentContainer2 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.textBox1 = New TextBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboBox2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.label3 = New Telerik.WinControls.UI.RadLabel()
			Me.label1 = New Telerik.WinControls.UI.RadLabel()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.label2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip3.SuspendLayout()
			CType(Me.documentContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer2.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.label3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.label1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.label2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow2
			Me.radDock1.Controls.Add(Me.toolTabStrip1)
			Me.radDock1.Controls.Add(Me.radSplitContainer1)
			Me.radDock1.Cursor = Cursors.HSplit
			Me.radDock1.Dock = DockStyle.Fill
			Me.radDock1.IsCleanUpTarget = True
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer2
			Me.radDock1.Name = "radDock1"
			Me.radDock1.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(25, 25)
			Me.radDock1.Size = New Size(692, 544)
			Me.radDock1.TabIndex = 4
			Me.radDock1.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(198, 304)
			Me.toolWindow2.Text = "Tool Window 2"
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.CanUpdateChildIndex = True
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(5, 5)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(682, 200)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(680, 174)
			Me.toolWindow1.Text = "Tool Window 1"
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip3)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer2)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(5, 209)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(682, 330)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.CanUpdateChildIndex = True
			Me.toolTabStrip3.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip3.Location = New Point(0, 0)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New Size(200, 330)
			Me.toolTabStrip3.SizeInfo.AutoSizeScale = New SizeF(-0.02554595F, 0F)
			Me.toolTabStrip3.SizeInfo.SplitterCorrection = New Size(-1190, 0)
			Me.toolTabStrip3.TabIndex = 3
			Me.toolTabStrip3.TabStop = False
			' 
			' documentContainer2
			' 
			Me.documentContainer2.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer2.Name = "documentContainer2"
			' 
			' 
			' 
			Me.documentContainer2.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer2.TabIndex = 4
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CanUpdateChildIndex = True
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(478, 330)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow1.Location = New Point(6, 29)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow1.Size = New Size(466, 295)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New Point(4, 161)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ReadOnly = True
			Me.textBox1.ScrollBars = ScrollBars.Both
			Me.textBox1.Size = New Size(343, 379)
			Me.textBox1.TabIndex = 7
			Me.textBox1.WordWrap = False
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radComboBox2)
			Me.radGroupBox1.Controls.Add(Me.label3)
			Me.radGroupBox1.Controls.Add(Me.label1)
			Me.radGroupBox1.Controls.Add(Me.radComboBox1)
			Me.radGroupBox1.Controls.Add(Me.radButton1)
			Me.radGroupBox1.Controls.Add(Me.label2)
			Me.radGroupBox1.Controls.Add(Me.textBox1)
			Me.radGroupBox1.Dock = DockStyle.Right
			Me.radGroupBox1.HeaderText = "Settings"
			Me.radGroupBox1.Location = New Point(692, 0)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(4, 110, 4, 4)
			Me.radGroupBox1.Size = New Size(351, 544)
			Me.radGroupBox1.TabIndex = 8
			Me.radGroupBox1.Text = "Settings"
			' 
			' radComboBox2
			' 
			Me.radComboBox2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox2.Location = New Point(112, 68)
			Me.radComboBox2.Name = "radComboBox2"
			Me.radComboBox2.Size = New Size(154, 24)
			Me.radComboBox2.TabIndex = 20
			Me.radComboBox2.Text = "radComboBox2"
			' 
			' label3
			' 
			Me.label3.Location = New Point(10, 73)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(63, 18)
			Me.label3.TabIndex = 19
			Me.label3.Text = "Dock State:"
			' 
			' label1
			' 
			Me.label1.Location = New Point(10, 28)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(78, 18)
			Me.label1.TabIndex = 18
			Me.label1.Text = "Dock Window:"
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.Location = New Point(113, 23)
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.Size = New Size(154, 24)
			Me.radComboBox1.TabIndex = 17
			Me.radComboBox1.Text = "radComboBox1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(113, 113)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(154, 23)
			Me.radButton1.TabIndex = 16
			Me.radButton1.Text = "Clear"
			' 
			' label2
			' 
			Me.label2.Location = New Point(3, 122)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(58, 18)
			Me.label2.TabIndex = 15
			Me.label2.Text = "Event Log:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(1043, 544)
			Me.Controls.Add(Me.radDock1)
			Me.Controls.Add(Me.radGroupBox1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Programming RadDock"
			Me.ThemeName = "Fluent"
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip3.ResumeLayout(False)
			CType(Me.documentContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer2.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.label3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.label1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.label2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private textBox1 As TextBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private label2 As RadLabel
		Private documentContainer2 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private label1 As RadLabel
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private label3 As RadLabel
		Private radComboBox2 As Telerik.WinControls.UI.RadDropDownList
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip

	End Class
End Namespace