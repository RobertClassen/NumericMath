namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseChar(this string text, out char result)
		{
			return char.TryParse(text, out result);
		}
	}
}