Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.GridView.Export.ExportMLWithEvents
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(17, 192)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(138, 30)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "RunExport"

			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.Location = New Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = Color.Black
			Me.radGridView1.Size = New Size(1224, 820)
			Me.radGridView1.TabIndex = 1
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.Dash = False
			Me.radProgressBar1.Location = New Point(17, 166)
			Me.radProgressBar1.Name = "radProgressBar1"
			Me.radProgressBar1.SeparatorColor1 = Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar1.SeparatorColor2 = Color.White
			Me.radProgressBar1.SeparatorWidth = 4
			Me.radProgressBar1.Size = New Size(138, 20)
			Me.radProgressBar1.StepWidth = 13
			Me.radProgressBar1.TabIndex = 2
			Me.radProgressBar1.Text = "radProgressBar1"
			Me.radProgressBar1.TextAlignment = ContentAlignment.MiddleLeft
			Me.radProgressBar1.Visible = False
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radComboBox1)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar1)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radButton1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Export Settings"
			Me.radGroupBox1.Location = New Point(10, 0)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 501)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Export Settings"
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem3, Me.radComboBoxItem4}))
			Me.radComboBox1.Location = New Point(17, 138)
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.NullText = "Select Row Numbers"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.Size = New Size(128, 20)
			Me.radComboBox1.TabIndex = 7
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.Text = "radComboBox1"

			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "100"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "1,000"
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "10,000"
			' 
			' radComboBoxItem4
			' 
			Me.radComboBoxItem4.Text = "100,000"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Location = New Point(17, 32)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(128, 29)
			Me.radRadioButton1.TabIndex = 5
			Me.radRadioButton1.Text = "Max rows supported" & vbCrLf & "by Excel 2007"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New Point(17, 67)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(128, 29)
			Me.radRadioButton2.TabIndex = 6
			Me.radRadioButton2.Text = "Max rows supported" & vbCrLf & "by prior versions"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(17, 118)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(81, 16)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Rows Number:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1224, 820)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub





		#End Region

		Private radButton1 As Telerik.WinControls.UI.RadButton
        Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList

	End Class
End Namespace
