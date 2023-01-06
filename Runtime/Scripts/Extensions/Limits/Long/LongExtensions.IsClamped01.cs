namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static bool IsClamped01(this long value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Long.Zero, Long.One, isInclusive);
		}
	}
}