namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Clamp(this decimal value, decimal min, decimal max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static decimal Clamp01(this decimal value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Decimal.Zero, Decimal.One) : value;
		}

		public static bool IsClamped(this decimal value, decimal min, decimal max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this decimal value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Decimal.Zero, Decimal.One, isInclusive);
		}
	}
}