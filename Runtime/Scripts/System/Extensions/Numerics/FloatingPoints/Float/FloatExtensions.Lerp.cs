namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Lerp(this float t, float a, float b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Lerp(a, b, t, isClamped);
		}
	}
}