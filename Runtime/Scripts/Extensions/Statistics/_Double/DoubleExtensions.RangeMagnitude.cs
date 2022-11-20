namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the absolute difference between the largest and smallest value.
		/// </summary>
		public static double RangeMagnitude(this double value, double other)
		{
			return value < other ? other - value : value - other;
		}
	}
}