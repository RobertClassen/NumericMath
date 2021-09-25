namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Float
	{
		public static float InverseLerp(float a, float b, float value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > float.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}

		public static float Lerp(float a, float b, float t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}

		public static float Remap(float fromA, float fromB, float toA, float toB, float value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}
	}
}