Namespace CustomControls
	Partial Public Class DateNavigator
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
			Me.rightNavigationButton_Renamed = New Telerik.WinControls.UI.RadButton()
			Me.leftNavigationButton_Renamed = New Telerik.WinControls.UI.RadButton()
			Me.dateLabel_Renamed = New Telerik.WinControls.UI.RadLabel()
			Me.navigatorDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
			CType(Me.rightNavigationButton_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.leftNavigationButton_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateLabel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigatorDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rightNavigationButton
			' 
			Me.rightNavigationButton_Renamed.Dock = DockStyle.Right
			Me.rightNavigationButton_Renamed.Location = New Point(240, 0)
			Me.rightNavigationButton_Renamed.Name = "rightNavigationButton"
			Me.rightNavigationButton_Renamed.Size = New Size(30, 49)
			Me.rightNavigationButton_Renamed.TabIndex = 0
			' 
			' leftNavigationButton
			' 
			Me.leftNavigationButton_Renamed.Dock = DockStyle.Right
			Me.leftNavigationButton_Renamed.Location = New Point(210, 0)
			Me.leftNavigationButton_Renamed.Name = "leftNavigationButton"
			Me.leftNavigationButton_Renamed.Size = New Size(30, 49)
			Me.leftNavigationButton_Renamed.TabIndex = 1
			' 
			' dateLabel
			' 
			Me.dateLabel_Renamed.AutoSize = False
			Me.dateLabel_Renamed.Dock = DockStyle.Fill
			Me.dateLabel_Renamed.Location = New Point(35, 0)
			Me.dateLabel_Renamed.Name = "dateLabel"
			Me.dateLabel_Renamed.Size = New Size(175, 49)
			Me.dateLabel_Renamed.TabIndex = 2
			Me.dateLabel_Renamed.Text = "radLabel1"
			' 
			' navigatorDateTimePicker
			' 
			Me.navigatorDateTimePicker.AutoSize = False
			Me.navigatorDateTimePicker.Dock = DockStyle.Left
			Me.navigatorDateTimePicker.Location = New Point(0, 0)
			Me.navigatorDateTimePicker.Name = "navigatorDateTimePicker"
			Me.navigatorDateTimePicker.Size = New Size(35, 49)
			Me.navigatorDateTimePicker.TabIndex = 3
			Me.navigatorDateTimePicker.TabStop = False
			Me.navigatorDateTimePicker.Text = "Thursday, May 18, 2017"
			Me.navigatorDateTimePicker.Value = New Date(2017, 5, 18, 15, 37, 25, 339)
			' 
			' DateNavigator
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.dateLabel_Renamed)
			Me.Controls.Add(Me.navigatorDateTimePicker)
			Me.Controls.Add(Me.leftNavigationButton_Renamed)
			Me.Controls.Add(Me.rightNavigationButton_Renamed)
			Me.Name = "DateNavigator"
			Me.Size = New Size(270, 49)
			CType(Me.rightNavigationButton_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.leftNavigationButton_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateLabel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigatorDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

'INSTANT VB NOTE: The variable rightNavigationButton was renamed since Visual Basic does not allow class members with the same name:
		Private rightNavigationButton_Renamed As Telerik.WinControls.UI.RadButton
'INSTANT VB NOTE: The variable leftNavigationButton was renamed since Visual Basic does not allow class members with the same name:
		Private leftNavigationButton_Renamed As Telerik.WinControls.UI.RadButton
'INSTANT VB NOTE: The variable dateLabel was renamed since Visual Basic does not allow class members with the same name:
		Private dateLabel_Renamed As Telerik.WinControls.UI.RadLabel
		Private navigatorDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker


	End Class
End Namespace
