Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
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
			Me.surface1 = New Telerik.Examples.WinControls.PropertyGrid.FirstLook.Surface()
			Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
			Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.radButtonRemove = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.surface1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me.radButtonRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButtonRemove)
			Me.settingsPanel.Controls.Add(Me.radDropDownButton1)
			Me.settingsPanel.Location = New Point(729, 1)
			Me.settingsPanel.Size = New Size(200, 548)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownButton1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonRemove, 0)
			' 
			' surface1
			' 
			Me.surface1.Dock = DockStyle.Fill
			Me.surface1.Location = New Point(0, 0)
			Me.surface1.Name = "surface1"
			Me.surface1.Size = New Size(232, 348)
			Me.surface1.TabIndex = 0
			' 
			' radPropertyGrid1
			' 
			Me.radPropertyGrid1.Dock = DockStyle.Fill
			Me.radPropertyGrid1.Location = New Point(0, 0)
			Me.radPropertyGrid1.Name = "radPropertyGrid1"
			Me.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical
			Me.radPropertyGrid1.Size = New Size(231, 348)
			Me.radPropertyGrid1.SortOrder = SortOrder.Ascending
			Me.radPropertyGrid1.TabIndex = 0
			Me.radPropertyGrid1.Text = "radPropertyGrid1"
			Me.radPropertyGrid1.ToolbarVisible = True
			' 
			' radDropDownButton1
			' 
			Me.radDropDownButton1.Anchor = AnchorStyles.Top
			Me.radDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5})
			Me.radDropDownButton1.Location = New Point(10, 42)
			Me.radDropDownButton1.Name = "radDropDownButton1"
			Me.radDropDownButton1.Size = New Size(180, 24)
			Me.radDropDownButton1.TabIndex = 1
			Me.radDropDownButton1.Text = "Add"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "Button"
			Me.radMenuItem1.AccessibleName = "Button"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Button"
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Label"
			Me.radMenuItem2.AccessibleName = "Label"
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Label"
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Checkbox"
			Me.radMenuItem3.AccessibleName = "Checkbox"
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Checkbox"
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Radio Button"
			Me.radMenuItem4.AccessibleName = "Radio Button"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Radio Button"
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "ScrollBar"
			Me.radMenuItem5.AccessibleName = "ScrollBar"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "ScrollBar"
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.EnableElementShadow = False
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(700, 500)
			Me.radSplitContainer1.SplitterWidth = 4
			Me.radSplitContainer1.TabIndex = 2
			Me.radSplitContainer1.TabStop = False
			Me.radSplitContainer1.Text = "radSplitContainer1"
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.surface1)
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel1.Size = New Size(232, 348)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Controls.Add(Me.radPropertyGrid1)
			Me.splitPanel2.Location = New Point(236, 0)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel2.Size = New Size(231, 348)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' radButtonRemove
			' 
			Me.radButtonRemove.Anchor = AnchorStyles.Top
			Me.radButtonRemove.Location = New Point(10, 73)
			Me.radButtonRemove.Name = "radButtonRemove"
			Me.radButtonRemove.Size = New Size(180, 24)
			Me.radButtonRemove.TabIndex = 2
			Me.radButtonRemove.Text = "Remove"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radSplitContainer1)
			Me.Name = "Form1"
			Me.Size = New Size(1223, 619)
			Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.surface1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			CType(Me.radButtonRemove, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private surface1 As Surface
		Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
		Private radDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private radButtonRemove As Telerik.WinControls.UI.RadButton
	End Class
End Namespace

