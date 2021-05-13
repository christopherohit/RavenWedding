Namespace Telerik.Examples.WinControls.Carousel.CarouselSettings
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
			Dim carouselEllipsePath1 As New Telerik.WinControls.UI.CarouselEllipsePath()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Me.groupBox2 = New GroupBox()
			Me.radCarouselDemo = New Telerik.WinControls.UI.RadCarousel()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement8 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radTitleBar = New Telerik.WinControls.UI.RadTitleBar()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radComboAutoLoop = New Telerik.WinControls.UI.RadDropDownList()
			Me.radCheckEnableLooping = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckAutoLoop = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckVirtualMode = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinRestoreDuration = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinVisibleElements = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLblAutoLoopDirection = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLblVItemCount = New Telerik.WinControls.UI.RadLabel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			CType(Me.radCarouselDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radComboAutoLoop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckEnableLooping, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckAutoLoop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckVirtualMode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinRestoreDuration, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinVisibleElements, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblAutoLoopDirection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblVItemCount, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox2
			' 
			Me.groupBox2.Dock = DockStyle.Fill
			Me.groupBox2.Location = New Point(0, 0)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New Size(672, 306)
			Me.groupBox2.TabIndex = 11
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Bezier path"
			' 
			' radCarouselDemo
			' 
			Me.radCarouselDemo.AutoLoopPauseCondition = Telerik.WinControls.UI.AutoLoopPauseConditions.None
			Me.radCarouselDemo.BackColor = Color.Black
			Me.radCarouselDemo.BackgroundImage = My.Resources.PlanetsBG
			Me.radCarouselDemo.BackgroundImageLayout = ImageLayout.Center
			carouselEllipsePath1.Center = New Telerik.WinControls.UI.Point3D(49.358974358974358R, 46.315789473684212R, -20R)
			carouselEllipsePath1.FinalAngle = 60R
			carouselEllipsePath1.InitialAngle = 60R
			carouselEllipsePath1.U = New Telerik.WinControls.UI.Point3D(37.93530426465815R, -18.191666666666663R, 0R)
			carouselEllipsePath1.V = New Telerik.WinControls.UI.Point3D(-11.489983091663683R, -15.391666666666662R, -20R)
			carouselEllipsePath1.ZScale = 60R
			Me.radCarouselDemo.CarouselPath = carouselEllipsePath1
			Me.radCarouselDemo.Dock = DockStyle.Fill
			Me.radCarouselDemo.EnableAutoLoop = True
			Me.radCarouselDemo.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radCarouselDemo.ForeColor = Color.Black
			Me.radCarouselDemo.ImageScalingSize = New Size(0, 0)
			Me.radCarouselDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radButtonElement2, Me.radButtonElement3, Me.radButtonElement4, Me.radButtonElement5, Me.radButtonElement6, Me.radButtonElement7, Me.radButtonElement8, Me.radButtonElement9})
			Me.radCarouselDemo.Location = New Point(0, 132)
			Me.radCarouselDemo.MinFadeOpacity = 0.5R
			Me.radCarouselDemo.Name = "radCarouselDemo"
			Me.radCarouselDemo.NavigationButtonsOffset = New Size(15, 15)
			Me.radCarouselDemo.SelectedIndex = 0
			Me.radCarouselDemo.Size = New Size(780, 475)
			Me.radCarouselDemo.TabIndex = 1
			Me.radCarouselDemo.Text = "radCarouselDemo"
			Me.radCarouselDemo.ThemeName = "ControlDefault"
			Me.radCarouselDemo.VisibleItemCount = 9
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt((CByte(146)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt((CByte(27)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.CarouselSettings_PrevBtn
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.CarouselSettings_NextBtn
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "radButtonElement1"
			Me.radButtonElement1.AccessibleName = "radButtonElement1"
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement1.Image = (CType(resources.GetObject("radButtonElement1.Image"), Image))
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.ShowBorder = False
			Me.radButtonElement1.Text = "radButtonElement1"
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement1.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement1.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.AccessibleDescription = "radButtonElement2"
			Me.radButtonElement2.AccessibleName = "radButtonElement2"
			Me.radButtonElement2.CanFocus = True
			Me.radButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement2.Image = (CType(resources.GetObject("radButtonElement2.Image"), Image))
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.ShowBorder = False
			Me.radButtonElement2.Text = "radButtonElement2"
			Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement2.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement2.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.AccessibleDescription = "radButtonElement3"
			Me.radButtonElement3.AccessibleName = "radButtonElement3"
			Me.radButtonElement3.CanFocus = True
			Me.radButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement3.Image = (CType(resources.GetObject("radButtonElement3.Image"), Image))
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.ShowBorder = False
			Me.radButtonElement3.Text = "radButtonElement3"
			Me.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement3.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement3.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement4
			' 
			Me.radButtonElement4.AccessibleDescription = "radButtonElement4"
			Me.radButtonElement4.AccessibleName = "radButtonElement4"
			Me.radButtonElement4.CanFocus = True
			Me.radButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement4.Image = (CType(resources.GetObject("radButtonElement4.Image"), Image))
			Me.radButtonElement4.Name = "radButtonElement4"
			Me.radButtonElement4.ShowBorder = False
			Me.radButtonElement4.Text = "radButtonElement4"
			Me.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement4.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement4.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement5
			' 
			Me.radButtonElement5.AccessibleDescription = "radButtonElement5"
			Me.radButtonElement5.AccessibleName = "radButtonElement5"
			Me.radButtonElement5.CanFocus = True
			Me.radButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement5.Image = (CType(resources.GetObject("radButtonElement5.Image"), Image))
			Me.radButtonElement5.Name = "radButtonElement5"
			Me.radButtonElement5.ShowBorder = False
			Me.radButtonElement5.Text = "radButtonElement5"
			Me.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement5.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement5.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement6
			' 
			Me.radButtonElement6.AccessibleDescription = "radButtonElement6"
			Me.radButtonElement6.AccessibleName = "radButtonElement6"
			Me.radButtonElement6.CanFocus = True
			Me.radButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement6.Image = (CType(resources.GetObject("radButtonElement6.Image"), Image))
			Me.radButtonElement6.Name = "radButtonElement6"
			Me.radButtonElement6.ShowBorder = False
			Me.radButtonElement6.Text = "radButtonElement6"
			Me.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement6.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement6.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement7
			' 
			Me.radButtonElement7.AccessibleDescription = "radButtonElement7"
			Me.radButtonElement7.AccessibleName = "radButtonElement7"
			Me.radButtonElement7.CanFocus = True
			Me.radButtonElement7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement7.Image = (CType(resources.GetObject("radButtonElement7.Image"), Image))
			Me.radButtonElement7.Name = "radButtonElement7"
			Me.radButtonElement7.ShowBorder = False
			Me.radButtonElement7.Text = "radButtonElement7"
			Me.radButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement7.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement7.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement8
			' 
			Me.radButtonElement8.AccessibleDescription = "radButtonElement8"
			Me.radButtonElement8.AccessibleName = "radButtonElement8"
			Me.radButtonElement8.CanFocus = True
			Me.radButtonElement8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement8.Image = (CType(resources.GetObject("radButtonElement8.Image"), Image))
			Me.radButtonElement8.Name = "radButtonElement8"
			Me.radButtonElement8.ShowBorder = False
			Me.radButtonElement8.Text = "radButtonElement8"
			Me.radButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement8.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement8.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement9
			' 
			Me.radButtonElement9.AccessibleDescription = "radButtonElement9"
			Me.radButtonElement9.AccessibleName = "radButtonElement9"
			Me.radButtonElement9.CanFocus = True
			Me.radButtonElement9.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement9.Image = (CType(resources.GetObject("radButtonElement9.Image"), Image))
			Me.radButtonElement9.Name = "radButtonElement9"
			Me.radButtonElement9.ShowBorder = False
			Me.radButtonElement9.Text = "radButtonElement9"
			Me.radButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radButtonElement9.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radButtonElement9.GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = "Telerik.Examples.WinControls.Carousel.CarouselSettings.CarouselButtons.xml"
			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = "TelerikExamples.Carousel.MusicLibrary.ButtonMusicLibrary.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1, themeSource2})
			' 
			' radTitleBar
			' 
			Me.radTitleBar.Dock = DockStyle.Top
			Me.radTitleBar.ForeColor = Color.White
			Me.radTitleBar.Location = New Point(0, 0)
			Me.radTitleBar.Name = "radTitleBar"
			Me.radTitleBar.Size = New Size(780, 52)
			Me.radTitleBar.TabIndex = 14
			Me.radTitleBar.TabStop = False
			Me.radTitleBar.Text = "Solar System Settings"
			CType(Me.radTitleBar.GetChildAt(0), Telerik.WinControls.UI.RadTitleBarElement).Text = "Solar System Settings"
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt((CByte(57)))), (CInt((CByte(60)))), (CInt((CByte(67)))))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.FromArgb((CInt((CByte(48)))), (CInt((CByte(48)))), (CInt((CByte(49)))))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.FromArgb((CInt((CByte(58)))), (CInt((CByte(58)))), (CInt((CByte(58)))))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.25F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.25F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt((CByte(61)))), (CInt((CByte(64)))), (CInt((CByte(74)))))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopWidth = 0F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightWidth = 0F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomWidth = 0F
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = Color.FromArgb((CInt((CByte(50)))), (CInt((CByte(50)))), (CInt((CByte(50)))))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.White
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.CarouselSettings_Min
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Margin = New Padding(0, 0, -2, 0)
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.CarouselSettings_Max
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Margin = New Padding(0, 0, -2, 0)
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.CarouselSettings_Close
			CType(Me.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radComboAutoLoop)
			Me.radPanel1.Controls.Add(Me.radCheckEnableLooping)
			Me.radPanel1.Controls.Add(Me.radCheckAutoLoop)
			Me.radPanel1.Controls.Add(Me.radCheckVirtualMode)
			Me.radPanel1.Controls.Add(Me.radSpinRestoreDuration)
			Me.radPanel1.Controls.Add(Me.radSpinVisibleElements)
			Me.radPanel1.Controls.Add(Me.radLblAutoLoopDirection)
			Me.radPanel1.Controls.Add(Me.radLabel3)
			Me.radPanel1.Controls.Add(Me.radLblVItemCount)
			Me.radPanel1.Dock = DockStyle.Top
			Me.radPanel1.Location = New Point(0, 52)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(780, 80)
			Me.radPanel1.TabIndex = 15
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Margin = New Padding(8)
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(233)))), (CInt((CByte(236)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.FromArgb((CInt((CByte(217)))), (CInt((CByte(222)))), (CInt((CByte(228)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.FromArgb((CInt((CByte(216)))), (CInt((CByte(222)))), (CInt((CByte(227)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(238)))), (CInt((CByte(241)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor = Color.FromArgb((CInt((CByte(245)))), (CInt((CByte(246)))), (CInt((CByte(248)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.FromArgb((CInt((CByte(182)))), (CInt((CByte(193)))), (CInt((CByte(204)))))
			' 
			' radComboAutoLoop
			' 
			Me.radComboAutoLoop.Anchor = AnchorStyles.None
			Me.radComboAutoLoop.DropDownAnimationEnabled = True
			Me.radComboAutoLoop.Location = New Point(332, 40)
			Me.radComboAutoLoop.Name = "radComboAutoLoop"
			Me.radComboAutoLoop.ShowImageInEditorArea = True
			Me.radComboAutoLoop.Size = New Size(106, 20)
			Me.radComboAutoLoop.TabIndex = 19
			Me.radComboAutoLoop.Text = "Forward"
			Me.radComboAutoLoop.ThemeName = "Office2010Black"
			Me.radComboAutoLoop.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

			' 
			' radCheckEnableLooping
			' 
			Me.radCheckEnableLooping.Anchor = AnchorStyles.None
			Me.radCheckEnableLooping.BackColor = Color.Transparent
			Me.radCheckEnableLooping.ForeColor = Color.FromArgb((CInt((CByte(5)))), (CInt((CByte(5)))), (CInt((CByte(5)))))
			Me.radCheckEnableLooping.Location = New Point(93, 20)
			Me.radCheckEnableLooping.Name = "radCheckEnableLooping"
			Me.radCheckEnableLooping.Size = New Size(98, 18)
			Me.radCheckEnableLooping.TabIndex = 12
			Me.radCheckEnableLooping.Text = "Enable Looping"
			Me.radCheckEnableLooping.ThemeName = "Office2010Black"
			Me.radCheckEnableLooping.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' radCheckAutoLoop
			' 
			Me.radCheckAutoLoop.Anchor = AnchorStyles.None
			Me.radCheckAutoLoop.BackColor = Color.Transparent
			Me.radCheckAutoLoop.ForeColor = Color.FromArgb((CInt((CByte(5)))), (CInt((CByte(5)))), (CInt((CByte(5)))))
			Me.radCheckAutoLoop.Location = New Point(93, 43)
			Me.radCheckAutoLoop.Name = "radCheckAutoLoop"
			Me.radCheckAutoLoop.Size = New Size(70, 18)
			Me.radCheckAutoLoop.TabIndex = 18
			Me.radCheckAutoLoop.Text = "AutoLoop"
			Me.radCheckAutoLoop.ThemeName = "Office2010Black"
			Me.radCheckAutoLoop.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' radCheckVirtualMode
			' 
			Me.radCheckVirtualMode.Anchor = AnchorStyles.None
			Me.radCheckVirtualMode.BackColor = Color.Transparent
			Me.radCheckVirtualMode.ForeColor = Color.FromArgb((CInt((CByte(5)))), (CInt((CByte(5)))), (CInt((CByte(5)))))
			Me.radCheckVirtualMode.Location = New Point(214, 31)
			Me.radCheckVirtualMode.Name = "radCheckVirtualMode"
			Me.radCheckVirtualMode.Size = New Size(85, 18)
			Me.radCheckVirtualMode.TabIndex = 17
			Me.radCheckVirtualMode.Text = "Virtual Mode"
			Me.radCheckVirtualMode.ThemeName = "Office2010Black"
			Me.radCheckVirtualMode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' radSpinRestoreDuration
			' 
			Me.radSpinRestoreDuration.Anchor = AnchorStyles.None
			Me.radSpinRestoreDuration.Location = New Point(597, 40)
			Me.radSpinRestoreDuration.Maximum = New Decimal(New Integer() { 9, 0, 0, 0})
			Me.radSpinRestoreDuration.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinRestoreDuration.Name = "radSpinRestoreDuration"
			' 
			' 
			' 
			Me.radSpinRestoreDuration.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinRestoreDuration.ShowBorder = True
			Me.radSpinRestoreDuration.Size = New Size(90, 20)
			Me.radSpinRestoreDuration.TabIndex = 14
			Me.radSpinRestoreDuration.TabStop = False
			Me.radSpinRestoreDuration.ThemeName = "Office2010Black"
			Me.radSpinRestoreDuration.Value = New Decimal(New Integer() { 3, 0, 0, 0})

			' 
			' radSpinVisibleElements
			' 
			Me.radSpinVisibleElements.Anchor = AnchorStyles.None
			Me.radSpinVisibleElements.Location = New Point(471, 40)
			Me.radSpinVisibleElements.Maximum = New Decimal(New Integer() { 9, 0, 0, 0})
			Me.radSpinVisibleElements.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinVisibleElements.Name = "radSpinVisibleElements"
			' 
			' 
			' 
			Me.radSpinVisibleElements.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinVisibleElements.ShowBorder = True
			Me.radSpinVisibleElements.Size = New Size(90, 20)
			Me.radSpinVisibleElements.TabIndex = 13
			Me.radSpinVisibleElements.TabStop = False
			Me.radSpinVisibleElements.ThemeName = "Office2010Black"
			Me.radSpinVisibleElements.Value = New Decimal(New Integer() { 9, 0, 0, 0})

			' 
			' radLblAutoLoopDirection
			' 
			Me.radLblAutoLoopDirection.Anchor = AnchorStyles.None
			Me.radLblAutoLoopDirection.BackColor = Color.Transparent
			Me.radLblAutoLoopDirection.ForeColor = Color.Black
			Me.radLblAutoLoopDirection.Location = New Point(332, 20)
			Me.radLblAutoLoopDirection.Name = "radLblAutoLoopDirection"
			Me.radLblAutoLoopDirection.Size = New Size(80, 18)
			Me.radLblAutoLoopDirection.TabIndex = 20
			Me.radLblAutoLoopDirection.Text = "Loop Direction"
			Me.radLblAutoLoopDirection.ThemeName = "Office2010Black"
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.None
			Me.radLabel3.BackColor = Color.Transparent
			Me.radLabel3.ForeColor = Color.Black
			Me.radLabel3.Location = New Point(597, 20)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(91, 18)
			Me.radLabel3.TabIndex = 16
			Me.radLabel3.Text = "Restore Duration"
			Me.radLabel3.ThemeName = "Office2010Black"
			' 
			' radLblVItemCount
			' 
			Me.radLblVItemCount.Anchor = AnchorStyles.None
			Me.radLblVItemCount.BackColor = Color.Transparent
			Me.radLblVItemCount.ForeColor = Color.Black
			Me.radLblVItemCount.Location = New Point(471, 20)
			Me.radLblVItemCount.Name = "radLblVItemCount"
			Me.radLblVItemCount.Size = New Size(69, 18)
			Me.radLblVItemCount.TabIndex = 15
			Me.radLblVItemCount.Text = "Visible Items"
			Me.radLblVItemCount.ThemeName = "Office2010Black"
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.Radius = 10
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.BackColor = Color.Black
			Me.BorderColor = Color.Silver
			Me.ClientSize = New Size(780, 607)
			Me.Controls.Add(Me.radCarouselDemo)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radTitleBar)
			Me.MinimumSize = New Size(780, 600)
			Me.Name = "Form1"
			Me.Shape = Me.roundRectShape1
			Me.Text = "Solar System Settings"
			CType(Me.radCarouselDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTitleBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radComboAutoLoop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckEnableLooping, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckAutoLoop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckVirtualMode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinRestoreDuration, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinVisibleElements, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblAutoLoopDirection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblVItemCount, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCarouselDemo As Telerik.WinControls.UI.RadCarousel
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private groupBox2 As GroupBox
		Private radTitleBar As Telerik.WinControls.UI.RadTitleBar
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement3 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement4 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement5 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement6 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement7 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement8 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement9 As Telerik.WinControls.UI.RadButtonElement
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radComboAutoLoop As Telerik.WinControls.UI.RadDropDownList
		Private radCheckEnableLooping As Telerik.WinControls.UI.RadCheckBox
		Private radCheckAutoLoop As Telerik.WinControls.UI.RadCheckBox
		Private radCheckVirtualMode As Telerik.WinControls.UI.RadCheckBox
		Private radSpinRestoreDuration As Telerik.WinControls.UI.RadSpinEditor
		Private radSpinVisibleElements As Telerik.WinControls.UI.RadSpinEditor
		Private radLblAutoLoopDirection As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLblVItemCount As Telerik.WinControls.UI.RadLabel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape

	End Class
End Namespace