Namespace Telerik.Examples.WinControls.Editors.SpinEditor
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
			Me.radSpinDemo = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radGroupRTL = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radSpinDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRTL.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radSpinDemo)
			Me.radPanelDemoHolder.Size = New Size(233, 137)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRTL)
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRTL, 0)
			' 
			' radSpinDemo
			' 
			Me.radSpinDemo.Anchor = AnchorStyles.None
			Me.radSpinDemo.Location = New Point(0, 0)
			Me.radSpinDemo.Name = "radSpinDemo"
			' 
			' 
			' 
			Me.radSpinDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinDemo.Size = New Size(131, 20)
			Me.radSpinDemo.TabIndex = 2
			Me.radSpinDemo.TabStop = False
			' 
			' radGroupRTL
			' 
			Me.radGroupRTL.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupRTL.Anchor = AnchorStyles.Top
			Me.radGroupRTL.Controls.Add(Me.radCheckBox1)
			Me.radGroupRTL.FooterText = ""
			Me.radGroupRTL.HeaderText = " RTL Support "
			Me.radGroupRTL.Location = New Point(10, 6)
			Me.radGroupRTL.Name = "radGroupRTL"
			Me.radGroupRTL.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupRTL.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupRTL.Size = New Size(180, 58)
			Me.radGroupRTL.TabIndex = 0
			Me.radGroupRTL.Text = " RTL Support "
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New Point(14, 28)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(84, 18)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "Right To Left"

			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupEvents.Anchor = AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radButton1)
			Me.radGroupEvents.Controls.Add(Me.radListBox1)
			Me.radGroupEvents.FooterText = ""
			Me.radGroupEvents.HeaderText = " Events "
			Me.radGroupEvents.Location = New Point(10, 71)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupEvents.Size = New Size(180, 382)
			Me.radGroupEvents.TabIndex = 0
			Me.radGroupEvents.Text = " Events "
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(14, 314)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(153, 32)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Clear list"

			' 
			' radListBox1
			' 
			Me.radListBox1.Location = New Point(14, 19)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Size = New Size(153, 276)
			Me.radListBox1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1144, 489)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radSpinDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRTL, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRTL.ResumeLayout(False)
			Me.radGroupRTL.PerformLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSpinDemo As Telerik.WinControls.UI.RadSpinEditor
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private radGroupRTL As Telerik.WinControls.UI.RadGroupBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radListBox1 As Telerik.WinControls.UI.RadListControl
	End Class
End Namespace