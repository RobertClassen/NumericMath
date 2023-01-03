namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static long RoundToLong(this double value, MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (long)Math.Round(value, mode);
		}
	}
}