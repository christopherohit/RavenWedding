Namespace Telerik.Examples.WinControls.SplitContainer.CollapsingPanels
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
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel3 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel4 = New Telerik.WinControls.UI.SplitPanel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBox2)
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.radDropDownList1)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New Point(723, 17)
			Me.settingsPanel.Size = New Size(230, 180)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox2, 0)
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel3)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel4)
			Me.radSplitContainer1.EnableCollapsing = False
			Me.radSplitContainer1.Location = New Point(0, 17)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer1.Size = New Size(661, 477)
			Me.radSplitContainer1.TabIndex = 2
			Me.radSplitContainer1.TabStop = False
			Me.radSplitContainer1.Text = "radSplitContainer1"
			Me.radSplitContainer1.UseSplitterButtons = False
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel1.Size = New Size(162, 477)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Location = New Point(166, 0)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel2.Size = New Size(162, 477)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' splitPanel3
			' 
			Me.splitPanel3.Location = New Point(332, 0)
			Me.splitPanel3.Name = "splitPanel3"
			' 
			' 
			' 
			Me.splitPanel3.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel3.Size = New Size(162, 477)
			Me.splitPanel3.TabIndex = 2
			Me.splitPanel3.TabStop = False
			Me.splitPanel3.Text = "splitPanel3"
			' 
			' splitPanel4
			' 
			Me.splitPanel4.Location = New Point(498, 0)
			Me.splitPanel4.Name = "splitPanel4"
			' 
			' 
			' 
			Me.splitPanel4.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel4.Size = New Size(163, 477)
			Me.splitPanel4.TabIndex = 3
			Me.splitPanel4.TabStop = False
			Me.splitPanel4.Text = "splitPanel4"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 52)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(68, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Orientation :"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.AllowShowFocusCues = False
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.Location = New Point(10, 76)
			Me.radDropDownList1.Name = "radDropDownList1"
			' 
			' 
			' 
			Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radDropDownList1.Size = New Size(210, 20)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.Text = "radDropDownList1"
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(10, 108)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(106, 18)
			Me.radCheckBox1.TabIndex = 4
			Me.radCheckBox1.Text = "EnableCollapsing"
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.Anchor = AnchorStyles.Top
			Me.radCheckBox2.Location = New Point(10, 132)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(113, 18)
			Me.radCheckBox2.TabIndex = 6
			Me.radCheckBox2.Text = "UseSplitterButtons"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radSplitContainer1)
			Me.Name = "Form1"
			Me.Size = New Size(1257, 600)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel3 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel4 As Telerik.WinControls.UI.SplitPanel
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace