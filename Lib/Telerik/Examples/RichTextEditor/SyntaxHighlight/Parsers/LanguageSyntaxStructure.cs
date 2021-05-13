using System;
using System.Drawing;

namespace RichTextEditor.Parsers
{
	internal class LanguageSyntaxStructure
	{
		private string regexString = null;
		private Brush segmentColor = null;
		private string description;

		public LanguageSyntaxStructure(string regularExpression, string description, Brush color)
		{
			this.regexString = regularExpression;
			this.segmentColor = color;
			this.description = description;
		}

		public string RegexString
		{
			get
			{
				return this.regexString;
			}
		}

		public string Description
		{
			get
			{
				return this.description;
			}
		}

		public Brush Color
		{
			get
			{
				return this.segmentColor;
			}
		}
	}
}
