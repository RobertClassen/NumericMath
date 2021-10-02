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
	}
}