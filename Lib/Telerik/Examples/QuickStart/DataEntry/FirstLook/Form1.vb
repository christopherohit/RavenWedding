Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataEntry.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radPanel1
            SetupControls()
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Me.IsTouchTheme() Then
                Dim newItemSize As Size = New Size(300, 32)

                If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                    newItemSize.Height = 36
                End If

                Me.radDataEntry1.ItemDefaultSize = newItemSize
                Me.radPanel1.Size = TelerikDpiHelper.ScaleSize(New Size(620, 571), Me.radDataEntry1.RootElement.DpiScaleFactor)
                Me.SuspendLayout()
                Me.radDataEntry1.DataSource = Nothing
                Me.radDataEntry1.DataSource = Me.bindingSource1
                Me.ResumeLayout()
            End If
        End Sub

        Private Sub SetupControls()
            Me.SuspendLayout()
            AddHandler Me.radDataEntry1.ItemInitializing, New ItemInitializingEventHandler(AddressOf radDataEntry1_ItemInitializing)
            AddHandler Me.radDataEntry1.EditorInitializing, New EditorInitializingEventHandler(AddressOf radDataEntry1_EditorInitializing)
            AddHandler Me.radDataEntry1.BindingCreating, New BindingCreatingEventHandler(AddressOf radDataEntry1_BindingCreating)
            AddHandler Me.radDataEntry1.BindingCreated, New BindingCreatedEventHandler(AddressOf radDataEntry1_BindingCreated)
            Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)
            Me.bindingSource1.AllowNew = True
            Me.radBindingNavigator1.BindingSource = Me.bindingSource1
            AddHandler Me.radBindingNavigator1AddNewItem.Click, New EventHandler(AddressOf radBindingNavigator1AddNewItem_Click)
            AddHandler Me.radBindingNavigator1.ContextMenuOpening, AddressOf radBindingNavigator1_ContextMenuOpening
            Me.radDataEntry1.DataSource = Me.bindingSource1
            Me.ResumeLayout()
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

        Private Sub radDataEntry1_BindingCreated(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.BindingCreatedEventArgs)
            If e.DataMember = "Photo" Then
                AddHandler e.Binding.Format, New ConvertEventHandler(AddressOf Binding_Format)
            End If
        End Sub

        Private Sub radDataEntry1_BindingCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.BindingCreatingEventArgs)
            If e.DataMember = "Photo" Then
                e.PropertyName = "Image"
            End If
        End Sub

        Private Sub Binding_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
            Dim img As Image = Telerik.WinControls.ImageHelper.GetImageFromBytes(CType(e.Value, Byte()))
            e.Value = img
        End Sub

        Private Sub radDataEntry1_EditorInitializing(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.EditorInitializingEventArgs)
            If e.[Property].Name = "Photo" Then
                Dim pictureBox As PictureBox = New PictureBox()
                pictureBox.Dock = DockStyle.Fill
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
                e.Editor = pictureBox
            End If
        End Sub

        Private Sub radDataEntry1_ItemInitializing(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ItemInitializingEventArgs)
            If e.Panel.Controls(1).Text = "Photo" Then
                e.Panel.Location = New Point(8, 200)
                e.Panel.Size = New Size(500, 220)

                If Me.IsTouchTheme() Then
                    e.Panel.Location = New Point(8, 300)
                End If
            End If
        End Sub

        Private Sub radBindingNavigator1_ContextMenuOpening(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = True
        End Sub

        Private Function IsTouchTheme() As Boolean
            Return TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) OrElse Me.CurrentThemeName = "TelerikMetroTouch"
        End Function
    End Class
End Namespace
