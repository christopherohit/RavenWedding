Namespace Telerik.Examples.WinControls.Editors.TextBoxControl
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
			Me.radBtnSetBackgroundImage = New Telerik.WinControls.UI.RadButton()
			Me.radTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radButtonSearch = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radBtnSetBackgroundImage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radButtonSearch, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1341, 24)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radBtnSetBackgroundImage)
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(86, 759)
			Me.settingsPanel.Size = New Size(86, 780)
			' 
			' radBtnSetBackgroundImage
			' 
			Me.radBtnSetBackgroundImage.Anchor = AnchorStyles.Top
			Me.radBtnSetBackgroundImage.Location = New Point(-76, 25)
			Me.radBtnSetBackgroundImage.Margin = New Padding(4, 4, 4, 4)
			Me.radBtnSetBackgroundImage.Name = "radBtnSetBackgroundImage"
			Me.radBtnSetBackgroundImage.Size = New Size(61, 30)
			Me.radBtnSetBackgroundImage.TabIndex = 1
			Me.radBtnSetBackgroundImage.Text = "Set Background Image"
			' 
			' radTextBoxControl1
			' 
			Me.radTextBoxControl1.Location = New Point(129, 171)
			Me.radTextBoxControl1.Margin = New Padding(4, 4, 4, 4)
			Me.radTextBoxControl1.Name = "radTextBoxControl1"
			Me.radTextBoxControl1.NullText = "Search in Bing"
			Me.radTextBoxControl1.ShowClearButton = True
			Me.radTextBoxControl1.Size = New Size(465, 35)
			Me.radTextBoxControl1.TabIndex = 2
			CType(Me.radTextBoxControl1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxControlElement).BackgroundImage = My.Resources.textbox_bg
			CType(Me.radTextBoxControl1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.TextBoxViewElement).Padding = New Padding(31, 8, 3, 0)
			CType(Me.radTextBoxControl1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.TextBoxWrapPanel).Padding = New Padding(31, 8, 3, 0)
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = My.Resources.ballons_image
			Me.radPanel1.BackgroundImageLayout = ImageLayout.Stretch
			Me.radPanel1.Controls.Add(Me.radButtonSearch)
			Me.radPanel1.Controls.Add(Me.radTextBoxControl1)
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Margin = New Padding(4, 4, 4, 4)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(752, 525)
			Me.radPanel1.TabIndex = 3
			' 
			' radButtonSearch
			' 
			Me.radButtonSearch.Image = My.Resources.search
			Me.radButtonSearch.ImageAlignment = ContentAlignment.MiddleCenter
			Me.radButtonSearch.Location = New Point(601, 171)
			Me.radButtonSearch.Margin = New Padding(4, 4, 4, 4)
			Me.radButtonSearch.Name = "radButtonSearch"
			Me.radButtonSearch.Size = New Size(40, 35)
			Me.radButtonSearch.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96, 96)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(2527, 1464)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radBtnSetBackgroundImage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radButtonSearch, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radBtnSetBackgroundImage As Telerik.WinControls.UI.RadButton
		Private radTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radButtonSearch As Telerik.WinControls.UI.RadButton
	End Class
End Namespace