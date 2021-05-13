Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.SelfReference
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.employeeBindingSource = New BindingSource(Me.components)
			Me.adventureLT2008DataSet = New Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSet()
			Me.imageList1 = New ImageList(Me.components)
			Me.employeeTableAdapter = New Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.adventureLT2008DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(982, 1)
			Me.settingsPanel.Size = New Size(200, 747)
			' 
			' employeeBindingSource
			' 
			Me.employeeBindingSource.DataMember = "Employee"
			Me.employeeBindingSource.DataSource = Me.adventureLT2008DataSet
			' 
			' adventureLT2008DataSet
			' 
			Me.adventureLT2008DataSet.DataSetName = "AdventureLT2008DataSet"
			Me.adventureLT2008DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "User Business Male.png")
			' 
			' employeeTableAdapter
			' 
			Me.employeeTableAdapter.ClearBeforeFill = True
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Dock = DockStyle.Left
			Me.radTreeView1.ImageIndex = 0
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New Size(325, 413)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 1
			Me.radTreeView1.Text = "radTreeView1"
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1308, 423)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.adventureLT2008DataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private employeeBindingSource As BindingSource
		Private adventureLT2008DataSet As DataSources.AdventureLT2008DataSet
		Private employeeTableAdapter As DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter
		Private imageList1 As ImageList
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
	End Class
End Namespace
