Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.Sorting
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.customersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButtonTitleCountryCity = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonContactTitleCity = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonCountry = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonCity = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonContactTitle = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonContactName = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonPostalCode = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonDesc = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonAsc = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabelCol = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButtonTitleCountryCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonContactTitleCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonContactTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonContactName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonDesc, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonAsc, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radLabelCol, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.ForeColor = System.Drawing.Color.White
			Me.settingsPanel.Location = New System.Drawing.Point(779, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.White
			Me.settingsPanel.Size = New System.Drawing.Size(200, 784)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGridView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(120, 134)
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowDragToGroup = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.EnableGrouping = False
			Me.radGridView1.MasterTemplate.ShowGroupedColumns = True
			Me.radGridView1.Name = "radGridView1"
			' 
			' 
			' 
			Me.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Size = New System.Drawing.Size(740, 547)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			Me.radGridView1.ThemeName = "Telerik"
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindRadGridView
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonTitleCountryCity)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonContactTitleCity)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonCountry)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonCity)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonContactTitle)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonContactName)
			Me.radGroupBox1.Controls.Add(Me.radRadioButtonPostalCode)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox1.HeaderText = "Sort By"
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 204)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Sort By"
			' 
			' radRadioButtonTitleCountryCity
			' 
			Me.radRadioButtonTitleCountryCity.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonTitleCountryCity.Location = New System.Drawing.Point(22, 161)
			Me.radRadioButtonTitleCountryCity.Name = "radRadioButtonTitleCountryCity"
			Me.radRadioButtonTitleCountryCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonTitleCountryCity.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonTitleCountryCity.Size = New System.Drawing.Size(132, 16)
			Me.radRadioButtonTitleCountryCity.TabIndex = 5
			Me.radRadioButtonTitleCountryCity.Text = "Title, Country and City"
'			Me.radRadioButtonTitleCountryCity.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonContactTitleCity
			' 
			Me.radRadioButtonContactTitleCity.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactTitleCity.Location = New System.Drawing.Point(22, 139)
			Me.radRadioButtonContactTitleCity.Name = "radRadioButtonContactTitleCity"
			Me.radRadioButtonContactTitleCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonContactTitleCity.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactTitleCity.Size = New System.Drawing.Size(128, 16)
			Me.radRadioButtonContactTitleCity.TabIndex = 5
			Me.radRadioButtonContactTitleCity.Text = "Contact Title and City"
'			Me.radRadioButtonContactTitleCity.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonCountry
			' 
			Me.radRadioButtonCountry.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCountry.Location = New System.Drawing.Point(22, 96)
			Me.radRadioButtonCountry.Name = "radRadioButtonCountry"
			Me.radRadioButtonCountry.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonCountry.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCountry.Size = New System.Drawing.Size(60, 16)
			Me.radRadioButtonCountry.TabIndex = 5
			Me.radRadioButtonCountry.Text = "Country"
'			Me.radRadioButtonCountry.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonCity
			' 
			Me.radRadioButtonCity.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCity.Location = New System.Drawing.Point(22, 74)
			Me.radRadioButtonCity.Name = "radRadioButtonCity"
			Me.radRadioButtonCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonCity.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonCity.Size = New System.Drawing.Size(40, 16)
			Me.radRadioButtonCity.TabIndex = 5
			Me.radRadioButtonCity.Text = "City"
'			Me.radRadioButtonCity.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonContactTitle
			' 
			Me.radRadioButtonContactTitle.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactTitle.Location = New System.Drawing.Point(22, 52)
			Me.radRadioButtonContactTitle.Name = "radRadioButtonContactTitle"
			Me.radRadioButtonContactTitle.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonContactTitle.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactTitle.Size = New System.Drawing.Size(84, 16)
			Me.radRadioButtonContactTitle.TabIndex = 5
			Me.radRadioButtonContactTitle.Text = "Contact Title"
'			Me.radRadioButtonContactTitle.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonContactName
			' 
			Me.radRadioButtonContactName.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactName.Location = New System.Drawing.Point(22, 30)
			Me.radRadioButtonContactName.Name = "radRadioButtonContactName"
			Me.radRadioButtonContactName.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonContactName.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonContactName.Size = New System.Drawing.Size(92, 16)
			Me.radRadioButtonContactName.TabIndex = 5
			Me.radRadioButtonContactName.Text = "Contact Name"
'			Me.radRadioButtonContactName.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonPostalCode
			' 
			Me.radRadioButtonPostalCode.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonPostalCode.Location = New System.Drawing.Point(22, 118)
			Me.radRadioButtonPostalCode.Name = "radRadioButtonPostalCode"
			Me.radRadioButtonPostalCode.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonPostalCode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonPostalCode.Size = New System.Drawing.Size(82, 16)
			Me.radRadioButtonPostalCode.TabIndex = 5
			Me.radRadioButtonPostalCode.Text = "Postal Code"
'			Me.radRadioButtonPostalCode.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonNone
			' 
			Me.radRadioButtonNone.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonNone.Location = New System.Drawing.Point(22, 81)
			Me.radRadioButtonNone.Name = "radRadioButtonNone"
			Me.radRadioButtonNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonNone.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonNone.Size = New System.Drawing.Size(47, 16)
			Me.radRadioButtonNone.TabIndex = 7
			Me.radRadioButtonNone.Text = "None"
			' 
			' radRadioButtonDesc
			' 
			Me.radRadioButtonDesc.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonDesc.Location = New System.Drawing.Point(22, 59)
			Me.radRadioButtonDesc.Name = "radRadioButtonDesc"
			Me.radRadioButtonDesc.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonDesc.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonDesc.Size = New System.Drawing.Size(80, 16)
			Me.radRadioButtonDesc.TabIndex = 6
			Me.radRadioButtonDesc.Text = "Descending"
'			Me.radRadioButtonDesc.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radRadioButtonAsc
			' 
			Me.radRadioButtonAsc.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonAsc.Location = New System.Drawing.Point(22, 36)
			Me.radRadioButtonAsc.Name = "radRadioButtonAsc"
			Me.radRadioButtonAsc.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButtonAsc.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButtonAsc.Size = New System.Drawing.Size(73, 16)
			Me.radRadioButtonAsc.TabIndex = 5
			Me.radRadioButtonAsc.Text = "Ascending"
'			Me.radRadioButtonAsc.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButtonAsc_ToggleStateChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLabel1.ForeColor = System.Drawing.Color.White
			Me.radLabel1.Location = New System.Drawing.Point(120, 114)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.White
			Me.radLabel1.Size = New System.Drawing.Size(90, 14)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Grid is sorted by:"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonNone)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonAsc)
			Me.radGroupBox2.Controls.Add(Me.radRadioButtonDesc)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBox2.HeaderText = "Sort Direction"
			Me.radGroupBox2.Location = New System.Drawing.Point(15, 218)
			Me.radGroupBox2.Name = "radGroupBox2"
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.Size = New System.Drawing.Size(162, 126)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Sort Direction"
			' 
			' radLabelCol
			' 
			Me.radLabelCol.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLabelCol.ForeColor = System.Drawing.Color.Black
			Me.radLabelCol.Location = New System.Drawing.Point(223, 114)
			Me.radLabelCol.Name = "radLabelCol"
			' 
			' 
			' 
			Me.radLabelCol.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabelCol.Size = New System.Drawing.Size(76, 14)
			Me.radLabelCol.TabIndex = 2
			Me.radLabelCol.Text = "Contact Name"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radLabelCol)
			Me.ForeColor = System.Drawing.Color.White
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 786)
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			Me.Controls.SetChildIndex(Me.radLabelCol, 0)
			Me.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioButtonTitleCountryCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonContactTitleCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonContactTitle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonContactName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonDesc, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonAsc, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radLabelCol, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private customersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButtonDesc As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonAsc As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonNone As Telerik.WinControls.UI.RadRadioButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioButtonCountry As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonCity As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonContactTitle As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonContactName As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonPostalCode As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonTitleCountryCity As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButtonContactTitleCity As Telerik.WinControls.UI.RadRadioButton
		Private radLabelCol As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace