Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
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
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.rbDataSet = New Telerik.WinControls.UI.RadRadioButton()
			Me.rbBusinessObjects = New Telerik.WinControls.UI.RadRadioButton()
			Me.btnSave = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.rbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rbBusinessObjects, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.btnSave)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(687, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnSave, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			' 
			' radSchedulerDemo
			' 
			Me.radSchedulerDemo.BackColor = Color.White
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Dock = DockStyle.Fill
			Me.radSchedulerDemo.ForeColor = Color.Black
			Me.radSchedulerDemo.HeaderFormat = "MMMM dd"
			Me.radSchedulerDemo.Location = New Point(0, 0)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			' 
			' 
			' 
			Me.radSchedulerDemo.RootElement.ForeColor = Color.Black
			Me.radSchedulerDemo.Size = New Size(888, 820)
			Me.radSchedulerDemo.TabIndex = 0
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.rbDataSet)
			Me.radGroupBox1.Controls.Add(Me.rbBusinessObjects)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = " Bind to: "
			Me.radGroupBox1.Location = New Point(10, 5)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = Color.Black
			Me.radGroupBox1.Size = New Size(180, 90)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = " Bind to: "
			' 
			' rbDataSet
			' 
			Me.rbDataSet.AllowShowFocusCues = True
			Me.rbDataSet.ForeColor = Color.Black
			Me.rbDataSet.Location = New Point(9, 51)
			Me.rbDataSet.Name = "rbDataSet"
			Me.rbDataSet.RadioCheckAlignment = ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.rbDataSet.RootElement.ForeColor = Color.Black
			Me.rbDataSet.Size = New Size(61, 16)
			Me.rbDataSet.TabIndex = 1
			Me.rbDataSet.Text = "DataSet"
			' 
			' rbBusinessObjects
			' 
			Me.rbBusinessObjects.AllowShowFocusCues = True
			Me.rbBusinessObjects.ForeColor = Color.Black
			Me.rbBusinessObjects.Location = New Point(9, 29)
			Me.rbBusinessObjects.Name = "rbBusinessObjects"
			Me.rbBusinessObjects.RadioCheckAlignment = ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.rbBusinessObjects.RootElement.ForeColor = Color.Black
			Me.rbBusinessObjects.Size = New Size(108, 16)
			Me.rbBusinessObjects.TabIndex = 0
			Me.rbBusinessObjects.Text = "Business Objects"
			' 
			' btnSave
			' 
			Me.btnSave.AllowShowFocusCues = True
			Me.btnSave.Anchor = AnchorStyles.Top
			Me.btnSave.ForeColor = Color.Black
			Me.btnSave.Location = New Point(10, 102)
			Me.btnSave.Name = "btnSave"
			' 
			' 
			' 
			Me.btnSave.RootElement.ForeColor = Color.Black
			Me.btnSave.Size = New Size(180, 23)
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "Save changes"

			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Font = New Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel1.Location = New Point(10, 126)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = Color.Black
			Me.radLabel1.Size = New Size(92, 12)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Text = "updates the database"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Name = "Form1"
			Me.Size = New Size(888, 820)
			Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.rbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rbBusinessObjects, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private rbDataSet As Telerik.WinControls.UI.RadRadioButton
		Private rbBusinessObjects As Telerik.WinControls.UI.RadRadioButton
		Private btnSave As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
