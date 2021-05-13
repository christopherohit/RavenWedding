Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataLayout.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radPanel1
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            SetupControls()
            ArrangePictureBox()
        End Sub

        Private Sub SetupControls()
            Me.radDataLayout1.AutoSizeLabels = True
            AddHandler Me.radDataLayout1.EditorInitializing, New Telerik.WinControls.UI.EditorInitializingEventHandler(AddressOf radDataEntry1_EditorInitializing)
            AddHandler Me.radDataLayout1.BindingCreating, New Telerik.WinControls.UI.BindingCreatingEventHandler(AddressOf radDataEntry1_BindingCreating)
            AddHandler Me.radDataLayout1.BindingCreated, New Telerik.WinControls.UI.BindingCreatedEventHandler(AddressOf radDataEntry1_BindingCreated)
            Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)
            Me.bindingSource1.AllowNew = True
            Me.radBindingNavigator1.BindingSource = Me.bindingSource1
            Me.radBindingNavigator1.AutoHandleAddNew = False
            AddHandler Me.radBindingNavigator1.ContextMenuOpening, AddressOf radBindingNavigator1_ContextMenuOpening
            AddHandler Me.radBindingNavigator1AddNewItem.Click, New EventHandler(AddressOf radBindingNavigator1AddNewItem_Click)
            Me.radDataLayout1.DataSource = Me.bindingSource1
        End Sub

        Private Sub ArrangePictureBox()
            Dim layoutControl As RadLayoutControl = Me.radDataLayout1.LayoutControl
            layoutControl.AddItem(CType(layoutControl.Items(5), LayoutControlItemBase), CType(layoutControl.Items(11), LayoutControlItemBase), LayoutControlDropPosition.Top)
            layoutControl.ResizeItem(CType(layoutControl.Items(5), LayoutControlItemBase), 22 - layoutControl.Items(5).Bounds.Height)
        End Sub

        Private Sub radBindingNavigator1AddNewItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim row As Telerik.Examples.WinControls.DataSources.FurnitureDataSet.ProductsRow = Me.furnitureDataSet.Products.NewProductsRow()
            row.Price = 0
            row.Photo = ImageHelper.GetBytesFromImage(My.Resources.insert5)
            row.Lining = String.Empty
            row.Manufacturer = String.Empty
            row.ProductName = String.Empty
            row.Quantity = 0
            row.SalesRepresentative = String.Empty
            row.Front = String.Empty
            row.Dimensions = String.Empty
            row.Condition = False
            Me.furnitureDataSet.Products.Rows.Add(row)
            Me.furnitureDataSet.AcceptChanges()
            productsTableAdapter.Update(Me.furnitureDataSet.Products)
            Me.bindingSource1.Position = Me.bindingSource1.Count - 1
        End Sub

        Private Sub radDataEntry1_BindingCreated(ByVal sender As Object, ByVal e As BindingCreatedEventArgs)
            If e.DataMember = "Photo" Then
                AddHandler e.Binding.Format, New ConvertEventHandler(AddressOf Binding_Format)
            End If
        End Sub

        Private Sub radDataEntry1_BindingCreating(ByVal sender As Object, ByVal e As BindingCreatingEventArgs)
            If e.DataMember = "Photo" Then
                e.PropertyName = "Image"
            End If
        End Sub

        Private Sub Binding_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
            Dim img As Image = ImageHelper.GetImageFromBytes(CType(e.Value, Byte()))
            e.Value = img
        End Sub

        Private Sub radDataEntry1_EditorInitializing(ByVal sender As Object, ByVal e As EditorInitializingEventArgs)
            If e.[Property].Name = "Photo" Then
                Dim pictureBox As PictureBox = New PictureBox()
                pictureBox.Name = "PictureBoxPhoto"
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
                e.Editor = pictureBox
            End If
        End Sub

        Private Sub radButtonCustomize_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radDataLayout1.LayoutControl.ShowCustomizeDialog()
        End Sub

        Private Sub radButtonSaveLayout_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using sfd As SaveFileDialog = New SaveFileDialog()
                sfd.DefaultExt = ".xml"
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"

                If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.radDataLayout1.LayoutControl.SaveLayout(sfd.FileName)
                End If
            End Using
        End Sub

        Private Sub radButtonLoadLayout_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using ofd As OpenFileDialog = New OpenFileDialog()
                ofd.DefaultExt = ".xml"
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"

                If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.radDataLayout1.LayoutControl.LoadLayout(ofd.FileName)
                End If
            End Using
        End Sub

        Private Sub radBindingNavigator1_ContextMenuOpening(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = True
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Me.IsTouchTheme() Then
                Dim newItemSize As Integer = 36

                If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                    newItemSize = 40
                End If

                Me.radDataLayout1.ItemDefaultHeight = newItemSize
                Me.radPanel1.Size = TelerikDpiHelper.ScaleSize(New Size(629, 602), Me.radDataLayout1.RootElement.DpiScaleFactor)
                Me.SuspendLayout()
                Me.radDataLayout1.DataSource = Nothing
                Me.radDataLayout1.DataSource = Me.bindingSource1
                Me.ResumeLayout()
            End If
        End Sub

        Private Function IsTouchTheme() As Boolean
            Return TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) OrElse Me.CurrentThemeName = "TelerikMetroTouch"
        End Function
    End Class
End Namespace
