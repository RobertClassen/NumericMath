namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static bool IsClamped01(this float value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Float.Zero, Float.One, isInclusive);
		}
	}
}