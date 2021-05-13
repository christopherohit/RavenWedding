using System;
using System.Drawing;
using System.IO;
using System.Text;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinForms.Controls.SyntaxEditor.UI;
using Telerik.WinForms.SyntaxEditor.Core.Tagging;
using Telerik.WinForms.SyntaxEditor.Core.Text;

namespace Telerik.Examples.WinControls.SyntaxEditor.CustomLanguage
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            string file = this.GetType().Namespace + ".script.py";
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(file))
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                this.syntaxEditor.Document = new TextDocument(reader);
            }

            PythonTagger pythonTagger = new PythonTagger(this.syntaxEditor.SyntaxEditorElement);
            if (!this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(pythonTagger))
            {
                this.syntaxEditor.TaggersRegistry.RegisterTagger(pythonTagger);
            }

            this.syntaxEditor.TextFormatDefinitions.AddLast(ClassificationTypes.NumberLiteral, new TextFormatDefinition(new SolidBrush(Color.Red)));
            this.syntaxEditor.TextFormatDefinitions.AddLast(ClassificationTypes.Operator, new TextFormatDefinition(new SolidBrush(Color.YellowGreen)));
            this.syntaxEditor.TextFormatDefinitions.AddLast(PythonTagger.FruitsClassificationType, new TextFormatDefinition(new SolidBrush(Color.LightCoral)));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.syntaxEditor.Focus();
        }
    }
}
