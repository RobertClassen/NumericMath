namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static double Root(this int value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}
	}
}