Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.ObjectRelational
    ''' <summary>
    ''' Form code
    ''' </summary>
    Partial Public Class Form1
        Inherits TreeExamplesControl
        Private bottomRightBitmap As Bitmap = My.Resources.TV_music

        Public Sub New()
            InitializeComponent()
            Me.SelectedControl = Me.radTreeView1
        End Sub

        Public Overrides ReadOnly Property TreeControl() As RadTreeView
            Get
                Return Me.radTreeView1
            End Get
        End Property

        Public Overrides ReadOnly Property BottomRightImage() As Bitmap
            Get
                Return bottomRightBitmap
            End Get
        End Property

        Public Overrides ReadOnly Property HeaderText() As String
            Get
                Return "Music Collection"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.radTreeView1.AllowDragDrop = True
            Me.radTreeView1.ChildMember = "Artist1\Albums1\Tracks1"
            Me.radTreeView1.DisplayMember = "Name1\Title1\Name1"
            Me.radTreeView1.DataSource = Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational.DataContext.TopArtists1
            Me.radTreeView1.AllowEdit = False


            '''--------------------------------------------------------------------------------------------------------------
            '''
            'auto generate Object-Relational Hierarchy using Entity Framework 
            'currently can not be run in our Demo Application - we have dependency to .NET Framework 2.0
            'will be available for next 4.0 version of Demo application and Code Library project: http://www.telerik.com/community/code-library/winforms.aspx

            'AWModel.AdventureWorksLT2008Entities entities = new AWModel.AdventureWorksLT2008Entities();
            'var query = from productCategory in entities.ProductCategory select productCategory;
            'this.radTreeView1.DataSource = query.ToList();
            'this.radTreeView1.ValueMember = @"ProductCategory\Products";
            'this.radTreeView1.DisplayMember = @"CategoryName\ProductName";

            '''--------------------------------------------------------------------------------------------------------------


            '''--------------------------------------------------------------------------------------------------------------
            '''
            'auto generate Object-Relational Hierarchy using our OpenAccess ORM Framework
            'you can found example in our Code Library project: http://www.telerik.com/community/code-library/winforms.aspx

            'using (AdventureWorksLT2008 context = new AdventureWorksLT2008())
            '{
            '    List<ProductCategory> list = context.ProductCategories.ToList();
            '    this.radTreeView1.DataSource = list;
            '    this.radTreeView1.ValueMember = @"ProductCategory\Products";
            '    this.radTreeView1.DisplayMember = @"CategoryName\ProductName";
            '}

            '''--------------------------------------------------------------------------------------------------------------
        End Sub

        Private Sub radTreeView1_NodeExpandedChanging(ByVal sender As Object, ByVal e As RadTreeViewCancelEventArgs) Handles radTreeView1.NodeExpandedChanging
            Dim nodes As RadTreeNodeCollection = e.Node.Nodes
            For Each node As RadTreeNode In nodes
                node.ImageIndex = node.Level
            Next node
        End Sub
    End Class
End Namespace

