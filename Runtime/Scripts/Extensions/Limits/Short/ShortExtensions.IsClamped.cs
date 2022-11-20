namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static bool IsClamped(this short value, short min, short max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this short value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Short.Zero, Short.One, isInclusive);
		}
	}
}