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

		public static bool IsEven(this long value)
		{
			return value % (long)Numeric.Base.Binary == Long.Zero;
		}

		public static bool IsOdd(this long value)
		{
			return value % (long)Numeric.Base.Binary != Long.Zero;
		}
	}
}