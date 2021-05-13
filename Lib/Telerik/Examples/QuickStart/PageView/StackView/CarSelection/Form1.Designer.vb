Namespace Telerik.Examples.WinControls.PageView.StackView.CarSelection
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageList2 = New ImageList(Me.components)
			Me.imageList3 = New ImageList(Me.components)
			Me.imageList4 = New ImageList(Me.components)
			Me.imageList1 = New ImageList(Me.components)
			Me.radBtnCar = New Telerik.WinControls.UI.RadButton()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radListOptions = New Telerik.WinControls.UI.RadListControl()
			Me.radLblBase = New Telerik.WinControls.UI.RadLabel()
			Me.radLblBuild = New Telerik.WinControls.UI.RadLabel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.automaticTransmissionCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.leatherWheelCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.smartPhoneCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.navigationSystemCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.heatedSeatsCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.accessSystemCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.hifiCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.ipodAdapterCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radioCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.xenonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.parkControlCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.assistantCheck = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnCar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radListOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblBase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblBuild, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.automaticTransmissionCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.leatherWheelCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.smartPhoneCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationSystemCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.heatedSeatsCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.accessSystemCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage4.SuspendLayout()
			CType(Me.hifiCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ipodAdapterCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage5.SuspendLayout()
			CType(Me.xenonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.parkControlCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.assistantCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1093, 1)
			Me.settingsPanel.Size = New Size(200, 587)

			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
			Me.imageList2.TransparentColor = Color.Transparent
			Me.imageList2.Images.SetKeyName(0, "0_Personal_Folders.gif")
			Me.imageList2.Images.SetKeyName(1, "1_Deleted_Items.gif")
			Me.imageList2.Images.SetKeyName(2, "2_Drafts.gif")
			Me.imageList2.Images.SetKeyName(3, "3_Inbox.gif")
			Me.imageList2.Images.SetKeyName(4, "4_Junk_E-mail.gif")
			Me.imageList2.Images.SetKeyName(5, "5_Outbox.gif")
			Me.imageList2.Images.SetKeyName(6, "6_Rss_Feeds.gif")
			Me.imageList2.Images.SetKeyName(7, "7_Sent_Items.gif")
			Me.imageList2.Images.SetKeyName(8, "8.1_Search.gif")
			Me.imageList2.Images.SetKeyName(9, "8_Search.gif")
			' 
			' imageList3
			' 
			Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), ImageListStreamer))
			Me.imageList3.TransparentColor = Color.Transparent
			Me.imageList3.Images.SetKeyName(0, "00_Personal_Folders.gif")
			Me.imageList3.Images.SetKeyName(1, "01_Calendar.gif")
			Me.imageList3.Images.SetKeyName(2, "02_Contacts.gif")
			Me.imageList3.Images.SetKeyName(3, "03_Deleted_Items.gif")
			Me.imageList3.Images.SetKeyName(4, "04_Drafts.gif")
			Me.imageList3.Images.SetKeyName(5, "05_Inbox.gif")
			Me.imageList3.Images.SetKeyName(6, "06_Journal.gif")
			Me.imageList3.Images.SetKeyName(7, "07_Junk_E-mail.gif")
			Me.imageList3.Images.SetKeyName(8, "08_Notes.gif")
			Me.imageList3.Images.SetKeyName(9, "09_Outbox.gif")
			Me.imageList3.Images.SetKeyName(10, "10_Rss_Feeds.gif")
			Me.imageList3.Images.SetKeyName(11, "11_Sent_Items.gif")
			Me.imageList3.Images.SetKeyName(12, "12_Tasks.gif")
			Me.imageList3.Images.SetKeyName(13, "13_0_Search.gif")
			Me.imageList3.Images.SetKeyName(14, "13_1_Search.gif")
			' 
			' imageList4
			' 
			Me.imageList4.ImageStream = (CType(resources.GetObject("imageList4.ImageStream"), ImageListStreamer))
			Me.imageList4.TransparentColor = Color.Transparent
			Me.imageList4.Images.SetKeyName(0, "1_Outlook_Today.gif")
			Me.imageList4.Images.SetKeyName(1, "2_Office_Online.gif")
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "Expanded_state.gif")
			Me.imageList1.Images.SetKeyName(1, "1_Mail_big.gif")
			Me.imageList1.Images.SetKeyName(2, "2_Calendar_big.gif")
			Me.imageList1.Images.SetKeyName(3, "3_Contacts_big.gif")
			Me.imageList1.Images.SetKeyName(4, "5_Notes_big.gif")
			Me.imageList1.Images.SetKeyName(5, "5_Tasks_big.gif")
			Me.imageList1.Images.SetKeyName(6, "6_Folder_list_big.gif")
			Me.imageList1.Images.SetKeyName(7, "7_Shortcuts_big.gif")
			Me.imageList1.Images.SetKeyName(8, "Collapsed_state.gif")
			' 
			' radBtnCar
			' 
			Me.radBtnCar.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radBtnCar.Font = New Font("Arial", 8.25F, FontStyle.Bold)
			Me.radBtnCar.Image = My.Resources.BMW_Small
			Me.radBtnCar.Location = New Point(3, 3)
			Me.radBtnCar.Name = "radBtnCar"
			Me.radBtnCar.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radBtnCar.RootElement.Padding = New Padding(5)
			Me.radBtnCar.Size = New Size(215, 47)
			Me.radBtnCar.TabIndex = 0
			Me.radBtnCar.Text = "BMW 128i Coupe"
			Me.radBtnCar.TextImageRelation = TextImageRelation.ImageBeforeText

			CType(Me.radBtnCar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = My.Resources.BMW_Small
			CType(Me.radBtnCar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = TextImageRelation.ImageBeforeText
			CType(Me.radBtnCar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "BMW 128i Coupe"
			CType(Me.radBtnCar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New Padding(5)
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radListOptions)
			Me.radPanel2.Controls.Add(Me.radLblBase)
			Me.radPanel2.Controls.Add(Me.radLblBuild)
			Me.radPanel2.Controls.Add(Me.radPanel3)
            Me.radPanel2.Location = New Point(250, 20)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New Size(483, 484)
			Me.radPanel2.TabIndex = 2
			' 
			' radListOptions
			' 
			Me.radListOptions.Location = New Point(4, 276)
			Me.radListOptions.Name = "radListOptions"
			Me.radListOptions.SelectionMode = SelectionMode.None
			Me.radListOptions.Size = New Size(476, 205)
			Me.radListOptions.TabIndex = 2
			' 
			' radLblBase
			' 
			Me.radLblBase.Location = New Point(3, 252)
			Me.radLblBase.Name = "radLblBase"
			Me.radLblBase.Size = New Size(244, 18)
			Me.radLblBase.TabIndex = 1
			Me.radLblBase.Text = "3-liter, inline 6 cylinder engine Rear-wheel drive"
			' 
			' radLblBuild
			' 
			Me.radLblBuild.Location = New Point(4, 4)
			Me.radLblBuild.Name = "radLblBuild"
			Me.radLblBuild.Size = New Size(171, 18)
			Me.radLblBuild.TabIndex = 1
			Me.radLblBuild.Text = "Build Your Own 2009 128i Coupe"
			' 
			' radPanel3
			' 
			Me.radPanel3.BackgroundImage = My.Resources.BMW_Big
			Me.radPanel3.BackgroundImageLayout = ImageLayout.Center
			Me.radPanel3.ForeColor = Color.Black
			Me.radPanel3.Location = New Point(3, 30)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New Size(477, 216)
			Me.radPanel3.TabIndex = 0
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Controls.Add(Me.radPageViewPage4)
			Me.radPageView1.Controls.Add(Me.radPageViewPage5)
            Me.radPageView1.Location = New Point(20, 20)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(231, 484)
			Me.radPageView1.TabIndex = 3
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStackElement).ItemSelectionMode = Telerik.WinControls.UI.StackViewItemSelectionMode.ContentWithSelected
			CType(Me.radPageView1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewLabelElement).Text = "Safety Options"
			CType(Me.radPageView1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewLabelElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radPageViewPage1
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage1.Controls.Add(Me.radBtnCar)
			Me.radPageViewPage1.Location = New Point(5, 35)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(221, 321)
			Me.radPageViewPage1.Text = "Car"
			' 
			' radPageViewPage2
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage2.Controls.Add(Me.automaticTransmissionCheck)
			Me.radPageViewPage2.Controls.Add(Me.leatherWheelCheck)
			Me.radPageViewPage2.Location = New Point(5, 66)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(221, 321)
			Me.radPageViewPage2.Text = "Performance Options"
			' 
			' automaticTransmissionCheck
			' 
			Me.automaticTransmissionCheck.Location = New Point(3, 27)
			Me.automaticTransmissionCheck.Name = "automaticTransmissionCheck"
			Me.automaticTransmissionCheck.Size = New Size(181, 18)
			Me.automaticTransmissionCheck.TabIndex = 1
			Me.automaticTransmissionCheck.Text = "Automatic Transmission    $2000"
			' 
			' leatherWheelCheck
			' 
			Me.leatherWheelCheck.Location = New Point(3, 3)
			Me.leatherWheelCheck.Name = "leatherWheelCheck"
			Me.leatherWheelCheck.Size = New Size(163, 18)
			Me.leatherWheelCheck.TabIndex = 0
			Me.leatherWheelCheck.Text = "Sports Leather Wheel    $100"
			' 
			' radPageViewPage3
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage3.Controls.Add(Me.smartPhoneCheck)
			Me.radPageViewPage3.Controls.Add(Me.navigationSystemCheck)
			Me.radPageViewPage3.Controls.Add(Me.heatedSeatsCheck)
			Me.radPageViewPage3.Controls.Add(Me.accessSystemCheck)
			Me.radPageViewPage3.Location = New Point(5, 97)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(221, 321)
			Me.radPageViewPage3.Text = "Convenience Options"
			' 
			' smartPhoneCheck
			' 
			Me.smartPhoneCheck.Location = New Point(3, 75)
			Me.smartPhoneCheck.Name = "smartPhoneCheck"
			Me.smartPhoneCheck.Size = New Size(175, 18)
			Me.smartPhoneCheck.TabIndex = 5
			Me.smartPhoneCheck.Text = "SmartPhone Integration    $150"
			' 
			' navigationSystemCheck
			' 
			Me.navigationSystemCheck.Location = New Point(3, 51)
			Me.navigationSystemCheck.Name = "navigationSystemCheck"
			Me.navigationSystemCheck.Size = New Size(155, 18)
			Me.navigationSystemCheck.TabIndex = 4
			Me.navigationSystemCheck.Text = "Navigation System    $2100"
			' 
			' heatedSeatsCheck
			' 
			Me.heatedSeatsCheck.Location = New Point(3, 27)
			Me.heatedSeatsCheck.Name = "heatedSeatsCheck"
			Me.heatedSeatsCheck.Size = New Size(151, 18)
			Me.heatedSeatsCheck.TabIndex = 3
			Me.heatedSeatsCheck.Text = "Heated Front Seats    $500"
			' 
			' accessSystemCheck
			' 
			Me.accessSystemCheck.Location = New Point(3, 3)
			Me.accessSystemCheck.Name = "accessSystemCheck"
			Me.accessSystemCheck.Size = New Size(173, 18)
			Me.accessSystemCheck.TabIndex = 2
			Me.accessSystemCheck.Text = "Comfort Access System    $500"
			' 
			' radPageViewPage4
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage4.Controls.Add(Me.hifiCheck)
			Me.radPageViewPage4.Controls.Add(Me.ipodAdapterCheck)
			Me.radPageViewPage4.Controls.Add(Me.radioCheck)
			Me.radPageViewPage4.Location = New Point(5, 128)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New Size(221, 321)
			Me.radPageViewPage4.Text = "Entertainment Options"
			' 
			' hifiCheck
			' 
			Me.hifiCheck.Location = New Point(3, 51)
			Me.hifiCheck.Name = "hifiCheck"
			Me.hifiCheck.Size = New Size(166, 18)
			Me.hifiCheck.TabIndex = 8
			Me.hifiCheck.Text = "Premium Hi-Fi System    $875"
			' 
			' ipodAdapterCheck
			' 
			Me.ipodAdapterCheck.Location = New Point(3, 27)
			Me.ipodAdapterCheck.Name = "ipodAdapterCheck"
			Me.ipodAdapterCheck.Size = New Size(167, 18)
			Me.ipodAdapterCheck.TabIndex = 7
			Me.ipodAdapterCheck.Text = "iPod and USB Adapter    $400"
			' 
			' radioCheck
			' 
			Me.radioCheck.Location = New Point(3, 3)
			Me.radioCheck.Name = "radioCheck"
			Me.radioCheck.Size = New Size(104, 18)
			Me.radioCheck.TabIndex = 6
			Me.radioCheck.Text = "HD Radio    $350"
			' 
			' radPageViewPage5
			' 
' TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			Me.radPageViewPage5.Controls.Add(Me.xenonCheck)
			Me.radPageViewPage5.Controls.Add(Me.parkControlCheck)
			Me.radPageViewPage5.Controls.Add(Me.assistantCheck)
			Me.radPageViewPage5.Location = New Point(5, 159)
			Me.radPageViewPage5.Name = "radPageViewPage5"
			Me.radPageViewPage5.Size = New Size(221, 320)
			Me.radPageViewPage5.Text = "Safety Options"
			' 
			' xenonCheck
			' 
			Me.xenonCheck.Location = New Point(3, 51)
			Me.xenonCheck.Name = "xenonCheck"
			Me.xenonCheck.Size = New Size(145, 18)
			Me.xenonCheck.TabIndex = 11
			Me.xenonCheck.Text = "Xenon Headlights    $900"
			' 
			' parkControlCheck
			' 
			Me.parkControlCheck.Location = New Point(3, 27)
			Me.parkControlCheck.Name = "parkControlCheck"
			Me.parkControlCheck.Size = New Size(164, 18)
			Me.parkControlCheck.TabIndex = 10
			Me.parkControlCheck.Text = "Park Distance Control    $350"
			' 
			' assistantCheck
			' 
			Me.assistantCheck.Location = New Point(3, 3)
			Me.assistantCheck.Name = "assistantCheck"
			Me.assistantCheck.Size = New Size(114, 18)
			Me.assistantCheck.TabIndex = 9
			Me.assistantCheck.Text = "BMW Assist    $750"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPageView1)
			Me.Controls.Add(Me.radPanel2)
			Me.Name = "Form1"
			Me.Size = New Size(1170, 671)
			Me.Controls.SetChildIndex(Me.radPanel2, 0)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnCar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			Me.radPanel2.PerformLayout()
			CType(Me.radListOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblBase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblBuild, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage2.PerformLayout()
			CType(Me.automaticTransmissionCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.leatherWheelCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			Me.radPageViewPage3.PerformLayout()
			CType(Me.smartPhoneCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationSystemCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.heatedSeatsCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.accessSystemCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage4.ResumeLayout(False)
			Me.radPageViewPage4.PerformLayout()
			CType(Me.hifiCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ipodAdapterCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage5.ResumeLayout(False)
			Me.radPageViewPage5.PerformLayout()
			CType(Me.xenonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.parkControlCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.assistantCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private imageList3 As ImageList
		Private imageList4 As ImageList
		Private radBtnCar As Telerik.WinControls.UI.RadButton
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
		Private radLblBase As Telerik.WinControls.UI.RadLabel
		Private radLblBuild As Telerik.WinControls.UI.RadLabel
		Private radListOptions As Telerik.WinControls.UI.RadListControl
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private automaticTransmissionCheck As Telerik.WinControls.UI.RadCheckBox
		Private leatherWheelCheck As Telerik.WinControls.UI.RadCheckBox
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private smartPhoneCheck As Telerik.WinControls.UI.RadCheckBox
		Private navigationSystemCheck As Telerik.WinControls.UI.RadCheckBox
		Private heatedSeatsCheck As Telerik.WinControls.UI.RadCheckBox
		Private accessSystemCheck As Telerik.WinControls.UI.RadCheckBox
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private hifiCheck As Telerik.WinControls.UI.RadCheckBox
		Private ipodAdapterCheck As Telerik.WinControls.UI.RadCheckBox
		Private radioCheck As Telerik.WinControls.UI.RadCheckBox
		Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
		Private xenonCheck As Telerik.WinControls.UI.RadCheckBox
		Private parkControlCheck As Telerik.WinControls.UI.RadCheckBox
		Private assistantCheck As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace