Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.DragAndDrop
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radListBox2 = New Telerik.WinControls.UI.RadListControl()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radButton7 = New Telerik.WinControls.UI.RadButton()
			Me.radButton8 = New Telerik.WinControls.UI.RadButton()
			Me.radButton5 = New Telerik.WinControls.UI.RadButton()
			Me.radButton6 = New Telerik.WinControls.UI.RadButton()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1364, 1)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(267, 1007)
			Me.settingsPanel.Size = New Size(267, 1007)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radListBox1
			' 
			Me.radListBox1.FormatString = "{0}"
			Me.radListBox1.ItemHeight = 24
			radListDataItem1.Image = My.Resources.lb_m4
			radListDataItem1.Text = "Tuna Salad"
			radListDataItem2.Image = My.Resources.lb_m3
			radListDataItem2.Text = "Grilled Salmon "
			radListDataItem3.Image = My.Resources.lb_m2
			radListDataItem3.Text = "Sashimi Salad"
			radListDataItem4.Image = My.Resources.lb_m1
			radListDataItem4.Text = "Fresh Mussels"
			Me.radListBox1.Items.Add(radListDataItem1)
			Me.radListBox1.Items.Add(radListDataItem2)
			Me.radListBox1.Items.Add(radListDataItem3)
			Me.radListBox1.Items.Add(radListDataItem4)
			Me.radListBox1.Location = New Point(60, 217)
			Me.radListBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Size = New Size(340, 314)
			Me.radListBox1.TabIndex = 1
			CType(Me.radListBox1.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Font = New Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			CType(Me.radListBox1.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Opacity = 0.8R
			' 
			' radListBox2
			' 
			Me.radListBox2.FormatString = "{0}"
			Me.radListBox2.ItemHeight = 24
			Me.radListBox2.Location = New Point(616, 217)
			Me.radListBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radListBox2.Name = "radListBox2"
			Me.radListBox2.Size = New Size(340, 314)
			Me.radListBox2.TabIndex = 2
			CType(Me.radListBox2.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Font = New Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			CType(Me.radListBox2.GetChildAt(0), Telerik.WinControls.UI.RadListElement).Opacity = 0.8R
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(436, 367)
			Me.radButton1.Margin = New Padding(4, 4, 4, 4)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(137, 30)
			Me.radButton1.TabIndex = 5
			Me.radButton1.Text = "Include Selected"
			' 
			' radButton2
			' 
			Me.radButton2.Location = New Point(436, 405)
			Me.radButton2.Margin = New Padding(4, 4, 4, 4)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(137, 30)
			Me.radButton2.TabIndex = 6
			Me.radButton2.Text = "Exclude Selected"
			' 
			' radButton3
			' 
			Me.radButton3.Location = New Point(436, 443)
			Me.radButton3.Margin = New Padding(4, 4, 4, 4)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New Size(137, 30)
			Me.radButton3.TabIndex = 7
			Me.radButton3.Text = "Include All"
			' 
			' radButton4
			' 
			Me.radButton4.Location = New Point(436, 481)
			Me.radButton4.Margin = New Padding(4, 4, 4, 4)
			Me.radButton4.Name = "radButton4"
			Me.radButton4.Size = New Size(137, 30)
			Me.radButton4.TabIndex = 8
			Me.radButton4.Text = "Exclude All"
			' 
			' radButton7
			' 
			Me.radButton7.Image = My.Resources.lb_arr_up
			Me.radButton7.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radButton7.Location = New Point(436, 235)
			Me.radButton7.Margin = New Padding(4, 4, 4, 4)
			Me.radButton7.Name = "radButton7"
			Me.radButton7.Size = New Size(35, 31)
			Me.radButton7.TabIndex = 11
			' 
			' radButton8
			' 
			Me.radButton8.Image = My.Resources.lb_arr_down
			Me.radButton8.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radButton8.Location = New Point(436, 273)
			Me.radButton8.Margin = New Padding(4, 4, 4, 4)
			Me.radButton8.Name = "radButton8"
			Me.radButton8.Size = New Size(35, 31)
			Me.radButton8.TabIndex = 12
			' 
			' radButton5
			' 
			Me.radButton5.Image = My.Resources.lb_arr_up
			Me.radButton5.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radButton5.Location = New Point(984, 235)
			Me.radButton5.Margin = New Padding(4, 4, 4, 4)
			Me.radButton5.Name = "radButton5"
			Me.radButton5.Size = New Size(35, 31)
			Me.radButton5.TabIndex = 13
			' 
			' radButton6
			' 
			Me.radButton6.Image = My.Resources.lb_arr_down
			Me.radButton6.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radButton6.Location = New Point(984, 273)
			Me.radButton6.Margin = New Padding(4, 4, 4, 4)
			Me.radButton6.Name = "radButton6"
			Me.radButton6.Size = New Size(35, 31)
			Me.radButton6.TabIndex = 14
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.Location = New Point(0, 0)
			Me.radPanelDemoHolder.Margin = New Padding(4, 4, 4, 4)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			Me.radPanelDemoHolder.Size = New Size(1081, 597)
			Me.radPanelDemoHolder.TabIndex = 15
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = My.Resources.lb_bg
			Me.radPanel1.BackgroundImageLayout = ImageLayout.Stretch
			Me.radPanel1.Controls.Add(Me.radButton5)
			Me.radPanel1.Controls.Add(Me.radButton6)
			Me.radPanel1.Controls.Add(Me.radListBox1)
			Me.radPanel1.Controls.Add(Me.radListBox2)
			Me.radPanel1.Controls.Add(Me.radButton3)
			Me.radPanel1.Controls.Add(Me.radButton7)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.Controls.Add(Me.radButton8)
			Me.radPanel1.Controls.Add(Me.radButton4)
			Me.radPanel1.Controls.Add(Me.radButton2)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Margin = New Padding(4, 4, 4, 4)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(1081, 597)
			Me.radPanel1.TabIndex = 15
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.Name = "Form1"
			Me.Size = New Size(2653, 1464)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListBox1 As Telerik.WinControls.UI.RadListControl

		Private radListBox2 As Telerik.WinControls.UI.RadListControl
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton4 As Telerik.WinControls.UI.RadButton
		Private radButton7 As Telerik.WinControls.UI.RadButton
		Private radButton8 As Telerik.WinControls.UI.RadButton
		Private radButton5 As Telerik.WinControls.UI.RadButton
		Private radButton6 As Telerik.WinControls.UI.RadButton
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
