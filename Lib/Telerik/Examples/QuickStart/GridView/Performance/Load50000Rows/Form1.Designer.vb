Namespace Telerik.Examples.WinControls.GridView.Performance.Load50000Rows
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataTable = New DataTable()
			Me.dataSet1 = New DataSet()
			Me.radGridViewDemo = New Telerik.WinControls.UI.RadGridView()
			Me.radBtnBind = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewDemo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGridViewDemo.SuspendLayout()
			CType(Me.radBtnBind, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' dataTable
			' 
			Me.dataTable.TableName = "Table1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New DataTable() { Me.dataTable})
			' 
			' radGridViewDemo
			' 
			Me.radGridViewDemo.Controls.Add(Me.radBtnBind)
			Me.radGridViewDemo.Dock = DockStyle.Fill
			Me.radGridViewDemo.ForeColor = Color.Black
			Me.radGridViewDemo.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridViewDemo.MasterTemplate.AllowAddNewRow = False
			Me.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridViewDemo.MasterTemplate.EnableFiltering = True
			Me.radGridViewDemo.Name = "radGridViewDemo"
			' 
			' 
			' 
			Me.radGridViewDemo.RootElement.ForeColor = Color.Black
			Me.radGridViewDemo.ShowNoDataText = False
			Me.radGridViewDemo.Size = New Size(1224, 737)
			Me.radGridViewDemo.TabIndex = 1
			' 
			' radBtnBind
			' 
			Me.radBtnBind.Anchor = AnchorStyles.None
			Me.radBtnBind.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.radBtnBind.Location = New Point(525, 342)
			Me.radBtnBind.Name = "radBtnBind"
            Me.radBtnBind.Size = New Size(170, 52)
			Me.radBtnBind.TabIndex = 0
			Me.radBtnBind.Text = "LOAD 50,000 ROWS"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridViewDemo)
			Me.Name = "Form1"
			Me.Size = New Size(1224, 737)
			Me.Controls.SetChildIndex(Me.radGridViewDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewDemo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGridViewDemo.ResumeLayout(False)
			CType(Me.radBtnBind, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridViewDemo As Telerik.WinControls.UI.RadGridView
		Private radBtnBind As Telerik.WinControls.UI.RadButton
		Private dataTable As DataTable
		Private dataSet1 As DataSet
	End Class
End Namespace
