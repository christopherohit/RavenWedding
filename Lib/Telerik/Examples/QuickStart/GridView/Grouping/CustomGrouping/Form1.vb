Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.GridView.Grouping.CustomGrouping
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radGridView.EnableGrouping = True
			Me.radGridView.EnableCustomGrouping = True
			Me.radGridView.ShowGroupedColumns = True
		End Sub

		Private Sub SetConditions()
			Dim c3 As New ConditionalFormattingObject("Grey, applied to cell", ConditionTypes.NotEqual, "Germany", "", False)
			c3.RowBackColor = Color.FromArgb(169, 183, 201)
			c3.CellBackColor = Color.FromArgb(169, 183, 201)
			Me.radGridView.Columns("Country").ConditionalFormattingObjectList.Add(c3)

			Dim c1 As New ConditionalFormattingObject("Blue , applied to cell", ConditionTypes.Equal, "Germany", "", False)
			c1.RowBackColor = Color.FromArgb(163, 191, 226)
			c1.CellBackColor = Color.FromArgb(163, 191, 226)
			Me.radGridView.Columns("Country").ConditionalFormattingObjectList.Add(c1)

			Dim c2 As New ConditionalFormattingObject("LightPurple, applied to cell", ConditionTypes.Equal, "France", "", False)
			c2.RowBackColor = Color.FromArgb(212, 210, 241)
			c2.CellBackColor = Color.FromArgb(212, 210, 241)
			Me.radGridView.Columns("Country").ConditionalFormattingObjectList.Add(c2)
		End Sub

		Private Sub radGridView1_CustomGrouping(ByVal sender As Object, ByVal e As GridViewCustomGroupingEventArgs)
			If Me.UseDefaultGrouping(e.Level) Then
				e.Handled = False
				Return
			End If

            Dim color As Integer = System.Drawing.Color.White.ToArgb()
			Dim columnIndex As Integer = Me.radGridView.Columns("Country").Index
			Dim conditions As ConditionalFormattingObjectCollection = Me.radGridView.Columns(columnIndex).ConditionalFormattingObjectList

			For i As Integer = 0 To conditions.Count - 1
				If conditions(i).Evaluate(e.Row, Me.radGridView.Columns("Country")) Then
					color = conditions(i).CellBackColor.ToArgb()
				End If
			Next i

			e.GroupKey = color
		End Sub

		Private Function UseDefaultGrouping(ByVal level As Integer) As Boolean
			Dim groupDescriptor As GroupDescriptor = Me.radGridView.GroupDescriptors(level)
			For i As Integer = 0 To groupDescriptor.GroupNames.Count - 1
				If groupDescriptor.GroupNames(i).PropertyName.Equals("Country", StringComparison.InvariantCultureIgnoreCase) Then
					Return False
				End If
			Next i

			Return True
		End Function

		Private Sub radGridView_ViewRowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs)
			Dim groupRow As GridViewGroupRowInfo = TryCast(e.RowElement.RowInfo, GridViewGroupRowInfo)
			If groupRow IsNot Nothing AndAlso TypeOf groupRow.Group.Key Is Integer Then
				e.RowElement.BackColor = Color.FromArgb(CInt(Fix(groupRow.Group.Key)))
			End If
		End Sub

		Private Sub radGridView_GroupSummaryEvaluate(ByVal sender As Object, ByVal e As GroupSummaryEvaluationEventArgs)
			If Me.UseDefaultGrouping(e.Group.Level) Then
				Return
			End If

			e.FormatString = Me.GetColorName(e.Group.Key.ToString())
		End Sub

		Private Function GetColorName(ByVal p As String) As String
			Select Case p
				Case "-6045726"
					Return "Blue"
				Case "-5654583"
					Return "Grey"
				Case "-2829583"
					Return "LightPurple"
				Case Else
					Return "White"
			End Select
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.SetConditions()
			Me.radGridView.GroupDescriptors.Expression = "Country"

			Me.SelectedControl = Me.radGridView
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGridView.GroupSummaryEvaluate, AddressOf radGridView_GroupSummaryEvaluate
			AddHandler radGridView.ViewRowFormatting, AddressOf radGridView_ViewRowFormatting
			AddHandler radGridView.CustomGrouping, AddressOf radGridView1_CustomGrouping
		End Sub
	End Class
End Namespace
