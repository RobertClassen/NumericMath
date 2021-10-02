namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Lerp(this double t, double a, double b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.Lerp(a, b, t, isClamped);
		}
	}
}