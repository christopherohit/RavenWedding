Imports Microsoft.VisualBasic
Imports System
Namespace DiagramOrganizationChart
	Public Partial Class OrgChartForm
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
			Me.radDiagram1 = New Telerik.WinControls.UI.RadDiagram()
			CType(Me.radDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDiagram1
			' 
			Me.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radDiagram1.Location = New System.Drawing.Point(0, 0)
			Me.radDiagram1.Name = "radDiagram1"
			Me.radDiagram1.Size = New System.Drawing.Size(1201, 734)
			Me.radDiagram1.TabIndex = 0
			Me.radDiagram1.Text = "radDiagram1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1201, 734)
			Me.Controls.Add(Me.radDiagram1)
			Me.Name = "Form1"
			Me.Text = "Organization Chart"
			CType(Me.radDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDiagram1 As Telerik.WinControls.UI.RadDiagram
	End Class
End Namespace

