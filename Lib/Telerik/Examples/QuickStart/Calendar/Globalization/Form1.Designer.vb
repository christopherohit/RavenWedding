Namespace Telerik.Examples.WinControls.Calendar.Globalization
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
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radComboCultureList = New Telerik.WinControls.UI.RadDropDownList()
			Me.lbRenderingDirection = New Telerik.WinControls.UI.RadLabel()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.lbTitleFormat = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboCultureList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New Date(2009, 3, 18, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radComboCultureList
			' 
			Me.radComboCultureList.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.radComboCultureList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboCultureList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboCultureList.Location = New Point(24, 55)
			Me.radComboCultureList.MaxDropDownItems = 6
			Me.radComboCultureList.Name = "radComboCultureList"
			' 
			' 
			' 
			Me.radComboCultureList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboCultureList.Size = New Size(132, 22)
			Me.radComboCultureList.TabIndex = 1
			' 
			' lbRenderingDirection
			' 
			Me.lbRenderingDirection.AutoSize = False
			Me.lbRenderingDirection.Location = New Point(24, 86)
			Me.lbRenderingDirection.Name = "lbRenderingDirection"
			Me.lbRenderingDirection.Size = New Size(132, 36)
			Me.lbRenderingDirection.TabIndex = 4
			Me.lbRenderingDirection.Text = "Type text to set the " & vbCrLf & " navigation bar: "
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(24, 161)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(132, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Change Texts"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New Point(24, 128)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.Size = New Size(132, 20)
			Me.radTextBox1.TabIndex = 7
			Me.radTextBox1.TabStop = False
			' 
			' lbTitleFormat
			' 
			Me.lbTitleFormat.Location = New Point(24, 31)
			Me.lbTitleFormat.Name = "lbTitleFormat"
			Me.lbTitleFormat.Size = New Size(84, 18)
			Me.lbTitleFormat.TabIndex = 6
			Me.lbTitleFormat.Text = "Choose culture:"
			Me.lbTitleFormat.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButton1)
			Me.radGroupBox1.Controls.Add(Me.lbTitleFormat)
			Me.radGroupBox1.Controls.Add(Me.radTextBox1)
			Me.radGroupBox1.Controls.Add(Me.lbRenderingDirection)
			Me.radGroupBox1.Controls.Add(Me.radComboCultureList)
			Me.radGroupBox1.HeaderText = "Globalization Options"
			Me.radGroupBox1.Location = New Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 197)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Globalization Options"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1308, 506)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboCultureList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbRenderingDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbTitleFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radComboCultureList As Telerik.WinControls.UI.RadDropDownList
		Private lbRenderingDirection As Telerik.WinControls.UI.RadLabel
		Private lbTitleFormat As Telerik.WinControls.UI.RadLabel
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace