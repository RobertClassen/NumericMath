namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Truncate(this double value)
		{
			return Math.Truncate(value);
		}
	}
}