namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Pow(this long value, long exponent)
		{
			return (long)Math.Pow(value, exponent);
		}
	}
}