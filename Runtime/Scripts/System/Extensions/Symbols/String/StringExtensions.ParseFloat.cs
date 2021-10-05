namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static float ParseFloat(this string text)
		{
			return float.Parse(text);
		}

		public static float ParseFloat(this string text, NumberStyles style)
		{
			return float.Parse(text, style);
		}

		public static float ParseFloat(this string text, IFormatProvider provider)
		{
			return float.Parse(text, provider);
		}

		public static float ParseFloat(this string text, NumberStyles style, IFormatProvider provider)
		{
			return float.Parse(text, style, provider);
		}
	}
}