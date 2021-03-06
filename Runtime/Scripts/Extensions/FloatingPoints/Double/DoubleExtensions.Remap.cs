namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Remap(this double value, double fromA, double fromB, double toA, double toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return value.InverseLerp(fromA, fromB, isClamped).Lerp(toA, toB, isClamped);
		}
	}
}