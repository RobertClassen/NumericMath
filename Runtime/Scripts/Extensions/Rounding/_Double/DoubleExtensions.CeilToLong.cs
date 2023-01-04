namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static long CeilToLong(this double value, double stepSize = Double.One)
		{
			return (long)value.Ceil(stepSize);
		}
	}
}