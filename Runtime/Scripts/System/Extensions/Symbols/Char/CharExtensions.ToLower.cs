namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class CharExtensions
	{
		public static char ToLower(this char c)
		{
			return char.ToLower(c);
		}

		public static char ToLowerInvariant(this char c)
		{
			return char.ToLowerInvariant(c);
		}
	}
}