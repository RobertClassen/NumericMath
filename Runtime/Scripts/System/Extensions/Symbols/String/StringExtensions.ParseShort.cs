namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static short ParseShort(this string text)
		{
			return short.Parse(text);
		}

		public static short ParseShort(this string text, NumberStyles style)
		{
			return short.Parse(text, style);
		}

		public static short ParseShort(this string text, IFormatProvider provider)
		{
			return short.Parse(text, provider);
		}

		public static short ParseShort(this string text, NumberStyles style, IFormatProvider provider)
		{
			return short.Parse(text, style, provider);
		}
	}
}