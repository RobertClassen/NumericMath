namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal Remap(this decimal value, decimal fromA, decimal fromB, decimal toA, decimal toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return toA.Lerp(toB, value.InverseLerp(fromA, fromB, isClamped), isClamped);
		}
	}
}