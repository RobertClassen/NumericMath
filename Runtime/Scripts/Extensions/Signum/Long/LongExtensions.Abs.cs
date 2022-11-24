namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the absolute value of the number.
		/// </summary>
		public static long Abs(this long value)
		{
			return Math.Abs(value);
		}
	}
}