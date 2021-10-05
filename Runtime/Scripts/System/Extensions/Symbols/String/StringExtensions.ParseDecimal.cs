namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static decimal ParseDecimal(this string text)
		{
			return decimal.Parse(text);
		}

		public static decimal ParseDecimal(this string text, NumberStyles style)
		{
			return decimal.Parse(text, style);
		}

		public static decimal ParseDecimal(this string text, IFormatProvider provider)
		{
			return decimal.Parse(text, provider);
		}

		public static decimal ParseDecimal(this string text, NumberStyles style, IFormatProvider provider)
		{
			return decimal.Parse(text, style, provider);
		}
	}
}