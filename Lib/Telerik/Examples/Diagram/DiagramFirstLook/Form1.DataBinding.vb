
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DiagramFirstLook
    Partial Public Class Form1
        Public Class Shapes
            Implements INotifyPropertyChanged
            Private m_id As String
            Private m_text As String
            Private m_type As String
            Private m_x As Double
            Private m_y As Double
            Private m_width As Double
            Private m_height As Double


            Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

            Public Property Id() As String
                Get
                    Return Me.m_id
                End Get
                Set(value As String)
                    Me.m_id = value
                    If Me.m_id <> value Then
                        Me.m_id = value
                        OnPropertyChanged("Id")
                    End If
                End Set
            End Property

            Public Property Text() As String
                Get
                    Return Me.m_text
                End Get
                Set(value As String)
                    Me.m_text = value
                    If Me.m_text <> value Then
                        Me.m_text = value
                        OnPropertyChanged("Text")
                    End If
                End Set
            End Property

            Public Property Type() As String
                Get
                    Return Me.m_type
                End Get
                Set(value As String)
                    If Me.m_type <> value Then
                        Me.m_type = value
                        OnPropertyChanged("Type")
                    End If
                End Set
            End Property

            Public Property X() As Double
                Get
                    Return Me.m_x
                End Get
                Set(value As Double)
                    If Me.m_x <> value Then
                        Me.m_x = value
                        OnPropertyChanged("X")
                    End If
                End Set
            End Property

            Public Property Y() As Double
                Get
                    Return Me.m_y
                End Get
                Set(value As Double)
                    Me.m_y = value
                    If Me.m_y <> value Then
                        Me.m_y = value
                        OnPropertyChanged("Y")
                    End If
                End Set
            End Property

            Public Property Height() As Double
                Get
                    Return Me.m_height
                End Get
                Set(value As Double)
                    If Me.m_height <> value Then
                        Me.m_height = value
                        OnPropertyChanged("Height")

                    End If
                End Set
            End Property

            Public Property Width() As Double
                Get
                    Return Me.m_width
                End Get
                Set(value As Double)
                    If Me.m_width <> value Then
                        Me.m_width = value
                        OnPropertyChanged("Width")
                    End If
                End Set
            End Property

            Private Sub OnPropertyChanged(propertyName As String)
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End Sub


        End Class

        Public Class Connections
            Implements INotifyPropertyChanged
            Private m_sourceShapeId As String
            Private m_sourceConnector As String
            Private m_targetShapeId As String
            Private m_targetConnector As String
            Private m_startCapField As String
            Private m_endCapField As String

            Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

            Public Property EndCapField() As String
                Get
                    Return Me.m_endCapField
                End Get
                Set(value As String)
                    Me.m_endCapField = value
                    If Me.m_endCapField <> value Then
                        Me.m_endCapField = value
                        OnPropertyChanged("EndCapField")
                    End If
                End Set
            End Property

            Public Property StartCapField() As String
                Get
                    Return Me.m_startCapField
                End Get
                Set(value As String)
                    Me.m_startCapField = value
                    If Me.m_startCapField <> value Then
                        Me.m_startCapField = value
                        OnPropertyChanged("StartCapField")
                    End If
                End Set
            End Property

            Public Property TargetConnector() As String
                Get
                    Return Me.m_targetConnector
                End Get
                Set(value As String)
                    Me.m_targetConnector = value
                    If Me.m_targetConnector <> value Then
                        Me.m_targetConnector = value
                        OnPropertyChanged("TargetConnector")
                    End If
                End Set
            End Property

            Public Property TargetShapeId() As String
                Get
                    Return Me.m_targetShapeId
                End Get
                Set(value As String)
                    Me.m_targetShapeId = value
                    If Me.m_targetShapeId <> value Then
                        Me.m_targetShapeId = value
                        OnPropertyChanged("TargetShapeId")
                    End If
                End Set
            End Property

            Public Property SourceConnector() As String
                Get
                    Return Me.m_sourceConnector
                End Get
                Set(value As String)
                    Me.m_sourceConnector = value
                    If Me.m_sourceConnector <> value Then
                        Me.m_sourceConnector = value
                        OnPropertyChanged("SourceConnector")
                    End If
                End Set
            End Property

            Public Property SourceShapeId() As String
                Get
                    Return Me.m_sourceShapeId
                End Get
                Set(value As String)
                    Me.m_sourceShapeId = value
                    If Me.m_sourceShapeId <> value Then
                        Me.m_sourceShapeId = value
                        OnPropertyChanged("SourceShapeId")
                    End If
                End Set
            End Property

            Private Sub OnPropertyChanged(propertyName As String)
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End Sub


        End Class

        Public Class Main
            Public ReadOnly Property Shapes() As BindingList(Of Shapes)
                Get
                    Return GetShapes()
                End Get
            End Property

            Public ReadOnly Property Connections() As BindingList(Of Connections)
                Get
                    Return GetConnections()
                End Get
            End Property


            Private Function GetShapes() As BindingList(Of Shapes)
                Return New BindingList(Of Shapes)() From { _
                    New Shapes() With { _
                        .Id = "Shape1", _
                        .Text = "Shape 1", _
                        .Type = "circle", _
                        .X = 100, _
                        .Y = 300, _
                        .Width = 50, _
                        .Height = 50 _
                    }, _
                    New Shapes() With { _
                        .Id = "Shape2", _
                        .Text = "Shape 2", _
                        .Type = "rectangle", _
                        .X = 200, _
                        .Y = 100, _
                        .Width = 100, _
                        .Height = 100 _
                    }, _
                    New Shapes() With { _
                        .Id = "Shape3", _
                        .Text = "Shape 3", _
                        .Type = "circle", _
                        .X = 300, _
                        .Y = 300, _
                        .Width = 50, _
                        .Height = 50 _
                    }, _
                    New Shapes() With { _
                        .Id = "Shape4", _
                        .Text = "Shape 4", _
                        .Type = "rectangle", _
                        .X = 400, _
                        .Y = 100, _
                        .Width = 100, _
                        .Height = 100 _
                    }, _
                    New Shapes() With { _
                        .Id = "Shape5", _
                        .Text = "Shape 5", _
                        .Type = "circle", _
                        .X = 500, _
                        .Y = 300, _
                        .Width = 50, _
                        .Height = 50 _
                    } _
                }
            End Function

            Private Function GetConnections() As BindingList(Of Connections)
                Return New BindingList(Of Connections)() From { _
                    New Connections() With { _
                        .SourceShapeId = "Shape2", _
                        .SourceConnector = "Auto", _
                        .TargetShapeId = "Shape1", _
                        .TargetConnector = "Auto", _
                        .StartCapField = "Arrow5Filled", _
                        .EndCapField = "Arrow1" _
                    }, _
                    New Connections() With { _
                        .SourceShapeId = "Shape2", _
                        .SourceConnector = "Auto", _
                        .TargetShapeId = "Shape3", _
                        .TargetConnector = "Auto", _
                        .StartCapField = "Arrow4Filled", _
                        .EndCapField = "Arrow1Filled" _
                    }, _
                    New Connections() With { _
                        .SourceShapeId = "Shape4", _
                        .SourceConnector = "Auto", _
                        .TargetShapeId = "Shape5", _
                        .TargetConnector = "Auto", _
                        .StartCapField = "Arrow2Filled", _
                        .EndCapField = "Arrow2" _
                    } _
                }
            End Function
        End Class

        Private Sub SetupDataBindindngs()
            Dim shapesTable As New DataTable("Shapes")
            Dim connectionsTable As New DataTable("Connections")
            shapesTable.Columns.Clear()
            shapesTable.Columns.Add("Id")
            shapesTable.Columns.Add("Text")
            shapesTable.Columns.Add("Type")
            shapesTable.Columns.Add("X")
            shapesTable.Columns.Add("Y")
            shapesTable.Columns.Add("Width")
            shapesTable.Columns.Add("Height")
            shapesTable.Rows.Add("Shape1", "Shape 1", "circle", 100, 300, 50, _
                50)
            shapesTable.Rows.Add("Shape2", "Shape 2", "rectangle", 200, 100, 100, _
                100)
            shapesTable.Rows.Add("Shape3", "Shape 3", "circle", 300, 300, 50, _
                50)
            shapesTable.Rows.Add("Shape4", "Shape 4", "rectangle", 400, 100, 100, _
                100)
            shapesTable.Rows.Add("Shape5", "Shape 5", "circle", 500, 300, 50, _
                50)

            connectionsTable.Columns.Clear()
            connectionsTable.Columns.Add("SourceShapeId")
            connectionsTable.Columns.Add("SourceConnector")
            connectionsTable.Columns.Add("TargetShapeId")
            connectionsTable.Columns.Add("TargetConnector")
            connectionsTable.Columns.Add("StartCapField")
            connectionsTable.Columns.Add("EndCapField")
            connectionsTable.Rows.Add("Shape2", "Auto", "Shape1", "Auto", "Arrow5Filled", "Arrow1")
            connectionsTable.Rows.Add("Shape2", "Auto", "Shape3", "Auto", "Arrow4Filled", "Arrow1Filled")
            connectionsTable.Rows.Add("Shape4", "Auto", "Shape5", "Auto", "Arrow2Filled", "Arrow2")

            Dim ds As New DataSet()
            ds.Tables.Add(shapesTable)
            ds.Tables.Add(connectionsTable)

            Dim bindingSource1 As New BindingSource()

            bindingSource1.DataSource = ds
            ' new Main();
            Me.radDiagram1.DiagramElement.DataLayer.DataSource = bindingSource1

            Me.radDiagram1.DiagramElement.DataLayer.ConnectionDataMember = "Connections"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeDataMember = "Shapes"

            Me.radDiagram1.DiagramElement.DataLayer.ConnectionTargetCapTypeMember = "endCapField"
            Me.radDiagram1.DiagramElement.DataLayer.ConnectionSourceCapTypeMember = "startCapField"
            Me.radDiagram1.DiagramElement.DataLayer.ConnectionSourceShapeIdMember = "sourceShapeId"
            Me.radDiagram1.DiagramElement.DataLayer.ConnectionTargetShapeIdMember = "targetShapeId"
            Me.radDiagram1.DiagramElement.DataLayer.ConnectionSourceConnectorMember = "sourceConnector"
            Me.radDiagram1.DiagramElement.DataLayer.ConnectionTargetConnectorMember = "targetConnector"

            Me.radDiagram1.DiagramElement.DataLayer.ShapeXMember = "x"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeYMember = "y"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeWidthMember = "width"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeHeightMember = "height"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeTypeMember = "type"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeIdMember = "id"
            Me.radDiagram1.DiagramElement.DataLayer.ShapeTextMember = "text"
        End Sub

    End Class
End Namespace

