Namespace Telerik.Examples.WinControls.PanelsLabels.Panel
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton5 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radRadioButton6 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.Size = New Size(355, 157)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = Color.Transparent
			Me.radPanel1.Font = New Font("Microsoft Sans Serif", 11.25F)
			Me.radPanel1.ForeColor = Color.Black
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(290, 120)
			Me.radPanel1.TabIndex = 1
			Me.radPanel1.Text = resources.GetString("radPanel1.Text")
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text")
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton3)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.HeaderText = " Background Gradients "
			Me.radGroupBox1.Location = New Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 103)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = " Background Gradients "
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Location = New Point(33, 73)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.Size = New Size(50, 18)
			Me.radRadioButton3.TabIndex = 2
			Me.radRadioButton3.Text = "Linear"

			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New Point(33, 51)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(45, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Solid"

			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Location = New Point(33, 29)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(80, 18)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "Transparent"

			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.Location = New Point(33, 34)
			Me.radRadioButton4.Name = "radRadioButton4"
			Me.radRadioButton4.Size = New Size(80, 18)
			Me.radRadioButton4.TabIndex = 0
			Me.radRadioButton4.Text = "Transparent"

			' 
			' radRadioButton5
			' 
			Me.radRadioButton5.Location = New Point(33, 56)
			Me.radRadioButton5.Name = "radRadioButton5"
			Me.radRadioButton5.Size = New Size(45, 18)
			Me.radRadioButton5.TabIndex = 1
			Me.radRadioButton5.Text = "Solid"

			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(33, 120)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 4, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(100, 20)
			Me.radSpinEditor1.TabIndex = 0
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 1, 0, 0, 0})

			' 
			' radRadioButton6
			' 
			Me.radRadioButton6.Location = New Point(33, 78)
			Me.radRadioButton6.Name = "radRadioButton6"
			Me.radRadioButton6.Size = New Size(50, 18)
			Me.radRadioButton6.TabIndex = 2
			Me.radRadioButton6.Text = "Linear"

			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(33, 100)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(76, 18)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Border Width:"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton6)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton5)
			Me.radGroupBox2.Controls.Add(Me.radRadioButton4)
			Me.radGroupBox2.HeaderText = " Border Settings "
			Me.radGroupBox2.Location = New Point(10, 115)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(180, 151)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = " Border Settings "
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1063, 516)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radRadioButton6 As Telerik.WinControls.UI.RadRadioButton
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radRadioButton5 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton4 As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace