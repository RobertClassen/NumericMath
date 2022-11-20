namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the difference between the largest and smallest value.
		/// </summary>
		public static float RangeMagnitude(this float value, float other)
		{
			return value < other ? other - value : value - other;
		}
	}
}