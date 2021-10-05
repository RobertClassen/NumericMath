namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseFloat(this string text, out float result)
		{
			return float.TryParse(text, out result);
		}

		public static bool TryParseFloat(this string text, NumberStyles style, IFormatProvider provider, out float result)
		{
			return float.TryParse(text, style, provider, out result);
		}
	}
}