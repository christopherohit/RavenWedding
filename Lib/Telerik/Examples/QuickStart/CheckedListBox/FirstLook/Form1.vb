Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.CheckedListBox.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.InitializeData()
            Dim nameColumn As ListViewDetailColumn = New ListViewDetailColumn("Product")
            nameColumn.Width = 132
            Me.radListView1.Columns.Add(nameColumn)
            Dim priceColumn As ListViewDetailColumn = New ListViewDetailColumn("Price")
            priceColumn.Width = 60
            Me.radListView1.Columns.Add(priceColumn)
            Dim totalColumn As ListViewDetailColumn = New ListViewDetailColumn("Total")
            totalColumn.Width = 132
            Me.radListView2.Columns.Add(totalColumn)
            Dim totalPriceColumn As ListViewDetailColumn = New ListViewDetailColumn("TotalPrice")
            totalPriceColumn.Width = 60
            Me.radListView2.Columns.Add(totalPriceColumn)
            AddHandler Me.radListView1.CellFormatting, AddressOf radListView1_CellFormatting
            AddHandler Me.radListView2.CellFormatting, AddressOf radListView2_CellFormatting
            AddHandler Me.radCheckedListBox1.VisualItemFormatting, AddressOf radCheckedListBox1_VisualItemFormatting
            AddHandler Me.radCheckedListBox1.SelectedItemsChanged, AddressOf radCheckedListBox1_SelectedItemsChanged
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ListViewDataItem = New ListViewDataItem()
            Me.radListView2.Items.Add(item)
            item("Total") = "Total"
            item("TotalPrice") = String.Format("{0:C2}", 0)
        End Sub

        Private Sub InitializeData()
            Dim mealProducts As IEnumerable(Of Product) = Me.CreateProducts()

            For Each product As Product In mealProducts
                Me.radCheckedListBox1.Items.Add(Me.CreateItem(product))
            Next
        End Sub

        Private Function CreateProducts() As IEnumerable(Of Product)
            Dim products As List(Of Product) = New List(Of Product)() From {
                New Product() With {
                    .Name = "Beef Burger",
                    .Price = 7.95D,
                    .Weight = 350,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\beef-burger.jpg")
                },
                New Product() With {
                    .Name = "Big Burger",
                    .Price = 7.45D,
                    .Weight = 450,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\big-burger.jpg")
                },
                New Product() With {
                    .Name = "Burger with fries",
                    .Price = 5.95D,
                    .Weight = 480,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\burger-fries.jpg")
                },
                New Product() With {
                    .Name = "Classical Burger",
                    .Price = 3.45D,
                    .Weight = 250,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\burger.jpg")
                },
                New Product() With {
                    .Name = "Chicken Toast",
                    .Price = 4.99D,
                    .Weight = 300,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\chicken-toast.jpg")
                },
                New Product() With {
                    .Name = "Chicken Wings",
                    .Price = 5.9D,
                    .Weight = 300,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\chicken-wings.jpg")
                },
                New Product() With {
                    .Name = "Crab meat sandwich",
                    .Price = 5.5D,
                    .Weight = 290,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\crab-sandwich.jpg")
                },
                New Product() With {
                    .Name = "Ham sandwich",
                    .Price = 2.95D,
                    .Weight = 300,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\ham-cheese-sandwich.jpg")
                },
                New Product() With {
                    .Name = "Hot dog",
                    .Price = 2D,
                    .Weight = 250,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\hot-dog.jpg")
                },
                New Product() With {
                    .Name = "Meatballs",
                    .Price = 4.35D,
                    .Weight = 200,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\meatballs.jpg")
                },
                New Product() With {
                    .Name = "Pork ribs",
                    .Price = 9.99D,
                    .Weight = 450,
                    .Image = Image.FromFile(Application.StartupPath & "\Resources\MealImages\pork-ribs.jpg")
                }
            }
            Return products
        End Function

        Private Function CreateItem(ByVal product As Product) As ListViewDataItem
            Dim item As ListViewDataItem = New ListViewDataItem()
            item.Image = product.Image.GetThumbnailImage(139, 84, Nothing, IntPtr.Zero)
            item.Text = product.Name
            item.Tag = product
            Return item
        End Function

        Private Sub radCheckedListBox1_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
            Dim product As Product = TryCast(e.Item.Tag, Product)

            If e.Item.CheckState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                Dim item As ListViewDataItem = New ListViewDataItem()
                item.Tag = product
                Me.radListView1.Items.Add(item)
                item("Product") = product.Name
                item("Price") = product.Price
            Else

                For Each item As ListViewDataItem In Me.radListView1.Items

                    If item("Product").ToString() = product.Name Then
                        Me.radListView1.Items.Remove(item)
                        Exit For
                    End If
                Next
            End If

            Dim total As Decimal = 0

            For Each item As ListViewDataItem In radListView1.Items
                total += Convert.ToDecimal(item("Price"))
            Next

            Me.radListView2.Items.Clear()
            Dim totalItem As ListViewDataItem = New ListViewDataItem()
            Me.radListView2.Items.Add(totalItem)
            totalItem("Total") = "Total"
            totalItem("TotalPrice") = String.Format("{0:C2}", total)

            If Me.radCheckedListBox1.Items.Count = Me.radCheckedListBox1.CheckedItems.Count Then
                Me.radCheckAllButton.Text = "Uncheck all"
            Else
                Me.radCheckAllButton.Text = "Check all"
            End If

            Me.UpdateSelectedButtonText()
        End Sub

        Private Sub radCheckedListBox1_SelectedItemsChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateSelectedButtonText()
        End Sub

        Private Sub radCheckedListBox1_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
            Dim item As SimpleListViewVisualItem = TryCast(e.VisualItem, SimpleListViewVisualItem)
            Dim product As Product = TryCast(item.Data.Tag, Product)
            Dim color As String = "#681406"

            If TelerikHelper.IsDarkTheme(Me.radListView1.ThemeName) Then
                color = "#FFFFFF"
            End If

            If item.Children.Count > 0 Then
                Dim checkBoxItem As ListViewItemCheckbox = TryCast(item.Children(0), ListViewItemCheckbox)
                checkBoxItem.Margin = New Padding(2, 2, 3, 2)
            End If

            item.Data.Text = "<html>" & "<span style=""font-size:14.5pt;font-family:Segoe UI Semibold;"">  " & product.Name & "</span>" & "<br><span style=""font-size:10.5pt;""><i>   " & product.Weight & "gr</i></span>" & "<br><span style=""font-size:19pt;""> </span>" & "<span style=""color:" & color & ";font-size:14.5pt;""> " & String.Format("{0:C2}", product.Price) & "</span>"
            item.ImageLayout = ImageLayout.Center
            item.ImageAlignment = ContentAlignment.MiddleLeft
        End Sub

        Private Sub radListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
            Dim cell As DetailListViewDataCellElement = TryCast(e.CellElement, DetailListViewDataCellElement)

            If cell IsNot Nothing Then

                If cell.Text <> String.Empty Then
                    Dim price As Decimal = 0

                    If Decimal.TryParse(cell.Text, price) Then
                        cell.Text = New String(" "c, 5) & String.Format("{0:C2}", price)
                    Else
                        cell.Text = New String(" "c, 2) & String.Format("{0}", cell.Text)
                    End If

                    e.CellElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
                Else
                    e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty, Telerik.WinControls.ValueResetFlags.Local)
                End If
            End If
        End Sub

        Private Sub radListView2_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
            Me.radListView1_CellFormatting(sender, e)
            Dim cell As DetailListViewDataCellElement = TryCast(e.CellElement, DetailListViewDataCellElement)

            If cell IsNot Nothing AndAlso cell.Text <> String.Empty Then
                Dim price As Decimal = 0

                If Decimal.TryParse(cell.Text.Substring(3), price) Then
                    Dim color As Color = color.FromArgb(255, 104, 20, 6)

                    If TelerikHelper.IsDarkTheme(Me.radListView1.ThemeName) Then
                        color = color.FromArgb(255, 255, 255, 255)
                    End If

                    Dim indent As Integer = 4

                    If price >= 10 Then
                        indent = 3
                    End If

                    cell.Text = New String(" "c, indent) & String.Format("{0:C2}", price)
                    e.CellElement.ForeColor = color
                Else
                    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local)
                End If

                e.CellElement.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            Else
                e.CellElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

        Private Sub radClearAllButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckedListBox1.UncheckAllItems()
        End Sub

        Private Sub radOrderButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radListView1.Items.Count < 1 Then
                Return
            End If

            Dim orderedItemsTexts As List(Of String) = New List(Of String)()

            For Each item As ListViewDataItem In Me.radListView1.Items
                orderedItemsTexts.Add((TryCast(item.Tag, Product)).Name)
            Next

            Dim message As String = "You ordered:" & Environment.NewLine & String.Join(Environment.NewLine, orderedItemsTexts.ToArray()) & Environment.NewLine & "Total: " & Me.radListView2.Items(0)("TotalPrice").ToString()
            RadMessageBox.ThemeName = Me.CurrentThemeName
            RadMessageBox.Show(message)
            Me.radCheckedListBox1.UncheckAllItems()
        End Sub

        Private Sub radCheckAllButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radCheckAllButton.Text = "Check all" Then
                Me.radCheckedListBox1.CheckAllItems()
                Me.radCheckAllButton.Text = "Uncheck all"
            Else
                Me.radCheckedListBox1.UncheckAllItems()
                Me.radCheckAllButton.Text = "Check all"
            End If
        End Sub

        Private Sub radCheckSelectedButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radCheckSelectedButton.Text = "Check selected" Then
                Me.radCheckedListBox1.CheckSelectedItems()
                Me.radCheckSelectedButton.Text = "Uncheck selected"
            Else
                Me.radCheckedListBox1.UncheckSelectedItems()
                Me.radCheckSelectedButton.Text = "Check selected"
            End If
        End Sub

        Private Sub UpdateSelectedButtonText()
            For Each item As ListViewDataItem In Me.radCheckedListBox1.SelectedItems

                If item.CheckState <> Telerik.WinControls.Enumerations.ToggleState.[On] Then
                    Me.radCheckSelectedButton.Text = "Check selected"
                    Return
                End If
            Next

            Me.radCheckSelectedButton.Text = "Uncheck selected"
        End Sub
    End Class

    Friend Class Product
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Weight As Integer
        Public Property Image As Image
    End Class
End Namespace
