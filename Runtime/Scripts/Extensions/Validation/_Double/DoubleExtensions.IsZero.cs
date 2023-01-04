namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static bool IsZero(this double value)
		{
			return value.IsApproximately(Double.Zero);
		}
	}
}