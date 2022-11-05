namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Root(this long value, double root)
		{
			return (long)Math.Pow(value, Double.One / root);
		}
	}
}