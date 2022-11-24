namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Clamp(this float value, float min, float max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static float Clamp01(this float value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Float.Zero, Float.One) : value;
		}

		public static float ClampMax(this float value, float max, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && max < value ? max : value;
		}

		public static float ClampMin(this float value, float min, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && value < min ? min : value;
		}
	}
}