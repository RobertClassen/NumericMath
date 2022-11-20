namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the difference between the largest and smallest value.
		/// </summary>
		public static long RangeMagnitude(this long value, long other)
		{
			return value < other ? other - value : value - other;
		}
	}
}