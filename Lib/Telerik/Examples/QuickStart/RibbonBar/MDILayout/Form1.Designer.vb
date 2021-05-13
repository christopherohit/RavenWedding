Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
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
			Me.radRibbonBarCommandTab1 = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarChunk2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement29 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radOffice2007ScreenTip1 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip2 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip3 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radOffice2007ScreenTip4 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radGalleryGroupFilter3 = New Telerik.WinControls.UI.RadGalleryGroupFilter()
			Me.radGalleryGroupItem1 = New Telerik.WinControls.UI.RadGalleryGroupItem()
			Me.radGalleryGroupItem2 = New Telerik.WinControls.UI.RadGalleryGroupItem()
			Me.radGalleryGroupFilter1 = New Telerik.WinControls.UI.RadGalleryGroupFilter()
			Me.radGalleryGroupFilter2 = New Telerik.WinControls.UI.RadGalleryGroupFilter()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radGalleryGroupFilter4 = New Telerik.WinControls.UI.RadGalleryGroupFilter()
			Me.radGalleryGroupItem3 = New Telerik.WinControls.UI.RadGalleryGroupItem()
			Me.radGalleryGroupItem4 = New Telerik.WinControls.UI.RadGalleryGroupItem()
			Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
			Me.imageList1 = New ImageList(Me.components)
			Me.radButtonElement41 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement42 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radRibbonBarCommandTab1
			' 
			Me.radRibbonBarCommandTab1.Alignment = ContentAlignment.BottomLeft
			Me.radRibbonBarCommandTab1.CanFocus = True
			Me.radRibbonBarCommandTab1.IsSelected = True
			Me.radRibbonBarCommandTab1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarChunk2, Me.radRibbonBarGroup1})
			Me.radRibbonBarCommandTab1.Name = "radRibbonBarCommandTab1"
			Me.radRibbonBarCommandTab1.StretchHorizontally = False
			Me.radRibbonBarCommandTab1.Text = "Actions"
			' 
			' radRibbonBarChunk2
			' 
			Me.radRibbonBarChunk2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement5, Me.radButtonElement29})
			Me.radRibbonBarChunk2.Name = "radRibbonBarChunk2"
			Me.radRibbonBarChunk2.Orientation = Orientation.Vertical
			Me.radRibbonBarChunk2.Text = "Pages"
			' 
			' radButtonElement5
			' 
			Me.radButtonElement5.CanFocus = True
			Me.radButtonElement5.Image = My.Resources.insert2
			Me.radButtonElement5.Margin = New Padding(4, 0, 4, 0)
			Me.radButtonElement5.Name = "radButtonElement5"
			Me.radButtonElement5.Padding = New Padding(2)
			Me.radButtonElement5.StretchVertically = False
			Me.radButtonElement5.Text = "New Form"
			Me.radButtonElement5.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButtonElement5.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButtonElement29
			' 
			Me.radButtonElement29.CanFocus = True
			Me.radButtonElement29.Image = My.Resources.exitButton
			Me.radButtonElement29.Margin = New Padding(4, 0, 4, 0)
			Me.radButtonElement29.Name = "radButtonElement29"
			Me.radButtonElement29.Padding = New Padding(2)
			Me.radButtonElement29.StretchVertically = False
			Me.radButtonElement29.Text = "Close Form"
			Me.radButtonElement29.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButtonElement29.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radRibbonBarGroup1
			' 
			Me.radRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radButtonElement2, Me.radButtonElement3})
			Me.radRibbonBarGroup1.Name = "radRibbonBarGroup1"
			Me.radRibbonBarGroup1.Orientation = Orientation.Vertical
			Me.radRibbonBarGroup1.Text = "Themes"
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Image = My.Resources.Blue
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.Padding = New Padding(2)
			Me.radButtonElement1.StretchVertically = False
			Me.radButtonElement1.Text = "Office 2007 Blue"
			Me.radButtonElement1.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButtonElement1.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.CanFocus = True
			Me.radButtonElement2.Image = My.Resources.Black
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.Padding = New Padding(2)
			Me.radButtonElement2.StretchVertically = False
			Me.radButtonElement2.Text = "Office 2010 Black"
			Me.radButtonElement2.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButtonElement2.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.CanFocus = True
			Me.radButtonElement3.Image = My.Resources.Silver
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.Padding = New Padding(2)
			Me.radButtonElement3.StretchVertically = False
			Me.radButtonElement3.Text = "Office 2010 Silver"
			Me.radButtonElement3.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButtonElement3.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radOffice2007ScreenTip1
			' 
			Me.radOffice2007ScreenTip1.CaptionVisible = True
			Me.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.FooterVisible = False
			Me.radOffice2007ScreenTip1.Location = New Point(0, 0)
			Me.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip1.ScreenTipElement.TipSize = New Size(0, 0)
			Me.radOffice2007ScreenTip1.Size = New Size(195, 43)
			Me.radOffice2007ScreenTip1.TabIndex = 0
			Me.radOffice2007ScreenTip1.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Paste"
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Paste the contents of the clipboard"
			' 
			' radOffice2007ScreenTip2
			' 
			Me.radOffice2007ScreenTip2.CaptionVisible = True
			Me.radOffice2007ScreenTip2.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip2.FooterVisible = False
			Me.radOffice2007ScreenTip2.Location = New Point(0, 0)
			Me.radOffice2007ScreenTip2.Name = "radOffice2007ScreenTip2"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip2.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip2.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip2.ScreenTipElement.TipSize = New Size(0, 0)
			Me.radOffice2007ScreenTip2.Size = New Size(336, 43)
			Me.radOffice2007ScreenTip2.TabIndex = 0
			Me.radOffice2007ScreenTip2.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Cut"
			CType(Me.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Cut the selection from the document and put it on the clipboard"
			' 
			' radOffice2007ScreenTip3
			' 
			Me.radOffice2007ScreenTip3.CaptionVisible = True
			Me.radOffice2007ScreenTip3.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip3.FooterVisible = False
			Me.radOffice2007ScreenTip3.Location = New Point(0, 0)
			Me.radOffice2007ScreenTip3.Name = "radOffice2007ScreenTip3"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip3.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip3.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip3.ScreenTipElement.TipSize = New Size(0, 0)
			Me.radOffice2007ScreenTip3.Size = New Size(247, 43)
			Me.radOffice2007ScreenTip3.TabIndex = 0
			Me.radOffice2007ScreenTip3.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Copy"
			CType(Me.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Copy the selection and put it on the clipboard"
			' 
			' radOffice2007ScreenTip4
			' 
			Me.radOffice2007ScreenTip4.CaptionVisible = True
			Me.radOffice2007ScreenTip4.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip4.FooterVisible = False
			Me.radOffice2007ScreenTip4.Location = New Point(0, 0)
			Me.radOffice2007ScreenTip4.Name = "radOffice2007ScreenTip4"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip4.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip4.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip4.ScreenTipElement.TipSize = New Size(0, 0)
			Me.radOffice2007ScreenTip4.Size = New Size(293, 43)
			Me.radOffice2007ScreenTip4.TabIndex = 0
			Me.radOffice2007ScreenTip4.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Format Painter"
			CType(Me.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Copy formatting from one place and apply it to another"
			' 
			' radGalleryGroupFilter3
			' 
			Me.radGalleryGroupFilter3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryGroupItem1, Me.radGalleryGroupItem2})
			Me.radGalleryGroupFilter3.Name = "radGalleryGroupFilter3"
			Me.radGalleryGroupFilter3.Text = "All Tables"
			' 
			' radGalleryGroupItem1
			' 
			Me.radGalleryGroupItem1.Name = "radGalleryGroupItem1"
			Me.radGalleryGroupItem1.Text = "Plain Tables"
			' 
			' radGalleryGroupItem2
			' 
			Me.radGalleryGroupItem2.Name = "radGalleryGroupItem2"
			Me.radGalleryGroupItem2.Text = "Built-In"
			' 
			' radGalleryGroupFilter1
			' 
			Me.radGalleryGroupFilter1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryGroupItem1})
			Me.radGalleryGroupFilter1.Name = "radGalleryGroupFilter1"
			Me.radGalleryGroupFilter1.Text = "Plain Tables"
			' 
			' radGalleryGroupFilter2
			' 
			Me.radGalleryGroupFilter2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryGroupItem2})
			Me.radGalleryGroupFilter2.Name = "radGalleryGroupFilter2"
			Me.radGalleryGroupFilter2.Text = "Built-In"
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.Image = (CType(resources.GetObject("radMenuItem12.Image"), Image))
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "&Modify Table Style..."
			Me.radMenuItem12.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.Image = (CType(resources.GetObject("radMenuItem13.Image"), Image))
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "&Clear"
			Me.radMenuItem13.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.Image = (CType(resources.GetObject("radMenuItem14.Image"), Image))
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "&New Table Style..."
			Me.radMenuItem14.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radGalleryGroupFilter4
			' 
			Me.radGalleryGroupFilter4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryGroupItem3, Me.radGalleryGroupItem4})
			Me.radGalleryGroupFilter4.Name = "radGalleryGroupFilter4"
			Me.radGalleryGroupFilter4.Text = "Greek Letters"
			' 
			' radGalleryGroupItem3
			' 
			Me.radGalleryGroupItem3.Name = "radGalleryGroupItem3"
			Me.radGalleryGroupItem3.Text = "Lowercase"
			' 
			' radGalleryGroupItem4
			' 
			Me.radGalleryGroupItem4.Name = "radGalleryGroupItem4"
			Me.radGalleryGroupItem4.Text = "Uppercase"
			' 
			' radRibbonBar1
			' 
			Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarCommandTab1})
			' 
			' 
			' 
			Me.radRibbonBar1.ExitButton.Alignment = ContentAlignment.TopRight
			Me.radRibbonBar1.ExitButton.CanFocus = True
			Me.radRibbonBar1.ExitButton.Image = My.Resources.exitButton
			Me.radRibbonBar1.ExitButton.Text = "Exit"
			Me.radRibbonBar1.ExitButton.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.ExitButton.ZIndex = 2
			Me.radRibbonBar1.ImageList = Me.imageList1
			Me.radRibbonBar1.Location = New Point(0, 0)
			Me.radRibbonBar1.Name = "radRibbonBar1"
			' 
			' 
			' 
			Me.radRibbonBar1.OptionsButton.Alignment = ContentAlignment.TopRight
			Me.radRibbonBar1.OptionsButton.CanFocus = True
			Me.radRibbonBar1.OptionsButton.Image = My.Resources.optionsButton
			Me.radRibbonBar1.OptionsButton.Text = "Options"
			Me.radRibbonBar1.OptionsButton.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.OptionsButton.ZIndex = 2
			Me.radRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement41, Me.radButtonElement42})
			' 
			' 
			' 
			Me.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radRibbonBar1.Size = New Size(942, 167)
			Me.radRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
			Me.radRibbonBar1.StartMenuRightColumnItems.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem6, Me.radMenuItem7, Me.radMenuItem8})
			Me.radRibbonBar1.TabIndex = 1
			Me.radRibbonBar1.Text = "RadRibbonBar"
			CType(Me.radRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "RadRibbonBar"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			Me.imageList1.Images.SetKeyName(8, "")
			Me.imageList1.Images.SetKeyName(9, "")
			Me.imageList1.Images.SetKeyName(10, "")
			Me.imageList1.Images.SetKeyName(11, "")
			Me.imageList1.Images.SetKeyName(12, "")
			Me.imageList1.Images.SetKeyName(13, "")
			Me.imageList1.Images.SetKeyName(14, "")
			Me.imageList1.Images.SetKeyName(15, "")
			Me.imageList1.Images.SetKeyName(16, "")
			Me.imageList1.Images.SetKeyName(17, "")
			Me.imageList1.Images.SetKeyName(18, "")
			Me.imageList1.Images.SetKeyName(19, "")
			Me.imageList1.Images.SetKeyName(20, "")
			Me.imageList1.Images.SetKeyName(21, "")
			Me.imageList1.Images.SetKeyName(22, "")
			Me.imageList1.Images.SetKeyName(23, "")
			Me.imageList1.Images.SetKeyName(24, "")
			Me.imageList1.Images.SetKeyName(25, "")
			Me.imageList1.Images.SetKeyName(26, "")
			Me.imageList1.Images.SetKeyName(27, "")
			Me.imageList1.Images.SetKeyName(28, "")
			Me.imageList1.Images.SetKeyName(29, "")
			Me.imageList1.Images.SetKeyName(30, "")
			Me.imageList1.Images.SetKeyName(31, "")
			Me.imageList1.Images.SetKeyName(32, "")
			Me.imageList1.Images.SetKeyName(33, "pageLayout.gif")
			Me.imageList1.Images.SetKeyName(34, "insert5.gif")
			Me.imageList1.Images.SetKeyName(35, "insert6.gif")
			Me.imageList1.Images.SetKeyName(36, "insert.gif")
			Me.imageList1.Images.SetKeyName(37, "pageLayout1.gif")
			Me.imageList1.Images.SetKeyName(38, "pageLayout2.gif")
			Me.imageList1.Images.SetKeyName(39, "pageLayout3.gif")
			Me.imageList1.Images.SetKeyName(40, "pageLayout4.gif")
			Me.imageList1.Images.SetKeyName(41, "Eraser.gif")
			Me.imageList1.Images.SetKeyName(42, "Letter_down.gif")
			Me.imageList1.Images.SetKeyName(43, "Letter_up.gif")
			Me.imageList1.Images.SetKeyName(44, "small1.GIF")
			Me.imageList1.Images.SetKeyName(45, "small2.GIF")
			Me.imageList1.Images.SetKeyName(46, "small3.GIF")
			Me.imageList1.Images.SetKeyName(47, "small4.GIF")
			Me.imageList1.Images.SetKeyName(48, "small5.GIF")
			Me.imageList1.Images.SetKeyName(49, "small6.gif")
			Me.imageList1.Images.SetKeyName(50, "small7.gif")
			Me.imageList1.Images.SetKeyName(51, "small8.gif")
			Me.imageList1.Images.SetKeyName(52, "small9.gif")
			Me.imageList1.Images.SetKeyName(53, "small10.gif")
			Me.imageList1.Images.SetKeyName(54, "small11.gif")
			Me.imageList1.Images.SetKeyName(55, "small12.gif")
			Me.imageList1.Images.SetKeyName(56, "small13.gif")
			Me.imageList1.Images.SetKeyName(57, "small14.gif")
			Me.imageList1.Images.SetKeyName(58, "small15.gif")
			Me.imageList1.Images.SetKeyName(59, "small16.gif")
			Me.imageList1.Images.SetKeyName(60, "small17.gif")
			Me.imageList1.Images.SetKeyName(61, "small18.gif")
			Me.imageList1.Images.SetKeyName(62, "small19.gif")
			Me.imageList1.Images.SetKeyName(63, "small20.gif")
			Me.imageList1.Images.SetKeyName(64, "small21.gif")
			Me.imageList1.Images.SetKeyName(65, "small22.gif")
			Me.imageList1.Images.SetKeyName(66, "small23.gif")
			Me.imageList1.Images.SetKeyName(67, "small24.gif")
			Me.imageList1.Images.SetKeyName(68, "small25.gif")
			Me.imageList1.Images.SetKeyName(69, "small26.gif")
			Me.imageList1.Images.SetKeyName(70, "small27.gif")
			Me.imageList1.Images.SetKeyName(71, "small28.gif")
			Me.imageList1.Images.SetKeyName(72, "small29.gif")
			Me.imageList1.Images.SetKeyName(73, "small30.gif")
			Me.imageList1.Images.SetKeyName(74, "big1.gif")
			Me.imageList1.Images.SetKeyName(75, "big2.gif")
			Me.imageList1.Images.SetKeyName(76, "big3.gif")
			Me.imageList1.Images.SetKeyName(77, "big4.gif")
			Me.imageList1.Images.SetKeyName(78, "big5.gif")
			Me.imageList1.Images.SetKeyName(79, "big6.gif")
			Me.imageList1.Images.SetKeyName(80, "big7.gif")
			Me.imageList1.Images.SetKeyName(81, "big8.gif")
			Me.imageList1.Images.SetKeyName(82, "big9.gif")
			Me.imageList1.Images.SetKeyName(83, "big10.gif")
			Me.imageList1.Images.SetKeyName(84, "big11.gif")
			Me.imageList1.Images.SetKeyName(85, "big12.gif")
			Me.imageList1.Images.SetKeyName(86, "big13.gif")
			Me.imageList1.Images.SetKeyName(87, "big14.gif")
			Me.imageList1.Images.SetKeyName(88, "big15.gif")
			Me.imageList1.Images.SetKeyName(89, "big16.gif")
			Me.imageList1.Images.SetKeyName(90, "big17.gif")
			Me.imageList1.Images.SetKeyName(91, "big18.gif")
			Me.imageList1.Images.SetKeyName(92, "big19.gif")
			Me.imageList1.Images.SetKeyName(93, "big20.gif")
			Me.imageList1.Images.SetKeyName(94, "big21.gif")
			Me.imageList1.Images.SetKeyName(95, "big22.gif")
			Me.imageList1.Images.SetKeyName(96, "big23.gif")
			Me.imageList1.Images.SetKeyName(97, "big24.gif")
			' 
			' radButtonElement41
			' 
			Me.radButtonElement41.Alignment = ContentAlignment.MiddleCenter
			Me.radButtonElement41.CanFocus = True
			Me.radButtonElement41.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement41.Image = My.Resources.msIcon1
			Me.radButtonElement41.MaxSize = New Size(0, 18)
			Me.radButtonElement41.Name = "radButtonElement41"
			Me.radButtonElement41.Padding = New Padding(2, 1, 2, 2)
			Me.radButtonElement41.StretchHorizontally = False
			Me.radButtonElement41.StretchVertically = False
			Me.radButtonElement41.Text = "New"
			Me.radButtonElement41.ZIndex = 1
			' 
			' radButtonElement42
			' 
			Me.radButtonElement42.Alignment = ContentAlignment.MiddleCenter
			Me.radButtonElement42.CanFocus = True
			Me.radButtonElement42.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement42.Image = My.Resources.msIcon3
			Me.radButtonElement42.MaxSize = New Size(0, 18)
			Me.radButtonElement42.Name = "radButtonElement42"
			Me.radButtonElement42.Padding = New Padding(2, 1, 2, 2)
			Me.radButtonElement42.StretchHorizontally = False
			Me.radButtonElement42.StretchVertically = False
			Me.radButtonElement42.Text = "Save"
			Me.radButtonElement42.ZIndex = 0
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Image = My.Resources.RibbonMenuNewMagenta
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "New"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Image = My.Resources.RibbonMenuOpenMagenta
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Open"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Image = My.Resources.RibbonMenuSaveAsMagenta
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Save As"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.Enabled = False
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Recent Documents"
			Me.radMenuItem6.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Document1"
			Me.radMenuItem7.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Document2"
			Me.radMenuItem8.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.FromArgb((CInt((CByte(217)))), (CInt((CByte(224)))), (CInt((CByte(237)))))
			Me.ClientSize = New Size(942, 667)
			Me.Controls.Add(Me.radRibbonBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadRibbonBar"
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub



		#End Region

		Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
		Private radRibbonBarChunk2 As RadRibbonBarGroup
		Private imageList1 As ImageList
		Private radMenuItem1 As RadMenuItem
		Private radMenuItem2 As RadMenuItem
		Private radMenuItem3 As RadMenuItem
		Private radMenuItem6 As RadMenuItem
		Private radMenuItem7 As RadMenuItem
		Private radMenuItem8 As RadMenuItem
		Private radButtonElement29 As RadButtonElement
		Private radButtonElement5 As RadButtonElement
		Private radButtonElement41 As RadButtonElement
		Private radButtonElement42 As RadButtonElement
		Private radOffice2007ScreenTip1 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip2 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip3 As RadOffice2007ScreenTip
		Private radOffice2007ScreenTip4 As RadOffice2007ScreenTip
		Private radGalleryGroupItem1 As RadGalleryGroupItem
		Private radGalleryGroupItem2 As RadGalleryGroupItem
		Private radMenuItem12 As RadMenuItem
		Private radMenuItem13 As RadMenuItem
		Private radMenuItem14 As RadMenuItem
		Private radGalleryGroupFilter1 As RadGalleryGroupFilter
		Private radGalleryGroupFilter2 As RadGalleryGroupFilter
		Private radGalleryGroupFilter3 As RadGalleryGroupFilter
		Private radGalleryGroupFilter4 As RadGalleryGroupFilter
		Private radGalleryGroupItem3 As RadGalleryGroupItem
		Private radGalleryGroupItem4 As RadGalleryGroupItem
		Private radRibbonBarCommandTab1 As RibbonTab
		Private radRibbonBarGroup1 As RadRibbonBarGroup
		Private radButtonElement1 As RadButtonElement
		Private radButtonElement2 As RadButtonElement
		Private radButtonElement3 As RadButtonElement
	End Class
End Namespace