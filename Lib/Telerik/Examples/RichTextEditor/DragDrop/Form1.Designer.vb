Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.DragDrop
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
			Dim listViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1")
			Dim listViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 2")
			Dim listViewDataItem3 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 3")
			Dim listViewDataItem4 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 4")
			Dim listViewDataItem5 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 5")
			Dim listViewDataItem6 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 6")
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radListView1
			' 
            Me.radListView1.AllowDragDrop = True
            Me.radListView1.AllowEdit = False
            Me.radListView1.AllowRemove = False
			Me.radListView1.Dock = System.Windows.Forms.DockStyle.Left
			Me.radListView1.FullRowSelect = False
			listViewDataItem1.Text = "Some predefined text"
			listViewDataItem2.Text = "Firstname Lastname"
			listViewDataItem3.Text = "firstname.lastname@telerik.com"
			listViewDataItem4.Text = "Company Name"
			listViewDataItem5.Text = "Signature"
			listViewDataItem6.Text = "Date"
			Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() { listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4, listViewDataItem5, listViewDataItem6})
			Me.radListView1.ItemSize = New System.Drawing.Size(185, 64)
			Me.radListView1.ItemSpacing = 5
			Me.radListView1.Location = New System.Drawing.Point(0, 0)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.Size = New System.Drawing.Size(198, 587)
			Me.radListView1.TabIndex = 1
			Me.radListView1.Text = "radListView1"
			Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
			CType(Me.radListView1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.IconListViewElement).ItemSize = New System.Drawing.Size(185, 64)
			CType(Me.radListView1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.IconListViewElement).Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
			' 
			' radSeparator1
			' 
			Me.radSeparator1.Dock = System.Windows.Forms.DockStyle.Left
			Me.radSeparator1.Location = New System.Drawing.Point(198, 0)
			Me.radSeparator1.Name = "radSeparator1"
			Me.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radSeparator1.Size = New System.Drawing.Size(16, 587)
			Me.radSeparator1.TabIndex = 2
			Me.radSeparator1.Text = "radSeparator1"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.LayoutMode = Telerik.WinForms.Documents.Model.DocumentLayoutMode.Paged
			Me.radRichTextEditor1.Location = New System.Drawing.Point(214, 0)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(888, 587)
			Me.radRichTextEditor1.TabIndex = 3
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1102, 587)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radSeparator1)
			Me.Controls.Add(Me.radListView1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Drag Drop"
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor

	End Class
End Namespace