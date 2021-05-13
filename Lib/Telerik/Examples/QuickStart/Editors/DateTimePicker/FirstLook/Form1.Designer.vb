Namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FirstLook
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
            Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLblLongDateFormat = New Telerik.WinControls.UI.RadLabel()
            Me.radLblShortDateFormat = New Telerik.WinControls.UI.RadLabel()
            Me.radDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLblTimeFormat = New Telerik.WinControls.UI.RadLabel()
            Me.radDateTimePicker3 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radBtnClearAll = New Telerik.WinControls.UI.RadButton()
            Me.radGroupExampleSettings = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadio24Hours = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadio12Hours = New Telerik.WinControls.UI.RadRadioButton()
            Me.radDateTimePicker4 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radDateTimePicker5 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radDateTimePicker6 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radDateTimePicker7 = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblLongDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblShortDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLblTimeFormat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBtnClearAll, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupExampleSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupExampleSettings.SuspendLayout()
            CType(Me.radRadio24Hours, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadio12Hours, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDateTimePicker7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.radPanelDemoHolder.Margin = New Padding(5, 5, 5, 5)
            ' 
            ' 
            ' 
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New Size(1203, 622)
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(1279, 1)
            Me.settingsPanel.Margin = New Padding(5, 5, 5, 5)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupExampleSettings)
            Me.settingsPanel.PanelContainer.Size = New Size(250, 919)
            Me.settingsPanel.Size = New Size(250, 919)
            ' 
            ' radDateTimePicker1
            ' 
            Me.radDateTimePicker1.Anchor = AnchorStyles.None
            Me.radDateTimePicker1.Checked = True
            Me.radDateTimePicker1.Location = New Point(381, 29)
            Me.radDateTimePicker1.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker1.Name = "radDateTimePicker1"
            Me.radDateTimePicker1.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker1.Size = New Size(239, 25)
            Me.radDateTimePicker1.TabIndex = 0
            Me.radDateTimePicker1.TabStop = False
            Me.radDateTimePicker1.Text = "Thursday, 23 August, 2007"
            Me.radDateTimePicker1.Value = New Date(2007, 8, 23, 15, 29, 8, 309)
            ' 
            ' radLblLongDateFormat
            ' 
            Me.radLblLongDateFormat.Anchor = AnchorStyles.None
            Me.radLblLongDateFormat.Location = New Point(107, 30)
            Me.radLblLongDateFormat.Margin = New Padding(4, 4, 4, 4)
            Me.radLblLongDateFormat.Name = "radLblLongDateFormat"
            Me.radLblLongDateFormat.Size = New Size(119, 22)
            Me.radLblLongDateFormat.TabIndex = 1
            Me.radLblLongDateFormat.Text = "Long date format:"
            ' 
            ' radLblShortDateFormat
            ' 
            Me.radLblShortDateFormat.Anchor = AnchorStyles.None
            Me.radLblShortDateFormat.Location = New Point(106, 113)
            Me.radLblShortDateFormat.Margin = New Padding(4, 4, 4, 4)
            Me.radLblShortDateFormat.Name = "radLblShortDateFormat"
            Me.radLblShortDateFormat.Size = New Size(121, 22)
            Me.radLblShortDateFormat.TabIndex = 3
            Me.radLblShortDateFormat.Text = "Short date format:"
            ' 
            ' radDateTimePicker2
            ' 
            Me.radDateTimePicker2.Anchor = AnchorStyles.None
            Me.radDateTimePicker2.Checked = True
            Me.radDateTimePicker2.Format = DateTimePickerFormat.Short
            Me.radDateTimePicker2.Location = New Point(381, 112)
            Me.radDateTimePicker2.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker2.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker2.Name = "radDateTimePicker2"
            Me.radDateTimePicker2.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker2.Size = New Size(239, 25)
            Me.radDateTimePicker2.TabIndex = 2
            Me.radDateTimePicker2.TabStop = False
            Me.radDateTimePicker2.Text = "1/1/1980"
            Me.radDateTimePicker2.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
            ' 
            ' radLblTimeFormat
            ' 
            Me.radLblTimeFormat.Anchor = AnchorStyles.None
            Me.radLblTimeFormat.Location = New Point(124, 196)
            Me.radLblTimeFormat.Margin = New Padding(4, 4, 4, 4)
            Me.radLblTimeFormat.Name = "radLblTimeFormat"
            Me.radLblTimeFormat.Size = New Size(86, 22)
            Me.radLblTimeFormat.TabIndex = 5
            Me.radLblTimeFormat.Text = "Time format:"
            ' 
            ' radDateTimePicker3
            ' 
            Me.radDateTimePicker3.Anchor = AnchorStyles.None
            Me.radDateTimePicker3.Checked = True
            Me.radDateTimePicker3.Format = DateTimePickerFormat.Time
            Me.radDateTimePicker3.Location = New Point(381, 195)
            Me.radDateTimePicker3.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker3.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker3.Name = "radDateTimePicker3"
            Me.radDateTimePicker3.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker3.ShowUpDown = True
            Me.radDateTimePicker3.Size = New Size(239, 25)
            Me.radDateTimePicker3.TabIndex = 4
            Me.radDateTimePicker3.TabStop = False
            Me.radDateTimePicker3.Text = "12:00:00 AM"
            Me.radDateTimePicker3.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
            ' 
            ' radBtnClearAll
            ' 
            Me.radBtnClearAll.Anchor = AnchorStyles.Top
            Me.radBtnClearAll.Location = New Point(6, 105)
            Me.radBtnClearAll.Margin = New Padding(4, 4, 4, 4)
            Me.radBtnClearAll.Name = "radBtnClearAll"
            Me.radBtnClearAll.Size = New Size(212, 29)
            Me.radBtnClearAll.TabIndex = 6
            Me.radBtnClearAll.Text = "Clear All"
            ' 
            ' radGroupExampleSettings
            ' 
            Me.radGroupExampleSettings.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupExampleSettings.Anchor = AnchorStyles.Top
            Me.radGroupExampleSettings.Controls.Add(Me.radRadio24Hours)
            Me.radGroupExampleSettings.Controls.Add(Me.radRadio12Hours)
            Me.radGroupExampleSettings.Controls.Add(Me.radBtnClearAll)
            Me.radGroupExampleSettings.FooterText = ""
            Me.radGroupExampleSettings.HeaderMargin = New Padding(13, 0, 0, 0)
            Me.radGroupExampleSettings.HeaderText = " Settings "
            Me.radGroupExampleSettings.Location = New Point(6, 8)
            Me.radGroupExampleSettings.Margin = New Padding(4, 4, 4, 4)
            Me.radGroupExampleSettings.Name = "radGroupExampleSettings"
            Me.radGroupExampleSettings.Padding = New Padding(12, 25, 12, 12)
            Me.radGroupExampleSettings.Size = New Size(225, 152)
            Me.radGroupExampleSettings.TabIndex = 7
            Me.radGroupExampleSettings.Text = " Settings "
            ' 
            ' radRadio24Hours
            ' 
            Me.radRadio24Hours.Anchor = AnchorStyles.Top
            Me.radRadio24Hours.Location = New Point(6, 66)
            Me.radRadio24Hours.Margin = New Padding(4, 4, 4, 4)
            Me.radRadio24Hours.Name = "radRadio24Hours"
            Me.radRadio24Hours.Size = New Size(81, 22)
            Me.radRadio24Hours.TabIndex = 7
            Me.radRadio24Hours.Text = "24 Hours"
            ' 
            ' radRadio12Hours
            ' 
            Me.radRadio12Hours.Anchor = AnchorStyles.Top
            Me.radRadio12Hours.Location = New Point(6, 39)
            Me.radRadio12Hours.Margin = New Padding(4, 4, 4, 4)
            Me.radRadio12Hours.Name = "radRadio12Hours"
            Me.radRadio12Hours.Size = New Size(81, 22)
            Me.radRadio12Hours.TabIndex = 7
            Me.radRadio12Hours.Text = "12 Hours"
            ' 
            ' radDateTimePicker4
            ' 
            Me.radDateTimePicker4.Anchor = AnchorStyles.None
            Me.radDateTimePicker4.Checked = True
            Me.radDateTimePicker4.Format = DateTimePickerFormat.Short
            Me.radDateTimePicker4.Location = New Point(381, 278)
            Me.radDateTimePicker4.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker4.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker4.Name = "radDateTimePicker4"
            Me.radDateTimePicker4.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker4.Size = New Size(239, 25)
            Me.radDateTimePicker4.TabIndex = 6
            Me.radDateTimePicker4.TabStop = False
            Me.radDateTimePicker4.Text = "1/1/1980"
            Me.radDateTimePicker4.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = AnchorStyles.None
            Me.radLabel1.Location = New Point(71, 279)
            Me.radLabel1.Margin = New Padding(4, 4, 4, 4)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(192, 22)
            Me.radLabel1.TabIndex = 7
            Me.radLabel1.Text = "Time format with Time Picker:"
            ' 
            ' radDateTimePicker5
            ' 
            Me.radDateTimePicker5.Anchor = AnchorStyles.None
            Me.radDateTimePicker5.Checked = True
            Me.radDateTimePicker5.Culture = New System.Globalization.CultureInfo("ar-SA")
            Me.radDateTimePicker5.Location = New Point(381, 361)
            Me.radDateTimePicker5.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker5.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker5.Name = "radDateTimePicker5"
            Me.radDateTimePicker5.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker5.Size = New Size(239, 25)
            Me.radDateTimePicker5.TabIndex = 0
            Me.radDateTimePicker5.TabStop = False
            Me.radDateTimePicker5.Text = "10/شعبان/1428"
            Me.radDateTimePicker5.Value = New Date(2007, 8, 23, 15, 29, 8, 309)
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Anchor = AnchorStyles.None
            Me.radLabel2.Location = New Point(110, 445)
            Me.radLabel2.Margin = New Padding(4, 4, 4, 4)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New Size(113, 22)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Hijri date format:"
            ' 
            ' radDateTimePicker6
            ' 
            Me.radDateTimePicker6.Anchor = AnchorStyles.None
            Me.radDateTimePicker6.Checked = True
            Me.radDateTimePicker6.Location = New Point(381, 527)
            Me.radDateTimePicker6.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker6.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker6.Name = "radDateTimePicker6"
            Me.radDateTimePicker6.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker6.Size = New Size(239, 25)
            Me.radDateTimePicker6.TabIndex = 0
            Me.radDateTimePicker6.TabStop = False
            Me.radDateTimePicker6.Text = "Thursday, 23 August, 2007"
            Me.radDateTimePicker6.Value = New Date(2007, 8, 23, 15, 29, 8, 309)
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Anchor = AnchorStyles.None
            Me.radLabel3.Location = New Point(90, 362)
            Me.radLabel3.Margin = New Padding(4, 4, 4, 4)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New Size(153, 22)
            Me.radLabel3.TabIndex = 1
            Me.radLabel3.Text = "UmAlQura date format:"
            ' 
            ' radDateTimePicker7
            ' 
            Me.radDateTimePicker7.Anchor = AnchorStyles.None
            Me.radDateTimePicker7.Checked = True
            Me.radDateTimePicker7.Culture = New System.Globalization.CultureInfo("ps-AF")
            Me.radDateTimePicker7.Location = New Point(381, 444)
            Me.radDateTimePicker7.Margin = New Padding(4, 4, 4, 4)
            Me.radDateTimePicker7.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker7.Name = "radDateTimePicker7"
            Me.radDateTimePicker7.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.radDateTimePicker7.Size = New Size(239, 25)
            Me.radDateTimePicker7.TabIndex = 0
            Me.radDateTimePicker7.TabStop = False
            Me.radDateTimePicker7.Text = "1 وږی 1386"
            Me.radDateTimePicker7.Value = New Date(2007, 8, 23, 15, 29, 8, 309)
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Anchor = AnchorStyles.None
            Me.radLabel4.Location = New Point(101, 529)
            Me.radLabel4.Margin = New Padding(4, 4, 4, 4)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New Size(132, 22)
            Me.radLabel4.TabIndex = 1
            Me.radLabel4.Text = "Persian date format:"
            ' 
            ' tableLayoutPanel1
            ' 
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLblLongDateFormat, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker6, 1, 6)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker5, 1, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker7, 1, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLblShortDateFormat, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 6)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker4, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLblTimeFormat, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker3, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker2, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDateTimePicker1, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Location = New Point(124, 22)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 7
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
            Me.doubleBufferedTableLayoutPanel1.Size = New Size(668, 582)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 8
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96, 96)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New Size(2527, 1464)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblLongDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblShortDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLblTimeFormat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBtnClearAll, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupExampleSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupExampleSettings.ResumeLayout(False)
            Me.radGroupExampleSettings.PerformLayout()
            CType(Me.radRadio24Hours, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadio12Hours, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDateTimePicker7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLblLongDateFormat As Telerik.WinControls.UI.RadLabel
        Private radLblShortDateFormat As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLblTimeFormat As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker3 As Telerik.WinControls.UI.RadDateTimePicker
        Private radBtnClearAll As Telerik.WinControls.UI.RadButton
        Private radGroupExampleSettings As Telerik.WinControls.UI.RadGroupBox
        Private radRadio24Hours As Telerik.WinControls.UI.RadRadioButton
        Private radRadio12Hours As Telerik.WinControls.UI.RadRadioButton
        Private radDateTimePicker4 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker5 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker6 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radDateTimePicker7 As Telerik.WinControls.UI.RadDateTimePicker
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace