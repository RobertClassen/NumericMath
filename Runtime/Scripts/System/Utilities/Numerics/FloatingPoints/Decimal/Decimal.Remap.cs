namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Decimal
	{
		public static decimal Remap(decimal fromA, decimal fromB, decimal toA, decimal toB, decimal value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}
	}
}