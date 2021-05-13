Namespace Telerik.Examples.WinControls.PivotGrid.LayoutTypes
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioCompactColumnHeader = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioTabularColumnHeader = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioCompactRowHeader = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioTabularRowHeader = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radioCompactColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioTabularColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radioCompactRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioTabularRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(838, 0)
			Me.settingsPanel.Size = New Size(234, 801)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radioCompactColumnHeader)
			Me.radGroupBox1.Controls.Add(Me.radioTabularColumnHeader)
			Me.radGroupBox1.HeaderText = "Column Headers Layout"
			Me.radGroupBox1.Location = New Point(72, 10)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New Size(152, 80)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Column Headers Layout"
			' 
			' radioCompactColumnHeader
			' 
			Me.radioCompactColumnHeader.Location = New Point(6, 46)
			Me.radioCompactColumnHeader.Name = "radioCompactColumnHeader"
			Me.radioCompactColumnHeader.Size = New Size(65, 18)
			Me.radioCompactColumnHeader.TabIndex = 1
			Me.radioCompactColumnHeader.Text = "Compact"

			' 
			' radioTabularColumnHeader
			' 
			Me.radioTabularColumnHeader.Location = New Point(6, 22)
			Me.radioTabularColumnHeader.Name = "radioTabularColumnHeader"
			Me.radioTabularColumnHeader.Size = New Size(57, 18)
			Me.radioTabularColumnHeader.TabIndex = 0
			Me.radioTabularColumnHeader.TabStop = True
			Me.radioTabularColumnHeader.Text = "Tabular"
			Me.radioTabularColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Controls.Add(Me.radioCompactRowHeader)
			Me.radGroupBox2.Controls.Add(Me.radioTabularRowHeader)
			Me.radGroupBox2.HeaderText = "Row Headers Layout"
			Me.radGroupBox2.Location = New Point(72, 116)
			Me.radGroupBox2.Name = "radGroupBox2"
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupBox2.Size = New Size(152, 77)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "Row Headers Layout"
			' 
			' radioCompactRowHeader
			' 
			Me.radioCompactRowHeader.Location = New Point(6, 45)
			Me.radioCompactRowHeader.Name = "radioCompactRowHeader"
			Me.radioCompactRowHeader.Size = New Size(65, 18)
			Me.radioCompactRowHeader.TabIndex = 3
			Me.radioCompactRowHeader.Text = "Compact"

			' 
			' radioTabularRowHeader
			' 
			Me.radioTabularRowHeader.Location = New Point(6, 21)
			Me.radioTabularRowHeader.Name = "radioTabularRowHeader"
			Me.radioTabularRowHeader.Size = New Size(57, 18)
			Me.radioTabularRowHeader.TabIndex = 2
			Me.radioTabularRowHeader.TabStop = True
			Me.radioTabularRowHeader.Text = "Tabular"
			Me.radioTabularRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New Size(1082, 811)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radioCompactColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioTabularColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radioCompactRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioTabularRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radioTabularColumnHeader As Telerik.WinControls.UI.RadRadioButton
		Private radioCompactColumnHeader As Telerik.WinControls.UI.RadRadioButton
		Private radioCompactRowHeader As Telerik.WinControls.UI.RadRadioButton
		Private radioTabularRowHeader As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace