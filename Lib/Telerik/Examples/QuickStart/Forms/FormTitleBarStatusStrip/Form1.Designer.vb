Namespace Telerik.Examples.WinControls.Forms.FormTitleBarStatusStrip
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
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radStatusBar1 = New Telerik.WinControls.UI.RadStatusStrip()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
			Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
			Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
			Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
			Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.timer1 = New Timer(Me.components)
			Me.radMenuItem21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem22 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem26 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radStatusBar1
			' 
			Me.radStatusBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.CommandBarSeparator3, Me.radLabelElement3, Me.CommandBarSeparator4, Me.radLabelElement2, Me.radProgressBarElement1, Me.CommandBarSeparator5, Me.radCheckBoxElement1, Me.CommandBarSeparator1, Me.radLabelElement1, Me.CommandBarSeparator2})
			Me.radStatusBar1.Location = New Point(0, 533)
			Me.radStatusBar1.Margin = New Padding(5)
			Me.radStatusBar1.Name = "radStatusBar1"
			Me.radStatusBar1.Size = New Size(745, 28)
			Me.radStatusBar1.TabIndex = 0
'			Me.radStatusBar1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.radStatusBar1_HelpRequested)
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusBar1"
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New Padding(2)
			CType(Me.radStatusBar1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New Size(0, 22)
			CType(Me.radStatusBar1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.StatusBarBoxLayout).Margin = New Padding(0, 0, 14, 0)
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Margin = New Padding(1)
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.Text = "Page 1 of 1"
			' 
			' CommandBarSeparator3
			' 
			Me.CommandBarSeparator3.AccessibleDescription = "CommandBarSeparator3"
			Me.CommandBarSeparator3.AccessibleName = "CommandBarSeparator3"
			Me.CommandBarSeparator3.Margin = New Padding(1)
			Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
			Me.CommandBarSeparator3.VisibleInOverflowMenu = False
			' 
			' radLabelElement3
			' 
			Me.radLabelElement3.ForeColor = Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(165)))), (CInt((CByte(165)))))
			Me.radLabelElement3.Margin = New Padding(1)
			Me.radLabelElement3.Name = "radLabelElement3"
			Me.radLabelElement3.Text = "Words: 2"
			Me.radLabelElement3.TextWrap = True
			' 
			' CommandBarSeparator4
			' 
			Me.CommandBarSeparator4.AccessibleDescription = "CommandBarSeparator4"
			Me.CommandBarSeparator4.AccessibleName = "CommandBarSeparator4"
			Me.CommandBarSeparator4.Margin = New Padding(1)
			Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
			Me.CommandBarSeparator4.VisibleInOverflowMenu = False
			' 
			' radLabelElement2
			' 
			Me.radLabelElement2.Margin = New Padding(1)
			Me.radLabelElement2.Name = "radLabelElement2"
			Me.radLabelElement2.Text = "Saving..."
			Me.radLabelElement2.TextWrap = True
			' 
			' radProgressBarElement1
			' 
			Me.radProgressBarElement1.AutoSize = False
			Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radProgressBarElement1.Bounds = New Rectangle(0, 0, 80, 20)
			Me.radProgressBarElement1.ClipDrawing = True
			Me.radProgressBarElement1.DefaultSize = New Size(80, 16)
			Me.radProgressBarElement1.Margin = New Padding(1)
			Me.radProgressBarElement1.Name = "radProgressBarElement1"
			Me.radProgressBarElement1.SeparatorColor1 = Color.White
			Me.radProgressBarElement1.SeparatorColor2 = Color.White
			Me.radProgressBarElement1.SeparatorColor3 = Color.White
			Me.radProgressBarElement1.SeparatorColor4 = Color.White
			Me.radProgressBarElement1.SeparatorGradientAngle = 0
			Me.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F
			Me.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F
			Me.radProgressBarElement1.SeparatorNumberOfColors = 2
			Me.radProgressBarElement1.Step = 1
			Me.radProgressBarElement1.StepWidth = 1
			Me.radProgressBarElement1.SweepAngle = 90
			' 
			' CommandBarSeparator5
			' 
			Me.CommandBarSeparator5.AccessibleDescription = "CommandBarSeparator5"
			Me.CommandBarSeparator5.AccessibleName = "CommandBarSeparator5"
			Me.CommandBarSeparator5.Margin = New Padding(1)
			Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
			Me.CommandBarSeparator5.VisibleInOverflowMenu = False
			' 
			' radCheckBoxElement1
			' 
			Me.radCheckBoxElement1.CanFocus = True
			Me.radCheckBoxElement1.Checked = False
			Me.radCheckBoxElement1.Margin = New Padding(1)
			Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
			Me.radCheckBoxElement1.ReadOnly = False
			Me.radCheckBoxElement1.ShowBorder = False
			Me.radCheckBoxElement1.Text = "Check for errors"
			' 
			' CommandBarSeparator1
			' 
			Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
			Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
			Me.CommandBarSeparator1.Margin = New Padding(1)
			Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
			Me.CommandBarSeparator1.VisibleInOverflowMenu = False
			' 
			' radLabelElement1
			' 
			Me.radLabelElement1.Margin = New Padding(1)
			Me.radLabelElement1.Name = "radLabelElement1"
			Me.radLabelElement1.Text = "English (US)"
			Me.radLabelElement1.TextWrap = True
			' 
			' CommandBarSeparator2
			' 
			Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
			Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
			Me.CommandBarSeparator2.Margin = New Padding(1)
			Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
			Me.CommandBarSeparator2.VisibleInOverflowMenu = False
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "50%"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "75%"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem9
			' 
			Me.radMenuItem9.Name = "radMenuItem9"
			Me.radMenuItem9.Text = "100%"
			Me.radMenuItem9.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem10
			' 
			Me.radMenuItem10.Name = "radMenuItem10"
			Me.radMenuItem10.Text = "200%"
			Me.radMenuItem10.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "radMenuItem3"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "radMenuItem4"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "radMenuItem5"
			Me.radMenuItem5.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.TextAlignment = ContentAlignment.MiddleLeft
			' 
			' radMenuItem6
			' 
			Me.radMenuItem6.Name = "radMenuItem6"
			Me.radMenuItem6.Text = "radMenuItem6"
			Me.radMenuItem6.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem7
			' 
			Me.radMenuItem7.Name = "radMenuItem7"
			Me.radMenuItem7.Text = "radMenuItem7"
			Me.radMenuItem7.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem8
			' 
			Me.radMenuItem8.Name = "radMenuItem8"
			Me.radMenuItem8.Text = "radMenuItem8"
			Me.radMenuItem8.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 25
			' 
			' radMenuItem21
			' 
			Me.radMenuItem21.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem22, Me.radMenuItem26, Me.radMenuItem12})
			Me.radMenuItem21.Name = "radMenuItem21"
			Me.radMenuItem21.Text = "Change Theme"
			' 
			' radMenuItem22
			' 
			Me.radMenuItem22.Name = "radMenuItem22"
			Me.radMenuItem22.Tag = "Office2010Blue"
			Me.radMenuItem22.Text = "Office2010 Blue"
			' 
			' radMenuItem26
			' 
			Me.radMenuItem26.Name = "radMenuItem26"
			Me.radMenuItem26.Tag = "Desert"
			Me.radMenuItem26.Text = "Desert"
			' 
			' radMenuItem12
			' 
			Me.radMenuItem12.IsChecked = True
			Me.radMenuItem12.Name = "radMenuItem12"
			Me.radMenuItem12.Tag = "TelerikMetro"
			Me.radMenuItem12.Text = "TelerikMetro"
			Me.radMenuItem12.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radMenuItem13
			' 
			Me.radMenuItem13.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem13.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem17})
			Me.radMenuItem13.Name = "radMenuItem13"
			Me.radMenuItem13.Text = "About"
			Me.radMenuItem13.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radMenuItem17
			' 
			Me.radMenuItem17.Name = "radMenuItem17"
			Me.radMenuItem17.Padding = New Padding(3, 1, 3, 1)
			Me.radMenuItem17.Text = "Telerik® UI for WinForms"
			Me.radMenuItem17.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButton3
			' 
			Me.radButton3.Location = New Point(2, 59)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New Size(124, 23)
			Me.radButton3.TabIndex = 0
			Me.radButton3.Text = "RadButton3"
'			Me.radButton3.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.Button_HelpRequested)
			' 
			' radButton2
			' 
			Me.radButton2.Location = New Point(2, 30)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(124, 23)
			Me.radButton2.TabIndex = 0
			Me.radButton2.Text = "RadButton2"
'			Me.radButton2.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.Button_HelpRequested)
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(2, 1)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(124, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "RadButton1"
'			Me.radButton1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.Button_HelpRequested)
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radGridView1.Location = New Point(12, 54)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			gridViewImageColumn1.DataType = GetType(Byte())
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.ImageLayout = ImageLayout.Zoom
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.Name = "Photo"
			gridViewImageColumn1.Width = 62
			gridViewTextBoxColumn1.FieldName = "LastName"
			gridViewTextBoxColumn1.HeaderText = "Last Name"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "LastName"
			gridViewTextBoxColumn1.Width = 93
			gridViewTextBoxColumn2.FieldName = "FirstName"
			gridViewTextBoxColumn2.HeaderText = "First Name"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "FirstName"
			gridViewTextBoxColumn2.Width = 93
			gridViewTextBoxColumn3.FieldName = "Title"
			gridViewTextBoxColumn3.HeaderText = "Title"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "Title"
			gridViewTextBoxColumn3.Width = 85
			gridViewDateTimeColumn1.CustomFormat = ""
			gridViewDateTimeColumn1.FieldName = "HireDate"
			gridViewDateTimeColumn1.Format = DateTimePickerFormat.Custom
			gridViewDateTimeColumn1.FormatString = "{0:M\/d\/yyyy}"
			gridViewDateTimeColumn1.HeaderText = "Hire Date"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "HireDate"
			gridViewDateTimeColumn1.Width = 82
			gridViewTextBoxColumn4.FieldName = "City"
			gridViewTextBoxColumn4.HeaderText = "City"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "City"
			gridViewTextBoxColumn4.Width = 58
			gridViewTextBoxColumn5.FieldName = "Country"
			gridViewTextBoxColumn5.HeaderText = "Country"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "Country"
			gridViewTextBoxColumn5.Width = 73
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewImageColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewDateTimeColumn1, gridViewTextBoxColumn4, gridViewTextBoxColumn5})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(561, 462)
			Me.radGridView1.TabIndex = 5
'			Me.radGridView1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.radGridView1_HelpRequested)
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' radMenu1
			' 
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = Color.Transparent
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem21, Me.radMenuItem13})
			Me.radMenu1.Location = New Point(0, 0)
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.Size = New Size(745, 20)
			Me.radMenu1.TabIndex = 3
'			Me.radMenu1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.radMenu1_HelpRequested)
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.ItemSizeMode = (CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode))
			Me.radPageView1.Location = New Point(585, 54)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage3
			Me.radPageView1.Size = New Size(148, 301)
			Me.radPageView1.TabIndex = 6
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
'			Me.radPageView1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.radPageView1_HelpRequested)
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radButton3)
			Me.radPageViewPage1.Controls.Add(Me.radButton2)
			Me.radPageViewPage1.Controls.Add(Me.radButton1)
			Me.radPageViewPage1.ItemSize = New SizeF(148F, 32F)
			Me.radPageViewPage1.Location = New Point(5, 29)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New Size(138, 175)
			Me.radPageViewPage1.Text = "Buttons"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox3)
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox2)
			Me.radPageViewPage2.Controls.Add(Me.radCheckBox1)
			Me.radPageViewPage2.ItemSize = New SizeF(148F, 32F)
			Me.radPageViewPage2.Location = New Point(5, 29)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New Size(138, 175)
			Me.radPageViewPage2.Text = "Check Boxes"
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.Location = New Point(3, 51)
			Me.radCheckBox3.Name = "radCheckBox3"
			Me.radCheckBox3.Size = New Size(91, 18)
			Me.radCheckBox3.TabIndex = 2
			Me.radCheckBox3.Text = "radCheckBox3"
'			Me.radCheckBox3.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.CheckBox_HelpRequested)
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.Location = New Point(3, 27)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(91, 18)
			Me.radCheckBox2.TabIndex = 1
			Me.radCheckBox2.Text = "radCheckBox2"
'			Me.radCheckBox2.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.CheckBox_HelpRequested)
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New Point(3, 3)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(91, 18)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "radCheckBox1"
'			Me.radCheckBox1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.CheckBox_HelpRequested)
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton3)
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton2)
			Me.radPageViewPage3.Controls.Add(Me.radRadioButton1)
			Me.radPageViewPage3.ItemSize = New SizeF(148F, 32F)
			Me.radPageViewPage3.Location = New Point(5, 29)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New Size(138, 175)
			Me.radPageViewPage3.Text = "Radio Buttons"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Location = New Point(4, 53)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.Size = New Size(105, 18)
			Me.radRadioButton3.TabIndex = 2
			Me.radRadioButton3.Text = "radRadioButton3"
'			Me.radRadioButton3.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.RadioButton_HelpRequested)
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New Point(4, 29)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(105, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "radRadioButton2"
'			Me.radRadioButton2.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.RadioButton_HelpRequested)
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.CheckState = CheckState.Checked
			Me.radRadioButton1.Location = New Point(4, 4)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(105, 18)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.Text = "radRadioButton1"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radRadioButton1.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.RadioButton_HelpRequested)
			' 
			' Form1
			' 
			Me.AutoScaleMode = AutoScaleMode.None
			Me.AutoScroll = True
			Me.ClientSize = New Size(745, 561)
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(Me.radMenu1)
			Me.Controls.Add(Me.radStatusBar1)
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.SizeGripStyle = SizeGripStyle.Hide
			Me.Text = "RadForm Example"
			Me.ThemeName = "TelerikMetro"
			CType(Me.radStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage2.PerformLayout()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			Me.radPageViewPage3.PerformLayout()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radStatusBar1 As Telerik.WinControls.UI.RadStatusStrip
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
		Private CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private timer1 As Timer
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuItem6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem10 As Telerik.WinControls.UI.RadMenuItem
		Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
		Private CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radMenuItem13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem17 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private radMenuItem21 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem22 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem26 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesBindingSource As BindingSource
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private radMenuItem12 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenu1 As Telerik.WinControls.UI.RadMenu
		Private WithEvents radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace