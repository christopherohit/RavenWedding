Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.IO
Imports System.Diagnostics
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.Columns.ColumnTypes
    Partial Public Class Form1
        Inherits ExamplesForm

        Private rand As Random = New Random()

        Enum TitleOfCourtesy
            Mr
            Ms
            Mrs
            Dr
        End Enum

        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radGridView1

            AddHandler Me.radGridView1.CellFormatting, New CellFormattingEventHandler(AddressOf radGridView1_CellFormatting)
            AddHandler Me.radGridView1.CellBeginEdit, New GridViewCellCancelEventHandler(AddressOf radGridView1_CellBeginEdit)
        End Sub

        Private Sub BindGrid()
            Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
            Me.radGridView1.MasterTemplate.AutoGenerateColumns = False
            radGridView1.DataSource = Me.nwindDataSet.Employees

            Dim decimalColumn As GridViewDecimalColumn = New GridViewDecimalColumn()
            decimalColumn.FieldName = "EmployeeID"
            decimalColumn.Name = "EmployeeID"
            decimalColumn.HeaderText = "Decimal"
            decimalColumn.DecimalPlaces = 0
            decimalColumn.Width = 100
            decimalColumn.IsVisible = False
            Me.radGridView1.Columns.Add(decimalColumn)

            Dim textBoxColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn()
            textBoxColumn.FieldName = "LastName"
            textBoxColumn.Name = "LastName"
            textBoxColumn.HeaderText = "Text"
            textBoxColumn.Width = 100
            textBoxColumn.IsVisible = False
            Me.radGridView1.Columns.Add(textBoxColumn)

            Dim imageColumn As GridViewImageColumn = New GridViewImageColumn()
            imageColumn.FieldName = "Photo"
            imageColumn.Name = "Photo"
            imageColumn.HeaderText = "Image"
            imageColumn.ImageLayout = ImageLayout.Zoom
            imageColumn.Width = 54
            Me.radGridView1.Columns.Add(imageColumn)

            Dim lookUpColumn As GridViewComboBoxColumn = New GridViewComboBoxColumn()
            lookUpColumn.FieldName = "TitleOfCourtesy"
            lookUpColumn.Name = "LookUp"
            lookUpColumn.HeaderText = "LookUp"
            lookUpColumn.DataSource = New String() {"Mr.", "Mrs.", "Dr.", "Ms."}
            lookUpColumn.Width = 100
            lookUpColumn.IsVisible = False
            Me.radGridView1.Columns.Add(lookUpColumn)

            Dim maskBoxColumn As GridViewMaskBoxColumn = New GridViewMaskBoxColumn()
            maskBoxColumn.FieldName = "HomePhone"
            maskBoxColumn.Name = "MaskBox"
            maskBoxColumn.HeaderText = "MaskBox"
            maskBoxColumn.MaskType = MaskType.Standard
            maskBoxColumn.Mask = "(###) ###-####"
            maskBoxColumn.Width = 200
            maskBoxColumn.IsVisible = False
            Me.radGridView1.Columns.Add(maskBoxColumn)

            Dim hyperlinkColumn As GridViewHyperlinkColumn = New GridViewHyperlinkColumn("Hyperlink")
            hyperlinkColumn.[ReadOnly] = True
            hyperlinkColumn.Width = 200
            Me.radGridView1.Columns.Add(hyperlinkColumn)

            Dim colorColumn As GridViewColorColumn = New GridViewColorColumn("Color")
            colorColumn.Width = 100
            Me.radGridView1.Columns.Add(colorColumn)

            Dim calculatorColumn As GridViewCalculatorColumn = New GridViewCalculatorColumn("Calculator")
            calculatorColumn.Width = 80
            Me.radGridView1.Columns.Add(calculatorColumn)

            Dim browseColumn As GridViewBrowseColumn = New GridViewBrowseColumn("Browse")
            browseColumn.Width = 180
            browseColumn.IsVisible = False
            Me.radGridView1.Columns.Add(browseColumn)

            Dim sparklineColumn As GridViewSparklineColumn = New GridViewSparklineColumn("Sparkline")
            sparklineColumn.Width = 180
            sparklineColumn.SeriesType = SparkSeriesType.Line
            sparklineColumn.ShowTooltip = True
            sparklineColumn.ShowHighPointIndicator = True
            sparklineColumn.ShowLowPointIndicator = True
            sparklineColumn.ShowFirstPointIndicator = True
            sparklineColumn.ShowLastPointIndicator = True
            Me.radGridView1.Columns.Add(sparklineColumn)

            Dim checkBoxColumn As GridViewCheckBoxColumn = New GridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = "CheckBox"
            checkBoxColumn.Name = "CheckBox"
            checkBoxColumn.Width = 100
            checkBoxColumn.EnableHeaderCheckBox = True
            Me.radGridView1.Columns.Add(checkBoxColumn)

            Dim ratingColumn As GridViewRatingColumn = New GridViewRatingColumn()
            ratingColumn.HeaderText = "Rating"
            ratingColumn.Name = "Rating"
            ratingColumn.Width = 150
            ratingColumn.IsVisible = False
            Me.radGridView1.Columns.Add(ratingColumn)

            Dim commandColumn As GridViewDataColumn = New GridViewTextBoxColumn()
            commandColumn.HeaderText = "Custom"
            commandColumn.Name = "ProgressBar"
            commandColumn.DataType = GetType(Integer)
            commandColumn.[ReadOnly] = True
            commandColumn.Width = 100
            Me.radGridView1.Columns.Add(commandColumn)

            Dim commandCol As GridViewCommandColumn = New GridViewCommandColumn("Command")
            commandCol.FieldName = "FirstName"
            commandCol.Name = "FirstName"
            commandCol.UseDefaultText = False
            commandCol.Width = 100
            commandCol.IsVisible = False
            Me.radGridView1.MasterTemplate.Columns.Add(commandCol)

            Dim dateTimeColumn As GridViewDateTimeColumn = New GridViewDateTimeColumn("DateTime")
            dateTimeColumn.Width = 100
            dateTimeColumn.FormatString = "{0:D}"
            dateTimeColumn.IsVisible = False
            Me.radGridView1.Columns.Add(dateTimeColumn)

            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("Id", GetType(Integer))
            dt.Columns.Add("Name", GetType(String))

            For i As Integer = 0 To 10 - 1
                dt.Rows.Add(i, "Item" & i)
            Next

            Dim mccbCol As GridViewMultiComboBoxColumn = New GridViewMultiComboBoxColumn("MultiComboBox")
            mccbCol.DataSource = dt
            mccbCol.DisplayMember = "Name"
            mccbCol.ValueMember = "Id"
            mccbCol.Width = 80
            mccbCol.IsVisible = False
            Me.radGridView1.Columns.Add(mccbCol)

            Dim timeSpanColumn As GridViewTimeSpanColumn = New GridViewTimeSpanColumn("TimeSpan")
            timeSpanColumn.Width = 130
            timeSpanColumn.FormatString = "dd:hh:mm:ss"
            timeSpanColumn.Format = "dd:hh:mm:ss"
            Me.radGridView1.Columns.Add(timeSpanColumn)
            Me.PopulateUnboundColumns()
        End Sub

        Private Sub PopulateUnboundColumns()
            Me.radGridView1.TableElement.BeginUpdate()

            For i As Integer = 0 To Me.radGridView1.Rows.Count - 1
                Dim number As Integer = rand.Next(0, 100)
                Me.radGridView1.Rows(i).Cells("CheckBox").Value = i Mod 2 = 0
                Me.radGridView1.Rows(i).Cells("ProgressBar").Value = number
                Me.radGridView1.Rows(i).Cells("Calculator").Value = number
                Me.radGridView1.Rows(i).Cells("MultiComboBox").Value = i + 1
                Me.radGridView1.Rows(i).Cells("DateTime").Value = DateTime.Now.AddDays(i)
                Me.radGridView1.Rows(i).Cells("TimeSpan").Value = DateTime.Now.AddSeconds((i + 1) * 32832) - DateTime.Now

                Dim sparkData As Double() = New Double(9) {}

                For j As Integer = 0 To sparkData.Length - 1 - 1
                    sparkData(j) = rand.[Next](-100, 100)
                Next

                Me.radGridView1.Rows(i).Cells("Sparkline").Value = sparkData
            Next

            Me.radGridView1.Rows(0).Cells("Hyperlink").Value = "http://www.telerik.com"
            Me.radGridView1.Rows(1).Cells("Hyperlink").Value = "http://www.microsoft.com"
            Me.radGridView1.Rows(2).Cells("Hyperlink").Value = "http://www.google.com"
            Me.radGridView1.Rows(3).Cells("Hyperlink").Value = "http://www.cnn.com"
            Me.radGridView1.Rows(4).Cells("Hyperlink").Value = "http://www.bbc.com"
            Me.radGridView1.Rows(5).Cells("Hyperlink").Value = "http://www.telerikwatch.com"
            Me.radGridView1.Rows(6).Cells("Hyperlink").Value = "http://www.wikipedia.com"
            Me.radGridView1.Rows(7).Cells("Hyperlink").Value = "http://blogs.telerik.com/blogs.aspx"
            Me.radGridView1.Rows(8).Cells("Hyperlink").Value = "http://www.telerik.com/forums"

            Me.radGridView1.Rows(0).Cells("Color").Value = "Red"
            Me.radGridView1.Rows(1).Cells("Color").Value = "Orange"
            Me.radGridView1.Rows(2).Cells("Color").Value = "Yellow"
            Me.radGridView1.Rows(3).Cells("Color").Value = "Green"
            Me.radGridView1.Rows(4).Cells("Color").Value = "Blue"
            Me.radGridView1.Rows(5).Cells("Color").Value = "Indigo"
            Me.radGridView1.Rows(6).Cells("Color").Value = "Violet"
            Me.radGridView1.Rows(7).Cells("Color").Value = "White"
            Me.radGridView1.Rows(8).Cells("Color").Value = "Black"

            Me.radGridView1.Rows(0).Cells("Browse").Value = "C:\Music\Sting\If You Love Somebody Set Them Free.wav"
            Me.radGridView1.Rows(1).Cells("Browse").Value = "C:\Music\Sting\Russians.wav"
            Me.radGridView1.Rows(2).Cells("Browse").Value = "C:\Music\Sting\Fortress Around Your Heart.wav"
            Me.radGridView1.Rows(3).Cells("Browse").Value = "C:\Music\Sting\Love Is the Seventh Wave.wav"
            Me.radGridView1.Rows(4).Cells("Browse").Value = "C:\Music\Sheryl Crow\Run, Baby, Run.wav"
            Me.radGridView1.Rows(5).Cells("Browse").Value = "C:\Music\Sheryl Crow\Leaving Las Vegas.wav"
            Me.radGridView1.Rows(6).Cells("Browse").Value = "C:\Music\Sheryl Crow\Strong Enough.wav"
            Me.radGridView1.Rows(7).Cells("Browse").Value = "C:\Music\Sheryl Crow\Maybe Angels.wav"
            Me.radGridView1.Rows(8).Cells("Browse").Value = "C:\Music\Sheryl Crow\A Change Would Do You Good.wav"

            Me.radGridView1.Rows(0).Cells("Rating").Value = 15
            Me.radGridView1.Rows(1).Cells("Rating").Value = 38
            Me.radGridView1.Rows(2).Cells("Rating").Value = 90
            Me.radGridView1.Rows(3).Cells("Rating").Value = 54
            Me.radGridView1.Rows(4).Cells("Rating").Value = 28
            Me.radGridView1.Rows(5).Cells("Rating").Value = 12
            Me.radGridView1.Rows(6).Cells("Rating").Value = 78
            Me.radGridView1.Rows(7).Cells("Rating").Value = 29
            Me.radGridView1.Rows(8).Cells("Rating").Value = 39

            Me.radGridView1.TableElement.EndUpdate()
        End Sub

#Region "Event handling"

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.MasterTemplate.EnableGrouping = False
            Me.radGridView1.MasterTemplate.EnableFiltering = False
            Me.radGridView1.MasterTemplate.EnableSorting = False
            Me.radGridView1.TableElement.EnableHotTracking = False
            Me.radGridView1.TableElement.TableHeaderHeight = 35
            Me.radGridView1.TableElement.RowHeight = 60

            Me.radGridView1.EnableFiltering = True
            Me.radGridView1.MasterTemplate.ShowHeaderCellButtons = True
            Me.radGridView1.MasterTemplate.ShowFilteringRow = False
            Me.BindGrid()
        End Sub

        Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
            Dim comboBoxEditor As RadDropDownListEditor = TryCast(Me.radGridView1.ActiveEditor, RadDropDownListEditor)

            If comboBoxEditor IsNot Nothing Then
                comboBoxEditor.EditorElement.StretchVertically = False
                comboBoxEditor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
                comboBoxEditor.DropDownSizingMode = SizingMode.UpDownAndRightBottom
            End If

            Dim mccb As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)

            If mccb IsNot Nothing Then
                mccb.AutoSizeDropDownToBestFit = True
            End If
        End Sub

        Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
            If TypeOf e.CellElement.RowInfo Is GridViewFilteringRowInfo Then
                Return
            End If

            If e.CellElement.ColumnInfo.Name = "FirstName" Then
                Dim commandCell As GridCommandCellElement = TryCast(e.CellElement, GridCommandCellElement)

                commandCell.Text = e.CellElement.Value.ToString() & ""
                commandCell.CommandButton.Visibility = ElementVisibility.Visible
                commandCell.CommandButton.Text = e.CellElement.Value.ToString() & ""
            ElseIf e.CellElement.ColumnInfo.Name = "ProgressBar" Then
                Dim progressBarElement As RadProgressBarElement

                If e.CellElement.Children.Count = 0 Then
                    progressBarElement = New RadProgressBarElement()
                    e.CellElement.Children.Add(progressBarElement)
                    progressBarElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                Else
                    progressBarElement = TryCast(e.CellElement.Children(0), RadProgressBarElement)
                End If

                progressBarElement.Margin = New Padding(15)
                progressBarElement.StretchHorizontally = True

                Dim value As Integer = 0

                If e.CellElement.Value IsNot Nothing Then

                    Try
                        Int32.TryParse((CType(e.CellElement, GridDataCellElement)).Value.ToString(), value)
                    Catch
                        value = 0
                    End Try
                End If

                If value < 0 Then
                    value = 0
                ElseIf value > 100 Then
                    value = 100
                End If

                progressBarElement.Value1 = value
                progressBarElement.Text = value.ToString() & "%"
                e.CellElement.DrawText = False
            ElseIf e.CellElement.ColumnInfo.Name = "Rating" Then
                e.CellElement.ResetValue(LightVisualElement.DrawTextProperty, ValueResetFlags.Local)
                e.CellElement.Padding = New Padding(0, 15, 0, 15)
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawTextProperty, ValueResetFlags.Local)

                If e.CellElement.ColumnInfo.Name <> "CheckBox" AndAlso e.CellElement.ColumnInfo.Name <> "Hyperlink" AndAlso e.CellElement.ColumnInfo.Name <> "Color" AndAlso e.CellElement.ColumnInfo.Name <> "Sparkline" AndAlso Not (e.CellElement.IsCurrent AndAlso Me.radGridView1.IsInEditMode) Then
                    e.CellElement.Children.Clear()
                End If

                If e.CellElement.ColumnInfo.Name = "MaskBox" Then
                    Dim result As Long

                    If e.CellElement.Text.Contains("(") OrElse Not Long.TryParse(e.CellElement.Text, result) Then
                        Return
                    End If

                    e.CellElement.Text = String.Format("{0:(000) 000-0000}", result)
                End If

                If e.CellElement.ColumnInfo.Name = "Color" Then
                    Dim cell As GridColorCellElement = TryCast(e.CellElement, GridColorCellElement)
                    cell.ColorBox.StretchVertically = False
                    cell.ColorBox.Alignment = ContentAlignment.MiddleCenter
                    cell.ColorBox.MinSize = New Size(20, 20)
                End If
            End If
        End Sub

        Private Sub radCheckBoxDecimal_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("EmployeeID").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxText_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("LastName").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxImage_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Photo").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxLookUp_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("LookUp").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxMaskBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("MaskBox").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxHyperlink_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Hyperlink").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxColor_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Color").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxCalculator_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Calculator").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxBrowse_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Browse").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("CheckBox").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxCustom_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("ProgressBar").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCheckBoxRating_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Rating").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radDateTimeCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("DateTime").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radMultiComboBoxCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("MultiComboBox").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub radCommandCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("FirstName").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub enableTimeSpanCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("TimeSpan").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

        Private Sub enableSparklineCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.Columns("Sparkline").IsVisible = args.ToggleState = ToggleState.[On]
        End Sub

#End Region

        Protected Overrides Sub WireEvents()
            AddHandler Me.radCheckBoxCustom.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxCustom_ToggleStateChanged)
            AddHandler Me.radCheckBoxCheckBox.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxCheckBox_ToggleStateChanged)
            AddHandler Me.radCheckBoxBrowse.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxBrowse_ToggleStateChanged)
            AddHandler Me.radCheckBoxCalculator.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxCalculator_ToggleStateChanged)
            AddHandler Me.radCheckBoxColor.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxColor_ToggleStateChanged)
            AddHandler Me.radCheckBoxHyperlink.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxHyperlink_ToggleStateChanged)
            AddHandler Me.radCheckBoxMaskBox.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxMaskBox_ToggleStateChanged)
            AddHandler Me.radCheckBoxLookUp.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxLookUp_ToggleStateChanged)
            AddHandler Me.radCheckBoxImage.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxImage_ToggleStateChanged)
            AddHandler Me.radCheckBoxText.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxText_ToggleStateChanged)
            AddHandler Me.radCheckBoxDecimal.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.radCheckBoxDecimal_ToggleStateChanged)
            AddHandler Me.radCheckBoxRating.ToggleStateChanged, New StateChangedEventHandler(AddressOf radCheckBoxRating_ToggleStateChanged)
            AddHandler Me.radCommandCheckBox.ToggleStateChanged, AddressOf radCommandCheckBox_ToggleStateChanged
            AddHandler Me.radMultiComboBoxCheckBox.ToggleStateChanged, AddressOf radMultiComboBoxCheckBox_ToggleStateChanged
            AddHandler Me.radDateTimeCheckBox.ToggleStateChanged, AddressOf radDateTimeCheckBox_ToggleStateChanged
            AddHandler Me.enableTimeSpanCheckBox.ToggleStateChanged, AddressOf enableTimeSpanCheckBox_ToggleStateChanged
            AddHandler Me.enableSparklineCheckBox.ToggleStateChanged, AddressOf enableSparklineCheckBox_ToggleStateChanged
        End Sub
    End Class
End Namespace
