namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static short Clamp(this short value, short min, short max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static short Clamp01(this short value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Short.Zero, Short.One) : value;
		}
	}
}