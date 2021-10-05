namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseShort(this string text, out short result)
		{
			return short.TryParse(text, out result);
		}

		public static bool TryParseShort(this string text, NumberStyles style, IFormatProvider provider, out short result)
		{
			return short.TryParse(text, style, provider, out result);
		}
	}
}