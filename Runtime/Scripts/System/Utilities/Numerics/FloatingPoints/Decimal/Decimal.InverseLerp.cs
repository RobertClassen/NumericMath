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
	}
}