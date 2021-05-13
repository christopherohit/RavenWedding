Namespace Telerik.Examples.WinControls.PageView.StripView.FirstLook
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
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox1 = New PictureBox()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox2 = New PictureBox()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox3 = New PictureBox()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox4 = New PictureBox()
			Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox5 = New PictureBox()
			Me.radPageViewPage8 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox8 = New PictureBox()
			Me.radPageViewPage6 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox6 = New PictureBox()
			Me.radPageViewPage7 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.pictureBox7 = New PictureBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.alignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.orientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.buttonsCombo = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage4.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage5.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage8.SuspendLayout()
			CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage6.SuspendLayout()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage7.SuspendLayout()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.buttonsCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.orientationCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.alignCombo)
			Me.settingsPanel.Location = New Point(1064, 1)
			Me.settingsPanel.Size = New Size(184, 541)

			Me.settingsPanel.Controls.SetChildIndex(Me.alignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.orientationCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.buttonsCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Controls.Add(Me.radPageViewPage4)
			Me.radPageView1.Controls.Add(Me.radPageViewPage5)
			Me.radPageView1.Controls.Add(Me.radPageViewPage8)
			Me.radPageView1.Controls.Add(Me.radPageViewPage6)
			Me.radPageView1.Controls.Add(Me.radPageViewPage7)
			Me.radPageView1.Location = New Point(3, 3)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(940, 540)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left
			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Horizontal
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage1.Controls.Add(Me.pictureBox1)
			Me.radPageViewPage1.Location = New Point(103, 9)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(827, 521)
			Me.radPageViewPage1.TabIndex = 0
			Me.radPageViewPage1.Text = "Application"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = My.Resources.Application
			Me.pictureBox1.Location = New Point(3, 3)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(648, 506)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage2.Controls.Add(Me.pictureBox2)
			Me.radPageViewPage2.Location = New Point(103, 9)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(827, 521)
			Me.radPageViewPage2.TabIndex = 1
			Me.radPageViewPage2.Text = "Build"
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Image = My.Resources.Build
			Me.pictureBox2.Location = New Point(3, 3)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New Size(587, 570)
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage3.Controls.Add(Me.pictureBox3)
			Me.radPageViewPage3.Location = New Point(103, 9)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(827, 521)
			Me.radPageViewPage3.TabIndex = 2
			Me.radPageViewPage3.Text = "Build Events"
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Image = My.Resources.BuildEvents
			Me.pictureBox3.Location = New Point(3, 3)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New Size(519, 348)
			Me.pictureBox3.TabIndex = 2
			Me.pictureBox3.TabStop = False
			' 
			' radPageViewPage4
			' 
			Me.radPageViewPage4.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage4.Controls.Add(Me.pictureBox4)
			Me.radPageViewPage4.Location = New Point(103, 9)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New Size(827, 521)
			Me.radPageViewPage4.TabIndex = 3
			Me.radPageViewPage4.Text = "Debug"
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Image = My.Resources.Debug
			Me.pictureBox4.Location = New Point(3, 3)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New Size(541, 443)
			Me.pictureBox4.TabIndex = 3
			Me.pictureBox4.TabStop = False
			' 
			' radPageViewPage5
			' 
			Me.radPageViewPage5.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage5.Controls.Add(Me.pictureBox5)
			Me.radPageViewPage5.Location = New Point(103, 9)
			Me.radPageViewPage5.Name = "radPageViewPage5"
			Me.radPageViewPage5.Size = New Size(827, 521)
			Me.radPageViewPage5.TabIndex = 4
			Me.radPageViewPage5.Text = "Publish"
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Image = My.Resources.Publish
			Me.pictureBox5.Location = New Point(3, 3)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New Size(586, 468)
			Me.pictureBox5.TabIndex = 0
			Me.pictureBox5.TabStop = False
			' 
			' radPageViewPage8
			' 
			Me.radPageViewPage8.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage8.Controls.Add(Me.pictureBox8)
			Me.radPageViewPage8.Location = New Point(103, 9)
			Me.radPageViewPage8.Name = "radPageViewPage8"
			Me.radPageViewPage8.Size = New Size(827, 521)
			Me.radPageViewPage8.TabIndex = 5
			Me.radPageViewPage8.Text = "Reference Paths"
			' 
			' pictureBox8
			' 
			Me.pictureBox8.Image = My.Resources.Refernce_Paths
			Me.pictureBox8.Location = New Point(3, 3)
			Me.pictureBox8.Name = "pictureBox8"
			Me.pictureBox8.Size = New Size(549, 381)
			Me.pictureBox8.TabIndex = 7
			Me.pictureBox8.TabStop = False
			' 
			' radPageViewPage6
			' 
			Me.radPageViewPage6.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage6.Controls.Add(Me.pictureBox6)
			Me.radPageViewPage6.Location = New Point(103, 9)
			Me.radPageViewPage6.Name = "radPageViewPage6"
			Me.radPageViewPage6.Size = New Size(827, 521)
			Me.radPageViewPage6.TabIndex = 6
			Me.radPageViewPage6.Text = "Security"
			' 
			' pictureBox6
			' 
			Me.pictureBox6.Image = My.Resources.Security
			Me.pictureBox6.Location = New Point(3, 3)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New Size(581, 515)
			Me.pictureBox6.TabIndex = 0
			Me.pictureBox6.TabStop = False
			' 
			' radPageViewPage7
			' 
			Me.radPageViewPage7.BackColor = Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.radPageViewPage7.Controls.Add(Me.pictureBox7)
			Me.radPageViewPage7.Location = New Point(103, 9)
			Me.radPageViewPage7.Name = "radPageViewPage7"
			Me.radPageViewPage7.Size = New Size(827, 521)
			Me.radPageViewPage7.TabIndex = 7
			Me.radPageViewPage7.Text = "Services"
			' 
			' pictureBox7
			' 
			Me.pictureBox7.Image = My.Resources.Services
			Me.pictureBox7.Location = New Point(3, 3)
			Me.pictureBox7.Name = "pictureBox7"
			Me.pictureBox7.Size = New Size(578, 441)
			Me.pictureBox7.TabIndex = 6
			Me.pictureBox7.TabStop = False
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(86, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Strip Alignment:"
			' 
			' alignCombo
			' 
			Me.alignCombo.Anchor = AnchorStyles.Top
			Me.alignCombo.Location = New Point(10, 59)
			Me.alignCombo.Name = "alignCombo"
			' 
			' 
			' 
			Me.alignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.alignCombo.Size = New Size(164, 20)
			Me.alignCombo.TabIndex = 2
			Me.alignCombo.TabStop = False
			Me.alignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(10, 85)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(90, 16)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Item Orientation:"
			' 
			' orientationCombo
			' 
			Me.orientationCombo.Anchor = AnchorStyles.Top
			Me.orientationCombo.Location = New Point(10, 107)
			Me.orientationCombo.Name = "orientationCombo"
			' 
			' 
			' 
			Me.orientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.orientationCombo.Size = New Size(164, 20)
			Me.orientationCombo.TabIndex = 4
			Me.orientationCombo.TabStop = False
			Me.orientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(10, 133)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(74, 16)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "Strip Buttons:"
			' 
			' buttonsCombo
			' 
			Me.buttonsCombo.Anchor = AnchorStyles.Top
			Me.buttonsCombo.Location = New Point(10, 155)
			Me.buttonsCombo.Name = "buttonsCombo"
			' 
			' 
			' 
			Me.buttonsCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.buttonsCombo.Size = New Size(164, 20)
			Me.buttonsCombo.TabIndex = 6
			Me.buttonsCombo.TabStop = False
			Me.buttonsCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1249, 538)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage4.ResumeLayout(False)
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage5.ResumeLayout(False)
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage8.ResumeLayout(False)
			CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage6.ResumeLayout(False)
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage7.ResumeLayout(False)
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonsCombo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage6 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage7 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage8 As Telerik.WinControls.UI.RadPageViewPage
		Private pictureBox1 As PictureBox
		Private pictureBox2 As PictureBox
		Private pictureBox3 As PictureBox
		Private pictureBox4 As PictureBox
		Private pictureBox5 As PictureBox
		Private pictureBox6 As PictureBox
		Private pictureBox7 As PictureBox
		Private pictureBox8 As PictureBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private buttonsCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private orientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private alignCombo As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace
