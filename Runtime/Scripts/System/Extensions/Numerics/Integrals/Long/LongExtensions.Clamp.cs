namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static long Clamp(this long value, long min, long max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static long Clamp01(this long value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Long.Zero, Long.One) : value;
		}

		public static bool IsClamped(this long value, long min, long max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}
	}
}