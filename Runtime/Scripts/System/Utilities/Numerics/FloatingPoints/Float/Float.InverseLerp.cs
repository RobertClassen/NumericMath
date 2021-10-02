namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Float
	{
		public static float InverseLerp(float a, float b, float value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > float.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}
	}
}