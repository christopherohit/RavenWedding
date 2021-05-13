using System.Collections.ObjectModel;
using System.Drawing;

namespace RichTextEditor.Parsers
{
	internal class XamlSyntaxParser : SyntaxParser
	{
		protected override Collection<LanguageSyntaxStructure> LoadLanguageSyntax(Collection<LanguageSyntaxStructure> languageSyntax)
		{
			////Load attributes
			string attributes = @"\G(?<attribute>[a-zA-Z][a-zA-Z0-9.:*_]*\s*(?==))";
            languageSyntax.Add(new LanguageSyntaxStructure(attributes, "attribute", new SolidBrush((Color)ColorConverter.ConvertFromString("#FF004E"))));

			////Load elements
			string elements = @"\G(?<element>(?<=(<)|(</))[a-zA-Z][a-zA-Z0-9.:*_]*\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(elements, "element", new SolidBrush((Color)ColorConverter.ConvertFromString("#000000"))));

			////Load comments
			string comments = @"\G(?<comment><!--\s*[\s\S]*\s*-->\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(comments, "comment", new SolidBrush((Color)ColorConverter.ConvertFromString("#537D01"))));

			////Load tags
			string tags = @"\G(?<tag>(</|<|/>|>)\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(tags, "tag", new SolidBrush((Color)ColorConverter.ConvertFromString("#0160E5"))));

			////Load attribute strings
			string strings = "\\G(?<string>=\\s*\"[_=#{}a-zA-Z0-9.:;\\s-/,*]*\\s*\"\\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(strings, "string", new SolidBrush((Color)ColorConverter.ConvertFromString("#0160E5"))));

			////Load content
			string content = @"\G(?<content>[^<]+\s*)";
            languageSyntax.Add(new LanguageSyntaxStructure(content, "content", new SolidBrush((Color)ColorConverter.ConvertFromString("#0160E5"))));
			return base.LoadLanguageSyntax(languageSyntax);
		}

		protected override void SetFileExtension(string extension)
		{
			base.SetFileExtension(".xaml");
		}
	}
}
