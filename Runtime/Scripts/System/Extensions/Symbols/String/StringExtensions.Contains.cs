namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class StringExtensions
	{
		public static bool Contains(this string text, char value)
		{
			return text.IndexOf(value) >= Int.Zero;
		}
	}
}