namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static bool IsZero(this float value)
		{
			return value.IsApproximately(Float.Zero);
		}
	}
}