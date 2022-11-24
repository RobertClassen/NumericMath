namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static double Root(this long value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}
	}
}