Namespace Telerik.Examples.WinControls.PropertyGrid.Validation
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
			Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPropertyGrid1
			' 
			Me.radPropertyGrid1.Location = New Point(0, 0)
			Me.radPropertyGrid1.Name = "radPropertyGrid1"
			Me.radPropertyGrid1.Size = New Size(400, 600)
			Me.radPropertyGrid1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPropertyGrid1)
			Me.Name = "Form1"
			Me.Size = New Size(1502, 737)
			Me.Controls.SetChildIndex(Me.radPropertyGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
	End Class
End Namespace