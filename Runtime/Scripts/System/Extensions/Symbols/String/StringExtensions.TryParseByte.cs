namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseByte(this string text, out byte result)
		{
			return byte.TryParse(text, out result);
		}

		public static bool TryParseByte(this string text, NumberStyles style, IFormatProvider provider, out byte result)
		{
			return byte.TryParse(text, style, provider, out result);
		}
	}
}