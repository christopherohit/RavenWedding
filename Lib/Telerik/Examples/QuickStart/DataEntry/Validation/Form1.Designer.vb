Namespace Telerik.Examples.WinControls.DataEntry.Validation
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
			Me.radBindingNavigator1 = New Telerik.WinControls.UI.RadBindingNavigator()
			Me.radBindingNavigator1RowElement = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.radBindingNavigator1FirstStrip = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radBindingNavigator1MoveFirstItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.commandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radBindingNavigator1MovePreviousItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.commandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radBindingNavigator1PositionItem = New Telerik.WinControls.UI.CommandBarTextBox()
			Me.radBindingNavigator1CountItem = New Telerik.WinControls.UI.CommandBarLabel()
			Me.commandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radBindingNavigator1MoveNextItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.commandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radBindingNavigator1MoveLastItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.radBindingNavigator1SecondStrip = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.radBindingNavigator1AddNewItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.commandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
			Me.radBindingNavigator1DeleteItem = New Telerik.WinControls.UI.CommandBarButton()
			Me.bindingSource1 = New BindingSource(Me.components)
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDataEntry1.SuspendLayout()
			CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radDropDownList1)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New Point(622, 3)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radDataEntry1)
			Me.radPanel1.Controls.Add(Me.radBindingNavigator1)
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(480, 350)
			Me.radPanel1.TabIndex = 2
			' 
			' radDataEntry1
			' 
			Me.radDataEntry1.Dock = DockStyle.Fill
			Me.radDataEntry1.FlowDirection = FlowDirection.LeftToRight
			Me.radDataEntry1.Location = New Point(0, 30)
			Me.radDataEntry1.Name = "radDataEntry1"
			' 
			' radDataEntry1.PanelContainer
			' 
			Me.radDataEntry1.PanelContainer.Size = New Size(478, 318)
			Me.radDataEntry1.Size = New Size(480, 320)
			Me.radDataEntry1.TabIndex = 1
			Me.radDataEntry1.Text = "radDataEntry1"
			' 
			' radBindingNavigator1
			' 
			Me.radBindingNavigator1.Dock = DockStyle.Top
			Me.radBindingNavigator1.Location = New Point(0, 0)
			Me.radBindingNavigator1.Name = "radBindingNavigator1"
			Me.radBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.radBindingNavigator1RowElement})
			Me.radBindingNavigator1.Size = New Size(480, 30)
			Me.radBindingNavigator1.TabIndex = 2
			Me.radBindingNavigator1.Text = "radBindingNavigator1"
			' 
			' radBindingNavigator1RowElement
			' 
			Me.radBindingNavigator1RowElement.MinSize = New Size(25, 25)
			Me.radBindingNavigator1RowElement.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.radBindingNavigator1FirstStrip, Me.radBindingNavigator1SecondStrip})
			' 
			' radBindingNavigator1FirstStrip
			' 
			Me.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip"
			Me.radBindingNavigator1FirstStrip.EnableDragging = False
			' 
			' 
			' 
			Me.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			Me.radBindingNavigator1FirstStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radBindingNavigator1MoveFirstItem, Me.commandBarSeparator1, Me.radBindingNavigator1MovePreviousItem, Me.commandBarSeparator2, Me.radBindingNavigator1PositionItem, Me.radBindingNavigator1CountItem, Me.commandBarSeparator3, Me.radBindingNavigator1MoveNextItem, Me.commandBarSeparator4, Me.radBindingNavigator1MoveLastItem})
			Me.radBindingNavigator1FirstStrip.MinSize = New Size(0, 0)
			' 
			' 
			' 
			Me.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radBindingNavigator1FirstStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radBindingNavigator1FirstStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radBindingNavigator1MoveFirstItem
			' 
			Me.radBindingNavigator1MoveFirstItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveFirstItem.Image"), Image))
			Me.radBindingNavigator1MoveFirstItem.Margin = New Padding(3, 0, 0, 0)
			Me.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem"
			Me.radBindingNavigator1MoveFirstItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' commandBarSeparator1
			' 
			Me.commandBarSeparator1.Name = "commandBarSeparator1"
			Me.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator1.VisibleInOverflowMenu = False
			' 
			' radBindingNavigator1MovePreviousItem
			' 
			Me.radBindingNavigator1MovePreviousItem.Image = (CType(resources.GetObject("radBindingNavigator1MovePreviousItem.Image"), Image))
			Me.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem"
			Me.radBindingNavigator1MovePreviousItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' commandBarSeparator2
			' 
			Me.commandBarSeparator2.Name = "commandBarSeparator2"
			Me.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator2.VisibleInOverflowMenu = False
			' 
			' radBindingNavigator1PositionItem
			' 
			Me.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem"
			Me.radBindingNavigator1PositionItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radBindingNavigator1CountItem
			' 
			Me.radBindingNavigator1CountItem.AccessibleDescription = "of {0}"
			Me.radBindingNavigator1CountItem.AccessibleName = "of {0}"
			Me.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem"
			Me.radBindingNavigator1CountItem.Text = "of {0}"
			Me.radBindingNavigator1CountItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' commandBarSeparator3
			' 
			Me.commandBarSeparator3.Name = "commandBarSeparator3"
			Me.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator3.VisibleInOverflowMenu = False
			' 
			' radBindingNavigator1MoveNextItem
			' 
			Me.radBindingNavigator1MoveNextItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveNextItem.Image"), Image))
			Me.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem"
			Me.radBindingNavigator1MoveNextItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' commandBarSeparator4
			' 
			Me.commandBarSeparator4.Name = "commandBarSeparator4"
			Me.commandBarSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator4.VisibleInOverflowMenu = False
			' 
			' radBindingNavigator1MoveLastItem
			' 
			Me.radBindingNavigator1MoveLastItem.Image = (CType(resources.GetObject("radBindingNavigator1MoveLastItem.Image"), Image))
			Me.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem"
			Me.radBindingNavigator1MoveLastItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radBindingNavigator1SecondStrip
			' 
			Me.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip"
			Me.radBindingNavigator1SecondStrip.EnableDragging = False
			' 
			' 
			' 
			Me.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			Me.radBindingNavigator1SecondStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.radBindingNavigator1AddNewItem, Me.commandBarSeparator5, Me.radBindingNavigator1DeleteItem})
			Me.radBindingNavigator1SecondStrip.MinSize = New Size(0, 0)
			' 
			' 
			' 
			Me.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radBindingNavigator1SecondStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radBindingNavigator1SecondStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radBindingNavigator1AddNewItem
			' 
			Me.radBindingNavigator1AddNewItem.Image = (CType(resources.GetObject("radBindingNavigator1AddNewItem.Image"), Image))
			Me.radBindingNavigator1AddNewItem.Margin = New Padding(3, 0, 0, 0)
			Me.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem"
			Me.radBindingNavigator1AddNewItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' commandBarSeparator5
			' 
			Me.commandBarSeparator5.Name = "commandBarSeparator5"
			Me.commandBarSeparator5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.commandBarSeparator5.VisibleInOverflowMenu = False
			' 
			' radBindingNavigator1DeleteItem
			' 
			Me.radBindingNavigator1DeleteItem.Image = (CType(resources.GetObject("radBindingNavigator1DeleteItem.Image"), Image))
			Me.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem"
			Me.radBindingNavigator1DeleteItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' bindingSource1
			' 
			Me.bindingSource1.AllowNew = False
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 32)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(67, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Validate on :"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Selected = True
			radListDataItem1.Text = "ItemValidating"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "ItemValidated"
			radListDataItem2.TextWrap = True
			Me.radDropDownList1.Items.Add(radListDataItem1)
			Me.radDropDownList1.Items.Add(radListDataItem2)
			Me.radDropDownList1.Location = New Point(10, 56)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(210, 20)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.Tag = "Right"
			Me.radDropDownList1.SelectedIndex = 0
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1348, 917)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDataEntry1.ResumeLayout(False)
			CType(Me.radBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radDataEntry1 As Telerik.WinControls.UI.RadDataEntry
		Private bindingSource1 As BindingSource
		Private radBindingNavigator1 As Telerik.WinControls.UI.RadBindingNavigator
		Private radBindingNavigator1RowElement As Telerik.WinControls.UI.CommandBarRowElement
		Private radBindingNavigator1FirstStrip As Telerik.WinControls.UI.CommandBarStripElement
		Private radBindingNavigator1MoveFirstItem As Telerik.WinControls.UI.CommandBarButton
		Private commandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
		Private radBindingNavigator1MovePreviousItem As Telerik.WinControls.UI.CommandBarButton
		Private commandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
		Private radBindingNavigator1PositionItem As Telerik.WinControls.UI.CommandBarTextBox
		Private radBindingNavigator1CountItem As Telerik.WinControls.UI.CommandBarLabel
		Private commandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
		Private radBindingNavigator1MoveNextItem As Telerik.WinControls.UI.CommandBarButton
		Private commandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
		Private radBindingNavigator1MoveLastItem As Telerik.WinControls.UI.CommandBarButton
		Private radBindingNavigator1SecondStrip As Telerik.WinControls.UI.CommandBarStripElement
		Private radBindingNavigator1AddNewItem As Telerik.WinControls.UI.CommandBarButton
		Private commandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
		Private radBindingNavigator1DeleteItem As Telerik.WinControls.UI.CommandBarButton
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace