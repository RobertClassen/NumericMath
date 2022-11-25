namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Lerp(this double t, double a, double b, bool clamp = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(clamp);
		}
	}
}