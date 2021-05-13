Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GanttView.Printing
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintPreview = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintSettings = New Telerik.WinControls.UI.RadButton()
			Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.buttonPrint)
			Me.settingsPanel.Controls.Add(Me.buttonPrintPreview)
			Me.settingsPanel.Controls.Add(Me.buttonPrintSettings)
			Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
			Me.settingsPanel.Location = New System.Drawing.Point(1107, 0)
			Me.settingsPanel.Size = New System.Drawing.Size(286, 831)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrintPreview, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonPrint, 0)
			' 
			' buttonPrint
			' 
			Me.buttonPrint.Location = New System.Drawing.Point(18, 59)
			Me.buttonPrint.Name = "buttonPrint"
			Me.buttonPrint.Size = New System.Drawing.Size(130, 24)
			Me.buttonPrint.TabIndex = 1
			Me.buttonPrint.Text = "Print"
			' 
			' buttonPrintPreview
			' 
			Me.buttonPrintPreview.Location = New System.Drawing.Point(18, 89)
			Me.buttonPrintPreview.Name = "buttonPrintPreview"
			Me.buttonPrintPreview.Size = New System.Drawing.Size(130, 24)
			Me.buttonPrintPreview.TabIndex = 1
			Me.buttonPrintPreview.Text = "Print Preview"
			' 
			' buttonPrintSettings
			' 
			Me.buttonPrintSettings.Location = New System.Drawing.Point(18, 119)
			Me.buttonPrintSettings.Name = "buttonPrintSettings"
			Me.buttonPrintSettings.Size = New System.Drawing.Size(130, 24)
			Me.buttonPrintSettings.TabIndex = 1
			Me.buttonPrintSettings.Text = "Print Settings"
			' 
			' radGanttView1
			' 
			Me.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGanttView1.Location = New System.Drawing.Point(0, 0)
			Me.radGanttView1.Name = "radGanttView1"
			Me.radGanttView1.Size = New System.Drawing.Size(1004, 600)
			Me.radGanttView1.TabIndex = 0
			Me.radGanttView1.Text = "radGanttView1"
			Me.radGanttView1.ThemeName = "TelerikMetroBlue"
			Me.radGanttView1.Ratio = 0.3970588f
			Me.radGanttView1.GanttViewElement.AllowDefaultContextMenu = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1016, 651)
			Me.Controls.Add(Me.radGanttView1)
			Me.Name = "Form1"
			Me.Text = "RadGanttViewExample"
			' 
			' 
			' 
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		#End Region

		Private buttonPrint As Telerik.WinControls.UI.RadButton
		Private buttonPrintPreview As Telerik.WinControls.UI.RadButton
		Private buttonPrintSettings As Telerik.WinControls.UI.RadButton
		Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
	End Class
End Namespace

