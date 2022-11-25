namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Remap(this float value, float fromA, float fromB, float toA, float toB, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			return value.InverseLerp(fromA, fromB, clamp).Lerp(toA, toB, clamp);
		}
	}
}