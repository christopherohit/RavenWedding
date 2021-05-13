Namespace Telerik.Examples.WinControls.PivotGrid.Printing
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
			Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintPreview = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintSettings = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.buttonPrint)
			Me.settingsPanel.Controls.Add(Me.buttonPrintPreview)
			Me.settingsPanel.Controls.Add(Me.buttonPrintSettings)
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(1107, 0)
			Me.settingsPanel.Size = New Size(286, 831)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintPreview, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrint, 0)
			' 
			' buttonPrint
			' 
			Me.buttonPrint.Location = New Point(18, 59)
			Me.buttonPrint.Name = "buttonPrint"
			Me.buttonPrint.Size = New Size(130, 24)
			Me.buttonPrint.TabIndex = 1
			Me.buttonPrint.Text = "Print"
			' 
			' buttonPrintPreview
			' 
			Me.buttonPrintPreview.Location = New Point(18, 89)
			Me.buttonPrintPreview.Name = "buttonPrintPreview"
			Me.buttonPrintPreview.Size = New Size(130, 24)
			Me.buttonPrintPreview.TabIndex = 1
			Me.buttonPrintPreview.Text = "Print Preview"
			' 
			' buttonPrintSettings
			' 
			Me.buttonPrintSettings.Location = New Point(18, 119)
			Me.buttonPrintSettings.Name = "buttonPrintSettings"
			Me.buttonPrintSettings.Size = New Size(130, 24)
			Me.buttonPrintSettings.TabIndex = 1
			Me.buttonPrintSettings.Text = "Print Settings"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New Size(1403, 841)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private buttonPrint As Telerik.WinControls.UI.RadButton
		Private buttonPrintPreview As Telerik.WinControls.UI.RadButton
		Private buttonPrintSettings As Telerik.WinControls.UI.RadButton
	End Class
End Namespace