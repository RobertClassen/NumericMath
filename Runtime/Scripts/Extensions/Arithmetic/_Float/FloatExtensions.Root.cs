namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static double Root(this float value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}
	}
}