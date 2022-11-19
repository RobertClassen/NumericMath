namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static long Extreme(this long value)
		{
			return value < Long.Zero ? long.MinValue : long.MaxValue;
		}
	}
}