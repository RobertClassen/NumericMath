namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static byte ParseByte(this string text)
		{
			return byte.Parse(text);
		}

		public static byte ParseByte(this string text, NumberStyles style)
		{
			return byte.Parse(text, style);
		}

		public static byte ParseByte(this string text, IFormatProvider provider)
		{
			return byte.Parse(text, provider);
		}

		public static byte ParseByte(this string text, NumberStyles style, IFormatProvider provider)
		{
			return byte.Parse(text, style, provider);
		}
	}
}