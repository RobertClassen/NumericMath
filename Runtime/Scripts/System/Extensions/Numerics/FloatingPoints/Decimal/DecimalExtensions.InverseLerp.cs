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
	}
}