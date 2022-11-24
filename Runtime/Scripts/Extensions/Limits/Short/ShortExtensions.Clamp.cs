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

		public static short ClampMax(this short value, short max, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && max < value ? max : value;
		}

		public static short ClampMin(this short value, short min, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && value < min ? min : value;
		}
	}
}