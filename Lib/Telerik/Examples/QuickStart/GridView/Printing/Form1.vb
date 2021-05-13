Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Printing
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private Class ViewDefinitionInfo
			Public Columns As List(Of String)
			Public ViewDefinition As IGridViewDefinition
			Public RowHeight As Integer = 30
			Public HeaderHeight As Integer = 30
		End Class

		Private tableViewInfo As ViewDefinitionInfo
		Private htmlViewInfo As ViewDefinitionInfo
		Private columnGroupViewInfo As ViewDefinitionInfo
		Private currentViewInfo As ViewDefinitionInfo

		Private italicFont As New Font("Segoe UI", 9f, FontStyle.Italic)

		#End Region

		#Region "Initialization"

		Public Sub New()
			InitializeComponent()

			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ShowFilteringRow = False
			Me.radGridView1.ShowHeaderCellButtons = True
			Me.radGridView1.ShowGroupedColumns = True
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.EnableAlternatingRowColor = True
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.PrintCellFormatting, AddressOf radGridView1_PrintCellFormatting
			Me.WireEvents()
        End Sub

        Private Sub InitializeGrid()
            Me.radGridView1.Columns("FirstName").Width = CInt((80.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("LastName").Width = CInt((80.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Title").Width = CInt((120.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Photo").Width = 80
            Me.radGridView1.Columns("Photo").ImageLayout = ImageLayout.Stretch
            Me.radGridView1.Columns("City").Width = CInt((70.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Country").Width = CInt((70.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Address").Width = CInt((200.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Notes").Width = CInt((260.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("Notes").WrapText = True
            Me.radGridView1.Columns("BirthDate").FormatString = "{0:d}"
            Me.radGridView1.Columns("BirthDate").Width = CInt((120.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            Me.radGridView1.Columns("HireDate").FormatString = "{0:d}"
            CType(Me.radGridView1.Columns("Notes"), GridViewTextBoxColumn).Multiline = True
            tableViewInfo = New ViewDefinitionInfo()
            tableViewInfo.ViewDefinition = CType(Me.radGridView1.ViewDefinition, TableViewDefinition)
            tableViewInfo.Columns = New List(Of String)() From {
                "FirstName",
                "LastName",
                "Title",
                "Country",
                "HomePhone",
                "Address",
                "Check",
                "Combo"
            }
            Dim cgv As ColumnGroupsViewDefinition = New ColumnGroupsViewDefinition()
            columnGroupViewInfo = New ViewDefinitionInfo()
            columnGroupViewInfo.ViewDefinition = cgv
            columnGroupViewInfo.Columns = New List(Of String)() From {
                "Photo",
                "FirstName",
                "LastName",
                "Title",
                "Address",
                "City",
                "Country",
                "HomePhone",
                "Notes"
            }
            columnGroupViewInfo.RowHeight = CInt((90.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            columnGroupViewInfo.HeaderHeight = CInt((80.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            cgv.ColumnGroups.Add(New GridViewColumnGroup())
            cgv.ColumnGroups.Add(New GridViewColumnGroup("General"))
            cgv.ColumnGroups.Add(New GridViewColumnGroup("Details"))
            cgv.ColumnGroups.Add(New GridViewColumnGroup("Notes"))
            cgv.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow() With {
                .MinHeight = 30
            })
            cgv.ColumnGroups(1).Rows.Add(New GridViewColumnGroupRow() With {
                .MinHeight = 30
            })
            cgv.ColumnGroups(1).Rows.Add(New GridViewColumnGroupRow() With {
                .MinHeight = 30
            })
            cgv.ColumnGroups(2).Rows.Add(New GridViewColumnGroupRow() With {
                .MinHeight = 30
            })
            cgv.ColumnGroups(2).Rows.Add(New GridViewColumnGroupRow() With {
                .MinHeight = 30
            })
            cgv.ColumnGroups(0).Rows(0).ColumnNames.Add("Photo")
            cgv.ColumnGroups(0).ShowHeader = False
            cgv.ColumnGroups(1).Rows(0).ColumnNames.Add("Title")
            cgv.ColumnGroups(1).Rows(1).ColumnNames.Add("FirstName")
            cgv.ColumnGroups(1).Rows(1).ColumnNames.Add("LastName")
            cgv.ColumnGroups(2).Rows(0).ColumnNames.Add("City")
            cgv.ColumnGroups(2).Rows(0).ColumnNames.Add("Country")
            cgv.ColumnGroups(2).Rows(0).ColumnNames.Add("HomePhone")
            cgv.ColumnGroups(2).Rows(1).ColumnNames.Add("Address")
            cgv.ColumnGroups(3).Rows.Add(New GridViewColumnGroupRow())
            cgv.ColumnGroups(3).Rows(0).ColumnNames.Add("Notes")
            cgv.ColumnGroups(3).ShowHeader = False
            htmlViewInfo = New ViewDefinitionInfo()
            htmlViewInfo.ViewDefinition = New HtmlViewDefinition()
            htmlViewInfo.Columns = New List(Of String)() From {
                "Photo",
                "Title",
                "FirstName",
                "LastName",
                "City",
                "Country",
                "Address",
                "Phone",
                "BirthDate",
                "HireDate",
                "HomePhone"
            }
            Dim htmlView As HtmlViewDefinition = New HtmlViewDefinition()
            htmlView.RowTemplate.Rows.Add(New RowDefinition())
            htmlView.RowTemplate.Rows.Add(New RowDefinition())
            htmlView.RowTemplate.Rows.Add(New RowDefinition())
            htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Photo", 0, 1, 3))
            htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("FirstName", 0, 1, 1))
            htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("LastName", 0, 2, 1))
            htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("BirthDate", 0, 1, 1))
            htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("Title", 0, 3, 1))
            htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("HireDate", 0, 1, 1))
            htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Address", 0, 1, 1))
            htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("City", 0, 1, 1))
            htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Country", 0, 1, 1))
            htmlView.RowTemplate.Rows(2).Cells.Add(New CellDefinition("HomePhone", 0, 1, 1))
            htmlView.RowTemplate.Rows(0).Height = 23
            htmlView.RowTemplate.Rows(1).Height = 23
            htmlView.RowTemplate.Rows(2).Height = 32
            htmlViewInfo.RowHeight = CInt((100.0F * radGridView1.RootElement.DpiScaleFactor.Height))
            htmlViewInfo.HeaderHeight = -1
            htmlViewInfo.ViewDefinition = htmlView
        End Sub

		Private Sub InitializePrintDocument()
			Me.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]"
			Me.radPrintDocument1.LeftHeader = "[Time Printed]"
			Me.radPrintDocument1.MiddleFooter = "***"
			Me.radPrintDocument1.MiddleHeader = "Company employees info"
			Me.radPrintDocument1.RightFooter = "Printed by: [User Name]"
			Me.radPrintDocument1.RightHeader = "[Date Printed]"
		End Sub

		Private Sub SetView(ByVal info As ViewDefinitionInfo)
			currentViewInfo = info

			Me.radGridView1.FilterDescriptors.Clear()

			Me.radGridView1.BeginUpdate()

			For Each col As GridViewColumn In Me.radGridView1.Columns
				col.IsVisible = info.Columns.Contains(col.Name)
			Next col

			Dim traverser As New GridTraverser(Me.radGridView1.MasterView)
			Do While traverser.MoveNext()
				If TypeOf traverser.Current Is GridViewDataRowInfo Then
					traverser.Current.Height = info.RowHeight
				End If
			Loop

			Me.radGridView1.MasterView.TableHeaderRow.Height = info.HeaderHeight

			Me.radGridView1.EndUpdate(False)

			Me.radGridView1.ViewDefinition = info.ViewDefinition
			Me.radGridView1.PrintStyle.FitWidthMode = PrintFitWidthMode.NoFitCentered
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then

                If Me.radRadioButtonHtml.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                    htmlViewInfo.RowHeight = CInt((130.0F * radGridView1.RootElement.DpiScaleFactor.Height))
                    radGridView1.Columns("Photo").Width += 20
                    SetView(htmlViewInfo)
                End If
            End If
        End Sub

		#End Region

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
			Me.radGridView1.GroupDescriptors.Add(New Telerik.WinControls.Data.GroupDescriptor("Title Desc"))

			InitializeGrid()
			InitializePrintDocument()

			SetView(columnGroupViewInfo)
		End Sub

		Private Sub radRadioTable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioButtonColumnGroups.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetView(columnGroupViewInfo)
			ElseIf Me.radRadioButtonHtml.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetView(htmlViewInfo)
			Else
				SetView(tableViewInfo)
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			Dim cell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)
			If cell IsNot Nothing Then
				If cell.ColumnInfo.Name = "Notes" Then
					cell.Font = italicFont
					cell.Padding = New Padding(4)
				Else
					cell.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
					cell.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local)
				End If
			End If
		End Sub

		Private Sub radGridView1_PrintCellFormatting(ByVal sender As Object, ByVal e As PrintCellFormattingEventArgs)
			If e.Column IsNot Nothing AndAlso e.Column.Name = "Notes" AndAlso TypeOf e.Row Is GridViewDataRowInfo Then
				e.PrintCell.Font = Me.italicFont
			End If
		End Sub

		Private Sub radButtonPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub radButtonPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New RadPrintPreviewDialog()
			dialog.ThemeName = Me.radGridView1.ThemeName
			dialog.Document = Me.radPrintDocument1
			dialog.StartPosition = FormStartPosition.CenterScreen
			dialog.ShowDialog()
		End Sub

		Private Sub radButtonPrintSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New GridViewPrintSettingsDialog()
			dialog.ThemeName = Me.radGridView1.ThemeName
			dialog.ShowPreviewButton = False
			dialog.PrintDocument = Me.radPrintDocument1
			dialog.StartPosition = FormStartPosition.CenterScreen
			If dialog.ShowDialog() = DialogResult.OK Then
				radButtonPrintPreview_Click(sender, e)
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radRadioButtonTable.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
			AddHandler radRadioButtonHtml.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
			AddHandler radRadioButtonColumnGroups.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
			AddHandler radButtonPrint.Click, AddressOf radButtonPrint_Click
			AddHandler radButtonPrintPreview.Click, AddressOf radButtonPrintPreview_Click
			AddHandler radButtonPrintSettings.Click, AddressOf radButtonPrintSettings_Click
		End Sub
	End Class
End Namespace
