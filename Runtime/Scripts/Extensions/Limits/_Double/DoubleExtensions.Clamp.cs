namespace NumericMath
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

		public static double ClampMax(this double value, double max, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && max < value ? max : value;
		}

		public static double ClampMin(this double value, double min, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && value < min ? min : value;
		}
	}
}