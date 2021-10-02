namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal InverseLerp(this decimal t, decimal a, decimal b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.InverseLerp(a, b, t, isClamped);
		}

		public static decimal Lerp(this decimal t, decimal a, decimal b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.Lerp(a, b, t, isClamped);
		}

		public static decimal Remap(this decimal value, decimal fromA, decimal fromB, decimal toA, decimal toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.Remap(fromA, fromB, toA, toB, value, isClamped);
		}
	}
}