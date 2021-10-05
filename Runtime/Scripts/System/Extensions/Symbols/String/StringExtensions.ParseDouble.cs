namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static double ParseDouble(this string text)
		{
			return double.Parse(text);
		}

		public static double ParseDouble(this string text, NumberStyles style)
		{
			return double.Parse(text, style);
		}

		public static double ParseDouble(this string text, IFormatProvider provider)
		{
			return double.Parse(text, provider);
		}

		public static double ParseDouble(this string text, NumberStyles style, IFormatProvider provider)
		{
			return double.Parse(text, style, provider);
		}
	}
}