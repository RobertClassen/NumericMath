namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static bool IsClamped01(this int value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Int.Zero, Int.One, isInclusive);
		}
	}
}