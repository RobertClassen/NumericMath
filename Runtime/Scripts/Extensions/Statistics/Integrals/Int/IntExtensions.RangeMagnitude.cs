namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the difference between the largest and smallest value.
		/// </summary>
		public static int RangeMagnitude(this int value, int other)
		{
			return value < other ? other - value : value - other;
		}
	}
}