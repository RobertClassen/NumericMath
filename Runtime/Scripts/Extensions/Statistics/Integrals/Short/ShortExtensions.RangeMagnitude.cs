namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the difference between the largest and smallest value.
		/// </summary>
		public static short RangeMagnitude(this short value, short other)
		{
			return (short)(value < other ? other - value : value - other);
		}
	}
}