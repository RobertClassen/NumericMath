namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Round(this double value)
		{
			return Math.Round(value);
		}

		public static long RoundToLong(this double value)
		{
			return (long)Math.Round(value);
		}

		public static double RoundToMid(this double value)
		{
			return Math.Round(value) + Double.OneHalf;
		}
	}
}