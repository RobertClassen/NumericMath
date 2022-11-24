namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static double Root(this short value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}
	}
}