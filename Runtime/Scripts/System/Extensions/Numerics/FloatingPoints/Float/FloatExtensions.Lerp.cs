namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float InverseLerp(this float t, float a, float b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.InverseLerp(a, b, t, isClamped);
		}

		public static float Lerp(this float t, float a, float b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Lerp(a, b, t, isClamped);
		}

		public static float Remap(this float value, float fromA, float fromB, float toA, float toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Remap(fromA, fromB, toA, toB, value, isClamped);
		}
	}
}