Namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FreeFormatDateInput
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
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radLblCulture = New Telerik.WinControls.UI.RadLabel()
            Me.radComboCultures = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
            Me.radMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radTimePicker1 = New Telerik.WinControls.UI.RadTimePicker()
            Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radDateTimePicker3 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblCulture, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radComboCultures, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.Controls.Add(Me.radTimePicker1)
            Me.radPanelDemoHolder.Controls.Add(Me.radDateTimePicker1)
            Me.radPanelDemoHolder.Controls.Add(Me.radMaskedEditBox1)
            Me.radPanelDemoHolder.Controls.Add(Me.radLabel10)
            Me.radPanelDemoHolder.Controls.Add(Me.radLabel9)
            Me.radPanelDemoHolder.Controls.Add(Me.radLabel8)
            Me.radPanelDemoHolder.ForeColor = Color.Black
            Me.radPanelDemoHolder.Size = New Size(661, 403)
            Me.radPanelDemoHolder.ThemeName = "ControlDefault"
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radLabel2)
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.radDateTimePicker3)
            Me.settingsPanel.Controls.Add(Me.radDateTimePicker2)
            Me.settingsPanel.Controls.Add(Me.radLblCulture)
            Me.settingsPanel.Controls.Add(Me.radComboCultures)
            Me.settingsPanel.Location = New Point(945, 1)
            Me.settingsPanel.Size = New Size(200, 527)
            Me.settingsPanel.Controls.SetChildIndex(Me.radComboCultures, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLblCulture, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDateTimePicker2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDateTimePicker3, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
            ' 
            ' radLabel8
            ' 
            Me.radLabel8.Location = New Point(210, 3)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New Size(86, 18)
            Me.radLabel8.TabIndex = 34
            Me.radLabel8.Text = "DateTimePicker:"
            ' 
            ' radLblCulture
            ' 
            Me.radLblCulture.Anchor = AnchorStyles.Top
            Me.radLblCulture.Location = New Point(10, 56)
            Me.radLblCulture.Name = "radLblCulture"
            Me.radLblCulture.Size = New Size(83, 18)
            Me.radLblCulture.TabIndex = 37
            Me.radLblCulture.Text = "Choose culture:"
            ' 
            ' radComboCultures
            ' 
            Me.radComboCultures.AllowShowFocusCues = False
            Me.radComboCultures.Anchor = AnchorStyles.Top
            Me.radComboCultures.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.radComboCultures.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
            Me.radComboCultures.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radComboCultures.Location = New Point(10, 76)
            Me.radComboCultures.MaxDropDownItems = 6
            Me.radComboCultures.Name = "radComboCultures"
            ' 
            ' 
            ' 
            Me.radComboCultures.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboCultures.Size = New Size(180, 20)
            Me.radComboCultures.TabIndex = 36
            ' 
            ' radLabel9
            ' 
            Me.radLabel9.Location = New Point(470, 5)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New Size(63, 18)
            Me.radLabel9.TabIndex = 31
            Me.radLabel9.Text = "TimePicker:"
            ' 
            ' radLabel10
            ' 
            Me.radLabel10.Location = New Point(5, 6)
            Me.radLabel10.Name = "radLabel10"
            Me.radLabel10.Size = New Size(98, 18)
            Me.radLabel10.TabIndex = 31
            Me.radLabel10.Text = "MaskedEditedBox:"
            ' 
            ' radMaskedEditBox1
            ' 
            Me.radMaskedEditBox1.Location = New Point(5, 26)
            Me.radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.FreeFormDateTime
            Me.radMaskedEditBox1.Name = "radMaskedEditBox1"
            Me.radMaskedEditBox1.Size = New Size(141, 20)
            Me.radMaskedEditBox1.TabIndex = 38
            Me.radMaskedEditBox1.TabStop = False
            ' 
            ' radDateTimePicker1
            ' 
            Me.radDateTimePicker1.Location = New Point(200, 26)
            Me.radDateTimePicker1.Name = "radDateTimePicker1"
            Me.radDateTimePicker1.Size = New Size(220, 20)
            Me.radDateTimePicker1.TabIndex = 39
            Me.radDateTimePicker1.TabStop = False
            Me.radDateTimePicker1.Text = "Monday, May 26, 2014"
            Me.radDateTimePicker1.Value = New Date(2014, 5, 26, 10, 14, 52, 620)
            ' 
            ' radTimePicker1
            ' 
            Me.radTimePicker1.Location = New Point(470, 26)
            Me.radTimePicker1.Name = "radTimePicker1"
            Me.radTimePicker1.Size = New Size(100, 20)
            Me.radTimePicker1.TabIndex = 40
            Me.radTimePicker1.TabStop = False
            Me.radTimePicker1.Text = "radTimePicker1"
            Me.radTimePicker1.Value = New Date(2014, 5, 26, 10, 15, 3, 0)
            ' 
            ' radDateTimePicker2
            ' 
            Me.radDateTimePicker2.Anchor = AnchorStyles.Top
            Me.radDateTimePicker2.Location = New Point(10, 135)
            Me.radDateTimePicker2.Name = "radDateTimePicker2"
            Me.radDateTimePicker2.Size = New Size(180, 20)
            Me.radDateTimePicker2.TabIndex = 38
            Me.radDateTimePicker2.TabStop = False
            Me.radDateTimePicker2.Text = "Monday, May 26, 2014"
            Me.radDateTimePicker2.Value = New Date(2014, 5, 26, 10, 17, 53, 369)
            ' 
            ' radDateTimePicker3
            ' 
            Me.radDateTimePicker3.Anchor = AnchorStyles.Top
            Me.radDateTimePicker3.Location = New Point(10, 197)
            Me.radDateTimePicker3.Name = "radDateTimePicker3"
            Me.radDateTimePicker3.Size = New Size(180, 20)
            Me.radDateTimePicker3.TabIndex = 39
            Me.radDateTimePicker3.TabStop = False
            Me.radDateTimePicker3.Text = "Monday, May 26, 2014"
            Me.radDateTimePicker3.Value = New Date(2014, 5, 26, 10, 18, 5, 30)
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = AnchorStyles.Top
            Me.radLabel1.Location = New Point(10, 111)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(54, 18)
            Me.radLabel1.TabIndex = 40
            Me.radLabel1.Text = "Min Date:"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Anchor = AnchorStyles.Top
            Me.radLabel2.Location = New Point(10, 173)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New Size(55, 18)
            Me.radLabel2.TabIndex = 41
            Me.radLabel2.Text = "Max Date:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New Size(1176, 514)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblCulture, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radComboCultures, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region


        Private radLabel8 As Telerik.WinControls.UI.RadLabel
        Private radLblCulture As Telerik.WinControls.UI.RadLabel
        Private radComboCultures As Telerik.WinControls.UI.RadDropDownList
        Private radMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
        Private radLabel10 As Telerik.WinControls.UI.RadLabel
        Private radLabel9 As Telerik.WinControls.UI.RadLabel
        Private radTimePicker1 As Telerik.WinControls.UI.RadTimePicker
        Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker3 As Telerik.WinControls.UI.RadDateTimePicker
        Private radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker

    End Class
End Namespace