Namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
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
			Dim inputBinding5 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord5 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier5 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand4 As New Telerik.WinControls.Elements.ClickCommand()
			Dim inputBinding6 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord6 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier6 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand5 As New Telerik.WinControls.Elements.ClickCommand()
			Dim inputBinding7 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord7 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier7 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim inputBinding8 As New Telerik.WinControls.Keyboard.InputBinding()
			Dim chord8 As New Telerik.WinControls.Keyboard.Chord()
			Dim chordModifier8 As New Telerik.WinControls.Keyboard.ChordModifier()
			Dim clickCommand6 As New Telerik.WinControls.Elements.ClickCommand()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource3 As New Telerik.WinControls.ThemeSource()
			Dim themeSource4 As New Telerik.WinControls.ThemeSource()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.imageList1 = New ImageList(Me.components)
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem23 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem6 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem24 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem7 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuPrint = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem41 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuEmail = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem60 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuBurn = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem70 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem71 = New Telerik.WinControls.UI.RadMenuItem()
			Me.menuOpenWidth = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem72 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem73 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem74 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem81 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem76 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem77 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem78 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem79 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem80 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem66 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem67 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem68 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem69 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem34 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem35 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem36 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem48 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem49 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem50 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem51 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem52 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem53 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem54 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radPanelDemo = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemo.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(821, 1)
			Me.settingsPanel.Size = New Size(200, 705)
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.AccessibleDescription = "Add Folder to Gallery…"
			Me.radMenuItem17.AccessibleName = "Add Folder to Gallery…"
			Me.radMenuItem17.ImageKey = "1_undo.gif"
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Text = "Add Folder to Gallery…"
			Me.radMenuItem17.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem17.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem18
			' 
			Me.radMenuItem18.AccessibleDescription = "Import from Camera or Scanner…"
			Me.radMenuItem18.AccessibleName = "Import from Camera or Scanner…"
			Me.radMenuItem18.ImageKey = "2_redo.gif"
			Me.radMenuItem18.Name = "radMenuItem18"
			Me.radMenuItem18.Text = "Import from Camera or Scanner…"
			Me.radMenuItem18.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem18.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.AccessibleDescription = "Copy"
			Me.radMenuItem22.AccessibleName = "Copy"
			Me.radMenuItem22.HintText = "Ctrl+C"
			Me.radMenuItem22.ImageKey = "6_Find.gif"
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Text = "Copy"
			Me.radMenuItem22.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem22.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem20
			' 
			Me.radMenuItem20.AccessibleDescription = "Rename"
			Me.radMenuItem20.AccessibleName = "Rename"
			Me.radMenuItem20.HintText = "Ctrl+M"
			Me.radMenuItem20.ImageKey = "4_Copy.gif"
			Me.radMenuItem20.Name = "radMenuItem20"
			Me.radMenuItem20.Text = "Rename"
			Me.radMenuItem20.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem20.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.AccessibleDescription = "New"
			Me.radMenuItem1_1.AccessibleName = "New"
			Me.radMenuItem1_1.HintText = "Ctrl+N"
			Me.radMenuItem1_1.ImageKey = "1_New.gif"
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.Text = "New"
			Me.radMenuItem1_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenu1
			' 
			Me.radMenu1.AllItemsEqualHeight = True
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = Color.Transparent
			chordModifier5.AltModifier = False
			chordModifier5.ControlModifier = True
			chordModifier5.ShiftModifier = False
			chord5.ChordModifier = chordModifier5
			chord5.Keys = "Ctrl+Z"
			inputBinding5.Chord = chord5
			clickCommand4.ContextType = Nothing
			clickCommand4.ImageList = Nothing
			clickCommand4.Name = "ActionCommand"
			clickCommand4.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand4.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand4.Type = ""
			inputBinding5.Command = clickCommand4
			inputBinding5.CommandContext = Me.radMenuItem17
			chordModifier6.AltModifier = False
			chordModifier6.ControlModifier = True
			chordModifier6.ShiftModifier = False
			chord6.ChordModifier = chordModifier6
			chord6.Keys = "Ctrl+Y"
			inputBinding6.Chord = chord6
			clickCommand5.ContextType = Nothing
			clickCommand5.ImageList = Nothing
			clickCommand5.Name = "ActionCommand"
			clickCommand5.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand5.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand5.Type = ""
			inputBinding6.Command = clickCommand5
			inputBinding6.CommandContext = Me.radMenuItem18
			chordModifier7.AltModifier = False
			chordModifier7.ControlModifier = True
			chordModifier7.ShiftModifier = False
			chord7.ChordModifier = chordModifier7
			chord7.Keys = "Ctrl+F"
			inputBinding7.Chord = chord7
			inputBinding7.Command = clickCommand5
			inputBinding7.CommandContext = Me.radMenuItem22
			chordModifier8.AltModifier = False
			chordModifier8.ControlModifier = True
			chordModifier8.ShiftModifier = False
			chord8.ChordModifier = chordModifier8
			chord8.Keys = "Ctrl+M"
			inputBinding8.Chord = chord8
			clickCommand6.ContextType = Nothing
			clickCommand6.ImageList = Nothing
			clickCommand6.Name = "ActionCommand"
			clickCommand6.OwnerType = GetType(Telerik.WinControls.RadItem)
			clickCommand6.Text = "This command rises the Click event of a selected RadItem instance."
			clickCommand6.Type = ""
			inputBinding8.Command = clickCommand6
			inputBinding8.CommandContext = Me.radMenuItem20
			Me.radMenu1.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() { inputBinding5, inputBinding6, inputBinding7, inputBinding8})
			Me.radMenu1.Dock = DockStyle.None
			Me.radMenu1.ImageList = Me.imageList1
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem9, Me.menuPrint, Me.menuEmail, Me.menuBurn, Me.menuOpenWidth, Me.radMenuItem16})
			Me.radMenu1.Location = New Point(38, 28)
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.Size = New Size(640, 26)
			Me.radMenu1.TabIndex = 0
			Me.radMenu1.Text = "radMenu1"
			CType(Me.radMenu1.GetChildAt(0), Telerik.WinControls.UI.RadMenuElement).AllItemsEqualHeight = True
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Lime
			Me.imageList1.Images.SetKeyName(0, "burner.png")
			Me.imageList1.Images.SetKeyName(1, "Email.png")
			Me.imageList1.Images.SetKeyName(2, "help.png")
			Me.imageList1.Images.SetKeyName(3, "New.png")
			Me.imageList1.Images.SetKeyName(4, "Open.png")
			Me.imageList1.Images.SetKeyName(5, "Print.png")
			Me.imageList1.Images.SetKeyName(6, "Order_prints.png")
			Me.imageList1.Images.SetKeyName(7, "paint.png")
			Me.imageList1.Images.SetKeyName(8, "Picture_Manager.png")
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.AccessibleDescription = "File"
			Me.radMenuItem9.AccessibleName = "File"
			Me.radMenuItem9.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem9.Image = (CType(resources.GetObject("radMenuItem9.Image"), Image))
			Me.radMenuItem9.ImageIndex = 3
			Me.radMenuItem9.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem17, Me.radMenuItem18, Me.radMenuSeparatorItem1, Me.radMenuItem19, Me.radMenuItem20, Me.radMenuSeparatorItem2, Me.radMenuItem22, Me.radMenuSeparatorItem5, Me.radMenuItem23, Me.radMenuSeparatorItem6, Me.radMenuItem24, Me.radMenuSeparatorItem7, Me.radMenuItem1, Me.radMenuItem2, Me.radMenuSeparatorItem8, Me.radMenuItem3})
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "File"
			Me.radMenuItem9.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem19
			' 
			Me.radMenuItem19.AccessibleDescription = "Delete"
			Me.radMenuItem19.AccessibleName = "Delete"
			Me.radMenuItem19.HintText = "Del"
			Me.radMenuItem19.ImageKey = "3_Cut.gif"
			Me.radMenuItem19.Name = "radMenuItem19"
			Me.radMenuItem19.Text = "Delete"
			Me.radMenuItem19.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem19.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AccessibleDescription = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.AccessibleName = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.AccessibleDescription = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.AccessibleName = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Text = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem23
			' 
			Me.radMenuItem23.AccessibleDescription = "Select All"
			Me.radMenuItem23.AccessibleName = "Select All"
			Me.radMenuItem23.HintText = "Ctrl+A"
			Me.radMenuItem23.Name = "radMenuItem23"
			Me.radMenuItem23.Text = "Select All"
			Me.radMenuItem23.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem23.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem6
			' 
			Me.radMenuSeparatorItem6.AccessibleDescription = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.AccessibleName = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.Name = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.Text = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem24
			' 
			Me.radMenuItem24.AccessibleDescription = "Share With Devices…"
			Me.radMenuItem24.AccessibleName = "Share With Devices…"
			Me.radMenuItem24.Name = "radMenuItem24"
			Me.radMenuItem24.Text = "Share With Devices…"
			Me.radMenuItem24.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem24.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem7
			' 
			Me.radMenuSeparatorItem7.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem7.AccessibleName = "New item"
			Me.radMenuSeparatorItem7.Name = "radMenuSeparatorItem7"
			Me.radMenuSeparatorItem7.Text = "New item"
			Me.radMenuSeparatorItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "Properties"
			Me.radMenuItem1.AccessibleName = "Properties"
			Me.radMenuItem1.HintText = "Alt+Enter"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Properties"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Options"
			Me.radMenuItem2.AccessibleName = "Options"
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Options"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem8
			' 
			Me.radMenuSeparatorItem8.AccessibleDescription = "New item"
			Me.radMenuSeparatorItem8.AccessibleName = "New item"
			Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.Text = "New item"
			Me.radMenuSeparatorItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Exit"
			Me.radMenuItem3.AccessibleName = "Exit"
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Exit"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' menuPrint
			' 
			Me.menuPrint.AccessibleDescription = "Print"
			Me.menuPrint.AccessibleName = "Print"
			Me.menuPrint.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuPrint.Enabled = False
			Me.menuPrint.Image = (CType(resources.GetObject("menuPrint.Image"), Image))
			Me.menuPrint.ImageIndex = 5
			Me.menuPrint.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem41, Me.radMenuItem4})
			Me.menuPrint.Name = "menuPrint"
			Me.menuPrint.Text = "Print"
			Me.menuPrint.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.menuPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem41
			' 
			Me.radMenuItem41.AccessibleDescription = "Print..."
			Me.radMenuItem41.AccessibleName = "Print..."
			Me.radMenuItem41.Image = (CType(resources.GetObject("radMenuItem41.Image"), Image))
			Me.radMenuItem41.ImageIndex = 5
			Me.radMenuItem41.Name = "radMenuItem41"
			Me.radMenuItem41.Text = "Print..."
			Me.radMenuItem41.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem41.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Order Prints"
			Me.radMenuItem4.AccessibleName = "Order Prints"
			Me.radMenuItem4.Image = (CType(resources.GetObject("radMenuItem4.Image"), Image))
			Me.radMenuItem4.ImageIndex = 6
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Order Prints"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' menuEmail
			' 
			Me.menuEmail.AccessibleDescription = "E-mail"
			Me.menuEmail.AccessibleName = "E-mail"
			Me.menuEmail.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuEmail.Enabled = False
			Me.menuEmail.Image = (CType(resources.GetObject("menuEmail.Image"), Image))
			Me.menuEmail.ImageIndex = 1
			Me.menuEmail.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem60})
			Me.menuEmail.Name = "menuEmail"
			Me.menuEmail.Text = "E-mail"
			Me.menuEmail.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.menuEmail.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem60
			' 
			Me.radMenuItem60.AccessibleDescription = "E-mail selected item"
			Me.radMenuItem60.AccessibleName = "E-mail selected item"
			Me.radMenuItem60.ImageKey = "1_Table-of-contents.gif"
			Me.radMenuItem60.Name = "radMenuItem60"
			Me.radMenuItem60.Text = "E-mail selected item"
			Me.radMenuItem60.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem60.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' menuBurn
			' 
			Me.menuBurn.AccessibleDescription = "Burn"
			Me.menuBurn.AccessibleName = "Burn"
			Me.menuBurn.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuBurn.Enabled = False
			Me.menuBurn.Image = (CType(resources.GetObject("menuBurn.Image"), Image))
			Me.menuBurn.ImageIndex = 0
			Me.menuBurn.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem70, Me.radMenuItem71})
			Me.menuBurn.Name = "menuBurn"
			Me.menuBurn.Text = "Burn"
			Me.menuBurn.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.menuBurn.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem70
			' 
			Me.radMenuItem70.AccessibleDescription = "Data Disc…"
			Me.radMenuItem70.AccessibleName = "Data Disc…"
			Me.radMenuItem70.Name = "radMenuItem70"
			Me.radMenuItem70.Text = "Data Disc…"
			Me.radMenuItem70.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem70.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem71
			' 
			Me.radMenuItem71.AccessibleDescription = "Video DVD…"
			Me.radMenuItem71.AccessibleName = "Video DVD…"
			Me.radMenuItem71.Name = "radMenuItem71"
			Me.radMenuItem71.Text = "Video DVD…"
			Me.radMenuItem71.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem71.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' menuOpenWidth
			' 
			Me.menuOpenWidth.AccessibleDescription = "Open With "
			Me.menuOpenWidth.AccessibleName = "Open With "
			Me.menuOpenWidth.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.menuOpenWidth.Enabled = False
			Me.menuOpenWidth.Image = (CType(resources.GetObject("menuOpenWidth.Image"), Image))
			Me.menuOpenWidth.ImageIndex = 4
			Me.menuOpenWidth.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem72, Me.radMenuItem73, Me.radMenuSeparatorItem3, Me.radMenuItem74})
			Me.menuOpenWidth.Name = "menuOpenWidth"
			Me.menuOpenWidth.Text = "Open With "
			Me.menuOpenWidth.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.menuOpenWidth.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem72
			' 
			Me.radMenuItem72.AccessibleDescription = "Picture Manager"
			Me.radMenuItem72.AccessibleName = "Picture Manager"
			Me.radMenuItem72.Image = (CType(resources.GetObject("radMenuItem72.Image"), Image))
			Me.radMenuItem72.ImageIndex = 8
			Me.radMenuItem72.Name = "radMenuItem72"
			Me.radMenuItem72.Text = "Picture Manager"
			Me.radMenuItem72.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem72.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem73
			' 
			Me.radMenuItem73.AccessibleDescription = "Paint"
			Me.radMenuItem73.AccessibleName = "Paint"
			Me.radMenuItem73.Image = (CType(resources.GetObject("radMenuItem73.Image"), Image))
			Me.radMenuItem73.ImageIndex = 7
			Me.radMenuItem73.Name = "radMenuItem73"
			Me.radMenuItem73.Text = "Paint"
			Me.radMenuItem73.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem73.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.AccessibleDescription = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.AccessibleName = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem74
			' 
			Me.radMenuItem74.AccessibleDescription = "Choose Program…"
			Me.radMenuItem74.AccessibleName = "Choose Program…"
			Me.radMenuItem74.ImageKey = "3_Thesaurus.gif"
			Me.radMenuItem74.Name = "radMenuItem74"
			Me.radMenuItem74.Text = "Choose Program…"
			Me.radMenuItem74.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem74.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem16
			' 
			Me.radMenuItem16.AccessibleDescription = "Help"
			Me.radMenuItem16.AccessibleName = "Help"
			Me.radMenuItem16.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem16.Image = (CType(resources.GetObject("radMenuItem16.Image"), Image))
			Me.radMenuItem16.ImageIndex = 2
			Me.radMenuItem16.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem81})
			Me.radMenuItem16.Name = "radMenuItem16"
			Me.radMenuItem16.Text = "Help"
			Me.radMenuItem16.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem16.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem81
			' 
			Me.radMenuItem81.AccessibleDescription = "About RadMenu"
			Me.radMenuItem81.AccessibleName = "About RadMenu"
			Me.radMenuItem81.Image = (CType(resources.GetObject("radMenuItem81.Image"), Image))
			Me.radMenuItem81.ImageIndex = 2
			Me.radMenuItem81.Name = "radMenuItem81"
			Me.radMenuItem81.Text = "About RadMenu"
			Me.radMenuItem81.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem81.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem76
			' 
			Me.radMenuItem76.AccessibleDescription = "Normal"
			Me.radMenuItem76.AccessibleName = "Normal"
			Me.radMenuItem76.ImageKey = "1_View.gif"
			Me.radMenuItem76.Name = "radMenuItem76"
			Me.radMenuItem76.Text = "Normal"
			Me.radMenuItem76.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem76.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem77
			' 
			Me.radMenuItem77.AccessibleDescription = "Web Layout"
			Me.radMenuItem77.AccessibleName = "Web Layout"
			Me.radMenuItem77.ImageKey = "2_Web.gif"
			Me.radMenuItem77.Name = "radMenuItem77"
			Me.radMenuItem77.Text = "Web Layout"
			Me.radMenuItem77.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem77.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem78
			' 
			Me.radMenuItem78.AccessibleDescription = "Print Layout"
			Me.radMenuItem78.AccessibleName = "Print Layout"
			Me.radMenuItem78.ImageKey = "3_Print-layout.gif"
			Me.radMenuItem78.Name = "radMenuItem78"
			Me.radMenuItem78.Text = "Print Layout"
			Me.radMenuItem78.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem78.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem79
			' 
			Me.radMenuItem79.AccessibleDescription = "Reading Layout"
			Me.radMenuItem79.AccessibleName = "Reading Layout"
			Me.radMenuItem79.ImageKey = "4_Reading-Layout.gif"
			Me.radMenuItem79.Name = "radMenuItem79"
			Me.radMenuItem79.Text = "Reading Layout"
			Me.radMenuItem79.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem79.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem80
			' 
			Me.radMenuItem80.AccessibleDescription = "Outline"
			Me.radMenuItem80.AccessibleName = "Outline"
			Me.radMenuItem80.ImageKey = "5_Outline.gif"
			Me.radMenuItem80.Name = "radMenuItem80"
			Me.radMenuItem80.Text = "Outline"
			Me.radMenuItem80.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem80.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem66
			' 
			Me.radMenuItem66.AccessibleDescription = "Do Not Show n Table of Contents"
			Me.radMenuItem66.AccessibleName = "Do Not Show n Table of Contents"
			Me.radMenuItem66.CheckOnClick = True
			Me.radMenuItem66.IsChecked = True
			Me.radMenuItem66.Name = "radMenuItem66"
			Me.radMenuItem66.Text = "Do Not Show n Table of Contents"
			Me.radMenuItem66.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem66.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radMenuItem66.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem67
			' 
			Me.radMenuItem67.AccessibleDescription = "Level 1"
			Me.radMenuItem67.AccessibleName = "Level 1"
			Me.radMenuItem67.Name = "radMenuItem67"
			Me.radMenuItem67.Text = "Level 1"
			Me.radMenuItem67.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem67.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem68
			' 
			Me.radMenuItem68.AccessibleDescription = "Level 2"
			Me.radMenuItem68.AccessibleName = "Level 2"
			Me.radMenuItem68.Name = "radMenuItem68"
			Me.radMenuItem68.Text = "Level 2"
			Me.radMenuItem68.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem68.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem69
			' 
			Me.radMenuItem69.AccessibleDescription = "Level 3"
			Me.radMenuItem69.AccessibleName = "Level 3"
			Me.radMenuItem69.Name = "radMenuItem69"
			Me.radMenuItem69.Text = "Level 3"
			Me.radMenuItem69.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem69.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem34
			' 
			Me.radMenuItem34.AccessibleDescription = "Clip Art"
			Me.radMenuItem34.AccessibleName = "Clip Art"
			Me.radMenuItem34.ImageKey = "5_Clip-art.gif"
			Me.radMenuItem34.Name = "radMenuItem34"
			Me.radMenuItem34.Text = "Clip Art"
			Me.radMenuItem34.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem34.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem35
			' 
			Me.radMenuItem35.AccessibleDescription = "From File"
			Me.radMenuItem35.AccessibleName = "From File"
			Me.radMenuItem35.ImageKey = "6_From-file.gif"
			Me.radMenuItem35.Name = "radMenuItem35"
			Me.radMenuItem35.Text = "From File"
			Me.radMenuItem35.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem35.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem36
			' 
			Me.radMenuItem36.AccessibleDescription = "From Scanner or Camera"
			Me.radMenuItem36.AccessibleName = "From Scanner or Camera"
			Me.radMenuItem36.ImageKey = "7_From-scanner.gif"
			Me.radMenuItem36.Name = "radMenuItem36"
			Me.radMenuItem36.Text = "From Scanner or Camera"
			Me.radMenuItem36.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem36.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem48
			' 
			Me.radMenuItem48.AccessibleDescription = "Portrait"
			Me.radMenuItem48.AccessibleName = "Portrait"
			Me.radMenuItem48.Name = "radMenuItem48"
			Me.radMenuItem48.Text = "Portrait"
			Me.radMenuItem48.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem48.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem49
			' 
			Me.radMenuItem49.AccessibleDescription = "Landscape"
			Me.radMenuItem49.AccessibleName = "Landscape"
			Me.radMenuItem49.Name = "radMenuItem49"
			Me.radMenuItem49.Text = "Landscape"
			Me.radMenuItem49.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem49.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem50
			' 
			Me.radMenuItem50.AccessibleDescription = "Letter"
			Me.radMenuItem50.AccessibleName = "Letter"
			Me.radMenuItem50.Name = "radMenuItem50"
			Me.radMenuItem50.Text = "Letter"
			Me.radMenuItem50.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem50.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem51
			' 
			Me.radMenuItem51.AccessibleDescription = "Tabloid"
			Me.radMenuItem51.AccessibleName = "Tabloid"
			Me.radMenuItem51.Name = "radMenuItem51"
			Me.radMenuItem51.Text = "Tabloid"
			Me.radMenuItem51.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem51.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem52
			' 
			Me.radMenuItem52.AccessibleDescription = "Legal"
			Me.radMenuItem52.AccessibleName = "Legal"
			Me.radMenuItem52.Name = "radMenuItem52"
			Me.radMenuItem52.Text = "Legal"
			Me.radMenuItem52.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem52.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem53
			' 
			Me.radMenuItem53.AccessibleDescription = "A3"
			Me.radMenuItem53.AccessibleName = "A3"
			Me.radMenuItem53.Name = "radMenuItem53"
			Me.radMenuItem53.Text = "A3"
			Me.radMenuItem53.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem53.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem54
			' 
			Me.radMenuItem54.AccessibleDescription = "A4"
			Me.radMenuItem54.AccessibleName = "A4"
			Me.radMenuItem54.Name = "radMenuItem54"
			Me.radMenuItem54.Text = "A4"
			Me.radMenuItem54.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem54.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.AccessibleDescription = "Open"
			Me.radMenuItem1_2.AccessibleName = "Open"
			Me.radMenuItem1_2.HintText = "Ctrl+O"
			Me.radMenuItem1_2.ImageKey = "2_Open.gif"
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.Text = "Open"
			Me.radMenuItem1_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.AccessibleDescription = "Properties"
			Me.radMenuItem2_1.AccessibleName = "Properties"
			Me.radMenuItem2_1.HintText = "Ctrl+Z"
			Me.radMenuItem2_1.ImageKey = "1_Properties.gif"
			Me.radMenuItem2_1.Name = "radMenuItem2_1"
			Me.radMenuItem2_1.Text = "Properties"
			Me.radMenuItem2_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.AccessibleDescription = "Inspect Document"
			Me.radMenuItem2_2.AccessibleName = "Inspect Document"
			Me.radMenuItem2_2.HintText = "Ctrl+Y"
			Me.radMenuItem2_2.ImageKey = "2_Inspect_Document.gif"
			Me.radMenuItem2_2.Name = "radMenuItem2_2"
			Me.radMenuItem2_2.Text = "Inspect Document"
			Me.radMenuItem2_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.AccessibleDescription = "Encrypt Document"
			Me.radMenuItem2_3.AccessibleName = "Encrypt Document"
			Me.radMenuItem2_3.HintText = "Ctrl+X"
			Me.radMenuItem2_3.ImageKey = "3_Encrypt_Document.gif"
			Me.radMenuItem2_3.Name = "radMenuItem2_3"
			Me.radMenuItem2_3.Text = "Encrypt Document"
			Me.radMenuItem2_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.AccessibleDescription = "Restrict Permission"
			Me.radMenuItem2_4.AccessibleName = "Restrict Permission"
			Me.radMenuItem2_4.HintText = "Ctrl+C"
			Me.radMenuItem2_4.ImageKey = "4_Restrict_Permission.gif"
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.Text = "Restrict Permission"
			Me.radMenuItem2_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_5
			' 
			Me.radMenuItem2_5.AccessibleDescription = "Add a Digital Signature"
			Me.radMenuItem2_5.AccessibleName = "Add a Digital Signature"
			Me.radMenuItem2_5.HintText = "Ctrl+V"
			Me.radMenuItem2_5.ImageKey = "5_Add_a_Digital_Signature.gif"
			Me.radMenuItem2_5.Name = "radMenuItem2_5"
			Me.radMenuItem2_5.Text = "Add a Digital Signature"
			Me.radMenuItem2_5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.AccessibleDescription = "Blog"
			Me.radMenuItem4_1.AccessibleName = "Blog"
			Me.radMenuItem4_1.HintText = "Ctrl+Shift+B"
			Me.radMenuItem4_1.ImageKey = "1_Blog.gif"
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.Text = "Blog"
			Me.radMenuItem4_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.AccessibleDescription = "Document Management"
			Me.radMenuItem4_2.AccessibleName = "Document Management"
			Me.radMenuItem4_2.HintText = "Shift+F6"
			Me.radMenuItem4_2.ImageKey = "2_Document_Management.gif"
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.Text = "Document Management"
			Me.radMenuItem4_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5_1
			' 
			Me.radMenuItem5_1.AccessibleDescription = "Word Document"
			Me.radMenuItem5_1.AccessibleName = "Word Document"
			Me.radMenuItem5_1.HintText = "Shift+Alt+D"
			Me.radMenuItem5_1.ImageKey = "1_Word_Document.gif"
			Me.radMenuItem5_1.Name = "radMenuItem5_1"
			Me.radMenuItem5_1.Text = "Word Document"
			Me.radMenuItem5_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.AccessibleDescription = "Save"
			Me.radMenuItem1_3.AccessibleName = "Save"
			Me.radMenuItem1_3.ImageKey = "3_Save.gif"
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.Text = "Save"
			Me.radMenuItem1_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.AccessibleDescription = "Save as"
			Me.radMenuItem1_4.AccessibleName = "Save as"
			Me.radMenuItem1_4.ImageKey = "4_Save_as.gif"
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.Text = "Save as"
			Me.radMenuItem1_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_5
			' 
			Me.radMenuItem1_5.AccessibleDescription = "Print"
			Me.radMenuItem1_5.AccessibleName = "Print"
			Me.radMenuItem1_5.ImageKey = "5_Print.gif"
			Me.radMenuItem1_5.Name = "radMenuItem1_5"
			Me.radMenuItem1_5.Text = "Print"
			Me.radMenuItem1_5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_6
			' 
			Me.radMenuItem1_6.AccessibleDescription = "Prepare"
			Me.radMenuItem1_6.AccessibleName = "Prepare"
			Me.radMenuItem1_6.ImageKey = "6_Prepare.gif"
			Me.radMenuItem1_6.Name = "radMenuItem1_6"
			Me.radMenuItem1_6.Text = "Prepare"
			Me.radMenuItem1_6.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_7
			' 
			Me.radMenuItem1_7.AccessibleDescription = "Send"
			Me.radMenuItem1_7.AccessibleName = "Send"
			Me.radMenuItem1_7.ImageKey = "7_Send.gif"
			Me.radMenuItem1_7.Name = "radMenuItem1_7"
			Me.radMenuItem1_7.Text = "Send"
			Me.radMenuItem1_7.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_8
			' 
			Me.radMenuItem1_8.AccessibleDescription = "Publish"
			Me.radMenuItem1_8.AccessibleName = "Publish"
			Me.radMenuItem1_8.ImageKey = "8_Publish.gif"
			Me.radMenuItem1_8.Name = "radMenuItem1_8"
			Me.radMenuItem1_8.Text = "Publish"
			Me.radMenuItem1_8.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem1_9
			' 
			Me.radMenuItem1_9.AccessibleDescription = "Close"
			Me.radMenuItem1_9.AccessibleName = "Close"
			Me.radMenuItem1_9.ImageKey = "9_Close.gif"
			Me.radMenuItem1_9.Name = "radMenuItem1_9"
			Me.radMenuItem1_9.Text = "Close"
			Me.radMenuItem1_9.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1_9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.AccessibleDescription = "radMenuItem7"
			Me.radMenuItem7.AccessibleName = "radMenuItem7"
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.AccessibleDescription = "radMenuItem8"
			Me.radMenuItem8.AccessibleName = "radMenuItem8"
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_6
			' 
			Me.radMenuItem2_6.AccessibleDescription = "Mark As Final"
			Me.radMenuItem2_6.AccessibleName = "Mark As Final"
			Me.radMenuItem2_6.ImageKey = "6_Mark_As_Final.gif"
			Me.radMenuItem2_6.Name = "radMenuItem2_6"
			Me.radMenuItem2_6.Text = "Mark As Final"
			Me.radMenuItem2_6.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2_7
			' 
			Me.radMenuItem2_7.AccessibleDescription = "Run Compatibility Checker"
			Me.radMenuItem2_7.AccessibleName = "Run Compatibility Checker"
			Me.radMenuItem2_7.ImageKey = "7_Run_Compatibility_Checker.gif"
			Me.radMenuItem2_7.Name = "radMenuItem2_7"
			Me.radMenuItem2_7.Text = "Run Compatibility Checker"
			Me.radMenuItem2_7.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2_7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.AccessibleDescription = "Print"
			Me.radMenuItem3_1.AccessibleName = "Print"
			Me.radMenuItem3_1.ImageKey = "1_Print.gif"
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.Text = "Print"
			Me.radMenuItem3_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.AccessibleDescription = "Quick Print"
			Me.radMenuItem3_2.AccessibleName = "Quick Print"
			Me.radMenuItem3_2.ImageKey = "2_Quick_Print.gif"
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.Text = "Quick Print"
			Me.radMenuItem3_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.AccessibleDescription = "Print Preview"
			Me.radMenuItem3_3.AccessibleName = "Print Preview"
			Me.radMenuItem3_3.ImageKey = "3_Print_Preview.gif"
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.Text = "Print Preview"
			Me.radMenuItem3_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.AccessibleDescription = "Create Document Workspace"
			Me.radMenuItem4_3.AccessibleName = "Create Document Workspace"
			Me.radMenuItem4_3.ImageKey = "3_Create_Document_Workspace.gif"
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.Text = "Create Document Workspace"
			Me.radMenuItem4_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5_2
			' 
			Me.radMenuItem5_2.AccessibleDescription = "Word Template"
			Me.radMenuItem5_2.AccessibleName = "Word Template"
			Me.radMenuItem5_2.ImageKey = "2_Word_Template.gif"
			Me.radMenuItem5_2.Name = "radMenuItem5_2"
			Me.radMenuItem5_2.Text = "Word Template"
			Me.radMenuItem5_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5_2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5_3
			' 
			Me.radMenuItem5_3.AccessibleDescription = "Word97 Document"
			Me.radMenuItem5_3.AccessibleName = "Word97 Document"
			Me.radMenuItem5_3.ImageKey = "3_Word_97_document.gif"
			Me.radMenuItem5_3.Name = "radMenuItem5_3"
			Me.radMenuItem5_3.Text = "Word97 Document"
			Me.radMenuItem5_3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5_3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5_4
			' 
			Me.radMenuItem5_4.AccessibleDescription = "Find addins"
			Me.radMenuItem5_4.AccessibleName = "Find addins"
			Me.radMenuItem5_4.ImageKey = "4_ Find_addins.gif"
			Me.radMenuItem5_4.Name = "radMenuItem5_4"
			Me.radMenuItem5_4.Text = "Find addins"
			Me.radMenuItem5_4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5_4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5_5
			' 
			Me.radMenuItem5_5.AccessibleDescription = "Other Formats"
			Me.radMenuItem5_5.AccessibleName = "Other Formats"
			Me.radMenuItem5_5.ImageKey = "5_Other_Formats.gif"
			Me.radMenuItem5_5.Name = "radMenuItem5_5"
			Me.radMenuItem5_5.Text = "Other Formats"
			Me.radMenuItem5_5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5_5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem6_1
			' 
			Me.radMenuItem6_1.AccessibleDescription = "E-mail"
			Me.radMenuItem6_1.AccessibleName = "E-mail"
			Me.radMenuItem6_1.ImageKey = "1_E-mail.gif"
			Me.radMenuItem6_1.Name = "radMenuItem6_1"
			Me.radMenuItem6_1.Text = "E-mail"
			Me.radMenuItem6_1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem6_1.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radMenuItem6_2
			' 
			Me.radMenuItem6_2.AccessibleDescription = "Internet Fax"
			Me.radMenuItem6_2.AccessibleName = "Internet Fax"
			Me.radMenuItem6_2.ImageKey = "2_Internet_Fax.gif"
			Me.radMenuItem6_2.Name = "radMenuItem6_2"
			Me.radMenuItem6_2.Text = "Internet Fax"
			Me.radMenuItem6_2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem6_2.Visibility = Telerik.WinControls.ElementVisibility.Visible

			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Bottom
			Me.radButton1.BackColor = Color.Transparent
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton1.Image = My.Resources.pic1
			Me.radButton1.Location = New Point(35, 179)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Padding = New Padding(0, 0, 1, 1)
			' 
			' 
			' 
			Me.radButton1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton1.RootElement.Padding = New Padding(0, 0, 1, 1)
			Me.radButton1.RootElement.StretchHorizontally = False
			Me.radButton1.RootElement.StretchVertically = False
			Me.radButton1.Size = New Size(151, 100)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"

			' 
			' radButton2
			' 
			Me.radButton2.Anchor = AnchorStyles.Bottom
			Me.radButton2.BackColor = Color.Transparent
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton2.Image = My.Resources.pic2
			Me.radButton2.Location = New Point(205, 179)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Padding = New Padding(0, 0, 1, 1)
			' 
			' 
			' 
			Me.radButton2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton2.RootElement.Padding = New Padding(0, 0, 1, 1)
			Me.radButton2.RootElement.StretchHorizontally = False
			Me.radButton2.RootElement.StretchVertically = False
			Me.radButton2.Size = New Size(151, 100)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "radButton2"

			' 
			' radButton3
			' 
			Me.radButton3.Anchor = AnchorStyles.Bottom
			Me.radButton3.BackColor = Color.Transparent
			Me.radButton3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton3.Image = My.Resources.pic3
			Me.radButton3.Location = New Point(375, 179)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Padding = New Padding(0, 0, 1, 1)
			' 
			' 
			' 
			Me.radButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton3.RootElement.Padding = New Padding(0, 0, 1, 1)
			Me.radButton3.RootElement.StretchHorizontally = False
			Me.radButton3.RootElement.StretchVertically = False
			Me.radButton3.Size = New Size(151, 100)
			Me.radButton3.TabIndex = 3
			Me.radButton3.Text = "radButton3"

			' 
			' radButton4
			' 
			Me.radButton4.Anchor = AnchorStyles.Bottom
			Me.radButton4.BackColor = Color.Transparent
			Me.radButton4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton4.Image = My.Resources.pic4
			Me.radButton4.Location = New Point(545, 179)
			Me.radButton4.Name = "radButton4"
			Me.radButton4.Padding = New Padding(0, 0, 1, 1)
			' 
			' 
			' 
			Me.radButton4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radButton4.RootElement.Padding = New Padding(0, 0, 1, 1)
			Me.radButton4.RootElement.StretchHorizontally = False
			Me.radButton4.RootElement.StretchVertically = False
			Me.radButton4.Size = New Size(151, 100)
			Me.radButton4.TabIndex = 4
			Me.radButton4.Text = "radButton4"

			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = Color.Transparent
			Me.radLabel1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.radLabel1.ForeColor = Color.SteelBlue
			Me.radLabel1.Location = New Point(39, 25)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(307, 26)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "Select a photo to enable the menu"
			' 
			' radThemeManager1
			' 
			themeSource3.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource3.ThemeLocation = "Telerik.Examples.WinControls.Resources.MenuFirstLook.xml"
			themeSource4.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource4.ThemeLocation = "Telerik.Examples.WinControls.Resources.MenuFirstLook_Button.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource3, themeSource4})
			' 
			' radPanelDemo
			' 
			Me.radPanelDemo.Controls.Add(Me.radPanel1)
			Me.radPanelDemo.Controls.Add(Me.radButton1)
			Me.radPanelDemo.Controls.Add(Me.radLabel1)
			Me.radPanelDemo.Controls.Add(Me.radButton2)
			Me.radPanelDemo.Controls.Add(Me.radButton4)
			Me.radPanelDemo.Controls.Add(Me.radButton3)
			Me.radPanelDemo.Location = New Point(0, 0)
			Me.radPanelDemo.Name = "radPanelDemo"
			Me.radPanelDemo.Size = New Size(731, 294)
			Me.radPanelDemo.TabIndex = 8
			CType(Me.radPanelDemo.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = My.Resources.menu_firstlook_bg
			Me.radPanel1.BackgroundImageLayout = ImageLayout.Zoom
			Me.radPanel1.Controls.Add(Me.radMenu1)
			Me.radPanel1.ForeColor = Color.Black
			Me.radPanel1.Location = New Point(7, 55)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.Shape = Me.roundRectShape1
			Me.radPanel1.Size = New Size(717, 87)
			Me.radPanel1.TabIndex = 7
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.Radius = 10
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.BackgroundImageLayout = ImageLayout.None
			Me.Controls.Add(Me.radPanelDemo)
			Me.Name = "Form1"
			Me.Size = New Size(1220, 516)
			Me.Controls.SetChildIndex(Me.radPanelDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemo.ResumeLayout(False)
			Me.radPanelDemo.PerformLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private menuPrint As Telerik.WinControls.UI.RadMenuItem
		Private menuEmail As Telerik.WinControls.UI.RadMenuItem
		Private menuBurn As Telerik.WinControls.UI.RadMenuItem
		Private menuOpenWidth As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem23 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem24 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem34 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem35 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem36 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem48 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem49 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem50 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem51 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem52 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem53 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem54 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem41 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem60 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem66 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem67 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem68 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem69 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem70 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem71 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem72 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem73 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem74 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem76 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem77 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem78 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem79 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem80 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem81 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem6 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem7 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private imageList1 As ImageList
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton4 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radPanelDemo As Telerik.WinControls.UI.RadPanel
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape

	End Class
End Namespace