Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ItemFormatting
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
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1183, 1)
			Me.settingsPanel.Size = New Size(200, 694)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radListControl1)
			Me.radGroupBox1.HeaderText = "ListControl"
			Me.radGroupBox1.Location = New Point(20, 20)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(270, 438)
			Me.radGroupBox1.TabIndex = 10
			Me.radGroupBox1.Text = "ListControl"
			' 
			' radListControl1
			' 
			Me.radListControl1.Location = New Point(13, 23)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New Size(244, 402)
			Me.radListControl1.TabIndex = 1
			Me.radListControl1.Text = "radListControl1"

			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox4.HeaderText = "DropDownList"
			Me.radGroupBox4.Location = New Point(370, 20)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox4.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox4.Size = New Size(270, 438)
			Me.radGroupBox4.TabIndex = 11
			Me.radGroupBox4.Text = "DropDownList"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.Location = New Point(13, 23)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(244, 20)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.Text = "ListItem 3"
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGroupBox1)
			Me.Controls.Add(Me.radGroupBox4)
			Me.Name = "Form1"
			Me.Size = New Size(1331, 754)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox4, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radListControl1 As Telerik.WinControls.UI.RadListControl
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace