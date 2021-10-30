namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Atan(this double value)
		{
			return Math.Atan(value);
		}

		public static double Atan2(this double y, double x)
		{
			return Math.Atan2(y, x);
		}

		public static double Tan(this double value)
		{
			return Math.Tan(value);
		}

		public static double Tanh(this double value)
		{
			return Math.Tanh(value);
		}
	}
}