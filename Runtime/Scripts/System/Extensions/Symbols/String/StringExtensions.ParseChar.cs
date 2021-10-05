namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static char ParseChar(this string text)
		{
			return char.Parse(text);
		}
	}
}