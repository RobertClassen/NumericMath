namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Remap(this double value, double fromA, double fromB, double toA, double toB, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			return value.InverseLerp(fromA, fromB, clamp).Lerp(toA, toB, clamp);
		}
	}
}