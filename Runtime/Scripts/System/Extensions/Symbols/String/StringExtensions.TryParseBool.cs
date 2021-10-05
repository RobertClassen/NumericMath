namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class StringExtensions
	{
		public static bool TryParseBool(this string text, out bool result)
		{
			return bool.TryParse(text, out result);
		}
	}
}