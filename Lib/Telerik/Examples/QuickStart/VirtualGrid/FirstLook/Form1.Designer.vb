Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
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
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radVirtualGrid1
			' 

			Me.radVirtualGrid1.Location = New System.Drawing.Point(24, 22)
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.RowCount = 1000
			Me.radVirtualGrid1.Size = New System.Drawing.Size(870, 512)
			Me.radVirtualGrid1.StandardTab = False
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
'			Me.radVirtualGrid1.CellValueNeeded += New Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(Me.radVirtualGrid1_CellValueNeeded);
'			Me.radVirtualGrid1.CellFormatting += New Telerik.WinControls.UI.VirtualGridCellElementEventHandler(Me.radVirtualGrid1_CellFormatting);
'			Me.radVirtualGrid1.SortChanged += New Telerik.WinControls.UI.VirtualGridEventHandler(Me.radVirtualGrid1_SortChanged);
'			Me.radVirtualGrid1.FilterChanged += New Telerik.WinControls.UI.VirtualGridEventHandler(Me.radVirtualGrid1_FilterChanged);
'			Me.radVirtualGrid1.UserDeletedRow += New Telerik.WinControls.UI.VirtualGridRowsEventHandler(Me.radVirtualGrid1_UserDeletingRow);
'			Me.radVirtualGrid1.UserAddedRow += New Telerik.WinControls.UI.VirtualGridNewRowEventHandler(Me.radVirtualGrid1_UserAddedRow);
'			Me.radVirtualGrid1.CellValuePushed += New Telerik.WinControls.UI.VirtualGridCellValuePushedEventHandler(Me.radVirtualGrid1_CellValuePushed);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(883, 626)
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
	End Class
End Namespace