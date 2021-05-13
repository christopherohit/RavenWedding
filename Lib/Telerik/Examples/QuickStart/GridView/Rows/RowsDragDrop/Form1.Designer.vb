Namespace Telerik.Examples.WinControls.GridView.Rows.RowsDragDrop
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.gbProducts = New Telerik.WinControls.UI.RadGroupBox()
			Me.gridViewProducts = New Telerik.WinControls.UI.RadGridView()
			Me.gbBasket = New Telerik.WinControls.UI.RadGroupBox()
			Me.gridBasket = New Telerik.WinControls.UI.RadGridView()
			Me.imageList1 = New ImageList(Me.components)
			Me.btnCheckoutSelectedProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnCheckoutAllProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnReturnSelectedProducts = New Telerik.WinControls.UI.RadButton()
			Me.btnReturnAllProducts = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.gbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbProducts.SuspendLayout()
			CType(Me.gridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gbBasket, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbBasket.SuspendLayout()
			CType(Me.gridBasket, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridBasket.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnCheckoutSelectedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnCheckoutAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnReturnSelectedProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnReturnAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.btnCheckoutSelectedProducts)
			Me.settingsPanel.Controls.Add(Me.btnReturnAllProducts)
			Me.settingsPanel.Controls.Add(Me.btnReturnSelectedProducts)
			Me.settingsPanel.Controls.Add(Me.btnCheckoutAllProducts)
			Me.settingsPanel.Location = New Point(744, 1)
			Me.settingsPanel.Size = New Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.btnCheckoutAllProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnReturnSelectedProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnReturnAllProducts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnCheckoutSelectedProducts, 0)
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.gbProducts)
			Me.radPanel1.Controls.Add(Me.gbBasket)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New Padding(100)
			' 
			' 
			' 
			Me.radPanel1.RootElement.Padding = New Padding(100)
			Me.radPanel1.Size = New Size(1029, 519)
			Me.radPanel1.TabIndex = 1

			' 
			' gbProducts
			' 
			Me.gbProducts.AccessibleRole = AccessibleRole.Grouping
			Me.gbProducts.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.gbProducts.Controls.Add(Me.gridViewProducts)
			Me.gbProducts.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.gbProducts.HeaderText = "Products"
			Me.gbProducts.Location = New Point(103, 97)
			Me.gbProducts.Name = "gbProducts"
			Me.gbProducts.Padding = New Padding(10, 25, 10, 10)
			' 
			' 
			' 
			Me.gbProducts.RootElement.Padding = New Padding(10, 25, 10, 10)
			Me.gbProducts.Size = New Size(200, 319)
			Me.gbProducts.TabIndex = 0
			Me.gbProducts.Text = "Products"
			' 
			' gridViewProducts
			' 
			Me.gridViewProducts.Dock = DockStyle.Fill
			Me.gridViewProducts.Location = New Point(10, 25)
			' 
			' gridViewProducts
			' 
			Me.gridViewProducts.MasterTemplate.AllowAddNewRow = False
			Me.gridViewProducts.MasterTemplate.EnableGrouping = False
			Me.gridViewProducts.Name = "gridViewProducts"
			' 
			' 
			' 
			Me.gridViewProducts.ShowGroupPanel = False
			Me.gridViewProducts.Size = New Size(180, 284)
			Me.gridViewProducts.TabIndex = 0
			Me.gridViewProducts.Text = "radGridView1"
			' 
			' gbBasket
			' 
			Me.gbBasket.AccessibleRole = AccessibleRole.Grouping
			Me.gbBasket.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.gbBasket.Controls.Add(Me.gridBasket)
			Me.gbBasket.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.gbBasket.HeaderText = "Basket"
			Me.gbBasket.Location = New Point(330, 97)
			Me.gbBasket.Name = "gbBasket"
			Me.gbBasket.Padding = New Padding(10, 25, 10, 10)
			' 
			' 
			' 
			Me.gbBasket.RootElement.Padding = New Padding(10, 25, 10, 10)
			Me.gbBasket.Size = New Size(200, 319)
			Me.gbBasket.TabIndex = 1
			Me.gbBasket.Text = "Basket"
			' 
			' gridBasket
			' 
			Me.gridBasket.Dock = DockStyle.Fill
			Me.gridBasket.Location = New Point(10, 25)
			' 
			' gridBasket
			' 
			Me.gridBasket.MasterTemplate.AllowAddNewRow = False
			Me.gridBasket.MasterTemplate.EnableGrouping = False
			Me.gridBasket.Name = "gridBasket"
			' 
			' 
			' 
			Me.gridBasket.ShowGroupPanel = False
			Me.gridBasket.Size = New Size(180, 284)
			Me.gridBasket.TabIndex = 0
			Me.gridBasket.Text = "radGridView2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Banana.png")
			Me.imageList1.Images.SetKeyName(1, "Eggplant.png")
			Me.imageList1.Images.SetKeyName(2, "Mushroom.png")
			Me.imageList1.Images.SetKeyName(3, "Onion.png")
			Me.imageList1.Images.SetKeyName(4, "Pear.png")
			Me.imageList1.Images.SetKeyName(5, "Watermelon.png")
			Me.imageList1.Images.SetKeyName(6, "full-basket-icon.png")
			' 
			' btnCheckoutSelectedProducts
			' 
			Me.btnCheckoutSelectedProducts.Anchor = AnchorStyles.Top
			Me.btnCheckoutSelectedProducts.Location = New Point(10, 66)
			Me.btnCheckoutSelectedProducts.Name = "btnCheckoutSelectedProducts"
			Me.btnCheckoutSelectedProducts.Size = New Size(180, 24)
			Me.btnCheckoutSelectedProducts.TabIndex = 1
			Me.btnCheckoutSelectedProducts.Text = "Checkout Selected Products"

			' 
			' btnCheckoutAllProducts
			' 
			Me.btnCheckoutAllProducts.Anchor = AnchorStyles.Top
			Me.btnCheckoutAllProducts.Location = New Point(10, 96)
			Me.btnCheckoutAllProducts.Name = "btnCheckoutAllProducts"
			Me.btnCheckoutAllProducts.Size = New Size(180, 24)
			Me.btnCheckoutAllProducts.TabIndex = 2
			Me.btnCheckoutAllProducts.Text = "Checkout All Products"

			' 
			' btnReturnSelectedProducts
			' 
			Me.btnReturnSelectedProducts.Anchor = AnchorStyles.Top
			Me.btnReturnSelectedProducts.Location = New Point(10, 126)
			Me.btnReturnSelectedProducts.Name = "btnReturnSelectedProducts"
			Me.btnReturnSelectedProducts.Size = New Size(180, 24)
			Me.btnReturnSelectedProducts.TabIndex = 3
			Me.btnReturnSelectedProducts.Text = "Return Selected Products "

			' 
			' btnReturnAllProducts
			' 
			Me.btnReturnAllProducts.Anchor = AnchorStyles.Top
			Me.btnReturnAllProducts.Location = New Point(10, 156)
			Me.btnReturnAllProducts.Name = "btnReturnAllProducts"
			Me.btnReturnAllProducts.Size = New Size(180, 24)
			Me.btnReturnAllProducts.TabIndex = 4
			Me.btnReturnAllProducts.Text = "Return All Products"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1029, 519)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.gbProducts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbProducts.ResumeLayout(False)
			CType(Me.gridViewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gbBasket, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbBasket.ResumeLayout(False)
			CType(Me.gridBasket.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridBasket, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnCheckoutSelectedProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnCheckoutAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnReturnSelectedProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnReturnAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private gbProducts As Telerik.WinControls.UI.RadGroupBox
		Private gbBasket As Telerik.WinControls.UI.RadGroupBox
		Private gridViewProducts As Telerik.WinControls.UI.RadGridView
		Private gridBasket As Telerik.WinControls.UI.RadGridView
		Private imageList1 As ImageList
		Private btnReturnSelectedProducts As Telerik.WinControls.UI.RadButton
		Private btnCheckoutAllProducts As Telerik.WinControls.UI.RadButton
		Private btnCheckoutSelectedProducts As Telerik.WinControls.UI.RadButton
		Private btnReturnAllProducts As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
