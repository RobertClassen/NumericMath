namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static string ToInvariantString(this long value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}