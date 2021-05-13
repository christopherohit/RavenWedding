using System.Drawing;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.Parsers
{
	internal class Token
	{
		public Token(string value, Brush color)
			: this(value, color, false, false)
		{
		}

		public Token(string value, Brush color, bool isBold, bool isItalic)
		{
			this.Value = value;
			this.Color = color;
			this.IsBold = isBold;
			this.IsItalic = isItalic;
		}

		public enum TokenType
		{
			/// <summary>
			/// 
			/// </summary>
			KeyWord,

			/// <summary>
			/// 
			/// </summary>
			Comment,

			/// <summary>
			/// 
			/// </summary>
			String,

			/// <summary>
			/// 
			/// </summary>
			Identifier,

			/// <summary>
			/// 
			/// </summary>
			Other, 

			/// <summary>
			/// 
			/// </summary>
			None
		}

        string _Value;
		public string Value
		{
			get
            {
                return _Value;
            }
			private set
            {
                _Value = value;
            }
		}

        Brush _Color;
		public Brush Color
		{
			get
            {
                return _Color;
            }
			private set
            {
                _Color = value;
            }
		}

        bool _IsBold;
		public bool IsBold 
        { 
            get
            {
                return _IsBold;
            }
            private set
            {
                _IsBold = value;
            }
        }

        bool _IsItalic;
		public bool IsItalic 
        { 
            get
            {
                return _IsItalic;
            }
            private set
            {
                _IsItalic = value;
            }
        }

		public Run GetRun()
		{
			return new Run()
			{
				Text = this.Value,
                Foreground = (SolidBrush)this.Color,
				FontWeight = this.IsBold ? FontWeights.ExtraBlack : FontWeights.Normal,
				FontStyle = this.IsItalic ? FontStyles.Italic : FontStyles.Normal
			};
		}


        public Span GetSpan()
        {
            return new Span()
            {
                Text = this.Value,
                ForeColor = ((SolidBrush)this.Color).Color,
                FontWeight = this.IsBold ? FontWeights.ExtraBlack : FontWeights.Normal,
                FontStyle = this.IsItalic ? FontStyles.Italic : FontStyles.Normal
            };
        }

        public Span GetSpanStyle()
        {
            return new Span()
            {
                ForeColor = ((SolidBrush)this.Color).Color,
                FontWeight = this.IsBold ? FontWeights.ExtraBlack : FontWeights.Normal,
                FontStyle = this.IsItalic ? FontStyles.Italic : FontStyles.Normal
            };
        }

	}
}
