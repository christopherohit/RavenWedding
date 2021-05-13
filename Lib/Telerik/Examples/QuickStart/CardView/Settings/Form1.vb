Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.CardView.Settings
    Partial Public Class Form1
        Inherits ExamplesForm
        Private fontConverter As FontConverter
        Public Sub New()
            InitializeComponent()
            AddHandler Me.radCardView1.VisualItemFormatting, AddressOf radCardView1_VisualItemFormatting
            AddHandler Me.radCardView1.CardViewItemFormatting, AddressOf radCardView1_CardViewItemFormatting
            Me.fontConverter = New FontConverter()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Me.SetInitialValues()
            Me.AddDataItems()
            Me.radCardView1.ListViewElement.SynchronizeVisualItems()
        End Sub

        Private Sub radCardView1_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs)
            e.VisualItem.ClipDrawing = False
            e.VisualItem.Padding = New Padding(5)
        End Sub

        Private Sub radCardView1_CardViewItemFormatting(sender As Object, e As CardViewItemFormattingEventArgs)
            Dim cardItem As CardViewItem = TryCast(e.Item, CardViewItem)
            If cardItem IsNot Nothing Then
                If cardItem.FieldName = "Column 0" Then
                    cardItem.EditorItem.DrawText = False
                    Dim image__1 As Image = Image.FromFile(Application.StartupPath & "\Resources\Cities\" & e.VisualItem.Data("Column 0").ToString())
                    cardItem.EditorItem.Image = image__1
                    cardItem.EditorItem.ImageLayout = ImageLayout.Stretch
                    cardItem.EditorItem.NotifyParentOnMouseInput = False
                    cardItem.EditorItem.ShouldHandleMouseInput = False
                    cardItem.Padding = New Padding(-5, -5, -5, 0)
                    Return
                ElseIf cardItem.FieldName = "Column 2" Then
                    cardItem.EditorItem.Text += " million"
                End If

                ' Font selectedItemFont = this.fontConverter.ConvertFromString(this.radBrowseEditorFont.Value) as Font;
                ' if (selectedItemFont != cardItem.Font)
                '  {
                ' Font itemFont = new Font(cardItem.Font.FontFamily, cardItem.Font.Size, FontStyle.Bold);
                Dim editorFont As New Font(cardItem.Font.FontFamily, cardItem.Font.Size, FontStyle.Regular)

                ' cardItem.Font = itemFont;
                '  }
                cardItem.EditorItem.Font = editorFont
            End If
        End Sub

        Private Sub AddDataItems()
            ' image path, city, population, country
            Me.radCardView1.Items.Add("Bejing.jpg", "Bejing", 21.516F, "China")
            Me.radCardView1.Items.Add("Berlin.jpg", "Berlin", 3.562F, "Germany")
            Me.radCardView1.Items.Add("Bloemfontain.jpg", "Bloemfontain", 0.256F, "South Africa")
            Me.radCardView1.Items.Add("Bombay.jpg", "Bombay", 12.479F, "India")
            Me.radCardView1.Items.Add("Bonn.jpg", "Bonn", 0.314F, "Germany")
            Me.radCardView1.Items.Add("Boston.jpg", "Boston", 0.656F, "United States")
            Me.radCardView1.Items.Add("Buenos Aires.jpg", "Buenos Aires", 2.891F, "Argentina")
            Me.radCardView1.Items.Add("Cairo.jpg", "Cairo", 10.23F, "Egypt")
            Me.radCardView1.Items.Add("Cancun.jpg", "Cancun", 0.723F, "Mexico")
            Me.radCardView1.Items.Add("Cannes.jpg", "Cannes", 0.074F, "France")
            Me.radCardView1.Items.Add("Cape Town.jpg", "Cape Town", 3.75F, "South Africa")
            Me.radCardView1.Items.Add("Frankfurt.jpg", "Frankfurt", 0.718F, "Germany")
            Me.radCardView1.Items.Add("Jakarta.jpg", "Jakarta", 9.608F, "Indonesia")
            Me.radCardView1.Items.Add("Liverpool.jpg", "Liverpool", 0.473F, "United Kingdom")
            Me.radCardView1.Items.Add("London.jpg", "London", 8.539F, "United Kingdom")
            Me.radCardView1.Items.Add("Los Angeles.jpg", "Los Angeles", 3.929F, "United States")
            Me.radCardView1.Items.Add("Manchester.jpg", "Manchester", 0.52F, "United Kingdom")
            Me.radCardView1.Items.Add("Melbourne.jpg", "Melbourne", 4.53F, "Australia")
            Me.radCardView1.Items.Add("Mexico City.jpg", "Mexico City", 8.918F, "Mexico")
            Me.radCardView1.Items.Add("Nairobi.jpg", "Nairobi", 3.138F, "Kenya")
            Me.radCardView1.Items.Add("New Brazil.jpg", "Brasilia", 2.556F, "Brasil")
            Me.radCardView1.Items.Add("New Delhi.jpg", "New Delhi", 18.686F, "India")
            Me.radCardView1.Items.Add("New York.jpg", "New York", 8.55F, "United States")
            Me.radCardView1.Items.Add("Nice.jpg", "Nice", 0.344F, "France")
            Me.radCardView1.Items.Add("Ottawa.jpg", "Ottawa", 0.883F, "Canada")
            Me.radCardView1.Items.Add("Paris.jpg", "Paris", 2.241F, "France")
            Me.radCardView1.Items.Add("Pretoria.jpg", "Pretoria", 0.742F, "South Africa")
            Me.radCardView1.Items.Add("Rio de Janeiro.jpg", "Rio de Janeiro", 6.454F, "Argentina")
            Me.radCardView1.Items.Add("San Francisco.jpg", "San Francisco", 0.852F, "United States")
            Me.radCardView1.Items.Add("Santiago.jpg", "Santiago", 6.158F, "Chile")
            Me.radCardView1.Items.Add("Sao Paolo.jpg", "Sao Paolo", 11.967F, "Brazil")
            Me.radCardView1.Items.Add("Seattle.jpg", "Seattle", 3.059, "United States")
            Me.radCardView1.Items.Add("Sydney.jpg", "Sydney", 4.921F, "Australia")
            Me.radCardView1.Items.Add("Toronto.jpg", "Toronto", 5.133F, "Canada")
            Me.radCardView1.Items.Add("Vancouver.jpg", "Vancouver", 2.135F, "Canada")
            Me.radCardView1.Items.Add("Wellington.jpg", "Wellington", 0.398F, "New Zeland")
        End Sub

        Private Sub SetInitialValues()
            Me.radCheckBoxAllowEdit.ToggleState = If(Me.radCardView1.AllowEdit, ToggleState.[On], ToggleState.Off)
            Me.radCheckBoxShowGroups.ToggleState = If(Me.radCardView1.ShowGroups, ToggleState.[On], ToggleState.Off)
            Me.radCheckBoxHotTracking.ToggleState = If(Me.radCardView1.HotTracking, ToggleState.[On], ToggleState.Off)
            Me.radCheckBoxAllowCustomize.ToggleState = If(Me.radCardView1.CardTemplate.AllowCustomize, ToggleState.[On], ToggleState.Off)
            Me.radDropDownListOrientation.SelectedIndex = If(Me.radCardView1.CardViewElement.ViewElement.Orientation = Orientation.Horizontal, 0, 1)
            Dim viewElement As CardListViewElement = TryCast(Me.radCardView1.CardViewElement.ViewElement, CardListViewElement)
            Dim items As List(Of LayoutControlItemBase) = viewElement.GetAllChildItems(Me.radCardView1.CardTemplate.Items)
            For Each item As CardViewItem In items
                If item.FieldName <> "Column 0" Then
                    Dim text As String = Me.GetItemText(item.FieldName)
                    Dim dataItem As New RadListDataItem(text, item)
                    Me.radDropDownListVisualItems.Items.Add(dataItem)
                End If
            Next
            Me.radDropDownListVisualItems.SelectedIndex = 0
        End Sub

        Private Function GetItemText(fieldName As String) As String
            Return Me.radCardView1.Columns(fieldName).HeaderText
        End Function

        Private Sub radCheckBoxAllowEdit_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radCardView1.AllowEdit = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxShowGroups_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim groupItems As Boolean = args.ToggleState = ToggleState.[On]
            If groupItems Then
                Me.radCardView1.ShowGroups = True
                Me.radCardView1.EnableGrouping = True
                Dim groupByCountry As New Telerik.WinControls.Data.GroupDescriptor(New Telerik.WinControls.Data.SortDescriptor() {New Telerik.WinControls.Data.SortDescriptor(Me.radCardView1.Columns(3).Name, ListSortDirection.Descending)})

                Me.radCardView1.GroupDescriptors.Add(groupByCountry)
            Else
                Me.radCardView1.ShowGroups = False
                Me.radCardView1.EnableGrouping = False
                Me.radCardView1.GroupDescriptors.Clear()
            End If
        End Sub

        Private Sub radCheckBoxHotTracking_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radCardView1.HotTracking = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxAllowCustomize_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radCardView1.CardTemplate.AllowCustomize = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radDropDownListOrientation_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radCardView1.CardViewElement.ViewElement.Orientation = If(e.Position = 0, Orientation.Horizontal, Orientation.Vertical)
        End Sub

        Private updatingItemValues As Boolean = False
        Private Sub radDropDownListVisualItems_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim item As CardViewItem = TryCast(Me.radDropDownListVisualItems.SelectedItem.Value, CardViewItem)
            If item IsNot Nothing Then
                Me.updatingItemValues = True
                Me.radColorBoxBackColor.Value = item.BackColor
                Me.radColorBoxForeColor.Value = item.ForeColor
                Dim fontAsString As String = fontConverter.ConvertToString(item.Font)
                Me.radBrowseEditorFont.Value = fontAsString
                Me.radColorBoxBorderColor.Value = item.BorderColor
                Me.updatingItemValues = False
            End If
        End Sub

        Private Sub radColorBoxBackColor_ValueChanged(sender As Object, e As EventArgs)
            If Me.updatingItemValues Then
                Return
            End If

            Dim item As CardViewItem = TryCast(Me.radDropDownListVisualItems.SelectedItem.Value, CardViewItem)
            If item IsNot Nothing Then
                item.DrawFill = True
                item.BackColor = Me.radColorBoxBackColor.Value
                item.GradientStyle = GradientStyles.Solid
            End If
        End Sub

        Private Sub radColorBoxForeColor_ValueChanged(sender As Object, e As EventArgs)
            If Me.updatingItemValues Then
                Return
            End If

            Dim item As CardViewItem = TryCast(Me.radDropDownListVisualItems.SelectedItem.Value, CardViewItem)
            If item IsNot Nothing Then
                item.ForeColor = Me.radColorBoxForeColor.Value
            End If
        End Sub

        Private Sub radBrowseEditorFont_ValueChanged(sender As Object, e As EventArgs)
            If Me.updatingItemValues Then
                Return
            End If

            Dim item As CardViewItem = TryCast(Me.radDropDownListVisualItems.SelectedItem.Value, CardViewItem)
            If item IsNot Nothing Then
                Dim font As Font = TryCast(fontConverter.ConvertFromString(Me.radBrowseEditorFont.Value), Font)
                item.Font = font
            End If
        End Sub

        Private Sub radColorBoxBorderColor_ValueChanged(sender As Object, e As EventArgs)
            If Me.updatingItemValues Then
                Return
            End If

            Dim item As CardViewItem = TryCast(Me.radDropDownListVisualItems.SelectedItem.Value, CardViewItem)
            If item IsNot Nothing Then
                item.DrawBorder = True
                item.BorderBoxStyle = BorderBoxStyle.SingleBorder
                item.BorderGradientStyle = GradientStyles.Solid
                item.BorderColor = Me.radColorBoxBorderColor.Value
                item.BorderWidth = 1
            End If
        End Sub
    End Class
End Namespace