

Namespace Telerik.Examples.WinControls.DataSources


    ''' <summary>
    '''Represents a strongly typed in-memory cache of data.
    '''</summary>
    <System.Serializable()> _
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")> _
    <System.Xml.Serialization.XmlRootAttribute("ChartDataSet")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
    Partial Public Class ChartDataSet
        Inherits Global.System.Data.DataSet

        Private tableCategory As CategoryDataTable

        Private tableData As DataDataTable

        Private tableRevenue As RevenueDataTable

        Private tableSubcategory As SubcategoryDataTable

        Private tableGetCategories As GetCategoriesDataTable

        Private tableGetYears As GetYearsDataTable

        Private tableQuery1 As Query1DataTable

        Private tableQuery2 As Query2DataTable

        Private relationSubcategoryData As Global.System.Data.DataRelation

        Private relationCategorySubcategory As Global.System.Data.DataRelation

        Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.BeginInit()
            Me.InitClass()
            Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
            AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
            Me.EndInit()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context, False)
            If (Me.IsBinarySerialized(info, context) = True) Then
                Me.InitVars(False)
                Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
                AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
                AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
                Return
            End If
            Dim strSchema As String = DirectCast(info.GetValue("XmlSchema", GetType(String)), String)
            If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
                Dim ds As New Global.System.Data.DataSet()
                ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
                If (ds.Tables("Category") IsNot Nothing) Then
                    MyBase.Tables.Add(New CategoryDataTable(ds.Tables("Category")))
                End If
                If (ds.Tables("Data") IsNot Nothing) Then
                    MyBase.Tables.Add(New DataDataTable(ds.Tables("Data")))
                End If
                If (ds.Tables("Revenue") IsNot Nothing) Then
                    MyBase.Tables.Add(New RevenueDataTable(ds.Tables("Revenue")))
                End If
                If (ds.Tables("Subcategory") IsNot Nothing) Then
                    MyBase.Tables.Add(New SubcategoryDataTable(ds.Tables("Subcategory")))
                End If
                If (ds.Tables("GetCategories") IsNot Nothing) Then
                    MyBase.Tables.Add(New GetCategoriesDataTable(ds.Tables("GetCategories")))
                End If
                If (ds.Tables("GetYears") IsNot Nothing) Then
                    MyBase.Tables.Add(New GetYearsDataTable(ds.Tables("GetYears")))
                End If
                If (ds.Tables("Query1") IsNot Nothing) Then
                    MyBase.Tables.Add(New Query1DataTable(ds.Tables("Query1")))
                End If
                If (ds.Tables("Query2") IsNot Nothing) Then
                    MyBase.Tables.Add(New Query2DataTable(ds.Tables("Query2")))
                End If
                Me.DataSetName = ds.DataSetName
                Me.Prefix = ds.Prefix
                Me.[Namespace] = ds.[Namespace]
                Me.Locale = ds.Locale
                Me.CaseSensitive = ds.CaseSensitive
                Me.EnforceConstraints = ds.EnforceConstraints
                Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
                Me.InitVars()
            Else
                Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            End If
            Me.GetSerializationData(info, context)
            Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Category() As CategoryDataTable
            Get
                Return Me.tableCategory
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Data() As DataDataTable
            Get
                Return Me.tableData
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Revenue() As RevenueDataTable
            Get
                Return Me.tableRevenue
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Subcategory() As SubcategoryDataTable
            Get
                Return Me.tableSubcategory
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property GetCategories() As GetCategoriesDataTable
            Get
                Return Me.tableGetCategories
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property GetYears() As GetYearsDataTable
            Get
                Return Me.tableGetYears
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Query1() As Query1DataTable
            Get
                Return Me.tableQuery1
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Browsable(False)> _
        <System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Query2() As Query2DataTable
            Get
                Return Me.tableQuery2
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.BrowsableAttribute(True)> _
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
        Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(value As Global.System.Data.SchemaSerializationMode)
                Me._schemaSerializationMode = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
        Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
        Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub InitializeDerivedDataSet()
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overrides Function Clone() As Global.System.Data.DataSet
            Dim cln As ChartDataSet = DirectCast(MyBase.Clone(), ChartDataSet)
            cln.InitVars()
            cln.SchemaSerializationMode = Me.SchemaSerializationMode
            Return cln
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub ReadXmlSerializable(reader As Global.System.Xml.XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
                Me.Reset()
                Dim ds As New Global.System.Data.DataSet()
                ds.ReadXml(reader)
                If (ds.Tables("Category") IsNot Nothing) Then
                    MyBase.Tables.Add(New CategoryDataTable(ds.Tables("Category")))
                End If
                If (ds.Tables("Data") IsNot Nothing) Then
                    MyBase.Tables.Add(New DataDataTable(ds.Tables("Data")))
                End If
                If (ds.Tables("Revenue") IsNot Nothing) Then
                    MyBase.Tables.Add(New RevenueDataTable(ds.Tables("Revenue")))
                End If
                If (ds.Tables("Subcategory") IsNot Nothing) Then
                    MyBase.Tables.Add(New SubcategoryDataTable(ds.Tables("Subcategory")))
                End If
                If (ds.Tables("GetCategories") IsNot Nothing) Then
                    MyBase.Tables.Add(New GetCategoriesDataTable(ds.Tables("GetCategories")))
                End If
                If (ds.Tables("GetYears") IsNot Nothing) Then
                    MyBase.Tables.Add(New GetYearsDataTable(ds.Tables("GetYears")))
                End If
                If (ds.Tables("Query1") IsNot Nothing) Then
                    MyBase.Tables.Add(New Query1DataTable(ds.Tables("Query1")))
                End If
                If (ds.Tables("Query2") IsNot Nothing) Then
                    MyBase.Tables.Add(New Query2DataTable(ds.Tables("Query2")))
                End If
                Me.DataSetName = ds.DataSetName
                Me.Prefix = ds.Prefix
                Me.[Namespace] = ds.[Namespace]
                Me.Locale = ds.Locale
                Me.CaseSensitive = ds.CaseSensitive
                Me.EnforceConstraints = ds.EnforceConstraints
                Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
                Me.InitVars()
            Else
                Me.ReadXml(reader)
                Me.InitVars()
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
            Dim stream As New Global.System.IO.MemoryStream()
            Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
            stream.Position = 0
            Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub InitVars()
            Me.InitVars(True)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub InitVars(initTable As Boolean)
            Me.tableCategory = DirectCast(MyBase.Tables("Category"), CategoryDataTable)
            If (initTable = True) Then
                If (Me.tableCategory IsNot Nothing) Then
                    Me.tableCategory.InitVars()
                End If
            End If
            Me.tableData = DirectCast(MyBase.Tables("Data"), DataDataTable)
            If (initTable = True) Then
                If (Me.tableData IsNot Nothing) Then
                    Me.tableData.InitVars()
                End If
            End If
            Me.tableRevenue = DirectCast(MyBase.Tables("Revenue"), RevenueDataTable)
            If (initTable = True) Then
                If (Me.tableRevenue IsNot Nothing) Then
                    Me.tableRevenue.InitVars()
                End If
            End If
            Me.tableSubcategory = DirectCast(MyBase.Tables("Subcategory"), SubcategoryDataTable)
            If (initTable = True) Then
                If (Me.tableSubcategory IsNot Nothing) Then
                    Me.tableSubcategory.InitVars()
                End If
            End If
            Me.tableGetCategories = DirectCast(MyBase.Tables("GetCategories"), GetCategoriesDataTable)
            If (initTable = True) Then
                If (Me.tableGetCategories IsNot Nothing) Then
                    Me.tableGetCategories.InitVars()
                End If
            End If
            Me.tableGetYears = DirectCast(MyBase.Tables("GetYears"), GetYearsDataTable)
            If (initTable = True) Then
                If (Me.tableGetYears IsNot Nothing) Then
                    Me.tableGetYears.InitVars()
                End If
            End If
            Me.tableQuery1 = DirectCast(MyBase.Tables("Query1"), Query1DataTable)
            If (initTable = True) Then
                If (Me.tableQuery1 IsNot Nothing) Then
                    Me.tableQuery1.InitVars()
                End If
            End If
            Me.tableQuery2 = DirectCast(MyBase.Tables("Query2"), Query2DataTable)
            If (initTable = True) Then
                If (Me.tableQuery2 IsNot Nothing) Then
                    Me.tableQuery2.InitVars()
                End If
            End If
            Me.relationSubcategoryData = Me.Relations("SubcategoryData")
            Me.relationCategorySubcategory = Me.Relations("CategorySubcategory")
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitClass()
            Me.DataSetName = "ChartDataSet"
            Me.Prefix = ""
            Me.[Namespace] = "http://tempuri.org/ChartDataSet.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
            Me.tableCategory = New CategoryDataTable()
            MyBase.Tables.Add(Me.tableCategory)
            Me.tableData = New DataDataTable()
            MyBase.Tables.Add(Me.tableData)
            Me.tableRevenue = New RevenueDataTable()
            MyBase.Tables.Add(Me.tableRevenue)
            Me.tableSubcategory = New SubcategoryDataTable()
            MyBase.Tables.Add(Me.tableSubcategory)
            Me.tableGetCategories = New GetCategoriesDataTable()
            MyBase.Tables.Add(Me.tableGetCategories)
            Me.tableGetYears = New GetYearsDataTable()
            MyBase.Tables.Add(Me.tableGetYears)
            Me.tableQuery1 = New Query1DataTable()
            MyBase.Tables.Add(Me.tableQuery1)
            Me.tableQuery2 = New Query2DataTable()
            MyBase.Tables.Add(Me.tableQuery2)
            Me.relationSubcategoryData = New Global.System.Data.DataRelation("SubcategoryData", New Global.System.Data.DataColumn() {Me.tableSubcategory.IdColumn}, New Global.System.Data.DataColumn() {Me.tableData.Subcategory_IdColumn}, False)
            Me.Relations.Add(Me.relationSubcategoryData)
            Me.relationCategorySubcategory = New Global.System.Data.DataRelation("CategorySubcategory", New Global.System.Data.DataColumn() {Me.tableCategory.IdColumn}, New Global.System.Data.DataColumn() {Me.tableSubcategory.Category_idColumn}, False)
            Me.Relations.Add(Me.relationCategorySubcategory)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeCategory() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeData() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeRevenue() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeSubcategory() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeGetCategories() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeGetYears() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeQuery1() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function ShouldSerializeQuery2() As Boolean
            Return False
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub SchemaChanged(sender As Object, e As Global.System.ComponentModel.CollectionChangeEventArgs)
            If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
                Me.InitVars()
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Shared Function GetTypedDataSetSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim ds As New ChartDataSet()
            Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim any As New Global.System.Xml.Schema.XmlSchemaAny()
            any.[Namespace] = ds.[Namespace]
            sequence.Items.Add(any)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As New Global.System.IO.MemoryStream()
                Dim s2 As New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                    While schemas.MoveNext()
                        schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                            End While
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                    End While
                Finally
                    If (s1 IsNot Nothing) Then
                        s1.Close()
                    End If
                    If (s2 IsNot Nothing) Then
                        s2.Close()
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub CategoryRowChangeEventHandler(sender As Object, e As CategoryRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub DataRowChangeEventHandler(sender As Object, e As DataRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub RevenueRowChangeEventHandler(sender As Object, e As RevenueRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub SubcategoryRowChangeEventHandler(sender As Object, e As SubcategoryRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub GetCategoriesRowChangeEventHandler(sender As Object, e As GetCategoriesRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub GetYearsRowChangeEventHandler(sender As Object, e As GetYearsRowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub Query1RowChangeEventHandler(sender As Object, e As Query1RowChangeEvent)

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Delegate Sub Query2RowChangeEventHandler(sender As Object, e As Query2RowChangeEvent)

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class CategoryDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnId As Global.System.Data.DataColumn

            Private columnName As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Category"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property IdColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnId
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As CategoryRow
                Get
                    Return DirectCast(Me.Rows(index), CategoryRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event CategoryRowChanging As CategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event CategoryRowChanged As CategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event CategoryRowDeleting As CategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event CategoryRowDeleted As CategoryRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddCategoryRow(row As CategoryRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddCategoryRow(Name As String) As CategoryRow
                Dim rowCategoryRow As CategoryRow = DirectCast(Me.NewRow(), CategoryRow)
                Dim columnValuesArray As Object() = New Object() {Nothing, Name}
                rowCategoryRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowCategoryRow)
                Return rowCategoryRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function FindById(Id As Integer) As CategoryRow
                Return DirectCast(Me.Rows.Find(New Object() {Id}), CategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As CategoryDataTable = DirectCast(MyBase.Clone(), CategoryDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New CategoryDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnId = MyBase.Columns("Id")
                Me.columnName = MyBase.Columns("Name")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnId = New Global.System.Data.DataColumn("Id", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnId)
                Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnId}, True))
                Me.columnId.AutoIncrement = True
                Me.columnId.AllowDBNull = False
                Me.columnId.Unique = True
                Me.columnName.MaxLength = 50
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewCategoryRow() As CategoryRow
                Return DirectCast(Me.NewRow(), CategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New CategoryRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(CategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent CategoryRowChanged(Me, New CategoryRowChangeEvent(DirectCast(e.Row, CategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent CategoryRowChanging(Me, New CategoryRowChangeEvent(DirectCast(e.Row, CategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent CategoryRowDeleted(Me, New CategoryRowChangeEvent(DirectCast(e.Row, CategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent CategoryRowDeleting(Me, New CategoryRowChangeEvent(DirectCast(e.Row, CategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveCategoryRow(row As CategoryRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "CategoryDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class DataDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnYear As Global.System.Data.DataColumn

            Private columnValue As Global.System.Data.DataColumn

            Private columnSubcategory_Id As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Data"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property YearColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnYear
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property ValueColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnValue
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Subcategory_IdColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnSubcategory_Id
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As DataRow
                Get
                    Return DirectCast(Me.Rows(index), DataRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event DataRowChanging As DataRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event DataRowChanged As DataRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event DataRowDeleting As DataRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event DataRowDeleted As DataRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddDataRow(row As DataRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddDataRow(Year As Integer, Value As Double, parentSubcategoryRowBySubcategoryData As SubcategoryRow) As DataRow
                Dim rowDataRow As DataRow = DirectCast(Me.NewRow(), DataRow)
                Dim columnValuesArray As Object() = New Object() {Year, Value, Nothing}
                If (parentSubcategoryRowBySubcategoryData IsNot Nothing) Then
                    columnValuesArray(2) = parentSubcategoryRowBySubcategoryData(0)
                End If
                rowDataRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowDataRow)
                Return rowDataRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As DataDataTable = DirectCast(MyBase.Clone(), DataDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New DataDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnYear = MyBase.Columns("Year")
                Me.columnValue = MyBase.Columns("Value")
                Me.columnSubcategory_Id = MyBase.Columns("Subcategory_Id")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnYear = New Global.System.Data.DataColumn("Year", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnYear)
                Me.columnValue = New Global.System.Data.DataColumn("Value", GetType(Double), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnValue)
                Me.columnSubcategory_Id = New Global.System.Data.DataColumn("Subcategory_Id", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnSubcategory_Id)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewDataRow() As DataRow
                Return DirectCast(Me.NewRow(), DataRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New DataRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(DataRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent DataRowChanged(Me, New DataRowChangeEvent(DirectCast(e.Row, DataRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent DataRowChanging(Me, New DataRowChangeEvent(DirectCast(e.Row, DataRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent DataRowDeleted(Me, New DataRowChangeEvent(DirectCast(e.Row, DataRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent DataRowDeleting(Me, New DataRowChangeEvent(DirectCast(e.Row, DataRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveDataRow(row As DataRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "DataDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class RevenueDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnID As Global.System.Data.DataColumn

            Private columnMonth As Global.System.Data.DataColumn

            Private columnQuarter As Global.System.Data.DataColumn

            Private columnYear As Global.System.Data.DataColumn

            Private columnRevenue As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Revenue"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property IDColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnID
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property MonthColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnMonth
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property QuarterColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnQuarter
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property YearColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnYear
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property RevenueColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnRevenue
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As RevenueRow
                Get
                    Return DirectCast(Me.Rows(index), RevenueRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event RevenueRowChanging As RevenueRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event RevenueRowChanged As RevenueRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event RevenueRowDeleting As RevenueRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event RevenueRowDeleted As RevenueRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddRevenueRow(row As RevenueRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddRevenueRow(Month As Integer, Quarter As Integer, Year As Integer, Revenue As Decimal) As RevenueRow
                Dim rowRevenueRow As RevenueRow = DirectCast(Me.NewRow(), RevenueRow)
                Dim columnValuesArray As Object() = New Object() {Nothing, Month, Quarter, Year, Revenue}
                rowRevenueRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowRevenueRow)
                Return rowRevenueRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function FindByID(ID As Integer) As RevenueRow
                Return DirectCast(Me.Rows.Find(New Object() {ID}), RevenueRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As RevenueDataTable = DirectCast(MyBase.Clone(), RevenueDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New RevenueDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnID = MyBase.Columns("ID")
                Me.columnMonth = MyBase.Columns("Month")
                Me.columnQuarter = MyBase.Columns("Quarter")
                Me.columnYear = MyBase.Columns("Year")
                Me.columnRevenue = MyBase.Columns("Revenue")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnID = New Global.System.Data.DataColumn("ID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnID)
                Me.columnMonth = New Global.System.Data.DataColumn("Month", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnMonth)
                Me.columnQuarter = New Global.System.Data.DataColumn("Quarter", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnQuarter)
                Me.columnYear = New Global.System.Data.DataColumn("Year", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnYear)
                Me.columnRevenue = New Global.System.Data.DataColumn("Revenue", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnRevenue)
                Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnID}, True))
                Me.columnID.AutoIncrement = True
                Me.columnID.AllowDBNull = False
                Me.columnID.Unique = True
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewRevenueRow() As RevenueRow
                Return DirectCast(Me.NewRow(), RevenueRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New RevenueRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(RevenueRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent RevenueRowChanged(Me, New RevenueRowChangeEvent(DirectCast(e.Row, RevenueRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent RevenueRowChanging(Me, New RevenueRowChangeEvent(DirectCast(e.Row, RevenueRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent RevenueRowDeleted(Me, New RevenueRowChangeEvent(DirectCast(e.Row, RevenueRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent RevenueRowDeleting(Me, New RevenueRowChangeEvent(DirectCast(e.Row, RevenueRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveRevenueRow(row As RevenueRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "RevenueDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class SubcategoryDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnId As Global.System.Data.DataColumn

            Private columnName As Global.System.Data.DataColumn

            Private columnCategory_id As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Subcategory"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property IdColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnId
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Category_idColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnCategory_id
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As SubcategoryRow
                Get
                    Return DirectCast(Me.Rows(index), SubcategoryRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event SubcategoryRowChanging As SubcategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event SubcategoryRowChanged As SubcategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event SubcategoryRowDeleting As SubcategoryRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event SubcategoryRowDeleted As SubcategoryRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddSubcategoryRow(row As SubcategoryRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddSubcategoryRow(Name As String, parentCategoryRowByCategorySubcategory As CategoryRow) As SubcategoryRow
                Dim rowSubcategoryRow As SubcategoryRow = DirectCast(Me.NewRow(), SubcategoryRow)
                Dim columnValuesArray As Object() = New Object() {Nothing, Name, Nothing}
                If (parentCategoryRowByCategorySubcategory IsNot Nothing) Then
                    columnValuesArray(2) = parentCategoryRowByCategorySubcategory(0)
                End If
                rowSubcategoryRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowSubcategoryRow)
                Return rowSubcategoryRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function FindById(Id As Integer) As SubcategoryRow
                Return DirectCast(Me.Rows.Find(New Object() {Id}), SubcategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As SubcategoryDataTable = DirectCast(MyBase.Clone(), SubcategoryDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New SubcategoryDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnId = MyBase.Columns("Id")
                Me.columnName = MyBase.Columns("Name")
                Me.columnCategory_id = MyBase.Columns("Category_id")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnId = New Global.System.Data.DataColumn("Id", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnId)
                Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnCategory_id = New Global.System.Data.DataColumn("Category_id", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnCategory_id)
                Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnId}, True))
                Me.columnId.AutoIncrement = True
                Me.columnId.AllowDBNull = False
                Me.columnId.Unique = True
                Me.columnName.MaxLength = 50
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewSubcategoryRow() As SubcategoryRow
                Return DirectCast(Me.NewRow(), SubcategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New SubcategoryRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(SubcategoryRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent SubcategoryRowChanged(Me, New SubcategoryRowChangeEvent(DirectCast(e.Row, SubcategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent SubcategoryRowChanging(Me, New SubcategoryRowChangeEvent(DirectCast(e.Row, SubcategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent SubcategoryRowDeleted(Me, New SubcategoryRowChangeEvent(DirectCast(e.Row, SubcategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent SubcategoryRowDeleting(Me, New SubcategoryRowChangeEvent(DirectCast(e.Row, SubcategoryRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveSubcategoryRow(row As SubcategoryRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "SubcategoryDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class GetCategoriesDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnId As Global.System.Data.DataColumn

            Private columnName As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "GetCategories"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property IdColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnId
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As GetCategoriesRow
                Get
                    Return DirectCast(Me.Rows(index), GetCategoriesRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetCategoriesRowChanging As GetCategoriesRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetCategoriesRowChanged As GetCategoriesRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetCategoriesRowDeleting As GetCategoriesRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetCategoriesRowDeleted As GetCategoriesRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddGetCategoriesRow(row As GetCategoriesRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddGetCategoriesRow(Name As String) As GetCategoriesRow
                Dim rowGetCategoriesRow As GetCategoriesRow = DirectCast(Me.NewRow(), GetCategoriesRow)
                Dim columnValuesArray As Object() = New Object() {Nothing, Name}
                rowGetCategoriesRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowGetCategoriesRow)
                Return rowGetCategoriesRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function FindById(Id As Integer) As GetCategoriesRow
                Return DirectCast(Me.Rows.Find(New Object() {Id}), GetCategoriesRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As GetCategoriesDataTable = DirectCast(MyBase.Clone(), GetCategoriesDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New GetCategoriesDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnId = MyBase.Columns("Id")
                Me.columnName = MyBase.Columns("Name")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnId = New Global.System.Data.DataColumn("Id", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnId)
                Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnId}, True))
                Me.columnId.AutoIncrement = True
                Me.columnId.AllowDBNull = False
                Me.columnId.Unique = True
                Me.columnName.MaxLength = 50
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewGetCategoriesRow() As GetCategoriesRow
                Return DirectCast(Me.NewRow(), GetCategoriesRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New GetCategoriesRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(GetCategoriesRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent GetCategoriesRowChanged(Me, New GetCategoriesRowChangeEvent(DirectCast(e.Row, GetCategoriesRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent GetCategoriesRowChanging(Me, New GetCategoriesRowChangeEvent(DirectCast(e.Row, GetCategoriesRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent GetCategoriesRowDeleted(Me, New GetCategoriesRowChangeEvent(DirectCast(e.Row, GetCategoriesRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent GetCategoriesRowDeleting(Me, New GetCategoriesRowChangeEvent(DirectCast(e.Row, GetCategoriesRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveGetCategoriesRow(row As GetCategoriesRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "GetCategoriesDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class GetYearsDataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnYear As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "GetYears"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property YearColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnYear
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As GetYearsRow
                Get
                    Return DirectCast(Me.Rows(index), GetYearsRow)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetYearsRowChanging As GetYearsRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetYearsRowChanged As GetYearsRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetYearsRowDeleting As GetYearsRowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event GetYearsRowDeleted As GetYearsRowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddGetYearsRow(row As GetYearsRow)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddGetYearsRow(Year As Integer) As GetYearsRow
                Dim rowGetYearsRow As GetYearsRow = DirectCast(Me.NewRow(), GetYearsRow)
                Dim columnValuesArray As Object() = New Object() {Year}
                rowGetYearsRow.ItemArray = columnValuesArray
                Me.Rows.Add(rowGetYearsRow)
                Return rowGetYearsRow
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As GetYearsDataTable = DirectCast(MyBase.Clone(), GetYearsDataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New GetYearsDataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnYear = MyBase.Columns("Year")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnYear = New Global.System.Data.DataColumn("Year", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnYear)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewGetYearsRow() As GetYearsRow
                Return DirectCast(Me.NewRow(), GetYearsRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New GetYearsRow(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(GetYearsRow)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent GetYearsRowChanged(Me, New GetYearsRowChangeEvent(DirectCast(e.Row, GetYearsRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent GetYearsRowChanging(Me, New GetYearsRowChangeEvent(DirectCast(e.Row, GetYearsRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent GetYearsRowDeleted(Me, New GetYearsRowChangeEvent(DirectCast(e.Row, GetYearsRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent GetYearsRowDeleting(Me, New GetYearsRowChangeEvent(DirectCast(e.Row, GetYearsRow), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveGetYearsRow(row As GetYearsRow)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "GetYearsDataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class Query1DataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnYear As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Query1"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property YearColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnYear
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As Query1Row
                Get
                    Return DirectCast(Me.Rows(index), Query1Row)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query1RowChanging As Query1RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query1RowChanged As Query1RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query1RowDeleting As Query1RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query1RowDeleted As Query1RowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddQuery1Row(row As Query1Row)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddQuery1Row(Year As Integer) As Query1Row
                Dim rowQuery1Row As Query1Row = DirectCast(Me.NewRow(), Query1Row)
                Dim columnValuesArray As Object() = New Object() {Year}
                rowQuery1Row.ItemArray = columnValuesArray
                Me.Rows.Add(rowQuery1Row)
                Return rowQuery1Row
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As Query1DataTable = DirectCast(MyBase.Clone(), Query1DataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New Query1DataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnYear = MyBase.Columns("Year")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnYear = New Global.System.Data.DataColumn("Year", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnYear)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewQuery1Row() As Query1Row
                Return DirectCast(Me.NewRow(), Query1Row)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New Query1Row(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(Query1Row)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent Query1RowChanged(Me, New Query1RowChangeEvent(DirectCast(e.Row, Query1Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent Query1RowChanging(Me, New Query1RowChangeEvent(DirectCast(e.Row, Query1Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent Query1RowDeleted(Me, New Query1RowChangeEvent(DirectCast(e.Row, Query1Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent Query1RowDeleting(Me, New Query1RowChangeEvent(DirectCast(e.Row, Query1Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveQuery1Row(row As Query1Row)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "Query1DataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents the strongly named DataTable class.
        '''</summary>
        <System.Serializable()> _
        <System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
        Partial Public Class Query2DataTable
            Inherits Global.System.Data.DataTable
            Implements Global.System.Collections.IEnumerable

            Private columnYear As Global.System.Data.DataColumn

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New()
                Me.TableName = "Query2"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(table As Global.System.Data.DataTable)
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
                    Me.Locale = table.Locale
                End If
                If (table.[Namespace] <> table.DataSet.[Namespace]) Then
                    Me.[Namespace] = table.[Namespace]
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Sub New(info As Global.System.Runtime.Serialization.SerializationInfo, context As Global.System.Runtime.Serialization.StreamingContext)
                MyBase.New(info, context)
                Me.InitVars()
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property YearColumn() As Global.System.Data.DataColumn
                Get
                    Return Me.columnYear
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            <System.ComponentModel.Browsable(False)> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Default Public ReadOnly Property Item(index As Integer) As Query2Row
                Get
                    Return DirectCast(Me.Rows(index), Query2Row)
                End Get
            End Property

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query2RowChanging As Query2RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query2RowChanged As Query2RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query2RowDeleting As Query2RowChangeEventHandler

            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Event Query2RowDeleted As Query2RowChangeEventHandler

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub AddQuery2Row(row As Query2Row)
                Me.Rows.Add(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function AddQuery2Row(Year As Integer) As Query2Row
                Dim rowQuery2Row As Query2Row = DirectCast(Me.NewRow(), Query2Row)
                Dim columnValuesArray As Object() = New Object() {Year}
                rowQuery2Row.ItemArray = columnValuesArray
                Me.Rows.Add(rowQuery2Row)
                Return rowQuery2Row
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Overrides Function Clone() As Global.System.Data.DataTable
                Dim cln As Query2DataTable = DirectCast(MyBase.Clone(), Query2DataTable)
                cln.InitVars()
                Return cln
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
                Return New Query2DataTable()
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub InitVars()
                Me.columnYear = MyBase.Columns("Year")
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Private Sub InitClass()
                Me.columnYear = New Global.System.Data.DataColumn("Year", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
                MyBase.Columns.Add(Me.columnYear)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function NewQuery2Row() As Query2Row
                Return DirectCast(Me.NewRow(), Query2Row)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function NewRowFromBuilder(builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
                Return New Query2Row(builder)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Function GetRowType() As Global.System.Type
                Return GetType(Query2Row)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanged(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                RaiseEvent Query2RowChanged(Me, New Query2RowChangeEvent(DirectCast(e.Row, Query2Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowChanging(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                RaiseEvent Query2RowChanging(Me, New Query2RowChangeEvent(DirectCast(e.Row, Query2Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleted(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                RaiseEvent Query2RowDeleted(Me, New Query2RowChangeEvent(DirectCast(e.Row, Query2Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Protected Overrides Sub OnRowDeleting(e As Global.System.Data.DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                RaiseEvent Query2RowDeleting(Me, New Query2RowChangeEvent(DirectCast(e.Row, Query2Row), e.Action))
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub RemoveQuery2Row(row As Query2Row)
                Me.Rows.Remove(row)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Shared Function GetTypedTableSchema(xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
                Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
                Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
                Dim ds As New ChartDataSet()
                Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
                any1.[Namespace] = "http://www.w3.org/2001/XMLSchema"
                any1.MinOccurs = New Decimal(0)
                any1.MaxOccurs = Decimal.MaxValue
                any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any1)
                Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
                any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
                any2.MinOccurs = New Decimal(1)
                any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute1.Name = "namespace"
                attribute1.FixedValue = ds.[Namespace]
                type.Attributes.Add(attribute1)
                Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "Query2DataTable"
                type.Attributes.Add(attribute2)
                type.Particle = sequence
                Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
                If xs.Contains(dsSchema.TargetNamespace) Then
                    Dim s1 As New Global.System.IO.MemoryStream()
                    Dim s2 As New Global.System.IO.MemoryStream()
                    Try
                        Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                        dsSchema.Write(s1)
                        Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
                        While schemas.MoveNext()
                            schema = DirectCast(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                            s2.SetLength(0)
                            schema.Write(s2)
                            If (s1.Length = s2.Length) Then
                                s1.Position = 0
                                s2.Position = 0
                                While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))


                                End While
                                If (s1.Position = s1.Length) Then
                                    Return type
                                End If
                            End If
                        End While
                    Finally
                        If (s1 IsNot Nothing) Then
                            s1.Close()
                        End If
                        If (s2 IsNot Nothing) Then
                            s2.Close()
                        End If
                    End Try
                End If
                xs.Add(dsSchema)
                Return type
            End Function
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class CategoryRow
            Inherits Global.System.Data.DataRow

            Private tableCategory As CategoryDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableCategory = DirectCast(Me.Table, CategoryDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Id() As Integer
                Get
                    Return CInt(Me(Me.tableCategory.IdColumn))
                End Get
                Set(value As Integer)
                    Me(Me.tableCategory.IdColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Name() As String
                Get
                    Try
                        Return DirectCast(Me(Me.tableCategory.NameColumn), String)
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Name' in table 'Category' is DBNull.", e)
                    End Try
                End Get
                Set(value As String)
                    Me(Me.tableCategory.NameColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableCategory.NameColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetNameNull()
                Me(Me.tableCategory.NameColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function GetSubcategoryRows() As SubcategoryRow()
                If (Me.Table.ChildRelations("CategorySubcategory") Is Nothing) Then
                    Return New SubcategoryRow(-1) {}
                Else
                    Return DirectCast(MyBase.GetChildRows(Me.Table.ChildRelations("CategorySubcategory")), SubcategoryRow())
                End If
            End Function
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class DataRow
            Inherits Global.System.Data.DataRow

            Private tableData As DataDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableData = DirectCast(Me.Table, DataDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Year() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableData.YearColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Year' in table 'Data' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableData.YearColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Value() As Double
                Get
                    Try
                        Return CDbl(Me(Me.tableData.ValueColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Value' in table 'Data' is DBNull.", e)
                    End Try
                End Get
                Set(value As Double)
                    Me(Me.tableData.ValueColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Subcategory_Id() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableData.Subcategory_IdColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Subcategory_Id' in table 'Data' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableData.Subcategory_IdColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property SubcategoryRow() As SubcategoryRow
                Get
                    Return DirectCast(Me.GetParentRow(Me.Table.ParentRelations("SubcategoryData")), SubcategoryRow)
                End Get
                Set(value As SubcategoryRow)
                    Me.SetParentRow(value, Me.Table.ParentRelations("SubcategoryData"))
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsYearNull() As Boolean
                Return Me.IsNull(Me.tableData.YearColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetYearNull()
                Me(Me.tableData.YearColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsValueNull() As Boolean
                Return Me.IsNull(Me.tableData.ValueColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetValueNull()
                Me(Me.tableData.ValueColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsSubcategory_IdNull() As Boolean
                Return Me.IsNull(Me.tableData.Subcategory_IdColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetSubcategory_IdNull()
                Me(Me.tableData.Subcategory_IdColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class RevenueRow
            Inherits Global.System.Data.DataRow

            Private tableRevenue As RevenueDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableRevenue = DirectCast(Me.Table, RevenueDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property ID() As Integer
                Get
                    Return CInt(Me(Me.tableRevenue.IDColumn))
                End Get
                Set(value As Integer)
                    Me(Me.tableRevenue.IDColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Month() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableRevenue.MonthColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Month' in table 'Revenue' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableRevenue.MonthColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Quarter() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableRevenue.QuarterColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Quarter' in table 'Revenue' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableRevenue.QuarterColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Year() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableRevenue.YearColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Year' in table 'Revenue' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableRevenue.YearColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Revenue() As Decimal
                Get
                    Try
                        Return CDec(Me(Me.tableRevenue.RevenueColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Revenue' in table 'Revenue' is DBNull.", e)
                    End Try
                End Get
                Set(value As Decimal)
                    Me(Me.tableRevenue.RevenueColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsMonthNull() As Boolean
                Return Me.IsNull(Me.tableRevenue.MonthColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetMonthNull()
                Me(Me.tableRevenue.MonthColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsQuarterNull() As Boolean
                Return Me.IsNull(Me.tableRevenue.QuarterColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetQuarterNull()
                Me(Me.tableRevenue.QuarterColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsYearNull() As Boolean
                Return Me.IsNull(Me.tableRevenue.YearColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetYearNull()
                Me(Me.tableRevenue.YearColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsRevenueNull() As Boolean
                Return Me.IsNull(Me.tableRevenue.RevenueColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetRevenueNull()
                Me(Me.tableRevenue.RevenueColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class SubcategoryRow
            Inherits Global.System.Data.DataRow

            Private tableSubcategory As SubcategoryDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableSubcategory = DirectCast(Me.Table, SubcategoryDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Id() As Integer
                Get
                    Return CInt(Me(Me.tableSubcategory.IdColumn))
                End Get
                Set(value As Integer)
                    Me(Me.tableSubcategory.IdColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Name() As String
                Get
                    Try
                        Return DirectCast(Me(Me.tableSubcategory.NameColumn), String)
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Name' in table 'Subcategory' is DBNull.", e)
                    End Try
                End Get
                Set(value As String)
                    Me(Me.tableSubcategory.NameColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Category_id() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableSubcategory.Category_idColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Category_id' in table 'Subcategory' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableSubcategory.Category_idColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property CategoryRow() As CategoryRow
                Get
                    Return DirectCast(Me.GetParentRow(Me.Table.ParentRelations("CategorySubcategory")), CategoryRow)
                End Get
                Set(value As CategoryRow)
                    Me.SetParentRow(value, Me.Table.ParentRelations("CategorySubcategory"))
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableSubcategory.NameColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetNameNull()
                Me(Me.tableSubcategory.NameColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsCategory_idNull() As Boolean
                Return Me.IsNull(Me.tableSubcategory.Category_idColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetCategory_idNull()
                Me(Me.tableSubcategory.Category_idColumn) = Global.System.Convert.DBNull
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function GetDataRows() As DataRow()
                If (Me.Table.ChildRelations("SubcategoryData") Is Nothing) Then
                    Return New DataRow(-1) {}
                Else
                    Return DirectCast(MyBase.GetChildRows(Me.Table.ChildRelations("SubcategoryData")), DataRow())
                End If
            End Function
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class GetCategoriesRow
            Inherits Global.System.Data.DataRow

            Private tableGetCategories As GetCategoriesDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableGetCategories = DirectCast(Me.Table, GetCategoriesDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Id() As Integer
                Get
                    Return CInt(Me(Me.tableGetCategories.IdColumn))
                End Get
                Set(value As Integer)
                    Me(Me.tableGetCategories.IdColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Name() As String
                Get
                    Try
                        Return DirectCast(Me(Me.tableGetCategories.NameColumn), String)
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Name' in table 'GetCategories' is DBNull.", e)
                    End Try
                End Get
                Set(value As String)
                    Me(Me.tableGetCategories.NameColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableGetCategories.NameColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetNameNull()
                Me(Me.tableGetCategories.NameColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class GetYearsRow
            Inherits Global.System.Data.DataRow

            Private tableGetYears As GetYearsDataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableGetYears = DirectCast(Me.Table, GetYearsDataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Year() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableGetYears.YearColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Year' in table 'GetYears' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableGetYears.YearColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsYearNull() As Boolean
                Return Me.IsNull(Me.tableGetYears.YearColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetYearNull()
                Me(Me.tableGetYears.YearColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class Query1Row
            Inherits Global.System.Data.DataRow

            Private tableQuery1 As Query1DataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableQuery1 = DirectCast(Me.Table, Query1DataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Year() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableQuery1.YearColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Year' in table 'Query1' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableQuery1.YearColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsYearNull() As Boolean
                Return Me.IsNull(Me.tableQuery1.YearColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetYearNull()
                Me(Me.tableQuery1.YearColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Represents strongly named DataRow class.
        '''</summary>
        Partial Public Class Query2Row
            Inherits Global.System.Data.DataRow

            Private tableQuery2 As Query2DataTable

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Friend Sub New(rb As Global.System.Data.DataRowBuilder)
                MyBase.New(rb)
                Me.tableQuery2 = DirectCast(Me.Table, Query2DataTable)
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Property Year() As Integer
                Get
                    Try
                        Return CInt(Me(Me.tableQuery2.YearColumn))
                    Catch e As System.InvalidCastException
                        Throw New Global.System.Data.StrongTypingException("The value for column 'Year' in table 'Query2' is DBNull.", e)
                    End Try
                End Get
                Set(value As Integer)
                    Me(Me.tableQuery2.YearColumn) = value
                End Set
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function IsYearNull() As Boolean
                Return Me.IsNull(Me.tableQuery2.YearColumn)
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub SetYearNull()
                Me(Me.tableQuery2.YearColumn) = Global.System.Convert.DBNull
            End Sub
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class CategoryRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As CategoryRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As CategoryRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As CategoryRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class DataRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As DataRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As DataRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As DataRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class RevenueRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As RevenueRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As RevenueRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As RevenueRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class SubcategoryRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As SubcategoryRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As SubcategoryRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As SubcategoryRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class GetCategoriesRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As GetCategoriesRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As GetCategoriesRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As GetCategoriesRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class GetYearsRowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As GetYearsRow

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As GetYearsRow, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As GetYearsRow
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class Query1RowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As Query1Row

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As Query1Row, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As Query1Row
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class

        ''' <summary>
        '''Row event argument class
        '''</summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Class Query2RowChangeEvent
            Inherits Global.System.EventArgs

            Private eventRow As Query2Row

            Private eventAction As Global.System.Data.DataRowAction

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Sub New(row As Query2Row, action As Global.System.Data.DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Row() As Query2Row
                Get
                    Return Me.eventRow
                End Get
            End Property

            <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public ReadOnly Property Action() As Global.System.Data.DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property
        End Class
    End Class
End Namespace
Namespace Telerik.Examples.WinControls.DataSources.ChartDataSetTableAdapters


    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class CategoryTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Category"
            tableMapping.ColumnMappings.Add("Id", "Id")
            tableMapping.ColumnMappings.Add("Name", "Name")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Category` WHERE ((`Id` = ?) AND ((? = 1 AND `Name` IS NULL) OR (`Nam" + "e` = ?)))"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Id", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Name", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.InsertCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO `Category` (`Name`) VALUES (?)"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE `Category` SET `Name` = ? WHERE ((`Id` = ?) AND ((? = 1 AND `Name` IS NULL" + ") OR (`Name` = ?)))"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Id", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Name", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, False, Nothing))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.Default.ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT Id, Name FROM Category"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.CategoryDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.CategoryDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.CategoryDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataTable As ChartDataSet.CategoryDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataSet As ChartDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Category")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRow As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRows As Global.System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Overridable Function Delete(Original_Id As Integer, Original_Name As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CInt(Original_Id)
            If (Original_Name Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = DirectCast(Original_Name, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Function Insert(Name As String) As Integer
            If (Name Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = DirectCast(Name, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Overridable Function Update(Name As String, Original_Id As Integer, Original_Name As String) As Integer
            If (Name Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = DirectCast(Name, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(1).Value = CInt(Original_Id)
            If (Original_Name Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(2).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(3).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(3).Value = DirectCast(Original_Name, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class DataTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Data"
            tableMapping.ColumnMappings.Add("Year", "Year")
            tableMapping.ColumnMappings.Add("Value", "Value")
            tableMapping.ColumnMappings.Add("Subcategory_Id", "Subcategory_Id")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.InsertCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO `Data` (`Year`, `Value`, `Subcategory_Id`) VALUES (?, ?, ?)"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Value", Global.System.Data.OleDb.OleDbType.[Double], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Value", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Subcategory_Id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Subcategory_Id", Global.System.Data.DataRowVersion.Current, False, Nothing))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT [Year], [Value], Subcategory_Id FROM Data"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.DataDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.DataDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.DataDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataTable As ChartDataSet.DataDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataSet As ChartDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Data")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRow As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRows As Global.System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Function Insert(Year As Integer, Value As Global.System.Nullable(Of Double), Subcategory_Id As Integer) As Integer
            Me.Adapter.InsertCommand.Parameters(0).Value = CInt(Year)
            If (Value.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CDbl(Value.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.InsertCommand.Parameters(2).Value = CInt(Subcategory_Id)
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class RevenueTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Revenue"
            tableMapping.ColumnMappings.Add("ID", "ID")
            tableMapping.ColumnMappings.Add("Month", "Month")
            tableMapping.ColumnMappings.Add("Quarter", "Quarter")
            tableMapping.ColumnMappings.Add("Year", "Year")
            tableMapping.ColumnMappings.Add("Revenue", "Revenue")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Revenue` WHERE ((`ID` = ?) AND ((? = 1 AND `Month` IS NULL) OR (`Mon" + "th` = ?)) AND ((? = 1 AND `Quarter` IS NULL) OR (`Quarter` = ?)) AND ((? = 1 AND" + " `Year` IS NULL) OR (`Year` = ?)) AND ((? = 1 AND `Revenue` IS NULL) OR (`Revenu" + "e` = ?)))"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ID", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "ID", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Revenue", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Revenue", Global.System.Data.OleDb.OleDbType.Currency, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.InsertCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO `Revenue` (`Month`, `Quarter`, `Year`, `Revenue`) VALUES (?, ?, ?, ?)" + ""
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Revenue", Global.System.Data.OleDb.OleDbType.Currency, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE `Revenue` SET `Month` = ?, `Quarter` = ?, `Year` = ?, `Revenue` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Month` IS NULL) OR (`Month` = ?)) AND ((? = 1 AND `Quarter` IS NULL) OR (`Quarter` = ?)) AND ((? = 1 AND `Year` IS NULL) OR (`Year` = ?)) AND ((? = 1 AND `Revenue` IS NULL) OR (`Revenue` = ?)))"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Revenue", Global.System.Data.OleDb.OleDbType.Currency, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ID", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "ID", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Month", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Month", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Revenue", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Revenue", Global.System.Data.OleDb.OleDbType.Currency, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Revenue", Global.System.Data.DataRowVersion.Original, False, Nothing))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(3) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT ID, [Month], Quarter, [Year], Revenue FROM Revenue"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
            Me._commandCollection(1) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(1).Connection = Me.Connection
            Me._commandCollection(1).CommandText = "SELECT Sum(Revenue) as Revenue, Month FROM Revenue WHERE Year=? AND Quarter = ? G" + "ROUP BY Month"
            Me._commandCollection(1).CommandType = Global.System.Data.CommandType.Text
            Me._commandCollection(1).Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._commandCollection(1).Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Quarter", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Quarter", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._commandCollection(2) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(2).Connection = Me.Connection
            Me._commandCollection(2).CommandText = "SELECT Sum(Revenue) as Revenue, Quarter FROM Revenue WHERE Year=? GROUP BY Quarte" + "r"
            Me._commandCollection(2).CommandType = Global.System.Data.CommandType.Text
            Me._commandCollection(2).Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Year", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Year", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._commandCollection(3) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(3).Connection = Me.Connection
            Me._commandCollection(3).CommandText = "SELECT Sum(Revenue) as Revenue, Year FROM Revenue GROUP BY Year"
            Me._commandCollection(3).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.RevenueDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.RevenueDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.RevenueDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, False)> _
        Public Overridable Function FillByMonth(dataTable As ChartDataSet.RevenueDataTable, Year As Global.System.Nullable(Of Integer), Quarter As Global.System.Nullable(Of Integer)) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(1)
            If (Year.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(0).Value = CInt(Year.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (Quarter.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(1).Value = CInt(Quarter.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], False)> _
        Public Overridable Function GetMonthlyRevenue(Year As Global.System.Nullable(Of Integer), Quarter As Global.System.Nullable(Of Integer)) As ChartDataSet.RevenueDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(1)
            If (Year.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(0).Value = CInt(Year.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (Quarter.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(1).Value = CInt(Quarter.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Dim dataTable As New ChartDataSet.RevenueDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, False)> _
        Public Overridable Function FillByQuarter(dataTable As ChartDataSet.RevenueDataTable, Year As Global.System.Nullable(Of Integer)) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(2)
            If (Year.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(0).Value = CInt(Year.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], False)> _
        Public Overridable Function GetQuarterlyRevenue(Year As Global.System.Nullable(Of Integer)) As ChartDataSet.RevenueDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(2)
            If (Year.HasValue = True) Then
                Me.Adapter.SelectCommand.Parameters(0).Value = CInt(Year.Value)
            Else
                Me.Adapter.SelectCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            Dim dataTable As New ChartDataSet.RevenueDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, False)> _
        Public Overridable Function FillByYear(dataTable As ChartDataSet.RevenueDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(3)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], False)> _
        Public Overridable Function GetRevenueData() As ChartDataSet.RevenueDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(3)
            Dim dataTable As New ChartDataSet.RevenueDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataTable As ChartDataSet.RevenueDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataSet As ChartDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Revenue")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRow As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRows As Global.System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Overridable Function Delete(Original_ID As Integer, Original_Month As Global.System.Nullable(Of Integer), Original_Quarter As Global.System.Nullable(Of Integer), Original_Year As Global.System.Nullable(Of Integer), Original_Revenue As Global.System.Nullable(Of Decimal)) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CInt(Original_ID)
            If (Original_Month.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = CInt(Original_Month.Value)
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (Original_Quarter.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(3).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = CInt(Original_Quarter.Value)
            Else
                Me.Adapter.DeleteCommand.Parameters(3).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
            End If
            If (Original_Year.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(5).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = CInt(Original_Year.Value)
            Else
                Me.Adapter.DeleteCommand.Parameters(5).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = Global.System.DBNull.Value
            End If
            If (Original_Revenue.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(7).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(8).Value = CDec(Original_Revenue.Value)
            Else
                Me.Adapter.DeleteCommand.Parameters(7).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(8).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Function Insert(Month As Global.System.Nullable(Of Integer), Quarter As Global.System.Nullable(Of Integer), Year As Global.System.Nullable(Of Integer), Revenue As Global.System.Nullable(Of Decimal)) As Integer
            If (Month.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CInt(Month.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (Quarter.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CInt(Quarter.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (Year.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = CInt(Year.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (Revenue.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CDec(Revenue.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Overridable Function Update(Month As Global.System.Nullable(Of Integer), Quarter As Global.System.Nullable(Of Integer), Year As Global.System.Nullable(Of Integer), Revenue As Global.System.Nullable(Of Decimal), Original_ID As Integer, Original_Month As Global.System.Nullable(Of Integer), _
   Original_Quarter As Global.System.Nullable(Of Integer), Original_Year As Global.System.Nullable(Of Integer), Original_Revenue As Global.System.Nullable(Of Decimal)) As Integer
            If (Month.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = CInt(Month.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (Quarter.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(1).Value = CInt(Quarter.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (Year.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(2).Value = CInt(Year.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (Revenue.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(3).Value = CDec(Revenue.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(4).Value = CInt(Original_ID)
            If (Original_Month.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(5).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(6).Value = CInt(Original_Month.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(5).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(6).Value = Global.System.DBNull.Value
            End If
            If (Original_Quarter.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(7).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(8).Value = CInt(Original_Quarter.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(7).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(8).Value = Global.System.DBNull.Value
            End If
            If (Original_Year.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(9).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(10).Value = CInt(Original_Year.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(9).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(10).Value = Global.System.DBNull.Value
            End If
            If (Original_Revenue.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(11).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(12).Value = CDec(Original_Revenue.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(11).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(12).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class SubcategoryTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Subcategory"
            tableMapping.ColumnMappings.Add("Id", "Id")
            tableMapping.ColumnMappings.Add("Name", "Name")
            tableMapping.ColumnMappings.Add("Category_id", "Category_id")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Subcategory` WHERE ((`Id` = ?) AND ((? = 1 AND `Name` IS NULL) OR (`" + "Name` = ?)) AND ((? = 1 AND `Category_id` IS NULL) OR (`Category_id` = ?)))"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Id", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Name", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.InsertCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO `Subcategory` (`Name`, `Category_id`) VALUES (?, ?)"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE `Subcategory` SET `Name` = ?, `Category_id` = ? WHERE ((`Id` = ?) AND ((? " + "= 1 AND `Name` IS NULL) OR (`Name` = ?)) AND ((? = 1 AND `Category_id` IS NULL) " + "OR (`Category_id` = ?)))"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Current, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Id", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Name", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Name", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Name", Global.System.Data.DataRowVersion.Original, False, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Original, True, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_Category_id", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CByte(0), CByte(0), _
             "Category_id", Global.System.Data.DataRowVersion.Original, False, Nothing))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT Id, Name, Category_id FROM Subcategory"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.SubcategoryDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.SubcategoryDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.SubcategoryDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataTable As ChartDataSet.SubcategoryDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataSet As ChartDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Subcategory")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRow As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        Public Overridable Function Update(dataRows As Global.System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, True)> _
        Public Overridable Function Delete(Original_Id As Integer, Original_Name As String, Original_Category_id As Global.System.Nullable(Of Integer)) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CInt(Original_Id)
            If (Original_Name Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = DirectCast(Original_Name, String)
            End If
            If (Original_Category_id.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(3).Value = DirectCast(0, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = CInt(Original_Category_id.Value)
            Else
                Me.Adapter.DeleteCommand.Parameters(3).Value = DirectCast(1, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Function Insert(Name As String, Category_id As Global.System.Nullable(Of Integer)) As Integer
            If (Name Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = DirectCast(Name, String)
            End If
            If (Category_id.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CInt(Category_id.Value)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Overridable Function Update(Name As String, Category_id As Global.System.Nullable(Of Integer), Original_Id As Integer, Original_Name As String, Original_Category_id As Global.System.Nullable(Of Integer)) As Integer
            If (Name Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = DirectCast(Name, String)
            End If
            If (Category_id.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(1).Value = CInt(Category_id.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(2).Value = CInt(Original_Id)
            If (Original_Name Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(3).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(3).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(4).Value = DirectCast(Original_Name, String)
            End If
            If (Original_Category_id.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(5).Value = DirectCast(0, Object)
                Me.Adapter.UpdateCommand.Parameters(6).Value = CInt(Original_Category_id.Value)
            Else
                Me.Adapter.UpdateCommand.Parameters(5).Value = DirectCast(1, Object)
                Me.Adapter.UpdateCommand.Parameters(6).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open) <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class GetCategoriesTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "GetCategories"
            tableMapping.ColumnMappings.Add("Id", "Id")
            tableMapping.ColumnMappings.Add("Name", "Name")
            Me._adapter.TableMappings.Add(tableMapping)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT Id, Name FROM GetCategories"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.GetCategoriesDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.GetCategoriesDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.GetCategoriesDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class GetYearsTableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "GetYears"
            tableMapping.ColumnMappings.Add("Year", "Year")
            Me._adapter.TableMappings.Add(tableMapping)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT [Year] FROM GetYears"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.GetYearsDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.GetYearsDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.GetYearsDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class Query1TableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Query1"
            tableMapping.ColumnMappings.Add("Year", "Year")
            Me._adapter.TableMappings.Add(tableMapping)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT [Year] FROM Query1"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.Query1DataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.Query1DataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.Query1DataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
    End Class

    ''' <summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")> _
    <System.ComponentModel.ToolboxItem(True)> _
    <System.ComponentModel.DataObjectAttribute(True)> _
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" + ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")> _
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
    Partial Public Class Query2TableAdapter
        Inherits Global.System.ComponentModel.Component

        Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

        Private _connection As Global.System.Data.OleDb.OleDbConnection

        Private _commandCollection As Global.System.Data.OleDb.OleDbCommand()

        Private _clearBeforeFill As Boolean

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter()
                End If
                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection()
                End If
                Return Me._connection
            End Get
            Set(value As Global.System.Data.OleDb.OleDbConnection)
                Me._connection = value
                If (Me.Adapter.InsertCommand IsNot Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Me.Adapter.DeleteCommand IsNot Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Me.Adapter.UpdateCommand IsNot Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        DirectCast(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Query2"
            tableMapping.ColumnMappings.Add("Year", "Year")
            Me._adapter.TableMappings.Add(tableMapping)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Settings.[Default].ChartConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT [Year] FROM Query2"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
        Public Overridable Function Fill(dataTable As ChartDataSet.Query2DataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
        <System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)> _
        Public Overridable Function GetData() As ChartDataSet.Query2DataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As New ChartDataSet.Query2DataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
    End Class
End Namespace



'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
