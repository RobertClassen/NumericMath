namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Log(this double value)
		{
			return Math.Log(value);
		}

		public static double Log(this double value, double newBase)
		{
			return Math.Log(value, newBase);
		}

		public static double Log10(this double value)
		{
			return Math.Log10(value);
		}
	}
}