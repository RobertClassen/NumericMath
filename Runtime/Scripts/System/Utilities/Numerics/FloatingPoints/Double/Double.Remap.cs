namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Double
	{
		public static double Remap(double fromA, double fromB, double toA, double toB, double value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}
	}
}