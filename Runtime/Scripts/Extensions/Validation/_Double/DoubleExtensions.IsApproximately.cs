namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static bool IsApproximately(this double value, double other, double epsilon)
		{
			return (value - other).Abs() <= epsilon;
		}

		public static bool IsApproximately(this double value, double other)
		{
			return value.IsApproximately(other, value.Abs().Max(other.Abs()) * Double.Epsilon);
		}
	}
}