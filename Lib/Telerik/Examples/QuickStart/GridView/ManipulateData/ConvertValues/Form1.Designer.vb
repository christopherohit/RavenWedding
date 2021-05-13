Namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
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
			Me.gridView = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.btnEvaluate = New Telerik.WinControls.UI.RadButton()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radComboTimeZone = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.btnEvaluate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboTimeZone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(751, 1)
			Me.settingsPanel.Size = New Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' gridView
			' 
			Me.gridView.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter
			Me.gridView.Dock = DockStyle.Fill
			Me.gridView.EnableHotTracking = False
			Me.gridView.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.gridView.MasterTemplate.Caption = Nothing
			Me.gridView.Name = "gridView"
			Me.gridView.Size = New Size(952, 808)
			Me.gridView.TabIndex = 1
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.btnEvaluate)
			Me.radGroupBox1.Controls.Add(Me.radTextBox1)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radComboTimeZone)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = "Conversion Preferences "
			Me.radGroupBox1.Location = New Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 229)
			Me.radGroupBox1.TabIndex = 8
			Me.radGroupBox1.Text = "Conversion Preferences "
			' 
			' btnEvaluate
			' 
			Me.btnEvaluate.Location = New Point(21, 200)
			Me.btnEvaluate.Name = "btnEvaluate"
			Me.btnEvaluate.Size = New Size(146, 24)
			Me.btnEvaluate.TabIndex = 6
			Me.btnEvaluate.Text = "Calculate"

			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New Point(21, 113)
			Me.radTextBox1.Multiline = True
			Me.radTextBox1.Name = "radTextBox1"
			' 
			' 
			' 
			Me.radTextBox1.RootElement.StretchVertically = True
			Me.radTextBox1.Size = New Size(146, 81)
			Me.radTextBox1.TabIndex = 5
			Me.radTextBox1.TabStop = False
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(21, 92)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(113, 18)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "Unit Price Expression:"
			' 
			' radComboTimeZone
			' 
			Me.radComboTimeZone.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboTimeZone.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboTimeZone.FormatString = "{0}"
			Me.radComboTimeZone.Location = New Point(21, 56)
			Me.radComboTimeZone.MaxDropDownItems = 6
			Me.radComboTimeZone.Name = "radComboTimeZone"
			' 
			' 
			' 
			Me.radComboTimeZone.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboTimeZone.Size = New Size(146, 20)
			Me.radComboTimeZone.TabIndex = 2
			Me.radComboTimeZone.TabStop = False
			Me.radComboTimeZone.ThemeName = "ControlDefault"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(21, 33)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(62, 18)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Time Zone:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.gridView)
			Me.Name = "Form1"
			Me.Size = New Size(952, 808)

			Me.Controls.SetChildIndex(Me.gridView, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.gridView.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.btnEvaluate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboTimeZone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView As Telerik.WinControls.UI.RadGridView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radComboTimeZone As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private btnEvaluate As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
