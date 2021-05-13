Namespace Telerik.Examples.WinControls.Map.Layers
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
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMap1
			' 
			Me.radMap1.Dock = DockStyle.Fill
			Me.radMap1.Location = New Point(0, 0)
			Me.radMap1.Name = "radMap1"
			Me.radMap1.ShowSearchBar = False
			Me.radMap1.ShowMiniMap = False
			Me.radMap1.Size = New Size(1871, 1028)
			Me.radMap1.TabIndex = 0
			Me.radMap1.Text = "radMap1"
'			Me.radMap1.Click += radMap1_Click
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radMap1)
			Me.Name = "Form1"
			Me.Size = New Size(1881, 1038)
			Me.Controls.SetChildIndex(Me.radMap1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

        Private WithEvents radMap1 As Telerik.WinControls.UI.RadMap
	End Class
End Namespace