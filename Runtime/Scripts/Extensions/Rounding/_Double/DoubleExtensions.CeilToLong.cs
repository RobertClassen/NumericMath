namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static long CeilToLong(this double value)
		{
			return (long)value.Ceil();
		}
	}
}