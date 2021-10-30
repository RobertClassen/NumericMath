namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal InverseLerp(this decimal value, decimal a, decimal b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > (decimal)double.Epsilon ? ((value - a) / (b - a)).Clamp01(isClamped) : Decimal.Zero;
		}
	}
}