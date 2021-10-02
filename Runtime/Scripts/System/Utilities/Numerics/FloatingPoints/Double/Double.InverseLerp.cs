namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Double
	{
		public static double InverseLerp(double a, double b, double value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > double.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}
	}
}