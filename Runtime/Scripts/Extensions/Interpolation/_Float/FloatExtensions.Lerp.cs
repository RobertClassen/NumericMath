namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Lerp(this float t, float a, float b, bool clamp = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(clamp);
		}
	}
}