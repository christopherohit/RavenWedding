Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar2 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar3 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar4 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar5 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radPanelCars = New Telerik.WinControls.UI.RadPanel()
			Me.radLabelSuperstars = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelDTM = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelWTCC = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelF1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelWRC = New Telerik.WinControls.UI.RadLabel()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radPanelCars, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelSuperstars, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelDTM, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelWTCC, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelF1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelWRC, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(855, 3)
			Me.settingsPanel.Size = New Size(1005, 790)
			' 
			' radPropertyGrid1
			' 
			Me.radPropertyGrid1.Location = New Point(382, 3)
			Me.radPropertyGrid1.Name = "radPropertyGrid1"
			Me.radPropertyGrid1.Size = New Size(376, 462)
			Me.radPropertyGrid1.TabIndex = 0
			Me.radPropertyGrid1.Text = "radPropertyGrid1"
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.Location = New Point(5, 59)
			Me.radProgressBar1.Name = "radProgressBar1"
			Me.radProgressBar1.ShowProgressIndicators = True
			Me.radProgressBar1.Size = New Size(363, 23)
			Me.radProgressBar1.TabIndex = 2
			Me.radProgressBar1.Text = "0 %"
			' 
			' radProgressBar2
			' 
			Me.radProgressBar2.Location = New Point(5, 112)
			Me.radProgressBar2.Name = "radProgressBar2"
			Me.radProgressBar2.ShowProgressIndicators = True
			Me.radProgressBar2.Size = New Size(363, 23)
			Me.radProgressBar2.TabIndex = 2
			Me.radProgressBar2.Text = "0 %"
			' 
			' radProgressBar3
			' 
			Me.radProgressBar3.Location = New Point(5, 165)
			Me.radProgressBar3.Name = "radProgressBar3"
			Me.radProgressBar3.ShowProgressIndicators = True
			Me.radProgressBar3.Size = New Size(363, 23)
			Me.radProgressBar3.TabIndex = 2
			Me.radProgressBar3.Text = "0 %"
			' 
			' radProgressBar4
			' 
			Me.radProgressBar4.Location = New Point(5, 218)
			Me.radProgressBar4.Name = "radProgressBar4"
			Me.radProgressBar4.ShowProgressIndicators = True
			Me.radProgressBar4.Size = New Size(363, 23)
			Me.radProgressBar4.TabIndex = 2
			Me.radProgressBar4.Text = "0 %"
			' 
			' radProgressBar5
			' 
			Me.radProgressBar5.Location = New Point(5, 271)
			Me.radProgressBar5.Name = "radProgressBar5"
			Me.radProgressBar5.ShowProgressIndicators = True
			Me.radProgressBar5.Size = New Size(363, 23)
			Me.radProgressBar5.TabIndex = 2
			Me.radProgressBar5.Text = "0 %"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.radPanelCars)
			Me.radGroupBox1.Controls.Add(Me.radLabelSuperstars)
			Me.radGroupBox1.Controls.Add(Me.radLabelDTM)
			Me.radGroupBox1.Controls.Add(Me.radLabelWTCC)
			Me.radGroupBox1.Controls.Add(Me.radLabelF1)
			Me.radGroupBox1.Controls.Add(Me.radLabelWRC)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar1)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar5)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar2)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar4)
			Me.radGroupBox1.Controls.Add(Me.radProgressBar3)
			Me.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
			Me.radGroupBox1.HeaderText = "Championship requirements met"
			Me.radGroupBox1.Location = New Point(3, 3)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(373, 462)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = "Championship requirements met"
			' 
			' radPanelCars
			' 
			Me.radPanelCars.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radPanelCars.BackgroundImage = My.Resources.propertyStoreCars
			Me.radPanelCars.Location = New Point(6, 300)
			Me.radPanelCars.Name = "radPanelCars"
			Me.radPanelCars.Size = New Size(362, 157)
			Me.radPanelCars.TabIndex = 9
			' 
			' radLabelSuperstars
			' 
			Me.radLabelSuperstars.Location = New Point(6, 247)
			Me.radLabelSuperstars.Name = "radLabelSuperstars"
			Me.radLabelSuperstars.Size = New Size(58, 18)
			Me.radLabelSuperstars.TabIndex = 8
			Me.radLabelSuperstars.Text = "Superstars"
			' 
			' radLabelDTM
			' 
			Me.radLabelDTM.Location = New Point(6, 194)
			Me.radLabelDTM.Name = "radLabelDTM"
			Me.radLabelDTM.Size = New Size(166, 18)
			Me.radLabelDTM.TabIndex = 7
			Me.radLabelDTM.Text = "Deutsche Tourenwagen Masters"
			' 
			' radLabelWTCC
			' 
			Me.radLabelWTCC.Location = New Point(6, 141)
			Me.radLabelWTCC.Name = "radLabelWTCC"
			Me.radLabelWTCC.Size = New Size(174, 18)
			Me.radLabelWTCC.TabIndex = 6
			Me.radLabelWTCC.Text = "World Touring Car Championship"
			' 
			' radLabelF1
			' 
			Me.radLabelF1.Location = New Point(5, 88)
			Me.radLabelF1.Name = "radLabelF1"
			Me.radLabelF1.Size = New Size(56, 18)
			Me.radLabelF1.TabIndex = 5
			Me.radLabelF1.Text = "Formula 1"
			' 
			' radLabelWRC
			' 
			Me.radLabelWRC.Location = New Point(5, 35)
			Me.radLabelWRC.Name = "radLabelWRC"
			Me.radLabelWRC.Size = New Size(138, 18)
			Me.radLabelWRC.TabIndex = 4
			Me.radLabelWRC.Text = "World Rally Championship"
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radGroupBox1)
			Me.radPanel1.Controls.Add(Me.radPropertyGrid1)
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(762, 470)
			Me.radPanel1.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1502, 737)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radPanelCars, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelSuperstars, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelDTM, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelWTCC, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelF1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelWRC, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
		Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar2 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar3 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar4 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar5 As Telerik.WinControls.UI.RadProgressBar
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radPanelCars As Telerik.WinControls.UI.RadPanel
		Private radLabelSuperstars As Telerik.WinControls.UI.RadLabel
		Private radLabelDTM As Telerik.WinControls.UI.RadLabel
		Private radLabelWTCC As Telerik.WinControls.UI.RadLabel
		Private radLabelF1 As Telerik.WinControls.UI.RadLabel
		Private radLabelWRC As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
