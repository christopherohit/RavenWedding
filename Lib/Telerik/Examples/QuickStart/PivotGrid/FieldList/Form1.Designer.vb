Namespace Telerik.Examples.WinControls.PivotGrid.FieldList
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
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.radPivotFieldList1 = New Telerik.WinControls.UI.RadPivotFieldList()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Dock = DockStyle.Fill
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(882, 497)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.radPivotGrid1)
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel1.Size = New Size(572, 497)
			Me.splitPanel1.SizeInfo.AutoSizeScale = New SizeF(0.1514806F, 0F)
			Me.splitPanel1.SizeInfo.SplitterCorrection = New Size(133, 0)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' radPivotGrid1
			' 
			Me.radPivotGrid1.DataMember = Nothing
			Me.radPivotGrid1.Dock = DockStyle.Fill
			Me.radPivotGrid1.Location = New Point(0, 0)
			Me.radPivotGrid1.Name = "radPivotGrid1"
			Me.radPivotGrid1.ShowFilterArea = True
			Me.radPivotGrid1.Size = New Size(572, 497)
			Me.radPivotGrid1.TabIndex = 0
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Controls.Add(Me.radPivotFieldList1)
			Me.splitPanel2.Location = New Point(576, 0)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel2.Size = New Size(306, 497)
			Me.splitPanel2.SizeInfo.AutoSizeScale = New SizeF(-0.1514806F, 0F)
			Me.splitPanel2.SizeInfo.MinimumSize = New Size(225, 25)
			Me.splitPanel2.SizeInfo.SplitterCorrection = New Size(-133, 0)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' radPivotFieldList1
			' 
			Me.radPivotFieldList1.AssociatedPivotGrid = Me.radPivotGrid1
			Me.radPivotFieldList1.Dock = DockStyle.Fill
			Me.radPivotFieldList1.Location = New Point(0, 0)
			Me.radPivotFieldList1.MinimumSize = New Size(225, 305)
			Me.radPivotFieldList1.Name = "radPivotFieldList1"
			Me.radPivotFieldList1.Size = New Size(306, 497)
			Me.radPivotFieldList1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(882, 497)
			Me.Controls.Add(Me.radSplitContainer1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Field List Example"
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private radPivotFieldList1 As Telerik.WinControls.UI.RadPivotFieldList
		Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
	End Class
End Namespace