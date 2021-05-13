using System.Collections.Generic;

namespace RichTextEditor.Parsers
{
	internal class SyntaxPicker
	{
		private List<SyntaxParser> parsers = new List<SyntaxParser>();

		internal SyntaxPicker()
		{
			this.AddParser(new CSharpSyntaxParser());
			this.AddParser(new XamlSyntaxParser());
		}

		internal void AddParser(SyntaxParser parser)
		{
			this.parsers.Add(parser);
		}

		internal SyntaxParser FindParserByExtension(string extension)
		{
			foreach (SyntaxParser parser in this.parsers)
			{
				if (parser.GetExtension == extension)
					return parser;
			}
			return null;
		}
	}
}
