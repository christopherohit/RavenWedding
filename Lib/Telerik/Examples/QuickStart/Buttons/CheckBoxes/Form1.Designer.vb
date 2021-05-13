Imports System.ComponentModel
Namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
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
            Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
            Me.radTextBoxEvents = New Telerik.WinControls.UI.RadTextBox()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupEvents.SuspendLayout()
            CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox1)
            Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox3)
            Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox2)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(404, 285)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(514, 318)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupEvents)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(250, 534)
            Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
            '
            'radCheckBox3
            '
            Me.radCheckBox3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radCheckBox3.Location = New System.Drawing.Point(197, 172)
            Me.radCheckBox3.Name = "radCheckBox3"
            Me.radCheckBox3.Size = New System.Drawing.Size(109, 25)
            Me.radCheckBox3.TabIndex = 2
            Me.radCheckBox3.Text = "Arial, 14pt"
            '
            'radCheckBox2
            '
            Me.radCheckBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radCheckBox2.Location = New System.Drawing.Point(197, 147)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(96, 22)
            Me.radCheckBox2.TabIndex = 1
            Me.radCheckBox2.Text = "Arial, 12pt"
            '
            'radCheckBox1
            '
            Me.radCheckBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.radCheckBox1.Location = New System.Drawing.Point(197, 122)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(83, 19)
            Me.radCheckBox1.TabIndex = 0
            Me.radCheckBox1.Text = "Arial, 10pt"
            '
            'radGroupEvents
            '
            Me.radGroupEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupEvents.Controls.Add(Me.radTextBoxEvents)
            Me.radGroupEvents.FooterText = ""
            Me.radGroupEvents.HeaderText = " Events "
            Me.radGroupEvents.Location = New System.Drawing.Point(15, 6)
            Me.radGroupEvents.Name = "radGroupEvents"
            Me.radGroupEvents.Size = New System.Drawing.Size(162, 188)
            Me.radGroupEvents.TabIndex = 0
            Me.radGroupEvents.Text = " Events "
            '
            'radTextBoxEvents
            '
            Me.radTextBoxEvents.AutoSize = False
            Me.radTextBoxEvents.Location = New System.Drawing.Point(13, 23)
            Me.radTextBoxEvents.Multiline = True
            Me.radTextBoxEvents.Name = "radTextBoxEvents"
            Me.radTextBoxEvents.Size = New System.Drawing.Size(138, 154)
            Me.radTextBoxEvents.TabIndex = 0
            Me.radTextBoxEvents.TabStop = False
            '
            'Form1
            '
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1425, 1170)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupEvents.ResumeLayout(False)
            CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxEvents As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace