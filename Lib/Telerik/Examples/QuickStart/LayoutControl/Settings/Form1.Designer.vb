Namespace Telerik.Examples.WinControls.LayoutControl.Settings
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

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radLayoutControl1 = New Telerik.WinControls.UI.RadLayoutControl()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radTextBox3 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radTextBox4 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radButton2 = New Telerik.WinControls.UI.RadButton()
            Me.radTextBox2 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radTextBox5 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radTextBox6 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.radTextBox7 = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.layoutControlItem3 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem6 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem9 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlLabelItem10 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlLabelItem11 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlLabelItem12 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlLabelItem13 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlItem4 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem14 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem5 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlLabelItem15 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlItem17 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem18 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlItem19 = New Telerik.WinControls.UI.LayoutControlItem()
            Me.layoutControlLabelItem2 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.layoutControlSeparatorItem1 = New Telerik.WinControls.UI.LayoutControlSeparatorItem()
            Me.layoutControlLabelItem20 = New Telerik.WinControls.UI.LayoutControlLabelItem()
            Me.radButtonAddMember = New Telerik.WinControls.UI.RadButton()
            Me.radButtonEditLayout = New Telerik.WinControls.UI.RadButton()
            Me.radButtonSaveLayout = New Telerik.WinControls.UI.RadButton()
            Me.radButtonLoadLayout = New Telerik.WinControls.UI.RadButton()
            Me.layoutControlSeparatorItem2 = New Telerik.WinControls.UI.LayoutControlSeparatorItem()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radLayoutControl1.SuspendLayout()
            DirectCast(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonAddMember, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonEditLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radButtonAddMember)
            Me.settingsPanel.Controls.Add(Me.radButtonLoadLayout)
            Me.settingsPanel.Controls.Add(Me.radButtonEditLayout)
            Me.settingsPanel.Controls.Add(Me.radButtonSaveLayout)
            Me.settingsPanel.Location = New System.Drawing.Point(857, 3)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonSaveLayout, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonEditLayout, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonLoadLayout, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radButtonAddMember, 0)
            ' 
            ' radLayoutControl1
            ' 
            Me.radLayoutControl1.Controls.Add(Me.radTextBox1)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox3)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox4)
            Me.radLayoutControl1.Controls.Add(Me.radButton1)
            Me.radLayoutControl1.Controls.Add(Me.radButton2)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox2)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox5)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox6)
            Me.radLayoutControl1.Controls.Add(Me.radTextBox7)
            Me.radLayoutControl1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutControlItem3, Me.layoutControlItem6, Me.layoutControlItem9, Me.layoutControlLabelItem10, Me.layoutControlLabelItem11, Me.layoutControlLabelItem12, _
                Me.layoutControlLabelItem13, Me.layoutControlLabelItem1, Me.layoutControlItem4, Me.layoutControlItem14, Me.layoutControlItem5, Me.layoutControlLabelItem15, _
                Me.layoutControlItem17, Me.layoutControlItem18, Me.layoutControlItem19, Me.layoutControlLabelItem2, Me.layoutControlSeparatorItem1, Me.layoutControlLabelItem20, _
                Me.layoutControlSeparatorItem2})
            Me.radLayoutControl1.Location = New System.Drawing.Point(13, 13)
            Me.radLayoutControl1.Name = "radLayoutControl1"
            Me.radLayoutControl1.Size = New System.Drawing.Size(626, 632)
            Me.radLayoutControl1.TabIndex = 0
            Me.radLayoutControl1.Text = "radLayoutControl1"
            ' 
            ' radTextBox1
            ' 
            Me.radTextBox1.Location = New System.Drawing.Point(3, 137)
            Me.radTextBox1.Multiline = True
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(620, 74)
            Me.radTextBox1.TabIndex = 6
            Me.radTextBox1.Text = "UI components for Windows Forms"
            ' 
            ' radTextBox3
            ' 
            Me.radTextBox3.Location = New System.Drawing.Point(3, 471)
            Me.radTextBox3.Name = "radTextBox3"
            Me.radTextBox3.Size = New System.Drawing.Size(620, 20)
            Me.radTextBox3.TabIndex = 9
            Me.radTextBox3.Text = "Anne Dodsworth"
            ' 
            ' radTextBox4
            ' 
            Me.radTextBox4.Location = New System.Drawing.Point(316, 91)
            Me.radTextBox4.Name = "radTextBox4"
            Me.radTextBox4.Size = New System.Drawing.Size(307, 20)
            Me.radTextBox4.TabIndex = 13
            Me.radTextBox4.Text = "http://www.telerik.com/products/winforms.aspx"
            ' 
            ' radButton1
            ' 
            Me.radButton1.Location = New System.Drawing.Point(316, 217)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(150, 24)
            Me.radButton1.TabIndex = 18
            Me.radButton1.Text = "Clone"
            ' 
            ' radButton2
            ' 
            Me.radButton2.Location = New System.Drawing.Point(472, 217)
            Me.radButton2.Name = "radButton2"
            Me.radButton2.Size = New System.Drawing.Size(151, 24)
            Me.radButton2.TabIndex = 19
            Me.radButton2.Text = "Download ZIP"
            ' 
            ' radTextBox2
            ' 
            Me.radTextBox2.Location = New System.Drawing.Point(3, 91)
            Me.radTextBox2.Name = "radTextBox2"
            Me.radTextBox2.Size = New System.Drawing.Size(307, 20)
            Me.radTextBox2.TabIndex = 20
            Me.radTextBox2.Text = "Progress® Telerik® UI for WinForms"
            ' 
            ' radTextBox5
            ' 
            Me.radTextBox5.Location = New System.Drawing.Point(3, 419)
            Me.radTextBox5.Name = "radTextBox5"
            Me.radTextBox5.Size = New System.Drawing.Size(620, 20)
            Me.radTextBox5.TabIndex = 22
            Me.radTextBox5.Text = "Andrew Fuller"
            ' 
            ' radTextBox6
            ' 
            Me.radTextBox6.Location = New System.Drawing.Point(3, 367)
            Me.radTextBox6.Name = "radTextBox6"
            Me.radTextBox6.Size = New System.Drawing.Size(620, 20)
            Me.radTextBox6.TabIndex = 23
            Me.radTextBox6.Text = "Nancy Davolio"
            ' 
            ' radTextBox7
            ' 
            Me.radTextBox7.Location = New System.Drawing.Point(3, 315)
            Me.radTextBox7.Name = "radTextBox7"
            Me.radTextBox7.Size = New System.Drawing.Size(620, 20)
            Me.radTextBox7.TabIndex = 24
            Me.radTextBox7.Text = "John Smith"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AccessibleDescription = "Mandra"
            Me.layoutControlItem3.AccessibleName = "Mandra"
            Me.layoutControlItem3.AssociatedControl = Me.radTextBox1
            Me.layoutControlItem3.Bounds = New System.Drawing.Rectangle(0, 114, 626, 100)
            Me.layoutControlItem3.DrawText = True
            Me.layoutControlItem3.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(46, 100)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Text = "Description"
            Me.layoutControlItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem3.TextFixedSize = 20
            Me.layoutControlItem3.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem3.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AccessibleDescription = "asdadas"
            Me.layoutControlItem6.AccessibleName = "asdadas"
            Me.layoutControlItem6.AssociatedControl = Me.radTextBox3
            Me.layoutControlItem6.Bounds = New System.Drawing.Rectangle(0, 442, 626, 52)
            Me.layoutControlItem6.DrawText = True
            Me.layoutControlItem6.Image = My.Resources.user
            Me.layoutControlItem6.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem6.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.layoutControlItem6.MaxSize = New System.Drawing.Size(0, 52)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(46, 52)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Text = "Team Member 4"
            Me.layoutControlItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem6.TextFixedSize = 26
            Me.layoutControlItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.layoutControlItem6.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem6.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.AccessibleDescription = "Website"
            Me.layoutControlItem9.AccessibleName = "Website"
            Me.layoutControlItem9.AssociatedControl = Me.radTextBox4
            Me.layoutControlItem9.Bounds = New System.Drawing.Rectangle(313, 68, 313, 46)
            Me.layoutControlItem9.DrawText = True
            Me.layoutControlItem9.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.layoutControlItem9.MaxSize = New System.Drawing.Size(0, 46)
            Me.layoutControlItem9.MinSize = New System.Drawing.Size(46, 46)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Text = "Website"
            Me.layoutControlItem9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem9.TextFixedSize = 20
            Me.layoutControlItem9.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem9.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlLabelItem10
            ' 
            Me.layoutControlLabelItem10.AccessibleDescription = "<html><b>3875</b> commits"
            Me.layoutControlLabelItem10.AccessibleName = "<html><b>3875</b> commits"
            Me.layoutControlLabelItem10.Bounds = New System.Drawing.Rectangle(0, 38, 156, 26)
            Me.layoutControlLabelItem10.MaxSize = New System.Drawing.Size(0, 26)
            Me.layoutControlLabelItem10.Name = "layoutControlLabelItem10"
            Me.layoutControlLabelItem10.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem10.Text = "<html><span style=""font-family:Segoe UI Light;font-size:12pt;color:#1A9B56""><b>38" + "75</b> </span><span style=""font-size:8.5pt"">commits</span>"
            Me.layoutControlLabelItem10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControlLabelItem11
            ' 
            Me.layoutControlLabelItem11.AccessibleDescription = "<html><b>24</b> releases"
            Me.layoutControlLabelItem11.AccessibleName = "<html><b>24</b> releases"
            Me.layoutControlLabelItem11.Bounds = New System.Drawing.Rectangle(312, 38, 156, 26)
            Me.layoutControlLabelItem11.MaxSize = New System.Drawing.Size(0, 26)
            Me.layoutControlLabelItem11.Name = "layoutControlLabelItem11"
            Me.layoutControlLabelItem11.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem11.Text = "<html><span style=""font-family:Segoe UI Light;font-size:12pt;color:#1A9B56""><b>24" + "</b> </span><span style=""font-size:8.5pt"">releases</span>"
            Me.layoutControlLabelItem11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControlLabelItem12
            ' 
            Me.layoutControlLabelItem12.AccessibleDescription = "<html><b>5</b> branches"
            Me.layoutControlLabelItem12.AccessibleName = "<html><b>5</b> branches"
            Me.layoutControlLabelItem12.Bounds = New System.Drawing.Rectangle(156, 38, 156, 26)
            Me.layoutControlLabelItem12.MaxSize = New System.Drawing.Size(0, 26)
            Me.layoutControlLabelItem12.Name = "layoutControlLabelItem12"
            Me.layoutControlLabelItem12.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem12.Text = "<html><span style=""font-family:Segoe UI Light;font-size:12pt;color:#1A9B56""><b>5<" + "/b> </span><span style=""font-size:8.5pt"">branches</span>"
            Me.layoutControlLabelItem12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControlLabelItem13
            ' 
            Me.layoutControlLabelItem13.AccessibleDescription = "<html><b>32</b> contributors"
            Me.layoutControlLabelItem13.AccessibleName = "<html><b>32</b> contributors"
            Me.layoutControlLabelItem13.Bounds = New System.Drawing.Rectangle(468, 38, 158, 26)
            Me.layoutControlLabelItem13.MaxSize = New System.Drawing.Size(0, 26)
            Me.layoutControlLabelItem13.Name = "layoutControlLabelItem13"
            Me.layoutControlLabelItem13.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem13.Text = "<html><span style=""font-family:Segoe UI Light;font-size:12pt;color:#1A9B56""><b>32" + "</b> </span><span style=""font-size:8.5pt"">contributors</span>"
            Me.layoutControlLabelItem13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControlLabelItem1
            ' 
            Me.layoutControlLabelItem1.Bounds = New System.Drawing.Rectangle(0, 214, 313, 30)
            Me.layoutControlLabelItem1.DrawText = False
            Me.layoutControlLabelItem1.Name = "layoutControlLabelItem1"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.AssociatedControl = Me.radButton1
            Me.layoutControlItem4.Bounds = New System.Drawing.Rectangle(313, 214, 156, 30)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(0, 30)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(46, 30)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.AssociatedControl = Me.radButton2
            Me.layoutControlItem14.Bounds = New System.Drawing.Rectangle(469, 214, 157, 30)
            Me.layoutControlItem14.MaxSize = New System.Drawing.Size(0, 30)
            Me.layoutControlItem14.MinSize = New System.Drawing.Size(46, 30)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.AccessibleDescription = "Project name"
            Me.layoutControlItem5.AccessibleName = "Project name"
            Me.layoutControlItem5.AssociatedControl = Me.radTextBox2
            Me.layoutControlItem5.Bounds = New System.Drawing.Rectangle(0, 68, 313, 46)
            Me.layoutControlItem5.DrawText = True
            Me.layoutControlItem5.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(0, 46)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(46, 46)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Text = "Project name"
            Me.layoutControlItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem5.TextFixedSize = 20
            Me.layoutControlItem5.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem5.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlLabelItem15
            ' 
            Me.layoutControlLabelItem15.AccessibleDescription = "Team Members"
            Me.layoutControlLabelItem15.AccessibleName = "Team Members"
            Me.layoutControlLabelItem15.Bounds = New System.Drawing.Rectangle(0, 248, 626, 38)
            Me.layoutControlLabelItem15.Font = New System.Drawing.Font("Segoe UI Light", 15.0F, System.Drawing.FontStyle.Bold)
            Me.layoutControlLabelItem15.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(26)), CInt(CByte(155)), CInt(CByte(86)))
            Me.layoutControlLabelItem15.MaxSize = New System.Drawing.Size(0, 38)
            Me.layoutControlLabelItem15.MinSize = New System.Drawing.Size(46, 38)
            Me.layoutControlLabelItem15.Name = "layoutControlLabelItem15"
            Me.layoutControlLabelItem15.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem15.Text = "team members"
            Me.layoutControlLabelItem15.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.AccessibleDescription = "Team Member"
            Me.layoutControlItem17.AccessibleName = "Team Member"
            Me.layoutControlItem17.AssociatedControl = Me.radTextBox5
            Me.layoutControlItem17.Bounds = New System.Drawing.Rectangle(0, 390, 626, 52)
            Me.layoutControlItem17.DrawImage = True
            Me.layoutControlItem17.DrawText = True
            Me.layoutControlItem17.Image = My.Resources.user
            Me.layoutControlItem17.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem17.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.layoutControlItem17.MaxSize = New System.Drawing.Size(0, 52)
            Me.layoutControlItem17.MinSize = New System.Drawing.Size(46, 52)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Text = "Team Member 3"
            Me.layoutControlItem17.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem17.TextFixedSize = 26
            Me.layoutControlItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.layoutControlItem17.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem17.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.AccessibleDescription = "Team Member"
            Me.layoutControlItem18.AccessibleName = "Team Member"
            Me.layoutControlItem18.AssociatedControl = Me.radTextBox6
            Me.layoutControlItem18.Bounds = New System.Drawing.Rectangle(0, 338, 626, 52)
            Me.layoutControlItem18.DrawImage = True
            Me.layoutControlItem18.DrawText = True
            Me.layoutControlItem18.Image = My.Resources.user
            Me.layoutControlItem18.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem18.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.layoutControlItem18.MaxSize = New System.Drawing.Size(0, 52)
            Me.layoutControlItem18.MinSize = New System.Drawing.Size(46, 52)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Text = "Team Member 2"
            Me.layoutControlItem18.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem18.TextFixedSize = 26
            Me.layoutControlItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.layoutControlItem18.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem18.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlItem19
            ' 
            Me.layoutControlItem19.AccessibleDescription = "Team Member"
            Me.layoutControlItem19.AccessibleName = "Team Member"
            Me.layoutControlItem19.AssociatedControl = Me.radTextBox7
            Me.layoutControlItem19.Bounds = New System.Drawing.Rectangle(0, 286, 626, 52)
            Me.layoutControlItem19.DrawImage = True
            Me.layoutControlItem19.DrawText = True
            Me.layoutControlItem19.Image = My.Resources.user
            Me.layoutControlItem19.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem19.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.layoutControlItem19.MaxSize = New System.Drawing.Size(0, 52)
            Me.layoutControlItem19.MinSize = New System.Drawing.Size(46, 52)
            Me.layoutControlItem19.Name = "layoutControlItem19"
            Me.layoutControlItem19.Text = "Team Member 1"
            Me.layoutControlItem19.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem19.TextFixedSize = 26
            Me.layoutControlItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.layoutControlItem19.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            Me.layoutControlItem19.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
            ' 
            ' layoutControlLabelItem2
            ' 
            Me.layoutControlLabelItem2.Bounds = New System.Drawing.Rectangle(0, 494, 626, 138)
            Me.layoutControlLabelItem2.DrawText = False
            Me.layoutControlLabelItem2.Name = "layoutControlLabelItem2"
            ' 
            ' layoutControlSeparatorItem1
            ' 
            Me.layoutControlSeparatorItem1.Bounds = New System.Drawing.Rectangle(0, 64, 626, 4)
            Me.layoutControlSeparatorItem1.Name = "layoutControlSeparatorItem1"
            ' 
            ' layoutControlLabelItem20
            ' 
            Me.layoutControlLabelItem20.AccessibleDescription = "Project"
            Me.layoutControlLabelItem20.AccessibleName = "Project"
            Me.layoutControlLabelItem20.Bounds = New System.Drawing.Rectangle(0, 0, 626, 38)
            Me.layoutControlLabelItem20.Font = New System.Drawing.Font("Segoe UI Light", 15.0F, System.Drawing.FontStyle.Bold)
            Me.layoutControlLabelItem20.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(26)), CInt(CByte(155)), CInt(CByte(86)))
            Me.layoutControlLabelItem20.MaxSize = New System.Drawing.Size(0, 38)
            Me.layoutControlLabelItem20.MinSize = New System.Drawing.Size(46, 38)
            Me.layoutControlLabelItem20.Name = "layoutControlLabelItem20"
            Me.layoutControlLabelItem20.Padding = New System.Windows.Forms.Padding(3)
            Me.layoutControlLabelItem20.Text = "telerik/winforms"
            Me.layoutControlLabelItem20.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' radButtonAddMember
            ' 
            Me.radButtonAddMember.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonAddMember.Location = New System.Drawing.Point(10, 32)
            Me.radButtonAddMember.Name = "radButtonAddMember"
            Me.radButtonAddMember.Size = New System.Drawing.Size(210, 24)
            Me.radButtonAddMember.TabIndex = 1
            Me.radButtonAddMember.Text = "Add team member"
            ' 
            ' radButtonEditLayout
            ' 
            Me.radButtonEditLayout.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonEditLayout.Location = New System.Drawing.Point(10, 62)
            Me.radButtonEditLayout.Name = "radButtonEditLayout"
            Me.radButtonEditLayout.Size = New System.Drawing.Size(210, 24)
            Me.radButtonEditLayout.TabIndex = 1
            Me.radButtonEditLayout.Text = "Edit Layout"
            ' 
            ' radButtonSaveLayout
            ' 
            Me.radButtonSaveLayout.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonSaveLayout.Location = New System.Drawing.Point(10, 92)
            Me.radButtonSaveLayout.Name = "radButtonSaveLayout"
            Me.radButtonSaveLayout.Size = New System.Drawing.Size(210, 24)
            Me.radButtonSaveLayout.TabIndex = 1
            Me.radButtonSaveLayout.Text = "Save Layout"
            ' 
            ' radButtonLoadLayout
            ' 
            Me.radButtonLoadLayout.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonLoadLayout.Location = New System.Drawing.Point(10, 122)
            Me.radButtonLoadLayout.Name = "radButtonLoadLayout"
            Me.radButtonLoadLayout.Size = New System.Drawing.Size(210, 24)
            Me.radButtonLoadLayout.TabIndex = 1
            Me.radButtonLoadLayout.Text = "Load Layout"
            ' 
            ' layoutControlSeparatorItem2
            ' 
            Me.layoutControlSeparatorItem2.Bounds = New System.Drawing.Rectangle(0, 244, 626, 4)
            Me.layoutControlSeparatorItem2.Name = "layoutControlSeparatorItem2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.Controls.Add(Me.radLayoutControl1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1094, 1039)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radLayoutControl1, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radLayoutControl1.ResumeLayout(False)
            DirectCast(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTextBox7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonAddMember, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonEditLayout, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
         
        Private radLayoutControl1 As Telerik.WinControls.UI.RadLayoutControl
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBoxControl
        Private radTextBox3 As Telerik.WinControls.UI.RadTextBoxControl
        Private radTextBox4 As Telerik.WinControls.UI.RadTextBoxControl
        Private layoutControlItem3 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem6 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem9 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlLabelItem10 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlLabelItem11 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlLabelItem12 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlLabelItem13 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private radButton1 As Telerik.WinControls.UI.RadButton
        Private radButton2 As Telerik.WinControls.UI.RadButton
        Private radTextBox2 As Telerik.WinControls.UI.RadTextBoxControl
        Private radTextBox5 As Telerik.WinControls.UI.RadTextBoxControl
        Private radTextBox6 As Telerik.WinControls.UI.RadTextBoxControl
        Private radTextBox7 As Telerik.WinControls.UI.RadTextBoxControl
        Private layoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlItem4 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem14 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem5 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlLabelItem15 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlItem17 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem18 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlItem19 As Telerik.WinControls.UI.LayoutControlItem
        Private layoutControlLabelItem2 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlSeparatorItem1 As Telerik.WinControls.UI.LayoutControlSeparatorItem
        Friend WithEvents radButtonAddMember As Telerik.WinControls.UI.RadButton
        Friend WithEvents radButtonEditLayout As Telerik.WinControls.UI.RadButton
        Friend WithEvents radButtonSaveLayout As Telerik.WinControls.UI.RadButton
        Friend WithEvents radButtonLoadLayout As Telerik.WinControls.UI.RadButton
        Private layoutControlLabelItem20 As Telerik.WinControls.UI.LayoutControlLabelItem
        Private layoutControlSeparatorItem2 As Telerik.WinControls.UI.LayoutControlSeparatorItem
    End Class
End Namespace