Namespace Telerik.Examples.WinControls.DropDownListAndListControl.Performance
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
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.button_Bind = New Telerik.WinControls.UI.RadButton()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabelElapsed = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabelElapsedDropDownList = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelElapsedListControl = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.button_Bind, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelElapsed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabelElapsedDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelElapsedListControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1096, 1)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.button_Bind)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Size = New Size(200, 832)
			Me.settingsPanel.Size = New Size(200, 832)
			' 
			' radListControl1
			' 
			Me.radListControl1.Location = New Point(13, 36)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New Size(133, 370)
			Me.radListControl1.TabIndex = 1
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(13, 38)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(133, 20)
			Me.radDropDownList1.TabIndex = 2
			' 
			' button_Bind
			' 
			Me.button_Bind.Anchor = AnchorStyles.Top
			Me.button_Bind.Location = New Point(-5, 110)
			Me.button_Bind.Name = "button_Bind"
			Me.button_Bind.Size = New Size(180, 24)
			Me.button_Bind.TabIndex = 1
			Me.button_Bind.Text = "Bind"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Anchor = AnchorStyles.Top
			Me.radSpinEditor1.Increment = New Decimal(New Integer() { 10000, 0, 0, 0})
			Me.radSpinEditor1.Location = New Point(13, 23)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			Me.radSpinEditor1.NullableValue = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(154, 20)
			Me.radSpinEditor1.TabIndex = 2
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.ThousandsSeparator = True
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' radLabelElapsed
			' 
			Me.radLabelElapsed.Location = New Point(13, 36)
			Me.radLabelElapsed.MaximumSize = New Size(230, 0)
			Me.radLabelElapsed.Name = "radLabelElapsed"
			' 
			' 
			' 
			Me.radLabelElapsed.RootElement.MaxSize = New Size(230, 0)
			Me.radLabelElapsed.Size = New Size(195, 32)
			Me.radLabelElapsed.TabIndex = 3
			Me.radLabelElapsed.Text = "<html>Press the <strong>Bind</strong> button to measure the binding time with</ht" & "ml>"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radListControl1)
			Me.radGroupBox1.HeaderText = "ListControl"
			Me.radGroupBox1.Location = New Point(20, 20)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(159, 419)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = "ListControl"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Controls.Add(Me.radLabelElapsedDropDownList)
			Me.radGroupBox2.Controls.Add(Me.radLabelElapsedListControl)
			Me.radGroupBox2.Controls.Add(Me.radLabelElapsed)
			Me.radGroupBox2.HeaderText = "Test Results"
			Me.radGroupBox2.Location = New Point(380, 20)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(246, 419)
			Me.radGroupBox2.TabIndex = 5
			Me.radGroupBox2.Text = "Test Results"
			' 
			' radLabelElapsedDropDownList
			' 
			Me.radLabelElapsedDropDownList.Location = New Point(14, 107)
			Me.radLabelElapsedDropDownList.MaximumSize = New Size(230, 0)
			Me.radLabelElapsedDropDownList.Name = "radLabelElapsedDropDownList"
			' 
			' 
			' 
			Me.radLabelElapsedDropDownList.RootElement.MaxSize = New Size(230, 0)
			Me.radLabelElapsedDropDownList.Size = New Size(2, 2)
			Me.radLabelElapsedDropDownList.TabIndex = 5
			' 
			' radLabelElapsedListControl
			' 
			Me.radLabelElapsedListControl.Location = New Point(14, 72)
			Me.radLabelElapsedListControl.MaximumSize = New Size(230, 0)
			Me.radLabelElapsedListControl.Name = "radLabelElapsedListControl"
			' 
			' 
			' 
			Me.radLabelElapsedListControl.RootElement.MaxSize = New Size(230, 0)
			Me.radLabelElapsedListControl.Size = New Size(2, 2)
			Me.radLabelElapsedListControl.TabIndex = 4
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox3.HeaderText = "Items Count"
			Me.radGroupBox3.Location = New Point(-5, 41)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New Size(180, 53)
			Me.radGroupBox3.TabIndex = 3
			Me.radGroupBox3.Text = "Items Count"
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox4.HeaderText = "DropDownList"
			Me.radGroupBox4.Location = New Point(200, 20)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox4.Size = New Size(159, 419)
			Me.radGroupBox4.TabIndex = 6
			Me.radGroupBox4.Text = "DropDownList"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGroupBox1)
			Me.Controls.Add(Me.radGroupBox4)
			Me.Controls.Add(Me.radGroupBox2)
			Me.Name = "Form1"
			Me.Size = New Size(2011, 1157)
			Me.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox4, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.button_Bind, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelElapsed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabelElapsedDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelElapsedListControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private button_Bind As Telerik.WinControls.UI.RadButton
		Private radListControl1 As Telerik.WinControls.UI.RadListControl
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelElapsed As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private radLabelElapsedDropDownList As Telerik.WinControls.UI.RadLabel
		Private radLabelElapsedListControl As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace