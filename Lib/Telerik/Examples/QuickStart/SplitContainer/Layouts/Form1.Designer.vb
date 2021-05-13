Namespace Telerik.Examples.WinControls.SplitContainer.Layouts
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.absVerticalButton = New Telerik.WinControls.UI.RadButton()
			Me.absHorizontalButton = New Telerik.WinControls.UI.RadButton()
			Me.grixX25FillButton = New Telerik.WinControls.UI.RadButton()
			Me.rowX9 = New Telerik.WinControls.UI.RadButton()
			Me.colX9Button = New Telerik.WinControls.UI.RadButton()
			Me.gridX25Button = New Telerik.WinControls.UI.RadButton()
			Me.gridX9Button = New Telerik.WinControls.UI.RadButton()
			Me.rootContainer = New Telerik.WinControls.UI.RadSplitContainer()
			Me.minMaxButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.absVerticalButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.absHorizontalButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grixX25FillButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowX9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colX9Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridX25Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridX9Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rootContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.minMaxButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.minMaxButton)
			Me.radGroupBox1.Controls.Add(Me.absVerticalButton)
			Me.radGroupBox1.Controls.Add(Me.absHorizontalButton)
			Me.radGroupBox1.Controls.Add(Me.grixX25FillButton)
			Me.radGroupBox1.Controls.Add(Me.rowX9)
			Me.radGroupBox1.Controls.Add(Me.colX9Button)
			Me.radGroupBox1.Controls.Add(Me.gridX25Button)
			Me.radGroupBox1.Controls.Add(Me.gridX9Button)
			Me.radGroupBox1.Dock = DockStyle.Left
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Layout Scenarios"
			Me.radGroupBox1.Location = New Point(0, 0)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(150, 350)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Layout Scenarios"
			' 
			' absVerticalButton
			' 
			Me.absVerticalButton.AllowShowFocusCues = True
			Me.absVerticalButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.absVerticalButton.Location = New Point(3, 198)
			Me.absVerticalButton.Name = "absVerticalButton"
			Me.absVerticalButton.Size = New Size(144, 23)
			Me.absVerticalButton.TabIndex = 6
			Me.absVerticalButton.Text = "Absolute Size (Vertical)"

			' 
			' absHorizontalButton
			' 
			Me.absHorizontalButton.AllowShowFocusCues = True
			Me.absHorizontalButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.absHorizontalButton.Location = New Point(3, 169)
			Me.absHorizontalButton.Name = "absHorizontalButton"
			Me.absHorizontalButton.Size = New Size(144, 23)
			Me.absHorizontalButton.TabIndex = 5
			Me.absHorizontalButton.Text = "Absolute Size (Horizontal)"

			' 
			' grixX25FillButton
			' 
			Me.grixX25FillButton.AllowShowFocusCues = True
			Me.grixX25FillButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.grixX25FillButton.Location = New Point(3, 140)
			Me.grixX25FillButton.Name = "grixX25FillButton"
			Me.grixX25FillButton.Size = New Size(144, 23)
			Me.grixX25FillButton.TabIndex = 4
			Me.grixX25FillButton.Text = "Grid 5 * 5 Center Panel Fill"

			' 
			' rowX9
			' 
			Me.rowX9.AllowShowFocusCues = True
			Me.rowX9.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.rowX9.Location = New Point(3, 53)
			Me.rowX9.Name = "rowX9"
			Me.rowX9.Size = New Size(144, 23)
			Me.rowX9.TabIndex = 3
			Me.rowX9.Text = "9 Vertical"

			' 
			' colX9Button
			' 
			Me.colX9Button.AllowShowFocusCues = True
			Me.colX9Button.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.colX9Button.Location = New Point(3, 24)
			Me.colX9Button.Name = "colX9Button"
			Me.colX9Button.Size = New Size(144, 23)
			Me.colX9Button.TabIndex = 2
			Me.colX9Button.Text = "9 Horizontal"

			' 
			' gridX25Button
			' 
			Me.gridX25Button.AllowShowFocusCues = True
			Me.gridX25Button.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.gridX25Button.Location = New Point(3, 111)
			Me.gridX25Button.Name = "gridX25Button"
			Me.gridX25Button.Size = New Size(144, 23)
			Me.gridX25Button.TabIndex = 1
			Me.gridX25Button.Text = "Grid 5 * 5"

			' 
			' gridX9Button
			' 
			Me.gridX9Button.AllowShowFocusCues = True
			Me.gridX9Button.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.gridX9Button.Location = New Point(3, 82)
			Me.gridX9Button.Name = "gridX9Button"
			Me.gridX9Button.Size = New Size(144, 23)
			Me.gridX9Button.TabIndex = 0
			Me.gridX9Button.Text = "Grid 3 * 3"

			' 
			' rootContainer
			' 
			Me.rootContainer.BackColor = Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(254)))))
			Me.rootContainer.Dock = DockStyle.Fill
			Me.rootContainer.Location = New Point(150, 0)
			Me.rootContainer.Name = "rootContainer"
			' 
			' 
			' 
			Me.rootContainer.RootElement.MinSize = New Size(25, 25)
			Me.rootContainer.Size = New Size(583, 350)
			Me.rootContainer.TabIndex = 1
			Me.rootContainer.TabStop = False
			Me.rootContainer.Text = "radSplitContainer1"
			' 
			' minMaxButton
			' 
			Me.minMaxButton.AllowShowFocusCues = True
			Me.minMaxButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.minMaxButton.Location = New Point(3, 227)
			Me.minMaxButton.Name = "minMaxButton"
			Me.minMaxButton.Size = New Size(144, 23)
			Me.minMaxButton.TabIndex = 7
			Me.minMaxButton.Text = "Minimum/Maximum Size"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(733, 350)
			Me.Controls.Add(Me.rootContainer)
			Me.Controls.Add(Me.radGroupBox1)
			Me.Name = "Form1"
			Me.Text = "RadSplitContainer Layouts"
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.absVerticalButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.absHorizontalButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grixX25FillButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowX9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colX9Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridX25Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridX9Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rootContainer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.minMaxButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private rowX9 As Telerik.WinControls.UI.RadButton
		Private colX9Button As Telerik.WinControls.UI.RadButton
		Private gridX25Button As Telerik.WinControls.UI.RadButton
		Private gridX9Button As Telerik.WinControls.UI.RadButton
		Private rootContainer As Telerik.WinControls.UI.RadSplitContainer
		Private grixX25FillButton As Telerik.WinControls.UI.RadButton
		Private absVerticalButton As Telerik.WinControls.UI.RadButton
		Private absHorizontalButton As Telerik.WinControls.UI.RadButton
		Private minMaxButton As Telerik.WinControls.UI.RadButton
	End Class
End Namespace