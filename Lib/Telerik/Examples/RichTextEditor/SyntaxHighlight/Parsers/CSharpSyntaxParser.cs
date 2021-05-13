using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace RichTextEditor.Parsers
{
	internal class CSharpSyntaxParser : SyntaxParser
	{
		private string[] keywords = new string[]
		{
            "abstract",
            "as",
            "base",
            "break",
            "byte",
            "bool",
            "char",
            "catch",
            "case",
            "checked",
            "class",
            "continue",
            "const", 
            "decimal",
            "default",
            "delegate",
            "double",
            "do",
            "event",
            "explicit",
            "extern",
            "else", 
            "enum", 
            "finally",
            "false",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in", 
            "int",
            "interface",
            "is",
            "internal",
            "lock", 
            "long",
            "new",
            "namespace",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "partial",
            "return",
            "readonly",
            "ref",
            "struct",
            "switch",
            "sbyte",
            "sealed",
            "sizeof",
            "short",
            "stackalloc", 	 
            "static", 	 
            "string",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "volatile",
            "void",
            "while"
        };

		protected override Collection<LanguageSyntaxStructure> LoadLanguageSyntax(Collection<LanguageSyntaxStructure> languageSyntax)
		{
			 ////Load comments
			string comments = @"\G(?<comment>(\/\/[ \t\S]*\s*\s*)|(\/\*\s*[\s\S]*\s*\*/\s))";
			languageSyntax.Add(new LanguageSyntaxStructure(comments, "comment", new SolidBrush((Color)ColorConverter.ConvertFromString("#537D01"))));

			 ////Load Keywords
			StringBuilder kwrds = new StringBuilder();
			kwrds.Append(@"\G(?<keyword>(");
			for (int i = 0; i < this.keywords.Length; i++)
			{
				kwrds.Append(this.keywords[i] + "|");
			}
			kwrds.Append(this.keywords[this.keywords.Length - 1]);
			kwrds.Append(@")(?=(\.)|(\s+)))");
            languageSyntax.Add(new LanguageSyntaxStructure(kwrds.ToString(), "keyword", new SolidBrush((Color)ColorConverter.ConvertFromString("#0160E5"))));

			 ////Load string
			string strings = "\\G(?<string>\"\\s*((\\\\\")|[^\\\"])*\\s*\"\\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(strings, "string", new SolidBrush((Color)ColorConverter.ConvertFromString("#0160E5"))));

			////Load identifier
			string identifier = @"\G(?<identifier>[\w]+\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(identifier, "identifier", new SolidBrush((Color)ColorConverter.ConvertFromString("#000000"))));

			////Load other
			string other = @"\G(?<other>[\s\S]\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(other, "other", new SolidBrush((Color)ColorConverter.ConvertFromString("#000000"))));
			return base.LoadLanguageSyntax(languageSyntax);
		}

		protected override void SetFileExtension(string extension)
		{
			base.SetFileExtension(".cs");
		}
	}
}
