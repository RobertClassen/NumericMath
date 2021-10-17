namespace WellDefinedNumerics
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
			return toA.Lerp(toB, value.InverseLerp(fromA, fromB, isClamped), isClamped);
		}
	}
}