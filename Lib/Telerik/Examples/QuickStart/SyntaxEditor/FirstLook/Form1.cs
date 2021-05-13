using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Controls.SyntaxEditor.Palettes;
using Telerik.WinForms.Controls.SyntaxEditor.Taggers;
using Telerik.WinForms.SyntaxEditor.Core.Tagging;
using Telerik.WinForms.SyntaxEditor.Core.Text;

namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        #region Fields

        private FoldingTaggerBase foldingTagger;
        private TextSearchHighlightTagger selectionWordTagger;
        private TaggerBase<ClassificationTag> currentLanguageTagger;
        private RadOpenFolderDialog openFolderDialog;
        private List<string> supportedFileExtensions = new List<string>() { ".cs", ".vb", ".js", ".xaml", ".xml", "html", ".sql", ".csproj", ".user", ".cpp", ".txt", ".config", ".resx", ".settings", ".sln", ".licx" };
        private bool usingFileSystem = false;

        #endregion

        public Form1()
        {
            this.InitializeComponent();
            this.CenterPanel = true;

            this.radButton1.ButtonElement.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.documentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.TabbedDocument;

            this.openFolderDialog = new RadOpenFolderDialog();
            this.openFolderDialog.ShowNetworkLocations = false;
            openFolderDialog.OpenFolderDialogForm.Text = "Open Directory";

            ExampleHelper.PopulateTreeView(this.treeView);

            this.foldingTagger = new CSharpFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
            this.selectionWordTagger = new TextSearchHighlightTagger(this.syntaxEditor.SyntaxEditorElement, TextSearchHighlightTagger.SearchFormatDefinition);
            this.syntaxEditor.TaggersRegistry.RegisterTagger(foldingTagger);
            this.syntaxEditor.TaggersRegistry.RegisterTagger(this.selectionWordTagger);

            this.syntaxEditor.SyntaxEditorElement.Selection.SelectionChanged += Selection_SelectionChanged;
            this.treeView.SelectedNodeChanged += this.TreeView_SelectionChanged;
        }

        #region Methods

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (TelerikHelper.IsDarkTheme(this.CurrentThemeName))
            {
                this.syntaxEditor.Palette = SyntaxPalettes.NeutralDark;
            }
            else
            {
                this.syntaxEditor.Palette = SyntaxPalettes.Light;
            }

            if (!this.usingFileSystem)
            {
                this.treeView.ExpandAll();
            }

            if (this.openFolderDialog != null)
            {
                this.openFolderDialog.OpenFolderDialogForm.ThemeName = this.CurrentThemeName;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.treeView.ExpandAll();
            this.treeView.SelectedNode = this.treeView.Nodes[0].Nodes[0];
            this.openFolderDialog.OpenFolderDialogForm.ThemeName = this.CurrentThemeName;
        }

        private void RegisterTagger(string fileName)
        {
            this.UnregisterTaggers();
            string extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".cs":
                    this.currentLanguageTagger = new CSharpTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.ClearXmlFormatDefinitions();
                    this.foldingTagger = new CSharpFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
                    break;
                case ".cpp":
                    this.currentLanguageTagger = new CSharpTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.ClearXmlFormatDefinitions();
                    this.foldingTagger = new BracketFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
                    break;
                case ".vb":
                    this.currentLanguageTagger = new VisualBasicTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.ClearXmlFormatDefinitions();
                    this.foldingTagger = new VisualBasicFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
                    break;
                case ".js":
                    this.currentLanguageTagger = new JavaScriptTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.ClearXmlFormatDefinitions();
                    this.foldingTagger = new JavaScriptFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
                    break;
                case ".sql":
                    this.currentLanguageTagger = new SqlTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.ClearXmlFormatDefinitions();
                    if (this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(this.foldingTagger))
                    {
                        this.syntaxEditor.TaggersRegistry.UnregisterTagger(this.foldingTagger);
                    }
                    break;
                case ".xaml":
                case ".xml":
                case ".licx":
                case ".html":
                case ".csproj":
                case ".vbproj":
                case ".user":
                case ".config":
                case ".resx":
                case ".settings":
                case ".sln":
                    this.currentLanguageTagger = new XmlTagger(this.syntaxEditor.SyntaxEditorElement);
                    this.AddXmlFormatDefinitions();
                    this.foldingTagger = new XmlFoldingTagger(this.syntaxEditor.SyntaxEditorElement);
                    break;
                default:
                    this.ClearXmlFormatDefinitions();
                    this.currentLanguageTagger = null;
                    if (this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(this.foldingTagger))
                    {
                        this.syntaxEditor.TaggersRegistry.UnregisterTagger(this.foldingTagger);
                    }
                    break;
            }

            if (this.currentLanguageTagger != null)
            {
                this.syntaxEditor.TaggersRegistry.RegisterTagger(this.currentLanguageTagger);
            }

            if (this.foldingTagger != null)
            {
                this.syntaxEditor.TaggersRegistry.RegisterTagger(this.foldingTagger);
            }
        }

        private void UnregisterTaggers()
        {
            if (this.currentLanguageTagger != null && this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(this.currentLanguageTagger))
            {
                this.syntaxEditor.TaggersRegistry.UnregisterTagger(this.currentLanguageTagger);
            }

            if (this.foldingTagger != null && this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(this.foldingTagger))
            {
                this.syntaxEditor.TaggersRegistry.UnregisterTagger(this.foldingTagger);
                this.foldingTagger = null;
            }
        }

        private void AddXmlFormatDefinitions()
        {
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlAttribute, XmlSyntaxHighlightingHelper.XmlAttributeFormatDefinition);
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlElement, XmlSyntaxHighlightingHelper.XmlElementFormatDefinition);
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlComment, XmlSyntaxHighlightingHelper.XmlCommentFormatDefinition);
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlContent, XmlSyntaxHighlightingHelper.XmlContentFormatDefinition);
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlString, XmlSyntaxHighlightingHelper.XmlStringFormatDefinition);
            this.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlTag, XmlSyntaxHighlightingHelper.XmlTagFormatDefinition);
        }

        private void ClearXmlFormatDefinitions()
        {
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlAttribute);
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlElement);
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlComment);
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlContent);
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlString);
            this.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlTag);
        }

        private ObservableCollection<FileInfo> treeItems;

        private void LoadDirectory(string directoryPath)
        {
            this.treeView.Nodes.Clear();
            this.treeView.DataSource = null;
            this.usingFileSystem = true;
            this.treeView.LazyMode = false;

            DirectoryInfo directory = new DirectoryInfo(directoryPath, Path.GetDirectoryName(directoryPath));
            directory.LoadChildren();
            this.treeItems = directory.Children;

            this.treeView.NodesNeeded -= this.TreeView_NodesNeeded;
            this.treeView.NodesNeeded += this.TreeView_NodesNeeded;
        }

        private void TreeView_NodesNeeded(object sender, NodesNeededEventArgs e)
        {
            if (e.Parent == null)
            {
                foreach (FileInfo item in this.treeItems)
                {
                    RadTreeNode mcNode = new RadTreeNode(item.Name) { Tag = item };
                    e.Nodes.Add(mcNode);
                }

                return;
            }

            if (e.Parent != null)
            {
                DirectoryInfo parent = e.Parent.Tag as DirectoryInfo;
                if (parent != null)
                {
                    parent.LoadChildren();
                    foreach (FileInfo item in parent.Children)
                    {
                        RadTreeNode mcNode = new RadTreeNode(item.Name) { Tag = item };
                        e.Nodes.Add(mcNode);
                    }
                }
            }
        }

        private void LoadFile(string fileName)
        {
            if (usingFileSystem)
            {
                try
                {
                    using (FileStream stream = new FileStream(fileName, FileMode.Open))
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        this.syntaxEditor.Document = new TextDocument(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                using (Stream stream = GetResourceStream(fileName))
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    this.syntaxEditor.Document = new TextDocument(reader);
                }
            }

            this.RegisterTagger(fileName);
        }

        protected static Stream GetResourceStream(string resourcePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());

            resourcePath = resourceNames.FirstOrDefault(r => r.EndsWith(resourcePath));

            if (resourcePath == null)
            {
                throw new FileNotFoundException("Resource not found");
            }

            return assembly.GetManifestResourceStream(resourcePath);
        }

        private void TreeView_SelectionChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            FileInfo file = null;
            if (!this.usingFileSystem)
            {
                file = e.Node.DataBoundItem as FileInfo;
            }
            else
            {
                file = e.Node.Tag as FileInfo;
            }

            if (file == null)
            {
                return;
            }

            DirectoryInfo d = file as DirectoryInfo;
            if (d != null && d.Children.Count > 0)
            {
                return;
            }

            if (this.supportedFileExtensions.Contains(Path.GetExtension(file.FullPath)))
            {
                this.LoadFile(file.FullPath);
                this.documentWindow1.Text = file.Name;
                this.syntaxEditor.Visible = true;
                this.infoLabel.Visible = false;
            }
            else
            {
                this.syntaxEditor.Visible = false;
                this.infoLabel.Visible = true;
            }
        }

        private void RadButton_Click(object sender, EventArgs e)
        {
            if (this.openFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFolder = this.openFolderDialog.FileName;
                if (!string.IsNullOrEmpty(selectedFolder))
                {
                    if (this.syntaxEditor != null)
                    {
                        this.documentWindow1.Text = this.openFolderDialog.SafeFileNames.FirstOrDefault();
                        this.syntaxEditor.Document = new TextDocument();
                    }

                    this.UnregisterTaggers();
                    this.LoadDirectory(selectedFolder);
                }
            }
        }

        #endregion

        private void Selection_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.syntaxEditor.SyntaxEditorElement.Selection.IsEmpty)
            {
                string searchedWord = this.syntaxEditor.SyntaxEditorElement.Selection.GetSelectedText();
                if (!string.IsNullOrWhiteSpace(searchedWord))
                {
                    this.selectionWordTagger.UpdateSearchWord(searchedWord);
                }
            }
            else
            {
                this.selectionWordTagger.UpdateSearchWord(string.Empty);
            }
        }
    }
}