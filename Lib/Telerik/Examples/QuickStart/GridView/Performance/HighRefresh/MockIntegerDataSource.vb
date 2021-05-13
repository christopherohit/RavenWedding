Imports System.Text

Namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
	Public Class MockIntegerDataSource
		Implements IMockDataSource(Of WorkItem(Of Integer))
		Private data As List(Of WorkItem(Of Integer))
'INSTANT VB NOTE: The variable rows was renamed since Visual Basic does not allow class members with the same name:
        Private rows_ As Integer
        'INSTANT VB NOTE: The variable columns was renamed since Visual Basic does not allow class members with the same name:
        Private columns_ As Integer

        Public Sub New(ByVal rows As Integer, ByVal columns As Integer)
            Me.rows_ = rows
            Me.columns_ = columns
            Me.Refresh()
        End Sub

        Public Sub Refresh() Implements IMockDataSource(Of WorkItem(Of Integer)).Refresh
            Me.data = New List(Of WorkItem(Of Integer))(rows_)
            Dim random As New Random(CInt(DateTime.Now.Millisecond))


            For i As Integer = 0 To rows_ - 1
                Dim temp As New WorkItem(Of Integer)(columns_)
                For j As Integer = 0 To columns_ - 1
                    temp.Add(random.[Next](5000))
                Next

                Me.data.Add(temp)
            Next
        End Sub


		#Region "IMockDataSource<int> Members"

		Public ReadOnly Property Source() As List(Of WorkItem(Of Integer)) Implements IMockDataSource(Of WorkItem(Of Integer)).Source
			Get
				Return data
			End Get
		End Property

		Public ReadOnly Property Columns() As Integer Implements IMockDataSource(Of WorkItem(Of Integer)).Columns
			Get
                Return Me.data(0).Count
			End Get
		End Property

		Public ReadOnly Property Rows() As Integer Implements IMockDataSource(Of WorkItem(Of Integer)).Rows
			Get
                Return Me.data.Count
			End Get
		End Property

		#End Region
	End Class

	Public Class WorkItem(Of T)
		Private columns As Integer = 0

		Public Sub New()
		End Sub

		Public Sub New(ByVal columns As Integer)
			Me.columns = columns
			internalData = New List(Of T)(columns)
		End Sub

		Private internalData As List(Of T) = Nothing

		Public Sub Add(ByVal item As T)
			internalData.Add(item)
		End Sub

		Public ReadOnly Property Count() As Integer
			Get
				Return internalData.Count
			End Get
		End Property

		Public ReadOnly Property Data() As List(Of T)
			Get
				Return internalData
			End Get
		End Property

		Public Property Column1() As T
			Get
				Return internalData(0)
			End Get
			Set(ByVal value As T)
				internalData(0) = value
			End Set
		End Property

		Public Property Column2() As T
			Get
				Return internalData(1)
			End Get
			Set(ByVal value As T)
				internalData(1) = value
			End Set
		End Property

		Public Property Column3() As T
			Get
				Return internalData(2)
			End Get
			Set(ByVal value As T)
				internalData(2) = value
			End Set
		End Property

		Public Property Column4() As T
			Get
				Return internalData(3)
			End Get
			Set(ByVal value As T)
				internalData(3) = value
			End Set
		End Property

		Public Property Column5() As T
			Get
				Return internalData(4)
			End Get
			Set(ByVal value As T)
				internalData(4) = value
			End Set
		End Property

		Public Property Column6() As T
			Get
				Return internalData(5)
			End Get
			Set(ByVal value As T)
				internalData(5) = value
			End Set
		End Property

		Public Property Column7() As T
			Get
				Return internalData(6)
			End Get
			Set(ByVal value As T)
				internalData(6) = value
			End Set
		End Property

		Public Property Column8() As T
			Get
				Return internalData(7)
			End Get
			Set(ByVal value As T)
				internalData(7) = value
			End Set
		End Property

		Public Property Column9() As T
			Get
				Return internalData(8)
			End Get
			Set(ByVal value As T)
				internalData(8) = value
			End Set
		End Property

		Public Property Column10() As T
			Get
				Return internalData(9)
			End Get
			Set(ByVal value As T)
				internalData(9) = value
			End Set
		End Property

		Public Property Column11() As T
			Get
				Return internalData(10)
			End Get
			Set(ByVal value As T)
				internalData(10) = value
			End Set
		End Property

		Public Property Column12() As T
			Get
				Return internalData(11)
			End Get
			Set(ByVal value As T)
				internalData(11) = value
			End Set
		End Property

	End Class
End Namespace
