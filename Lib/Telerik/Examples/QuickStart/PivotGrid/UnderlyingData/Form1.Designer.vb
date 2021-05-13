Namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
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
			Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
			Me.radPivotFieldList1 = New Telerik.WinControls.UI.RadPivotFieldList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPivotGrid1
			' 
			Me.radPivotGrid1.Dock = DockStyle.Fill
			Me.radPivotGrid1.Location = New Point(0, 0)
			Me.radPivotGrid1.Name = "radPivotGrid1"
			Me.radPivotGrid1.Size = New Size(1232, 1006)
			Me.radPivotGrid1.TabIndex = 0
			Me.radPivotGrid1.Text = "radPivotGrid1"
			' 
			' radPivotFieldList1
			' 
			Me.radPivotFieldList1.AssociatedPivotGrid = Me.radPivotGrid1
			Me.radPivotFieldList1.Dock = DockStyle.Right
			Me.radPivotFieldList1.Location = New Point(1232, 0)
			Me.radPivotFieldList1.MinimumSize = New Size(225, 305)
			Me.radPivotFieldList1.Name = "radPivotFieldList1"
			Me.radPivotFieldList1.Size = New Size(258, 1006)
			Me.radPivotFieldList1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPivotGrid1)
			Me.Controls.Add(Me.radPivotFieldList1)
			Me.Name = "Form1"
			Me.Size = New Size(1500, 1016)
			Me.Controls.SetChildIndex(Me.radPivotFieldList1, 0)
			Me.Controls.SetChildIndex(Me.radPivotGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
		Private radPivotFieldList1 As Telerik.WinControls.UI.RadPivotFieldList
	End Class
End Namespace
