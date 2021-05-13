Namespace Telerik.Examples.WinControls.Buttons.RadioButtons
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
            Me.radTextBoxEvents = New Telerik.WinControls.UI.RadTextBox()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioDonut = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioSquare = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioOffice = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioRound = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioRegular = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioCustShape = New Telerik.WinControls.UI.RadRadioButton()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radRadioDonut, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioSquare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioOffice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioRegular, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioCustShape, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(404, 285)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(800, 600)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(250, 534)
            Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
            '
            'radTextBoxEvents
            '
            Me.radTextBoxEvents.AutoSize = False
            Me.radTextBoxEvents.Location = New System.Drawing.Point(12, 21)
            Me.radTextBoxEvents.Multiline = True
            Me.radTextBoxEvents.Name = "radTextBoxEvents"
            Me.radTextBoxEvents.Size = New System.Drawing.Size(139, 170)
            Me.radTextBoxEvents.TabIndex = 0
            Me.radTextBoxEvents.TabStop = False
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radTextBoxEvents)
            Me.radGroupBox1.FooterText = ""
            Me.radGroupBox1.HeaderText = " Events "
            Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(162, 203)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = " Events "
            '
            'radRadioDonut
            '
            Me.radRadioDonut.Location = New System.Drawing.Point(3, 235)
            Me.radRadioDonut.Name = "radRadioDonut"
            Me.radRadioDonut.Size = New System.Drawing.Size(51, 18)
            Me.radRadioDonut.TabIndex = 0
            Me.radRadioDonut.Text = "Donut"
            '
            'radRadioSquare
            '
            Me.radRadioSquare.Location = New System.Drawing.Point(3, 177)
            Me.radRadioSquare.Name = "radRadioSquare"
            Me.radRadioSquare.Size = New System.Drawing.Size(55, 18)
            Me.radRadioSquare.TabIndex = 0
            Me.radRadioSquare.Text = "Square"
            '
            'radRadioOffice
            '
            Me.radRadioOffice.Location = New System.Drawing.Point(3, 293)
            Me.radRadioOffice.Name = "radRadioOffice"
            Me.radRadioOffice.Size = New System.Drawing.Size(71, 18)
            Me.radRadioOffice.TabIndex = 0
            Me.radRadioOffice.Text = "Office Tab"
            '
            'radRadioRound
            '
            Me.radRadioRound.Location = New System.Drawing.Point(3, 119)
            Me.radRadioRound.Name = "radRadioRound"
            Me.radRadioRound.Size = New System.Drawing.Size(105, 18)
            Me.radRadioRound.TabIndex = 0
            Me.radRadioRound.Text = "Round Rectangle"
            '
            'radRadioRegular
            '
            Me.radRadioRegular.Location = New System.Drawing.Point(3, 3)
            Me.radRadioRegular.Name = "radRadioRegular"
            Me.radRadioRegular.Size = New System.Drawing.Size(58, 18)
            Me.radRadioRegular.TabIndex = 0
            Me.radRadioRegular.Text = "Regular"
            '
            'radRadioCustShape
            '
            Me.radRadioCustShape.Location = New System.Drawing.Point(3, 61)
            Me.radRadioCustShape.Name = "radRadioCustShape"
            Me.radRadioCustShape.Size = New System.Drawing.Size(93, 18)
            Me.radRadioCustShape.TabIndex = 0
            Me.radRadioCustShape.Text = "Custom Shape"
            '
            'doubleBufferedTableLayoutPanel1
            '
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioRegular, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioOffice, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioDonut, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioCustShape, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioSquare, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioRound, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(291, 104)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 6
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(200, 352)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1425, 1170)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            CType(Me.radRadioDonut, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioSquare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioOffice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioRegular, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioCustShape, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxEvents As Telerik.WinControls.UI.RadTextBox
		Private radRadioDonut As Telerik.WinControls.UI.RadRadioButton
		Private radRadioSquare As Telerik.WinControls.UI.RadRadioButton
		Private radRadioOffice As Telerik.WinControls.UI.RadRadioButton
		Private radRadioRound As Telerik.WinControls.UI.RadRadioButton
		Private radRadioCustShape As Telerik.WinControls.UI.RadRadioButton
		Private radRadioRegular As Telerik.WinControls.UI.RadRadioButton
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
