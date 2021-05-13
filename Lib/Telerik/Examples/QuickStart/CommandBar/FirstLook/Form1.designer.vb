Namespace Telerik.Examples.WinControls.CommandBar.FirstLook
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem4 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem25 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem26 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem27 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem28 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem29 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem30 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem31 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem32 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem33 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.radCommandBarLineElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radCommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radCommandBarButtonItem1 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem2 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem3 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarButtonItem4 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarDropDownListItem1 = New Telerik.WinControls.UI.CommandBarDropDownList()
			Me.radCommandBarButtonItem5 = New Telerik.WinControls.UI.CommandBarButton()
			Me.radCommandBarSeparatorItem2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCommandBarTextBoxItem1 = New Telerik.WinControls.UI.CommandBarTextBox()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.webBrowser1 = New WebBrowser()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMenu1
			' 
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5, Me.radMenuItem6})
			Me.radMenu1.Location = New Point(0, 0)
			Me.radMenu1.Name = "radMenu1"
			Me.radMenu1.Size = New Size(874, 20)
			Me.radMenu1.TabIndex = 0
			Me.radMenu1.Text = "radMenu1"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "File"
			Me.radMenuItem1.AccessibleName = "File"
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem7, Me.radMenuItem8, Me.radMenuItem9, Me.radMenuSeparatorItem1, Me.radMenuItem10, Me.radMenuItem11, Me.radMenuItem12, Me.radMenuSeparatorItem2, Me.radMenuItem13, Me.radMenuItem14})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "File"
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "Open"
			Me.radMenuItem7.AccessibleName = "Open"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "Open"
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "Edit"
			Me.radMenuItem8.AccessibleName = "Edit"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "Edit"
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "Save"
			Me.radMenuItem9.AccessibleName = "Save"
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "Save"
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.AccessibleDescription = "Page Setup..."
			Me.radMenuItem10.AccessibleName = "Page Setup..."
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "Page Setup..."
			Me.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem11
			' 
			Me.radMenuItem11.AccessibleDescription = "Print..."
			Me.radMenuItem11.AccessibleName = "Print..."
			Me.radMenuItem11.Name = "radMenuItem11"
			Me.radMenuItem11.Text = "Print..."
			Me.radMenuItem11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.AccessibleDescription = "Print Preview..."
			Me.radMenuItem12.AccessibleName = "Print Preview..."
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Text = "Print Preview..."
			Me.radMenuItem12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.AccessibleDescription = "Work Offline"
			Me.radMenuItem13.AccessibleName = "Work Offline"
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "Work Offline"
			Me.radMenuItem13.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem14
			' 
			Me.radMenuItem14.AccessibleDescription = "Exit"
			Me.radMenuItem14.AccessibleName = "Exit"
			Me.radMenuItem14.Name = "radMenuItem14"
			Me.radMenuItem14.Text = "Exit"
			Me.radMenuItem14.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Edit"
			Me.radMenuItem2.AccessibleName = "Edit"
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem15, Me.radMenuItem16, Me.radMenuItem17, Me.radMenuSeparatorItem3, Me.radMenuItem18, Me.radMenuSeparatorItem4, Me.radMenuItem19})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Edit"
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem15
			' 
			Me.radMenuItem15.AccessibleDescription = "Copy"
			Me.radMenuItem15.AccessibleName = "Copy"
			Me.radMenuItem15.Name = "radMenuItem15"
			Me.radMenuItem15.Text = "Copy"
			Me.radMenuItem15.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.AccessibleDescription = "Cut"
			Me.radMenuItem16.AccessibleName = "Cut"
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Cut"
			Me.radMenuItem16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.AccessibleDescription = "Paste"
			Me.radMenuItem17.AccessibleName = "Paste"
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Paste"
			Me.radMenuItem17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.AccessibleDescription = "Select All"
			Me.radMenuItem18.AccessibleName = "Select All"
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Select All"
			Me.radMenuItem18.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem4
			' 
			Me.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4"
			Me.radMenuSeparatorItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.AccessibleDescription = "Find..."
			Me.radMenuItem19.AccessibleName = "Find..."
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Find..."
			Me.radMenuItem19.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "View"
			Me.radMenuItem3.AccessibleName = "View"
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem25, Me.radMenuItem26, Me.radMenuItem27, Me.radMenuItem28, Me.radMenuItem29})
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "View"
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem25
			' 
			Me.radMenuItem25.AccessibleDescription = "Zoom"
			Me.radMenuItem25.AccessibleName = "Zoom"
			Me.radMenuItem25.Name = "radMenuItem25"
			Me.radMenuItem25.Text = "Zoom"
			Me.radMenuItem25.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem26
			' 
			Me.radMenuItem26.AccessibleDescription = "Font"
			Me.radMenuItem26.AccessibleName = "Font"
			Me.radMenuItem26.Name = "radMenuItem26"
			Me.radMenuItem26.Text = "Font"
			Me.radMenuItem26.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem27
			' 
			Me.radMenuItem27.AccessibleDescription = "Style"
			Me.radMenuItem27.AccessibleName = "Style"
			Me.radMenuItem27.Name = "radMenuItem27"
			Me.radMenuItem27.Text = "Style"
			Me.radMenuItem27.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem28
			' 
			Me.radMenuItem28.AccessibleDescription = "Encoding"
			Me.radMenuItem28.AccessibleName = "Encoding"
			Me.radMenuItem28.Name = "radMenuItem28"
			Me.radMenuItem28.Text = "Encoding"
			Me.radMenuItem28.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem29
			' 
			Me.radMenuItem29.AccessibleDescription = "Source"
			Me.radMenuItem29.AccessibleName = "Source"
			Me.radMenuItem29.Name = "radMenuItem29"
			Me.radMenuItem29.Text = "Source"
			Me.radMenuItem29.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Favourites"
			Me.radMenuItem4.AccessibleName = "Favourites"
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem30, Me.radMenuItem31, Me.radMenuItem32, Me.radMenuSeparatorItem5, Me.radMenuItem33})
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Favourites"
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem30
			' 
			Me.radMenuItem30.AccessibleDescription = "Telerik UI for WinForms"
			Me.radMenuItem30.AccessibleName = "Telerik UI for WinForms"
			Me.radMenuItem30.Name = "radMenuItem30"
			Me.radMenuItem30.Text = "Telerik UI for WinForms"
			Me.radMenuItem30.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem31
			' 
			Me.radMenuItem31.AccessibleDescription = "Telerik Help"
			Me.radMenuItem31.AccessibleName = "Telerik Help"
			Me.radMenuItem31.Name = "radMenuItem31"
			Me.radMenuItem31.Text = "Telerik Help"
			Me.radMenuItem31.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem32
			' 
			Me.radMenuItem32.AccessibleDescription = "Telerik Community"
			Me.radMenuItem32.AccessibleName = "Telerik Community"
			Me.radMenuItem32.Name = "radMenuItem32"
			Me.radMenuItem32.Text = "Telerik Community"
			Me.radMenuItem32.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem33
			' 
			Me.radMenuItem33.AccessibleDescription = "Organize Favourites"
			Me.radMenuItem33.AccessibleName = "Organize Favourites"
			Me.radMenuItem33.Name = "radMenuItem33"
			Me.radMenuItem33.Text = "Organize Favourites"
			Me.radMenuItem33.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "Tools"
			Me.radMenuItem5.AccessibleName = "Tools"
			Me.radMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem22, Me.radMenuItem23, Me.radMenuItem24})
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "Tools"
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.AccessibleDescription = "History"
			Me.radMenuItem22.AccessibleName = "History"
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Text = "History"
			Me.radMenuItem22.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.AccessibleDescription = "Updates"
			Me.radMenuItem23.AccessibleName = "Updates"
			Me.radMenuItem23.Name = "radMenuItem23"
			Me.radMenuItem23.Text = "Updates"
			Me.radMenuItem23.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.AccessibleDescription = "Internet Options"
			Me.radMenuItem24.AccessibleName = "Internet Options"
			Me.radMenuItem24.Name = "radMenuItem24"
			Me.radMenuItem24.Text = "Internet Options"
			Me.radMenuItem24.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.AccessibleDescription = "Help"
			Me.radMenuItem6.AccessibleName = "Help"
			Me.radMenuItem6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem20, Me.radMenuItem21})
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "Help"
			Me.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.AccessibleDescription = "Online Help"
			Me.radMenuItem20.AccessibleName = "Online Help"
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Online Help"
			Me.radMenuItem20.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.AccessibleDescription = "About Telerik"
			Me.radMenuItem21.AccessibleName = "About Telerik"
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "About Telerik"
			Me.radMenuItem21.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.AutoSize = True
			Me.radCommandBar1.Dock = DockStyle.Top
			Me.radCommandBar1.Location = New Point(0, 20)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.radCommandBarLineElement1})
			Me.radCommandBar1.Size = New Size(874, 59)
			Me.radCommandBar1.TabIndex = 1
			Me.radCommandBar1.Text = "radCommandBar1"
			' 
			' radCommandBarLineElement1
			' 
			Me.radCommandBarLineElement1.DisplayName = Nothing
			Me.radCommandBarLineElement1.MinSize = New Size(25, 25)
			Me.radCommandBarLineElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radCommandBarStripElement1})
			' 
			' radCommandBarStripElement1
			' 
			Me.radCommandBarStripElement1.DisplayName = "Main Tool Strip"
			Me.radCommandBarStripElement1.FloatingForm = Nothing
			Me.radCommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radCommandBarButtonItem1, Me.radCommandBarButtonItem2, Me.radCommandBarButtonItem3, Me.radCommandBarButtonItem4, Me.radCommandBarSeparatorItem1, Me.radCommandBarDropDownListItem1, Me.radCommandBarButtonItem5, Me.radCommandBarSeparatorItem2, Me.radCommandBarTextBoxItem1})
			Me.radCommandBarStripElement1.Name = "radCommandBarStripElement1"
			Me.radCommandBarStripElement1.StretchHorizontally = True
			Me.radCommandBarStripElement1.Text = ""
			' 
			' radCommandBarButtonItem1
			' 
			Me.radCommandBarButtonItem1.AccessibleDescription = "Back"
			Me.radCommandBarButtonItem1.AccessibleName = "Back"
			Me.radCommandBarButtonItem1.DisplayName = "Back Button"
			Me.radCommandBarButtonItem1.DrawBorder = False
			Me.radCommandBarButtonItem1.DrawFill = False
			Me.radCommandBarButtonItem1.Image = (CType(resources.GetObject("radCommandBarButtonItem1.Image"), Image))
			Me.radCommandBarButtonItem1.Name = "radCommandBarButtonItem1"
			Me.radCommandBarButtonItem1.Text = "Back"
			Me.radCommandBarButtonItem1.ToolTipText = "Back"
			Me.radCommandBarButtonItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem1.VisibleInOverflowMenu = True

			' 
			' radCommandBarButtonItem2
			' 
			Me.radCommandBarButtonItem2.AccessibleDescription = "Forward"
			Me.radCommandBarButtonItem2.AccessibleName = "Forward"
			Me.radCommandBarButtonItem2.DisplayName = "Forward Button"
			Me.radCommandBarButtonItem2.DrawBorder = False
			Me.radCommandBarButtonItem2.DrawFill = False
			Me.radCommandBarButtonItem2.Image = (CType(resources.GetObject("radCommandBarButtonItem2.Image"), Image))
			Me.radCommandBarButtonItem2.Margin = New Padding(-1, 0, 0, 0)
			Me.radCommandBarButtonItem2.Name = "radCommandBarButtonItem2"
			Me.radCommandBarButtonItem2.Padding = New Padding(0)
			Me.radCommandBarButtonItem2.Text = "Forward"
			Me.radCommandBarButtonItem2.ToolTipText = "Forward"
			Me.radCommandBarButtonItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem2.VisibleInOverflowMenu = True

			' 
			' radCommandBarButtonItem3
			' 
			Me.radCommandBarButtonItem3.AccessibleDescription = "Refresh"
			Me.radCommandBarButtonItem3.AccessibleName = "Refresh"
			Me.radCommandBarButtonItem3.DisplayName = "Refresh Button"
			Me.radCommandBarButtonItem3.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.refresh3
			Me.radCommandBarButtonItem3.Name = "radCommandBarButtonItem3"
			Me.radCommandBarButtonItem3.Text = "Refresh"
			Me.radCommandBarButtonItem3.ToolTipText = "Refresh"
			Me.radCommandBarButtonItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem3.VisibleInOverflowMenu = True

			' 
			' radCommandBarButtonItem4
			' 
			Me.radCommandBarButtonItem4.AccessibleDescription = "Stop"
			Me.radCommandBarButtonItem4.AccessibleName = "Stop"
			Me.radCommandBarButtonItem4.DisplayName = "Stop Button"
			Me.radCommandBarButtonItem4.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.stop
			Me.radCommandBarButtonItem4.Name = "radCommandBarButtonItem4"
			Me.radCommandBarButtonItem4.ShouldPaint = True
			Me.radCommandBarButtonItem4.Text = "Stop"
			Me.radCommandBarButtonItem4.ToolTipText = "Stop"
			Me.radCommandBarButtonItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem4.VisibleInOverflowMenu = True

			' 
			' radCommandBarSeparatorItem1
			' 
			Me.radCommandBarSeparatorItem1.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem1.Name = "radCommandBarSeparatorItem1"
			Me.radCommandBarSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem1.VisibleInOverflowMenu = False
			' 
			' radCommandBarDropDownListItem1
			' 
			Me.radCommandBarDropDownListItem1.DisplayName = "URL Field"
			Me.radCommandBarDropDownListItem1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radCommandBarDropDownListItem1.MaxSize = New Size(0, 0)
			Me.radCommandBarDropDownListItem1.Name = "radCommandBarDropDownListItem1"
			Me.radCommandBarDropDownListItem1.NullText = "Enter URL"
			Me.radCommandBarDropDownListItem1.StretchHorizontally = True
			Me.radCommandBarDropDownListItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarDropDownListItem1.VisibleInOverflowMenu = True

			' 
			' radCommandBarButtonItem5
			' 
			Me.radCommandBarButtonItem5.AccessibleDescription = "Go"
			Me.radCommandBarButtonItem5.AccessibleName = "Go"
			Me.radCommandBarButtonItem5.DisplayName = "GO Button"
			Me.radCommandBarButtonItem5.Image = Global.Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.go
			Me.radCommandBarButtonItem5.Name = "radCommandBarButtonItem5"
			Me.radCommandBarButtonItem5.Text = "Go"
			Me.radCommandBarButtonItem5.ToolTipText = "Go"
			Me.radCommandBarButtonItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarButtonItem5.VisibleInOverflowMenu = True

			' 
			' radCommandBarSeparatorItem2
			' 
			Me.radCommandBarSeparatorItem2.DisplayName = "Separator"
			Me.radCommandBarSeparatorItem2.Name = "radCommandBarSeparatorItem2"
			Me.radCommandBarSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarSeparatorItem2.VisibleInOverflowMenu = False
			' 
			' radCommandBarTextBoxItem1
			' 
			Me.radCommandBarTextBoxItem1.DisplayName = "Search Field"
			Me.radCommandBarTextBoxItem1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radCommandBarTextBoxItem1.MinSize = New Size(180, 0)
			Me.radCommandBarTextBoxItem1.Name = "radCommandBarTextBoxItem1"
			Me.radCommandBarTextBoxItem1.StretchVertically = False
			Me.radCommandBarTextBoxItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radCommandBarTextBoxItem1.VisibleInOverflowMenu = True
			CType(Me.radCommandBarTextBoxItem1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Search"
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Dock = DockStyle.Fill
			Me.radPageView1.Location = New Point(0, 79)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New Size(874, 371)
			Me.radPageView1.TabIndex = 2
			Me.radPageView1.Text = "radPageView1"

			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = True
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.webBrowser1)
			Me.radPageViewPage1.Location = New Point(10, 37)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(853, 323)
			Me.radPageViewPage1.Text = "blank"
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = DockStyle.Fill
			Me.webBrowser1.Location = New Point(0, 0)
			Me.webBrowser1.MinimumSize = New Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New Size(853, 323)
			Me.webBrowser1.TabIndex = 0

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(874, 450)
			Me.Controls.Add(Me.radPageView1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Controls.Add(Me.radMenu1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Telerik Explorer"
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region


		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private radCommandBarLineElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private radCommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radCommandBarButtonItem1 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem2 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem3 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarButtonItem4 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarDropDownListItem1 As Telerik.WinControls.UI.CommandBarDropDownList
		Private radCommandBarButtonItem5 As Telerik.WinControls.UI.CommandBarButton
		Private radCommandBarSeparatorItem2 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCommandBarTextBoxItem1 As Telerik.WinControls.UI.CommandBarTextBox
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private webBrowser1 As WebBrowser
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem4 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem21 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem23 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem24 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem25 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem26 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem27 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem28 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem29 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem30 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem31 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem32 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem33 As Telerik.WinControls.UI.RadMenuItem

	End Class
End Namespace

