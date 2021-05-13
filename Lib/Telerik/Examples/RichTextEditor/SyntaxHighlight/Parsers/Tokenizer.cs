using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;

namespace RichTextEditor.Parsers
{
	internal class Tokenizer
	{
		private static Regex codeSyntax;
		private List<Token> tokens = new List<Token>();
		private SyntaxPicker picker = new SyntaxPicker();
		private Collection<LanguageSyntaxStructure> languageStructure;

		public enum ParserType
		{
			/// <summary>
			/// 
			/// </summary>
			CSharp,

			/// <summary>
			/// 
			/// </summary>
			VisualBasic,

			/// <summary>
			/// 
			/// </summary>
			XAML
		}

		public List<Token> TokenizeCode(string code, string extension)
		{
			this.tokens.Clear();

			SyntaxParser syntaxPicker = this.picker.FindParserByExtension(extension);
			if (syntaxPicker == null)
			{
				throw new ArgumentException("No Syntax Parser found that can parse this file!", "extension");
			}

			this.languageStructure = syntaxPicker.GenerateLanguageSyntaxPatterns();

			codeSyntax = new Regex(this.GenerateLanguageSyntaxRegularExpression(),
                RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

			MatchCollection matches = codeSyntax.Matches(code);

		    if (matches.Count != 0)
		    {
			    for (int i = 0; i < matches.Count; i++)
			    {
				    Token t = this.Tokenize(matches[i]);
				    this.tokens.Add(t);
			    }
		    }

			return this.tokens;
		}

		private string GenerateLanguageSyntaxRegularExpression()
		{
			StringBuilder regEx = new StringBuilder();
			regEx.Append(@"\s*");
            if (this.languageStructure.Count > 0)
            {
                for (int i = 0; i < this.languageStructure.Count - 1; i++)
                {
                    regEx.AppendFormat("{0}|", this.languageStructure[i].RegexString);
                }
                regEx.AppendFormat("{0}", this.languageStructure[this.languageStructure.Count - 1].RegexString);
            }
			regEx.Append(@"\s*");
			return regEx.ToString();
		}

		private Token Tokenize(Match match)
		{
			for (int i = 0; i < this.languageStructure.Count; i++)
			{
				if (match.Groups[this.languageStructure[i].Description].Success)
				{
					return new Token(match.Groups[this.languageStructure[i].Description].Value, this.languageStructure[i].Color);
				}
			}
			return new Token(null, null);
		}
	}
}
