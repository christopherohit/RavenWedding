Namespace Telerik.Examples.WinControls.GridView.Customize.ConditionalFormatting
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
			Me.components = New System.ComponentModel.Container()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.btnOpenCondFormatting = New Telerik.WinControls.UI.RadButton()
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersBindingSource = New BindingSource(Me.components)
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnOpenCondFormatting, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.btnOpenCondFormatting)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnOpenCondFormatting, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowDragToGroup = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.Size = New Size(1224, 737)
			Me.radGridView1.TabIndex = 2
			Me.radGridView1.Text = "radGridView1"
			' 
			' btnOpenCondFormatting
			' 
			Me.btnOpenCondFormatting.Anchor = AnchorStyles.Top
			Me.btnOpenCondFormatting.Location = New Point(10, 7)
			Me.btnOpenCondFormatting.Name = "btnOpenCondFormatting"
			Me.btnOpenCondFormatting.Size = New Size(180, 59)
			Me.btnOpenCondFormatting.TabIndex = 5
			Me.btnOpenCondFormatting.Text = "Launch" & vbCrLf & "Conditional" & vbCrLf & "Formatting"
            ' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Location = New Point(10, 72)
			Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(220, 133)
            Me.radLabel1.MaximumSize = New Size(220, 0)
			Me.radLabel1.TabIndex = 6
            Me.radLabel1.Text = "or Right-click on the grid to invoke the Conditional Formatting Editor from the c" & "ontext menu"
            Me.radLabel1.TextWrap = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
            Me.Size = New Size(1224, 737)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnOpenCondFormatting, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private btnOpenCondFormatting As Telerik.WinControls.UI.RadButton
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersBindingSource As BindingSource
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace