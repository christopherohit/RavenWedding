Namespace Telerik.Examples.WinControls.Editors.AutoCompleteBox
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
            Me.radButtonSend = New Telerik.WinControls.UI.RadButton()
            Me.radButtonTo = New Telerik.WinControls.UI.RadButton()
            Me.radButtonCc = New Telerik.WinControls.UI.RadButton()
            Me.radLabelSubject = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxControlSubject = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radAutoCompleteBox1 = New Telerik.WinControls.UI.RadAutoCompleteBox()
            Me.radAutoCompleteBox2 = New Telerik.WinControls.UI.RadAutoCompleteBox()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radListControlRecipients = New Telerik.WinControls.UI.RadListControl()
            Me.radLabel1Recipients = New Telerik.WinControls.UI.RadLabel()
            Me.radListControlCarbonCopy = New Telerik.WinControls.UI.RadListControl()
            Me.radLabelCarbonCopy = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListAutoCompleteMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabelAutoComplete = New Telerik.WinControls.UI.RadLabel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonSend, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonTo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonCc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxControlSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radAutoCompleteBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radAutoCompleteBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            CType(Me.radListControlRecipients, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1Recipients, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListControlCarbonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelCarbonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListAutoCompleteMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelAutoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(900, 125)
            Me.settingsPanel.Margin = New Padding(8)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.settingsPanel.PanelContainer.Size = New Size(420, 998)
            Me.settingsPanel.Size = New Size(420, 998)
            ' 
            ' optionsLabel
            ' 
            Me.optionsLabel.Location = New Point(5, 5)
            Me.optionsLabel.Margin = New Padding(4)
            ' 
            ' radButtonSend
            ' 
            Me.radButtonSend.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radButtonSend.Image = My.Resources.send_email
            Me.radButtonSend.ImageAlignment = ContentAlignment.BottomCenter
            Me.radButtonSend.Location = New Point(15, 15)
            Me.radButtonSend.Margin = New Padding(15)
            Me.radButtonSend.Name = "radButtonSend"
            Me.tableLayoutPanel1.SetRowSpan(Me.radButtonSend, 3)
            Me.radButtonSend.Size = New Size(75, 174)
            Me.radButtonSend.TabIndex = 1
            Me.radButtonSend.Text = "Send"
            Me.radButtonSend.TextAlignment = ContentAlignment.TopCenter
            Me.radButtonSend.TextImageRelation = TextImageRelation.ImageAboveText
            ' 
            ' radButtonTo
            ' 
            Me.radButtonTo.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.radButtonTo.Location = New Point(113, 9)
            Me.radButtonTo.Margin = New Padding(8)
            Me.radButtonTo.Name = "radButtonTo"
            Me.radButtonTo.Size = New Size(82, 50)
            Me.radButtonTo.TabIndex = 2
            Me.radButtonTo.Text = "To..."
            ' 
            ' radButtonCc
            ' 
            Me.radButtonCc.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.radButtonCc.Location = New Point(113, 77)
            Me.radButtonCc.Margin = New Padding(8)
            Me.radButtonCc.Name = "radButtonCc"
            Me.radButtonCc.Size = New Size(82, 50)
            Me.radButtonCc.TabIndex = 3
            Me.radButtonCc.Text = "Cc..."
            ' 
            ' radLabelSubject
            ' 
            Me.radLabelSubject.Anchor = AnchorStyles.Right
            Me.radLabelSubject.Location = New Point(150, 163)
            Me.radLabelSubject.Margin = New Padding(8, 12, 8, 8)
            Me.radLabelSubject.Name = "radLabelSubject"
            Me.radLabelSubject.Size = New Size(45, 18)
            Me.radLabelSubject.TabIndex = 4
            Me.radLabelSubject.Text = "Subject:"
            ' 
            ' radTextBoxControlSubject
            ' 
            Me.radTextBoxControlSubject.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radTextBoxControlSubject.Location = New Point(211, 144)
            Me.radTextBoxControlSubject.Margin = New Padding(8)
            Me.radTextBoxControlSubject.Name = "radTextBoxControlSubject"
            ' 
            ' 
            ' 
            Me.radTextBoxControlSubject.RootElement.MinSize = New Size(0, 0)
            Me.radTextBoxControlSubject.Size = New Size(487, 52)
            Me.radTextBoxControlSubject.TabIndex = 5
            Me.radTextBoxControlSubject.Text = "Re: Feedback"
            ' 
            ' radAutoCompleteBox1
            ' 
            Me.radAutoCompleteBox1.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.radAutoCompleteBox1.Location = New Point(211, 77)
            Me.radAutoCompleteBox1.Margin = New Padding(8)
            Me.radAutoCompleteBox1.Name = "radAutoCompleteBox1"
            ' 
            ' 
            ' 
            Me.radAutoCompleteBox1.RootElement.MaxSize = New Size(0, 0)
            Me.radAutoCompleteBox1.RootElement.MinSize = New Size(0, 0)
            Me.radAutoCompleteBox1.Size = New Size(487, 50)
            Me.radAutoCompleteBox1.TabIndex = 6
            Me.radAutoCompleteBox1.Text = "Samuel Jackson;"
            ' 
            ' radAutoCompleteBox2
            ' 
            Me.radAutoCompleteBox2.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.radAutoCompleteBox2.Location = New Point(211, 9)
            Me.radAutoCompleteBox2.Margin = New Padding(8)
            Me.radAutoCompleteBox2.Name = "radAutoCompleteBox2"
            ' 
            ' 
            ' 
            Me.radAutoCompleteBox2.RootElement.MaxSize = New Size(0, 0)
            Me.radAutoCompleteBox2.RootElement.MinSize = New Size(0, 0)
            Me.radAutoCompleteBox2.Size = New Size(487, 50)
            Me.radAutoCompleteBox2.TabIndex = 7
            Me.radAutoCompleteBox2.Text = "Joe Smith;"
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Controls.Add(Me.radTextBox1)
            Me.radPanel1.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanel1.Location = New Point(0, 0)
            Me.radPanel1.Margin = New Padding(8)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New Size(872, 700)
            Me.radPanel1.TabIndex = 8
            ' 
            ' radTextBox1
            ' 
            Me.radTextBox1.AutoSize = False
            Me.radTextBox1.Font = New Font("Calibri", 11.0F)
            Me.radTextBox1.Location = New Point(24, 266)
            Me.radTextBox1.Margin = New Padding(8)
            Me.radTextBox1.Multiline = True
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.ReadOnly = True
            Me.radTextBox1.Size = New Size(698, 334)
            Me.radTextBox1.TabIndex = 8
            Me.radTextBox1.Text = resources.GetString("radTextBox1.Text")
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.89521F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.99701F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 71.18263F))
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonSend, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxControlSubject, 2, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelSubject, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonTo, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radAutoCompleteBox1, 2, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonCc, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radAutoCompleteBox2, 2, 0)
            Me.tableLayoutPanel1.Location = New Point(24, 48)
            Me.tableLayoutPanel1.Margin = New Padding(6)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.Size = New Size(706, 204)
            Me.tableLayoutPanel1.TabIndex = 5
            ' 
            ' radListControlRecipients
            ' 
            Me.radListControlRecipients.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radListControlRecipients.ItemHeight = 45
            Me.radListControlRecipients.Location = New Point(8, 69)
            Me.radListControlRecipients.Margin = New Padding(8)
            Me.radListControlRecipients.Name = "radListControlRecipients"
            Me.radListControlRecipients.Size = New Size(254, 291)
            Me.radListControlRecipients.TabIndex = 1
            ' 
            ' radLabel1Recipients
            ' 
            Me.radLabel1Recipients.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
            Me.radLabel1Recipients.Location = New Point(8, 35)
            Me.radLabel1Recipients.Margin = New Padding(8)
            Me.radLabel1Recipients.Name = "radLabel1Recipients"
            Me.radLabel1Recipients.Size = New Size(77, 18)
            Me.radLabel1Recipients.TabIndex = 2
            Me.radLabel1Recipients.Text = "Recipients List"
            ' 
            ' radListControlCarbonCopy
            ' 
            Me.radListControlCarbonCopy.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radListControlCarbonCopy.ItemHeight = 45
            Me.radListControlCarbonCopy.Location = New Point(8, 437)
            Me.radListControlCarbonCopy.Margin = New Padding(8)
            Me.radListControlCarbonCopy.Name = "radListControlCarbonCopy"
            Me.radListControlCarbonCopy.Size = New Size(254, 291)
            Me.radListControlCarbonCopy.TabIndex = 3
            ' 
            ' radLabelCarbonCopy
            ' 
            Me.radLabelCarbonCopy.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
            Me.radLabelCarbonCopy.Location = New Point(8, 403)
            Me.radLabelCarbonCopy.Margin = New Padding(8)
            Me.radLabelCarbonCopy.Name = "radLabelCarbonCopy"
            Me.radLabelCarbonCopy.Size = New Size(91, 18)
            Me.radLabelCarbonCopy.TabIndex = 4
            Me.radLabelCarbonCopy.Text = "Carbon Copy List"
            ' 
            ' radDropDownListAutoCompleteMode
            ' 
            Me.radDropDownListAutoCompleteMode.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radDropDownListAutoCompleteMode.DropDownHeight = 260
            Me.radDropDownListAutoCompleteMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Text = "Suggest"
            radListDataItem2.Text = "Append"
            radListDataItem3.Text = "SuggestAppend"
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem1)
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem2)
            Me.radDropDownListAutoCompleteMode.Items.Add(radListDataItem3)
            Me.radDropDownListAutoCompleteMode.Location = New Point(8, 805)
            Me.radDropDownListAutoCompleteMode.Margin = New Padding(8)
            Me.radDropDownListAutoCompleteMode.Name = "radDropDownListAutoCompleteMode"
            Me.radDropDownListAutoCompleteMode.Size = New Size(254, 20)
            Me.radDropDownListAutoCompleteMode.TabIndex = 5
            ' 
            ' radLabelAutoComplete
            ' 
            Me.radLabelAutoComplete.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
            Me.radLabelAutoComplete.Location = New Point(8, 771)
            Me.radLabelAutoComplete.Margin = New Padding(8)
            Me.radLabelAutoComplete.Name = "radLabelAutoComplete"
            Me.radLabelAutoComplete.Size = New Size(111, 18)
            Me.radLabelAutoComplete.TabIndex = 6
            Me.radLabelAutoComplete.Text = "AutoComplete Mode"
            ' 
            ' doubleBufferedTableLayoutPanel1
            ' 
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radListControlRecipients, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1Recipients, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownListAutoCompleteMode, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelAutoComplete, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelCarbonCopy, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radListControlCarbonCopy, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Location = New Point(82, 5)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 6
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35.71429F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35.71429F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
            Me.doubleBufferedTableLayoutPanel1.Size = New Size(270, 861)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 7
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radPanel1)
            Me.Name = "Form1"
            Me.Size = New Size(1963, 1146)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonSend, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonTo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonCc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelSubject, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxControlSubject, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radAutoCompleteBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radAutoCompleteBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType(Me.radListControlRecipients, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1Recipients, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListControlCarbonCopy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelCarbonCopy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListAutoCompleteMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelAutoComplete, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radButtonSend As Telerik.WinControls.UI.RadButton
        Private radButtonTo As Telerik.WinControls.UI.RadButton
        Private radButtonCc As Telerik.WinControls.UI.RadButton
        Private radLabelSubject As Telerik.WinControls.UI.RadLabel
        Private radTextBoxControlSubject As Telerik.WinControls.UI.RadTextBoxControl
        Private radAutoCompleteBox1 As Telerik.WinControls.UI.RadAutoCompleteBox
        Private radAutoCompleteBox2 As Telerik.WinControls.UI.RadAutoCompleteBox
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radLabelCarbonCopy As Telerik.WinControls.UI.RadLabel
        Private radListControlCarbonCopy As Telerik.WinControls.UI.RadListControl
        Private radLabel1Recipients As Telerik.WinControls.UI.RadLabel
        Private radListControlRecipients As Telerik.WinControls.UI.RadListControl
        Private radLabelAutoComplete As Telerik.WinControls.UI.RadLabel
        Private radDropDownListAutoCompleteMode As Telerik.WinControls.UI.RadDropDownList
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace