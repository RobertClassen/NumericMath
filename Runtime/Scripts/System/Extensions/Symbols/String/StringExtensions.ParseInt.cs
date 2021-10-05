namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static int ParseInt(this string text)
		{
			return int.Parse(text);
		}

		public static int ParseInt(this string text, NumberStyles style)
		{
			return int.Parse(text, style);
		}

		public static int ParseInt(this string text, IFormatProvider provider)
		{
			return int.Parse(text, provider);
		}

		public static int ParseInt(this string text, NumberStyles style, IFormatProvider provider)
		{
			return int.Parse(text, style, provider);
		}
	}
}