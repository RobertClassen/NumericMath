namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float InverseLerp(this float value, float a, float b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > float.Epsilon ? ((value - a) / (b - a)).Clamp01(isClamped) : Float.Zero;
		}
	}
}