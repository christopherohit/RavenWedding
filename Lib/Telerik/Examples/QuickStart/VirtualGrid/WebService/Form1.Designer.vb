
Namespace Telerik.Examples.WinControls.VirtualGrid.WebService
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radVirtualGrid1.SuspendLayout()
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.AllowFiltering = False
			Me.radVirtualGrid1.ColumnCount = 100
			Me.radVirtualGrid1.Controls.Add(Me.radButton1)
			Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.RowCount = 1000
			Me.radVirtualGrid1.Size = New System.Drawing.Size(685, 544)
			Me.radVirtualGrid1.StandardTab = False
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(254, 260)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(176, 35)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Load Data from JSON service"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1533, 1000)
			Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radVirtualGrid1.ResumeLayout(False)
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

        Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
        Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace


