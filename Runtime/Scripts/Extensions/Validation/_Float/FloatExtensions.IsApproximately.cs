namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static bool IsApproximately(this float value, float other, float epsilon)
		{
			return (value - other).Abs() <= epsilon;
		}

		public static bool IsApproximately(this float value, float other)
		{
			return value.IsApproximately(other, value.Abs().Max(other.Abs()) * Float.Epsilon);
		}
	}
}