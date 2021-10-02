namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Remap(this float value, float fromA, float fromB, float toA, float toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Remap(fromA, fromB, toA, toB, value, isClamped);
		}
	}
}