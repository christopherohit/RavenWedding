Namespace Telerik.Examples.WinControls.DropDownListAndListControl.CheckedDropDownList
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
            Dim radCheckedListDataItem1 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem2 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem3 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem4 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem5 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem6 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem7 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem8 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem9 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem10 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem11 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem12 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Dim radCheckedListDataItem13 As New Telerik.WinControls.UI.RadCheckedListDataItem()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckedDropDownList1 = New Telerik.WinControls.UI.RadCheckedDropDownList()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckedDropDownList2 = New Telerik.WinControls.UI.RadCheckedDropDownList()
            Me.radTimePicker1 = New Telerik.WinControls.UI.RadTimePicker()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckedDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckedDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(751, 0)
            Me.settingsPanel.Margin = New Padding(5)
            Me.settingsPanel.Padding = New Padding(5)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radToggleButton1)
            Me.settingsPanel.PanelContainer.Location = New Point(5, 5)
            Me.settingsPanel.PanelContainer.Margin = New Padding(5)
            Me.settingsPanel.PanelContainer.Size = New Size(399, 239)
            Me.settingsPanel.Size = New Size(409, 249)
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Location = New Point(30, 30)
            Me.radLabel1.Margin = New Padding(5)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(52, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "New task"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Location = New Point(27, 125)
            Me.radLabel2.Margin = New Padding(5)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New Size(51, 18)
            Me.radLabel2.TabIndex = 4
            Me.radLabel2.Text = "Category"
            ' 
            ' radCheckedDropDownList1
            ' 
            Me.radCheckedDropDownList1.DropDownAnimationEnabled = False
            Me.radCheckedDropDownList1.DropDownHeight = 188
            radCheckedListDataItem1.Checked = True
            radCheckedListDataItem1.Text = "work"
            radCheckedListDataItem2.Checked = True
            radCheckedListDataItem2.Text = "to do"
            radCheckedListDataItem3.Checked = True
            radCheckedListDataItem3.Text = "emails"
            radCheckedListDataItem4.Text = "forwarded"
            radCheckedListDataItem5.Text = "replied"
            radCheckedListDataItem6.Text = "duplicate"
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem1)
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem2)
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem3)
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem4)
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem5)
            Me.radCheckedDropDownList1.Items.Add(radCheckedListDataItem6)
            Me.radCheckedDropDownList1.Location = New Point(27, 157)
            Me.radCheckedDropDownList1.Margin = New Padding(5)
            Me.radCheckedDropDownList1.Name = "radCheckedDropDownList1"
            Me.radCheckedDropDownList1.Size = New Size(533, 20)
            Me.radCheckedDropDownList1.TabIndex = 5
            Me.radCheckedDropDownList1.Text = "work;to do;emails;"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Location = New Point(27, 215)
            Me.radLabel3.Margin = New Padding(5)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New Size(54, 18)
            Me.radLabel3.TabIndex = 6
            Me.radLabel3.Text = "Reminder"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Location = New Point(27, 303)
            Me.radLabel4.Margin = New Padding(5)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New Size(98, 18)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Text = "Appointment time"
            ' 
            ' radCheckedDropDownList2
            ' 
            Me.radCheckedDropDownList2.DropDownAnimationEnabled = False
            Me.radCheckedDropDownList2.DropDownHeight = 188
            radCheckedListDataItem7.Checked = True
            radCheckedListDataItem7.Text = "Monday"
            radCheckedListDataItem8.Checked = True
            radCheckedListDataItem8.Text = "Tuesday"
            radCheckedListDataItem9.Text = "Wednesday"
            radCheckedListDataItem10.Text = "Thursday"
            radCheckedListDataItem11.Text = "Friday"
            radCheckedListDataItem12.Text = "Saturday"
            radCheckedListDataItem13.Text = "Sunday"
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem7)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem8)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem9)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem10)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem11)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem12)
            Me.radCheckedDropDownList2.Items.Add(radCheckedListDataItem13)
            Me.radCheckedDropDownList2.Location = New Point(27, 247)
            Me.radCheckedDropDownList2.Margin = New Padding(5)
            Me.radCheckedDropDownList2.Name = "radCheckedDropDownList2"
            Me.radCheckedDropDownList2.Size = New Size(533, 20)
            Me.radCheckedDropDownList2.TabIndex = 8
            Me.radCheckedDropDownList2.Text = "Monday;Tuesday;"
            ' 
            ' radTimePicker1
            ' 
            Me.radTimePicker1.Location = New Point(27, 335)
            Me.radTimePicker1.Margin = New Padding(5)
            Me.radTimePicker1.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
            Me.radTimePicker1.MinValue = New Date((CLng(0)))
            Me.radTimePicker1.Name = "radTimePicker1"
            Me.radTimePicker1.Size = New Size(533, 20)
            Me.radTimePicker1.TabIndex = 9
            Me.radTimePicker1.TabStop = False
            Me.radTimePicker1.Value = New Date(2014, 9, 3, 10, 43, 22, 508)
            ' 
            ' radTextBox1
            ' 
            Me.radTextBox1.Location = New Point(27, 69)
            Me.radTextBox1.Margin = New Padding(5)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.NullText = "Task name"
            Me.radTextBox1.Size = New Size(533, 20)
            Me.radTextBox1.TabIndex = 10
            Me.radTextBox1.Text = "Task name"
            ' 
            ' radButton1
            ' 
            Me.radButton1.Location = New Point(27, 423)
            Me.radButton1.Margin = New Padding(5)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New Size(196, 37)
            Me.radButton1.TabIndex = 11
            Me.radButton1.Text = "Create"
            '			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
            ' 
            ' radToggleButton1
            ' 
            Me.radToggleButton1.Anchor = AnchorStyles.Top
            Me.radToggleButton1.Location = New Point(12, 86)
            Me.radToggleButton1.Margin = New Padding(5)
            Me.radToggleButton1.Name = "radToggleButton1"
            Me.radToggleButton1.Size = New Size(373, 37)
            Me.radToggleButton1.TabIndex = 1
            Me.radToggleButton1.Text = "Show CheckAll Item"
            '			Me.radToggleButton1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radToggleButton1_ToggleStateChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.radButton1)
            Me.Controls.Add(Me.radTextBox1)
            Me.Controls.Add(Me.radTimePicker1)
            Me.Controls.Add(Me.radCheckedDropDownList2)
            Me.Controls.Add(Me.radLabel4)
            Me.Controls.Add(Me.radLabel3)
            Me.Controls.Add(Me.radCheckedDropDownList1)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.radLabel1)
            Me.Name = "Form1"
            Me.Size = New Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.Controls.SetChildIndex(Me.radCheckedDropDownList1, 0)
            Me.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.Controls.SetChildIndex(Me.radLabel4, 0)
            Me.Controls.SetChildIndex(Me.radCheckedDropDownList2, 0)
            Me.Controls.SetChildIndex(Me.radTimePicker1, 0)
            Me.Controls.SetChildIndex(Me.radTextBox1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radButton1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckedDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckedDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radCheckedDropDownList1 As Telerik.WinControls.UI.RadCheckedDropDownList
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radCheckedDropDownList2 As Telerik.WinControls.UI.RadCheckedDropDownList
        Private radTimePicker1 As Telerik.WinControls.UI.RadTimePicker
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
        Private WithEvents radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
    End Class
End Namespace