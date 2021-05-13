Namespace Telerik.Examples.WinControls.Map.Shapefile
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
			Me.radMap1 = New Telerik.WinControls.UI.RadMap()
			Me.radGroupBoxOptions = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonReserve = New Telerik.WinControls.UI.RadButton()
			Me.radButtonBuyNow = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxOptions.SuspendLayout()
			CType(Me.radButtonReserve, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonBuyNow, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxOptions)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxOptions, 0)
			' 
			' radMap1
			' 
			Me.radMap1.Dock = DockStyle.Fill
			Me.radMap1.Location = New Point(0, 0)
			Me.radMap1.Name = "radMap1"
			Me.radMap1.ShowMiniMap = False
			Me.radMap1.ShowNavigationBar = False
			Me.radMap1.ShowScaleIndicator = False
			Me.radMap1.ShowSearchBar = False
			Me.radMap1.Size = New Size(1282, 626)
			Me.radMap1.TabIndex = 0
			Me.radMap1.Text = "radMap1"
			' 
			' radGroupBoxOptions
			' 
			Me.radGroupBoxOptions.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxOptions.Anchor = AnchorStyles.Top
			Me.radGroupBoxOptions.Controls.Add(Me.radButtonReserve)
			Me.radGroupBoxOptions.Controls.Add(Me.radButtonBuyNow)
			Me.radGroupBoxOptions.HeaderText = "Purchase options"
			Me.radGroupBoxOptions.Location = New Point(10, 33)
			Me.radGroupBoxOptions.Name = "radGroupBoxOptions"
			Me.radGroupBoxOptions.Size = New Size(210, 85)
			Me.radGroupBoxOptions.TabIndex = 1
			Me.radGroupBoxOptions.Text = "Purchase options"
			' 
			' radButtonReserve
			' 
			Me.radButtonReserve.Anchor = AnchorStyles.Top
			Me.radButtonReserve.Location = New Point(5, 57)
			Me.radButtonReserve.Name = "radButtonReserve"
			Me.radButtonReserve.Size = New Size(200, 24)
			Me.radButtonReserve.TabIndex = 0
			Me.radButtonReserve.Text = "Reserve"
'			Me.radButtonReserve.Click += New System.EventHandler(Me.radButtonReserve_Click)
			' 
			' radButtonBuyNow
			' 
			Me.radButtonBuyNow.Anchor = AnchorStyles.Top
			Me.radButtonBuyNow.Location = New Point(5, 29)
			Me.radButtonBuyNow.Name = "radButtonBuyNow"
			Me.radButtonBuyNow.Size = New Size(200, 24)
			Me.radButtonBuyNow.TabIndex = 0
			Me.radButtonBuyNow.Text = "Buy Now"
'			Me.radButtonBuyNow.Click += New System.EventHandler(Me.radButtonBuyNow_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radMap1)
			Me.Name = "Form1"
			Me.Size = New Size(1292, 636)
			Me.Controls.SetChildIndex(Me.radMap1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxOptions.ResumeLayout(False)
			CType(Me.radButtonReserve, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonBuyNow, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMap1 As Telerik.WinControls.UI.RadMap
		Private radGroupBoxOptions As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radButtonReserve As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonBuyNow As Telerik.WinControls.UI.RadButton
	End Class
End Namespace