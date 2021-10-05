namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseDecimal(this string text, out decimal result)
		{
			return decimal.TryParse(text, out result);
		}

		public static bool TryParseDecimal(this string text, NumberStyles style, IFormatProvider provider, out decimal result)
		{
			return decimal.TryParse(text, style, provider, out result);
		}
	}
}