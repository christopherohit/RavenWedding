Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
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
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
            CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radVirtualGrid1
            ' 
            Me.radVirtualGrid1.AllowAddNewRow = False
            Me.radVirtualGrid1.AllowCut = False
            Me.radVirtualGrid1.AllowDelete = False
            Me.radVirtualGrid1.AllowEdit = False
            Me.radVirtualGrid1.AllowFiltering = False
            Me.radVirtualGrid1.AllowPaste = False
            Me.radVirtualGrid1.AllowSorting = False
            Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
            Me.radVirtualGrid1.Name = "radVirtualGrid1"
            Me.radVirtualGrid1.Size = New System.Drawing.Size(684, 533)
            Me.radVirtualGrid1.StandardTab = False
            Me.radVirtualGrid1.TabIndex = 0
            Me.radVirtualGrid1.Text = "radVirtualGrid1"
            '			Me.radVirtualGrid1.CellValueNeeded += New Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(Me.radVirtualGrid1_CellValueNeeded);
            '			Me.radVirtualGrid1.CellFormatting += New Telerik.WinControls.UI.VirtualGridCellElementEventHandler(Me.radVirtualGrid1_CellFormatting);
            '			Me.radVirtualGrid1.RowExpanding += New Telerik.WinControls.UI.VirtualGridRowExpandingEventHandler(Me.radVirtualGrid1_RowExpanding);
            '			Me.radVirtualGrid1.QueryHasChildRows += New Telerik.WinControls.UI.VirtualGridQueryHasChildRowsEventHandler(Me.radVirtualGrid1_QueryHasChildRows);
            ' 
            ' northwindDataSet
            ' 
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' employeesTableAdapter
            ' 
            Me.employeesTableAdapter.ClearBeforeFill = True
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(684, 533)
            Me.Controls.Add(Me.radVirtualGrid1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
	End Class
End Namespace