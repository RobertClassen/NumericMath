namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Root(this double value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}
	}
}