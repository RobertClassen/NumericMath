namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseLong(this string text, out long result)
		{
			return long.TryParse(text, out result);
		}

		public static bool TryParseLong(this string text, NumberStyles style, IFormatProvider provider, out long result)
		{
			return long.TryParse(text, style, provider, out result);
		}
	}
}