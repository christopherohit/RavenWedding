Namespace Telerik.Examples.WinControls.GridView.PopulateWithData.DataBinding
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
			If [set] IsNot Nothing Then
				[set].Dispose()
				[set] = Nothing
			End If
			If adapter IsNot Nothing Then
				adapter.Dispose()
				adapter = Nothing
			End If
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioDataSet = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioArrLst = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioSubObj = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioObjects = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDataReader = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioArrLst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioSubObj, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioObjects, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDataReader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(727, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 608)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowDragToGroup = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = Color.Black
			Me.radGridView1.Size = New Size(928, 610)
			Me.radGridView1.TabIndex = 2
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "Telerik"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioDataSet)
			Me.radGroupBox1.Controls.Add(Me.radRadioArrLst)
			Me.radGroupBox1.Controls.Add(Me.radRadioSubObj)
			Me.radGroupBox1.Controls.Add(Me.radRadioObjects)
			Me.radGroupBox1.Controls.Add(Me.radRadioDataReader)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = "Data Binding Options"
			Me.radGroupBox1.Location = New Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(180, 161)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Data Binding Options"
			' 
			' radRadioDataSet
			' 
			Me.radRadioDataSet.AllowShowFocusCues = True
			Me.radRadioDataSet.Location = New Point(31, 54)
			Me.radRadioDataSet.Name = "radRadioDataSet"
			Me.radRadioDataSet.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioDataSet.Size = New Size(64, 16)
			Me.radRadioDataSet.TabIndex = 3
			Me.radRadioDataSet.Text = "Data Set"
			' 
			' radRadioArrLst
			' 
			Me.radRadioArrLst.AllowShowFocusCues = True
			Me.radRadioArrLst.Location = New Point(31, 120)
			Me.radRadioArrLst.Name = "radRadioArrLst"
			Me.radRadioArrLst.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioArrLst.Size = New Size(68, 16)
			Me.radRadioArrLst.TabIndex = 2
			Me.radRadioArrLst.Text = "Array List"
			' 
			' radRadioSubObj
			' 
			Me.radRadioSubObj.AllowShowFocusCues = True
			Me.radRadioSubObj.Location = New Point(31, 98)
			Me.radRadioSubObj.Name = "radRadioSubObj"
			Me.radRadioSubObj.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioSubObj.Size = New Size(83, 16)
			Me.radRadioSubObj.TabIndex = 2
			Me.radRadioSubObj.Text = "Sub-Objects"
			' 
			' radRadioObjects
			' 
			Me.radRadioObjects.AllowShowFocusCues = True
			Me.radRadioObjects.Location = New Point(31, 76)
			Me.radRadioObjects.Name = "radRadioObjects"
			Me.radRadioObjects.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioObjects.Size = New Size(101, 16)
			Me.radRadioObjects.TabIndex = 2
			Me.radRadioObjects.Text = "Custom Objects"
			' 
			' radRadioDataReader
			' 
			Me.radRadioDataReader.AllowShowFocusCues = True
			Me.radRadioDataReader.Location = New Point(31, 32)
			Me.radRadioDataReader.Name = "radRadioDataReader"
			Me.radRadioDataReader.RadioCheckAlignment = ContentAlignment.MiddleLeft
			Me.radRadioDataReader.Size = New Size(84, 16)
			Me.radRadioDataReader.TabIndex = 2
			Me.radRadioDataReader.Text = "Data Reader"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(928, 610)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioArrLst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioSubObj, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioObjects, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDataReader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioDataReader As Telerik.WinControls.UI.RadRadioButton
		Private radRadioArrLst As Telerik.WinControls.UI.RadRadioButton
		Private radRadioSubObj As Telerik.WinControls.UI.RadRadioButton
		Private radRadioObjects As Telerik.WinControls.UI.RadRadioButton
		Private radRadioDataSet As Telerik.WinControls.UI.RadRadioButton


	End Class
End Namespace
