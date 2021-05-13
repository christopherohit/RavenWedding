using System.Collections.Generic;
using Telerik.WinControls.UI;
using Telerik.WinForms.Controls.SyntaxEditor.Taggers;
using Telerik.WinForms.SyntaxEditor.Core.Tagging;

namespace Telerik.Examples.WinControls.SyntaxEditor.CustomLanguage
{
    public class PythonTagger : WordTaggerBase
    {
        private static readonly string[] Keywords = new string[]
        {
            "False", "None", "True", "and", "as", "assert","break", "class",
            "continue", "def", "del", "elif", "else", "except", "for", "from",
            "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "print",
            "or", "pass", "raise", "finally", "return", "try", "while", "with", "yield"
        };

        private static readonly string[] Comments = new string[]
        {
            "#",
        };

        private static readonly string[] Operators = new string[]
        {
            "+", "-",  "", "/"
        };

        public static readonly ClassificationType FruitsClassificationType = new ClassificationType("Fruits");

        private static readonly string[] Fruits = new string[]
        {
            "apple", "banana",  "cherry"
        };

        private static readonly Dictionary<string, ClassificationType> WordsToClassificationType = new Dictionary<string, ClassificationType>();

        static PythonTagger()
        {
            WordsToClassificationType = new Dictionary<string, ClassificationType>();

            foreach (string keyword in Keywords)
            {
                WordsToClassificationType.Add(keyword, ClassificationTypes.Keyword);
            }

            foreach (string preprocessor in Operators)
            {
                WordsToClassificationType.Add(preprocessor, ClassificationTypes.Operator);
            }

            foreach (string comment in Comments)
            {
                WordsToClassificationType.Add(comment, ClassificationTypes.Comment);
            }

            foreach (string comment in Fruits)
            {
                WordsToClassificationType.Add(comment, FruitsClassificationType);
            }
        }

        public PythonTagger(RadSyntaxEditorElement editor)
          : base(editor)
        {
        }

        protected override Dictionary<string, ClassificationType> GetWordsToClassificationTypes()
        {
            return PythonTagger.WordsToClassificationType;
        }

        protected override bool TryGetClassificationType(string word, out ClassificationType classificationType)
        {
            int number;
            if (int.TryParse(word, out number))
            {
                classificationType = ClassificationTypes.NumberLiteral;
                return true;
            }

            return base.TryGetClassificationType(word, out classificationType);
        }
    }
}
