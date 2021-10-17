namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double InverseLerp(this double value, double a, double b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > double.Epsilon ? ((value - a) / (b - a)).Clamp01(isClamped) : Double.Zero;
		}
	}
}