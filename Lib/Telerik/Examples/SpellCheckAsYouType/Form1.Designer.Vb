Namespace SpellCheckAsYouType
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

        '#region Windows Form Designer generated code

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.telerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radSpellChecker1 = New Telerik.WinControls.UI.RadSpellChecker()
            Me.radSpellChecker2 = New Telerik.WinControls.UI.RadSpellChecker()
            Me.radSpellChecker3 = New Telerik.WinControls.UI.RadSpellChecker()
			(CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize)).BeginInit()
            Me.radGroupBox1.SuspendLayout()
			(CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize)).BeginInit()
			(CType((Me.radGroupBox2), System.ComponentModel.ISupportInitialize)).BeginInit()
            Me.radGroupBox2.SuspendLayout()
			(CType((Me.radCheckBox2), System.ComponentModel.ISupportInitialize)).BeginInit()
			(CType((Me.radTextBox1), System.ComponentModel.ISupportInitialize)).BeginInit()
			(CType((Me.radGroupBox3), System.ComponentModel.ISupportInitialize)).BeginInit()
            Me.radGroupBox3.SuspendLayout()
			(CType((Me.radCheckBox3), System.ComponentModel.ISupportInitialize)).BeginInit()
			(CType((Me.radTextBoxControl1), System.ComponentModel.ISupportInitialize)).BeginInit()
			(CType((Me), System.ComponentModel.ISupportInitialize)).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textBox1
            ' 
            Me.textBox1.AcceptsReturn = True
            Me.textBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.textBox1.Location = New System.Drawing.Point(9, 32)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(638, 146)
            Me.textBox1.TabIndex = 1
            Me.textBox1.Text = "The quick brown fox jamped voer the lazee dog"
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox1.Controls.Add(Me.radCheckBox1)
            Me.radGroupBox1.Controls.Add(Me.textBox1)
            Me.radGroupBox1.HeaderText = "Microsoft TextBox"
            Me.radGroupBox1.Location = New System.Drawing.Point(3, 12)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(660, 209)
            Me.radGroupBox1.TabIndex = 2
            Me.radGroupBox1.Text = "Microsoft TextBox"
            Me.radGroupBox1.ThemeName = "TelerikMetro"
            ' 
            ' radCheckBox1
            ' 
            Me.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox1.Location = New System.Drawing.Point(10, 188)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(196, 19)
            Me.radCheckBox1.TabIndex = 0
            Me.radCheckBox1.Text = "Enable Spell Check As You Type"
            Me.radCheckBox1.ThemeName = "TelerikMetro"
            Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox1.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf (Me.radToggleButton1_ToggleStateChanged))
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox2.Controls.Add(Me.radCheckBox2)
            Me.radGroupBox2.Controls.Add(Me.radTextBox1)
            Me.radGroupBox2.HeaderText = "RadTextBox"
            Me.radGroupBox2.Location = New System.Drawing.Point(3, 243)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(660, 209)
            Me.radGroupBox2.TabIndex = 3
            Me.radGroupBox2.Text = "RadTextBox"
            Me.radGroupBox2.ThemeName = "TelerikMetro"
            ' 
            ' radCheckBox2
            ' 
            Me.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox2.Location = New System.Drawing.Point(10, 185)
            Me.radCheckBox2.Name = "radCheckBox2"
            Me.radCheckBox2.Size = New System.Drawing.Size(196, 19)
            Me.radCheckBox2.TabIndex = 1
            Me.radCheckBox2.Text = "Enable Spell Check As You Type"
            Me.radCheckBox2.ThemeName = "TelerikMetro"
            Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox2.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf (Me.radToggleButton2_ToggleStateChanged))
            ' 
            ' radTextBox1
            ' 
            Me.radTextBox1.AcceptsReturn = True
            Me.radTextBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBox1.AutoSize = False
            Me.radTextBox1.Location = New System.Drawing.Point(9, 33)
            Me.radTextBox1.Multiline = True
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(638, 146)
            Me.radTextBox1.TabIndex = 0
            Me.radTextBox1.Text = "The quick brown fox jamped voer the lazee dog"
            Me.radTextBox1.ThemeName = "TelerikMetro"
            ' 
            ' radGroupBox3
            ' 
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox3.Controls.Add(Me.radCheckBox3)
            Me.radGroupBox3.Controls.Add(Me.radTextBoxControl1)
            Me.radGroupBox3.HeaderText = "RadTextBoxControl"
            Me.radGroupBox3.Location = New System.Drawing.Point(3, 465)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Size = New System.Drawing.Size(660, 209)
            Me.radGroupBox3.TabIndex = 4
            Me.radGroupBox3.Text = "RadTextBoxControl"
            Me.radGroupBox3.ThemeName = "TelerikMetro"
            ' 
            ' radCheckBox3
            ' 
            Me.radCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBox3.Location = New System.Drawing.Point(10, 174)
            Me.radCheckBox3.Name = "radCheckBox3"
            Me.radCheckBox3.Size = New System.Drawing.Size(196, 19)
            Me.radCheckBox3.TabIndex = 1
            Me.radCheckBox3.Text = "Enable Spell Check As You Type"
            Me.radCheckBox3.ThemeName = "TelerikMetro"
            Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBox3.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf (Me.radCheckBox3_ToggleStateChanged))
            ' 
            ' radTextBoxControl1
            ' 
            Me.radTextBoxControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radTextBoxControl1.Location = New System.Drawing.Point(10, 22)
            Me.radTextBoxControl1.Multiline = True
            Me.radTextBoxControl1.Name = "radTextBoxControl1"
            Me.radTextBoxControl1.Size = New System.Drawing.Size(637, 146)
            Me.radTextBoxControl1.TabIndex = 0
            Me.radTextBoxControl1.Text = "The quick brown fox jamped voer the lazee dog"
            Me.radTextBoxControl1.ThemeName = "TelerikMetro"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(675, 684)
            Me.Controls.Add(Me.radGroupBox3)
            Me.Controls.Add(Me.radGroupBox2)
            Me.Controls.Add(Me.radGroupBox1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "RadSpellChecker"
            Me.ThemeName = "TelerikMetro"
            AddHandler Me.Shown, New System.EventHandler(AddressOf (Me.Form1_Shown))
			(CType((Me.radGroupBox1), System.ComponentModel.ISupportInitialize)).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
			(CType((Me.radCheckBox1), System.ComponentModel.ISupportInitialize)).EndInit()
			(CType((Me.radGroupBox2), System.ComponentModel.ISupportInitialize)).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
			(CType((Me.radCheckBox2), System.ComponentModel.ISupportInitialize)).EndInit()
			(CType((Me.radTextBox1), System.ComponentModel.ISupportInitialize)).EndInit()
			(CType((Me.radGroupBox3), System.ComponentModel.ISupportInitialize)).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.radGroupBox3.PerformLayout()
			(CType((Me.radCheckBox3), System.ComponentModel.ISupportInitialize)).EndInit()
			(CType((Me.radTextBoxControl1), System.ComponentModel.ISupportInitialize)).EndInit()
			(CType((Me), System.ComponentModel.ISupportInitialize)).EndInit()
            Me.ResumeLayout(False)

        End Sub

        '#endregion

        Private textBox1 As System.Windows.Forms.TextBox
        Private radSpellChecker1 As Telerik.WinControls.UI.RadSpellChecker
        Private telerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private radSpellChecker2 As Telerik.WinControls.UI.RadSpellChecker
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
        Private radTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
        Private radSpellChecker3 As Telerik.WinControls.UI.RadSpellChecker
    End Class
End Namespace