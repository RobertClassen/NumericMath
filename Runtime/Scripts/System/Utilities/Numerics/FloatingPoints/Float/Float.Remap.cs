namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Float
	{
		public static float Remap(float fromA, float fromB, float toA, float toB, float value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}
	}
}