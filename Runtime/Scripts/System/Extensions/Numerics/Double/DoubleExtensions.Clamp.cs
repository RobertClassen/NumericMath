namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Clamp(this double value, double min, double max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static double Clamp01(this double value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Double.Zero, Double.One) : value;
		}

		public static bool IsClamped(this double value, double min, double max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this double value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Double.Zero, Double.One, isInclusive);
		}
	}
}