Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Xml

Namespace Telerik.Examples.WinControls.GanttView.MSProjectImport

    Public Class MsProjectImporter
        Private tasksByLevel As Dictionary(Of Integer, List(Of DataRow))
        Private dataSet As DataSet

        Public Function GetData(reader As TextReader) As DataSet
            Dim doc As New XmlDocument()
            doc.Load(reader)

            Me.InitializeDataStructures()
            Me.ExtractTasks(doc)
            Dim root As ImporterNode = Me.BuildTasksHierarchy()
            Me.SaveTasksDataTable(root)
            Me.SaveLinksDataTable(doc)

            Return Me.dataSet
        End Function

        Private Sub InitializeDataStructures()
            Me.tasksByLevel = New Dictionary(Of Integer, List(Of DataRow))()
            Dim tasks As New DataTable("Tasks")
            tasks.Columns.Add("Id", GetType(Integer))
            tasks.Columns.Add("ParentId", GetType(Integer))
            tasks.Columns.Add("Title", GetType(String))
            tasks.Columns.Add("Start", GetType(DateTime))
            tasks.Columns.Add("End", GetType(DateTime))
            tasks.Columns.Add("Progress", GetType(Decimal))
            tasks.Columns.Add("Outline", GetType(String))

            Dim links As New DataTable("Links")
            links.Columns.Add("StartId", GetType(Integer))
            links.Columns.Add("EndId", GetType(Integer))
            links.Columns.Add("LinkType", GetType(Integer))

            Me.dataSet = New DataSet()
            Me.dataSet.Tables.Add(tasks)
            Me.dataSet.Tables.Add(links)
        End Sub

        Private Function BuildTasksHierarchy() As ImporterNode
            Dim root As ImporterNode = Nothing

            For Each key As Integer In Me.tasksByLevel.Keys
                If key = 0 Then
                    root = New ImporterNode()
                    root.Row = Me.tasksByLevel(key)(0)

                    Continue For
                End If

                For Each row As DataRow In Me.tasksByLevel(key)
                    Dim outlineIndexes As New List(Of String)(row("Outline").ToString().Split("."c))

                    Dim parent As ImporterNode = root

                    While outlineIndexes.Count > 1
                        parent = parent.Children(Integer.Parse(outlineIndexes(0)) - 1)
                        outlineIndexes.RemoveAt(0)
                    End While

                    Dim newNode As New ImporterNode()
                    newNode.Row = row
                    newNode.Row("ParentId") = parent.Row("Id")
                    parent.Children.Add(newNode)
                Next
            Next

            Return root
        End Function

        Private Sub ExtractTasks(doc As XmlDocument)
            For Each node As XmlNode In doc.DocumentElement("Tasks").ChildNodes
                If node("OutlineNumber") Is Nothing Then
                    Continue For
                End If

                Dim row As DataRow = Me.dataSet.Tables("Tasks").NewRow()
                Dim outlineLevel As Integer = Integer.Parse(node("OutlineLevel").InnerText)
                Dim id As Integer = Integer.Parse(node("UID").InnerText)
                row("Id") = id
                row("ParentId") = 0
                row("Title") = node("Name").InnerText
                row("Start") = DateTime.Parse(node("Start").InnerText)
                row("End") = DateTime.Parse(node("Finish").InnerText)
                row("Progress") = Decimal.Parse(node("PercentComplete").InnerText)
                row("Outline") = node("OutlineNumber").InnerText

                If Me.tasksByLevel.ContainsKey(outlineLevel) Then
                    Me.tasksByLevel(outlineLevel).Add(row)
                Else
                    Me.tasksByLevel.Add(outlineLevel, New List(Of DataRow)() From { _
                     row _
                    })
                End If
            Next
        End Sub

        Private Sub SaveTasksDataTable(root As ImporterNode)
            Dim queue As New Queue(Of ImporterNode)()

            For Each node As ImporterNode In root.Children
                queue.Enqueue(node)
            Next

            While queue.Count > 0
                Dim node As ImporterNode = queue.Dequeue()

                For Each item As ImporterNode In node.Children
                    queue.Enqueue(item)
                Next

                Me.dataSet.Tables("Tasks").Rows.Add(node.Row)
            End While

            dataSet.Tables("Tasks").Columns.Remove("Outline")
        End Sub

        Private Sub SaveLinksDataTable(doc As XmlDocument)
            For Each node As XmlNode In doc.DocumentElement("Tasks").ChildNodes
                Dim predecessor As XmlNode = node("PredecessorLink")

                If predecessor IsNot Nothing Then
                    Dim id As Integer = Integer.Parse(node("UID").InnerText)
                    Dim startId As Integer = Integer.Parse(predecessor("PredecessorUID").InnerText)
                    Dim linkType As Integer = Integer.Parse(predecessor("Type").InnerText)

                    Me.dataSet.Tables("Links").Rows.Add(startId, id, linkType)
                End If
            Next
        End Sub
    End Class

    Public Class ImporterNode
        Private m_row As DataRow
        Private m_children As List(Of ImporterNode)

        Public Sub New()
            Me.m_children = New List(Of ImporterNode)()
        End Sub

        Public Property Row() As DataRow
            Get
                Return m_row
            End Get
            Set(value As DataRow)
                m_row = value
            End Set
        End Property

        Public ReadOnly Property Children() As List(Of ImporterNode)
            Get
                Return m_children
            End Get
        End Property

    End Class

End Namespace