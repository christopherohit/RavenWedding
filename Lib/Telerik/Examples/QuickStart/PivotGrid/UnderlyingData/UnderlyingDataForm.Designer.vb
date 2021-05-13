Namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
	Partial Public Class UnderlyingDataForm
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
			Dim tableViewDefinition2 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(512, 340)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.AllowEditRow = False
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ShowFilteringRow = False
			Me.radGridView1.ShowHeaderCellButtons = True
			' 
			' UnderlyingDataForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(550, 340)
			Me.Controls.Add(Me.radGridView1)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "UnderlyingDataForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.StartPosition = FormStartPosition.CenterParent
			Me.ShowInTaskbar = False
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.Text = "Underlying Data"
			Me.ShowIcon = False
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace
