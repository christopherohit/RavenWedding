Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.Forms.MessageBox
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
			Dim radListDataItem12 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem10 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem11 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radTxtMessage = New Telerik.WinControls.UI.RadTextBox()
			Me.radCheckRTL = New Telerik.WinControls.UI.RadCheckBox()
			Me.radTxtCaption = New Telerik.WinControls.UI.RadTextBox()
			Me.radBtnShow = New Telerik.WinControls.UI.RadButton()
			Me.radComboMessageType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboButtons = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblDialog = New Telerik.WinControls.UI.RadLabel()
			Me.radLblButtons = New Telerik.WinControls.UI.RadLabel()
			Me.radLblType = New Telerik.WinControls.UI.RadLabel()
			Me.radLblText = New Telerik.WinControls.UI.RadLabel()
			Me.radLblCaption = New Telerik.WinControls.UI.RadLabel()
			Me.radTxtDialogResult = New Telerik.WinControls.UI.RadTextBox()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtMessage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboMessageType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radLblDialog, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtDialogResult, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(940, 1)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.PanelContainer.Size = New Size(200, 597)
			Me.settingsPanel.Size = New Size(200, 597)
			' 
			' radTxtMessage
			' 
			Me.radTxtMessage.AcceptsReturn = True
			Me.radTxtMessage.Anchor = AnchorStyles.Top
			Me.radTxtMessage.AutoSize = False
			Me.radTxtMessage.Location = New Point(5, 94)
			Me.radTxtMessage.Multiline = True
			Me.radTxtMessage.Name = "radTxtMessage"
			Me.radTxtMessage.Size = New Size(170, 41)
			Me.radTxtMessage.TabIndex = 0
			Me.radTxtMessage.Text = "Hello, World!"
			' 
			' radCheckRTL
			' 
			Me.radCheckRTL.Anchor = AnchorStyles.Top
			Me.radCheckRTL.BackColor = Color.Transparent
			Me.radCheckRTL.Location = New Point(5, 269)
			Me.radCheckRTL.Name = "radCheckRTL"
			Me.radCheckRTL.Size = New Size(78, 18)
			Me.radCheckRTL.TabIndex = 9
			Me.radCheckRTL.Text = "RightToLeft"
			' 
			' radTxtCaption
			' 
			Me.radTxtCaption.Anchor = AnchorStyles.Top
			Me.radTxtCaption.Location = New Point(5, 49)
			Me.radTxtCaption.Name = "radTxtCaption"
			Me.radTxtCaption.NullText = "Type caption..."
			Me.radTxtCaption.Size = New Size(170, 20)
			Me.radTxtCaption.TabIndex = 1
			Me.radTxtCaption.Text = "Message"
			' 
			' radBtnShow
			' 
			Me.radBtnShow.Location = New Point(104, 166)
			Me.radBtnShow.Name = "radBtnShow"
			Me.radBtnShow.Size = New Size(229, 30)
			Me.radBtnShow.TabIndex = 5
			Me.radBtnShow.Text = "Show RadMessageBox"
			' 
			' radComboMessageType
			' 
			Me.radComboMessageType.Anchor = AnchorStyles.Top
			Me.radComboMessageType.AutoCompleteDisplayMember = Nothing
			Me.radComboMessageType.AutoCompleteValueMember = Nothing
			Me.radComboMessageType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem12.Text = "None"
			radListDataItem13.Text = "Info"
			radListDataItem14.Text = "Question"
			radListDataItem15.Text = "Exclamation"
			radListDataItem16.Text = "Error"
			Me.radComboMessageType.Items.Add(radListDataItem12)
			Me.radComboMessageType.Items.Add(radListDataItem13)
			Me.radComboMessageType.Items.Add(radListDataItem14)
			Me.radComboMessageType.Items.Add(radListDataItem15)
			Me.radComboMessageType.Items.Add(radListDataItem16)
			Me.radComboMessageType.Location = New Point(5, 161)
			Me.radComboMessageType.Name = "radComboMessageType"
			Me.radComboMessageType.Size = New Size(170, 20)
			Me.radComboMessageType.TabIndex = 8
			' 
			' radComboButtons
			' 
			Me.radComboButtons.Anchor = AnchorStyles.Top
			Me.radComboButtons.AutoCompleteDisplayMember = Nothing
			Me.radComboButtons.AutoCompleteValueMember = Nothing
			Me.radComboButtons.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem6.Text = "OK"
			radListDataItem7.Text = "OK, Cancel"
			radListDataItem8.Text = "Yes, No"
			radListDataItem9.Text = "Yes, No, Cancel"
			radListDataItem10.Text = "Retry, Cancel"
			radListDataItem11.Text = "Abort, Retry, Ignore"
			Me.radComboButtons.Items.Add(radListDataItem6)
			Me.radComboButtons.Items.Add(radListDataItem7)
			Me.radComboButtons.Items.Add(radListDataItem8)
			Me.radComboButtons.Items.Add(radListDataItem9)
			Me.radComboButtons.Items.Add(radListDataItem10)
			Me.radComboButtons.Items.Add(radListDataItem11)
			Me.radComboButtons.Location = New Point(5, 207)
			Me.radComboButtons.Name = "radComboButtons"
			Me.radComboButtons.Size = New Size(170, 20)
			Me.radComboButtons.TabIndex = 6
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupSettings.Anchor = AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radLblDialog)
			Me.radGroupSettings.Controls.Add(Me.radLblButtons)
			Me.radGroupSettings.Controls.Add(Me.radCheckRTL)
			Me.radGroupSettings.Controls.Add(Me.radLblType)
			Me.radGroupSettings.Controls.Add(Me.radTxtMessage)
			Me.radGroupSettings.Controls.Add(Me.radLblText)
			Me.radGroupSettings.Controls.Add(Me.radLblCaption)
			Me.radGroupSettings.Controls.Add(Me.radComboButtons)
			Me.radGroupSettings.Controls.Add(Me.radTxtDialogResult)
			Me.radGroupSettings.Controls.Add(Me.radTxtCaption)
			Me.radGroupSettings.Controls.Add(Me.radComboMessageType)
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.HeaderText = " MessageBox Settings "
			Me.radGroupSettings.Location = New Point(-5, 5)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Size = New Size(180, 300)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " MessageBox Settings "
			' 
			' radLblDialog
			' 
			Me.radLblDialog.Anchor = AnchorStyles.Top
			Me.radLblDialog.Location = New Point(5, 243)
			Me.radLblDialog.Name = "radLblDialog"
			Me.radLblDialog.Size = New Size(75, 18)
			Me.radLblDialog.TabIndex = 12
			Me.radLblDialog.Text = "Dialog Result:"
			' 
			' radLblButtons
			' 
			Me.radLblButtons.Anchor = AnchorStyles.Top
			Me.radLblButtons.Location = New Point(5, 187)
			Me.radLblButtons.Name = "radLblButtons"
			Me.radLblButtons.Size = New Size(47, 18)
			Me.radLblButtons.TabIndex = 2
			Me.radLblButtons.Text = "Buttons:"
			' 
			' radLblType
			' 
			Me.radLblType.Anchor = AnchorStyles.Top
			Me.radLblType.Location = New Point(5, 141)
			Me.radLblType.Name = "radLblType"
			Me.radLblType.Size = New Size(80, 18)
			Me.radLblType.TabIndex = 2
			Me.radLblType.Text = "Message Type:"
			' 
			' radLblText
			' 
			Me.radLblText.Anchor = AnchorStyles.Top
			Me.radLblText.Location = New Point(5, 74)
			Me.radLblText.Name = "radLblText"
			Me.radLblText.Size = New Size(77, 18)
			Me.radLblText.TabIndex = 2
			Me.radLblText.Text = "Message Text:"
			' 
			' radLblCaption
			' 
			Me.radLblCaption.Anchor = AnchorStyles.Top
			Me.radLblCaption.Location = New Point(5, 28)
			Me.radLblCaption.Name = "radLblCaption"
			Me.radLblCaption.Size = New Size(95, 18)
			Me.radLblCaption.TabIndex = 0
			Me.radLblCaption.Text = "Message Caption:"
			' 
			' radTxtDialogResult
			' 
			Me.radTxtDialogResult.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radTxtDialogResult.Location = New Point(93, 240)
			Me.radTxtDialogResult.Name = "radTxtDialogResult"
			Me.radTxtDialogResult.Size = New Size(82, 20)
			Me.radTxtDialogResult.TabIndex = 1
			Me.radTxtDialogResult.Tag = "Right"
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radBtnShow)
			Me.radPanel1.Location = New Point(237, 80)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(512, 325)
			Me.radPanel1.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1974, 1181)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtMessage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckRTL, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboMessageType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radLblDialog, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtDialogResult, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTxtMessage As Telerik.WinControls.UI.RadTextBox
		Private radCheckRTL As Telerik.WinControls.UI.RadCheckBox
		Private radTxtCaption As Telerik.WinControls.UI.RadTextBox
		Private radBtnShow As Telerik.WinControls.UI.RadButton
		Private radComboMessageType As Telerik.WinControls.UI.RadDropDownList
		Private radComboButtons As Telerik.WinControls.UI.RadDropDownList
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblCaption As Telerik.WinControls.UI.RadLabel
		Private radLblText As Telerik.WinControls.UI.RadLabel
		Private radLblType As Telerik.WinControls.UI.RadLabel
		Private radLblButtons As Telerik.WinControls.UI.RadLabel
		Private radLblDialog As Telerik.WinControls.UI.RadLabel
		Private radTxtDialogResult As Telerik.WinControls.UI.RadTextBox
		Private radPanel1 As RadPanel
	End Class
End Namespace
