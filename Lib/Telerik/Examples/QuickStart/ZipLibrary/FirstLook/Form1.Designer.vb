Namespace Telerik.Examples.WinControls.ZipLibrary.FirstLook
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
			Dim startsWithFindStringComparer1 As New Telerik.WinControls.UI.StartsWithFindStringComparer()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.checkedListView = New Telerik.WinControls.UI.RadListView()
			Me.saveZipFileButton = New Telerik.WinControls.UI.RadButton()
			Me.readZipFileButton = New Telerik.WinControls.UI.RadButton()
			Me.clearZipFileButton = New Telerik.WinControls.UI.RadButton()
			Me.radSeparator1 = New Telerik.WinControls.UI.RadSeparator()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedListView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.saveZipFileButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.readZipFileButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clearZipFileButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1141, 75)
			' 
			' checkedListView
			' 
			Me.checkedListView.FindStringComparer = startsWithFindStringComparer1
			Me.checkedListView.Location = New Point(3, 3)
			Me.checkedListView.Name = "checkedListView"
			Me.checkedListView.ShowCheckBoxes = True
			Me.checkedListView.Size = New Size(209, 264)
			Me.checkedListView.TabIndex = 2
			Me.checkedListView.Text = "radListView1"
			' 
			' saveZipFileButton
			' 
			Me.saveZipFileButton.Location = New Point(3, 273)
			Me.saveZipFileButton.Name = "saveZipFileButton"
			Me.saveZipFileButton.Size = New Size(209, 24)
			Me.saveZipFileButton.TabIndex = 3
			Me.saveZipFileButton.Text = "Save Zip File"
'			Me.saveZipFileButton.Click += New System.EventHandler(Me.saveZipFileButton_Click)
			' 
			' readZipFileButton
			' 
			Me.readZipFileButton.Location = New Point(512, 270)
			Me.readZipFileButton.Name = "readZipFileButton"
			Me.readZipFileButton.Size = New Size(123, 24)
			Me.readZipFileButton.TabIndex = 4
			Me.readZipFileButton.Text = "Read Zip File"
'			Me.readZipFileButton.Click += New System.EventHandler(Me.readZipFileButton_Click)
			' 
			' clearZipFileButton
			' 
			Me.clearZipFileButton.Location = New Point(643, 270)
			Me.clearZipFileButton.Name = "clearZipFileButton"
			Me.clearZipFileButton.Size = New Size(123, 24)
			Me.clearZipFileButton.TabIndex = 4
			Me.clearZipFileButton.Text = "Clear Zip File"
'			Me.clearZipFileButton.Click += New System.EventHandler(Me.clearZipFileButton_Click)
			' 
			' radSeparator1
			' 
			Me.radSeparator1.Location = New Point(211, 0)
			Me.radSeparator1.Name = "radSeparator1"
			Me.radSeparator1.Orientation = Orientation.Vertical
			Me.radSeparator1.Size = New Size(22, 297)
			Me.radSeparator1.TabIndex = 6
			Me.radSeparator1.Text = "radSeparator1"
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New Point(235, 0)
			Me.radGridView1.GridViewElement.Padding = New Padding(0, 1, 0, 1)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			gridViewTextBoxColumn1.FieldName = "Name"
			gridViewTextBoxColumn1.HeaderText = "File name"
			gridViewTextBoxColumn1.Name = "FileNameInZip"
			gridViewTextBoxColumn1.Width = 171
			gridViewTextBoxColumn2.FieldName = "Length"
			gridViewTextBoxColumn2.HeaderText = "Uncompressed size"
			gridViewTextBoxColumn2.Name = "Length"
			gridViewTextBoxColumn2.Width = 171
			gridViewTextBoxColumn3.FieldName = "CompressedLength"
			gridViewTextBoxColumn3.HeaderText = "Compressed size"
			gridViewTextBoxColumn3.Name = "CompressedLength"
			gridViewTextBoxColumn3.Width = 171
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3})
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.Size = New Size(531, 264)
			Me.radGridView1.TabIndex = 7
			Me.radGridView1.Text = "radGridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(Me.checkedListView)
			Me.Controls.Add(Me.saveZipFileButton)
			Me.Controls.Add(Me.radSeparator1)
			Me.Controls.Add(Me.clearZipFileButton)
			Me.Controls.Add(Me.readZipFileButton)
			Me.Name = "Form1"
			Me.Size = New Size(1523, 1000)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.readZipFileButton, 0)
			Me.Controls.SetChildIndex(Me.clearZipFileButton, 0)
			Me.Controls.SetChildIndex(Me.radSeparator1, 0)
			Me.Controls.SetChildIndex(Me.saveZipFileButton, 0)
			Me.Controls.SetChildIndex(Me.checkedListView, 0)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedListView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.saveZipFileButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.readZipFileButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clearZipFileButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private checkedListView As Telerik.WinControls.UI.RadListView
		Private WithEvents saveZipFileButton As Telerik.WinControls.UI.RadButton
		Private WithEvents readZipFileButton As Telerik.WinControls.UI.RadButton
		Private WithEvents clearZipFileButton As Telerik.WinControls.UI.RadButton
		Private radSeparator1 As Telerik.WinControls.UI.RadSeparator
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace