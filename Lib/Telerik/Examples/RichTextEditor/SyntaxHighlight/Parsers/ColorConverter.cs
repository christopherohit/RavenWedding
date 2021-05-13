
using System.Drawing;
namespace RichTextEditor.Parsers
{
	internal static class ColorConverter
	{
		public static Color ConvertFromString(string argb)
		{
			uint result;
			if (uint.TryParse(argb.TrimStart('#', '0'), System.Globalization.NumberStyles.HexNumber, null, out result))
			{
				uint a = 0xFF;
                uint r = (result >> 16) & 0xFF;
                uint g = (result >> 8) & 0xFF;
                uint b = result & 0xFF;

				return Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
			}
			return Color.Black;
		}
	}
}