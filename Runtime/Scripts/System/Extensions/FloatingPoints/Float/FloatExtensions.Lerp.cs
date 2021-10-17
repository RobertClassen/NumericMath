namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Lerp(this float a, float b, float t, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}
	}
}