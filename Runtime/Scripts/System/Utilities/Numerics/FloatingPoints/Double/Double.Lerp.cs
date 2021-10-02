namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Double
	{
		public static double Lerp(double a, double b, double t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}
	}
}