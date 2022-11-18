namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static bool IsClamped(this long value, long min, long max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this long value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Long.Zero, Long.One, isInclusive);
		}
	}
}