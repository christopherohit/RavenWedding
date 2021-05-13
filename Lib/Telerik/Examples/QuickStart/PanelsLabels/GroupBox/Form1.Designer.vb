Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.PanelsLabels.GroupBox
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton5 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton6 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton11 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton10 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton9 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton8 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton7 = New Telerik.WinControls.UI.RadRadioButton()
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.radRadioButton11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1315, 1)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(250, 1038)
			Me.settingsPanel.Size = New Size(250, 1038)
			' 
			' optionsLabel
			' 
			Me.optionsLabel.Location = New Point(5, 5)
			Me.optionsLabel.Margin = New Padding(4, 4, 4, 4)
			Me.optionsLabel.Size = New Size(87, 27)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radGroupBox2)
			Me.radGroupBox1.Controls.Add(Me.radGroupBox3)
			Me.radGroupBox1.Controls.Add(Me.radGroupBox4)
			Me.radGroupBox1.HeaderImage = My.Resources.info2
			Me.radGroupBox1.HeaderText = "Telerik Groupbox "
			Me.radGroupBox1.Location = New Point(0, 0)
			Me.radGroupBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(12, 25, 12, 12)
			Me.radGroupBox1.Size = New Size(1208, 444)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Telerik Groupbox "
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox2.HeaderText = "Groupbox style"
			Me.radGroupBox2.Location = New Point(65, 347)
			Me.radGroupBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(12, 25, 12, 12)
			Me.radGroupBox2.Size = New Size(391, 81)
			Me.radGroupBox2.TabIndex = 0
			Me.radGroupBox2.Text = "Groupbox style"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New Point(15, 30)
			Me.radRadioButton2.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(80, 22)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Standard"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Location = New Point(160, 30)
			Me.radRadioButton1.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(61, 22)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "Office"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Controls.Add(Me.tableLayoutPanel2)
			Me.radGroupBox3.HeaderText = "Header Position"
			Me.radGroupBox3.Location = New Point(65, 54)
			Me.radGroupBox3.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(12, 25, 12, 12)
			Me.radGroupBox3.Size = New Size(145, 270)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Header Position"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Location = New Point(4, 4)
			Me.radRadioButton3.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.Size = New Size(48, 22)
			Me.radRadioButton3.TabIndex = 0
			Me.radRadioButton3.Text = "Top"
			' 
			' radRadioButton5
			' 
			Me.radRadioButton5.Location = New Point(4, 96)
			Me.radRadioButton5.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton5.Name = "radRadioButton5"
			Me.radRadioButton5.Size = New Size(71, 22)
			Me.radRadioButton5.TabIndex = 2
			Me.radRadioButton5.Text = "Bottom"
			' 
			' radRadioButton6
			' 
			Me.radRadioButton6.Location = New Point(4, 142)
			Me.radRadioButton6.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton6.Name = "radRadioButton6"
			Me.radRadioButton6.Size = New Size(47, 22)
			Me.radRadioButton6.TabIndex = 3
			Me.radRadioButton6.Text = "Left"
			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.Location = New Point(4, 50)
			Me.radRadioButton4.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton4.Name = "radRadioButton4"
			Me.radRadioButton4.Size = New Size(57, 22)
			Me.radRadioButton4.TabIndex = 1
			Me.radRadioButton4.Text = "Right"
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Controls.Add(Me.tableLayoutPanel1)
			Me.radGroupBox4.HeaderText = "Text and Image Relation"
			Me.radGroupBox4.Location = New Point(220, 54)
			Me.radGroupBox4.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New Padding(12, 25, 12, 12)
			Me.radGroupBox4.Size = New Size(236, 270)
			Me.radGroupBox4.TabIndex = 2
			Me.radGroupBox4.Text = "Text and Image Relation"
			' 
			' radRadioButton11
			' 
			Me.radRadioButton11.Location = New Point(4, 192)
			Me.radRadioButton11.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton11.Name = "radRadioButton11"
			Me.radRadioButton11.Size = New Size(137, 22)
			Me.radRadioButton11.TabIndex = 4
			Me.radRadioButton11.Text = "Text before image"
			' 
			' radRadioButton10
			' 
			Me.radRadioButton10.Location = New Point(4, 145)
			Me.radRadioButton10.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton10.Name = "radRadioButton10"
			Me.radRadioButton10.Size = New Size(135, 22)
			Me.radRadioButton10.TabIndex = 3
			Me.radRadioButton10.Text = "Text above image"
			' 
			' radRadioButton9
			' 
			Me.radRadioButton9.Location = New Point(4, 98)
			Me.radRadioButton9.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton9.Name = "radRadioButton9"
			Me.radRadioButton9.Size = New Size(71, 22)
			Me.radRadioButton9.TabIndex = 2
			Me.radRadioButton9.Text = "Overlay"
			' 
			' radRadioButton8
			' 
			Me.radRadioButton8.Location = New Point(4, 51)
			Me.radRadioButton8.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton8.Name = "radRadioButton8"
			Me.radRadioButton8.Size = New Size(135, 22)
			Me.radRadioButton8.TabIndex = 1
			Me.radRadioButton8.Text = "Image before text"
			' 
			' radRadioButton7
			' 
			Me.radRadioButton7.Location = New Point(4, 4)
			Me.radRadioButton7.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioButton7.Name = "radRadioButton7"
			Me.radRadioButton7.Size = New Size(132, 22)
			Me.radRadioButton7.TabIndex = 0
			Me.radRadioButton7.Text = "Image above text"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.radRadioButton11, 0, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.radRadioButton7, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radRadioButton10, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radRadioButton8, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radRadioButton9, 0, 2)
			Me.tableLayoutPanel1.Location = New Point(21, 26)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 5
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.Size = New Size(200, 236)
			Me.tableLayoutPanel1.TabIndex = 3
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.ColumnCount = 1
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel2.Controls.Add(Me.radRadioButton6, 0, 3)
			Me.tableLayoutPanel2.Controls.Add(Me.radRadioButton5, 0, 2)
			Me.tableLayoutPanel2.Controls.Add(Me.radRadioButton3, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.radRadioButton4, 0, 1)
			Me.tableLayoutPanel2.Location = New Point(15, 28)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 4
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel2.Size = New Size(115, 186)
			Me.tableLayoutPanel2.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radGroupBox1)
			Me.Name = "Form1"
			Me.Size = New Size(1822, 1104)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			CType(Me.radRadioButton11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.tableLayoutPanel2.ResumeLayout(False)
			Me.tableLayoutPanel2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton6 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton5 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton4 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton7 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton8 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton9 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton10 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton11 As Telerik.WinControls.UI.RadRadioButton
		Private tableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace
