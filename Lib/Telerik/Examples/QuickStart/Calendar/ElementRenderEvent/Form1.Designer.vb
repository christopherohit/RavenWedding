Namespace Telerik.Examples.WinControls.Calendar.ElementRenderEvent
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
			Me.DatesList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.ColorList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupRenderOpts = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DatesList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ColorList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRenderOpts.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRenderOpts)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 818)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRenderOpts, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New Date(2009, 3, 13, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = Color.Black
			Me.radCalendar1.Location = New Point(0, 0)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.Size = New Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' DatesList
			' 
			Me.DatesList.Anchor = AnchorStyles.Top
			Me.DatesList.AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.DatesList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.DatesList.Location = New Point(5, 43)
			Me.DatesList.MaxDropDownItems = 6
			Me.DatesList.Name = "DatesList"
			' 
			' 
			' 
			Me.DatesList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.DatesList.Size = New Size(170, 20)
			Me.DatesList.TabIndex = 1
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 23)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(76, 18)
			Me.radLabel2.TabIndex = 6
			Me.radLabel2.Text = "Selected Date:"
			Me.radLabel2.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 74)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(102, 18)
			Me.radLabel3.TabIndex = 7
			Me.radLabel3.Text = "Selected Day Color:"
			Me.radLabel3.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(5, 125)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(96, 18)
			Me.radLabel4.TabIndex = 8
			Me.radLabel4.Text = "Selected Day Text:"
			Me.radLabel4.TextAlignment = ContentAlignment.MiddleCenter
			' 
			' ColorList
			' 
			Me.ColorList.Anchor = AnchorStyles.Top
			Me.ColorList.AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.ColorList.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.ColorList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.ColorList.Location = New Point(5, 94)
			Me.ColorList.MaxDropDownItems = 6
			Me.ColorList.Name = "ColorList"
			' 
			' 
			' 
			Me.ColorList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.ColorList.Size = New Size(170, 20)
			Me.ColorList.TabIndex = 7
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(5, 180)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(170, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Apply Changes"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Anchor = AnchorStyles.Top
			Me.radTextBox1.Location = New Point(5, 145)
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTextBox1.Size = New Size(170, 20)
			Me.radTextBox1.TabIndex = 7
			Me.radTextBox1.TabStop = False
			Me.radTextBox1.Text = "MyDay"
			' 
			' radGroupRenderOpts
			' 
			Me.radGroupRenderOpts.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupRenderOpts.Anchor = AnchorStyles.Top
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel2)
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel3)
			Me.radGroupRenderOpts.Controls.Add(Me.DatesList)
			Me.radGroupRenderOpts.Controls.Add(Me.radLabel4)
			Me.radGroupRenderOpts.Controls.Add(Me.radTextBox1)
			Me.radGroupRenderOpts.Controls.Add(Me.ColorList)
			Me.radGroupRenderOpts.Controls.Add(Me.radButton1)
			Me.radGroupRenderOpts.HeaderText = "Rendering Options"
			Me.radGroupRenderOpts.Location = New Point(10, 6)
			Me.radGroupRenderOpts.Name = "radGroupRenderOpts"
			Me.radGroupRenderOpts.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupRenderOpts.Size = New Size(180, 208)
			Me.radGroupRenderOpts.TabIndex = 1
			Me.radGroupRenderOpts.Text = "Rendering Options"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(1460, 1000)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DatesList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ColorList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRenderOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRenderOpts.ResumeLayout(False)
			Me.radGroupRenderOpts.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private DatesList As Telerik.WinControls.UI.RadDropDownList
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private ColorList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radGroupRenderOpts As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace