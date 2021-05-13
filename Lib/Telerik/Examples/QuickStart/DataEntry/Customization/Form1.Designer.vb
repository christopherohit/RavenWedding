Namespace Telerik.Examples.WinControls.DataEntry.Customization
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
			Me.radDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDataEntry1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(571, 3)
			' 
			' radDataEntry1
			' 
			Me.radDataEntry1.AutoSize = False
			Me.radDataEntry1.FlowDirection = FlowDirection.LeftToRight
            Me.radDataEntry1.ItemDefaultSize = New Size(460, 25)
            Me.radDataEntry1.ItemSpace = 10
			Me.radDataEntry1.Location = New Point(0, 0)
            Me.radDataEntry1.Name = "radDataEntry1"
            Me.radDataEntry1.ShowValidationPanel = True
			' 
			' radDataEntry1.PanelContainer
			' 
			Me.radDataEntry1.PanelContainer.Size = New Size(487, 362)
			Me.radDataEntry1.ShowValidationPanel = False
			Me.radDataEntry1.Size = New Size(489, 364)
			Me.radDataEntry1.TabIndex = 2
			Me.radDataEntry1.Text = "radDataEntry1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radDataEntry1)
			Me.Name = "Form1"
			Me.Size = New Size(1243, 775)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radDataEntry1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDataEntry1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDataEntry1 As Telerik.WinControls.UI.RadDataEntry
	End Class
End Namespace