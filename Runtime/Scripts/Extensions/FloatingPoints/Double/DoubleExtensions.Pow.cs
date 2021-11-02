namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Pow(this double value, double exponent)
		{
			return Math.Pow(value, exponent);
		}
	}
}