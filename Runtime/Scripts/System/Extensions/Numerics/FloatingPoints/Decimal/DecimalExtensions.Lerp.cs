namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Lerp(this decimal t, decimal a, decimal b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.Lerp(a, b, t, isClamped);
		}
	}
}