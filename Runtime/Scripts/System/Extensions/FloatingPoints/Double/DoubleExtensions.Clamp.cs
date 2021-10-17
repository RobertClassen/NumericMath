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
	}
}