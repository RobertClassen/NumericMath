namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
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