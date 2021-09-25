namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double InverseLerp(this double t, double a, double b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.InverseLerp(a, b, t, IsClamped);
		}

		public static double Lerp(this double t, double a, double b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.Lerp(a, b, t, IsClamped);
		}

		public static double Remap(this double value, double fromA, double fromB, double toA, double toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.Remap(fromA, fromB, toA, toB, value, isClamped);
		}
	}
}