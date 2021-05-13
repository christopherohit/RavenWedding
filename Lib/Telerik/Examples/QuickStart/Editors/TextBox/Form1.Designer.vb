Namespace Telerik.Examples.WinControls.Editors.TextBox
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
			Me.radTxtDemo1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radTxtDemo2 = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupNull = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblNulltext = New Telerik.WinControls.UI.RadLabel()
			Me.radTxtNullText = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupMulti = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckCancel = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLblNewValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLblOldValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxShowClearButton = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTxtDemo1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtDemo2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupNull, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupNull.SuspendLayout()
			CType(Me.radLblNulltext, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtNullText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupMulti, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupMulti.SuspendLayout()
			CType(Me.radCheckCancel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblNewValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblOldValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowClearButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel2)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radTxtDemo2)
			Me.radPanelDemoHolder.Controls.Add(Me.radTxtDemo1)
			Me.radPanelDemoHolder.Size = New Size(261, 208)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupMulti)
			Me.settingsPanel.Controls.Add(Me.radGroupNull)
			Me.settingsPanel.Location = New Point(598, 1)
			Me.settingsPanel.Size = New Size(200, 569)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupNull, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupMulti, 0)
			' 
			' radTxtDemo1
			' 
			Me.radTxtDemo1.Anchor = AnchorStyles.None
			Me.radTxtDemo1.Location = New Point(1, 24)
			Me.radTxtDemo1.Name = "radTxtDemo1"
			Me.radTxtDemo1.NullText = "Type here..."
			' 
			' 
			' 
			Me.radTxtDemo1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTxtDemo1.ShowClearButton = True
			Me.radTxtDemo1.Size = New Size(153, 20)
			Me.radTxtDemo1.TabIndex = 0
			' 
			' radTxtDemo2
			' 
			Me.radTxtDemo2.Anchor = AnchorStyles.None
			Me.radTxtDemo2.AutoSize = False
			Me.radTxtDemo2.Location = New Point(1, 77)
			Me.radTxtDemo2.Multiline = True
			Me.radTxtDemo2.Name = "radTxtDemo2"
			Me.radTxtDemo2.NullText = "Type here..."
			Me.radTxtDemo2.Size = New Size(153, 94)
			Me.radTxtDemo2.TabIndex = 0
			' 
			' radGroupNull
			' 
			Me.radGroupNull.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupNull.Anchor = AnchorStyles.Top
			Me.radGroupNull.Controls.Add(Me.radCheckBoxShowClearButton)
			Me.radGroupNull.Controls.Add(Me.radLblNulltext)
			Me.radGroupNull.Controls.Add(Me.radTxtNullText)
			Me.radGroupNull.FooterText = ""
			Me.radGroupNull.HeaderText = "Singleline TextBox settings"
			Me.radGroupNull.Location = New Point(10, 6)
			Me.radGroupNull.Name = "radGroupNull"
			Me.radGroupNull.Size = New Size(180, 102)
			Me.radGroupNull.TabIndex = 0
			Me.radGroupNull.Text = "Singleline TextBox settings"
			' 
			' radLblNulltext
			' 
			Me.radLblNulltext.AutoSize = False
			Me.radLblNulltext.Location = New Point(7, 44)
			Me.radLblNulltext.Name = "radLblNulltext"
			Me.radLblNulltext.Size = New Size(141, 16)
			Me.radLblNulltext.TabIndex = 1
			Me.radLblNulltext.Text = "Enter new Null Text:"
			' 
			' radTxtNullText
			' 
			Me.radTxtNullText.Location = New Point(7, 66)
			Me.radTxtNullText.Name = "radTxtNullText"
			' 
			' 
			' 
			Me.radTxtNullText.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radTxtNullText.Size = New Size(148, 20)
			Me.radTxtNullText.TabIndex = 0
			' 
			' radGroupMulti
			' 
			Me.radGroupMulti.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupMulti.Anchor = AnchorStyles.Top
			Me.radGroupMulti.Controls.Add(Me.radCheckCancel)
			Me.radGroupMulti.Controls.Add(Me.radLblNewValue)
			Me.radGroupMulti.Controls.Add(Me.radLblOldValue)
			Me.radGroupMulti.FooterText = ""
			Me.radGroupMulti.HeaderText = " Multiline TextBox settings"
			Me.radGroupMulti.Location = New Point(10, 123)
			Me.radGroupMulti.Name = "radGroupMulti"
			Me.radGroupMulti.Size = New Size(180, 194)
			Me.radGroupMulti.TabIndex = 1
			Me.radGroupMulti.Text = " Multiline TextBox settings"
			' 
			' radCheckCancel
			' 
			Me.radCheckCancel.Location = New Point(7, 164)
			Me.radCheckCancel.Name = "radCheckCancel"
			Me.radCheckCancel.Size = New Size(102, 18)
			Me.radCheckCancel.TabIndex = 2
			Me.radCheckCancel.Text = "Cancel On Event"
			' 
			' radLblNewValue
			' 
			Me.radLblNewValue.Location = New Point(7, 90)
			Me.radLblNewValue.MaximumSize = New Size(155, 67)
			Me.radLblNewValue.Name = "radLblNewValue"
			' 
			' 
			' 
			Me.radLblNewValue.RootElement.MaxSize = New Size(155, 67)
			Me.radLblNewValue.Size = New Size(61, 18)
			Me.radLblNewValue.TabIndex = 1
			Me.radLblNewValue.Text = "New value:"
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "New value:"
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
			CType(Me.radLblNewValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
			CType(Me.radLblNewValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchVertically = True
			CType(Me.radLblNewValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.TopLeft
			' 
			' radLblOldValue
			' 
			Me.radLblOldValue.Location = New Point(7, 25)
			Me.radLblOldValue.MaximumSize = New Size(155, 67)
			Me.radLblOldValue.Name = "radLblOldValue"
			' 
			' 
			' 
			Me.radLblOldValue.RootElement.MaxSize = New Size(155, 67)
			Me.radLblOldValue.Size = New Size(56, 18)
			Me.radLblOldValue.TabIndex = 1
			Me.radLblOldValue.Text = "Old value:"
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Old value:"
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
			CType(Me.radLblOldValue.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
			CType(Me.radLblOldValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchVertically = True
			CType(Me.radLblOldValue.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.TopLeft
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.None
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Location = New Point(1, 2)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(153, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Single-line text box:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.None
			Me.radLabel2.AutoSize = False
			Me.radLabel2.Location = New Point(1, 55)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(153, 16)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Multi-line text box:"
			' 
			' radCheckBoxShowClearButton
			' 
			Me.radCheckBoxShowClearButton.CheckState = CheckState.Checked
			Me.radCheckBoxShowClearButton.Location = New Point(7, 22)
			Me.radCheckBoxShowClearButton.Name = "radCheckBoxShowClearButton"
			Me.radCheckBoxShowClearButton.Size = New Size(111, 18)
			Me.radCheckBoxShowClearButton.TabIndex = 2
			Me.radCheckBoxShowClearButton.Text = "Show clear button"
			Me.radCheckBoxShowClearButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1471, 917)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTxtDemo1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtDemo2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupNull, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupNull.ResumeLayout(False)
			Me.radGroupNull.PerformLayout()
			CType(Me.radLblNulltext, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtNullText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupMulti, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupMulti.ResumeLayout(False)
			Me.radGroupMulti.PerformLayout()
			CType(Me.radCheckCancel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblNewValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblOldValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowClearButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTxtDemo1 As Telerik.WinControls.UI.RadTextBox
		Private radTxtDemo2 As Telerik.WinControls.UI.RadTextBox
		Private radGroupNull As Telerik.WinControls.UI.RadGroupBox
		Private radGroupMulti As Telerik.WinControls.UI.RadGroupBox
		Private radLblNewValue As Telerik.WinControls.UI.RadLabel
		Private radLblOldValue As Telerik.WinControls.UI.RadLabel
		Private radLblNulltext As Telerik.WinControls.UI.RadLabel
		Private radTxtNullText As Telerik.WinControls.UI.RadTextBox
		Private radCheckCancel As Telerik.WinControls.UI.RadCheckBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radCheckBoxShowClearButton As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace