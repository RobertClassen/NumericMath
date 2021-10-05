namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static long ParseLong(this string text)
		{
			return long.Parse(text);
		}

		public static long ParseLong(this string text, NumberStyles style)
		{
			return long.Parse(text, style);
		}

		public static long ParseLong(this string text, IFormatProvider provider)
		{
			return long.Parse(text, provider);
		}

		public static long ParseLong(this string text, NumberStyles style, IFormatProvider provider)
		{
			return long.Parse(text, style, provider);
		}
	}
}