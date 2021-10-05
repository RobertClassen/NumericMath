namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseDouble(this string text, out double result)
		{
			return double.TryParse(text, out result);
		}

		public static bool TryParseDouble(this string text, NumberStyles style, IFormatProvider provider, out double result)
		{
			return double.TryParse(text, style, provider, out result);
		}
	}
}