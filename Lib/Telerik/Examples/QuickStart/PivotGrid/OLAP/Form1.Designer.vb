﻿Namespace Telerik.Examples.WinControls.PivotGrid.OLAP
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radPivotFieldList1 = New Telerik.WinControls.UI.RadPivotFieldList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPivotGrid1.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPivotGrid1
			' 
			Me.radPivotGrid1.Controls.Add(Me.radButton1)
			Me.radPivotGrid1.DataMember = Nothing
			Me.radPivotGrid1.Dock = DockStyle.Fill
			Me.radPivotGrid1.Location = New Point(0, 0)
			Me.radPivotGrid1.Name = "radPivotGrid1"
			Me.radPivotGrid1.ShowFilterArea = True
			Me.radPivotGrid1.Size = New Size(814, 801)
			Me.radPivotGrid1.TabIndex = 0
			Me.radPivotGrid1.Text = "radPivotGrid1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(165, 245)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(215, 31)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Connect to ""Adventure Works"" Cube"

			' 
			' radPivotFieldList1
			' 
			Me.radPivotFieldList1.AssociatedPivotGrid = Me.radPivotGrid1
			Me.radPivotFieldList1.Dock = DockStyle.Right
			Me.radPivotFieldList1.Location = New Point(814, 0)
			Me.radPivotFieldList1.MinimumSize = New Size(225, 305)
			Me.radPivotFieldList1.Name = "radPivotFieldList1"
			Me.radPivotFieldList1.Size = New Size(258, 801)
			Me.radPivotFieldList1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPivotGrid1)
			Me.Controls.Add(Me.radPivotFieldList1)
			Me.Name = "Form1"
			Me.Size = New Size(1082, 811)
			Me.Controls.SetChildIndex(Me.radPivotFieldList1, 0)
			Me.Controls.SetChildIndex(Me.radPivotGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPivotGrid1.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		#End Region

		Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
		Private radPivotFieldList1 As Telerik.WinControls.UI.RadPivotFieldList
		Private radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace