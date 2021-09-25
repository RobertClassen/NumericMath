namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Decimal
	{
		public static decimal InverseLerp(decimal a, decimal b, decimal value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > (decimal)double.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}

		public static decimal Lerp(decimal a, decimal b, decimal t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}

		public static decimal Remap(decimal fromA, decimal fromB, decimal toA, decimal toB, decimal value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}
	}
}