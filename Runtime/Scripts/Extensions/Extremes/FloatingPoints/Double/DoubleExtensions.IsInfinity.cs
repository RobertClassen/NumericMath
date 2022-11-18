namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static bool IsInfinity(this double value)
		{
			return double.IsInfinity(value);
		}

		public static bool IsNaN(this double value)
		{
			return double.IsNaN(value);
		}

		public static bool IsNegativeInfinity(this double value)
		{
			return double.IsNegativeInfinity(value);
		}

		public static bool IsPositiveInfinity(this double value)
		{
			return double.IsPositiveInfinity(value);
		}
	}
}