namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Decimal
	{
		public static decimal Lerp(decimal a, decimal b, decimal t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}
	}
}