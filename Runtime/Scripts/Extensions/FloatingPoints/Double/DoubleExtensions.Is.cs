namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static bool IsClamped(this double value, double min, double max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this double value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Double.Zero, Double.One, isInclusive);
		}

		public static bool IsInfinity(this double value)
		{
			return double.IsInfinity(value);
		}

		public static bool IsNaN(this double value)
		{
			return double.IsNaN(value);
		}

		public static bool IsNegativeInfinity(this double value)
		{
			return double.IsNegativeInfinity(value);
		}

		public static bool IsPositiveInfinity(this double value)
		{
			return double.IsPositiveInfinity(value);
		}
	}
}