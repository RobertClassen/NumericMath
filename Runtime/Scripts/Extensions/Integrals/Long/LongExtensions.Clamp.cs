namespace NumericMath
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
	}
}