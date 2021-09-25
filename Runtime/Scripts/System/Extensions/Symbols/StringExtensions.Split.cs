namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class StringExtensions
	{
		public static string[] Split(this string text, char separator)
		{
			return text.Split(new[]{ separator }, StringSplitOptions.RemoveEmptyEntries);
		}
	}
}