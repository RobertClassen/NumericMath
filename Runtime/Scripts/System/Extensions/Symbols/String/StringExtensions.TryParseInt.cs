namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseInt(this string text, out int result)
		{
			return int.TryParse(text, out result);
		}

		public static bool TryParseInt(this string text, NumberStyles style, IFormatProvider provider, out int result)
		{
			return int.TryParse(text, style, provider, out result);
		}
	}
}