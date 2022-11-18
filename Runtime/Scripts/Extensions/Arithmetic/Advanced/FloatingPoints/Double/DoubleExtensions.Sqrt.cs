namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Sqrt(this double value)
		{
			return Math.Sqrt(value);
		}

		public static float SqrtF(this double value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}