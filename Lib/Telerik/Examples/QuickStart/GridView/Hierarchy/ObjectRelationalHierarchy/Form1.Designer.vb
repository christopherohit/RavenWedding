Namespace Telerik.Examples.WinControls.GridView.Hierarchy.ObjectRelationalHierarchy
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupHierarchyOptions = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioHierarchyFromDataSet = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioManuallyUnbound = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupHierarchyOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioHierarchyFromDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioManuallyUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.settingsPanel.AutoScroll = True
			Me.settingsPanel.BackColor = Color.Transparent
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupHierarchyOptions)
			Me.settingsPanel.Controls.Add(Me.btnSpy)
			Me.settingsPanel.ForeColor = Color.Black
			Me.settingsPanel.Location = New Point(1446, 1)
			Me.settingsPanel.Name = "settingsPanel"
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = Color.Black
			Me.settingsPanel.Size = New Size(200, 770)
			Me.settingsPanel.TabIndex = 0
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), Image))
			Me.btnSpy.Location = New Point(10, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New Padding(2, 0, 0, 0)
			' 
			' 
			' 
			Me.btnSpy.RootElement.Padding = New Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New Size(180, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(1647, 772)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' radGroupHierarchyOptions
			' 
			Me.radGroupHierarchyOptions.Anchor = AnchorStyles.Top
			Me.radGroupHierarchyOptions.Controls.Add(Me.radRadioHierarchyFromDataSet)
			Me.radGroupHierarchyOptions.Controls.Add(Me.radRadioManuallyUnbound)
			Me.radGroupHierarchyOptions.Controls.Add(Me.radRadioButton2)
			Me.radGroupHierarchyOptions.FooterImageIndex = -1
			Me.radGroupHierarchyOptions.FooterImageKey = ""
			Me.radGroupHierarchyOptions.HeaderImageIndex = -1
			Me.radGroupHierarchyOptions.HeaderImageKey = ""
			Me.radGroupHierarchyOptions.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupHierarchyOptions.HeaderText = " Scenarios "
			Me.radGroupHierarchyOptions.Location = New Point(10, 6)
			Me.radGroupHierarchyOptions.Name = "radGroupHierarchyOptions"
			Me.radGroupHierarchyOptions.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupHierarchyOptions.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupHierarchyOptions.Size = New Size(180, 141)
			Me.radGroupHierarchyOptions.TabIndex = 0
			Me.radGroupHierarchyOptions.Text = " Scenarios "
			' 
			' radRadioHierarchyFromDataSet
			' 
			Me.radRadioHierarchyFromDataSet.Location = New Point(15, 94)
			Me.radRadioHierarchyFromDataSet.Name = "radRadioHierarchyFromDataSet"
			Me.radRadioHierarchyFromDataSet.Size = New Size(133, 29)
			Me.radRadioHierarchyFromDataSet.TabIndex = 0
			Me.radRadioHierarchyFromDataSet.Text = "Auto-Generated from" & vbCrLf & "DataSet"
			' 
			' radRadioManuallyUnbound
			' 
			Me.radRadioManuallyUnbound.Location = New Point(15, 24)
			Me.radRadioManuallyUnbound.Name = "radRadioManuallyUnbound"
			Me.radRadioManuallyUnbound.Size = New Size(128, 29)
			Me.radRadioManuallyUnbound.TabIndex = 0
			Me.radRadioManuallyUnbound.Text = "Manually Generated" & vbCrLf & "for Unbound Mode"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New Point(15, 59)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(128, 29)
			Me.radRadioButton2.TabIndex = 0
			Me.radRadioButton2.Text = "Manually Generated" & vbCrLf & "for Bound Mode"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(10, 153)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(136, 19)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Use nested scrollbars"
			' 
			' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1647, 772)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupHierarchyOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioHierarchyFromDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioManuallyUnbound, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView

		Private radGroupHierarchyOptions As Telerik.WinControls.UI.RadGroupBox
		Private radRadioManuallyUnbound As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioHierarchyFromDataSet As Telerik.WinControls.UI.RadRadioButton
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private Shadows settingsPanel As Telerik.WinControls.UI.RadPanel
		Private btnSpy As Telerik.WinControls.UI.RadButton

	End Class
End Namespace
