using System;
using System.Collections.ObjectModel;

namespace RichTextEditor.Parsers
{
	internal class SyntaxParser : IDisposable
	{
		private string defaultExtension = ".default";

		private Collection<LanguageSyntaxStructure> languageSyntaxList = new Collection<LanguageSyntaxStructure>();

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public SyntaxParser()
		{
			this.SetFileExtension(this.defaultExtension);
		}

		public string GetExtension
		{
			get
			{
				return this.defaultExtension;
			}
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public Collection<LanguageSyntaxStructure> GenerateLanguageSyntaxPatterns()
		{
			return this.LoadLanguageSyntax(this.languageSyntaxList);
		}

		protected virtual void SetFileExtension(string extension)
		{
			if (!extension.StartsWith(".", StringComparison.OrdinalIgnoreCase))
				throw new ArgumentException("File Extension must start with a '.'!", "extension");
			this.defaultExtension = extension;
		}

		protected virtual Collection<LanguageSyntaxStructure> LoadLanguageSyntax(Collection<LanguageSyntaxStructure> languageSyntax)
		{
			return languageSyntax;
		}
	}
}
