namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class StringExtensions
	{
		public static int Count(this string text, char character)
		{
			int count = 0;
			foreach(char c in text)
			{
				if(c == character)
				{
					count++;
				}
			}
			return count;
		}
	}
}