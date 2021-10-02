namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Float
	{
		public static float Lerp(float a, float b, float t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}
	}
}