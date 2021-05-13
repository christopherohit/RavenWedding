Namespace Telerik.Examples.WinControls.PanelsLabels.Label
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel1)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.Size = New Size(416, 187)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(779, 1)
			Me.settingsPanel.Size = New Size(200, 784)
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel1.Location = New Point(0, 0)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(296, 80)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = resources.GetString("radLabel1.Text")
			Me.radLabel1.TextWrap = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1063, 516)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace